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
        private static BindingList<DTO.Book> books;

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
        public static BindingList<DTO.Book> Books { get => books; set => books = value; }

        public Book()
        {
            books = new BindingList<DTO.Book>();
            GetListBook();
        }

        private void GetListBook()
        {
            int id;
            int titleId;
            string publisher;
            int publishYear;
            int inStock;
            int price;

            string query = "select * from SACH";
            DataTable results = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in results.Rows)
            {
                id = (int)row.ItemArray[0];
                titleId = (int)row.ItemArray[1];
                publisher = row.ItemArray[2].ToString();
                publishYear = (int)row.ItemArray[3];
                inStock = (int)row.ItemArray[4];
                price = (int)row.ItemArray[5];

                Books.Add(new DTO.Book(id, titleId, publisher, publishYear, inStock, price));
            }
        }

        private bool AddBook(int titleId, string publisher, int publishYear, int inStock, int price)
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

            if (result != null)
            {
                Books.Add(new DTO.Book(
                    (int)result,
                    titleId,
                    publisher,
                    publishYear,
                    inStock,
                    price
                ));
            }

            return result != null;
        }

        private bool UpdateBook(DTO.Book updated)
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
                var obj = Books.First(book => book.Id == updated.Id);

                obj.TitleId = updated.TitleId;
                obj.Publisher = updated.Publisher;
                obj.PublishYear = updated.PublishYear;
                obj.InStock = updated.InStock;
                obj.Price = updated.Price;
            }

            return result > 0;
        }

        private bool DeleteBook(int id)
        {
            string query = "EXEC sp_remove_book @id";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[]
            {
                id
            });

            if (result > 0)
            {
                Books.Remove(Books.First(book => book.Id == id));
            }

            return result > 0;
        }
    }
}
