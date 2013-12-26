Imports Microsoft.Win32
Module General
    Public O2Type As Integer
    Public MAPType As Integer
    Public currentsensor As Integer
    Public rpm As Long
    Public stockmap As Long
    Public ECT As Long
    Public IAT As Long
    Public O2 As Long
    Public MAP As Long
    Public TPS As Long
    Public VTEC As Boolean
    Public VSS As Long
    Public OneByteRPM As Long
    Public LogData As Boolean = False
    Dim x As Long
    Dim cReg As RegistryKey
    'Dim DigitalGuage As New DigitalGuage

#Region "Settings"
    Public Property ComSettings(ByVal Setting As String)

        Get

            cReg = Registry.CurrentUser.OpenSubKey("EcuControl.Net\\ComSettings", True)
            If cReg Is Nothing Then
                Return "-1"
            Else
                ComSettings = cReg.GetValue(Setting)
                Return ComSettings
            End If
        End Get
        Set(ByVal Value)
            cReg = Registry.CurrentUser.OpenSubKey("EcuControl.Net\\ComSettings", True)
            If cReg Is Nothing Then
                cReg = Registry.CurrentUser.CreateSubKey("EcuControl.Net\\ComSettings")
                cReg.SetValue(Setting, Value)
            Else
                cReg.SetValue(Setting, Value)
            End If
        End Set
    End Property
    Public Property EcuType() As String
        Get

            cReg = Registry.CurrentUser.OpenSubKey("EcuControl.Net\\ECUType", True)
            If cReg Is Nothing Then
                Return "-1"
            Else
                EcuType = cReg.GetValue("EcuType")
                Return EcuType
            End If
        End Get
        Set(ByVal Value As String)
            cReg = Registry.CurrentUser.OpenSubKey("EcuControl.Net\\EcuType", True)
            If cReg Is Nothing Then
                cReg = Registry.CurrentUser.CreateSubKey("EcuControl.Net\\EcuType")
                cReg.SetValue("EcuType", Value)
            Else
                cReg.SetValue("EcuType", Value)
            End If
        End Set
    End Property
    Public Property O2SensorType() As Integer
        Get
            Dim keyString As String
            keyString = "EcuControl.Net\\O2"
            cReg = Registry.CurrentUser.OpenSubKey(keyString, True)
            If cReg Is Nothing Then
                cReg = Registry.CurrentUser.CreateSubKey(keyString)
                cReg.SetValue("Type", 1)
            End If
            keyString = cReg.GetValue("Type")
            Return keyString

        End Get
        Set(ByVal Value As Integer)
            Dim keystring As String
            keystring = "EcuControl.Net\\O2"
            cReg = Registry.CurrentUser.OpenSubKey(keystring, True)
            If cReg Is Nothing Then
                cReg = Registry.CurrentUser.CreateSubKey(keystring)
                cReg.SetValue("Type", Value)
            Else
                cReg.SetValue("Type", Value)
            End If
        End Set
    End Property
    Public Property Standard() As Integer
        '1 = Metric    2 = SAE
        Get
            Dim keyString As String
            keyString = "EcuControl.Net\\Standard"
            cReg = Registry.CurrentUser.OpenSubKey(keyString, True)
            If cReg Is Nothing Then
                cReg = Registry.CurrentUser.CreateSubKey(keyString)
                cReg.SetValue("Type", 1)
            End If
            keyString = cReg.GetValue("Type")
            Return keyString

        End Get
        Set(ByVal Value As Integer)
            Dim keystring As String
            keystring = "EcuControl.Net\\Standard"
            cReg = Registry.CurrentUser.OpenSubKey(keystring, True)
            If cReg Is Nothing Then
                cReg = Registry.CurrentUser.CreateSubKey(keystring)
                cReg.SetValue("Type", Value)
            Else
                cReg.SetValue("Type", Value)
            End If
        End Set
    End Property
    Public Property MapSensorType() As Integer
        Get
            Dim keyString As String
            keyString = "EcuControl.Net\\MAP"
            cReg = Registry.CurrentUser.OpenSubKey(keyString, True)
            If cReg Is Nothing Then
                cReg = Registry.CurrentUser.CreateSubKey(keyString)
                cReg.SetValue("Type", 1)
            End If
            keyString = cReg.GetValue("Type")
            Return keyString

        End Get
        Set(ByVal Value As Integer)
            Dim keystring As String
            keystring = "EcuControl.Net\\MAP"
            cReg = Registry.CurrentUser.OpenSubKey(keystring, True)
            If cReg Is Nothing Then
                cReg = Registry.CurrentUser.CreateSubKey(keystring)
                cReg.SetValue("Type", Value)
            Else
                cReg.SetValue("Type", Value)
            End If
        End Set
    End Property
    Public Property TimeOutSettings() As Integer
        Get

            cReg = Registry.CurrentUser.OpenSubKey("EcuControl.Net\\TimeOut", True)
            If cReg Is Nothing Then
                Return -1
            Else
                TimeOutSettings = cReg.GetValue("ms")
                Return TimeOutSettings
            End If
        End Get
        Set(ByVal Value As Integer)
            cReg = Registry.CurrentUser.OpenSubKey("EcuControl.Net\\TimeOut", True)
            If cReg Is Nothing Then
                cReg = Registry.CurrentUser.CreateSubKey("EcuControl.Net\\TimeOut")
                cReg.SetValue("ms", Value)
            Else
                cReg.SetValue("ms", Value)
            End If
        End Set
    End Property
    Public Property FormHeight(ByVal frm As String)
        Get
            Dim keyString As String
            keyString = "EcuControl.Net\\FormSettings\\Height"
            cReg = Registry.CurrentUser.OpenSubKey(keyString, True)
            If cReg Is Nothing Then
                cReg = Registry.CurrentUser.CreateSubKey(keyString)
                cReg.SetValue(frm, 448)
            End If
            keyString = cReg.GetValue(frm)
            Return keyString

        End Get
        Set(ByVal Value)
            Dim keystring As String
            keystring = "EcuControl.Net\\FormSettings\\Height"
            cReg = Registry.CurrentUser.OpenSubKey(keystring, True)
            If cReg Is Nothing Then
                cReg = Registry.CurrentUser.CreateSubKey(keystring)
                cReg.SetValue(frm, Value)
            Else
                cReg.SetValue(frm, Value)
            End If
        End Set
    End Property
    Public Property FormWidth(ByVal frm As String)
        Get
            Dim keyString As String
            keyString = "EcuControl.Net\\FormSettings\\Width"
            cReg = Registry.CurrentUser.OpenSubKey(keyString, True)
            If cReg Is Nothing Then
                cReg = Registry.CurrentUser.CreateSubKey(keyString)
                cReg.SetValue(frm, 448)
            End If

            keyString = cReg.GetValue(frm)
            Return keyString

        End Get
        Set(ByVal Value)
            Dim keystring As String
            keystring = "EcuControl.Net\\FormSettings\\Width"
            cReg = Registry.CurrentUser.OpenSubKey(keystring, True)
            If cReg Is Nothing Then
                cReg = Registry.CurrentUser.CreateSubKey(keystring)
                cReg.SetValue(frm, Value)
            Else
                cReg.SetValue(frm, Value)
            End If
        End Set
    End Property
    Public Property FormTop(ByVal frm As String)
        Get
            Dim keyString As String
            keyString = "EcuControl.Net\\FormSettings\\Top"
            cReg = Registry.CurrentUser.OpenSubKey(keyString, True)
            If cReg Is Nothing Then
                cReg = Registry.CurrentUser.CreateSubKey(keyString)
                cReg.SetValue(frm, 0)
            End If

            keyString = cReg.GetValue(frm)
            Return keyString

        End Get
        Set(ByVal Value)
            Dim keystring As String
            keystring = "EcuControl.Net\\FormSettings\\Top"
            cReg = Registry.CurrentUser.OpenSubKey(keystring, True)
            If cReg Is Nothing Then
                cReg = Registry.CurrentUser.CreateSubKey(keystring)
                cReg.SetValue(frm, Value)
            Else
                cReg.SetValue(frm, Value)
            End If
        End Set
    End Property
    Public Property FormLeft(ByVal frm As String)
        Get
            Dim keyString As String
            keyString = "EcuControl.Net\\FormSettings\\Left"
            cReg = Registry.CurrentUser.OpenSubKey(keyString, True)
            If cReg Is Nothing Then
                cReg = Registry.CurrentUser.CreateSubKey(keyString)
                cReg.SetValue(frm, 0)
            End If

            keyString = cReg.GetValue(frm)
            Return keyString

        End Get
        Set(ByVal Value)
            Dim keystring As String
            keystring = "EcuControl.Net\\FormSettings\\Left"
            cReg = Registry.CurrentUser.OpenSubKey(keystring, True)
            If cReg Is Nothing Then
                cReg = Registry.CurrentUser.CreateSubKey(keystring)
                cReg.SetValue(frm, Value)
            Else
                cReg.SetValue(frm, Value)
            End If
        End Set
    End Property
    Public Property OnColor() As Integer
        Get
            Dim keyString As String
            keyString = "EcuControl.Net\\OnColor"
            cReg = Registry.CurrentUser.OpenSubKey(keyString, True)
            If cReg Is Nothing Then
                cReg = Registry.CurrentUser.CreateSubKey(keyString)
                cReg.SetValue("Type", 1)
            End If
            keyString = cReg.GetValue("Type")
            Return keyString

        End Get
        Set(ByVal Value As Integer)
            Dim keystring As String
            keystring = "EcuControl.Net\\OnColor"
            cReg = Registry.CurrentUser.OpenSubKey(keystring, True)
            If cReg Is Nothing Then
                cReg = Registry.CurrentUser.CreateSubKey(keystring)
                cReg.SetValue("Type", Value)
            Else
                cReg.SetValue("Type", Value)
            End If
        End Set
    End Property
    Public Property OffColor() As Integer
        Get
            Dim keyString As String
            keyString = "EcuControl.Net\\OffColor"
            cReg = Registry.CurrentUser.OpenSubKey(keyString, True)
            If cReg Is Nothing Then
                cReg = Registry.CurrentUser.CreateSubKey(keyString)
                cReg.SetValue("Type", 1)
            End If
            keyString = cReg.GetValue("Type")
            Return keyString

        End Get
        Set(ByVal Value As Integer)
            Dim keystring As String
            keystring = "EcuControl.Net\\OffColor"
            cReg = Registry.CurrentUser.OpenSubKey(keystring, True)
            If cReg Is Nothing Then
                cReg = Registry.CurrentUser.CreateSubKey(keystring)
                cReg.SetValue("Type", Value)
            Else
                cReg.SetValue("Type", Value)
            End If
        End Set
    End Property
    Public Property BackColor() As Integer
        Get
            Dim keyString As String
            keyString = "EcuControl.Net\\BackColor"
            cReg = Registry.CurrentUser.OpenSubKey(keyString, True)
            If cReg Is Nothing Then
                cReg = Registry.CurrentUser.CreateSubKey(keyString)
                cReg.SetValue("Type", 1)
            End If
            keyString = cReg.GetValue("Type")
            Return keyString

        End Get
        Set(ByVal Value As Integer)
            Dim keystring As String
            keystring = "EcuControl.Net\\BackColor"
            cReg = Registry.CurrentUser.OpenSubKey(keystring, True)
            If cReg Is Nothing Then
                cReg = Registry.CurrentUser.CreateSubKey(keystring)
                cReg.SetValue("Type", Value)
            Else
                cReg.SetValue("Type", Value)
            End If
        End Set
    End Property
    Public Property GaugeStyle() As Integer
        Get
            Dim keyString As String
            keyString = "EcuControl.Net\\GaugeStyle"
            cReg = Registry.CurrentUser.OpenSubKey(keyString, True)
            If cReg Is Nothing Then
                cReg = Registry.CurrentUser.CreateSubKey(keyString)
                cReg.SetValue("Type", 1)
            End If
            keyString = cReg.GetValue("Type")
            Return keyString

        End Get
        Set(ByVal Value As Integer)
            Dim keystring As String
            keystring = "EcuControl.Net\\GaugeStyle"
            cReg = Registry.CurrentUser.OpenSubKey(keystring, True)
            If cReg Is Nothing Then
                cReg = Registry.CurrentUser.CreateSubKey(keystring)
                cReg.SetValue("Type", Value)
            Else
                cReg.SetValue("Type", Value)
            End If
        End Set
    End Property

