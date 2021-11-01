using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Entity1
{
    public class ClaseB : ClaseA
    {
        public override string Saludar()
        {
            return base.Saludar() + " que bueno que soy extendido por la clase hija";
        }
    }
}