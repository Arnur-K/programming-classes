using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_Classes
{
    class Car
    {
        private string _brand = "";
        private int _tankCapacity;
        private double _currentFuelLevel;
        private int _consumption;
        private double _totalKm;
        private double _tripKm;

        public Car(string brand, int tankCapacity, int consumption)
        {
            // TODO check if the values are correct and throw argument
            _brand = brand;
            _tankCapacity = tankCapacity;
            _consumption = consumption;
        }

        public string Brand => _brand;
        public int TankCapacity => _tankCapacity;
        public int CurrentFuelLevel => (int)_currentFuelLevel;
        public int Consumption => _consumption;
        public int TotalKm => (int)_totalKm;
        public int TripKm => (int)_tripKm;
        public void ResetTripKms() => _tripKm = 0;

        public void Tank(int amount)
        {
            if (_currentFuelLevel + amount <= _tankCapacity)
                _currentFuelLevel += amount;
            else
                _currentFuelLevel += _tankCapacity;
        }

        public void Drive(int kms)
        {
            var fuelNeedded = kms * _consumption / 100.0;
            if (_currentFuelLevel >= fuelNeedded) 
            {
                _totalKm += kms;
                _tripKm += kms;
                _currentFuelLevel -= fuelNeedded;
            }
            else 
            { 
                var howFarIsPossible = 100.0 * _currentFuelLevel * _consumption;
                _totalKm += howFarIsPossible;
                _tripKm += howFarIsPossible;
                _currentFuelLevel = 0;
            }
        }
    }
}