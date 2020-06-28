Imports System.ComponentModel
Imports System.Data.OleDb
Imports ShareClass.ChaoSub
Public Class FormYanyuan
    Dim BC As Color = Color.FromArgb(50, 54, 57)
    Dim FC As Color = Color.FromArgb(148, 149, 153)
    Public ActorDic As Dictionary(Of String, Integer)
    Public MaxNum As Integer = 30
    Private Sub FormLeibie_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormIconPicB.Image = FormMain.FormIconPicB.Image
        Me.Icon = FormMain.Icon
        Label1.Text = Settings.YanyuanType
        SetSkin()
    End Sub
    Public Sub SetSkin()
        Dim SC = New ShareClass.Skin(Settings.SkinStyle)
        Me.BackColor = SC.BC2
        TitlePanel.BackColor = SC.BC1
        FormTextLabel.ForeColor = SC.FC2
        Chao_Button2.ButtonBackColor = SC.BC2
        Chao_Button2.TextColor = SC.FC2
        Chao_Button2.ButtonColor = SC.BC2
        Label1.ForeColor = SC.FC2
        Label2.ForeColor = SC.FC2

        Chao_TextBox1.TextBackColor = SC.BC2
        Chao_TextBox1.TextForeColor = SC.FC2

        With Chao_SearchBox1
            .BackColor = SC.BC2
            .SearchBoxColor = GetRelativeColor(SC.BC1, 30)
            .SearchBoxMouseMoveColor = SC.FC1
            .SearchIconColor = SC.FC1
            .SearchTextForeColor = SC.FC2
        End With

        For Each Panel As Panel In Chao_FlowLayoutPanel1.Controls
            Panel.BackColor = GetRelativeColor(SC.BC2, -10)
            For Each item In Panel.Controls
                If item.GetType.ToString = "System.Windows.Forms.Label" Then
                    Dim Label As Label = item
                    Label.BackColor = GetRelativeColor(New ShareClass.Skin(Settings.SkinStyle).BC2, 15)
                    Label.ForeColor = New ShareClass.Skin(Settings.SkinStyle).FC2
                End If
            Next
        Next


    End Sub


    Private Sub FormYanyuan_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Chao_FlowLayoutPanel1.Controls.Clear()
        Dim con As New OleDbConnection
        Dim cmd As New OleDbCommand
        Dim dr As OleDbDataReader
        ActorDic = New Dictionary(Of String, Integer)
        Try
            con.ConnectionString = con_ConnectionString_read
            con.Open()
            cmd.Connection = con
            Dim sql As String = ""
            Select Case Label1.Text
                Case "步兵"
                    sql = "select yanyuan from Main where shipinleixing=1"
                Case "骑兵"
                    sql = "select yanyuan from Main where shipinleixing=2"
                Case "欧美"
                    sql = "select yanyuan from Main where shipinleixing=3"
                Case "所有"
                    sql = "select yanyuan from Main"
                Case Else
                    sql = "select yanyuan from Main"
            End Select

            cmd.CommandText = sql
            dr = cmd.ExecuteReader() '执行OLEDB命令以ExecuteReader()方式，并返回一个OLEDBReader，赋值给dr


            While (dr.Read)
                For Each s In Split(dr(0).ToString, " ")
                    If Len(s) > 0 Then
                        If ActorDic.ContainsKey(s) Then
                            ActorDic(s) += 1
                        Else
                            ActorDic.Add(s, 1)
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
        Sort(ActorDic)
        LoadYanyuanFromDic(1)
    End Sub


    Sub LoadYanyuanFromDic(PageNum As Integer, Optional SearchList As Dictionary(Of String, Integer) = Nothing)
        Chao_FlowLayoutPanel1.Controls.Clear()

        Dim num As Integer = 1
        Dim LoadDic As New Dictionary(Of String, Integer)
        If SearchList IsNot Nothing Then
            LoadDic = SearchList
            Chao_TextBox1.Text = "0"
            Label2.Text = "/0 页"
            Chao_Button1.Enabled = False
            Chao_Button3.Enabled = False
        Else
            LoadDic = ActorDic
            Chao_TextBox1.Text = PageNum
            Label2.Text = "/" & Math.Ceiling(LoadDic.Count / MaxNum) & " 页"
            Chao_Button1.Enabled = True
            Chao_Button3.Enabled = True
        End If


        For Each item In LoadDic

            If num = PageNum * MaxNum + 1 Then Exit For
            If num >= (PageNum - 1) * MaxNum + 1 And num <= LoadDic.Count Then
                Dim PicB As New PictureBox
                With PicB
                    .Size = New Size(200, 125)
                    .SizeMode = PictureBoxSizeMode.CenterImage
                    .Location = New Point(10, 10)
                    Dim PicPath As String = Application.StartupPath & "\Pic\Actresses\" & Juncode(item.Key) & ".jpg"
                    If IO.File.Exists(PicPath) Then
                        If My.Computer.FileSystem.GetFileInfo(PicPath).Length > 0 Then '如果图片错误会显示内存不足
                            If Not IsFileInUse(PicPath) Then
                                Try
                                    Dim FS As New IO.FileStream(PicPath, IO.FileMode.Open, IO.FileAccess.Read)
                                    .Image = Image.FromStream(FS)
                                    FS.Close()
                                    FS.Dispose()
                                Catch ex As Exception

                                End Try
                            End If
                        End If
                        Else
                        .Image = My.Resources.Resource_FormInfo.ActressesNotFound
                    End If


                End With


                Dim Label As New Label
                With Label
                    .Name = Juncode(item.Key)
                    .Left = 0
                    .Top = PicB.Top + PicB.Height + 10
                    .AutoSize = False
                    .Font = New Font("微软雅黑", 12)
                    .Height = 50
                    If Settings.YanyuanShowNum Then
                        .Text = Juncode(item.Key) & "(" & item.Value & ")"
                    Else
                        .Text = Juncode(item.Key)
                    End If

                    If GetLabelSize(Label).Width > 200 Then
                        .Width = GetLabelSize(Label).Width + 20
                        PicB.Width = .Width
                    Else
                        .Width = 200
                    End If

                    .TextAlign = ContentAlignment.MiddleCenter

                    .BackColor = GetRelativeColor(New ShareClass.Skin(Settings.SkinStyle).BC2, 15)
                    .ForeColor = New ShareClass.Skin(Settings.SkinStyle).FC2
                    .Cursor = Cursors.Hand

                    AddHandler .Click, AddressOf Label_Click
                    AddHandler .MouseEnter, AddressOf Label_MouseEnter
                    AddHandler .MouseLeave, AddressOf Label_MouseLeave
                End With

                Dim Panel As New Panel
                With Panel
                    .Height = 200
                    .Width = Label.Width
                    .BackColor = GetRelativeColor(New ShareClass.Skin(Settings.SkinStyle).BC2, -10)
                    .Margin = New Padding(5)
                    .Controls.Add(PicB)
                    .Controls.Add(Label)
                End With
                PicB.Width = Panel.Width - 20
                Chao_FlowLayoutPanel1.Controls.Add(Panel)
                Application.DoEvents()

            End If
            num += 1
        Next
        Chao_FlowLayoutPanel1.Focus()
        SetSkin()
    End Sub

    Sub Label_Click(sender As Object, e As EventArgs)
        Clickindex = 10
        myYanyuan = Jencode(sender.name)
        Try
            Select Case Label1.Text
                Case "步兵"
                    mysql = getPaixuSql("where yanyuan like '%" & myYanyuan & "%' and shipinleixing=1", "Main")
                Case "骑兵"
                    mysql = getPaixuSql("where yanyuan like '%" & myYanyuan & "%' and shipinleixing=2", "Main")
                Case "欧美"
                    mysql = getPaixuSql("where yanyuan like '%" & myYanyuan & "%' and shipinleixing=3", "Main")
                Case "所有"
                    mysql = getPaixuSql("where yanyuan like '%" & myYanyuan & "%'", "Main")
            End Select
            FormMain.SelectFromDatabase(mysql, 1)
            FormMain.Label2.Text = Juncode(myYanyuan)
            Me.Close()
            FormMain.Activate()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try

    End Sub

    Sub Label_MouseEnter(sender As Object, e As EventArgs)
        Dim Label As Label = sender
        Label.BackColor = GetRelativeColor(Label.BackColor, -20)
        Label.ForeColor = New ShareClass.Skin(Settings.SkinStyle).FC2
    End Sub

    Sub Label_MouseLeave(sender As Object, e As EventArgs)
        Dim Label As Label = sender
        Label.BackColor = GetRelativeColor(New ShareClass.Skin(Settings.SkinStyle).BC2, 15)
        Label.ForeColor = New ShareClass.Skin(Settings.SkinStyle).FC2
    End Sub

    Private Sub Chao_SearchBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles Chao_SearchBox1.KeyDown
        Dim SearchText As String = sender.text
        Dim Panel As New Panel
        Dim Label As New Label
        Dim SearchDic As New Dictionary(Of String, Integer)
        If e.KeyCode = Keys.Enter Then
            If SearchText <> "" Then
                For Each item In ActorDic
                    If InStr(Juncode(item.Key), SearchText) > 0 Then
                        If SearchDic.ContainsKey(item.Key) Then
                            SearchDic(item.Key) += 1
                        Else
                            SearchDic.Add(item.Key, 1)
                        End If
                    End If

                Next
            End If
            LoadYanyuanFromDic(1, SearchDic)
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
        Settings.YanyuanType = Label1.Text
        Settings.Save()
        FormYanyuan_Shown(sender, e)
    End Sub



    Private Sub FlowLayoutPanel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub FlowLayoutPanel1_MouseMove(sender As Object, e As MouseEventArgs)
        sender.focus
    End Sub

    Private Sub Chao_Button3_Click(sender As Object, e As EventArgs) Handles Chao_Button3.Click
        Dim Page = Chao_TextBox1.Text
        If Not IsNumeric(Page) Then
            Debug.Print("页数错误")
            Exit Sub
        Else
            If Page <= 0 Then
                Debug.Print("页数错误")
                Exit Sub
            ElseIf Page >= Math.Ceiling(ActorDic.count / MaxNum) Then
                Page = 1
            Else
                Page += 1
            End If
        End If
        LoadYanyuanFromDic(Page)
        Chao_TextBox1.Text = Page
    End Sub

    Private Sub Chao_Button1_Click(sender As Object, e As EventArgs) Handles Chao_Button1.Click
        Dim Page = Chao_TextBox1.Text
        If Not IsNumeric(Page) Then
            'MsgBox("页数错误")
            Exit Sub
        Else
            If Page > Math.Ceiling(ActorDic.Count / MaxNum) Then
                'MsgBox("页数错误")
                Exit Sub
            ElseIf Page <= 1 Then
                Page = Math.Ceiling(ActorDic.Count / MaxNum)
            Else
                Page += -1
            End If
        End If
        LoadYanyuanFromDic(Page)
        Chao_TextBox1.Text = Page
    End Sub

    Private Sub Chao_Button2_Click(sender As Object, e As EventArgs) Handles Chao_Button2.Click
        FormYanyuan_Shown(sender, e)
    End Sub

    Private Sub Chao_TextBox1_TextChanged(sender As Object, e As PropertyChangedEventArgs) Handles Chao_TextBox1.TextChanged

    End Sub

    Private Sub Chao_TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles Chao_TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim Page = sender.Text
            If Not IsNumeric(Page) Then
                Page = 1
            Else
                If Page <= 0 Then
                    Page = 1
                ElseIf Page > Math.Ceiling(ActorDic.Count / MaxNum) Then
                    Page = 1
                End If
            End If
            LoadYanyuanFromDic(Page)
        End If
    End Sub

    Private Sub Chao_FlowLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles Chao_FlowLayoutPanel1.Paint

    End Sub

    Private Sub Chao_FlowLayoutPanel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Chao_FlowLayoutPanel1.MouseMove
        sender.focus
    End Sub

    Private Sub FormYanyuan_PaddingChanged(sender As Object, e As EventArgs) Handles Me.PaddingChanged

    End Sub

    Private Sub FormYanyuan_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        '消除周围白线
        e.Graphics.Clear(Me.BackColor)
        e.Graphics.DrawLine(New Pen(Color.FromArgb(34, 37, 42), 2), 0, 0, Me.Width, 0)
        e.Graphics.DrawLine(New Pen(Me.BackColor, 2), Me.Width, 0, Me.Width, Me.Height)
        e.Graphics.DrawLine(New Pen(Me.BackColor, 2), Me.Width, Me.Height, 0, Me.Height)
        e.Graphics.DrawLine(New Pen(Me.BackColor, 2), 0, Me.Height, 0, 0)
    End Sub
End Class