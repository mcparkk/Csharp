﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shutta
{
    //internal class Card
    public class Card
    {
        public Card(int no, bool isKwang, bool isSecretAgent) // SecretAgent = 암행어사
        {
            _no = no;
            IsKwang = isKwang;
            IsSecretAgent = isSecretAgent;
        }

        private int _no; // 자바의 기본 접근 지정자와 다름

        public int No
        {
            get
            {
                return _no;
            }
            //set
            //{
            //    // validation check
            //    if (value >= 1 && value <= 10)
            //        _no = value;
            //}
        }

        // 3.0 auto property (자동으로 기반이 되는 필드를 생성해 줌)
        public bool IsKwang { get; }
        public bool IsSecretAgent { get; }
        public override string ToString()
        {
            if (IsKwang)
                return _no + "K";
            else if (IsSecretAgent)
                return _no + "A";
            else
                return _no + "";
        }
    }
}
