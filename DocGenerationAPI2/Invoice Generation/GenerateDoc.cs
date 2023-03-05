



using DocGenerationAPI2.Models;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.Reflection.Metadata;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using iTextSharp.text.pdf.parser;
using DocGenerationAPI2.Entites;
using Microsoft.AspNetCore.Components.Routing;
using System.IO;

namespace DocGenerationAPI2.Invoice_Generation
{
    public class GenerateDoc
    {
        #region Declaration
        int _totalColumn = 5;
        iTextSharp.text.Document _document;
        Font _fontStyle;
        // Create a new table with 5 columns
        PdfPTable _pdfTable = new PdfPTable(5);
        PdfPCell _pdfCell;
        MemoryStream _memoryStream = new MemoryStream();
        InvoiceDto _invoice = new InvoiceDto();
        #endregion
        public byte[] PrepareInvoice(InvoiceDto invoice)
        {
            _invoice = invoice;

            #region
            // Create a new PDF document
            _document = new iTextSharp.text.Document(PageSize.A4, 0f, 0f, 0f, 0f);
            _document.SetPageSize(PageSize.A4);
            _document.SetMargins(30f, 30f, 50f, 30f);


            _pdfTable.WidthPercentage = 100;
            _pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
            //setiing the widths of the columns 
            _pdfTable.SetWidths(new float[] { 20f, 80f, 80f,80f,80f });

            _fontStyle = FontFactory.GetFont("Tahoma", 8f, 1);

            // Create a new PDF writer
            PdfWriter writer = PdfWriter.GetInstance(_document, _memoryStream);
            



            _document.Open();

            #endregion
            // Add an empty paragraph to create space for the image
            _document.Add(new Paragraph(" "));
            _document.Add(new Paragraph(" "));
           


            iTextSharp.text.Image image = iTextSharp.text.Image.GetInstance("ced.png");
            // Set the position of the image on the page
            
            image.SetAbsolutePosition(_document.Left,_document.Top);
            image.ScaleToFit(100f, 100f);
            // Add the image to the document
            _document.Add(image);
           


            _document.Add(new Paragraph(" "));
            _document.Add(new Paragraph(" "));

            this.InvoiceHeader();

            _pdfTable.HeaderRows = 2;
            _document.Add(_pdfTable);


            this.InvoiceBody2(writer);

          
            _document.Close();

            byte[] bytes = _memoryStream.ToArray();
            PdfReader reader = new PdfReader(bytes);
            

            // Get the total number of pages
            int totalPages = reader.NumberOfPages;
            Console.WriteLine(totalPages);
            return _memoryStream.ToArray();

        }

        private void InvoiceHeader()
        {

            
            
            _fontStyle = FontFactory.GetFont("Tahoma", 18f, 1);
            _pdfCell = new PdfPCell(new Phrase("Services Invoice ", _fontStyle));
            _pdfCell.Colspan = _totalColumn;
            _pdfCell.HorizontalAlignment = Element.ALIGN_CENTER;
            _pdfCell.Border = 2;
            _pdfCell.BackgroundColor = BaseColor.WHITE;
            _pdfCell.ExtraParagraphSpace = 0;
            _pdfTable.AddCell(_pdfCell);
            _pdfCell = new PdfPCell(new Phrase("Invoice ID : " + _invoice.Id.ToString(), _fontStyle));

            _pdfCell.Colspan = _totalColumn;
            _pdfCell.HorizontalAlignment = Element.ALIGN_LEFT;
            _pdfCell.Border = 0;
            _pdfCell.BackgroundColor = BaseColor.WHITE;
            _pdfCell.ExtraParagraphSpace = 2;
            _pdfTable.AddCell(_pdfCell);
            _pdfTable.CompleteRow();

            _fontStyle = FontFactory.GetFont("Tahoma", 9f, 1);
            _pdfCell = new PdfPCell(new Phrase("Services List :", _fontStyle));
            _pdfCell.Colspan = _totalColumn;
            _pdfCell.HorizontalAlignment = Element.ALIGN_LEFT;
            _pdfCell.Border = 0;
            _pdfCell.BackgroundColor = BaseColor.WHITE;
            _pdfCell.ExtraParagraphSpace = 3;
            _pdfTable.AddCell(_pdfCell);
            _pdfTable.CompleteRow();

          



        }


