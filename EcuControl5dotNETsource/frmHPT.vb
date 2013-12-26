Friend Class frmHPT
    Inherits System.Windows.Forms.Form
#Region "Form Access support"
    Private Shared m_vb6FormDefInstance As frmHPT
    Private Shared m_InitializingDefInstance As Boolean
    Public Shared Property DefInstance() As frmHPT
        Get
            If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_vb6FormDefInstance = New frmHPT
                m_InitializingDefInstance = False
            End If
            DefInstance = m_vb6FormDefInstance
        End Get
        Set(ByVal Value As frmHPT)
            m_vb6FormDefInstance = Value
        End Set
    End Property
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
    Public WithEvents cmdLoadGraph As System.Windows.Forms.Button
    Public WithEvents cmdSaveGraph As System.Windows.Forms.Button
    Public WithEvents cmdClearTable As System.Windows.Forms.Button
    Public WithEvents pbox As System.Windows.Forms.PictureBox
    Public WithEvents cmdGraph As System.Windows.Forms.Button
    Public WithEvents hptLbl As System.Windows.Forms.Label
    Public WithEvents torqueLbl As System.Windows.Forms.Label
    Public WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents cmdGraphRPMvsBoost As System.Windows.Forms.Button
    Friend WithEvents HPTGrid As AxMSFlexGridLib.AxMSFlexGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmHPT))
        Me.cmdLoadGraph = New System.Windows.Forms.Button
        Me.cmdSaveGraph = New System.Windows.Forms.Button
        Me.cmdClearTable = New System.Windows.Forms.Button
        Me.pbox = New System.Windows.Forms.PictureBox
        Me.cmdGraph = New System.Windows.Forms.Button
        Me.hptLbl = New System.Windows.Forms.Label
        Me.torqueLbl = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.HPTGrid = New AxMSFlexGridLib.AxMSFlexGrid
        Me.cmdGraphRPMvsBoost = New System.Windows.Forms.Button
        CType(Me.HPTGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdLoadGraph
        '
        Me.cmdLoadGraph.BackColor = System.Drawing.SystemColors.Control
        Me.cmdLoadGraph.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdLoadGraph.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmdLoadGraph.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLoadGraph.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdLoadGraph.Location = New System.Drawing.Point(576, 440)
        Me.cmdLoadGraph.Name = "cmdLoadGraph"
        Me.cmdLoadGraph.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdLoadGraph.Size = New System.Drawing.Size(72, 41)
        Me.cmdLoadGraph.TabIndex = 114
        Me.cmdLoadGraph.Text = "Comp Graph"
        '
        'cmdSaveGraph
        '
        Me.cmdSaveGraph.BackColor = System.Drawing.SystemColors.Control
        Me.cmdSaveGraph.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdSaveGraph.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmdSaveGraph.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSaveGraph.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdSaveGraph.Location = New System.Drawing.Point(672, 440)
        Me.cmdSaveGraph.Name = "cmdSaveGraph"
        Me.cmdSaveGraph.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdSaveGraph.Size = New System.Drawing.Size(72, 41)
        Me.cmdSaveGraph.TabIndex = 113
        Me.cmdSaveGraph.Text = "Save Graph"
        '
        'cmdClearTable
        '
        Me.cmdClearTable.BackColor = System.Drawing.SystemColors.Control
        Me.cmdClearTable.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdClearTable.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmdClearTable.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClearTable.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdClearTable.Location = New System.Drawing.Point(288, 440)
        Me.cmdClearTable.Name = "cmdClearTable"
        Me.cmdClearTable.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdClearTable.Size = New System.Drawing.Size(72, 41)
        Me.cmdClearTable.TabIndex = 112
        Me.cmdClearTable.Text = "Clear Table"
        '
        'pbox
        '
        Me.pbox.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.pbox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbox.Cursor = System.Windows.Forms.Cursors.Default
        Me.pbox.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pbox.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pbox.Location = New System.Drawing.Point(280, 72)
        Me.pbox.Name = "pbox"
        Me.pbox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.pbox.Size = New System.Drawing.Size(464, 352)
        Me.pbox.TabIndex = 108
        Me.pbox.TabStop = False
        '
        'cmdGraph
        '
        Me.cmdGraph.BackColor = System.Drawing.SystemColors.Control
        Me.cmdGraph.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdGraph.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmdGraph.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGraph.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdGraph.Location = New System.Drawing.Point(384, 440)
        Me.cmdGraph.Name = "cmdGraph"
        Me.cmdGraph.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdGraph.Size = New System.Drawing.Size(72, 41)
        Me.cmdGraph.TabIndex = 107
        Me.cmdGraph.Text = "Graph HP/Torque"
        '
        'hptLbl
        '
        Me.hptLbl.BackColor = System.Drawing.SystemColors.Control
        Me.hptLbl.Cursor = System.Windows.Forms.Cursors.Default
        Me.hptLbl.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.hptLbl.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hptLbl.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.hptLbl.Location = New System.Drawing.Point(280, 32)
        Me.hptLbl.Name = "hptLbl"
        Me.hptLbl.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.hptLbl.Size = New System.Drawing.Size(200, 17)
        Me.hptLbl.TabIndex = 111
        Me.hptLbl.Text = "HP"
        '
        'torqueLbl
        '
        Me.torqueLbl.BackColor = System.Drawing.SystemColors.Control
        Me.torqueLbl.Cursor = System.Windows.Forms.Cursors.Default
        Me.torqueLbl.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.torqueLbl.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.torqueLbl.ForeColor = System.Drawing.Color.Red
        Me.torqueLbl.Location = New System.Drawing.Point(280, 48)
        Me.torqueLbl.Name = "torqueLbl"
        Me.torqueLbl.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.torqueLbl.Size = New System.Drawing.Size(193, 17)
        Me.torqueLbl.TabIndex = 110
        Me.torqueLbl.Text = "Torque"
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.SystemColors.Control
        Me.Label16.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label16.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label16.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label16.Location = New System.Drawing.Point(8, 8)
        Me.Label16.Name = "Label16"
        Me.Label16.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label16.Size = New System.Drawing.Size(217, 17)
        Me.Label16.TabIndex = 109
        Me.Label16.Text = "Each line = 10 HP/Torque on graph"
        '
        'HPTGrid
        '
        Me.HPTGrid.Location = New System.Drawing.Point(8, 32)
        Me.HPTGrid.Name = "HPTGrid"
        Me.HPTGrid.OcxState = CType(resources.GetObject("HPTGrid.OcxState"), System.Windows.Forms.AxHost.State)
        Me.HPTGrid.Size = New System.Drawing.Size(264, 456)
        Me.HPTGrid.TabIndex = 115
        '
        'cmdGraphRPMvsBoost
        '
        Me.cmdGraphRPMvsBoost.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmdGraphRPMvsBoost.Location = New System.Drawing.Point(480, 440)
        Me.cmdGraphRPMvsBoost.Name = "cmdGraphRPMvsBoost"
        Me.cmdGraphRPMvsBoost.Size = New System.Drawing.Size(72, 41)
        Me.cmdGraphRPMvsBoost.TabIndex = 116
        Me.cmdGraphRPMvsBoost.Text = "Graph RPM/Boost"
        '
        'frmHPT
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(752, 494)
        Me.Controls.Add(Me.cmdGraphRPMvsBoost)
        Me.Controls.Add(Me.HPTGrid)
        Me.Controls.Add(Me.cmdLoadGraph)
        Me.Controls.Add(Me.cmdSaveGraph)
        Me.Controls.Add(Me.cmdClearTable)
        Me.Controls.Add(Me.pbox)
        Me.Controls.Add(Me.cmdGraph)
        Me.Controls.Add(Me.hptLbl)
        Me.Controls.Add(Me.torqueLbl)
        Me.Controls.Add(Me.Label16)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmHPT"
        Me.Text = "HP/Torque Trace"
        CType(Me.HPTGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
#Region "Form Events"
    Private Sub frmHPT_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim I As Integer

        With HPTGrid

        End With
    End Sub
#End Region




    Private Sub cmdClearTable_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClearTable.Click

    End Sub
End Class
