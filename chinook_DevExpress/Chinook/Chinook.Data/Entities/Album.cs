using Chinook.Data.Entities;
using Chinook.Data.Models;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Chinook.Data
{
    // Buddy Class
    partial class AlbumBuddy
    {
        [JsonProperty]
        public int AlbumId { get; set; }

        [JsonProperty]
        public string Title { get; set; }

        [JsonProperty]
        public int ArtistId { get; set; }
    }


    [JsonObject(MemberSerialization.OptIn)]
    [MetadataType(typeof(AlbumBuddy))]
    partial class Album : Entity
    {
        public string ArtistName { get; set; }

        public string Name
        {
            get
            {
                return Title;
            }
        }
    }
}
