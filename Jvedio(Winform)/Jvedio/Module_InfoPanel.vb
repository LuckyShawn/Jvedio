Imports System.IO
Imports ShareClass.ChaoSub

Module Module_InfoPanel

    Public Class InfoPanel

        Public Panel As New Panel
        Dim PicBox As New PictureBox
        Dim StampPicB As New PictureBox
        Dim FlowPanel As New FlowLayoutPanel
        Dim MingchengTB As New TextBox
        Dim FanhaoTB As New TextBox
        Dim FaxingRiqiTB As New TextBox
        Dim PlayButton As New PictureBox
        Dim LovePicbox As New PictureBox



        Public LoveIndex As Integer
        Private Mingcheng As String
        Private Fanhao As String
        Private FaxingRiqi As String
        Private ID As Double
        Private Pic As Image
        Private CMSLove As ContextMenuStrip
        Private StampContent As String

        Sub New(VedioInfo As ShareClass.Variable.VedioInfo, CMS As ContextMenuStrip)
            Me.Mingcheng = VedioInfo.mingcheng
            Me.Fanhao = VedioInfo.fanhao
            Me.ID = VedioInfo.ID
            Me.LoveIndex = VedioInfo.love
            Dim PicPath As String = ""
            If Settings.FormMainShowBigPic Then
                PicPath = BigPicSavePath & "\" & VedioInfo.fanhao & ".jpg"
            Else
                PicPath = SmallPicSavePath & "\" & VedioInfo.fanhao & ".jpg"
            End If
            Me.Pic = GetImage(PicPath)
            Me.CMSLove = CMS
            Me.StampContent = GetStampContent(VedioInfo.love, VedioInfo.weizhi)
            Initial()
        End Sub
        Sub Initial()
            With PicBox
                .Image = Pic
                If Settings.FormMainShowBigPic Then
                    .Width = 400
                    .Height = 250
                Else
                    .Width = 150
                    .Height = 200
                End If
                If Settings.MainFormPicAutoSize Then
                    .SizeMode = PictureBoxSizeMode.AutoSize
                Else
                    .SizeMode = PictureBoxSizeMode.Zoom
                End If
                '.Cursor = Windows.Forms.Cursors.Hand
                .Location = New Point(10, 10)
                .Name = "PicBox_" & Fanhao
                AddHandler .MouseMove, AddressOf Picbox_MouseMove
                AddHandler .MouseDown, AddressOf Picbox_MouseDown
                AddHandler .MouseEnter, AddressOf Picbox_MouseEnter
            End With



            With PlayButton
                .Parent = PicBox
                .Image = My.Resources.Resource_Image.Play
                .SizeMode = PictureBoxSizeMode.AutoSize
                .Cursor = Windows.Forms.Cursors.Hand
                .Name = "myPlayButton_" & Fanhao
                .BackColor = Color.Transparent
                .Left = (PicBox.Width - .Width) / 2
                .Top = (PicBox.Height - .Height) / 2
                .BringToFront()
                .Visible = False
                AddHandler .Click, AddressOf myPlayButton_MouseDown
            End With


            With LovePicbox
                .Parent = PicBox
                .Name = LoveIndex & "LovePicbox_" & Fanhao
                If LoveIndex > 0 Then
                    .Image = My.Resources.Resource_Image._Like
                Else
                    .Image = My.Resources.Resource_Image.UnLike
                End If
                .SizeMode = PictureBoxSizeMode.AutoSize
                .Cursor = Windows.Forms.Cursors.Hand
                .Left = PicBox.Width - .Width
                .Top = PicBox.Height - .Height
                .BackColor = Color.Transparent
                .Visible = False
                AddHandler LovePicbox.MouseDown, AddressOf LovePicbox_MouseDown
            End With






            With MingchengTB
                '.Visible = IIf(Mingcheng <> "", True, False)
                .Font = SmallPicMingcheng
                .Name = "MingchengTB_" & Fanhao

                .BackColor = GetRelativeColor(New ShareClass.Skin(Settings.SkinStyle).BC1, 5)
                '.BackColor = Color.Transparent
                .ForeColor = global_Forecolor(0)
                .BorderStyle = BorderStyle.None
                .ReadOnly = True
                .Enabled = Not EditMode
                .Multiline = True
                .Text = Mingcheng
                .TextAlign = HorizontalAlignment.Center
                .Width = PicBox.Width
                .Height = GetTextBoxHeight(.Text, .Font) * (.GetLineFromCharIndex(.TextLength) + 1)
            End With



            With FanhaoTB
                '.Visible = IIf(Fanhao <> "", True, False)
                .Font = SmallPicFanhao
                .Name = "FanhaoTB_" & Fanhao
                .BackColor = GetRelativeColor(New ShareClass.Skin(Settings.SkinStyle).BC1, 5)
                '.BackColor = Color.Transparent
                .ForeColor = global_Forecolor(0)
                .BorderStyle = BorderStyle.None
                .ReadOnly = True
                .Enabled = Not EditMode
                .Multiline = True
                .Text = Fanhao
                .TextAlign = HorizontalAlignment.Center
                .Width = PicBox.Width
                .Height = GetTextBoxHeight(.Text, .Font) * (.GetLineFromCharIndex(.TextLength) + 1)
            End With
            '错误收集：
            '描述，当数据很多的时候点击所有视频会出错


            With FaxingRiqiTB
                '.Visible = IIf(FaxingRiqi <> "", True, False)
                .Font = SmallPicRiqi
                .Name = "FaxingRiqiTB_" & Fanhao
                .BackColor = GetRelativeColor(New ShareClass.Skin(Settings.SkinStyle).BC1, 5)
                '.BackColor = Color.Transparent
                .ForeColor = global_Forecolor(0)
                .BorderStyle = BorderStyle.None
                .ReadOnly = True
                .Enabled = Not EditMode
                .Multiline = True
                .Text = FaxingRiqi
                .TextAlign = HorizontalAlignment.Center
                .Width = PicBox.Width
                .Height = GetTextBoxHeight(.Text, .Font) * (.GetLineFromCharIndex(.TextLength) + 1)
            End With

            With FlowPanel
                .Left = PicBox.Left
                .Top = PicBox.Top + PicBox.Height + 5
                .Width = PicBox.Width
                .Height = 0
                '.BackColor = global_Backcolor(1)
                .BackColor = Color.Transparent
                .Name = "FlowPanel_" & Fanhao & ";" & ID
                If Settings.ShowMingCheng Then .Controls.Add(MingchengTB)
                If Settings.ShowFanhao Then .Controls.Add(FanhaoTB)
                If Settings.ShowDate Then .Controls.Add(FaxingRiqiTB)
                For Each item In FlowPanel.Controls
                    FlowPanel.Height = FlowPanel.Height + item.height
                Next
                .Height = .Height + 20
            End With

            Dim StampPicBPath As New System.Drawing.Drawing2D.GraphicsPath
            With StampPicBPath
                .AddLine(60, 0, 120, 0)
                .AddLine(120, 0, 0, 120)
                .AddLine(0, 120, 0, 60)
                .CloseFigure()
            End With



            With Panel
                '.BackColor = global_Backcolor(1)
                .BackColor = GetRelativeColor(New ShareClass.Skin(Settings.SkinStyle).BC1, 5)
                .Padding = New Padding(5)
                .Margin = New Padding(2)
                .Controls.Add(StampPicB)
                .Controls.Add(FlowPanel)
                .Controls.Add(PicBox)
                .Name = "Panel_" & Fanhao
                .Width = PicBox.Width + 20
                .Height = PicBox.Top + PicBox.Height + FlowPanel.Height + 10
                AddHandler Panel.MouseEnter, AddressOf Panel_MouseMove
                AddHandler Panel.Paint, AddressOf Panel_Paint
            End With

            With StampPicB
                If Not Settings.ShowStamp Then .Visible = False
                If StampContent = "" Then .Visible = False
                .Width = 150
                .Height = 150
                .Location = New Point(0, 0)
                .Name = "StampPicB_" & Fanhao
                .Image = DrawStampPicB(StampPicB, StampContent, New Font("微软雅黑", 10, FontStyle.Bold))
                .Region = New Region(StampPicBPath)
                .BackColor = Color.Red
            End With

            PicBox.SendToBack()
            StampPicB.BringToFront()

        End Sub




        Private Function GetStampContent(Lv As String, Path As String) As String
            'Return "高清视频"
            Dim result As String = ""
            If IO.File.Exists(Path) Then
                Dim VedioLength = New FileInfo(Path).Length
                If VedioLength / 1024 / 1024 > 2 Then       '超过 2G
                    result = "高清视频"
                End If
            Else
                If Lv > 0 Then
                    result = "我的喜爱"
                End If
            End If
            Return result
        End Function



        Private Function DrawStampPicB(ByRef PicB As PictureBox, Content As String, Font As Font) As Bitmap
            Dim TextColor As Color
            Select Case Content
                Case "高清视频"
                    PicB.BackColor = Color.FromArgb(128, 191, 255)
                    TextColor = Color.FromArgb(18, 109, 122)
                Case Else
                    PicB.BackColor = Color.FromArgb(255, 215, 0)
                    TextColor = Color.FromArgb(0, 96, 100)
            End Select



            Dim bmp As New Bitmap(PicB.Width, PicB.Height)
            Dim g As Graphics = Graphics.FromImage(bmp)
            g.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
            g.Clear(PicB.BackColor)
            g.RotateTransform(-45)
            g.TextRenderingHint = Drawing.Text.TextRenderingHint.AntiAlias
            g.DrawString(Content, Font, New SolidBrush(TextColor), New Point(-37, 55))

            Return bmp
        End Function

        Sub Panel_MouseMove()
            If EditMode Then Exit Sub
            PlayButton.Visible = False
            LovePicbox.Visible = False
        End Sub





        Sub Picbox_MouseDown(sender As Object, e As MouseEventArgs)
            GlobalID = GetIDFromPicBox(sender)
            GlobalFanhao = New ShareClass.DataBase("select * from Main where ID=" & GlobalID).GetInfo("fanhao")
            If EditMode Then
                If e.Button = MouseButtons.Right Then
                    FormMain.FUN_CMS.Show(FormMain.MousePosition.X, FormMain.MousePosition.Y)
                ElseIf e.Button = MouseButtons.Left Then
                    If EditList.Contains(ID) Then
                        EditList.Remove(ID)
                    Else
                        EditList.Add(ID)
                    End If
                    Panel.Invalidate()

                End If
                Exit Sub
            End If

            If e.Button = MouseButtons.Right Then
                EditList.Clear()
                EditList.Add(ID)
                FormMain.FUN_CMS.Show(FormMain.MousePosition.X, FormMain.MousePosition.Y)
            ElseIf e.Button = MouseButtons.Left Then
                If Settings.ShowDefaultInfo Then
                    If FormInfo.Visible Then
                        FormInfo.Close()
                    End If
                    FormInfo.Show()
                    FormInfo.Activate()
                Else
                    If FormBus.Visible Then
                        FormBus.Close()
                    End If
                    FormBus.Show()
                    FormBus.Activate()
                End If

            End If
        End Sub


        Private Sub Picbox_MouseMove(sender As Object, e As MouseEventArgs)
            If EditMode Then

            Else
                PlayButton.BringToFront()
                PlayButton.Visible = True
                LovePicbox.Visible = True
            End If

        End Sub




        Private Sub Panel_Paint(sender As Object, e As PaintEventArgs)
            If EditMode Then
                Dim p As Panel = sender
                Dim ID As Double = GetIDFromPanel(sender)
                If Panel_PicboxMouseEnter Then

                    If ID <> GlobalID Then
                        p.CreateGraphics.Clear(p.BackColor)
                    Else
                        If Not EditList.Contains(ID) Then
                            p.CreateGraphics.Clear(p.BackColor)
                            p.CreateGraphics.DrawRectangle(New Pen(Color.Red, 4), New Rectangle(0, 0, p.Width, p.Height))
                        End If
                    End If
                End If

                If EditList.Contains(ID) Then
                    p.CreateGraphics.Clear(p.BackColor)
                    p.CreateGraphics.DrawRectangle(New Pen(Color.FromArgb(255, 215, 0), 4), New Rectangle(0, 0, p.Width, p.Height))
                End If

            End If
        End Sub

        Sub Picbox_MouseEnter(sender As Object, e As EventArgs)
            GlobalID = GetIDFromPicBox(sender)
            GlobalFanhao = New ShareClass.DataBase("select * from Main where ID=" & GlobalID).GetInfo("fanhao")
            If EditMode Then
                For Each item In FormMain.Chao_FlowLayoutPanel1.Controls
                    Panel_PicboxMouseEnter = True
                    Dim Panel As Panel = item
                    Panel.Invalidate()
                Next

            Else

                For Each item In FormMain.Chao_FlowLayoutPanel1.Controls
                    If item.GetType.ToString = "System.Windows.Forms.Panel" Then
                        Dim mypanel As New Panel
                        mypanel = item
                        For Each item1 In mypanel.Controls
                            If item1.GetType.ToString = "System.Windows.Forms.PictureBox" Then
                                Dim myPicbox As New PictureBox
                                myPicbox = item1
                                If InStr(myPicbox.Name, "PicBox_") > 0 Then
                                    For Each item2 In myPicbox.Controls
                                        item2.visible = False
                                    Next
                                    GoTo FP1
                                End If
                            End If
                        Next
                    End If
