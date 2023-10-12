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
            string mensaje_final = null;
            if (tipo_modalidad == "personalizacion")
            {
                if (pers_modalidad == "independiente")
                {
                    int led_num = columna + fila * 8 + 64*pers_angulo;
                    if (color.R != 0 && color.G != 0 && color.B != 0)
                    {
                        mensaje_final = $":{led_num}:{color.R}:{color.G}:{color.B}";
                    }
                    else
                    {
                        return "::";
                    }
                }
                else
                {
                    if (pers_modalidad == "apagado")
                    {
                        mensaje_final = $"{pers_modalidad}";
                    }
                    else
                    {
                        mensaje_final = $"{pers_modalidad}:{delay}";
                    }
                    switch (pers_angulo)
                    {
                        case 0:
                            mensaje_final = $"s:0:{mensaje_final}";
                            break;
                        case 1:
                            mensaje_final = $"s:1:{mensaje_final}";
                            break;
                        case 2:
                            mensaje_final = $"s:2:{mensaje_final}";
                            break;
                    }
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
                mensaje_final = $"p{mensaje_final}";
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
        string pathconfig = Program.pathConfig;
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
            string string_compuesto = "";
            string[] lineas = File.ReadAllLines(pathconfig);

            for (int x = 0; x < 8; x++)
            {
                for (int y = 0; y < 8; y++)
                {
                    Color color = colores[y, x];
                    string rgb_color = $"{color.R}:{color.G}:{color.B}";
                    string_compuesto = $"{string_compuesto}{rgb_color},";
                }
            }

            lineas[linea_a_modificar - 1] = string_compuesto.TrimEnd(',');
            File.WriteAllLines(pathconfig, lineas);
        }

        public (List<Color>, Color[,]) leer_colores(int linea_a_leer, int mx, int my)
        {
            List<Color> rColores = new List<Color>();
            string[] lineas = File.ReadAllLines(pathconfig);
            string colores = lineas[linea_a_leer - 1];
            string[] rgbColors = colores.Split(',');

            for (int i = 0; i < rgbColors.Length; i++)
            {
                string[] rgb = rgbColors[i].Split(':');
                if (rgb.Length == 3 && int.TryParse(rgb[0], out int r) && int.TryParse(rgb[1], out int g) && int.TryParse(rgb[2], out int b))
                {
                    Color color = Color.FromArgb(r, g, b);
                    rColores.Add(color);
                }
            }
            Color[,] rMColores = new Color[mx, my];
            if (rColores.Count > 0)
            {
                for (int x = 0; x < mx; x++)
                {
                    for (int y = 0; y < my; y++)
                    {
                        rMColores[y, x] = rColores[y + x * 8];
                    }
                }
            }

            return (rColores, rMColores);
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

        public (List<string>, List<int>) leer_recor(int linea_a_leer)
        {
            linea_a_leer--;
            string[] lineas = File.ReadAllLines(pathconfig);
            int linea_index = linea_a_leer;
            List<string> rTipo = new List<string>();
            List<int> rCant = new List<int>();

            while (lineas[linea_index]!="}")
            {
                if (lineas[linea_index] != "")
                {
                    string[] partes = lineas[linea_a_leer].Split(' ');
                    rTipo.Add(partes[0]);
                    rCant.Add(Convert.ToInt32(partes[1]));
                }
                linea_index++;
            }
            return (rTipo, rCant);
        }
        public void escribir_recor(int linea_a_escribir, List<string> tipo, List<int> cant)
        {
            List<string> lineas= File.ReadAllLines(pathconfig).ToList();
            for (int i = 0; i < tipo.Count; i++)
            {
                lineas.Insert(linea_a_escribir-1+i, $"{tipo[i]} {cant[i]}");
            }
            File.WriteAllLines(pathconfig, lineas);
        }
    }
}
