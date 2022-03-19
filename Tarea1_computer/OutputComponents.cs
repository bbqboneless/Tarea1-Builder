using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea1_computer
{
    public abstract class OutputComponents
    {
        protected string _descripcion, tipoCartucho,_fabricante,_modelo;
        protected int _precio;
        protected int[] puertos;
        public string Descripcion { get { return _descripcion + "\n     Fabricante: " + _fabricante + "\n       Modelo:" + _modelo + "\n        "; } }
        public int Precio { get { return _precio; } }

        public class Pantalla : OutputComponents
        {
            public Pantalla()
            {
                _precio = 2000;
                _fabricante = "Aoc";
                _modelo = "C27G1";
                puertos = new int[2] {2,4};
                _descripcion = "Conexion Pantalla disponible en puertos:";
                for (int i = 0; i < puertos.Length; i++)
                {
                    _descripcion += puertos[i] + ",";
                }
            }
        }

        public class ImpresoraInyeccion : OutputComponents
        {
            public ImpresoraInyeccion()
            {
                _precio = 1800;
                _fabricante = "Epson";
                _modelo = "EP1834";
                tipoCartucho = "Blannco y Negro";
                puertos = new int[2] { 6, 13 };
                _descripcion = "Conexion Impresora de Inyeccion con cartucho:" + tipoCartucho + "Disponible en puertos:";
                for (int i = 0; i < puertos.Length; i++)
                {
                    _descripcion += puertos[i] + ",";
                }
            }
        }

        public class ImpresoraLaser : OutputComponents
        {
            public ImpresoraLaser()
            {
                _precio = 4000;
                _fabricante = "Toshiba";
                _modelo = "InkTank1932";
                tipoCartucho = "Color";
                puertos = new int[2] { 14, 15 };
                _descripcion = "Conexion Impresora Laser con cartucho:" + tipoCartucho + "Disponible en puertos:";
                for (int i = 0; i < puertos.Length; i++)
                {
                    _descripcion += puertos[i] + ",";
                }
            }
        }
    }
}
