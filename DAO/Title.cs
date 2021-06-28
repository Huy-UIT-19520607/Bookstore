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
        //private static BindingList<DTO.Title> titles;

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

        //public static BindingList<DTO.Title> Titles { get => titles; set => titles = value; }

        public Title() 
        {
            //titles = new BindingList<DTO.Title>();
            //GetListTitle();
        }

        public BindingList<DTO.Title> GetListTitle()
        {
            string query = "select * from DAUSACH";
            DataTable results = DataProvider.Instance.ExecuteQuery(query);

            BindingList<DTO.Title> titles = new BindingList<DTO.Title>();

            foreach (DataRow row in results.Rows)
            {
                //Titles.Add(new DTO.Title(id, name, categoryId));
                titles.Add(new DTO.Title(
                    (int)row.ItemArray[0],
                    row.ItemArray[1].ToString(),
                    (int)row.ItemArray[2]
                ));
            }

            return titles;
        }

        public int AddTitle(string name, int categoryId)
        {
            string query = "EXEC sp_add_title @name , @category_id";
            object results = DataProvider.Instance.ExecuteScalar(query, new object[] { name, categoryId });

            if (results == null)
            {
                //Titles.Add(new DTO.Title(
                //    (int)results,
                //    name,
                //    categoryId
                //));

                return -1;
            }

            return (int)results;
        }

        public bool DeleteTitle(int id)
        {
            string query = "EXEC sp_remove_title @id";
            int results = DataProvider.Instance.ExecuteNonQuery(query, new object[] { id });

            if (results > 0)
            {
                //Titles.Remove(Titles.First(title => title.Id == id));
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
                //var obj = Titles.First(title => title.Id.Equals(updated.Id));

                //obj.Name = updated.Name;
                //obj.CategoryId = obj.CategoryId;
            }

            return results > 0;
        }
    }
}
