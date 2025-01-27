using SautinSoft;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace PdfConverterLibrary
{
    public class PdfConverter
    {
        public void PDFtoImage(string pdfPath, int pages, string imagePath, int dpi = 400)
        {
            try
            {
                byte[] pdfBytes = ExtractPages(pdfPath, pages);
                var newPdf = new MemoryStream(pdfBytes);
                string tempPdfPath = Path.GetTempFileName() + ".pdf";

                using (var fs = new FileStream(tempPdfPath, FileMode.Create))
                {
                    newPdf.WriteTo(fs);
                }

                var pdf = new PdfFocus();
                pdf.OpenPdf(tempPdfPath);
                if (pdf.PageCount > 0)
                {
                    pdf.ImageOptions.Dpi = dpi;
                    pdf.ToImages(imagePath, $"Output.");
                }
                pdf.ClosePdf();
                File.Delete(tempPdfPath);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        private byte[] ExtractPages(string pdfPath, int pages)
        {
            try
            {
                var pdfReader = new PdfReader(pdfPath);
                var doc = new Document();
                var memoryStream = new MemoryStream();
                var copy = new PdfCopy(doc, memoryStream);
                doc.Open();

                for (int i = 1; i <= pages; i++)
                {
                    if (i > 0 && i <= pdfReader.NumberOfPages)
                    {
                        copy.AddPage(copy.GetImportedPage(pdfReader, i));
                    }
                    else
                    {
                        throw new ArgumentException($"Page {i} does not exists");
                    }
                }

                doc.Close();
                pdfReader.Close();
                return memoryStream.ToArray();
            }
            catch (ArgumentException ex)
            {
                throw new Exception($"Error extracting pages: {ex.Message}");
            }
            catch (IOException ex)
            {
                throw new Exception($"Error reading or writing file: {ex.Message}");
            }
            catch (OutOfMemoryException)
            {
                throw new Exception($"Error: out of memory");
            }
            catch (Exception ex)
            {
                throw new Exception($"Error extracting pages: {ex.Message}");
            }
        }
    }
}

