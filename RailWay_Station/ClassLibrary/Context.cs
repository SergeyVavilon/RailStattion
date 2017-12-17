using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace ClassLibrary
{
    class Context : DbContext
    {
        public Context(): base()
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Train> Trains { get; set; }
        public DbSet<Station> Stations { get; set; }
        public DbSet<Timetable> Timetables { get; set; }
        public DbSet<Schedule> Schedules { get; set; }


        

    }
}
