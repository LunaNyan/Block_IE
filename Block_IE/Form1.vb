Public Class Form1
    Dim count As Integer

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        For Each prog As Process In Process.GetProcesses
            If prog.ProcessName = "iexplore" Then
                prog.Kill()
                count = count + 1
            End If
            If prog.ProcessName = "pmbpush" Then
                prog.Kill()
                count = count + 1
            End If
        Next
    End Sub

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim confirm As Integer = MsgBox("종료하시겠습니까?" & vbCrLf & count & "번의 IE 실행 시도가 있었습니다.", vbYesNo, "확인")
        If confirm = vbYes Then
            End
        Else
            e.Cancel = True
        End If
    End Sub
End Class