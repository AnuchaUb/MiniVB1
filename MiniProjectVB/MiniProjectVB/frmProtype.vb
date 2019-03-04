Imports System.Configuration
Imports System.Data
Imports System.Data.SqlClient

Public Class frmProtype
    Dim myCon As New SqlConnection

    Dim myDA As New SqlDataAdapter
    Dim myDS As New DataSet

    Dim myCom As New SqlCommand
    Dim myDR As SqlDataReader

    Dim strBtn As String
    Dim typeid As String
    Dim typename As String

    Private Sub connData()
        If myCon.State = ConnectionState.Open Then
            myCon.Close()
        End If
        myCon.ConnectionString = strCon
        myCon.Open()
    End Sub
    Private Sub frmProtype_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connData()
        strSql = "select typename from tbtypeofproduct"
        myCom = New SqlCommand(strSql, myCon)
        myCom.CommandTimeout = 15
        myCom.CommandType = CommandType.Text
        myDR = myCom.ExecuteReader
        If myDR.HasRows Then
            While myDR.Read
                cboProtype.Items.Add(myDR.Item("typename"))
            End While
            myDR.Close()
            cboProtype.SelectedIndex = 0

        Else
            MessageBox.Show("ยังไม่มีการเพิ่มข้อมูลประเภทสินค้าในระบบ" & vbCrLf & "กรุณาเพิ่มข้อมูลด้วยครับ !", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            cboProtype.Enabled = False
            btnAdd.Enabled = True
            btnEdit.Enabled = False
            btnDelete.Enabled = False
        End If
        txtProtypeid.Enabled = False
        txtProtypename.Enabled = False
        btnSave.Enabled = False
        btnCancel.Enabled = False
        myCon.Close()
    End Sub

    Private Sub dgvShowprotype_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvShowprotype.CellEnter

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        strBtn = "Insert"

        cboProtype.Enabled = False
        btnAdd.Enabled = False
        btnEdit.Enabled = False
        btnDelete.Enabled = False
        btnSave.Enabled = True
        btnCancel.Enabled = True
        txtProtypeid.Enabled = True
        txtProtypename.Enabled = True

        txtProtypeid.Focus()

        txtProtypeid.Clear()
        txtProtypename.Clear()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        txtProtypeid.Text = txtProtypeid.Text.Trim()
        txtProtypename.Text = txtProtypename.Text.Trim()

        If txtProtypeid.Text = "" Or txtProtypename.Text = "" Then
            MessageBox.Show("กรุณาป้อนข้อมูลให้ครบถ้วนด้วยครับ !", "ป้อนข้อมูลผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtProtypeid.Focus()
            Exit Sub
        End If
        connData()
        strSql = ""


    End Sub
End Class