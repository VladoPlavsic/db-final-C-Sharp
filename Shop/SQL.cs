using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Shop
{
    public static class SQL
    {


        public static bool UseCLR(String query)
        {
            /*
            SqlConnection connection;
            String connect = String.Format(@"Data Source=DESKTOP-3DJA5K7\SCHOOLPOLINA; Initial Catalog=school; User ID={0}; Password={1}", m_GuestUsername, m_GuestPassword);
            connection = new SqlConnection(connect);
            return SQL.GetFirstBool(query, connection);
            */
            return false;
        }

        public static int IsAdmin(String username, String password)
        {
            SqlConnection connection;
            String connect = String.Format(@"Data Source=DESKTOP-3DJA5K7\SCHOOLPOLINA; Initial Catalog=school; User ID={0}; Password={1}", username, password);
            connection = new SqlConnection(connect);
            String query = "SELECT dbo.get_category() admin";
            try
            {
                connection.Open();
                int resposne = Convert.ToInt32(SQL.GetFirst(query, connection));
                connection.Dispose();
                connection.Close();
                return resposne;
            }
            catch
            {
                Console.WriteLine(String.Format("Error trying to open connection with parameters:\nUSERNAME: {0} \nPASSWORD: {1}", username, password));
            }

            return -1;
        }

        public static SqlConnection Connect(String username, String password)
        {
            SqlConnection connection;
            String connect = String.Format(@"Data Source=DESKTOP-3DJA5K7\SCHOOLPOLINA; Initial Catalog=school; User ID={0}; Password={1}", username, password);
            connection = new SqlConnection(connect);

            try
            {
                connection.Open();
                return connection;
            }
            catch
            {
                Console.WriteLine(String.Format("Error trying to open connection with parameters:\nUSERNAME: {0} \nPASSWORD: {1}", username, password));
            }
            
            return null;
        }

        public static void ExecuteQuery(String query, SqlConnection connection)
        {
            if (connection.State == ConnectionState.Closed)
                connection.Open();

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                try
                {
                    command.ExecuteReader();
                    connection.Close();
                }
                catch (Exception e)
                {
                    Console.WriteLine(String.Format("Error executing query:\n{0}\nExited with:\n{1}", query, e));
                }
            }
        }

        public static int GetFirst(String query, SqlConnection connection)
        {
            if (connection.State == ConnectionState.Closed)
                connection.Open();

            using (SqlCommand command = new SqlCommand(query, connection))
            {

                try
                {
                    using (var reader = command.ExecuteReader())
                    {
                        if (!reader.Read())
                            throw new Exception("Reader empty");

                        return reader.GetInt32(0);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(String.Format("Error executing query:\n{0}\nExited with:\n{1}", query, e));
                    return -1;
                }
            }
        }

        public static bool GetFirstBool(String query, SqlConnection connection)
        {
            if (connection.State == ConnectionState.Closed)
                connection.Open();

            using (SqlCommand command = new SqlCommand(query, connection))
            {

                try
                {
                    using (var reader = command.ExecuteReader())
                    {
                        if (!reader.Read())
                            throw new Exception("Reader empty");

                        return reader.GetBoolean(0);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(String.Format("Error executing query:\n{0}\nExited with:\n{1}", query, e));
                    return false;
                }
            }
        }

        public static List<String> GetAll(String query, SqlConnection connection)
        {
            List<String> list = new List<String>();

            if(connection.State == ConnectionState.Closed)
                connection.Open();

            using (SqlCommand command = new SqlCommand(query, connection))
            {

                try
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(reader.GetString(0));
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(String.Format("Error executing query:\n{0}\nExited with:\n{1}", query, e));
                    return null;
                }
            }
            return list;
        } 

        public static DataTable GetTable(String query, SqlConnection connection)
        {
            if (connection.State == ConnectionState.Closed)
                connection.Open();

            try
            {
                using (DataTable table = new DataTable())
                {

                    using (var command = new SqlCommand(query, connection))
                    {

                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(table);
                        }
                    }
                    return table;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(String.Format("Error trying to get table. Exited with:\n{0}", e));
                return null;
            }
        }

    }
}
