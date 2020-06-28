
Imports System.Data.OleDb
Imports System.Windows.Forms
Public Class Access


    ''' <summary>
    ''' 在已有的mdb中创建数据表
    ''' </summary>
    Public Shared Sub CreateAccessTable(ADOX_Table_Name As String, Optional Format As Boolean = False)

        'If New ShareClass.DataBase("").IsTableExist(ADOX_Table_Name) Then Exit Sub

        Dim con_ConnectionString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\mdb\MainDatabase.mdb"

        Dim ADODB_Connection As ADODB.Connection = New ADODB.Connection()
        ADODB_Connection.Open(con_ConnectionString)

        Dim ADOX_Table As ADOX.Table = New ADOX.Table() With {.Name = ADOX_Table_Name}
        Dim ADOX_Catalog As ADOX.Catalog = New ADOX.Catalog() With {.ActiveConnection = ADODB_Connection}
        ADOX_Catalog.Tables.Append(ADOX_Table)

        Dim ADOX_Column As New ADOX.Column
        With ADOX_Column
            .Name = "ID"
            .Type = ADOX.DataTypeEnum.adInteger
            .ParentCatalog = ADOX_Catalog '要先关联 cat 才能设置 AutoIncrement'
            .Properties("AutoIncrement").Value = True
            ADOX_Table.Columns.Append(ADOX_Column)
        End With

        If Format Then
            ADOX_ColumnAdd("num", ADOX.DataTypeEnum.adLongVarWChar, ADOX_Table)
            ADOX_ColumnAdd("actorthumb", ADOX.DataTypeEnum.adLongVarWChar, ADOX_Table)
            ADOX_ColumnAdd("fanart", ADOX.DataTypeEnum.adLongVarWChar, ADOX_Table)
            ADOX_ColumnAdd("Pic_S", ADOX.DataTypeEnum.adLongVarWChar, ADOX_Table)
            ADOX_ColumnAdd("Pic_B", ADOX.DataTypeEnum.adLongVarWChar, ADOX_Table)
        Else
            ADOX_ColumnAdd("fanhao", ADOX.DataTypeEnum.adWChar, ADOX_Table)
            ADOX_ColumnAdd("mingcheng", ADOX.DataTypeEnum.adLongVarWChar, ADOX_Table)
            ADOX_ColumnAdd("wenjiandaxiao", ADOX.DataTypeEnum.adDouble, ADOX_Table)
            ADOX_ColumnAdd("weizhi", ADOX.DataTypeEnum.adWChar, ADOX_Table)
            ADOX_ColumnAdd("shipinleixing", ADOX.DataTypeEnum.adInteger, ADOX_Table)
            ADOX_ColumnAdd("daorushijian", ADOX.DataTypeEnum.adWChar, ADOX_Table)
            ADOX_ColumnAdd("fangwencishu", ADOX.DataTypeEnum.adInteger, ADOX_Table)
            ADOX_ColumnAdd("faxingriqi", ADOX.DataTypeEnum.adWChar, ADOX_Table)
            ADOX_ColumnAdd("changdu", ADOX.DataTypeEnum.adInteger, ADOX_Table)
            ADOX_ColumnAdd("zhizuoshang", ADOX.DataTypeEnum.adLongVarWChar, ADOX_Table)
            ADOX_ColumnAdd("faxingshang", ADOX.DataTypeEnum.adLongVarWChar, ADOX_Table)
            ADOX_ColumnAdd("daoyan", ADOX.DataTypeEnum.adLongVarWChar, ADOX_Table)
            ADOX_ColumnAdd("leibie", ADOX.DataTypeEnum.adLongVarWChar, ADOX_Table)
            ADOX_ColumnAdd("yanyuan", ADOX.DataTypeEnum.adLongVarWChar, ADOX_Table)
            ADOX_ColumnAdd("xilie", ADOX.DataTypeEnum.adLongVarWChar, ADOX_Table)
            ADOX_ColumnAdd("love", ADOX.DataTypeEnum.adInteger, ADOX_Table)
            ADOX_ColumnAdd("biaoqian", ADOX.DataTypeEnum.adWChar, ADOX_Table)
        End If


        ADOX_Table.Keys.Append("ID", ADOX.KeyTypeEnum.adKeyPrimary, "ID")


        '关闭连接
        Dim connection = ADOX_Catalog.ActiveConnection
        connection.Close()
        System.Runtime.InteropServices.Marshal.ReleaseComObject(connection)
        System.Runtime.InteropServices.Marshal.ReleaseComObject(ADOX_Catalog)
        GC.Collect()

    End Sub



    Public Shared Sub CreateAccessMdb()
        Dim con_ConnectionString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\mdb\MainDatabase.mdb"

        Dim ADOX_Catalog As ADOX.Catalog = New ADOX.Catalog
        Try
            ADOX_Catalog.Create(con_ConnectionString)

        Catch ex As Exception
        End Try
    End Sub
    Public Shared Sub ADOX_ColumnAdd(name As String, t As Object, ADOX_Table As ADOX.Table)
        Dim ADOX_Column = New ADOX.Column
        With ADOX_Column
            .Name = name
            .Type = t
            '.DefinedSize = 7
            .Attributes = ADOX.ColumnAttributesEnum.adColNullable
            ADOX_Table.Columns.Append(ADOX_Column)
        End With
    End Sub

End Class
