using System;
using Npgsql;

namespace DB_manipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            var cs = "Host=localhost;Username=postgres;" +
                "Password=P_ost38246_gre7s_ql;Database=VARM";

            using var con = new NpgsqlConnection(cs);
            con.Open();

            using var cmd = new NpgsqlCommand();
            cmd.Connection = con;

            //cmd.CommandText = "INSERT INTO \"Player\"(name, id, password) VALUES('First_Player',52642, B'101')";
            //cmd.ExecuteNonQuery();
            cmd.CommandText = "INSERT INTO \"Player\"(name, id, password) VALUES('Second_Player',11111, B'101')";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "INSERT INTO \"Player\"(name, id, password) VALUES('Third_Player',22222, B'101')";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "INSERT INTO \"Player\"(name, id, password) VALUES('Fourth_Player',33333, B'101')";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "INSERT INTO \"Player\"(name, id, password) VALUES('Fifth_Player',44444, B'101')";
            cmd.ExecuteNonQuery();

            cmd.CommandText = "INSERT INTO \"Games\"(title, g_id) VALUES('Tic_Tac_Toe',911)";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "INSERT INTO \"Games\"(title, g_id) VALUES('Tic_Tac_Toe',922)";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "INSERT INTO \"Games\"(title, g_id) VALUES('Tic_Tac_Toe',933)";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "INSERT INTO \"Games\"(title, g_id) VALUES('Tic_Tac_Toe',944)";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "INSERT INTO \"Games\"(title, g_id) VALUES('Tic_Tac_Toe',955)";
            cmd.ExecuteNonQuery();

            cmd.CommandText = "INSERT INTO \"Records\"(id, g_id, record) VALUES(52642,911,100)";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "INSERT INTO \"Records\"(id, g_id, record) VALUES(11111,922,200)";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "INSERT INTO \"Records\"(id, g_id, record) VALUES(22222,933,300)";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "INSERT INTO \"Records\"(id, g_id, record) VALUES(33333,944,400)";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "INSERT INTO \"Records\"(id, g_id, record) VALUES(44444,955,200)";
            cmd.ExecuteNonQuery();


            Console.WriteLine("Tables created");


            string sql = "SELECT \"Player\".name, \"Player\".id, \"Games\".title, \"Records\".record from \"Records\""+
                "join \"Player\" on (\"Player\".id = \"Records\".id) join \"Games\" on (\"Games\".g_id = \"Records\".g_id)";
               
            using var cmd_ = new NpgsqlCommand(sql, con);

            using NpgsqlDataReader rdr = cmd_.ExecuteReader();

            while (rdr.Read())
            {
                Console.WriteLine("{0} {1} {2} {3}", rdr.GetString(0), rdr.GetInt32(1), rdr.GetString(2), rdr.GetInt32(3));
            }
        }
    }
}
