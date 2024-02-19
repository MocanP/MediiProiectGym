using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediiProiectGym.Models
{
    public class Exercises
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Description { get; set; }
        [OneToMany]
        public List<ListExercises> ListExercises { get; set; }
    }

}
