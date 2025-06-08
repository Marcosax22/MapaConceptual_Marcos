using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapaConceptual_Marcos_
{
    public class Docente : Empleado
    {
        public string Area { get; set; }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Área: {Area}");
        }
    }
}
