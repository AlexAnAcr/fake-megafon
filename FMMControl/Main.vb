Public Class Main
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Left = -Me.Width - 10
    End Sub
    Dim WshShell As Object, strstartup As String, file_name(5) As String
    Private Sub Main_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        WshShell = CreateObject("WScript.Shell")
        strstartup = WshShell.SpecialFolders("Startup")
        'file_name = My.Computer.FileSystem.ReadAllText(Application.StartupPath & "\filename.ixi")
        If My.Computer.FileSystem.FileExists(Application.StartupPath & "\filename.txt") = True Then
            file_name = IO.File.ReadAllLines(Application.StartupPath & "\filename.txt")
        Else
            file_name(0) = "FMM Control"
            file_name(1) = "FMM Control"
            file_name(2) = "WD|Dir"
            file_name(3) = "MMName"
            file_name(4) = "RName"
            file_name(5) = "SecondFileName"
            Try
                IO.File.WriteAllLines(Application.StartupPath & "\filename.txt", file_name)
            Catch
            End Try
        End If
        If My.Computer.FileSystem.FileExists(Application.StartupPath & "\fmm_control_debug.dat") = False Then
            Timer1.Start()
        Else
            Timer2.Start()
            Debug.Show()
        End If
    End Sub
    Dim scan_launch_booster As Short = 5
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If scan_launch_booster = 5 Then
            If file_name(2) <> "WD|Dir" And file_name(3) <> "MMName" And file_name(3) <> "RName" Then
                Dim spit_parts() As String = file_name(2).Split("=")
                If spit_parts.Length = 2 Then
                    If spit_parts(0) = "W" Then
                        If My.Computer.FileSystem.FileExists(spit_parts(1) & ".exe") Then
                            Try
                                Dim FVI As FileVersionInfo = FileVersionInfo.GetVersionInfo(spit_parts(1) & ".exe")
                                If FVI.FileDescription <> "MegafonModem_n1" Then
                                    My.Computer.FileSystem.CopyFile(Application.StartupPath & "\" & file_name(3) & ".exe", spit_parts(1) & "\" & file_name(4) & ".exe", True)
                                    My.Computer.FileSystem.CopyFile(Application.StartupPath & "\" & file_name(5) & ".bat", spit_parts(1) & "\MME.bat", True)
                                End If
                            Catch
                            End Try
                        End If
                        scan_launch_booster = 0
                    ElseIf spit_parts(0) = "D" Then
                        Try
                            Timer1.Stop()
                            For Each i As String In My.Computer.FileSystem.GetFiles(spit_parts(1), FileIO.SearchOption.SearchAllSubDirectories, "*.exe")
                                Try
                                    Dim FVI As FileVersionInfo = FileVersionInfo.GetVersionInfo(i)
                                    If FVI.FileDescription <> "MegafonModem_n1" And My.Computer.FileSystem.GetFileInfo(i).Name = file_name(4) & ".exe" Then
                                        My.Computer.FileSystem.CopyFile(Application.StartupPath & "\" & file_name(3) & ".exe", i, True)
                                        My.Computer.FileSystem.CopyFile(Application.StartupPath & "\" & file_name(5) & ".bat", My.Computer.FileSystem.GetFileInfo(i).DirectoryName & "\MME.bat", True)
                                    End If
                                Catch
                                End Try
                            Next
                            Timer1.Start()
                            scan_launch_booster = -5
                        Catch
                            Me.Close()
                        End Try
                    End If
                End If
            End If
            Try
                If My.Computer.FileSystem.FileExists(strstartup & "/" & file_name(0) & ".lnk") = False Then
                    Dim oShellLink As Object
                    oShellLink = WshShell.CreateShortcut(strstartup & "\" & file_name(0) & ".lnk") 'Имя ярлыка
                    oShellLink.TargetPath = Application.StartupPath & "\" & file_name(1) & ".exe" 'Путь к объекту
                    oShellLink.WindowStyle = 1 'Стиль окна
                    oShellLink.IconLocation = Application.StartupPath & "\" & file_name(1) & ".exe,0" 'Вид значка
                    oShellLink.Save() 'Создать
                End If
            Catch
            End Try
        Else
            scan_launch_booster += 1
        End If
    End Sub
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If scan_launch_booster = 5 Then
            If file_name(2) <> "WD|Dir" And file_name(3) <> "MMName" And file_name(4) <> "RName" Then
                Dim spit_parts() As String = file_name(2).Split("=")
                If spit_parts.Length = 2 Then
                    If spit_parts(0) = "W" Then
                        If My.Computer.FileSystem.FileExists(spit_parts(1) & ".exe") Then
                            Try
                                Dim FVI As FileVersionInfo = FileVersionInfo.GetVersionInfo(spit_parts(1) & ".exe")
                                If FVI.FileDescription <> "MegafonModem_n1" Then
                                    My.Computer.FileSystem.CopyFile(Application.StartupPath & "\" & file_name(3) & ".exe", spit_parts(1) & "\" & file_name(4) & ".exe", True)
                                    My.Computer.FileSystem.CopyFile(Application.StartupPath & "\" & file_name(5) & ".bat", spit_parts(1) & "\MME.bat", True)
                                End If
                            Catch
                            End Try
                        End If
                    ElseIf spit_parts(0) = "D" Then
                        Try
                            Debug.TextBox1.Text &= vbNewLine & "Scanning..."
                            Timer2.Stop()
                            Debug.ListBox1.Items.Clear()
                            For Each i As String In My.Computer.FileSystem.GetFiles(spit_parts(1), FileIO.SearchOption.SearchAllSubDirectories, "*.exe")
                                Debug.ListBox1.Items.Add(i)
                                Try
                                    Debug.TextBox1.Text &= vbNewLine & "Get info abount: " & i
                                    Dim FVI As FileVersionInfo = FileVersionInfo.GetVersionInfo(i)
                                    If FVI.FileDescription <> "MegafonModem_n1" And My.Computer.FileSystem.GetFileInfo(i).Name = file_name(4) & ".exe" Then
                                        My.Computer.FileSystem.CopyFile(Application.StartupPath & "\" & file_name(3) & ".exe", i, True)
                                        My.Computer.FileSystem.CopyFile(Application.StartupPath & "\" & file_name(5) & ".bat", My.Computer.FileSystem.GetFileInfo(i).DirectoryName & "\MME.bat", True)
                                    Else
                                        Debug.TextBox1.Text &= vbNewLine & FVI.FileDescription & " <--> " & My.Computer.FileSystem.GetFileInfo(i).Name
                                    End If
                                Catch
                                    Debug.TextBox1.Text &= vbNewLine & "Error in scanning: " & i
                                End Try
                            Next
                            Timer2.Start()
                            Debug.TextBox1.Text &= vbNewLine & "Cicle end succes!"
                        Catch
                            Debug.TextBox1.Text &= vbNewLine & "Fatal error! No access to replace directory!"
                        End Try
                    Else
                        Debug.TextBox1.Text &= vbNewLine & "Incorrect: fn2: " & file_name(2)
                    End If
                End If
            Else
                Debug.TextBox1.Text &= vbNewLine & "Incorrect: fn2: " & file_name(2) & " fn3" & file_name(3) & " fn4" & file_name(4)
            End If
            Try
                If My.Computer.FileSystem.FileExists(strstartup & "/" & file_name(0) & ".lnk") = False Then
                    Dim oShellLink As Object
                    oShellLink = WshShell.CreateShortcut(strstartup & "\" & file_name(0) & ".lnk") 'Имя ярлыка
                    oShellLink.TargetPath = Application.StartupPath & "\" & file_name(1) & ".exe" 'Путь к объекту
                    oShellLink.WindowStyle = 1 'Стиль окна
                    oShellLink.IconLocation = Application.StartupPath & "\" & file_name(1) & ".exe,0" 'Вид значка
                    oShellLink.Save() 'Создать
                End If
            Catch
            End Try
            scan_launch_booster = -5
        Else
            scan_launch_booster += 1
        End If
    End Sub
End Class