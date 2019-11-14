using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace IndependienteStaFe.Services
{
    public interface IGameDate
    {
        Task<DateTime> GetPartidos(int num);
    }
}
