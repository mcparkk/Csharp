using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Step4.Data
{
    public class AlbumData
    {
        public int GetCount()
        {
            throw new NotImplementedException();
        }

        public List<Album> GetAll()
        {
            throw new NotImplementedException();
        }

        public Album GetByPK(int albumId)
        {
            throw new NotImplementedException();
        }

        public string Insert(Album album)
        {
            throw new NotImplementedException();
        }

        public string Update(Album album)
        {
            throw new NotImplementedException();
        }

        public string Delete(Album album)
        {
            throw new NotImplementedException();
        }

        public int GetTrackCount(string keyword)
        {
            using (var context = new ChinookEntities())
            {
                context.Database.Log = PrintToDebug;

                var query = 
                    from x in context.Tracks
                    where x.Album.Title.Contains(keyword)
                    select x;

//                return query.ToList();
                return query.Count();
            }
        }

        private void PrintToDebug(string log)
        {
            Debug.WriteLine(log);
        }
    }
}
