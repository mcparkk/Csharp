using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericExample
{
    class MonsterList
    {   

        private List<Monster> _monsterList = new List<Monster>();
        int i = 0;
        public void AddList(Monster monster)
        {
            _monsterList.Add(monster);
        }

        public string GetList(Monster monster)
        {
            string gettedMonster = _monsterList[i].ToString();
            i++;
            return gettedMonster;
        }
    }
}
