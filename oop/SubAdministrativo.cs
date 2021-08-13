using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    class SubAdministrativo:Administrativo
    {
        public override string metodoPadre()
        {
            return base.metodoPadre()+" bis";//HOLA MUNDO BIS
        }
    }
}
