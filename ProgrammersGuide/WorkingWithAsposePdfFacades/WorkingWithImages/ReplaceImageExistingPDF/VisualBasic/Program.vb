'////////////////////////////////////////////////////////////////////////
' Copyright 2001-2014 Aspose Pty Ltd. All Rights Reserved.
'
' This file is part of Aspose.Pdf. The source code in this file
' is only intended as a supplement to the documentation, and is provided
' "as is", without warranty of any kind, either expressed or implied.
'////////////////////////////////////////////////////////////////////////

Imports Microsoft.VisualBasic
Imports System.IO

Imports Aspose.Pdf
Imports Aspose.Pdf.Facades

Namespace ReplaceImageExistingPDFExample
	Public Class Program
		Public Shared Sub Main()
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")
			'open input PDF
			Dim pdfContentEditor As New PdfContentEditor()
			pdfContentEditor.BindPdf(dataDir & "input.pdf")
			'replace image on a particular page
			pdfContentEditor.ReplaceImage(1, 1, dataDir & "aspose-logo.jpg")
			'save output PDF
			pdfContentEditor.Save(dataDir & "output.pdf")


		End Sub
	End Class
End Namespace