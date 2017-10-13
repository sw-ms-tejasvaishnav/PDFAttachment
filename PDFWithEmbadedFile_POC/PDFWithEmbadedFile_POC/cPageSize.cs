using System;
namespace PDFWithEmbadedFile_POC
{
    /// <summary>
    /// The cPageSize-object contains a number of read only iTextSharp.text.Rectangles representing the most common paper sizes.
    /// The cPageSize contains custome constroctor to create document with custome background color, and having number of known pagesizes
    /// </summary>
    /// <seealso cref="T:iTextSharp.text.iTextSharp.text.Rectangle"/>
    public class cPageSize
    {
        public static iTextSharp.text.Rectangle GetDocumentWithBackroundColor(iTextSharp.text.Rectangle pageSize, iTextSharp.text.BaseColor backgroundColor)
        {
            pageSize.BackgroundColor = backgroundColor;
            return pageSize;
        }

        // membervariables

        /** This is the letter format */
        public static readonly iTextSharp.text.Rectangle LETTER = new iTextSharp.text.Rectangle(612, 792);

        /** This is the note format */
        public static readonly iTextSharp.text.Rectangle NOTE = new iTextSharp.text.Rectangle(540, 720);

        /** This is the legal format */
        public static readonly iTextSharp.text.Rectangle LEGAL = new iTextSharp.text.Rectangle(612, 1008);

        /** This is the tabloid format */
        public static readonly iTextSharp.text.Rectangle TABLOID = new iTextSharp.text.Rectangle(792, 1224);

        /** This is the executive format */
        public static readonly iTextSharp.text.Rectangle EXECUTIVE = new iTextSharp.text.Rectangle(522, 756);

        /** This is the postcard format */
        public static readonly iTextSharp.text.Rectangle POSTCARD = new iTextSharp.text.Rectangle(283, 416);

        /** This is the a0 format */
        public static readonly iTextSharp.text.Rectangle A0 = new iTextSharp.text.Rectangle(2384, 3370);

        /** This is the a1 format */
        public static readonly iTextSharp.text.Rectangle A1 = new iTextSharp.text.Rectangle(1684, 2384);

        /** This is the a2 format */
        public static readonly iTextSharp.text.Rectangle A2 = new iTextSharp.text.Rectangle(1191, 1684);

        /** This is the a3 format */
        public static readonly iTextSharp.text.Rectangle A3 = new iTextSharp.text.Rectangle(842, 1191);

        /** This is the a4 format */
        public static readonly iTextSharp.text.Rectangle A4 = new iTextSharp.text.Rectangle(595, 842);

        /** This is the a5 format */
        public static readonly iTextSharp.text.Rectangle A5 = new iTextSharp.text.Rectangle(420, 595);

        /** This is the a6 format */
        public static readonly iTextSharp.text.Rectangle A6 = new iTextSharp.text.Rectangle(297, 420);

        /** This is the a7 format */
        public static readonly iTextSharp.text.Rectangle A7 = new iTextSharp.text.Rectangle(210, 297);

        /** This is the a8 format */
        public static readonly iTextSharp.text.Rectangle A8 = new iTextSharp.text.Rectangle(148, 210);

        /** This is the a9 format */
        public static readonly iTextSharp.text.Rectangle A9 = new iTextSharp.text.Rectangle(105, 148);

        /** This is the a10 format */
        public static readonly iTextSharp.text.Rectangle A10 = new iTextSharp.text.Rectangle(73, 105);

        /** This is the b0 format */
        public static readonly iTextSharp.text.Rectangle B0 = new iTextSharp.text.Rectangle(2834, 4008);

        /** This is the b1 format */
        public static readonly iTextSharp.text.Rectangle B1 = new iTextSharp.text.Rectangle(2004, 2834);

        /** This is the b2 format */
        public static readonly iTextSharp.text.Rectangle B2 = new iTextSharp.text.Rectangle(1417, 2004);

        /** This is the b3 format */
        public static readonly iTextSharp.text.Rectangle B3 = new iTextSharp.text.Rectangle(1000, 1417);

        /** This is the b4 format */
        public static readonly iTextSharp.text.Rectangle B4 = new iTextSharp.text.Rectangle(708, 1000);

        /** This is the b5 format */
        public static readonly iTextSharp.text.Rectangle B5 = new iTextSharp.text.Rectangle(498, 708);

        /** This is the b6 format */
        public static readonly iTextSharp.text.Rectangle B6 = new iTextSharp.text.Rectangle(354, 498);

        /** This is the b7 format */
        public static readonly iTextSharp.text.Rectangle B7 = new iTextSharp.text.Rectangle(249, 354);

        /** This is the b8 format */
        public static readonly iTextSharp.text.Rectangle B8 = new iTextSharp.text.Rectangle(175, 249);

        /** This is the b9 format */
        public static readonly iTextSharp.text.Rectangle B9 = new iTextSharp.text.Rectangle(124, 175);

        /** This is the b10 format */
        public static readonly iTextSharp.text.Rectangle B10 = new iTextSharp.text.Rectangle(87, 124);

        /** This is the archE format */
        public static readonly iTextSharp.text.Rectangle ARCH_E = new iTextSharp.text.Rectangle(2592, 3456);

        /** This is the archD format */
        public static readonly iTextSharp.text.Rectangle ARCH_D = new iTextSharp.text.Rectangle(1728, 2592);

