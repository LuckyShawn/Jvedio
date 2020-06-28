Imports System.Text.RegularExpressions
Imports System.Data.OleDb
Imports System.Windows.Forms.DataVisualization.Charting
Imports ShareClass.ChaoSub

Module Module_Function

    Public Sub DrawInChart(MyChart As Chart, XTitle As String, YTitle As String, Title As String, ByVal dic As Dictionary(Of String, Integer))
        '绘制柱形图
        MyChart.ChartAreas.Clear()
        Dim ChartAreas1 As New ChartArea(Title) With {.BackColor = Color.White}

        MyChart.ChartAreas.Add(ChartAreas1)                 '将新定义的ChartArea加入Chart1
        MyChart.Series.Clear()
        Dim series1 As New Series(Title) With {.ChartType = SeriesChartType.Bar}  '设置Series的绘图类型
        MyChart.Series.Add(series1)
        MyChart.Series(Title).IsValueShownAsLabel = True
        MyChart.Series(Title).Font = New Font("Times New Roman", 10)

        MyChart.Legends(0).Alignment = StringAlignment.Center '调整图例
        MyChart.Legends(0).Docking = Docking.Top
        MyChart.Legends(0).Font = New Font("微软雅黑", 12, FontStyle.Bold)

        MyChart.ChartAreas(0).AxisX.Title = XTitle  '设置ChartArea里坐标轴标题
        MyChart.ChartAreas(0).AxisX.MajorGrid.Enabled = False        '取消网格
        MyChart.ChartAreas(0).AxisX.MajorTickMark.Enabled = False        '不显示刻度
        MyChart.ChartAreas(0).AxisX.LabelStyle.IsStaggered = False        '设置是否交错显示,比如数据多的时间分成两行来显示 
        'MyChart.ChartAreas(0).AxisX.ArrowStyle = AxisArrowStyle.Triangle        '显示箭头
        MyChart.ChartAreas(0).AxisX.TextOrientation = TextOrientation.Horizontal
        MyChart.ChartAreas(0).AxisX.TextOrientation = TextOrientation.Horizontal
        MyChart.ChartAreas(0).AxisX.TitleFont = New Font("微软雅黑", 12, FontStyle.Bold)
        MyChart.ChartAreas(0).AxisX.LabelStyle.Font = New Font("微软雅黑", 10)
        MyChart.ChartAreas(0).AxisX.LineWidth = 1

        If DisPlayNum > 15 Then
            MyChart.ChartAreas(0).AxisX.Interval = 1 '设置X轴坐标的间隔为1
            MyChart.ChartAreas(0).AxisX.IntervalOffset = 1 '设置X轴坐标偏移为1
            MyChart.ChartAreas(0).AxisX.LabelStyle.Font = New Font("微软雅黑", 8)
            MyChart.Series(Title).Font = New Font("Times New Roman", 8)
            'MyChart.ChartAreas(0).AxisX.LabelStyle.Angle = 90
        End If

        'Chart1.ChartAreas(0).AxisY.Title = YTitle
        'MyChart.ChartAreas(0).AxisY.ArrowStyle = AxisArrowStyle.Triangle
        MyChart.ChartAreas(0).AxisY.MajorGrid.Enabled = False
        MyChart.ChartAreas(0).AxisY.MajorTickMark.Enabled = False
        MyChart.ChartAreas(0).AxisY.LabelStyle.Enabled = False        '不显示y轴标签
        'MyChart.ChartAreas(0).AxisY.Enabled = False
        MyChart.ChartAreas(0).AxisY.LineWidth = 0





        Dim i As Integer = 0
        For Each item In dic
            MyChart.Series(Title).Points.AddXY(i, item.Value)    '为这个Series加数据点
            MyChart.Series(Title).Points(i).AxisLabel = item.Key
            i += 1
            If i = DisPlayNum Then Exit For
        Next

    End Sub


    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="MyChart"></param>
    Public Sub ExportPicture(ByVal MyChart As Chart)
        Dim saveFileName As String = ""
        Dim saveDialog As SaveFileDialog = New SaveFileDialog()
        saveDialog.FileName = MyChart.ChartAreas(0).AxisX.Title
        saveFileName = saveDialog.FileName
        saveDialog.Filter = "Bitmap (*.bmp)|*.bmp|JPEG (*.jpg)|*.jpg|EMF (*.emf)|*.emf|PNG (*.png)|*.png|SVG (*.svg)|*.svg|GIF (*.gif)|*.gif|TIFF (*.tif)|*.tif"
        saveDialog.FilterIndex = 2
        saveDialog.RestoreDirectory = True

        If saveDialog.ShowDialog() = DialogResult.OK Then
            Dim format As ChartImageFormat = ChartImageFormat.Bmp

            If saveDialog.FileName.EndsWith("bmp") Then
                format = ChartImageFormat.Bmp
            ElseIf saveDialog.FileName.EndsWith("jpg") Then
                format = ChartImageFormat.Jpeg
            ElseIf saveDialog.FileName.EndsWith("emf") Then
                format = ChartImageFormat.Emf
            ElseIf saveDialog.FileName.EndsWith("gif") Then
                format = ChartImageFormat.Gif
            ElseIf saveDialog.FileName.EndsWith("png") Then
                format = ChartImageFormat.Png
            ElseIf saveDialog.FileName.EndsWith("tif") Then
                format = ChartImageFormat.Tiff
            End If

            MyChart.SaveImage(saveDialog.FileName, format)
            MsgBox("保存成功！",, "保存图片")
        End If
    End Sub


    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="str"></param>
    ''' <returns></returns>
    Public Function GetDic(str As String) As Dictionary(Of String, Integer)
        Dim con As New OleDbConnection
        Dim cmd As New OleDbCommand
        Dim dr As OleDbDataReader
        Dim mylist As New List(Of String)
        Try
            con.ConnectionString = con_ConnectionString
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "Select * from Main"
            dr = cmd.ExecuteReader

            While (dr.Read)
                mylist.Add(Juncode((dr.Item(str)).ToString))
            End While
            dr.Close()
            con.Close()
        Catch ex As Exception
        Finally
            If con IsNot Nothing Then con.Close()
        End Try

        Dim LB As New List(Of String)
        Dim slb() As String
        For Each item In mylist
            slb = Split(item, " ")
            For Each s In slb
                LB.Add(s)
            Next
        Next

        Dim myDic As Dictionary(Of String, Integer) = New Dictionary(Of String, Integer)
        For Each item In LB
            If InStr(item, " ") = 0 And item <> "" Then
                If myDic.ContainsKey(item) Then
                    myDic(item) += 1
                Else
                    myDic.Add(item, 1)
                End If
            End If
        Next
        Sort(myDic)
        Return myDic
    End Function
End Module
