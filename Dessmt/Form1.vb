Imports System.IO
Imports System.Data.SQLite

Public Class Form1
    Public Class GlobalVariables
        ' Hold Config Info
        Public Shared strEmulatorLocation As String
        Public Shared strServerFilesFldrLocation As String
        Public Shared strDBLocation As String

        ' Hold Desired Tendency
        Public Shared strDesiredTendency As String
        Public Shared strPlayerName As String

    End Class

    ' Log Management Section
    Private Sub btnBakPacketLog_Click(sender As Object, e As EventArgs) Handles btnBakPacketLog.Click
        Try
            MessageBox.Show("Backing Up Packet Log File.. This may take a minute due to size.")
            My.Computer.FileSystem.CopyFile(
            GlobalVariables.strEmulatorLocation & "packetlog.log",
            GlobalVariables.strServerFilesFldrLocation & "BackupLogs\packetlog.log",
            Microsoft.VisualBasic.FileIO.UIOption.OnlyErrorDialogs,
            Microsoft.VisualBasic.FileIO.UICancelOption.DoNothing)
            MessageBox.Show("Backup Successfull")
        Catch ex As Exception
            MessageBox.Show("Failed to Backup file.. File may not be found.")
        End Try
    End Sub

    Private Sub btnBakEmulatorLog_Click(sender As Object, e As EventArgs) Handles btnBakEmulatorLog.Click
        Try
            MessageBox.Show("Backing Up Emulator Log File..")
            My.Computer.FileSystem.CopyFile(
            GlobalVariables.strEmulatorLocation & "emulator.log",
            GlobalVariables.strServerFilesFldrLocation & "BackupLogs\emulator.log",
            Microsoft.VisualBasic.FileIO.UIOption.OnlyErrorDialogs,
            Microsoft.VisualBasic.FileIO.UICancelOption.DoNothing)
            MessageBox.Show("Backup Successfull")
        Catch ex As Exception
            MessageBox.Show("Failed to Backup file.. File may not be found.")
        End Try

    End Sub

    Private Sub btnDelPacketLog_Click(sender As Object, e As EventArgs) Handles btnDelPacketLog.Click
        Try
            MessageBox.Show("Deleting Packet Log File ")
            My.Computer.FileSystem.DeleteFile(GlobalVariables.strEmulatorLocation & "packetlog.log")
        Catch ex As Exception
            MessageBox.Show("Failed to Delete file.. File may not be found.")
        End Try
    End Sub

    Private Sub btnDelEmulatorLog_Click(sender As Object, e As EventArgs) Handles btnDelEmulatorLog.Click
        Try
            MessageBox.Show("Deleting Emulator Log File ")
            My.Computer.FileSystem.DeleteFile(GlobalVariables.strEmulatorLocation & "Emulator.log")
        Catch ex As Exception
            MessageBox.Show("Failed to Delete file.. File may not be found.")
        End Try
    End Sub

    ' Exit Form
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    ' World Tendency Management
    Private Sub btnPureBlack_Click(sender As Object, e As EventArgs) Handles btnPureBlack.Click
        Try
            MessageBox.Show("Setting Pure Black World Tendency")
            My.Computer.FileSystem.CopyFile(
            GlobalVariables.strServerFilesFldrLocation & "TendencyFiles\PureBlack.py",
            GlobalVariables.strEmulatorLocation & "\emu\PlayerManager.py",
            Microsoft.VisualBasic.FileIO.UIOption.OnlyErrorDialogs,
            Microsoft.VisualBasic.FileIO.UICancelOption.DoNothing)
            MessageBox.Show("Server Successfully set to Pure Black")
        Catch ex As Exception
            MessageBox.Show("Failed to set World Tendency, Template File may not exsist")
        End Try
    End Sub

    Private Sub btnSmallBlack_Click(sender As Object, e As EventArgs) Handles btnSmallBlack.Click
        Try
            MessageBox.Show("Setting Small Black World Tendency")
            My.Computer.FileSystem.CopyFile(
            GlobalVariables.strServerFilesFldrLocation & "TendencyFiles\SmallBlack.py",
            GlobalVariables.strEmulatorLocation & "\emu\PlayerManager.py",
            Microsoft.VisualBasic.FileIO.UIOption.OnlyErrorDialogs,
            Microsoft.VisualBasic.FileIO.UICancelOption.DoNothing)
            MessageBox.Show("Server Successfully set to Small Black")
        Catch ex As Exception
            MessageBox.Show("Failed to set World Tendency, Template File may not exsist")
        End Try
    End Sub

    Private Sub btnNeutral_Click(sender As Object, e As EventArgs) Handles btnNeutral.Click
        Try
            MessageBox.Show("Setting Neutral World Tendency")
            My.Computer.FileSystem.CopyFile(
            GlobalVariables.strServerFilesFldrLocation & "TendencyFiles\Neutral.py",
            GlobalVariables.strEmulatorLocation & "\emu\PlayerManager.py",
            Microsoft.VisualBasic.FileIO.UIOption.OnlyErrorDialogs,
            Microsoft.VisualBasic.FileIO.UICancelOption.DoNothing)
            MessageBox.Show("Server Successfully set to Neutral")
        Catch ex As Exception
            MessageBox.Show("Failed to set World Tendency, Template File may not exsist")
        End Try
    End Sub

    Private Sub btnSmallWhite_Click(sender As Object, e As EventArgs) Handles btnSmallWhite.Click
        Try
            MessageBox.Show("Setting Small White World Tendency")
            My.Computer.FileSystem.CopyFile(
            GlobalVariables.strServerFilesFldrLocation & "TendencyFiles\SmallWhite.py",
            GlobalVariables.strEmulatorLocation & "\emu\PlayerManager.py",
            Microsoft.VisualBasic.FileIO.UIOption.OnlyErrorDialogs,
            Microsoft.VisualBasic.FileIO.UICancelOption.DoNothing)
            MessageBox.Show("Server Successfully set to Small White")
        Catch ex As Exception
            MessageBox.Show("Failed to set World Tendency, Template File may not exsist")
        End Try
    End Sub

    Private Sub btnPureWhite_Click(sender As Object, e As EventArgs) Handles btnPureWhite.Click
        Try
            MessageBox.Show("Setting Pure White World Tendency")
            My.Computer.FileSystem.CopyFile(
            GlobalVariables.strServerFilesFldrLocation & "TendencyFiles\PureWhite.py",
            GlobalVariables.strEmulatorLocation & "\emu\PlayerManager.py",
            Microsoft.VisualBasic.FileIO.UIOption.OnlyErrorDialogs,
            Microsoft.VisualBasic.FileIO.UICancelOption.DoNothing)
            MessageBox.Show("Server Successfully set to Pure White")
        Catch ex As Exception
            MessageBox.Show("Failed to set World Tendency, Template File may not exsist")
        End Try
    End Sub

    ' Set Emulator Location and Save to file for
    Private Sub btnEmuFolderBrowse_Click(sender As Object, e As EventArgs) Handles btnEmuFolderBrowse.Click
        Try
            If (FolderBrowserDialog1.ShowDialog() = DialogResult.OK) Then
                txtEmulatorFolderPath.Text = FolderBrowserDialog1.SelectedPath
                GlobalVariables.strEmulatorLocation = FolderBrowserDialog1.SelectedPath
                If Not Directory.Exists(FolderBrowserDialog1.SelectedPath & "\ServerManagementFiles\") Then
                    My.Computer.FileSystem.CreateDirectory(FolderBrowserDialog1.SelectedPath & "\ServerManagementFiles\")
                End If
                GlobalVariables.strServerFilesFldrLocation = FolderBrowserDialog1.SelectedPath & "\ServerManagementFiles\"
                GlobalVariables.strDBLocation = FolderBrowserDialog1.SelectedPath & "\db\players.sqlite"
                Dim Writer As System.IO.StreamWriter
                Writer = My.Computer.FileSystem.OpenTextFileWriter(FolderBrowserDialog1.SelectedPath & "\ServerManagementFiles\" & "Config.ini", False)
                Writer.WriteLine("-------Demon's Souls Server Management Config-------")
                Writer.WriteLine("[Emulator Location]")
                Writer.WriteLine(GlobalVariables.strEmulatorLocation)
                Writer.WriteLine("[Server Management Files Location]")
                Writer.WriteLine(GlobalVariables.strServerFilesFldrLocation)
                Writer.WriteLine("[DB Player File Location]")
                Writer.WriteLine(GlobalVariables.strDBLocation)
                Writer.Close()
                btnBakEmulatorLog.Enabled = True
                btnBakPacketLog.Enabled = True
                btnDelEmulatorLog.Enabled = True
                btnDelPacketLog.Enabled = True
                btnNeutral.Enabled = True
                btnPureBlack.Enabled = True
                btnPureWhite.Enabled = True
                btnSmallBlack.Enabled = True
                btnSmallWhite.Enabled = True
                btnStartServer.Enabled = True
                btnStopServer.Enabled = True
                btnSetTendency.Enabled = True
                btnGetTendency.Enabled = True
                If Not Directory.Exists(FolderBrowserDialog1.SelectedPath & "\ServerManagementFiles\BackupLogs") Then
                    My.Computer.FileSystem.CreateDirectory(FolderBrowserDialog1.SelectedPath & "\ServerManagementFiles\BackupLogs")
                End If
            Else
                MsgBox("Please Select the Emulator Folder Location")
            End If
        Catch ex As Exception
            MsgBox("Error")
        End Try
    End Sub

    ' Load Config File
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckServerTimer.Enabled = True
        ' Read Config File
        If System.IO.File.Exists("Config.ini") Then
            Dim line As String() = IO.File.ReadAllLines("Config.ini")
            GlobalVariables.strEmulatorLocation = line(2)
            GlobalVariables.strServerFilesFldrLocation = line(4)
            GlobalVariables.strDBLocation = line(6)
            txtEmulatorFolderPath.Text = GlobalVariables.strEmulatorLocation
            btnBakEmulatorLog.Enabled = True
            btnBakPacketLog.Enabled = True
            btnDelEmulatorLog.Enabled = True
            btnDelPacketLog.Enabled = True
            btnNeutral.Enabled = True
            btnPureBlack.Enabled = True
            btnPureWhite.Enabled = True
            btnSmallBlack.Enabled = True
            btnSmallWhite.Enabled = True
            btnStartServer.Enabled = True
            btnStopServer.Enabled = True
            btnSetTendency.Enabled = True
            btnGetTendency.Enabled = True
        End If
    End Sub

    ' Timer for checking if server is running
    Private Sub CheckServerTimer_Tick(sender As Object, e As EventArgs) Handles CheckServerTimer.Tick
        Dim ServerRunning = Process.GetProcessesByName("python.exe")
        If ServerRunning.Count > 0 Then
            lblServerStatus.Text = "Running"
            lblServerStatus.BackColor = Color.Lime
        Else
            lblServerStatus.Text = "Not Running"
            lblServerStatus.BackColor = Color.LightCoral
        End If
    End Sub

    ' Set Desired Tendency for any player
    Private Sub BtnSetTendency_Click(sender As Object, e As EventArgs) Handles btnSetTendency.Click
        ' SQLite Stuff
        Try
            Dim sqlite_conn As SQLiteConnection
            Dim sqlite_cmd As SQLiteCommand
            If Not txtPlayerName.Text = "" Then
                GlobalVariables.strPlayerName = txtPlayerName.Text & "0"
                GlobalVariables.strDesiredTendency = txtTendecyAmount.Text
                sqlite_conn = New SQLiteConnection("Data Source=" & GlobalVariables.strDBLocation & ";Version=3;")
                sqlite_conn.Open()
                sqlite_cmd = sqlite_conn.CreateCommand()
                sqlite_cmd.CommandText = ("UPDATE players SET desired_tendency = '" & GlobalVariables.strDesiredTendency & "' WHERE characterID = '" & GlobalVariables.strPlayerName & "'")
                sqlite_cmd.ExecuteNonQuery()
                sqlite_conn.Close()
                MessageBox.Show("Successful Update")
            Else
                MessageBox.Show("Please enter a Player Name and Please select tendency between -200 and 200")
            End If
        Catch ex As Exception
            MsgBox("Sql Command Failed to Run please try again")
        End Try
    End Sub


    ' Gets Current Tendency
    Private Sub BtnGetTendency_Click(sender As Object, e As EventArgs) Handles btnGetTendency.Click
        Try
            ' SQLite Stuff
            Dim sqlite_conn As New SQLiteConnection("Data Source=" & GlobalVariables.strDBLocation & ";Version=3;")
            If Not txtPlayerName.Text = "" Then
                GlobalVariables.strPlayerName = txtPlayerName.Text & "0"
                Dim decTendency As Decimal
                sqlite_conn.Open()
                Using cmd As New SQLiteCommand("SELECT desired_tendency FROM players WHERE characterID = '" & GlobalVariables.strPlayerName & "'", sqlite_conn)
                    decTendency = CDec(cmd.ExecuteScalar)
                End Using
                sqlite_conn.Close()
                txtTendecyAmount.Value = decTendency
            Else
                MessageBox.Show("Please enter a Player Name")
            End If
        Catch ex As Exception
            MsgBox("Sql Command Failed to Run please try again")
        End Try
    End Sub
End Class
