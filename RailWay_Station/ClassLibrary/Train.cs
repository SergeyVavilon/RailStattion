using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;


namespace ClassLibrary
{
    public class Train
    {
        public int TrainId { get; set; }

        public string DepTime { get; set; }

        public string ArrTime { get; set; }



    }
}
