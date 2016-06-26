<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.ProfileEdit = New System.Windows.Forms.Button()
        Me.Profile = New System.Windows.Forms.ComboBox()
        Me.Version = New System.Windows.Forms.ComboBox()
        Me.mcupdate = New System.Windows.Forms.WebBrowser()
        Me.Username = New System.Windows.Forms.Label()
        Me.DownloadTxt = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Premiumraido = New System.Windows.Forms.RadioButton()
        Me.Crackedraido = New System.Windows.Forms.RadioButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.iconprofile = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.iconprofile, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProfileEdit
        '
        Me.ProfileEdit.Location = New System.Drawing.Point(45, 543)
        Me.ProfileEdit.Name = "ProfileEdit"
        Me.ProfileEdit.Size = New System.Drawing.Size(75, 23)
        Me.ProfileEdit.TabIndex = 26
        Me.ProfileEdit.Text = "Edit Profile"
        Me.ProfileEdit.UseVisualStyleBackColor = True
        '
        'Profile
        '
        Me.Profile.FormattingEnabled = True
        Me.Profile.Location = New System.Drawing.Point(126, 545)
        Me.Profile.Name = "Profile"
        Me.Profile.Size = New System.Drawing.Size(219, 21)
        Me.Profile.TabIndex = 24
        Me.Profile.Text = "Profile"
        '
        'Version
        '
        Me.Version.FormattingEnabled = True
        Me.Version.Location = New System.Drawing.Point(126, 518)
        Me.Version.Name = "Version"
        Me.Version.Size = New System.Drawing.Size(219, 21)
        Me.Version.TabIndex = 25
        Me.Version.Text = "Latest"
        '
        'mcupdate
        '
        Me.mcupdate.Location = New System.Drawing.Point(29, 79)
        Me.mcupdate.MinimumSize = New System.Drawing.Size(20, 20)
        Me.mcupdate.Name = "mcupdate"
        Me.mcupdate.Size = New System.Drawing.Size(897, 384)
        Me.mcupdate.TabIndex = 20
        Me.mcupdate.Url = New System.Uri("http://mcupdate.tumblr.com", System.UriKind.Absolute)
        '
        'Username
        '
        Me.Username.AutoSize = True
        Me.Username.Location = New System.Drawing.Point(740, 516)
        Me.Username.Name = "Username"
        Me.Username.Size = New System.Drawing.Size(55, 13)
        Me.Username.TabIndex = 18
        Me.Username.Text = "Username"
        '
        'DownloadTxt
        '
        Me.DownloadTxt.AutoSize = True
        Me.DownloadTxt.Location = New System.Drawing.Point(444, 466)
        Me.DownloadTxt.Name = "DownloadTxt"
        Me.DownloadTxt.Size = New System.Drawing.Size(70, 13)
        Me.DownloadTxt.TabIndex = 19
        Me.DownloadTxt.Text = "DownloadTxt"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(45, 482)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(869, 23)
        Me.ProgressBar1.TabIndex = 16
        '
        'Premiumraido
        '
        Me.Premiumraido.AutoSize = True
        Me.Premiumraido.Location = New System.Drawing.Point(613, 541)
        Me.Premiumraido.Name = "Premiumraido"
        Me.Premiumraido.Size = New System.Drawing.Size(65, 17)
        Me.Premiumraido.TabIndex = 14
        Me.Premiumraido.TabStop = True
        Me.Premiumraido.Text = "Premuim"
        Me.Premiumraido.UseVisualStyleBackColor = True
        '
        'Crackedraido
        '
        Me.Crackedraido.AutoSize = True
        Me.Crackedraido.Location = New System.Drawing.Point(613, 518)
        Me.Crackedraido.Name = "Crackedraido"
        Me.Crackedraido.Size = New System.Drawing.Size(65, 17)
        Me.Crackedraido.TabIndex = 15
        Me.Crackedraido.TabStop = True
        Me.Crackedraido.Text = "Cracked"
        Me.Crackedraido.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(351, 518)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(256, 43)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Play Game"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(756, 541)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 20)
        Me.Label1.TabIndex = 28
        '
        'iconprofile
        '
        Me.iconprofile.Location = New System.Drawing.Point(684, 516)
        Me.iconprofile.Name = "iconprofile"
        Me.iconprofile.Size = New System.Drawing.Size(50, 50)
        Me.iconprofile.TabIndex = 27
        Me.iconprofile.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(277, -17)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(432, 125)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(955, 578)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.iconprofile)
        Me.Controls.Add(Me.ProfileEdit)
        Me.Controls.Add(Me.Profile)
        Me.Controls.Add(Me.Version)
        Me.Controls.Add(Me.mcupdate)
        Me.Controls.Add(Me.Username)
        Me.Controls.Add(Me.DownloadTxt)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Premiumraido)
        Me.Controls.Add(Me.Crackedraido)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.iconprofile, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ProfileEdit As Button
    Friend WithEvents Profile As ComboBox
    Friend WithEvents Version As ComboBox
    Friend WithEvents mcupdate As WebBrowser
    Friend WithEvents Username As Label
    Friend WithEvents DownloadTxt As Label
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Premiumraido As RadioButton
    Friend WithEvents Crackedraido As RadioButton
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents iconprofile As PictureBox
    Friend WithEvents Label1 As Label
End Class
