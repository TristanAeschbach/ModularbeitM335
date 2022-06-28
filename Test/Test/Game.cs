using System;
using SQLite;

namespace ModularbeitM335
{
    public class Game
    {
        [PrimaryKey] [AutoIncrement] public int id { get; set; }

        public string name { get; set; }
        public string developer { get; set; }
        public DateTime date { get; set; }
    }
}