Imports Microsoft.Win32 'so we can access registry
Imports System.Drawing.Drawing2D
Public Class frmMain
    Inherits System.Windows.Forms.Form
    Private Shared m_vb6FormDefInstance As frmMain
    Private Shared m_InitializingDefInstance As Boolean
    Public WithEvents moRS232 As Rs232
    Private Delegate Sub CommEventUpdate(ByVal source As Rs232, ByVal mask As Rs232.EventMasks)
    Public I As Integer = 0
    Dim cmd As String
    Dim rpmlo As Integer
    Dim rpmhi As Integer
    Public Retries As Integer = 0
    Public SensorCount As Integer = 0
    Public Sensor(9) As Integer
    Public tOut As Integer
    Public buffer As Integer
    Public bBuffer() As Byte
    Public bRate As Integer = 38400
    Public cPort As Integer = 1
    Public dBit As Integer = 8
    Public datalog As Boolean = False 'keep track of whether or not we want to datalog
    Public dRcvd As Boolean = False
    Public wait As Boolean = False
#Region "Enable XP Styles"
    Shared Sub Main()
        Application.EnableVisualStyles() 'enable the XP style drawing on the controls
        Application.DoEvents() 'finish processing all messages before starting new form with XP styles
        Application.Run(New frmMain) ' start new form with Xp Styles


    End Sub
