using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chinook.Data
{
    public class TrackData : EntityData<Track>
    {
        //public List<Track> GetAllOrderByName()
        //{
        //    using (ChinookEntities context = new ChinookEntities())
        //    {
        //        var query = from x in context.Albums
        //                    orderby x.AlbumId
        //                    select x;

        //        return query.ToList();
        //    }
        //}
        //public List<Track> GetTrackInfo()
        //{
        //    using(ChinookEntities context = new ChinookEntities())
        //    {
        //        List<Track> query = from x in context.Genres
        //                            orderby x.na
        //        return query.ToList();
        //    }
        //}
    }
}
