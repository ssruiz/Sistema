Imports System.Drawing
Imports System.IO
Imports System.Net.Mail
Imports System.Net.Mime
Imports Microsoft.Office.Interop
Imports Microsoft.Office.Interop.Excel
Imports GemBox.Spreadsheet

Module Module1
    'Dim pathFile = ""
    'Sub Main()
    '    SpreadsheetInfo.SetLicense("FREE-LIMITED-KEY")
    '    Try
    '        Dim pathI = Config.RutaInformes
    '        Dim mes = Date.Today.Month
    '        Dim anho = Date.Today.Year
    '        Dim pathImg = Path.Combine(pathI, mes.ToString + "_" + anho.ToString)
    '        pathImg = pathImg + ".xls"
    '        pathFile = pathImg
    '        ' pathImg = Path.Combine(pathImg, mes)
    '        If My.Computer.FileSystem.FileExists(pathImg) Then
    '            Dim xlApp As New Excel.Application
    '            Dim xlWorkbook As Excel.Workbook = xlApp.Workbooks.Open(pathImg)
    '            Dim xlWorksheet As Excel.Worksheet = CType(xlWorkbook.Sheets(1), Excel.Worksheet)
    '            Dim lastRow As Integer = 0 'xlWorksheet.UsedRange.Rows.Count
    '            Dim r2 As Excel.Range
    '            'Dim lastrow As Integer

    '            'r2 = xlWorksheet.Range("A") 'Task_ID is my column name
    '            lastRow = xlWorksheet.Range("A4000").End(Excel.XlDirection.xlUp).Row + 1
    '            'MsgBox(lastRow)
    '            'MsgBox(lastRow)
    '            xlWorksheet.Rows(lastRow + 1).EntireRow.Insert()

    '            Dim range = xlWorksheet.Range("A" + lastRow.ToString + ":F2")
    '            Dim daoc As New Consultas
    '            xlWorksheet.Cells(lastRow, 1) = Date.Today
    '            ' xlWorksheet.Cells(1, 1).interior.color = Color.Green

    '            xlWorksheet.Cells(lastRow, 2) = daoc.getVentasM2()

    '            'xlWorksheet.Cells(1, 2).interior.color = Color.Green


    '            xlWorksheet.Cells(lastRow, 3) = daoc.getCorte()
    '            'xlWorksheet.Cells(1, 3).interior.color = Color.Green


    '            xlWorksheet.Cells(lastRow, 4) = daoc.getProduccion()
    '            ' xlWorksheet.Cells(1, 4).interior.color = Color.Green


    '            xlWorksheet.Cells(lastRow, 5) = daoc.getPendientes()
    '            xlWorksheet.Cells(lastRow, 6) = daoc.getReposicionesDia()
    '            xlWorksheet.Cells(lastRow, 7) = daoc.getEfectivoDia
    '            xlWorksheet.Cells(lastRow, 8) = daoc.getChequesDia()

    '            ' xlWorksheet.Cells(1, 5).interior.color = Color.Green

    '            Dim strCurrency = Chr(34) & "₲" & Chr(34)
    '            xlWorksheet.Range("I" + lastRow.ToString).Formula = "=SUM($F$" + lastRow.ToString + ":G$" + lastRow.ToString + ")"
    '            xlWorksheet.Range("I" + lastRow.ToString).NumberFormat = String.Format("{0}###,##0_0;({0}#,##0)", strCurrency)
    '            xlWorksheet.Range("H" + lastRow.ToString).NumberFormat = String.Format("{0}###,##0_0;({0}#,##0)", strCurrency)
    '            xlWorksheet.Range("G" + lastRow.ToString).NumberFormat = String.Format("{0}###,##0_0;({0}#,##0)", strCurrency)

    '            With xlWorksheet.Range("A" + (lastRow).ToString + "", "I" + (lastRow).ToString + "")
    '                .Font.Bold = False
    '                .Font.Size = 11
    '                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
    '                .HorizontalAlignment = Excel.XlVAlign.xlVAlignCenter
    '                .Interior.Color = Color.FromArgb(92, 92, 92)
    '                .Font.Color = Color.White
    '                .EntireColumn.AutoFit()
    '                .Borders.LineStyle = Excel.XlLineStyle.xlContinuous
    '                .Borders.Color = Color.White
    '            End With
    '            ' xlWorksheet.Cells(1, 6).interior.color = Color.Green
    '            xlWorkbook.Save()
    '            xlWorkbook.Close()
    '            xlApp.Quit()

    '            releaseObject(xlApp)
    '            releaseObject(xlWorkbook)
    '            releaseObject(xlWorksheet)
    '            xlApp = Nothing
    '            xlWorksheet = Nothing
    '            xlWorkbook = Nothing
    '        Else
    '            'xlApp = New Excel.Application
    '            'If xlApp Is Nothing Then
    '            '    Console.Write("Excel is not properly installed!!")
    '            '    Return
    '            'Else
    '            '    Console.Write("Excel is properly installed!!")
    '            'End If
    '            Dim xlApp As New Excel.Application
    '            Dim xlWorkbook As Excel.Workbook = xlApp.Workbooks.Add()
    '            Dim xlWorksheet As Excel.Worksheet = CType(xlWorkbook.Sheets(1), Excel.Worksheet)
    '            Dim range = xlWorksheet.Range("A2:H3")

    '            With range.Borders
    '                .LineStyle = Excel.XlLineStyle.xlContinuous
    '                .Color = Color.White

    '            End With
    '            ' range.Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
    '            'range.BorderAround(LineStyleType.Medium, Color.Blue)
    '            xlWorksheet.Rows(1).RowHeight = 40
    '            xlWorksheet.Rows(2).RowHeight = 25
    '            '' TITULOS
    '            xlWorksheet.Cells(1, 1) = "MES: " + MonthName(Date.Today.Month) + " Año: " + Date.Today.Year.ToString
    '            xlWorksheet.Cells(1, 7) = "COBROS"

    '            xlWorksheet.Cells(2, 1) = "Fecha:"
    '            xlWorksheet.Cells(3, 1) = Date.Today
    '            Dim daoc As New Consultas
    '            ' xlWorksheet.Cells(1, 1).interior.color = Color.Green
    '            xlWorksheet.Cells(2, 2) = "Venta (m" & Chr(178) & ")"
    '            xlWorksheet.Cells(3, 2) = daoc.getVentasM2()

    '            'xlWorksheet.Cells(1, 2).interior.color = Color.Green

    '            xlWorksheet.Cells(2, 3) = "Corte (m" & Chr(178) & ")"
    '            xlWorksheet.Cells(3, 3) = daoc.getCorte()
    '            'xlWorksheet.Cells(1, 3).interior.color = Color.Green

    '            xlWorksheet.Cells(2, 4) = "Producción (m" & Chr(178) & ")"
    '            xlWorksheet.Cells(3, 4) = daoc.getProduccion()
    '            ' xlWorksheet.Cells(1, 4).interior.color = Color.Green

    '            xlWorksheet.Cells(2, 5) = "Pendiente (m" & Chr(178) & ")"
    '            xlWorksheet.Cells(3, 5) = daoc.getPendientes()

    '            xlWorksheet.Cells(2, 6) = "Reposiciones (m" & Chr(178) & ")"
    '            xlWorksheet.Cells(3, 6) = daoc.getReposicionesDia()

    '            ' xlWorksheet.Cells(1, 5).interior.color = Color.Green
    '            xlWorksheet.Cells(2, 7) = "Efectivo"
    '            xlWorksheet.Cells(3, 7) = daoc.getEfectivoDia()
    '            xlWorksheet.Cells(2, 8) = "Cheques"
    '            xlWorksheet.Cells(3, 8) = daoc.getChequesDia()
    '            xlWorksheet.Cells(2, 9) = "Totales (Efectivo + Cheques)"


    '            With xlWorksheet.Range("A2", "I2")
    '                .Font.Bold = True
    '                .Font.Size = 12
    '                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
    '                .HorizontalAlignment = Excel.XlVAlign.xlVAlignCenter
    '                .Interior.Color = Color.FromArgb(26, 51, 92)
    '                .Font.Color = Color.White
    '                .EntireColumn.AutoFit()
    '            End With

    '            With xlWorksheet.Range("A3", "I3")
    '                .Font.Bold = False
    '                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
    '                .HorizontalAlignment = Excel.XlVAlign.xlVAlignCenter
    '                .Interior.Color = Color.FromArgb(92, 92, 92)
    '                .Font.Color = Color.White
    '                .EntireColumn.AutoFit()
    '            End With

    '            With xlWorksheet.Range("A1", "F1")

    '                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
    '                .HorizontalAlignment = Excel.XlVAlign.xlVAlignCenter
    '                .Interior.Color = Color.FromArgb(69, 149, 35)
    '                .Font.Color = Color.White
    '                .Font.Size = 13


    '                .Borders.Color = Color.White
    '                .Borders.LineStyle = Excel.XlLineStyle.xlContinuous
    '                .Borders.Weight = Excel.XlBorderWeight.xlThick
    '                .MergeCells = True
    '            End With

    '            With xlWorksheet.Range("G1", "I1")

    '                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
    '                .HorizontalAlignment = Excel.XlVAlign.xlVAlignCenter
    '                .Interior.Color = Color.FromArgb(69, 149, 35)
    '                .Font.Color = Color.White
    '                .Font.Size = 13
    '                .Borders.Color = Color.White
    '                .Borders.LineStyle = Excel.XlLineStyle.xlContinuous
    '                .Borders.Weight = Excel.XlBorderWeight.xlThick
    '                .MergeCells = True
    '            End With


    '            '' TOTALES
    '            xlWorksheet.Cells(1, 11) = "TOTALES MES PRODUCCIÓN " + MonthName(Date.Today.Month)
    '            xlWorksheet.Cells(13, 11) = "TOTALES MES - COBROS: " + MonthName(Date.Today.Month)
    '            xlWorksheet.Cells(14, 11) = "Efectivo: "
    '            With xlWorksheet.Range("K14", "K15")
    '                .MergeCells = True
    '            End With

    '            xlWorksheet.Cells(16, 11) = "Cheques: "
    '            With xlWorksheet.Range("K16", "K17")
    '                .MergeCells = True
    '            End With

    '            xlWorksheet.Cells(18, 11) = "Totales: "
    '            With xlWorksheet.Range("K18", "K19")
    '                .MergeCells = True
    '            End With

    '            xlWorksheet.Cells(2, 11) = "Venta: (m" & Chr(178) & ")"
    '            With xlWorksheet.Range("K2", "K3")
    '                .MergeCells = True
    '            End With

    '            xlWorksheet.Cells(4, 11) = "Corte: (m" & Chr(178) & ")"
    '            With xlWorksheet.Range("K4", "K5")
    '                .MergeCells = True
    '            End With

    '            xlWorksheet.Cells(6, 11) = "Producción: (m" & Chr(178) & ")"
    '            With xlWorksheet.Range("K6", "K7")
    '                .MergeCells = True
    '            End With

    '            xlWorksheet.Cells(8, 11) = "Pendientes: (m" & Chr(178) & ")"
    '            With xlWorksheet.Range("K8", "K9")
    '                .MergeCells = True
    '            End With

    '            xlWorksheet.Cells(10, 11) = "Reposiciones: (m" & Chr(178) & ")"
    '            With xlWorksheet.Range("K10", "K11")
    '                .MergeCells = True
    '            End With

    '            With xlWorksheet.Range("K2", "K11")
    '                .Font.Bold = True
    '                .Font.Size = 12
    '                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
    '                .HorizontalAlignment = Excel.XlVAlign.xlVAlignCenter
    '                .Interior.Color = Color.FromArgb(26, 51, 92)
    '                .Font.Color = Color.White
    '                .EntireColumn.AutoFit()
    '                .Borders.LineStyle = Excel.XlLineStyle.xlContinuous
    '                .Borders.Color = Color.White
    '            End With

    '            With xlWorksheet.Range("K14", "K19")
    '                .Font.Bold = True
    '                .Font.Size = 12
    '                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
    '                .HorizontalAlignment = Excel.XlVAlign.xlVAlignCenter
    '                .Interior.Color = Color.FromArgb(26, 51, 92)
    '                .Font.Color = Color.White
    '                .EntireColumn.AutoFit()
    '                .Borders.LineStyle = Excel.XlLineStyle.xlContinuous
    '                .Borders.Color = Color.White
    '            End With

    '            With xlWorksheet.Range("K1", "M1")

    '                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
    '                .HorizontalAlignment = Excel.XlVAlign.xlVAlignCenter
    '                .Interior.Color = Color.FromArgb(69, 149, 35)
    '                .Font.Color = Color.White
    '                .Font.Size = 13
    '                .MergeCells = True
    '            End With

    '            With xlWorksheet.Range("K13", "M13")

    '                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
    '                .HorizontalAlignment = Excel.XlVAlign.xlVAlignCenter
    '                .Interior.Color = Color.FromArgb(69, 149, 35)
    '                .Font.Color = Color.White
    '                .Font.Size = 13
    '                .MergeCells = True
    '            End With

    '            xlWorksheet.Range("L2").Formula = "=SUM($B$3:B$34)"
    '            xlWorksheet.Range("L2").Formula = "=SUM($B$3:B$34)"
    '            xlWorksheet.Range("L4").Formula = "=SUM($C$3:C$34)"
    '            xlWorksheet.Range("L6").Formula = "=SUM($D$3:D$34)"
    '            xlWorksheet.Range("L8").Formula = "=SUM($E$3:E$34)"
    '            xlWorksheet.Range("L10").Formula = "=SUM($F$3:F$34)"

    '            Dim strCurrency = Chr(34) & "₲" & Chr(34)
    '            xlWorksheet.Range("L14").Formula = "=SUM($G$3:G$34)"
    '            xlWorksheet.Range("L14").NumberFormat = String.Format("{0}###,##0_0;({0}#,##0)", strCurrency)

    '            xlWorksheet.Range("L16").Formula = "=SUM($H$3:H$34)"
    '            xlWorksheet.Range("L16").NumberFormat = String.Format("{0}###,##0_0;({0}#,##0)", strCurrency)

    '            xlWorksheet.Range("L18").Formula = "=SUM($I$3:I$34)"
    '            xlWorksheet.Range("L18").NumberFormat = String.Format("{0}###,##0_0;({0}#,##0)", strCurrency)

    '            xlWorksheet.Range("I3").Formula = "=SUM($G$3:H$3)"
    '            xlWorksheet.Range("I3").NumberFormat = String.Format("{0}###,##0_0;({0}#,##0)", strCurrency)
    '            xlWorksheet.Range("H3").NumberFormat = String.Format("{0}###,##0_0;({0}#,##0)", strCurrency)
    '            xlWorksheet.Range("G3").NumberFormat = String.Format("{0}###,##0_0;({0}#,##0)", strCurrency)

    '            With xlWorksheet.Range("L2", "M3")

    '                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
    '                .HorizontalAlignment = Excel.XlVAlign.xlVAlignCenter
    '                .Interior.Color = Color.FromArgb(92, 92, 92)
    '                .Font.Color = Color.White
    '                .Font.Size = 13
    '                .Borders.LineStyle = Excel.XlLineStyle.xlContinuous
    '                .Borders.Color = Color.White
    '                .MergeCells = True
    '            End With

    '            With xlWorksheet.Range("L4", "M5")

    '                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
    '                .HorizontalAlignment = Excel.XlVAlign.xlVAlignCenter
    '                .Interior.Color = Color.FromArgb(92, 92, 92)
    '                .Font.Color = Color.White
    '                .Font.Size = 13
    '                .Borders.LineStyle = Excel.XlLineStyle.xlContinuous
    '                .Borders.Color = Color.White
    '                .MergeCells = True
    '            End With

    '            With xlWorksheet.Range("L6", "M7")

    '                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
    '                .HorizontalAlignment = Excel.XlVAlign.xlVAlignCenter
    '                .Interior.Color = Color.FromArgb(92, 92, 92)
    '                .Font.Color = Color.White
    '                .Font.Size = 13
    '                .Borders.LineStyle = Excel.XlLineStyle.xlContinuous
    '                .Borders.Color = Color.White
    '                .MergeCells = True
    '            End With

    '            With xlWorksheet.Range("L8", "M9")

    '                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
    '                .HorizontalAlignment = Excel.XlVAlign.xlVAlignCenter
    '                .Interior.Color = Color.FromArgb(92, 92, 92)
    '                .Font.Color = Color.White
    '                .Font.Size = 13
    '                .Borders.LineStyle = Excel.XlLineStyle.xlContinuous
    '                .Borders.Color = Color.White
    '                .MergeCells = True
    '            End With

    '            With xlWorksheet.Range("L10", "M11")

    '                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
    '                .HorizontalAlignment = Excel.XlVAlign.xlVAlignCenter
    '                .Interior.Color = Color.FromArgb(92, 92, 92)
    '                .Font.Color = Color.White
    '                .Font.Size = 13
    '                .Borders.LineStyle = Excel.XlLineStyle.xlContinuous
    '                .Borders.Color = Color.White
    '                .MergeCells = True
    '            End With

    '            With xlWorksheet.Range("L14", "M15")

    '                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
    '                .HorizontalAlignment = Excel.XlVAlign.xlVAlignCenter
    '                .Interior.Color = Color.FromArgb(92, 92, 92)
    '                .Font.Color = Color.White
    '                .Font.Size = 13
    '                .Borders.LineStyle = Excel.XlLineStyle.xlContinuous
    '                .Borders.Color = Color.White
    '                .MergeCells = True
    '            End With

    '            With xlWorksheet.Range("L16", "M17")

    '                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
    '                .HorizontalAlignment = Excel.XlVAlign.xlVAlignCenter
    '                .Interior.Color = Color.FromArgb(92, 92, 92)
    '                .Font.Color = Color.White
    '                .Font.Size = 13
    '                .Borders.LineStyle = Excel.XlLineStyle.xlContinuous
    '                .Borders.Color = Color.White
    '                .MergeCells = True
    '            End With

    '            With xlWorksheet.Range("L18", "M19")

    '                .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
    '                .HorizontalAlignment = Excel.XlVAlign.xlVAlignCenter
    '                .Interior.Color = Color.FromArgb(92, 92, 92)
    '                .Font.Color = Color.White
    '                .Font.Size = 13
    '                .Borders.LineStyle = Excel.XlLineStyle.xlContinuous
    '                .Borders.Color = Color.White
    '                .MergeCells = True
    '            End With
    '            'Dim oXLRange As Excel.Range
    '            'oXLRange = CType(xlWorksheet.Cells(2, 8), Excel.Range)
    '            'oXLRange.Formula = "SUM(B3:B3)"

    '            ''------------------
    '            xlWorksheet.SaveAs(pathImg)

    '            xlWorkbook.Close()
    '            xlApp.Quit()

    '            releaseObject(xlApp)
    '            releaseObject(xlWorkbook)
    '            releaseObject(xlWorksheet)
    '            releaseObject(range)
    '            range = Nothing
    '            xlApp = Nothing
    '            xlWorksheet = Nothing
    '            xlWorkbook = Nothing
    '            'xlApp.Quit()
    '        End If



    '        ' xlApp = New Microsoft.Office.Interop.Excel.Application()

    '        'releaseObject(xlApp)
    '        mandarMail()
    '        Console.Write("INFORME ENVIADO")



    '        'Threading.Thread.Sleep(1000)
    '    Catch ex As Exception
    '        Console.Write(ex.Message)
    '        Console.Read()
    '    End Try


    'End Sub


    'Private Sub mandarMail()
    '    Try
    '        Dim Smtp_Server As New SmtpClient
    '        Dim e_mail As New MailMessage()
    '        Smtp_Server.UseDefaultCredentials = False
    '        Smtp_Server.Credentials = New Net.NetworkCredential("sistema.casa.marco@gmail.com", "c@samarco--2019")
    '        Smtp_Server.Port = 587
    '        Smtp_Server.EnableSsl = True
    '        Smtp_Server.Host = "smtp.gmail.com"

    '        e_mail = New MailMessage()
    '        e_mail.From = New MailAddress("sistema.casa.marco@gmail.com")
    '        e_mail.To.Add("samuel.sebastian.ruiz@gmail.com")
    '        'e_mail.CC.Add("samuel.sebastian.ruiz@gmail.com")
    '        e_mail.Subject = "Oviedo Prueba"
    '        e_mail.IsBodyHtml = False
    '        e_mail.Body = "Informe dia " + Date.Today.ToShortDateString
    '        Dim attachment = New System.Net.Mail.Attachment(pathFile) 'file pat


    '        e_mail.Attachments.Add(attachment)
    '        Smtp_Server.Send(e_mail)
    '        Console.Write("Mail ENVIADO")
    '        MsgBox("Mail Sent")

    '    Catch error_t As Exception
    '        MsgBox(error_t.ToString)
    '    End Try
    'End Sub
    'Private Sub releaseObject(ByVal obj As Object)
    '    Try
    '        System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
    '        obj = Nothing
    '    Catch ex As Exception
    '        obj = Nothing
    '    Finally
    '        GC.Collect()
    '    End Try
    'End Sub
End Module
