Public Class Form2
    Public Property StringPass As String
    'Inherits class
    'Implements class
    Dim result As DialogResult
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ColorPicker.Click
        result = ColorDialog1.ShowDialog()
        'If result Is Nothing 
        If result.OK = 1 Then
            Label1.ForeColor = ColorDialog1.Color
        End If
    End Sub
    ' Install-Package itext
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        Label2.Text = DateTimePicker1.Value.ToString()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Label3.Text = ComboBox1.SelectedItem.ToString()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        ContextMenuStrip1.Show()
        ContextMenuStrip1.Location = Cursor.Position
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Form2_Click(sender As Object, e As EventArgs) Handles MyBase.Click
    End Sub

    Private Sub ToolStripTextBox1_Click(sender As Object, e As EventArgs) Handles ToolStripTextBox1.Click

    End Sub

    Private Sub ToolStripTextBox1_TextChanged(sender As Object, e As EventArgs) Handles ToolStripTextBox1.TextChanged
        ChooToolStripMenuItem.Text = ToolStripTextBox1.Text
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        result = FontDialog1.ShowDialog()
        If result.OK = 1 Then
            Label4.Font = FontDialog1.Font

        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'Dim N As String
        'N = InputBox("Enter Node Name")
        'If TreeView1.SelectedNode Is Nothing Then
        '    TreeView1.Nodes.Add(N, N)
        'Else
        '    TreeView1.SelectedNode.Nodes.Add(N, N)
        'End If
        ' ============ for to loop
        Dim I As Integer
        'For I = 0 To 100
        '    TreeView1.Nodes.Add(I, I)
        'Next
        ' DO while not (), do until 
        Do While (I < 10)
            I = I + 1
        Loop
        Do Until (I = 10)
            I = I + 1
        Loop

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TreeView1.Nodes.Remove(TreeView1.SelectedNode)

    End Sub
End Class