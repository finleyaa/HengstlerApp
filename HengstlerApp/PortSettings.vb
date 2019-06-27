Public Class PortSettings

    Public ApplySettings As Boolean = False
    Private Sub PortSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.ClientSize = New Size(200, 180)
        Me.MaximumSize = Me.Size
        Me.MinimumSize = Me.Size
        Me.MaximizeBox = False

        Dim TextBoxX As Single = 10 + Label_BaudRate.Width
        Dim TextBoxWidth As Single = Me.ClientSize.Width - TextBoxX - 5

        Label_COMPort.Location = New Point(5, 20 - Label_COMPort.Height / 2)
        TextBox_COMPort.Location = New Point(TextBoxX, 20 - TextBox_COMPort.Height / 2)
        TextBox_COMPort.Size = New Size(TextBoxWidth, TextBox_COMPort.Height)
        TextBox_COMPort.Text = Form1.COMPort

        Label_BaudRate.Location = New Point(5, 50 - Label_BaudRate.Height / 2)
        TextBox_BaudRate.Location = New Point(TextBoxX, 50 - TextBox_BaudRate.Height / 2)
        TextBox_BaudRate.Size = New Size(TextBoxWidth, TextBox_BaudRate.Height)
        TextBox_BaudRate.Text = Form1.BaudRate

        Label_DataBits.Location = New Point(5, 80 - Label_DataBits.Height / 2)
        TextBox_DataBits.Location = New Point(TextBoxX, 80 - TextBox_DataBits.Height / 2)
        TextBox_DataBits.Size = New Size(TextBoxWidth, TextBox_DataBits.Height)
        TextBox_DataBits.Text = Form1.DataBits

        Label_StopBits.Location = New Point(5, 110 - Label_StopBits.Height / 2)
        ComboBox_StopBits.Location = New Point(TextBoxX, 110 - ComboBox_StopBits.Height / 2)
        ComboBox_StopBits.Size = New Size(TextBoxWidth, ComboBox_StopBits.Height)

        ComboBox_StopBits.Items.Add("1")
        ComboBox_StopBits.Items.Add("1.5")
        ComboBox_StopBits.Items.Add("2")

        If Form1.StopBits = 1 Then
            ComboBox_StopBits.SelectedIndex = 0
        ElseIf Form1.StopBits = 2 Then
            ComboBox_StopBits.SelectedIndex = 2
        Else
            ComboBox_StopBits.SelectedIndex = 1
        End If

        Button_Apply.Location = New Point(Me.ClientSize.Width / 2 - Button_Apply.Width / 2, 150 - Button_Apply.Height / 2)

    End Sub

    Private Sub Button_Apply_Click(sender As Object, e As EventArgs) Handles Button_Apply.Click
        ApplySettings = True
        Me.Close()
    End Sub
End Class