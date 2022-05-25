using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;
namespace Datos
{
    public class PesoRepository
    {
        public List<MatrizPeso> ConsultarTodo()
        {
            string ruta = "Pesos.txt";
            List<MatrizPeso> listaPesos = new List<MatrizPeso>();
            FileStream file = new FileStream(ruta, FileMode.OpenOrCreate);
            StreamReader reader = new StreamReader(file);
            string? linea = string.Empty;
            while ((linea = reader.ReadLine()) != null)
            {
                MatrizPeso peso = new MatrizPeso();
                string[] datoPeso = linea.Split(';');
                peso.Peso1= decimal.Parse(datoPeso[0]);
                peso.Peso2 = decimal.Parse(datoPeso[1]);
                peso.Peso3 = decimal.Parse(datoPeso[2]);
                peso.Peso4 = decimal.Parse(datoPeso[3]);
                peso.Peso5 = decimal.Parse(datoPeso[4]);
                peso.Peso6 = decimal.Parse(datoPeso[5]);
                listaPesos.Add(peso);

            }
            reader.Close();
            file.Close();
            return listaPesos;
        }
    }
}
