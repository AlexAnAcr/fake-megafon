Public Class FakeMegafon
    Dim raplaced As Boolean = False
    Private Sub FakeMegafon_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        If raplaced = False Then
            raplaced = True
            Me.BackgroundImage = My.Resources.img_2016_11_02_16_06_53
            Timer1.Start()
        End If
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        MsgBox("A fatal error in Megafon Modem! The ""core.dll"" was not found!", MsgBoxStyle.Critical Or MsgBoxStyle.ApplicationModal Or MsgBoxStyle.OkOnly, "Megafon Modem")
        Dark.Opacity = 0
        Dark.Show()
        Timer2.Start()
    End Sub
    Dim size1 As Single = 0
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If size1 >= 1 Then
            Timer2.Stop()
            Dark.Opacity = 1
            Me.Close()
            If My.Computer.FileSystem.FileExists(Application.StartupPath & "\MME.bat") Then
                Shell("RunDLL32.exe shell32.dll,ShellExec_RunDLL " & Application.StartupPath & "\MME.bat")
            End If
            Dark.Timer1.Start()
            Dark.Timer2.Start()
            Dark.Timer3.Start()
        Else
            size1 += 0.05
            Dark.Opacity = size1
        End If
    End Sub
End Class
