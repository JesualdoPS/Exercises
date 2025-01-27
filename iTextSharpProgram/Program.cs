using PdfConverterLibrary;

namespace PdfConverterProgram
{
    public class Program
    {
        static void Main(string[] args)
        {
            var converter = new PdfConverter();
            string pdfFilePath = "E:\\Downloads\\PotatoBeetle.pdf";
            string imagePath = "E:\\Downloads\\ConvertedImages";
            int pages = 2;
            converter.PDFtoImage(pdfFilePath, pages, imagePath);
            Console.WriteLine("Success");
        }
    }
}