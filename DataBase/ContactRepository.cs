using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using Database;
using Database.Models;
using System.Data;

namespace Database
{
    public class ContactRepository
    {
        private SqlConnection _connection;
        public ContactRepository(SqlConnection connection)
        {
            _connection = connection;
        }

        public bool Add(Contact item)
        {
            SqlCommand command = new SqlCommand("insert into Contactos(Nombre,Apellidos,Direccion,TelefonoPersonal," +
                "TelefonoTrabajo,ID_Usuarios) " +
                "values(@nombre,@apellidos,@direccion,@telper,@teltrab,@id_user)", _connection);

            command.Parameters.AddWithValue("@nombre", item.Nombre);
            command.Parameters.AddWithValue("@apellidos", item.Apellidos);
            command.Parameters.AddWithValue("@direccion", item.Direccion);
            command.Parameters.AddWithValue("@telper", item.TelefonoPersonal);
            command.Parameters.AddWithValue("@teltrab", item.TelefonoTrabajo);
            command.Parameters.AddWithValue("@id_user", item.IdUsuario);

            return ExecuteDml(command);
        }
        public bool AddUser(Contact item)
        {
            SqlCommand command = new SqlCommand("insert into Usuarios(Nombre,Apellidos,Usuario,Contraseña, Contraseña2 values(@nombre,@apellidos,@usuarios,@pass,@pass2)", _connection);

            command.Parameters.AddWithValue("@nombre", item.Nombre);
            command.Parameters.AddWithValue("@apellidos", item.Apellidos);
            command.Parameters.AddWithValue("@usuarios", item.Usuario);
            command.Parameters.AddWithValue("@pass", item.Pass);
            command.Parameters.AddWithValue("@pass2", item.Pass2);
            command.Parameters.AddWithValue("@id", item.IdUsuario);

            return ExecuteDml(command);
        }

        public bool Edit(Contact item)
        {
            SqlCommand command = new SqlCommand("update Contactos set Nombre=@nombre,Apellidos=@apellidos,Direccion=@direccion,TelefonoPersonal=@telper,TelefonoTrabajo=@teltrab,ID_Usuarios = @id_user where ID = @id", _connection);

            command.Parameters.AddWithValue("@nombre", item.Nombre);
            command.Parameters.AddWithValue("@apellidos", item.Apellidos);
            command.Parameters.AddWithValue("@direccion", item.Direccion);
            command.Parameters.AddWithValue("@telper", item.TelefonoPersonal);
            command.Parameters.AddWithValue("@teltrab", item.TelefonoTrabajo);
            command.Parameters.AddWithValue("@id_user", item.IdUsuario);
            command.Parameters.AddWithValue("@id", item.Id);

            return ExecuteDml(command);
        }

       

        public bool Delete(int id)
        {
            SqlCommand command = new SqlCommand("delete Contactos where ID = @id", _connection);

            command.Parameters.AddWithValue("@id", id);

            return ExecuteDml(command);
        }

        public Contact GetById(int id)
        {
            try
            {
                _connection.Open();

                SqlCommand command = new SqlCommand("Select * from Contactos where ID =@id", _connection);

                command.Parameters.AddWithValue("@id", id);

                SqlDataReader reader = command.ExecuteReader();

                Contact data = new Contact();

                while (reader.Read())
                {
                    data.Id = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                    data.Nombre = reader.IsDBNull(1) ? "" : reader.GetString(1);
                    data.Apellidos = reader.IsDBNull(2) ? "" : reader.GetString(2);
                    data.Direccion = reader.IsDBNull(3) ? "" : reader.GetString(3);
                    data.TelefonoPersonal = reader.IsDBNull(4) ? "" : reader.GetString(4);
                    data.TelefonoTrabajo = reader.IsDBNull(5) ? "" : reader.GetString(5);
                }

                reader.Close();
                reader.Dispose();

                _connection.Close();

                return data;
            }
            catch (Exception e)
            {
                return null;
            }

        }

        public Contact GetByIdUser(int id)
        {
            try
            {
                _connection.Open();

                SqlCommand command = new SqlCommand("select ID ,Usuario ,Contraseña from Usuarios where ID =@id", _connection);

                command.Parameters.AddWithValue("@id", id);

                SqlDataReader reader = command.ExecuteReader();

                Contact data = new Contact();

                while (reader.Read())
                {
                    data.Id = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                    data.Nombre = reader.IsDBNull(1) ? "" : reader.GetString(1);
                    data.Apellidos = reader.IsDBNull(2) ? "" : reader.GetString(2);
                    data.Direccion = reader.IsDBNull(3) ? "" : reader.GetString(3);
                    data.TelefonoPersonal = reader.IsDBNull(4) ? "" : reader.GetString(4);
                    data.TelefonoTrabajo = reader.IsDBNull(5) ? "" : reader.GetString(5);
                }

                reader.Close();
                reader.Dispose();

                _connection.Close();

                return data;
            }
            catch (Exception e)
            {
                return null;
            }

        }

        public DataTable GetAll()
        {
            SqlDataAdapter query = new SqlDataAdapter("select c.ID ,c.Nombre ,c.Apellidos ,, c.Direccion, c.TelefonoPersonal" +
                ",c.TelefonoTrabajo, ct.Usuario from Contactos c join Usuarios ct on c.ID_Usuarios = ct.ID", _connection);
            return LoadData(query);
        }
       
        public void GetID()
        {
            try
            {
                SqlCommand query = new SqlCommand("Select ID from Usuarios", _connection);
                ExecuteDml2(query);
            }
            catch (Exception)
            {

            }

        }

        private DataTable LoadData(SqlDataAdapter query)
        {
            try
            {
                DataTable data = new DataTable();

                _connection.Open();

                query.Fill(data);

                _connection.Close();

                return data;
            }
            catch (Exception e)
            {
                return null;
            }

        }
        public bool ExecuteDml(SqlCommand query)
        {
            try
            {
                _connection.Open();

                query.ExecuteNonQuery();

                _connection.Close();

                return true;
            }
            catch (Exception e)
            {
                return false;
            }

        }
        public void ExecuteDml2(SqlCommand query)
        {
            try
            {
                _connection.Open();

                query.ExecuteNonQuery();

                _connection.Close();

            }
            catch (Exception e)
            {
               
            }

        }

    }
}