        /** This is the archC format */
        public static readonly iTextSharp.text.Rectangle ARCH_C = new iTextSharp.text.Rectangle(1296, 1728);

        /** This is the archB format */
        public static readonly iTextSharp.text.Rectangle ARCH_B = new iTextSharp.text.Rectangle(864, 1296);

        /** This is the archA format */
        public static readonly iTextSharp.text.Rectangle ARCH_A = new iTextSharp.text.Rectangle(648, 864);

        /** This is the American Foolscap format */
        public static readonly iTextSharp.text.Rectangle FLSA = new iTextSharp.text.Rectangle(612, 936);

        /** This is the European Foolscap format */
        public static readonly iTextSharp.text.Rectangle FLSE = new iTextSharp.text.Rectangle(648, 936);

        /** This is the halfletter format */
        public static readonly iTextSharp.text.Rectangle HALFLETTER = new iTextSharp.text.Rectangle(396, 612);

        /** This is the 11x17 format */
        public static readonly iTextSharp.text.Rectangle _11X17 = new iTextSharp.text.Rectangle(792, 1224);

        /** This is the ISO 7810 ID-1 format (85.60 x 53.98 mm or 3.370 x 2.125 inch) */
        public static readonly iTextSharp.text.Rectangle ID_1 = new iTextSharp.text.Rectangle(242.65f, 153);

        /** This is the ISO 7810 ID-2 format (A7 rotated) */
        public static readonly iTextSharp.text.Rectangle ID_2 = new iTextSharp.text.Rectangle(297, 210);

        /** This is the ISO 7810 ID-3 format (B7 rotated) */
        public static readonly iTextSharp.text.Rectangle ID_3 = new iTextSharp.text.Rectangle(354, 249);

        /** This is the ledger format */
        public static readonly iTextSharp.text.Rectangle LEDGER = new iTextSharp.text.Rectangle(1224, 792);

        /** This is the Crown Quarto format */
        public static readonly iTextSharp.text.Rectangle CROWN_QUARTO = new iTextSharp.text.Rectangle(535, 697);

        /** This is the Large Crown Quarto format */
        public static readonly iTextSharp.text.Rectangle LARGE_CROWN_QUARTO = new iTextSharp.text.Rectangle(569, 731);

        /** This is the Demy Quarto format. */
        public static readonly iTextSharp.text.Rectangle DEMY_QUARTO = new iTextSharp.text.Rectangle(620, 782);

        /** This is the Royal Quarto format. */
        public static readonly iTextSharp.text.Rectangle ROYAL_QUARTO = new iTextSharp.text.Rectangle(671, 884);

        /** This is the Crown Octavo format */
        public static readonly iTextSharp.text.Rectangle CROWN_OCTAVO = new iTextSharp.text.Rectangle(348, 527);

        /** This is the Large Crown Octavo format */
        public static readonly iTextSharp.text.Rectangle LARGE_CROWN_OCTAVO = new iTextSharp.text.Rectangle(365, 561);

        /** This is the Demy Octavo format */
        public static readonly iTextSharp.text.Rectangle DEMY_OCTAVO = new iTextSharp.text.Rectangle(391, 612);

        /** This is the Royal Octavo format. */
        public static readonly iTextSharp.text.Rectangle ROYAL_OCTAVO = new iTextSharp.text.Rectangle(442, 663);

        /** This is the small paperback format. */
        public static readonly iTextSharp.text.Rectangle SMALL_PAPERBACK = new iTextSharp.text.Rectangle(314, 504);

        /** This is the Pengiun small paperback format. */
        public static readonly iTextSharp.text.Rectangle PENGUIN_SMALL_PAPERBACK = new iTextSharp.text.Rectangle(314, 513);

        /** This is the Penguin large paparback format. */
        public static readonly iTextSharp.text.Rectangle PENGUIN_LARGE_PAPERBACK = new iTextSharp.text.Rectangle(365, 561);


        /**
        * This method returns a iTextSharp.text.Rectangle based on a String.
        * Possible values are the the names of a constant in this class
        * (for instance "A4", "LETTER",...) or a value like "595 842"
        */
        public static iTextSharp.text.Rectangle GetRectangle(String name)
        {
            name = name.Trim().ToUpper(System.Globalization.CultureInfo.InvariantCulture);
            int pos = name.IndexOf(' ');
            if (pos == -1)
            {
                try
                {
                    return (iTextSharp.text.Rectangle)typeof(iTextSharp.text.PageSize).GetField(name).GetValue(null);
                }
                catch (Exception)
                {
                    throw new ArgumentException(iTextSharp.text.error_messages.MessageLocalization.GetComposedMessage("can.t.find.page.size.1", name));
                }
            }
            else
            {
                try
                {
                    String width = name.Substring(0, pos);
                    String height = name.Substring(pos + 1);
                    return new iTextSharp.text.Rectangle(float.Parse(width, System.Globalization.NumberFormatInfo.InvariantInfo), float.Parse(height, System.Globalization.NumberFormatInfo.InvariantInfo));
                }
                catch (Exception e)
                {
                    throw new ArgumentException(iTextSharp.text.error_messages.MessageLocalization.GetComposedMessage("1.is.not.a.valid.page.size.format.2", name, e.Message));
                }
            }
        }
    }
}