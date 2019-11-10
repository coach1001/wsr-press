using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections.Concurrent;
using RJCP.IO.Ports;

namespace wsrPress
{
    
    public class FixedSizedQueue<T> 
    {
        public ConcurrentQueue<T> q = new ConcurrentQueue<T>();        
        public int Limit { get; set; }

        public void Enqueue (T obj){
            q.Enqueue(obj);
            lock (this)
            {
                T overflow;
                while(q.Count > Limit && q.TryDequeue(out overflow) );
            }
        }    
    }

    public class pressController
    {
                      
        public UInt32[] inputChannel = new UInt32[8];
        public UInt32[] outputChannel = new UInt32[7];
        Timer receiveTimer;

        public FixedSizedQueue<double> lc0 = new FixedSizedQueue<double>();
        public FixedSizedQueue<double> pt0 = new FixedSizedQueue<double>();

        public SerialPortStream pressSerialPort;
                        
        public pressController(String port,int baudrate)
        {

            pressSerialPort = new SerialPortStream(port, baudrate);
            pressSerialPort.Open();
            lc0.Limit = 8;
            pt0.Limit = 24;
            receiveTimer = new Timer();
            receiveTimer.Tick += receiveTimer_Tick;
            receiveTimer.Interval = 5;
            receiveTimer.Enabled = true;
        }
        
        private void ErrorReceived(object sender, SerialErrorReceivedEventArgs e)
        {
            Console.WriteLine(e.ToString());
            
        }

        void receiveTimer_Tick(object sender, EventArgs e)
        {
            receiveTimer.Stop();
            readDevice();
        }

        
        private void DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPortStream sp = (SerialPortStream)sender;
            double temp=0;
            if (sp.BytesToRead == 26)
            {
                inputChannel[0] = Convert.ToUInt32(sp.ReadByte()) << 24;
                inputChannel[0] = inputChannel[0] | (Convert.ToUInt32(sp.ReadByte()) << 16);
                inputChannel[0] = inputChannel[0] | (Convert.ToUInt32(sp.ReadByte()) << 8);
                inputChannel[0] = inputChannel[0] | Convert.ToUInt32(sp.ReadByte());                
                temp = Convert.ToDouble(inputChannel[0]);                
                lc0.Enqueue(temp);                                    
               
                inputChannel[0] = Convert.ToUInt32(lc0.q.Average());
                
                inputChannel[1] = Convert.ToUInt32(sp.ReadByte()) << 24;
                inputChannel[1] = inputChannel[1] | (Convert.ToUInt32(sp.ReadByte()) << 16);
                inputChannel[1] = inputChannel[1] | (Convert.ToUInt32(sp.ReadByte()) << 8);
                inputChannel[1] = inputChannel[1] | Convert.ToUInt32(sp.ReadByte());
                
                inputChannel[2] = Convert.ToUInt32(sp.ReadByte()) << 24;
                inputChannel[2] = inputChannel[2] | (Convert.ToUInt32(sp.ReadByte()) << 16);
                inputChannel[2] = inputChannel[2] | (Convert.ToUInt32(sp.ReadByte()) << 8);
                inputChannel[2] = inputChannel[2] | Convert.ToUInt32(sp.ReadByte());
                temp = Convert.ToDouble(inputChannel[2]);                         
                pt0.Enqueue(temp);                    
                
                inputChannel[2] = Convert.ToUInt32(pt0.q.Average());                
                inputChannel[3] = Convert.ToUInt32(sp.ReadByte()) << 24;
                inputChannel[3] = inputChannel[3] | (Convert.ToUInt32(sp.ReadByte()) << 16);
                inputChannel[3] = inputChannel[3] | (Convert.ToUInt32(sp.ReadByte()) << 8);
                inputChannel[3] = inputChannel[3] | Convert.ToUInt32(sp.ReadByte());
                
                inputChannel[4] = Convert.ToUInt32(sp.ReadByte()) << 24;
                inputChannel[4] = inputChannel[4] | (Convert.ToUInt32(sp.ReadByte()) << 16);
                inputChannel[4] = inputChannel[4] | (Convert.ToUInt32(sp.ReadByte()) << 8);
                inputChannel[4] = inputChannel[4] | Convert.ToUInt32(sp.ReadByte());
                
                inputChannel[5] = Convert.ToUInt32(sp.ReadByte()) << 24;
                inputChannel[5] = inputChannel[5] | (Convert.ToUInt32(sp.ReadByte()) << 16);
                inputChannel[5] = inputChannel[5] | (Convert.ToUInt32(sp.ReadByte()) << 8);
                inputChannel[5] = inputChannel[5] | Convert.ToUInt32(sp.ReadByte());

                inputChannel[6] = Convert.ToUInt32(sp.ReadByte());
                inputChannel[7] = Convert.ToUInt32(sp.ReadByte());

                //System.Threading.Thread.Sleep(10);
                writeReadDevice();
            }
        }

