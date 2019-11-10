using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace wsrPress
{
    public class testParams
    {
        public string sampleNumber;
        public DateTime dateTime;
        public string testSelected;
        public int testypeId;
        public double Adjust;
        public string pressType;
        public bool testDirection;

        public double[] forceCoff = new double[4]; //A,B,C,D 
        public double[] dispCoff = new double[4];

        public double P=0;
        public double I=0;
        public double D=0;
        public double C = 0;

        public string xAxisUnit;
        public string yAxisUnit;

        public Stopwatch testStopwatch = new Stopwatch();

        public double[] forceReadings = new double[5]; //raw,zero,zerod,kN,maxkN
        public double[] dispReadings = new double[5];//raw,zero,zerod,mm,mm@maxkN
               
        public double pidSetPoint=0;
        public double setPointTimeMultiplier=1;
        public double pidCurrPoint=0;
        public double pidError=0;
        public double pidPreError=0;
        public double pidOutput=0;
        public double pidPaceError=0;
        public double startForce=0.05f;
        public double pidIntegral = 0;
        public double pidProportional = 0;
        public double pidDerivative = 0;

        public string rateType;
        public string rateUnit;
        public double rateValue;
        public double userRate;
        public double userArea;

        public int forceChannel;
        public int dispChannel;
        
        public int directionChannel0;
        public int directionChannel1;

        public string endCondition0;
        public string endCondition1;
        public double endConditionValue0;
        public double endConditionValue1;

        public int[] directionUpValues = new int[2];
        public int[] directionDownValues = new int[2];

        public int[] motorChannel = new int[5];//channel,idle,approach,manual,max
        public int[] limitChannel = new int[4];//channel,raw,min,max
        public int rushSpeed = 0;

        public double sampleRate;
        public string sampleUnit="";

        public string YAxisTitle = "";
        public string XAxisTitle = "";
        public string YSeriesTitle = "";
        public string GraphTitle = "";

        public int XAxisTimeWindow = 720;
        public int XAxisMinorTick = 720 / 100;
        public int XAxisMajorTick = 720 / 10;
        public double prevTime = 0;

        public double potMin = 0;
        public double potMax = 0;
        public double potRange = 0;
        public double potRangeMin = 0;
        public double potRangeMax = 0;

        public UInt32 pid_motor()
        {
            double Dt;
            double now = testStopwatch.Elapsed.TotalMilliseconds / 1000.0f;
            
            double P_, I_, D_;

            Dt = (now - prevTime);
            prevTime = now;

            if (rateUnit == "kN/min" || rateUnit == "mm/min")
            {
                //Console.WriteLine("Got Here");
                pidSetPoint = setPointTimeMultiplier * now;       
            }
            else if (rateUnit == "kN")
            {
                pidSetPoint = rateValue;
            }

            if (rateType == "DISPLACEMENT") { pidCurrPoint = dispReadings[4]; }
            else if (rateType == "FORCE") { pidCurrPoint = forceReadings[4]; }

            pidError = pidSetPoint - pidCurrPoint;
            
            pidPaceError = ((-1 * (pidError / pidSetPoint)) * 100);
            pidIntegral = pidIntegral + (pidError * Dt);
            pidDerivative = (pidError - pidPreError) / Dt;
            
            P_ = (P * pidError); // was 1000
            I_ = (I * pidIntegral);//Was 0.005 
            D_ = (D * pidDerivative);//was 10000

            pidOutput = Convert.ToUInt32(rushSpeed) + P_ + I_ + D_;

            if (pidOutput > motorChannel[4]) pidOutput = motorChannel[4];

            if (pidOutput < motorChannel[1]) pidOutput = motorChannel[1];            
            
            pidPreError = pidError;

            Console.WriteLine(" Time :"+now.ToString("000000.00") +
                " CP:" + pidCurrPoint.ToString("00000.00") +
                " SP:" + pidSetPoint.ToString("00000.00")+
            " MO:" + pidOutput.ToString("00000") + " RV:"+rateValue.ToString("0000.00")+ " Error:"+pidError.ToString("00000.00")
            + " Dt: "+ Dt.ToString("000.00")
            );

            
             try{return Convert.ToUInt32(pidOutput);}catch{return 0;}
        }
        public UInt32 pid2_motor()
        {
            double Dt;
            double now = testStopwatch.Elapsed.TotalMilliseconds / 1000.0f;
            int Sign1=0;
            Random ran = new Random(8213);

            Dt = (now - prevTime);
            prevTime = now;

            if (rateUnit == "kN/min" || rateUnit == "mm/min")
            {
                
                pidSetPoint = setPointTimeMultiplier * now;
            }
            else if (rateUnit == "kN")
            {
                pidSetPoint = rateValue;
            }

            if (rateType == "DISPLACEMENT") { pidCurrPoint = dispReadings[3]; }
            else if (rateType == "FORCE") { pidCurrPoint = forceReadings[3]; }

            pidError = pidSetPoint - pidCurrPoint;

            pidPaceError = -100 * (pidError / (pidSetPoint + 0.00001) );

            if (pidPaceError > 90) pidPaceError = 90;
            if (pidPaceError < -90) pidPaceError = -90;            

            if (pidError > 0) Sign1 = 1;
            if (pidError < 0) Sign1 = -1;

            Adjust = Adjust - I*(pidPaceError+(Sign1*D)-pidError);
            //Adjust = 0;

            pidOutput = (motorChannel[1] + Adjust) * ((P - pidPaceError) / (P + pidPaceError)) + ran.Next(-1, 1);


            if (rateType == "DISPLACEMENT")
                pidOutput = pidOutput + (C * pidSetPoint);
            else if (rateType == "FORCE")
                pidOutput = pidOutput + (C * pidSetPoint);

            if (pidOutput > motorChannel[4]) pidOutput = motorChannel[4];

            if (pidOutput < motorChannel[1]) pidOutput = motorChannel[1];


            Console.WriteLine(//" Time :" + now.ToString("000000.00") +
                //" P :" + P.ToString() + " I :" + I.ToString() + " D :" + D.ToString() +
                " CurrPoint:" + pidCurrPoint.ToString("##0.00") +
                " SetPoint:" + pidSetPoint.ToString("##0.00") +
                " Adjust:" + Adjust.ToString("####") +
            " MotorOut:" + pidOutput.ToString("######") + /*" RV:" + rateValue.ToString("0000.00")*/ 
            " Error:" + pidError.ToString("#####.0")
            //+ " Dt: " + Dt.ToString("000.00")
            );


            try { return Convert.ToUInt32(pidOutput); }
            catch { return 0; }
        }
    }
}
