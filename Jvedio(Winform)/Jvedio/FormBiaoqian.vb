Imports System.ComponentModel
Imports System.Data.OleDb
Imports ShareClass.ChaoSub
Public Class FormBiaoqian
    Declare Auto Function ReleaseCapture Lib "user32.dll" Alias "ReleaseCapture" () As Boolean
    'API ReleaseCapture函数是用来释放鼠标捕获的
    Declare Auto Function SendMessage Lib "user32.dll" Alias "SendMessage" (ByVal hWnd As IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As IntPtr
    '向windows发送消息
    Public Const WM_SYSCOMMAND As Integer = &H112&
    Public Const SC_MOVE As Integer = &HF010&
    Public Const HTCAPTION As Integer = &H2&
    Private Sub FormBiaoqian_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Opacity = 0.9
        Me.BackColor = Color.FromArgb(1, 1, 1)
        Me.TransparencyKey = Color.FromArgb(1, 1, 1)
        Me.Top = FormMain.Top + FormMain.Label11.Top + 64 - 420
        Me.Left = FormMain.Left + 110

        For Each item In Chao_FlowLayoutPanel1.Controls
            item.backcolor = GetRelativeColor(Me.BackColor, 20)
        Next


    End Sub

    Private Sub FormBiaoqian_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Chao_FlowLayoutPanel1.Controls.Clear()
        Dim con As New OleDbConnection
        Dim cmd As New OleDbCommand
        Dim dr As OleDbDataReader
        Dim myDic As Dictionary(Of String, Integer) = New Dictionary(Of String, Integer)
        'Try
        con.ConnectionString = con_ConnectionString_read
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "select biaoqian from Main"
        dr = cmd.ExecuteReader() '执行OLEDB命令以ExecuteReader()方式，并返回一个OLEDBReader，赋值给dr

        While (dr.Read)
                For Each s In Split(dr(0).ToString, " ")
                    If Len(s) > 0 And InStr(s, " ") <= 0 Then
                        If myDic.ContainsKey(s) Then
                            myDic(s) += 1
                        Else
                            myDic.Add(s, 1)
                        End If
                    End If
                Next
            End While
            dr.Close()
            con.Close()

            Sort(myDic)

        For Each item In myDic
            Dim Label As New Label
            With Label
                .Name = Juncode(item.Key)
                .Text = Juncode(item.Key) & "(" & item.Value & ")"
                .AutoSize = False
                .TextAlign = ContentAlignment.MiddleCenter
                .Font = New Font("微软雅黑", 12)
                .Margin = New Padding(5)
                .Height = 50
                If GetLabelSize(Label).Width > 100 Then
                    .Width = GetLabelSize(Label).Width + 20
                Else
                    .Width = 100
                End If
                .BackColor = GetRelativeColor(Me.BackColor, 20)
                .ForeColor = Color.White
                .Cursor = Cursors.Hand
                Chao_FlowLayoutPanel1.Controls.Add(Label)
                AddHandler .Click, AddressOf Label_Click
                AddHandler .MouseEnter, AddressOf Label_MouseEnter
                AddHandler .MouseLeave, AddressOf Label_MouseLeave
            End With
            Application.DoEvents()
        Next

        Chao_FlowLayoutPanel1.Focus()

    End Sub

    Sub Label_Click(sender As Object, e As EventArgs)
        '点击标签
        Clickindex = 12
        myBiaoqian = Jencode(sender.name)
        mysql = getPaixuSql("where biaoqian like '%" & myBiaoqian & "%'", "Main")
        FormMain.SelectFromDatabase(mysql, 1)
        FormMain.Label2.Text = Juncode(myBiaoqian)
        Me.Close()
        FormMain.Activate()
    End Sub

    Sub Label_MouseEnter(sender As Object, e As EventArgs)
        Dim Label As Label = sender
        Label.BackColor = GetRelativeColor(Me.BackColor, 40)
    End Sub

    Sub Label_MouseLeave(sender As Object, e As EventArgs)
        Dim Label As Label = sender
        Label.BackColor = GetRelativeColor(Me.BackColor, 20)
    End Sub

    Private Sub FormBiaoqian_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        If e.Button = MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Me.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0)
        End If
    End Sub

    Private Sub FormBiaoqian_LostFocus(sender As Object, e As EventArgs) Handles Me.LostFocus

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub





    Private Sub FlowLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles Chao_FlowLayoutPanel1.Paint

    End Sub

    Private Sub FlowLayoutPanel1_LostFocus(sender As Object, e As EventArgs) Handles Chao_FlowLayoutPanel1.LostFocus
        Me.Close()

    End Sub

End Class