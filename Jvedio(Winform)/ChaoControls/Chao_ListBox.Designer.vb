Imports System.Drawing.Drawing2D
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Chao_ListBox
    Inherits System.Windows.Forms.UserControl

    Private SelectedIndex As Integer = -1
    Public ListItems As New List(Of String)
    '测试用
    'Private myTestItem As Collection = New Collection("Item1Item2Item3Item4Item5Item6", "Item2", "Item3", "Item4", "Item5")
    'New String() {"Item1Item2Item3Item4Item5Item6", "Item2", "Item3", "Item4", "Item5"} '测试用

    Private MouseMoveIndex As Integer = -1
    Private MouseDownTimer As New Timer With {.Interval = 1}
    Private myMouseDown As MD
    Private MouseDownR As Single = 0
    Private myVscrollbar As New Chao_VscrollBar With {
            .Height = Me.Height - 2 * BorderWidth,
            .Width = 10,
            .Top = BorderWidth,
            .Left = Me.Width - .Width - BorderWidth
        }
    Private myHscrollbar As New Chao_HscrollBar With {
            .Height = 10,
            .Width = Me.Width,
            .Top = Me.Height - .Height,
            .Left = 0
        }

    Private VScrollValue As Integer = 0
    Private VscrollWidth As Single = 0
    Private HscrollWidth As Single = 0
    Private ItemLength As Single = 0

    Structure MD
        Dim Enabled As Boolean
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
    Private Sub IniTial()

        ItemLength = 0
        'If ListBoxItems Is Nothing Then
        If Items Is Nothing Then
            ItemLength = 0
            myHscrollbar.Visible = False

            Exit Sub
        End If



        ListItems.Clear()
        For Each s In Items
            ListItems.Add(s)
        Next

        '获得最长的文字
        Dim bmp As Bitmap = New Bitmap(Me.Width, Me.Height)
        Dim g As Graphics = Graphics.FromImage(bmp)
        Dim TextSize As SizeF
        For i = 0 To ListItems.Count - 1
            TextSize = g.MeasureString(ListItems.Item(i), ListBoxFont)
            If ItemLength <= TextSize.Width Then
                ItemLength = TextSize.Width
            End If
        Next
        g.Dispose()
        bmp.Dispose()


        Me.Controls.Add(myVscrollbar)
        Me.Controls.Add(myHscrollbar)


        With myVscrollbar
            .Height = Me.Height - 2 * BorderWidth
            .Width = 20
            .Top = BorderWidth
            .Left = Me.Width - .Width - BorderWidth
            If myHscrollbar.Visible Then
                .Maximum = Me.ListItems.Count - Int((Me.Height - 10) / ItemHeight) + 1
            Else
                .Maximum = Me.ListItems.Count - Int((Me.Height - 10) / ItemHeight)
            End If
            .SmallChange = 1
            .LargeChange = 2
            .Minimum = 0
            .Value = 0
        End With

        With myHscrollbar
            .Height = 20
            .Width = Me.Width
            .Top = Me.Height - .Height - BorderWidth
            .Left = BorderWidth
            .Maximum = 10 + ItemLength - Me.Width + myVscrollbar.Width
            .SmallChange = .Maximum / 8
            .LargeChange = .Maximum / 4
        End With


        '显示垂直滚动条
        Dim HscrollbarHeight As Single = 0
        If myHscrollbar.Visible Then
            HscrollbarHeight = myHscrollbar.Height
        Else
            HscrollbarHeight = 0
        End If
        If Me.Height - HscrollbarHeight < 10 + Me.ListItems.Count * ItemHeight Then
            myVscrollbar.Visible = True
            VscrollWidth = myVscrollbar.Width
        Else
            myVscrollbar.Visible = False
            VscrollWidth = 0
            myVscrollbar.Value = 0
        End If

        '显示水平滚动条
        If ItemLength = 0 Then
            myHscrollbar.Visible = False
            myHscrollbar.Value = 0
        Else
            If Me.Width < ItemLength + 10 Then
                myHscrollbar.Visible = True
                If myVscrollbar.Visible Then myHscrollbar.Width = Me.Width - myVscrollbar.Width
            Else
                myHscrollbar.Visible = False
                myHscrollbar.Value = 0
            End If
        End If


        Dim Count As Integer = Me.ListItems.Count
        If Count > 0 Then
            If Me.Height > 10 + Count * ItemHeight Then '不能过大
                Me.Height = 10 + Count * ItemHeight
            End If
            '锁定高度
            If (Me.Height - 10) Mod ItemHeight <> 0 Then
                Me.Height = 10 + ItemHeight * (Int((Me.Height - 10) / ItemHeight) + 1) + myHscrollbar.Height
            End If
        End If

        AddHandler myVscrollbar.ValueChanged, AddressOf myVscrollbar_ValueChanged
        AddHandler myHscrollbar.ValueChanged, AddressOf myHscrollbar_ValueChanged
        AddHandler MouseDownTimer.Tick, AddressOf MouseDownTimer_Tick
        Invalidate()
    End Sub

    Sub New()

        ' 此调用是设计器所必需的。
        InitializeComponent()
        With Me
            '防止闪烁
            .SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
            .SetStyle(ControlStyles.UserPaint, True)
            .SetStyle(ControlStyles.ResizeRedraw, True)
            .SetStyle(ControlStyles.AllPaintingInWmPaint, True)
            .MinimumSize = New Size(150, 90)
        End With
        ' 在 InitializeComponent() 调用之后添加任何初始化。

        'ListBoxItems = myString
        IniTial()

    End Sub

    Sub myHscrollbar_ValueChanged()
        'myHscrollbar.Value 
        Invalidate()
    End Sub

    Sub myVscrollbar_ValueChanged()
        'myVScroll.value = myVscrollbar.Value
        Invalidate()

    End Sub


    Protected Overrides Sub OnMouseWheel(e As MouseEventArgs)
        MyBase.OnMouseWheel(e)
        If e.Delta < 0 Then
            myVscrollbar.Value += myVscrollbar.LargeChange
        Else
            myVscrollbar.Value -= myVscrollbar.LargeChange
        End If
    End Sub

    Protected Overrides Sub OnSizeChanged(e As EventArgs)
        MyBase.OnSizeChanged(e)
        Dim Count As Integer = Me.ListItems.Count
        If Me.Height <= 10 + ItemHeight Then '不能过小
            Me.Height = 10 + ItemHeight
        End If


        If Count > 0 Then
            If Me.Height > 10 + Count * ItemHeight Then '不能过大
                Me.Height = 10 + Count * ItemHeight
            End If
            '锁定高度
            If (Me.Height - 10) Mod ItemHeight <> 0 Then
                Me.Height = 10 + ItemHeight * (Int((Me.Height - 10) / ItemHeight) + 1)
            End If

        End If



        '显示垂直滚动条
        Dim HscrollbarHeight As Single = 0
        If myHscrollbar.Visible Then
            HscrollbarHeight = myHscrollbar.Height
        Else
            HscrollbarHeight = 0
        End If
        If Me.Height - HscrollbarHeight < 10 + Me.ListItems.Count * ItemHeight Then
            With myVscrollbar
                .Height = Me.Height - 2 * BorderWidth
                .Width = 20
                .Top = BorderWidth
                .Left = Me.Width - .Width - BorderWidth
                .Visible = True
                .Maximum = Me.ListItems.Count - Int((Me.Height - 10) / ItemHeight) + 1
                .SmallChange = 1
                .LargeChange = 2
                .Minimum = 0
            End With
            VscrollWidth = myVscrollbar.Width
        Else
            myVscrollbar.Visible = False
            VscrollWidth = 0
        End If


        '显示水平滚动条
        If Me.Width < ItemLength + 10 Then

            With myHscrollbar
                .Height = 20
                If myVscrollbar.Visible Then
                    .Width = Me.Width - myVscrollbar.Width
                Else
                    .Width = Me.Width
                End If
                .Top = Me.Height - .Height - BorderWidth
                .Left = BorderWidth
                .Maximum = 10 + ItemLength - Me.Width + myVscrollbar.Width
                .SmallChange = .Maximum / 8
                .LargeChange = .Maximum / 4
                .Visible = True
            End With
        Else
            myHscrollbar.Visible = False
            myHscrollbar.Value = 0
        End If


    End Sub

    Sub MouseDownTimer_Tick()
        MouseDownR += (Me.Width - VscrollWidth) / 16
        Invalidate()
        If MouseDownR >= Math.Max(Me.Width - VscrollWidth, ItemHeight) Then
            MouseDownTimer.Enabled = False
            myMouseDown.Enabled = False
            Invalidate()
        End If
    End Sub

    Protected Overrides Sub OnMouseDown(e As MouseEventArgs)
        MyBase.OnMouseDown(e)
        Dim region As Region
        Dim Rect As RectangleF
        VScrollValue = -myVscrollbar.Value * ItemHeight
        For i = 0 To Me.ListItems.Count - 1
            Rect = New RectangleF(0, VScrollValue + i * ItemHeight, Me.Width - VscrollWidth, ItemHeight)
            region = New Region(Rect)
            If region.IsVisible(New Point(e.X, e.Y)) Then
                myMouseDown.Enabled = True
                myMouseDown.X = e.X
                myMouseDown.Y = e.Y
                MouseDownR = 0
                SelectedIndex = i
                MouseDownTimer.Enabled = True
                'Invalidate()

                Exit For
            End If
        Next

    End Sub

    Protected Overrides Sub OnMouseMove(e As MouseEventArgs)
        MyBase.OnMouseMove(e)
        Dim region As Region
        Dim Rect As RectangleF
        VScrollValue = -myVscrollbar.Value * ItemHeight
        For i = 0 To Me.ListItems.Count - 1
            Rect = New RectangleF(0, VScrollValue + i * ItemHeight, Me.Width - VscrollWidth, ItemHeight)
            region = New Region(Rect)
            If region.IsVisible(New Point(e.X, e.Y)) Then
                MouseMoveIndex = i
                Invalidate()
                Exit For
            End If
        Next
    End Sub

    Protected Overrides Sub OnMouseLeave(e As EventArgs)
        MyBase.OnMouseLeave(e)
        MouseMoveIndex = -1
        Invalidate()
    End Sub



    Protected Overrides Sub OnPaint(e As PaintEventArgs)

        MyBase.OnPaint(e)
        Dim bmp = Draw()
        e.Graphics.DrawImage(bmp, 0, 0)
        bmp.Dispose()


    End Sub

    Private Function Draw() As Bitmap

        Dim bmp As New Bitmap(Me.Width, Me.Height)
        Dim g As Graphics = Graphics.FromImage(bmp)
        g.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
        g.Clear(ListBoxBackColor)
        Dim w As Single = Me.Width
        Dim h As Single = Me.Height

        Dim TextSize As SizeF
        Dim TextPoint As PointF

        '滚动条

        VScrollValue = -myVscrollbar.Value * ItemHeight

        '画每一项
        g.TextRenderingHint = Drawing.Text.TextRenderingHint.ClearTypeGridFit
        Dim UnSelectedSolidBrush As New SolidBrush(Color.White)
        For i = 0 To ListItems.Count - 1
            g.FillRectangle(UnSelectedSolidBrush, New RectangleF(BorderWidth, VScrollValue + 10 + ItemHeight * i, Me.Width - 3 * BorderWidth - VscrollWidth, ItemHeight))
        Next



        '画MouseMove和MouseDown
        For i = 0 To ListItems.Count - 1
            If i = SelectedIndex Then
                g.FillRectangle(New SolidBrush(SelectedColor), New RectangleF(BorderWidth, VScrollValue + 10 + ItemHeight * i + BorderWidth, Me.Width - 3 * BorderWidth - VscrollWidth, ItemHeight))
            ElseIf i = MouseMoveIndex Then
                g.FillRectangle(New SolidBrush(GetRelativeColor(SelectedColor, -10, 100)), New RectangleF(BorderWidth, VScrollValue + 10 + ItemHeight * i + BorderWidth, Me.Width - 3 * BorderWidth - VscrollWidth, ItemHeight))
            Else
                g.FillRectangle(Brushes.White, New RectangleF(BorderWidth, VScrollValue + 10 + ItemHeight * i, Me.Width - 3 * BorderWidth - VscrollWidth, ItemHeight))
            End If
        Next

        'MouseDownR
        If myMouseDown.Enabled Then
            g.Clip = New Region(New RectangleF(BorderWidth, VScrollValue + 10 + SelectedIndex * ItemHeight + BorderWidth, Me.Width - 3 * BorderWidth - VscrollWidth, ItemHeight))
            g.FillEllipse(New SolidBrush(GetRelativeColor(SelectedColor, -10)), myMouseDown.X - MouseDownR, myMouseDown.Y - MouseDownR, 2 * MouseDownR, 2 * MouseDownR)
            g.Clip = New Region(New RectangleF(0, 0, Me.Width, Me.Height))
        End If

        '画文字
        For i = 0 To ListItems.Count - 1
            TextSize = g.MeasureString(ListItems.Item(i), ListBoxFont)
            TextPoint = New PointF(10 - myHscrollbar.Value, VScrollValue + 10 + ItemHeight * i + (ItemHeight - TextSize.Height) / 2)
            g.DrawString(ListItems.Item(i), ListBoxFont, New SolidBrush(TextColor), TextPoint)
        Next



        '画边框
        Dim BorderPath As New GraphicsPath
        With BorderPath
            .AddRectangle(New RectangleF(0, 0, w - 1, h - 1))
        End With
        g.DrawPath(New Pen(BorderColor, BorderWidth), BorderPath)

        g.Dispose()
        Return bmp

    End Function

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.SuspendLayout()
        '
        'Chao_ListBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Name = "Chao_ListBox"
        Me.Size = New System.Drawing.Size(198, 193)
        Me.ResumeLayout(False)

    End Sub

End Class