        private void readDevice()
        {            
            double temp = 0;

            inputChannel[0] = Convert.ToUInt32(pressSerialPort.ReadByte()) << 24;
            inputChannel[0] = inputChannel[0] | (Convert.ToUInt32(pressSerialPort.ReadByte()) << 16);
            inputChannel[0] = inputChannel[0] | (Convert.ToUInt32(pressSerialPort.ReadByte()) << 8);
            inputChannel[0] = inputChannel[0] | Convert.ToUInt32(pressSerialPort.ReadByte());
            temp = Convert.ToDouble(inputChannel[0]);
            lc0.Enqueue(temp);

            inputChannel[0] = Convert.ToUInt32(lc0.q.Average());

            inputChannel[1] = Convert.ToUInt32(pressSerialPort.ReadByte()) << 24;
            inputChannel[1] = inputChannel[1] | (Convert.ToUInt32(pressSerialPort.ReadByte()) << 16);
            inputChannel[1] = inputChannel[1] | (Convert.ToUInt32(pressSerialPort.ReadByte()) << 8);
            inputChannel[1] = inputChannel[1] | Convert.ToUInt32(pressSerialPort.ReadByte());

            inputChannel[2] = Convert.ToUInt32(pressSerialPort.ReadByte()) << 24;
            inputChannel[2] = inputChannel[2] | (Convert.ToUInt32(pressSerialPort.ReadByte()) << 16);
            inputChannel[2] = inputChannel[2] | (Convert.ToUInt32(pressSerialPort.ReadByte()) << 8);
            inputChannel[2] = inputChannel[2] | Convert.ToUInt32(pressSerialPort.ReadByte());
            temp = Convert.ToDouble(inputChannel[2]);
            pt0.Enqueue(temp);

            inputChannel[2] = Convert.ToUInt32(pt0.q.Average());
            inputChannel[3] = Convert.ToUInt32(pressSerialPort.ReadByte()) << 24;
            inputChannel[3] = inputChannel[3] | (Convert.ToUInt32(pressSerialPort.ReadByte()) << 16);
            inputChannel[3] = inputChannel[3] | (Convert.ToUInt32(pressSerialPort.ReadByte()) << 8);
            inputChannel[3] = inputChannel[3] | Convert.ToUInt32(pressSerialPort.ReadByte());

            inputChannel[4] = Convert.ToUInt32(pressSerialPort.ReadByte()) << 24;
            inputChannel[4] = inputChannel[4] | (Convert.ToUInt32(pressSerialPort.ReadByte()) << 16);
            inputChannel[4] = inputChannel[4] | (Convert.ToUInt32(pressSerialPort.ReadByte()) << 8);
            inputChannel[4] = inputChannel[4] | Convert.ToUInt32(pressSerialPort.ReadByte());

            inputChannel[5] = Convert.ToUInt32(pressSerialPort.ReadByte()) << 24;
            inputChannel[5] = inputChannel[5] | (Convert.ToUInt32(pressSerialPort.ReadByte()) << 16);
            inputChannel[5] = inputChannel[5] | (Convert.ToUInt32(pressSerialPort.ReadByte()) << 8);
            inputChannel[5] = inputChannel[5] | Convert.ToUInt32(pressSerialPort.ReadByte());

            inputChannel[6] = Convert.ToUInt32(pressSerialPort.ReadByte());
            inputChannel[7] = Convert.ToUInt32(pressSerialPort.ReadByte());
            
            writeReadDevice();
        }
        
