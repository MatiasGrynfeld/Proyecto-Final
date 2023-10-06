using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;

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
        string pathconfig = Proyecto_Final___Wingo.Properties.Settings.Default.pathConfig;
        public void escribir_datos(int linea_a_modificar, string dato_a_modificar)
        {
            string[] lineas = File.ReadAllLines(pathconfig);
            lineas[linea_a_modificar - 1] = dato_a_modificar;
            File.WriteAllLines(pathconfig, lineas);
        }

        public string leer_datos(int linea_a_leer)
        {
            string[] lineas = File.ReadAllLines(pathconfig);
            return lineas[linea_a_leer - 1];
        }

        public void escribir_colores(int linea_a_modificar, Color[,] colores)
        {
            string string_compuesto="";
            string[] lineas = File.ReadAllLines(pathconfig);
            Color color;
            for (int x = 0; x < 8; x++)
            {
                for (int y = 0; y < 8; y++)
                {
                    color = colores[y,x];
                    string hex_color = ColorTranslator.FromHtml(String.Format("#{0:X2}{1:X2}{2:X2}", color.R, color.G, color.B)).Name.Remove(0, 2);
                    string_compuesto = $"{string_compuesto}#{hex_color}";
                }
            }
            lineas[linea_a_modificar - 1] = string_compuesto;
            File.WriteAllLines(pathconfig, lineas);
        }

        public (List<Color>, Color[,]) leer_colores(int linea_a_leer, int mx, int my)
        {
            List<Color> rColores = new List<Color>();
            string[] lineas = File.ReadAllLines(pathconfig);
            string colores = lineas[linea_a_leer-1];

            for (int i = 0; i < colores.Length; i += 7)
            {
                string colorHex = colores.Substring(i, 7);
                Color color = ColorTranslator.FromHtml(colorHex);
                rColores.Add(color);
            }
            Color[,] rMColores = new Color[mx, my];
            for (int x = 0; x < mx; x++)
            {
                for (int y = 0; y < my; y++)
                {
                    rMColores[x, y] = rColores[y + x * 8];
                }
            }

            return (rColores,rMColores);
        }

        public string[] leer_valores(int linea_a_leer)
        {
            string[] lineas = File.ReadAllLines(pathconfig);
            string[] rMods = lineas[linea_a_leer-1].Split(' ');
            return rMods;
        }

        public void escribir_valores(int linea_a_modificar, string dato_a_modificar, int parte_a_modificar)
        {
            string[] lineas = File.ReadAllLines(pathconfig);
            string[] reemplazo = lineas[linea_a_modificar - 1].Split(' ');
            reemplazo[parte_a_modificar] = dato_a_modificar;
            string devolver = reemplazo[0];
            for (int i = 1; i < reemplazo.Length; i++)
            {
                devolver = devolver + " " + reemplazo[i];
            }
            lineas[linea_a_modificar - 1] = devolver;
            File.WriteAllLines(pathconfig, lineas);
        }

    }
}
