using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputadorasWF
{
    public class ListComputadoras
    {
        public List<Computadora> Lista { get; set; }
        public ListComputadoras()
        {
            Lista = new List<Computadora>();
        }
        public void Agregar(Computadora computadora)
        {
            Lista.Add(computadora);
        }

        public List<Computadora> ModeloEmpiezaL(string cadena)
        {
            List<Computadora> listaAux = new List<Computadora>();
            for (int i = 0; i < Lista.Count; i++)
            {
                if (Lista[i].Modelo.StartsWith(cadena))
                {
                    listaAux.Add(Lista[i]);
                }
            }
            return listaAux;
        }

        public List<Computadora> AnioIgual(string cadena)
        {
            List<Computadora> listAux2 = new List<Computadora>();
            for (int i = 0; i < Lista.Count; i++)
            {
                if (Lista[i].Anio.Equals(cadena))
                {
                    listAux2.Add(Lista[i]);
                }
            }
            return listAux2;
        }

        public int RamCifras()
        {
            int aux = 0;
            foreach (Computadora computadora in Lista)
            {
                if (computadora.MemoriaR >= 10)
                {
                    aux++;
                }
            }
            return aux;
        }

    }
}
