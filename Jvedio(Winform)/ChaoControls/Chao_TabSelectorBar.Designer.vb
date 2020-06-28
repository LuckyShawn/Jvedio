Imports System.Drawing.Drawing2D
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Chao_TabSelectorBar
    Inherits System.Windows.Forms.UserControl

#Region "测试用TabControl"
    'Private TabPage1 As New TabPage With {
    '    .Location = New Point(4, 25),
    '    .Name = "TabPage1",
    '    .TabIndex = 0,
    '    .Text = "TabPage1"
    '}

    'Private TabPage2 As New TabPage With {
    '    .Location = New Point(4, 25),
    '    .Name = "TabPage2",
    '    .TabIndex = 0,
    '    .Text = "TabPage2"
    '}

    'Private TabPage3 As New TabPage With {
    '    .Location = New Point(4, 25),
    '    .Name = "TabPage3",
    '    .TabIndex = 0,
    '    .Text = "TabPage3"
    '}


    'Private myTabControl As New TabControl With {
    '    .Left = 0,
    '    .Top = Me.Height
    '}

#End Region

    Private TabCount As Integer
    Private BarWidth As Single
    Private myMouseMove As New MyMouse
    Private myMouseDown As New MyMouse
    Private BeforeMouseDownIndex As Integer
    Private SlideTimer As New Timer With {.Interval = 1}
    Private SlideLength As Single
    Private MouseDownR As Single = 0
    Private Structure MyMouse
        Dim Enable As Boolean
        Dim X As Single
        Dim Y As Single
    End Structure



    'UserControl 重写释放以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Sub New()

        ' 此调用是设计器所必需的。
        InitializeComponent()

        ' 在 InitializeComponent() 调用之后添加任何初始化。
        With Me
            .MinimumSize = New Size(100, 0)
            .SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
            .SetStyle(ControlStyles.UserPaint, True)
            .SetStyle(ControlStyles.ResizeRedraw, True)
            .SetStyle(ControlStyles.AllPaintingInWmPaint, True)
        End With

#Region "测试用"
        'myTabControl.Controls.Add(TabPage1)
        'myTabControl.Controls.Add(TabPage2)
        'myTabControl.Controls.Add(TabPage3)
        'myTabControl.Width = 500
        'Me.BaseTabControl = myTabControl
        'BaseTabControl.SelectedTab = TabPage3
        'Me.TabImageList = ImageList1
