using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Linq;
using MyLibrary;

namespace Chinook.Data
{
    public class ArtistData : EntityData<Artist>
    {
        public override List<Artist> GetAll(Expression<Func<Artist, bool>> predicate = null)
        {
            using (ChinookEntities context = DbContextFactory.Create<ChinookEntities>())
            {
                var query = from x in context.Artists
                            orderby x.Name
                            select x;
                
                return query.ToList();
            }
        }
    }
}
