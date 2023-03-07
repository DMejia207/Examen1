using System;
using System.Collections.Generic;
using System.Text;
using Examen1.Models;
using SQLite;
using System.Threading.Tasks;
namespace Examen1.Controllers
{
    public class GuardControllers
    {
        readonly SQLiteAsyncConnection connection;

        //Constructor de clase
        public GuardControllers(string dbpath)
        {
            // Crear una nueva conexion hacia la base de dato
            connection = new SQLiteAsyncConnection(dbpath);

            // Crear los objetos de base de datos que vamos a ocupar
            connection.CreateTableAsync<Contactos>().Wait();
        }

        // Creacion de las operaciones CRUD - DB
        // Create

        public Task<int> SaveListaa(Contactos info)
        {
            if (info.id != 0)
                return connection.UpdateAsync(info);
            else
                return connection.InsertAsync(info);
        }
        // Read

        public Task<List<Contactos>> GetListaa()
        {
            return connection.Table<Contactos>().ToListAsync();
        }


        public Task<Contactos> GetListaa(int pid)
        {
            return connection.Table<Contactos>()
            .Where(i => i.id == pid)
            .FirstOrDefaultAsync();
        }

        // Delete

        public Task<int> DeleteListaa(Contactos info)
        {
            return connection.DeleteAsync(info);
        }

    }
}
