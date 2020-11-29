
Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class sqlDBM
    Private myConn As SqlConnection
    Private myCom As SqlCommand
    Private myAdapter As SqlDataAdapter
    'Private myReader As SqlDataReader
    Private myDS As DataSet
    Private dbAdapterFlag As Boolean = False
    Private dbReaderFlag As Boolean = False
    Private dbstr As String
    '
    Private dbOpenFlag As Boolean = False
    Private sqlAdapter As SqlDataAdapter
    Private sqlDS As DataSet
    Private sqlDT As Object
    Private myReader As Object

    'basic_function--------------------------------------------------------------------------------------------------------------
    Public Sub dbconn()
        dbstr = "Data Source=(local);Initial Catalog=gym_test;Integrated Security=True"
        Try
            myConn = New SqlConnection(dbstr)
            myConn.Open()
            dbOpenFlag = True
            'MsgBox("connected")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub get_notification(ByRef ds As DataSet)
        select_table(ds, "notification")
        '按时间排序
        'MsgBox(ds.Tables("notification").Rows(0).Item(1))
        'ds.Tables("PlaneDt").DefaultView.Sort = "价钱 DESC"
        'Dg.DataSource = PlaneDs.Tables("PlaneDt")
        'Dg.Refresh()
    End Sub
    Function loginCheck(ByVal id1 As String, ByVal id2 As String) As Boolean
        Dim str As String, b As Boolean
        str = "Select * from  account where accountID=" & id1 & " and password=" & id2
        Dim theR As SqlDataReader
        Try
            myCom = New SqlCommand(str, myConn)
            theR = myCom.ExecuteReader()
        Catch
            Return False
        End Try
        If theR.HasRows Then
            b = True
        Else
            b = False
        End If
        'theR.Dispose()
        Return b
    End Function
    Public Sub select_table(ByRef ds As DataSet, ByVal table_name As String)
        If dbOpenFlag = False Then
            MsgBox("Please connect to the database first")
            Return
        End If
        Try
            myCom = New SqlCommand("Select * from " & table_name, myConn)
            myAdapter = New SqlDataAdapter
            myAdapter.SelectCommand = myCom
            myAdapter.Fill(ds, table_name)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Function get_username() As String
        Dim strSQL As String = "select name from users, where userID=" & accountID
        Dim cmd As New SqlCommand(strSQL, myConn)
        Dim adap As New SqlDataAdapter(cmd)
        Dim ds As New DataSet
        adap.Fill(ds)
        Return ds.Tables(0).Rows(0).Item(0)
    End Function

    Public Sub dbClose()
        myConn.Close()
        dbOpenFlag = False
    End Sub

    'student_function-----------------------------------------------------------------------
    Public Sub all_info()

    End Sub
    Public Sub time_stadium_info(ByRef DataGrid1 As DataGridView, ByVal searchTime As String, ByVal searchStadium As Int16)
        'MsgBox(searchTime)
        Dim strSQL As String = "time_stadium_get"
        Dim cmd As New SqlCommand(strSQL, myConn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@searchTime", SqlDbType.DateTime)
        cmd.Parameters("@searchTime").Value = searchTime 'TextBox1.Text.ToString
        cmd.Parameters("@searchTime").Direction = ParameterDirection.Input
        cmd.Parameters.Add("@searchStadium", SqlDbType.Int)
        cmd.Parameters("@searchStadium").Value = searchStadium 'TextBox2.Text.ToString
        cmd.Parameters("@searchStadium").Direction = ParameterDirection.Input
        Dim adap As New SqlDataAdapter(cmd)
        Dim ds As New DataSet
        adap.Fill(ds, "time_stadium_info")
        DataGrid1.DataSource = ds.Tables("time_stadium_info").DefaultView
    End Sub
    Public Function court_check(ByVal courtID As String, ByVal expectedTime As String) As Boolean
        Dim p As Boolean
        Dim theR As SqlDataReader
        Try
            myCom = New SqlCommand("select * from court_manage where courtID='" & courtID & "' and stoptime < CONVERT(datetime," & expectedTime & " ,120) ", myConn)
            If theR.HasRows Then
                p = False
            End If
        Catch
            p = True
        End Try

        'theR.Dispose()
        Return p
    End Function
    Public Function appointment_check(ByVal courtID As String, ByVal expectedTime As String) As Boolean
        Dim p As Boolean
        Dim theR As SqlDataReader
        Try
            myCom = New SqlCommand("select * from appointment_records 
where courtID=" & courtID & " and expectedTime=" & expectedTime & "", myConn)
            theR = myCom.ExecuteReader()
            If theR.HasRows Then
                p = False
            End If
        Catch
            p = True
        End Try
        'theR.Dispose()
        Return p
    End Function
    Public Sub appointment(ByVal courtID As String, ByVal expectedTime As String)
        Try
            myCom = New SqlCommand("insert into appointment_records values('" & courtID & "','" & accountID & "','" & Now() & "','" & expectedTime & "');", myConn)
            myAdapter = New SqlDataAdapter
            myAdapter.InsertCommand = myCom
            MsgBox("预约成功")
        Catch
            MsgBox("预约失败,请刷新重试")
        End Try
    End Sub
    '    Public Function sharing_check(ByVal courtID As String, ByVal expectedTime As String) As Boolean
    '        Dim p As Boolean
    '        myCom = New SqlCommand("select * from appointment_records, 
    '(select sharing_records.appointmentID appointmentID,
    'sharing_records.maxNum-count(share_application_records.shareID) n_share
    '	from sharing_records left join share_application_records 
    '	on sharing_records.shareID=share_application_records.shareID
    '	group by sharing_records.shareID,sharing_records.appointmentID,sharing_records.maxNum)t1
    'where appointment_records.appointmentID=t1.appointmentID
    'and appointment_records.courtID=" & courtID & " and 
    'appointment_records.expectedTime=" & expectedTime & " and t1.n_share>0 ", myConn)
    '        Dim theR As SqlDataReader
    '        theR = myCom.ExecuteReader()
    '        If theR.HasRows Then
    '            p = True
    '        Else
    '            p = False
    '        End If
    '        theR.Dispose()
    '        Return p
    '    End Function
    '    Public Sub sharing(ByVal courtID As String, ByVal expectedTime As String)
    '        myCom = New SqlCommand("insert into appointment_records values('" & courtID & "','" & accountID & "','" & Now() & "','" & expectedTime & "');", myConn)
    '        myAdapter = New SqlDataAdapter
    '        myAdapter.InsertCommand = myCom
    '    End Sub
    Public Function sharing_application_check(ByVal courtID As String, ByVal expectedTime As String, ByRef shareID As Int16) As Boolean

        Dim p As Boolean
        Dim dt As New DataTable
        Dim theR As SqlDataReader
        Try
            myCom = New SqlCommand("select t1.shareID from appointment_records, 
(select sharing_records.appointmentID appointmentID,sharing_records.shareID shareID,
sharing_records.maxNum-count(share_application_records.shareID) n_share
	from sharing_records left join share_application_records 
	on sharing_records.shareID=share_application_records.shareID
	group by sharing_records.shareID,sharing_records.appointmentID,sharing_records.maxNum)t1
where appointment_records.appointmentID=t1.appointmentID
and appointment_records.courtID=" & courtID & " and 
appointment_records.expectedTime=" & expectedTime & " and t1.n_share>0 ", myConn)
            theR = myCom.ExecuteReader()
            dt.Load(theR)
            If theR.HasRows Then
                p = True
                shareID = dt.Rows(0).Item(0)
            End If
        Catch
            p = False
        End Try
        'theR.Dispose()
        Return p
    End Function
    Public Sub sharing_application(ByVal courtID As String, ByVal expectedTime As String, ByVal shareID As Int16)
        Try
            myCom = New SqlCommand("insert into appointment_records values('" & shareID & "','" & accountID & "','" & Now() & "');", myConn)
            myAdapter = New SqlDataAdapter
            myAdapter.InsertCommand = myCom
            MsgBox("拼场成功")
        Catch
            MsgBox("拼场申请失败,请刷新重试")
        End Try
    End Sub
    Public Function queue_check(ByVal courtID As String, ByVal expectedTime As String) As Int16
        Dim k As Int16
        Dim theR As SqlDataReader
        Dim dt As New DataTable
        Try
            myCom = New SqlCommand("select count(*) from queuing_records where courtID= " & courtID & " and expectedTime= " & expectedTime & " group by courtID ", myConn)
            theR = myCom.ExecuteReader()
            dt.Load(theR)
        Catch
        End Try
        If theR.HasRows Then
            k = dt.Rows(0).Item(0)
        Else
            k = 0
        End If
        'theR.Dispose()
        Return k
    End Function
    Public Sub queue_application(ByVal courtID As String, ByVal expectedTime As String)
        Dim k As Int16 = queue_check(courtID, expectedTime)
        Try
            myCom = New SqlCommand("insert into appointment_records values('" & courtID & "','" & accountID & "','" & Now() & "','" & expectedTime & "');", myConn)
            myAdapter = New SqlDataAdapter
            myAdapter.InsertCommand = myCom
            MsgBox("等待成功" & vbCrLf & "前面有" & k & "人等待")
        Catch
        End Try
    End Sub
    '
End Class

