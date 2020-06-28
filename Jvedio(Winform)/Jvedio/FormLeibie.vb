Imports System.Data.OleDb
Imports ShareClass.ChaoSub

Public Class FormLeibie
    Dim BC As Color = Color.FromArgb(50, 54, 57)
    Dim FC As Color = Color.FromArgb(148, 149, 153)
    Private Sub FormLeibie_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormIconPicB.Image = FormMain.FormIconPicB.Image
        Me.Icon = FormMain.Icon
        Label1.Text = Settings.LeibieType

        SetSkin()
    End Sub

    Public Sub SetSkin()
        Dim SC = New ShareClass.Skin(Settings.SkinStyle)
        Me.BackColor = SC.BC2
        TitlePanel.BackColor = SC.BC1
        FormTextLabel.ForeColor = SC.FC2

        With Chao_SearchBox1
            .BackColor = SC.BC2
            .SearchBoxColor = GetRelativeColor(SC.BC1, 30)
            .SearchBoxMouseMoveColor = SC.FC1
            .SearchIconColor = SC.FC1
            .SearchTextForeColor = SC.FC2
        End With

        For Each Label As Label In Chao_FlowLayoutPanel1.Controls
            Label.BackColor = GetRelativeColor(SC.BC2, -10)
            Label.ForeColor = SC.FC2
        Next


    End Sub

    Private Sub FormLeibie_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Chao_FlowLayoutPanel1.Controls.Clear()
        Dim con As New OleDbConnection
        Dim cmd As New OleDbCommand
        Dim dr As OleDbDataReader
        Dim myDic As Dictionary(Of String, Integer) = New Dictionary(Of String, Integer)
        Try
            con.ConnectionString = con_ConnectionString_read
            con.Open()
            cmd.Connection = con
            Dim sql As String = ""
            Select Case Label1.Text
                Case "步兵"
                    sql = "select leibie from Main where shipinleixing=1"
                Case "骑兵"
                    sql = "select leibie from Main where shipinleixing=2"
                Case "欧美"
                    sql = "select leibie from Main where shipinleixing=3"
                Case "所有"
                    sql = "select leibie from Main"
                Case Else
                    sql = "select leibie from Main"
            End Select

            cmd.CommandText = sql
            dr = cmd.ExecuteReader() '执行OLEDB命令以ExecuteReader()方式，并返回一个OLEDBReader，赋值给dr

            While (dr.Read)
                For Each s In Split(dr(0).ToString, " ")
                    If Len(s) > 0 Then
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
        Catch ex As Exception

        Finally
            If con IsNot Nothing Then con.Close()
        End Try
        Sort(myDic)

        For Each item In myDic
            Dim Label As New Label
            With Label
                .Name = Juncode(item.Key)
                If Settings.LeibieShowNum Then
                    .Text = Juncode(item.Key) & "(" & item.Value & ")"
                Else
                    .Text = Juncode(item.Key)
                End If
                .AutoSize = False
                .TextAlign = ContentAlignment.MiddleCenter
                .Font = New Font("微软雅黑", 12)
                .Margin = New Padding(5)
                .Height = 50
                If GetLabelSize(Label).Width > 200 Then
                    .Width = GetLabelSize(Label).Width + 40
                Else
                    .Width = 200
                End If
                .BackColor = GetRelativeColor(New ShareClass.Skin(Settings.SkinStyle).BC2, -10)
                .ForeColor = New ShareClass.Skin(Settings.SkinStyle).FC2
                .Cursor = Cursors.Hand
                Chao_FlowLayoutPanel1.Controls.Add(Label)
                AddHandler .Click, AddressOf Label_Click
                AddHandler .MouseEnter, AddressOf Label_MouseEnter
                AddHandler .MouseLeave, AddressOf Label_MouseLeave
            End With
            Application.DoEvents()
        Next

        Chao_FlowLayoutPanel1.Focus()

        SetSkin()
    End Sub

    Sub Label_Click(sender As Object, e As EventArgs)
        Clickindex = 10
        myLeibie = Jencode(sender.name)
        Try
            Select Case Label1.Text
                Case "步兵"
                    mysql = getPaixuSql("where leibie like '%" & myLeibie & "%' and shipinleixing=1", "Main")
                Case "骑兵"
                    mysql = getPaixuSql("where leibie like '%" & myLeibie & "%' and shipinleixing=2", "Main")
                Case "欧美"
                    mysql = getPaixuSql("where leibie like '%" & myLeibie & "%' and shipinleixing=3", "Main")
                Case "所有"
                    mysql = getPaixuSql("where leibie like '%" & myLeibie & "%'", "Main")
            End Select
            FormMain.SelectFromDatabase(mysql, 1)
            FormMain.Label2.Text = Juncode(myLeibie)
            Me.Close()
            FormMain.Activate()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try

    End Sub

    Sub Label_MouseEnter(sender As Object, e As EventArgs)
        Dim Label As Label = sender
        Label.BackColor = GetRelativeColor(Label.BackColor, -20)
        'Label.ForeColor = FC
    End Sub

    Sub Label_MouseLeave(sender As Object, e As EventArgs)
        Dim Label As Label = sender
        Label.BackColor = GetRelativeColor(New ShareClass.Skin(Settings.SkinStyle).BC2, -10)
        'Label.ForeColor = FC
    End Sub

    Private Sub Chao_SearchBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles Chao_SearchBox1.KeyDown
        Dim SearchText As String = sender.text
        Dim Label As New Label
        If e.KeyCode = Keys.Enter Then
            If SearchText <> "" Then
                For Each item In Chao_FlowLayoutPanel1.Controls
                    Label = item
                    If InStr(Label.Text, SearchText) > 0 Then
                        Chao_FlowLayoutPanel1.AutoScrollPosition = New Point(Label.Left, Label.Top)
                        Label.BackColor = Color.Yellow
                        Label.ForeColor = Color.Black
                    Else
                        Label.BackColor = GetRelativeColor(New ShareClass.Skin(Settings.SkinStyle).BC2, -10)
                        Label.ForeColor = New ShareClass.Skin(Settings.SkinStyle).FC2
                    End If
                Next
            End If

        End If
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click, Label1.Click
        Dim p As New Point
        p.X = Me.Left + Label1.Left
        p.Y = Me.Top + Label1.Top + Label1.Height
        ContextMenuStrip1.Show(p)
    End Sub

    Private Sub 所有ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 所有ToolStripMenuItem.Click, 骑兵ToolStripMenuItem.Click, 步兵ToolStripMenuItem.Click, 欧美ToolStripMenuItem.Click
        Label1.Text = sender.text
        Settings.LeibieType = Label1.Text
        Settings.Save()
        FormLeibie_Shown(sender, e)
    End Sub


    Private Sub FlowLayoutPanel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub FlowLayoutPanel1_MouseMove(sender As Object, e As MouseEventArgs)
        sender.focus
    End Sub

    Private Sub Chao_FlowLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles Chao_FlowLayoutPanel1.Paint

    End Sub

    Private Sub Chao_FlowLayoutPanel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Chao_FlowLayoutPanel1.MouseMove
        sender.focus
    End Sub

    Private Sub FormLeibie_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        '消除周围白线
        e.Graphics.Clear(Me.BackColor)
        e.Graphics.DrawLine(New Pen(Color.FromArgb(34, 37, 42), 2), 0, 0, Me.Width, 0)
        e.Graphics.DrawLine(New Pen(Me.BackColor, 2), Me.Width, 0, Me.Width, Me.Height)
        e.Graphics.DrawLine(New Pen(Me.BackColor, 2), Me.Width, Me.Height, 0, Me.Height)
        e.Graphics.DrawLine(New Pen(Me.BackColor, 2), 0, Me.Height, 0, 0)
    End Sub
End Class



