namespace Chinook.Data
{
    partial class Artist : Entity
    {
        public override string ToText()
        {
            return $"{ArtistId}:{Name}";
        }
    }
}
