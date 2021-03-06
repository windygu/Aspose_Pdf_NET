//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2014 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Pdf. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Pdf;
using Aspose.Pdf.Facades;

namespace ChangePositionOfAStampExample
{
    public class Program
    {
        public static void Main()
        {
            // The path to the documents directory.
            string dataDir = Path.GetFullPath("../../../Data/");

            //Instantiate PdfContentEditor Object
            PdfContentEditor pdfContentEditor = new PdfContentEditor();

            ////bind input PDF file
            pdfContentEditor.BindPdf(dataDir+ "input.pdf");

            int pageId = 1;
            int stampIndex = 1;
            double x = 200;
            double y = 200;

            //Change the position of the stamp to new x and y position
            pdfContentEditor.MoveStamp(pageId, stampIndex, x, y);

            //Save the PDF file
            pdfContentEditor.Save(dataDir+ "output.pdf");
        }
    }
}