Imports iText.Kernel.Pdf
Imports iText.Kernel.Font
Imports iText.Layout
Imports iText.Layout.Element

Imports iText.IO.Image
Imports System.Data.Odbc
Imports System.IO
Imports System.Text

Public Class Form1

    Dim Message As String = "THis is a message string"
    Dim intvar As Integer = 25
    Dim num1 As Single
    Dim result As DialogResult

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'MessageBox.Show(Message)
        'If intvar = 20 Then

        'End If
        Form2.Show()
        'Me.Hide()



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Timer1.Start()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Timer1.Stop()
        'Dim SAPI As Object
        'SAPI = CreateObject("SAPI.SpVoice")
        'SAPI.Speak(TextBox1.Text)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Timer1.Stop()
        ProgressBar1.Value = 1
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Timer1.Interval = 1
        If ProgressBar1.Value < 100 Then
            ProgressBar1.Value += 1
        Else
            Timer1.Stop()
        End If

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ListBox1.Items.Add(TextBox1.Text)
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        MessageBox.Show(ListBox1.SelectedIndex.ToString(), ListBox1.SelectedItem.ToString())
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        'Dim vbsuba As VbSubsA
        'vbsuba = CreateObject("VbSubsA")
        OpenFileDialog1.Filter = "TEXT FILE(.txt)|*.txt|JIS FILE|*.jis|JSON FILE|*.json|ALL FILE |*.*"
        result = OpenFileDialog1.ShowDialog()
        Dim content As String = ""
        If (result = result.OK And Not (System.IO.Path.GetExtension(OpenFileDialog1.FileName) = ".exe")) Then
            Label1.Text = OpenFileDialog1.FileName
            'MessageBox.Show(System.IO.Path.GetExtension(OpenFileDialog1.FileName))
            Using textReader As New System.IO.StreamReader(Label1.Text)
                content = textReader.ReadToEnd
                RichTextBox1.Text = content
            End Using
        ElseIf (result = result.OK) Then
            Label1.Text = OpenFileDialog1.FileName

            System.Diagnostics.Process.Start(Label1.Text)
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim index As Integer = 0
        Dim temp As String = RichTextBox1.Text
        RichTextBox1.Text = temp
        While (index < RichTextBox1.Text.LastIndexOf(TextBox2.Text))

            RichTextBox1.Find(TextBox2.Text, index, RichTextBox1.TextLength, RichTextBoxFinds.None)
            RichTextBox1.SelectionBackColor = Color.Aqua
            index = RichTextBox1.Text.IndexOf(TextBox2.Text, index) + 1

        End While
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click

        'Dim file As System.IO.StreamWriter
        'file = My.Computer.FileSystem.OpenTextFileWriter("a.txt", True)
        'file.WriteLine("content")
        'file.Close()
        'My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Question)
        Dim file As System.IO.StreamWriter
        result = SaveFileDialog1.ShowDialog()
        'MessageBox.Show(result)
        MessageBox.Show(result)
        If result = DialogResult.OK Then
            Label1.Text = SaveFileDialog1.FileName
            file = My.Computer.FileSystem.OpenTextFileWriter(Label1.Text, False)
            file.WriteLine(RichTextBox1.Text)
            file.Close()

        End If


    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim Obj As New VbSubsA
        Dim a, b As Integer
        a = 10
        b = 20
        Dim refa = a
        Label1.Text = Obj.add(refa, b).ToString()
    End Sub
    ' itext7.bouncy-castle-adapter
    ' itext7
    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        result = SaveFileDialog1.ShowDialog()
        If result = DialogResult.OK Then
            Label1.Text = SaveFileDialog1.FileName
            Dim file As New FileInfo(Label1.Text)


            Try
                Dim writer As New PdfWriter(file)
                Dim pdf As New PdfDocument(writer)
                Dim document As New Document(pdf)
                document.Add(New Paragraph("hello world"))
                Dim list As New List()
                list.Add(New ListItem("One"))
                list.Add(New ListItem("Two"))
                list.Add(New ListItem("Three"))
                list.Add(New ListItem("Four"))
                document.Add(list)

                Dim img As New Image(ImageDataFactory.Create("01.jpg"))
                document.Add(img)

                Dim table As New Table(4)
                Dim cell As New Cell()
                cell.SetHorizontalAlignment(1)
                table.AddCell("Col 1 Row 1")
                table.AddCell("Col 2 Row 1")
                table.AddCell("Col 3 Row 1")
                table.AddCell("Col 1 Row 2")
                table.AddCell("Col 2 Row 2")
                table.AddCell("Col 3 Row 2")
                document.Add(table)
                document.Close()

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                MessageBox.Show("finished")


            End Try
            '<> < = >
            'Process.Start("filename")
            ' System.Text.StringBuilder
            Dim QueryAddress As New StringBuilder
            'QueryAddress.Append()
        End If

        OpenFileDialog1.Filter = "*.xls|*.xlsx"
        result = OpenFileDialog1.ShowDialog()
        If result = result.OK Then
            'Dim MyConnection As OleDb.OleDbConnection

        End If



    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click

    End Sub
End Class
