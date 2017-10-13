using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;

namespace PDFWithEmbadedFile_POC
{
    public class Core
    {
        public Core()
        {

        }

        public void CreatePDFFile(string strPDFPath, string attachment, string password)
        {
            try
            {
                string fileName = Path.GetFileName(attachment);

                using (Document document = new Document(cPageSize.GetDocumentWithBackroundColor(cPageSize.A4, new BaseColor(245, 245, 245)), 0f, 0f, 0f, 17f))
                {
                    using (FileStream pdf = new FileStream(strPDFPath, FileMode.Create, FileAccess.Write, FileShare.None))
                    {
                        using (PdfWriter pdfWriter = PdfWriter.GetInstance(document, pdf))
                        {
                            document.Open();

                            document.Add(new Paragraph("Attached files:"));


                            var fs = PdfFileSpecification.FileEmbedded(pdfWriter, attachment, fileName, null);

                            //var rect = new Rectangle(10000f,10000f);
                            Rectangle rect = new Rectangle(100, 400, 500, 800);
                            rect.Border = Rectangle.BOX;
                            rect.BorderWidth = 0.5f;
                            rect.BorderColor  = new BaseColor(0xFF, 0x00, 0x00);

                            fs.AddDescription(fileName, false);
                            PdfAnnotation annotation = new PdfAnnotation(pdfWriter, rect);
                            annotation.Put(PdfName.NAME, PdfName.ANNOT);
                            annotation.Put(PdfName.SUBTYPE, PdfName.FILEATTACHMENT);
                            annotation.Put(PdfName.CONTENTS, new PdfString(fileName));
                            annotation.Put(PdfName.FS, fs.Reference);

                            //PdfTemplate tmp = PdfTemplate.CreateTemplate(pdfWriter, document.PageSize.Width, 100);
                            PdfAppearance ap = pdfWriter.DirectContent.CreateAppearance(rect.Width, rect.Height);
                            annotation.SetAppearance(PdfAnnotation.APPEARANCE_NORMAL, ap);                          

                            Chunk linkChunk = new Chunk(fileName);
                            linkChunk.SetAnnotation(annotation);
                            Phrase phrase = new Phrase();
                            phrase.Add(linkChunk);
                            document.Add(phrase);
                            


                            document.Close();
                            pdfWriter.Close();
                            pdfWriter.Dispose();

                        }
                        pdf.Close();
                        pdf.Dispose();
                    }
                    document.Dispose();
                }
            }
            catch (Exception ex)
            {

            }

            PasswordProtectPDF(strPDFPath, password);
        }     
        
        
        
