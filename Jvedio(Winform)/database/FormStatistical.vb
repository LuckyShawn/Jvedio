Imports System.Data.OleDb
Imports ShareClass.ChaoSub
Imports System.Drawing.Drawing2D
Public Class FormStatistical



    Private Sub Label2_MouseMove(sender As Object, e As MouseEventArgs) Handles Label3.MouseMove, Label4.MouseMove, Label5.MouseMove, Label6.MouseMove, Label8.MouseMove
        sender.backcolor = GetRelativeColor(Panel2.BackColor, 20)
    End Sub

    Private Sub Label2_MouseLeave(sender As Object, e As EventArgs) Handles Label3.MouseLeave, Label4.MouseLeave, Label5.MouseLeave, Label6.MouseLeave, Label8.MouseLeave
        sender.backcolor = Color.Transparent
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        '统计番号
        Dim con As New OleDbConnection
        Dim cmd As New OleDbCommand
        Dim dr As OleDbDataReader
        Dim fanhao As New List(Of String)
        Try
            con.ConnectionString = con_ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "Select * from Main"
            dr = cmd.ExecuteReader
            While (dr.Read)
                fanhao.Add(dr.Item("fanhao").ToString)
            End While
            dr.Close()
            con.Close()
        Catch ex As Exception
            WriteLog(ex)
            Exit Sub
        Finally
#Disable Warning
            If dr IsNot Nothing Then dr.Close()
            If con IsNot Nothing Then con.Close()
        End Try


        '番号类型:
        'fanhao1:AAA-001
        'fanhao2:000000_000
        '分离出英文番号
        Dim fanhao1 As New List(Of String)
        Dim fanhao2 As New List(Of String)
        For Each item In fanhao
            If InStr(item, "_") = 0 Then
                If InStr(item, "-") = 0 Then
                    fanhao2.Add(item)
                Else
                    If Not IsNumeric(Split(item, "-")(0)) Then
                        fanhao1.Add(Split(item, "-")(0))
                    Else
                        fanhao2.Add(item)
                    End If
                End If
            Else
                fanhao2.Add(item)
            End If
        Next

        Dim myDic As Dictionary(Of String, Integer) = New Dictionary(Of String, Integer)
        For Each item In fanhao1
            'Debug.Print(item)
            If myDic.ContainsKey(item) Then
                myDic(item) += 1
            Else
                myDic.Add(item, 1)
            End If
        Next
        Sort(myDic)
        DrawInChart(Chart1, "番号", "数目", "番号统计表", myDic)

    End Sub






    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        '统计视频类型
        myDic = GetDic("shipinleixing")
        Dim dic As Dictionary(Of String, Integer) = New Dictionary(Of String, Integer)
        For Each item In myDic
            Select Case item.Key
                Case 0
                    dic.Add("其它", item.Value)
                Case 1
                    dic.Add("步兵", item.Value)
                Case 2
                    dic.Add("骑兵", item.Value)
            End Select
        Next
        DrawInChart(Chart1, "视频类型", "数目", "视频类型统计表", dic)
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        '统计类别
        myDic = GetDic("leibie")
        DrawInChart(Chart1, "类别", "数目", "类别统计表", myDic)
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        '统计系列
        myDic = GetDic("xilie")
        DrawInChart(Chart1, "系列", "数目", "系列统计表", myDic)

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        '统计演员
        myDic = GetDic("yanyuan")
        DrawInChart(Chart1, "演员", "数目", "演员统计表", myDic)
    End Sub



    Private Sub Chao_Sliders1_ValueChanged_1(sender As Object, e As System.ComponentModel.PropertyChangedEventArgs) Handles Chao_Sliders1.ValueChanged
        DisPlayNum = Int(Chao_Sliders1.Value)

        If Chart1.ChartAreas.Count = 0 Then Exit Sub
        Dim title As String = Chart1.ChartAreas(0).AxisX.Title
        Select Case title
            Case "番号"
                Label3_Click(sender, e)
            Case "视频类型"
                Label4_Click(sender, e)
            Case "类别"
                Label5_Click(sender, e)
            Case "系列"
                Label6_Click(sender, e)
            Case "演员"
                Label8_Click(sender, e)
            Case Else

        End Select
    End Sub




    Private Sub 保存为图片ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 保存为图片ToolStripMenuItem.Click
        '保存图片
        If Chart1.ChartAreas.Count = 0 Then Exit Sub

        ExportPicture(Chart1)
    End Sub

    Private Sub Chart1_Click(sender As Object, e As EventArgs) Handles Chart1.Click

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint
        Dim BS As New LinearGradientBrush(Me.ClientRectangle, Color.FromArgb(33, 147, 176), Color.FromArgb(109, 213, 237), LinearGradientMode.Vertical)
        e.Graphics.FillRectangle(BS, Me.ClientRectangle)
    End Sub
End Class
