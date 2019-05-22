using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitOperation
{
    class Program
    {
        static void Main(string[] args)
        {
            // S + A + D
            int s01 = 0x0001; // 0000 0000 0000 0001
            int s02 = 0x0002; // 0000 0000 0000 0010
            int s03 = 0x0004; // 0000 0000 0000 0100
            int s04 = 0x0008; // 0000 0000 0000 1000
            int s05 = 0x0010; // 0000 0000 0001 0000
            int s06 = 0x0020; // 0000 0000 0010 0000
            int s07 = 0x0040;
            int s08 = 0x0080;
            int s09 = 0x0100;
            int s10 = 0x0200;
            int s11 = 0x0400;
            int s12 = 0x0800;
            int s13 = 0x1000;
            int s14 = 0x2000;
            int s15 = 0x4000;
            int s16 = 0x8000;

            //int men = 0x0091;  // 0000 0000 1001 0001
            int men = s01 | s05 | s08;
            int smoker = s04 | s12 | s14;


            int i = 0x0;

            // i    : 0000 0000 0000 0000
            // s01  : 0000 0000 0000 0001
            //      : 0000 0000 0000 0001
            // s05  : 0000 0000 0001 0000
            // i    : 0000 0000 0001 0001
            // i    : 0000 0000 0011 0001

            i = i | s01; // 1번 출석
            i = i | s05; // 5번 출석
            i = i | s06; // 6번 출석



            bool isS01 = (i & s01) == s01;
            // i    : 0000 0000 0011 0001
            // s01  : 0000 0000 0000 0001
            // =    : 0000 0000 0000 0001

            bool areAllMen = (i & men) == men;
            bool areAllSmoker = (i & smoker) != 0;



            bool[] checks = new bool[16];
            checks[0] = true;
            checks[1] = true;
            checks[4] = true;

            if (checks[3] && checks[11] && checks[13])
                ;

        }
    }
}
