Public Class Form1

    Public COMPort As Integer = 1
    Public BaudRate As Integer
    Public DataBits As Integer
    Public StopBits As Integer

    Private Power As Boolean = False

    Private Image_PowerOff As Image = Image.FromFile("power_off.png")
    Private Image_PowerOn As Image = Image.FromFile("power_on.png")

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        BaudRate = HengstlerSerialPort.BaudRate
        DataBits = HengstlerSerialPort.DataBits
        StopBits = HengstlerSerialPort.StopBits

        Me.ClientSize = New Size(380, 160)
        Me.MaximumSize = Me.Size
        Me.MinimumSize = Me.Size
        Button_SendCmd.Location = New Point(Me.ClientSize.Width - 10 - Button_SendCmd.Width, Me.ClientSize.Height - 10 - Button_SendCmd.Height)
        TBar_UpdateRate.Location = New Point(Me.ClientSize.Width / 2 - TBar_UpdateRate.Width / 2, Me.ClientSize.Height - 10 - TBar_UpdateRate.Height / 2)

        Label_Counter.Font = New Font(DefaultFont.FontFamily, 24.0F, FontStyle.Regular)
        Label_Counter.Location = New Point(30, Me.ClientSize.Height / 4)

        Button_Port.Location = New Point(10, Me.ClientSize.Height - 10 - Button_Port.Height)

        Label_UpdateRate.Text = "Update Rate: " & TBar_UpdateRate.Value * 100 & "ms"
        Label_UpdateRate.Location = New Point(Me.ClientSize.Width / 2 - Label_UpdateRate.Width / 2, Me.ClientSize.Height - 10 - TBar_UpdateRate.Height / 2 - Label_UpdateRate.Height - 5)

        SetupPort()

    End Sub

    Private Sub Form1_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        If Power Then
            e.Graphics.DrawImage(Image_PowerOn, Me.ClientSize.Width - 30, 10)
        Else
            e.Graphics.DrawImage(Image_PowerOff, Me.ClientSize.Width - 30, 10)
        End If
    End Sub

    Public Sub SetupPort()

        HengstlerSerialPort.Close()

        Try
            HengstlerSerialPort = New IO.Ports.SerialPort() With {.PortName = "COM" & COMPort, .BaudRate = BaudRate, .DataBits = DataBits, .StopBits = StopBits}
            HengstlerSerialPort.Open()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub ChangeCOMPort(NewCOMPort As Integer)

        If NewCOMPort > 0 And NewCOMPort <= 4 Then ' Ensure that the COM port is between 0 and 4
            COMPort = NewCOMPort ' Set the new COM port
        Else
            MessageBox.Show("COM port must be between 1 and 4")
        End If

    End Sub

    Private Sub Button_SendCmd_Click(sender As Object, e As EventArgs) Handles Button_SendCmd.Click

        ' Send CNT SPACE R CR command
        Dim Data As Byte() = New Byte() {&H43, &H4E, &H54, &H20, &H82, &HD}
        WriteData(Data)

    End Sub

    Private Sub WriteData(Data As Byte())

        HengstlerSerialPort.Write(Data, 0, Data.Count)

    End Sub

    Private Sub HengstlerSerialPort_DataReceived(sender As Object, e As System.IO.Ports.SerialDataReceivedEventArgs) Handles HengstlerSerialPort.DataReceived

        Dim Data As String = HengstlerSerialPort.ReadLine()

        If Data = "OK" Then
            MessageBox.Show("Power On")
            Power = True
            Timer_Update.Start()
        End If

    End Sub

    Private Sub ReadData(Amount As Integer)

        Dim ByteCount As Integer = Amount
        Dim Data(ByteCount - 1) As Byte
        HengstlerSerialPort.Read(Data, 0, ByteCount)

        Dim NewCount As Integer = Convert.ToInt64(Hex(Data(3)) & Hex(Data(4)))
        Label_Counter.Text = NewCount & ".0"

    End Sub

    Private Sub TBar_UpdateRate_Scroll(sender As Object, e As EventArgs) Handles TBar_UpdateRate.Scroll

        Label_UpdateRate.Text = "Update Rate: " & TBar_UpdateRate.Value * 100 & "ms"
        Label_UpdateRate.Location = New Point(Me.ClientSize.Width / 2 - Label_UpdateRate.Width / 2, Me.ClientSize.Height - 10 - TBar_UpdateRate.Height / 2 - Label_UpdateRate.Height - 5)
        Timer_Update.Interval = TBar_UpdateRate.Value * 100

    End Sub

    Private Sub Button_Port_Click(sender As Object, e As EventArgs) Handles Button_Port.Click

        Dim PortSettings_Form As New PortSettings()
        PortSettings_Form.ShowDialog()
        If PortSettings_Form.ApplySettings Then
            Try
                COMPort = Convert.ToInt32(PortSettings_Form.TextBox_COMPort.Text)
                BaudRate = Convert.ToInt64(PortSettings_Form.TextBox_BaudRate.Text)
                DataBits = Convert.ToInt64(PortSettings_Form.TextBox_DataBits.Text)
                If PortSettings_Form.ComboBox_StopBits.SelectedItem = "1" Then
                    StopBits = 1
                ElseIf PortSettings_Form.ComboBox_StopBits.SelectedItem = "1.5" Then
                    StopBits = 3
                Else
                    StopBits = 2
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

            SetupPort()

        End If

    End Sub

    Private Sub Timer_Update_Tick(sender As Object, e As EventArgs) Handles Timer_Update.Tick
        ReadData(8)
    End Sub
End Class
