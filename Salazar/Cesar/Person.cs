﻿using System;

namespace Cesar
{
    public class Person
    {

        private string _name; 
        private double _savemoney;
        public string Name { get; set; }
        public double SaveMoney { 
            get { 
                return _savemoney; 
            } 
        }
        public Person(string name, double savemoney) { 
            Name = name;
            _savemoney = savemoney; 
        }

        public void Save(double save) {
            _savemoney += save; 
        }

        public void Spend(double save) {
            _savemoney -= save; 
        }
        public void ChangeName(string name) {
           Name = name; 
        }

    }
}
