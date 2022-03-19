using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea1_computer
{
    public class MyComputer : Builder
    {
        public MyComputer()
        {
            _descripcion = "Compu de Sam";
        }
        public override CentralUnit BuildCentralUnit()
        {
            return new CentralUnit.CPU();
        }

        public override InputComponents BuildInputComponents()
        {
            return new InputComponents.Teclado();
        }

        public override OutputComponents BuildOutputComponents()
        {
            return new OutputComponents.Pantalla();
        }

        public override SpecialComponents BuildSpecialComponents()
        {
            return new SpecialComponents.PantallaTactil();
        }
    }
}
