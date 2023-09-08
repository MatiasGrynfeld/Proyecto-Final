﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Proyecto_Final___Wingo
{
    class Funciones
    {
        public string string_a_enviar(string tipo_modalidad, int pers_perfil, int pers_angulo, string pers_modalidad, string delay, Color color, int num_led, int man_perf, int man_pasonum, string man_tipo_paso, int man_cant_paso)
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
                    mensaje_final = $"{pers_modalidad}:{delay}:null:null";
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
                mensaje_final = $"paso{man_pasonum}:{man_tipo_paso}:{man_cant_paso}:null:null";
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
