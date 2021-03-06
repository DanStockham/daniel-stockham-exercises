﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechElevator.Classes
{
    public class Company
    {
        private string name;
        private int numberOfEmployees;
        private decimal revenue;
        private decimal expenses;

        public Company(string startingName)
        {
            name = startingName;
        }

        public string Name
        {
            get
            {
                return name;
            }
        }

        public int NumberOfEmployees
        {
            get
            {
                return numberOfEmployees;
            }
            set
            {
                numberOfEmployees = value;
            }
        }

        public decimal Revenue
        {
            get
            {
                return revenue;
            }
            set
            {
                revenue = value;
            }
        }

        public decimal Expenses
        {
            get
            {
                return expenses;
            }
            set
            {
                expenses = value;
            }
        }

        public string GetCompanySize()
        {
            if(numberOfEmployees <= 49)
            {
                return "small";
            }
            else if(numberOfEmployees >= 50 && numberOfEmployees <= 250)
            {
                return "medium";
            }
            else
            {
                return "large";
            }
        }

        public decimal GetProfit()
        {
            return Revenue - Expenses;
        }
    }
}
