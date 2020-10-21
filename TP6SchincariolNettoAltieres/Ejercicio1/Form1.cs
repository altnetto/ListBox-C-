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

        public List<string> listaLibros = new List<string>();

        public void limpiarPantalla()
        {
            txtNombre.Text = "";
            txtAutor.Text = "";
            cbxGenero.Text = "";
            txtPaginas.Text = "";
            cbxImportado.Checked = false;
            txtPrecio.Text = "";
        }
        public string cadastrarLibro()
        {
            string Nombre = txtNombre.Text + " - ";
            string Autor = txtAutor.Text + " - ";
            string Genero = cbxGenero.Text + " - ";
            string Paginas = txtPaginas.Text + " - ";
            string Precio = txtPrecio.Text;
            string Importado;

            campoVacio(txtNombre);
            campoVacio(txtAutor);
            campoVacio(txtPaginas);
            campoVacio(txtPrecio);

            if (cbxImportado.Checked == false)
            {
                Importado = "Nacional - ";
            }
            else
            {
                Importado = "Importado - ";
            }


            return (Nombre +
                    Autor +
                    Genero +
                    Paginas +
                    Importado +
                    Precio);
        }

        public void campoVacio (TextBox campo)
        {
            if(campo.Text == "")
            {
                MessageBox.Show("Hay un campo vacio!");
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
            lbxLista.DataSource = listaLibros;
            string nuevoItemLista = cadastrarLibro();         
            listaLibros.Add(nuevoItemLista);
            limpiarPantalla();

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
