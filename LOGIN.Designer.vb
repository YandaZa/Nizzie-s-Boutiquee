<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LOGIN
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
        txtUsername = New TextBox()
        txtPassword = New TextBox()
        lblSignIn = New Label()
        LinkLabel1 = New LinkLabel()
        btnSignIn = New Button()
        lnkNoProfile = New LinkLabel()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(305, 169)
        txtUsername.Name = "txtUsername"
        txtUsername.PlaceholderText = "USERNAME"
        txtUsername.Size = New Size(204, 23)
        txtUsername.TabIndex = 0
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(305, 224)
        txtPassword.Name = "txtPassword"
        txtPassword.PlaceholderText = "PASSWORD"
        txtPassword.Size = New Size(204, 23)
        txtPassword.TabIndex = 1
        ' 
        ' lblSignIn
        ' 
        lblSignIn.AutoSize = True
        lblSignIn.Font = New Font("Mongolian Baiti", 18F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblSignIn.Location = New Point(352, 26)
        lblSignIn.Name = "lblSignIn"
        lblSignIn.Size = New Size(105, 25)
        lblSignIn.TabIndex = 2
        lblSignIn.Text = "SIGN IN"
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.LinkColor = Color.Black
        LinkLabel1.Location = New Point(305, 264)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(100, 15)
        LinkLabel1.TabIndex = 3
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "Forgot Password?"
        ' 
        ' btnSignIn
        ' 
        btnSignIn.Location = New Point(352, 302)
        btnSignIn.Name = "btnSignIn"
        btnSignIn.Size = New Size(100, 41)
        btnSignIn.TabIndex = 4
        btnSignIn.Text = "SIGN IN"
        btnSignIn.UseVisualStyleBackColor = True
        ' 
        ' lnkNoProfile
        ' 
        lnkNoProfile.AutoSize = True
        lnkNoProfile.LinkColor = Color.Black
        lnkNoProfile.Location = New Point(347, 364)
        lnkNoProfile.Name = "lnkNoProfile"
        lnkNoProfile.Size = New Size(107, 15)
        lnkNoProfile.TabIndex = 5
        lnkNoProfile.TabStop = True
        lnkNoProfile.Text = "No Profile? register"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(265, 393)
        Label1.Name = "Label1"
        Label1.Size = New Size(290, 30)
        Label1.TabIndex = 6
        Label1.Text = "By continuing, you agree with our Privacy and Cookie" & vbCrLf & "                     Policy and Terms && Conditions"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.Capture
        PictureBox1.Location = New Point(151, 65)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(521, 73)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 7
        PictureBox1.TabStop = False
        ' 
        ' LOGIN
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(PictureBox1)
        Controls.Add(Label1)
        Controls.Add(lnkNoProfile)
        Controls.Add(btnSignIn)
        Controls.Add(LinkLabel1)
        Controls.Add(lblSignIn)
        Controls.Add(txtPassword)
        Controls.Add(txtUsername)
        Name = "LOGIN"
        StartPosition = FormStartPosition.CenterScreen
        Text = "LOGIN"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents lblSignIn As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents btnSignIn As Button
    Friend WithEvents lnkNoProfile As LinkLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox

End Class
