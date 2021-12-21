using System;
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

        public int SumBalance(DateTime date, int bookId)
        {
            int import = BookReceiptDetail.Instance.Details.Where(detail =>
                detail.BookId == bookId
                && BookReceipt.Instance.Receipts.Any(receipt =>
                    receipt.Id == detail.Id
                    && receipt.ReceiveDay.Month == date.Month
                    && receipt.ReceiveDay.Year == date.Year
                )
            ).Sum(det => det.Number);

            int sold = BillDetail.Instance.BillDetails.Where(detail =>
                detail.BookId == bookId
                && Bill.Instance.Bills.Any(bill => 
                    bill.CreateDate.Month == date.Month
                    && bill.CreateDate.Year == date.Year
                )
            ).Sum(det => det.Number);

            return import - sold;
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
                    book.InStock += (oldAmount - amount);
                    break;
                case 3:
                    book.InStock += amount;
                    break;
                case 4:
                    book.InStock += (amount - oldAmount);
                    break;
            }

            UpdateBook(book);

            if (!InventoryReport.Instance.Reports.Any(report =>
                report.Month == date.Month
                && report.Year == date.Year
                && report.BookId == bookId))
            {
                CreateNewReport(date, bookId);
            }
            else
            {
                InventoryReport.Instance.UpdateChange(bookId, date, book.InStock, old);
            }
        }

        private void CreateNewReport(DateTime date, int bookId)
        {
            var temp = BUS.InventoryReport.Instance.Reports.FirstOrDefault(report =>
            {
                int m = date.Month - 1;
                int y = date.Year;

                if (m == 0)
                {
                    m = 12;
                    y--;
                }

                return report.Month == m && report.Year == y;
            });

            int start = temp == null ? 0 : temp.Final;
            int change = SumBalance(date, bookId);

            BUS.InventoryReport.Instance.AddReport
            (
                date.Month,
                date.Year,
                bookId,
                start,
                change,
                start + change
            );
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
                //foreach (var item in Books)
                //{
                //    item.Price = item.Price / oldValue * value;
                //}
                Books.ToList().ForEach(item => item.Price = item.Price / oldValue * value);
            });
        }
    }
}
