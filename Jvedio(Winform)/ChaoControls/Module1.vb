Imports System.Drawing.Drawing2D
Imports System.Reflection
Module Module1

    ''' <summary>
    ''' 防止ListView闪烁
    ''' </summary>
    Public Class ControlExtensions
        Public Sub DoubleBuffering(ByVal control As Control, ByVal enable As Boolean)
            Dim doubleBufferPropertyInfo = control.[GetType]().GetProperty("DoubleBuffered", BindingFlags.Instance Or BindingFlags.NonPublic)
            doubleBufferPropertyInfo.SetValue(control, enable, Nothing)
        End Sub
    End Class




    ''' <summary>
    ''' 在一个圆角矩形框内画一个对号
    ''' </summary>
    ''' <param name="x">正方形X</param>
    ''' <param name="y">正方形Y</param>
    ''' <param name="w">正方形边长</param>
    ''' <param name="r">过渡半径</param>
    ''' <returns></returns>
    ''' 各个坐标见CAD文件
    Public Function GetDuiHaoPath(x As Single, y As Single, w As Single, r As Single) As GraphicsPath
        Dim h As Single = w
        Dim myGraphicsPath As New GraphicsPath
        With myGraphicsPath
            .AddLine(x + 8 * r / 10, y + h / 2 + 4 * r / 10, x + w / 2 - 2 * r / 10, y + h - r)
            .AddLine(x + w / 2 - 2 * r / 10, y + h - r, x + w - r, y + r - 4 * r / 10)
            .AddLine(x + w - r, y + r - 4 * r / 10, x + w - r / 2, y + r)
            .AddLine(x + w - r / 2, y + r, x + w / 2, y + h - r / 2)
            .AddLine(x + w / 2, y + h - r / 2, x + r / 2, y + h - r)
            .CloseFigure()
        End With
        Return myGraphicsPath
    End Function




    ''' <summary>
    ''' 在给定正方形画布上画一个搜索按钮
    ''' </summary>
    ''' <param name="width">正方形边长</param>
    ''' <param name="myBackColor">背景色</param>
    ''' <param name="SearchColor">搜索按钮颜色</param>
    ''' <returns></returns>
    Public Function DrawSearchIcon(width As Integer, myBackColor As Color, SearchColor As Color) As Bitmap
        Dim k As Single = width / 100
        Dim bmp As Bitmap = New Bitmap(width, width)
        Dim g As Graphics
        g = Graphics.FromImage(bmp)
        g.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
        g.Clear(myBackColor)
        Dim mypath1 As New System.Drawing.Drawing2D.GraphicsPath
        With mypath1
            .AddEllipse(11.5F * k, 11.5F * k, 62.0F * k, 62.0F * k)
        End With
        Dim mypath2 As New System.Drawing.Drawing2D.GraphicsPath
        With mypath2
            .AddArc(1.5F * k, 1.5F * k, 82.0F * k, 82.0F * k, 55, 340)
            .AddLine(76.0F * k, 66.0F * k, CType(width, Single), 90.0F * k)
            .AddLine(CType(width, Single), 90.0F * k, 90.0F * k, CType(width, Single))
            .CloseFigure()
        End With
        g.FillPath(New SolidBrush(SearchColor), mypath2)
        g.FillPath(New SolidBrush(myBackColor), mypath1)
        g.Dispose()
        Return bmp
    End Function


    Public Function DrawClearIcon(width As Integer, myBackColor As Color, SearchColor As Color) As Bitmap
        Dim k As Single = width / 100
        Dim bmp As Bitmap = New Bitmap(width, width)
        Dim g As Graphics
        g = Graphics.FromImage(bmp)
        g.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
        g.Clear(myBackColor)

        g.DrawLine(New Pen(SearchColor, 2), 5, 5, width - 5, width - 5)
        g.DrawLine(New Pen(SearchColor, 2), width - 5, 5, 5, width - 5)
        g.Dispose()
        Return bmp
    End Function

    Public Function HalfdrawRoundRectangle(x As Single, y As Single, w As Single, h As Single, r As Single) As GraphicsPath
        Dim result As New GraphicsPath
        With result
            .AddArc(x, y, 2 * r, 2 * r, 180, 90)
            .AddLine(x + r, y, x + w - r, y)
            .AddArc(x + w - 2 * r, y, 2 * r, 2 * r, 270, 90)
            .AddLine(x + w, y + r, x + w, y + h)
            .AddLine(x + w, y + h, x, y + h)
            .CloseFigure()
        End With
        Return result
    End Function

    Public Function DrawRoundRectangle(x As Single, y As Single, w As Single, h As Single, r As Single) As GraphicsPath
        Dim result As New GraphicsPath
        With result
            .AddArc(x, y, 2 * r, 2 * r, 180, 90)
            .AddLine(x + r, y, x + w - r, y)
            .AddArc(x + w - 2 * r, y, 2 * r, 2 * r, 270, 90)
            .AddLine(x + w, y + r, x + w, y + h - r)
            .AddArc(x + w - 2 * r, y + h - 2 * r, 2 * r, 2 * r, 0, 90)
            .AddLine(x + w - r, y + h, x + r, y + h)
            .AddArc(x, y + h - 2 * r, 2 * r, 2 * r, 90, 90)
            .CloseFigure()
        End With
        Return result
    End Function


    ''' <summary>
    ''' 获得相对颜色，RGB整体加减一个值
    ''' </summary>
    ''' <param name="Mycolor">要修改的颜色</param>
    ''' <param name="CV">改变的大小</param>
    ''' <param name="A">是否设置透明色，默认不透明</param>
    ''' <returns></returns>
    Public Function GetRelativeColor(Mycolor As Color, CV As Integer, Optional A As Integer = 255) As Color
        Dim ChangeValue As Integer = CV
        Dim aVal As Integer = Mycolor.A
        Dim rVal As Integer = Mycolor.R
        Dim gVal As Integer = Mycolor.G
        Dim bVal As Integer = Mycolor.B
        If rVal + ChangeValue <= 255 And rVal + ChangeValue >= 0 Then
            rVal += ChangeValue
        End If
        If gVal + ChangeValue <= 255 And gVal + ChangeValue >= 0 Then
            gVal += ChangeValue
        End If
        If bVal + ChangeValue <= 255 And bVal + ChangeValue >= 0 Then
            bVal += ChangeValue
        End If
        Return Color.FromArgb(A, rVal, gVal, bVal)
    End Function
End Module
