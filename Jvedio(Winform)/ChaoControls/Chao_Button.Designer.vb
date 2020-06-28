Imports System.Drawing.Drawing2D
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Chao_Button
    Inherits System.Windows.Forms.UserControl


    Private myMouseMove As Boolean = False
    Private myMouseDown As MD
    Private MouseDownR As Single = 0    'MouseDown动画效果的圆直径
    Private IsClicked As Boolean = False
    Private Structure MD
        Dim IsMouseDown As Boolean
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
            '防止闪烁
            .SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
            .SetStyle(ControlStyles.UserPaint, True)
            .SetStyle(ControlStyles.ResizeRedraw, True)
            .SetStyle(ControlStyles.AllPaintingInWmPaint, True)
            .SetStyle(ControlStyles.SupportsTransparentBackColor, True)
            UpdateStyles()
        End With
        Me.MinimumSize = New Size(25, 25)
    End Sub

    Protected Overrides Sub OnMouseMove(e As MouseEventArgs)
        MyBase.OnMouseMove(e)

        If Not myMouseDown.IsMouseDown Then
            If GetGraphicsPath(5, 5).IsVisible(New Point(e.X, e.Y)) Then
                myMouseMove = True
            Else
                myMouseMove = False
            End If
            Invalidate()
        End If
    End Sub

    Protected Overrides Sub OnMouseLeave(e As EventArgs)
        MyBase.OnMouseLeave(e)
        myMouseMove = False
        Invalidate()
    End Sub

    Protected Overrides Sub OnLostFocus(e As EventArgs)
        MyBase.OnLostFocus(e)
        IsClicked = False
        Invalidate()
    End Sub

    Protected Overrides Sub OnMouseDown(e As MouseEventArgs)
        MyBase.OnMouseDown(e)
        If GetGraphicsPath(5, 5).IsVisible(New Point(e.X, e.Y)) Then
            myMouseDown.IsMouseDown = True
            myMouseDown.X = e.X
            myMouseDown.Y = e.Y
            MouseDownR = 0
            Timer1.Enabled = True
        End If
    End Sub


    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)
        Dim mybmp As Bitmap = DrawButton()
        e.Graphics.DrawImage(mybmp, 0, 0)
        mybmp.Dispose()
    End Sub


    Private Function DrawButton() As Bitmap
        Dim bmp As Bitmap = New Bitmap(Me.Width, Me.Height)
        Dim g As Graphics = Graphics.FromImage(bmp)
        g.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
        g.Clear(ButtonBackColor)

        '设置padding和圆角
        Dim PaddingLR As Single = 5 '左右
        Dim PaddingUD As Single = 5 '上下
        Dim r As Single = 5


        '画边框
        Dim BorderPath As GraphicsPath = GetGraphicsPath(5, 5)
        Dim ButtonColorSolidBrush As SolidBrush = New SolidBrush(ButtonColor)
        Dim MouseMoveSolidBrush As SolidBrush = New SolidBrush(GetRelativeColor(ButtonColor, 20))
        Dim BackColorSolidBrush As SolidBrush = New SolidBrush(ButtonBackColor)
        Dim UnEnabledSolidBrush As SolidBrush = New SolidBrush(Color.Gray)
        Dim MouseDownSolidBrush As SolidBrush = New SolidBrush(GetRelativeColor(ButtonColor, 40, 200))
        Dim ClickedSolidBrush As SolidBrush = New SolidBrush(GetRelativeColor(ButtonColor, 20))

        If Not Me.Enabled Then
            g.FillPath(UnEnabledSolidBrush, BorderPath)
        Else
            '画按钮
            Select Case ButtonType
                Case "ContainedButton"
                    If myMouseMove Then
                        g.FillPath(MouseMoveSolidBrush, BorderPath)
                    Else
                        If IsClicked Then
                            g.FillPath(ClickedSolidBrush, BorderPath)
                        Else
                            g.FillPath(ButtonColorSolidBrush, BorderPath)
                        End If

                    End If
                Case "OutlinedButton"
                    If myMouseMove Then
                        g.FillPath(MouseMoveSolidBrush, BorderPath)
                    Else
                        If IsClicked Then
                            g.DrawPath(New Pen(BorderColor, 2), BorderPath)
                            g.FillPath(BackColorSolidBrush, BorderPath)
                        Else
                            g.DrawPath(New Pen(BorderColor, 1), BorderPath)
                            g.FillPath(BackColorSolidBrush, BorderPath)
                        End If

                    End If
                Case "TextButton"
                    If myMouseMove Then
                        g.FillPath(MouseMoveSolidBrush, BorderPath)
                    Else
                        If IsClicked Then
                            g.FillPath(ClickedSolidBrush, BorderPath)
                        Else
                             g.FillPath(BackColorSolidBrush, BorderPath)
                        End If

                    End If
            End Select

        End If

        'MouseDown

        Dim NarrowBorderPath As GraphicsPath = GetGraphicsPath(5.5, 5.5)
        If myMouseDown.IsMouseDown Then
            g.Clip = New Region(NarrowBorderPath)
            g.FillEllipse(MouseDownSolidBrush, New RectangleF(myMouseDown.X - MouseDownR, myMouseDown.Y - MouseDownR, 2 * MouseDownR, 2 * MouseDownR))
        End If



        '画图象
        If Image IsNot Nothing Then
            Dim myImage As Image = Image
            Dim ImageSize As SizeF = New SizeF(myImage.Width, myImage.Height)
            If ImagePosition = "Left" Then
                g.DrawImage(Image, PaddingLR + 5, (Me.Height - ImageSize.Height) / 2, ImageSize.Width, ImageSize.Height)
            ElseIf ImagePosition = "Center" Then
                g.DrawImage(Image, (Me.Width - ImageSize.Width) / 2, (Me.Height - ImageSize.Height) / 2, ImageSize.Width, ImageSize.Height)
            Else
                g.DrawImage(Image, Me.Width - ImageSize.Width - PaddingLR - 5, (Me.Height - ImageSize.Height) / 2, ImageSize.Width, ImageSize.Height)
            End If
        End If

        '画文字
        Dim TextSize As SizeF = g.MeasureString(ButtonText, ButtonFont)
        Dim TextPoint As PointF
        If Image IsNot Nothing Then
            If ImagePosition = "Left" Then
                TextPoint = New PointF(Image.Width + PaddingLR + 5, (Me.Height - TextSize.Height) / 2)
            Else
                TextPoint = New PointF(PaddingLR + 5, (Me.Height - TextSize.Height) / 2)
            End If
        Else
            TextPoint = New PointF((Me.Width - TextSize.Width) / 2, (Me.Height - TextSize.Height) / 2)
        End If

        Dim TextColorSolidBrush As SolidBrush = New SolidBrush(TextColor)
        Select Case ButtonType
            Case "ContainedButton"
                g.TextRenderingHint = Drawing.Text.TextRenderingHint.ClearTypeGridFit
                g.DrawString(ButtonText, ButtonFont, TextColorSolidBrush, TextPoint)
            Case "OutlinedButton"

                If myMouseMove Then
                    g.TextRenderingHint = Drawing.Text.TextRenderingHint.ClearTypeGridFit
                    g.DrawString(ButtonText, ButtonFont, TextColorSolidBrush, TextPoint)
                Else
                    g.TextRenderingHint = Drawing.Text.TextRenderingHint.AntiAlias
                    g.DrawString(ButtonText, ButtonFont, ButtonColorSolidBrush, TextPoint)
                End If

            Case "TextButton"

                If myMouseMove Then
                    g.TextRenderingHint = Drawing.Text.TextRenderingHint.ClearTypeGridFit
                    g.DrawString(ButtonText, ButtonFont, TextColorSolidBrush, TextPoint)
                Else
                    If IsClicked Then
                        g.TextRenderingHint = Drawing.Text.TextRenderingHint.ClearTypeGridFit
                        g.DrawString(ButtonText, ButtonFont, TextColorSolidBrush, TextPoint)
                    Else
                        g.TextRenderingHint = Drawing.Text.TextRenderingHint.AntiAlias
                        g.DrawString(ButtonText, ButtonFont, ButtonColorSolidBrush, TextPoint)
                    End If

                End If

        End Select




        ButtonColorSolidBrush.Dispose()
        MouseMoveSolidBrush.Dispose()
        BackColorSolidBrush.Dispose()
        MouseDownSolidBrush.Dispose()
        ClickedSolidBrush.Dispose()
        UnEnabledSolidBrush.Dispose()
        BorderPath.Dispose()
        NarrowBorderPath.Dispose()
        g.Dispose() 'Graphics必须要dispose
        Return bmp
    End Function


    Public Function GetGraphicsPath(PaddingLR As Single, PaddingUD As Single) As GraphicsPath
        If ButtonShape = "RoundedRectangle" Then
            Return RoundedReactanglePath(PaddingLR, PaddingUD, 5)
        ElseIf ButtonShape = "Rectangle" Then
            Return RoundedReactanglePath(PaddingLR, PaddingUD, 0)
        Else
            Return EllipsePath(PaddingLR, PaddingUD)
        End If
    End Function

    Private Function RoundedReactanglePath(PaddingLR As Single, PaddingUD As Single, r As Single) As GraphicsPath
        If r = 0 Then r = 0.1
        Dim BorderPath As New GraphicsPath
        With BorderPath
            .AddArc(PaddingLR, PaddingUD, 2 * r, 2 * r, 180, 90)
            .AddLine(r + PaddingLR, PaddingUD, Me.Width - 2 * r - PaddingLR, PaddingUD)
            .AddArc(Me.Width - 2 * r - PaddingLR, PaddingUD, 2 * r, 2 * r, 270, 90)
            .AddLine(Me.Width - PaddingLR, r + PaddingUD, Me.Width - PaddingLR, Me.Height - 2 * r - PaddingUD)
            .AddArc(Me.Width - 2 * r - PaddingLR, Me.Height - 2 * r - PaddingUD, 2 * r, 2 * r, 0, 90)
            .AddLine(Me.Width - r - PaddingLR, Me.Height - PaddingUD, r + PaddingLR, Me.Height - PaddingUD)
            .AddArc(PaddingLR, Me.Height - 2 * r - PaddingUD, 2 * r, 2 * r, 90, 90)
            .CloseFigure()
        End With
        Return BorderPath
    End Function




    Private Function EllipsePath(PaddingLR As Single, PaddingUD As Single) As GraphicsPath
        Dim BorderPath As New GraphicsPath
        With BorderPath
            .AddEllipse(PaddingLR, PaddingUD, Me.Width - PaddingLR * 2, Me.Height - PaddingUD * 2)
        End With
        Return BorderPath
    End Function

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
        '
        'Chao_Button
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Name = "Chao_Button"
        Me.Size = New System.Drawing.Size(160, 70)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Timer1 As Timer
End Class
