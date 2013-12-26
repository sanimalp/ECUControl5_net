Public Class frmDatalog
    Inherits System.Windows.Forms.Form
#Region "Form Access support"
    Private Shared m_vb6FormDefInstance As frmDatalog
    Private Shared m_InitializingDefInstance As Boolean
    Public Shared Property DefInstance() As frmDatalog
        Get
            If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_vb6FormDefInstance = New frmDatalog
                m_InitializingDefInstance = False
            End If
            DefInstance = m_vb6FormDefInstance
        End Get
        Set(ByVal Value As frmDatalog)
            m_vb6FormDefInstance = Value
        End Set
    End Property
#End Region
#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Public WithEvents _chkSensor_1 As System.Windows.Forms.CheckBox
    Public WithEvents _chkSensor_2 As System.Windows.Forms.CheckBox
    Public WithEvents _chkSensor_3 As System.Windows.Forms.CheckBox
    Public WithEvents _chkSensor_4 As System.Windows.Forms.CheckBox
    Public WithEvents _chkSensor_5 As System.Windows.Forms.CheckBox
    Public WithEvents _chkSensor_6 As System.Windows.Forms.CheckBox
    Public WithEvents _chkSensor_7 As System.Windows.Forms.CheckBox
    Public WithEvents _chkSensor_8 As System.Windows.Forms.CheckBox
    Public WithEvents _chkSensor_10 As System.Windows.Forms.CheckBox
    Public WithEvents _chkSensor_9 As System.Windows.Forms.CheckBox
    Public WithEvents Label10 As System.Windows.Forms.Label
    Public WithEvents Frame1 As System.Windows.Forms.GroupBox
    Public WithEvents txtMass As System.Windows.Forms.TextBox
    Public WithEvents tLogintvl As System.Windows.Forms.TextBox
    Public WithEvents minTPS As System.Windows.Forms.TextBox
    Public WithEvents chkDLEnable As System.Windows.Forms.CheckBox
    Public WithEvents lblMass As System.Windows.Forms.Label
    Public WithEvents Label13 As System.Windows.Forms.Label
    Public WithEvents Label12 As System.Windows.Forms.Label
    Public WithEvents Frame2 As System.Windows.Forms.GroupBox
    Friend WithEvents pbo2 As System.Windows.Forms.ProgressBar
    Public WithEvents tMAP As System.Windows.Forms.TextBox
    Public WithEvents tRPM As System.Windows.Forms.TextBox
    Public WithEvents lMAP As System.Windows.Forms.Label
    Public WithEvents Label9 As System.Windows.Forms.Label
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents Frame3 As System.Windows.Forms.GroupBox
    Public WithEvents tIAT As System.Windows.Forms.TextBox
    Public WithEvents tECT As System.Windows.Forms.TextBox
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents Frame5 As System.Windows.Forms.GroupBox
    Public WithEvents tTPS As System.Windows.Forms.TextBox
    Public WithEvents tVSS As System.Windows.Forms.TextBox
    Public WithEvents Label15 As System.Windows.Forms.Label
    Public WithEvents Label6 As System.Windows.Forms.Label
    Public WithEvents Label7 As System.Windows.Forms.Label
    Public WithEvents cmdClearLog As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents LoggingGrid As AxMSFlexGridLib.AxMSFlexGrid
    Public WithEvents chkLogData As System.Windows.Forms.CheckBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtVTEC As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmDatalog))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me._chkSensor_1 = New System.Windows.Forms.CheckBox
        Me._chkSensor_2 = New System.Windows.Forms.CheckBox
        Me._chkSensor_3 = New System.Windows.Forms.CheckBox
        Me._chkSensor_4 = New System.Windows.Forms.CheckBox
        Me._chkSensor_5 = New System.Windows.Forms.CheckBox
        Me._chkSensor_6 = New System.Windows.Forms.CheckBox
        Me._chkSensor_7 = New System.Windows.Forms.CheckBox
        Me._chkSensor_8 = New System.Windows.Forms.CheckBox
        Me._chkSensor_10 = New System.Windows.Forms.CheckBox
        Me._chkSensor_9 = New System.Windows.Forms.CheckBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Frame1 = New System.Windows.Forms.GroupBox
        Me.chkLogData = New System.Windows.Forms.CheckBox
        Me.cmdClearLog = New System.Windows.Forms.Button
        Me.txtMass = New System.Windows.Forms.TextBox
        Me.tLogintvl = New System.Windows.Forms.TextBox
        Me.minTPS = New System.Windows.Forms.TextBox
        Me.chkDLEnable = New System.Windows.Forms.CheckBox
        Me.lblMass = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Frame2 = New System.Windows.Forms.GroupBox
        Me.pbo2 = New System.Windows.Forms.ProgressBar
        Me.tMAP = New System.Windows.Forms.TextBox
        Me.tRPM = New System.Windows.Forms.TextBox
        Me.lMAP = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Frame3 = New System.Windows.Forms.GroupBox
        Me.tIAT = New System.Windows.Forms.TextBox
        Me.tECT = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Frame5 = New System.Windows.Forms.GroupBox
        Me.tTPS = New System.Windows.Forms.TextBox
        Me.tVSS = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.LoggingGrid = New AxMSFlexGridLib.AxMSFlexGrid
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtVTEC = New System.Windows.Forms.TextBox
        Me.GroupBox1.SuspendLayout()
        Me.Frame1.SuspendLayout()
        Me.Frame2.SuspendLayout()
        Me.Frame3.SuspendLayout()
        Me.Frame5.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.LoggingGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me._chkSensor_1)
        Me.GroupBox1.Controls.Add(Me._chkSensor_2)
        Me.GroupBox1.Controls.Add(Me._chkSensor_3)
        Me.GroupBox1.Controls.Add(Me._chkSensor_4)
        Me.GroupBox1.Controls.Add(Me._chkSensor_5)
        Me.GroupBox1.Controls.Add(Me._chkSensor_6)
        Me.GroupBox1.Controls.Add(Me._chkSensor_7)
        Me.GroupBox1.Controls.Add(Me._chkSensor_8)
        Me.GroupBox1.Controls.Add(Me._chkSensor_10)
        Me.GroupBox1.Controls.Add(Me._chkSensor_9)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(160, 200)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sensor Selection"
        '
        '_chkSensor_1
        '
        Me._chkSensor_1.BackColor = System.Drawing.SystemColors.Control
        Me._chkSensor_1.Checked = True
        Me._chkSensor_1.CheckState = System.Windows.Forms.CheckState.Checked
        Me._chkSensor_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkSensor_1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me._chkSensor_1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkSensor_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._chkSensor_1.Location = New System.Drawing.Point(8, 16)
        Me._chkSensor_1.Name = "_chkSensor_1"
        Me._chkSensor_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkSensor_1.Size = New System.Drawing.Size(104, 16)
        Me._chkSensor_1.TabIndex = 74
        Me._chkSensor_1.Tag = "7"
        Me._chkSensor_1.Text = "WATER TEMP"
        '
        '_chkSensor_2
        '
        Me._chkSensor_2.BackColor = System.Drawing.SystemColors.Control
        Me._chkSensor_2.Checked = True
        Me._chkSensor_2.CheckState = System.Windows.Forms.CheckState.Checked
        Me._chkSensor_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkSensor_2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me._chkSensor_2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkSensor_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._chkSensor_2.Location = New System.Drawing.Point(8, 32)
        Me._chkSensor_2.Name = "_chkSensor_2"
        Me._chkSensor_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkSensor_2.Size = New System.Drawing.Size(89, 17)
        Me._chkSensor_2.TabIndex = 73
        Me._chkSensor_2.Tag = "7"
        Me._chkSensor_2.Text = "AIR TEMP"
        '
        '_chkSensor_3
        '
        Me._chkSensor_3.BackColor = System.Drawing.SystemColors.Control
        Me._chkSensor_3.Checked = True
        Me._chkSensor_3.CheckState = System.Windows.Forms.CheckState.Checked
        Me._chkSensor_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkSensor_3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me._chkSensor_3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkSensor_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me._chkSensor_3.Location = New System.Drawing.Point(8, 48)
        Me._chkSensor_3.Name = "_chkSensor_3"
        Me._chkSensor_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkSensor_3.Size = New System.Drawing.Size(49, 17)
        Me._chkSensor_3.TabIndex = 72
        Me._chkSensor_3.Tag = "7"
        Me._chkSensor_3.Text = "TPS"
        '
        '_chkSensor_4
        '
        Me._chkSensor_4.BackColor = System.Drawing.SystemColors.Control
        Me._chkSensor_4.Checked = True
        Me._chkSensor_4.CheckState = System.Windows.Forms.CheckState.Checked
        Me._chkSensor_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkSensor_4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me._chkSensor_4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkSensor_4.ForeColor = System.Drawing.SystemColors.ControlText
        Me._chkSensor_4.Location = New System.Drawing.Point(8, 64)
        Me._chkSensor_4.Name = "_chkSensor_4"
        Me._chkSensor_4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkSensor_4.Size = New System.Drawing.Size(65, 17)
        Me._chkSensor_4.TabIndex = 71
        Me._chkSensor_4.Tag = "7"
        Me._chkSensor_4.Text = "SPEED"
        '
        '_chkSensor_5
        '
        Me._chkSensor_5.BackColor = System.Drawing.SystemColors.Control
        Me._chkSensor_5.Checked = True
        Me._chkSensor_5.CheckState = System.Windows.Forms.CheckState.Checked
        Me._chkSensor_5.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkSensor_5.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me._chkSensor_5.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkSensor_5.ForeColor = System.Drawing.SystemColors.ControlText
        Me._chkSensor_5.Location = New System.Drawing.Point(8, 112)
        Me._chkSensor_5.Name = "_chkSensor_5"
        Me._chkSensor_5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkSensor_5.Size = New System.Drawing.Size(97, 17)
        Me._chkSensor_5.TabIndex = 70
        Me._chkSensor_5.Tag = "7"
        Me._chkSensor_5.Text = "BOOST / VAC"
        '
        '_chkSensor_6
        '
        Me._chkSensor_6.BackColor = System.Drawing.SystemColors.Control
        Me._chkSensor_6.Checked = True
        Me._chkSensor_6.CheckState = System.Windows.Forms.CheckState.Checked
        Me._chkSensor_6.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkSensor_6.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me._chkSensor_6.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkSensor_6.ForeColor = System.Drawing.SystemColors.ControlText
        Me._chkSensor_6.Location = New System.Drawing.Point(8, 80)
        Me._chkSensor_6.Name = "_chkSensor_6"
        Me._chkSensor_6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkSensor_6.Size = New System.Drawing.Size(73, 17)
        Me._chkSensor_6.TabIndex = 69
        Me._chkSensor_6.Tag = "7"
        Me._chkSensor_6.Text = "MIXTURE"
        '
        '_chkSensor_7
        '
        Me._chkSensor_7.BackColor = System.Drawing.SystemColors.Control
        Me._chkSensor_7.Checked = True
        Me._chkSensor_7.CheckState = System.Windows.Forms.CheckState.Checked
        Me._chkSensor_7.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkSensor_7.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me._chkSensor_7.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkSensor_7.ForeColor = System.Drawing.SystemColors.ControlText
        Me._chkSensor_7.Location = New System.Drawing.Point(8, 96)
        Me._chkSensor_7.Name = "_chkSensor_7"
        Me._chkSensor_7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkSensor_7.Size = New System.Drawing.Size(49, 17)
        Me._chkSensor_7.TabIndex = 68
        Me._chkSensor_7.Tag = "7"
        Me._chkSensor_7.Text = "RPM"
        '
        '_chkSensor_8
        '
        Me._chkSensor_8.BackColor = System.Drawing.SystemColors.Control
        Me._chkSensor_8.Checked = True
        Me._chkSensor_8.CheckState = System.Windows.Forms.CheckState.Checked
        Me._chkSensor_8.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkSensor_8.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me._chkSensor_8.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkSensor_8.ForeColor = System.Drawing.SystemColors.ControlText
        Me._chkSensor_8.Location = New System.Drawing.Point(72, 96)
        Me._chkSensor_8.Name = "_chkSensor_8"
        Me._chkSensor_8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkSensor_8.Size = New System.Drawing.Size(49, 17)
        Me._chkSensor_8.TabIndex = 67
        Me._chkSensor_8.Tag = "7"
        Me._chkSensor_8.Text = "RPM"
        Me._chkSensor_8.Visible = False
        '
        '_chkSensor_10
        '
        Me._chkSensor_10.BackColor = System.Drawing.SystemColors.Control
        Me._chkSensor_10.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkSensor_10.Enabled = False
        Me._chkSensor_10.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me._chkSensor_10.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkSensor_10.ForeColor = System.Drawing.SystemColors.ControlText
        Me._chkSensor_10.Location = New System.Drawing.Point(8, 144)
        Me._chkSensor_10.Name = "_chkSensor_10"
        Me._chkSensor_10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkSensor_10.Size = New System.Drawing.Size(97, 17)
        Me._chkSensor_10.TabIndex = 66
        Me._chkSensor_10.Tag = "7"
        Me._chkSensor_10.Text = "MAP TRACE"
        Me._chkSensor_10.Visible = False
        '
        '_chkSensor_9
        '
        Me._chkSensor_9.BackColor = System.Drawing.SystemColors.Control
        Me._chkSensor_9.Checked = True
        Me._chkSensor_9.CheckState = System.Windows.Forms.CheckState.Checked
        Me._chkSensor_9.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkSensor_9.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me._chkSensor_9.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkSensor_9.ForeColor = System.Drawing.SystemColors.ControlText
        Me._chkSensor_9.Location = New System.Drawing.Point(8, 128)
        Me._chkSensor_9.Name = "_chkSensor_9"
        Me._chkSensor_9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkSensor_9.Size = New System.Drawing.Size(121, 17)
        Me._chkSensor_9.TabIndex = 65
        Me._chkSensor_9.Tag = "7"
        Me._chkSensor_9.Text = "VTEC"
        Me._chkSensor_9.Visible = False
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.SystemColors.Control
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label10.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label10.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label10.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(120, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label10.Size = New System.Drawing.Size(17, 17)
        Me.Label10.TabIndex = 75
        Me.Label10.Visible = False
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.Controls.Add(Me.chkLogData)
        Me.Frame1.Controls.Add(Me.cmdClearLog)
        Me.Frame1.Controls.Add(Me.txtMass)
        Me.Frame1.Controls.Add(Me.tLogintvl)
        Me.Frame1.Controls.Add(Me.minTPS)
        Me.Frame1.Controls.Add(Me.chkDLEnable)
        Me.Frame1.Controls.Add(Me.lblMass)
        Me.Frame1.Controls.Add(Me.Label13)
        Me.Frame1.Controls.Add(Me.Label12)
        Me.Frame1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Frame1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(176, 8)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(201, 89)
        Me.Frame1.TabIndex = 35
        Me.Frame1.TabStop = False
        Me.Frame1.Text = "Options:"
        '
        'chkLogData
        '
        Me.chkLogData.BackColor = System.Drawing.SystemColors.Control
        Me.chkLogData.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkLogData.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.chkLogData.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkLogData.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkLogData.Location = New System.Drawing.Point(128, 16)
        Me.chkLogData.Name = "chkLogData"
        Me.chkLogData.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkLogData.Size = New System.Drawing.Size(65, 17)
        Me.chkLogData.TabIndex = 110
        Me.chkLogData.Text = "Log Data"
        '
        'cmdClearLog
        '
        Me.cmdClearLog.BackColor = System.Drawing.SystemColors.Control
        Me.cmdClearLog.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdClearLog.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmdClearLog.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClearLog.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdClearLog.Location = New System.Drawing.Point(120, 52)
        Me.cmdClearLog.Name = "cmdClearLog"
        Me.cmdClearLog.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdClearLog.Size = New System.Drawing.Size(73, 32)
        Me.cmdClearLog.TabIndex = 109
        Me.cmdClearLog.Text = "Clear Log"
        '
        'txtMass
        '
        Me.txtMass.AcceptsReturn = True
        Me.txtMass.AutoSize = False
        Me.txtMass.BackColor = System.Drawing.SystemColors.Window
        Me.txtMass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMass.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMass.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtMass.Location = New System.Drawing.Point(8, 16)
        Me.txtMass.MaxLength = 0
        Me.txtMass.Name = "txtMass"
        Me.txtMass.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtMass.Size = New System.Drawing.Size(41, 19)
        Me.txtMass.TabIndex = 74
        Me.txtMass.Text = "2100"
        '
        'tLogintvl
        '
        Me.tLogintvl.AcceptsReturn = True
        Me.tLogintvl.AutoSize = False
        Me.tLogintvl.BackColor = System.Drawing.SystemColors.Window
        Me.tLogintvl.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tLogintvl.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tLogintvl.ForeColor = System.Drawing.SystemColors.WindowText
        Me.tLogintvl.Location = New System.Drawing.Point(8, 40)
        Me.tLogintvl.MaxLength = 0
        Me.tLogintvl.Name = "tLogintvl"
        Me.tLogintvl.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tLogintvl.Size = New System.Drawing.Size(41, 19)
        Me.tLogintvl.TabIndex = 37
        Me.tLogintvl.Text = "30"
        '
        'minTPS
        '
        Me.minTPS.AcceptsReturn = True
        Me.minTPS.AutoSize = False
        Me.minTPS.BackColor = System.Drawing.SystemColors.Window
        Me.minTPS.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.minTPS.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.minTPS.ForeColor = System.Drawing.SystemColors.WindowText
        Me.minTPS.Location = New System.Drawing.Point(8, 64)
        Me.minTPS.MaxLength = 0
        Me.minTPS.Name = "minTPS"
        Me.minTPS.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.minTPS.Size = New System.Drawing.Size(41, 19)
        Me.minTPS.TabIndex = 36
        Me.minTPS.Text = "20"
        '
        'chkDLEnable
        '
        Me.chkDLEnable.BackColor = System.Drawing.SystemColors.Control
        Me.chkDLEnable.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkDLEnable.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.chkDLEnable.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDLEnable.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkDLEnable.Location = New System.Drawing.Point(128, 32)
        Me.chkDLEnable.Name = "chkDLEnable"
        Me.chkDLEnable.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkDLEnable.Size = New System.Drawing.Size(65, 17)
        Me.chkDLEnable.TabIndex = 35
        Me.chkDLEnable.Text = "Log File"
        '
        'lblMass
        '
        Me.lblMass.BackColor = System.Drawing.SystemColors.Control
        Me.lblMass.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblMass.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lblMass.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMass.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblMass.Location = New System.Drawing.Point(56, 16)
        Me.lblMass.Name = "lblMass"
        Me.lblMass.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblMass.Size = New System.Drawing.Size(88, 17)
        Me.lblMass.TabIndex = 75
        Me.lblMass.Text = "Car Mass (lbs)"
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.SystemColors.Control
        Me.Label13.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label13.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label13.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label13.Location = New System.Drawing.Point(56, 40)
        Me.Label13.Name = "Label13"
        Me.Label13.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label13.Size = New System.Drawing.Size(80, 17)
        Me.Label13.TabIndex = 39
        Me.Label13.Text = "Log Int (ms)"
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.SystemColors.Control
        Me.Label12.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label12.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label12.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label12.Location = New System.Drawing.Point(56, 64)
        Me.Label12.Name = "Label12"
        Me.Label12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label12.Size = New System.Drawing.Size(49, 17)
        Me.Label12.TabIndex = 38
        Me.Label12.Text = "Min TPS"
        '
        'Frame2
        '
        Me.Frame2.BackColor = System.Drawing.SystemColors.Control
        Me.Frame2.Controls.Add(Me.pbo2)
        Me.Frame2.Controls.Add(Me.tMAP)
        Me.Frame2.Controls.Add(Me.tRPM)
        Me.Frame2.Controls.Add(Me.lMAP)
        Me.Frame2.Controls.Add(Me.Label9)
        Me.Frame2.Controls.Add(Me.Label1)
        Me.Frame2.Controls.Add(Me.Label3)
        Me.Frame2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Frame2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame2.Location = New System.Drawing.Point(176, 104)
        Me.Frame2.Name = "Frame2"
        Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame2.Size = New System.Drawing.Size(200, 104)
        Me.Frame2.TabIndex = 36
        Me.Frame2.TabStop = False
        Me.Frame2.Text = "Tuning Sensors:"
        '
        'pbo2
        '
        Me.pbo2.Location = New System.Drawing.Point(16, 40)
        Me.pbo2.Name = "pbo2"
        Me.pbo2.Size = New System.Drawing.Size(168, 16)
        Me.pbo2.TabIndex = 72
        '
        'tMAP
        '
        Me.tMAP.AcceptsReturn = True
        Me.tMAP.AutoSize = False
        Me.tMAP.BackColor = System.Drawing.SystemColors.Window
        Me.tMAP.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tMAP.Enabled = False
        Me.tMAP.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tMAP.ForeColor = System.Drawing.SystemColors.WindowText
        Me.tMAP.Location = New System.Drawing.Point(16, 72)
        Me.tMAP.MaxLength = 0
        Me.tMAP.Name = "tMAP"
        Me.tMAP.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tMAP.Size = New System.Drawing.Size(41, 19)
        Me.tMAP.TabIndex = 69
        Me.tMAP.Text = ""
        '
        'tRPM
        '
        Me.tRPM.AcceptsReturn = True
        Me.tRPM.AutoSize = False
        Me.tRPM.BackColor = System.Drawing.SystemColors.Window
        Me.tRPM.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tRPM.Enabled = False
        Me.tRPM.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tRPM.ForeColor = System.Drawing.SystemColors.WindowText
        Me.tRPM.Location = New System.Drawing.Point(144, 72)
        Me.tRPM.MaxLength = 0
        Me.tRPM.Name = "tRPM"
        Me.tRPM.ReadOnly = True
        Me.tRPM.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tRPM.Size = New System.Drawing.Size(41, 19)
        Me.tRPM.TabIndex = 20
        Me.tRPM.Text = ""
        Me.tRPM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lMAP
        '
        Me.lMAP.BackColor = System.Drawing.SystemColors.Control
        Me.lMAP.Cursor = System.Windows.Forms.Cursors.Default
        Me.lMAP.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lMAP.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lMAP.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lMAP.Location = New System.Drawing.Point(64, 72)
        Me.lMAP.Name = "lMAP"
        Me.lMAP.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lMAP.Size = New System.Drawing.Size(41, 19)
        Me.lMAP.TabIndex = 71
        Me.lMAP.Text = "In/Hg"
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.SystemColors.Control
        Me.Label9.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label9.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(16, 56)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label9.Size = New System.Drawing.Size(29, 13)
        Me.Label9.TabIndex = 70
        Me.Label9.Text = "MAP"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(144, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(32, 19)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "RPM"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(16, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(172, 16)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "| Lean  |        Stoich        |    Rich   |"
        '
        'Frame3
        '
        Me.Frame3.BackColor = System.Drawing.SystemColors.Control
        Me.Frame3.Controls.Add(Me.tIAT)
        Me.Frame3.Controls.Add(Me.tECT)
        Me.Frame3.Controls.Add(Me.Label4)
        Me.Frame3.Controls.Add(Me.Label5)
        Me.Frame3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Frame3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame3.Location = New System.Drawing.Point(384, 8)
        Me.Frame3.Name = "Frame3"
        Me.Frame3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame3.Size = New System.Drawing.Size(168, 89)
        Me.Frame3.TabIndex = 37
        Me.Frame3.TabStop = False
        Me.Frame3.Text = "Temperature Sensors:"
        '
        'tIAT
        '
        Me.tIAT.AcceptsReturn = True
        Me.tIAT.AutoSize = False
        Me.tIAT.BackColor = System.Drawing.SystemColors.Window
        Me.tIAT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tIAT.Enabled = False
        Me.tIAT.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tIAT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.tIAT.Location = New System.Drawing.Point(88, 24)
        Me.tIAT.MaxLength = 0
        Me.tIAT.Name = "tIAT"
        Me.tIAT.ReadOnly = True
        Me.tIAT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tIAT.Size = New System.Drawing.Size(41, 19)
        Me.tIAT.TabIndex = 25
        Me.tIAT.Text = ""
        Me.tIAT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tECT
        '
        Me.tECT.AcceptsReturn = True
        Me.tECT.AutoSize = False
        Me.tECT.BackColor = System.Drawing.SystemColors.Window
        Me.tECT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tECT.Enabled = False
        Me.tECT.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tECT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.tECT.Location = New System.Drawing.Point(88, 56)
        Me.tECT.MaxLength = 0
        Me.tECT.Name = "tECT"
        Me.tECT.ReadOnly = True
        Me.tECT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tECT.Size = New System.Drawing.Size(41, 19)
        Me.tECT.TabIndex = 24
        Me.tECT.Text = ""
        Me.tECT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(8, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(89, 17)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Intake Manifold"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(8, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(81, 17)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Engine Coolant"
        '
        'Frame5
        '
        Me.Frame5.BackColor = System.Drawing.SystemColors.Control
        Me.Frame5.Controls.Add(Me.txtVTEC)
        Me.Frame5.Controls.Add(Me.Label2)
        Me.Frame5.Controls.Add(Me.tTPS)
        Me.Frame5.Controls.Add(Me.tVSS)
        Me.Frame5.Controls.Add(Me.Label15)
        Me.Frame5.Controls.Add(Me.Label6)
        Me.Frame5.Controls.Add(Me.Label7)
        Me.Frame5.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Frame5.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame5.Location = New System.Drawing.Point(384, 104)
        Me.Frame5.Name = "Frame5"
        Me.Frame5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame5.Size = New System.Drawing.Size(169, 104)
        Me.Frame5.TabIndex = 38
        Me.Frame5.TabStop = False
        Me.Frame5.Text = "Misc. Sensors:"
        '
        'tTPS
        '
        Me.tTPS.AcceptsReturn = True
        Me.tTPS.AutoSize = False
        Me.tTPS.BackColor = System.Drawing.SystemColors.Window
        Me.tTPS.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tTPS.Enabled = False
        Me.tTPS.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tTPS.ForeColor = System.Drawing.SystemColors.WindowText
        Me.tTPS.Location = New System.Drawing.Point(48, 16)
        Me.tTPS.MaxLength = 0
        Me.tTPS.Name = "tTPS"
        Me.tTPS.ReadOnly = True
        Me.tTPS.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tTPS.Size = New System.Drawing.Size(56, 19)
        Me.tTPS.TabIndex = 30
        Me.tTPS.Text = ""
        Me.tTPS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tVSS
        '
        Me.tVSS.AcceptsReturn = True
        Me.tVSS.AutoSize = False
        Me.tVSS.BackColor = System.Drawing.SystemColors.Window
        Me.tVSS.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tVSS.Enabled = False
        Me.tVSS.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tVSS.ForeColor = System.Drawing.SystemColors.WindowText
        Me.tVSS.Location = New System.Drawing.Point(48, 40)
        Me.tVSS.MaxLength = 0
        Me.tVSS.Name = "tVSS"
        Me.tVSS.ReadOnly = True
        Me.tVSS.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tVSS.Size = New System.Drawing.Size(56, 19)
        Me.tVSS.TabIndex = 29
        Me.tVSS.Text = ""
        Me.tVSS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.SystemColors.Control
        Me.Label15.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label15.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label15.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label15.Location = New System.Drawing.Point(104, 16)
        Me.Label15.Name = "Label15"
        Me.Label15.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label15.Size = New System.Drawing.Size(17, 17)
        Me.Label15.TabIndex = 72
        Me.Label15.Text = "%"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(24, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(25, 16)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "TPS"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.Control
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label7.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(16, 40)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(41, 16)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "SPEED"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LoggingGrid)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox2.Location = New System.Drawing.Point(8, 208)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(544, 360)
        Me.GroupBox2.TabIndex = 39
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Data Log"
        '
        'LoggingGrid
        '
        Me.LoggingGrid.ContainingControl = Me
        Me.LoggingGrid.Location = New System.Drawing.Point(8, 16)
        Me.LoggingGrid.Name = "LoggingGrid"
        Me.LoggingGrid.OcxState = CType(resources.GetObject("LoggingGrid.OcxState"), System.Windows.Forms.AxHost.State)
        Me.LoggingGrid.Size = New System.Drawing.Size(528, 336)
        Me.LoggingGrid.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(16, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 16)
        Me.Label2.TabIndex = 103
        Me.Label2.Text = "VTEC"
        '
        'txtVTEC
        '
        Me.txtVTEC.Cursor = System.Windows.Forms.Cursors.No
        Me.txtVTEC.Enabled = False
        Me.txtVTEC.Location = New System.Drawing.Point(48, 64)
        Me.txtVTEC.Name = "txtVTEC"
        Me.txtVTEC.Size = New System.Drawing.Size(56, 20)
        Me.txtVTEC.TabIndex = 104
        Me.txtVTEC.Text = "VTEC Off"
        '
        'frmDatalog
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(560, 574)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Frame5)
        Me.Controls.Add(Me.Frame3)
        Me.Controls.Add(Me.Frame2)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.GroupBox1)
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmDatalog"
        Me.Text = "DataLog"
        Me.GroupBox1.ResumeLayout(False)
        Me.Frame1.ResumeLayout(False)
        Me.Frame2.ResumeLayout(False)
        Me.Frame3.ResumeLayout(False)
        Me.Frame5.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.LoggingGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub cmdClearLog_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClearLog.Click
        frmDatalog.DefInstance.LoggingGrid.Clear()
        frmDatalog.DefInstance.LoggingGrid.Rows = 2
        General.InitDatalogGrid()
    End Sub
    Private Sub frmDatalog_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        General.InitDatalogGrid()
    End Sub
    Private Sub chkLogData_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkLogData.CheckedChanged
        If chkLogData.Checked = True Then
            General.LogData = True
        Else
            General.LogData = False
        End If
    End Sub
End Class
