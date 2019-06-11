namespace Chinook.Data
{
    partial class Invoice : Entity
    {
        public override string ToText()
        {
            return InvoiceDate + "";
        }

        public string CustomerName { get; internal set; }

        public int TotalPoint { get; set; }


        //public string CustomerName
        //{
        //    get
        //    {
        //        string name = CustomerFirstName + " " + CustomerLastName;
        //        return name;
        //    }

        //    set
        //    {

        //    }
        //}

        //public string CustomerLastName
        //{
        //    get; internal set;
        //}

        //public string CustomerFirstName
        //{
        //    get; internal set;
        //}

    }
}
