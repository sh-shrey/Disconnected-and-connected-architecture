using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace ConsoleApp1
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    //SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\visual basics practical\ConsoleApp1\ConsoleApp1\Database2.mdf;Integrated Security=True");
        //    //Con.Open();
        //    Delete();
        //   Insert();
        //   Update();

        //    Console.ReadKey();
        //}
        //    static void Insert()
        //    {
        //        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\visual basics practical\ConsoleApp1\ConsoleApp1\Database2.mdf;Integrated Security=True");
        //        Console.WriteLine("ENTER NAME: ");
        //        string name = Console.ReadLine();
        //        //int id = Convert.ToInt32(Console.ReadLine());
        //        Console.WriteLine("ENTER EMAILID: ");
        //        string phonenumber = Console.ReadLine();
        //        Console.WriteLine("age: ");
        //        string age = Console.ReadLine();
        //        Console.WriteLine("enter subject");
        //        string subject = Console.ReadLine();
        //        Con.Open();
        //        string q = " insert into student (name,phonenumber,age,subject) values('"+name+"','"+phonenumber+"','"+age+"','"+subject+"')";
        //        SqlCommand cmd = new SqlCommand(q, Con);
        //        int i = cmd.ExecuteNonQuery();
        //        Con.Close();
        //        if(i==1)
        //        {
        //            Console.WriteLine(i + "record inserted");
        //        }
        //        else
        //        {
        //            Console.WriteLine();
        //        }
        //    }
        //    static void Delete()
        //    {
        //        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\visual basics practical\ConsoleApp1\ConsoleApp1\Database2.mdf;Integrated Security=True");
        //        Console.WriteLine("ENTER the row you want to delete ");
        //        int id = Convert.ToInt32(Console.ReadLine());
        //        Con.Open();
        //        string q = " delete from student where id=("+id+")";
        //        SqlCommand cmd = new SqlCommand(q, Con);
        //        int i = cmd.ExecuteNonQuery();
        //        Con.Close();
        //        if (i == 1)
        //        {
        //            Console.WriteLine(i + "record deleted");
        //        }
        //        else
        //        {
        //            Console.WriteLine();
        //        }
        //    }
        //    static void Update()
        //    {
        //        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\visual basics practical\ConsoleApp1\ConsoleApp1\Database2.mdf;Integrated Security=True");
        //        Console.WriteLine("enter the value to be inserted");
        //        string subject = Console.ReadLine();
        //        Console.WriteLine("enter id in which you have to insert the values");
        //        int id = Convert.ToInt32(Console.ReadLine());
        //        Con.Open();
        //        string q = "update student set subject=('"+subject+"') where id=("+id+")";
        //        SqlCommand cmd = new SqlCommand(q, Con);
        //        int i = cmd.ExecuteNonQuery();
        //        Con.Close();
        //        if(i==1)
        //        {
        //            Console.WriteLine(i + "record updated");
        //        }
        //        else
        //        {
        //            Console.WriteLine();
        //        }
        //    }
        //}
    }
}

    

