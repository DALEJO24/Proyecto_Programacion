using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2
{
    public class Computadora
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Anio { get; set; }
        public int MemoriaR { get; set; }
        public string CapDisco { get; set; }

        public Computadora() { }

        public Computadora(string marca, string modelo, string anio, int memoriaR, string capDisco)
        {
            Marca = marca;
            Modelo = modelo;
            Anio = anio;
            MemoriaR = memoriaR;
            CapDisco = capDisco;
        }
    }
}
