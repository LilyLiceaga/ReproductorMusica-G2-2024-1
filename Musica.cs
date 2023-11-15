
namespace ReproductorMusica_G2_2024_1
{
    public class Musica
    {
        #region Atributos
        private string artista;
        private string album;
        private string titulo;
        private short duracion;
        #endregion

        #region Constructor
        public Musica(string artista, string titulo, string album)
        {
            this.artista = artista;
            this.album = album;
            this.titulo = titulo;
        }

        public Musica(string artista, string album, string titulo, short duracion)
        {
            Artista = artista;
            Album = album;
            Titulo = titulo;
            Duracion = duracion;
        }
        #endregion

        #region Propiedades
        public string Artista { get => artista; set => artista = value; }
        public string Album { get => album; set => album = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public short Duracion { get => duracion; set => duracion = value; }
        #endregion



    }
}
