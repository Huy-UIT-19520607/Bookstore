using System.ComponentModel;
using System.Linq;

namespace BookStore.BUS
{
    public class Parameter
    {
        private static Parameter instance;
        private static BindingList<DTO.Parameter> parameters;

        public Parameter()
        {
            Parameters = new BindingList<DTO.Parameter>();
            GetListParameter();
        }

        public static Parameter Instance {
            get
            {
                if (instance == null)
                {
                    instance = new Parameter();
                }
                return instance;
            }
            set => instance = value;
        }
        public static BindingList<DTO.Parameter> Parameters { get => parameters; set => parameters = value; }
        public int ApDungQD4 { get => Parameters[0].Value; }
        public int SLNhapMin { get => Parameters[1].Value; }
        public int SLTruocNhapMax { get => Parameters[2].Value; }
        public int SLTruocNhapMin { get => Parameters[3].Value; }
        public int SoTienNoMax { get => Parameters[4].Value; }
        public int TiLeTinhDonGiaBan { get => Parameters[5].Value; }

        private void GetListParameter()
        {
            Parameters = DAO.Parameter.Instance.GetListParameter();
        }

        public bool ChangeValue(string name, int value)
        {
            if (DAO.Parameter.Instance.ChangeValue(name, value))
            {
                var obj = Parameters.First(parameter => parameter.Name == name);

                obj.Value = value;

                if (name.Equals("ApDungQD4"))
                {
                    BUS.Book.Instance.UpdatePrice(value);
                }

                return true;
            }
            return false;
        }
    }
}
