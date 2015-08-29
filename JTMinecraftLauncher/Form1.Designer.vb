<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MinecraftLauncher
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MinecraftLauncher))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Crackedraido = New System.Windows.Forms.RadioButton()
        Me.Premiumraido = New System.Windows.Forms.RadioButton()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.DownloadTxt = New System.Windows.Forms.Label()
        Me.mcupdate = New System.Windows.Forms.WebBrowser()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Username = New System.Windows.Forms.Label()
        Me.Password = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Version = New System.Windows.Forms.ComboBox()
        Me.Profile = New System.Windows.Forms.ComboBox()
        Me.ProfileEdit = New System.Windows.Forms.Button()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(244, -21)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(432, 125)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(318, 514)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(256, 43)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Play Game"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Crackedraido
        '
        Me.Crackedraido.AutoSize = True
        Me.Crackedraido.Location = New System.Drawing.Point(580, 514)
        Me.Crackedraido.Name = "Crackedraido"
        Me.Crackedraido.Size = New System.Drawing.Size(65, 17)
        Me.Crackedraido.TabIndex = 3
        Me.Crackedraido.TabStop = True
        Me.Crackedraido.Text = "Cracked"
        Me.Crackedraido.UseVisualStyleBackColor = True
        '
        'Premiumraido
        '
        Me.Premiumraido.AutoSize = True
        Me.Premiumraido.Location = New System.Drawing.Point(580, 537)
        Me.Premiumraido.Name = "Premiumraido"
        Me.Premiumraido.Size = New System.Drawing.Size(65, 17)
        Me.Premiumraido.TabIndex = 3
        Me.Premiumraido.TabStop = True
        Me.Premiumraido.Text = "Premuim"
        Me.Premiumraido.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(12, 478)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(869, 23)
        Me.ProgressBar1.TabIndex = 4
        '
        'DownloadTxt
        '
        Me.DownloadTxt.AutoSize = True
        Me.DownloadTxt.Location = New System.Drawing.Point(411, 462)
        Me.DownloadTxt.Name = "DownloadTxt"
        Me.DownloadTxt.Size = New System.Drawing.Size(70, 13)
        Me.DownloadTxt.TabIndex = 5
        Me.DownloadTxt.Text = "DownloadTxt"
        '
        'mcupdate
        '
        Me.mcupdate.Location = New System.Drawing.Point(-4, 75)
        Me.mcupdate.MinimumSize = New System.Drawing.Size(20, 20)
        Me.mcupdate.Name = "mcupdate"
        Me.mcupdate.Size = New System.Drawing.Size(897, 384)
        Me.mcupdate.TabIndex = 6
        Me.mcupdate.Url = New System.Uri("http://mcupdate.tumblr.com", System.UriKind.Absolute)
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.Location = New System.Drawing.Point(768, 530)
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.MaskedTextBox1.Size = New System.Drawing.Size(113, 20)
        Me.MaskedTextBox1.TabIndex = 7
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(768, 508)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(113, 20)
        Me.TextBox1.TabIndex = 8
        '
        'Username
        '
        Me.Username.AutoSize = True
        Me.Username.Location = New System.Drawing.Point(707, 511)
        Me.Username.Name = "Username"
        Me.Username.Size = New System.Drawing.Size(55, 13)
        Me.Username.TabIndex = 5
        Me.Username.Text = "Username"
        '
        'Password
        '
        Me.Password.AutoSize = True
        Me.Password.Location = New System.Drawing.Point(709, 533)
        Me.Password.Name = "Password"
        Me.Password.Size = New System.Drawing.Size(53, 13)
        Me.Password.TabIndex = 5
        Me.Password.Text = "Password"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(768, 557)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(123, 17)
        Me.CheckBox1.TabIndex = 9
        Me.CheckBox1.Text = "Keep Me Logged In!"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Version
        '
        Me.Version.FormattingEnabled = True
        Me.Version.Location = New System.Drawing.Point(93, 514)
        Me.Version.Name = "Version"
        Me.Version.Size = New System.Drawing.Size(219, 21)
        Me.Version.TabIndex = 10
        Me.Version.Text = "Latest"
        '
        'Profile
        '
        Me.Profile.FormattingEnabled = True
        Me.Profile.Location = New System.Drawing.Point(93, 541)
        Me.Profile.Name = "Profile"
        Me.Profile.Size = New System.Drawing.Size(219, 21)
        Me.Profile.TabIndex = 10
        Me.Profile.Text = "Profile"
        '
        'ProfileEdit
        '
        Me.ProfileEdit.Location = New System.Drawing.Point(12, 539)
        Me.ProfileEdit.Name = "ProfileEdit"
        Me.ProfileEdit.Size = New System.Drawing.Size(75, 23)
        Me.ProfileEdit.TabIndex = 11
        Me.ProfileEdit.Text = "Edit Profile"
        Me.ProfileEdit.UseVisualStyleBackColor = True
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.NotifyIcon1.BalloonTipText = "Minecraft Is Running!"
        Me.NotifyIcon1.BalloonTipTitle = "Minecraft"
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "Minecraft"
        Me.NotifyIcon1.Visible = True
        '
        'MinecraftLauncher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(893, 572)
        Me.Controls.Add(Me.ProfileEdit)
        Me.Controls.Add(Me.Profile)
        Me.Controls.Add(Me.Version)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.MaskedTextBox1)
        Me.Controls.Add(Me.mcupdate)
        Me.Controls.Add(Me.Password)
        Me.Controls.Add(Me.Username)
        Me.Controls.Add(Me.DownloadTxt)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Premiumraido)
        Me.Controls.Add(Me.Crackedraido)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MinecraftLauncher"
        Me.Text = "Minecraft Launcher"
        Me.TransparencyKey = System.Drawing.Color.DarkOliveGreen
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Crackedraido As System.Windows.Forms.RadioButton
    Friend WithEvents Premiumraido As System.Windows.Forms.RadioButton
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents DownloadTxt As System.Windows.Forms.Label
    Friend WithEvents mcupdate As System.Windows.Forms.WebBrowser
    Friend WithEvents MaskedTextBox1 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Username As System.Windows.Forms.Label
    Friend WithEvents Password As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Version As System.Windows.Forms.ComboBox
    Friend WithEvents Profile As System.Windows.Forms.ComboBox
    Friend WithEvents ProfileEdit As System.Windows.Forms.Button
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon

End Class
