using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace MediiProiectGym.Models
{
    public class ListExercises
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        [ForeignKey(typeof(WorkoutList))]
        public int ShopListID { get; set; }
        public int ProductID { get; set; }
    }
}