        public void CreatePDFFile_old(string strPDFPath, string attachment, string password)
        {
            try
            {
                string fileName = Path.GetFileName(attachment);

                using (Document document = new Document(cPageSize.GetDocumentWithBackroundColor(cPageSize.A4, new BaseColor(245, 245, 245)), 0f, 0f, 0f, 17f))
                {
                    using (FileStream pdf = new FileStream(strPDFPath, FileMode.Create, FileAccess.Write, FileShare.None))
                    {
                        using (PdfWriter pdfWriter = PdfWriter.GetInstance(document, pdf))
                        {
                            document.Open();
                            var fs = PdfFileSpecification.FileEmbedded(pdfWriter, attachment, fileName, null);

                            fs.AddDescription(fileName, false);
                            PdfAnnotation annotation = new PdfAnnotation(pdfWriter, new Rectangle(1550f, 50f, 150f, 500f));
                            annotation.Put(PdfName.SUBTYPE, PdfName.FILEATTACHMENT);
                            annotation.Put(PdfName.CONTENTS, new PdfString(fileName));
                            annotation.Put(PdfName.FS, fs.Reference);

                            document.Add(new Paragraph("Attached files:"));

                            Chunk linkChunk = new Chunk("this is what we need to achive using pdfanotation");
                            linkChunk.SetAnnotation(annotation);
                            Phrase phrase = new Phrase();
                            phrase.Add(linkChunk);
                            document.Add(phrase);
                            document.Close();
                            pdfWriter.Close();
                            pdfWriter.Dispose();

                        }
                        pdf.Close();
                        pdf.Dispose();
                    }
                    document.Dispose();
                }
            }
            catch (Exception ex)
            {

            }

            PasswordProtectPDF(strPDFPath, password);
        }
        public void CreatePDFFile111(string strPDFPath, string attachment)
        {
            try
            {
                if (!File.Exists(attachment))
                    throw new FileNotFoundException("File Not Found", attachment);


                string fileName = Path.GetFileName(attachment);
                string fileNameWithOutExt = Path.GetFileNameWithoutExtension(attachment);
                using (Document document = new Document(cPageSize.GetDocumentWithBackroundColor(cPageSize.A4, new BaseColor(245, 245, 245)), 0f, 0f, 0f, 17f))
                {
                    using (FileStream pdf = new FileStream(strPDFPath, FileMode.Create, FileAccess.Write, FileShare.None))
                    {
                        using (PdfWriter pdfWriter = PdfWriter.GetInstance(document, pdf))
                        {
                            document.Open();
                            var fs = PdfFileSpecification.FileEmbedded(pdfWriter, attachment, fileName, null);

                            fs.AddDescription(fileNameWithOutExt, false);
                            //pdfWriter.AddFileAttachment(fs);
                            Rectangle rec = new Rectangle(150, 150);
                            //PdfAnnotation annotation = PdfAnnotation.CreateFileAttachment(pdfWriter, rec, fileName, fs);

                            //PdfAnnotation annotation = PdfAnnotation.CreateFileAttachment(pdfWriter, new iTextSharp.text.Rectangle(100, 200), "Link", fs);
                            //chapter1.Add(annotation);

                            PdfAnnotation annotation = new PdfAnnotation(pdfWriter, rec);
                            annotation.Put(PdfName.SUBTYPE, PdfName.FILEATTACHMENT);
                            annotation.Put(PdfName.FS, fs.Reference);
                            //annotation.Put(PdfName.CONTENTS, new PdfString(fileName));


                            document.Add(new Paragraph("Attached files:"));

                            Chunk linkChunk = new Chunk("Click Here to Download");
                            linkChunk.SetAnnotation(annotation);
                            Phrase phrase = new Phrase();
                            phrase.Add(linkChunk);

                            //PdfAction action = PdfAction.

                            //pdfWriter.AddFileAttachment(fileNameWithOutExt, StrToByteArray(attachment), fileName, fileNameWithOutExt);

                            //PdfAnnotation action = PdfAnnotation.CreateFileAttachment(pdfWriter, null, fileName, fs);
                            //PdfAnnotation action = PdfAnnotation.CreateFileAttachment(pdfWriter, null, fileName, null, attachment, fileNameWithOutExt);
                            //Paragraph pa = new Paragraph();
                            //Chunk chk1 = new Chunk("click here");

                            //chk1.SetAnchor("https://www.google.com");
                            //chk1.SetAnnotation(action);
                            //pa.Add(chk1);
                            document.Add(phrase);
                            document.Close();
                            pdfWriter.Close();
                            pdfWriter.Dispose();

                        }
                        pdf.Close();
                        pdf.Dispose();
                    }
                    document.Dispose();
                }
            }
            catch (Exception ex)
            {

            }
        }
        //public void EmbadedFileToPDF(string strPDFPath, List<string> fileToEmbad)
        //{
        //    PdfReader reader = new PdfReader(strPDFPath);
        //    PdfStamper stamper = new PdfStamper(reader, new FileOutputStream(dest));

        //}


        //Additional Function
        private static void PasswordProtectPDF(string strPDFPath, string strPassword)
        {
            try
            {
                Stream input = new FileStream(strPDFPath, FileMode.Open, FileAccess.Read, FileShare.Read);
                byte[] btSourceFile = StreamToByteArray(input);
                input.Close();

                using (Stream output = new FileStream(strPDFPath, FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    PdfReader reader = new PdfReader(btSourceFile);
                    PdfReader.unethicalreading = true;

                    PdfEncryptor.Encrypt(reader, output, true, strPassword, strPassword, PdfWriter.ALLOW_PRINTING | PdfWriter.AllowFillIn | PdfWriter.AllowScreenReaders | PdfWriter.ENCRYPTION_AES_128);

                    reader.Close();
                    //PdfEncryptor.IsPrintingAllowed(PdfWriter.ALLOW_PRINTING);
                }
            }
            catch (Exception ex)
            {
                if (ex.Message == "Bad user password")
                {
                    throw new Exception("Document is password protected");
                }
                else
                {
                    throw ex;
                }
            }
        }

        private static byte[] StreamToByteArray(Stream inputStream)
        {
            if (!inputStream.CanRead)
            {
                throw new ArgumentException();
            }

            // This is optional
            if (inputStream.CanSeek)
            {
                inputStream.Seek(0, SeekOrigin.Begin);
            }

            byte[] output = new byte[inputStream.Length];
            int bytesRead = inputStream.Read(output, 0, output.Length);
            Debug.Assert(bytesRead == output.Length, "Bytes read from stream matches stream length");
            return output;
        }
        private static byte[] StrToByteArray(string str)
        {
            System.Text.UTF8Encoding encoding = new System.Text.UTF8Encoding();
            return encoding.GetBytes(str);
        }
    }
}
