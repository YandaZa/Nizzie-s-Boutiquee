<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WELCOME
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
        Label2 = New Label()
        Panel1 = New Panel()
        PictureBox1 = New PictureBox()
        btnLogIn = New Button()
        btnRegister = New Button()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Kristen ITC", 36F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(237, 33)
        Label1.Name = "Label1"
        Label1.Size = New Size(325, 66)
        Label1.TabIndex = 0
        Label1.Text = "WELCOME "
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Mongolian Baiti", 18F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(293, 99)
        Label2.Name = "Label2"
        Label2.Size = New Size(213, 25)
        Label2.TabIndex = 1
        Label2.Text = "To Nizzie's Boutique"
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(PictureBox1)
        Panel1.Location = New Point(164, 137)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(472, 267)
        Panel1.TabIndex = 2
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.IMG_7807
        PictureBox1.Location = New Point(3, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(466, 261)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' btnLogIn
        ' 
        btnLogIn.Location = New Point(632, 415)
        btnLogIn.Name = "btnLogIn"
        btnLogIn.Size = New Size(75, 23)
        btnLogIn.TabIndex = 3
        btnLogIn.Text = "LOGIN"
        btnLogIn.UseVisualStyleBackColor = True
        ' 
        ' btnRegister
        ' 
        btnRegister.Location = New Point(713, 415)
        btnRegister.Name = "btnRegister"
        btnRegister.Size = New Size(75, 23)
        btnRegister.TabIndex = 4
        btnRegister.Text = "REGISTER"
        btnRegister.UseVisualStyleBackColor = True
        ' 
        ' WELCOME
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.GhostWhite
        ClientSize = New Size(800, 450)
        Controls.Add(btnRegister)
        Controls.Add(btnLogIn)
        Controls.Add(Panel1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "WELCOME"
        StartPosition = FormStartPosition.CenterScreen
        Text = "WELCOME"
        Panel1.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnLogIn As Button
    Friend WithEvents btnRegister As Button
End Class
