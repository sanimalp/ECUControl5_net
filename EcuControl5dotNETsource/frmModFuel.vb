Option Strict Off
Option Explicit On
Friend Class frmModFuel
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
	Public WithEvents cmdSubs As System.Windows.Forms.Button
	Public WithEvents cmdAdd As System.Windows.Forms.Button
	Public WithEvents txtFuel As System.Windows.Forms.TextBox
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmModFuel))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.ToolTip1.Active = True
		Me.Command1 = New System.Windows.Forms.Button
		Me.cmdSubs = New System.Windows.Forms.Button
		Me.cmdAdd = New System.Windows.Forms.Button
		Me.txtFuel = New System.Windows.Forms.TextBox
		Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
		Me.Text = "Fuel Adjustment"
		Me.ClientSize = New System.Drawing.Size(225, 168)
		Me.Location = New System.Drawing.Point(4, 30)
		Me.ShowInTaskbar = False
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
		Me.HelpButton = False
		Me.WindowState = System.Windows.Forms.FormWindowState.Normal
		Me.Name = "frmModFuel"
		Me.Command1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Command1.Text = "OK"
		Me.Command1.Size = New System.Drawing.Size(73, 25)
		Me.Command1.Location = New System.Drawing.Point(8, 56)
		Me.Command1.TabIndex = 3
		Me.Command1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Command1.BackColor = System.Drawing.SystemColors.Control
		Me.Command1.CausesValidation = True
		Me.Command1.Enabled = True
		Me.Command1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Command1.Cursor = System.Windows.Forms.Cursors.Default
		Me.Command1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Command1.TabStop = True
		Me.Command1.Name = "Command1"
		Me.cmdSubs.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.cmdSubs.Size = New System.Drawing.Size(25, 25)
		Me.cmdSubs.Location = New System.Drawing.Point(56, 24)
		Me.cmdSubs.Image = CType(resources.GetObject("cmdSubs.Image"), System.Drawing.Image)
		Me.cmdSubs.TabIndex = 2
		Me.cmdSubs.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdSubs.BackColor = System.Drawing.SystemColors.Control
		Me.cmdSubs.CausesValidation = True
		Me.cmdSubs.Enabled = True
		Me.cmdSubs.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdSubs.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdSubs.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdSubs.TabStop = True
		Me.cmdSubs.Name = "cmdSubs"
		Me.cmdAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.cmdAdd.Size = New System.Drawing.Size(25, 25)
		Me.cmdAdd.Location = New System.Drawing.Point(56, 0)
		Me.cmdAdd.Image = CType(resources.GetObject("cmdAdd.Image"), System.Drawing.Image)
		Me.cmdAdd.TabIndex = 1
		Me.cmdAdd.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdAdd.BackColor = System.Drawing.SystemColors.Control
		Me.cmdAdd.CausesValidation = True
		Me.cmdAdd.Enabled = True
		Me.cmdAdd.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdAdd.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdAdd.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdAdd.TabStop = True
		Me.cmdAdd.Name = "cmdAdd"
		Me.txtFuel.AutoSize = False
		Me.txtFuel.Size = New System.Drawing.Size(49, 25)
		Me.txtFuel.Location = New System.Drawing.Point(0, 8)
		Me.txtFuel.TabIndex = 0
		Me.txtFuel.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtFuel.AcceptsReturn = True
		Me.txtFuel.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtFuel.BackColor = System.Drawing.SystemColors.Window
		Me.txtFuel.CausesValidation = True
		Me.txtFuel.Enabled = True
		Me.txtFuel.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtFuel.HideSelection = True
		Me.txtFuel.ReadOnly = False
		Me.txtFuel.Maxlength = 0
		Me.txtFuel.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtFuel.MultiLine = False
		Me.txtFuel.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtFuel.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtFuel.TabStop = True
		Me.txtFuel.Visible = True
		Me.txtFuel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtFuel.Name = "txtFuel"
		Me.Controls.Add(Command1)
		Me.Controls.Add(cmdSubs)
		Me.Controls.Add(cmdAdd)
		Me.Controls.Add(txtFuel)
	End Sub
#End Region 
#Region "Upgrade Support "
	Private Shared m_vb6FormDefInstance As frmModFuel
	Private Shared m_InitializingDefInstance As Boolean
	Public Shared Property DefInstance() As frmModFuel
		Get
			If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
				m_InitializingDefInstance = True
				m_vb6FormDefInstance = New frmModFuel()
				m_InitializingDefInstance = False
			End If
			DefInstance = m_vb6FormDefInstance
		End Get
		Set
			m_vb6FormDefInstance = Value
		End Set
	End Property
#End Region 
	Private Sub cmdAdd_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdAdd.Click
		If Me.txtFuel.Text = "" Then Exit Sub
		Me.txtFuel.Text = CStr(CDbl(Me.txtFuel.Text) + 0.05)
	End Sub
	Private Sub cmdsubs_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdsubs.Click
		If Me.txtFuel.Text = "" Then Exit Sub
		Me.txtFuel.Text = CStr(CDbl(Me.txtFuel.Text) - 0.05)
	End Sub
	
	Private Sub Command1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command1.Click
		Dim NewValue As Object
		Dim address As Object
		'UPGRADE_WARNING: Couldn't resolve default property of object EditFuelRow. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		'UPGRADE_WARNING: Couldn't resolve default property of object address. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		address = (((EditFuelRow - 1)) + EditFuelCol) - 1
		'UPGRADE_WARNING: Couldn't resolve default property of object address. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		'UPGRADE_WARNING: Couldn't resolve default property of object NewValue. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		NewValue = CDbl(txtFuel.Text) * (208 / 2 ^ Multipliers(address + 1)) - (224 / 2 ^ Multipliers(address + 1))
		'UPGRADE_WARNING: Couldn't resolve default property of object NewValue. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		If NewValue < 0 Then NewValue = 1
		'UPGRADE_WARNING: Couldn't resolve default property of object NewValue. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		If NewValue > 255 Then NewValue = 255
		OutBuffer(1) = "06"
		'UPGRADE_WARNING: Couldn't resolve default property of object address. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		OutBuffer(2) = Hex(address + ICFuelAddress)
		'UPGRADE_WARNING: Couldn't resolve default property of object NewValue. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		OutBuffer(4) = Hex(NewValue)
		OutBuffer(5) = "0F"
		WriteMemory()
		'UPGRADE_WARNING: Couldn't resolve default property of object address. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		'UPGRADE_WARNING: Couldn't resolve default property of object NewValue. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		FuelMapBuffer(address + 1) = NewValue
		frmModFuel.DefInstance.Close()
	End Sub
	
	Private Sub frmModFuel_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		'UPGRADE_WARNING: Couldn't resolve default property of object EditFuelRow. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		Me.txtFuel.Text = frmDataLog.DefInstance.MSFlexGrid1.get_TextMatrix(EditFuelRow, EditFuelCol)
	End Sub
	
	'UPGRADE_WARNING: Form event frmModFuel.Unload has a new behavior. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2065"'
	Private Sub frmModFuel_Closed(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Closed
		'frmDataLog.WriteValuesToGrid 'Original Code
		'UPGRADE_WARNING: Couldn't resolve default property of object EditFuelRow. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		frmDataLog.DefInstance.MSFlexGrid1.set_TextMatrix(EditFuelRow, EditFuelCol, Me.txtFuel.Text)
		
	End Sub
End Class