#End Region

        If BaseTabControl IsNot Nothing Then
            Index = BaseTabControl.SelectedIndex
            TabCount = BaseTabControl.TabCount
            BarWidth = Me.Width / TabCount
            BeforeMouseDownIndex = Index
            AddHandler BaseTabControl.SelectedIndexChanged, AddressOf BaseTabControl_SelectedIndexChanged
            AddHandler BaseTabControl.ControlAdded, AddressOf BaseTabControl_ControlAdded
            AddHandler BaseTabControl.ControlRemoved, AddressOf BaseTabControl_ControlRemoved

        End If
        AddHandler SlideTimer.Tick, AddressOf SlideTimer_Tick
    End Sub

    Private Sub BaseTabControl_ControlRemoved()
        Index = BaseTabControl.SelectedIndex
        TabCount = BaseTabControl.TabCount - 1
        If TabCount = 0 Then
            BarWidth = 0
        Else
            BarWidth = Me.Width / TabCount
        End If
        BeforeMouseDownIndex = Index
    End Sub

    Private Sub BaseTabControl_ControlAdded()
        Index = BaseTabControl.SelectedIndex
        TabCount = BaseTabControl.TabCount
        BarWidth = Me.Width / TabCount
        BeforeMouseDownIndex = Index
    End Sub

    Private Sub BaseTabControl_SelectedIndexChanged()
        Index = BaseTabControl.SelectedIndex
        SlideTimer.Enabled = True
    End Sub


    Protected Overrides Sub OnResize(e As EventArgs)
        MyBase.OnResize(e)
        If TabCount = 0 Then
            BarWidth = 0
        Else
            BarWidth = Me.Width / TabCount
        End If
        Invalidate()
    End Sub

    Private Sub SlideTimer_Tick()
        MouseDownR += Me.Height / 2
        Invalidate()
        If BeforeMouseDownIndex > Index Then
            SlideLength -= Me.Width / 40
            Invalidate()
            If BeforeMouseDownIndex * BarWidth + SlideLength <= Index * BarWidth Then
                BeforeMouseDownIndex = Index
                SlideLength = 0
                Invalidate()
            End If
        ElseIf BeforeMouseDownIndex < Index Then
            SlideLength += Me.Width / 32
            Invalidate()
            If BeforeMouseDownIndex * BarWidth + SlideLength >= Index * BarWidth Then
                BeforeMouseDownIndex = Index
                SlideLength = 0
                Invalidate()
            End If
        Else
            If MouseDownR >= Math.Max(Me.Height, BarWidth) Then
                myMouseDown.Enable = False
                SlideTimer.Enabled = False
                Invalidate()
            End If
        End If
    End Sub

    Protected Overrides Sub OnMouseMove(e As MouseEventArgs)
        MyBase.OnMouseMove(e)
        myMouseMove.Enable = True
        myMouseMove.X = e.X
        myMouseMove.Y = e.Y
        Invalidate()
    End Sub

    Protected Overrides Sub OnMouseLeave(e As EventArgs)
        MyBase.OnMouseLeave(e)
        myMouseMove.Enable = False
        Invalidate()
    End Sub

    Protected Overrides Sub OnMouseDown(e As MouseEventArgs)
        MyBase.OnMouseDown(e)
        If BaseTabControl Is Nothing Then Exit Sub
        myMouseDown.Enable = True
        myMouseDown.X = e.X
        myMouseDown.Y = e.Y
        BeforeMouseDownIndex = Index
        SlideLength = 0
        MouseDownR = 0
        Dim TabRegion As Region
        For i = 0 To BaseTabControl.TabCount - 1
            TabRegion = New Region(New RectangleF(i * BarWidth, 0, BarWidth, Me.Height))
            If TabRegion.IsVisible(New PointF(myMouseDown.X, myMouseDown.Y)) Then
                Index = i
                TabRegion.Dispose()
                Exit For
            End If
        Next
        BaseTabControl.SelectedIndex = Index
        SlideTimer.Enabled = True
    End Sub



    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)
        If BaseTabControl Is Nothing Then
            Dim bmp As Bitmap = New Bitmap(Me.Width, Me.Height)
            Dim g As Graphics = Graphics.FromImage(bmp)
            g.Clear(TabBackColor)
            e.Graphics.DrawImage(bmp, 0, 0)
            bmp.Dispose()
            g.Dispose()
        Else
            Dim bmp As Bitmap
            bmp = DrawBar()
            e.Graphics.DrawImage(bmp, 0, 0)
            bmp.Dispose()
        End If
    End Sub


    Private Function DrawBar() As Bitmap
        Dim bmp As Bitmap = New Bitmap(Me.Width, Me.Height)
        Dim g As Graphics = Graphics.FromImage(bmp)
        g.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
        g.Clear(TabBackColor)

        Dim TextSize As SizeF
        Dim TextPoint As PointF
        Dim TabText As String = ""
        Dim TextSolidBrush As SolidBrush = New SolidBrush(TabForeColor)
        Dim TabRegion As Region

        'MouseMove
        If myMouseMove.Enable Then
            For i = 0 To BaseTabControl.TabCount - 1
                TabRegion = New Region(New RectangleF(i * BarWidth, 0, BarWidth, Me.Height))
                If TabRegion.IsVisible(New PointF(myMouseMove.X, myMouseMove.Y)) Then
                    g.FillRegion(New SolidBrush(GetRelativeColor(TabSelectedForeColor, 20, 100)), TabRegion)
                End If
            Next
        End If

        'MouseDown
        If myMouseDown.Enable Then
            TabRegion = New Region(New RectangleF(Index * BarWidth, 0, BarWidth, Me.Height))
            g.Clip = TabRegion
            g.FillEllipse(New SolidBrush(GetRelativeColor(TabSelectedForeColor, 20, 100)), New RectangleF(myMouseDown.X - MouseDownR, myMouseDown.Y - MouseDownR, 2 * MouseDownR, 2 * MouseDownR))
        End If
        g.Clip = New Region(New RectangleF(0, 0, CType(Me.Width, Single), CType(Me.Height, Single)))

        '画滑块
        TabRegion = New Region(New RectangleF(Index * BarWidth, 0, BarWidth, Me.Height))
        Dim SlideSolideBrush As SolidBrush = New SolidBrush(SlideColor)
        g.FillRectangle(SlideSolideBrush, New RectangleF(BeforeMouseDownIndex * BarWidth + SlideLength, Me.Height - SlideHeight, BarWidth, SlideHeight))

        '画文字
        Dim ImageListIndex As Integer = 0
        For i = 0 To BaseTabControl.TabCount - 1
            If i = Index Then
                TextSolidBrush = New SolidBrush(TabSelectedForeColor)
            Else
                TextSolidBrush = New SolidBrush(TabForeColor)
            End If
            TabText = BaseTabControl.TabPages.Item(i).Text
            TextSize = g.MeasureString(TabText, TabFont)
            '画图象
            If TabImageList IsNot Nothing Then
                If TabImageList.Images.Count > 0 Then
                    If i > TabImageList.Images.Count - 1 Then
                        ImageListIndex = TabImageList.Images.Count - 1
                    Else
                        ImageListIndex = i
                    End If
                    If ImageDrawStyle = "Leading" Then
                        Dim ImagePoint As New PointF(i * BarWidth + (BarWidth - (TabImageList.Images.Item(ImageListIndex).Width + TextSize.Width)) / 2, (Me.Height - TabImageList.Images.Item(ImageListIndex).Height) / 2)
                        TextPoint = New PointF(i * BarWidth + TabImageList.Images.Item(ImageListIndex).Width + (BarWidth - (TabImageList.Images.Item(ImageListIndex).Width + TextSize.Width)) / 2, (Me.Height - TextSize.Height) / 2)
                        g.DrawImage(TabImageList.Images.Item(ImageListIndex), ImagePoint)
                        g.DrawString(TabText, TabFont, TextSolidBrush, TextPoint)
                    Else
                        Dim ImagePoint As New PointF(i * BarWidth + (BarWidth - TabImageList.Images.Item(ImageListIndex).Width) / 2, (Me.Height - (TabImageList.Images.Item(ImageListIndex).Height + TextSize.Height)) / 2)
                        TextPoint = New PointF(i * BarWidth + (BarWidth - TextSize.Width) / 2, ImagePoint.Y + TabImageList.Images.Item(ImageListIndex).Height)
                        g.DrawImage(TabImageList.Images.Item(ImageListIndex), ImagePoint)
                        g.DrawString(TabText, TabFont, TextSolidBrush, TextPoint)
                    End If
                Else
                    TextPoint = New PointF(i * BarWidth + (BarWidth - TextSize.Width) / 2, (Me.Height - TextSize.Height) / 2)
                    g.DrawString(TabText, TabFont, TextSolidBrush, TextPoint)
                End If
            Else
                TextPoint = New PointF(i * BarWidth + (BarWidth - TextSize.Width) / 2, (Me.Height - TextSize.Height) / 2)
                g.DrawString(TabText, TabFont, TextSolidBrush, TextPoint)
            End If

        Next
        SlideSolideBrush.Dispose()
        TextSolidBrush.Dispose()
        TabRegion.Dispose()
        g.Dispose()
        Return bmp
    End Function

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.SuspendLayout()
        '
        'Chao_TabSelectorBar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Name = "Chao_TabSelectorBar"
        Me.Size = New System.Drawing.Size(400, 50)
        Me.ResumeLayout(False)

    End Sub
End Class
