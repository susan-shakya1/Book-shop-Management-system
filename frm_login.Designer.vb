<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_login))
        PictureBox1 = New PictureBox()
        txt_password = New TextBox()
        txt_userName = New TextBox()
        btn_login = New Button()
        btn_exit = New Button()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Dock = DockStyle.Left
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(362, 402)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' txt_password
        ' 
        txt_password.BorderStyle = BorderStyle.FixedSingle
        txt_password.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txt_password.Location = New Point(417, 191)
        txt_password.Name = "txt_password"
        txt_password.Size = New Size(229, 30)
        txt_password.TabIndex = 1
        txt_password.UseSystemPasswordChar = True
        ' 
        ' txt_userName
        ' 
        txt_userName.BorderStyle = BorderStyle.FixedSingle
        txt_userName.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txt_userName.Location = New Point(417, 117)
        txt_userName.Name = "txt_userName"
        txt_userName.Size = New Size(229, 30)
        txt_userName.TabIndex = 1
        ' 
        ' btn_login
        ' 
        btn_login.BackColor = SystemColors.Highlight
        btn_login.FlatStyle = FlatStyle.Flat
        btn_login.ForeColor = Color.White
        btn_login.Location = New Point(422, 237)
        btn_login.Name = "btn_login"
        btn_login.Size = New Size(229, 35)
        btn_login.TabIndex = 2
        btn_login.Text = "Login"
        btn_login.UseVisualStyleBackColor = False
        ' 
        ' btn_exit
        ' 
        btn_exit.BackColor = Color.IndianRed
        btn_exit.FlatStyle = FlatStyle.Flat
        btn_exit.ForeColor = Color.White
        btn_exit.Location = New Point(422, 278)
        btn_exit.Name = "btn_exit"
        btn_exit.Size = New Size(229, 35)
        btn_exit.TabIndex = 2
        btn_exit.Text = "Exit"
        btn_exit.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(417, 165)
        Label2.Name = "Label2"
        Label2.Size = New Size(82, 23)
        Label2.TabIndex = 4
        Label2.Text = "Password"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(417, 91)
        Label3.Name = "Label3"
        Label3.Size = New Size(87, 23)
        Label3.TabIndex = 4
        Label3.Text = "Username"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(477, 31)
        Label4.Name = "Label4"
        Label4.Size = New Size(128, 28)
        Label4.TabIndex = 4
        Label4.Text = "Login Here !"
        ' 
        ' frm_login
        ' 
        AutoScaleDimensions = New SizeF(9F, 23F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(728, 402)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(btn_exit)
        Controls.Add(btn_login)
        Controls.Add(txt_userName)
        Controls.Add(txt_password)
        Controls.Add(PictureBox1)
        Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.None
        Name = "frm_login"
        StartPosition = FormStartPosition.CenterScreen
        Text = "frm_login"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txt_password As TextBox
    Friend WithEvents txt_userName As TextBox
    Friend WithEvents btn_login As Button
    Friend WithEvents btn_exit As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
