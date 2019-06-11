using System;

namespace GenericDemo
{
    class Marine : IComparable<Marine>, Unit
    {
        public Marine(int hp, string name)
        {
            HP = hp;
            Name = name;
        }

        public int HP { get; set; }

        public string Name { get; set; }

        public override string ToString()
        {
            return $"HP : {HP}, Name : {Name}";
        }

        public int CompareTo(Marine other)
        {
            //if (this.HP > other.HP)
            //    return 1;
            //else if (HP < other.HP)
            //    return -1;
            //else
            //    return 0;

            return HP - other.HP;
            //return HP.CompareTo(other.HP);
            //return Name.CompareTo(other.Name);
        }

        public string SayName()
        {
            return Name;
        }

        public override string FullName
        {
            get
            {
                return Name;
            }
        }
    }
}
