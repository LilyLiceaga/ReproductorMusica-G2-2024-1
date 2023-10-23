using System;
using System.Collections;
using System.Net.Http.Headers;
using System.Windows.Forms;

namespace ReproductorMusica_G2_2024_1
{
    public partial class FormReproductor : Form
    {
        private Form formPadre; //al ser llamada desde Form1, esa será controlada por la Form1
        private ArrayList canciones;
        public FormReproductor(Form formPadre)
        {
            InitializeComponent();
            this.formPadre = formPadre;
            canciones = new ArrayList();
        }
        
        private void FormReproductor_FormClosing(object sender, FormClosingEventArgs e) //al cerrar este form se hace la principal
        {
            formPadre.Show();
        }

        private void CargarCanciones()
        {
            lstbCanciones.Items.Clear();
            canciones.Add(new Musica("Peso Pluma", "Lady Gaga", "Génesis"));
            canciones.Add(new Musica("Michael Jackson", "Thriller", "Thriller"));
            canciones.Add(new Musica("Queen", "Somebody to Love", "A Day at the Races"));
            canciones.Add(new Musica("Hozier", "Would That I", "Wasteland, Baby!"));
            canciones.Add(new Musica("Édith Piaf", "La Vie En Rose", "Chansons Parisiennes"));
        }

        private void cargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CargarCanciones();


            foreach (object cancion in canciones)
            {
                Musica musica = (Musica)cancion;
                lstbCanciones.Items.Add(musica.Titulo);
                //lstbCanciones.Items.Clear(musica.Titulo);
            }
        }

        private void lstbCanciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            Musica musica = (Musica)canciones[lstbCanciones.SelectedIndex];
            lbTitulo.Text = musica.Titulo;   
            lbArtista.Text = musica.Artista;   
            lbAlbum.Text = musica.Album;   
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAgregar formAgregar = new FormAgregar();
            formAgregar.EnviarMusica += AgregarCancion;
            formAgregar.ShowDialog();
        }
        public void AgregarCancion(Musica musica)
        {
            canciones.Add(musica);
            lstbCanciones.Items.Add(musica.Titulo);
        }
    }
}
