namespace Chinook.Data
{
    partial class Track : Entity
    {
        public override string ToText()
        {
            return Name;
        }

        public string AlbumTitle {get; internal set;}

        public string ArtistName {get; internal set;}

        public string MediaTypeName {get; internal set;}

        public string GenreName {get; internal set;}

        public string Length
        {
            get
            {
                int value = Milliseconds / 1000; // 343
                return $"{value / 60}'{value % 60}''";
            }
        }
    }
}
