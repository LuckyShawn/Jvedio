Imports System.Data.OleDb
Imports System.Windows.Forms
Imports ShareClass.ChaoSub
Imports System.Reflection
Public Class DataBase

    Private con_ConnectionString_read As String
    Private _ConnectionString As String


    Property con_ConnectionString As String
        Get
            Return _ConnectionString
        End Get
        Set
            _ConnectionString = Value
        End Set
    End Property

    Private con As OleDbConnection
    Private cmd As OleDbCommand
    Private da As OleDbDataAdapter
    Private dr As OleDbDataReader

    Sub New(CommandText As String)
        Me.con_ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\mdb\MainDatabase.mdb"
        Me.con_ConnectionString_read = Me.con_ConnectionString & ";Mode=Read"
        con = New OleDbConnection With {.ConnectionString = con_ConnectionString}
        cmd = New OleDbCommand With {.CommandText = CommandText}
        da = New OleDbDataAdapter
        con.Open()
        cmd.Connection = con
        cmd.CommandText = CommandText
    End Sub


    Public Function IsTableExist(Table As String) As Boolean
        Try
            cmd.CommandText = "select * from " & Table
            da.UpdateCommand = cmd
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Console.WriteLine("message={0},CommandText={1}", ex.Message, cmd.CommandText)
            con.Close()
            Return False
        End Try
        '存在该表
        con.Close()
        Return True
    End Function



    Public Function GetIDList(SL As List(Of Integer)) As List(Of Integer)
        Dim i As Integer = 0
        Dim result As New List(Of Integer)
        dr = cmd.ExecuteReader() '执行OLEDB命令以ExecuteReader()方式，并返回一个OLEDBReader，赋值给dr
        While (dr.Read)
            For Each item In SL
                If i = item Then
                    result.Add(Int(dr.Item(0).ToString))
                End If
            Next
            i += 1
        End While
        dr.Close()
        con.Close()
        Return result
    End Function

    Public Function GetTotalCount() As Double
        Dim result As Double = 0
        dr = cmd.ExecuteReader() '执行OLEDB命令以ExecuteReader()方式，并返回一个OLEDBReader，赋值给dr
        While (dr.Read)
            result = CType(dr.Item(0).ToString, Double)
        End While
        dr.Close()
        con.Close()
        Return result
    End Function

    Public Sub UpdateCommand(Optional CmdText As String = "")
        If CmdText <> "" Then cmd.CommandText = CmdText
        da.UpdateCommand = cmd
        cmd.ExecuteNonQuery()
    End Sub

    Public Sub Dispose()
        If con IsNot Nothing Then con.Close()
    End Sub


    Public Function GetVedio() As Vedio
        Dim VI As New Vedio
        Try
            dr = cmd.ExecuteReader
            While (dr.Read)
                VI.num = dr.Item("num").ToString
                VI.actorthumb = dr.Item("actorthumb").ToString
                VI.fanart = dr.Item("fanart").ToString
                VI.Pic_S = dr.Item("Pic_S").ToString
                VI.Pic_B = dr.Item("Pic_B").ToString
            End While
            dr.Close()
        Catch ex As Exception
            Console.WriteLine("message={0},CommandText={1}", ex.Message, cmd.CommandText)
        End Try


        con.Close()
        Return VI

    End Function

    Public Function GetAllVedio() As List(Of Vedio)
        Dim VIList As New List(Of Vedio)
        Dim VI As New Vedio
        Try
            dr = cmd.ExecuteReader
            While (dr.Read)
                VI.num = dr.Item("num").ToString
                VI.actorthumb = dr.Item("actorthumb").ToString
                VI.fanart = dr.Item("fanart").ToString
                VI.Pic_S = dr.Item("Pic_S").ToString
                VI.Pic_B = dr.Item("Pic_B").ToString
                VIList.Add(VI)
            End While
            dr.Close()
        Catch ex As Exception
            Console.WriteLine("message={0},CommandText={1}", ex.Message, cmd.CommandText)
        End Try
        con.Close()
        Return VIList

    End Function


    Public Function GetAllVedioInfo() As List(Of VedioInfo)
        Dim VIList As New List(Of VedioInfo)
        Dim VI As New VedioInfo
        dr = cmd.ExecuteReader
        While (dr.Read)
            VI.ID = CType(dr.Item("ID").ToString, Double)
            VI.fanhao = UCase(dr.Item("fanhao").ToString)
            VI.mingcheng = Juncode(dr.Item("mingcheng").ToString)
            VI.shipinleixing = CType(dr.Item("shipinleixing").ToString, Integer)
            VI.wenjiandaxiao = CType(dr.Item("wenjiandaxiao").ToString, Double)
            VI.weizhi = dr.Item("weizhi").ToString
            VI.daorushijian = dr.Item("daorushijian").ToString
            VI.faxingriqi = dr.Item("faxingriqi").ToString
            If dr.Item("fangwencishu").ToString = "" Then
                VI.fangwencishu = 0
            Else
                VI.fangwencishu = Int(dr.Item("fangwencishu"))
            End If
            VI.faxingriqi = dr.Item("faxingriqi").ToString
            If dr.Item("changdu").ToString = "" Then
                VI.changdu = 0
            Else
                VI.changdu = Int(dr.Item("changdu"))
            End If
            VI.zhizuoshang = Juncode(dr.Item("zhizuoshang").ToString)
            VI.faxingshang = Juncode(dr.Item("faxingshang").ToString)
            VI.daoyan = Juncode(dr.Item("daoyan").ToString)
            VI.leibie = Juncode(dr.Item("leibie").ToString)
            VI.yanyuan = Juncode(dr.Item("yanyuan").ToString)
            VI.xilie = Juncode(dr.Item("xilie").ToString)
            If dr.Item("love").ToString = "" Then
                VI.love = 0
            Else
                VI.love = Int(dr.Item("love"))
            End If
            VI.biaoqian = Juncode(dr.Item("biaoqian").ToString)
            VIList.Add(VI)
        End While
        dr.Close()
        con.Close()
        Return VIList

    End Function

    Public Function GetVedioInfo() As VedioInfo
        Dim VI As New VedioInfo
        dr = cmd.ExecuteReader
        While (dr.Read)
            VI.ID = CType(dr.Item("ID").ToString, Double)
            VI.fanhao = UCase(dr.Item("fanhao").ToString)
            VI.mingcheng = Juncode(dr.Item("mingcheng").ToString)
            VI.shipinleixing = CType(dr.Item("shipinleixing").ToString, Integer)
            VI.wenjiandaxiao = CType(dr.Item("wenjiandaxiao").ToString, Double)
            VI.weizhi = dr.Item("weizhi").ToString
            VI.daorushijian = dr.Item("daorushijian").ToString
            VI.faxingriqi = dr.Item("faxingriqi").ToString
            If dr.Item("fangwencishu").ToString = "" Then
                VI.fangwencishu = 0
            Else
                VI.fangwencishu = Int(dr.Item("fangwencishu"))
            End If
            VI.faxingriqi = dr.Item("faxingriqi").ToString
            If dr.Item("changdu").ToString = "" Then
                VI.changdu = 0
            Else
                VI.changdu = Int(dr.Item("changdu"))
            End If
            VI.zhizuoshang = Juncode(dr.Item("zhizuoshang").ToString)
            VI.faxingshang = Juncode(dr.Item("faxingshang").ToString)
            VI.daoyan = Juncode(dr.Item("daoyan").ToString)
            VI.leibie = Juncode(dr.Item("leibie").ToString)
            VI.yanyuan = Juncode(dr.Item("yanyuan").ToString)
            VI.xilie = Juncode(dr.Item("xilie").ToString)
            If dr.Item("love").ToString = "" Then
                VI.love = 0
            Else
                VI.love = Int(dr.Item("love"))
            End If
            VI.biaoqian = Juncode(dr.Item("biaoqian").ToString)
        End While
        dr.Close()
        con.Close()
        Return VI

    End Function


    Public Function GetAllInfo(Info As String) As List(Of String)
        Dim result As New List(Of String)
        dr = cmd.ExecuteReader() '执行OLEDB命令以ExecuteReader()方式，并返回一个OLEDBReader，赋值给dr
        While (dr.Read)
            result.Add(dr.Item(Info).ToString)
        End While
        dr.Close()
        con.Close()
        Return result
    End Function



    Public Function GetInfo(Info As String) As String
        Dim result As String = ""
        dr = cmd.ExecuteReader() '执行OLEDB命令以ExecuteReader()方式，并返回一个OLEDBReader，赋值给dr
        While (dr.Read)
            result = dr.Item(Info).ToString
        End While
        dr.Close()
        con.Close()
        Return result
    End Function



End Class
