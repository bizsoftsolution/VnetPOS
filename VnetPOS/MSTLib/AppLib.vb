﻿
Imports System.Data.OleDb
Imports System.Data.Odbc
Imports System.Data.SqlClient
Imports System.Drawing
Imports System.Windows.Forms
Imports System.IO

Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Module AppLib

    Public ConStr As String = GetConStr()
    Public ConType As String = GetConType()
    Public Connection As Object
    Public adp As Object

    Public CMPName As String = ""

    Public JISDb As New JISDatabase(ConStr, ConType)

    Function GetConStr() As String
        Dim ds As New DataSet()
        ds.ReadXml(Application.StartupPath + "\\App.Xml")
        If 1 = 1 Then
            Return ds.Tables(0).Rows(0).Item("ConStr64").ToString()
        Else
            Return ds.Tables(0).Rows(0).Item("ConStr32").ToString()
        End If
    End Function


    Function GetConType() As String
        Dim ds As New DataSet()
        ds.ReadXml(Application.StartupPath + "\\App.Xml")
        Return ds.Tables(0).Rows(0).Item("ConType").ToString()
    End Function


    Function GetCompanyName() As String
        Dim ds As New DataSet()
        ds.ReadXml(Application.StartupPath + "\\App.Xml")
        Return ds.Tables(0).Rows(0).Item("CompanyName").ToString()
    End Function

    Public Sub FormsRefresh()
        Dim openFrm As Form
        For Each openFrm In Application.OpenForms
            If openFrm.Name = frmMaster.Name Then Continue For
            SetFormStyle(openFrm)
        Next
    End Sub



    Public db As New DBLib()
    Public Login_Id As String = ""
    Public ErrMSG As String = "Error is occured. Please Contact Admin"
    Public CryPath As String = Application.StartupPath + "\Report\"
    'Public FColor As Color = Color.FromArgb(0, 37, 74)
    Public FColor As Color = Color.FromArgb(0, 36, 36)
    Public BColor As Color = Color.FromArgb(250, 255, 255)

    Public Grid1stFColor As Color = Color.FromArgb(0, 36, 36)
    Public Grid2ndFColor As Color = Color.FromArgb(0, 36, 36)
    Public Grid1stBColor As Color = Color.FromArgb(250, 255, 255)
    Public Grid2ndBColor As Color = Color.FromArgb(250, 255, 255)

    Public btnBordercolor As Color = Color.FromArgb(0, 46, 45)
    Public btnMouseDownBackcolor As Color = Color.FromArgb(166, 255, 255)
    Public btnMouseOverBackcolor As Color = Color.FromArgb(204, 255, 255)
    Public GridHeading As Color = Color.FromArgb(250, 255, 255)
    Public lbltitle1 As Color = Color.FromArgb(250, 255, 255)

    Public cmbEnterHeight As Integer = 120
    Public cmbLeaveHeight As Integer = 24

    Public Type As String
    Public SalesCode As String
    Public Function GetColorValue(ByVal ColorInt) As Color
        Dim n, r, g, b As Integer
        n = ColorInt
        r = (n And &HFF0000) >> 16
        g = (n And &HFF00) >> 8
        b = n And &HFF
        Return Color.FromArgb(r, g, b)
    End Function


    Function DateOnly(ByVal dt As Date)
        Return New Date(dt.Year, dt.Month, dt.Day, 0, 0, 0)
    End Function

    Public Sub SetFormStyle(ByVal obj As Object)

        For Each ctl As Control In obj.Controls

            If TypeOf ctl Is Panel Then
                SetFormStyle(ctl)
            End If
            If TypeOf ctl Is SplitContainer Then
                SetFormStyle(ctl)
            End If
            If TypeOf ctl Is GroupBox Then
                Dim gbx As GroupBox = DirectCast(ctl, GroupBox)
                gbx.BackColor = Color.Transparent
                gbx.ForeColor = FColor
                gbx.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                SetFormStyle(ctl)
            End If
            If TypeOf ctl Is TabControl Then
                SetFormStyle(ctl)
            End If

            If (ctl.Name.ToLower.StartsWith("lbl")) AndAlso (TypeOf ctl Is Label) Then
                Dim lbl As Label = DirectCast(ctl, Label)
                If lbl.Name = "lblHeading" Then lbl.Height = 40

                If lbl.Name.ToLower() = "lblheading" Or lbl.Tag = "Heading" Then
                    lbl.BackColor = Color.FromArgb(66, 166, 149)
                    lbl.ForeColor = BColor
                Else
                    lbl.BackColor = Color.Transparent
                    lbl.ForeColor = FColor
                    lbl.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                End If
            End If

            If (ctl.Name.ToLower.StartsWith("txt")) AndAlso (TypeOf ctl Is TextBox) Then
                Dim txt As TextBox = DirectCast(ctl, TextBox)
                txt.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                txt.BackColor = BColor
                txt.ForeColor = FColor
            End If

            If (ctl.Name.ToLower.StartsWith("dtp")) AndAlso (TypeOf ctl Is DateTimePicker) Then
                Dim dtp As DateTimePicker = DirectCast(ctl, DateTimePicker)
                dtp.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                dtp.BackColor = BColor
                dtp.ForeColor = FColor
            End If

            If (ctl.Name.ToLower.StartsWith("mtb")) AndAlso (TypeOf ctl Is MaskedTextBox) Then
                Dim txt As MaskedTextBox = DirectCast(ctl, MaskedTextBox)
                txt.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                txt.BackColor = BColor
                txt.ForeColor = FColor
            End If
            If (ctl.Name.ToLower.StartsWith("cmb")) AndAlso (TypeOf ctl Is ComboBox) Then
                Dim cbox As ComboBox = DirectCast(ctl, ComboBox)
                cbox.BackColor = BColor
                cbox.ForeColor = FColor
                cbox.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                If cbox.Name = "cmbSearchBox" Then cbox.Top = 0
                cbox.Height = cmbLeaveHeight
                cbox.AutoCompleteMode = AutoCompleteMode.None
                cbox.AutoCompleteSource = AutoCompleteSource.None
            End If
            If (ctl.Name.ToLower.StartsWith("lst")) AndAlso (TypeOf ctl Is ListBox) Then
                Dim lst As ListBox = DirectCast(ctl, ListBox)
                lst.BackColor = BColor
                lst.ForeColor = FColor
            End If
            If (TypeOf ctl Is Form) Then
                Dim frm As Form = DirectCast(ctl, Form)
                frm.BackColor = BColor
                frm.ForeColor = FColor

            End If
            If (ctl.Name.ToLower.StartsWith("pnl")) AndAlso (TypeOf ctl Is Panel) Then
                Dim pnl As Panel = DirectCast(ctl, Panel)
                pnl.BackColor = BColor
                pnl.ForeColor = FColor
                If pnl.Name = "pnlMain" Then pnl.BorderStyle = BorderStyle.FixedSingle
                'If pnl.Name = "pnlToolBar" Then
                '    pnl.Top = 40
                '    pnl.Height = 67
                'End If

            End If

            If (ctl.Name.ToLower.StartsWith("btn")) AndAlso (TypeOf ctl Is Button) Then

                Dim btn As Button = DirectCast(ctl, Button)
                btn.BackColor = Color.Transparent
                btn.FlatAppearance.BorderColor = btnBordercolor
                btn.FlatAppearance.MouseDownBackColor = btnMouseDownBackcolor
                btn.FlatAppearance.MouseOverBackColor = btnMouseOverBackcolor
                btn.FlatAppearance.BorderSize = 2
                btn.FlatStyle = FlatStyle.Flat

                btn.Font = New System.Drawing.Font("Verdana", 6.75, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))

                btn.ForeColor = FColor
                '  btn.Size = New Size(157, 36)
            End If


            If (ctl.Name.ToLower.StartsWith("rbn")) AndAlso (TypeOf ctl Is RadioButton) Then

                Dim rbn As RadioButton = DirectCast(ctl, RadioButton)
                rbn.BackColor = Color.Transparent
                rbn.FlatAppearance.BorderColor = btnBordercolor
                rbn.FlatAppearance.CheckedBackColor = Color.LightSkyBlue
                rbn.FlatAppearance.MouseDownBackColor = btnMouseDownBackcolor
                rbn.FlatAppearance.MouseOverBackColor = btnMouseOverBackcolor
                'rbn.FlatAppearance.BorderSize = 2
                rbn.FlatStyle = FlatStyle.Flat
                rbn.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                rbn.ForeColor = FColor
                'rbn.Size = New Size(102, 36)
                rbn.AutoSize = True
            End If

            If (ctl.Name.ToLower.StartsWith("dgv")) AndAlso (TypeOf ctl Is DataGridView) Then
                Dim dgv As DataGridView = DirectCast(ctl, DataGridView)

                dgv.AllowUserToAddRows = False
                dgv.AllowUserToDeleteRows = False
                dgv.AllowUserToResizeColumns = False
                dgv.AllowUserToResizeRows = False
                dgv.BackgroundColor = BColor
                dgv.BorderStyle = BorderStyle.FixedSingle
                dgv.RowsDefaultCellStyle.BackColor = Grid1stBColor
                dgv.RowsDefaultCellStyle.ForeColor = Grid1stFColor
                dgv.AlternatingRowsDefaultCellStyle.ForeColor = Grid2ndFColor
                dgv.AlternatingRowsDefaultCellStyle.BackColor = Grid2ndBColor
                dgv.ColumnHeadersDefaultCellStyle.BackColor = FColor
                dgv.ColumnHeadersDefaultCellStyle.ForeColor = BColor

                dgv.Font = New Font("Arial", 9, FontStyle.Bold)

                dgv.BorderStyle = BorderStyle.FixedSingle
                dgv.CellBorderStyle = DataGridViewCellBorderStyle.Single
                dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
                dgv.ColumnHeadersVisible = True
                dgv.EditMode = DataGridViewEditMode.EditProgrammatically
                dgv.RowHeadersVisible = False
                dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect
                '  dgv.Size = New Size(770, 295)



            End If

        Next
        If TypeOf obj Is Form Then
            Dim frm As Form = DirectCast(obj, Form)
            frm.BackColor = BColor
            frm.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            frm.KeyPreview = True
            frm.AutoScroll = True
        End If

    End Sub


    Public Sub List_Datas(ByVal Obj As Object, ByVal Arr As ArrayList, Optional ByVal IsUpdate As Boolean = False)
        Try
            If (Obj.Name.ToLower.StartsWith("txt")) AndAlso (TypeOf Obj Is TextBox) Then
                If IsUpdate = False Then Obj.AutoCompleteCustomSource.Clear()
                For i As Integer = 0 To Arr.Count - 1
                    Obj.AutoCompleteCustomSource.Add(Arr(i).ToString())
                Next
            Else
                If IsUpdate = False Then Obj.items.Clear()
                For i As Integer = 0 To Arr.Count - 1
                    Obj.items.Add(Arr(i).ToString())
                Next
            End If


        Catch ex As Exception

        End Try

    End Sub
    Private Function ExecuteQuerySQL(ByVal Qry As String) As Object
        Try
            If Connection.State <> ConnectionState.Open Then Connection.Open()

            Dim cmdText As String = Qry
            Dim command As New SqlCommand(cmdText, Connection)
            If (InStr(Qry.ToLower(), "select") = 1) Then
                adp = New SqlDataAdapter(command)
                Dim ds As New DataSet()
                Dim dv As New DataView
                adp.Fill(ds, 0)

                dv = ds.Tables(0).DefaultView

                Connection.Close()
                Return dv
            Else
                Dim i As Integer = command.ExecuteNonQuery()
                Connection.Close()
                Return i
            End If
        Catch e As SqlException
            Connection.Close()
            Return Nothing
        End Try
    End Function

    Private Function ExecuteQueryODBC(ByVal Qry As String) As Object
        Try
            If Connection.State <> ConnectionState.Open Then Connection.Open()

            Dim cmdText As String = Qry
            Dim command As New OdbcCommand(cmdText, Connection)
            If (InStr(Qry.ToLower(), "select") = 1) Then
                adp = New OdbcDataAdapter(command)
                Dim ds As New DataSet()
                Dim dv As New DataView
                adp.Fill(ds, 0)

                dv = ds.Tables(0).DefaultView
                Connection.Close()
                Return dv
            Else
                Dim i As Integer = command.ExecuteNonQuery()
                Connection.Close()
                Return i
            End If
        Catch e As OdbcException
            Connection.Close()
            Return Nothing
        End Try
    End Function
    Private Function ExecuteQueryOLEDB(ByVal Qry As String) As Object
        Try
            If Connection.State <> ConnectionState.Open Then Connection.Open()

            Dim cmdText As String = Qry
            Dim command As New OleDbCommand(cmdText, Connection)
            If (InStr(Qry.ToLower(), "select") = 1) Then
                adp = New OleDbDataAdapter(command)
                Dim ds As New DataSet()
                Dim dv As New DataView
                adp.Fill(ds, 0)

                dv = ds.Tables(0).DefaultView
                Connection.Close()
                Return dv
            Else
                Dim i As Integer = command.ExecuteNonQuery()
                Connection.Close()
                Return i
            End If
        Catch e As OleDbException
            Connection.Close()
            Return Nothing
        End Try
    End Function


    Public Function ExecuteQuery(ByVal Qry As String) As Object
        Dim RValue As Object = ""

        If ConType = "SQL" Then
            RValue = ExecuteQuerySQL(Qry)
        ElseIf ConType = "OLEDB" Then
            RValue = ExecuteQueryOLEDB(Qry)
        ElseIf ConType = "ODBC" Then
            RValue = ExecuteQueryODBC(Qry)
        End If

        Return RValue

    End Function

    Public Sub ReportView(ByVal CryRptViewer As Object, ByVal ReportName As String, ByVal ds As DataTable, Optional ByVal ParameterValues As Hashtable = Nothing)
        Dim rpt As New ReportDocument
        rpt.Load(CryPath + ReportName)
        rpt.SetDataSource(ds)
        If Not ParameterValues Is Nothing Then SetParameterValueInReport(rpt, ParameterValues)
        CryRptViewer.ReportSource = rpt
        CryRptViewer.Refresh()
    End Sub

    Public Sub ReportView(ByVal CryRptViewer As Object, ByVal ReportName As String, ByVal ds As DataSet, Optional ByVal ParameterValues As Hashtable = Nothing)
        Dim rpt As New ReportDocument
        rpt.Load(CryPath + ReportName)
        rpt.SetDataSource(ds)
        If Not ParameterValues Is Nothing Then SetParameterValueInReport(rpt, ParameterValues)
        CryRptViewer.ReportSource = rpt
        CryRptViewer.Refresh()
    End Sub

    Public Sub SetParameterValueInReport(ByRef rpt As ReportDocument, ByVal ParameterValues As Hashtable)
        Dim ParameterValue As DictionaryEntry
        For Each ParameterValue In ParameterValues
            rpt.SetParameterValue(ParameterValue.Key, ParameterValue.Value)
        Next
    End Sub

    Public Sub FormShow(ByVal FormName As Form)
        frmMaster.IsMdiContainer = True
        FormName.MdiParent = frmMaster
        FormName.StartPosition = FormStartPosition.CenterScreen
        FormName.Show()
        FormName.BringToFront()

    End Sub

    Public Function DateToString(ByVal dt As Date) As String
        Return String.Format("{0:MM/dd/yyyy}", dt)
    End Function
End Module
