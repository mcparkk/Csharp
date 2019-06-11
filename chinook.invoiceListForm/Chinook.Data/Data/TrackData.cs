using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chinook.Data
{
    public class TrackData : EntityData<Track>
    {
        public Track GetByPK(int trackId)
        {
            using (ChinookEntities context = new ChinookEntities())
            {
                return context.Tracks.FirstOrDefault(x => x.TrackId == trackId);
            }
        }

        public void DeleteByPK(int trackId)
        {
            Track entity = GetByPK(trackId);

            if (entity == null)
                return;

            Delete(entity);
        }

        public List<Track> Search(string trackName, int? artistId, int? albumId, decimal? minUnitPrice, decimal? maxUnitPrice)
        {
            // tuple
            // anonymous class
            //var m1 = new { HP = 1, X = 2, Y = 3};
            //Console.WriteLine(m1.HP);
            //Console.WriteLine(m1.X);

            using (ChinookEntities context = new ChinookEntities())
            {
                context.Database.Log = x => Debug.WriteLine(x);

                var artists = context.Artists.ToDictionary(x => x.ArtistId, x => x.Name);
                var albums = context.Albums.ToDictionary(x => x.AlbumId, x => x.Title);
                var genres = context.Genres.ToDictionary(x => x.GenreId, x => x.Name);
                var mediaTypes = context.MediaTypes.ToDictionary(x => x.MediaTypeId, x => x.Name);

                var query = from x in context.Tracks
                            select new
                            {
                                ArtistId = x.Album.ArtistId,
                                Track = x
                            };

                if (trackName.IsNullOrEmpty() == false)
                    query = query.Where(x => x.Track.Name.Contains(trackName));

                if (albumId != null)
                    query = query.Where(x => x.Track.AlbumId == albumId.Value);

                if (minUnitPrice.HasValue)
                    query = query.Where(x => x.Track.UnitPrice >= minUnitPrice);

                if (maxUnitPrice.HasValue)
                    query = query.Where(x => x.Track.UnitPrice <= maxUnitPrice);

                var list = query.ToList();

                foreach (var x in list)
                {
                    if (x.Track.AlbumId.HasValue)
                        x.Track.AlbumTitle =  albums[x.Track.AlbumId.Value];
                    else
                        x.Track.AlbumTitle = string.Empty;

                    if (x.Track.GenreId.HasValue)
                        x.Track.GenreName = genres[x.Track.GenreId.Value];
                    else
                        x.Track.GenreName = string.Empty;

                    x.Track.MediaTypeName = mediaTypes[x.Track.MediaTypeId];

                    x.Track.ArtistName = artists[x.ArtistId];
                }

                List<int> intList = new List<int>{ 3,5,1,2};
                List<string> stringList = intList.ConvertAll(x => x.ToString()); // "3" "5" "1" "2"

                return list.ConvertAll(x => x.Track);

                //List<Track> tracks = new List<Track>();
                //foreach (var x in list)
                //    tracks.Add(x.Track);

                //return tracks;
            }
        }

        public List<Track> Search2(string trackName, int? artistId, int? albumId, decimal? minUnitPrice, decimal? maxUnitPrice)
        {
            using (ChinookEntities context = new ChinookEntities())
            {
                context.Database.Log = x => Debug.WriteLine(x);

                var query = from x in context.Tracks
                            select new 
                            {
                                ArtistName = x.Album.Artist.Name,
                                GenreName = x.Genre.Name,
                                AlbumTitle = x.Album.Title,
                                MediaTypeName = x.MediaType.Name,
                                Track = x
                            };

                if (trackName.IsNullOrEmpty() == false)
                    query = query.Where(x => x.Track.Name.Contains(trackName));

                if (albumId != null)
                    query = query.Where(x => x.Track.AlbumId == albumId.Value);

                if (minUnitPrice.HasValue)
                    query = query.Where(x => x.Track.UnitPrice >= minUnitPrice);

                if (maxUnitPrice.HasValue)
                    query = query.Where(x => x.Track.UnitPrice <= maxUnitPrice);

                var list = query.ToList();

                foreach (var x in list)
                {
                    x.Track.ArtistName = x.ArtistName;
                    x.Track.AlbumTitle = x.AlbumTitle;
                    x.Track.GenreName = x.GenreName;
                    x.Track.MediaTypeName = x.MediaTypeName;
                }

                return list.ConvertAll(x => x.Track);

                //List<Track> tracks = new List<Track>();
                //foreach (var x in list)
                //    tracks.Add(x.Track);

                //return tracks;
            }
        }
    }

    public static class Extension
    {
        public static bool IsNullOrEmpty(this string value)
        {
            return string.IsNullOrEmpty(value);
        }
    }
}














