//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace BookStore.BUS
//{
//    public class Category
//    {
//        private static Category instance;

//        private static BindingList<DTO.Category> categories = new BindingList<DTO.Category>();

//        public static Category Instance
//        {
//            get
//            {
//                if (instance == null)
//                {
//                    instance = new Category();
//                }
//                return instance;
//            }
//            private set => instance = value;
//        }

//        public static BindingList<DTO.Category> Categories { get => categories; set => categories = value; }

//        public Category()
//        {

//        }

//        public void GetListCategory()
//        {
            
//        }

//        private void AddToList(string name)
//        {
            
//        }

//        public bool AddCategory(string name)
//        {
            
//        }

//        public bool DeleteCategory(int id)
//        {
            
//        }

//        public bool UpdateCategory(int id, string name)
//        {
            
//        }
//    }
//}
