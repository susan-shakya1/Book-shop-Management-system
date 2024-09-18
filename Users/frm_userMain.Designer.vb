<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_userMain
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
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Panel1 = New Panel()
        TableLayoutPanel2 = New TableLayoutPanel()
        btn_ManageUser = New Button()
        btn_Report = New Button()
        btn_Exit = New Button()
        btn_ManageBook = New Button()
        Label1 = New Label()
        Panel2 = New Panel()
        txt_Search = New TextBox()
        Label6 = New Label()
        Label3 = New Label()
        Ibl_TranscationDate = New Label()
        Ibl_TransactionNo = New Label()
        Label2 = New Label()
        Panel3 = New Panel()
        Ibl_userinfo = New Label()
        TableLayoutPanel1 = New TableLayoutPanel()
        DataGridView1 = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewTextBoxColumn()
        Column7 = New DataGridViewTextBoxColumn()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        Panel1.SuspendLayout()
        TableLayoutPanel2.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(TableLayoutPanel2)
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1370, 84)
        Panel1.TabIndex = 0
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        TableLayoutPanel2.ColumnCount = 4
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TableLayoutPanel2.Controls.Add(btn_ManageUser, 1, 0)
        TableLayoutPanel2.Controls.Add(btn_Report, 2, 0)
        TableLayoutPanel2.Controls.Add(btn_Exit, 3, 0)
        TableLayoutPanel2.Controls.Add(btn_ManageBook, 0, 0)
        TableLayoutPanel2.Location = New Point(765, 12)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 1
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel2.Size = New Size(605, 63)
        TableLayoutPanel2.TabIndex = 1
        ' 
        ' btn_ManageUser
        ' 
        btn_ManageUser.BackColor = SystemColors.Highlight
        btn_ManageUser.Dock = DockStyle.Fill
        btn_ManageUser.FlatAppearance.BorderSize = 0
        btn_ManageUser.FlatAppearance.MouseOverBackColor = Color.Firebrick
        btn_ManageUser.FlatStyle = FlatStyle.Flat
        btn_ManageUser.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_ManageUser.ForeColor = Color.White
        btn_ManageUser.Location = New Point(154, 3)
        btn_ManageUser.Name = "btn_ManageUser"
        btn_ManageUser.Size = New Size(145, 57)
        btn_ManageUser.TabIndex = 0
        btn_ManageUser.Text = "[ F2 - CANCEL ]"
        btn_ManageUser.UseVisualStyleBackColor = False
        ' 
        ' btn_Report
        ' 
        btn_Report.BackColor = SystemColors.Highlight
        btn_Report.Dock = DockStyle.Fill
        btn_Report.FlatAppearance.BorderSize = 0
        btn_Report.FlatAppearance.MouseOverBackColor = Color.Firebrick
        btn_Report.FlatStyle = FlatStyle.Flat
        btn_Report.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_Report.ForeColor = Color.White
        btn_Report.Location = New Point(305, 3)
        btn_Report.Name = "btn_Report"
        btn_Report.Size = New Size(145, 57)
        btn_Report.TabIndex = 0
        btn_Report.Text = "[ F3 - REPORT ]"
        btn_Report.UseVisualStyleBackColor = False
        ' 
        ' btn_Exit
        ' 
        btn_Exit.BackColor = Color.IndianRed
        btn_Exit.Dock = DockStyle.Fill
        btn_Exit.FlatAppearance.BorderSize = 0
        btn_Exit.FlatAppearance.MouseOverBackColor = Color.Firebrick
        btn_Exit.FlatStyle = FlatStyle.Flat
        btn_Exit.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_Exit.ForeColor = Color.White
        btn_Exit.Location = New Point(456, 3)
        btn_Exit.Name = "btn_Exit"
        btn_Exit.Size = New Size(146, 57)
        btn_Exit.TabIndex = 0
        btn_Exit.Text = "[ F4 - EXIT ]"
        btn_Exit.UseVisualStyleBackColor = False
        ' 
        ' btn_ManageBook
        ' 
        btn_ManageBook.BackColor = SystemColors.Highlight
        btn_ManageBook.Dock = DockStyle.Fill
        btn_ManageBook.FlatAppearance.BorderSize = 0
        btn_ManageBook.FlatAppearance.MouseOverBackColor = Color.Firebrick
        btn_ManageBook.FlatStyle = FlatStyle.Flat
        btn_ManageBook.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_ManageBook.ForeColor = Color.White
        btn_ManageBook.Location = New Point(3, 3)
        btn_ManageBook.Name = "btn_ManageBook"
        btn_ManageBook.Size = New Size(145, 57)
        btn_ManageBook.TabIndex = 0
        btn_ManageBook.Text = "[ F1 - NEW ]"
        btn_ManageBook.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.IndianRed
        Label1.Location = New Point(67, 28)
        Label1.Name = "Label1"
        Label1.Size = New Size(133, 28)
        Label1.TabIndex = 0
        Label1.Text = " BOOK SHOP"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.Controls.Add(txt_Search)
        Panel2.Controls.Add(Label6)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(Ibl_TranscationDate)
        Panel2.Controls.Add(Ibl_TransactionNo)
        Panel2.Controls.Add(Label2)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(0, 84)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1370, 133)
        Panel2.TabIndex = 1
        ' 
        ' txt_Search
        ' 
        txt_Search.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        txt_Search.BorderStyle = BorderStyle.FixedSingle
        txt_Search.Location = New Point(84, 84)
        txt_Search.Name = "txt_Search"
        txt_Search.Size = New Size(588, 31)
        txt_Search.TabIndex = 1
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(84, 58)
        Label6.Name = "Label6"
        Label6.Size = New Size(140, 23)
        Label6.TabIndex = 0
        Label6.Text = "Search / Barcode"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(465, 19)
        Label3.Name = "Label3"
        Label3.Size = New Size(147, 23)
        Label3.TabIndex = 0
        Label3.Text = "Transaction Date: "
        ' 
        ' Ibl_TranscationDate
        ' 
        Ibl_TranscationDate.AutoSize = True
        Ibl_TranscationDate.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Ibl_TranscationDate.Location = New Point(632, 19)
        Ibl_TranscationDate.Name = "Ibl_TranscationDate"
        Ibl_TranscationDate.Size = New Size(134, 23)
        Ibl_TranscationDate.TabIndex = 0
        Ibl_TranscationDate.Text = "Transaction No: "
        ' 
        ' Ibl_TransactionNo
        ' 
        Ibl_TransactionNo.AutoSize = True
        Ibl_TransactionNo.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Ibl_TransactionNo.ForeColor = Color.IndianRed
        Ibl_TransactionNo.Location = New Point(251, 19)
        Ibl_TransactionNo.Name = "Ibl_TransactionNo"
        Ibl_TransactionNo.Size = New Size(134, 23)
        Ibl_TransactionNo.TabIndex = 0
        Ibl_TransactionNo.Text = "Transaction No: "
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(84, 19)
        Label2.Name = "Label2"
        Label2.Size = New Size(134, 23)
        Label2.TabIndex = 0
        Label2.Text = "Transaction No: "
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.White
        Panel3.Controls.Add(Ibl_userinfo)
        Panel3.Dock = DockStyle.Bottom
        Panel3.Location = New Point(0, 687)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1370, 72)
        Panel3.TabIndex = 2
        ' 
        ' Ibl_userinfo
        ' 
        Ibl_userinfo.AutoSize = True
        Ibl_userinfo.BackColor = Color.Transparent
        Ibl_userinfo.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Ibl_userinfo.ForeColor = Color.DimGray
        Ibl_userinfo.Location = New Point(67, 23)
        Ibl_userinfo.Name = "Ibl_userinfo"
        Ibl_userinfo.Size = New Size(211, 28)
        Ibl_userinfo.TabIndex = 0
        Ibl_userinfo.Text = "Management System"
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 2
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 62.7737236F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 37.2262764F))
        TableLayoutPanel1.Controls.Add(DataGridView1, 1, 0)
        TableLayoutPanel1.Controls.Add(FlowLayoutPanel1, 0, 0)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 217)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 1
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Size = New Size(1370, 470)
        TableLayoutPanel1.TabIndex = 3
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.BackgroundColor = Color.White
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Control
        DataGridViewCellStyle2.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = Color.White
        DataGridViewCellStyle2.SelectionForeColor = Color.Black
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        DataGridView1.ColumnHeadersHeight = 28
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5, Column6, Column7})
        DataGridView1.Dock = DockStyle.Fill
        DataGridView1.Location = New Point(863, 3)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersVisible = False
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(504, 464)
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
        Column4.Width = 108
        ' 
        ' Column5
        ' 
        Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column5.HeaderText = "PRICE"
        Column5.MinimumWidth = 6
        Column5.Name = "Column5"
        Column5.ReadOnly = True
        Column5.Width = 85
        ' 
        ' Column6
        ' 
        Column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column6.HeaderText = "TAX %"
        Column6.MinimumWidth = 6
        Column6.Name = "Column6"
        Column6.ReadOnly = True
        Column6.Width = 88
        ' 
        ' Column7
        ' 
        Column7.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column7.HeaderText = "TOTAL PRICE"
        Column7.MinimumWidth = 6
        Column7.Name = "Column7"
        Column7.ReadOnly = True
        Column7.Width = 137
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.Dock = DockStyle.Fill
        FlowLayoutPanel1.Location = New Point(3, 3)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(854, 464)
        FlowLayoutPanel1.TabIndex = 0
        ' 
        ' frm_userMain
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(244), CByte(244), CByte(244))
        ClientSize = New Size(1370, 759)
        Controls.Add(TableLayoutPanel1)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4)
        Name = "frm_userMain"
        StartPosition = FormStartPosition.CenterScreen
        Text = "frm_userMain"
        WindowState = FormWindowState.Maximized
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        TableLayoutPanel2.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        TableLayoutPanel1.ResumeLayout(False)
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Ibl_userinfo As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents btn_ManageUser As Button
    Friend WithEvents btn_Report As Button
    Friend WithEvents btn_Exit As Button
    Friend WithEvents btn_ManageBook As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Ibl_TranscationDate As Label
    Friend WithEvents Ibl_TransactionNo As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_Search As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
End Class
