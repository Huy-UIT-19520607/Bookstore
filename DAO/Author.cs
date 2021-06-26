using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.DAO
{
    public class Author
    {
        private static Author instance;
        private static BindingList<DTO.Author> authors;

        public Author()
        {
            Authors = new BindingList<DTO.Author>();
            GetListAuthor();
        }

        public static Author Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Author();
                }
                return instance;
            }
            set => instance = value;
        }
        public static BindingList<DTO.Author> Authors { get => authors; set => authors = value; }

        private void GetListAuthor()
        {
            string query = "select * from CT_TACGIA";
            DataTable results = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in results.Rows)
            {
                Authors.Add(new DTO.Author(
                    (int)row.ItemArray[0],
                    row.ItemArray[1].ToString()
                ));
            }
        }

        public bool AddAuthor(int titleId, string name)
        {
            string query = "exec sp_add_author @title_id , @name";
            int results = DataProvider.Instance.ExecuteNonQuery(query, new object[]
            {
                titleId,
                name
            });

            if (results > 0)
            {
                Authors.Add(new DTO.Author(
                    titleId,
                    name
                ));
            }

            return results > 0;
        }

        public bool UpdateAuthor(DTO.Author updated, string oldName)
        {
            string query = "exec sp_update_author @title_id , @old_name , @new_name";
            int results = DataProvider.Instance.ExecuteNonQuery(query, new object[]
            {
                updated.TitleId,
                oldName,
                updated.Name
            });

            if (results > 0)
            {
                var obj = Authors.First(author =>
                            author.TitleId == updated.TitleId
                            && author.Name.Equals(oldName));

                obj.Name = updated.Name;
            }

            return results > 0;
        }

        public bool DeleteAuthor(DTO.Author removed)
        {
            string query = "exec sp_remove_author @title_id , @new_name";
            int results = DataProvider.Instance.ExecuteNonQuery(query, new object[]
            {
                removed.TitleId,
                removed.Name
            });

            if (results > 0)
            {
                Authors.Remove(Authors.First(author =>
                            author.TitleId == removed.TitleId
                            && author.Name.Equals(removed.Name)
                            ));
            }

            return results > 0;
        }
    }
}