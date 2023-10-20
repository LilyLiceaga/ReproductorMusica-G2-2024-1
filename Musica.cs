
namespace ReproductorMusica_G2_2024_1
{
    public class Musica
    {
        #region Atributos
        private string artista;
        private string album;
        private string titulo;
        #endregion

        #region Constructor
        public Musica(string artista, string titulo, string album)
        {
            this.artista = artista;
            this.album = album;
            this.titulo = titulo;
        }
        #endregion

        #region Propiedades
        public string Artista { get => artista; set => artista = value; }
        public string Album { get => album; set => album = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        #endregion



    }
}
