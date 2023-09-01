using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Proyecto_Final___Wingo
{
    class Funciones
    {
        public string string_a_enviar(string tipo_modalidad, int pers_perfil, int pers_angulo, string pers_modalidad, string delay, Color color, int num_led)
        {
            string mensaje_final = null;
            if (tipo_modalidad == "personalizacion")
            {
                if (pers_modalidad=="independiente")
                {
                    mensaje_final = $"{num_led}:{color.R.ToString()}:{color.G.ToString()}:{color.B.ToString()}";
                }
                else
                {
                    mensaje_final = $"{pers_modalidad}:{delay}";
                }
                switch (pers_angulo)
                {
                    case 0:
                        mensaje_final = $"arriba:{mensaje_final}";
                        break;
                    case 1:
                        mensaje_final = $"izquierda:{mensaje_final}";
                        break;
                    case 2:
                        mensaje_final = $"derrecha:{mensaje_final}";
                        break;
                }
                switch (pers_perfil)
                {
                    case 1:
                        mensaje_final = $"perfil1:{mensaje_final}";
                        break;
                    case 2:
                        mensaje_final = $"perfil2:{mensaje_final}";
                        break;
                }
                mensaje_final = $"personalizacion:{mensaje_final}";
                return mensaje_final;
            }
            else
            {
                return null;
            }
        }
    }
}
