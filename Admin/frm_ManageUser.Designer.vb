<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_ManageUser
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Panel1 = New Panel()
        Label5 = New Label()
        txt_name = New TextBox()
        Label1 = New Label()
        txt_UserName = New TextBox()
        Label2 = New Label()
        txt_Password = New TextBox()
        Label3 = New Label()
        cbo_role = New ComboBox()
        Label4 = New Label()
        btn_Cancel = New Button()
        btn_register = New Button()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(42), CByte(42), CByte(42))
        Panel1.Controls.Add(Label5)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(800, 60)
        Panel1.TabIndex = 0
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.White
        Label5.Location = New Point(90, 18)
        Label5.Name = "Label5"
        Label5.Size = New Size(145, 28)
        Label5.TabIndex = 2
        Label5.Text = "Manage Users"
        ' 
        ' txt_name
        ' 
        txt_name.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txt_name.Location = New Point(190, 79)
        txt_name.Name = "txt_name"
        txt_name.Size = New Size(381, 30)
        txt_name.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(90, 86)
        Label1.Name = "Label1"
        Label1.Size = New Size(49, 20)
        Label1.TabIndex = 2
        Label1.Text = "Name"
        ' 
        ' txt_UserName
        ' 
        txt_UserName.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txt_UserName.Location = New Point(190, 143)
        txt_UserName.Name = "txt_UserName"
        txt_UserName.Size = New Size(381, 30)
        txt_UserName.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(90, 150)
        Label2.Name = "Label2"
        Label2.Size = New Size(78, 20)
        Label2.TabIndex = 2
        Label2.Text = "UserName"
        ' 
        ' txt_Password
        ' 
        txt_Password.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txt_Password.Location = New Point(190, 206)
        txt_Password.Name = "txt_Password"
        txt_Password.Size = New Size(381, 30)
        txt_Password.TabIndex = 1
        txt_Password.UseSystemPasswordChar = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(90, 213)
        Label3.Name = "Label3"
        Label3.Size = New Size(70, 20)
        Label3.TabIndex = 2
        Label3.Text = "Password"
        ' 
        ' cbo_role
        ' 
        cbo_role.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cbo_role.FormattingEnabled = True
        cbo_role.Items.AddRange(New Object() {"ADMIN", "USER"})
        cbo_role.Location = New Point(190, 270)
        cbo_role.Name = "cbo_role"
        cbo_role.Size = New Size(376, 31)
        cbo_role.TabIndex = 3
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(90, 278)
        Label4.Name = "Label4"
        Label4.Size = New Size(39, 20)
        Label4.TabIndex = 2
        Label4.Text = "Role"
        ' 
        ' btn_Cancel
        ' 
        btn_Cancel.BackColor = Color.IndianRed
        btn_Cancel.FlatStyle = FlatStyle.Flat
        btn_Cancel.ForeColor = Color.White
        btn_Cancel.Location = New Point(408, 324)
        btn_Cancel.Name = "btn_Cancel"
        btn_Cancel.Size = New Size(158, 37)
        btn_Cancel.TabIndex = 4
        btn_Cancel.Text = "Cancel"
        btn_Cancel.UseVisualStyleBackColor = False
        ' 
        ' btn_register
        ' 
        btn_register.BackColor = SystemColors.Highlight
        btn_register.FlatStyle = FlatStyle.Flat
        btn_register.ForeColor = Color.White
        btn_register.Location = New Point(190, 324)
        btn_register.Name = "btn_register"
        btn_register.Size = New Size(158, 37)
        btn_register.TabIndex = 4
        btn_register.Text = "Register"
        btn_register.UseVisualStyleBackColor = False
        ' 
        ' frm_ManageUser
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(800, 450)
        Controls.Add(btn_register)
        Controls.Add(btn_Cancel)
        Controls.Add(cbo_role)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(txt_Password)
        Controls.Add(Label2)
        Controls.Add(txt_UserName)
        Controls.Add(Label1)
        Controls.Add(txt_name)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "frm_ManageUser"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents txt_name As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_UserName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_Password As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cbo_role As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btn_Cancel As Button
    Friend WithEvents btn_register As Button
    Friend WithEvents Label5 As Label

End Class
