
namespace Chinook.Data
{
    partial class Track : Entity
    {
        public override string ToText()
        {
            return Name;
        }

        public string GenreName { get; set; }
    }
}
