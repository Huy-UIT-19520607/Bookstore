//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace BookStore.BUS
//{
//    public class Title
//    {
//        private static Title instance;
//        private static BindingList<DTO.Title> titles;

//        public static Title Instance 
//        { 
//            get
//            {
//                if (instance == null)
//                {
//                    instance = new Title();
//                }
//                return instance;
//            }
//            private set => instance = value;
//        }

//        public static BindingList<DTO.Title> Titles { get => titles; set => titles = value; }

//        public Title() 
//        {
            
//        }

//        public void GetListTitle()
//        {
            
//        }

//        private void AddToList(string name, int categoryId)
//        {
           
//        }

//        public bool AddTitle(string name, int categoryId)
//        {
            
//        }

//        public bool DeleteTitle(int id)
//        {
            
//        }

//        public bool UpdateTitle(DTO.Title updated)
//        {
            
//        }
//    }
//}
