Imports Microsoft.Win32
Public Class frmGC
    Inherits System.Windows.Forms.Form
    Dim cReg As RegistryKey
#Region "Form Access support"
    Private Shared m_vb6FormDefInstance As frmGC
    Private Shared m_InitializingDefInstance As Boolean
    Public Shared Property DefInstance() As frmGC
        Get
            If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_vb6FormDefInstance = New frmGC
                m_InitializingDefInstance = False
            End If
            DefInstance = m_vb6FormDefInstance
        End Get
        Set(ByVal Value As frmGC)
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
    Public WithEvents frmInfo As System.Windows.Forms.GroupBox
    Public WithEvents chkManual As System.Windows.Forms.CheckBox
    Public WithEvents cboModel As System.Windows.Forms.ComboBox
    Public WithEvents cmdNew As System.Windows.Forms.Button
    Public WithEvents cmdSave As System.Windows.Forms.Button
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
    Friend WithEvents cmdOK As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmGC))
        Me.frmInfo = New System.Windows.Forms.GroupBox
        Me.chkManual = New System.Windows.Forms.CheckBox
        Me.cboModel = New System.Windows.Forms.ComboBox
        Me.cmdNew = New System.Windows.Forms.Button
        Me.cmdSave = New System.Windows.Forms.Button
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
        Me.cmdOK = New System.Windows.Forms.Button
        Me.frmInfo.SuspendLayout()
        Me.SuspendLayout()
        '
        'frmInfo
        '
        Me.frmInfo.BackColor = System.Drawing.SystemColors.Control
        Me.frmInfo.Controls.Add(Me.cmdOK)
        Me.frmInfo.Controls.Add(Me.chkManual)
        Me.frmInfo.Controls.Add(Me.cboModel)
        Me.frmInfo.Controls.Add(Me.cmdNew)
        Me.frmInfo.Controls.Add(Me.cmdSave)
        Me.frmInfo.Controls.Add(Me.txtFinal)
        Me.frmInfo.Controls.Add(Me.txt5th)
        Me.frmInfo.Controls.Add(Me.txt4th)
        Me.frmInfo.Controls.Add(Me.txt3rd)
        Me.frmInfo.Controls.Add(Me.txt2nd)
        Me.frmInfo.Controls.Add(Me.txt1st)
        Me.frmInfo.Controls.Add(Me.Label6)
        Me.frmInfo.Controls.Add(Me.Label5)
        Me.frmInfo.Controls.Add(Me.Label4)
        Me.frmInfo.Controls.Add(Me.Label3)
        Me.frmInfo.Controls.Add(Me.Label2)
        Me.frmInfo.Controls.Add(Me.Label1)
        Me.frmInfo.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.frmInfo.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.frmInfo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.frmInfo.Location = New System.Drawing.Point(8, 8)
        Me.frmInfo.Name = "frmInfo"
        Me.frmInfo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.frmInfo.Size = New System.Drawing.Size(345, 209)
        Me.frmInfo.TabIndex = 20
        Me.frmInfo.TabStop = False
        Me.frmInfo.Text = "Info"
        '
        'chkManual
        '
        Me.chkManual.BackColor = System.Drawing.SystemColors.Control
        Me.chkManual.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkManual.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.chkManual.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkManual.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkManual.Location = New System.Drawing.Point(8, 40)
        Me.chkManual.Name = "chkManual"
        Me.chkManual.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkManual.Size = New System.Drawing.Size(233, 17)
        Me.chkManual.TabIndex = 17
        Me.chkManual.Text = "Manual Transmission"
        '
        'cboModel
        '
        Me.cboModel.BackColor = System.Drawing.SystemColors.Window
        Me.cboModel.Cursor = System.Windows.Forms.Cursors.Default
        Me.cboModel.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboModel.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboModel.Location = New System.Drawing.Point(8, 16)
        Me.cboModel.Name = "cboModel"
        Me.cboModel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboModel.Size = New System.Drawing.Size(329, 22)
        Me.cboModel.TabIndex = 16
        Me.cboModel.Text = "Combo1"
        '
        'cmdNew
        '
        Me.cmdNew.BackColor = System.Drawing.SystemColors.Control
        Me.cmdNew.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdNew.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmdNew.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNew.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdNew.Location = New System.Drawing.Point(104, 80)
        Me.cmdNew.Name = "cmdNew"
        Me.cmdNew.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdNew.TabIndex = 15
        Me.cmdNew.Text = "New"
        '
        'cmdSave
        '
        Me.cmdSave.BackColor = System.Drawing.SystemColors.Control
        Me.cmdSave.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdSave.Enabled = False
        Me.cmdSave.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmdSave.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSave.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdSave.Location = New System.Drawing.Point(104, 108)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdSave.TabIndex = 14
        Me.cmdSave.Text = "Save"
        '
        'txtFinal
        '
        Me.txtFinal.AcceptsReturn = True
        Me.txtFinal.AutoSize = False
        Me.txtFinal.BackColor = System.Drawing.SystemColors.Window
        Me.txtFinal.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFinal.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFinal.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtFinal.Location = New System.Drawing.Point(40, 184)
        Me.txtFinal.MaxLength = 0
        Me.txtFinal.Name = "txtFinal"
        Me.txtFinal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtFinal.Size = New System.Drawing.Size(41, 19)
        Me.txtFinal.TabIndex = 11
        Me.txtFinal.Text = "1.00"
        '
        'txt5th
        '
        Me.txt5th.AcceptsReturn = True
        Me.txt5th.AutoSize = False
        Me.txt5th.BackColor = System.Drawing.SystemColors.Window
        Me.txt5th.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt5th.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt5th.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txt5th.Location = New System.Drawing.Point(40, 160)
        Me.txt5th.MaxLength = 0
        Me.txt5th.Name = "txt5th"
        Me.txt5th.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt5th.Size = New System.Drawing.Size(41, 19)
        Me.txt5th.TabIndex = 9
        Me.txt5th.Text = "1.00"
        '
        'txt4th
        '
        Me.txt4th.AcceptsReturn = True
        Me.txt4th.AutoSize = False
        Me.txt4th.BackColor = System.Drawing.SystemColors.Window
        Me.txt4th.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt4th.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt4th.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txt4th.Location = New System.Drawing.Point(40, 136)
        Me.txt4th.MaxLength = 0
        Me.txt4th.Name = "txt4th"
        Me.txt4th.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt4th.Size = New System.Drawing.Size(41, 19)
        Me.txt4th.TabIndex = 7
        Me.txt4th.Text = "1.00"
        '
        'txt3rd
        '
        Me.txt3rd.AcceptsReturn = True
        Me.txt3rd.AutoSize = False
        Me.txt3rd.BackColor = System.Drawing.SystemColors.Window
        Me.txt3rd.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt3rd.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt3rd.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txt3rd.Location = New System.Drawing.Point(40, 112)
        Me.txt3rd.MaxLength = 0
        Me.txt3rd.Name = "txt3rd"
        Me.txt3rd.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt3rd.Size = New System.Drawing.Size(41, 19)
        Me.txt3rd.TabIndex = 5
        Me.txt3rd.Text = "1.00"
        '
        'txt2nd
        '
        Me.txt2nd.AcceptsReturn = True
        Me.txt2nd.AutoSize = False
        Me.txt2nd.BackColor = System.Drawing.SystemColors.Window
        Me.txt2nd.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt2nd.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt2nd.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txt2nd.Location = New System.Drawing.Point(40, 88)
        Me.txt2nd.MaxLength = 0
        Me.txt2nd.Name = "txt2nd"
        Me.txt2nd.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt2nd.Size = New System.Drawing.Size(41, 19)
        Me.txt2nd.TabIndex = 3
        Me.txt2nd.Text = "1.00"
        '
        'txt1st
        '
        Me.txt1st.AcceptsReturn = True
        Me.txt1st.AutoSize = False
        Me.txt1st.BackColor = System.Drawing.SystemColors.Window
        Me.txt1st.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt1st.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt1st.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txt1st.Location = New System.Drawing.Point(40, 64)
        Me.txt1st.MaxLength = 0
        Me.txt1st.Name = "txt1st"
        Me.txt1st.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt1st.Size = New System.Drawing.Size(41, 19)
        Me.txt1st.TabIndex = 1
        Me.txt1st.Text = "1.00"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(8, 184)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(33, 17)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Final"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(8, 160)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(33, 17)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "5th"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(8, 136)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(33, 17)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "4th"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(8, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(33, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "3rd"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(8, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(33, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "2nd"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(8, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(33, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "1st"
        '
        'cmdOK
        '
        Me.cmdOK.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmdOK.Location = New System.Drawing.Point(104, 136)
        Me.cmdOK.Name = "cmdOK"
        Me.cmdOK.TabIndex = 18
        Me.cmdOK.Text = "OK"
        '
        'frmGC
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(360, 222)
        Me.Controls.Add(Me.frmInfo)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmGC"
        Me.Text = "Gear Correction Selection"
        Me.frmInfo.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub cmdNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNew.Click
        cboModel.Items.Clear()
        cboModel.Text = "Add Description Here"
        txt1st.Text = "1.00"
        txt2nd.Text = "1.00"
        txt3rd.Text = "1.00"
        txt4th.Text = "1.00"
        txt5th.Text = "1.00"
        txtFinal.Text = "1.00"
        chkManual.Checked = True
        cmdSave.Enabled = True

    End Sub
    Private Sub chkManual_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkManual.CheckedChanged
        If chkManual.Checked = False Then
            txt5th.Enabled = False
        Else
            txt5th.Enabled = True
        End If
        cmdSave.Enabled = True
    End Sub
    Private Sub cmdSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        cReg = Registry.CurrentUser.OpenSubKey("EcuControl.Net\\TrannyList\\" & cboModel.Text, True)
        If cReg Is Nothing Then
            cReg = Registry.CurrentUser.CreateSubKey("EcuControl.Net\\TrannyList\\" & cboModel.Text)
        End If
        cReg.SetValue("1st", txt1st.Text)
        cReg.SetValue("2nd", txt2nd.Text)
        cReg.SetValue("3rd", txt3rd.Text)
        cReg.SetValue("4th", txt4th.Text)
        cReg.SetValue("5th", txt5th.Text)
        cReg.SetValue("Final", txtFinal.Text)
        cReg.SetValue("Manual", chkManual.Checked)
        cmdSave.Enabled = False
        InitCbo()
    End Sub
    Private Sub frmGC_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        InitCbo()
    End Sub
    Private Sub cboModel_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboModel.SelectedIndexChanged
        cReg = Registry.CurrentUser.OpenSubKey("EcuControl.Net\\TrannyList\\" & cboModel.Text, True)
        If cReg Is Nothing Then
            MessageBox.Show("Entry Not Found", "Tranny List Error", MessageBoxButtons.OK)
        Else
            txt1st.Text = cReg.GetValue("1st")
            txt2nd.Text = cReg.GetValue("2nd")
            txt3rd.Text = cReg.GetValue("3rd")
            txt4th.Text = cReg.GetValue("4th")
            txt5th.Text = cReg.GetValue("5th")
            txtFinal.Text = cReg.GetValue("Final")
            If cReg.GetValue("Manual") = "True" Then
                chkManual.Checked = True
            Else
                chkManual.Checked = False

            End If
        End If
    End Sub
    Public Sub InitCbo()
        Dim TrannyName As String
        cReg = Registry.CurrentUser.OpenSubKey("EcuControl.Net\\TrannyList", True)
        If cReg Is Nothing Then
            cReg = Registry.CurrentUser.CreateSubKey("EcuControl.Net\\TrannyList")
            cReg = Registry.CurrentUser.OpenSubKey("EcuControl.Net\\TrannyList", True)
        End If
        For Each TrannyName In cReg.GetSubKeyNames()
            cboModel.Items.Add(TrannyName)
        Next
        cboModel.Text = TrannyName
    End Sub
    Private Sub cmdOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOK.Click
        Me.DefInstance.Hide()
    End Sub
End Class
