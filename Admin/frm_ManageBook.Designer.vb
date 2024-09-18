<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ManageBook
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Panel1 = New Panel()
        btn_Close = New Button()
        Label1 = New Label()
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        DataGridView1 = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewTextBoxColumn()
        Column7 = New DataGridViewTextBoxColumn()
        TabPage2 = New TabPage()
        pic_bookimg = New PictureBox()
        btn_Search = New Button()
        btn_Delete = New Button()
        btn_Edit = New Button()
        btn_Save = New Button()
        cbo_Tax = New ComboBox()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label4 = New Label()
        txt_TotalPrice = New TextBox()
        txt_Author = New TextBox()
        txt_Price = New TextBox()
        Label3 = New Label()
        txt_BookName = New TextBox()
        Label8 = New Label()
        txt_Search = New TextBox()
        Label2 = New Label()
        txt_BookId = New TextBox()
        Panel1.SuspendLayout()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        TabPage2.SuspendLayout()
        CType(pic_bookimg, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(42), CByte(42), CByte(42))
        Panel1.Controls.Add(btn_Close)
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1114, 69)
        Panel1.TabIndex = 0
        ' 
        ' btn_Close
        ' 
        btn_Close.Cursor = Cursors.Hand
        btn_Close.FlatAppearance.BorderSize = 0
        btn_Close.FlatAppearance.MouseOverBackColor = Color.IndianRed
        btn_Close.FlatStyle = FlatStyle.Flat
        btn_Close.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_Close.ForeColor = Color.White
        btn_Close.Location = New Point(1002, -4)
        btn_Close.Name = "btn_Close"
        btn_Close.Size = New Size(112, 70)
        btn_Close.TabIndex = 1
        btn_Close.Text = "CLOSE"
        btn_Close.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(49, 12)
        Label1.Name = "Label1"
        Label1.Size = New Size(179, 28)
        Label1.TabIndex = 0
        Label1.Text = "MANAGE BOOK'S"
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Dock = DockStyle.Fill
        TabControl1.ItemSize = New Size(120, 44)
        TabControl1.Location = New Point(0, 69)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(1114, 649)
        TabControl1.TabIndex = 1
        ' 
        ' TabPage1
        ' 
        TabPage1.Controls.Add(DataGridView1)
        TabPage1.Location = New Point(4, 48)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(1106, 597)
        TabPage1.TabIndex = 0
        TabPage1.Text = " BOOK LIST"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.BackgroundColor = Color.White
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5, Column6, Column7})
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Window
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        DataGridViewCellStyle1.SelectionForeColor = Color.Black
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.False
        DataGridView1.DefaultCellStyle = DataGridViewCellStyle1
        DataGridView1.Dock = DockStyle.Fill
        DataGridView1.Location = New Point(3, 3)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersVisible = False
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.Size = New Size(1100, 591)
        DataGridView1.TabIndex = 0
        ' 
        ' Column1
        ' 
        Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column1.HeaderText = "#"
        Column1.MinimumWidth = 6
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        Column1.Width = 49
        ' 
        ' Column2
        ' 
        Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column2.HeaderText = "BOOK ID"
        Column2.MinimumWidth = 6
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        Column2.Width = 107
        ' 
        ' Column3
        ' 
        Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column3.HeaderText = "BOOK NAME"
        Column3.MinimumWidth = 6
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        ' 
        ' Column4
        ' 
        Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column4.HeaderText = "AUTHOR"
        Column4.MinimumWidth = 6
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        Column4.Width = 106
        ' 
        ' Column5
        ' 
        Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column5.HeaderText = "PRICE"
        Column5.MinimumWidth = 6
        Column5.Name = "Column5"
        Column5.ReadOnly = True
        Column5.Width = 84
        ' 
        ' Column6
        ' 
        Column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column6.HeaderText = "TAX %"
        Column6.MinimumWidth = 6
        Column6.Name = "Column6"
        Column6.ReadOnly = True
        Column6.Width = 87
        ' 
        ' Column7
        ' 
        Column7.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column7.HeaderText = "TOTOL PRICE"
        Column7.MinimumWidth = 6
        Column7.Name = "Column7"
        Column7.ReadOnly = True
        Column7.Width = 138
        ' 
        ' TabPage2
        ' 
        TabPage2.Controls.Add(pic_bookimg)
        TabPage2.Controls.Add(btn_Search)
        TabPage2.Controls.Add(btn_Delete)
        TabPage2.Controls.Add(btn_Edit)
        TabPage2.Controls.Add(btn_Save)
        TabPage2.Controls.Add(cbo_Tax)
        TabPage2.Controls.Add(Label5)
        TabPage2.Controls.Add(Label6)
        TabPage2.Controls.Add(Label7)
        TabPage2.Controls.Add(Label4)
        TabPage2.Controls.Add(txt_TotalPrice)
        TabPage2.Controls.Add(txt_Author)
        TabPage2.Controls.Add(txt_Price)
        TabPage2.Controls.Add(Label3)
        TabPage2.Controls.Add(txt_BookName)
        TabPage2.Controls.Add(Label8)
        TabPage2.Controls.Add(txt_Search)
        TabPage2.Controls.Add(Label2)
        TabPage2.Controls.Add(txt_BookId)
        TabPage2.Location = New Point(4, 48)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(1106, 597)
        TabPage2.TabIndex = 1
        TabPage2.Text = "MANAGE BOOK"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' pic_bookimg
        ' 
        pic_bookimg.BorderStyle = BorderStyle.FixedSingle
        pic_bookimg.Location = New Point(90, 137)
        pic_bookimg.Name = "pic_bookimg"
        pic_bookimg.Size = New Size(379, 348)
        pic_bookimg.SizeMode = PictureBoxSizeMode.StretchImage
        pic_bookimg.TabIndex = 23
        pic_bookimg.TabStop = False
        ' 
        ' btn_Search
        ' 
        btn_Search.BackColor = SystemColors.Highlight
        btn_Search.FlatAppearance.BorderSize = 0
        btn_Search.FlatAppearance.MouseOverBackColor = SystemColors.HotTrack
        btn_Search.FlatStyle = FlatStyle.Flat
        btn_Search.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_Search.ForeColor = Color.White
        btn_Search.Location = New Point(675, 61)
        btn_Search.Name = "btn_Search"
        btn_Search.Size = New Size(134, 30)
        btn_Search.TabIndex = 22
        btn_Search.Text = "Search"
        btn_Search.UseVisualStyleBackColor = False
        ' 
        ' btn_Delete
        ' 
        btn_Delete.BackColor = Color.Brown
        btn_Delete.FlatAppearance.BorderSize = 0
        btn_Delete.FlatAppearance.MouseOverBackColor = SystemColors.HotTrack
        btn_Delete.FlatStyle = FlatStyle.Flat
        btn_Delete.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_Delete.ForeColor = Color.White
        btn_Delete.Location = New Point(921, 488)
        btn_Delete.Name = "btn_Delete"
        btn_Delete.Size = New Size(96, 48)
        btn_Delete.TabIndex = 21
        btn_Delete.Text = "&Delete"
        btn_Delete.UseVisualStyleBackColor = False
        ' 
        ' btn_Edit
        ' 
        btn_Edit.BackColor = Color.Green
        btn_Edit.FlatAppearance.BorderSize = 0
        btn_Edit.FlatAppearance.MouseOverBackColor = SystemColors.HotTrack
        btn_Edit.FlatStyle = FlatStyle.Flat
        btn_Edit.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_Edit.ForeColor = Color.White
        btn_Edit.Location = New Point(789, 489)
        btn_Edit.Name = "btn_Edit"
        btn_Edit.Size = New Size(103, 47)
        btn_Edit.TabIndex = 20
        btn_Edit.Text = "&Edit"
        btn_Edit.UseVisualStyleBackColor = False
        ' 
        ' btn_Save
        ' 
        btn_Save.BackColor = SystemColors.Highlight
        btn_Save.FlatAppearance.BorderSize = 0
        btn_Save.FlatAppearance.MouseOverBackColor = SystemColors.HotTrack
        btn_Save.FlatStyle = FlatStyle.Flat
        btn_Save.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_Save.ForeColor = Color.White
        btn_Save.Location = New Point(675, 489)
        btn_Save.Name = "btn_Save"
        btn_Save.Size = New Size(89, 47)
        btn_Save.TabIndex = 19
        btn_Save.Text = "&Save"
        btn_Save.UseVisualStyleBackColor = False
        ' 
        ' cbo_Tax
        ' 
        cbo_Tax.FormattingEnabled = True
        cbo_Tax.Items.AddRange(New Object() {"5", "9", "18", "24 ", "28"})
        cbo_Tax.Location = New Point(675, 371)
        cbo_Tax.Name = "cbo_Tax"
        cbo_Tax.Size = New Size(342, 31)
        cbo_Tax.TabIndex = 18
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(566, 262)
        Label5.Name = "Label5"
        Label5.Size = New Size(77, 23)
        Label5.TabIndex = 16
        Label5.Text = "AUTHOR"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(585, 374)
        Label6.Name = "Label6"
        Label6.Size = New Size(58, 23)
        Label6.TabIndex = 15
        Label6.Text = "TAX %"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(534, 439)
        Label7.Name = "Label7"
        Label7.Size = New Size(107, 23)
        Label7.TabIndex = 17
        Label7.Text = "TOTAL PRICE"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(588, 321)
        Label4.Name = "Label4"
        Label4.Size = New Size(55, 23)
        Label4.TabIndex = 14
        Label4.Text = "PRICE"
        ' 
        ' txt_TotalPrice
        ' 
        txt_TotalPrice.BorderStyle = BorderStyle.FixedSingle
        txt_TotalPrice.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txt_TotalPrice.Location = New Point(675, 432)
        txt_TotalPrice.Name = "txt_TotalPrice"
        txt_TotalPrice.Size = New Size(342, 30)
        txt_TotalPrice.TabIndex = 10
        ' 
        ' txt_Author
        ' 
        txt_Author.BorderStyle = BorderStyle.FixedSingle
        txt_Author.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txt_Author.Location = New Point(675, 255)
        txt_Author.Name = "txt_Author"
        txt_Author.Size = New Size(342, 30)
        txt_Author.TabIndex = 9
        ' 
        ' txt_Price
        ' 
        txt_Price.BorderStyle = BorderStyle.FixedSingle
        txt_Price.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txt_Price.Location = New Point(675, 314)
        txt_Price.Name = "txt_Price"
        txt_Price.Size = New Size(342, 30)
        txt_Price.TabIndex = 8
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(534, 198)
        Label3.Name = "Label3"
        Label3.Size = New Size(109, 23)
        Label3.TabIndex = 12
        Label3.Text = "BOOK NAME"
        ' 
        ' txt_BookName
        ' 
        txt_BookName.BorderStyle = BorderStyle.FixedSingle
        txt_BookName.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txt_BookName.Location = New Point(675, 191)
        txt_BookName.Name = "txt_BookName"
        txt_BookName.Size = New Size(342, 30)
        txt_BookName.TabIndex = 7
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(265, 68)
        Label8.Name = "Label8"
        Label8.Size = New Size(66, 23)
        Label8.TabIndex = 11
        Label8.Text = "Search "
        ' 
        ' txt_Search
        ' 
        txt_Search.BorderStyle = BorderStyle.FixedSingle
        txt_Search.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txt_Search.Location = New Point(377, 61)
        txt_Search.Name = "txt_Search"
        txt_Search.Size = New Size(275, 30)
        txt_Search.TabIndex = 6
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(563, 137)
        Label2.Name = "Label2"
        Label2.Size = New Size(78, 23)
        Label2.TabIndex = 13
        Label2.Text = "BOOK ID"
        ' 
        ' txt_BookId
        ' 
        txt_BookId.BorderStyle = BorderStyle.FixedSingle
        txt_BookId.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txt_BookId.Location = New Point(675, 130)
        txt_BookId.Name = "txt_BookId"
        txt_BookId.Size = New Size(342, 30)
        txt_BookId.TabIndex = 5
        ' 
        ' frm_ManageBook
        ' 
        AutoScaleDimensions = New SizeF(9F, 23F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1114, 718)
        Controls.Add(TabControl1)
        Controls.Add(Panel1)
        Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4, 3, 4, 3)
        Name = "frm_ManageBook"
        StartPosition = FormStartPosition.CenterScreen
        Text = "frm_ManageBook"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        CType(pic_bookimg, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents btn_Close As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents pic_bookimg As PictureBox
    Friend WithEvents btn_Search As Button
    Friend WithEvents btn_Delete As Button
    Friend WithEvents btn_Edit As Button
    Friend WithEvents btn_Save As Button
    Friend WithEvents cbo_Tax As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_TotalPrice As TextBox
    Friend WithEvents txt_Author As TextBox
    Friend WithEvents txt_Price As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_BookName As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_Search As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_BookId As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
End Class
