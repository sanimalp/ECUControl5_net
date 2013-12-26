Option Strict Off
Option Explicit On
Friend Class frmModIgn
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
	Public WithEvents txtIgn As System.Windows.Forms.TextBox
	Public WithEvents cmdAdd As System.Windows.Forms.Button
	Public WithEvents cmdSubs As System.Windows.Forms.Button
	Public WithEvents cmdOk As System.Windows.Forms.Button
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmModIgn))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.ToolTip1.Active = True
		Me.txtIgn = New System.Windows.Forms.TextBox
		Me.cmdAdd = New System.Windows.Forms.Button
		Me.cmdSubs = New System.Windows.Forms.Button
		Me.cmdOk = New System.Windows.Forms.Button
		Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
		Me.Text = "Form1"
		Me.ClientSize = New System.Drawing.Size(115, 92)
		Me.Location = New System.Drawing.Point(4, 30)
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
		Me.Name = "frmModIgn"
		Me.txtIgn.AutoSize = False
		Me.txtIgn.Size = New System.Drawing.Size(49, 25)
		Me.txtIgn.Location = New System.Drawing.Point(0, 8)
		Me.txtIgn.TabIndex = 3
		Me.txtIgn.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtIgn.AcceptsReturn = True
		Me.txtIgn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtIgn.BackColor = System.Drawing.SystemColors.Window
		Me.txtIgn.CausesValidation = True
		Me.txtIgn.Enabled = True
		Me.txtIgn.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtIgn.HideSelection = True
		Me.txtIgn.ReadOnly = False
		Me.txtIgn.Maxlength = 0
		Me.txtIgn.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtIgn.MultiLine = False
		Me.txtIgn.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtIgn.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtIgn.TabStop = True
		Me.txtIgn.Visible = True
		Me.txtIgn.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtIgn.Name = "txtIgn"
		Me.cmdAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.cmdAdd.Size = New System.Drawing.Size(25, 25)
		Me.cmdAdd.Location = New System.Drawing.Point(56, 0)
		Me.cmdAdd.Image = CType(resources.GetObject("cmdAdd.Image"), System.Drawing.Image)
		Me.cmdAdd.TabIndex = 2
		Me.cmdAdd.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdAdd.BackColor = System.Drawing.SystemColors.Control
		Me.cmdAdd.CausesValidation = True
		Me.cmdAdd.Enabled = True
		Me.cmdAdd.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdAdd.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdAdd.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdAdd.TabStop = True
		Me.cmdAdd.Name = "cmdAdd"
		Me.cmdSubs.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.cmdSubs.Size = New System.Drawing.Size(25, 25)
		Me.cmdSubs.Location = New System.Drawing.Point(56, 24)
		Me.cmdSubs.Image = CType(resources.GetObject("cmdSubs.Image"), System.Drawing.Image)
		Me.cmdSubs.TabIndex = 1
		Me.cmdSubs.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdSubs.BackColor = System.Drawing.SystemColors.Control
		Me.cmdSubs.CausesValidation = True
		Me.cmdSubs.Enabled = True
		Me.cmdSubs.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdSubs.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdSubs.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdSubs.TabStop = True
		Me.cmdSubs.Name = "cmdSubs"
		Me.cmdOk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdOk.Text = "OK"
		Me.cmdOk.Size = New System.Drawing.Size(73, 25)
		Me.cmdOk.Location = New System.Drawing.Point(8, 56)
		Me.cmdOk.TabIndex = 0
		Me.cmdOk.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdOk.BackColor = System.Drawing.SystemColors.Control
		Me.cmdOk.CausesValidation = True
		Me.cmdOk.Enabled = True
		Me.cmdOk.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdOk.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdOk.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdOk.TabStop = True
		Me.cmdOk.Name = "cmdOk"
		Me.Controls.Add(txtIgn)
		Me.Controls.Add(cmdAdd)
		Me.Controls.Add(cmdSubs)
		Me.Controls.Add(cmdOk)
	End Sub
#End Region 
#Region "Upgrade Support "
	Private Shared m_vb6FormDefInstance As frmModIgn
	Private Shared m_InitializingDefInstance As Boolean
	Public Shared Property DefInstance() As frmModIgn
		Get
			If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
				m_InitializingDefInstance = True
				m_vb6FormDefInstance = New frmModIgn()
				m_InitializingDefInstance = False
			End If
			DefInstance = m_vb6FormDefInstance
		End Get
		Set
			m_vb6FormDefInstance = Value
		End Set
	End Property
#End Region 
	Dim IgnValue As Object
	Private Sub cmdAdd_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdAdd.Click
		If Me.txtIgn.Text = "" Then Exit Sub
		Me.txtIgn.Text = CStr(CDbl(Me.txtIgn.Text) + 0.05)
	End Sub
	Private Sub cmdsubs_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdsubs.Click
		If Me.txtIgn.Text = "" Then Exit Sub
		Me.txtIgn.Text = CStr(CDbl(Me.txtIgn.Text) - 0.05)
	End Sub
	Private Sub cmdOk_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdOk.Click
		Dim NewValue As Object
		Dim address As Object
		
		If txtIgn.Text = "" Then Exit Sub
		'UPGRADE_WARNING: Couldn't resolve default property of object EditIgnRow. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		'UPGRADE_WARNING: Couldn't resolve default property of object address. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		address = ((30 * (EditIgnRow - 1)) + EditIgnCol) - 1
		'UPGRADE_WARNING: Couldn't resolve default property of object NewValue. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		NewValue = (CDbl(txtIgn.Text) / 0.36) + 15
		'UPGRADE_WARNING: Couldn't resolve default property of object NewValue. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		If NewValue < 0 Then NewValue = 1
		'UPGRADE_WARNING: Couldn't resolve default property of object NewValue. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		If NewValue > 255 Then NewValue = 255
		OutBuffer(1) = "06"
		'UPGRADE_WARNING: Couldn't resolve default property of object address. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		OutBuffer(2) = Hex(address + ICIgnAddress)
		'UPGRADE_WARNING: Couldn't resolve default property of object NewValue. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		OutBuffer(4) = Hex(NewValue)
		OutBuffer(5) = "0F"
		'UPGRADE_WARNING: Couldn't resolve default property of object address. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		'UPGRADE_WARNING: Couldn't resolve default property of object NewValue. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		'UPGRADE_WARNING: Couldn't resolve default property of object IgnitionMapBuffer(address + 1). Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		IgnitionMapBuffer(address + 1) = NewValue
		WriteMemory()
		frmModIgn.DefInstance.Close()
	End Sub
	Private Sub frmModIgn_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		'UPGRADE_WARNING: Couldn't resolve default property of object EditIgnRow. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		Me.txtIgn.Text = frmDataLog.DefInstance.MSFlexGrid2.get_TextMatrix(EditIgnRow, EditIgnCol)
		'UPGRADE_WARNING: Couldn't resolve default property of object IgnValue. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		IgnValue = (CInt(txtIgn.Text) / 0.36) + 15
	End Sub
	'UPGRADE_WARNING: Form event frmModIgn.Unload has a new behavior. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2065"'
	Private Sub frmModIgn_Closed(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Closed
		frmDataLog.DefInstance.WriteValuesToGrid()
	End Sub
End Class