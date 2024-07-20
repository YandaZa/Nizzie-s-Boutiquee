<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Register
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
        lblRegister = New Label()
        txtFirstName = New TextBox()
        txtEmail = New TextBox()
        txtPassword = New TextBox()
        txtLastName = New TextBox()
        txtPhone = New TextBox()
        txtConfirmPassword = New TextBox()
        chkYesUpdate = New CheckBox()
        btnRegister = New Button()
        SuspendLayout()
        ' 
        ' lblRegister
        ' 
        lblRegister.AutoSize = True
        lblRegister.Font = New Font("Mongolian Baiti", 18F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblRegister.Location = New Point(320, 61)
        lblRegister.Name = "lblRegister"
        lblRegister.Size = New Size(135, 25)
        lblRegister.TabIndex = 0
        lblRegister.Text = "REGISTER"
        ' 
        ' txtFirstName
        ' 
        txtFirstName.Cursor = Cursors.Hand
        txtFirstName.Location = New Point(196, 144)
        txtFirstName.Name = "txtFirstName"
        txtFirstName.PlaceholderText = "FIRST NAME"
        txtFirstName.Size = New Size(169, 23)
        txtFirstName.TabIndex = 1
        ' 
        ' txtEmail
        ' 
        txtEmail.Cursor = Cursors.Hand
        txtEmail.Location = New Point(196, 216)
        txtEmail.Name = "txtEmail"
        txtEmail.PlaceholderText = "EMAIL"
        txtEmail.Size = New Size(169, 23)
        txtEmail.TabIndex = 2
        ' 
        ' txtPassword
        ' 
        txtPassword.Cursor = Cursors.Hand
        txtPassword.Location = New Point(196, 290)
        txtPassword.Name = "txtPassword"
        txtPassword.PlaceholderText = "PASSWORD"
        txtPassword.Size = New Size(169, 23)
        txtPassword.TabIndex = 3
        ' 
        ' txtLastName
        ' 
        txtLastName.Cursor = Cursors.Hand
        txtLastName.Location = New Point(434, 144)
        txtLastName.Name = "txtLastName"
        txtLastName.PlaceholderText = "LAST NAME"
        txtLastName.Size = New Size(169, 23)
        txtLastName.TabIndex = 4
        ' 
        ' txtPhone
        ' 
        txtPhone.Cursor = Cursors.Hand
        txtPhone.Location = New Point(434, 216)
        txtPhone.Name = "txtPhone"
        txtPhone.PlaceholderText = "PHONE"
        txtPhone.Size = New Size(169, 23)
        txtPhone.TabIndex = 5
        ' 
        ' txtConfirmPassword
        ' 
        txtConfirmPassword.Cursor = Cursors.Hand
        txtConfirmPassword.Location = New Point(434, 290)
        txtConfirmPassword.Name = "txtConfirmPassword"
        txtConfirmPassword.PlaceholderText = "CONFIRM PASSWORD"
        txtConfirmPassword.Size = New Size(169, 23)
        txtConfirmPassword.TabIndex = 6
        ' 
        ' chkYesUpdate
        ' 
        chkYesUpdate.AutoSize = True
        chkYesUpdate.Location = New Point(321, 335)
        chkYesUpdate.Name = "chkYesUpdate"
        chkYesUpdate.Size = New Size(142, 19)
        chkYesUpdate.TabIndex = 7
        chkYesUpdate.Text = "Yes, Keep me updated"
        chkYesUpdate.UseVisualStyleBackColor = True
        ' 
        ' btnRegister
        ' 
        btnRegister.Cursor = Cursors.Hand
        btnRegister.Location = New Point(333, 376)
        btnRegister.Name = "btnRegister"
        btnRegister.Size = New Size(130, 45)
        btnRegister.TabIndex = 8
        btnRegister.Text = "REGISTER"
        btnRegister.UseVisualStyleBackColor = True
        ' 
        ' Register
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnRegister)
        Controls.Add(chkYesUpdate)
        Controls.Add(txtConfirmPassword)
        Controls.Add(txtPhone)
        Controls.Add(txtLastName)
        Controls.Add(txtPassword)
        Controls.Add(txtEmail)
        Controls.Add(txtFirstName)
        Controls.Add(lblRegister)
        Name = "Register"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Register"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblRegister As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtConfirmPassword As TextBox
    Friend WithEvents chkYesUpdate As CheckBox
    Friend WithEvents btnRegister As Button
End Class
