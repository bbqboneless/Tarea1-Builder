using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea1_computer
{
    public class Computer
    {
        //este es el que va a guardar todas las features, literal la compu pues

        CentralUnit _cu;
        InputComponents _icomp;
        OutputComponents _ocomp;
        SpecialComponents _scomp;
        string _tipo;

        public override string ToString()
        {
            return $"\n{_tipo}\n--> Unidad Central: {_cu.Descripcion} PRICE: ${_cu.Precio}\n" +
                $"--> Input Components: {_icomp.Descripcion} PRICE: ${_icomp.Precio}\n" +
                $"--> Ouptut Components: {_ocomp.Descripcion} PRICE: ${_ocomp.Precio}\n" +
                $"--> Special Components: {_scomp.Descripcion} PRICE: ${_scomp.Precio}\n" +
                $"--> TOTAL PRICE: ${_cu.Precio+_icomp.Precio+_ocomp.Precio+_scomp.Precio}";
        }


        public Computer(CentralUnit cu, InputComponents icomp, OutputComponents ocomp, SpecialComponents scomp, string tipo)
        {
            _cu = cu;
            _icomp = icomp;
            _ocomp = ocomp;
            _scomp = scomp;
            _tipo = tipo;
        }

        /*
        private Dictionary<string, string> _components = new Dictionary<string, string>();

        public void Add(string component)
        {
            _components.Add(component, component);
        }

        public override string ToString()
        {
            return String.Join(", ", _components.Values);
        }
        */
    }
}