FP1:
                Next
            End If


        End Sub

        Sub LovePicbox_MouseDown(sender As Object, e As MouseEventArgs)

            GlobalID = GetIDFromPicBox(sender.parent)
            GlobalFanhao = New ShareClass.DataBase("select * from Main where ID=" & GlobalID).GetInfo("fanhao")


            Dim PicB As PictureBox = sender
            LovePicBTemp = sender
            Dim p As New Point()
            p.X = System.Windows.Forms.Control.MousePosition.X - CMSLove.Width / 2
            p.Y = System.Windows.Forms.Control.MousePosition.Y + 20
            CMSLove.Show(p)
            For Each item In CMSLove.Items
                If Int(item.text) = Strings.Left(sender.name, 1) Then
                    item.checked = True
                Else
                    item.checked = False
                End If
            Next
        End Sub




        Public Sub myPlayButton_MouseDown(sender As Object, e As MouseEventArgs)
            GlobalID = GetIDFromPicBox(sender.parent)
            GlobalFanhao = New ShareClass.DataBase("select * from Main where ID=" & GlobalID).GetInfo("fanhao")

            If e.Button = MouseButtons.Left Then

                Dim weizhi = New ShareClass.DataBase("select * from Main where ID=" & GlobalID).GetInfo("weizhi")
                If IO.File.Exists(weizhi) Then
                    Try
                        Process.Start(weizhi)
                    Catch ex As Exception
                        MsgBox("打开失败，杀毒软件阻止",, "提示")
                    End Try

                Else
                    MsgBox("文件不存在",, "文件不存在")
                End If
            End If
        End Sub

    End Class

End Module
