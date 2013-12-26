Public Class frmCustomColor
    Inherits System.Windows.Forms.Form
#Region "Form Access support"
    Private Shared m_vb6FormDefInstance As frmCustomColor
    Private Shared m_InitializingDefInstance As Boolean
    Public Shared Property DefInstance() As frmCustomColor
        Get
            If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_vb6FormDefInstance = New frmCustomColor
                m_InitializingDefInstance = False
            End If
            DefInstance = m_vb6FormDefInstance
        End Get
        Set(ByVal Value As frmCustomColor)
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
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Public WithEvents previewLED As AxNUMLEDLib.AxNumLED
    Friend WithEvents pbOnColor As System.Windows.Forms.PictureBox
    Friend WithEvents pbOffColor As System.Windows.Forms.PictureBox
    Friend WithEvents pbBackColor As System.Windows.Forms.PictureBox
    Friend WithEvents cmdOnColor As System.Windows.Forms.Button
    Friend WithEvents cmdOffColor As System.Windows.Forms.Button
    Friend WithEvents cmdBackColor As System.Windows.Forms.Button
    Friend WithEvents cmdOK As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmCustomColor))
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog
        Me.cmdOnColor = New System.Windows.Forms.Button
        Me.cmdOffColor = New System.Windows.Forms.Button
        Me.cmdBackColor = New System.Windows.Forms.Button
        Me.previewLED = New AxNUMLEDLib.AxNumLED
        Me.pbOnColor = New System.Windows.Forms.PictureBox
        Me.pbOffColor = New System.Windows.Forms.PictureBox
        Me.pbBackColor = New System.Windows.Forms.PictureBox
        Me.cmdOK = New System.Windows.Forms.Button
        CType(Me.previewLED, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdOnColor
        '
        Me.cmdOnColor.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmdOnColor.Location = New System.Drawing.Point(8, 16)
        Me.cmdOnColor.Name = "cmdOnColor"
        Me.cmdOnColor.Size = New System.Drawing.Size(88, 32)
        Me.cmdOnColor.TabIndex = 0
        Me.cmdOnColor.Text = "Digit On Color"
        '
        'cmdOffColor
        '
        Me.cmdOffColor.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmdOffColor.Location = New System.Drawing.Point(8, 56)
        Me.cmdOffColor.Name = "cmdOffColor"
        Me.cmdOffColor.Size = New System.Drawing.Size(88, 32)
        Me.cmdOffColor.TabIndex = 104
        Me.cmdOffColor.Text = "Digit Off Color"
        '
        'cmdBackColor
        '
        Me.cmdBackColor.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmdBackColor.Location = New System.Drawing.Point(8, 96)
        Me.cmdBackColor.Name = "cmdBackColor"
        Me.cmdBackColor.Size = New System.Drawing.Size(88, 32)
        Me.cmdBackColor.TabIndex = 105
        Me.cmdBackColor.Text = "Back Color"
        '
        'previewLED
        '
        Me.previewLED.Location = New System.Drawing.Point(160, 32)
        Me.previewLED.Name = "previewLED"
        Me.previewLED.OcxState = CType(resources.GetObject("previewLED.OcxState"), System.Windows.Forms.AxHost.State)
        Me.previewLED.Size = New System.Drawing.Size(105, 73)
        Me.previewLED.TabIndex = 107
        '
        'pbOnColor
        '
        Me.pbOnColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbOnColor.Location = New System.Drawing.Point(112, 16)
        Me.pbOnColor.Name = "pbOnColor"
        Me.pbOnColor.Size = New System.Drawing.Size(24, 24)
        Me.pbOnColor.TabIndex = 108
        Me.pbOnColor.TabStop = False
        '
        'pbOffColor
        '
        Me.pbOffColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbOffColor.Location = New System.Drawing.Point(112, 56)
        Me.pbOffColor.Name = "pbOffColor"
        Me.pbOffColor.Size = New System.Drawing.Size(24, 24)
        Me.pbOffColor.TabIndex = 109
        Me.pbOffColor.TabStop = False
        '
        'pbBackColor
        '
        Me.pbBackColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbBackColor.Location = New System.Drawing.Point(112, 96)
        Me.pbBackColor.Name = "pbBackColor"
        Me.pbBackColor.Size = New System.Drawing.Size(24, 24)
        Me.pbBackColor.TabIndex = 110
        Me.pbBackColor.TabStop = False
        '
        'cmdOK
        '
        Me.cmdOK.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmdOK.Location = New System.Drawing.Point(8, 136)
        Me.cmdOK.Name = "cmdOK"
        Me.cmdOK.Size = New System.Drawing.Size(88, 32)
        Me.cmdOK.TabIndex = 111
        Me.cmdOK.Text = "OK"
        '
        'frmCustomColor
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(280, 198)
        Me.Controls.Add(Me.cmdOK)
        Me.Controls.Add(Me.pbBackColor)
        Me.Controls.Add(Me.pbOffColor)
        Me.Controls.Add(Me.pbOnColor)
        Me.Controls.Add(Me.previewLED)
        Me.Controls.Add(Me.cmdBackColor)
        Me.Controls.Add(Me.cmdOffColor)
        Me.Controls.Add(Me.cmdOnColor)
        Me.Name = "frmCustomColor"
        Me.Text = "Customize Digital Gauges"
        CType(Me.previewLED, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub cmdOnColor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOnColor.Click
        ColorDialog1.Color = pbOnColor.BackColor
        ColorDialog1.ShowDialog()
        previewLED.OnColor = ColorDialog1.Color
        pbOnColor.BackColor = ColorDialog1.Color
    End Sub
    Private Sub frmCustomColor_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If General.OnColor <> 1 Then
            With previewLED
                .BackColor = Color.FromArgb(General.BackColor)
                .OnColor = Color.FromArgb(General.OnColor)
                .OffColor = Color.FromArgb(General.OffColor)
            End With
        Else

            pbOnColor.BackColor = previewLED.OnColor
            pbOffColor.BackColor = previewLED.OffColor
            pbBackColor.BackColor = previewLED.BackColor

        End If
        Me.BackColor = previewLED.BackColor
        pbOnColor.BackColor = previewLED.OnColor
        pbOffColor.BackColor = previewLED.OffColor
        pbBackColor.BackColor = previewLED.BackColor
    End Sub
    Private Sub cmdOffColor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOffColor.Click
        ColorDialog1.Color = pbOffColor.BackColor
        ColorDialog1.ShowDialog()
        previewLED.OffColor = ColorDialog1.Color
        pbOffColor.BackColor = ColorDialog1.Color
    End Sub
    Private Sub cmdBackColor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBackColor.Click
        ColorDialog1.Color = pbBackColor.BackColor
        ColorDialog1.ShowDialog()
        previewLED.BackColor = ColorDialog1.Color
        pbBackColor.BackColor = ColorDialog1.Color
        Me.BackColor = ColorDialog1.Color
    End Sub
    Private Sub cmdOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOK.Click
        General.OnColor = pbOnColor.BackColor.ToArgb
        General.OffColor = pbOffColor.BackColor.ToArgb
        General.BackColor = pbBackColor.BackColor.ToArgb
        'frmDgauges.DefInstance.gaugeScheme(3)
        Me.Hide()
    End Sub


End Class
