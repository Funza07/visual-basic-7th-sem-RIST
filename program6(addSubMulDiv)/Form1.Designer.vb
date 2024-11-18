<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(115, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(203, 19)
        Label1.TabIndex = 0
        Label1.Text = "Operations On Two Numbers"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(47, 53)
        Label2.Name = "Label2"
        Label2.Size = New Size(165, 19)
        Label2.TabIndex = 1
        Label2.Text = "Enter the first Number:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(28, 83)
        Label3.Name = "Label3"
        Label3.Size = New Size(184, 19)
        Label3.TabIndex = 2
        Label3.Text = "Enter the second Number:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(132, 192)
        Label4.Name = "Label4"
        Label4.Size = New Size(66, 19)
        Label4.TabIndex = 3
        Label4.Text = "Result : "
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(213, 192)
        Label5.Name = "Label5"
        Label5.Size = New Size(36, 19)
        Label5.TabIndex = 4
        Label5.Text = "N/A"
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(47, 120)
        Button1.Name = "Button1"
        Button1.Size = New Size(79, 57)
        Button1.TabIndex = 5
        Button1.Text = "Add(+)"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(132, 120)
        Button2.Name = "Button2"
        Button2.Size = New Size(79, 57)
        Button2.TabIndex = 6
        Button2.Text = "Subtract(-)"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button3.Location = New Point(214, 120)
        Button3.Name = "Button3"
        Button3.Size = New Size(79, 57)
        Button3.TabIndex = 7
        Button3.Text = "Multiply(*)"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Font = New Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button4.Location = New Point(299, 120)
        Button4.Name = "Button4"
        Button4.Size = New Size(79, 57)
        Button4.TabIndex = 8
        Button4.Text = "Divide(/)"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(230, 53)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(100, 23)
        TextBox1.TabIndex = 9
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(230, 83)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(100, 23)
        TextBox2.TabIndex = 10
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(387, 230)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Arithmetic Operations"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox

End Class
