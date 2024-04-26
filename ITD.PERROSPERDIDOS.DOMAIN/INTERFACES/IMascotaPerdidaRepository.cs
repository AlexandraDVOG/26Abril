using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITD.PERROSPERDIDOS.DOMAIN.INTERFACES
{
    public interface IMascotaPerdidaRepository
    {
        Task<int> ModificarCaracteristicasPerroPerdido(int idMascota, string nuevasCaracteristicas);
        Task<int> ReportarPerroPerdido(int idUsuario, int celular, string raza, string color, string tamano, char sexo, string caracteristicas, DateTime fechaVisto, string lugarVisto, byte[] imagen);
        Task<IEnumerable<MascotaPerdida>> ObtenerPublicacionesRecientes();
    }
}
