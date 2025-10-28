using System;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PARCIAL_2.Clases;
using PARCIAL_2.Repositorios;

namespace PARCIAL_2.UoW
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly SqlConnection _connection;
        private readonly SqlTransaction _transaction;
        private AlumnoRepository _alumnoRepo;


        public UnitOfWork(string  connectionString)
        {
            _connection = new SqlConnection (connectionString);
            _connection.Open ();
            _transaction = _connection.BeginTransaction();
        }

        public AlumnoRepository Alumno
        {
            get
            {
                if (_alumnoRepo == null) { 
                    _alumnoRepo = new AlumnoRepository (_connection, _transaction);
                }
                return _alumnoRepo;
            }
        }

        public AlumnoRepository AlumnoRepository => throw new NotImplementedException();

        public void Commit()
        {
            _transaction?.Commit();
            _transaction?.Dispose();
            //_transaction = null;
        }

        public void Dispose()
        {
            _transaction?.Dispose();
            _connection?.Dispose();
        }
    }
}
