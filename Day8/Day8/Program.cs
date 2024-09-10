namespace Day8
{
    public delegate void tempDel(int t);
    public class Heater
    {
        private int _heaterTemp;
        public int heaterTemp
        {
            get { return _heaterTemp; }
            set { _heaterTemp = value; }
        }
        public void HeaterHandler(int t)
        {
            if (t < _heaterTemp)
            {
                Console.WriteLine("Heater ON");
            }
            else
            {
                Console.WriteLine("Heater OFF");
            }
        }
    }
    public class cooler
    {
        private int _coolertemp;
        public int coolertemp
        {
            get { return _coolertemp; }
            set { _coolertemp = value; }
        }
        public void CoolerHandler(int t)
        {
            if (t > _coolertemp)
            {
                Console.WriteLine("Cooler ON");
            }
            else
            {
                Console.WriteLine("Cooler OFF");
            }
        }
    }
    public class Thermostate
    {
        public event tempDel OnTemperatureChange;
        private int _temp;
        public int currenttemp
        {

            get { return _temp; }
            set
            {
                if (_temp != value)
                {
                    _temp = value;
                    if(OnTemperatureChange != null)
                    {
                        OnTemperatureChange(_temp);
                    }
                }
            }    
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Thermostate thermostate = new Thermostate();
            cooler cooler = new cooler();
            Heater heater = new Heater();
            cooler.coolertemp = 80;
            heater.heaterTemp = 20;
            thermostate.OnTemperatureChange += cooler.CoolerHandler;
            thermostate.OnTemperatureChange += heater.HeaterHandler;
            thermostate.currenttemp = 120;
            Console.WriteLine("----------------------------------");
            thermostate.currenttemp = 10;
            
            ;


            Console.WriteLine("Hello, World!");
        }
    }
}