#End Region
#Region "Sensor Calcs"
    Sub ProcessOBD0(ByVal data As Integer, ByVal data2 As Integer)
        Select Case currentsensor
            Case 1 'ECT
                Select Case Standard
                    Case 1 'metric
                        x = data * (5 / 256)
                        ECT = (((0.1423 * x ^ 6) - (2.4938 * x ^ 5) + (17.837 * x ^ 4) - (68.698 * x ^ 3) + (154.69 * x ^ 2) - (232.75 * x) + 291.24) - 32) * (5 / 9)
                        'update Digital
                        frmDatalog.DefInstance.tECT.Text = CStr(ECT)
                        DigitalGuage.DefInstance.ECTDisp.Text = CStr(ECT)
                        'frmDgauges.DefInstance.ectLED.Value = ECT
                        'frmDgauges.DefInstance.lblECT.Text = "ECT ºC"
                        'Update Analog
                        'frmAgauges.DefInstance.ectgm.Value = CDbl(ECT)
                    Case 2 'sae
                        x = data * (5 / 256)
                        ECT = ((0.1423 * x ^ 6) - (2.4938 * x ^ 5) + (17.837 * x ^ 4) - (68.698 * x ^ 3) + (154.69 * x ^ 2) - (232.75 * x) + 291.24)
                        'update Digital
                        frmDatalog.DefInstance.tECT.Text = CStr(ECT)
                        DigitalGuage.DefInstance.ECTDisp.Text = CStr(ECT)
                        'frmDgauges.DefInstance.ectLED.Value = ECT
                        'frmDgauges.DefInstance.lblECT.Text = "ECT ºF"
                        'Update Analog
                        'frmAgauges.DefInstance.ectg.Value = CDbl(ECT)
                End Select
            Case 2 'IAT
                Select Case Standard
                    Case 1 'Metric
                        x = data * (5 / 256)
                        IAT = (((0.1423 * x ^ 6) - (2.4938 * x ^ 5) + (17.837 * x ^ 4) - (68.698 * x ^ 3) + (154.69 * x ^ 2) - (232.75 * x) + 291.24) - 32) * (5 / 9)
                        DigitalGuage.DefInstance.IATDisp.Text = CStr(IAT)
                        'frmDgauges.DefInstance.lblIAT.Text = "IAT ºC"
                        'frmDgauges.DefInstance.iatLED.Value = IAT
                        'frmDatalog.DefInstance.tIAT.Text = CStr(IAT)
                        'frmDgauges.DefInstance.iatLED.Value = IAT
                        'frmAgauges.DefInstance.iatgm.Value = CDbl(IAT)
                    Case 2 'SAE
                        x = data * (5 / 256)
                        IAT = ((0.1423 * x ^ 6) - (2.4938 * x ^ 5) + (17.837 * x ^ 4) - (68.698 * x ^ 3) + (154.69 * x ^ 2) - (232.75 * x) + 291.24)
                        frmDatalog.DefInstance.tIAT.Text = CStr(IAT)
                        DigitalGuage.DefInstance.IATDisp.Text = IAT
                        'frmDgauges.DefInstance.iatLED.Value = IAT
                        'frmDgauges.DefInstance.lblIAT.Text = "IAT ºF"
                        'frmAgauges.DefInstance.iatg.Value = CDbl(IAT)
                End Select
            Case 3 'O2
                Select Case O2Type
                    Case 1 'stock
                        If data > 50 Then data = 50
                        O2 = data
                    Case 2 Or 3 'Plx or LM1
                        O2 = ((2 * (data * (5 / 256))) + 9.35)
                End Select
                frmDatalog.DefInstance.pbo2.Value = O2
                DigitalGuage.DefInstance.AirFuelDisp.Text = CStr(O2)
                'frmDgauges.DefInstance.afLED.Value = O2
                'frmAgauges.DefInstance.o2g.Value = CDbl(O2)
            Case 4 'MAP
                Select Case MAPType
                    Case 1
                        If data <= 141 Then
                            MAP = 0 - ((-0.1957 * data + 27.587) / 1.875)
                            frmDatalog.DefInstance.lMAP.Text = "in/Hg"
                            frmDatalog.DefInstance.tMAP.Text = CStr(MAP)
                            DigitalGuage.DefInstance.MAPDisp.Text = CStr(MAP)
                            'frmDgauges.DefInstance.mapLED.Value = MAP
                            'frmDgauges.DefInstance.lblMAP.Text = "in/Hg"
                            'frmAgauges.DefInstance.mapg.Value = CDbl(MAP)
                        Else
                            MAP = 0 - ((0.1124 * data - 15.843) / 1.875)
                            frmDatalog.DefInstance.lMAP.Text = "PSI"
                            frmDatalog.DefInstance.tMAP.Text = CStr(MAP)
                            DigitalGuage.DefInstance.MAPDisp.Text = CStr(MAP)
                            'frmDgauges.DefInstance.mapLED.Value = MAP
                            'frmDgauges.DefInstance.lblMAP.Text = "PSI"
                            'frmAgauges.DefInstance.mapg.Value = CDbl(MAP)
                        End If
                    Case 2
                    Case 3
                        MAP = ((8.91667 * ((5 / 256) * data)) - 15.172)
                        If MAP >= 0 Then
                            'frmDgauges.DefInstance.mapLED.Value = MAP
                            frmDatalog.DefInstance.lMAP.Text = "PSI"
                            'frmDgauges.DefInstance.lblMAP.Text = "PSI"
                            frmDatalog.DefInstance.tMAP.Text = CStr(MAP)
                            DigitalGuage.DefInstance.MAPDisp.Text = CStr(MAP)
                            'frmAgauges.DefInstance.mapg.Value = CDbl(MAP)
                        Else
                            'frmDgauges.DefInstance.mapLED.Value = MAP
                            'frmDgauges.DefInstance.lblMAP.Text = "in/Hg"
                            frmDatalog.DefInstance.lMAP.Text = "in/Hg"
                            frmDatalog.DefInstance.tMAP.Text = CStr(MAP)
                            DigitalGuage.DefInstance.MAPDisp.Text = CStr(MAP)
                            'frmAgauges.DefInstance.mapg.Value = CDbl(MAP)
                        End If
                End Select
            Case 5 'TPS
                If data > 250 Then '250 = 4.49v, 4.49v = WOT)
                    data = 250
                End If

                If data < 47 Then  '47 = Closed Throttle
                    data = 47
                End If
                TPS = ((0.4926 * data) - 23.153)
                frmDatalog.DefInstance.tTPS.Text = CStr(TPS)
                DigitalGuage.DefInstance.TPSDisp.Text = CStr(TPS)
                'frmDgauges.DefInstance.tpsLED.Value = TPS
            Case 7 'RPM (6 is not needed since its part of 7)
                rpm = CLng((1848000 / ((data * 256) + data2)))
                frmDatalog.DefInstance.tRPM.Text = CStr(rpm)
                DigitalGuage.DefInstance.RPMDisp.Text = CStr(rpm)
                'frmDgauges.DefInstance.rpmLED.Value = rpm
                'frmAgauges.DefInstance.rpmg.Value = CDbl(rpm / 100)
            Case 8 'VTEC
                If data < 128 Then
                    frmDatalog.DefInstance.txtVTEC.Text = "VTEC OFF"
                    DigitalGuage.DefInstance.VTECDisp.Text = "OFF"
                    VTEC = False
                Else
                    frmDatalog.DefInstance.txtVTEC.Text = "VTEC ON"
                    DigitalGuage.DefInstance.VTECDisp.Text = "ON"
                    VTEC = True
                End If
            Case 9 'VSS
                Select Case Standard
                    Case 1 'Metric
                        VSS = data
                        frmDatalog.DefInstance.tVSS.Text = CStr(VSS)
                        DigitalGuage.DefInstance.SpeedDisp.Text = CStr(VSS)
                        'frmDgauges.DefInstance.vssLED.Value = VSS
                        'frmDgauges.DefInstance.lblVSS.Text = "KPH"
                        'frmAgauges.DefInstance.vssgm.Value = CDbl(VSS)
                    Case 2 'Sae
                        VSS = data / 1.666
                        frmDatalog.DefInstance.tVSS.Text = CStr(VSS)
                        DigitalGuage.DefInstance.SpeedDisp.Text = CStr(VSS)
                        'frmDgauges.DefInstance.vssLED.Value = VSS
                        'frmDgauges.DefInstance.lblVSS.Text = "MPH"
                        'frmAgauges.DefInstance.vssgm.Value = CDbl(VSS)
                End Select
        End Select

        UpdateLoggingGrid()
    End Sub
    Sub ProcessOBD1(ByVal data As Integer, ByVal data2 As Integer)
        Select Case currentsensor
            Case 1 'ECT
                Select Case Standard
                    Case 1 'metric
                        x = data * (5 / 256)
                        ECT = (((0.1423 * x ^ 6) - (2.4938 * x ^ 5) + (17.837 * x ^ 4) - (68.698 * x ^ 3) + (154.69 * x ^ 2) - (232.75 * x) + 291.24) - 32) * (5 / 9)
                        'update Digital
                        frmDatalog.DefInstance.tECT.Text = CStr(ECT)
                        DigitalGuage.DefInstance.ECTDisp.Text = CStr(ECT)
                        'frmDgauges.DefInstance.ectLED.Value = ECT
                        'frmDgauges.DefInstance.lblECT.Text = "ECT ºC"
                        'Update Analog
                        'frmAgauges.DefInstance.ectgm.Value = CDbl(ECT)
                    Case 2 'sae
                        x = data * (5 / 256)
                        ECT = ((0.1423 * x ^ 6) - (2.4938 * x ^ 5) + (17.837 * x ^ 4) - (68.698 * x ^ 3) + (154.69 * x ^ 2) - (232.75 * x) + 291.24)
                        'update Digital
                        frmDatalog.DefInstance.tECT.Text = CStr(ECT)
                        DigitalGuage.DefInstance.ECTDisp.Text = CStr(ECT)
                        'frmDgauges.DefInstance.ectLED.Value = ECT
                        'frmDgauges.DefInstance.lblECT.Text = "ECT ºF"
                        'Update Analog
                        'frmAgauges.DefInstance.ectg.Value = CDbl(ECT)
                End Select
            Case 2 'IAT
                Select Case Standard
                    Case 1 'Metric
                        x = data * (5 / 256)
                        IAT = (((0.1423 * x ^ 6) - (2.4938 * x ^ 5) + (17.837 * x ^ 4) - (68.698 * x ^ 3) + (154.69 * x ^ 2) - (232.75 * x) + 291.24) - 32) * (5 / 9)
                        'frmDgauges.DefInstance.lblIAT.Text = "IAT ºC"
                        'frmDgauges.DefInstance.iatLED.Value = IAT
                        frmDatalog.DefInstance.tIAT.Text = CStr(IAT)
                        DigitalGuage.DefInstance.IATDisp.Text = CStr(IAT)
                        'frmDgauges.DefInstance.iatLED.Value = IAT
                        'frmAgauges.DefInstance.iatgm.Value = CDbl(IAT)
                    Case 2 'SAE
                        x = data * (5 / 256)
                        IAT = ((0.1423 * x ^ 6) - (2.4938 * x ^ 5) + (17.837 * x ^ 4) - (68.698 * x ^ 3) + (154.69 * x ^ 2) - (232.75 * x) + 291.24)
                        frmDatalog.DefInstance.tIAT.Text = CStr(IAT)
                        DigitalGuage.DefInstance.IATDisp.Text = CStr(IAT)
                        'frmDgauges.DefInstance.iatLED.Value = IAT
                        'frmDgauges.DefInstance.lblIAT.Text = "IAT ºF"
                        'frmAgauges.DefInstance.iatg.Value = CDbl(IAT)
                End Select
            Case 3 'O2
                Select Case O2Type
                    Case 1 'stock
                        If data > 50 Then data = 50
                        O2 = data
                    Case 2 Or 3 'Plx or LM1
                        O2 = ((2 * (data * (5 / 256))) + 9.35)
                End Select
                frmDatalog.DefInstance.pbo2.Value = O2
                DigitalGuage.DefInstance.AirFuelDisp.Text = O2
                'frmDgauges.DefInstance.afLED.Value = O2
                'frmAgauges.DefInstance.o2g.Value = CDbl(O2)
            Case 4 'MAP
                Select Case MAPType
                    Case 1
                        If data <= 141 Then
                            MAP = 0 - ((-0.1957 * data + 27.587) / 1.875)
                            frmDatalog.DefInstance.lMAP.Text = "in/Hg"
                            frmDatalog.DefInstance.tMAP.Text = CStr(MAP)
                            DigitalGuage.DefInstance.MAPDisp.Text = CStr(MAP)
                            'frmDgauges.DefInstance.mapLED.Value = MAP
                            'frmDgauges.DefInstance.lblMAP.Text = "in/Hg"
                            'frmAgauges.DefInstance.mapg.Value = CDbl(MAP)
                        Else
                            MAP = 0 - ((0.1124 * data - 15.843) / 1.875)
                            frmDatalog.DefInstance.lMAP.Text = "PSI"
                            frmDatalog.DefInstance.tMAP.Text = CStr(MAP)
                            DigitalGuage.DefInstance.MAPDisp.Text = CStr(MAP)
                            'frmDgauges.DefInstance.mapLED.Value = MAP
                            'frmDgauges.DefInstance.lblMAP.Text = "PSI"
                            'frmAgauges.DefInstance.mapg.Value = CDbl(MAP)
                        End If
                    Case 2
                    Case 3
                        MAP = ((8.91667 * ((5 / 256) * data)) - 15.172)
                        If MAP >= 0 Then
                            'frmDgauges.DefInstance.mapLED.Value = MAP
                            frmDatalog.DefInstance.lMAP.Text = "PSI"
                            'frmDgauges.DefInstance.lblMAP.Text = "PSI"
                            frmDatalog.DefInstance.tMAP.Text = CStr(MAP)
                            DigitalGuage.DefInstance.MAPDisp.Text = CStr(MAP)
                            'frmAgauges.DefInstance.mapg.Value = CDbl(MAP)
                        Else
                            'frmDgauges.DefInstance.mapLED.Value = MAP
                            'frmDgauges.DefInstance.lblMAP.Text = "in/Hg"
                            frmDatalog.DefInstance.lMAP.Text = "in/Hg"
                            frmDatalog.DefInstance.tMAP.Text = CStr(MAP)
                            DigitalGuage.DefInstance.MAPDisp.Text = CStr(MAP)
                            'frmAgauges.DefInstance.mapg.Value = CDbl(MAP)
                        End If
                End Select
            Case 5 'TPS
                If data > 250 Then '250 = 4.49v, 4.49v = WOT)
                    data = 250
                End If

                If data < 47 Then  '47 = Closed Throttle
                    data = 47
                End If
                TPS = ((0.4926 * data) - 23.153)
                frmDatalog.DefInstance.tTPS.Text = CStr(TPS)
                DigitalGuage.DefInstance.TPSDisp.Text = CStr(TPS)
                'frmDgauges.DefInstance.tpsLED.Value = TPS
            Case 7 'RPM (6 is not needed since its part of 7)
                rpm = CLng((1875000 / ((data * 256) + data2)))
                frmDatalog.DefInstance.tRPM.Text = CStr(rpm)
                DigitalGuage.DefInstance.RPMDisp.Text = CStr(rpm)
                'frmDgauges.DefInstance.rpmLED.Value = rpm
                'frmAgauges.DefInstance.rpmg.Value = CDbl(rpm / 100)
            Case 8 'VTEC
                If data < 128 Then
                    frmDatalog.DefInstance.txtVTEC.Text = "VTEC OFF"
                    DigitalGuage.DefInstance.VTECDisp.Text = "OFF"
                    VTEC = False
                Else
                    frmDatalog.DefInstance.txtVTEC.Text = "VTEC ON"
                    DigitalGuage.DefInstance.VTECDisp.Text = "ON"
                    VTEC = True
                End If
            Case 9 'VSS
                Select Case Standard
                    Case 1 'Metric
                        VSS = data
                        frmDatalog.DefInstance.tVSS.Text = CStr(VSS)
                        DigitalGuage.DefInstance.SpeedDisp.Text = CStr(VSS)
                        'frmDgauges.DefInstance.vssLED.Value = VSS
                        'frmDgauges.DefInstance.lblVSS.Text = "KPH"
                        'frmAgauges.DefInstance.vssgm.Value = CDbl(VSS)
                    Case 2 'Sae
                        VSS = data / 1.666
                        frmDatalog.DefInstance.tVSS.Text = CStr(VSS)
                        DigitalGuage.DefInstance.SpeedDisp.Text = CStr(VSS)
                        'frmDgauges.DefInstance.vssLED.Value = VSS
                        'frmDgauges.DefInstance.lblVSS.Text = "MPH"
                        'frmAgauges.DefInstance.vssgm.Value = CDbl(VSS)
                End Select
        End Select
        UpdateLoggingGrid()
    End Sub
    Sub ProcessNG55(ByVal data As Integer, ByVal data2 As Integer)
        Select Case currentsensor
            Case 1 'ECT
                Select Case Standard
                    Case 1 'metric
                        x = data * (5 / 256)
                        ECT = (((0.1423 * x ^ 6) - (2.4938 * x ^ 5) + (17.837 * x ^ 4) - (68.698 * x ^ 3) + (154.69 * x ^ 2) - (232.75 * x) + 291.24) - 32) * (5 / 9)
                        'update Digital
                        frmDatalog.DefInstance.tECT.Text = CStr(ECT)
                        DigitalGuage.DefInstance.ECTDisp.Text = CStr(ECT)
                        'frmDgauges.DefInstance.ectLED.Value = ECT
                        'frmDgauges.DefInstance.lblECT.Text = "ECT ºC"
                        'Update Analog
                        'frmAgauges.DefInstance.ectgm.Value = CDbl(ECT)
                    Case 2 'sae
                        x = data * (5 / 256)
                        ECT = ((0.1423 * x ^ 6) - (2.4938 * x ^ 5) + (17.837 * x ^ 4) - (68.698 * x ^ 3) + (154.69 * x ^ 2) - (232.75 * x) + 291.24)
                        'update Digital
                        frmDatalog.DefInstance.tECT.Text = CStr(ECT)
                        DigitalGuage.DefInstance.ECTDisp.Text = CStr(ECT)
                        'frmDgauges.DefInstance.ectLED.Value = ECT
                        'frmDgauges.DefInstance.lblECT.Text = "ECT ºF"
                        'Update Analog
                        'frmAgauges.DefInstance.ectg.Value = CDbl(ECT)
                End Select
            Case 2 'IAT
                Select Case Standard
                    Case 1 'Metric
                        x = data * (5 / 256)
                        IAT = (((0.1423 * x ^ 6) - (2.4938 * x ^ 5) + (17.837 * x ^ 4) - (68.698 * x ^ 3) + (154.69 * x ^ 2) - (232.75 * x) + 291.24) - 32) * (5 / 9)
                        'frmDgauges.DefInstance.lblIAT.Text = "IAT ºC"
                        'frmDgauges.DefInstance.iatLED.Value = IAT
                        frmDatalog.DefInstance.tIAT.Text = CStr(IAT)
                        DigitalGuage.DefInstance.IATDisp.Text = CStr(IAT)
                        'frmDgauges.DefInstance.iatLED.Value = IAT
                        'frmAgauges.DefInstance.iatgm.Value = CDbl(IAT)
                    Case 2 'SAE
                        x = data * (5 / 256)
                        IAT = ((0.1423 * x ^ 6) - (2.4938 * x ^ 5) + (17.837 * x ^ 4) - (68.698 * x ^ 3) + (154.69 * x ^ 2) - (232.75 * x) + 291.24)
                        frmDatalog.DefInstance.tIAT.Text = CStr(IAT)
                        DigitalGuage.DefInstance.IATDisp.Text = CStr(IAT)
                        'frmDgauges.DefInstance.iatLED.Value = IAT
                        'frmDgauges.DefInstance.lblIAT.Text = "IAT ºF"
                        'frmAgauges.DefInstance.iatg.Value = CDbl(IAT)
                End Select
            Case 3 'O2
                Select Case O2Type
                    Case 1 'stock
                        If data > 50 Then data = 50
                        O2 = data
                    Case 2 Or 3 'Plx or LM1
                        O2 = ((2 * (data * (5 / 256))) + 9.35)
                End Select
                frmDatalog.DefInstance.pbo2.Value = O2
                DigitalGuage.DefInstance.AirFuelDisp.Text = O2
                'frmDgauges.DefInstance.afLED.Value = O2
                'frmAgauges.DefInstance.o2g.Value = CDbl(O2)
            Case 4 'MAP
                Select Case MAPType
                    Case 1
                        If data <= 141 Then
                            MAP = 0 - ((-0.1957 * data + 27.587) / 1.875)
                            frmDatalog.DefInstance.lMAP.Text = "in/Hg"
                            frmDatalog.DefInstance.tMAP.Text = CStr(MAP)
                            DigitalGuage.DefInstance.MAPDisp.Text = CStr(MAP)
                            'frmDgauges.DefInstance.mapLED.Value = MAP
                            'frmDgauges.DefInstance.lblMAP.Text = "in/Hg"
                            'frmAgauges.DefInstance.mapg.Value = CDbl(MAP)
                        Else
                            MAP = 0 - ((0.1124 * data - 15.843) / 1.875)
                            frmDatalog.DefInstance.lMAP.Text = "PSI"
                            frmDatalog.DefInstance.tMAP.Text = CStr(MAP)
                            DigitalGuage.DefInstance.MAPDisp.Text = CStr(MAP)
                            'frmDgauges.DefInstance.mapLED.Value = MAP
                            'frmDgauges.DefInstance.lblMAP.Text = "PSI"
                            'frmAgauges.DefInstance.mapg.Value = CDbl(MAP)
                        End If
                    Case 2
                    Case 3
                        MAP = ((8.91667 * ((5 / 256) * data)) - 15.172)
                        If MAP >= 0 Then
                            'frmDgauges.DefInstance.mapLED.Value = MAP
                            frmDatalog.DefInstance.lMAP.Text = "PSI"
                            'frmDgauges.DefInstance.lblMAP.Text = "PSI"
                            frmDatalog.DefInstance.tMAP.Text = CStr(MAP)
                            DigitalGuage.DefInstance.MAPDisp.Text = CStr(MAP)
                            'frmAgauges.DefInstance.mapg.Value = CDbl(MAP)
                        Else
                            'frmDgauges.DefInstance.mapLED.Value = MAP
                            'frmDgauges.DefInstance.lblMAP.Text = "in/Hg"
                            frmDatalog.DefInstance.lMAP.Text = "in/Hg"
                            frmDatalog.DefInstance.tMAP.Text = CStr(MAP)
                            DigitalGuage.DefInstance.MAPDisp.Text = CStr(MAP)
                            'frmAgauges.DefInstance.mapg.Value = CDbl(MAP)
                        End If
                End Select
            Case 5 'TPS
                If data > 250 Then '250 = 4.49v, 4.49v = WOT)
                    data = 250
                End If

                If data < 47 Then  '47 = Closed Throttle
                    data = 47
                End If
                TPS = ((0.4926 * data) - 23.153)
                frmDatalog.DefInstance.tTPS.Text = CStr(TPS)
                DigitalGuage.DefInstance.TPSDisp.Text = CStr(TPS)
                'frmDgauges.DefInstance.tpsLED.Value = TPS
            Case 7 'RPM (6 is not needed since its part of 7)
                rpm = CLng((1920000 / ((data * 256) + data2)))
                frmDatalog.DefInstance.tRPM.Text = CStr(rpm)
                DigitalGuage.DefInstance.RPMDisp.Text = CStr(rpm)
                'frmDgauges.DefInstance.rpmLED.Value = rpm
                'frmAgauges.DefInstance.rpmg.Value = CDbl(rpm / 100)
            Case 8 And MAPType = 1 ' STOCK MAP
                stockmap = data
            Case 9 'VSS
                Select Case Standard
                    Case 1 'Metric
                        VSS = data
                        frmDatalog.DefInstance.tVSS.Text = CStr(VSS)
                        DigitalGuage.DefInstance.SpeedDisp.Text = CStr(VSS)
                        ' frmDgauges.DefInstance.vssLED.Value = VSS
                        'frmDgauges.DefInstance.lblVSS.Text = "KPH"
                        'frmAgauges.DefInstance.vssgm.Value = CDbl(VSS)
                    Case 2 'Sae
                        VSS = data / 1.666
                        frmDatalog.DefInstance.tVSS.Text = CStr(VSS)
                        DigitalGuage.DefInstance.SpeedDisp.Text = CStr(VSS)
                        'frmDgauges.DefInstance.vssLED.Value = VSS
                        'frmDgauges.DefInstance.lblVSS.Text = "MPH"
                        'frmAgauges.DefInstance.vssg.Value = CDbl(VSS)
                End Select
            Case 0 ' 8 bit RPM
                OneByteRPM = data

        End Select
        UpdateLoggingGrid()
        UpdateDigitalGuage()
    End Sub
