using Datos;
using Entidad;

namespace Logica
{
    public class ParametroService
    {
        readonly ParametroRespository parametroRespository;

        public ParametroService()
        {
            parametroRespository = new ParametroRespository();
        }

        public ConsultaParametroResponse ConsultarTodo()
        {
            try
            {
                return new ConsultaParametroResponse(parametroRespository.ConsultarTodo());
            }
            catch (Exception ex)
            {
                return new ConsultaParametroResponse(ex.Message);
            }
        }
        
    }
    public class ConsultaParametroResponse
    {
        public List<Parametro>? ListParametros { get; set; }
        public string? Mensaje { get; set; }
        public bool Error { get; set; }

        public ConsultaParametroResponse(List<Parametro> listParametros)
        {
            ListParametros = listParametros;
            Error = false;
        }
        public ConsultaParametroResponse(string mensaje)
        {
            Mensaje = mensaje;
            Error = true;
        }
    }
}