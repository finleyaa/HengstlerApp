<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PortSettings
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label_COMPort = New System.Windows.Forms.Label()
        Me.Label_BaudRate = New System.Windows.Forms.Label()
        Me.Label_DataBits = New System.Windows.Forms.Label()
        Me.Label_StopBits = New System.Windows.Forms.Label()
        Me.TextBox_COMPort = New System.Windows.Forms.TextBox()
        Me.TextBox_BaudRate = New System.Windows.Forms.TextBox()
        Me.TextBox_DataBits = New System.Windows.Forms.TextBox()
        Me.Button_Apply = New System.Windows.Forms.Button()
        Me.ComboBox_StopBits = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label_COMPort
        '
        Me.Label_COMPort.AutoSize = True
        Me.Label_COMPort.Location = New System.Drawing.Point(13, 13)
        Me.Label_COMPort.Name = "Label_COMPort"
        Me.Label_COMPort.Size = New System.Drawing.Size(53, 13)
        Me.Label_COMPort.TabIndex = 0
        Me.Label_COMPort.Text = "COM Port"
        '
        'Label_BaudRate
        '
        Me.Label_BaudRate.AutoSize = True
        Me.Label_BaudRate.Location = New System.Drawing.Point(13, 41)
        Me.Label_BaudRate.Name = "Label_BaudRate"
        Me.Label_BaudRate.Size = New System.Drawing.Size(58, 13)
        Me.Label_BaudRate.TabIndex = 1
        Me.Label_BaudRate.Text = "Baud Rate"
        '
        'Label_DataBits
        '
        Me.Label_DataBits.AutoSize = True
        Me.Label_DataBits.Location = New System.Drawing.Point(13, 75)
        Me.Label_DataBits.Name = "Label_DataBits"
        Me.Label_DataBits.Size = New System.Drawing.Size(50, 13)
        Me.Label_DataBits.TabIndex = 2
        Me.Label_DataBits.Text = "Data Bits"
        '
        'Label_StopBits
        '
        Me.Label_StopBits.AutoSize = True
        Me.Label_StopBits.Location = New System.Drawing.Point(13, 109)
        Me.Label_StopBits.Name = "Label_StopBits"
        Me.Label_StopBits.Size = New System.Drawing.Size(49, 13)
        Me.Label_StopBits.TabIndex = 3
        Me.Label_StopBits.Text = "Stop Bits"
        '
        'TextBox_COMPort
        '
        Me.TextBox_COMPort.Location = New System.Drawing.Point(73, 13)
        Me.TextBox_COMPort.Name = "TextBox_COMPort"
        Me.TextBox_COMPort.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_COMPort.TabIndex = 4
        '
        'TextBox_BaudRate
        '
        Me.TextBox_BaudRate.Location = New System.Drawing.Point(77, 39)
        Me.TextBox_BaudRate.Name = "TextBox_BaudRate"
        Me.TextBox_BaudRate.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_BaudRate.TabIndex = 5
        '
        'TextBox_DataBits
        '
        Me.TextBox_DataBits.Location = New System.Drawing.Point(77, 68)
        Me.TextBox_DataBits.Name = "TextBox_DataBits"
        Me.TextBox_DataBits.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_DataBits.TabIndex = 6
        '
        'Button_Apply
        '
        Me.Button_Apply.Location = New System.Drawing.Point(111, 164)
        Me.Button_Apply.Name = "Button_Apply"
        Me.Button_Apply.Size = New System.Drawing.Size(75, 23)
        Me.Button_Apply.TabIndex = 8
        Me.Button_Apply.Text = "Apply"
        Me.Button_Apply.UseVisualStyleBackColor = True
        '
        'ComboBox_StopBits
        '
        Me.ComboBox_StopBits.FormattingEnabled = True
        Me.ComboBox_StopBits.Location = New System.Drawing.Point(68, 101)
        Me.ComboBox_StopBits.Name = "ComboBox_StopBits"
        Me.ComboBox_StopBits.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox_StopBits.TabIndex = 9
        '
        'PortSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ComboBox_StopBits)
        Me.Controls.Add(Me.Button_Apply)
        Me.Controls.Add(Me.TextBox_DataBits)
        Me.Controls.Add(Me.TextBox_BaudRate)
        Me.Controls.Add(Me.TextBox_COMPort)
        Me.Controls.Add(Me.Label_StopBits)
        Me.Controls.Add(Me.Label_DataBits)
        Me.Controls.Add(Me.Label_BaudRate)
        Me.Controls.Add(Me.Label_COMPort)
        Me.Name = "PortSettings"
        Me.Text = "PortSettings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label_COMPort As Label
    Friend WithEvents Label_BaudRate As Label
    Friend WithEvents Label_DataBits As Label
    Friend WithEvents Label_StopBits As Label
    Friend WithEvents TextBox_COMPort As TextBox
    Friend WithEvents TextBox_BaudRate As TextBox
    Friend WithEvents TextBox_DataBits As TextBox
    Friend WithEvents Button_Apply As Button
    Friend WithEvents ComboBox_StopBits As ComboBox
End Class
