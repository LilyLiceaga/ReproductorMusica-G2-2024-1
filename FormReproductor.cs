using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReproductorMusica_G2_2024_1
{
    public partial class FormReproductor : Form
    {
        //Form formPadre; //al ser llamada desde Form1, esa será controlada por la Form1
        public FormReproductor() //Form formPadre
        {
            InitializeComponent();
            //this.formPadre = formPadre;
        }
        
        private void FormReproductor_FormClosing(object sender, FormClosingEventArgs e) //al cerrar este form se hace la principal
        {
            //formPadre.Show();
        }
    }
}
