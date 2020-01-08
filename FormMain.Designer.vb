<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMain
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.textBoxRcvData = New System.Windows.Forms.TextBox()
        Me.labelRcvData = New System.Windows.Forms.Label()
        Me.textBoxStatus = New System.Windows.Forms.TextBox()
        Me.labelStatus = New System.Windows.Forms.Label()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.textBoxPort = New System.Windows.Forms.TextBox()
        Me.textBoxIpAddress = New System.Windows.Forms.TextBox()
        Me.lblPort = New System.Windows.Forms.Label()
        Me.lblIpAddress = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.White
        Me.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnClear.ForeColor = System.Drawing.Color.Black
        Me.btnClear.Location = New System.Drawing.Point(169, 196)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 21
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'textBoxRcvData
        '
        Me.textBoxRcvData.Location = New System.Drawing.Point(68, 222)
        Me.textBoxRcvData.Multiline = True
        Me.textBoxRcvData.Name = "textBoxRcvData"
        Me.textBoxRcvData.ReadOnly = True
        Me.textBoxRcvData.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.textBoxRcvData.Size = New System.Drawing.Size(619, 181)
        Me.textBoxRcvData.TabIndex = 20
        '
        'labelRcvData
        '
        Me.labelRcvData.Location = New System.Drawing.Point(38, 196)
        Me.labelRcvData.Name = "labelRcvData"
        Me.labelRcvData.Size = New System.Drawing.Size(104, 23)
        Me.labelRcvData.TabIndex = 19
        Me.labelRcvData.Text = "Recieve Data"
        Me.labelRcvData.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'textBoxStatus
        '
        Me.textBoxStatus.Location = New System.Drawing.Point(169, 148)
        Me.textBoxStatus.Name = "textBoxStatus"
        Me.textBoxStatus.ReadOnly = True
        Me.textBoxStatus.Size = New System.Drawing.Size(235, 19)
        Me.textBoxStatus.TabIndex = 18
        '
        'labelStatus
        '
        Me.labelStatus.Location = New System.Drawing.Point(38, 146)
        Me.labelStatus.Name = "labelStatus"
        Me.labelStatus.Size = New System.Drawing.Size(104, 23)
        Me.labelStatus.TabIndex = 17
        Me.labelStatus.Text = "Status"
        Me.labelStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnStop
        '
        Me.btnStop.BackColor = System.Drawing.Color.White
        Me.btnStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnStop.ForeColor = System.Drawing.Color.Black
        Me.btnStop.Location = New System.Drawing.Point(261, 106)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(75, 23)
        Me.btnStop.TabIndex = 16
        Me.btnStop.Text = "Stop"
        Me.btnStop.UseVisualStyleBackColor = False
        '
        'btnStart
        '
        Me.btnStart.BackColor = System.Drawing.Color.White
        Me.btnStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnStart.ForeColor = System.Drawing.Color.Black
        Me.btnStart.Location = New System.Drawing.Point(169, 106)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(75, 23)
        Me.btnStart.TabIndex = 15
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = False
        '
        'textBoxPort
        '
        Me.textBoxPort.Location = New System.Drawing.Point(169, 67)
        Me.textBoxPort.Name = "textBoxPort"
        Me.textBoxPort.Size = New System.Drawing.Size(235, 19)
        Me.textBoxPort.TabIndex = 14
        '
        'textBoxIpAddress
        '
        Me.textBoxIpAddress.Location = New System.Drawing.Point(169, 26)
        Me.textBoxIpAddress.Name = "textBoxIpAddress"
        Me.textBoxIpAddress.Size = New System.Drawing.Size(235, 19)
        Me.textBoxIpAddress.TabIndex = 13
        '
        'lblPort
        '
        Me.lblPort.Location = New System.Drawing.Point(38, 65)
        Me.lblPort.Name = "lblPort"
        Me.lblPort.Size = New System.Drawing.Size(104, 23)
        Me.lblPort.TabIndex = 12
        Me.lblPort.Text = "Port"
        Me.lblPort.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblIpAddress
        '
        Me.lblIpAddress.Location = New System.Drawing.Point(38, 24)
        Me.lblIpAddress.Name = "lblIpAddress"
        Me.lblIpAddress.Size = New System.Drawing.Size(104, 23)
        Me.lblIpAddress.TabIndex = 11
        Me.lblIpAddress.Text = "IP Address"
        Me.lblIpAddress.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(725, 426)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.textBoxRcvData)
        Me.Controls.Add(Me.labelRcvData)
        Me.Controls.Add(Me.textBoxStatus)
        Me.Controls.Add(Me.labelStatus)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.textBoxPort)
        Me.Controls.Add(Me.textBoxIpAddress)
        Me.Controls.Add(Me.lblPort)
        Me.Controls.Add(Me.lblIpAddress)
        Me.Name = "FormMain"
        Me.Text = "TCP Server"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents btnClear As Button
    Private WithEvents textBoxRcvData As TextBox
    Private WithEvents labelRcvData As Label
    Private WithEvents textBoxStatus As TextBox
    Private WithEvents labelStatus As Label
    Private WithEvents btnStop As Button
    Private WithEvents btnStart As Button
    Private WithEvents textBoxPort As TextBox
    Private WithEvents textBoxIpAddress As TextBox
    Private WithEvents lblPort As Label
    Private WithEvents lblIpAddress As Label
End Class
