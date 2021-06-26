using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    public class DataProvider
    {
        private static DataProvider instance;

        public static DataProvider Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DataProvider();
                }
                return instance;
            }
            private set { DataProvider.instance = value; }
        }

        private DataProvider() { }

        private readonly string connectionString = 
            @"Data Source=DESKTOP-O9Q211T;Initial Catalog=QuanLyNhaSach;Persist Security Info=True;User ID=sa;Password=Huy123456";

        private SqlCommand AddParameters(string query, SqlCommand command, object[] parameter = null)
        {
            if (parameter != null)
            {
                string[] listPara = query.Split(' ');
                int i = 0;
                foreach (string item in listPara)
                {
                    if (item.Contains('@'))
                    {
                        command.Parameters.AddWithValue(item, parameter[i]);
                        i++;
                    }
                }
            }

            return command;
        }

        /// <summary>
        /// Thực hiện câu lệnh query và trả về kết quả
        /// </summary>
        /// <param name="query">Câu lệnh</param>
        /// <param name="parameter">Tham số</param>
        /// <returns>Kết quả sau khi thực hiện query</returns>
        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                command = AddParameters(query, command, parameter);

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(data);

                connection.Close();
            }

            return data;
        }

        /// <summary>
        /// Thực hiện câu lệnh query và trả về số hàng bị ảnh hưởng. Chỉ sử dụng với INSERT, UPDATE, DELETE
        /// </summary>
        /// <param name="query">Câu lệnh</param>
        /// <param name="parameter">Tham số</param>
        /// <returns>Số hàng bị ảnh hưởng sau khi thực hiện query</returns>
        public int ExecuteNonQuery(string query, object[] parameter = null)
        {
            int recordNumber = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                command = AddParameters(query, command, parameter);

                recordNumber = command.ExecuteNonQuery();

                connection.Close();
            }

            return recordNumber;
        }

        /// <summary>
        /// Thực hiện query và trả về kết quả của hàng và cột đầu tiên, không trả về các hàng và cột còn lại
        /// </summary>
        /// <param name="query">Câu lệnh</param>
        /// <param name="parameter">Tham số</param>
        /// <returns>Hàng và cột đầu tiên của kết quả sau khi thực hiện query</returns>
        public object ExecuteScalar(string query, object[] parameter = null)
        {
            object firstData = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                command = AddParameters(query, command, parameter);

                firstData = command.ExecuteScalar();

                connection.Close();
            }

            return firstData;
        }


        
    }
}
