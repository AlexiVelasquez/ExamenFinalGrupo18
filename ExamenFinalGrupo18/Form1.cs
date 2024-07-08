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
                list_Desordenado.Items.Clear();
                foreach (string item in G18_listaDatos)
                {
                    list_Desordenado.Items.Add(item);
                }
                txt_dato.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ingresar");
            }

        }

        private void txt_dato_TextChanged(object sender, EventArgs e)
        {

        }

        private void botoncrear_Click(object sender, EventArgs e)
        {

        }

   

        private void listOrdenado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_ordenar_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> G18_listaOrdenada = G18_listaDatos.OrderBy(x => x).ToList();
                listOrdenado.Items.Clear();
                foreach (string item in G18_listaOrdenada)
                {
                    listOrdenado.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ordenar: " + ex.Message);
            }
        }

        private void btn_crearDocumento_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> G18_listaOrdenada = G18_listaDatos.OrderBy(x => x).ToList();
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Text File|*.txt";
                saveFileDialog.Title = "Guardar lista ordenada";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName))
                    {
                        foreach (string item in G18_listaOrdenada)
                        {
                            sw.WriteLine(item);
                        }
                    }
                    MessageBox.Show("Documento creado exitosamente");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear el documento: " + ex.Message);
            }
        }
    }
}
