using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Step1
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection connection = new SqlConnection(); //연결 문자열 string 
            connection.ConnectionString = "server=10.10.14.51;database=chinookOrigin;uid=sa;pwd=1234";  //db ip주소 & 포트주소

            connection.Open();

            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "select * from Album where ArtistId < @ArtistId and Title like @Title + '%' ";             //오타를 못잡아냄!! & 효율성 (1000줄짜리 쿼리문에서는?) 

            SqlParameter p1 = new SqlParameter();       //p1 = artistIdparameter //  sqlparameter -> ref 형식 
            p1.ParameterName = "@ArtistId";
            p1.Value = 10;
            p1.SqlDbType = System.Data.SqlDbType.Int;                       //sqldbtype 변경 
            command.Parameters.Add(p1);                 //p1 파라미터를 추가

            SqlParameter p2 = new SqlParameter();
            p2.ParameterName = "@Title";
            p2.Value = "b";
            p2.SqlDbType = System.Data.SqlDbType.NVarChar;
            p2.Size = 50;
            command.Parameters.Add(p2);

            //동기(직렬적 처리) vs 비동기(병렬적 처리)
            SqlDataReader reader = command.ExecuteReader();  //sqldataReader객체의 reader

            while (reader.Read())        //read()-> bool 형 => while문 사용   true & false 
            {
                // int albumId = reader.GetInt32(0);        //컬럼의 순번을 호출 
                int albumId = (int)reader["AlbumId"];                  //인덱서를 사용하는법  - 형변환
                string title = (string)reader["Title"];                //####  is 연산자와 as(참조 o, 값 x) 연산자의 차이점? ####
                int artistId = (int)reader["ArtistId"];

                Console.WriteLine($"{albumId}\t{title}\t{artistId}");
            }

            connection.Close();
            /*
            using (SqlConnection connection2 = new SqlConnection())     //using 문을 쓰면 자동으로 close()를 호출하여 사용
            {
                connection2.ConnectionString = "";
                connection2.Open();
                //
                connection2.Dispose();      // 리소스 해제    Dispose가 있는 인터페이스 (using)의 사용-dispose 기능의 유무 
                //connection2.Close();
            }
            */

        }
    }

}
