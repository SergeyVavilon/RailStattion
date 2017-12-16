using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;



namespace ClassLibrary
{
    public class Station
    {
        public int StationId { get; set; }
        public string Name { get; set; }
    }
}
