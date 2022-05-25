using Entidad;

namespace Datos
{
    public class ParametroRespository
    {
        public List<Parametro> ConsultarTodo()
        {
            string ruta = "Parametros.txt";
            List<Parametro> listaParametros = new List<Parametro>();
            FileStream file = new FileStream(ruta, FileMode.OpenOrCreate);
            StreamReader reader = new StreamReader(file);
            string? linea = string.Empty;
            while ((linea = reader.ReadLine())!=null)
            {
                Parametro parametro = new Parametro();
                string[] datoParametro = linea.Split(';');
                parametro.Entrada = decimal.Parse(datoParametro[0]);
                parametro.Entrada2 = decimal.Parse(datoParametro[1]);
                parametro.Entrada3 = decimal.Parse(datoParametro[2]);
                parametro.Salida = decimal.Parse(datoParametro[3]);
                parametro.Salida2 = decimal.Parse(datoParametro[4]);
                listaParametros.Add(parametro);
            }
            reader.Close();
            file.Close();
            return listaParametros;
        }

    }
}