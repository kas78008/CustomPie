Public Class FormSelectTort


    Dim RowsCount As Single


    Private Sub FormSelectTort_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.Rows.Clear()
        TextBox1.Text = ""
        If Not BoolOnlyObtyag Then
            If FormZakaz.RadioButton1.Checked Then
                GridViewFillRows()
            End If
            If FormZakaz.RadioButton2.Checked Then
                GridViewFillRows2()
            End If
        Else
            GridViewFillRowsObtyag()

        End If

        'ChangeGridView()

        'MsgBox(Me.TortTableAdapter.GetData().Rows.Count)
        'MsgBox(Me.TortTableAdapter.GetData().Rows.Item(1).Item(1))
        'TODO: данная строка кода позволяет загрузить данные в таблицу "DataSet1.tort". При необходимости она может быть перемещена или удалена.
        'Me.TortTableAdapter.Fill(Me.DataSet1.tort)

        boolSelect = False
        If Not BoolOpenSelectFormTort Then
            BoolOpenSelectFormTort = True
        End If

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        boolSelect = True
        EE = e
    End Sub

    Private Sub DataGridView1_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentDoubleClick
        If Not BoolOnlyStyazhka Then
            FillStyaska(e)
        End If

        boolSelect = True
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If boolSelect Then
            If Not BoolOnlyStyazhka Then
                FillStyaska(EE)
            End If

        End If

        Me.Close()
    End Sub

    Private Sub FormSelectTort_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        If Not BoolOnlyObtyag Then
            If boolSelect Then
                FormZakaz.TxtBxNameTort.Text = TxtNameTort
            End If
        ElseIf boolSelect Then

            BoolOnlyObtyag = False
            FormZakaz.TxtBxDecor.Text = RTrim(DataGridView1.Rows(EE.RowIndex).Cells(1).Value)
        End If

        Me.TortTableAdapter.Connection.Close()
        Me.TortTableAdapter.Dispose()
        Me.ExclusivTableAdapter1.Connection.Close()
        Me.ExclusivTableAdapter1.Dispose()
    End Sub
    Private Sub FillStyaska(e As DataGridViewCellEventArgs)
        TxtNameTort = RTrim(DataGridView1.Rows(e.RowIndex).Cells(1).Value)
        TxtBxStyazhki(0).Text = RTrim(DataGridView1.Rows(e.RowIndex).Cells(2).Value)
        LblStyazhki(0).Text = RTrim(DataGridView1.Rows(e.RowIndex).Cells(3).Value)
        TxtBxStyazhki(1).Text = RTrim(DataGridView1.Rows(e.RowIndex).Cells(4).Value)
        LblStyazhki(1).Text = RTrim(DataGridView1.Rows(e.RowIndex).Cells(5).Value)
        TxtBxStyazhki(2).Text = RTrim(DataGridView1.Rows(e.RowIndex).Cells(6).Value)
        LblStyazhki(2).Text = RTrim(DataGridView1.Rows(e.RowIndex).Cells(7).Value)
        TxtBxStyazhki(3).Text = RTrim(DataGridView1.Rows(e.RowIndex).Cells(8).Value)
        LblStyazhki(3).Text = RTrim(DataGridView1.Rows(e.RowIndex).Cells(9).Value)
        TxtBxStyazhki(4).Text = RTrim(DataGridView1.Rows(e.RowIndex).Cells(10).Value)
        LblStyazhki(4).Text = RTrim(DataGridView1.Rows(e.RowIndex).Cells(11).Value)
    End Sub
    Private Sub ChangeGridView()
        DataGridView1.Columns(0).Visible = False
        'DataGridView1.Columns(0).ValueType = GetType(Single)
        DataGridView1.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridView1.Columns(1).HeaderText = "Название торта"
        DataGridView1.Columns(1).HeaderCell.Style.Font = New Font(Me.DataGridView1.DefaultCellStyle.Font, FontStyle.Bold)


        DataGridView1.Columns(3).Visible = False
        DataGridView1.Columns(5).Visible = False
        DataGridView1.Columns(7).Visible = False
        DataGridView1.Columns(9).Visible = False
        DataGridView1.Columns(11).Visible = False
        DataGridView1.Columns(12).Visible = False
        DataGridView1.Columns(13).Visible = False
        DataGridView1.Columns(14).Visible = False
        DataGridView1.Refresh()
        Me.Refresh()
    End Sub
    Private Sub GridViewFillRows()
        Dim IntColumns As Integer
        Dim i As Integer

        IntColumns = 15
        RowsCount = Me.TortTableAdapter.GetData().Rows.Count
        Me.TortTableAdapter.Fill(Me.DataSet1.tort)
        For index = 0 To RowsCount - 1
            DataGridView1.Rows.Add()

            For i = 0 To IntColumns - 1
                'DataGridView1.Rows(index).Cells(i).Value = RTrim(Me.TortTableAdapter.GetData().Rows.Item(index).Item(i))
                DataGridView1.Rows(index).Cells(i).Value = RTrim(Me.DataSet1.tort.Rows(index).Item(i))
            Next
        Next
        DataGridView1.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridView1.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
    End Sub
    Private Sub GridViewFillRows2()
        Dim IntColumns As Integer
        Dim i As Integer

        IntColumns = 15
        RowsCount = Me.ExclusivTableAdapter1.GetData().Rows.Count
        Me.ExclusivTableAdapter1.Fill(Me.DataSet2.exclusiv)
        For index = 0 To RowsCount - 1
            DataGridView1.Rows.Add()

            For i = 0 To IntColumns - 1
                'DataGridView1.Rows(index).Cells(i).Value = RTrim(Me.TortTableAdapter.GetData().Rows.Item(index).Item(i))
                DataGridView1.Rows(index).Cells(i).Value = RTrim(Me.DataSet2.exclusiv.Rows(index).Item(i))
            Next
        Next
        DataGridView1.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridView1.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        ' Dim SearchWord As String
        If TextBox1.Text.Length > 0 Then

            For Each dr As DataGridViewRow In Me.DataGridView1.Rows

                If dr.Cells(1).Value.ToString.ToLower.Contains(TextBox1.Text.ToLower) Then dr.Visible = True Else dr.Visible = False


            Next
        End If
    End Sub
    Private Sub GridViewFillRowsObtyag()
        Dim IntColumns As Integer
        Dim i As Integer

        IntColumns = 15
        RowsCount = Me.ObtyagTableAdapter1.GetData().Rows.Count
        Me.ObtyagTableAdapter1.Fill(Me.DataSetObtyazhka1.obtyag)
        For index = 0 To RowsCount - 1
            DataGridView1.Rows.Add()

            For i = 0 To IntColumns - 1
                'DataGridView1.Rows(index).Cells(i).Value = RTrim(Me.TortTableAdapter.GetData().Rows.Item(index).Item(i))
                DataGridView1.Rows(index).Cells(i).Value = RTrim(Me.DataSetObtyazhka1.obtyag.Rows(index).Item(i))
            Next
        Next
        DataGridView1.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridView1.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells


    End Sub


End Class