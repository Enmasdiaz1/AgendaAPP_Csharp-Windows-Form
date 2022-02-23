using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using Database;
using Database.Models;

namespace BussinessLayer
{
    public class ServicioContacto
    {
        private ContactRepository repository;
        public ServicioContacto(SqlConnection connection)
        {
            repository = new ContactRepository(connection);
        }

        public bool Add(Contact item)
        {
            return repository.Add(item);
        }
        public bool AddUser(Contact item)
        {
            return repository.AddUser(item);
        }

        public bool Edit(Contact item)
        {
            return repository.Edit(item);
        }

        public bool Delete(int id)
        {
            return repository.Delete(id);
        }

        public Contact GetById(int id)
        {
            return repository.GetById(id);
        }
        public Contact GetByIdUser(int id)
        {
            return repository.GetByIdUser(id);
        }
        public DataTable GetAll()
        {
            return repository.GetAll();
        }
        
    }
}
