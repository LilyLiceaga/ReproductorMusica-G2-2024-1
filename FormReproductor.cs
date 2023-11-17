using System;
using System.Collections;
using System.IO;
using System.Net.Http.Headers;
using System.Windows.Forms;
using System.IO;


namespace ReproductorMusica_G2_2024_1
{
    public partial class FormReproductor : Form
    {
        //private Form formPadre; //al ser llamada desde Form1, esa será controlada por la Form1
        private ArrayList canciones;
        private int tiempo;
        private Musica musica;
        public FormReproductor()
        {
            InitializeComponent();
            //this.formPadre = formPadre;
            canciones = new ArrayList();
        }
        /*public FormReproductor(Form formPadre)
        {
            InitializeComponent();
            //this.formPadre = formPadre;
            canciones = new ArrayList();
        }*/
        
        private void FormReproductor_FormClosing(object sender, FormClosingEventArgs e) //al cerrar este form se hace la principal
        {
            //formPadre.Show();
        }

        private void CargarCanciones()
        {
            lstbCanciones.Items.Clear();
            canciones.Add(new Musica("Peso Pluma", "Lady Gaga", "Génesis", 210));
            canciones.Add(new Musica("Michael Jackson", "Thriller", "Thriller", 202));
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
            //Musica musica = (Musica)canciones[lstbCanciones.SelectedIndex];
            this.musica = (Musica)canciones[lstbCanciones.SelectedIndex];
            lbTitulo.Text = musica.Titulo;   
            lbArtista.Text = musica.Artista;   
            lbAlbum.Text = musica.Album;   
            lbFinal.Text = String.Format("{0}:{1}", musica.Duracion/60, (musica.Duracion/60.0 - musica.Duracion/60)*60);   
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            pbDuracion.Value += 1;
            lbInicio.Text = String.Format("{0}  [s]", pbDuracion.Value);

            if (pbDuracion.Value == 100)
            {
                timer1.Stop();
            }
        }

        private void playToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfDialog = new SaveFileDialog();

            FileStream fs = null;
            StreamWriter sw = null;

            sfDialog.Filter = ".csv|] .csv ";

            if (sfDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    fs = new FileStream(sfDialog.FileName, FileMode.Create, FileAccess.Write);
                    sw = new StreamWriter(fs);
                    sw.WriteLine("Artista, Album, Titulo y Duración");
                    foreach (Musica musica in canciones)
                    {
                        sw.WriteLine(String.Format("{0}, {1}, {2},{3}", musica.Artista, musica.Album, musica.Titulo, musica.Duracion));

                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);

                }
                finally
                {
                    sw.Close();
                    fs.Close();

                } 

            }
        }
    }


}
