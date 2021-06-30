﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.BUS
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
        public BindingList<DTO.Book> Books { get => books; set => books = value; }

        public Book()
        {
            Books = new BindingList<DTO.Book>();
            GetListBook();
        }

        private void GetListBook()
        {
            Books = DAO.Book.Instance.GetListBook();
        }

        public bool AddBook(int titleId, string publisher, int publishYear, int inStock, int price)
        {
            //if (Books.FirstOrDefault(book => 
            //    book.TitleId == titleId 
            //    && book.Publisher.Equals(publisher)
            //    && book.InStock == inStock
            //    && book.Price == price
            //) == null)
            //{
                int id = DAO.Book.Instance.AddBook(titleId, publisher, publishYear, inStock, price);

                if (id != -1)
                {
                    Books.Add(new DTO.Book(
                        id,
                        titleId,
                        publisher,
                        publishYear,
                        inStock,
                        price
                    ));

                    return true;
                }
                return false;
            //}
            //return false;
        }

        public bool UpdateBook(DTO.Book updated)
        {
            //if (Books.FirstOrDefault(book =>
            //       book.TitleId == updated.TitleId
            //       && book.Publisher.Equals(updated.Publisher)
            //       && book.InStock == updated.PublishYear
            //       && book.Price == updated.Price
            //   ) == null)
            //{
                if (DAO.Book.Instance.UpdateBook(updated))
                {
                    var obj = Books.First(book => book.Id == updated.Id);

                    obj.TitleId = updated.TitleId;
                    obj.Publisher = updated.Publisher;
                    obj.PublishYear = updated.PublishYear;
                    obj.InStock = updated.InStock;
                    obj.Price = updated.Price;

                    return true;
                }
            //}
            return false;
        }

        public void UpdateInStock(int type, int bookId, DateTime date, int amount, int oldAmount = 0)
        {
            var book = Books.First(bk => bk.Id == bookId);
            int old = book.InStock;

            switch (type)
            {
                case 1:
                    book.InStock -= amount;
                    break;
                case 2:
                    book.InStock += (amount - oldAmount);
                    break;
                case 3:
                    book.InStock += amount;
                    break;
            }

            UpdateBook(book);
            InventoryReport.Instance.UpdateChange(bookId, date, book.InStock, old);
        }

        public bool DeleteBook(int id)
        {
            if (DAO.Book.Instance.DeleteBook(id))
            {
                Books.Remove(Books.First(book => book.Id == id));
                return true;
            }
            return false;
        }

        public async void UpdatePrice(int value, int oldValue)
        {
            await Task.Run(() =>
            {
                foreach (var item in Books)
                {
                    item.Price = item.Price / oldValue * value;
                }
            });
        }
    }
}
