using System;
using Microsoft.Data.SqlClient;
using RepoDb;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PARCIAL_2.Clases;

namespace PARCIAL_2.Repositorios
{
    public class AlumnoRepository
    {
        private readonly SqlConnection _connection;
        private readonly SqlTransaction _transaction;



        public AlumnoRepository(SqlConnection connection, SqlTransaction transaction)
        {
            _connection = connection;
            _transaction = transaction;
        }

        //ocupamos expreciones lambda para el where
        public Alumno? GetById(int id)
        { 
            return _connection.Query<Alumno>(where: (Alumno a) => a.Id == id, transaction: _transaction).FirstOrDefault();
        }

        public int Insert(Alumno alumno)
        {
            return (int) _connection.Insert(alumno, transaction: _transaction);
        }

        public IEnumerable<Alumno> GetAll() 
        { 
            return _connection.QueryAll<Alumno>(transaction : _transaction);
        }

        public int Update(Alumno alumno, IEnumerable<Field> campos)
        {
            return _connection.Update<Alumno>(alumno, fields: campos, transaction : _transaction);

        }

        public IEnumerable<Alumno> GetByEstado(bool activo)
        {
            return _connection.Query<Alumno>(where: (Alumno a) => a.Activo == activo, transaction: _transaction);
        }
    }
}