#End Region
#Region "Misc Subs"
    Public Sub InitDatalogGrid()

        With frmDatalog.DefInstance.LoggingGrid
            .Cols = 11
            .set_TextMatrix(0, 0, "RPM")
            .set_TextMatrix(0, 1, "VSS")
            .set_TextMatrix(0, 2, "TPS")
            .set_TextMatrix(0, 3, "A/F")
            .set_TextMatrix(0, 4, "VTEC")
            .set_TextMatrix(0, 5, "IAT")
            .set_TextMatrix(0, 6, "ECT")
            .set_TextMatrix(0, 7, "MAP")
            .set_TextMatrix(0, 8, "Time")
            .set_TextMatrix(0, 9, "HP")
            .set_TextMatrix(0, 10, "Torque")
        End With

    End Sub
    Public Sub UpdateLoggingGrid()
        If LogData = True Then
            If CLng(frmDatalog.DefInstance.minTPS.Text) >= TPS Then
                With frmDatalog.DefInstance.LoggingGrid
                    .AddItem(CStr(.Rows))
                    .set_TextMatrix(.Rows - 1, 0, CStr(rpm))
                    .set_TextMatrix(.Rows - 1, 1, CStr(VSS))
                    .set_TextMatrix(.Rows - 1, 2, CStr(TPS))
                    .set_TextMatrix(.Rows - 1, 3, CStr(O2))
                    .set_TextMatrix(.Rows - 1, 4, CStr(VTEC))
                    .set_TextMatrix(.Rows - 1, 5, CStr(IAT))
                    .set_TextMatrix(.Rows - 1, 6, CStr(ECT))
                    .set_TextMatrix(.Rows - 1, 7, CStr(MAP))
                    .set_TextMatrix(.Rows - 1, 8, CStr(Now))
                    .set_TextMatrix(.Rows - 1, 9, "N/A")
                    .set_TextMatrix(.Rows - 1, 10, "N/A")
                End With
            End If
        End If
    End Sub
    Public Sub UpdateDigitalGuage()
        If LogData = True Then
            DigitalGuage.DefInstance.RPMDisp.Text = CStr(rpm)
            DigitalGuage.DefInstance.SpeedDisp.Text = CStr(VSS)
            DigitalGuage.DefInstance.MAPDisp.Text = CStr(MAP)
            DigitalGuage.DefInstance.VTECDisp.Text = CStr(VTEC)
            DigitalGuage.DefInstance.ECTDisp.Text = CStr(ECT)
            DigitalGuage.DefInstance.AirFuelDisp.Text = CStr(O2)
            DigitalGuage.DefInstance.TPSDisp.Text = CStr(TPS)
            DigitalGuage.DefInstance.IATDisp.Text = CStr(IAT)
        End If
    End Sub
#End Region
End Module
