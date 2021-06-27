using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.BUS
{
    public class BillDetail
    {
        private static BillDetail instance;
        private BindingList<DTO.BillDetail> billDetails;

        public BillDetail()
        {
            BillDetails = new BindingList<DTO.BillDetail>();
        }

        public static BillDetail Instance { get => instance; set => instance = value; }
        public BindingList<DTO.BillDetail> BillDetails { get => billDetails; set => billDetails = value; }
    
        public void GetListDetail()
        {
            BillDetails = DAO.BillDetail.Instance.GetListDetail();
        }

        public bool AddDetail(DTO.BillDetail billDetail)
        {
            if (DAO.BillDetail.Instance.AddDetail(billDetail))
            {
                BillDetails.Add(billDetail);

                return true;
            }
            return false;
        }

        public void DeleteAllDetailById(int id)
        {
            List<DTO.BillDetail> detailToRemove = 
                BillDetails.Where(detail => detail.Id != id).ToList();

            foreach(var detail in detailToRemove)
            {
                BillDetails.Remove(detail);
            }
        }

        public bool DeleteDetail(int id, int bookId)
        {
            if (DAO.BillDetail.Instance.DeleteDetail(id, bookId))
            {
                BillDetails.Remove(
                    BillDetails.First(detail => detail.Id == id && detail.BookId == bookId));

                return true;
            }
            return false;
        }

        public bool UpdateDetail(DTO.BillDetail updated)
        {
            if (DAO.BillDetail.Instance.UpdateDetail(updated))
            {
                var obj = BillDetails.First(
                    detail => detail.Id == updated.Id && detail.BookId == updated.BookId);

                obj.Number = updated.Number;
                obj.Price = updated.Price;
                obj.Total = updated.Total;

                return true;
            }
            return false;
        }
    }
}
