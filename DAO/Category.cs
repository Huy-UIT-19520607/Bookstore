using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.DAO
{
    public class Category
    {
        private static Category instance;

        private static BindingList<DTO.Category> categories = new BindingList<DTO.Category>();

        public static Category Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Category();
                }
                return instance;
            }
            private set => instance = value;
        }

        public static BindingList<DTO.Category> Categories { get => categories; set => categories = value; }

        public Category()
        {
            GetListCategory();
        }

        public void GetListCategory()
        {
            int id;
            string name;

            string query = "Select * from THELOAI";

            DataTable results = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in results.Rows)
            {
                id = (int)row.ItemArray[0];
                name = row.ItemArray[1].ToString(); 

                Categories.Add(new DTO.Category(id, name));
            }
        }

        public bool AddCategory(string name)
        {
            string query = "EXEC sp_add_category @name";

            object results = DataProvider.Instance.ExecuteScalar(query, new object[] { name });

            if (results != null)
            {
                Categories.Add(new DTO.Category(
                    (int)results,
                    name
                ));
            }

            return results != null;
        }

        public bool DeleteCategory(int id)
        {
            string query = "EXEC sp_remove_category @id";

            int results = DataProvider.Instance.ExecuteNonQuery(query, new object[] { id });

            if (results > 0)
            {
                Categories.Remove(Categories.First(category => category.Id == id));
            }

            return results > 0;
        }

        public bool UpdateCategory(int id, string name)
        {
            string query = "EXEC sp_update_category @id , @name";

            int results = DataProvider.Instance.ExecuteNonQuery(query, new object[] { id, name });

            if (results > 0)
            {
                var obj = Categories.First(category => category.Id == id);

                obj.Name = name;
            }

            return results > 0;
        }
    }
}
