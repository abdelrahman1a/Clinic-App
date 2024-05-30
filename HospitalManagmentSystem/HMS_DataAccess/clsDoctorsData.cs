using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Data;
using System.Reflection;

namespace HMS_DataAccess
{
    public class clsDoctorsData
    {

        public static int AddNewDoctor(string DoctorName, int DocExp, string DoctorPassword, string DoctorSpecialization)
        {
            int DoctorID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO Doctors(DocName ,DocExp , DocPassword , DoctorSpecialization)
                            Values(@DoctorName , @DocExp ,@DoctorPassword , @DoctorSpecialization)
                            SELECT SCOPE_IDENTITY()";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@DoctorName", DoctorName);
            command.Parameters.AddWithValue("@DocExp", DocExp);
            command.Parameters.AddWithValue("@DoctorPassword", DoctorPassword);
            command.Parameters.AddWithValue("@DoctorSpecialization", DoctorSpecialization);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    DoctorID = insertedID;
                }
            }

            catch (Exception ex)
            {
                clsLogError.LogError("DataBaseError", clsLogError.enStatus.Error);

            }

            finally
            {
                connection.Close();
            }
            return DoctorID;

        }

        public static bool UpdateDoctor(int DoctorID, string DoctorName, int DocExp, string DoctorPassword, string DoctorSpecialization)
        {
            int RowsAffected = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = @"UPDATE DOCTORS 
                             SET DocName = @DoctorName, 
                                 DocExp = @DocExp, 
                                 DocPassword = @DoctorPassword, 
                                 DoctorSpecialization = @DoctorSpecialization
                             WHERE DocID = @DoctorID";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@DoctorID", DoctorID);
                    command.Parameters.AddWithValue("@DoctorName", DoctorName);
                    command.Parameters.AddWithValue("@DocExp", DocExp);
                    command.Parameters.AddWithValue("@DoctorPassword", DoctorPassword);
                    command.Parameters.AddWithValue("@DoctorSpecialization", DoctorSpecialization);

                    connection.Open();
                    RowsAffected = command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                clsLogError.LogError("DataBaseError", clsLogError.enStatus.Error);
                // Handle exception or rethrow as needed
            }

            return RowsAffected > 0;
        }


        public static DataTable GetAllDoctors()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Select DocID , DocName , DocExp , DoctorSpecialization from Doctors";
            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        dt.Load(reader);
                    }

                    reader.Close();
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                connection.Close();
                clsLogError.LogError("DataBaseError", clsLogError.enStatus.Error);
            }
            return dt;
        }

        public static bool Find(int DoctorID, ref string DoctorName, ref int DocExp, ref string DoctorPassword, ref string DoctorSpecialization)
        {
            bool isfound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"Select * from Doctors 
                                Where DocID = @DoctorID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@DoctorID", DoctorID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    isfound = true;
                    DoctorName = (string)reader["DocName"];
                    DocExp = (int)reader["DocExp"];
                    DoctorPassword = (string)reader["DocPassword"];
                    DoctorSpecialization = (string)reader["DoctorSpecialization"];
                }
                else
                {
                    isfound = false;
                }

            }
            catch (Exception ex)
            {
                isfound = false;
                clsLogError.LogError("DataBaseError", clsLogError.enStatus.Error);
            }
            finally
            {
                connection.Close();
            }
            return isfound;
        }


        public static bool DeleteDoctor(int DoctorID)
        {
            int RowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Delete From Doctors
                              Where DocID =@DoctorID ";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@DoctorID", DoctorID);

            try
            {
                connection.Open();

                RowsAffected = command.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
                clsLogError.LogError("DataBaseError", clsLogError.enStatus.Error);

            }

            finally
            {
                connection.Close();
            }
            return (RowsAffected > 0);
        }

        public static bool CheckDoctorName(string DocName)
        {
            bool isfound = false;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = @"Select isfound=1 from Doctors Where DocName = @DoctorName";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@DoctorName", DocName);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        isfound = true;
                    }
                    else
                    {
                        isfound = false;
                    }
                }
                catch (Exception ex)
                {
                    clsLogError.LogError("DataBase Error", clsLogError.enStatus.Error);
                }

               
            }
            return isfound;


        }


        public static bool CheckDoctorPassword(string DocPassword)
        {
            bool isfound = false;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = @"Select isfound=1 from Doctors Where DocPassword = @DocPassword";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@DocPassword", DocPassword);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        isfound = true;
                    }
                    else
                    {
                        isfound = false;
                    }
                }
                catch (Exception ex)
                {
                    clsLogError.LogError("DataBase Error", clsLogError.enStatus.Error);
                }

           
            }
            return isfound;
        }

    }
}
