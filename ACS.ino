#define TRIGGER 5
#define ECHO 2
unsigned long per2;
unsigned long permil2;
unsigned long t=0;
unsigned long bt=0;
int count2;
int duty2;
int mode=20;
int duty2count;
unsigned long per;
unsigned long ultraper;
unsigned long permil;
int count;
int duty;
int dutycount;
int lc;
bool e;
void setup() {
  // put your setup code here, to run once:
  pinMode(4,OUTPUT);
  pinMode(3,OUTPUT);
  pinMode(TRIGGER,OUTPUT);
  pinMode(ECHO,INPUT);
  attachInterrupt(0,myISR,CHANGE);
  Serial.begin(9600);
}

void loop() {

    char mod = Serial.read();
    if(mod=='e') mode=10;
    else if(mod=='d') mode=20;
    else if(mod=='z') delay(10000000);
  
  // put your main code here, to run repeatedly:
  unsigned long ultracur = millis();
  unsigned long cur2 = micros();
  unsigned long curmil2 = millis();
  unsigned long cur = micros();
  unsigned long curmil = millis();

  
  if(e){
  if(cur-per>=100)
  {
    per = cur;
    count++;
    if(count==100)
    {
      digitalWrite(4,1);
      count=0;
    }
    if(count==duty)
    {
      digitalWrite(4,0);
    }
  }
  if(curmil-permil>=3)
  {
    permil=curmil;
    dutycount++;
    lc++;
    if(dutycount<=72) duty++;
    else if(dutycount<=144) duty--;
    else dutycount=0;

    if(lc==1000) 
    {
      lc=0;
      Serial.print("a");
    }
  }

}

else{ //servo
  digitalWrite(4,0);
  if(cur2-per2>=32)
  {
    per2=cur2;
    count2++;
    if(count2==625)
    {
      digitalWrite(3,1);
      count2=0;
    }
    if(count2==duty2)
    {
      digitalWrite(3,0);
    }
  }

  if(curmil2-permil2>mode)
  {
    permil2=curmil2;
    duty2count++;
    if(duty2count<72) duty2++;
    else if(duty2count<144) duty2--;
    else duty2count=0;
  }
}

  if(ultracur-ultraper>1000)
  {
    digitalWrite(TRIGGER,1);
    delayMicroseconds(10);
    digitalWrite(TRIGGER,0);
  }
}

void myISR()
{
  if(digitalRead(ECHO)){
   t = micros();
  }
  else{
    bt = micros();
    if(bt-t<1000) e=true;
    else e=false;
  }
}
