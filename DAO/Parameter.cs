using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.DAO
{
    public class Parameter
    {
        private static Parameter instance;
        private static BindingList<DTO.Parameter> parameters;

        public Parameter()
        {
            parameters = new BindingList<DTO.Parameter>();
            GetListParameter();
        }

        public static Parameter Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Parameter();
                }
                return instance;
            }
            set => instance = value;
        }
        public static BindingList<DTO.Parameter> Parameters { get => parameters; set => parameters = value; }

        private void GetListParameter()
        {
            string query = "select * from THAMSO";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);

            foreach(DataRow row in result.Rows)
            {
                Parameters.Add(new DTO.Parameter(
                    row.ItemArray[0].ToString(),
                    (int)row.ItemArray[1]
                ));
            }
        }

        public bool ChangeValue(string name, int value)
        {
            string query = "EXEC sp_change_value_parameter @name , @value";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[]
            {
                name,
                value
            });

            if (result > 0)
            {
                var obj = Parameters.First(parameter => parameter.Name == name);

                obj.Value = value;
            }

            return result > 0;
        }
    }
}
