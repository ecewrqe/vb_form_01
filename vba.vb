Sub count_yellow()
    Set selectionArea = Selection()
    Dim cell_count As Integer
    cell_count = 0
    Dim singleCellRange As Range
    
    Dim Count As Integer
    Count = 0
    For Each singleCell In selectionArea
        
        If singleCell.Interior.Color = 65535 Then
            If Range(singleCell.Address).MergeArea.Address Like singleCell.Address & "*" Then
                    cell_count = cell_count + 1
            End If
            
        End If
        
        
        'MsgBox singleCell.Column & "==" & singleCell.Row & ", address: " & singleCell.Address
        
    Next
    Range("A1").Value = cell_count
    
    
End Sub



Private Sub Worksheet_SelectionChange(ByVal Target As Range)
    count_yellow
    
End Sub
