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
        public string string_a_enviar(string tipo_modalidad, int pers_perfil, int pers_angulo, string pers_modalidad, string delay, Color color, int fila, int columna, int man_perf, int man_pasonum, string man_tipo_paso, int man_cant_paso)
        {
            int num_modalidad = -100;
            string mensaje_final = null;
            if (tipo_modalidad == "personalizacion")
            {
                if (pers_modalidad == "independiente")
                {
                    mensaje_final = $"{columna}:{fila}:{color.R}:{color.G}:{color.B}";
                }
                else if (pers_modalidad == "apagado") 
                {
                    mensaje_final = $"{pers_modalidad}:null:null:null:null";
                }
                else
                {
                    mensaje_final = $"{pers_modalidad}:{delay}:null:null:null";
                }
                switch (pers_angulo)
                {
                    case 0:
                        mensaje_final = $"a:{mensaje_final}";
                        break;
                    case 1:
                        mensaje_final = $"i:{mensaje_final}";
                        break;
                    case 2:
                        mensaje_final = $"d:{mensaje_final}";
                        break;
                }
                switch (pers_perfil)
                {
                    case 1:
                        mensaje_final = $"1{mensaje_final}";
                        break;
                    case 2:
                        mensaje_final = $"2{mensaje_final}";
                        break;
                }
                mensaje_final = $"p:{mensaje_final}";
                return mensaje_final;
            }
            else
            {
                mensaje_final = $"{man_pasonum}:{man_tipo_paso}:{man_cant_paso}:null:null";
                switch (man_perf)
                {
                    case 1:
                        mensaje_final = $"1:{mensaje_final}"; break;
                    case 2:
                        mensaje_final = $"2:{mensaje_final}"; break;
                    case 3:
                        mensaje_final = $"3:{mensaje_final}"; break;
                }
                mensaje_final = $"m:{mensaje_final}";
                return mensaje_final;
            }
        }
    }
}
