using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;


namespace ClassLibrary
{
    class Timetable
    {
        public int TimetableId { get; set; }

        public bool Monday { get; set; }

        public bool Tuesday { get; set; }

        public bool WednesDay { get; set; }

        public bool Thursday { get; set; }

        public bool Friday { get; set; }

        public bool Saturday { get; set; }

        public bool Sunday { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
    }
}
