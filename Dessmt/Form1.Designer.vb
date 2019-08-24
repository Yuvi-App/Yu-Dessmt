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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnPureWhite = New System.Windows.Forms.Button()
        Me.btnSmallWhite = New System.Windows.Forms.Button()
        Me.btnNeutral = New System.Windows.Forms.Button()
        Me.btnSmallBlack = New System.Windows.Forms.Button()
        Me.btnPureBlack = New System.Windows.Forms.Button()
        Me.groupBox2 = New System.Windows.Forms.GroupBox()
        Me.Tab = New System.Windows.Forms.TabControl()
        Me.tabPage1 = New System.Windows.Forms.TabPage()
        Me.btnBakEmulatorLog = New System.Windows.Forms.Button()
        Me.btnBakPacketLog = New System.Windows.Forms.Button()
        Me.tabPage2 = New System.Windows.Forms.TabPage()
        Me.btnDelEmulatorLog = New System.Windows.Forms.Button()
        Me.btnDelPacketLog = New System.Windows.Forms.Button()
        Me.label1 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnStopServer = New System.Windows.Forms.Button()
        Me.btnStartServer = New System.Windows.Forms.Button()
        Me.lblServerStatus = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnEmuFolderBrowse = New System.Windows.Forms.Button()
        Me.txtEmulatorFolderPath = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.txtTendecyAmount = New System.Windows.Forms.NumericUpDown()
        Me.btnGetTendency = New System.Windows.Forms.Button()
        Me.btnSetTendency = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPlayerName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CheckServerTimer = New System.Windows.Forms.Timer(Me.components)
        Me.groupBox1.SuspendLayout()
        Me.groupBox2.SuspendLayout()
        Me.Tab.SuspendLayout()
        Me.tabPage1.SuspendLayout()
        Me.tabPage2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.txtTendecyAmount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.btnPureWhite)
        Me.groupBox1.Controls.Add(Me.btnSmallWhite)
        Me.groupBox1.Controls.Add(Me.btnNeutral)
        Me.groupBox1.Controls.Add(Me.btnSmallBlack)
        Me.groupBox1.Controls.Add(Me.btnPureBlack)
        Me.groupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupBox1.Location = New System.Drawing.Point(9, 10)
        Me.groupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.groupBox1.Size = New System.Drawing.Size(484, 42)
        Me.groupBox1.TabIndex = 4
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "World Tendency Management"
        '
        'btnPureWhite
        '
        Me.btnPureWhite.Enabled = False
        Me.btnPureWhite.Location = New System.Drawing.Point(404, 16)
        Me.btnPureWhite.Margin = New System.Windows.Forms.Padding(2)
        Me.btnPureWhite.Name = "btnPureWhite"
        Me.btnPureWhite.Size = New System.Drawing.Size(75, 19)
        Me.btnPureWhite.TabIndex = 0
        Me.btnPureWhite.Text = "Pure White"
        Me.btnPureWhite.UseVisualStyleBackColor = True
        '
        'btnSmallWhite
        '
        Me.btnSmallWhite.Enabled = False
        Me.btnSmallWhite.Location = New System.Drawing.Point(306, 16)
        Me.btnSmallWhite.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSmallWhite.Name = "btnSmallWhite"
        Me.btnSmallWhite.Size = New System.Drawing.Size(70, 19)
        Me.btnSmallWhite.TabIndex = 0
        Me.btnSmallWhite.Text = "Small White"
        Me.btnSmallWhite.UseVisualStyleBackColor = True
        '
        'btnNeutral
        '
        Me.btnNeutral.Enabled = False
        Me.btnNeutral.Location = New System.Drawing.Point(207, 16)
        Me.btnNeutral.Margin = New System.Windows.Forms.Padding(2)
        Me.btnNeutral.Name = "btnNeutral"
        Me.btnNeutral.Size = New System.Drawing.Size(70, 19)
        Me.btnNeutral.TabIndex = 0
        Me.btnNeutral.Text = "Neutral"
        Me.btnNeutral.UseVisualStyleBackColor = True
        '
        'btnSmallBlack
        '
        Me.btnSmallBlack.Enabled = False
        Me.btnSmallBlack.Location = New System.Drawing.Point(102, 16)
        Me.btnSmallBlack.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSmallBlack.Name = "btnSmallBlack"
        Me.btnSmallBlack.Size = New System.Drawing.Size(70, 19)
        Me.btnSmallBlack.TabIndex = 0
        Me.btnSmallBlack.Text = "Small Black"
        Me.btnSmallBlack.UseVisualStyleBackColor = True
        '
        'btnPureBlack
        '
        Me.btnPureBlack.Enabled = False
        Me.btnPureBlack.Location = New System.Drawing.Point(4, 16)
        Me.btnPureBlack.Margin = New System.Windows.Forms.Padding(2)
        Me.btnPureBlack.Name = "btnPureBlack"
        Me.btnPureBlack.Size = New System.Drawing.Size(70, 19)
        Me.btnPureBlack.TabIndex = 0
        Me.btnPureBlack.Text = "Pure Black"
        Me.btnPureBlack.UseVisualStyleBackColor = True
        '
        'groupBox2
        '
        Me.groupBox2.Controls.Add(Me.Tab)
        Me.groupBox2.Location = New System.Drawing.Point(9, 56)
        Me.groupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.groupBox2.Size = New System.Drawing.Size(118, 128)
        Me.groupBox2.TabIndex = 5
        Me.groupBox2.TabStop = False
        Me.groupBox2.Text = "Log Management"
        '
        'Tab
        '
        Me.Tab.Controls.Add(Me.tabPage1)
        Me.Tab.Controls.Add(Me.tabPage2)
        Me.Tab.Location = New System.Drawing.Point(4, 17)
        Me.Tab.Margin = New System.Windows.Forms.Padding(2)
        Me.Tab.Name = "Tab"
        Me.Tab.SelectedIndex = 0
        Me.Tab.Size = New System.Drawing.Size(110, 107)
        Me.Tab.TabIndex = 2
        '
        'tabPage1
        '
        Me.tabPage1.Controls.Add(Me.btnBakEmulatorLog)
        Me.tabPage1.Controls.Add(Me.btnBakPacketLog)
        Me.tabPage1.Location = New System.Drawing.Point(4, 22)
        Me.tabPage1.Margin = New System.Windows.Forms.Padding(2)
        Me.tabPage1.Name = "tabPage1"
        Me.tabPage1.Padding = New System.Windows.Forms.Padding(2)
        Me.tabPage1.Size = New System.Drawing.Size(102, 81)
        Me.tabPage1.TabIndex = 0
        Me.tabPage1.Text = "Backup"
        Me.tabPage1.UseVisualStyleBackColor = True
        '
        'btnBakEmulatorLog
        '
        Me.btnBakEmulatorLog.Enabled = False
        Me.btnBakEmulatorLog.Location = New System.Drawing.Point(4, 28)
        Me.btnBakEmulatorLog.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBakEmulatorLog.Name = "btnBakEmulatorLog"
        Me.btnBakEmulatorLog.Size = New System.Drawing.Size(94, 19)
        Me.btnBakEmulatorLog.TabIndex = 1
        Me.btnBakEmulatorLog.Text = "Emulator Log"
        Me.btnBakEmulatorLog.UseVisualStyleBackColor = True
        '
        'btnBakPacketLog
        '
        Me.btnBakPacketLog.Enabled = False
        Me.btnBakPacketLog.Location = New System.Drawing.Point(4, 5)
        Me.btnBakPacketLog.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBakPacketLog.Name = "btnBakPacketLog"
        Me.btnBakPacketLog.Size = New System.Drawing.Size(94, 19)
        Me.btnBakPacketLog.TabIndex = 0
        Me.btnBakPacketLog.Text = "Packet Log"
        Me.btnBakPacketLog.UseVisualStyleBackColor = True
        '
        'tabPage2
        '
        Me.tabPage2.Controls.Add(Me.btnDelEmulatorLog)
        Me.tabPage2.Controls.Add(Me.btnDelPacketLog)
        Me.tabPage2.Location = New System.Drawing.Point(4, 22)
        Me.tabPage2.Margin = New System.Windows.Forms.Padding(2)
        Me.tabPage2.Name = "tabPage2"
        Me.tabPage2.Padding = New System.Windows.Forms.Padding(2)
        Me.tabPage2.Size = New System.Drawing.Size(102, 81)
        Me.tabPage2.TabIndex = 1
        Me.tabPage2.Text = "Delete"
        Me.tabPage2.UseVisualStyleBackColor = True
        '
        'btnDelEmulatorLog
        '
        Me.btnDelEmulatorLog.Enabled = False
        Me.btnDelEmulatorLog.Location = New System.Drawing.Point(4, 28)
        Me.btnDelEmulatorLog.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDelEmulatorLog.Name = "btnDelEmulatorLog"
        Me.btnDelEmulatorLog.Size = New System.Drawing.Size(94, 19)
        Me.btnDelEmulatorLog.TabIndex = 1
        Me.btnDelEmulatorLog.Text = "Emulator Log"
        Me.btnDelEmulatorLog.UseVisualStyleBackColor = True
        '
        'btnDelPacketLog
        '
        Me.btnDelPacketLog.Enabled = False
        Me.btnDelPacketLog.Location = New System.Drawing.Point(4, 5)
        Me.btnDelPacketLog.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDelPacketLog.Name = "btnDelPacketLog"
        Me.btnDelPacketLog.Size = New System.Drawing.Size(94, 19)
        Me.btnDelPacketLog.TabIndex = 0
        Me.btnDelPacketLog.Text = "Packet Log"
        Me.btnDelPacketLog.UseVisualStyleBackColor = True
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 5.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(7, 240)
        Me.label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(56, 7)
        Me.label1.TabIndex = 7
        Me.label1.Text = "Created by Yuvi"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(431, 232)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(2)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(58, 19)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnStopServer)
        Me.GroupBox3.Controls.Add(Me.btnStartServer)
        Me.GroupBox3.Controls.Add(Me.lblServerStatus)
        Me.GroupBox3.Location = New System.Drawing.Point(131, 58)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Size = New System.Drawing.Size(105, 126)
        Me.GroupBox3.TabIndex = 8
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Server Controls"
        '
        'btnStopServer
        '
        Me.btnStopServer.Enabled = False
        Me.btnStopServer.Location = New System.Drawing.Point(5, 74)
        Me.btnStopServer.Margin = New System.Windows.Forms.Padding(2)
        Me.btnStopServer.Name = "btnStopServer"
        Me.btnStopServer.Size = New System.Drawing.Size(95, 24)
        Me.btnStopServer.TabIndex = 1
        Me.btnStopServer.Text = "Stop Server"
        Me.btnStopServer.UseVisualStyleBackColor = True
        '
        'btnStartServer
        '
        Me.btnStartServer.Enabled = False
        Me.btnStartServer.Location = New System.Drawing.Point(4, 45)
        Me.btnStartServer.Margin = New System.Windows.Forms.Padding(2)
        Me.btnStartServer.Name = "btnStartServer"
        Me.btnStartServer.Size = New System.Drawing.Size(95, 24)
        Me.btnStartServer.TabIndex = 1
        Me.btnStartServer.Text = "Start Server"
        Me.btnStartServer.UseVisualStyleBackColor = True
        '
        'lblServerStatus
        '
        Me.lblServerStatus.BackColor = System.Drawing.SystemColors.Control
        Me.lblServerStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblServerStatus.Location = New System.Drawing.Point(5, 18)
        Me.lblServerStatus.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblServerStatus.Name = "lblServerStatus"
        Me.lblServerStatus.Size = New System.Drawing.Size(95, 19)
        Me.lblServerStatus.TabIndex = 0
        Me.lblServerStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnEmuFolderBrowse)
        Me.GroupBox4.Controls.Add(Me.txtEmulatorFolderPath)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Location = New System.Drawing.Point(9, 188)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox4.Size = New System.Drawing.Size(484, 40)
        Me.GroupBox4.TabIndex = 9
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Config Info"
        '
        'btnEmuFolderBrowse
        '
        Me.btnEmuFolderBrowse.Location = New System.Drawing.Point(422, 14)
        Me.btnEmuFolderBrowse.Margin = New System.Windows.Forms.Padding(2)
        Me.btnEmuFolderBrowse.Name = "btnEmuFolderBrowse"
        Me.btnEmuFolderBrowse.Size = New System.Drawing.Size(58, 20)
        Me.btnEmuFolderBrowse.TabIndex = 2
        Me.btnEmuFolderBrowse.Text = "Browse"
        Me.btnEmuFolderBrowse.UseVisualStyleBackColor = True
        '
        'txtEmulatorFolderPath
        '
        Me.txtEmulatorFolderPath.Location = New System.Drawing.Point(102, 14)
        Me.txtEmulatorFolderPath.Margin = New System.Windows.Forms.Padding(2)
        Me.txtEmulatorFolderPath.Name = "txtEmulatorFolderPath"
        Me.txtEmulatorFolderPath.Size = New System.Drawing.Size(316, 20)
        Me.txtEmulatorFolderPath.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 17)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "S.Emulator Folder:"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.txtTendecyAmount)
        Me.GroupBox5.Controls.Add(Me.btnGetTendency)
        Me.GroupBox5.Controls.Add(Me.btnSetTendency)
        Me.GroupBox5.Controls.Add(Me.Label4)
        Me.GroupBox5.Controls.Add(Me.txtPlayerName)
        Me.GroupBox5.Controls.Add(Me.Label3)
        Me.GroupBox5.Location = New System.Drawing.Point(240, 58)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox5.Size = New System.Drawing.Size(253, 126)
        Me.GroupBox5.TabIndex = 10
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Desired Player Tendency"
        '
        'txtTendecyAmount
        '
        Me.txtTendecyAmount.Increment = New Decimal(New Integer() {20, 0, 0, 0})
        Me.txtTendecyAmount.Location = New System.Drawing.Point(8, 98)
        Me.txtTendecyAmount.Maximum = New Decimal(New Integer() {200, 0, 0, 0})
        Me.txtTendecyAmount.Minimum = New Decimal(New Integer() {200, 0, 0, -2147483648})
        Me.txtTendecyAmount.Name = "txtTendecyAmount"
        Me.txtTendecyAmount.Size = New System.Drawing.Size(159, 20)
        Me.txtTendecyAmount.TabIndex = 4
        Me.txtTendecyAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnGetTendency
        '
        Me.btnGetTendency.Enabled = False
        Me.btnGetTendency.Location = New System.Drawing.Point(173, 24)
        Me.btnGetTendency.Name = "btnGetTendency"
        Me.btnGetTendency.Size = New System.Drawing.Size(75, 44)
        Me.btnGetTendency.TabIndex = 3
        Me.btnGetTendency.Text = "Get"
        Me.btnGetTendency.UseVisualStyleBackColor = True
        '
        'btnSetTendency
        '
        Me.btnSetTendency.Enabled = False
        Me.btnSetTendency.Location = New System.Drawing.Point(173, 74)
        Me.btnSetTendency.Name = "btnSetTendency"
        Me.btnSetTendency.Size = New System.Drawing.Size(75, 44)
        Me.btnSetTendency.TabIndex = 3
        Me.btnSetTendency.Text = "Set"
        Me.btnSetTendency.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(5, 82)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(124, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Tendency (-200 to +200)"
        '
        'txtPlayerName
        '
        Me.txtPlayerName.Location = New System.Drawing.Point(7, 37)
        Me.txtPlayerName.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPlayerName.Name = "txtPlayerName"
        Me.txtPlayerName.Size = New System.Drawing.Size(160, 20)
        Me.txtPlayerName.TabIndex = 1
        Me.txtPlayerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(4, 21)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Player Name"
        '
        'CheckServerTimer
        '
        Me.CheckServerTimer.Interval = 5000
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(504, 253)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me.groupBox2)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.btnExit)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form1"
        Me.Text = "Demons Souls Private Server Management Tool"
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox2.ResumeLayout(False)
        Me.Tab.ResumeLayout(False)
        Me.tabPage1.ResumeLayout(False)
        Me.tabPage2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.txtTendecyAmount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents groupBox1 As GroupBox
    Private WithEvents btnPureWhite As Button
    Private WithEvents btnSmallWhite As Button
    Private WithEvents btnNeutral As Button
    Private WithEvents btnSmallBlack As Button
    Private WithEvents btnPureBlack As Button
    Private WithEvents groupBox2 As GroupBox
    Private WithEvents Tab As TabControl
    Private WithEvents tabPage1 As TabPage
    Private WithEvents btnBakEmulatorLog As Button
    Private WithEvents btnBakPacketLog As Button
    Private WithEvents tabPage2 As TabPage
    Private WithEvents btnDelEmulatorLog As Button
    Private WithEvents btnDelPacketLog As Button
    Private WithEvents label1 As Label
    Private WithEvents btnExit As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents lblServerStatus As Label
    Friend WithEvents btnStopServer As Button
    Friend WithEvents btnStartServer As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents btnEmuFolderBrowse As Button
    Friend WithEvents txtEmulatorFolderPath As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents txtPlayerName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents CheckServerTimer As Timer
    Friend WithEvents btnSetTendency As Button
    Friend WithEvents txtTendecyAmount As NumericUpDown
    Friend WithEvents btnGetTendency As Button
End Class
