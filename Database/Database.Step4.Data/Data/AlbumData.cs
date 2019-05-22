using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Database.Step4.Data
{
    public class AlbumData
    {
        private static ChinookEntities Createcontext()
        {
            ChinookEntities context = new ChinookEntities();
            context.Database.Log = PrintToConsoleWindow;
            return context;
        }
        public int GetCount()
        {
            using (var context = Createcontext())
            {
                return context.Albums.Count();
            }
        }

        public List<Album> GetAll()
        {
            using (var context = Createcontext())
            {
                return context.Albums.ToList();
            }
        }

        public Album GetByPK(int albumId)
        {
            using (var context = Createcontext())
            {
                return context.Albums.FirstOrDefault(x => x.AlbumId == albumId);
            }
        }

        public static void Insert(Album album)
        {
            using (var context = Createcontext())
            {
                context.Entry(album).State = EntityState.Added;

                context.SaveChanges();
            }
        }

        public static void Update(Album album)
        {
            using (var context = Createcontext())
            {
                context.Entry(album).State = EntityState.Modified;

                context.SaveChanges();
            }
        }

        public static void Delete(Album album)
        {
            using (var context = Createcontext())
            {
                context.Entry(album).State = EntityState.Deleted;

                context.SaveChanges();
            }
        }

        //public int AlbumTrack(string albumName)
        //{
        //    using (var context = new ChinookEntities())
        //    {
        //        var AlbumQuery = from x in context.Albums
        //                         where x.Title.Equals(albumName)
        //                         select x.AlbumId;

        //        var millisec = from x in context.Tracks
        //                     where AlbumQuery.Equals(x.AlbumId)
        //                     select x.Milliseconds;

        //        int totalMilliSeconds = 0;
        //        totalMilliSeconds += millisec.FirstOrDefault();

        //        return totalMilliSeconds;
        //    }
        //}

        public int GetTrackTime(string albumName)
        {
            using (var context = new ChinookEntities())
            {
                IQueryable<int> albumQuery = from x in context.Albums
                                 where x.Title == albumName
                                 select x.AlbumId;

                int firstAlbumId = albumQuery.FirstOrDefault();

                if (firstAlbumId == 0)
                    return -1;

                IQueryable<int> trackSecondQuery = from x in context.Tracks
                                       where x.AlbumId == firstAlbumId
                                       select x.Milliseconds;


                List<int> albumSecond = trackSecondQuery.ToList();
                int tracknum = albumSecond.Count;
               

                var resultSecond = albumSecond.Sum();

                return resultSecond;
            }

        }   
        public static int GetTrackCount(int tracknum)
        {
            return tracknum;
        }

        //int milliseconds = 0;
        //foreach (int millisecond in trackMilliseconds)
        //{
        //    milliseconds += millisecond;
        //}
        private static void PrintToConsoleWindow(string log)
        {
            Console.WriteLine(log);
        }
    }
}
