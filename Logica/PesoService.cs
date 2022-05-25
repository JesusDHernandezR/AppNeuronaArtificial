using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidad;
namespace Logica
{
    public class PesoService
    {
        readonly PesoRepository pesoRepository;

        public PesoService()
        {
            pesoRepository = new PesoRepository();
        }
        public ConsultarPesoResponse ConsultarPesos()
        {
            try
            {
                return new ConsultarPesoResponse(pesoRepository.ConsultarTodo());
            }
            catch (Exception ex)
            {
                return new ConsultarPesoResponse(ex.Message);
            }
        }
    }
    public class ConsultarPesoResponse
    {
            public List<MatrizPeso>? ListPeso { get; set; }
            public string? Mensaje { get; set; }
            public bool Error { get; set; }

            public ConsultarPesoResponse(List<MatrizPeso> listPesos)
            {
                ListPeso = listPesos;
                Error = false;
            }
            public ConsultarPesoResponse(string mensaje)
            {
                Mensaje = mensaje;
                Error = true;
            }
        
    }
}
