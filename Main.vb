Public Class Main
    '
    ' MouseJiggler Software
    ' by (c) Luca Franziskowski
    '
    Dim r As New Random
    Dim interval As Integer = 5000
    Dim randomPos As Boolean = False
    Dim point1 As Point
    Dim point2 As Point

    'Mouseclick:
    Private Declare Sub mouse_event Lib "user32" (ByVal dwFlags As Integer, ByVal dx As Integer, ByVal dy As Integer, ByVal cButtons As Integer, ByVal dwExtraInfo As Integer)
    Private Const MOUSEEVENTF_ABSOLUTE = &H8000 ' absolute move
    Private Const MOUSEEVENTF_LEFTDOWN = &H2 ' left button down
    Private Const MOUSEEVENTF_LEFTUP = &H4 ' left button up
    Private Const MOUSEEVENTF_MOVE = &H1 ' mouse move
    Private Const MOUSEEVENTF_MIDDLEDOWN = &H20
    Private Const MOUSEEVENTF_MIDDLEUP = &H40
    Private Const MOUSEEVENTF_RIGHTDOWN = &H8
    Private Const MOUSEEVENTF_RIGHTUP = &H10

    Private Sub B_Main_Start_Click(sender As Object, e As EventArgs) Handles B_Main_Start.Click
        interval = N_Main_Interval.Value
        point1 = New Point(N_Main_1.Value, N_Main_1b.Value)
        point2 = New Point(N_Main_2.Value, N_Main_2b.Value)
        If Not Worker.IsBusy Then
            Worker.RunWorkerAsync()
            B_Main_Start.Enabled = False
            B_Main_Stop.Enabled = True
        End If
    End Sub

    Private Sub B_Main_Stop_Click(sender As Object, e As EventArgs) Handles B_Main_Stop.Click
        Worker.CancelAsync()
        B_Main_Start.Enabled = True
        B_Main_Stop.Enabled = False
    End Sub

    Private Sub Worker_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles Worker.DoWork
        Do Until Worker.CancellationPending
            If randomPos Then
                point1 = New Point(r.Next(100, 1000), r.Next(100, 1000))
                point2 = New Point(r.Next(100, 1000), r.Next(100, 1000))
            End If
            If C_Main_MakeClicks.Checked Then
                mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 1)
            End If
            Cursor.Position = point1
            Threading.Thread.Sleep(interval)
            Cursor.Position = point2
            Threading.Thread.Sleep(interval)
        Loop
    End Sub

    Private Sub C_RandomPosition_CheckedChanged(sender As Object, e As EventArgs) Handles C_RandomPosition.CheckedChanged
        N_Main_1.Enabled = C_RandomPosition.Checked = False
        N_Main_1b.Enabled = C_RandomPosition.Checked = False
        N_Main_2.Enabled = C_RandomPosition.Checked = False
        N_Main_2b.Enabled = C_RandomPosition.Checked = False
        randomPos = C_RandomPosition.Checked
    End Sub
End Class
