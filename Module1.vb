Module Module1
    Public TxtBxStyazhki() As TextBox = {FormZakaz.TextBox1, FormZakaz.TextBox2, FormZakaz.TextBox4, FormZakaz.TextBox5, FormZakaz.TextBox6}
    Public LblStyazhki() As Label = {FormZakaz.Label14, FormZakaz.Label15, FormZakaz.Label16, FormZakaz.Label17, FormZakaz.Label18}
    Public TxtNameTort As String
    Public BtnSelectStyazhka() As Button = {FormZakaz.Button1, FormZakaz.Button2, FormZakaz.Button3, FormZakaz.Button4, FormZakaz.Button5}
    Public BoolOpenSelectFormTort As Boolean
    Public EE As DataGridViewCellEventArgs
    Public BoolOnlyStyazhka As Boolean
    Public BoolOnlyObtyag As Boolean
    Public AppPath As String
    Public BoolSelect As Boolean
    Public Function ConnectDb() As Boolean
        Dim ConnectionString As String

        ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;" & "Data Source=D:\users\user0\Desktop\temp\;Extended Properties=dBase IV"
        Dim dBaseConnection As New System.Data.OleDb.OleDbConnection(ConnectionString)
        dBaseConnection.Open()

        Dim dBaseCommand As New System.Data.OleDb.OleDbCommand("SELECT * FROM 1SCONST.DBF", dBaseConnection)
        Dim dBaseDataReader As System.Data.OleDb.OleDbDataReader = dBaseCommand.ExecuteReader(CommandBehavior.SequentialAccess)

        While dBaseDataReader.Read
            FormZakaz.TextBox1.Text = (dBaseDataReader("ACTNO").ToString)
            ' Form1.TextBox2.Text = (dBaseDataReader("TIME").ToString)
            FormZakaz.TextBox3.Text = (dBaseDataReader("LINENO").ToString)
        End While

        dBaseConnection.Close()
        dBaseConnection.Dispose()
        Return ConnectDb

    End Function
    Public Sub SetStyazhka(a As Integer, e As DataGridViewCellEventArgs)
        Dim i As Integer
        Dim Summa As Decimal
        TxtBxStyazhki(a).Text = RTrim(FormSelectTort.DataGridView1.Rows(e.RowIndex).Cells(2).Value)
        LblStyazhki(a).Text = RTrim(FormSelectTort.DataGridView1.Rows(e.RowIndex).Cells(3).Value)
        For i = 0 To 4
            Summa += LblStyazhki(i).Text
        Next

        FormZakaz.txtPrice.Text = Summa
    End Sub
End Module
