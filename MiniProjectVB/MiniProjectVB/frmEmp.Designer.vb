﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmp
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboDep = New System.Windows.Forms.ComboBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dgvShowemp = New System.Windows.Forms.DataGridView()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtEmpphone = New System.Windows.Forms.TextBox()
        Me.txtEmppostalcode = New System.Windows.Forms.TextBox()
        Me.txtEmpprovince = New System.Windows.Forms.TextBox()
        Me.txtEmparea = New System.Windows.Forms.TextBox()
        Me.txtEmpsubarea = New System.Windows.Forms.TextBox()
        Me.txtEmpaddress = New System.Windows.Forms.TextBox()
        Me.txtEmpidcard = New System.Windows.Forms.TextBox()
        Me.txtEmpname = New System.Windows.Forms.TextBox()
        Me.txtEmpid = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtEmpuser = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtEmppass = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtEmplname = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtEmpbirthday = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtEmphiredate = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtEmpsalary = New System.Windows.Forms.TextBox()
        Me.cboEmpdep = New System.Windows.Forms.ComboBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgvShowemp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.cboDep)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1114, 57)
        Me.Panel1.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("_Layiji MaHaNiYom V 1.2", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(26, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 31)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "ชื่อแผนก :"
        '
        'cboDep
        '
        Me.cboDep.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDep.FormattingEnabled = True
        Me.cboDep.Location = New System.Drawing.Point(117, 14)
        Me.cboDep.Name = "cboDep"
        Me.cboDep.Size = New System.Drawing.Size(236, 27)
        Me.cboDep.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.dgvShowemp)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 57)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1114, 249)
        Me.Panel2.TabIndex = 4
        '
        'dgvShowemp
        '
        Me.dgvShowemp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvShowemp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvShowemp.Location = New System.Drawing.Point(0, 0)
        Me.dgvShowemp.Name = "dgvShowemp"
        Me.dgvShowemp.RowTemplate.Height = 24
        Me.dgvShowemp.Size = New System.Drawing.Size(1114, 249)
        Me.dgvShowemp.TabIndex = 0
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Transparent
        Me.btnDelete.FlatAppearance.BorderSize = 0
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("_Layiji MaHaNiYom V 1.2", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.Navy
        Me.btnDelete.Image = Global.MiniProjectVB.My.Resources.Resources.icons8_Minus_48px
        Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnDelete.Location = New System.Drawing.Point(595, 556)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(89, 81)
        Me.btnDelete.TabIndex = 19
        Me.btnDelete.Text = "ลบ"
        Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.Transparent
        Me.btnEdit.FlatAppearance.BorderSize = 0
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.Font = New System.Drawing.Font("_Layiji MaHaNiYom V 1.2", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.ForeColor = System.Drawing.Color.Navy
        Me.btnEdit.Image = Global.MiniProjectVB.My.Resources.Resources.icons8_Edit_Property_48px
        Me.btnEdit.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnEdit.Location = New System.Drawing.Point(500, 556)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(89, 81)
        Me.btnEdit.TabIndex = 18
        Me.btnEdit.Text = "แก้ไข"
        Me.btnEdit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Transparent
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("_Layiji MaHaNiYom V 1.2", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.Navy
        Me.btnCancel.Image = Global.MiniProjectVB.My.Resources.Resources.icons8_Cancel_48px
        Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCancel.Location = New System.Drawing.Point(990, 498)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(89, 81)
        Me.btnCancel.TabIndex = 21
        Me.btnCancel.Text = "ยกเลิก"
        Me.btnCancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Transparent
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("_Layiji MaHaNiYom V 1.2", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.Navy
        Me.btnSave.Image = Global.MiniProjectVB.My.Resources.Resources.icons8_Save_Close_48px
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSave.Location = New System.Drawing.Point(895, 498)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(89, 81)
        Me.btnSave.TabIndex = 20
        Me.btnSave.Text = "บันทึก"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.Transparent
        Me.btnAdd.FlatAppearance.BorderSize = 0
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("_Layiji MaHaNiYom V 1.2", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.Navy
        Me.btnAdd.Image = Global.MiniProjectVB.My.Resources.Resources.icons8_Plus_48px
        Me.btnAdd.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAdd.Location = New System.Drawing.Point(405, 556)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(89, 81)
        Me.btnAdd.TabIndex = 17
        Me.btnAdd.Text = "เพิ่ม"
        Me.btnAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'txtEmpphone
        '
        Me.txtEmpphone.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmpphone.Location = New System.Drawing.Point(595, 455)
        Me.txtEmpphone.Name = "txtEmpphone"
        Me.txtEmpphone.Size = New System.Drawing.Size(130, 27)
        Me.txtEmpphone.TabIndex = 13
        '
        'txtEmppostalcode
        '
        Me.txtEmppostalcode.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmppostalcode.Location = New System.Drawing.Point(346, 453)
        Me.txtEmppostalcode.Name = "txtEmppostalcode"
        Me.txtEmppostalcode.Size = New System.Drawing.Size(119, 27)
        Me.txtEmppostalcode.TabIndex = 12
        '
        'txtEmpprovince
        '
        Me.txtEmpprovince.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmpprovince.Location = New System.Drawing.Point(103, 453)
        Me.txtEmpprovince.Name = "txtEmpprovince"
        Me.txtEmpprovince.Size = New System.Drawing.Size(116, 27)
        Me.txtEmpprovince.TabIndex = 11
        '
        'txtEmparea
        '
        Me.txtEmparea.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmparea.Location = New System.Drawing.Point(868, 411)
        Me.txtEmparea.Name = "txtEmparea"
        Me.txtEmparea.Size = New System.Drawing.Size(116, 27)
        Me.txtEmparea.TabIndex = 10
        '
        'txtEmpsubarea
        '
        Me.txtEmpsubarea.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmpsubarea.Location = New System.Drawing.Point(632, 411)
        Me.txtEmpsubarea.Name = "txtEmpsubarea"
        Me.txtEmpsubarea.Size = New System.Drawing.Size(127, 27)
        Me.txtEmpsubarea.TabIndex = 9
        '
        'txtEmpaddress
        '
        Me.txtEmpaddress.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmpaddress.Location = New System.Drawing.Point(87, 411)
        Me.txtEmpaddress.Name = "txtEmpaddress"
        Me.txtEmpaddress.Size = New System.Drawing.Size(411, 27)
        Me.txtEmpaddress.TabIndex = 8
        '
        'txtEmpidcard
        '
        Me.txtEmpidcard.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmpidcard.Location = New System.Drawing.Point(905, 370)
        Me.txtEmpidcard.Name = "txtEmpidcard"
        Me.txtEmpidcard.Size = New System.Drawing.Size(176, 27)
        Me.txtEmpidcard.TabIndex = 7
        '
        'txtEmpname
        '
        Me.txtEmpname.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmpname.Location = New System.Drawing.Point(74, 370)
        Me.txtEmpname.Name = "txtEmpname"
        Me.txtEmpname.Size = New System.Drawing.Size(143, 27)
        Me.txtEmpname.TabIndex = 4
        '
        'txtEmpid
        '
        Me.txtEmpid.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmpid.Location = New System.Drawing.Point(146, 330)
        Me.txtEmpid.Name = "txtEmpid"
        Me.txtEmpid.Size = New System.Drawing.Size(110, 27)
        Me.txtEmpid.TabIndex = 1
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("_Layiji MaHaNiYom V 1.2", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Navy
        Me.Label12.Location = New System.Drawing.Point(26, 491)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(68, 31)
        Me.Label12.TabIndex = 43
        Me.Label12.Text = "แผนก :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("_Layiji MaHaNiYom V 1.2", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Navy
        Me.Label11.Location = New System.Drawing.Point(471, 451)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(118, 31)
        Me.Label11.TabIndex = 44
        Me.Label11.Text = "เบอร์โทรศัพท์ :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("_Layiji MaHaNiYom V 1.2", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Navy
        Me.Label9.Location = New System.Drawing.Point(225, 451)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(115, 31)
        Me.Label9.TabIndex = 37
        Me.Label9.Text = "รหัสไปรษณีย์ :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("_Layiji MaHaNiYom V 1.2", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Navy
        Me.Label8.Location = New System.Drawing.Point(26, 451)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 31)
        Me.Label8.TabIndex = 46
        Me.Label8.Text = "จังหวัด :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("_Layiji MaHaNiYom V 1.2", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Navy
        Me.Label7.Location = New System.Drawing.Point(765, 409)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(97, 31)
        Me.Label7.TabIndex = 38
        Me.Label7.Text = "อำเภอ/เขต :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("_Layiji MaHaNiYom V 1.2", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Navy
        Me.Label6.Location = New System.Drawing.Point(519, 409)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(107, 31)
        Me.Label6.TabIndex = 39
        Me.Label6.Text = "ตำบล/แขวง :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("_Layiji MaHaNiYom V 1.2", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(26, 409)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 31)
        Me.Label5.TabIndex = 41
        Me.Label5.Text = "ที่อยู่ :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("_Layiji MaHaNiYom V 1.2", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(688, 368)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(211, 31)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "รหัสบัตรประจำตัวประชาชน :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("_Layiji MaHaNiYom V 1.2", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(26, 368)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 31)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "ชื่อ :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("_Layiji MaHaNiYom V 1.2", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(26, 328)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 31)
        Me.Label2.TabIndex = 47
        Me.Label2.Text = "รหัสพนักงาน :"
        '
        'txtEmpuser
        '
        Me.txtEmpuser.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmpuser.Location = New System.Drawing.Point(369, 330)
        Me.txtEmpuser.Name = "txtEmpuser"
        Me.txtEmpuser.Size = New System.Drawing.Size(144, 27)
        Me.txtEmpuser.TabIndex = 2
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("_Layiji MaHaNiYom V 1.2", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Navy
        Me.Label13.Location = New System.Drawing.Point(262, 328)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(101, 31)
        Me.Label13.TabIndex = 47
        Me.Label13.Text = "Username :"
        '
        'txtEmppass
        '
        Me.txtEmppass.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmppass.Location = New System.Drawing.Point(621, 330)
        Me.txtEmppass.Name = "txtEmppass"
        Me.txtEmppass.Size = New System.Drawing.Size(144, 27)
        Me.txtEmppass.TabIndex = 3
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("_Layiji MaHaNiYom V 1.2", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Navy
        Me.Label14.Location = New System.Drawing.Point(519, 328)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(96, 31)
        Me.Label14.TabIndex = 47
        Me.Label14.Text = "Password :"
        '
        'txtEmplname
        '
        Me.txtEmplname.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmplname.Location = New System.Drawing.Point(313, 370)
        Me.txtEmplname.Name = "txtEmplname"
        Me.txtEmplname.Size = New System.Drawing.Size(143, 27)
        Me.txtEmplname.TabIndex = 5
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("_Layiji MaHaNiYom V 1.2", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Navy
        Me.Label15.Location = New System.Drawing.Point(223, 368)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(84, 31)
        Me.Label15.TabIndex = 40
        Me.Label15.Text = "นามสกุล :"
        '
        'txtEmpbirthday
        '
        Me.txtEmpbirthday.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmpbirthday.Location = New System.Drawing.Point(571, 370)
        Me.txtEmpbirthday.Name = "txtEmpbirthday"
        Me.txtEmpbirthday.Size = New System.Drawing.Size(111, 27)
        Me.txtEmpbirthday.TabIndex = 6
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("_Layiji MaHaNiYom V 1.2", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Navy
        Me.Label16.Location = New System.Drawing.Point(463, 368)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(102, 31)
        Me.Label16.TabIndex = 42
        Me.Label16.Text = "ว/ด/ป เกิด :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("_Layiji MaHaNiYom V 1.2", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Navy
        Me.Label10.Location = New System.Drawing.Point(307, 493)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(144, 31)
        Me.Label10.TabIndex = 43
        Me.Label10.Text = "ว/ด/ป เข้าทำงาน :"
        '
        'txtEmphiredate
        '
        Me.txtEmphiredate.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmphiredate.Location = New System.Drawing.Point(457, 495)
        Me.txtEmphiredate.Name = "txtEmphiredate"
        Me.txtEmphiredate.Size = New System.Drawing.Size(119, 27)
        Me.txtEmphiredate.TabIndex = 15
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("_Layiji MaHaNiYom V 1.2", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Navy
        Me.Label17.Location = New System.Drawing.Point(582, 491)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(84, 31)
        Me.Label17.TabIndex = 43
        Me.Label17.Text = "เงินเดือน :"
        '
        'txtEmpsalary
        '
        Me.txtEmpsalary.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmpsalary.Location = New System.Drawing.Point(672, 493)
        Me.txtEmpsalary.Name = "txtEmpsalary"
        Me.txtEmpsalary.Size = New System.Drawing.Size(135, 27)
        Me.txtEmpsalary.TabIndex = 16
        '
        'cboEmpdep
        '
        Me.cboEmpdep.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboEmpdep.FormattingEnabled = True
        Me.cboEmpdep.Location = New System.Drawing.Point(100, 493)
        Me.cboEmpdep.Name = "cboEmpdep"
        Me.cboEmpdep.Size = New System.Drawing.Size(201, 27)
        Me.cboEmpdep.TabIndex = 14
        '
        'frmEmp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1114, 652)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.cboEmpdep)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtEmpsalary)
        Me.Controls.Add(Me.txtEmphiredate)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtEmpphone)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtEmppostalcode)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtEmpprovince)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtEmparea)
        Me.Controls.Add(Me.txtEmpsubarea)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtEmpaddress)
        Me.Controls.Add(Me.txtEmppass)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtEmpbirthday)
        Me.Controls.Add(Me.txtEmpuser)
        Me.Controls.Add(Me.txtEmpidcard)
        Me.Controls.Add(Me.txtEmplname)
        Me.Controls.Add(Me.txtEmpid)
        Me.Controls.Add(Me.txtEmpname)
        Me.Name = "frmEmp"
        Me.Text = "Employee"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.dgvShowemp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents cboDep As ComboBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents dgvShowemp As DataGridView
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents txtEmpphone As TextBox
    Friend WithEvents txtEmppostalcode As TextBox
    Friend WithEvents txtEmpprovince As TextBox
    Friend WithEvents txtEmparea As TextBox
    Friend WithEvents txtEmpsubarea As TextBox
    Friend WithEvents txtEmpaddress As TextBox
    Friend WithEvents txtEmpidcard As TextBox
    Friend WithEvents txtEmpname As TextBox
    Friend WithEvents txtEmpid As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtEmpuser As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtEmppass As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtEmplname As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtEmpbirthday As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtEmphiredate As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txtEmpsalary As TextBox
    Friend WithEvents cboEmpdep As ComboBox
End Class
