using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfCalculatrice
{

    /// <summary>
    /// Simple Addition class
    /// </summary>
    public class Addition
    {
        private double Val1;
        private double Val2;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="V1">First value double</param>
        /// <param name="V2">Seconde value double</param>
        public Addition(double V1, double V2)
        {
            this.Val1 = V1;
            this.Val2 = V2;
        }

        /// <summary>
        /// Add the two setted values 
        /// </summary>
        /// <returns>result of sum</returns>
        public double Additionne()
        {
            return Val1 + Val2;
        }

        /// <summary>
        /// Get the first value
        /// </summary>
        /// <returns>Value</returns>
        public double getVal1()
        {
            return this.Val1;
        }

        /// <summary>
        /// Get the seconde value
        /// </summary>
        /// <returns>Value</returns>
        public double getVal2()
        {
            return this.Val2;
        }

        /// <summary>
        /// Set the first value
        /// </summary>
        /// <param name="val">value</param>
        public void setVal1 (double val)
        {
            this.Val1 = val;
        }

        /// <summary>
        /// Set the seconde value
        /// </summary>
        /// <param name="val">value</param>
        public void setVal2(double val)
        {
            this.Val2 = val;
        }

        public string Affiche()
        {
            return "The sum of " + Val1.ToString() 
                + " and " + Val2.ToString() 
                + " is " + Additionne().ToString();
        }
    }
}
