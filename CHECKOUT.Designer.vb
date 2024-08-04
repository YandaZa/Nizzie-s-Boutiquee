<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CHECKOUT
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
        Label1 = New Label()
        Panel1 = New Panel()
        Label2 = New Label()
        Panel2 = New Panel()
        Label3 = New Label()
        RadioButton1 = New RadioButton()
        Label4 = New Label()
        Panel3 = New Panel()
        Label5 = New Label()
        CheckBox1 = New CheckBox()
        Panel4 = New Panel()
        Label6 = New Label()
        RadioButton2 = New RadioButton()
        RadioButton3 = New RadioButton()
        RadioButton4 = New RadioButton()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        Panel4.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(324, 31)
        Label1.Name = "Label1"
        Label1.Size = New Size(141, 15)
        Label1.TabIndex = 0
        Label1.Text = "ORDER CORNFIRMATION"
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Label2)
        Panel1.Location = New Point(55, 64)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(693, 74)
        Panel1.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(26, 13)
        Label2.Name = "Label2"
        Label2.Size = New Size(306, 45)
        Label2.TabIndex = 0
        Label2.Text = "Wendy Zakhe 0622966031" & vbCrLf & "Elundini Municipality, 1 Seller street, Finance department" & vbCrLf & "Maclear, Eastern Cape South Africa, 5480"
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(RadioButton1)
        Panel2.Controls.Add(Label3)
        Panel2.Location = New Point(54, 144)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(694, 77)
        Panel2.TabIndex = 2
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(27, 10)
        Label3.Name = "Label3"
        Label3.Size = New Size(111, 15)
        Label3.TabIndex = 0
        Label3.Text = "SHIPPING METHOD"
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Location = New Point(22, 31)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(139, 34)
        RadioButton1.TabIndex = 1
        RadioButton1.TabStop = True
        RadioButton1.Text = "STANDARD SHIPPING" & vbCrLf & "R150 "
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(69, 48)
        Label4.Name = "Label4"
        Label4.Size = New Size(123, 15)
        Label4.TabIndex = 2
        Label4.Text = "(11-17 Business Days.)"
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(CheckBox1)
        Panel3.Controls.Add(Label5)
        Panel3.Location = New Point(54, 227)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(293, 33)
        Panel3.TabIndex = 3
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(19, 9)
        Label5.Name = "Label5"
        Label5.Size = New Size(139, 15)
        Label5.TabIndex = 0
        Label5.Text = "Shipping Guarantee: R18 "
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Checked = True
        CheckBox1.CheckState = CheckState.Checked
        CheckBox1.Location = New Point(267, 10)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(15, 14)
        CheckBox1.TabIndex = 1
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' Panel4
        ' 
        Panel4.Controls.Add(RadioButton4)
        Panel4.Controls.Add(RadioButton3)
        Panel4.Controls.Add(RadioButton2)
        Panel4.Controls.Add(Label6)
        Panel4.Location = New Point(54, 266)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(369, 180)
        Panel4.TabIndex = 4
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(23, 20)
        Label6.Name = "Label6"
        Label6.Size = New Size(111, 15)
        Label6.TabIndex = 0
        Label6.Text = "PAYMENT METHOD"
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Location = New Point(26, 59)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(14, 13)
        RadioButton2.TabIndex = 1
        RadioButton2.TabStop = True
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' RadioButton3
        ' 
        RadioButton3.AutoSize = True
        RadioButton3.Location = New Point(23, 89)
        RadioButton3.Name = "RadioButton3"
        RadioButton3.Size = New Size(97, 19)
        RadioButton3.TabIndex = 2
        RadioButton3.TabStop = True
        RadioButton3.Text = "RadioButton3"
        RadioButton3.UseVisualStyleBackColor = True
        ' 
        ' RadioButton4
        ' 
        RadioButton4.AutoSize = True
        RadioButton4.Location = New Point(26, 122)
        RadioButton4.Name = "RadioButton4"
        RadioButton4.Size = New Size(97, 19)
        RadioButton4.TabIndex = 3
        RadioButton4.TabStop = True
        RadioButton4.Text = "RadioButton4"
        RadioButton4.UseVisualStyleBackColor = True
        ' 
        ' CHECKOUT
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Panel4)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(Label1)
        Name = "CHECKOUT"
        Text = "CHECKOUT"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
End Class
