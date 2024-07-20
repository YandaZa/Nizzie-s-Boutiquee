<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SHOP
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
        btnClothing = New Button()
        btnShoes = New Button()
        btn = New Button()
        Button4 = New Button()
        Button5 = New Button()
        Button6 = New Button()
        PictureBox1 = New PictureBox()
        Button1 = New Button()
        Button2 = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnClothing
        ' 
        btnClothing.Location = New Point(140, 118)
        btnClothing.Name = "btnClothing"
        btnClothing.Size = New Size(223, 61)
        btnClothing.TabIndex = 0
        btnClothing.Text = "CLOTHING"
        btnClothing.UseVisualStyleBackColor = True
        ' 
        ' btnShoes
        ' 
        btnShoes.Location = New Point(140, 206)
        btnShoes.Name = "btnShoes"
        btnShoes.Size = New Size(223, 61)
        btnShoes.TabIndex = 1
        btnShoes.Text = "SHOES"
        btnShoes.UseVisualStyleBackColor = True
        ' 
        ' btn
        ' 
        btn.Location = New Point(140, 293)
        btn.Name = "btn"
        btn.Size = New Size(223, 61)
        btn.TabIndex = 2
        btn.Text = "UNDERWEAR"
        btn.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(432, 118)
        Button4.Name = "Button4"
        Button4.Size = New Size(223, 61)
        Button4.TabIndex = 3
        Button4.Text = "SLEEPWEAR"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(432, 206)
        Button5.Name = "Button5"
        Button5.Size = New Size(223, 61)
        Button5.TabIndex = 4
        Button5.Text = "ACCESSORIES"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button6
        ' 
        Button6.Location = New Point(432, 293)
        Button6.Name = "Button6"
        Button6.Size = New Size(223, 61)
        Button6.TabIndex = 5
        Button6.Text = "BEAUTY"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.IMG_7817
        PictureBox1.Location = New Point(207, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(391, 92)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 6
        PictureBox1.TabStop = False
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(140, 378)
        Button1.Name = "Button1"
        Button1.Size = New Size(223, 61)
        Button1.TabIndex = 7
        Button1.Text = "BEACHWEAR"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(432, 378)
        Button2.Name = "Button2"
        Button2.Size = New Size(223, 61)
        Button2.TabIndex = 8
        Button2.Text = "MARTENITY WEAR"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' SHOP
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(PictureBox1)
        Controls.Add(Button6)
        Controls.Add(Button5)
        Controls.Add(Button4)
        Controls.Add(btn)
        Controls.Add(btnShoes)
        Controls.Add(btnClothing)
        Name = "SHOP"
        StartPosition = FormStartPosition.CenterScreen
        Text = "SHOP"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnClothing As Button
    Friend WithEvents btnShoes As Button
    Friend WithEvents btn As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
