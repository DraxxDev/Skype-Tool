<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.timer_spammer = New System.Windows.Forms.Timer(Me.components)
        Me.timer_afk = New System.Windows.Forms.Timer(Me.components)
        Me.timer_status = New System.Windows.Forms.Timer(Me.components)
        Me.FormSkin1 = New SkypeTool.FormSkin()
        Me.FlatAlertBox1 = New SkypeTool.FlatAlertBox()
        Me.FlatTabControl1 = New SkypeTool.FlatTabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.FlatLabel3 = New SkypeTool.FlatLabel()
        Me.rtxtb_changelog = New System.Windows.Forms.RichTextBox()
        Me.AxSkype1 = New AxSKYPE4COMLib.AxSkype()
        Me.btn_connect = New SkypeTool.FlatButton()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.btn_moodcenter = New SkypeTool.FlatButton()
        Me.btn_mooditalic = New SkypeTool.FlatButton()
        Me.btn_moodunderline = New SkypeTool.FlatButton()
        Me.btn_moodbold = New SkypeTool.FlatButton()
        Me.btn_moodblink = New SkypeTool.FlatButton()
        Me.rtxtb_mood = New System.Windows.Forms.RichTextBox()
        Me.btn_changemood = New SkypeTool.FlatButton()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.ftoggle_statusabfuck = New SkypeTool.FlatToggle()
        Me.FlatLabel4 = New SkypeTool.FlatLabel()
        Me.ftoggle_afk = New SkypeTool.FlatToggle()
        Me.FlatGroupBox3 = New SkypeTool.FlatGroupBox()
        Me.rtxtb_afk = New System.Windows.Forms.RichTextBox()
        Me.btn_status = New SkypeTool.FlatButton()
        Me.FlatComboBox1 = New SkypeTool.FlatComboBox()
        Me.btn_changename = New SkypeTool.FlatButton()
        Me.txb_name = New SkypeTool.FlatTextBox()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.FlatGroupBox2 = New SkypeTool.FlatGroupBox()
        Me.FlatTextBox1 = New SkypeTool.FlatTextBox()
        Me.FlatTrackBar1 = New SkypeTool.FlatTrackBar()
        Me.rtxtb_spammer = New System.Windows.Forms.RichTextBox()
        Me.FlatComboBox2 = New SkypeTool.FlatComboBox()
        Me.btn_mstop = New SkypeTool.FlatButton()
        Me.btn_mstart = New SkypeTool.FlatButton()
        Me.FlatGroupBox1 = New SkypeTool.FlatGroupBox()
        Me.btn_msend = New SkypeTool.FlatButton()
        Me.rtxtb_broadcast = New System.Windows.Forms.RichTextBox()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.btn_grabbergeo = New SkypeTool.FlatButton()
        Me.btn_grabspammer = New SkypeTool.FlatButton()
        Me.FlatLabel8 = New SkypeTool.FlatLabel()
        Me.txtb_grabbirthday = New SkypeTool.FlatTextBox()
        Me.FlatLabel7 = New SkypeTool.FlatLabel()
        Me.txtb_grabstatus = New SkypeTool.FlatTextBox()
        Me.FlatLabel6 = New SkypeTool.FlatLabel()
        Me.txtb_grabmood = New SkypeTool.FlatTextBox()
        Me.FlatLabel5 = New SkypeTool.FlatLabel()
        Me.txtb_grabname = New SkypeTool.FlatTextBox()
        Me.FlatLabel2 = New SkypeTool.FlatLabel()
        Me.FlatButton6 = New SkypeTool.FlatButton()
        Me.txb_ip = New SkypeTool.FlatTextBox()
        Me.FlatLabel1 = New SkypeTool.FlatLabel()
        Me.FlatButton5 = New SkypeTool.FlatButton()
        Me.FlatButton4 = New SkypeTool.FlatButton()
        Me.FlatListBox1 = New SkypeTool.FlatListBox()
        Me.pctureb_grabavatar = New System.Windows.Forms.PictureBox()
        Me.FlatMini1 = New SkypeTool.FlatMini()
        Me.FlatClose1 = New SkypeTool.FlatClose()
        Me.FormSkin1.SuspendLayout()
        Me.FlatTabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.AxSkype1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.FlatGroupBox3.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.FlatGroupBox2.SuspendLayout()
        Me.FlatGroupBox1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.pctureb_grabavatar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'timer_spammer
        '
        Me.timer_spammer.Interval = 500
        '
        'timer_status
        '
        Me.timer_status.Interval = 800
        '
        'FormSkin1
        '
        Me.FormSkin1.BackColor = System.Drawing.Color.White
        Me.FormSkin1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.FormSkin1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.FormSkin1.Controls.Add(Me.FlatAlertBox1)
        Me.FormSkin1.Controls.Add(Me.FlatTabControl1)
        Me.FormSkin1.Controls.Add(Me.FlatMini1)
        Me.FormSkin1.Controls.Add(Me.FlatClose1)
        Me.FormSkin1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FormSkin1.FlatColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FormSkin1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FormSkin1.HeaderColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.FormSkin1.HeaderMaximize = False
        Me.FormSkin1.Location = New System.Drawing.Point(0, 0)
        Me.FormSkin1.Name = "FormSkin1"
        Me.FormSkin1.Size = New System.Drawing.Size(806, 413)
        Me.FormSkin1.TabIndex = 0
        Me.FormSkin1.Text = "Skype Tool by Draxx v1.0"
        '
        'FlatAlertBox1
        '
        Me.FlatAlertBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.FlatAlertBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatAlertBox1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatAlertBox1.kind = SkypeTool.FlatAlertBox._Kind.Success
        Me.FlatAlertBox1.Location = New System.Drawing.Point(16, 359)
        Me.FlatAlertBox1.Name = "FlatAlertBox1"
        Me.FlatAlertBox1.Size = New System.Drawing.Size(778, 42)
        Me.FlatAlertBox1.TabIndex = 0
        Me.FlatAlertBox1.Text = "FlatAlertBox1"
        Me.FlatAlertBox1.Visible = False
        '
        'FlatTabControl1
        '
        Me.FlatTabControl1.ActiveColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.FlatTabControl1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FlatTabControl1.Controls.Add(Me.TabPage1)
        Me.FlatTabControl1.Controls.Add(Me.TabPage4)
        Me.FlatTabControl1.Controls.Add(Me.TabPage2)
        Me.FlatTabControl1.Controls.Add(Me.TabPage5)
        Me.FlatTabControl1.Controls.Add(Me.TabPage6)
        Me.FlatTabControl1.Controls.Add(Me.TabPage3)
        Me.FlatTabControl1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatTabControl1.ItemSize = New System.Drawing.Size(120, 40)
        Me.FlatTabControl1.Location = New System.Drawing.Point(12, 53)
        Me.FlatTabControl1.Name = "FlatTabControl1"
        Me.FlatTabControl1.SelectedIndex = 0
        Me.FlatTabControl1.Size = New System.Drawing.Size(782, 300)
        Me.FlatTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.FlatTabControl1.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.FlatLabel3)
        Me.TabPage1.Controls.Add(Me.rtxtb_changelog)
        Me.TabPage1.Controls.Add(Me.AxSkype1)
        Me.TabPage1.Controls.Add(Me.btn_connect)
        Me.TabPage1.Location = New System.Drawing.Point(4, 44)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(774, 252)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Connection"
        '
        'FlatLabel3
        '
        Me.FlatLabel3.AutoSize = True
        Me.FlatLabel3.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel3.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.FlatLabel3.ForeColor = System.Drawing.Color.White
        Me.FlatLabel3.Location = New System.Drawing.Point(633, 3)
        Me.FlatLabel3.Name = "FlatLabel3"
        Me.FlatLabel3.Size = New System.Drawing.Size(104, 25)
        Me.FlatLabel3.TabIndex = 0
        Me.FlatLabel3.Text = "Changelog"
        '
        'rtxtb_changelog
        '
        Me.rtxtb_changelog.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.rtxtb_changelog.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rtxtb_changelog.ForeColor = System.Drawing.Color.White
        Me.rtxtb_changelog.Location = New System.Drawing.Point(598, 31)
        Me.rtxtb_changelog.Name = "rtxtb_changelog"
        Me.rtxtb_changelog.ReadOnly = True
        Me.rtxtb_changelog.Size = New System.Drawing.Size(170, 215)
        Me.rtxtb_changelog.TabIndex = 4
        Me.rtxtb_changelog.Text = ""
        '
        'AxSkype1
        '
        Me.AxSkype1.Enabled = True
        Me.AxSkype1.Location = New System.Drawing.Point(21, 15)
        Me.AxSkype1.Name = "AxSkype1"
        Me.AxSkype1.OcxState = CType(resources.GetObject("AxSkype1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxSkype1.Size = New System.Drawing.Size(192, 192)
        Me.AxSkype1.TabIndex = 3
        '
        'btn_connect
        '
        Me.btn_connect.BackColor = System.Drawing.Color.Transparent
        Me.btn_connect.BaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btn_connect.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_connect.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btn_connect.Location = New System.Drawing.Point(243, 75)
        Me.btn_connect.Name = "btn_connect"
        Me.btn_connect.Rounded = False
        Me.btn_connect.Size = New System.Drawing.Size(286, 93)
        Me.btn_connect.TabIndex = 0
        Me.btn_connect.Text = "Connect to Skype"
        Me.btn_connect.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.TabPage4.Controls.Add(Me.btn_moodcenter)
        Me.TabPage4.Controls.Add(Me.btn_mooditalic)
        Me.TabPage4.Controls.Add(Me.btn_moodunderline)
        Me.TabPage4.Controls.Add(Me.btn_moodbold)
        Me.TabPage4.Controls.Add(Me.btn_moodblink)
        Me.TabPage4.Controls.Add(Me.rtxtb_mood)
        Me.TabPage4.Controls.Add(Me.btn_changemood)
        Me.TabPage4.Location = New System.Drawing.Point(4, 44)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(774, 252)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Mood"
        '
        'btn_moodcenter
        '
        Me.btn_moodcenter.BackColor = System.Drawing.Color.Transparent
        Me.btn_moodcenter.BaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btn_moodcenter.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_moodcenter.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btn_moodcenter.Location = New System.Drawing.Point(455, 176)
        Me.btn_moodcenter.Name = "btn_moodcenter"
        Me.btn_moodcenter.Rounded = False
        Me.btn_moodcenter.Size = New System.Drawing.Size(308, 29)
        Me.btn_moodcenter.TabIndex = 11
        Me.btn_moodcenter.Text = "Center"
        Me.btn_moodcenter.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'btn_mooditalic
        '
        Me.btn_mooditalic.BackColor = System.Drawing.Color.Transparent
        Me.btn_mooditalic.BaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btn_mooditalic.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_mooditalic.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btn_mooditalic.Location = New System.Drawing.Point(455, 117)
        Me.btn_mooditalic.Name = "btn_mooditalic"
        Me.btn_mooditalic.Rounded = False
        Me.btn_mooditalic.Size = New System.Drawing.Size(308, 29)
        Me.btn_mooditalic.TabIndex = 10
        Me.btn_mooditalic.Text = "Italic"
        Me.btn_mooditalic.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'btn_moodunderline
        '
        Me.btn_moodunderline.BackColor = System.Drawing.Color.Transparent
        Me.btn_moodunderline.BaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btn_moodunderline.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_moodunderline.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btn_moodunderline.Location = New System.Drawing.Point(455, 82)
        Me.btn_moodunderline.Name = "btn_moodunderline"
        Me.btn_moodunderline.Rounded = False
        Me.btn_moodunderline.Size = New System.Drawing.Size(308, 29)
        Me.btn_moodunderline.TabIndex = 9
        Me.btn_moodunderline.Text = "Underline"
        Me.btn_moodunderline.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'btn_moodbold
        '
        Me.btn_moodbold.BackColor = System.Drawing.Color.Transparent
        Me.btn_moodbold.BaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btn_moodbold.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_moodbold.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btn_moodbold.Location = New System.Drawing.Point(455, 47)
        Me.btn_moodbold.Name = "btn_moodbold"
        Me.btn_moodbold.Rounded = False
        Me.btn_moodbold.Size = New System.Drawing.Size(308, 29)
        Me.btn_moodbold.TabIndex = 8
        Me.btn_moodbold.Text = "Bold"
        Me.btn_moodbold.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'btn_moodblink
        '
        Me.btn_moodblink.BackColor = System.Drawing.Color.Transparent
        Me.btn_moodblink.BaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btn_moodblink.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_moodblink.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btn_moodblink.Location = New System.Drawing.Point(455, 12)
        Me.btn_moodblink.Name = "btn_moodblink"
        Me.btn_moodblink.Rounded = False
        Me.btn_moodblink.Size = New System.Drawing.Size(308, 29)
        Me.btn_moodblink.TabIndex = 7
        Me.btn_moodblink.Text = "Blink"
        Me.btn_moodblink.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'rtxtb_mood
        '
        Me.rtxtb_mood.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.rtxtb_mood.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.rtxtb_mood.Location = New System.Drawing.Point(14, 12)
        Me.rtxtb_mood.Name = "rtxtb_mood"
        Me.rtxtb_mood.Size = New System.Drawing.Size(435, 228)
        Me.rtxtb_mood.TabIndex = 6
        Me.rtxtb_mood.Text = ""
        '
        'btn_changemood
        '
        Me.btn_changemood.BackColor = System.Drawing.Color.Transparent
        Me.btn_changemood.BaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btn_changemood.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_changemood.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btn_changemood.Location = New System.Drawing.Point(455, 211)
        Me.btn_changemood.Name = "btn_changemood"
        Me.btn_changemood.Rounded = False
        Me.btn_changemood.Size = New System.Drawing.Size(308, 29)
        Me.btn_changemood.TabIndex = 5
        Me.btn_changemood.Text = "Change Mood"
        Me.btn_changemood.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.TabPage2.Controls.Add(Me.ftoggle_statusabfuck)
        Me.TabPage2.Controls.Add(Me.FlatLabel4)
        Me.TabPage2.Controls.Add(Me.ftoggle_afk)
        Me.TabPage2.Controls.Add(Me.FlatGroupBox3)
        Me.TabPage2.Controls.Add(Me.btn_status)
        Me.TabPage2.Controls.Add(Me.FlatComboBox1)
        Me.TabPage2.Controls.Add(Me.btn_changename)
        Me.TabPage2.Controls.Add(Me.txb_name)
        Me.TabPage2.Location = New System.Drawing.Point(4, 44)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(774, 252)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Profile"
        '
        'ftoggle_statusabfuck
        '
        Me.ftoggle_statusabfuck.BackColor = System.Drawing.Color.Transparent
        Me.ftoggle_statusabfuck.Checked = False
        Me.ftoggle_statusabfuck.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ftoggle_statusabfuck.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.ftoggle_statusabfuck.Location = New System.Drawing.Point(474, 36)
        Me.ftoggle_statusabfuck.Name = "ftoggle_statusabfuck"
        Me.ftoggle_statusabfuck.Options = SkypeTool.FlatToggle._Options.Style1
        Me.ftoggle_statusabfuck.Size = New System.Drawing.Size(76, 33)
        Me.ftoggle_statusabfuck.TabIndex = 6
        '
        'FlatLabel4
        '
        Me.FlatLabel4.AutoSize = True
        Me.FlatLabel4.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel4.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatLabel4.ForeColor = System.Drawing.Color.White
        Me.FlatLabel4.Location = New System.Drawing.Point(460, 10)
        Me.FlatLabel4.Name = "FlatLabel4"
        Me.FlatLabel4.Size = New System.Drawing.Size(105, 19)
        Me.FlatLabel4.TabIndex = 5
        Me.FlatLabel4.Text = "Status Abfucker"
        '
        'ftoggle_afk
        '
        Me.ftoggle_afk.BackColor = System.Drawing.Color.Transparent
        Me.ftoggle_afk.Checked = False
        Me.ftoggle_afk.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ftoggle_afk.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.ftoggle_afk.Location = New System.Drawing.Point(14, 41)
        Me.ftoggle_afk.Name = "ftoggle_afk"
        Me.ftoggle_afk.Options = SkypeTool.FlatToggle._Options.Style1
        Me.ftoggle_afk.Size = New System.Drawing.Size(76, 33)
        Me.ftoggle_afk.TabIndex = 0
        '
        'FlatGroupBox3
        '
        Me.FlatGroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.FlatGroupBox3.BaseColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.FlatGroupBox3.Controls.Add(Me.rtxtb_afk)
        Me.FlatGroupBox3.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatGroupBox3.Location = New System.Drawing.Point(6, 71)
        Me.FlatGroupBox3.Name = "FlatGroupBox3"
        Me.FlatGroupBox3.ShowText = True
        Me.FlatGroupBox3.Size = New System.Drawing.Size(762, 175)
        Me.FlatGroupBox3.TabIndex = 4
        Me.FlatGroupBox3.Text = "AFK Bot"
        '
        'rtxtb_afk
        '
        Me.rtxtb_afk.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.rtxtb_afk.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rtxtb_afk.Location = New System.Drawing.Point(18, 38)
        Me.rtxtb_afk.Name = "rtxtb_afk"
        Me.rtxtb_afk.Size = New System.Drawing.Size(725, 120)
        Me.rtxtb_afk.TabIndex = 2
        Me.rtxtb_afk.Text = ""
        '
        'btn_status
        '
        Me.btn_status.BackColor = System.Drawing.Color.Transparent
        Me.btn_status.BaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btn_status.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_status.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btn_status.Location = New System.Drawing.Point(571, 6)
        Me.btn_status.Name = "btn_status"
        Me.btn_status.Rounded = False
        Me.btn_status.Size = New System.Drawing.Size(187, 29)
        Me.btn_status.TabIndex = 3
        Me.btn_status.Text = "Change Online status"
        Me.btn_status.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatComboBox1
        '
        Me.FlatComboBox1.AutoCompleteCustomSource.AddRange(New String() {"Online", "Away", "", "Offline"})
        Me.FlatComboBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.FlatComboBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.FlatComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.FlatComboBox1.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.FlatComboBox1.ForeColor = System.Drawing.Color.White
        Me.FlatComboBox1.FormattingEnabled = True
        Me.FlatComboBox1.HoverColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.FlatComboBox1.ItemHeight = 18
        Me.FlatComboBox1.Items.AddRange(New Object() {"Online", "Away", "NotAvailable", "Invisible", "Offline"})
        Me.FlatComboBox1.Location = New System.Drawing.Point(571, 41)
        Me.FlatComboBox1.Name = "FlatComboBox1"
        Me.FlatComboBox1.Size = New System.Drawing.Size(187, 24)
        Me.FlatComboBox1.TabIndex = 2
        '
        'btn_changename
        '
        Me.btn_changename.BackColor = System.Drawing.Color.Transparent
        Me.btn_changename.BaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btn_changename.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_changename.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btn_changename.Location = New System.Drawing.Point(255, 6)
        Me.btn_changename.Name = "btn_changename"
        Me.btn_changename.Rounded = False
        Me.btn_changename.Size = New System.Drawing.Size(106, 29)
        Me.btn_changename.TabIndex = 1
        Me.btn_changename.Text = "Change Name"
        Me.btn_changename.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'txb_name
        '
        Me.txb_name.BackColor = System.Drawing.Color.Transparent
        Me.txb_name.Location = New System.Drawing.Point(14, 6)
        Me.txb_name.MaxLength = 32767
        Me.txb_name.Multiline = False
        Me.txb_name.Name = "txb_name"
        Me.txb_name.ReadOnly = False
        Me.txb_name.Size = New System.Drawing.Size(235, 29)
        Me.txb_name.TabIndex = 0
        Me.txb_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txb_name.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txb_name.UseSystemPasswordChar = False
        '
        'TabPage5
        '
        Me.TabPage5.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.TabPage5.Controls.Add(Me.FlatGroupBox2)
        Me.TabPage5.Controls.Add(Me.FlatGroupBox1)
        Me.TabPage5.Location = New System.Drawing.Point(4, 44)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(774, 252)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Message"
        '
        'FlatGroupBox2
        '
        Me.FlatGroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.FlatGroupBox2.BaseColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.FlatGroupBox2.Controls.Add(Me.FlatTextBox1)
        Me.FlatGroupBox2.Controls.Add(Me.FlatTrackBar1)
        Me.FlatGroupBox2.Controls.Add(Me.rtxtb_spammer)
        Me.FlatGroupBox2.Controls.Add(Me.FlatComboBox2)
        Me.FlatGroupBox2.Controls.Add(Me.btn_mstop)
        Me.FlatGroupBox2.Controls.Add(Me.btn_mstart)
        Me.FlatGroupBox2.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatGroupBox2.Location = New System.Drawing.Point(404, 17)
        Me.FlatGroupBox2.Name = "FlatGroupBox2"
        Me.FlatGroupBox2.ShowText = True
        Me.FlatGroupBox2.Size = New System.Drawing.Size(359, 218)
        Me.FlatGroupBox2.TabIndex = 2
        Me.FlatGroupBox2.Text = "Spammer"
        '
        'FlatTextBox1
        '
        Me.FlatTextBox1.BackColor = System.Drawing.Color.Transparent
        Me.FlatTextBox1.Location = New System.Drawing.Point(126, 164)
        Me.FlatTextBox1.MaxLength = 32767
        Me.FlatTextBox1.Multiline = False
        Me.FlatTextBox1.Name = "FlatTextBox1"
        Me.FlatTextBox1.ReadOnly = True
        Me.FlatTextBox1.Size = New System.Drawing.Size(97, 29)
        Me.FlatTextBox1.TabIndex = 5
        Me.FlatTextBox1.Text = "0"
        Me.FlatTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.FlatTextBox1.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.FlatTextBox1.UseSystemPasswordChar = False
        '
        'FlatTrackBar1
        '
        Me.FlatTrackBar1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.FlatTrackBar1.HatchColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.FlatTrackBar1.Location = New System.Drawing.Point(14, 134)
        Me.FlatTrackBar1.Maximum = 1000
        Me.FlatTrackBar1.Minimum = 0
        Me.FlatTrackBar1.Name = "FlatTrackBar1"
        Me.FlatTrackBar1.ShowValue = False
        Me.FlatTrackBar1.Size = New System.Drawing.Size(330, 23)
        Me.FlatTrackBar1.Style = SkypeTool.FlatTrackBar._Style.Slider
        Me.FlatTrackBar1.TabIndex = 4
        Me.FlatTrackBar1.Text = "FlatTrackBar1"
        Me.FlatTrackBar1.TrackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.FlatTrackBar1.Value = 500
        '
        'rtxtb_spammer
        '
        Me.rtxtb_spammer.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.rtxtb_spammer.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rtxtb_spammer.Location = New System.Drawing.Point(14, 67)
        Me.rtxtb_spammer.Name = "rtxtb_spammer"
        Me.rtxtb_spammer.Size = New System.Drawing.Size(330, 61)
        Me.rtxtb_spammer.TabIndex = 3
        Me.rtxtb_spammer.Text = ""
        '
        'FlatComboBox2
        '
        Me.FlatComboBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.FlatComboBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatComboBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.FlatComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.FlatComboBox2.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.FlatComboBox2.ForeColor = System.Drawing.Color.White
        Me.FlatComboBox2.FormattingEnabled = True
        Me.FlatComboBox2.HoverColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.FlatComboBox2.ItemHeight = 18
        Me.FlatComboBox2.Location = New System.Drawing.Point(14, 37)
        Me.FlatComboBox2.Name = "FlatComboBox2"
        Me.FlatComboBox2.Size = New System.Drawing.Size(330, 24)
        Me.FlatComboBox2.TabIndex = 1
        '
        'btn_mstop
        '
        Me.btn_mstop.BackColor = System.Drawing.Color.Transparent
        Me.btn_mstop.BaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btn_mstop.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_mstop.Enabled = False
        Me.btn_mstop.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btn_mstop.Location = New System.Drawing.Point(229, 163)
        Me.btn_mstop.Name = "btn_mstop"
        Me.btn_mstop.Rounded = False
        Me.btn_mstop.Size = New System.Drawing.Size(106, 32)
        Me.btn_mstop.TabIndex = 2
        Me.btn_mstop.Text = "Stop"
        Me.btn_mstop.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'btn_mstart
        '
        Me.btn_mstart.BackColor = System.Drawing.Color.Transparent
        Me.btn_mstart.BaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btn_mstart.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_mstart.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btn_mstart.Location = New System.Drawing.Point(14, 163)
        Me.btn_mstart.Name = "btn_mstart"
        Me.btn_mstart.Rounded = False
        Me.btn_mstart.Size = New System.Drawing.Size(106, 32)
        Me.btn_mstart.TabIndex = 1
        Me.btn_mstart.Text = "Start"
        Me.btn_mstart.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatGroupBox1
        '
        Me.FlatGroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.FlatGroupBox1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.FlatGroupBox1.Controls.Add(Me.btn_msend)
        Me.FlatGroupBox1.Controls.Add(Me.rtxtb_broadcast)
        Me.FlatGroupBox1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatGroupBox1.Location = New System.Drawing.Point(12, 14)
        Me.FlatGroupBox1.Name = "FlatGroupBox1"
        Me.FlatGroupBox1.ShowText = True
        Me.FlatGroupBox1.Size = New System.Drawing.Size(386, 221)
        Me.FlatGroupBox1.TabIndex = 0
        Me.FlatGroupBox1.Text = "Broadcast"
        '
        'btn_msend
        '
        Me.btn_msend.BackColor = System.Drawing.Color.Transparent
        Me.btn_msend.BaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btn_msend.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_msend.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btn_msend.Location = New System.Drawing.Point(19, 166)
        Me.btn_msend.Name = "btn_msend"
        Me.btn_msend.Rounded = False
        Me.btn_msend.Size = New System.Drawing.Size(341, 32)
        Me.btn_msend.TabIndex = 1
        Me.btn_msend.Text = "Send"
        Me.btn_msend.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'rtxtb_broadcast
        '
        Me.rtxtb_broadcast.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.rtxtb_broadcast.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rtxtb_broadcast.Location = New System.Drawing.Point(19, 40)
        Me.rtxtb_broadcast.Name = "rtxtb_broadcast"
        Me.rtxtb_broadcast.Size = New System.Drawing.Size(341, 120)
        Me.rtxtb_broadcast.TabIndex = 1
        Me.rtxtb_broadcast.Text = ""
        '
        'TabPage6
        '
        Me.TabPage6.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.TabPage6.Location = New System.Drawing.Point(4, 44)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage6.Size = New System.Drawing.Size(774, 252)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "CallBack"
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.TabPage3.Controls.Add(Me.btn_grabbergeo)
        Me.TabPage3.Controls.Add(Me.btn_grabspammer)
        Me.TabPage3.Controls.Add(Me.FlatLabel8)
        Me.TabPage3.Controls.Add(Me.txtb_grabbirthday)
        Me.TabPage3.Controls.Add(Me.FlatLabel7)
        Me.TabPage3.Controls.Add(Me.txtb_grabstatus)
        Me.TabPage3.Controls.Add(Me.FlatLabel6)
        Me.TabPage3.Controls.Add(Me.txtb_grabmood)
        Me.TabPage3.Controls.Add(Me.FlatLabel5)
        Me.TabPage3.Controls.Add(Me.txtb_grabname)
        Me.TabPage3.Controls.Add(Me.FlatLabel2)
        Me.TabPage3.Controls.Add(Me.FlatButton6)
        Me.TabPage3.Controls.Add(Me.txb_ip)
        Me.TabPage3.Controls.Add(Me.FlatLabel1)
        Me.TabPage3.Controls.Add(Me.FlatButton5)
        Me.TabPage3.Controls.Add(Me.FlatButton4)
        Me.TabPage3.Controls.Add(Me.FlatListBox1)
        Me.TabPage3.Controls.Add(Me.pctureb_grabavatar)
        Me.TabPage3.Location = New System.Drawing.Point(4, 44)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(774, 252)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Grabber"
        '
        'btn_grabbergeo
        '
        Me.btn_grabbergeo.BackColor = System.Drawing.Color.Transparent
        Me.btn_grabbergeo.BaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btn_grabbergeo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_grabbergeo.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btn_grabbergeo.Location = New System.Drawing.Point(584, 205)
        Me.btn_grabbergeo.Name = "btn_grabbergeo"
        Me.btn_grabbergeo.Rounded = False
        Me.btn_grabbergeo.Size = New System.Drawing.Size(179, 32)
        Me.btn_grabbergeo.TabIndex = 17
        Me.btn_grabbergeo.Text = "GeoLocate"
        Me.btn_grabbergeo.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'btn_grabspammer
        '
        Me.btn_grabspammer.BackColor = System.Drawing.Color.Transparent
        Me.btn_grabspammer.BaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btn_grabspammer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_grabspammer.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btn_grabspammer.Location = New System.Drawing.Point(584, 167)
        Me.btn_grabspammer.Name = "btn_grabspammer"
        Me.btn_grabspammer.Rounded = False
        Me.btn_grabspammer.Size = New System.Drawing.Size(179, 32)
        Me.btn_grabspammer.TabIndex = 16
        Me.btn_grabspammer.Text = "Spammer"
        Me.btn_grabspammer.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatLabel8
        '
        Me.FlatLabel8.AutoSize = True
        Me.FlatLabel8.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel8.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatLabel8.ForeColor = System.Drawing.Color.White
        Me.FlatLabel8.Location = New System.Drawing.Point(271, 184)
        Me.FlatLabel8.Name = "FlatLabel8"
        Me.FlatLabel8.Size = New System.Drawing.Size(81, 19)
        Me.FlatLabel8.TabIndex = 15
        Me.FlatLabel8.Text = "Geburtstag:"
        '
        'txtb_grabbirthday
        '
        Me.txtb_grabbirthday.BackColor = System.Drawing.Color.Transparent
        Me.txtb_grabbirthday.Location = New System.Drawing.Point(357, 180)
        Me.txtb_grabbirthday.MaxLength = 32767
        Me.txtb_grabbirthday.Multiline = False
        Me.txtb_grabbirthday.Name = "txtb_grabbirthday"
        Me.txtb_grabbirthday.ReadOnly = True
        Me.txtb_grabbirthday.Size = New System.Drawing.Size(197, 29)
        Me.txtb_grabbirthday.TabIndex = 14
        Me.txtb_grabbirthday.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtb_grabbirthday.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtb_grabbirthday.UseSystemPasswordChar = False
        '
        'FlatLabel7
        '
        Me.FlatLabel7.AutoSize = True
        Me.FlatLabel7.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel7.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatLabel7.ForeColor = System.Drawing.Color.White
        Me.FlatLabel7.Location = New System.Drawing.Point(255, 149)
        Me.FlatLabel7.Name = "FlatLabel7"
        Me.FlatLabel7.Size = New System.Drawing.Size(96, 19)
        Me.FlatLabel7.TabIndex = 13
        Me.FlatLabel7.Text = "Online-Status:"
        '
        'txtb_grabstatus
        '
        Me.txtb_grabstatus.BackColor = System.Drawing.Color.Transparent
        Me.txtb_grabstatus.Location = New System.Drawing.Point(357, 145)
        Me.txtb_grabstatus.MaxLength = 32767
        Me.txtb_grabstatus.Multiline = False
        Me.txtb_grabstatus.Name = "txtb_grabstatus"
        Me.txtb_grabstatus.ReadOnly = True
        Me.txtb_grabstatus.Size = New System.Drawing.Size(197, 29)
        Me.txtb_grabstatus.TabIndex = 12
        Me.txtb_grabstatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtb_grabstatus.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtb_grabstatus.UseSystemPasswordChar = False
        '
        'FlatLabel6
        '
        Me.FlatLabel6.AutoSize = True
        Me.FlatLabel6.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel6.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatLabel6.ForeColor = System.Drawing.Color.White
        Me.FlatLabel6.Location = New System.Drawing.Point(303, 114)
        Me.FlatLabel6.Name = "FlatLabel6"
        Me.FlatLabel6.Size = New System.Drawing.Size(49, 19)
        Me.FlatLabel6.TabIndex = 11
        Me.FlatLabel6.Text = "Mood:"
        '
        'txtb_grabmood
        '
        Me.txtb_grabmood.BackColor = System.Drawing.Color.Transparent
        Me.txtb_grabmood.Location = New System.Drawing.Point(357, 110)
        Me.txtb_grabmood.MaxLength = 32767
        Me.txtb_grabmood.Multiline = False
        Me.txtb_grabmood.Name = "txtb_grabmood"
        Me.txtb_grabmood.ReadOnly = True
        Me.txtb_grabmood.Size = New System.Drawing.Size(197, 29)
        Me.txtb_grabmood.TabIndex = 10
        Me.txtb_grabmood.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtb_grabmood.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtb_grabmood.UseSystemPasswordChar = False
        '
        'FlatLabel5
        '
        Me.FlatLabel5.AutoSize = True
        Me.FlatLabel5.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel5.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatLabel5.ForeColor = System.Drawing.Color.White
        Me.FlatLabel5.Location = New System.Drawing.Point(303, 76)
        Me.FlatLabel5.Name = "FlatLabel5"
        Me.FlatLabel5.Size = New System.Drawing.Size(48, 19)
        Me.FlatLabel5.TabIndex = 9
        Me.FlatLabel5.Text = "Name:"
        '
        'txtb_grabname
        '
        Me.txtb_grabname.BackColor = System.Drawing.Color.Transparent
        Me.txtb_grabname.Location = New System.Drawing.Point(357, 72)
        Me.txtb_grabname.MaxLength = 32767
        Me.txtb_grabname.Multiline = False
        Me.txtb_grabname.Name = "txtb_grabname"
        Me.txtb_grabname.ReadOnly = True
        Me.txtb_grabname.Size = New System.Drawing.Size(197, 29)
        Me.txtb_grabname.TabIndex = 8
        Me.txtb_grabname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtb_grabname.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtb_grabname.UseSystemPasswordChar = False
        '
        'FlatLabel2
        '
        Me.FlatLabel2.AutoSize = True
        Me.FlatLabel2.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel2.ForeColor = System.Drawing.Color.White
        Me.FlatLabel2.Location = New System.Drawing.Point(633, 48)
        Me.FlatLabel2.Name = "FlatLabel2"
        Me.FlatLabel2.Size = New System.Drawing.Size(74, 21)
        Me.FlatLabel2.TabIndex = 7
        Me.FlatLabel2.Text = "IP Adress"
        '
        'FlatButton6
        '
        Me.FlatButton6.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton6.BaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.FlatButton6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton6.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatButton6.Location = New System.Drawing.Point(584, 107)
        Me.FlatButton6.Name = "FlatButton6"
        Me.FlatButton6.Rounded = False
        Me.FlatButton6.Size = New System.Drawing.Size(178, 32)
        Me.FlatButton6.TabIndex = 6
        Me.FlatButton6.Text = "Copy IP Adress"
        Me.FlatButton6.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'txb_ip
        '
        Me.txb_ip.BackColor = System.Drawing.Color.Transparent
        Me.txb_ip.Location = New System.Drawing.Point(584, 72)
        Me.txb_ip.MaxLength = 32767
        Me.txb_ip.Multiline = False
        Me.txb_ip.Name = "txb_ip"
        Me.txb_ip.ReadOnly = True
        Me.txb_ip.Size = New System.Drawing.Size(178, 29)
        Me.txb_ip.TabIndex = 5
        Me.txb_ip.Text = "Disabeld"
        Me.txb_ip.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txb_ip.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txb_ip.UseSystemPasswordChar = False
        '
        'FlatLabel1
        '
        Me.FlatLabel1.AutoSize = True
        Me.FlatLabel1.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel1.ForeColor = System.Drawing.Color.White
        Me.FlatLabel1.Location = New System.Drawing.Point(170, 48)
        Me.FlatLabel1.Name = "FlatLabel1"
        Me.FlatLabel1.Size = New System.Drawing.Size(55, 21)
        Me.FlatLabel1.TabIndex = 4
        Me.FlatLabel1.Text = "Avatar"
        '
        'FlatButton5
        '
        Me.FlatButton5.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton5.BaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.FlatButton5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton5.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatButton5.Location = New System.Drawing.Point(148, 174)
        Me.FlatButton5.Name = "FlatButton5"
        Me.FlatButton5.Rounded = False
        Me.FlatButton5.Size = New System.Drawing.Size(96, 32)
        Me.FlatButton5.TabIndex = 3
        Me.FlatButton5.Text = "Save Avatar"
        Me.FlatButton5.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatButton4
        '
        Me.FlatButton4.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton4.BaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.FlatButton4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton4.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatButton4.Location = New System.Drawing.Point(149, 13)
        Me.FlatButton4.Name = "FlatButton4"
        Me.FlatButton4.Rounded = False
        Me.FlatButton4.Size = New System.Drawing.Size(614, 32)
        Me.FlatButton4.TabIndex = 2
        Me.FlatButton4.Text = "Grab"
        Me.FlatButton4.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatListBox1
        '
        Me.FlatListBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.FlatListBox1.items = New String() {""}
        Me.FlatListBox1.Location = New System.Drawing.Point(12, 13)
        Me.FlatListBox1.Name = "FlatListBox1"
        Me.FlatListBox1.SelectedColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.FlatListBox1.Size = New System.Drawing.Size(131, 224)
        Me.FlatListBox1.TabIndex = 1
        Me.FlatListBox1.Text = "flistb_grabuser"
        '
        'pctureb_grabavatar
        '
        Me.pctureb_grabavatar.Location = New System.Drawing.Point(148, 72)
        Me.pctureb_grabavatar.Name = "pctureb_grabavatar"
        Me.pctureb_grabavatar.Size = New System.Drawing.Size(96, 96)
        Me.pctureb_grabavatar.TabIndex = 0
        Me.pctureb_grabavatar.TabStop = False
        '
        'FlatMini1
        '
        Me.FlatMini1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlatMini1.BackColor = System.Drawing.Color.White
        Me.FlatMini1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.FlatMini1.Font = New System.Drawing.Font("Marlett", 12.0!)
        Me.FlatMini1.Location = New System.Drawing.Point(761, 3)
        Me.FlatMini1.Name = "FlatMini1"
        Me.FlatMini1.Size = New System.Drawing.Size(18, 18)
        Me.FlatMini1.TabIndex = 1
        Me.FlatMini1.Text = "FlatMini1"
        Me.FlatMini1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatClose1
        '
        Me.FlatClose1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlatClose1.BackColor = System.Drawing.Color.White
        Me.FlatClose1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.FlatClose1.Font = New System.Drawing.Font("Marlett", 12.0!)
        Me.FlatClose1.Location = New System.Drawing.Point(785, 3)
        Me.FlatClose1.Name = "FlatClose1"
        Me.FlatClose1.Size = New System.Drawing.Size(18, 18)
        Me.FlatClose1.TabIndex = 0
        Me.FlatClose1.Text = "FlatClose1"
        Me.FlatClose1.TextColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(806, 413)
        Me.Controls.Add(Me.FormSkin1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.FormSkin1.ResumeLayout(False)
        Me.FlatTabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.AxSkype1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.FlatGroupBox3.ResumeLayout(False)
        Me.TabPage5.ResumeLayout(False)
        Me.FlatGroupBox2.ResumeLayout(False)
        Me.FlatGroupBox1.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.pctureb_grabavatar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FormSkin1 As SkypeTool.FormSkin
    Friend WithEvents FlatMini1 As SkypeTool.FlatMini
    Friend WithEvents FlatClose1 As SkypeTool.FlatClose
    Friend WithEvents FlatAlertBox1 As SkypeTool.FlatAlertBox
    Friend WithEvents FlatTabControl1 As SkypeTool.FlatTabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents btn_connect As SkypeTool.FlatButton
    Friend WithEvents AxSkype1 As AxSKYPE4COMLib.AxSkype
    Friend WithEvents btn_changename As SkypeTool.FlatButton
    Friend WithEvents txb_name As SkypeTool.FlatTextBox
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents pctureb_grabavatar As System.Windows.Forms.PictureBox
    Friend WithEvents FlatListBox1 As SkypeTool.FlatListBox
    Friend WithEvents FlatButton4 As SkypeTool.FlatButton
    Friend WithEvents FlatButton5 As SkypeTool.FlatButton
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents FlatLabel1 As SkypeTool.FlatLabel
    Friend WithEvents FlatButton6 As SkypeTool.FlatButton
    Friend WithEvents txb_ip As SkypeTool.FlatTextBox
    Friend WithEvents FlatLabel2 As SkypeTool.FlatLabel
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents btn_changemood As SkypeTool.FlatButton
    Friend WithEvents rtxtb_mood As System.Windows.Forms.RichTextBox
    Friend WithEvents btn_moodblink As SkypeTool.FlatButton
    Friend WithEvents btn_moodbold As SkypeTool.FlatButton
    Friend WithEvents btn_moodunderline As SkypeTool.FlatButton
    Friend WithEvents btn_mooditalic As SkypeTool.FlatButton
    Friend WithEvents btn_moodcenter As SkypeTool.FlatButton
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents FlatGroupBox1 As SkypeTool.FlatGroupBox
    Friend WithEvents btn_msend As SkypeTool.FlatButton
    Friend WithEvents rtxtb_broadcast As System.Windows.Forms.RichTextBox
    Friend WithEvents btn_status As SkypeTool.FlatButton
    Friend WithEvents FlatComboBox1 As SkypeTool.FlatComboBox
    Friend WithEvents FlatGroupBox2 As SkypeTool.FlatGroupBox
    Friend WithEvents btn_mstop As SkypeTool.FlatButton
    Friend WithEvents btn_mstart As SkypeTool.FlatButton
    Friend WithEvents timer_spammer As System.Windows.Forms.Timer
    Friend WithEvents FlatComboBox2 As SkypeTool.FlatComboBox
    Friend WithEvents rtxtb_spammer As System.Windows.Forms.RichTextBox
    Friend WithEvents FlatTrackBar1 As SkypeTool.FlatTrackBar
    Friend WithEvents FlatTextBox1 As SkypeTool.FlatTextBox
    Friend WithEvents TabPage6 As TabPage
    Friend WithEvents FlatLabel3 As FlatLabel
    Friend WithEvents rtxtb_changelog As RichTextBox
    Friend WithEvents FlatGroupBox3 As FlatGroupBox
    Friend WithEvents ftoggle_afk As FlatToggle
    Friend WithEvents timer_afk As Timer
    Friend WithEvents ftoggle_statusabfuck As FlatToggle
    Friend WithEvents FlatLabel4 As FlatLabel
    Friend WithEvents timer_status As Timer
    Friend WithEvents rtxtb_afk As RichTextBox
    Friend WithEvents FlatLabel7 As FlatLabel
    Friend WithEvents txtb_grabstatus As FlatTextBox
    Friend WithEvents FlatLabel6 As FlatLabel
    Friend WithEvents txtb_grabmood As FlatTextBox
    Friend WithEvents FlatLabel5 As FlatLabel
    Friend WithEvents txtb_grabname As FlatTextBox
    Friend WithEvents FlatLabel8 As FlatLabel
    Friend WithEvents txtb_grabbirthday As FlatTextBox
    Friend WithEvents btn_grabspammer As FlatButton
    Friend WithEvents btn_grabbergeo As FlatButton
End Class
