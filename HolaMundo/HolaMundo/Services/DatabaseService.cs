using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using HolaMundo.Model;
using SQLite;

namespace HolaMundo.Services
{
    public class DatabaseService
    {
        SQLiteAsyncConnection conn;

        public DatabaseService()
        {
            var databasePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "basededatos.db");

            conn = new SQLiteAsyncConnection(databasePath);
        }

        public async Task<int> Store(List<People> peopleList)
        {
            await conn.CreateTableAsync(typeof(People));

            return await conn.InsertAllAsync(peopleList);
        }

        public async Task<List<People>> GetPeople()
        {
            return await conn.Table<People>().ToListAsync();
            //return conn.Table<People>().Where(persona => persona.id > 10).ToList();
        }
    }
}
