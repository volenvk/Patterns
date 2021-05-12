namespace DesignPatterns.Bridge
{
    using System;
    using System.Linq;

    public abstract class BaseGadget
    {
        private BaseAdapter _adapter;
        private string _energy;

        public abstract void ShowCharge();
        
        public void SetAdapter(BaseAdapter adapter)
        {
            _adapter = adapter;
        }

        public void OnCharge()
        {
            _energy = _adapter?.GetEnergy();
        }

        /// <summary>
        /// Power, watt
        /// </summary>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        protected int GetEnergy()
        {
            if (string.IsNullOrEmpty(_energy))
                throw new ArgumentNullException(nameof(_energy));
            
            var array = _energy.Split(' ');
            var amperage = array.First(e => e.Contains("A"));
            amperage = amperage.Replace("A", "");
            var voltage = array.First(e => e.Contains("V"));
            voltage = voltage.Replace("V", "");
            var power = int.Parse(amperage) * int.Parse(voltage);
            
            return power;
        }
    }
}