        public void writeReadDevice()
        {            
            Byte[] output = new Byte[13];
            //Console.WriteLine("Sending C....");
            output[0] = 0x63;
            
            output[1] = Convert.ToByte((outputChannel[0] & 0x0000FF00) >> 8);//PWM-0 Channel 0
            output[2] = Convert.ToByte(outputChannel[0] & 0x000000FF);

            output[3] = Convert.ToByte((outputChannel[1] & 0x0000FF00) >> 8);//PWM-1 Channel 1
            output[4] = Convert.ToByte(outputChannel[1] & 0x000000FF);

            output[5] = Convert.ToByte(outputChannel[2]);//VALVE-0 Channel 2
            output[6] = Convert.ToByte(outputChannel[3]);//VALVE-1 Channel 3
            output[7] = Convert.ToByte(outputChannel[4]);//RELAY-0 Channel 4
            output[8] = Convert.ToByte(outputChannel[5]);//SSR-0 Channel 5
            output[9] = Convert.ToByte(outputChannel[6]);//PROXY RESET COUNT Channel 6
            output[10] = 0;
	        output[11] = 0;
            output[12] = 0;

            pressSerialPort.Write(output,0,13);
            receiveTimer.Start();
            
            //System.Threading.Thread.Sleep(10);
            //writeReadDevice();            

        }
        public bool getDevice()
        {       
            
            Byte[] input = new Byte[64];
            Byte[] output = new Byte[64];
            
            output[0] = 0x81;
            bool success=false;
            //success = writeSingleReportToDevice(output);

            if (success)
            {
                //success = readSingleReportFromDevice(ref input);

                if (!success) return false;
               
                inputChannel[0] = Convert.ToUInt32(input[0]) << 16;  
                inputChannel[0] = inputChannel[0]|(Convert.ToUInt32(input[1]) << 8);
                inputChannel[0] = inputChannel[0]|Convert.ToUInt32(input[2]);

                if (inputChannel[0] != 1234567)
                {
                    Console.WriteLine("HX711 Error : " + inputChannel[0].ToString());
                }

                inputChannel[1] = Convert.ToUInt32(input[3]) << 16;  
                inputChannel[1] = inputChannel[1] | (Convert.ToUInt32(input[4]) << 8);
                inputChannel[1] = inputChannel[1] | Convert.ToUInt32(input[5]);
                
                inputChannel[2] = Convert.ToUInt32(input[6]) << 8;                
                inputChannel[2] = inputChannel[2] | Convert.ToUInt32(input[7]);

                if (inputChannel[2] != 12345)
                {
                    Console.WriteLine("ADC0 Error : " + inputChannel[2].ToString());

                }

                inputChannel[3] = Convert.ToUInt32(input[8]) << 8;
                inputChannel[3] = inputChannel[3] | Convert.ToUInt32(input[9]);

                inputChannel[4] = Convert.ToUInt32(input[10]) << 8;
                inputChannel[4] = inputChannel[4] | Convert.ToUInt32(input[11]);

                inputChannel[5] = Convert.ToUInt32(input[12]) << 8;
                inputChannel[5] = inputChannel[5] | Convert.ToUInt32(input[13]);    

                inputChannel[6] = Convert.ToUInt32(input[14]);
                inputChannel[7] = Convert.ToUInt32(input[15]);
                
                //rollingForce = rollingForce + ((inputChannel[0] - rollingForce)/divider);
                success = true;
            }
            return success;
        }
        public void setOutputChannel(int channel,UInt32 Value)
        {
            outputChannel[channel] = Value;
        }
        public UInt32 returnInputChannel(int channel)
        {
            //if (channel == 0) {return Convert.ToUInt32(rollingForce);}
            return inputChannel[channel];
        }    
        public bool setDevice()
        {
            Byte[] input = new Byte[64];
            Byte[] output = new Byte[64];

            output[0] = 0x80;
            output[1] = Convert.ToByte((outputChannel[0] & 0x0000FF00) >> 8);//PWM-0 Channel 0
            output[2] = Convert.ToByte(outputChannel[0] & 0x000000FF);

            output[3] = Convert.ToByte((outputChannel[1] & 0x0000FF00) >> 8);//PWM-1 Channel 1
            output[4] = Convert.ToByte(outputChannel[1] & 0x000000FF);            
            output[5] = Convert.ToByte(outputChannel[2]);//VALVE-0 Channel 2
            output[6] = Convert.ToByte(outputChannel[3]);//VALVE-1 Channel 3
            output[7] = Convert.ToByte(outputChannel[4]);//RELAY-0 Channel 4
            output[8] = Convert.ToByte(outputChannel[5]);//SSR-0 Channel 5
            output[9] = Convert.ToByte(outputChannel[6]);//PROXY RESET COUNT Channel 6
            bool success=false;
            //success = writeSingleReportToDevice(output);
            
            if (success)
                return true;
            else
                return false;
        }
        
    }
}