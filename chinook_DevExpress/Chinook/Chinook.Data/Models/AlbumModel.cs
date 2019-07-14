using Newtonsoft.Json;

namespace Chinook.Data.Models
{
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public class AlbumModel
    {
        [JsonProperty]
        public string Letter { get; set; }

        public int Count { get; set; }

        public override string ToString()
        {
            return $"{Letter} / {Count}";
        }
    }
}
