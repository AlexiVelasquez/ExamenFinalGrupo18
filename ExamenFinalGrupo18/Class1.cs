using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinalGrupo18
{
        public class ActividadVideojuego
        {
            public string NombreJuego { get; set; }
            public bool Gano { get; set; }
            public DateTime Fecha { get; set; }
            public int Puntos { get; set; }

            public ActividadVideojuego(string nombreJuego, bool gano)
            {
                NombreJuego = nombreJuego;
                Gano = gano;
                Fecha = DateTime.Now;
                Puntos = gano ? 100 : -20;
            }

            public override string ToString()
            {
                return $"{Fecha.ToShortDateString()} - {NombreJuego} - {(Gano ? "Ganado" : "Perdido")} - {Puntos} puntos";
            }
        }
}

