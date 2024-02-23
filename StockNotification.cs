//stocknotification.cs

using System;
using System.Collections.Generic;
using System.Text;

namespace Stock
{
    public class StockNotification : EventArgs
    {
        public string StockName { get; set; }
        public int CurrentValue { get; set; }
        public int NumChanges { get; set; }

        /// <summary>
        /// Stock notification attributes that are set and changed
        /// </summary>
        /// <param name="stockName">Name of stock</param>
        /// <param name="currentValue">Current vallue of the stock</param>
        /// <param name="numChanges">Number of changes the stock goes through</param>

        public StockNotification(string stockName, int currentValue, int numChanges)
        {
            // !NOTE!: Fill in below of what the notification will do using the comments above
            this.StockName = stockName;
            this.CurrentValue = currentValue;
            this.NumChanges = numChanges;
        }
    }
}

/*Extras:
string titles = "Broker".PadRight(16) + "Stock".PadRight(16) +
"Value".PadRight(16) + "Changes".PadRight(10) + "Date and Time";
Console.WriteLine(titles);
string destPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,
"Lab1_output.txt");
using (StreamWriter outputFile = new StreamWriter(destPath, false))*/