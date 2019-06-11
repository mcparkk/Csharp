﻿namespace Chinook.Data
{
    public class DataRepository
    {
        static DataRepository()
        {
            Album = new AlbumData();
            Artist = new ArtistData();
            Track = new TrackData();
            Invoice = new InvoiceData();
        }

        public static ArtistData Artist { get; }

        public static AlbumData Album { get; }

        public static TrackData Track { get; }

        public static InvoiceData Invoice { get; }
    }
}
