using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ConsoleApp1
{
    class disconn
    {
        //static void Main(string[] args)
        //{
        //    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\visual basics practical\ConsoleApp1\ConsoleApp1\Database2.mdf;Integrated Security=True");
        //    //InsertData(con);
        //    //UpdateData(con);
        //    //SelectData(con);
        //    Deletedata(con);
        //    Console.ReadLine();
        //}

        static void SelectData(SqlConnection con)
        {
            string q = "select * from student";
            SqlDataAdapter da = new SqlDataAdapter(q, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count != 0)
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    Console.WriteLine(ds.Tables[0].Rows[i]["id"].ToString()
                      + "\t" + ds.Tables[0].Rows[i]["name"].ToString()
                      + "\t" + ds.Tables[0].Rows[i]["phonenumber"].ToString()
                      + "\t" + ds.Tables[0].Rows[i]["age"].ToString()
                      + "\t" + ds.Tables[0].Rows[i]["subject"].ToString());
                }

            }
            else
                Console.WriteLine("no rows found");
        }

        static void InsertData(SqlConnection con)
        {
            Console.WriteLine("ENTER NAME: ");
            string name = Console.ReadLine();
            //int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ENTER phonenumber: ");
            string phonenumber = Console.ReadLine();
            Console.WriteLine("age: ");
            string age = Console.ReadLine();
            Console.WriteLine("enter subject");
            string subject = Console.ReadLine();
            SqlDataAdapter adp = new SqlDataAdapter("select * from student", con);
            SqlCommandBuilder cmb = new SqlCommandBuilder(adp);
            DataSet ds = new DataSet();
            adp.Fill(ds, "student");
            DataRow rw = ds.Tables[0].NewRow();

            rw[1] = name;
            rw[2] = phonenumber;
            rw[3] = age;
            rw[4] = subject;

            ds.Tables[0].Rows.Add(rw);

            int i = adp.Update(ds.Tables[0]);
            if (i == 1)
                Console.Write(i + " New row added.");
            else
                Console.Write("Insertion Failed.");
        }

        static void UpdateData(SqlConnection con)
        {
            Console.WriteLine("enter the row index which you want to update");
            int k = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("name:");
            string name = Console.ReadLine();
            Console.WriteLine("PH_NO.");
            string phonenumber = Console.ReadLine();
            Console.WriteLine("AGE:");
            string age = Console.ReadLine();
            Console.WriteLine("SUBJECT:");
            string subject = Console.ReadLine();
            SqlDataAdapter adp = new SqlDataAdapter("select * from student", con);
            SqlCommandBuilder cmb = new SqlCommandBuilder(adp);
            DataSet ds = new DataSet();
            adp.Fill(ds, "student");
            DataRow rw = ds.Tables[0].Rows[k];
            rw["name"] = name;
            rw["phonenumber"] = phonenumber;
            rw["age"] = age;
            rw["subject"] = subject;
            int i = adp.Update(ds.Tables[0]);
            if (i == 1)
                Console.Write(i + " row updated.");
            else
                Console.Write("updation Failed.");


        }


        static void Deletedata(SqlConnection con)
        {
            Console.WriteLine("enter the id to be deleted");
            int id = Convert.ToInt32(Console.ReadLine());
            SqlDataAdapter adp = new SqlDataAdapter("Select * from student", con);
            SqlCommandBuilder cmb = new SqlCommandBuilder(adp);
            DataSet ds = new DataSet();
            adp.Fill(ds, "student");
            DataRow rw = ds.Tables[0].Rows[id];
            rw["ID"] = id;
            rw.Delete();
            int i = adp.Update(ds.Tables[0]);
            if (i == 1)
                Console.Write(i + "row deleted.");
            else
                Console.Write("deletion Failed.");


        }

    }
}