        private void InvoiceBody(PdfWriter writer)
        {
            #region Table header
            _fontStyle = FontFactory.GetFont("Tahoma", 12f, 1);

            _pdfCell = new PdfPCell(new Phrase("ID", _fontStyle));
            _pdfCell.HorizontalAlignment = Element.ALIGN_CENTER;
            _pdfCell.VerticalAlignment = Element.ALIGN_MIDDLE;
            _pdfCell.BackgroundColor = BaseColor.LIGHT_GRAY;
            _pdfTable.AddCell(_pdfCell);

            _pdfCell = new PdfPCell(new Phrase("Service Provider", _fontStyle));
            _pdfCell.HorizontalAlignment = Element.ALIGN_CENTER;
            _pdfCell.VerticalAlignment = Element.ALIGN_MIDDLE;
            _pdfCell.BackgroundColor = BaseColor.LIGHT_GRAY;
            _pdfTable.AddCell(_pdfCell);

            _pdfCell = new PdfPCell(new Phrase("Service Price", _fontStyle));
            _pdfCell.HorizontalAlignment = Element.ALIGN_CENTER;
            _pdfCell.VerticalAlignment = Element.ALIGN_MIDDLE;
            _pdfCell.BackgroundColor = BaseColor.LIGHT_GRAY;
            _pdfTable.AddCell(_pdfCell);
           

            _pdfCell = new PdfPCell(new Phrase("Service Qte/Hour", _fontStyle));
            _pdfCell.HorizontalAlignment = Element.ALIGN_CENTER;
            _pdfCell.VerticalAlignment = Element.ALIGN_MIDDLE;
            _pdfCell.BackgroundColor = BaseColor.LIGHT_GRAY;
            _pdfTable.AddCell(_pdfCell);

            _pdfCell = new PdfPCell(new Phrase("Service Total Price", _fontStyle));
            _pdfCell.HorizontalAlignment = Element.ALIGN_CENTER;
            _pdfCell.VerticalAlignment = Element.ALIGN_MIDDLE;
            _pdfCell.BackgroundColor = BaseColor.LIGHT_GRAY;
            _pdfTable.AddCell(_pdfCell);
            _pdfTable.CompleteRow();
            #endregion

            #region Table Body
            _fontStyle = FontFactory.GetFont("Tahoma", 10f, 0);

            var _invoiceLines = _invoice.InvoiceLines;
            int total = 0;
            foreach (InvoiceLineDto line in _invoiceLines)
            {
                _pdfCell = new PdfPCell(new Phrase(line.Id.ToString(), _fontStyle));
                _pdfCell.HorizontalAlignment = Element.ALIGN_CENTER;
                _pdfCell.VerticalAlignment = Element.ALIGN_MIDDLE;
                _pdfCell.BackgroundColor = BaseColor.WHITE;
                _pdfCell.FixedHeight = 50f;
                _pdfTable.AddCell(_pdfCell);
               

                _pdfCell = new PdfPCell(new Phrase(line.Service.Provider.ToString(), _fontStyle));
                _pdfCell.HorizontalAlignment = Element.ALIGN_CENTER;
                _pdfCell.VerticalAlignment = Element.ALIGN_MIDDLE;
                _pdfCell.BackgroundColor = BaseColor.WHITE;
                _pdfTable.AddCell(_pdfCell);

                _pdfCell = new PdfPCell(new Phrase(line.Service.Price.ToString(), _fontStyle));
                _pdfCell.HorizontalAlignment = Element.ALIGN_CENTER;
                _pdfCell.VerticalAlignment = Element.ALIGN_MIDDLE;
                _pdfCell.BackgroundColor = BaseColor.WHITE;
                _pdfTable.AddCell(_pdfCell);

                _pdfCell = new PdfPCell(new Phrase(line.Qte.ToString(), _fontStyle));
                _pdfCell.HorizontalAlignment = Element.ALIGN_CENTER;
                _pdfCell.VerticalAlignment = Element.ALIGN_MIDDLE;
                _pdfCell.BackgroundColor = BaseColor.WHITE;
                _pdfTable.AddCell(_pdfCell);

                _pdfCell = new PdfPCell(new Phrase((line.Qte * line.Service.Price).ToString(), _fontStyle));
                _pdfCell.HorizontalAlignment = Element.ALIGN_CENTER;
                _pdfCell.VerticalAlignment = Element.ALIGN_MIDDLE;
                _pdfCell.BackgroundColor = BaseColor.WHITE;

                _pdfTable.AddCell(_pdfCell);
                _pdfTable.CompleteRow();
                line.PageNumber = 1;
                if (line.Id >= 19) 
                {
                    line.PageNumber = 2;
                }
          

                total += (line.Qte * line.Service.Price);

            }

            
           
            InvoiceFooter footer = new InvoiceFooter(_invoiceLines);
            writer.PageEvent = footer;



            _pdfCell = new PdfPCell(new Phrase("", _fontStyle));
            _pdfCell.Colspan = 3;
            _pdfCell.Border = 0;
            _pdfTable.AddCell(_pdfCell);


            _pdfCell = new PdfPCell(new Phrase("Total Price :", _fontStyle));
            _pdfCell.HorizontalAlignment = Element.ALIGN_RIGHT;
            _pdfCell.VerticalAlignment = Element.ALIGN_MIDDLE;
            _pdfCell.BorderWidthRight= 0;
            _pdfCell.BackgroundColor = BaseColor.LIGHT_GRAY;
            
            _pdfTable.AddCell(_pdfCell);

            _pdfCell = new PdfPCell(new Phrase( total+"  Dt", _fontStyle));
            _pdfCell.HorizontalAlignment = Element.ALIGN_CENTER;
            _pdfCell.VerticalAlignment = Element.ALIGN_MIDDLE;
           
            _pdfCell.BackgroundColor = BaseColor.LIGHT_GRAY;
            _pdfTable.AddCell(_pdfCell);
            _pdfTable.CompleteRow();

            #endregion
            
        }

        private void InvoiceBody2(PdfWriter writer)
        {
            _fontStyle = FontFactory.GetFont("Tahoma", 12f, 1);

            _document.Add(new Paragraph($" ID    |    Service Provider    | Service Price |    Service Qte/Hour    |    Service Total Price "));

            var _invoiceLines = _invoice.InvoiceLines;
            int total = 0;
            foreach (InvoiceLineDto line in _invoiceLines)
            {
                _document.Add(new Paragraph($" {line.Id.ToString()}  |   {line.Service.Provider.ToString()}  | {line.Service.Price.ToString()} |   {line.Qte.ToString()}   |  {(line.Qte * line.Service.Price).ToString()} "));
                _document.Add(new Paragraph("  "));
                _document.Add(new Paragraph("  "));

                line.PageNumber = writer.CurrentPageNumber;

                total += (line.Qte * line.Service.Price);
                InvoiceFooter footer = new InvoiceFooter(_invoiceLines);
                writer.PageEvent = footer;
            }
           
            _document.Add(new Paragraph($"Total Price :{total}  "));

           

            // Call OnOpenDocument method of footer manually to add the footer to the first page
                                 
        }
    }
}

