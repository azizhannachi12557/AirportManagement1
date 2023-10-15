using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Interface;

namespace AM.ApplicationCore.Service
{
    public class FlightMethode :IflightMethode
    {

        IList<Flight> flights=new List<Flight>();

        public IList<DateTime> GetFlightDates(string dest)
        {
            //IList<DateTime> Result = new List<DateTime>();
            //foreach (var item in flights)
            //{
            //           }
            //methode query
            var query = from item in flights
                        where item.Destination == dest
                        select item.FlightDate;
            return query.ToList();
        }
            public IList<DateTime> GetFlightDates(Plane plane)
            {
                var query = from item in flights
                            where item.Plane == Plane
                            select new {item.FlightDate, item.Destination};
            foreach (var item in query) {
                Console.WriteLine("flighte date"+a.FlightDestination); }
                
            }
    }
        }
    }

