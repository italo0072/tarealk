using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea salir de el programa?", "Cuadro de leave", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("no tube buenos fondos sorry :V");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Actores actores = new Actores();
        actores.setNombre(txtNombre.Text);
            actores.setNacionalidad(txtNacionalidad.Text);
            actores.setNacimiento(txtNacimiento.Text);
            actores.setGenero(txtGenero.Text);
            actores.setpremios(txtPremios.Text);

            listBox1.Items.Add(actores.get1());
            listBox1.Items.Add(actores.get2());
            listBox1.Items.Add(actores.get3());
            listBox1.Items.Add(actores.get4()); 
            listBox1.Items.Add(actores.get5());

            txtNombre.Text = "";
            txtNacionalidad.Text = "";
            txtNacimiento.Text = "";
            txtGenero.Text = "";
            txtPremios.Text = "";
            
            
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Desea Borrar los Datos de el Registro", "Datos de el registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                listBox1.Items.Clear();
            }
        }
    }
}
