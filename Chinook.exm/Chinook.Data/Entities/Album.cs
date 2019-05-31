namespace Chinook.Data
{
    partial class Album : Entity
    {
        public override string ToText()
        {
            return $"{Title} : {Artist}";
        }
    }
}
