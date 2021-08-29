Public Class FormZakaz
    Public strData As String
    Public boolMonthChange As Boolean
    Dim boolClick As Boolean
    Dim Summa As Decimal
    Dim Itogo As Decimal
    Dim FileReader As System.IO.StreamReader
    Dim StringReader As String
    Dim Id As Integer
    Dim NomerZakaza As Integer

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        FormCalendar.Visible = True
        FormCalendar.Show()
        boolMonthChange = False
        strData = ""
        boolClick = False
    End Sub



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim i As Integer
        i = 0
        RadioButton1.Checked = True
        RadioButton2.Checked = False
        BoolOpenSelectFormTort = False
        BoolOnlyStyazhka = False
        BoolOnlyObtyag = False

        'Название текущей точки
        AppPath = My.Computer.FileSystem.SpecialDirectories.Desktop + "\WinniPuh\"
        FileReader = My.Computer.FileSystem.OpenTextFileReader(AppPath + "config.ini", System.Text.Encoding.Default)
        StringReader = FileReader.ReadLine()
        lblName.Text = StringReader.Split("=")(1)
        StringReader = FileReader.ReadLine()
        Id = StringReader.Split("=")(1)
        FileReader.Close()
        'Название точки получения (выбрать из списка)
        FileReader = My.Computer.FileSystem.OpenTextFileReader(AppPath + "точки.txt", System.Text.Encoding.UTF8)
        While Not FileReader.EndOfStream
            StringReader = FileReader.ReadLine()
            ComboBox1.Items.Add(i)
            ComboBox1.Items(i) = StringReader
            i += 1
        End While
        FileReader.Close()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs)
        e.Handled = Not Char.IsDigit(e.KeyChar)
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs)
        e.Handled = Not Char.IsDigit(e.KeyChar)
    End Sub

    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles TabPage2.Click

    End Sub
    'Галочка согласие
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If Not boolClick Then
            PictureBox1.Image = Заказы.My.Resources.Resources.yes
            PictureBox1.BackColor = Color.BlueViolet
            PictureBox1.Refresh()
            boolClick = True
        Else
            PictureBox1.Image = Заказы.My.Resources.Resources.no
            PictureBox1.BackColor = Color.Crimson
            PictureBox1.Refresh()
            boolClick = False
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If Not boolClick Then
            MsgBox("Не проставлена галочка - покупатель проинформирован!")
            Exit Sub

        End If
    End Sub

    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        If Not boolClick Then
            MsgBox("Не проставлена галочка - покупатель проинформирован!")
            Exit Sub

        End If
        ConnectDb()
    End Sub

    Private Sub BtnSelectTort_Click(sender As Object, e As EventArgs) Handles BtnSelectTort.Click
        Dim i As Integer
        Summa = 0
        FormSelectTort.Visible = False
        FormSelectTort.ShowDialog()
        For i = 0 To 4
            Summa += LblStyazhki(i).Text
        Next
        'Summa += RTrim(FormSelectTort.DataGridView1.Rows(EE.RowIndex).Cells(12).Value)
        If BoolSelect Then
            If ChkBxNal.Checked = True Then
                Itogo = RTrim(FormSelectTort.DataGridView1.Rows(EE.RowIndex).Cells(14).Value)
            Else
                Itogo = RTrim(FormSelectTort.DataGridView1.Rows(EE.RowIndex).Cells(13).Value)
            End If
        End If

        txtPrice.Text = Itogo
    End Sub



    Private Sub txtbxPredoplata_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbxPredoplata.KeyPress
        If IsNumeric(e.KeyChar) Then
            e.Handled = False
        Else e.Handled = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        BoolOnlyStyazhka = True
        FormSelectTort.Visible = False
        FormSelectTort.ShowDialog()
        SetStyazhka(0, EE)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        BoolOnlyStyazhka = True
        FormSelectTort.Visible = False
        FormSelectTort.ShowDialog()
        SetStyazhka(1, EE)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        BoolOnlyStyazhka = True
        FormSelectTort.Visible = False
        FormSelectTort.ShowDialog()
        SetStyazhka(2, EE)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        BoolOnlyStyazhka = True
        FormSelectTort.Visible = False
        FormSelectTort.ShowDialog()
        SetStyazhka(3, EE)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        BoolOnlyStyazhka = True
        FormSelectTort.Visible = False
        FormSelectTort.ShowDialog()
        SetStyazhka(4, EE)
    End Sub

    Private Sub BtnSelectDecor_Click(sender As Object, e As EventArgs) Handles BtnSelectDecor.Click
        BoolOnlyObtyag = True
        FormSelectTort.Visible = False
        FormSelectTort.ShowDialog()

    End Sub

    Private Sub ChkBxNal_CheckedChanged(sender As Object, e As EventArgs) Handles ChkBxNal.CheckedChanged
        If Not boolSelect Then
            Exit Sub
        End If
        If ChkBxNal.Checked = True Then
            Itogo = RTrim(FormSelectTort.DataGridView1.Rows(EE.RowIndex).Cells(14).Value)
        Else
            Itogo = RTrim(FormSelectTort.DataGridView1.Rows(EE.RowIndex).Cells(13).Value)
        End If
        txtPrice.Text = Itogo
    End Sub
End Class
