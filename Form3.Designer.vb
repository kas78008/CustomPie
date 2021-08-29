<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormSelectTort
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataSet1 = New Заказы.DataSet1()
        Me.TortTableAdapter = New Заказы.DataSet1TableAdapters.tortTableAdapter()
        Me.DataSet2 = New Заказы.DataSet2()
        Me.ExclusivTableAdapter1 = New Заказы.DataSet2TableAdapters.exclusivTableAdapter()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataSetObtyazhka1 = New Заказы.DataSetObtyazhka()
        Me.ObtyagTableAdapter1 = New Заказы.DataSetObtyazhkaTableAdapters.obtyagTableAdapter()
        Me.kod = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nametort = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.styazh1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cenastyazh1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.styazh2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cenastyazh2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.styazh3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cenastyazh3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.styazh = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cenastyazh4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.styazh5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cenastyazh5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cenaotdelki = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cenareal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cenanal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetObtyazhka1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.kod, Me.nametort, Me.styazh1, Me.cenastyazh1, Me.styazh2, Me.cenastyazh2, Me.styazh3, Me.cenastyazh3, Me.styazh, Me.cenastyazh4, Me.styazh5, Me.cenastyazh5, Me.cenaotdelki, Me.cenareal, Me.cenanal})
        Me.DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.ShowEditingIcon = False
        Me.DataGridView1.Size = New System.Drawing.Size(801, 435)
        Me.DataGridView1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button1.Location = New System.Drawing.Point(28, 460)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(105, 34)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Выбрать"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TortTableAdapter
        '
        Me.TortTableAdapter.ClearBeforeFill = True
        '
        'DataSet2
        '
        Me.DataSet2.DataSetName = "DataSet2"
        Me.DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ExclusivTableAdapter1
        '
        Me.ExclusivTableAdapter1.ClearBeforeFill = True
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(275, 465)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(169, 29)
        Me.TextBox1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.Location = New System.Drawing.Point(205, 465)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 24)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Поиск"
        '
        'DataSetObtyazhka1
        '
        Me.DataSetObtyazhka1.DataSetName = "DataSetObtyazhka"
        Me.DataSetObtyazhka1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ObtyagTableAdapter1
        '
        Me.ObtyagTableAdapter1.ClearBeforeFill = True
        '
        'kod
        '
        Me.kod.HeaderText = "Код"
        Me.kod.Name = "kod"
        Me.kod.ReadOnly = True
        Me.kod.Visible = False
        '
        'nametort
        '
        Me.nametort.HeaderText = "Название"
        Me.nametort.Name = "nametort"
        Me.nametort.ReadOnly = True
        '
        'styazh1
        '
        Me.styazh1.HeaderText = "Стяжка1"
        Me.styazh1.Name = "styazh1"
        Me.styazh1.ReadOnly = True
        '
        'cenastyazh1
        '
        Me.cenastyazh1.HeaderText = "Цена стяжка1"
        Me.cenastyazh1.Name = "cenastyazh1"
        Me.cenastyazh1.ReadOnly = True
        Me.cenastyazh1.Visible = False
        '
        'styazh2
        '
        Me.styazh2.HeaderText = "Стяжка2"
        Me.styazh2.Name = "styazh2"
        Me.styazh2.ReadOnly = True
        '
        'cenastyazh2
        '
        Me.cenastyazh2.HeaderText = "Цена стяжка2"
        Me.cenastyazh2.Name = "cenastyazh2"
        Me.cenastyazh2.ReadOnly = True
        Me.cenastyazh2.Visible = False
        '
        'styazh3
        '
        Me.styazh3.HeaderText = "Стяжка3"
        Me.styazh3.Name = "styazh3"
        Me.styazh3.ReadOnly = True
        '
        'cenastyazh3
        '
        Me.cenastyazh3.HeaderText = "Цена стяжка3"
        Me.cenastyazh3.Name = "cenastyazh3"
        Me.cenastyazh3.ReadOnly = True
        Me.cenastyazh3.Visible = False
        '
        'styazh
        '
        Me.styazh.HeaderText = "Стяжка4"
        Me.styazh.Name = "styazh"
        Me.styazh.ReadOnly = True
        '
        'cenastyazh4
        '
        Me.cenastyazh4.HeaderText = "Цена стяжка4"
        Me.cenastyazh4.Name = "cenastyazh4"
        Me.cenastyazh4.ReadOnly = True
        Me.cenastyazh4.Visible = False
        '
        'styazh5
        '
        Me.styazh5.HeaderText = "Стяжка5"
        Me.styazh5.Name = "styazh5"
        Me.styazh5.ReadOnly = True
        '
        'cenastyazh5
        '
        Me.cenastyazh5.HeaderText = "Цена стяжка5"
        Me.cenastyazh5.Name = "cenastyazh5"
        Me.cenastyazh5.ReadOnly = True
        Me.cenastyazh5.Visible = False
        '
        'cenaotdelki
        '
        Me.cenaotdelki.HeaderText = "Цена отделки"
        Me.cenaotdelki.Name = "cenaotdelki"
        Me.cenaotdelki.ReadOnly = True
        Me.cenaotdelki.Visible = False
        '
        'cenareal
        '
        Me.cenareal.HeaderText = "Цена реализации"
        Me.cenareal.Name = "cenareal"
        Me.cenareal.ReadOnly = True
        '
        'cenanal
        '
        Me.cenanal.HeaderText = "Цена за наличные"
        Me.cenanal.Name = "cenanal"
        Me.cenanal.ReadOnly = True
        '
        'FormSelectTort
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(822, 506)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormSelectTort"
        Me.Text = "Выбор торта"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetObtyazhka1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents TortTableAdapter As DataSet1TableAdapters.tortTableAdapter
    Friend WithEvents Button1 As Button
    Friend WithEvents DataSet2 As DataSet2
    Friend WithEvents ExclusivTableAdapter1 As DataSet2TableAdapters.exclusivTableAdapter
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DataSetObtyazhka1 As DataSetObtyazhka
    Friend WithEvents ObtyagTableAdapter1 As DataSetObtyazhkaTableAdapters.obtyagTableAdapter
    Friend WithEvents kod As DataGridViewTextBoxColumn
    Friend WithEvents nametort As DataGridViewTextBoxColumn
    Friend WithEvents styazh1 As DataGridViewTextBoxColumn
    Friend WithEvents cenastyazh1 As DataGridViewTextBoxColumn
    Friend WithEvents styazh2 As DataGridViewTextBoxColumn
    Friend WithEvents cenastyazh2 As DataGridViewTextBoxColumn
    Friend WithEvents styazh3 As DataGridViewTextBoxColumn
    Friend WithEvents cenastyazh3 As DataGridViewTextBoxColumn
    Friend WithEvents styazh As DataGridViewTextBoxColumn
    Friend WithEvents cenastyazh4 As DataGridViewTextBoxColumn
    Friend WithEvents styazh5 As DataGridViewTextBoxColumn
    Friend WithEvents cenastyazh5 As DataGridViewTextBoxColumn
    Friend WithEvents cenaotdelki As DataGridViewTextBoxColumn
    Friend WithEvents cenareal As DataGridViewTextBoxColumn
    Friend WithEvents cenanal As DataGridViewTextBoxColumn
End Class
