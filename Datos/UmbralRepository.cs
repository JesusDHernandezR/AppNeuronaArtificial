using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;
namespace Datos
{
    public class UmbralRepository
    {
        public List<MatrizUmbral> ConsultarTodo()
        {
            string ruta = "Umbrales.txt";
            List<MatrizUmbral> listaUmbrales = new List<MatrizUmbral>();
            FileStream file = new FileStream(ruta, FileMode.OpenOrCreate);
            StreamReader reader = new StreamReader(file);
            string? linea = string.Empty;
            while ((linea = reader.ReadLine()) != null)
            {
                MatrizUmbral umbral = new MatrizUmbral();
                string[] datoUmbral = linea.Split(';');
                umbral.Umbral1 = decimal.Parse(datoUmbral[0]);
                umbral.Umbral2 = decimal.Parse(datoUmbral[2]);
                listaUmbrales.Add(umbral);

            }
            reader.Close();
            file.Close();
            return listaUmbrales;
        }
    }
}
