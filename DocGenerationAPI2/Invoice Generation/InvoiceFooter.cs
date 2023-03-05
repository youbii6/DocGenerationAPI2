using DocGenerationAPI2.Entites;
using DocGenerationAPI2.Models;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace DocGenerationAPI2.Invoice_Generation
{
    public class InvoiceFooter : PdfPageEventHelper
    {
        private readonly ICollection<InvoiceLineDto> _invoiceLines;
        private float _currentPageEnd;

        public InvoiceFooter(ICollection<InvoiceLineDto> invoiceLines)
        {
            _invoiceLines = invoiceLines;
        }
        public override void OnEndPage(PdfWriter writer, Document document)
        {
            base.OnEndPage(writer, document);

            // Calculate the total price for the invoice lines on this page
            decimal totalPrice = 0;
          

            foreach (var line in _invoiceLines)
            {
                // If this line is on the current page, add its price to the total
                if (line.PageNumber == writer.PageNumber)
                {
                    totalPrice += line.Service.Price*line.Qte;
                }
            }

            // Add the total price to the footer of the page
           
            ColumnText.ShowTextAligned(writer.DirectContent, Element.ALIGN_RIGHT,
                new Paragraph($"page Number :{writer.PageNumber.ToString()}  Total: {totalPrice:C}"), document.Right, document.Bottom, 0);
            

            // Update the current page end position for the next page
            _currentPageEnd = writer.GetVerticalPosition(false);
        }

        public override void OnStartPage(PdfWriter writer, Document document)
        {
            base.OnStartPage(writer, document);

            // Add footer to the first page
            if (writer.PageNumber == 1)
            {
                OnEndPage(writer, document);
            }
        }
    }
}