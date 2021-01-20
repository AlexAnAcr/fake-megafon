Public Class Dark
    Private Sub Dark_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Left = -2
        Me.Top = -2
        Me.Width = My.Computer.Screen.Bounds.Width + 4
        Me.Opacity = 0
        Me.Height = My.Computer.Screen.Bounds.Height + 4
        pos.X = 80
        pos.Y = 80
    End Sub
    Dim back_number As Short = 10
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If back_number = 0 Then
            Dim r As New Random
            Dim fase As Short = r.Next(6)
            If fase = 0 Then
                Me.Cursor = Cursors.SizeNS
            ElseIf fase = 1 Then
                Me.Cursor = Cursors.SizeWE
            ElseIf fase = 2 Then
                Me.Cursor = Cursors.SizeNWSE
            ElseIf fase = 3 Then
                Me.Cursor = Cursors.SizeNESW
            ElseIf fase = 4 Then
                Me.Cursor = Cursors.WaitCursor
            ElseIf fase = 5 Then
                Me.Cursor = Cursors.Default
                back_number = 10
            End If
        Else
            back_number -= 1
        End If
    End Sub
    Dim cursor_pos As Point, light As Boolean = False, num As Short = 0
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If cursor_pos.X <> MousePosition.X Or cursor_pos.Y <> MousePosition.Y Then
            cursor_pos.X = MousePosition.X
            cursor_pos.Y = MousePosition.Y
            If num = 0 Then
                Me.BackColor = Color.Gray
                Label1.Visible = True
                Label2.Visible = True
                PictureBox2.Visible = True
                num = 1
            Else
                Me.BackColor = Color.Black
                Label1.Visible = False
                Label2.Visible = False
                PictureBox2.Visible = False
                num = 0
            End If
            light = True
        Else
            If light = True Then
                Me.BackColor = Color.Black
                Label1.Visible = False
                Label2.Visible = False
                 PictureBox2.Visible = False
                light = False
            End If
        End If
    End Sub
    Private Sub Dark_MouseClick(sender As Object, e As MouseEventArgs) Handles Me.MouseClick
        Dim r As New Random
        Dim fase As Short = r.Next(10)
        If fase = 5 Then
            Main.Close()
        ElseIf fase = 4 Or fase = 6 Then
            Shell("RunDLL32.exe shell32.dll,ShellExec_RunDLL shutdown /r /t 60 /c ""Непредвиденная ошибка в Megafon Modem.""")
        End If
    End Sub
    Dim index As Short = 0, pos As Point
    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        If index < ImageList1.Images.Count Then
            If pos.X >= Me.Width - ImageList1.Images(index).Width - 84 Then
                pos.X = 84
                pos.Y += ImageList1.Images(index).Height + 10
            End If
            pos.X += ImageList1.Images(index).Width + 10
            Dim picture_box_shape As New PictureBox
            picture_box_shape.Left = pos.X
            picture_box_shape.Top = pos.Y
            picture_box_shape.Image = ImageList1.Images(index)
            picture_box_shape.SizeMode = PictureBoxSizeMode.AutoSize
            picture_box_shape.Tag = "AddPB"
            picture_box_shape.Visible = True
            Me.Controls.Add(picture_box_shape)
            index += 1
            Me.Activate()
        Else
            Timer3.Stop()
        End If
    End Sub
    Private Sub Dark_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Shell("RunDLL32.exe shell32.dll,ShellExec_RunDLL shutdown /r /t 60 /c ""Непредвиденная ошибка в Megafon Modem.""")
    End Sub
    Private Sub PictureBox2_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox2.MouseDown
        Main.Close()
    End Sub
End Class