using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenFinalGrupo18
{
    public partial class Form2 : Form
    {
        private List<ActividadVideojuego> actividades;
        private int puntosTotales;
       
        public Form2()
        {
            InitializeComponent();
            actividades = new List<ActividadVideojuego>();
            puntosTotales = 0;
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            
        }
        private void GuardarRegistroEnArchivo()
        {
            string filePath = "registro_actividades.txt";
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                foreach (var actividad in actividades)
                {
                    writer.WriteLine(actividad.ToString());
                }
            }
        }
    }
}
