using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea1_computer
{
    public class MyComputer2 : Builder
    {
        public MyComputer2()
        {
            _descripcion = "Compu de Fulanito";
        }
        public override CentralUnit BuildCentralUnit()
        {
            return new CentralUnit.CPU();
        }

        public override InputComponents BuildInputComponents()
        {
            return new InputComponents.Raton();
        }

        public override OutputComponents BuildOutputComponents()
        {
            return new OutputComponents.ImpresoraLaser();
        }

        public override SpecialComponents BuildSpecialComponents()
        {
            return new SpecialComponents.None();
        }
    }
}
