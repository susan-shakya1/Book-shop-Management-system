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
        Panel1 = New Panel()
        btn_Close = New Button()
        Label1 = New Label()
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        TabPage2 = New TabPage()
        txt_BookId = New TextBox()
        Label2 = New Label()
        txt_BookName = New TextBox()
        Label3 = New Label()
        txt_Price = New TextBox()
        Label4 = New Label()
        txt_Author = New TextBox()
        Label5 = New Label()
        cbo_Tax = New ComboBox()
        Label6 = New Label()
        txt_TotalPrice = New TextBox()
        Label7 = New Label()
        btn_Save = New Button()
        btn_Edit = New Button()
        btn_Delete = New Button()
        txt_Search = New TextBox()
        Label8 = New Label()
        btn_Search = New Button()
        pic_bookimg = New PictureBox()
        Panel1.SuspendLayout()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
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
        TabPage1.Controls.Add(pic_bookimg)
        TabPage1.Controls.Add(btn_Search)
        TabPage1.Controls.Add(btn_Delete)
        TabPage1.Controls.Add(btn_Edit)
        TabPage1.Controls.Add(btn_Save)
        TabPage1.Controls.Add(cbo_Tax)
        TabPage1.Controls.Add(Label5)
        TabPage1.Controls.Add(Label6)
        TabPage1.Controls.Add(Label7)
        TabPage1.Controls.Add(Label4)
        TabPage1.Controls.Add(txt_TotalPrice)
        TabPage1.Controls.Add(txt_Author)
        TabPage1.Controls.Add(txt_Price)
        TabPage1.Controls.Add(Label3)
        TabPage1.Controls.Add(txt_BookName)
        TabPage1.Controls.Add(Label8)
        TabPage1.Controls.Add(txt_Search)
        TabPage1.Controls.Add(Label2)
        TabPage1.Controls.Add(txt_BookId)
        TabPage1.Location = New Point(4, 48)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(1106, 597)
        TabPage1.TabIndex = 0
        TabPage1.Text = " BOOK LIST"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' TabPage2
        ' 
        TabPage2.Location = New Point(4, 48)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(1106, 597)
        TabPage2.TabIndex = 1
        TabPage2.Text = "MANAGE BOOK"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' txt_BookId
        ' 
        txt_BookId.BorderStyle = BorderStyle.FixedSingle
        txt_BookId.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txt_BookId.Location = New Point(663, 131)
        txt_BookId.Name = "txt_BookId"
        txt_BookId.Size = New Size(342, 30)
        txt_BookId.TabIndex = 0
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(551, 138)
        Label2.Name = "Label2"
        Label2.Size = New Size(78, 23)
        Label2.TabIndex = 1
        Label2.Text = "BOOK ID"
        ' 
        ' txt_BookName
        ' 
        txt_BookName.BorderStyle = BorderStyle.FixedSingle
        txt_BookName.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txt_BookName.Location = New Point(663, 192)
        txt_BookName.Name = "txt_BookName"
        txt_BookName.Size = New Size(342, 30)
        txt_BookName.TabIndex = 0
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(522, 199)
        Label3.Name = "Label3"
        Label3.Size = New Size(109, 23)
        Label3.TabIndex = 1
        Label3.Text = "BOOK NAME"
        ' 
        ' txt_Price
        ' 
        txt_Price.BorderStyle = BorderStyle.FixedSingle
        txt_Price.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txt_Price.Location = New Point(663, 315)
        txt_Price.Name = "txt_Price"
        txt_Price.Size = New Size(342, 30)
        txt_Price.TabIndex = 0
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(576, 322)
        Label4.Name = "Label4"
        Label4.Size = New Size(55, 23)
        Label4.TabIndex = 1
        Label4.Text = "PRICE"
        ' 
        ' txt_Author
        ' 
        txt_Author.BorderStyle = BorderStyle.FixedSingle
        txt_Author.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txt_Author.Location = New Point(663, 256)
        txt_Author.Name = "txt_Author"
        txt_Author.Size = New Size(342, 30)
        txt_Author.TabIndex = 0
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(554, 263)
        Label5.Name = "Label5"
        Label5.Size = New Size(77, 23)
        Label5.TabIndex = 1
        Label5.Text = "AUTHOR"
        ' 
        ' cbo_Tax
        ' 
        cbo_Tax.FormattingEnabled = True
        cbo_Tax.Location = New Point(663, 372)
        cbo_Tax.Name = "cbo_Tax"
        cbo_Tax.Size = New Size(342, 31)
        cbo_Tax.TabIndex = 2
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(573, 375)
        Label6.Name = "Label6"
        Label6.Size = New Size(58, 23)
        Label6.TabIndex = 1
        Label6.Text = "TAX %"
        ' 
        ' txt_TotalPrice
        ' 
        txt_TotalPrice.BorderStyle = BorderStyle.FixedSingle
        txt_TotalPrice.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txt_TotalPrice.Location = New Point(663, 433)
        txt_TotalPrice.Name = "txt_TotalPrice"
        txt_TotalPrice.Size = New Size(342, 30)
        txt_TotalPrice.TabIndex = 0
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(522, 440)
        Label7.Name = "Label7"
        Label7.Size = New Size(107, 23)
        Label7.TabIndex = 1
        Label7.Text = "TOTAL PRICE"
        ' 
        ' btn_Save
        ' 
        btn_Save.BackColor = SystemColors.Highlight
        btn_Save.FlatAppearance.BorderSize = 0
        btn_Save.FlatAppearance.MouseOverBackColor = SystemColors.HotTrack
        btn_Save.FlatStyle = FlatStyle.Flat
        btn_Save.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_Save.ForeColor = Color.White
        btn_Save.Location = New Point(663, 490)
        btn_Save.Name = "btn_Save"
        btn_Save.Size = New Size(89, 47)
        btn_Save.TabIndex = 3
        btn_Save.Text = "&Save"
        btn_Save.UseVisualStyleBackColor = False
        ' 
        ' btn_Edit
        ' 
        btn_Edit.BackColor = Color.Green
        btn_Edit.FlatAppearance.BorderSize = 0
        btn_Edit.FlatAppearance.MouseOverBackColor = SystemColors.HotTrack
        btn_Edit.FlatStyle = FlatStyle.Flat
        btn_Edit.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_Edit.ForeColor = Color.White
        btn_Edit.Location = New Point(777, 490)
        btn_Edit.Name = "btn_Edit"
        btn_Edit.Size = New Size(103, 47)
        btn_Edit.TabIndex = 3
        btn_Edit.Text = "&Edit"
        btn_Edit.UseVisualStyleBackColor = False
        ' 
        ' btn_Delete
        ' 
        btn_Delete.BackColor = Color.Brown
        btn_Delete.FlatAppearance.BorderSize = 0
        btn_Delete.FlatAppearance.MouseOverBackColor = SystemColors.HotTrack
        btn_Delete.FlatStyle = FlatStyle.Flat
        btn_Delete.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_Delete.ForeColor = Color.White
        btn_Delete.Location = New Point(909, 489)
        btn_Delete.Name = "btn_Delete"
        btn_Delete.Size = New Size(96, 48)
        btn_Delete.TabIndex = 3
        btn_Delete.Text = "&Delete"
        btn_Delete.UseVisualStyleBackColor = False
        ' 
        ' txt_Search
        ' 
        txt_Search.BorderStyle = BorderStyle.FixedSingle
        txt_Search.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txt_Search.Location = New Point(365, 62)
        txt_Search.Name = "txt_Search"
        txt_Search.Size = New Size(275, 30)
        txt_Search.TabIndex = 0
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(253, 69)
        Label8.Name = "Label8"
        Label8.Size = New Size(66, 23)
        Label8.TabIndex = 1
        Label8.Text = "Search "
        ' 
        ' btn_Search
        ' 
        btn_Search.BackColor = SystemColors.Highlight
        btn_Search.FlatAppearance.BorderSize = 0
        btn_Search.FlatAppearance.MouseOverBackColor = SystemColors.HotTrack
        btn_Search.FlatStyle = FlatStyle.Flat
        btn_Search.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_Search.ForeColor = Color.White
        btn_Search.Location = New Point(663, 62)
        btn_Search.Name = "btn_Search"
        btn_Search.Size = New Size(134, 30)
        btn_Search.TabIndex = 3
        btn_Search.Text = "Search"
        btn_Search.UseVisualStyleBackColor = False
        ' 
        ' pic_bookimg
        ' 
        pic_bookimg.Location = New Point(78, 138)
        pic_bookimg.Name = "pic_bookimg"
        pic_bookimg.Size = New Size(379, 348)
        pic_bookimg.TabIndex = 4
        pic_bookimg.TabStop = False
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
        TabPage1.PerformLayout()
        CType(pic_bookimg, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents btn_Close As Button
    Friend WithEvents Label1 As Label
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
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_BookId As TextBox
    Friend WithEvents btn_Save As Button
    Friend WithEvents btn_Search As Button
    Friend WithEvents btn_Delete As Button
    Friend WithEvents btn_Edit As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_Search As TextBox
    Friend WithEvents pic_bookimg As PictureBox
End Class
