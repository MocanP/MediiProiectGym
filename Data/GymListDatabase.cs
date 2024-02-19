using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MediiProiectGym.Models;

namespace MediiProiectGym.Data
{
    public class GymListDatabase
    {
        readonly SQLiteAsyncConnection _database;
        public GymListDatabase(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<WorkoutList>().Wait();
        }
        public Task<List<WorkoutList>> GetShopListsAsync()
        {
            return _database.Table<WorkoutList>().ToListAsync();
        }
        public Task<WorkoutList> GetShopListAsync(int id)
        {
            return _database.Table<WorkoutList>()
            .Where(i => i.ID == id)
           .FirstOrDefaultAsync();
        }
        public Task<int> SaveShopListAsync(WorkoutList slist)
        {
            if (slist.ID != 0)
            {
                return _database.UpdateAsync(slist);
            }
            else
            {
                return _database.InsertAsync(slist);
            }
        }
        public Task<int> DeleteShopListAsync(WorkoutList slist)
        {
            return _database.DeleteAsync(slist);
        }
    }
}