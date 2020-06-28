Imports System.Text.RegularExpressions
Public Class FormUpdate
    Delegate Sub DelegateSetEnable(ByVal En As Boolean)
    Delegate Sub DelegateSetText(ByVal t As String)
    Delegate Sub DelegateSetStatus(ByVal S As String)

    Sub SetStatus(ByVal S As String)
        Chao_StatusIndicator1.Status = S
        If S = "Success" Then
            If Split(Label4.Text, ".")(0) > Split(Label3.Text, ".")(0) And Split(Label4.Text, ".")(1) > Split(Label3.Text, ".")(1) Then
                Label4.ForeColor = Color.Green
                Chao_Button1.Enabled = True
            Else
                Label4.ForeColor = Color.Black
                'Chao_Button1.Enabled = False
            End If
        End If
    End Sub

    Sub SetText(ByVal t As String)
        Label4.Text = t
    End Sub

    Sub SetEnable(ByVal En As Boolean)
        Chao_Button2.Enabled = En
    End Sub
    Private Sub FormUpdate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Chao_StatusIndicator1.Status = "Running"
    End Sub

    Private Sub FormUpdate_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Dim version = Application.ProductVersion
        Label3.Text = Split(version, ".")(0) & "." & Split(version, ".")(1)
        CheckUpdateThread()
    End Sub

    Sub CheckUpdateThread()
        Dim T As Threading.Thread = New System.Threading.Thread(AddressOf CheckUpdate)
        T.Start()
    End Sub

    Private Async Sub CheckUpdate()
        Me.Invoke(New DelegateSetEnable(AddressOf SetEnable), False)

        Dim url As String = "http://www.hitchao.cn/Jvedio_Update/"
        Dim SourceCode As String = Await ShareClass.Net.HttpGet(url)

        If SourceCode <> "" Then
            Dim mc As MatchCollection
            mc = Regex.Matches(SourceCode, "<title>([\s\S]*)</title>")
            If mc.Count > 0 Then
                mc = Regex.Matches(mc(0).ToString, "\d([\s\S]+)(hitchao)")
                Dim title = Split(mc(0).ToString, "|")(0)
                Dim version As String = "0.0"
                If InStr(title, ".") > 0 Then
                    version = Replace(title, " ", "")
                Else
                    version = Int(title) & ".0"
                End If
                Console.WriteLine(version)
                Me.Invoke(New DelegateSetText(AddressOf SetText), version)
            End If
            Me.Invoke(New DelegateSetStatus(AddressOf SetStatus), "Success")

        Else
            '失败
            Me.Invoke(New DelegateSetStatus(AddressOf SetStatus), "Failed")
        End If
        Me.Invoke(New DelegateSetEnable(AddressOf SetEnable), True)
    End Sub

    Private Sub Chao_Button2_Click(sender As Object, e As EventArgs) Handles Chao_Button2.Click
        Chao_StatusIndicator1.Status = "Running"
        CheckUpdateThread()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs)

    End Sub

    Private Sub Chao_Button1_Click(sender As Object, e As EventArgs) Handles Chao_Button1.Click
        Try
            Process.Start("http://www.hitchao.cn/Jvedio/")
        Catch ex As Exception
            MsgBox("被杀毒软件拦截")
        End Try
    End Sub

    Private Sub FormUpdate_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        '消除周围白线
        e.Graphics.Clear(Me.BackColor)
        e.Graphics.DrawLine(New Pen(Color.FromArgb(34, 37, 42), 2), 0, 0, Me.Width, 0)
        e.Graphics.DrawLine(New Pen(Me.BackColor, 2), Me.Width, 0, Me.Width, Me.Height)
        e.Graphics.DrawLine(New Pen(Me.BackColor, 2), Me.Width, Me.Height, 0, Me.Height)
        e.Graphics.DrawLine(New Pen(Me.BackColor, 2), 0, Me.Height, 0, 0)
    End Sub
End Class