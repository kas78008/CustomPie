Public Class FormCalendar
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Visible = False
        Me.Hide()
        FormZakaz.boolMonthChange = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If FormZakaz.boolMonthChange = False Then
            MsgBox("Не выбрана дата!")
            Exit Sub
        End If
        FormZakaz.LinkLabel1.Text = FormZakaz.strData
        Me.Visible = False
        Me.Hide()
    End Sub

    Private Sub MonthCalendar1_DateChanged(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar1.DateChanged
        FormZakaz.strData = e.Start.ToShortDateString
        FormZakaz.boolMonthChange = True
    End Sub

    Private Sub FormCalendar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class