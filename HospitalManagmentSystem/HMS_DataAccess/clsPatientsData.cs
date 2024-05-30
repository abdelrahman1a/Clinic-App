using System;
using System.Data;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.IO;

namespace HMS_DataAccess
{
    public class clsPatientsData
    {
        public static int AddNewpatient(string patName, string PatAddress, int patAge, string PatGender, string PatDisease, string BloodGroup)
        {
            int insertedid = -1;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                SqlCommand command = new SqlCommand("sp_ADDNewPatient", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@PatName", patName);
                command.Parameters.AddWithValue("@PatAddress", PatAddress);
                command.Parameters.AddWithValue("@PatAge", patAge);
                command.Parameters.AddWithValue("@PatGender", PatGender);
                command.Parameters.AddWithValue("@PatDisease", PatDisease);
                command.Parameters.AddWithValue("@BloodGroup", BloodGroup);

                SqlParameter outputParameter = new SqlParameter("@PatID", SqlDbType.Int);
                outputParameter.Direction = ParameterDirection.Output;
                command.Parameters.Add(outputParameter);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    insertedid = (int)outputParameter.Value; // Retrieve the output parameter value
                }
                catch (Exception ex)
                {
                    clsLogError.LogError("DataBaseError", clsLogError.enStatus.Error);
                    // Handle or log the exception appropriately
                }

                connection.Close();
            }

            return insertedid;
        }


        public static bool UpdatePatient(int PatID , string patName, string PatAddress, int patAge, string PatGender, string PatDisease, string BloodGroup)
        {
            int rowsAffected = 0;   
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                SqlCommand command = new SqlCommand("sp_UpdatePatient", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@PatAddress", PatAddress);
                command.Parameters.AddWithValue("@PatAge", patAge);
                command.Parameters.AddWithValue("@PatGender", PatGender);
                command.Parameters.AddWithValue("@PatDisease", PatDisease);
                command.Parameters.AddWithValue("@PatName", patName);
                command.Parameters.AddWithValue("@PatID", PatID);
                command.Parameters.AddWithValue("@BloodGroup", BloodGroup);

                try
                {
                    connection.Open();
                    rowsAffected = command.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    clsLogError.LogError("DataBaseError", clsLogError.enStatus.Error);
                }
                connection.Close();
            }

            return rowsAffected > 0;
        }

        public static bool DeletePatient(int PatID)
        {
            int rowsAffected = 0; 

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                SqlCommand command = new SqlCommand("Sp_DeletePatient", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@PatID", PatID);

                try
                {
                    connection.Open();
                    rowsAffected = command.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    clsLogError.LogError("DataBaseError", clsLogError.enStatus.Error);
                }
                connection.Close();
            }

            return rowsAffected > 0;
        }

        public static DataTable GetAllPaients()
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = "Select * from Patients";
                SqlCommand command = new SqlCommand(query, connection);
              

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows) {
                        dt.Load(reader);
                    }

                }
                catch (Exception ex)
                {
                    clsLogError.LogError("DataBaseError", clsLogError.enStatus.Error);
                }
                connection.Close();
            }

            return dt;

        }

        public static string GetPatientName(int ID)
        {
            string patientname = "";

            using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = "Select PatName from Patients Where PatID = @ID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID", ID);

                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        patientname = (string)result;
                    }
                    else
                    {
                        clsLogError.LogError("DataBaseError", clsLogError.enStatus.Error);
                            
                    }
                }
                catch(Exception ex)
                {
                    clsLogError.LogError("DataBaseError", clsLogError.enStatus.Error);

                }
            }
            return patientname; 
        }

    }
}
