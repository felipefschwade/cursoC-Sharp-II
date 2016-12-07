using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhandoComClasses
{
    class ContaPouopanca : Conta
    {
        public override void saca(double valorASacar)
        {
            base.saca(valorASacar + 0.1);
        }
    }
}
