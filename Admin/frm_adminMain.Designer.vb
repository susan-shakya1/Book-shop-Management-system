<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_adminMain
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
        Logo = New Label()
        TableLayoutPanel1 = New TableLayoutPanel()
        btn_ManageUser = New Button()
        btn_Report = New Button()
        btn_Exit = New Button()
        btn_ManageBook = New Button()
        Panel2 = New Panel()
        Ibl_UserInfo = New Button()
        Panel1.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(Logo)
        Panel1.Controls.Add(TableLayoutPanel1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1842, 84)
        Panel1.TabIndex = 0
        ' 
        ' Logo
        ' 
        Logo.AutoSize = True
        Logo.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Logo.ForeColor = Color.IndianRed
        Logo.Location = New Point(58, 35)
        Logo.Name = "Logo"
        Logo.Size = New Size(163, 28)
        Logo.TabIndex = 2
        Logo.Text = "B O O K S H O P"
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        TableLayoutPanel1.ColumnCount = 4
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TableLayoutPanel1.Controls.Add(btn_ManageUser, 1, 0)
        TableLayoutPanel1.Controls.Add(btn_Report, 2, 0)
        TableLayoutPanel1.Controls.Add(btn_Exit, 3, 0)
        TableLayoutPanel1.Controls.Add(btn_ManageBook, 0, 0)
        TableLayoutPanel1.Location = New Point(1237, 3)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 1
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.Size = New Size(605, 63)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' btn_ManageUser
        ' 
        btn_ManageUser.Dock = DockStyle.Fill
        btn_ManageUser.FlatAppearance.BorderSize = 0
        btn_ManageUser.FlatAppearance.MouseOverBackColor = Color.Firebrick
        btn_ManageUser.FlatStyle = FlatStyle.Flat
        btn_ManageUser.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_ManageUser.Location = New Point(154, 3)
        btn_ManageUser.Name = "btn_ManageUser"
        btn_ManageUser.Size = New Size(145, 57)
        btn_ManageUser.TabIndex = 0
        btn_ManageUser.Text = "Manage User's"
        btn_ManageUser.UseVisualStyleBackColor = True
        ' 
        ' btn_Report
        ' 
        btn_Report.Dock = DockStyle.Fill
        btn_Report.FlatAppearance.BorderSize = 0
        btn_Report.FlatAppearance.MouseOverBackColor = Color.Firebrick
        btn_Report.FlatStyle = FlatStyle.Flat
        btn_Report.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_Report.Location = New Point(305, 3)
        btn_Report.Name = "btn_Report"
        btn_Report.Size = New Size(145, 57)
        btn_Report.TabIndex = 0
        btn_Report.Text = "Report"
        btn_Report.UseVisualStyleBackColor = True
        ' 
        ' btn_Exit
        ' 
        btn_Exit.Dock = DockStyle.Fill
        btn_Exit.FlatAppearance.BorderSize = 0
        btn_Exit.FlatAppearance.MouseOverBackColor = Color.Firebrick
        btn_Exit.FlatStyle = FlatStyle.Flat
        btn_Exit.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_Exit.Location = New Point(456, 3)
        btn_Exit.Name = "btn_Exit"
        btn_Exit.Size = New Size(146, 57)
        btn_Exit.TabIndex = 0
        btn_Exit.Text = "Exit"
        btn_Exit.UseVisualStyleBackColor = True
        ' 
        ' btn_ManageBook
        ' 
        btn_ManageBook.Dock = DockStyle.Fill
        btn_ManageBook.FlatAppearance.BorderSize = 0
        btn_ManageBook.FlatAppearance.MouseOverBackColor = Color.Firebrick
        btn_ManageBook.FlatStyle = FlatStyle.Flat
        btn_ManageBook.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_ManageBook.Location = New Point(3, 3)
        btn_ManageBook.Name = "btn_ManageBook"
        btn_ManageBook.Size = New Size(145, 57)
        btn_ManageBook.TabIndex = 0
        btn_ManageBook.Text = "Manage Book's"
        btn_ManageBook.UseVisualStyleBackColor = True
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.WhiteSmoke
        Panel2.Controls.Add(Ibl_UserInfo)
        Panel2.Dock = DockStyle.Bottom
        Panel2.Location = New Point(0, 830)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1842, 72)
        Panel2.TabIndex = 1
        ' 
        ' Ibl_UserInfo
        ' 
        Ibl_UserInfo.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Ibl_UserInfo.Location = New Point(58, 14)
        Ibl_UserInfo.Name = "Ibl_UserInfo"
        Ibl_UserInfo.Size = New Size(177, 46)
        Ibl_UserInfo.TabIndex = 3
        Ibl_UserInfo.Text = "Label1"
        Ibl_UserInfo.UseVisualStyleBackColor = True
        ' 
        ' frm_adminMain
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1842, 902)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Cursor = Cursors.Hand
        FormBorderStyle = FormBorderStyle.None
        Name = "frm_adminMain"
        StartPosition = FormStartPosition.CenterScreen
        Text = "frm_adminMain"
        WindowState = FormWindowState.Maximized
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        TableLayoutPanel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btn_ManageBook As Button
    Friend WithEvents btn_ManageUser As Button
    Friend WithEvents btn_Report As Button
    Friend WithEvents btn_Exit As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Logo As Label
    Friend WithEvents Ibl_UserInfo As Button
End Class
