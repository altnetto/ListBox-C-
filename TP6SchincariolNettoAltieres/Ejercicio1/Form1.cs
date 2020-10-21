using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        public void limpiarPantalla()
        {
            txtNombre.Text = "";
            txtAutor.Text = "";
            cbxGenero.Text = "";
            txtPaginas.Text = "";
            cbxImportado.Checked = false;
            txtPrecio.Text = "";
        }
        public void cadastrarLibro()
        {

            Libro libro = new Libro();

            libro.Nombre = txtNombre.Text + " - ";
            libro.Autor = txtAutor.Text + " - ";
            libro.Genero = cbxGenero.Text + " - ";
            libro.Paginas = txtPaginas.Text + " - ";
            libro.Importado = verificarImportado(cbxImportado) + " - ";
            libro.Precio = txtPrecio.Text;

            string info = libro.Nombre + libro.Autor + libro.Genero + libro.Paginas + libro.Importado + libro.Precio;

            lbxLista.Items.Add(info);

        }


        public string verificarImportado(CheckBox checkBox)
        {
            if (checkBox.Checked == false)
            {
                return "Nacional - ";
            }
            else
            {
                return "Importado - ";
            }
        }

        public bool campoVacio (TextBox campo)
        {
            if (campo.Text == "")
            {
                MessageBox.Show("Hay un campo vacio!");
                return true;
            }
            else
            {
                return false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            limpiarPantalla();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            cadastrarLibro();         
            limpiarPantalla();

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
