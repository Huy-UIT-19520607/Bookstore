using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.BUS
{
    public class Category
    {
        private static Category instance;

        private static BindingList<DTO.Category> categories;

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

        public BindingList<DTO.Category> Categories { get => categories; set => categories = value; }

        public Category()
        {
            Categories = new BindingList<DTO.Category>();
            GetListCategory();
        }

        public void GetListCategory()
        {
            Categories = DAO.Category.Instance.GetListCategory();
        }

        public bool AddCategory(string name)
        {
            //if (Categories.FirstOrDefault(category => category.Name.Equals(name)) == null)
            //{
                int id = DAO.Category.Instance.AddCategory(name);

                if (id == -1)
                {
                    return false;
                }

                Categories.Add(new DTO.Category(
                    id,
                    name
                ));

                return true;
            //}
            //return false;
        }

        public bool DeleteCategory(int id)
        {
            if (DAO.Category.Instance.DeleteCategory(id))
            {
                Categories.Remove(Categories.First(category => category.Id == id));

                return true;
            }
            return false;
        }

        public bool UpdateCategory(int id, string name)
        {
            //if (Categories.FirstOrDefault(category => category.Name.Equals(name)) != null)
            //{
                if (DAO.Category.Instance.UpdateCategory(id, name))
                {
                    var obj = Categories.First(category => category.Id == id);

                    obj.Name = name;

                    return true;
                }
                //return false;
            //}
            return false;
        }
    }
}