#End Region
#Region " Windows Form Designer generated code "

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
    Friend WithEvents mnuFile As System.Windows.Forms.MenuItem
    Friend WithEvents mnuExit As System.Windows.Forms.MenuItem
    Friend WithEvents mnuSettings As System.Windows.Forms.MenuItem
    Friend WithEvents mnuEcuType As System.Windows.Forms.MenuItem
    Friend WithEvents mnuComport As System.Windows.Forms.MenuItem
    Friend WithEvents mnuGearCorrection As System.Windows.Forms.MenuItem
    Friend WithEvents mnuRTP As System.Windows.Forms.MenuItem
    Friend WithEvents mnuWindows As System.Windows.Forms.MenuItem
    Friend WithEvents mnuHelp As System.Windows.Forms.MenuItem
    Friend WithEvents mnuNG55 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuRTPOBD0 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuRTPOBD1 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuDatalogging As System.Windows.Forms.MenuItem
    Friend WithEvents mnuWRTP As System.Windows.Forms.MenuItem
    Friend WithEvents mnuHPT As System.Windows.Forms.MenuItem
    Friend WithEvents mnuGagues As System.Windows.Forms.MenuItem
    Friend WithEvents mnuAbout As System.Windows.Forms.MenuItem
    Public WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents StatusBar1 As System.Windows.Forms.StatusBar
    Friend WithEvents mnuCom1 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuCom2 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuCom3 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuCom4 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuCom5 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuCom6 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuCom7 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuCom8 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuConnect As System.Windows.Forms.MenuItem
    Friend WithEvents mnuStartLogging As System.Windows.Forms.MenuItem
    Friend WithEvents mnuEcu As System.Windows.Forms.MenuItem
    Friend WithEvents mnuTimeout As System.Windows.Forms.MenuItem
    Friend WithEvents mnu100ms As System.Windows.Forms.MenuItem
    Friend WithEvents mnu150ms As System.Windows.Forms.MenuItem
    Friend WithEvents mnu200ms As System.Windows.Forms.MenuItem
    Friend WithEvents mnu250ms As System.Windows.Forms.MenuItem
    Friend WithEvents mnu300ms As System.Windows.Forms.MenuItem
    Friend WithEvents mnu350ms As System.Windows.Forms.MenuItem
    Friend WithEvents mnu400ms As System.Windows.Forms.MenuItem
    Friend WithEvents mnu450ms As System.Windows.Forms.MenuItem
    Friend WithEvents mnu500ms As System.Windows.Forms.MenuItem
    Friend WithEvents toTimer As System.Windows.Forms.Timer
    Friend WithEvents DebugBox As System.Windows.Forms.ListBox
    Friend WithEvents mnuShowDebugInfo As System.Windows.Forms.MenuItem
    Friend WithEvents mnuOBD0 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuOBD1 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuO2Type As System.Windows.Forms.MenuItem
    Friend WithEvents mnuStockO2 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuPlxO2 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuMapSensor As System.Windows.Forms.MenuItem
    Friend WithEvents mnuStockMap As System.Windows.Forms.MenuItem
    Friend WithEvents mnuGM2Bar As System.Windows.Forms.MenuItem
    Friend WithEvents mnuGM3Bar As System.Windows.Forms.MenuItem
    Friend WithEvents mnuLM1 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuStandard As System.Windows.Forms.MenuItem
    Friend WithEvents mnuMetric As System.Windows.Forms.MenuItem
    Friend WithEvents mnuSAE As System.Windows.Forms.MenuItem
    Friend WithEvents BackGroundPic As System.Windows.Forms.PictureBox
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuGuageDigital As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmMain))
        Me.MainMenu1 = New System.Windows.Forms.MainMenu
        Me.mnuFile = New System.Windows.Forms.MenuItem
        Me.mnuExit = New System.Windows.Forms.MenuItem
        Me.mnuSettings = New System.Windows.Forms.MenuItem
        Me.mnuComport = New System.Windows.Forms.MenuItem
        Me.mnuCom1 = New System.Windows.Forms.MenuItem
        Me.mnuCom2 = New System.Windows.Forms.MenuItem
        Me.mnuCom3 = New System.Windows.Forms.MenuItem
        Me.mnuCom4 = New System.Windows.Forms.MenuItem
        Me.mnuCom5 = New System.Windows.Forms.MenuItem
        Me.mnuCom6 = New System.Windows.Forms.MenuItem
        Me.mnuCom7 = New System.Windows.Forms.MenuItem
        Me.mnuCom8 = New System.Windows.Forms.MenuItem
        Me.mnuTimeout = New System.Windows.Forms.MenuItem
        Me.mnu100ms = New System.Windows.Forms.MenuItem
        Me.mnu150ms = New System.Windows.Forms.MenuItem
        Me.mnu200ms = New System.Windows.Forms.MenuItem
        Me.mnu250ms = New System.Windows.Forms.MenuItem
        Me.mnu300ms = New System.Windows.Forms.MenuItem
        Me.mnu350ms = New System.Windows.Forms.MenuItem
        Me.mnu400ms = New System.Windows.Forms.MenuItem
        Me.mnu450ms = New System.Windows.Forms.MenuItem
        Me.mnu500ms = New System.Windows.Forms.MenuItem
        Me.mnuStandard = New System.Windows.Forms.MenuItem
        Me.mnuMetric = New System.Windows.Forms.MenuItem
        Me.mnuSAE = New System.Windows.Forms.MenuItem
        Me.mnuO2Type = New System.Windows.Forms.MenuItem
        Me.mnuStockO2 = New System.Windows.Forms.MenuItem
        Me.mnuPlxO2 = New System.Windows.Forms.MenuItem
        Me.mnuLM1 = New System.Windows.Forms.MenuItem
        Me.mnuMapSensor = New System.Windows.Forms.MenuItem
        Me.mnuStockMap = New System.Windows.Forms.MenuItem
        Me.mnuGM2Bar = New System.Windows.Forms.MenuItem
        Me.mnuGM3Bar = New System.Windows.Forms.MenuItem
        Me.mnuGearCorrection = New System.Windows.Forms.MenuItem
        Me.mnuEcuType = New System.Windows.Forms.MenuItem
        Me.mnuNG55 = New System.Windows.Forms.MenuItem
        Me.mnuOBD0 = New System.Windows.Forms.MenuItem
        Me.mnuOBD1 = New System.Windows.Forms.MenuItem
        Me.mnuEcu = New System.Windows.Forms.MenuItem
        Me.mnuConnect = New System.Windows.Forms.MenuItem
        Me.mnuStartLogging = New System.Windows.Forms.MenuItem
        Me.mnuRTP = New System.Windows.Forms.MenuItem
        Me.mnuRTPOBD0 = New System.Windows.Forms.MenuItem
        Me.mnuRTPOBD1 = New System.Windows.Forms.MenuItem
        Me.mnuWindows = New System.Windows.Forms.MenuItem
        Me.mnuDatalogging = New System.Windows.Forms.MenuItem
        Me.mnuWRTP = New System.Windows.Forms.MenuItem
        Me.mnuHPT = New System.Windows.Forms.MenuItem
        Me.mnuGagues = New System.Windows.Forms.MenuItem
        Me.mnuGuageDigital = New System.Windows.Forms.MenuItem
        Me.mnuHelp = New System.Windows.Forms.MenuItem
        Me.mnuAbout = New System.Windows.Forms.MenuItem
        Me.mnuShowDebugInfo = New System.Windows.Forms.MenuItem
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.StatusBar1 = New System.Windows.Forms.StatusBar
        Me.toTimer = New System.Windows.Forms.Timer(Me.components)
        Me.DebugBox = New System.Windows.Forms.ListBox
        Me.BackGroundPic = New System.Windows.Forms.PictureBox
        Me.SuspendLayout()
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuFile, Me.mnuSettings, Me.mnuEcuType, Me.mnuEcu, Me.mnuRTP, Me.mnuWindows, Me.mnuHelp})
        Me.MainMenu1.RightToLeft = CType(resources.GetObject("MainMenu1.RightToLeft"), System.Windows.Forms.RightToLeft)
        '
        'mnuFile
        '
        Me.mnuFile.Enabled = CType(resources.GetObject("mnuFile.Enabled"), Boolean)
        Me.mnuFile.Index = 0
        Me.mnuFile.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuExit})
        Me.mnuFile.Shortcut = CType(resources.GetObject("mnuFile.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnuFile.ShowShortcut = CType(resources.GetObject("mnuFile.ShowShortcut"), Boolean)
        Me.mnuFile.Text = resources.GetString("mnuFile.Text")
        Me.mnuFile.Visible = CType(resources.GetObject("mnuFile.Visible"), Boolean)
        '
        'mnuExit
        '
        Me.mnuExit.Enabled = CType(resources.GetObject("mnuExit.Enabled"), Boolean)
        Me.mnuExit.Index = 0
        Me.mnuExit.Shortcut = CType(resources.GetObject("mnuExit.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnuExit.ShowShortcut = CType(resources.GetObject("mnuExit.ShowShortcut"), Boolean)
        Me.mnuExit.Text = resources.GetString("mnuExit.Text")
        Me.mnuExit.Visible = CType(resources.GetObject("mnuExit.Visible"), Boolean)
        '
        'mnuSettings
        '
        Me.mnuSettings.Enabled = CType(resources.GetObject("mnuSettings.Enabled"), Boolean)
        Me.mnuSettings.Index = 1
        Me.mnuSettings.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuComport, Me.mnuStandard, Me.mnuO2Type, Me.mnuMapSensor, Me.mnuGearCorrection})
        Me.mnuSettings.Shortcut = CType(resources.GetObject("mnuSettings.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnuSettings.ShowShortcut = CType(resources.GetObject("mnuSettings.ShowShortcut"), Boolean)
        Me.mnuSettings.Text = resources.GetString("mnuSettings.Text")
        Me.mnuSettings.Visible = CType(resources.GetObject("mnuSettings.Visible"), Boolean)
        '
        'mnuComport
        '
        Me.mnuComport.Enabled = CType(resources.GetObject("mnuComport.Enabled"), Boolean)
        Me.mnuComport.Index = 0
        Me.mnuComport.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuCom1, Me.mnuCom2, Me.mnuCom3, Me.mnuCom4, Me.mnuCom5, Me.mnuCom6, Me.mnuCom7, Me.mnuCom8, Me.mnuTimeout})
        Me.mnuComport.Shortcut = CType(resources.GetObject("mnuComport.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnuComport.ShowShortcut = CType(resources.GetObject("mnuComport.ShowShortcut"), Boolean)
        Me.mnuComport.Text = resources.GetString("mnuComport.Text")
        Me.mnuComport.Visible = CType(resources.GetObject("mnuComport.Visible"), Boolean)
        '
        'mnuCom1
        '
        Me.mnuCom1.Enabled = CType(resources.GetObject("mnuCom1.Enabled"), Boolean)
        Me.mnuCom1.Index = 0
        Me.mnuCom1.Shortcut = CType(resources.GetObject("mnuCom1.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnuCom1.ShowShortcut = CType(resources.GetObject("mnuCom1.ShowShortcut"), Boolean)
        Me.mnuCom1.Text = resources.GetString("mnuCom1.Text")
        Me.mnuCom1.Visible = CType(resources.GetObject("mnuCom1.Visible"), Boolean)
        '
        'mnuCom2
        '
        Me.mnuCom2.Enabled = CType(resources.GetObject("mnuCom2.Enabled"), Boolean)
        Me.mnuCom2.Index = 1
        Me.mnuCom2.Shortcut = CType(resources.GetObject("mnuCom2.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnuCom2.ShowShortcut = CType(resources.GetObject("mnuCom2.ShowShortcut"), Boolean)
        Me.mnuCom2.Text = resources.GetString("mnuCom2.Text")
        Me.mnuCom2.Visible = CType(resources.GetObject("mnuCom2.Visible"), Boolean)
        '
        'mnuCom3
        '
        Me.mnuCom3.Enabled = CType(resources.GetObject("mnuCom3.Enabled"), Boolean)
        Me.mnuCom3.Index = 2
        Me.mnuCom3.Shortcut = CType(resources.GetObject("mnuCom3.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnuCom3.ShowShortcut = CType(resources.GetObject("mnuCom3.ShowShortcut"), Boolean)
        Me.mnuCom3.Text = resources.GetString("mnuCom3.Text")
        Me.mnuCom3.Visible = CType(resources.GetObject("mnuCom3.Visible"), Boolean)
        '
        'mnuCom4
        '
        Me.mnuCom4.Enabled = CType(resources.GetObject("mnuCom4.Enabled"), Boolean)
        Me.mnuCom4.Index = 3
        Me.mnuCom4.Shortcut = CType(resources.GetObject("mnuCom4.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnuCom4.ShowShortcut = CType(resources.GetObject("mnuCom4.ShowShortcut"), Boolean)
        Me.mnuCom4.Text = resources.GetString("mnuCom4.Text")
        Me.mnuCom4.Visible = CType(resources.GetObject("mnuCom4.Visible"), Boolean)
        '
        'mnuCom5
        '
        Me.mnuCom5.Enabled = CType(resources.GetObject("mnuCom5.Enabled"), Boolean)
        Me.mnuCom5.Index = 4
        Me.mnuCom5.Shortcut = CType(resources.GetObject("mnuCom5.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnuCom5.ShowShortcut = CType(resources.GetObject("mnuCom5.ShowShortcut"), Boolean)
        Me.mnuCom5.Text = resources.GetString("mnuCom5.Text")
        Me.mnuCom5.Visible = CType(resources.GetObject("mnuCom5.Visible"), Boolean)
        '
        'mnuCom6
        '
        Me.mnuCom6.Enabled = CType(resources.GetObject("mnuCom6.Enabled"), Boolean)
        Me.mnuCom6.Index = 5
        Me.mnuCom6.Shortcut = CType(resources.GetObject("mnuCom6.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnuCom6.ShowShortcut = CType(resources.GetObject("mnuCom6.ShowShortcut"), Boolean)
        Me.mnuCom6.Text = resources.GetString("mnuCom6.Text")
        Me.mnuCom6.Visible = CType(resources.GetObject("mnuCom6.Visible"), Boolean)
        '
        'mnuCom7
        '
        Me.mnuCom7.Enabled = CType(resources.GetObject("mnuCom7.Enabled"), Boolean)
        Me.mnuCom7.Index = 6
        Me.mnuCom7.Shortcut = CType(resources.GetObject("mnuCom7.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnuCom7.ShowShortcut = CType(resources.GetObject("mnuCom7.ShowShortcut"), Boolean)
        Me.mnuCom7.Text = resources.GetString("mnuCom7.Text")
        Me.mnuCom7.Visible = CType(resources.GetObject("mnuCom7.Visible"), Boolean)
        '
        'mnuCom8
        '
        Me.mnuCom8.Enabled = CType(resources.GetObject("mnuCom8.Enabled"), Boolean)
        Me.mnuCom8.Index = 7
        Me.mnuCom8.Shortcut = CType(resources.GetObject("mnuCom8.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnuCom8.ShowShortcut = CType(resources.GetObject("mnuCom8.ShowShortcut"), Boolean)
        Me.mnuCom8.Text = resources.GetString("mnuCom8.Text")
        Me.mnuCom8.Visible = CType(resources.GetObject("mnuCom8.Visible"), Boolean)
        '
        'mnuTimeout
        '
        Me.mnuTimeout.Enabled = CType(resources.GetObject("mnuTimeout.Enabled"), Boolean)
        Me.mnuTimeout.Index = 8
        Me.mnuTimeout.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnu100ms, Me.mnu150ms, Me.mnu200ms, Me.mnu250ms, Me.mnu300ms, Me.mnu350ms, Me.mnu400ms, Me.mnu450ms, Me.mnu500ms})
        Me.mnuTimeout.Shortcut = CType(resources.GetObject("mnuTimeout.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnuTimeout.ShowShortcut = CType(resources.GetObject("mnuTimeout.ShowShortcut"), Boolean)
        Me.mnuTimeout.Text = resources.GetString("mnuTimeout.Text")
        Me.mnuTimeout.Visible = CType(resources.GetObject("mnuTimeout.Visible"), Boolean)
        '
        'mnu100ms
        '
        Me.mnu100ms.Checked = True
        Me.mnu100ms.Enabled = CType(resources.GetObject("mnu100ms.Enabled"), Boolean)
        Me.mnu100ms.Index = 0
        Me.mnu100ms.Shortcut = CType(resources.GetObject("mnu100ms.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnu100ms.ShowShortcut = CType(resources.GetObject("mnu100ms.ShowShortcut"), Boolean)
        Me.mnu100ms.Text = resources.GetString("mnu100ms.Text")
        Me.mnu100ms.Visible = CType(resources.GetObject("mnu100ms.Visible"), Boolean)
        '
        'mnu150ms
        '
        Me.mnu150ms.Enabled = CType(resources.GetObject("mnu150ms.Enabled"), Boolean)
        Me.mnu150ms.Index = 1
        Me.mnu150ms.Shortcut = CType(resources.GetObject("mnu150ms.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnu150ms.ShowShortcut = CType(resources.GetObject("mnu150ms.ShowShortcut"), Boolean)
        Me.mnu150ms.Text = resources.GetString("mnu150ms.Text")
        Me.mnu150ms.Visible = CType(resources.GetObject("mnu150ms.Visible"), Boolean)
        '
        'mnu200ms
        '
        Me.mnu200ms.Enabled = CType(resources.GetObject("mnu200ms.Enabled"), Boolean)
        Me.mnu200ms.Index = 2
        Me.mnu200ms.Shortcut = CType(resources.GetObject("mnu200ms.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnu200ms.ShowShortcut = CType(resources.GetObject("mnu200ms.ShowShortcut"), Boolean)
        Me.mnu200ms.Text = resources.GetString("mnu200ms.Text")
        Me.mnu200ms.Visible = CType(resources.GetObject("mnu200ms.Visible"), Boolean)
        '
        'mnu250ms
        '
        Me.mnu250ms.Enabled = CType(resources.GetObject("mnu250ms.Enabled"), Boolean)
        Me.mnu250ms.Index = 3
        Me.mnu250ms.Shortcut = CType(resources.GetObject("mnu250ms.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnu250ms.ShowShortcut = CType(resources.GetObject("mnu250ms.ShowShortcut"), Boolean)
        Me.mnu250ms.Text = resources.GetString("mnu250ms.Text")
        Me.mnu250ms.Visible = CType(resources.GetObject("mnu250ms.Visible"), Boolean)
        '
        'mnu300ms
        '
        Me.mnu300ms.Enabled = CType(resources.GetObject("mnu300ms.Enabled"), Boolean)
        Me.mnu300ms.Index = 4
        Me.mnu300ms.Shortcut = CType(resources.GetObject("mnu300ms.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnu300ms.ShowShortcut = CType(resources.GetObject("mnu300ms.ShowShortcut"), Boolean)
        Me.mnu300ms.Text = resources.GetString("mnu300ms.Text")
        Me.mnu300ms.Visible = CType(resources.GetObject("mnu300ms.Visible"), Boolean)
        '
        'mnu350ms
        '
        Me.mnu350ms.Enabled = CType(resources.GetObject("mnu350ms.Enabled"), Boolean)
        Me.mnu350ms.Index = 5
        Me.mnu350ms.Shortcut = CType(resources.GetObject("mnu350ms.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnu350ms.ShowShortcut = CType(resources.GetObject("mnu350ms.ShowShortcut"), Boolean)
        Me.mnu350ms.Text = resources.GetString("mnu350ms.Text")
        Me.mnu350ms.Visible = CType(resources.GetObject("mnu350ms.Visible"), Boolean)
        '
        'mnu400ms
        '
        Me.mnu400ms.Enabled = CType(resources.GetObject("mnu400ms.Enabled"), Boolean)
        Me.mnu400ms.Index = 6
        Me.mnu400ms.Shortcut = CType(resources.GetObject("mnu400ms.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnu400ms.ShowShortcut = CType(resources.GetObject("mnu400ms.ShowShortcut"), Boolean)
        Me.mnu400ms.Text = resources.GetString("mnu400ms.Text")
        Me.mnu400ms.Visible = CType(resources.GetObject("mnu400ms.Visible"), Boolean)
        '
        'mnu450ms
        '
        Me.mnu450ms.Enabled = CType(resources.GetObject("mnu450ms.Enabled"), Boolean)
        Me.mnu450ms.Index = 7
        Me.mnu450ms.Shortcut = CType(resources.GetObject("mnu450ms.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnu450ms.ShowShortcut = CType(resources.GetObject("mnu450ms.ShowShortcut"), Boolean)
        Me.mnu450ms.Text = resources.GetString("mnu450ms.Text")
        Me.mnu450ms.Visible = CType(resources.GetObject("mnu450ms.Visible"), Boolean)
        '
        'mnu500ms
        '
        Me.mnu500ms.Enabled = CType(resources.GetObject("mnu500ms.Enabled"), Boolean)
        Me.mnu500ms.Index = 8
        Me.mnu500ms.Shortcut = CType(resources.GetObject("mnu500ms.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnu500ms.ShowShortcut = CType(resources.GetObject("mnu500ms.ShowShortcut"), Boolean)
        Me.mnu500ms.Text = resources.GetString("mnu500ms.Text")
        Me.mnu500ms.Visible = CType(resources.GetObject("mnu500ms.Visible"), Boolean)
        '
        'mnuStandard
        '
        Me.mnuStandard.Enabled = CType(resources.GetObject("mnuStandard.Enabled"), Boolean)
        Me.mnuStandard.Index = 1
        Me.mnuStandard.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuMetric, Me.mnuSAE})
        Me.mnuStandard.Shortcut = CType(resources.GetObject("mnuStandard.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnuStandard.ShowShortcut = CType(resources.GetObject("mnuStandard.ShowShortcut"), Boolean)
        Me.mnuStandard.Text = resources.GetString("mnuStandard.Text")
        Me.mnuStandard.Visible = CType(resources.GetObject("mnuStandard.Visible"), Boolean)
        '
        'mnuMetric
        '
        Me.mnuMetric.Enabled = CType(resources.GetObject("mnuMetric.Enabled"), Boolean)
        Me.mnuMetric.Index = 0
        Me.mnuMetric.Shortcut = CType(resources.GetObject("mnuMetric.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnuMetric.ShowShortcut = CType(resources.GetObject("mnuMetric.ShowShortcut"), Boolean)
        Me.mnuMetric.Text = resources.GetString("mnuMetric.Text")
        Me.mnuMetric.Visible = CType(resources.GetObject("mnuMetric.Visible"), Boolean)
        '
        'mnuSAE
        '
        Me.mnuSAE.Enabled = CType(resources.GetObject("mnuSAE.Enabled"), Boolean)
        Me.mnuSAE.Index = 1
        Me.mnuSAE.Shortcut = CType(resources.GetObject("mnuSAE.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnuSAE.ShowShortcut = CType(resources.GetObject("mnuSAE.ShowShortcut"), Boolean)
        Me.mnuSAE.Text = resources.GetString("mnuSAE.Text")
        Me.mnuSAE.Visible = CType(resources.GetObject("mnuSAE.Visible"), Boolean)
        '
        'mnuO2Type
        '
        Me.mnuO2Type.Enabled = CType(resources.GetObject("mnuO2Type.Enabled"), Boolean)
        Me.mnuO2Type.Index = 2
        Me.mnuO2Type.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuStockO2, Me.mnuPlxO2, Me.mnuLM1})
        Me.mnuO2Type.Shortcut = CType(resources.GetObject("mnuO2Type.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnuO2Type.ShowShortcut = CType(resources.GetObject("mnuO2Type.ShowShortcut"), Boolean)
        Me.mnuO2Type.Text = resources.GetString("mnuO2Type.Text")
        Me.mnuO2Type.Visible = CType(resources.GetObject("mnuO2Type.Visible"), Boolean)
        '
        'mnuStockO2
        '
        Me.mnuStockO2.Enabled = CType(resources.GetObject("mnuStockO2.Enabled"), Boolean)
        Me.mnuStockO2.Index = 0
        Me.mnuStockO2.Shortcut = CType(resources.GetObject("mnuStockO2.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnuStockO2.ShowShortcut = CType(resources.GetObject("mnuStockO2.ShowShortcut"), Boolean)
        Me.mnuStockO2.Text = resources.GetString("mnuStockO2.Text")
        Me.mnuStockO2.Visible = CType(resources.GetObject("mnuStockO2.Visible"), Boolean)
        '
        'mnuPlxO2
        '
        Me.mnuPlxO2.Enabled = CType(resources.GetObject("mnuPlxO2.Enabled"), Boolean)
        Me.mnuPlxO2.Index = 1
        Me.mnuPlxO2.Shortcut = CType(resources.GetObject("mnuPlxO2.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnuPlxO2.ShowShortcut = CType(resources.GetObject("mnuPlxO2.ShowShortcut"), Boolean)
        Me.mnuPlxO2.Text = resources.GetString("mnuPlxO2.Text")
        Me.mnuPlxO2.Visible = CType(resources.GetObject("mnuPlxO2.Visible"), Boolean)
        '
        'mnuLM1
        '
        Me.mnuLM1.Enabled = CType(resources.GetObject("mnuLM1.Enabled"), Boolean)
        Me.mnuLM1.Index = 2
        Me.mnuLM1.Shortcut = CType(resources.GetObject("mnuLM1.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnuLM1.ShowShortcut = CType(resources.GetObject("mnuLM1.ShowShortcut"), Boolean)
        Me.mnuLM1.Text = resources.GetString("mnuLM1.Text")
        Me.mnuLM1.Visible = CType(resources.GetObject("mnuLM1.Visible"), Boolean)
        '
        'mnuMapSensor
        '
        Me.mnuMapSensor.Enabled = CType(resources.GetObject("mnuMapSensor.Enabled"), Boolean)
        Me.mnuMapSensor.Index = 3
        Me.mnuMapSensor.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuStockMap, Me.mnuGM2Bar, Me.mnuGM3Bar})
        Me.mnuMapSensor.Shortcut = CType(resources.GetObject("mnuMapSensor.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnuMapSensor.ShowShortcut = CType(resources.GetObject("mnuMapSensor.ShowShortcut"), Boolean)
        Me.mnuMapSensor.Text = resources.GetString("mnuMapSensor.Text")
        Me.mnuMapSensor.Visible = CType(resources.GetObject("mnuMapSensor.Visible"), Boolean)
        '
        'mnuStockMap
        '
        Me.mnuStockMap.Enabled = CType(resources.GetObject("mnuStockMap.Enabled"), Boolean)
        Me.mnuStockMap.Index = 0
        Me.mnuStockMap.Shortcut = CType(resources.GetObject("mnuStockMap.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnuStockMap.ShowShortcut = CType(resources.GetObject("mnuStockMap.ShowShortcut"), Boolean)
        Me.mnuStockMap.Text = resources.GetString("mnuStockMap.Text")
        Me.mnuStockMap.Visible = CType(resources.GetObject("mnuStockMap.Visible"), Boolean)
        '
        'mnuGM2Bar
        '
        Me.mnuGM2Bar.Enabled = CType(resources.GetObject("mnuGM2Bar.Enabled"), Boolean)
        Me.mnuGM2Bar.Index = 1
        Me.mnuGM2Bar.Shortcut = CType(resources.GetObject("mnuGM2Bar.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnuGM2Bar.ShowShortcut = CType(resources.GetObject("mnuGM2Bar.ShowShortcut"), Boolean)
        Me.mnuGM2Bar.Text = resources.GetString("mnuGM2Bar.Text")
        Me.mnuGM2Bar.Visible = CType(resources.GetObject("mnuGM2Bar.Visible"), Boolean)
        '
        'mnuGM3Bar
        '
        Me.mnuGM3Bar.Enabled = CType(resources.GetObject("mnuGM3Bar.Enabled"), Boolean)
        Me.mnuGM3Bar.Index = 2
        Me.mnuGM3Bar.Shortcut = CType(resources.GetObject("mnuGM3Bar.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnuGM3Bar.ShowShortcut = CType(resources.GetObject("mnuGM3Bar.ShowShortcut"), Boolean)
        Me.mnuGM3Bar.Text = resources.GetString("mnuGM3Bar.Text")
        Me.mnuGM3Bar.Visible = CType(resources.GetObject("mnuGM3Bar.Visible"), Boolean)
        '
        'mnuGearCorrection
        '
        Me.mnuGearCorrection.Enabled = CType(resources.GetObject("mnuGearCorrection.Enabled"), Boolean)
        Me.mnuGearCorrection.Index = 4
        Me.mnuGearCorrection.Shortcut = CType(resources.GetObject("mnuGearCorrection.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnuGearCorrection.ShowShortcut = CType(resources.GetObject("mnuGearCorrection.ShowShortcut"), Boolean)
        Me.mnuGearCorrection.Text = resources.GetString("mnuGearCorrection.Text")
        Me.mnuGearCorrection.Visible = CType(resources.GetObject("mnuGearCorrection.Visible"), Boolean)
        '
        'mnuEcuType
        '
        Me.mnuEcuType.Enabled = CType(resources.GetObject("mnuEcuType.Enabled"), Boolean)
        Me.mnuEcuType.Index = 2
        Me.mnuEcuType.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuNG55, Me.mnuOBD0, Me.mnuOBD1})
        Me.mnuEcuType.Shortcut = CType(resources.GetObject("mnuEcuType.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnuEcuType.ShowShortcut = CType(resources.GetObject("mnuEcuType.ShowShortcut"), Boolean)
        Me.mnuEcuType.Text = resources.GetString("mnuEcuType.Text")
        Me.mnuEcuType.Visible = CType(resources.GetObject("mnuEcuType.Visible"), Boolean)
        '
        'mnuNG55
        '
        Me.mnuNG55.Enabled = CType(resources.GetObject("mnuNG55.Enabled"), Boolean)
        Me.mnuNG55.Index = 0
        Me.mnuNG55.Shortcut = CType(resources.GetObject("mnuNG55.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnuNG55.ShowShortcut = CType(resources.GetObject("mnuNG55.ShowShortcut"), Boolean)
        Me.mnuNG55.Text = resources.GetString("mnuNG55.Text")
        Me.mnuNG55.Visible = CType(resources.GetObject("mnuNG55.Visible"), Boolean)
        '
        'mnuOBD0
        '
        Me.mnuOBD0.Enabled = CType(resources.GetObject("mnuOBD0.Enabled"), Boolean)
        Me.mnuOBD0.Index = 1
        Me.mnuOBD0.Shortcut = CType(resources.GetObject("mnuOBD0.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnuOBD0.ShowShortcut = CType(resources.GetObject("mnuOBD0.ShowShortcut"), Boolean)
        Me.mnuOBD0.Text = resources.GetString("mnuOBD0.Text")
        Me.mnuOBD0.Visible = CType(resources.GetObject("mnuOBD0.Visible"), Boolean)
        '
        'mnuOBD1
        '
        Me.mnuOBD1.Enabled = CType(resources.GetObject("mnuOBD1.Enabled"), Boolean)
        Me.mnuOBD1.Index = 2
        Me.mnuOBD1.Shortcut = CType(resources.GetObject("mnuOBD1.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnuOBD1.ShowShortcut = CType(resources.GetObject("mnuOBD1.ShowShortcut"), Boolean)
        Me.mnuOBD1.Text = resources.GetString("mnuOBD1.Text")
        Me.mnuOBD1.Visible = CType(resources.GetObject("mnuOBD1.Visible"), Boolean)
        '
        'mnuEcu
        '
        Me.mnuEcu.Enabled = CType(resources.GetObject("mnuEcu.Enabled"), Boolean)
        Me.mnuEcu.Index = 3
        Me.mnuEcu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuConnect, Me.mnuStartLogging})
        Me.mnuEcu.Shortcut = CType(resources.GetObject("mnuEcu.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnuEcu.ShowShortcut = CType(resources.GetObject("mnuEcu.ShowShortcut"), Boolean)
        Me.mnuEcu.Text = resources.GetString("mnuEcu.Text")
        Me.mnuEcu.Visible = CType(resources.GetObject("mnuEcu.Visible"), Boolean)
        '
        'mnuConnect
        '
        Me.mnuConnect.Enabled = CType(resources.GetObject("mnuConnect.Enabled"), Boolean)
        Me.mnuConnect.Index = 0
        Me.mnuConnect.Shortcut = CType(resources.GetObject("mnuConnect.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnuConnect.ShowShortcut = CType(resources.GetObject("mnuConnect.ShowShortcut"), Boolean)
        Me.mnuConnect.Text = resources.GetString("mnuConnect.Text")
        Me.mnuConnect.Visible = CType(resources.GetObject("mnuConnect.Visible"), Boolean)
        '
        'mnuStartLogging
        '
        Me.mnuStartLogging.Enabled = CType(resources.GetObject("mnuStartLogging.Enabled"), Boolean)
        Me.mnuStartLogging.Index = 1
        Me.mnuStartLogging.Shortcut = CType(resources.GetObject("mnuStartLogging.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnuStartLogging.ShowShortcut = CType(resources.GetObject("mnuStartLogging.ShowShortcut"), Boolean)
        Me.mnuStartLogging.Text = resources.GetString("mnuStartLogging.Text")
        Me.mnuStartLogging.Visible = CType(resources.GetObject("mnuStartLogging.Visible"), Boolean)
        '
        'mnuRTP
        '
        Me.mnuRTP.Enabled = CType(resources.GetObject("mnuRTP.Enabled"), Boolean)
        Me.mnuRTP.Index = 4
        Me.mnuRTP.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuRTPOBD0, Me.mnuRTPOBD1})
        Me.mnuRTP.Shortcut = CType(resources.GetObject("mnuRTP.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnuRTP.ShowShortcut = CType(resources.GetObject("mnuRTP.ShowShortcut"), Boolean)
        Me.mnuRTP.Text = resources.GetString("mnuRTP.Text")
        Me.mnuRTP.Visible = CType(resources.GetObject("mnuRTP.Visible"), Boolean)
        '
        'mnuRTPOBD0
        '
        Me.mnuRTPOBD0.Enabled = CType(resources.GetObject("mnuRTPOBD0.Enabled"), Boolean)
        Me.mnuRTPOBD0.Index = 0
        Me.mnuRTPOBD0.Shortcut = CType(resources.GetObject("mnuRTPOBD0.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnuRTPOBD0.ShowShortcut = CType(resources.GetObject("mnuRTPOBD0.ShowShortcut"), Boolean)
        Me.mnuRTPOBD0.Text = resources.GetString("mnuRTPOBD0.Text")
        Me.mnuRTPOBD0.Visible = CType(resources.GetObject("mnuRTPOBD0.Visible"), Boolean)
        '
        'mnuRTPOBD1
        '
        Me.mnuRTPOBD1.Enabled = CType(resources.GetObject("mnuRTPOBD1.Enabled"), Boolean)
        Me.mnuRTPOBD1.Index = 1
        Me.mnuRTPOBD1.Shortcut = CType(resources.GetObject("mnuRTPOBD1.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnuRTPOBD1.ShowShortcut = CType(resources.GetObject("mnuRTPOBD1.ShowShortcut"), Boolean)
        Me.mnuRTPOBD1.Text = resources.GetString("mnuRTPOBD1.Text")
        Me.mnuRTPOBD1.Visible = CType(resources.GetObject("mnuRTPOBD1.Visible"), Boolean)
        '
        'mnuWindows
        '
        Me.mnuWindows.Enabled = CType(resources.GetObject("mnuWindows.Enabled"), Boolean)
        Me.mnuWindows.Index = 5
        Me.mnuWindows.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuDatalogging, Me.mnuWRTP, Me.mnuHPT, Me.mnuGagues})
        Me.mnuWindows.Shortcut = CType(resources.GetObject("mnuWindows.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnuWindows.ShowShortcut = CType(resources.GetObject("mnuWindows.ShowShortcut"), Boolean)
        Me.mnuWindows.Text = resources.GetString("mnuWindows.Text")
        Me.mnuWindows.Visible = CType(resources.GetObject("mnuWindows.Visible"), Boolean)
        '
        'mnuDatalogging
        '
        Me.mnuDatalogging.Enabled = CType(resources.GetObject("mnuDatalogging.Enabled"), Boolean)
        Me.mnuDatalogging.Index = 0
        Me.mnuDatalogging.Shortcut = CType(resources.GetObject("mnuDatalogging.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnuDatalogging.ShowShortcut = CType(resources.GetObject("mnuDatalogging.ShowShortcut"), Boolean)
        Me.mnuDatalogging.Text = resources.GetString("mnuDatalogging.Text")
        Me.mnuDatalogging.Visible = CType(resources.GetObject("mnuDatalogging.Visible"), Boolean)
        '
        'mnuWRTP
        '
        Me.mnuWRTP.Enabled = CType(resources.GetObject("mnuWRTP.Enabled"), Boolean)
        Me.mnuWRTP.Index = 1
        Me.mnuWRTP.Shortcut = CType(resources.GetObject("mnuWRTP.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnuWRTP.ShowShortcut = CType(resources.GetObject("mnuWRTP.ShowShortcut"), Boolean)
        Me.mnuWRTP.Text = resources.GetString("mnuWRTP.Text")
        Me.mnuWRTP.Visible = CType(resources.GetObject("mnuWRTP.Visible"), Boolean)
        '
        'mnuHPT
        '
        Me.mnuHPT.Enabled = CType(resources.GetObject("mnuHPT.Enabled"), Boolean)
        Me.mnuHPT.Index = 2
        Me.mnuHPT.Shortcut = CType(resources.GetObject("mnuHPT.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnuHPT.ShowShortcut = CType(resources.GetObject("mnuHPT.ShowShortcut"), Boolean)
        Me.mnuHPT.Text = resources.GetString("mnuHPT.Text")
        Me.mnuHPT.Visible = CType(resources.GetObject("mnuHPT.Visible"), Boolean)
        '
        'mnuGagues
        '
        Me.mnuGagues.Enabled = CType(resources.GetObject("mnuGagues.Enabled"), Boolean)
        Me.mnuGagues.Index = 3
        Me.mnuGagues.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuGuageDigital})
        Me.mnuGagues.Shortcut = CType(resources.GetObject("mnuGagues.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnuGagues.ShowShortcut = CType(resources.GetObject("mnuGagues.ShowShortcut"), Boolean)
        Me.mnuGagues.Text = resources.GetString("mnuGagues.Text")
        Me.mnuGagues.Visible = CType(resources.GetObject("mnuGagues.Visible"), Boolean)
        '
        'mnuGuageDigital
        '
        Me.mnuGuageDigital.Enabled = CType(resources.GetObject("mnuGuageDigital.Enabled"), Boolean)
        Me.mnuGuageDigital.Index = 0
        Me.mnuGuageDigital.Shortcut = CType(resources.GetObject("mnuGuageDigital.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnuGuageDigital.ShowShortcut = CType(resources.GetObject("mnuGuageDigital.ShowShortcut"), Boolean)
        Me.mnuGuageDigital.Text = resources.GetString("mnuGuageDigital.Text")
        Me.mnuGuageDigital.Visible = CType(resources.GetObject("mnuGuageDigital.Visible"), Boolean)
        '
        'mnuHelp
        '
        Me.mnuHelp.Enabled = CType(resources.GetObject("mnuHelp.Enabled"), Boolean)
        Me.mnuHelp.Index = 6
        Me.mnuHelp.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuAbout, Me.mnuShowDebugInfo, Me.MenuItem1})
        Me.mnuHelp.Shortcut = CType(resources.GetObject("mnuHelp.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnuHelp.ShowShortcut = CType(resources.GetObject("mnuHelp.ShowShortcut"), Boolean)
        Me.mnuHelp.Text = resources.GetString("mnuHelp.Text")
        Me.mnuHelp.Visible = CType(resources.GetObject("mnuHelp.Visible"), Boolean)
        '
        'mnuAbout
        '
        Me.mnuAbout.Enabled = CType(resources.GetObject("mnuAbout.Enabled"), Boolean)
        Me.mnuAbout.Index = 0
        Me.mnuAbout.Shortcut = CType(resources.GetObject("mnuAbout.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnuAbout.ShowShortcut = CType(resources.GetObject("mnuAbout.ShowShortcut"), Boolean)
        Me.mnuAbout.Text = resources.GetString("mnuAbout.Text")
        Me.mnuAbout.Visible = CType(resources.GetObject("mnuAbout.Visible"), Boolean)
        '
        'mnuShowDebugInfo
        '
        Me.mnuShowDebugInfo.Enabled = CType(resources.GetObject("mnuShowDebugInfo.Enabled"), Boolean)
        Me.mnuShowDebugInfo.Index = 1
        Me.mnuShowDebugInfo.Shortcut = CType(resources.GetObject("mnuShowDebugInfo.Shortcut"), System.Windows.Forms.Shortcut)
        Me.mnuShowDebugInfo.ShowShortcut = CType(resources.GetObject("mnuShowDebugInfo.ShowShortcut"), Boolean)
        Me.mnuShowDebugInfo.Text = resources.GetString("mnuShowDebugInfo.Text")
        Me.mnuShowDebugInfo.Visible = CType(resources.GetObject("mnuShowDebugInfo.Visible"), Boolean)
        '
        'MenuItem1
        '
        Me.MenuItem1.Enabled = CType(resources.GetObject("MenuItem1.Enabled"), Boolean)
        Me.MenuItem1.Index = 2
        Me.MenuItem1.Shortcut = CType(resources.GetObject("MenuItem1.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem1.ShowShortcut = CType(resources.GetObject("MenuItem1.ShowShortcut"), Boolean)
        Me.MenuItem1.Text = resources.GetString("MenuItem1.Text")
        Me.MenuItem1.Visible = CType(resources.GetObject("MenuItem1.Visible"), Boolean)
        '
        'StatusBar1
        '
        Me.StatusBar1.AccessibleDescription = resources.GetString("StatusBar1.AccessibleDescription")
        Me.StatusBar1.AccessibleName = resources.GetString("StatusBar1.AccessibleName")
        Me.StatusBar1.Anchor = CType(resources.GetObject("StatusBar1.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.StatusBar1.BackgroundImage = CType(resources.GetObject("StatusBar1.BackgroundImage"), System.Drawing.Image)
        Me.StatusBar1.Dock = CType(resources.GetObject("StatusBar1.Dock"), System.Windows.Forms.DockStyle)
        Me.StatusBar1.Enabled = CType(resources.GetObject("StatusBar1.Enabled"), Boolean)
        Me.StatusBar1.Font = CType(resources.GetObject("StatusBar1.Font"), System.Drawing.Font)
        Me.StatusBar1.ImeMode = CType(resources.GetObject("StatusBar1.ImeMode"), System.Windows.Forms.ImeMode)
        Me.StatusBar1.Location = CType(resources.GetObject("StatusBar1.Location"), System.Drawing.Point)
        Me.StatusBar1.Name = "StatusBar1"
        Me.StatusBar1.RightToLeft = CType(resources.GetObject("StatusBar1.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.StatusBar1.Size = CType(resources.GetObject("StatusBar1.Size"), System.Drawing.Size)
        Me.StatusBar1.TabIndex = CType(resources.GetObject("StatusBar1.TabIndex"), Integer)
        Me.StatusBar1.Text = resources.GetString("StatusBar1.Text")
        Me.StatusBar1.Visible = CType(resources.GetObject("StatusBar1.Visible"), Boolean)
        '
        'toTimer
        '
        '
        'DebugBox
        '
        Me.DebugBox.AccessibleDescription = resources.GetString("DebugBox.AccessibleDescription")
        Me.DebugBox.AccessibleName = resources.GetString("DebugBox.AccessibleName")
        Me.DebugBox.Anchor = CType(resources.GetObject("DebugBox.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.DebugBox.BackgroundImage = CType(resources.GetObject("DebugBox.BackgroundImage"), System.Drawing.Image)
        Me.DebugBox.ColumnWidth = CType(resources.GetObject("DebugBox.ColumnWidth"), Integer)
        Me.DebugBox.Dock = CType(resources.GetObject("DebugBox.Dock"), System.Windows.Forms.DockStyle)
        Me.DebugBox.Enabled = CType(resources.GetObject("DebugBox.Enabled"), Boolean)
        Me.DebugBox.Font = CType(resources.GetObject("DebugBox.Font"), System.Drawing.Font)
        Me.DebugBox.HorizontalExtent = CType(resources.GetObject("DebugBox.HorizontalExtent"), Integer)
        Me.DebugBox.HorizontalScrollbar = CType(resources.GetObject("DebugBox.HorizontalScrollbar"), Boolean)
        Me.DebugBox.ImeMode = CType(resources.GetObject("DebugBox.ImeMode"), System.Windows.Forms.ImeMode)
        Me.DebugBox.IntegralHeight = CType(resources.GetObject("DebugBox.IntegralHeight"), Boolean)
        Me.DebugBox.ItemHeight = CType(resources.GetObject("DebugBox.ItemHeight"), Integer)
        Me.DebugBox.Location = CType(resources.GetObject("DebugBox.Location"), System.Drawing.Point)
        Me.DebugBox.Name = "DebugBox"
        Me.DebugBox.RightToLeft = CType(resources.GetObject("DebugBox.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.DebugBox.ScrollAlwaysVisible = CType(resources.GetObject("DebugBox.ScrollAlwaysVisible"), Boolean)
        Me.DebugBox.Size = CType(resources.GetObject("DebugBox.Size"), System.Drawing.Size)
        Me.DebugBox.TabIndex = CType(resources.GetObject("DebugBox.TabIndex"), Integer)
        Me.DebugBox.Visible = CType(resources.GetObject("DebugBox.Visible"), Boolean)
        '
        'BackGroundPic
        '
        Me.BackGroundPic.AccessibleDescription = resources.GetString("BackGroundPic.AccessibleDescription")
        Me.BackGroundPic.AccessibleName = resources.GetString("BackGroundPic.AccessibleName")
        Me.BackGroundPic.Anchor = CType(resources.GetObject("BackGroundPic.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.BackGroundPic.BackgroundImage = CType(resources.GetObject("BackGroundPic.BackgroundImage"), System.Drawing.Image)
        Me.BackGroundPic.Dock = CType(resources.GetObject("BackGroundPic.Dock"), System.Windows.Forms.DockStyle)
        Me.BackGroundPic.Enabled = CType(resources.GetObject("BackGroundPic.Enabled"), Boolean)
        Me.BackGroundPic.Font = CType(resources.GetObject("BackGroundPic.Font"), System.Drawing.Font)
        Me.BackGroundPic.Image = CType(resources.GetObject("BackGroundPic.Image"), System.Drawing.Image)
        Me.BackGroundPic.ImeMode = CType(resources.GetObject("BackGroundPic.ImeMode"), System.Windows.Forms.ImeMode)
        Me.BackGroundPic.Location = CType(resources.GetObject("BackGroundPic.Location"), System.Drawing.Point)
        Me.BackGroundPic.Name = "BackGroundPic"
        Me.BackGroundPic.RightToLeft = CType(resources.GetObject("BackGroundPic.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.BackGroundPic.Size = CType(resources.GetObject("BackGroundPic.Size"), System.Drawing.Size)
        Me.BackGroundPic.SizeMode = CType(resources.GetObject("BackGroundPic.SizeMode"), System.Windows.Forms.PictureBoxSizeMode)
        Me.BackGroundPic.TabIndex = CType(resources.GetObject("BackGroundPic.TabIndex"), Integer)
        Me.BackGroundPic.TabStop = False
        Me.BackGroundPic.Text = resources.GetString("BackGroundPic.Text")
        Me.BackGroundPic.Visible = CType(resources.GetObject("BackGroundPic.Visible"), Boolean)
        '
        'frmMain
        '
        Me.AccessibleDescription = resources.GetString("$this.AccessibleDescription")
        Me.AccessibleName = resources.GetString("$this.AccessibleName")
        Me.AutoScaleBaseSize = CType(resources.GetObject("$this.AutoScaleBaseSize"), System.Drawing.Size)
        Me.AutoScroll = CType(resources.GetObject("$this.AutoScroll"), Boolean)
        Me.AutoScrollMargin = CType(resources.GetObject("$this.AutoScrollMargin"), System.Drawing.Size)
        Me.AutoScrollMinSize = CType(resources.GetObject("$this.AutoScrollMinSize"), System.Drawing.Size)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = CType(resources.GetObject("$this.ClientSize"), System.Drawing.Size)
        Me.Controls.Add(Me.BackGroundPic)
        Me.Controls.Add(Me.DebugBox)
        Me.Controls.Add(Me.StatusBar1)
        Me.Enabled = CType(resources.GetObject("$this.Enabled"), Boolean)
        Me.Font = CType(resources.GetObject("$this.Font"), System.Drawing.Font)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.ImeMode = CType(resources.GetObject("$this.ImeMode"), System.Windows.Forms.ImeMode)
        Me.IsMdiContainer = True
        Me.Location = CType(resources.GetObject("$this.Location"), System.Drawing.Point)
        Me.MaximumSize = CType(resources.GetObject("$this.MaximumSize"), System.Drawing.Size)
        Me.Menu = Me.MainMenu1
        Me.MinimumSize = CType(resources.GetObject("$this.MinimumSize"), System.Drawing.Size)
        Me.Name = "frmMain"
        Me.RightToLeft = CType(resources.GetObject("$this.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.StartPosition = CType(resources.GetObject("$this.StartPosition"), System.Windows.Forms.FormStartPosition)
        Me.Text = resources.GetString("$this.Text")
        Me.ResumeLayout(False)

    End Sub

#End Region
#Region "Menu Events"
    Private Sub mnuConnect_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuConnect.Click
        Select Case mnuConnect.Text
            Case "Connect"
                mnuEcuType.Enabled = False
                OpenComPort()
            Case "Disconnect"
                mnuEcuType.Enabled = True
                CloseComPort()
        End Select
        
    End Sub
    Private Sub mnuStartLogging_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuStartLogging.Click
        Select Case datalog
            Case False
                mnuConnect.Text = "Disconnect"
                mnuConnect.Enabled = False
                mnuStartLogging.Text = "Stop Logging"
                datalog = True
                PollData()
            Case True
                mnuConnect.Enabled = True
                mnuStartLogging.Text = "Start Logging"
                datalog = False

        End Select
    End Sub
    Private Sub mnuDatalogging_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDatalogging.Click
        frmDatalog.DefInstance.MdiParent = Me 'make this form the parent/owner
        frmDatalog.DefInstance.Show() 'show the new instance of frmDatalog
    End Sub
    Public Sub mnuGuageDigital_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuGuageDigital.Click
        'DigitalGuage.DefInstance.gaugeScheme(1) '1=LCD,2=Indiglo
        'Dim DigGuage As New DigitalGuage
        DigitalGuage.DefInstance.MdiParent = Me
        DigitalGuage.DefInstance.Show()

    End Sub
    Public Sub mnuAnalog_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'frmAgauges.DefInstance.Show()
    End Sub
    Private Sub mnuHPT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuHPT.Click
        frmHPT.DefInstance.MdiParent = Me
        frmHPT.DefInstance.Show()
    End Sub
    Private Sub mnuExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuExit.Click
        'Call Me.Close() ' make sure we save form settings
        Application.Exit() 'Close all windows and exit App
        End
    End Sub
    Private Sub mnuLCD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'frmDgauges.DefInstance.gaugeScheme(1)
        GaugeStyle = 1
    End Sub
    Private Sub mnuIndiglo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'frmDgauges.DefInstance.gaugeScheme(2)
        GaugeStyle = 2
    End Sub
    'Private Sub mnuCreateCustom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '   frmCustomColor.DefInstance.Show()
    '   mnuCustom.Enabled = True
    'End Sub
    Private Sub mnuCustom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'frmDgauges.DefInstance.gaugeScheme(3)
        GaugeStyle = 3
    End Sub
    Private Sub mnuGearCorrection_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuGearCorrection.Click
        frmGC.DefInstance.MdiParent = Me
        frmGC.DefInstance.Show()
    End Sub
    Private Sub mnuCom1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCom1.Click
        ComSettings("Port") = "COM1,38400,8,n,1"
        StatusBar1.Panels(0).Text = "COM1,38400,8,n,1"
        cPort = 1
        InitCommPort()
    End Sub
    Private Sub mnuCom2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCom2.Click
        ComSettings("Port") = "COM2,38400,8,n,1"
        StatusBar1.Panels(0).Text = ComSettings("Port")
        cPort = 2
        InitCommPort()
    End Sub
    Private Sub mnuCom3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuCom3.Click
        ComSettings("Port") = "COM3,38400,8,n,1"
        StatusBar1.Panels(0).Text = "COM3,38400,8,n,1"
        cPort = 3
        InitCommPort()
    End Sub
    Private Sub mnuCom4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuCom4.Click
        ComSettings("Port") = "COM4,38400,8,n,1"
        StatusBar1.Panels(0).Text = "COM4,38400,8,n,1"
        cPort = 4
        InitCommPort()
    End Sub
    Private Sub mnuCom5_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuCom5.Click
        ComSettings("Port") = "COM5,38400,8,n,1"
        StatusBar1.Panels(0).Text = "COM5,38400,8,n,1"
        cPort = 5
        InitCommPort()
    End Sub
    Private Sub mnuCom6_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuCom6.Click
        ComSettings("Port") = "COM6,38400,8,n,1"
        StatusBar1.Panels(0).Text = "COM6,38400,8,n,1"
        cPort = 6
        InitCommPort()
    End Sub
    Private Sub mnuCom7_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuCom7.Click
        ComSettings("Port") = "COM7,38400,8,n,1"
        StatusBar1.Panels(0).Text = "COM7,38400,8,n,1"
        cPort = 7
        InitCommPort()
    End Sub
    Private Sub mnuCom8_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuCom8.Click
        ComSettings("Port") = "COM8,38400,8,n,1"
        StatusBar1.Panels(0).Text = "COM8,38400,8,n,1"
        cPort = 8
        InitCommPort()
    End Sub
    Private Sub mnuNG55_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuNG55.Click
        Sensor(1) = 48 'ECT
        Sensor(2) = 50 'IAT
        Sensor(3) = 251 'Raw O2
        Sensor(4) = 248 'Raw MAp Value
        Sensor(5) = 57 'TPS
        Sensor(6) = 250 'RPMLO
        Sensor(7) = 71 'RPMHI
        Sensor(8) = 54 'Stock Map
        Sensor(9) = 108 '8Bit VSS
        Sensor(0) = 73 '8Bit RPM

        EcuType = "NG55"
        StatusBar1.Panels(1).Text = EcuType
        mnuEcu.Enabled = True
        mnuRTP.Enabled = True

    End Sub
    Private Sub mnuOBD0Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuOBD0.Click
        Sensor(0) = 255 'UNUSED
        Sensor(1) = 16 'ECT
        Sensor(2) = 17 'IAT
        Sensor(3) = 18 'O2
        Sensor(4) = 20 'MAP
        Sensor(5) = 21 'TPS
        Sensor(6) = 22 'RPMLO
        Sensor(7) = 23 'RPMHI
        Sensor(8) = 24 'VTEC
        Sensor(9) = 32 'VSS
        EcuType = "OBD0"
        StatusBar1.Panels(1).Text = EcuType
        mnuEcu.Enabled = True
        mnuRTP.Enabled = True
    End Sub
    Private Sub mnuOBD1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuOBD1.Click
        Sensor(0) = 255 'UNUSED
        Sensor(1) = 16 'ECT
        Sensor(2) = 17 'IAT
        Sensor(3) = 18 'O2
        Sensor(4) = 20 'MAP
        Sensor(5) = 21 'TPS
        Sensor(6) = 22 'RPMLO
        Sensor(7) = 23 'RPMHI
        Sensor(8) = 24 'VTEC
        Sensor(9) = 32 'VSS
        EcuType = "OBD1"
        StatusBar1.Panels(1).Text = EcuType
        mnuEcu.Enabled = True
        mnuRTP.Enabled = True
    End Sub
    Private Sub mnu100ms_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu100ms.Click
        ClearTOmnuChecks()
        mnu100ms.Checked = True
        TimeOutSettings = 100
        toTimer.Interval = 10
    End Sub
    Private Sub mnu150ms_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu150ms.Click
        ClearTOmnuChecks()
        mnu150ms.Checked = True
        TimeOutSettings = 150
        toTimer.Interval = 150
    End Sub
    Private Sub mnu200ms_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu200ms.Click
        ClearTOmnuChecks()
        mnu200ms.Checked = True
        TimeOutSettings = 200
        toTimer.Interval = 200
    End Sub
    Private Sub mnu250ms_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu250ms.Click
        ClearTOmnuChecks()
        mnu250ms.Checked = True
        TimeOutSettings = 250
        toTimer.Interval = 250
    End Sub
    Private Sub mnu300ms_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu300ms.Click
        ClearTOmnuChecks()
        mnu300ms.Checked = True
        TimeOutSettings = 300
        toTimer.Interval = 300
    End Sub
    Private Sub mnu350ms_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu350ms.Click
        ClearTOmnuChecks()
        mnu350ms.Checked = True
        TimeOutSettings = 350
        toTimer.Interval = 350
    End Sub
    Private Sub mnu400ms_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu400ms.Click
        ClearTOmnuChecks()
        mnu400ms.Checked = True
        TimeOutSettings = 400
        toTimer.Interval = 400
    End Sub
    Private Sub mnu450ms_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu450ms.Click
        ClearTOmnuChecks()
        mnu450ms.Checked = True
        TimeOutSettings = 450
        toTimer.Interval = 450
    End Sub
    Private Sub mnu500ms_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu500ms.Click
        ClearTOmnuChecks()
        mnu500ms.Checked = True
        TimeOutSettings = 500
        toTimer.Interval = 500
    End Sub
    Private Sub mnuStockO2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuStockO2.Click
        General.O2Type = 1 'stock O2
        General.O2SensorType = 1
        mnuStockO2.Checked = True
        mnuPlxO2.Checked = False
        mnuLM1.Checked = False
        StatusBar1.Panels(3).Text = "O2: Stock"
    End Sub
    Private Sub mnuPlxO2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPlxO2.Click
        General.O2Type = 2 'plx
        General.O2SensorType = 2
        mnuStockO2.Checked = False
        mnuPlxO2.Checked = True
        mnuLM1.Checked = False
        StatusBar1.Panels(3).Text = "O2: Plx"
    End Sub
    Private Sub mnuLM1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuLM1.Click
        General.O2Type = 3 'LM1
        General.O2SensorType = 3
        mnuStockO2.Checked = False
        mnuPlxO2.Checked = False
        mnuLM1.Checked = True
        StatusBar1.Panels(3).Text = "O2: LM1"
    End Sub
    Private Sub mnuStockMap_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuStockMap.Click
        General.MapSensorType = 1 'stockMap
        General.MAPType = 1
        mnuStockMap.Checked = True
        mnuGM2Bar.Checked = False
        mnuGM3Bar.Checked = False
        StatusBar1.Panels(4).Text = "MAP: Stock"
    End Sub
    Private Sub mnuGM2Bar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuGM2Bar.Click
        General.MapSensorType = 2 'gm 2bar
        General.MAPType = 2
        mnuStockMap.Checked = False
        mnuGM2Bar.Checked = True
        mnuGM3Bar.Checked = False
        StatusBar1.Panels(4).Text = "MAP: GM 2Bar"
    End Sub
    Private Sub mnuGM3Bar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuGM3Bar.Click
        General.MapSensorType = 3 'gm 3bar
        General.MAPType = 3
        mnuStockMap.Checked = False
        mnuGM2Bar.Checked = False
        mnuGM3Bar.Checked = True
        StatusBar1.Panels(4).Text = "MAP: GM 3Bar"
    End Sub
    Private Sub mnuMetric_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuMetric.Click
        mnuSAE.Checked = False
        mnuMetric.Checked = True
        General.Standard = 1
        StatusBar1.Panels(5).Text = "Metric"
        'frmAgauges.DefInstance.vssgm.Visible = True
        'frmAgauges.DefInstance.vssg.Visible = False
        'frmAgauges.DefInstance.iatgm.Visible = True
        'frmAgauges.DefInstance.iatg.Visible = False
        'frmAgauges.DefInstance.ectgm.Visible = True
        'frmAgauges.DefInstance.ectg.Visible = False
    End Sub
    Private Sub mnuSAE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSAE.Click
        mnuSAE.Checked = True
        mnuMetric.Checked = False
        General.Standard = 2
        StatusBar1.Panels(5).Text = "SAE"
        'frmAgauges.DefInstance.vssgm.Visible = False
        'frmAgauges.DefInstance.vssg.Visible = True
        'frmAgauges.DefInstance.iatgm.Visible = False
        'frmAgauges.DefInstance.iatg.Visible = True
        'frmAgauges.DefInstance.ectgm.Visible = False
        'frmAgauges.DefInstance.ectg.Visible = True
    End Sub
    Private Sub mnuShowDebugInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuShowDebugInfo.Click
        frmDebug.DefInstance.MdiParent = Me
        frmDebug.DefInstance.Show()
    End Sub
    Private Sub ClearTOmnuChecks()
        For I = 0 To 8
            mnuTimeout.MenuItems(I).Checked = False
        Next
    End Sub
#End Region
#Region "Form Events"
    Private Sub frmMain_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Load Com Settings From Registry
        Dim temp As String
        temp = ComSettings("Port")
        If temp = "-1" Then
            StatusBar1.Panels.Add("Com")
            StatusBar1.Panels(0).Text = "COM1,38400,8,n,1"

            ComSettings("Port") = StatusBar1.Panels(0).Text
        Else
            StatusBar1.Panels.Add("Com")
            StatusBar1.Panels(0).Text = temp
        End If
        StatusBar1.Panels.Add("ECGEN")
        StatusBar1.Panels(1).Text = EcuType 'loaded from registry
        StatusBar1.Panels(1).AutoSize = StatusBarPanelAutoSize.Contents
        StatusBar1.Panels.Add("Status")
        StatusBar1.Panels(2).Text = "Not Connected"
        StatusBar1.Panels(2).AutoSize = StatusBarPanelAutoSize.Contents
        StatusBar1.Panels.Add("O2") 'panel 3
        StatusBar1.Panels(3).AutoSize = StatusBarPanelAutoSize.Contents
        StatusBar1.Panels.Add("MAP") 'panel 4
        StatusBar1.Panels(4).AutoSize = StatusBarPanelAutoSize.Contents
        StatusBar1.Panels.Add("STANDARD") 'panel 5
        StatusBar1.Panels(5).AutoSize = StatusBarPanelAutoSize.Contents
        StatusBar1.Panels.Add("Sensor") 'temporary debug info
        StatusBar1.Panels(6).AutoSize = StatusBarPanelAutoSize.Contents 'temporary debug info
        StatusBar1.ShowPanels = True
        'create instance of RS232 and setup RS232 port with current settings
        moRS232 = New Rs232
        Select Case temp
            Case "COM1,38400,8,n,1"
                cPort = 1
            Case "COM2,38400,8,n,1"
                cPort = 2
            Case "COM3,38400,8,n,1"
                cPort = 3
            Case "COM4,38400,8,n,1"
                cPort = 4
            Case "COM5,38400,8,n,1"
                cPort = 5
            Case "COM6,38400,8,n,1"
                cPort = 6
            Case "COM7,38400,8,n,1"
                cPort = 7
            Case "COM8,38400,8,n,1"
                cPort = 8
        End Select

        If TimeOutSettings = -1 Then 'get timeout settings from registry
            TimeOutSettings = 100
            moRS232.Timeout = TimeOutSettings
        Else
            moRS232.Timeout = TimeOutSettings
        End If
        ClearTOmnuChecks() 'remove all checks on timeout mnu
        For I = 0 To 8
            If Mid(mnuTimeout.MenuItems(I).Text(), 1, 3) = CStr(moRS232.Timeout.ToString) Then
                mnuTimeout.MenuItems(I).Checked = True
            End If
        Next
        InitCommPort() 'intialize com port with settings

        'Load saved form Settings from Registry
        Me.Height = FormHeight("frmMain")
        Me.Width = FormWidth("frmMain")
        Me.Left = FormLeft("frmMain")
        Me.Top = FormTop("frmMain")
        'Load O2 settings from Registry
        Select Case General.O2SensorType
            Case 1
                mnuStockO2.Checked = True
                General.O2Type = General.O2SensorType
                StatusBar1.Panels(3).Text = "O2: Stock"
            Case 2
                mnuPlxO2.Checked = True
                General.O2Type = General.O2SensorType
                StatusBar1.Panels(3).Text = "O2: Plx"
            Case 3
                mnuLM1.Checked = True
                General.O2Type = General.O2SensorType
                StatusBar1.Panels(3).Text = "O2: LM1(Beta)"
        End Select
        'Load Map Sensor Settings from registry
        Select Case General.MapSensorType
            Case 1
                mnuStockMap.Checked = True
                General.MAPType = General.MapSensorType
                StatusBar1.Panels(4).Text = "MAP: Stock"
            Case 2
                mnuGM2Bar.Checked = True
                General.MAPType = General.MapSensorType
                StatusBar1.Panels(4).Text = "MAP: GM 2Bar"
            Case 3
                mnuGM3Bar.Checked = True
                General.MAPType = General.MapSensorType
                StatusBar1.Panels(4).Text = "MAP: GM 3Bar"
        End Select
        'Load Standard settings from registry
        Select Case General.Standard
            Case 1
                mnuMetric.Checked = True
                StatusBar1.Panels(5).Text = "Metric"
                'frmAgauges.DefInstance.vssgm.Visible = True
                'frmAgauges.DefInstance.vssg.Visible = False
                'frmAgauges.DefInstance.iatgm.Visible = True
                'frmAgauges.DefInstance.iatg.Visible = False
                'frmAgauges.DefInstance.ectgm.Visible = True
                'frmAgauges.DefInstance.ectg.Visible = False
            Case 2
                mnuSAE.Checked = True
                StatusBar1.Panels(5).Text = "SAE"
                'frmAgauges.DefInstance.vssgm.Visible = False
                'frmAgauges.DefInstance.vssg.Visible = True
                'frmAgauges.DefInstance.iatgm.Visible = False
                'frmAgauges.DefInstance.iatg.Visible = True
                'frmAgauges.DefInstance.ectgm.Visible = False
                'frmAgauges.DefInstance.ectg.Visible = True
        End Select
        
    End Sub
    Private Sub frmMain_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        'Save Form Settings to Registry
        FormHeight("frmMain") = Me.Height
        FormWidth("frmMain") = Me.Width
        FormLeft("frmMain") = Me.Left
        FormTop("frmMain") = Me.Top
    End Sub
    Private Sub frmMain_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        Me.BackgroundImage = ResizeBitmap(BackGroundPic.Image, Me.Width, Me.Height, True)

    End Sub
#End Region
#Region "Com Port Init,Open,Close stuff"
    Public Sub InitCommPort()
        Try
            With moRS232
                .BaudRate = bRate
                .DataBit = dBit
                .Parity = Rs232.DataParity.Parity_None
                .StopBit = Rs232.DataStopBit.StopBit_1
                .Port = cPort
                .BufferSize = 512
                .Timeout = 1200
                .RxBufferThreshold = 1
            End With
            Me.mnuConnect.Enabled = True
        Catch Ex As Exception
            MessageBox.Show(Ex.Message, "Connection Error", MessageBoxButtons.OK)
        End Try
    End Sub
    Public Sub OpenComPort()
        If moRS232.IsOpen = True Then
            moRS232.Close()
        End If
        Try
            moRS232.Open()
            moRS232.EnableEvents()
            mnuConnect.Text = "Disconnect"
            mnuStartLogging.Enabled = True
            StatusBar1.Panels(2).Text = "Connected"
            StatusBar1.Panels(2).Icon = Me.Icon

        Catch Ex As Exception
            MessageBox.Show(Ex.Message, "Connection Error", MessageBoxButtons.OK)
        End Try
    End Sub
    Public Sub CloseComPort()

        Try
            moRS232.Close()
            StatusBar1.Panels(2).Text = "Disconnected"
            StatusBar1.Panels(2).Icon = Nothing
            mnuConnect.Text = "Connect"
            mnuStartLogging.Enabled = False
        Catch Ex As Exception
            MessageBox.Show(Ex.Message, "Connection Error", MessageBoxButtons.OK)
        End Try
    End Sub
#End Region
#Region "Beta ComPort Data Polling Routines"
    Sub PollData()

        If datalog = True And dRcvd = False Then
            If moRS232.IsOpen Then
                'If SensorCount < 9 Then 'IF SENSOR ADDRESS IS 255 (unused) we dont need to send a byte
                'SensorCount = SensorCount + 1
                cmd = Chr(Sensor(SensorCount))
                moRS232.Write(cmd)
                toTimer.Enabled = True
                Me.Text = "+"
                'Else
                '   SensorCount = 0
                'End If
        End If
        Application.DoEvents()
        End If
    End Sub
    Private Sub moRS232_CommEvent1(ByVal Source As Rs232, ByVal Mask As Rs232.EventMasks) Handles moRS232.CommEvent
        toTimer.Enabled = False
        If (Mask And Rs232.EventMasks.RxChar) > 0 Then
            dRcvd = True
            Me.Text = "x"
            Try
                buffer = CInt(Val(Asc(Source.InputStreamString)))
                moRS232.PurgeBuffer(Rs232.PurgeBuffers.TxClear Or Rs232.PurgeBuffers.RXClear)
                General.currentsensor = SensorCount

                Select Case EcuType
                    Case "OBD0"
                        If SensorCount >= 0 And SensorCount < 6 Or SensorCount > 7 Then
                            ProcessOBD0(buffer, 0)
                        End If
                        If SensorCount = 6 Then 'rpmlo
                            rpmlo = buffer
                        End If
                        If SensorCount = 7 Then 'rpmhi
                            rpmhi = buffer
                            ProcessOBD0(rpmhi, rpmlo)
                        End If
                    Case "OBD1"
                        If SensorCount >= 0 And SensorCount < 6 Or SensorCount > 7 Then
                            ProcessOBD1(buffer, 0)
                        End If
                        If SensorCount = 6 Then 'rpmlo
                            rpmlo = buffer
                        End If
                        If SensorCount = 7 Then 'rpmhi
                            rpmhi = buffer
                            ProcessOBD1(rpmhi, rpmlo)
                        End If
                    Case "NG55"
                        If SensorCount >= 0 And SensorCount < 6 Or SensorCount > 7 Then
                            ProcessNG55(buffer, 0)
                        End If
                        If SensorCount = 6 Then 'rpmlo
                            rpmlo = buffer
                        End If
                        If SensorCount = 7 Then 'rpmhi
                            rpmhi = buffer
                            ProcessNG55(rpmhi, rpmlo)
                        End If

                End Select
                If SensorCount >= 9 Then
                    SensorCount = 0
                Else
                    SensorCount = SensorCount + 1
                    StatusBar1.Panels(6).Text = CStr(SensorCount) 'temporary debug info
                End If
                dRcvd = False
            Catch ex As Exception
                MessageBox.Show(ex.Message.ToString, "Error", MessageBoxButtons.OK)
            End Try
        End If
        PollData()
    End Sub
    Private Sub toTimer_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles toTimer.Tick
        toTimer.Enabled = False
        Me.Text = "x"
        If dRcvd = False Then

            StatusBar1.Panels(6).Text = CStr(SensorCount) 'temporary debug info
            PollData()
        End If

    End Sub
#End Region
#Region "Backgroung Image Code"
    Public Shared Function ResizeBitmap(ByVal bmpBitmap As Bitmap, ByVal snglBoundingWidth As Single, ByVal snglBoundingHeight As Single, Optional ByVal blnHighQuality As Boolean = False) As Bitmap
        Dim snglNewWidth, snglNewHeight As Single

        If snglBoundingWidth > 1 And snglBoundingHeight > 1 Then
            If (bmpBitmap.Height / bmpBitmap.Width) > (snglBoundingHeight / snglBoundingWidth) Then
                snglNewHeight = Int(snglBoundingHeight)
                snglNewWidth = Int((bmpBitmap.Width / bmpBitmap.Height) * snglNewHeight)
            Else
                snglNewWidth = Int(snglBoundingWidth)
                snglNewHeight = Int((bmpBitmap.Height / bmpBitmap.Width) * snglNewWidth)
            End If
        Else
            snglNewWidth = bmpBitmap.Width * snglBoundingWidth
            snglNewHeight = bmpBitmap.Height * snglBoundingHeight
        End If

        Dim bmpNewBitmap As System.Drawing.Bitmap

        bmpNewBitmap = New Bitmap(bmpBitmap, snglNewWidth, snglNewHeight)

        If blnHighQuality = True Then
            Dim g As Graphics = Graphics.FromImage(bmpNewBitmap)

            g.InterpolationMode = InterpolationMode.HighQualityBicubic

            g.DrawImage(bmpBitmap, 0, 0, bmpNewBitmap.Width, bmpNewBitmap.Height)
        End If

        Return bmpNewBitmap
    End Function
#End Region





    
End Class
