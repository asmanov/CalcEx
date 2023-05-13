using System.Data.SqlClient;

string connStr = "Server=localhost\\SQLEXPRESS;" +
                "Database=UserDB;" +
                "Trusted_Connection=True;" +
                "TrustServerCertificate=True;";


int id = 1;
Console.WriteLine("Enter login");
string log = Console.ReadLine();
Console.WriteLine("Enter parol");
string pas = Console.ReadLine();
string commandText = @$"INSERT INTO [Registr]([id],[login],[pasword]) VALUES ({id},'{log}', '{pas}')";
id++;

using (SqlConnection conn = new SqlConnection(connStr))
{
    conn.Open();
    SqlCommand command = new SqlCommand(commandText, conn);
    int count = command.ExecuteNonQuery();
    if (count > 0)
    {
        Console.WriteLine(conn.State);
    }
    else Console.WriteLine("Ne ok!");

}