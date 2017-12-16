using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;



namespace ClassLibrary
{
    class Schedule
    {

        private int ScheduleId { get; set; }

        public int Cost { get; set; }
        
        public int ProductId { get; set; }
        public Station Station { get; set; }

        public int TrainId { get; set; }
        public Train Train { get; set; }

    }
}
