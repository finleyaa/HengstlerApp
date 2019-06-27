<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.Label_Counter = New System.Windows.Forms.Label()
        Me.HengstlerSerialPort = New System.IO.Ports.SerialPort(Me.components)
        Me.Button_SendCmd = New System.Windows.Forms.Button()
        Me.TBar_UpdateRate = New System.Windows.Forms.TrackBar()
        Me.Label_UpdateRate = New System.Windows.Forms.Label()
        Me.Button_Port = New System.Windows.Forms.Button()
        Me.Timer_Update = New System.Windows.Forms.Timer(Me.components)
        CType(Me.TBar_UpdateRate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label_Counter
        '
        Me.Label_Counter.AutoSize = True
        Me.Label_Counter.Location = New System.Drawing.Point(13, 13)
        Me.Label_Counter.Name = "Label_Counter"
        Me.Label_Counter.Size = New System.Drawing.Size(46, 13)
        Me.Label_Counter.TabIndex = 0
        Me.Label_Counter.Text = "00000.0"
        '
        'HengstlerSerialPort
        '
        '
        'Button_SendCmd
        '
        Me.Button_SendCmd.Location = New System.Drawing.Point(16, 49)
        Me.Button_SendCmd.Name = "Button_SendCmd"
        Me.Button_SendCmd.Size = New System.Drawing.Size(115, 23)
        Me.Button_SendCmd.TabIndex = 1
        Me.Button_SendCmd.Text = "CNT SPACE R CR"
        Me.Button_SendCmd.UseVisualStyleBackColor = True
        '
        'TBar_UpdateRate
        '
        Me.TBar_UpdateRate.Location = New System.Drawing.Point(13, 88)
        Me.TBar_UpdateRate.Minimum = 1
        Me.TBar_UpdateRate.Name = "TBar_UpdateRate"
        Me.TBar_UpdateRate.Size = New System.Drawing.Size(104, 45)
        Me.TBar_UpdateRate.TabIndex = 2
        Me.TBar_UpdateRate.TickStyle = System.Windows.Forms.TickStyle.None
        Me.TBar_UpdateRate.Value = 1
        '
        'Label_UpdateRate
        '
        Me.Label_UpdateRate.AutoSize = True
        Me.Label_UpdateRate.Location = New System.Drawing.Point(124, 100)
        Me.Label_UpdateRate.Name = "Label_UpdateRate"
        Me.Label_UpdateRate.Size = New System.Drawing.Size(39, 13)
        Me.Label_UpdateRate.TabIndex = 3
        Me.Label_UpdateRate.Text = "Label1"
        '
        'Button_Port
        '
        Me.Button_Port.Location = New System.Drawing.Point(16, 140)
        Me.Button_Port.Name = "Button_Port"
        Me.Button_Port.Size = New System.Drawing.Size(75, 23)
        Me.Button_Port.TabIndex = 4
        Me.Button_Port.Text = "Port"
        Me.Button_Port.UseVisualStyleBackColor = True
        '
        'Timer_Update
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button_Port)
        Me.Controls.Add(Me.Label_UpdateRate)
        Me.Controls.Add(Me.TBar_UpdateRate)
        Me.Controls.Add(Me.Button_SendCmd)
        Me.Controls.Add(Me.Label_Counter)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Hengstler Count"
        CType(Me.TBar_UpdateRate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label_Counter As Label
    Friend WithEvents HengstlerSerialPort As IO.Ports.SerialPort
    Friend WithEvents Button_SendCmd As Button
    Friend WithEvents TBar_UpdateRate As TrackBar
    Friend WithEvents Label_UpdateRate As Label
    Friend WithEvents Button_Port As Button
    Friend WithEvents Timer_Update As Timer
End Class
