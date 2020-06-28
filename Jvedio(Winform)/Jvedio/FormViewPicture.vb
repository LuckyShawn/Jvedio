Imports ShareClass.ChaoSub
Public Class FormViewPicture

    Public PictureList As New List(Of String)
    Public PicIndex As Integer
    Public Fanhao As String

    Declare Auto Function ReleaseCapture Lib "user32.dll" Alias "ReleaseCapture" () As Boolean
    'API ReleaseCapture函数是用来释放鼠标捕获的
    Declare Auto Function SendMessage Lib "user32.dll" Alias "SendMessage" (ByVal hWnd As IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As IntPtr
    '向windows发送消息
    Public Const WM_SYSCOMMAND As Integer = &H112&
    Public Const SC_MOVE As Integer = &HF010&
    Public Const HTCAPTION As Integer = &H2&
    Private Sub FormViewPicture_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Settings.ShowDefaultInfo Then
            For Each item In FormInfo.Chao_Panel1.Controls
                If Not PictureList.Contains(item.name) Then
                    PictureList.Add(item.name)
                End If
            Next

        Else
            For Each item In FormBus.FlowLayoutPanel4.Controls
                If Not PictureList.Contains(item.name) Then
                    PictureList.Add(item.name)
                End If
            Next
        End If

        For i = 0 To PictureList.Count - 1 Step 1
            If PictureList.Item(i) = PictureBox1.Name Then
                PicIndex = i
                Exit For
            End If
        Next


        Fanhao = GlobalFanhao

        Label3.BackColor = Color.FromArgb(150, 50, 50, 50)
        Label4.BackColor = Color.FromArgb(150, 50, 50, 50)

    End Sub

    Private Sub FormViewPicture_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove, PictureBox1.MouseMove
        If e.Button = MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Me.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0)
        End If
    End Sub

    Private Sub FormViewPicture_LostFocus(sender As Object, e As EventArgs) Handles Me.LostFocus
        Me.Close()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

        RightPic()

    End Sub

    Sub RightPic()

        If PicIndex < PictureList.Count - 1 Then
            PicIndex += 1
        Else
            PicIndex = 0
        End If

        Dim PicPath As String = Application.StartupPath & "\Pic\Extra\" & Fanhao & "\" & PictureList.Item(PicIndex)
        If IO.File.Exists(PicPath) Then
            If Not IsFileInUse(PicPath) Then


                Dim FS As New IO.FileStream(PicPath, IO.FileMode.Open, IO.FileAccess.Read)
                Try
                    PictureBox1.Image = Image.FromStream(FS)
                    FS.Close()
                    FS.Dispose()
                Catch ex As Exception

                Finally
                    FS.Close()
                    FS.Dispose()
                End Try
            End If
        End If
    End Sub

    Sub LeftPic()
        If PicIndex > 0 Then
            PicIndex -= 1
        Else
            PicIndex = PictureList.Count - 1
        End If

        Dim PicPath As String = Application.StartupPath & "\Pic\Extra\" & Fanhao & "\" & PictureList.Item(PicIndex)
        If IO.File.Exists(PicPath) Then
            If Not IsFileInUse(PicPath) Then


                Dim FS As New IO.FileStream(PicPath, IO.FileMode.Open, IO.FileAccess.Read)
                Try
                    PictureBox1.Image = Image.FromStream(FS)
                    FS.Close()
                    FS.Dispose()
                Catch ex As Exception

                Finally
                    FS.Close()
                    FS.Dispose()
                End Try
            End If
        End If
    End Sub



    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        LeftPic()
    End Sub

    Private Sub Label4_MouseMove(sender As Object, e As MouseEventArgs) Handles Label4.MouseMove, Label3.MouseMove
        Dim Label As Label = sender
        Label.BackColor = GetRelativeColor(Label.BackColor, -20, 255)
    End Sub

    Private Sub Label4_MouseLeave(sender As Object, e As EventArgs) Handles Label4.MouseLeave, Label3.MouseLeave
        Dim Label As Label = sender
        Label.BackColor = Color.FromArgb(150, 50, 50, 50)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub PictureBox1_MouseWheel(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseWheel, Me.MouseWheel
        If e.Delta > 0 Then
            If Label3.Visible Then LeftPic()
        Else
            If Label4.Visible Then RightPic()
        End If
    End Sub

    Private Sub PictureBox1_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseDown
        If e.Button = MouseButtons.Right Then
            Me.Close()
        End If
    End Sub
End Class