using Chinook.Data.Entities;
using System.IO;

namespace Chinook.Data
{
    public partial class Artist : Entity
    {
        public byte[] Picture
        {
            get
            {
                int index = ArtistId % 5;
                string filePath = $@"Z:\D\Desktop\{index}.png";
                return File.ReadAllBytes(filePath);
            }
        }
    }
}
