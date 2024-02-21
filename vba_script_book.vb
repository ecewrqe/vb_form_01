Sub fillCellBackground_yellow()
    Set selectionArea = Selection()
    For Each singleCell In selectionArea
        singleCell.Interior.Color = 65535
    Next
End Sub

Sub fillCellBackground_green()
    Set selectionArea = Selection()
    For Each singleCell In selectionArea
        singleCell.Interior.Color = 5296274
    Next
End Sub

Sub fillCellBackground_blue()
    Set selectionArea = Selection()
    For Each singleCell In selectionArea
        singleCell.Interior.Color = 13998939
    Next
End Sub

Sub fillCellBackground_red()
    Set selectionArea = Selection()
    For Each singleCell In selectionArea
        selectionArea.Interior.Color = 255
    Next
End Sub

Sub cleanCellBackground()
    Set selectionArea = Selection()
    selectionArea.Interior.ColorIndex = 0
End Sub

Sub cleanCellStyle()
    Set selectionArea = Selection()
    selectionArea.ClearFormats
End Sub

Sub cleanCellLineStyle()
    Set selectionArea = Selection()
    selectionArea.Borders.LineStyle = xlLineStyleNone
End Sub

Sub DrawAdgeLineStyle()
    Set selectionArea = Selection()
    selectionArea.BorderAround LineStyle:=xlContinuous

End Sub

Sub DrawLineStyleThick()
    Set selectionArea = Selection()
    selectionArea.Borders.LineStyle = xlContinuous
    selectionArea.BorderAround LineStyle:=xlContinuous, Weight:=xlThick
End Sub

Sub DrawLineStyle()
    Set selectionArea = Selection()
    selectionArea.Borders.LineStyle = xlContinuouss
End Sub

Sub MergeCell()
    Set selectionArea = Selection()
    selectionArea.Merge
End Sub

Sub UnMergeCell()
    Set selectionArea = Selection()
    selectionArea.UnMerge
End Sub

Sub MergeCellByRow()
    Set selectionArea = Selection()
    For Each Row In selectionArea.Rows
        Row.Merge
    Next
End Sub

Sub MonthStrReplace()
    Set selectionArea = Selection()
    Dim Month As Integer

    Month = InputBox("月", Default:=-1)
    If Month <> -1 Then
        For Each singleCell In selectionArea
            singleCell.Value = Replace(singleCell.Value, "M", Month)
        Next
    End If
End Sub

Sub StrReplace()
    Set selectionArea = Selection()
    Dim Front As String, Back As String

    Front = "A"
    Back = "B"
    For Each singleCell In selectionArea
        singleCell.Value = Replace(singleCell.Value, Front, Back)
    Next
    
End Sub

Sub SelectBeginColumn()
    Set selectionArea = Selection()
    Set firstCell = selectionArea(1)
    Dim Col As Integer, Row As Integer

    Col = firstCell.Column
    Row = 1
    Cells(Row, Col).Select

End Sub

Sub SelectRowInSelectedColumn()
    Set selectionArea = Selection()
    Set firstCell = selectionArea(1)
    Dim Col As Integer, Row As Integer
    Col = firstCell.Column
    Row = InputBox("行", Default:=1)
    Cells(Row, Col).Select
    
End Sub

Sub selectLastColumn()
    Set selectionArea = Selection()
    Set firstCell = selectionArea(1)
    Dim Col As Integer, Row As Integer
    Col = firstCell.Column
    Row = Cells(Rows.Count, 1).End(xlUp).Row
    Cells(Row, Col).Select()
    
End Sub






Sub count_yellow()
    Set selectionArea = Selection()
    Dim cell_count As Integer
    Dim singleCellRange As Range
    Dim Count As Integer
    cell_count = 0
    For Each singleCell In selectionArea
        If singleCell.Interior.Color = 65535 Then
            If Range(singleCell.Address).MergeArea.Address Like singleCell.Address & "*" Then
                cell_count = cell_count + 1
            End If
        End If
    Next
    
    MsgBox cell_count
    
End Sub

Sub count_Green()
    Set selectionArea = Selection()
    Dim cell_count As Integer
    Dim singleCellRange As Range
    Dim Count As Integer
    cell_count = 0
    For Each singleCell In selectionArea
        If singleCell.Interior.Color = 5296274 Then
            If Range(singleCell.Address).MergeArea.Address Like singleCell.Address & "*" Then
                cell_count = cell_count + 1
            End If
        End If
    Next
    
    MsgBox cell_count
    
