using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea1_computer
{
    public abstract class InputComponents
    {
        protected string _descripcion,tipoConnect, _fabricante, _modelo;
        protected int _precio;
        protected int[] puertos;
        public string Descripcion { get { return _descripcion + "\n       Fabricante: " + _fabricante + "\n       Modelo:" + _modelo + "\n        "; } }
        public int Precio { get { return _precio; } }

        public class Teclado : InputComponents
        {
            public Teclado()
            {
                _precio = 750;
                _fabricante = "Logitech";
                _modelo = "2005RGBShine";
                tipoConnect = "DIN-5";
                puertos = new int[3]{ 1,3,5};
                _descripcion = "Conexion Teclado con conector: "+tipoConnect+" Disponible en puertos:";
                for(int i = 0;i < puertos.Length; i++)
                {
                    _descripcion += puertos[i] + ",";
                }
            }
        }

        public class Raton : InputComponents
        {
            public Raton()
            {
                _precio = 350;
                _fabricante = "Razer";
                _modelo = "7863GreenShine";
                tipoConnect = "PS/2";
                puertos = new int[2] { 9, 11 };
                _descripcion = "Conexion Raton con conector: " + tipoConnect + " Disponible en puertos:";
                for (int i = 0; i < puertos.Length; i++)
                {
                    _descripcion += puertos[i] + ",";
                }
            }
        }

        public class Tableta : InputComponents
        {
            public Tableta()
            {
                _precio = 1800;
                _fabricante = "Samsung";
                _modelo = "Galaxy Tab S8";
                tipoConnect = "AC";
                puertos = new int[4] { 7, 8, 10, 12 };
                _descripcion = "Conexion Tableta con conector: " + tipoConnect + " Disponible en puertos:";
                for (int i = 0; i < puertos.Length; i++)
                {
                    _descripcion += puertos[i] + ",";
                }
            }
        }
    }
}
