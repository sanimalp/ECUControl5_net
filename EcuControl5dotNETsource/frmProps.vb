Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Friend Class frmProps
	Inherits System.Windows.Forms.Form
#Region "Windows Form Designer generated code "
	Public Sub New()
		MyBase.New()
		If m_vb6FormDefInstance Is Nothing Then
			If m_InitializingDefInstance Then
				m_vb6FormDefInstance = Me
			Else
				Try 
					'For the start-up form, the first instance created is the default instance.
					If System.Reflection.Assembly.GetExecutingAssembly.EntryPoint.DeclaringType Is Me.GetType Then
						m_vb6FormDefInstance = Me
					End If
				Catch
				End Try
			End If
		End If
		'This call is required by the Windows Form Designer.
		InitializeComponent()
	End Sub
	'Form overrides dispose to clean up the component list.
	Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
		If Disposing Then
			If Not components Is Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(Disposing)
	End Sub
	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer
	Public ToolTip1 As System.Windows.Forms.ToolTip
	Public WithEvents txtPoll As System.Windows.Forms.TextBox
	Public WithEvents Label6 As System.Windows.Forms.Label
	Public WithEvents Frame2 As System.Windows.Forms.GroupBox
	Public WithEvents cmdCancel As System.Windows.Forms.Button
	Public WithEvents cboPort As System.Windows.Forms.ComboBox
	Public WithEvents cboSpeed As System.Windows.Forms.ComboBox
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents cboStopBits As System.Windows.Forms.ComboBox
	Public WithEvents cboParity As System.Windows.Forms.ComboBox
	Public WithEvents cboDataBits As System.Windows.Forms.ComboBox
	Public WithEvents Label5 As System.Windows.Forms.Label
	Public WithEvents Label4 As System.Windows.Forms.Label
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents fraConnection As System.Windows.Forms.GroupBox
	Public WithEvents cmdOK As System.Windows.Forms.Button
	Public WithEvents _optEcho_0 As System.Windows.Forms.RadioButton
	Public WithEvents _optEcho_1 As System.Windows.Forms.RadioButton
	Public WithEvents Frame7 As System.Windows.Forms.GroupBox
	Public WithEvents _optFlow_0 As System.Windows.Forms.RadioButton
	Public WithEvents _optFlow_1 As System.Windows.Forms.RadioButton
	Public WithEvents _optFlow_2 As System.Windows.Forms.RadioButton
	Public WithEvents _optFlow_3 As System.Windows.Forms.RadioButton
	Public WithEvents Frame5 As System.Windows.Forms.GroupBox
	Public WithEvents fraSettings As System.Windows.Forms.Panel
	Public WithEvents tabSettings As AxMSComctlLib.AxTabStrip
	Public WithEvents optEcho As Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray
	Public WithEvents optFlow As Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmProps))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.ToolTip1.Active = True
		Me.fraSettings = New System.Windows.Forms.Panel
		Me.Frame2 = New System.Windows.Forms.GroupBox
		Me.txtPoll = New System.Windows.Forms.TextBox
		Me.Label6 = New System.Windows.Forms.Label
		Me.cmdCancel = New System.Windows.Forms.Button
		Me.Frame1 = New System.Windows.Forms.GroupBox
		Me.cboPort = New System.Windows.Forms.ComboBox
		Me.cboSpeed = New System.Windows.Forms.ComboBox
		Me.Label2 = New System.Windows.Forms.Label
		Me.Label1 = New System.Windows.Forms.Label
		Me.fraConnection = New System.Windows.Forms.GroupBox
		Me.cboStopBits = New System.Windows.Forms.ComboBox
		Me.cboParity = New System.Windows.Forms.ComboBox
		Me.cboDataBits = New System.Windows.Forms.ComboBox
		Me.Label5 = New System.Windows.Forms.Label
		Me.Label4 = New System.Windows.Forms.Label
		Me.Label3 = New System.Windows.Forms.Label
		Me.cmdOK = New System.Windows.Forms.Button
		Me.Frame7 = New System.Windows.Forms.GroupBox
		Me._optEcho_0 = New System.Windows.Forms.RadioButton
		Me._optEcho_1 = New System.Windows.Forms.RadioButton
		Me.Frame5 = New System.Windows.Forms.GroupBox
		Me._optFlow_0 = New System.Windows.Forms.RadioButton
		Me._optFlow_1 = New System.Windows.Forms.RadioButton
		Me._optFlow_2 = New System.Windows.Forms.RadioButton
		Me._optFlow_3 = New System.Windows.Forms.RadioButton
		Me.tabSettings = New AxMSComctlLib.AxTabStrip
		Me.optEcho = New Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray(components)
		Me.optFlow = New Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray(components)
		CType(Me.tabSettings, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.optEcho, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.optFlow, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.Text = "Com Port Properties"
		Me.ClientSize = New System.Drawing.Size(426, 279)
		Me.Location = New System.Drawing.Point(139, 137)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.ShowInTaskbar = False
		Me.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
		Me.BackColor = System.Drawing.SystemColors.Control
		Me.ControlBox = True
		Me.Enabled = True
		Me.KeyPreview = False
		Me.Cursor = System.Windows.Forms.Cursors.Default
		Me.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.HelpButton = False
		Me.WindowState = System.Windows.Forms.FormWindowState.Normal
		Me.Name = "frmProps"
		Me.fraSettings.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.fraSettings.Size = New System.Drawing.Size(399, 233)
		Me.fraSettings.Location = New System.Drawing.Point(17, 32)
		Me.fraSettings.TabIndex = 1
		Me.fraSettings.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.fraSettings.BackColor = System.Drawing.SystemColors.Control
		Me.fraSettings.Enabled = True
		Me.fraSettings.ForeColor = System.Drawing.SystemColors.ControlText
		Me.fraSettings.Cursor = System.Windows.Forms.Cursors.Default
		Me.fraSettings.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.fraSettings.Visible = True
		Me.fraSettings.Name = "fraSettings"
		Me.Frame2.Text = "Poll Interval"
		Me.Frame2.Size = New System.Drawing.Size(113, 81)
		Me.Frame2.Location = New System.Drawing.Point(192, 24)
		Me.Frame2.TabIndex = 24
		Me.Frame2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame2.BackColor = System.Drawing.SystemColors.Control
		Me.Frame2.Enabled = True
		Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame2.Visible = True
		Me.Frame2.Name = "Frame2"
		Me.txtPoll.AutoSize = False
		Me.txtPoll.Size = New System.Drawing.Size(41, 19)
		Me.txtPoll.Location = New System.Drawing.Point(8, 24)
		Me.txtPoll.TabIndex = 25
		Me.txtPoll.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtPoll.AcceptsReturn = True
		Me.txtPoll.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtPoll.BackColor = System.Drawing.SystemColors.Window
		Me.txtPoll.CausesValidation = True
		Me.txtPoll.Enabled = True
		Me.txtPoll.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtPoll.HideSelection = True
		Me.txtPoll.ReadOnly = False
		Me.txtPoll.Maxlength = 0
		Me.txtPoll.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtPoll.MultiLine = False
		Me.txtPoll.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtPoll.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtPoll.TabStop = True
		Me.txtPoll.Visible = True
		Me.txtPoll.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtPoll.Name = "txtPoll"
		Me.Label6.Text = "millisec."
		Me.Label6.Size = New System.Drawing.Size(41, 17)
		Me.Label6.Location = New System.Drawing.Point(56, 32)
		Me.Label6.TabIndex = 26
		Me.Label6.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label6.BackColor = System.Drawing.SystemColors.Control
		Me.Label6.Enabled = True
		Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label6.UseMnemonic = True
		Me.Label6.Visible = True
		Me.Label6.AutoSize = False
		Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label6.Name = "Label6"
		Me.cmdCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdCancel.Text = "Cancel"
		Me.cmdCancel.Size = New System.Drawing.Size(72, 20)
		Me.cmdCancel.Location = New System.Drawing.Point(323, 71)
		Me.cmdCancel.TabIndex = 20
		Me.cmdCancel.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdCancel.BackColor = System.Drawing.SystemColors.Control
		Me.cmdCancel.CausesValidation = True
		Me.cmdCancel.Enabled = True
		Me.cmdCancel.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdCancel.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdCancel.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdCancel.TabStop = True
		Me.cmdCancel.Name = "cmdCancel"
		Me.Frame1.Text = "Port and Speed"
		Me.Frame1.Size = New System.Drawing.Size(174, 80)
		Me.Frame1.Location = New System.Drawing.Point(8, 24)
		Me.Frame1.TabIndex = 18
		Me.Frame1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame1.BackColor = System.Drawing.SystemColors.Control
		Me.Frame1.Enabled = True
		Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame1.Visible = True
		Me.Frame1.Name = "Frame1"
		Me.cboPort.Size = New System.Drawing.Size(113, 21)
		Me.cboPort.Location = New System.Drawing.Point(48, 24)
		Me.cboPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cboPort.TabIndex = 21
		Me.cboPort.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboPort.BackColor = System.Drawing.SystemColors.Window
		Me.cboPort.CausesValidation = True
		Me.cboPort.Enabled = True
		Me.cboPort.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboPort.IntegralHeight = True
		Me.cboPort.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboPort.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboPort.Sorted = False
		Me.cboPort.TabStop = True
		Me.cboPort.Visible = True
		Me.cboPort.Name = "cboPort"
		Me.cboSpeed.Size = New System.Drawing.Size(113, 21)
		Me.cboSpeed.Location = New System.Drawing.Point(48, 48)
		Me.cboSpeed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cboSpeed.TabIndex = 19
		Me.cboSpeed.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboSpeed.BackColor = System.Drawing.SystemColors.Window
		Me.cboSpeed.CausesValidation = True
		Me.cboSpeed.Enabled = True
		Me.cboSpeed.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboSpeed.IntegralHeight = True
		Me.cboSpeed.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboSpeed.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboSpeed.Sorted = False
		Me.cboSpeed.TabStop = True
		Me.cboSpeed.Visible = True
		Me.cboSpeed.Name = "cboSpeed"
		Me.Label2.Text = "Speed:"
		Me.Label2.Size = New System.Drawing.Size(33, 21)
		Me.Label2.Location = New System.Drawing.Point(8, 48)
		Me.Label2.TabIndex = 23
		Me.Label2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label2.BackColor = System.Drawing.SystemColors.Control
		Me.Label2.Enabled = True
		Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label2.UseMnemonic = True
		Me.Label2.Visible = True
		Me.Label2.AutoSize = False
		Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label2.Name = "Label2"
		Me.Label1.Text = "Port:"
		Me.Label1.Size = New System.Drawing.Size(33, 21)
		Me.Label1.Location = New System.Drawing.Point(8, 24)
		Me.Label1.TabIndex = 22
		Me.Label1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label1.BackColor = System.Drawing.SystemColors.Control
		Me.Label1.Enabled = True
		Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label1.UseMnemonic = True
		Me.Label1.Visible = True
		Me.Label1.AutoSize = False
		Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label1.Name = "Label1"
		Me.fraConnection.Text = "Communication Settings"
		Me.fraConnection.Size = New System.Drawing.Size(175, 118)
		Me.fraConnection.Location = New System.Drawing.Point(8, 112)
		Me.fraConnection.TabIndex = 11
		Me.fraConnection.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.fraConnection.BackColor = System.Drawing.SystemColors.Control
		Me.fraConnection.Enabled = True
		Me.fraConnection.ForeColor = System.Drawing.SystemColors.ControlText
		Me.fraConnection.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.fraConnection.Visible = True
		Me.fraConnection.Name = "fraConnection"
		Me.cboStopBits.Size = New System.Drawing.Size(68, 21)
		Me.cboStopBits.Location = New System.Drawing.Point(90, 84)
		Me.cboStopBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cboStopBits.TabIndex = 14
		Me.cboStopBits.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboStopBits.BackColor = System.Drawing.SystemColors.Window
		Me.cboStopBits.CausesValidation = True
		Me.cboStopBits.Enabled = True
		Me.cboStopBits.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboStopBits.IntegralHeight = True
		Me.cboStopBits.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboStopBits.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboStopBits.Sorted = False
		Me.cboStopBits.TabStop = True
		Me.cboStopBits.Visible = True
		Me.cboStopBits.Name = "cboStopBits"
		Me.cboParity.Size = New System.Drawing.Size(68, 21)
		Me.cboParity.Location = New System.Drawing.Point(90, 54)
		Me.cboParity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cboParity.TabIndex = 13
		Me.cboParity.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboParity.BackColor = System.Drawing.SystemColors.Window
		Me.cboParity.CausesValidation = True
		Me.cboParity.Enabled = True
		Me.cboParity.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboParity.IntegralHeight = True
		Me.cboParity.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboParity.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboParity.Sorted = False
		Me.cboParity.TabStop = True
		Me.cboParity.Visible = True
		Me.cboParity.Name = "cboParity"
		Me.cboDataBits.Size = New System.Drawing.Size(68, 21)
		Me.cboDataBits.Location = New System.Drawing.Point(90, 22)
		Me.cboDataBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cboDataBits.TabIndex = 12
		Me.cboDataBits.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboDataBits.BackColor = System.Drawing.SystemColors.Window
		Me.cboDataBits.CausesValidation = True
		Me.cboDataBits.Enabled = True
		Me.cboDataBits.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboDataBits.IntegralHeight = True
		Me.cboDataBits.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboDataBits.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboDataBits.Sorted = False
		Me.cboDataBits.TabStop = True
		Me.cboDataBits.Visible = True
		Me.cboDataBits.Name = "cboDataBits"
		Me.Label5.Text = "Stop Bits:"
		Me.Label5.Size = New System.Drawing.Size(59, 19)
		Me.Label5.Location = New System.Drawing.Point(32, 88)
		Me.Label5.TabIndex = 17
		Me.Label5.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label5.BackColor = System.Drawing.SystemColors.Control
		Me.Label5.Enabled = True
		Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label5.UseMnemonic = True
		Me.Label5.Visible = True
		Me.Label5.AutoSize = False
		Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label5.Name = "Label5"
		Me.Label4.Text = "Parity:"
		Me.Label4.Size = New System.Drawing.Size(31, 19)
		Me.Label4.Location = New System.Drawing.Point(54, 57)
		Me.Label4.TabIndex = 16
		Me.Label4.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label4.BackColor = System.Drawing.SystemColors.Control
		Me.Label4.Enabled = True
		Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label4.UseMnemonic = True
		Me.Label4.Visible = True
		Me.Label4.AutoSize = False
		Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label4.Name = "Label4"
		Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
		Me.Label3.Text = "Data Bits:"
		Me.Label3.Size = New System.Drawing.Size(81, 19)
		Me.Label3.Location = New System.Drawing.Point(6, 25)
		Me.Label3.TabIndex = 15
		Me.Label3.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.BackColor = System.Drawing.SystemColors.Control
		Me.Label3.Enabled = True
		Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label3.UseMnemonic = True
		Me.Label3.Visible = True
		Me.Label3.AutoSize = False
		Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label3.Name = "Label3"
		Me.cmdOK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdOK.Text = "OK"
		Me.AcceptButton = Me.cmdOK
		Me.cmdOK.Size = New System.Drawing.Size(72, 20)
		Me.cmdOK.Location = New System.Drawing.Point(323, 47)
		Me.cmdOK.TabIndex = 10
		Me.cmdOK.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdOK.BackColor = System.Drawing.SystemColors.Control
		Me.cmdOK.CausesValidation = True
		Me.cmdOK.Enabled = True
		Me.cmdOK.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdOK.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdOK.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdOK.TabStop = True
		Me.cmdOK.Name = "cmdOK"
		Me.Frame7.Text = "Local &Echo"
		Me.Frame7.Enabled = False
		Me.Frame7.Size = New System.Drawing.Size(84, 117)
		Me.Frame7.Location = New System.Drawing.Point(192, 112)
		Me.Frame7.TabIndex = 7
		Me.Frame7.Visible = False
		Me.Frame7.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame7.BackColor = System.Drawing.SystemColors.Control
		Me.Frame7.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame7.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame7.Name = "Frame7"
		Me._optEcho_0.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optEcho_0.Text = "No"
		Me._optEcho_0.Enabled = False
		Me._optEcho_0.Size = New System.Drawing.Size(41, 21)
		Me._optEcho_0.Location = New System.Drawing.Point(16, 16)
		Me._optEcho_0.TabIndex = 9
		Me._optEcho_0.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._optEcho_0.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optEcho_0.BackColor = System.Drawing.SystemColors.Control
		Me._optEcho_0.CausesValidation = True
		Me._optEcho_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._optEcho_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._optEcho_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._optEcho_0.Appearance = System.Windows.Forms.Appearance.Normal
		Me._optEcho_0.TabStop = True
		Me._optEcho_0.Checked = False
		Me._optEcho_0.Visible = True
		Me._optEcho_0.Name = "_optEcho_0"
		Me._optEcho_1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optEcho_1.Text = "Yes"
		Me._optEcho_1.Enabled = False
		Me._optEcho_1.Size = New System.Drawing.Size(47, 13)
		Me._optEcho_1.Location = New System.Drawing.Point(16, 40)
		Me._optEcho_1.TabIndex = 8
		Me._optEcho_1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._optEcho_1.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optEcho_1.BackColor = System.Drawing.SystemColors.Control
		Me._optEcho_1.CausesValidation = True
		Me._optEcho_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me._optEcho_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._optEcho_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._optEcho_1.Appearance = System.Windows.Forms.Appearance.Normal
		Me._optEcho_1.TabStop = True
		Me._optEcho_1.Checked = False
		Me._optEcho_1.Visible = True
		Me._optEcho_1.Name = "_optEcho_1"
		Me.Frame5.Text = "&Flow Control"
		Me.Frame5.Enabled = False
		Me.Frame5.Size = New System.Drawing.Size(108, 118)
		Me.Frame5.Location = New System.Drawing.Point(288, 112)
		Me.Frame5.TabIndex = 2
		Me.Frame5.Visible = False
		Me.Frame5.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame5.BackColor = System.Drawing.SystemColors.Control
		Me.Frame5.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame5.Name = "Frame5"
		Me._optFlow_0.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optFlow_0.Text = "None"
		Me._optFlow_0.Enabled = False
		Me._optFlow_0.Size = New System.Drawing.Size(57, 17)
		Me._optFlow_0.Location = New System.Drawing.Point(12, 23)
		Me._optFlow_0.TabIndex = 6
		Me._optFlow_0.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._optFlow_0.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optFlow_0.BackColor = System.Drawing.SystemColors.Control
		Me._optFlow_0.CausesValidation = True
		Me._optFlow_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._optFlow_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._optFlow_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._optFlow_0.Appearance = System.Windows.Forms.Appearance.Normal
		Me._optFlow_0.TabStop = True
		Me._optFlow_0.Checked = False
		Me._optFlow_0.Visible = True
		Me._optFlow_0.Name = "_optFlow_0"
		Me._optFlow_1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optFlow_1.Text = "XOn/XOff"
		Me._optFlow_1.Enabled = False
		Me._optFlow_1.Size = New System.Drawing.Size(73, 17)
		Me._optFlow_1.Location = New System.Drawing.Point(12, 43)
		Me._optFlow_1.TabIndex = 5
		Me._optFlow_1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._optFlow_1.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optFlow_1.BackColor = System.Drawing.SystemColors.Control
		Me._optFlow_1.CausesValidation = True
		Me._optFlow_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me._optFlow_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._optFlow_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._optFlow_1.Appearance = System.Windows.Forms.Appearance.Normal
		Me._optFlow_1.TabStop = True
		Me._optFlow_1.Checked = False
		Me._optFlow_1.Visible = True
		Me._optFlow_1.Name = "_optFlow_1"
		Me._optFlow_2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optFlow_2.Text = "RTS"
		Me._optFlow_2.Enabled = False
		Me._optFlow_2.Size = New System.Drawing.Size(75, 17)
		Me._optFlow_2.Location = New System.Drawing.Point(12, 63)
		Me._optFlow_2.TabIndex = 4
		Me._optFlow_2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._optFlow_2.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optFlow_2.BackColor = System.Drawing.SystemColors.Control
		Me._optFlow_2.CausesValidation = True
		Me._optFlow_2.ForeColor = System.Drawing.SystemColors.ControlText
		Me._optFlow_2.Cursor = System.Windows.Forms.Cursors.Default
		Me._optFlow_2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._optFlow_2.Appearance = System.Windows.Forms.Appearance.Normal
		Me._optFlow_2.TabStop = True
		Me._optFlow_2.Checked = False
		Me._optFlow_2.Visible = True
		Me._optFlow_2.Name = "_optFlow_2"
		Me._optFlow_3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optFlow_3.Text = "XOn/RTS"
		Me._optFlow_3.Enabled = False
		Me._optFlow_3.Size = New System.Drawing.Size(71, 17)
		Me._optFlow_3.Location = New System.Drawing.Point(12, 83)
		Me._optFlow_3.TabIndex = 3
		Me._optFlow_3.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._optFlow_3.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._optFlow_3.BackColor = System.Drawing.SystemColors.Control
		Me._optFlow_3.CausesValidation = True
		Me._optFlow_3.ForeColor = System.Drawing.SystemColors.ControlText
		Me._optFlow_3.Cursor = System.Windows.Forms.Cursors.Default
		Me._optFlow_3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._optFlow_3.Appearance = System.Windows.Forms.Appearance.Normal
		Me._optFlow_3.TabStop = True
		Me._optFlow_3.Checked = False
		Me._optFlow_3.Visible = True
		Me._optFlow_3.Name = "_optFlow_3"
		tabSettings.OcxState = CType(resources.GetObject("tabSettings.OcxState"), System.Windows.Forms.AxHost.State)
		Me.tabSettings.Size = New System.Drawing.Size(420, 271)
		Me.tabSettings.Location = New System.Drawing.Point(6, 7)
		Me.tabSettings.TabIndex = 0
		Me.tabSettings.Name = "tabSettings"
		Me.Controls.Add(fraSettings)
		Me.Controls.Add(tabSettings)
		Me.fraSettings.Controls.Add(Frame2)
		Me.fraSettings.Controls.Add(cmdCancel)
		Me.fraSettings.Controls.Add(Frame1)
		Me.fraSettings.Controls.Add(fraConnection)
		Me.fraSettings.Controls.Add(cmdOK)
		Me.fraSettings.Controls.Add(Frame7)
		Me.fraSettings.Controls.Add(Frame5)
		Me.Frame2.Controls.Add(txtPoll)
		Me.Frame2.Controls.Add(Label6)
		Me.Frame1.Controls.Add(cboPort)
		Me.Frame1.Controls.Add(cboSpeed)
		Me.Frame1.Controls.Add(Label2)
		Me.Frame1.Controls.Add(Label1)
		Me.fraConnection.Controls.Add(cboStopBits)
		Me.fraConnection.Controls.Add(cboParity)
		Me.fraConnection.Controls.Add(cboDataBits)
		Me.fraConnection.Controls.Add(Label5)
		Me.fraConnection.Controls.Add(Label4)
		Me.fraConnection.Controls.Add(Label3)
		Me.Frame7.Controls.Add(_optEcho_0)
		Me.Frame7.Controls.Add(_optEcho_1)
		Me.Frame5.Controls.Add(_optFlow_0)
		Me.Frame5.Controls.Add(_optFlow_1)
		Me.Frame5.Controls.Add(_optFlow_2)
		Me.Frame5.Controls.Add(_optFlow_3)
		Me.optEcho.SetIndex(_optEcho_0, CType(0, Short))
		Me.optEcho.SetIndex(_optEcho_1, CType(1, Short))
		Me.optFlow.SetIndex(_optFlow_0, CType(0, Short))
		Me.optFlow.SetIndex(_optFlow_1, CType(1, Short))
		Me.optFlow.SetIndex(_optFlow_2, CType(2, Short))
		Me.optFlow.SetIndex(_optFlow_3, CType(3, Short))
		CType(Me.optFlow, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.optEcho, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.tabSettings, System.ComponentModel.ISupportInitialize).EndInit()
	End Sub
#End Region 
#Region "Upgrade Support "
	Private Shared m_vb6FormDefInstance As frmProps
	Private Shared m_InitializingDefInstance As Boolean
	Public Shared Property DefInstance() As frmProps
		Get
			If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
				m_InitializingDefInstance = True
				m_vb6FormDefInstance = New frmProps()
				m_InitializingDefInstance = False
			End If
			DefInstance = m_vb6FormDefInstance
		End Get
		Set
			m_vb6FormDefInstance = Value
		End Set
	End Property
#End Region 
	'********************************************
	' ECU Control is a software designed to control
	' Honda Motors's Inc. Emission Control Unit (ECU).
	' BASE CODE (C) Nicolas Mailloux - nicolas.mailloux@micronick.com
	
	Private iFlow As Short
	Private iTempEcho As Boolean
	
	
	Sub LoadPropertySettings()
		Dim Echo As Object
		Dim i, Offset As Short
		Dim Settings As String
		
		' Charge les paramètres du port de communication.
		For i = 1 To 16
			cboPort.Items.Add("Com" & Trim(Str(i)))
		Next i
		
		' Charge les paramètres de vitesse.
		cboSpeed.Items.Add("9600")
		cboSpeed.Items.Add("19200")
		cboSpeed.Items.Add("38400")
		cboSpeed.Items.Add("57600")
		
		' Charge les paramètres de bit de donnée.
		cboDataBits.Items.Add("4")
		cboDataBits.Items.Add("5")
		cboDataBits.Items.Add("6")
		cboDataBits.Items.Add("7")
		cboDataBits.Items.Add("8")
		
		' Charge les paramètres de parité.
		cboParity.Items.Add("Even")
		cboParity.Items.Add("Odd")
		cboParity.Items.Add("None")
		cboParity.Items.Add("Mark")
		cboParity.Items.Add("Space")
		
		' Charge les paramètres de bit d'arrêt.
		cboStopBits.Items.Add("1")
		cboStopBits.Items.Add("1.5")
		cboStopBits.Items.Add("2")
		
		' Définit les paramètres par défaut.
        '*************** Change this to read from registry
        'Settings = frmDataLog.DefInstance.MSComm1.Settings
		
		' Dans tous les cas, l'élément le plus à droite des paramètres
		' sera de 1 caractère, sauf lorsque le bit d'arrêt est 1.5.
		If InStr(Settings, ".") > 0 Then
			Offset = 2
		Else
			Offset = 0
		End If
		
		cboSpeed.Text = VB.Left(Settings, Len(Settings) - 6 - Offset)
		Select Case Mid(Settings, Len(Settings) - 4 - Offset, 1)
			Case "e"
				cboParity.SelectedIndex = 0
			Case "m"
				cboParity.SelectedIndex = 1
			Case "n"
				cboParity.SelectedIndex = 2
			Case "o"
				cboParity.SelectedIndex = 3
			Case "s"
				cboParity.SelectedIndex = 4
		End Select
		
		cboDataBits.Text = Mid(Settings, Len(Settings) - 2 - Offset, 1)
		cboStopBits.Text = VB.Right(Settings, 1 + Offset)
		
        'cboPort.SelectedIndex = frmDataLog.DefInstance.MSComm1.CommPort - 1
		
        'optFlow(frmDataLog.DefInstance.MSComm1.Handshaking).Checked = True
		'UPGRADE_WARNING: Couldn't resolve default property of object Echo. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		If Echo Then
			optEcho(1).Checked = True
		Else
			optEcho(0).Checked = True
		End If
		
	End Sub
	
	
	
	
	
	Private Sub cmdCancel_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCancel.Click
		Me.Close()
	End Sub
	
	Private Sub cmdOk_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdOk.Click
		Dim NewPort As Object
		Dim Echo As Object
		Dim OldPort As Short
		Dim ReOpen As Boolean
		
		On Error Resume Next
		
		'UPGRADE_WARNING: Couldn't resolve default property of object Echo. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		Echo = iTempEcho
        'OldPort = frmDataLog.DefInstance.MSComm1.CommPort
		'UPGRADE_WARNING: Couldn't resolve default property of object NewPort. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		NewPort = cboPort.SelectedIndex + 1
		
		'UPGRADE_WARNING: Couldn't resolve default property of object NewPort. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
        'If NewPort <> OldPort Then ' Si le numéro de port change, ferme l'ancien port.
        '      If frmDataLog.DefInstance.MSComm1.PortOpen Then
        '     frmDataLog.DefInstance.MSComm1.PortOpen = False
        '    ReOpen = True
        '   End If

        'UPGRADE_WARNING: Couldn't resolve default property of object NewPort. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
        '  frmDataLog.DefInstance.MSComm1.CommPort = NewPort ' Définit le nouveau numéro de port.

        ' If Err.Number = 0 Then
        'If ReOpen Then
        'frmDataLog.DefInstance.MSComm1.PortOpen = True
        'End If
        'End If

        'If Err.Number Then
        'MsgBox(ErrorToString(), 48)
        'frmDataLog.DefInstance.MSComm1.CommPort = OldPort
        'Exit Sub
        'End If
        'End If


        '     frmDataLog.DefInstance.MSComm1.Settings = Trim(cboSpeed.Text) & "," & VB.Left(cboParity.Text, 1) & "," & Trim(cboDataBits.Text) & "," & Trim(cboStopBits.Text)

        'If Err.Number Then
        'MsgBox(ErrorToString(), 48)
        'Exit Sub
        'End If

        'frmDataLog.DefInstance.MSComm1.Handshaking = iFlow
        'If Err.Number Then
        'MsgBox(ErrorToString(), 48)
        'Exit Sub
        'End If

        'SaveSetting(System.Reflection.Assembly.GetExecutingAssembly.GetName.Name, "Properties", "Settings", frmDataLog.DefInstance.MSComm1.Settings)
        'SaveSetting(System.Reflection.Assembly.GetExecutingAssembly.GetName.Name, "Properties", "CommPort", CStr(frmDataLog.DefInstance.MSComm1.CommPort))
        'SaveSetting(System.Reflection.Assembly.GetExecutingAssembly.GetName.Name, "Properties", "Handshaking", CStr(frmDataLog.DefInstance.MSComm1.Handshaking))
        'UPGRADE_WARNING: Couldn't resolve default property of object Echo. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
        SaveSetting(System.Reflection.Assembly.GetExecutingAssembly.GetName.Name, "Properties", "Echo", Echo)

        PollTime = CInt(txtPoll.Text)
        frmDataLog.DefInstance.Set_PollTime()
        frmDataLog.DefInstance.UpdateStatus()
        Me.Close()
		
	End Sub
	Private Sub frmProps_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		
		' Définit la taille de la feuille.
		Me.Left = VB6.TwipsToPixelsX((VB6.PixelsToTwipsX(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width) - VB6.PixelsToTwipsX(Me.Width)) / 2)
		Me.Top = VB6.TwipsToPixelsY((VB6.PixelsToTwipsY(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height) - VB6.PixelsToTwipsY(Me.Height)) / 2)
		
		' Dimensionne le cadre pour l'ajuster au contrôle Tabstrip.
		fraSettings.SetBounds(VB6.TwipsToPixelsX(tabSettings.ClientLeft), VB6.TwipsToPixelsY(tabSettings.ClientTop), 0, 0, Windows.Forms.BoundsSpecified.X Or Windows.Forms.BoundsSpecified.Y)
		
		' Vérifie que le cadre est le contrôle de premier plan.
		fraSettings.BringToFront()
		
		' Charge les paramètres de la propriété courante.
		Me.txtPoll.Text = CStr(PollTime)
		LoadPropertySettings()
		
	End Sub
	
	'UPGRADE_WARNING: Event optEcho.CheckedChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2075"'
	Private Sub optEcho_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optEcho.CheckedChanged
		If eventSender.Checked Then
			Dim Index As Short = optEcho.GetIndex(eventSender)
			If Index = 1 Then
				iTempEcho = True
			Else
				iTempEcho = False
			End If
		End If
	End Sub
	
	'UPGRADE_WARNING: Event optFlow.CheckedChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2075"'
	Private Sub optFlow_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optFlow.CheckedChanged
		If eventSender.Checked Then
			Dim Index As Short = optFlow.GetIndex(eventSender)
			iFlow = Index
		End If
	End Sub
End Class