Partial Class DataSet1
    Partial Public Class tortDataTable
        Private Sub tortDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.kodColumn.ColumnName) Then
                'Добавьте здесь пользовательский код
            End If

        End Sub

    End Class
End Class
