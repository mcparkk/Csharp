namespace Chinook.Data
{
    public class DataRepository
    {
        static DataRepository()
        {
            Album = new AlbumData();
            Artist = new ArtistData();
        }

        public static ArtistData Artist { get; }

        public static AlbumData Album { get; }
    }
}
