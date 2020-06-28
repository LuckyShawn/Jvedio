
public void LoadSetupInfomation()
{

    // 骑兵
    // Dim sr As IO.StreamReader = New IO.StreamReader(Application.StartupPath & "\Data\Qibing.txt")
    // Dim tempqibing = Split(Replace(sr.ReadToEnd, "，", ","), ",")
    // sr.Close()
    // For Each item In tempqibing
    // If item <> "" Then
    // Qibing.Add(item)
    // End If
    // Next

    // '步兵
    // Dim tempbubing = Split(Replace(BubingFanhao, "，", ","), ",")
    // For Each item In tempbubing
    // If item <> "" Then
    // Bubing.Add(item)
    // End If
    // Next

    // 视频后缀
    var temp = global::Microsoft.VisualBasic.Strings.Split(global::Jvedio.Module_Variable.Scan_Shipinleixing, ",");
    global::Jvedio.Module_Variable.SearchPattern = new global::System.String[(temp.Count())];
    for (global::System.Int32 i = 0, loopTo = ((temp.Count()) - (1)); i <= loopTo; i += 1)
        global::Jvedio.Module_Variable.SearchPattern[i] = ("*." + temp[i]);
    this.Label12.Text = global::Jvedio.Module_Settings.Settings.SortType;
    this.Label13.Text = Conversions.ToString(global::Microsoft.VisualBasic.Interaction.IIf(global::Jvedio.Module_Settings.Settings.SortDesc, "↓", "↑"));
    global::Jvedio.Module_Variable.global_Backcolor = new global::System.Drawing.Color[] { global::System.Drawing.Color.FromArgb(57, 61, 64), global::System.Drawing.Color.FromArgb(80, 80, 80) };
    global::Jvedio.Module_Variable.global_Forecolor = new global::System.Drawing.Color[] { global::System.Drawing.Color.FromArgb(148, 149, 153), global::System.Drawing.Color.FromArgb(160, 160, 160) };
    global::Jvedio.Module_Variable.EditMode = this.Chao_CheckBox1.Checked;
    this.Chao_CheckBox2.Checked = global::Jvedio.Module_Settings.Settings.ShowPlay;
    // 代理
    global::Jvedio.Module_Function.SetProxy();
}
