using System;
using System.Collections.Generic;
using System.Linq;
using TripCalculator.Models;

namespace TripCalculator 
{
    public class TripService 
    {
        public IEnumerable<Person> SettleUpTrip(IEnumerable<Person> people)
        {
            var total = people.Select(p => p.Total).Sum();
            var average = total / people.Count();
            
            var overpaid = people.Where(p => p.Total > average);
            var underpaid = people.Where(p => p.Total < average);

            var totalOverpaid = overpaid.Select(p => p.Total - average).Sum();
            
            foreach(var person in overpaid)
            {
                var percentage = (person.Total - average) / totalOverpaid;
                underpaid.ToList().ForEach(p => 
                {
                    p.MoneyOwed.Add(person.Name, Math.Abs(p.Total - average) * percentage);
                });
            }

            return overpaid.Union(underpaid);
        }
    }
}