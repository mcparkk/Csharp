﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chinook.Data
{
    public class AlbumData : EntityData<Album>
    {
        public Album GetByPK(int albumId)
        {
            using (ChinookEntities context = new ChinookEntities())
            {
                return context.Albums.FirstOrDefault(x => x.AlbumId == albumId);
            }
        }

        public void DeleteByPK(int albumId)
        {
            Album entity = GetByPK(albumId);

            if (entity == null)
                return;

            Delete(entity);
        }

        public List<Album> Search(string albumTitle, int minArtistId, int maxArtistId)
        {
            using (ChinookEntities context = new ChinookEntities())
            {
                IQueryable<Album> query = from x in context.Albums
                            select x;

                // lazy execution

                if (albumTitle != null)
                    query = query.Where(x => x.Title.Contains(albumTitle));

                if (minArtistId != 0)
                    query = query.Where(x => x.ArtistId >= minArtistId);

                if (maxArtistId != 0)
                    query = query.Where(x => x.ArtistId <= maxArtistId);

                return query.ToList();
            }

        }

        public List<Album> Search(string albumTitle, int? artistId)     //int? - nullable<int>
        {
            using (ChinookEntities context = new ChinookEntities())
            {
                IQueryable<Album> query = from x in context.Albums
                                          select x;

                // lazy execution

                if (string.IsNullOrEmpty(albumTitle) == false)
                    
                    query = query.Where(x => x.Title.Contains(albumTitle));

                if (artistId != null)
                    query = query.Where(x => x.ArtistId == artistId);



                return query.ToList();
            }

        }
    }
}
