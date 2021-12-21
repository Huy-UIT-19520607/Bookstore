using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.DAO
{
    public class Book
    {
        private static Book instance;
        //private static BindingList<DTO.Book> books;

        public static Book Instance 
        { 
            get
            {
                if (instance == null)
                {
                    instance = new Book();
                }
                return instance;
            }
            set => instance = value; 
        }
        //public static BindingList<DTO.Book> Books { get => books; set => books = value; }

        public Book()
        {
            //books = new BindingList<DTO.Book>();
            //GetListBook();
        }

        public BindingList<DTO.Book> GetListBook()
        {
            string query = "select * from SACH";
            DataTable results = DataProvider.Instance.ExecuteQuery(query);

            BindingList<DTO.Book> books = new BindingList<DTO.Book>();

            foreach (DataRow row in results.Rows)
            {
                //Books.Add(new DTO.Book(
                //    (int)row.ItemArray[0],
                //    (int)row.ItemArray[1],
                //    row.ItemArray[2].ToString(),
                //    (int)row.ItemArray[3],
                //    (int)row.ItemArray[4],
                //    (int)row.ItemArray[5]
                //));

                books.Add(new DTO.Book(
                    (int)row.ItemArray[0],
                    (int)row.ItemArray[1],
                    row.ItemArray[2].ToString(),
                    (int)row.ItemArray[3],
                    (int)row.ItemArray[4],
                    (int)row.ItemArray[5]
                ));
            }

            return books;
        }

        public int AddBook(int titleId, string publisher, int publishYear, int inStock, int price)
        {
            string query = "EXEC sp_add_book @title_id , @publisher , @publish_year , @in_stock , @price";
            object result = DataProvider.Instance.ExecuteScalar(query, new object[]
            {
                titleId,
                publisher,
                publishYear,
                inStock,
                price
            });

            if (result == null)
            {
                //Books.Add(new DTO.Book(
                //    (int)result,
                //    titleId,
                //    publisher,
                //    publishYear,
                //    inStock,
                //    price
                //));

                return -1;
            }

            return (int)result;
        }

        public bool UpdateBook(DTO.Book updated)
        {
            string query = "EXEC sp_update_book @id , @title_id , @publisher , @publish_year , @in_stock , @price";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[]
            {
                updated.Id,
                updated.TitleId,
                updated.Publisher,
                updated.PublishYear,
                updated.InStock,
                updated.Price
            });

            if (result > 0)
            {
                //var obj = Books.First(book => book.Id == updated.Id);

                //obj.TitleId = updated.TitleId;
                //obj.Publisher = updated.Publisher;
                //obj.PublishYear = updated.PublishYear;
                //obj.InStock = updated.InStock;
                //obj.Price = updated.Price;
            }

            return result > 0;
        }

        public bool DeleteBook(int id)
        {
            string query = "EXEC sp_remove_book @id";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[]
            {
                id
            });

            if (result > 0)
            {
                //Books.Remove(Books.First(book => book.Id == id));
            }

            return result > 0;
        }
    }
}
