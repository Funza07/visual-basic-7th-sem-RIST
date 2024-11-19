<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class registerForm
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
        txtUsername = New TextBox()
        txtPassword = New TextBox()
        txtEmail = New TextBox()
        BtnRegister = New Button()
        txtConfirmPassword = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        SuspendLayout()
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(121, 23)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(199, 23)
        txtUsername.TabIndex = 0
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(121, 59)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(199, 23)
        txtPassword.TabIndex = 1
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(121, 94)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(199, 23)
        txtEmail.TabIndex = 2
        ' 
        ' BtnRegister
        ' 
        BtnRegister.Location = New Point(152, 169)
        BtnRegister.Name = "BtnRegister"
        BtnRegister.Size = New Size(75, 23)
        BtnRegister.TabIndex = 3
        BtnRegister.Text = "Register"
        BtnRegister.UseVisualStyleBackColor = True
        ' 
        ' txtConfirmPassword
        ' 
        txtConfirmPassword.Location = New Point(121, 128)
        txtConfirmPassword.Name = "txtConfirmPassword"
        txtConfirmPassword.Size = New Size(199, 23)
        txtConfirmPassword.TabIndex = 4
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(53, 26)
        Label1.Name = "Label1"
        Label1.Size = New Size(62, 15)
        Label1.TabIndex = 5
        Label1.Text = "UserName"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(53, 62)
        Label2.Name = "Label2"
        Label2.Size = New Size(57, 15)
        Label2.TabIndex = 6
        Label2.Text = "Password"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(74, 97)
        Label3.Name = "Label3"
        Label3.Size = New Size(36, 15)
        Label3.TabIndex = 7
        Label3.Text = "Email"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(2, 131)
        Label4.Name = "Label4"
        Label4.Size = New Size(108, 15)
        Label4.TabIndex = 8
        Label4.Text = "Conform Password"
        ' 
        ' registerForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(343, 206)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtConfirmPassword)
        Controls.Add(BtnRegister)
        Controls.Add(txtEmail)
        Controls.Add(txtPassword)
        Controls.Add(txtUsername)
        Name = "registerForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "registerForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents BtnRegister As Button
    Friend WithEvents txtConfirmPassword As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
