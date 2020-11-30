
Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class sqlDBM
	Public myConn As SqlConnection
	Public myCom As SqlCommand
	Public myAdapter As SqlDataAdapter
	'public myReader As SqlDataReader
	Public myDS As DataSet
	Public dbAdapterFlag As Boolean = False
	Public dbReaderFlag As Boolean = False
	Public dbstr As String
	'
	Public dbOpenFlag As Boolean = False
	Public sqlAdapter As SqlDataAdapter
	Public sqlDS As DataSet
	Public sqlDT As Object
	Public myReader As Object

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
		theR.Dispose()
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
        Dim strSQL As String = "select name from users, where ID=" & accountID
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
	Public Function searchname(usertype As String)
		Select Case usertype
			Case "users"
				Try
                    Dim sqlString As String = "select name from " & usertype & " where ID='" & accountID & "'"
                    Dim cmd111 As New SqlCommand(sqlString, myConn)
					Dim adap111 As New SqlDataAdapter(cmd111)
					Dim ds111 As New DataSet
					adap111.Fill(ds111, "table")
					Name = ds111.Tables(0).Rows(0).Item(0)
				Catch
				End Try
			Case "teacher"
				Try
                    Dim sqlString As String = "select name from " & usertype & " where ID='" & accountID & "'"
                    Dim cmd111 As New SqlCommand(sqlString, myConn)
					Dim adap111 As New SqlDataAdapter(cmd111)
					Dim ds111 As New DataSet
					adap111.Fill(ds111, "table")
					Name = ds111.Tables(0).Rows(0).Item(0)
				Catch
				End Try


		End Select
		Return Name
	End Function
    'student_function-----------------------------------------------------------------------

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
        adap.Dispose()
    End Sub
	Public Function court_check(ByVal courtID As String, ByVal expectedTime As String) As Boolean
		Dim p As Boolean
		Dim theR As SqlDataReader
        Try
            myCom = New SqlCommand("select * from court_manage where courtID='" & courtID & "' and stoptime<'" & expectedTime & "'", myConn)
            theR = myCom.ExecuteReader()
            If theR.HasRows Then
                p = False
            End If
            theR.Dispose()
        Catch
            p = True
        End Try
        Return p
	End Function
	Public Function appointment_check(ByVal courtID As String, ByVal expectedTime As String) As Boolean
		Dim p As Boolean
        Dim theR As SqlDataReader
        Dim dt As New DataTable
        Try
            myCom = New SqlCommand("select * from appointment_records where courtID='" & courtID & "' and expectedTime='" & expectedTime & "' and ID='" & accountID & "'", myConn)
            theR = myCom.ExecuteReader()
            dt.Load(theR)
            If dt.Rows.Count <> 0 Then
                    p = False
                End If
                theR.Dispose()
            Catch
            p = True
            theR.Dispose()
        End Try
        Return p
	End Function
    Public Sub appointment(ByVal courtID As String, ByVal expectedTime As String)
        Dim str As String = "insert into appointment_records values('" & courtID & "','" & accountID & "',GETDATE() ,'" & expectedTime & "')"
        'Dim str2 As String = "insert into appointment_records values('01','10101',GETDATE(),'2020-11-30 11:00:00')"
        Try
            'myCom = New SqlCommand(str, myConn)
            'myCom.ExecuteNonQuery()
            myCom = New SqlCommand(str, myConn)
            myAdapter = New SqlDataAdapter
            myAdapter.InsertCommand = myCom
            myAdapter.InsertCommand.ExecuteNonQuery()
            MsgBox("预约成功")
        Catch e As Exception
            MsgBox("您已预约过")
        End Try
    End Sub
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
and appointment_records.courtID='" & courtID & "' and 
appointment_records.expectedTime='" & expectedTime & "' and t1.n_share>0 ", myConn)
            theR = myCom.ExecuteReader()
            dt.Load(theR)
            If dt.Rows.Count <> 0 Then
                p = True
                shareID = dt.Rows(0).Item(0)
            End If
            theR.Dispose()
        Catch e As Exception
            MsgBox(e.ToString)
            p = False
        End Try
        Return p
	End Function
	Public Sub sharing_application(ByVal courtID As String, ByVal expectedTime As String, ByVal shareID As Int16)
		Try
            myCom = New SqlCommand("insert into share_application_records values(" & shareID & ",'" & accountID & "',GETDATE())", myConn)
            myAdapter = New SqlDataAdapter
            myAdapter.InsertCommand = myCom
            myAdapter.InsertCommand.ExecuteNonQuery()
            MsgBox("拼场成功")
		Catch
			MsgBox("拼场申请失败,请刷新重试")
		End Try
	End Sub
	Public Function queue_check(ByVal courtID As String, ByVal expectedTime As String) As Int16
        Dim k As Int16 = 0
        Dim theR As SqlDataReader
		Dim dt As New DataTable
        Try
            myCom = New SqlCommand("select count(*) from queuing_records where courtID= '" & courtID & "' and expectedTime= '" & expectedTime & "' group by courtID ", myConn)
            theR = myCom.ExecuteReader()
            dt.Load(theR)
            If dt.Rows.Count <> 0 Then
                k = dt.Rows(0).Item(0)
            End If
            theR.Dispose()
        Catch e As Exception
            MsgBox("queue_check error" & e.ToString)
        End Try
        Return k
	End Function
    Public Sub queue_application(ByVal courtID As String, ByVal expectedTime As String)
        Dim k As Int16 = queue_check(courtID, expectedTime)
        Try
            myCom = New SqlCommand("insert into queuing_records values('" & courtID & "','" & accountID & "',GETDATE(),'" & expectedTime & "')", myConn)
            myAdapter = New SqlDataAdapter
            myAdapter.InsertCommand = myCom
            myAdapter.InsertCommand.ExecuteNonQuery()
            MsgBox("等待成功" & vbCrLf & "前面有" & k & "人等待")
        Catch e As Exception
            MsgBox("queue_application error" & e.ToString)
        End Try
    End Sub
    '------------------------------------------------------------------我的场地
    Public Sub my_search(ByRef DataGridView2 As DataGridView)
        Dim f As Boolean = False
        Try
            myCom = New SqlCommand("select appointment_records.*,t1.maxNum 最多拼场数,n_share 拼场数
from appointment_records left join (select sharing_records.appointmentID appointmentID,
sharing_records.maxNum maxNum,count(share_application_records.shareID) n_share
	from sharing_records left join share_application_records 
	on sharing_records.shareID=share_application_records.shareID
	group by sharing_records.shareID,sharing_records.appointmentID,sharing_records.maxNum
	)t1 on t1.appointmentID=appointment_records.appointmentID
where appointment_records.ID= '" & accountID & "'", myConn)
            myAdapter = New SqlDataAdapter
            myAdapter.SelectCommand = myCom
            Dim dt As New DataTable
            myAdapter.Fill(dt)
            DataGridView2.DataSource = dt
            If dt.Rows.Count <> 0 Then
                f = True
            End If
        Catch e As Exception
            MsgBox(e.ToString)
        End Try
    End Sub

    Public Function cancel_appointment_check() As Boolean
        myCom = New SqlCommand("select * from appointment_records Where ID = '" & accountID & "'", myConn)
        myAdapter = New SqlDataAdapter
        myAdapter.SelectCommand = myCom
        Dim dt As New DataTable
        myAdapter.Fill(dt)

        Return dt.Rows.Count <> 0
    End Function
    Public Sub cancel_appointment()
        If cancel_appointment_check() Then
            Try
                myCom = New SqlCommand("Delete From appointment_records Where ID = '" & accountID & "'", myConn)
                myAdapter = New SqlDataAdapter
                myAdapter.DeleteCommand = myCom
                myAdapter.DeleteCommand.ExecuteNonQuery()
                MsgBox("退场成功")
            Catch
            End Try
        Else
            MsgBox("退场失败")
            Return
        End If
    End Sub
    Public Function share_check(ByRef appointmentID As Int16) As Boolean
        myCom = New SqlCommand("select * from appointment_records left join sharing_records 
on appointment_records.appointmentID=sharing_records.appointmentID
Where appointment_records.ID = '" & accountID & "' and  sharing_records.shareID is null", myConn)
        myAdapter = New SqlDataAdapter
        myAdapter.SelectCommand = myCom
        Dim dt As New DataTable
        myAdapter.Fill(dt)
        If dt.Rows.Count <> 0 Then
            appointmentID = dt.Rows(0).Item(0)
            Return True
        Else
            Return False
        End If
    End Function
    Public Sub share()
        Dim appointmentID As New Int16
        If share_check(appointmentID) Then
            Try
                Dim maxNum As Int16 = 0
                While maxNum <= 0
                    maxNum = InputBox("请输入希望的拼场人数")
                    If maxNum < 0 Then
                        MsgBox("必须为正整数")
                    ElseIf maxNum > 10 Then
                        MsgBox("人数太多了")
                    End If
                End While

                myCom = New SqlCommand("insert into sharing_records values(" & appointmentID & "," & maxNum & ",null)", myConn)
                myAdapter = New SqlDataAdapter
                myAdapter.InsertCommand = myCom
                myAdapter.InsertCommand.ExecuteNonQuery()
                MsgBox("已开启拼场")
            Catch
            End Try
        Else
            MsgBox("不能重复开启拼场")
            Return
        End If
    End Sub

    '------------------other student function
    Public Sub repair_feedback_set(ByVal stadiumID As String, ByVal type As String, ByVal details As String)
        Try
            Dim str As String = "insert into repair_feedback values(GETDATE(),'" & type & "','" & stadiumID & "','" & details & "','" & accountID & "')"
            myCom = New SqlCommand(str, myConn)
            myAdapter = New SqlDataAdapter
            myAdapter.InsertCommand = myCom
            myAdapter.InsertCommand.ExecuteNonQuery()
            MsgBox("提交成功")
        Catch e As Exception
            MsgBox("提交失败" & e.ToString)
        End Try
    End Sub

    Public Sub other_feedback_set(ByVal stadiumID As String, ByVal type As String, ByVal details As String)
        Try
            Dim str As String = "insert into other_feedback values(GETDATE(),'" & type & "','" & details & "','" & accountID & "')"
            myCom = New SqlCommand(str, myConn)
            myAdapter = New SqlDataAdapter
            myAdapter.InsertCommand = myCom
            myAdapter.InsertCommand.ExecuteNonQuery()
            MsgBox("提交成功")
        Catch e As Exception
            MsgBox("提交失败" & e.ToString)
        End Try
    End Sub

    Public Sub course_search(ByRef DataGridView5 As DataGridView)
        Try
            myCom = New SqlCommand("select * from course_schedule", myConn)
            myAdapter = New SqlDataAdapter
            myAdapter.SelectCommand = myCom
            Dim dt As New DataTable
            myAdapter.Fill(dt)
            DataGridView5.DataSource = dt
        Catch e As Exception
            MsgBox(e.ToString)
        End Try
    End Sub

    Public Sub course_application(ByVal courseID As String)
        Try
            Dim str As String = "insert into course_application values('" & accountID & "',GETDATE(),'" & courseID & "')"
            myCom = New SqlCommand(str, myConn)
            myAdapter = New SqlDataAdapter
            myAdapter.InsertCommand = myCom
            myAdapter.InsertCommand.ExecuteNonQuery()
            MsgBox("提交成功")
        Catch e As Exception
            MsgBox("提交失败" & e.ToString)
        End Try
    End Sub

    Public Sub match_search(ByRef datagrid As DataGridView)
        Try
            myCom = New SqlCommand("select * from match_schedule", myConn)
            myAdapter = New SqlDataAdapter
            myAdapter.SelectCommand = myCom
            Dim dt As New DataTable
            myAdapter.Fill(dt)
            datagrid.DataSource = dt
        Catch e As Exception
            MsgBox(e.ToString)
        End Try
    End Sub
    Public Sub my_match_search(ByRef datagrid As DataGridView)
        Try
            myCom = New SqlCommand("select * from match_player where playerID='" & accountID & "'", myConn)
            myAdapter = New SqlDataAdapter
            myAdapter.SelectCommand = myCom
            Dim dt As New DataTable
            myAdapter.Fill(dt)
            datagrid.DataSource = dt
        Catch e As Exception
            MsgBox(e.ToString)
        End Try
    End Sub
    Public Sub match_application()
        Dim matchID As String
        Try
            myCom = New SqlCommand("select matchID from match_player group by matchID having count(playerID)<2 order by matchID;", myConn)
            myAdapter = New SqlDataAdapter
            myAdapter.SelectCommand = myCom
            Dim dt As New DataTable
            myAdapter.Fill(dt)
            If dt.Rows.Count <> 0 Then
                matchID = dt.Rows(0).Item(0)
            Else
                MsgBox("暂无可参与的比赛")
                Return
            End If
        Catch ex As Exception
            MsgBox("暂无可参与的比赛")
            Return
        End Try
        If matchID <> Nothing Then
            Try
                Dim str As String = "insert into match_player values('" & accountID & "','" & matchID & "')"
                myCom = New SqlCommand(str, myConn)
                myAdapter = New SqlDataAdapter
                myAdapter.InsertCommand = myCom
                myAdapter.InsertCommand.ExecuteNonQuery()
                MsgBox("提交成功")
            Catch ex As Exception
                MsgBox("提交失败")
            End Try
        End If

    End Sub

    Public Sub datagrid_show(datagrid As DataGridView, sqlString As String)
        Dim Comm As New SqlCommand(sqlString, myConn)
        Dim dr As SqlDataReader
        dr = Comm.ExecuteReader()
        Dim dt As DataTable
        dt = New DataTable()
        dt.Load(dr)
        datagrid.DataSource = dt
    End Sub
    '体育部
    Public Sub Maintain_search(ByRef datagrid As DataGridView)
        Try
            myCom = New SqlCommand("select * from maintenance", myConn)
            myAdapter = New SqlDataAdapter
            myAdapter.SelectCommand = myCom
            Dim dt As New DataTable
            myAdapter.Fill(dt)
            datagrid.DataSource = dt
        Catch e As Exception
            MsgBox(e.ToString)
        End Try
    End Sub

    Public Sub add_match(ByVal matchID As String, ByVal startTime As String, ByVal courtID As String)
        Try
            Dim str As String = "insert into match_schedule values('" & matchID & "','" & startTime & "','" & courtID & "','null')"
            myCom = New SqlCommand(str, myConn)
            myAdapter = New SqlDataAdapter
            myAdapter.InsertCommand = myCom
            myAdapter.InsertCommand.ExecuteNonQuery()
            MsgBox("添加成功")
        Catch ex As Exception
            MsgBox("添加失败")
        End Try
    End Sub
    '管理员
    Public Sub get_court_manage(ByRef DataGridView4 As DataGridView)
        Try
            myCom = New SqlCommand("select * from court_manage", myConn)
            myAdapter = New SqlDataAdapter
            myAdapter.SelectCommand = myCom
            Dim dt As New DataTable
            myAdapter.Fill(dt)
            DataGridView4.DataSource = dt
        Catch e As Exception
            MsgBox(e.ToString)
        End Try
    End Sub

    Public Function court_check2(ByVal courtID As String) As Boolean
        Dim p As Boolean
        Dim theR As SqlDataReader
        Try
            myCom = New SqlCommand("select * from court_manage where courtID='" & courtID & "'", myConn)
            theR = myCom.ExecuteReader()
            If theR.HasRows Then
                p = False
            End If
            theR.Dispose()
        Catch
            p = True
        End Try
        Return p
    End Function

    Public Sub add_court_manage(ByVal courtID As String, ByVal stopTime As String)
        Try
            Dim str As String = "insert into court_manage values('" & courtID & "','" & stopTime & "')"
            myCom = New SqlCommand(str, myConn)
            myAdapter = New SqlDataAdapter
            myAdapter.InsertCommand = myCom
            myAdapter.InsertCommand.ExecuteNonQuery()
            MsgBox("添加成功")
        Catch ex As Exception
            MsgBox("添加失败")
        End Try
    End Sub
    Public Sub delete_court_manage(ByVal courtID As String)
        Try
            Dim str As String = "delete FROM court_manage WHERE courtID ='" & courtID & "'"
            myCom = New SqlCommand(str, myConn)
            myAdapter = New SqlDataAdapter
            myAdapter.DeleteCommand = myCom
            myAdapter.DeleteCommand.ExecuteNonQuery()
            MsgBox("删除成功")
        Catch ex As Exception
            MsgBox("删除失败")
        End Try
    End Sub

End Class

