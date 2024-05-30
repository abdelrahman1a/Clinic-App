using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace HMS_DataAccess
{
    public class clsDiagnosisData
    {
      public static DataTable  GetAllDiagnosis()
        {
            DataTable dt = new DataTable(); 

            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = "Select * from Diagnosis";
                SqlCommand command = new SqlCommand(query, conn);

                try
                {
                    conn.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows) {

                        dt.Load(reader);
                         
                    }
                }
                catch (Exception ex)
                {
                    clsLogError.LogError("DataBase Error", clsLogError.enStatus.Error);
                }
            }
            return dt;  
        }

        public static List<int> FillComboBoxWithID()
        {
            List<int> ids = new List<int>();

            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = "Select PatID from Patients";
                SqlCommand command = new SqlCommand(query, conn);

                try
                {
                    conn.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            // Read the PatientID from the database and add it to the list
                            int id = Convert.ToInt32(reader["PatID"]);
                            ids.Add(id);
                        }

                    }
                }
                catch (Exception ex)
                {
                    clsLogError.LogError("DataBase Error", clsLogError.enStatus.Error);
                }
            }
            return ids;
        }

        public static List<string> GetSpecificRowofData(int ID)
        {
            List<string> data = new List<string>();

            using (SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = "SELECT Symptoms, Diagnosis, Medicines, PatientName FROM Diagnosis WHERE PatientID = @ID";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@ID", ID);

                try
                {
                    conn.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read()) // Check if there are rows
                    {
                        // Add data to list, handle null values
                        data.Add(reader.IsDBNull(0) ? string.Empty : (string)reader["Symptoms"]);
                        data.Add(reader.IsDBNull(1) ? string.Empty : (string)reader["Diagnosis"]);
                        data.Add(reader.IsDBNull(2) ? string.Empty : (string)reader["Medicines"]);
                        data.Add(reader.IsDBNull(3) ? string.Empty : (string)reader["PatientName"]);
                    }
                    else
                    {
                        // Handle case when no rows are returned
                        // You might want to throw an exception or log a message
                        clsLogError.LogError("DataBase Error", clsLogError.enStatus.Error);

                    }
                }
                catch (Exception ex)
                {
                    clsLogError.LogError("DataBase Error", clsLogError.enStatus.Error);
                    // Handle the exception, log, or throw it depending on your requirements
                }
            }
            return data;
        }

        public static bool AddNewDiagnosis(int PatientId , string Symptoms ,  string Diagnosis , string Medicine , string PatientName)
        {
            int rowsAffected = 0;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = @"Insert Into Diagnosis(PatientID , Symptoms , Diagnosis , Medicines , PatientName)
                                Values(@PatientId , @Symptoms ,@Diagnosis ,@Medicine ,@PatientName)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@PatientId", PatientId);
                command.Parameters.AddWithValue("@Symptoms", Symptoms);
                command.Parameters.AddWithValue("@Diagnosis", Diagnosis);
                command.Parameters.AddWithValue("@Medicine", Medicine);
                command.Parameters.AddWithValue("@PatientName", PatientName);

                try
                {
                    connection.Open();
                    rowsAffected = command.ExecuteNonQuery();
                }
                catch(Exception message)
                {
                    clsLogError.LogError("DataBase Error " , clsLogError.enStatus.Error);

                }
            }

            return rowsAffected > 0;    
        }

        public static bool  UpdateDiagnosis(int PatientId, string Symptoms, string Diagnosis, string Medicine)
        {
            int rowsAffected = 0;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = @"Update  Diagnosis 
                               Set Symptoms = @Symptoms,
                                   Diagnosis = @Diagnosis,              
                                   Medicines = @Medicine  
                              where PatientID = @PatientId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@PatientId", PatientId);
                command.Parameters.AddWithValue("@Symptoms", Symptoms);
                command.Parameters.AddWithValue("@Diagnosis", Diagnosis);
                command.Parameters.AddWithValue("@Medicine", Medicine);
            

                try
                {
                    connection.Open();
                    rowsAffected = command.ExecuteNonQuery();
                }
                catch (Exception message)
                {
                    clsLogError.LogError("DataBase Error ", clsLogError.enStatus.Error);

                }
            }

            return rowsAffected > 0;
        }

        public static bool CheckSpecificID(int ID)
        {
            bool IsFound = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = "SELECT 1 FROM Diagnosis WHERE PatientID = @Id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", ID);

                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        IsFound = true;
                    }
                }
                catch (Exception ex)
                {
                    // Handle exception as needed
                    clsLogError.LogError("DataBaseError", clsLogError.enStatus.Error);
                }
            }

            return IsFound;
        }

        public static bool DeleteDiagnosis(int PatientID)
        {
            int rowsAffected = 0;
            using (SqlConnection connection  = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = @"Delete From Diagnosis
                                Where PatientID = @PatientID";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@PatientID", PatientID);

                try
                {
                    connection.Open();
                    rowsAffected = command.ExecuteNonQuery();
                }
                catch(Exception ex)
                {
                    clsLogError.LogError("DataBase Error" , clsLogError.enStatus.Error);
                }

                return rowsAffected > 0;
            }
        }

    }
}

