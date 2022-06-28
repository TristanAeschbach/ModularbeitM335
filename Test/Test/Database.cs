using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using SQLite;

namespace ModularbeitM335
{
    public class Database
    {
        private readonly SQLiteAsyncConnection _database;

        public Database()
        {
            var dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                "games.db3");
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Game>();
        }

        public Task<List<Game>> GetPeopleAsync()
        {
            return _database.Table<Game>().OrderByDescending(Game => Game.id).ToListAsync();
        }

        public Task<int> SavePersonAsync(Game person)
        {
            return _database.InsertAsync(person);
        }
    }
}