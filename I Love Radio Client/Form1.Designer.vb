<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.AxWindowsMediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Star7 = New System.Windows.Forms.PictureBox()
        Me.ILR7B = New System.Windows.Forms.Button()
        Me.Star6 = New System.Windows.Forms.PictureBox()
        Me.Star5 = New System.Windows.Forms.PictureBox()
        Me.ILR6B = New System.Windows.Forms.Button()
        Me.ILR5B = New System.Windows.Forms.Button()
        Me.Star4 = New System.Windows.Forms.PictureBox()
        Me.Star3 = New System.Windows.Forms.PictureBox()
        Me.Star2 = New System.Windows.Forms.PictureBox()
        Me.Star1 = New System.Windows.Forms.PictureBox()
        Me.ILR4B = New System.Windows.Forms.Button()
        Me.ILR3B = New System.Windows.Forms.Button()
        Me.ILR2B = New System.Windows.Forms.Button()
        Me.ILR1B = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.B7 = New System.Windows.Forms.Button()
        Me.B6 = New System.Windows.Forms.Button()
        Me.B5 = New System.Windows.Forms.Button()
        Me.B4 = New System.Windows.Forms.Button()
        Me.B3 = New System.Windows.Forms.Button()
        Me.B2 = New System.Windows.Forms.Button()
        Me.B1 = New System.Windows.Forms.Button()
        Me.FavTimer = New System.Windows.Forms.Timer(Me.components)
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.versionlbl = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.Star7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Star6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Star5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Star4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Star3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Star2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Star1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'AxWindowsMediaPlayer1
        '
        Me.AxWindowsMediaPlayer1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.AxWindowsMediaPlayer1.Enabled = True
        Me.AxWindowsMediaPlayer1.Location = New System.Drawing.Point(0, 520)
        Me.AxWindowsMediaPlayer1.Name = "AxWindowsMediaPlayer1"
        Me.AxWindowsMediaPlayer1.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer1.Size = New System.Drawing.Size(653, 45)
        Me.AxWindowsMediaPlayer1.TabIndex = 0
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TabControl1.Font = New System.Drawing.Font("Exo", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(653, 446)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.Star7)
        Me.TabPage1.Controls.Add(Me.ILR7B)
        Me.TabPage1.Controls.Add(Me.Star6)
        Me.TabPage1.Controls.Add(Me.Star5)
        Me.TabPage1.Controls.Add(Me.ILR6B)
        Me.TabPage1.Controls.Add(Me.ILR5B)
        Me.TabPage1.Controls.Add(Me.Star4)
        Me.TabPage1.Controls.Add(Me.Star3)
        Me.TabPage1.Controls.Add(Me.Star2)
        Me.TabPage1.Controls.Add(Me.Star1)
        Me.TabPage1.Controls.Add(Me.ILR4B)
        Me.TabPage1.Controls.Add(Me.ILR3B)
        Me.TabPage1.Controls.Add(Me.ILR2B)
        Me.TabPage1.Controls.Add(Me.ILR1B)
        Me.TabPage1.ForeColor = System.Drawing.SystemColors.Control
        Me.TabPage1.Location = New System.Drawing.Point(4, 45)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(645, 397)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Sender"
        '
        'Star7
        '
        Me.Star7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Star7.Image = Global.I_Love_Radio_Client.My.Resources.Resources.star_off
        Me.Star7.Location = New System.Drawing.Point(26, 371)
        Me.Star7.Name = "Star7"
        Me.Star7.Size = New System.Drawing.Size(58, 50)
        Me.Star7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Star7.TabIndex = 15
        Me.Star7.TabStop = False
        '
        'ILR7B
        '
        Me.ILR7B.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ILR7B.FlatAppearance.BorderSize = 0
        Me.ILR7B.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ILR7B.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ILR7B.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ILR7B.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.ILR7B.Location = New System.Drawing.Point(118, 371)
        Me.ILR7B.Name = "ILR7B"
        Me.ILR7B.Size = New System.Drawing.Size(450, 50)
        Me.ILR7B.TabIndex = 14
        Me.ILR7B.Text = "I Love Radio Hits History"
        Me.ILR7B.UseVisualStyleBackColor = False
        '
        'Star6
        '
        Me.Star6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Star6.Image = Global.I_Love_Radio_Client.My.Resources.Resources.star_off
        Me.Star6.Location = New System.Drawing.Point(26, 315)
        Me.Star6.Name = "Star6"
        Me.Star6.Size = New System.Drawing.Size(58, 50)
        Me.Star6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Star6.TabIndex = 13
        Me.Star6.TabStop = False
        '
        'Star5
        '
        Me.Star5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Star5.Image = Global.I_Love_Radio_Client.My.Resources.Resources.star_off
        Me.Star5.Location = New System.Drawing.Point(26, 259)
        Me.Star5.Name = "Star5"
        Me.Star5.Size = New System.Drawing.Size(58, 50)
        Me.Star5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Star5.TabIndex = 12
        Me.Star5.TabStop = False
        '
        'ILR6B
        '
        Me.ILR6B.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ILR6B.FlatAppearance.BorderSize = 0
        Me.ILR6B.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ILR6B.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ILR6B.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ILR6B.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.ILR6B.Location = New System.Drawing.Point(118, 315)
        Me.ILR6B.Name = "ILR6B"
        Me.ILR6B.Size = New System.Drawing.Size(450, 50)
        Me.ILR6B.TabIndex = 11
        Me.ILR6B.Text = "I Love Radio Mainstage"
        Me.ILR6B.UseVisualStyleBackColor = False
        '
        'ILR5B
        '
        Me.ILR5B.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ILR5B.FlatAppearance.BorderSize = 0
        Me.ILR5B.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ILR5B.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ILR5B.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ILR5B.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.ILR5B.Location = New System.Drawing.Point(118, 259)
        Me.ILR5B.Name = "ILR5B"
        Me.ILR5B.Size = New System.Drawing.Size(450, 50)
        Me.ILR5B.TabIndex = 10
        Me.ILR5B.Text = "I Love Radio The Sun"
        Me.ILR5B.UseVisualStyleBackColor = False
        '
        'Star4
        '
        Me.Star4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Star4.Image = Global.I_Love_Radio_Client.My.Resources.Resources.star_off
        Me.Star4.Location = New System.Drawing.Point(26, 203)
        Me.Star4.Name = "Star4"
        Me.Star4.Size = New System.Drawing.Size(58, 50)
        Me.Star4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Star4.TabIndex = 8
        Me.Star4.TabStop = False
        '
        'Star3
        '
        Me.Star3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Star3.Image = Global.I_Love_Radio_Client.My.Resources.Resources.star_off
        Me.Star3.Location = New System.Drawing.Point(26, 147)
        Me.Star3.Name = "Star3"
        Me.Star3.Size = New System.Drawing.Size(58, 50)
        Me.Star3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Star3.TabIndex = 7
        Me.Star3.TabStop = False
        '
        'Star2
        '
        Me.Star2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Star2.Image = Global.I_Love_Radio_Client.My.Resources.Resources.star_off
        Me.Star2.Location = New System.Drawing.Point(26, 91)
        Me.Star2.Name = "Star2"
        Me.Star2.Size = New System.Drawing.Size(58, 50)
        Me.Star2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Star2.TabIndex = 6
        Me.Star2.TabStop = False
        '
        'Star1
        '
        Me.Star1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Star1.Image = Global.I_Love_Radio_Client.My.Resources.Resources.star_off
        Me.Star1.Location = New System.Drawing.Point(26, 35)
        Me.Star1.Name = "Star1"
        Me.Star1.Size = New System.Drawing.Size(58, 50)
        Me.Star1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Star1.TabIndex = 5
        Me.Star1.TabStop = False
        '
        'ILR4B
        '
        Me.ILR4B.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ILR4B.FlatAppearance.BorderSize = 0
        Me.ILR4B.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ILR4B.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ILR4B.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ILR4B.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.ILR4B.Location = New System.Drawing.Point(118, 203)
        Me.ILR4B.Name = "ILR4B"
        Me.ILR4B.Size = New System.Drawing.Size(450, 50)
        Me.ILR4B.TabIndex = 4
        Me.ILR4B.Text = "I Love Radio Deutschrap"
        Me.ILR4B.UseVisualStyleBackColor = False
        '
        'ILR3B
        '
        Me.ILR3B.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ILR3B.FlatAppearance.BorderSize = 0
        Me.ILR3B.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ILR3B.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ILR3B.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ILR3B.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.ILR3B.Location = New System.Drawing.Point(118, 147)
        Me.ILR3B.Name = "ILR3B"
        Me.ILR3B.Size = New System.Drawing.Size(450, 50)
        Me.ILR3B.TabIndex = 3
        Me.ILR3B.Text = "I Love Radio Club"
        Me.ILR3B.UseVisualStyleBackColor = False
        '
        'ILR2B
        '
        Me.ILR2B.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ILR2B.FlatAppearance.BorderSize = 0
        Me.ILR2B.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ILR2B.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ILR2B.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ILR2B.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.ILR2B.Location = New System.Drawing.Point(118, 91)
        Me.ILR2B.Name = "ILR2B"
        Me.ILR2B.Size = New System.Drawing.Size(450, 50)
        Me.ILR2B.TabIndex = 2
        Me.ILR2B.Text = "I Love Radio Masup"
        Me.ILR2B.UseVisualStyleBackColor = False
        '
        'ILR1B
        '
        Me.ILR1B.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ILR1B.FlatAppearance.BorderSize = 0
        Me.ILR1B.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ILR1B.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ILR1B.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ILR1B.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.ILR1B.Location = New System.Drawing.Point(118, 35)
        Me.ILR1B.Name = "ILR1B"
        Me.ILR1B.Size = New System.Drawing.Size(450, 50)
        Me.ILR1B.TabIndex = 1
        Me.ILR1B.Text = "I Love Radio"
        Me.ILR1B.UseVisualStyleBackColor = False
        '
        'TabPage2
        '
        Me.TabPage2.AutoScroll = True
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.TabPage2.Controls.Add(Me.B7)
        Me.TabPage2.Controls.Add(Me.B6)
        Me.TabPage2.Controls.Add(Me.B5)
        Me.TabPage2.Controls.Add(Me.B4)
        Me.TabPage2.Controls.Add(Me.B3)
        Me.TabPage2.Controls.Add(Me.B2)
        Me.TabPage2.Controls.Add(Me.B1)
        Me.TabPage2.ForeColor = System.Drawing.SystemColors.Control
        Me.TabPage2.Location = New System.Drawing.Point(4, 45)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(645, 397)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Favoriten"
        '
        'B7
        '
        Me.B7.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.B7.Enabled = False
        Me.B7.FlatAppearance.BorderSize = 0
        Me.B7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.B7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.B7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.B7.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.B7.Location = New System.Drawing.Point(87, 341)
        Me.B7.Name = "B7"
        Me.B7.Size = New System.Drawing.Size(450, 50)
        Me.B7.TabIndex = 21
        Me.B7.Text = "I Love Radio Hits History"
        Me.B7.UseVisualStyleBackColor = False
        '
        'B6
        '
        Me.B6.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.B6.Enabled = False
        Me.B6.FlatAppearance.BorderSize = 0
        Me.B6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.B6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.B6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.B6.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.B6.Location = New System.Drawing.Point(87, 285)
        Me.B6.Name = "B6"
        Me.B6.Size = New System.Drawing.Size(450, 50)
        Me.B6.TabIndex = 20
        Me.B6.Text = "I Love Radio Mainstage"
        Me.B6.UseVisualStyleBackColor = False
        '
        'B5
        '
        Me.B5.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.B5.Enabled = False
        Me.B5.FlatAppearance.BorderSize = 0
        Me.B5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.B5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.B5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.B5.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.B5.Location = New System.Drawing.Point(87, 229)
        Me.B5.Name = "B5"
        Me.B5.Size = New System.Drawing.Size(450, 50)
        Me.B5.TabIndex = 19
        Me.B5.Text = "I Love Radio The Sun"
        Me.B5.UseVisualStyleBackColor = False
        '
        'B4
        '
        Me.B4.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.B4.Enabled = False
        Me.B4.FlatAppearance.BorderSize = 0
        Me.B4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.B4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.B4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.B4.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.B4.Location = New System.Drawing.Point(87, 173)
        Me.B4.Name = "B4"
        Me.B4.Size = New System.Drawing.Size(450, 50)
        Me.B4.TabIndex = 18
        Me.B4.Text = "I Love Radio Deutschrap"
        Me.B4.UseVisualStyleBackColor = False
        '
        'B3
        '
        Me.B3.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.B3.Enabled = False
        Me.B3.FlatAppearance.BorderSize = 0
        Me.B3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.B3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.B3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.B3.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.B3.Location = New System.Drawing.Point(87, 117)
        Me.B3.Name = "B3"
        Me.B3.Size = New System.Drawing.Size(450, 50)
        Me.B3.TabIndex = 17
        Me.B3.Text = "I Love Radio Club"
        Me.B3.UseVisualStyleBackColor = False
        '
        'B2
        '
        Me.B2.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.B2.Enabled = False
        Me.B2.FlatAppearance.BorderSize = 0
        Me.B2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.B2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.B2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.B2.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.B2.Location = New System.Drawing.Point(87, 61)
        Me.B2.Name = "B2"
        Me.B2.Size = New System.Drawing.Size(450, 50)
        Me.B2.TabIndex = 16
        Me.B2.Text = "I Love Radio Masup"
        Me.B2.UseVisualStyleBackColor = False
        '
        'B1
        '
        Me.B1.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.B1.FlatAppearance.BorderSize = 0
        Me.B1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.B1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.B1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.B1.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.B1.Location = New System.Drawing.Point(87, 5)
        Me.B1.Name = "B1"
        Me.B1.Size = New System.Drawing.Size(450, 50)
        Me.B1.TabIndex = 15
        Me.B1.Text = "I Love Radio"
        Me.B1.UseVisualStyleBackColor = False
        '
        'FavTimer
        '
        Me.FavTimer.Enabled = True
        Me.FavTimer.Interval = 1000
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.TabPage3.Controls.Add(Me.Button1)
        Me.TabPage3.Controls.Add(Me.versionlbl)
        Me.TabPage3.Controls.Add(Me.Label1)
        Me.TabPage3.Location = New System.Drawing.Point(4, 45)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(645, 397)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Über"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Version:"
        '
        'versionlbl
        '
        Me.versionlbl.AutoSize = True
        Me.versionlbl.Location = New System.Drawing.Point(134, 10)
        Me.versionlbl.Name = "versionlbl"
        Me.versionlbl.Size = New System.Drawing.Size(52, 37)
        Me.versionlbl.TabIndex = 1
        Me.versionlbl.Text = "1.0"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Exo", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Button1.Location = New System.Drawing.Point(358, 7)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(279, 44)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Suche nach Updates"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(653, 565)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.AxWindowsMediaPlayer1)
        Me.ForeColor = System.Drawing.SystemColors.Control
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.Text = "I Love Radio"
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.Star7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Star6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Star5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Star4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Star3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Star2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Star1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents AxWindowsMediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents ILR1B As Button
    Friend WithEvents Star4 As PictureBox
    Friend WithEvents Star3 As PictureBox
    Friend WithEvents Star2 As PictureBox
    Friend WithEvents Star1 As PictureBox
    Friend WithEvents ILR4B As Button
    Friend WithEvents ILR3B As Button
    Friend WithEvents ILR2B As Button
    Friend WithEvents ILR7B As Button
    Friend WithEvents Star6 As PictureBox
    Friend WithEvents Star5 As PictureBox
    Friend WithEvents ILR6B As Button
    Friend WithEvents ILR5B As Button
    Friend WithEvents Star7 As PictureBox
    Friend WithEvents B7 As Button
    Friend WithEvents B6 As Button
    Friend WithEvents B5 As Button
    Friend WithEvents B3 As Button
    Friend WithEvents B2 As Button
    Friend WithEvents B1 As Button
    Friend WithEvents FavTimer As Timer
    Friend WithEvents B4 As Button
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Button1 As Button
    Friend WithEvents versionlbl As Label
    Friend WithEvents Label1 As Label
End Class
