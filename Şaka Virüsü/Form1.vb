Public Class Form1
    Dim MarazAli As New Random
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If DesktopLocation = New Point(MarazAli.Next(1, 1000), MarazAli.Next(1, 500)) Then
            DesktopLocation = New Point(MarazAli.Next(1, 1000), MarazAli.Next(1, 500))

        Else DesktopLocation = New Point(MarazAli.Next(1, 1000), MarazAli.Next(1, 500))

            MessageBox.Show("Kapat Lan O Bilgisayarı :D", "Maraz Ali", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            SendKeys.Send("HACKED")

            'THT MR DEATH WİNG
            'https://www.turkhackteam.org/members/896810.html

        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()


    End Sub
End Class

'THT MR DEATH WİNG
'https://www.turkhackteam.org/members/896810.html