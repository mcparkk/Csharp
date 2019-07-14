using MyLibrary;
using System.Data.Entity;
using System.Linq;

namespace Chinook.Data
{
    public class TrackData : EntityData<Track>
    {
        internal TrackData()
        {
        }

        public int GetCountByAlbumId(int albumId)
        {
            using (ChinookEntities context = 
                DbContextFactory.Create<ChinookEntities>())
            {
                var query = from x in context.Tracks
                            where x.AlbumId < 10
                            select x;

                return query.Count();
            }
        }
    }
}
