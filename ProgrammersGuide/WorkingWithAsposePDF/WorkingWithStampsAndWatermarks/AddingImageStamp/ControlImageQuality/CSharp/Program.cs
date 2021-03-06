//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Pdf. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Pdf;

namespace ControlImageQuality
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // The path to the documents directory.
            string dataDir = Path.GetFullPath("../../../Data/");

            Document doc = new Document(dataDir+ "input.pdf");
            ImageStamp stamp = new ImageStamp(dataDir + "aspose-logo.jpg");
            stamp.Quality = 10;
            doc.Pages[1].AddStamp(stamp);
            doc.Save(dataDir + "output.pdf");
            
            
        }
    }
}