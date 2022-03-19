using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea1_computer
{
    public abstract class CentralUnit
    {
        protected string _descripcion,_fabricante,_modelo;
        protected int _precio;
        public string Descripcion { get { return _descripcion+"\n       Fabricante: "+_fabricante+"\n       Modelo:"+_modelo+"\n        "; } }
        public int Precio { get { return _precio; } }

        public class CPU : CentralUnit
        {
            public CPU()
            {
                _precio = 1500;
                _fabricante = "Intel";
                _modelo = "2019";
                _descripcion = "Unidad Central CPU.";
            }
        }

    }
}
