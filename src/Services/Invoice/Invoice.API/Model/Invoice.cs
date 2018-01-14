namespace eSupport.Services.Invoice.API.Model
{
    public class Invoice
    {
        public int Id { get; set; }

        public string InvoiceNumber { get; set; }

        public string InvoiceHeader { get; set; }

        public float InvoiceValue { get; set; }

        public int Valute { get; set; }
 
        public bool Active { get; set; }
    }
}