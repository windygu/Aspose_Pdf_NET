//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Pdf. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Pdf;
using Aspose.Pdf.InteractiveFeatures.Forms;

namespace MoveFormField
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // The path to the documents directory.
            string dataDir = Path.GetFullPath("../../../Data/");

            //open document
            Document pdfDocument = new Document(dataDir + "input.pdf");

            //get a field
            TextBoxField textBoxField = pdfDocument.Form["textbox1"] as TextBoxField;

            //modify field location
            textBoxField.Rect = new Aspose.Pdf.Rectangle(300, 400, 600, 500);

            //save modified document
            pdfDocument.Save(dataDir + "output.pdf");

        }
    }
}