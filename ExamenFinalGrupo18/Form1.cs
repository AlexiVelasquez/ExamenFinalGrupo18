using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenFinalGrupo18
{
    public partial class Form1 : Form
    {
        //Declaración
        List<string> G18_listaDatos = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_ingreso_Click(object sender, EventArgs e)
        {
            try
            {
                string G18_dato = txt_dato.Text;
                G18_listaDatos.Add(G18_dato);
                list_Dato.Items.Clear();
                foreach (string item in G18_listaDatos)
                {
                    list_Dato.Items.Add(item);
                }
                txt_dato.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ingresar");
            }

        }
    }
}
