using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.DAO
{
    public class Title
    {
        private static Title instance;
        private static BindingList<DTO.Title> titles;

        public static Title Instance 
        { 
            get
            {
                if (instance == null)
                {
                    instance = new Title();
                }
                return instance;
            }
            private set => instance = value;
        }

        public static BindingList<DTO.Title> Titles { get => titles; set => titles = value; }

        public Title() 
        {
            GetListTitle();
        }

        public void GetListTitle()
        {
            int id;
            string name;
            int categoryId;

            string query = "select * from DAUSACH";
            DataTable results = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in results.Rows)
            {
                id = (int)row.ItemArray[0];
                name = row.ItemArray[1].ToString();
                categoryId = (int)row.ItemArray[2];

                Titles.Add(new DTO.Title(id, name, categoryId));
            }
        }

        private void AddToList(string name, int categoryId)
        {
            string query = "EXEC sp_get_title_by_data @name , @category_id";
            DataTable results = DataProvider.Instance.ExecuteQuery(query, new object[] { name, categoryId });

            if (results.Rows.Count > 0)
            {
                Titles.Add(new DTO.Title(
                    (int)results.Rows[0].ItemArray[0], 
                    results.Rows[0].ItemArray[1].ToString(),
                    (int)results.Rows[0].ItemArray[2]
                ));
            }
        }

        public bool AddTitle(string name, int categoryId)
        {
            string query = "EXEC sp_add_title @name , @category_id";
            int results = DataProvider.Instance.ExecuteNonQuery(query, new object[] { name, categoryId });

            if (results > 0)
            {
                AddToList(name, categoryId);
            }

            return results > 0;
        }

        public bool DeleteTitle(int id)
        {
            string query = "EXEC sp_remove_title @id";
            int results = DataProvider.Instance.ExecuteNonQuery(query, new object[] { id });

            if (results > 0)
            {
                Titles.Remove(Titles.First(title => title.Id == id));
            }

            return results > 0;
        }

        public bool UpdateTitle(DTO.Title updated)
        {
            string query = "EXEC sp_update_title @id , @name , @category_id";
            int results = DataProvider.Instance.ExecuteNonQuery(query,
                new object[] 
                {
                    updated.Id,
                    updated.Name,
                    updated.CategoryId 
                });

            if (results > 0)
            {
                var obj = Titles.First(title => title.Id.Equals(updated.Id));

                obj.Name = updated.Name;
                obj.CategoryId = obj.CategoryId;
            }

            return results > 0;
        }
    }
}
