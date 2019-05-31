namespace Chinook.Data
{
    public class DataRepository
    {
        static DataRepository()
        {
            Album = new AlbumData();
            Artist = new ArtistData();
            Track = new TrackData();
        }

        public static ArtistData Artist { get; }

        public static AlbumData Album { get; }

        public static TrackData Track { get; }
    }
}
