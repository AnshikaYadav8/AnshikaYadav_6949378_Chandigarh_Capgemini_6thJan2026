using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace UniversityManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                string connectionString = "Server=LAPTOP-SSRF91E5\\SQLEXPRESS;" + "Database=UniversityDB;" + "Integrated Security=True;" + "TrustServerCertificate=True;";

                // Get All Students
                GetAllStudents(connectionString);

                // Get Student By ID
                GetStudentByID(connectionString, 1);

                // Create Student
                CreateStudent(
                    connectionString,
                    "David",
                    "Miller",
                    "david@uni.com",
                    1
                );

                // Update Student
                UpdateStudent(
                    connectionString,
                    1,
                    "Alice",
                    "Johnson",
                    "alice_new@uni.com",
                    2
                );

                // Delete Student
                DeleteStudent(connectionString, 3);
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: " + ex.Message);
            }

            Console.ReadLine();
        }

        // ================= GET ALL STUDENTS =================
        static void GetAllStudents(string connectionString)
        {
            Console.WriteLine("sp_GetAllStudents Stored Procedure Called");

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command =
                    new SqlCommand("sp_GetAllStudents", connection);
                command.CommandType = CommandType.StoredProcedure;

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Console.WriteLine(
                        $"StudentID: {reader["StudentId"]}, " +
                        $"Name: {reader["FirstName"]} {reader["LastName"]}, " +
                        $"Email: {reader["Email"]}, " +
                        $"DeptID: {reader["DeptId"]}"
                    );
                }

                reader.Close();
                connection.Close();
            }
        }

        // ================= GET STUDENT BY ID =================
        static void GetStudentByID(string connectionString, int studentID)
        {
            Console.WriteLine("sp_GetStudentById Stored Procedure Called");

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command =
                    new SqlCommand("sp_GetStudentById", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@StudentId", studentID);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Console.WriteLine(
                        $"Student: {reader["FirstName"]} {reader["LastName"]}, " +
                        $"Email: {reader["Email"]}, " +
                        $"DeptID: {reader["DeptId"]}"
                    );
                }

                reader.Close();
                connection.Close();
            }
        }

        // ================= CREATE STUDENT =================
        static void CreateStudent(
            string connectionString,
            string firstName,
            string lastName,
            string email,
            int deptId)
        {
            Console.WriteLine("sp_InsertStudent Stored Procedure Called");

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command =
                    new SqlCommand("sp_InsertStudent", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@FirstName", firstName);
                command.Parameters.AddWithValue("@LastName", lastName);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@DeptId", deptId);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

                Console.WriteLine("Student created successfully.\n");
            }
        }

        // ================= UPDATE STUDENT =================
        static void UpdateStudent(
            string connectionString,
            int studentID,
            string firstName,
            string lastName,
            string email,
            int deptId)
        {
            Console.WriteLine("sp_UpdateStudent Stored Procedure Called");

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command =
                    new SqlCommand("sp_UpdateStudent", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@StudentId", studentID);
                command.Parameters.AddWithValue("@FirstName", firstName);
                command.Parameters.AddWithValue("@LastName", lastName);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@DeptId", deptId);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

                Console.WriteLine("Student updated successfully.\n");
            }
        }

        // ================= DELETE STUDENT =================
        static void DeleteStudent(string connectionString, int studentID)
        {
            Console.WriteLine("sp_DeleteStudent Stored Procedure Called");

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command =
                    new SqlCommand("sp_DeleteStudent", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@StudentId", studentID);

                connection.Open();
                int result = command.ExecuteNonQuery();

                if (result > 0)
                    Console.WriteLine("Student deleted successfully.\n");
                else
                    Console.WriteLine("Student not found.\n");

                connection.Close();
            }

        }
    }
}

