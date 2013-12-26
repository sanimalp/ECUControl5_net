Public Class frmDebug
    Inherits System.Windows.Forms.Form
#Region "Form Access support"
    Private Shared m_vb6FormDefInstance As frmDebug
    Private Shared m_InitializingDefInstance As Boolean
    Public Shared Property DefInstance() As frmDebug
        Get
            If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_vb6FormDefInstance = New frmDebug
                m_InitializingDefInstance = False
            End If
            DefInstance = m_vb6FormDefInstance
        End Get
        Set(ByVal Value As frmDebug)
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
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.Button6 = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(448, 424)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ecu Debug Tools"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(8, 32)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(56, 20)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.Text = ""
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(8, 72)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(56, 20)
        Me.TextBox2.TabIndex = 1
        Me.TextBox2.Text = ""
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(192, 16)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBox3.Size = New System.Drawing.Size(248, 392)
        Me.TextBox3.TabIndex = 2
        Me.TextBox3.Text = "TextBox3"
        '
        'Label1
        '
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.Location = New System.Drawing.Point(8, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(232, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "CMD (1Byte) or Address to read."
        '
        'Label2
        '
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label2.Location = New System.Drawing.Point(8, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Value to write."
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button6)
        Me.GroupBox2.Controls.Add(Me.Button5)
        Me.GroupBox2.Controls.Add(Me.Button4)
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox2.Location = New System.Drawing.Point(8, 104)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(176, 312)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Commands"
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button1.Location = New System.Drawing.Point(24, 24)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 32)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Send CMD"
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button2.Location = New System.Drawing.Point(24, 73)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(80, 32)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Read XRAM"
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button3.Location = New System.Drawing.Point(24, 122)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(80, 32)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Write XRAM"
        '
        'Button4
        '
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button4.Location = New System.Drawing.Point(24, 171)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(80, 32)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Read IRAM"
        '
        'Button5
        '
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button5.Location = New System.Drawing.Point(24, 220)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(80, 32)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "Read ICRAM"
        '
        'Button6
        '
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button6.Location = New System.Drawing.Point(24, 269)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(80, 32)
        Me.Button6.TabIndex = 5
        Me.Button6.Text = "Write ICRAM"
        '
        'frmDebug
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(464, 438)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmDebug"
        Me.Text = "frmDebug"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

End Class
