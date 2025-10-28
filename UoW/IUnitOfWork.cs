using PARCIAL_2.Clases;
using PARCIAL_2.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARCIAL_2.UoW
{
    public interface IUnitOfWork : IDisposable
    {
        AlumnoRepository AlumnoRepository { get; }

        void Commit();

    }
}
