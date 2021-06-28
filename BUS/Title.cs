using System.ComponentModel;
using System.Linq;

namespace BookStore.BUS
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

        public BindingList<DTO.Title> Titles { get => titles; set => titles = value; }

        public Title()
        {
            Titles = new BindingList<DTO.Title>();
            GetListTitle();
        }

        public void GetListTitle()
        {
            Titles = DAO.Title.Instance.GetListTitle();
        }

        public bool AddTitle(string name, int categoryId)
        {
            //if (Titles.FirstOrDefault(
            //    title => title.Name == name && title.CategoryId == categoryId) == null)
            //{
                int id = DAO.Title.Instance.AddTitle(name, categoryId);
                if (id != -1)
                {
                    Titles.Add(new DTO.Title(
                        id,
                        name,
                        categoryId
                    ));

                    return true;
                }
            //    return false;
            //}
            return false;
        }

        public bool DeleteTitle(int id)
        {
            if (DAO.Title.Instance.DeleteTitle(id))
            {
                Titles.Remove(Titles.First(title => title.Id == id));

                return true;
            }
            return false;
        }

        public bool UpdateTitle(DTO.Title updated)
        {
            //if (Titles.FirstOrDefault(
            //    title => title.Name == updated.Name && title.CategoryId == updated.CategoryId) != null)
            //{
                if (DAO.Title.Instance.UpdateTitle(updated))
                {
                    var obj = Titles.First(title => title.Id.Equals(updated.Id));

                    obj.Name = updated.Name;
                    obj.CategoryId = obj.CategoryId;

                    return true;
                }
                //return false;
            //}
            return false;
        }
    }
}
