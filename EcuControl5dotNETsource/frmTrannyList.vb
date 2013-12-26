Option Strict Off
Option Explicit On
Friend Class frmTrannyList
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
	Public WithEvents Command1 As System.Windows.Forms.Button
	Public WithEvents Text1 As System.Windows.Forms.TextBox
	Public WithEvents chkManual As System.Windows.Forms.CheckBox
	Public WithEvents cboModel As System.Windows.Forms.ComboBox
	Public WithEvents cmdNew As System.Windows.Forms.Button
	Public WithEvents cmdSave As System.Windows.Forms.Button
	Public WithEvents txtNotes As System.Windows.Forms.TextBox
	Public WithEvents txtFinal As System.Windows.Forms.TextBox
	Public WithEvents txt5th As System.Windows.Forms.TextBox
	Public WithEvents txt4th As System.Windows.Forms.TextBox
	Public WithEvents txt3rd As System.Windows.Forms.TextBox
	Public WithEvents txt2nd As System.Windows.Forms.TextBox
	Public WithEvents txt1st As System.Windows.Forms.TextBox
	Public WithEvents Label6 As System.Windows.Forms.Label
	Public WithEvents Label5 As System.Windows.Forms.Label
	Public WithEvents Label4 As System.Windows.Forms.Label
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents frmInfo As System.Windows.Forms.GroupBox
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmTrannyList))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.ToolTip1.Active = True
		Me.Command1 = New System.Windows.Forms.Button
		Me.Text1 = New System.Windows.Forms.TextBox
		Me.frmInfo = New System.Windows.Forms.GroupBox
		Me.chkManual = New System.Windows.Forms.CheckBox
		Me.cboModel = New System.Windows.Forms.ComboBox
		Me.cmdNew = New System.Windows.Forms.Button
		Me.cmdSave = New System.Windows.Forms.Button
		Me.txtNotes = New System.Windows.Forms.TextBox
		Me.txtFinal = New System.Windows.Forms.TextBox
		Me.txt5th = New System.Windows.Forms.TextBox
		Me.txt4th = New System.Windows.Forms.TextBox
		Me.txt3rd = New System.Windows.Forms.TextBox
		Me.txt2nd = New System.Windows.Forms.TextBox
		Me.txt1st = New System.Windows.Forms.TextBox
		Me.Label6 = New System.Windows.Forms.Label
		Me.Label5 = New System.Windows.Forms.Label
		Me.Label4 = New System.Windows.Forms.Label
		Me.Label3 = New System.Windows.Forms.Label
		Me.Label2 = New System.Windows.Forms.Label
		Me.Label1 = New System.Windows.Forms.Label
		Me.Text = "Gear Corrections"
		Me.ClientSize = New System.Drawing.Size(359, 222)
		Me.Location = New System.Drawing.Point(4, 30)
		Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation
		Me.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
		Me.BackColor = System.Drawing.SystemColors.Control
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable
		Me.ControlBox = True
		Me.Enabled = True
		Me.KeyPreview = False
		Me.MaximizeBox = True
		Me.MinimizeBox = True
		Me.Cursor = System.Windows.Forms.Cursors.Default
		Me.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.ShowInTaskbar = True
		Me.HelpButton = False
		Me.WindowState = System.Windows.Forms.FormWindowState.Normal
		Me.Name = "frmTrannyList"
		Me.Command1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Command1.Text = "Command1"
		Me.Command1.Size = New System.Drawing.Size(57, 17)
		Me.Command1.Location = New System.Drawing.Point(8, 224)
		Me.Command1.TabIndex = 19
		Me.Command1.Visible = False
		Me.Command1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Command1.BackColor = System.Drawing.SystemColors.Control
		Me.Command1.CausesValidation = True
		Me.Command1.Enabled = True
		Me.Command1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Command1.Cursor = System.Windows.Forms.Cursors.Default
		Me.Command1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Command1.TabStop = True
		Me.Command1.Name = "Command1"
		Me.Text1.AutoSize = False
		Me.Text1.Size = New System.Drawing.Size(289, 129)
		Me.Text1.Location = New System.Drawing.Point(32, 224)
		Me.Text1.MultiLine = True
		Me.Text1.ScrollBars = System.Windows.Forms.ScrollBars.Both
		Me.Text1.WordWrap = False
		Me.Text1.TabIndex = 18
		Me.Text1.Text = "Text1"
		Me.Text1.Visible = False
		Me.Text1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Text1.AcceptsReturn = True
		Me.Text1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.Text1.BackColor = System.Drawing.SystemColors.Window
		Me.Text1.CausesValidation = True
		Me.Text1.Enabled = True
		Me.Text1.ForeColor = System.Drawing.SystemColors.WindowText
		Me.Text1.HideSelection = True
		Me.Text1.ReadOnly = False
		Me.Text1.Maxlength = 0
		Me.Text1.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.Text1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Text1.TabStop = True
		Me.Text1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Text1.Name = "Text1"
		Me.frmInfo.Text = "Info"
		Me.frmInfo.Size = New System.Drawing.Size(345, 209)
		Me.frmInfo.Location = New System.Drawing.Point(8, 8)
		Me.frmInfo.TabIndex = 0
		Me.frmInfo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.frmInfo.BackColor = System.Drawing.SystemColors.Control
		Me.frmInfo.Enabled = True
		Me.frmInfo.ForeColor = System.Drawing.SystemColors.ControlText
		Me.frmInfo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.frmInfo.Visible = True
		Me.frmInfo.Name = "frmInfo"
		Me.chkManual.Text = "Manual Transmission"
		Me.chkManual.Size = New System.Drawing.Size(233, 17)
		Me.chkManual.Location = New System.Drawing.Point(104, 40)
		Me.chkManual.TabIndex = 17
		Me.chkManual.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.chkManual.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.chkManual.BackColor = System.Drawing.SystemColors.Control
		Me.chkManual.CausesValidation = True
		Me.chkManual.Enabled = True
		Me.chkManual.ForeColor = System.Drawing.SystemColors.ControlText
		Me.chkManual.Cursor = System.Windows.Forms.Cursors.Default
		Me.chkManual.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.chkManual.Appearance = System.Windows.Forms.Appearance.Normal
		Me.chkManual.TabStop = True
		Me.chkManual.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.chkManual.Visible = True
		Me.chkManual.Name = "chkManual"
		Me.cboModel.Size = New System.Drawing.Size(329, 21)
		Me.cboModel.Location = New System.Drawing.Point(8, 16)
		Me.cboModel.TabIndex = 16
		Me.cboModel.Text = "Combo1"
		Me.cboModel.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboModel.BackColor = System.Drawing.SystemColors.Window
		Me.cboModel.CausesValidation = True
		Me.cboModel.Enabled = True
		Me.cboModel.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboModel.IntegralHeight = True
		Me.cboModel.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboModel.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboModel.Sorted = False
		Me.cboModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboModel.TabStop = True
		Me.cboModel.Visible = True
		Me.cboModel.Name = "cboModel"
		Me.cmdNew.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdNew.Text = "New"
		Me.cmdNew.Size = New System.Drawing.Size(65, 25)
		Me.cmdNew.Location = New System.Drawing.Point(104, 80)
		Me.cmdNew.TabIndex = 15
		Me.cmdNew.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdNew.BackColor = System.Drawing.SystemColors.Control
		Me.cmdNew.CausesValidation = True
		Me.cmdNew.Enabled = True
		Me.cmdNew.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdNew.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdNew.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdNew.TabStop = True
		Me.cmdNew.Name = "cmdNew"
		Me.cmdSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdSave.Text = "Save"
		Me.cmdSave.Enabled = False
		Me.cmdSave.Size = New System.Drawing.Size(65, 25)
		Me.cmdSave.Location = New System.Drawing.Point(104, 104)
		Me.cmdSave.TabIndex = 14
		Me.cmdSave.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdSave.BackColor = System.Drawing.SystemColors.Control
		Me.cmdSave.CausesValidation = True
		Me.cmdSave.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdSave.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdSave.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdSave.TabStop = True
		Me.cmdSave.Name = "cmdSave"
		Me.txtNotes.AutoSize = False
		Me.txtNotes.Enabled = False
		Me.txtNotes.Size = New System.Drawing.Size(89, 121)
		Me.txtNotes.Location = New System.Drawing.Point(248, 72)
		Me.txtNotes.MultiLine = True
		Me.txtNotes.TabIndex = 13
		Me.txtNotes.Visible = False
		Me.txtNotes.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtNotes.AcceptsReturn = True
		Me.txtNotes.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtNotes.BackColor = System.Drawing.SystemColors.Window
		Me.txtNotes.CausesValidation = True
		Me.txtNotes.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtNotes.HideSelection = True
		Me.txtNotes.ReadOnly = False
		Me.txtNotes.Maxlength = 0
		Me.txtNotes.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtNotes.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtNotes.TabStop = True
		Me.txtNotes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtNotes.Name = "txtNotes"
		Me.txtFinal.AutoSize = False
		Me.txtFinal.Size = New System.Drawing.Size(41, 19)
		Me.txtFinal.Location = New System.Drawing.Point(40, 176)
		Me.txtFinal.TabIndex = 11
		Me.txtFinal.Text = "1.00"
		Me.txtFinal.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtFinal.AcceptsReturn = True
		Me.txtFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtFinal.BackColor = System.Drawing.SystemColors.Window
		Me.txtFinal.CausesValidation = True
		Me.txtFinal.Enabled = True
		Me.txtFinal.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtFinal.HideSelection = True
		Me.txtFinal.ReadOnly = False
		Me.txtFinal.Maxlength = 0
		Me.txtFinal.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtFinal.MultiLine = False
		Me.txtFinal.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtFinal.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtFinal.TabStop = True
		Me.txtFinal.Visible = True
		Me.txtFinal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtFinal.Name = "txtFinal"
		Me.txt5th.AutoSize = False
		Me.txt5th.Size = New System.Drawing.Size(41, 19)
		Me.txt5th.Location = New System.Drawing.Point(40, 152)
		Me.txt5th.TabIndex = 9
		Me.txt5th.Text = "1.00"
		Me.txt5th.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txt5th.AcceptsReturn = True
		Me.txt5th.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txt5th.BackColor = System.Drawing.SystemColors.Window
		Me.txt5th.CausesValidation = True
		Me.txt5th.Enabled = True
		Me.txt5th.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txt5th.HideSelection = True
		Me.txt5th.ReadOnly = False
		Me.txt5th.Maxlength = 0
		Me.txt5th.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txt5th.MultiLine = False
		Me.txt5th.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txt5th.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txt5th.TabStop = True
		Me.txt5th.Visible = True
		Me.txt5th.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txt5th.Name = "txt5th"
		Me.txt4th.AutoSize = False
		Me.txt4th.Size = New System.Drawing.Size(41, 19)
		Me.txt4th.Location = New System.Drawing.Point(40, 128)
		Me.txt4th.TabIndex = 7
		Me.txt4th.Text = "1.00"
		Me.txt4th.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txt4th.AcceptsReturn = True
		Me.txt4th.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txt4th.BackColor = System.Drawing.SystemColors.Window
		Me.txt4th.CausesValidation = True
		Me.txt4th.Enabled = True
		Me.txt4th.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txt4th.HideSelection = True
		Me.txt4th.ReadOnly = False
		Me.txt4th.Maxlength = 0
		Me.txt4th.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txt4th.MultiLine = False
		Me.txt4th.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txt4th.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txt4th.TabStop = True
		Me.txt4th.Visible = True
		Me.txt4th.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txt4th.Name = "txt4th"
		Me.txt3rd.AutoSize = False
		Me.txt3rd.Size = New System.Drawing.Size(41, 19)
		Me.txt3rd.Location = New System.Drawing.Point(40, 104)
		Me.txt3rd.TabIndex = 5
		Me.txt3rd.Text = "1.00"
		Me.txt3rd.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txt3rd.AcceptsReturn = True
		Me.txt3rd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txt3rd.BackColor = System.Drawing.SystemColors.Window
		Me.txt3rd.CausesValidation = True
		Me.txt3rd.Enabled = True
		Me.txt3rd.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txt3rd.HideSelection = True
		Me.txt3rd.ReadOnly = False
		Me.txt3rd.Maxlength = 0
		Me.txt3rd.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txt3rd.MultiLine = False
		Me.txt3rd.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txt3rd.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txt3rd.TabStop = True
		Me.txt3rd.Visible = True
		Me.txt3rd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txt3rd.Name = "txt3rd"
		Me.txt2nd.AutoSize = False
		Me.txt2nd.Size = New System.Drawing.Size(41, 19)
		Me.txt2nd.Location = New System.Drawing.Point(40, 80)
		Me.txt2nd.TabIndex = 3
		Me.txt2nd.Text = "1.00"
		Me.txt2nd.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txt2nd.AcceptsReturn = True
		Me.txt2nd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txt2nd.BackColor = System.Drawing.SystemColors.Window
		Me.txt2nd.CausesValidation = True
		Me.txt2nd.Enabled = True
		Me.txt2nd.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txt2nd.HideSelection = True
		Me.txt2nd.ReadOnly = False
		Me.txt2nd.Maxlength = 0
		Me.txt2nd.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txt2nd.MultiLine = False
		Me.txt2nd.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txt2nd.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txt2nd.TabStop = True
		Me.txt2nd.Visible = True
		Me.txt2nd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txt2nd.Name = "txt2nd"
		Me.txt1st.AutoSize = False
		Me.txt1st.Size = New System.Drawing.Size(41, 19)
		Me.txt1st.Location = New System.Drawing.Point(40, 56)
		Me.txt1st.TabIndex = 1
		Me.txt1st.Text = "1.00"
		Me.txt1st.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txt1st.AcceptsReturn = True
		Me.txt1st.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txt1st.BackColor = System.Drawing.SystemColors.Window
		Me.txt1st.CausesValidation = True
		Me.txt1st.Enabled = True
		Me.txt1st.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txt1st.HideSelection = True
		Me.txt1st.ReadOnly = False
		Me.txt1st.Maxlength = 0
		Me.txt1st.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txt1st.MultiLine = False
		Me.txt1st.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txt1st.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txt1st.TabStop = True
		Me.txt1st.Visible = True
		Me.txt1st.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txt1st.Name = "txt1st"
		Me.Label6.Text = "Final"
		Me.Label6.Size = New System.Drawing.Size(33, 17)
		Me.Label6.Location = New System.Drawing.Point(8, 176)
		Me.Label6.TabIndex = 12
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
		Me.Label5.Text = "5th"
		Me.Label5.Size = New System.Drawing.Size(33, 17)
		Me.Label5.Location = New System.Drawing.Point(8, 152)
		Me.Label5.TabIndex = 10
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
		Me.Label4.Text = "4th"
		Me.Label4.Size = New System.Drawing.Size(33, 17)
		Me.Label4.Location = New System.Drawing.Point(8, 128)
		Me.Label4.TabIndex = 8
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
		Me.Label3.Text = "3rd"
		Me.Label3.Size = New System.Drawing.Size(33, 17)
		Me.Label3.Location = New System.Drawing.Point(8, 104)
		Me.Label3.TabIndex = 6
		Me.Label3.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopLeft
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
		Me.Label2.Text = "2nd"
		Me.Label2.Size = New System.Drawing.Size(33, 17)
		Me.Label2.Location = New System.Drawing.Point(8, 80)
		Me.Label2.TabIndex = 4
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
		Me.Label1.Text = "1st"
		Me.Label1.Size = New System.Drawing.Size(33, 17)
		Me.Label1.Location = New System.Drawing.Point(8, 56)
		Me.Label1.TabIndex = 2
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
		Me.Controls.Add(Command1)
		Me.Controls.Add(Text1)
		Me.Controls.Add(frmInfo)
		Me.frmInfo.Controls.Add(chkManual)
		Me.frmInfo.Controls.Add(cboModel)
		Me.frmInfo.Controls.Add(cmdNew)
		Me.frmInfo.Controls.Add(cmdSave)
		Me.frmInfo.Controls.Add(txtNotes)
		Me.frmInfo.Controls.Add(txtFinal)
		Me.frmInfo.Controls.Add(txt5th)
		Me.frmInfo.Controls.Add(txt4th)
		Me.frmInfo.Controls.Add(txt3rd)
		Me.frmInfo.Controls.Add(txt2nd)
		Me.frmInfo.Controls.Add(txt1st)
		Me.frmInfo.Controls.Add(Label6)
		Me.frmInfo.Controls.Add(Label5)
		Me.frmInfo.Controls.Add(Label4)
		Me.frmInfo.Controls.Add(Label3)
		Me.frmInfo.Controls.Add(Label2)
		Me.frmInfo.Controls.Add(Label1)
	End Sub
