<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Chao_FluidPanel
    Inherits Panel

    'UserControl 重写释放以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New System.ComponentModel.Container()
    End Sub


    Public Sub New()
        MyBase.New()
        Me.SetStyle(ControlStyles.UserPaint, True)
        Me.SetStyle(ControlStyles.AllPaintingInWmPaint, True)
        Me.SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
    End Sub

    Protected Overrides Sub OnScroll(ByVal se As ScrollEventArgs)
        Me.Invalidate()
        MyBase.OnScroll(se)
    End Sub

    Private Const WM_HSCROLL As Integer = &H114
    Private Const WM_VSCROLL As Integer = &H115
    Protected Overrides Sub WndProc(ByRef m As Message)
        If (m.Msg = WM_HSCROLL OrElse m.Msg = WM_VSCROLL) AndAlso (CInt(m.WParam) And &HFFFF) = 5 Then
            ' Change SB_THUMBTRACK to SB_THUMBPOSITION
            m.WParam = CType(CInt(m.WParam) And Not &HFFFF Or 4, IntPtr)
        End If

        MyBase.WndProc(m)
    End Sub

    Protected Overrides ReadOnly Property CreateParams As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or &H2000000
            Return cp
        End Get
    End Property

    Delegate Sub DelegateAnimation()

    Public Sub AnimationChanged()
        Me.AutoScroll = False
        Dim BeforeMove As New List(Of Point)
        For i = 0 To Me.Controls.Count - 1 Step 1
            BeforeMove.Add(Me.Controls.Item(i).Location)
        Next

        Dim AfterMove As New List(Of Point)
        If Me.Controls.Count > 0 Then AfterMove.Add(New Point(10, 10))
        If Me.Controls.Count > 1 Then
            Dim x As Single = 10 : Dim y As Single = 10
            Dim RowNumOne As Boolean = True
            For i = 1 To Me.Controls.Count - 1
                x = AfterMove(i - 1).X + Me.Controls.Item(i - 1).Width + 10
                If x + Me.Controls.Item(i).Width - 10 >= Me.Width Then
                    x = 10
                End If
                y = 10
                RowNumOne = True
                For j = i - 1 To 0 Step -1
                    If AfterMove(j).X = x Then
                        y = AfterMove(j).Y + Me.Controls.Item(j).Height + 10
                        RowNumOne = False
                        Exit For
                    End If
                Next
                If RowNumOne Then y = 10
                AfterMove.Add(New Point(x, y))
            Next
        End If

        ''动画
        Task.Run(Sub()
                     If Me.IsHandleCreated Then
                         Me.Invoke(New DelegateAnimation(Sub()

                                                             For Each item In Me.Controls
                                                                 Dim P1 As Point = item.Location
                                                                 Dim P2 As Point = AfterMove(Me.Controls.IndexOf(item))
                                                                 Dim Vx, Vy As Single
                                                                 Dim Speed As Single = 10
                                                                 Vx = (P2.X - P1.X) / Speed
                                                                 Vy = (P2.Y - P1.Y) / Speed
                                                                 For j = 0 To Speed Step 1
                                                                     If Math.Abs(item.Left - P2.X) <= Speed / 2 Then
                                                                         item.Left = P2.X
                                                                     Else
                                                                         item.Left = item.Left + Vx
                                                                     End If
                                                                     If Math.Abs(item.Top - P2.Y) <= Speed / 2 Then
                                                                         item.Top = P2.Y
                                                                     Else
                                                                         item.Top = item.Top + Vy
                                                                     End If
                                                                     Application.DoEvents()
                                                                 Next
                                                             Next
                                                             Me.AutoScroll = True
                                                         End Sub)）
                     End If
                 End Sub)
    End Sub



    Public Sub Changed()
        Dim BeforeMove As New List(Of Point)
        For i = 0 To Me.Controls.Count - 1 Step 1
            BeforeMove.Add(Me.Controls.Item(i).Location)
        Next

        Dim AfterMove As New List(Of Point)
        If Me.Controls.Count > 0 Then Me.Controls.Item(0).Location = New Point(10, 10)
        If Me.Controls.Count > 1 Then
            Dim x As Single = 10 : Dim y As Single = 10
            Dim RowNumOne As Boolean = True
            For i = 1 To Me.Controls.Count - 1
                x = Me.Controls.Item(i - 1).Left + Me.Controls.Item(i - 1).Width + 10
                If x + Me.Controls.Item(i).Width - 10 >= Me.Width Then
                    x = 10
                End If
                y = 10
                RowNumOne = True
                For j = i - 1 To 0 Step -1
                    If Me.Controls.Item(j).Left = x Then
                        y = Me.Controls.Item(j).Top + Me.Controls.Item(j).Height + 10
                        RowNumOne = False
                        Exit For
                    End If
                Next
                If RowNumOne Then y = 10
                Me.Controls.Item(i).Location = New Point(x, y)
            Next
        End If
    End Sub

    Protected Overrides Sub OnResize(eventargs As EventArgs)
        MyBase.OnResize(eventargs)
        If DesignMode Then
            Changed()
        End If

    End Sub


    Private Sub Chao_Panel_ControlAdded(sender As Object, e As ControlEventArgs) Handles Me.ControlAdded
        Changed()
    End Sub

End Class