End Sub

Sub count_Blue()
    Set selectionArea = Selection()
    Dim cell_count As Integer
    Dim singleCellRange As Range
    Dim Count As Integer
    cell_count = 0
    For Each singleCell In selectionArea
        If singleCell.Interior.Color = 13998939 Then
            If Range(singleCell.Address).MergeArea.Address Like singleCell.Address & "*" Then
                cell_count = cell_count + 1
            End If
        End If
    Next
    
    MsgBox cell_count
    
End Sub

Sub count_Red()
    Set selectionArea = Selection()
    Dim cell_count As Integer
    Dim singleCellRange As Range
    Dim Count As Integer
    cell_count = 0
    For Each singleCell In selectionArea
        If singleCell.Interior.Color = 255 Then
            If Range(singleCell.Address).MergeArea.Address Like singleCell.Address & "*" Then
                cell_count = cell_count + 1
            End If
        End If
    Next
    
    MsgBox cell_count
    
End Sub


Sub count_Cell()
    Set selectionArea = Selection()
    Dim cell_count As Integer
    Dim singleCellRange As Range
    Dim Count As Integer
    cell_count = 0
    For Each singleCell In selectionArea
        If Range(singleCell.Address).MergeArea.Address Like singleCell.Address & "*" Then
            cell_count = cell_count + 1
        End If
    Next
    
    MsgBox cell_count
    
End Sub

Sub SaveEachSheetToCSV()
    Dim csvFile As String
    Dim i As Integer, j As Integer, ws_count As Integer, start As Integer, FileNumber As Integer
    Dim LR As Integer, LC As Integer
    Dim ws As Worksheet
    Dim cell_content As String
    
    ws_count = ThisWorkbook.Worksheets.Count
    
    For start = 1 To ws_count
        Set ws = ThisWorkbook.Worksheets(start)
        FileNumber = FreeFile
        
        LR = ws.Cells(Rows.Count, 1).End(xlUp).Row
        LC = ws.Cells(1, Columns.Count).End(xlToLeft).Column
        csvFile = ThisWorkbook.Path & "\" & ws.Name & ".csv"
        
       
        
        Line = ""
        MsgBox csvFile & "," & LR & "/" & LC
        
        Open csvFile For Output As #FileNumber
        
        For i = 1 To LR
            For j = 1 To LC
                cell_content = ws.Cells(i, j).Value
                If Len(Trim(cell_content)) > 0 Then
                    If j <> LC Then
                        Line = Line & cell_content & ","
                    Else
                        Line = Line & cell_content & vbCr
                    End If
                End If
                
            Next
        Next
        Print #FileNumber, Line
        
        
        Close #FileNumber
Continue:
    Next
End Sub

Sub SaveEachSheetToCSV_utf8()
    Dim csvFile As String
    Dim i As Integer, j As Integer, ws_count As Integer, start As Integer, FileNumber As Integer
    Dim LR As Integer, LC As Integer
    Dim ws As Worksheet
    Dim cell_content As String
    
    ws_count = ThisWorkbook.Worksheets.Count
    
    For start = 1 To ws_count
        Set ws = ThisWorkbook.Worksheets(start)
        FileNumber = FreeFile
        
        LR = ws.Cells(Rows.Count, 1).End(xlUp).Row
        LC = ws.Cells(1, Columns.Count).End(xlToLeft).Column
        csvFile = ThisWorkbook.Path & "\" & ws.Name & ".csv"
        
       
        
        Line = ""
        MsgBox csvFile & "," & LR & "/" & LC
        
        
        Set Stream = CreateObject("ADODB.Stream")
        
        Stream.Charset = "UTF-8"
        Stream.Type = 2
        
        Stream.Open
        
        For i = 1 To LR
            For j = 1 To LC
                cell_content = ws.Cells(i, j).Value
                If Len(Trim(cell_content)) > 0 Then
                    If j <> LC Then
                        Stream.WriteText cell_content & ","
                    Else
                        Stream.WriteText cell_content, adWriteLine
                    End If
                End If
                
            Next
        Next
        Stream.SaveToFile csvFile, adSaveCreateOverWrite
        Stream.Close
        Set Stream = Nothing
        
Continue:
    Next
End Sub

Sub selectA1saving()
'
' 保存後A1に設定する Macro
'

'
    Range("A1").Select
    
    ActiveWorkbook.Save
End Sub
