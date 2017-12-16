using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RailwayClass
{
    public class Train
    {
        private int train_id;

        public int Train_ID
        {
            get { return train_id; }
            set { train_id = value; }
        }

        private string depart_station;

        public string StationofDeparture
        {
            get { return depart_station; }
            set { depart_station = value; }
        }

        private string arrival_station;

        public string StationofArrival
        {
            get { return arrival_station; }
            set { arrival_station = value; }
        }

        private int cost;

        public int TravelCost
        {
            get { return cost; }
            set { cost = value; }
        }

        public Train(int id, string depart, string arrival, int price)
        {
            Train_ID = id;
            StationofDeparture = depart;
            StationofArrival = arrival;
            TravelCost = price;
        }

        public string TrainRoute()
        {
            return StationofDeparture + "-" + StationofArrival;
        }
    }
}
