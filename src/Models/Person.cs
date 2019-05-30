using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace TripCalculator.Models 
{
    public class Person 
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("identifier")]
        public string Identifier { get; set; }

        // Since we're working with money, it would probably be a good idea to 
        // store the amounts in integer form as the number of cents.
        // When dealing with very large sums of money we could run into
        // rounding issues, but in this program it's unlikely so double it is.
        [JsonProperty("expenses")]
        public IEnumerable<double> Expenses { get; set; }

        [JsonProperty("moneyOwed")]
        public IDictionary<string, double> MoneyOwed { get; set; }

        [JsonIgnore]
        public double Total => Expenses.Sum();

        public Person()
        {
            Expenses = new List<double>();
            MoneyOwed = new Dictionary<string, double>();
        }
    }
}