#End Region 
#Region "Upgrade Support "
	Private Shared m_vb6FormDefInstance As frmTrannyList
	Private Shared m_InitializingDefInstance As Boolean
	Public Shared Property DefInstance() As frmTrannyList
		Get
			If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
				m_InitializingDefInstance = True
				m_vb6FormDefInstance = New frmTrannyList()
				m_InitializingDefInstance = False
			End If
			DefInstance = m_vb6FormDefInstance
		End Get
		Set
			m_vb6FormDefInstance = Value
		End Set
	End Property
#End Region 
	Dim lineno As Integer 'store line number of entry
	
	
	
	'UPGRADE_WARNING: Event cboModel.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2075"'
	'UPGRADE_WARNING: ComboBox event cboModel.Change was upgraded to cboModel.TextChanged which has a new behavior. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2074"'
	Private Sub cboModel_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboModel.TextChanged
		cmdSave.Enabled = True
	End Sub
	
	'UPGRADE_WARNING: Event cboModel.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2075"'
	Private Sub cboModel_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboModel.SelectedIndexChanged
		Dim tempD As String 'variable to hold data from grid
		Dim fso As New Scripting.FileSystemObject
		Dim ts As Scripting.TextStream
		Dim path As String
		Dim filename As String
		tempD = ""
		
		path = VB6.GetPath & "\tranlist.txt"
		ts = fso.OpenTextFile(path, Scripting.IOMode.ForReading)
		ts = fso.OpenTextFile(path, Scripting.IOMode.ForReading)
		Do While ts.AtEndOfStream = False
			
			tempD = ts.ReadLine
			Do While tempD = "" Or ts.AtEndOfStream = True
				tempD = ts.ReadLine
			Loop 
			If Mid(tempD, 2, Len(tempD) - 2) = cboModel.Text Then
				
				tempD = ts.ReadLine
				If tempD = "[Auto]" Then
					chkManual.CheckState = System.Windows.Forms.CheckState.Unchecked
					tempD = ts.ReadLine
					txt1st.Text = tempD
					tempD = ts.ReadLine
					txt2nd.Text = tempD
					tempD = ts.ReadLine
					txt3rd.Text = tempD
					tempD = ts.ReadLine
					txt4th.Text = tempD
					txt5th.Text = "0.00"
					txt5th.Enabled = False
					tempD = ts.ReadLine
					txtFinal.Text = tempD
					
				Else
					chkManual.CheckState = System.Windows.Forms.CheckState.Checked
					tempD = ts.ReadLine
					txt1st.Text = tempD
					tempD = ts.ReadLine
					txt2nd.Text = tempD
					tempD = ts.ReadLine
					txt3rd.Text = tempD
					tempD = ts.ReadLine
					txt4th.Text = tempD
					tempD = ts.ReadLine
					txt5th.Text = tempD
					txt5th.Enabled = True
					tempD = ts.ReadLine
					txtFinal.Text = tempD
				End If
				tempD = ""
				txtNotes.Text = ""
				tempD = ts.ReadLine
				Do While tempD <> "[ENDNOTES]"
					txtNotes.Text = txtNotes.Text & tempD
					tempD = ts.ReadLine
				Loop 
				Exit Do
			End If
			
		Loop 
		'close file and cleanup
		ts.Close()
		
		'UPGRADE_NOTE: Object ts may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1029"'
		ts = Nothing
		'UPGRADE_NOTE: Object fso may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1029"'
		fso = Nothing
		
	End Sub
	
	'UPGRADE_WARNING: Event chkManual.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2075"'
	Private Sub chkManual_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkManual.CheckStateChanged
		If chkManual.CheckState = 1 Then
			txt5th.Enabled = True
		Else
			txt5th.Text = "0.00"
			txt5th.Enabled = False
		End If
	End Sub
	
	
	
	Private Sub cmdNew_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdNew.Click
		cboModel.Text = "Enter Model Here"
		txt1st.Text = "1.00"
		txt2nd.Text = "1.00"
		txt3rd.Text = "1.00"
		txt4th.Text = "1.00"
		txt5th.Text = "1.00"
		txtFinal.Text = "1.00"
	End Sub
	
	Private Sub cmdSave_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdSave.Click
		
		Dim tempD As String
		Dim fso As New Scripting.FileSystemObject
		Dim ts As Scripting.TextStream
		Dim path As String
		Dim filename As String
		tempD = ""
		
		path = VB6.GetPath & "\tranlist.txt"
		
		
		Select Case EntryExists
			Case True
				Text1.Text = ""
				
				ts = fso.OpenTextFile(path, Scripting.IOMode.ForReading)
				
				Do Until ts.AtEndOfStream = True
					tempD = ts.ReadLine
					If tempD = "*" & cboModel.Text & "*" Then
						Text1.Text = Text1.Text & tempD
						Exit Do
					End If
					
				Loop 
				If chkManual.CheckState = 1 Then
					Text1.Text = Text1.Text & vbCrLf & "[Manual]" & vbCrLf & txt1st.Text & vbCrLf & txt2nd.Text & vbCrLf & txt3rd.Text & vbCrLf & txt4th.Text & vbCrLf & txt5th.Text & vbCrLf & txtFinal.Text & vbCrLf & txtNotes.Text & vbCrLf & "[ENDNOTES]"
					
					
				Else
					Text1.Text = Text1.Text & vbCrLf & "[Auto]" & vbCrLf & txt1st.Text & vbCrLf & txt2nd.Text & vbCrLf & txt3rd.Text & vbCrLf & txt4th.Text & vbCrLf & txtFinal.Text & vbCrLf & txtNotes.Text & vbCrLf & "[ENDNOTES]"
				End If
				Do 
					tempD = ts.ReadLine
					If tempD = "[ENDNOTES]" Then
						Exit Do
					End If
				Loop 
				If ts.AtEndOfStream = False Then
					Text1.Text = Text1.Text & ts.ReadAll
				End If
				
				
				
				ts.Close()
				'UPGRADE_NOTE: Object ts may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1029"'
				ts = Nothing
				ts = fso.OpenTextFile(path, Scripting.IOMode.ForWriting)
				ts.Write(Text1.Text)
				ts.Close()
				'UPGRADE_NOTE: Object ts may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1029"'
				ts = Nothing
				'UPGRADE_NOTE: Object fso may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1029"'
				fso = Nothing
				
				
				
			Case False
				ts = fso.OpenTextFile(path, Scripting.IOMode.ForAppending)
				ts.WriteLine("") 'start new line
				ts.WriteLine("*" & cboModel.Text & "*")
				If chkManual.CheckState = 1 Then
					ts.WriteLine("[Manual]")
					ts.WriteLine(txt1st.Text)
					ts.WriteLine(txt2nd.Text)
					ts.WriteLine(txt3rd.Text)
					ts.WriteLine(txt4th.Text)
					ts.WriteLine(txt5th.Text)
					ts.WriteLine(txtFinal.Text)
					ts.WriteLine(txtNotes.Text)
					ts.WriteLine("[ENDNOTES]")
					
				Else
					ts.WriteLine("[Auto]")
					ts.WriteLine(txt1st.Text)
					ts.WriteLine(txt2nd.Text)
					ts.WriteLine(txt3rd.Text)
					ts.WriteLine(txt4th.Text)
					ts.WriteLine(txtFinal.Text)
					ts.WriteLine(txtNotes.Text)
					ts.WriteLine("[ENDNOTES]")
				End If
				
				ts.Close()
				'UPGRADE_NOTE: Object ts may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1029"'
				ts = Nothing
				'UPGRADE_NOTE: Object fso may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1029"'
				fso = Nothing
				
		End Select
		
		
		lineno = 0
		Call frmTrannyList_Load(Me, New System.EventArgs())
		Call Command1_Click(Command1, New System.EventArgs())
		cmdSave.Enabled = False
	End Sub
	
	
	
	Private Sub Command1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command1.Click
		lineno = 0
		Dim tempD As String 'variable to hold data from grid
		Dim fso As New Scripting.FileSystemObject
		Dim ts As Scripting.TextStream
		Dim path As String
		Dim filename As String
		tempD = ""
		
		path = VB6.GetPath & "\tranlist.txt"
		
		ts = fso.OpenTextFile(path, Scripting.IOMode.ForReading)
		Text1.Text = ts.ReadLine
		Text1.Text = Text1.Text & vbCrLf & ts.ReadAll
		ts.Close()
		'UPGRADE_NOTE: Object ts may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1029"'
		ts = Nothing
		'UPGRADE_NOTE: Object fso may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1029"'
		fso = Nothing
		
	End Sub
	
	Private Sub frmTrannyList_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		lineno = 0
		Dim tempD As String 'variable to hold data from grid
		Dim fso As New Scripting.FileSystemObject
		Dim ts As Scripting.TextStream
		Dim path As String
		Dim filename As String
		tempD = ""
		cboModel.Items.Clear()
		path = VB6.GetPath & "\tranlist.txt"
		
		ts = fso.OpenTextFile(path, Scripting.IOMode.ForReading)
		Do While ts.AtEndOfStream = False
			tempD = ts.ReadLine
			If Mid(tempD, 1, 1) = "*" Then
				cboModel.Items.Add(Mid(tempD, 2, Len(tempD) - 2))
				tempD = ts.ReadLine
				If tempD = "[Auto]" Then
					chkManual.CheckState = System.Windows.Forms.CheckState.Unchecked
					tempD = ts.ReadLine
					txt1st.Text = tempD
					tempD = ts.ReadLine
					txt2nd.Text = tempD
					tempD = ts.ReadLine
					txt3rd.Text = tempD
					tempD = ts.ReadLine
					txt4th.Text = tempD
					txt5th.Text = "0.00"
					txt5th.Enabled = False
					tempD = ts.ReadLine
					txtFinal.Text = tempD
					
				Else
					chkManual.CheckState = System.Windows.Forms.CheckState.Checked
					tempD = ts.ReadLine
					txt1st.Text = tempD
					tempD = ts.ReadLine
					txt2nd.Text = tempD
					tempD = ts.ReadLine
					txt3rd.Text = tempD
					tempD = ts.ReadLine
					txt4th.Text = tempD
					tempD = ts.ReadLine
					txt5th.Text = tempD
					txt5th.Enabled = True
					tempD = ts.ReadLine
					txtFinal.Text = tempD
				End If
				tempD = ""
				txtNotes.Text = ""
				tempD = ts.ReadLine
				Do While tempD <> "[ENDNOTES]"
					txtNotes.Text = txtNotes.Text & tempD
					tempD = ts.ReadLine
				Loop 
			End If
		Loop 
		'close file and cleanup
		ts.Close()
		
		'UPGRADE_NOTE: Object ts may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1029"'
		ts = Nothing
		'UPGRADE_NOTE: Object fso may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1029"'
		fso = Nothing
		'cboModel.ListIndex = ListCount + 1
	End Sub
	Public Function EntryExists() As Boolean
		Dim tempD As String 'variable to hold data from grid
		Dim fso As New Scripting.FileSystemObject
		Dim ts As Scripting.TextStream
		Dim path As String
		Dim filename As String
		tempD = ""
		
		path = VB6.GetPath & "\tranlist.txt"
		
		ts = fso.OpenTextFile(path, Scripting.IOMode.ForReading)
		Do Until ts.AtEndOfStream = True
			tempD = ts.ReadLine
			lineno = lineno + 1
			Select Case tempD
				Case Is <> ""
					If Mid(tempD, 2, Len(tempD) - 2) = cboModel.Text Then
						EntryExists = True
						Exit Do
					Else
						EntryExists = False
					End If
			End Select
		Loop 
		
	End Function
End Class