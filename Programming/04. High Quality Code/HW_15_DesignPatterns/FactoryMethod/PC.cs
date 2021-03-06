﻿namespace FactoryMethod
{
    using System;

    public class PC : IProduct
    {
        private string name;

        public PC(string name)
        {
            this.Name = name;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("PC name can not be null!");
                }

                this.name = value;
            }
        }

        public string Sell()
        {
            return this.name + " has been sold.";
        }

        public string Buy()
        {
            return this.name + " has been bought.";
        }
    }
}