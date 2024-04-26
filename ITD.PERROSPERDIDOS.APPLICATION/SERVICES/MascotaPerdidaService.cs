using ITD.PERROSPERDIDOS.DOMAIN.INTERFACES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITD.PERROSPERDIDOS.APPLICATION.SERVICES
{
    public class MascotaPerdidaService
    {
        private readonly IMascotaPerdidaRepository _mascotaPerdidaRepository;

        public MascotaPerdidaService(IMascotaPerdidaRepository mascotaPerdidaRepository)
        {
            _mascotaPerdidaRepository = mascotaPerdidaRepository;
        }
        // ------------------------------------PROCEDIMIENTO PATCH-----------------------------------------
        public async Task<int> ModificarCaracteristicasPerroPerdido(int idMascota, string nuevasCaracteristicas)
        {
            return await _mascotaPerdidaRepository.ModificarCaracteristicasPerroPerdido(idMascota, nuevasCaracteristicas);
        }
        // ------------------------------------PROCEDIMIENTO POST-----------------------------------------
        public async Task<int> ReportarPerroPerdido(int idUsuario, int celular, string raza, string color, string tamano, char sexo, string caracteristicas, DateTime fechaVisto, string lugarVisto, byte[] imagen)
        {
            return await _mascotaPerdidaRepository.ReportarPerroPerdido(idUsuario, celular, raza, color, tamano, sexo, caracteristicas, fechaVisto, lugarVisto, imagen);
        }
        // ------------------------------------PROCEDIMIENTO GET-----------------------------------------
        public async Task<IEnumerable<MascotaPerdida>> ObtenerPublicacionesRecientes()
        {
            return await _mascotaPerdidaRepository.ObtenerPublicacionesRecientes();
        }
    }
}
