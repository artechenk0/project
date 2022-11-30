using System;
using System.Collections.ObjectModel;
using System.Linq;

namespace Project04
{
    public class Traffic
    {
        public static ObservableCollection<Traffic> traffics = new ObservableCollection<Traffic>();
        public static ObservableCollection<Traffic> sortTraffics = new ObservableCollection<Traffic>();
        public static ObservableCollection<Traffic> AllDistance = new ObservableCollection<Traffic>();
        public string Type { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public double Distance { get; set; }
        public string DistanceName { get; set; }
        public int SiteCount { get; set; }
        public double TicketPrice { get; set; }
        public int TicketCount { get; set; }

        public static void AddTraffic(string type, DateTime startDate, DateTime endDate, double distance, string distanceName, int siteCount, double ticketPrice, int ticketCount)
        {
            Traffic traffic = new Traffic();
            traffic.Type = type;
            traffic.StartDate = startDate;
            traffic.EndDate = endDate;
            traffic.Distance = distance;
            traffic.DistanceName = distanceName;
            traffic.SiteCount = siteCount;
            traffic.TicketPrice = ticketPrice;
            traffic.TicketCount = ticketCount;
            traffics.Add(traffic);
        }
        public static void SortTraffic(string distanceName)
        {
            sortTraffics.Clear();
            for (int i = 0; i < traffics.Count; i++)
            {
                if (traffics[i].DistanceName == distanceName)
                {
                    sortTraffics.Add(traffics[i]);
                }
            }
        }
        public static void SearchAllDistanceName()
        {
        }
    }
}
