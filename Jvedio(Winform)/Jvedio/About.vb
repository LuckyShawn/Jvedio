Public Class About


    Declare Auto Function ReleaseCapture Lib "user32.dll" Alias "ReleaseCapture" () As Boolean
    'API ReleaseCapture函数是用来释放鼠标捕获的
    Declare Auto Function SendMessage Lib "user32.dll" Alias "SendMessage" (ByVal hWnd As IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As IntPtr
    '向windows发送消息
    Public Const WM_SYSCOMMAND As Integer = &H112&
    Public Const SC_MOVE As Integer = &HF010&
    Public Const HTCAPTION As Integer = &H2&
    Private Sub About_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.BackgroundImage = My.Resources.Resource1.bg
        Me.BackgroundImageLayout = ImageLayout.Stretch
        With PictureBox1
            .Location = New Point(0, 0)
            .Height = Me.Height
            .Width = Me.Width
            .BackColor = Color.FromArgb(100, 0, 0, 0)
        End With
        For i = Me.Controls.Count - 1 To 0 Step -1
            If Me.Controls.Item(i).GetType.ToString = "System.Windows.Forms.Label" Then
                Dim mylabel As Label
                mylabel = Me.Controls.Item(i)
                mylabel.Parent = PictureBox1
                mylabel.BackColor = Color.Transparent
            End If
        Next
        PictureBox2.Parent = PictureBox1
        PictureBox2.BackColor = Color.Transparent
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub PictureBox1_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseMove
        If e.Button = MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Me.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0)
        End If
    End Sub

    Private Sub About_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd

    End Sub

    Private Sub About_LostFocus(sender As Object, e As EventArgs) Handles Me.LostFocus
        Me.Close()
    End Sub


    Private Sub Label1_Click(sender As Object, e As EventArgs)
        Try
            Process.Start(sender.Text)
        Catch ex As Exception

        End Try
    End Sub
End Class