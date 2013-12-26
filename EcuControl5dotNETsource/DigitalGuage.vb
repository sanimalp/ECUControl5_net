Public Class DigitalGuage
    Inherits System.Windows.Forms.Form
#Region "Form Access support"
    Private Shared m_vb6FormDefInstance As DigitalGuage
    Private Shared m_InitializingDefInstance As Boolean
    Public Shared Property DefInstance() As DigitalGuage
        Get
            If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_vb6FormDefInstance = New DigitalGuage
                m_InitializingDefInstance = False
            End If
            DefInstance = m_vb6FormDefInstance
        End Get
        Set(ByVal Value As DigitalGuage)
            m_vb6FormDefInstance = Value
        End Set
    End Property
#End Region

    Private displayinformation As Boolean = False

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
    Public WithEvents SpeedDisp As System.Windows.Forms.TextBox
    Public WithEvents SpeedLabel As System.Windows.Forms.Label
    Public WithEvents RPMDisp As System.Windows.Forms.TextBox
    Public WithEvents RPMLabel As System.Windows.Forms.Label
    Public WithEvents AirFuelDisp As System.Windows.Forms.TextBox
    Public WithEvents AirFuelLabel As System.Windows.Forms.Label
    Public WithEvents IATDisp As System.Windows.Forms.TextBox
    Public WithEvents ECTDisp As System.Windows.Forms.TextBox
    Public WithEvents TPSLabel As System.Windows.Forms.Label
    Public WithEvents IATLabel As System.Windows.Forms.Label
    Public WithEvents ECTLabel As System.Windows.Forms.Label
    Public WithEvents MAPLabel As System.Windows.Forms.Label
    Public WithEvents VTECLabel As System.Windows.Forms.Label
    Public WithEvents MAPDisp As System.Windows.Forms.TextBox
    Public WithEvents TPSDisp As System.Windows.Forms.TextBox
    Public WithEvents VTECDisp As System.Windows.Forms.TextBox
    Friend WithEvents DiplayMenu As System.Windows.Forms.MainMenu
    Private WithEvents DisplayMenu As System.Windows.Forms.MenuItem
    Friend WithEvents DisplayOn As System.Windows.Forms.MenuItem
    Friend WithEvents DisplayOff As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(DigitalGuage))
        Me.SpeedDisp = New System.Windows.Forms.TextBox
        Me.SpeedLabel = New System.Windows.Forms.Label
        Me.RPMDisp = New System.Windows.Forms.TextBox
        Me.RPMLabel = New System.Windows.Forms.Label
        Me.AirFuelDisp = New System.Windows.Forms.TextBox
        Me.AirFuelLabel = New System.Windows.Forms.Label
        Me.IATLabel = New System.Windows.Forms.Label
        Me.IATDisp = New System.Windows.Forms.TextBox
        Me.ECTDisp = New System.Windows.Forms.TextBox
        Me.ECTLabel = New System.Windows.Forms.Label
        Me.MAPDisp = New System.Windows.Forms.TextBox
        Me.MAPLabel = New System.Windows.Forms.Label
        Me.TPSDisp = New System.Windows.Forms.TextBox
        Me.TPSLabel = New System.Windows.Forms.Label
        Me.VTECDisp = New System.Windows.Forms.TextBox
        Me.VTECLabel = New System.Windows.Forms.Label
        Me.DiplayMenu = New System.Windows.Forms.MainMenu
        Me.DisplayMenu = New System.Windows.Forms.MenuItem
        Me.DisplayOn = New System.Windows.Forms.MenuItem
        Me.DisplayOff = New System.Windows.Forms.MenuItem
        Me.SuspendLayout()
        '
        'SpeedDisp
        '
        Me.SpeedDisp.AcceptsReturn = True
        Me.SpeedDisp.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.SpeedDisp.Enabled = False
        Me.SpeedDisp.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SpeedDisp.Location = New System.Drawing.Point(248, 256)
        Me.SpeedDisp.MaxLength = 0
        Me.SpeedDisp.Name = "SpeedDisp"
        Me.SpeedDisp.ReadOnly = True
        Me.SpeedDisp.Size = New System.Drawing.Size(152, 49)
        Me.SpeedDisp.TabIndex = 0
        Me.SpeedDisp.Text = ""
        Me.SpeedDisp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'SpeedLabel
        '
        Me.SpeedLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SpeedLabel.Location = New System.Drawing.Point(248, 232)
        Me.SpeedLabel.Name = "SpeedLabel"
        Me.SpeedLabel.Size = New System.Drawing.Size(56, 23)
        Me.SpeedLabel.TabIndex = 1
        Me.SpeedLabel.Text = "Speed"
        Me.SpeedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RPMDisp
        '
        Me.RPMDisp.AcceptsReturn = True
        Me.RPMDisp.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.RPMDisp.Enabled = False
        Me.RPMDisp.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RPMDisp.Location = New System.Drawing.Point(16, 48)
        Me.RPMDisp.MaxLength = 0
        Me.RPMDisp.Name = "RPMDisp"
        Me.RPMDisp.ReadOnly = True
        Me.RPMDisp.Size = New System.Drawing.Size(176, 49)
        Me.RPMDisp.TabIndex = 2
        Me.RPMDisp.Text = ""
        Me.RPMDisp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RPMLabel
        '
        Me.RPMLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RPMLabel.Location = New System.Drawing.Point(16, 24)
        Me.RPMLabel.Name = "RPMLabel"
        Me.RPMLabel.Size = New System.Drawing.Size(48, 24)
        Me.RPMLabel.TabIndex = 3
        Me.RPMLabel.Text = "RPM"
        '
        'AirFuelDisp
        '
        Me.AirFuelDisp.AcceptsReturn = True
        Me.AirFuelDisp.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.AirFuelDisp.Enabled = False
        Me.AirFuelDisp.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AirFuelDisp.Location = New System.Drawing.Point(16, 152)
        Me.AirFuelDisp.MaxLength = 0
        Me.AirFuelDisp.Name = "AirFuelDisp"
        Me.AirFuelDisp.ReadOnly = True
        Me.AirFuelDisp.Size = New System.Drawing.Size(176, 49)
        Me.AirFuelDisp.TabIndex = 4
        Me.AirFuelDisp.Text = ""
        Me.AirFuelDisp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'AirFuelLabel
        '
        Me.AirFuelLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AirFuelLabel.Location = New System.Drawing.Point(16, 128)
        Me.AirFuelLabel.Name = "AirFuelLabel"
        Me.AirFuelLabel.Size = New System.Drawing.Size(120, 23)
        Me.AirFuelLabel.TabIndex = 5
        Me.AirFuelLabel.Text = "Air/Fuel Value"
        '
        'IATLabel
        '
        Me.IATLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IATLabel.Location = New System.Drawing.Point(16, 232)
        Me.IATLabel.Name = "IATLabel"
        Me.IATLabel.Size = New System.Drawing.Size(40, 23)
        Me.IATLabel.TabIndex = 6
        Me.IATLabel.Text = "IAT"
        '
        'IATDisp
        '
        Me.IATDisp.AcceptsReturn = True
        Me.IATDisp.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.IATDisp.Enabled = False
        Me.IATDisp.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IATDisp.Location = New System.Drawing.Point(16, 256)
        Me.IATDisp.MaxLength = 0
        Me.IATDisp.Name = "IATDisp"
        Me.IATDisp.ReadOnly = True
        Me.IATDisp.Size = New System.Drawing.Size(176, 49)
        Me.IATDisp.TabIndex = 7
        Me.IATDisp.Text = ""
        Me.IATDisp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ECTDisp
        '
        Me.ECTDisp.AcceptsReturn = True
        Me.ECTDisp.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.ECTDisp.Enabled = False
        Me.ECTDisp.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ECTDisp.Location = New System.Drawing.Point(248, 152)
        Me.ECTDisp.MaxLength = 0
        Me.ECTDisp.Name = "ECTDisp"
        Me.ECTDisp.ReadOnly = True
        Me.ECTDisp.Size = New System.Drawing.Size(152, 49)
        Me.ECTDisp.TabIndex = 10
        Me.ECTDisp.Text = ""
        Me.ECTDisp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ECTLabel
        '
        Me.ECTLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ECTLabel.Location = New System.Drawing.Point(248, 128)
        Me.ECTLabel.Name = "ECTLabel"
        Me.ECTLabel.Size = New System.Drawing.Size(48, 23)
        Me.ECTLabel.TabIndex = 11
        Me.ECTLabel.Text = "ECT"
        '
        'MAPDisp
        '
        Me.MAPDisp.AcceptsReturn = True
        Me.MAPDisp.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.MAPDisp.Enabled = False
        Me.MAPDisp.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MAPDisp.Location = New System.Drawing.Point(248, 48)
        Me.MAPDisp.MaxLength = 0
        Me.MAPDisp.Name = "MAPDisp"
        Me.MAPDisp.ReadOnly = True
        Me.MAPDisp.Size = New System.Drawing.Size(152, 49)
        Me.MAPDisp.TabIndex = 12
        Me.MAPDisp.Text = ""
        Me.MAPDisp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'MAPLabel
        '
        Me.MAPLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MAPLabel.Location = New System.Drawing.Point(248, 24)
        Me.MAPLabel.Name = "MAPLabel"
        Me.MAPLabel.Size = New System.Drawing.Size(136, 23)
        Me.MAPLabel.TabIndex = 13
        Me.MAPLabel.Text = "MAP Sensor Val"
        '
        'TPSDisp
        '
        Me.TPSDisp.AcceptsReturn = True
        Me.TPSDisp.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.TPSDisp.Enabled = False
        Me.TPSDisp.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TPSDisp.Location = New System.Drawing.Point(248, 360)
        Me.TPSDisp.MaxLength = 0
        Me.TPSDisp.Name = "TPSDisp"
        Me.TPSDisp.ReadOnly = True
        Me.TPSDisp.Size = New System.Drawing.Size(152, 49)
        Me.TPSDisp.TabIndex = 14
        Me.TPSDisp.Text = ""
        Me.TPSDisp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TPSLabel
        '
        Me.TPSLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TPSLabel.Location = New System.Drawing.Point(248, 336)
        Me.TPSLabel.Name = "TPSLabel"
        Me.TPSLabel.Size = New System.Drawing.Size(136, 23)
        Me.TPSLabel.TabIndex = 15
        Me.TPSLabel.Text = "TPS %"
        '
        'VTECDisp
        '
        Me.VTECDisp.AcceptsReturn = True
        Me.VTECDisp.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.VTECDisp.Enabled = False
        Me.VTECDisp.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VTECDisp.Location = New System.Drawing.Point(16, 360)
        Me.VTECDisp.MaxLength = 0
        Me.VTECDisp.Name = "VTECDisp"
        Me.VTECDisp.ReadOnly = True
        Me.VTECDisp.Size = New System.Drawing.Size(176, 49)
        Me.VTECDisp.TabIndex = 16
        Me.VTECDisp.Text = ""
        Me.VTECDisp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'VTECLabel
        '
        Me.VTECLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VTECLabel.Location = New System.Drawing.Point(16, 336)
        Me.VTECLabel.Name = "VTECLabel"
        Me.VTECLabel.Size = New System.Drawing.Size(80, 23)
        Me.VTECLabel.TabIndex = 17
        Me.VTECLabel.Text = "VTEC"
        '
        'DiplayMenu
        '
        Me.DiplayMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.DisplayMenu})
        '
        'DisplayMenu
        '
        Me.DisplayMenu.Index = 0
        Me.DisplayMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.DisplayOn, Me.DisplayOff})
        Me.DisplayMenu.Text = "Display"
        '
        'DisplayOn
        '
        Me.DisplayOn.Index = 0
        Me.DisplayOn.Text = "On"
        '
        'DisplayOff
        '
        Me.DisplayOff.Index = 1
        Me.DisplayOff.Text = "Off"
        '
        'DigitalGuage
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(424, 429)
        Me.Controls.Add(Me.VTECLabel)
        Me.Controls.Add(Me.VTECDisp)
        Me.Controls.Add(Me.TPSLabel)
        Me.Controls.Add(Me.TPSDisp)
        Me.Controls.Add(Me.MAPLabel)
        Me.Controls.Add(Me.MAPDisp)
        Me.Controls.Add(Me.ECTLabel)
        Me.Controls.Add(Me.ECTDisp)
        Me.Controls.Add(Me.IATDisp)
        Me.Controls.Add(Me.IATLabel)
        Me.Controls.Add(Me.AirFuelLabel)
        Me.Controls.Add(Me.AirFuelDisp)
        Me.Controls.Add(Me.RPMLabel)
        Me.Controls.Add(Me.RPMDisp)
        Me.Controls.Add(Me.SpeedLabel)
        Me.Controls.Add(Me.SpeedDisp)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Menu = Me.DiplayMenu
        Me.Name = "DigitalGuage"
        Me.Text = "Digital Guage Display"
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub showVals_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DisplayOn.Click
        displayinformation = True
        If LogData = True Then
            While displayinformation = True
                General.UpdateDigitalGuage()
            End While
        End If
    End Sub

    Private Sub hidevals_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DisplayOff.Click
        displayinformation = False
    End Sub

End Class
