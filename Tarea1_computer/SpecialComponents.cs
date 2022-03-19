using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea1_computer
{
    public abstract class SpecialComponents
    {
        protected string _descripcion,_fabricante,_modelo;
        protected int _precio;
        protected int[] puertos;
        public string Descripcion { get { return _descripcion + "\n     Fabricante: " + _fabricante + "\n       Modelo:" + _modelo + "\n        "; } }
        public int Precio { get { return _precio; } }

        public class PantallaTactil : SpecialComponents
        {
            public PantallaTactil()
            {
                _precio = 2400;
                _fabricante = "Huawei";
                _modelo = "T34C8T Shine";
                puertos = new int[5] { 16, 17,18,19,20 };
                _descripcion = "Conexion Pantalla Tactil disponible en puertos:";
                for (int i = 0; i < puertos.Length; i++)
                {
                    _descripcion += puertos[i] + ",";
                }
            }
        }

        public class None : SpecialComponents
        {
            public None()
            {
                _precio = 0;
                _fabricante = "";
                _modelo = "";
            }
        }
    }
}
