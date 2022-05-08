using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NationalInstruments;
using NationalInstruments.NetworkVariable;
using NationalInstruments.NetworkVariable.WindowsForms;


namespace DataLoggingSystem
{
    class OPC
    {
        //OPC connection
        private NetworkVariableReader<double> _readTemp;
        private NetworkVariableReader<double> _readPower;

        private const string LoactionTemp = @"\\localhost\SCADA\Sensor";
        private const string LoactionPower = @"\\localhost\SCADA\Sensor";


        NetworkVariableData<double> opcData = null;

        public void ConnectOPC()
        {
            _readTemp = new NetworkVariableReader<double>(LoactionTemp);
            _readPower = new NetworkVariableReader<double>(LoactionPower);
            _readTemp.Connect();
            _readPower.Connect();
        }

        public double GetDataTemp()
        {
           
           opcData = _readTemp.ReadData();
            return opcData.GetValue();
        }

        public double GetDataPower()
        {

            opcData = _readPower.ReadData();
            double value = opcData.GetValue() * opcData.GetValue();
            return value;
        }
    }
}
