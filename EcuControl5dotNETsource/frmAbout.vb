Option Strict Off
Option Explicit On
Friend Class frmAbout
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
	Public WithEvents txtabout As System.Windows.Forms.TextBox
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmAbout))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.ToolTip1.Active = True
		Me.Command1 = New System.Windows.Forms.Button
		Me.txtabout = New System.Windows.Forms.TextBox
		Me.ClientSize = New System.Drawing.Size(690, 521)
		Me.Location = New System.Drawing.Point(4, 23)
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
		Me.Name = "frmAbout"
		Me.Command1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Command1.Text = "&Close"
		Me.Command1.Size = New System.Drawing.Size(89, 33)
		Me.Command1.Location = New System.Drawing.Point(592, 480)
		Me.Command1.TabIndex = 1
		Me.Command1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Command1.BackColor = System.Drawing.SystemColors.Control
		Me.Command1.CausesValidation = True
		Me.Command1.Enabled = True
		Me.Command1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Command1.Cursor = System.Windows.Forms.Cursors.Default
		Me.Command1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Command1.TabStop = True
		Me.Command1.Name = "Command1"
		Me.txtabout.AutoSize = False
		Me.txtabout.BackColor = System.Drawing.SystemColors.Control
		Me.txtabout.Size = New System.Drawing.Size(673, 465)
		Me.txtabout.Location = New System.Drawing.Point(8, 8)
		Me.txtabout.ReadOnly = True
		Me.txtabout.MultiLine = True
		Me.txtabout.TabIndex = 0
		Me.txtabout.Text = "	Copyright (c) 2003-2004, Nicolas Mailloux" & Chr(13) & Chr(10) & "All rights reserved." & Chr(13) & Chr(10) & "" & Chr(13) & Chr(10) & "This Version of EcuControl 5 could not be done without the help of the PGMFI Group project (www.pgmfi.org)" & Chr(13) & Chr(10) & "I also want to thank Jason Parker of TurboEdit (www.turboedit.org) for helping"
		Me.txtabout.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtabout.AcceptsReturn = True
		Me.txtabout.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtabout.CausesValidation = True
		Me.txtabout.Enabled = True
		Me.txtabout.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtabout.HideSelection = True
		Me.txtabout.Maxlength = 0
		Me.txtabout.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtabout.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtabout.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtabout.TabStop = True
		Me.txtabout.Visible = True
		Me.txtabout.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtabout.Name = "txtabout"
		Me.Controls.Add(Command1)
		Me.Controls.Add(txtabout)
	End Sub
#End Region 
#Region "Upgrade Support "
	Private Shared m_vb6FormDefInstance As frmAbout
	Private Shared m_InitializingDefInstance As Boolean
	Public Shared Property DefInstance() As frmAbout
		Get
			If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
				m_InitializingDefInstance = True
				m_vb6FormDefInstance = New frmAbout()
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
	
	Private Sub Command1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command1.Click
		Me.Close()
	End Sub
	
	Private Sub frmAbout_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		frmAbout.DefInstance.Text = "About EcuControl 5"
	End Sub
End Class