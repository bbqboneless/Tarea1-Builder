using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea1_computer
{
    public abstract class Builder
    {
        protected string _descripcion;
        //aqui voy a poner lo que tenemos que construir por default
        public abstract CentralUnit BuildCentralUnit();
        public abstract InputComponents BuildInputComponents();
        public abstract OutputComponents BuildOutputComponents();
        public abstract SpecialComponents BuildSpecialComponents();
        //y obtener lo que me regresa
        //public abstract Computer GetResult();

        public override string ToString()
        {
            return _descripcion;
        }
        public Computer BuildComputer()
        {
            CentralUnit cu = BuildCentralUnit();
            InputComponents icomp = BuildInputComponents();
            OutputComponents ocomp = BuildOutputComponents();
            SpecialComponents scomp = BuildSpecialComponents();

            return new Computer(cu, icomp, ocomp, scomp, _descripcion);
        }


    }
}
