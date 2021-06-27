using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.BUS
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
            Authors = DAO.Author.Instance.GetListAuthor();
        }

        public bool AddAuthor(int titleId, string name)
        {
            //if (Authors.FirstOrDefault(author => author.TitleId == titleId && author.Name == name) == null)
            //{
            //    if (DAO.Author.Instance.AddAuthor(titleId, name))
            //    {
            //        Authors.Add(new DTO.Author(
            //            titleId,
            //            name
            //        ));

            //        return true;
            //    }
            //    return false;
            //}
            //return false;

            if (DAO.Author.Instance.AddAuthor(titleId, name))
            {
                Authors.Add(new DTO.Author(
                    titleId,
                    name
                ));

                return true;
            }
            return false;
        }

        public bool UpdateAuthor(DTO.Author updated, string oldName)
        {
            //if (Authors.FirstOrDefault(author => author.TitleId == updated.TitleId && author.Name == oldName) != null)
            //{
            //    if (DAO.Author.Instance.UpdateAuthor(updated, oldName))
            //    {
            //        var obj = Authors.First(author =>
            //                author.TitleId == updated.TitleId
            //                && author.Name.Equals(oldName));

            //        obj.Name = updated.Name;

            //        return true;
            //    }
            //    return false;
            //}
            //return false;

            if (DAO.Author.Instance.UpdateAuthor(updated, oldName))
            {
                var obj = Authors.First(author =>
                        author.TitleId == updated.TitleId
                        && author.Name.Equals(oldName));

                obj.Name = updated.Name;

                return true;
            }
            return false;
        }

        public bool DeleteAuthor(DTO.Author removed)
        {
            if (DAO.Author.Instance.DeleteAuthor(removed))
            {
                Authors.Remove(Authors.First(author =>
                            author.TitleId == removed.TitleId
                            && author.Name.Equals(removed.Name)
                            ));

                return true;
            }
            return false;
        }
    }
}
