using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea1_computer
{
    class Director
    {
        //este va a se mi orden
        public void Construct(Builder builder)
        {
            builder.BuildCentralUnit();
            builder.BuildInputComponents();
            builder.BuildOutputComponents();
            builder.BuildSpecialComponents();
        }
    }
}
