using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace LibraryManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connectionString =
                "Server=LAPTOP-SSRF91E5\\SQLEXPRESS;" +"Database=LibraryDB;" +"Integrated Security=True;" +"TrustServerCertificate=True;";

            try
            {
                GetAllBooks(connectionString);
                InsertBook(connectionString, "Animal Farm", 2, 1945);
                UpdateBook(connectionString, 1, "Harry Potter Updated", 1, 1998);
                DeleteBook(connectionString, 3);
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: " + ex.Message);
            }

            Console.ReadLine();
        }

        // ================= GET ALL BOOKS =================
        static void GetAllBooks(string connectionString)
        {
            Console.WriteLine("sp_GetAllBooks Called");

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter =
                    new SqlDataAdapter("sp_GetAllBooks", connection);
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;

                DataSet ds = new DataSet();
                adapter.Fill(ds, "Books");

                DataTable table = ds.Tables["Books"];

                foreach (DataRow row in table.Rows)
                {
                    Console.WriteLine(
                        $"BookId: {row["BookId"]}, " +
                        $"Title: {row["Title"]}, " +
                        $"Author: {row["AuthorName"]}, " +
                        $"Year: {row["PublishedYear"]}"
                    );
                }

                Console.WriteLine();
            }
        }

        // ================= INSERT BOOK =================
        static void InsertBook(string connectionString, string title, int authorId, int year)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.InsertCommand = new SqlCommand("sp_InsertBook", connection);
                adapter.InsertCommand.CommandType = CommandType.StoredProcedure;

                adapter.InsertCommand.Parameters.AddWithValue("@Title", title);
                adapter.InsertCommand.Parameters.AddWithValue("@AuthorId", authorId);
                adapter.InsertCommand.Parameters.AddWithValue("@PublishedYear", year);

                connection.Open();
                adapter.InsertCommand.ExecuteNonQuery();
                connection.Close();

                Console.WriteLine("Book inserted successfully.\n");
            }
        }

        // ================= UPDATE BOOK =================
        static void UpdateBook(string connectionString, int bookId, string title, int authorId, int year)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.UpdateCommand = new SqlCommand("sp_UpdateBook", connection);
                adapter.UpdateCommand.CommandType = CommandType.StoredProcedure;

                adapter.UpdateCommand.Parameters.AddWithValue("@BookId", bookId);
                adapter.UpdateCommand.Parameters.AddWithValue("@Title", title);
                adapter.UpdateCommand.Parameters.AddWithValue("@AuthorId", authorId);
                adapter.UpdateCommand.Parameters.AddWithValue("@PublishedYear", year);

                connection.Open();
                adapter.UpdateCommand.ExecuteNonQuery();
                connection.Close();

                Console.WriteLine("Book updated successfully.\n");
            }
        }

        // ================= DELETE BOOK =================
        static void DeleteBook(string connectionString, int bookId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.DeleteCommand = new SqlCommand("sp_DeleteBook", connection);
                adapter.DeleteCommand.CommandType = CommandType.StoredProcedure;

                adapter.DeleteCommand.Parameters.AddWithValue("@BookId", bookId);

                connection.Open();
                adapter.DeleteCommand.ExecuteNonQuery();
                connection.Close();

                Console.WriteLine("Book deleted successfully.\n");
            }
        }
    }
}