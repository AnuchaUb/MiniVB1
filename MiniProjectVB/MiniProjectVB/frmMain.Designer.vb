<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnSell = New System.Windows.Forms.Button()
        Me.btnCus = New System.Windows.Forms.Button()
        Me.btnEmp = New System.Windows.Forms.Button()
        Me.btnDep = New System.Windows.Forms.Button()
        Me.btnCorp = New System.Windows.Forms.Button()
        Me.btnPros = New System.Windows.Forms.Button()
        Me.btnProtype = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(848, 98)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnSell)
        Me.Panel2.Controls.Add(Me.btnCus)
        Me.Panel2.Controls.Add(Me.btnEmp)
        Me.Panel2.Controls.Add(Me.btnDep)
        Me.Panel2.Controls.Add(Me.btnCorp)
        Me.Panel2.Controls.Add(Me.btnPros)
        Me.Panel2.Controls.Add(Me.btnProtype)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 98)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(848, 284)
        Me.Panel2.TabIndex = 1
        '
        'btnSell
        '
        Me.btnSell.FlatAppearance.BorderSize = 0
        Me.btnSell.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnSell.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSell.Font = New System.Drawing.Font("_Layiji MaHaNiYom V 1.2", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSell.ForeColor = System.Drawing.Color.Navy
        Me.btnSell.Image = Global.MiniProjectVB.My.Resources.Resources.icons8_Paid_75px_1
        Me.btnSell.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSell.Location = New System.Drawing.Point(12, 6)
        Me.btnSell.Name = "btnSell"
        Me.btnSell.Size = New System.Drawing.Size(160, 128)
        Me.btnSell.TabIndex = 0
        Me.btnSell.Text = "ขายสินค้า"
        Me.btnSell.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSell.UseVisualStyleBackColor = True
        '
        'btnCus
        '
        Me.btnCus.FlatAppearance.BorderSize = 0
        Me.btnCus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnCus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCus.Font = New System.Drawing.Font("_Layiji MaHaNiYom V 1.2", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCus.ForeColor = System.Drawing.Color.Navy
        Me.btnCus.Image = Global.MiniProjectVB.My.Resources.Resources.icons8_Man_75px
        Me.btnCus.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCus.Location = New System.Drawing.Point(178, 140)
        Me.btnCus.Name = "btnCus"
        Me.btnCus.Size = New System.Drawing.Size(160, 128)
        Me.btnCus.TabIndex = 0
        Me.btnCus.Text = "ลูกค้า"
        Me.btnCus.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCus.UseVisualStyleBackColor = True
        '
        'btnEmp
        '
        Me.btnEmp.FlatAppearance.BorderSize = 0
        Me.btnEmp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEmp.Font = New System.Drawing.Font("_Layiji MaHaNiYom V 1.2", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEmp.ForeColor = System.Drawing.Color.Navy
        Me.btnEmp.Image = Global.MiniProjectVB.My.Resources.Resources.icons8_Employee_75px
        Me.btnEmp.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnEmp.Location = New System.Drawing.Point(12, 140)
        Me.btnEmp.Name = "btnEmp"
        Me.btnEmp.Size = New System.Drawing.Size(160, 128)
        Me.btnEmp.TabIndex = 0
        Me.btnEmp.Text = "พนักงาน"
        Me.btnEmp.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnEmp.UseVisualStyleBackColor = True
        '
        'btnDep
        '
        Me.btnDep.FlatAppearance.BorderSize = 0
        Me.btnDep.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnDep.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDep.Font = New System.Drawing.Font("_Layiji MaHaNiYom V 1.2", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDep.ForeColor = System.Drawing.Color.Navy
        Me.btnDep.Image = Global.MiniProjectVB.My.Resources.Resources.icons8_Conference_75px
        Me.btnDep.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnDep.Location = New System.Drawing.Point(676, 6)
        Me.btnDep.Name = "btnDep"
        Me.btnDep.Size = New System.Drawing.Size(160, 128)
        Me.btnDep.TabIndex = 0
        Me.btnDep.Text = "แผนก"
        Me.btnDep.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnDep.UseVisualStyleBackColor = True
        '
        'btnCorp
        '
        Me.btnCorp.FlatAppearance.BorderSize = 0
        Me.btnCorp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnCorp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCorp.Font = New System.Drawing.Font("_Layiji MaHaNiYom V 1.2", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCorp.ForeColor = System.Drawing.Color.Navy
        Me.btnCorp.Image = Global.MiniProjectVB.My.Resources.Resources.icons8_Permanent_Job_75px
        Me.btnCorp.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCorp.Location = New System.Drawing.Point(510, 6)
        Me.btnCorp.Name = "btnCorp"
        Me.btnCorp.Size = New System.Drawing.Size(160, 128)
        Me.btnCorp.TabIndex = 0
        Me.btnCorp.Text = "บริษัทผู้ผลิต"
        Me.btnCorp.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCorp.UseVisualStyleBackColor = True
        '
        'btnPros
        '
        Me.btnPros.FlatAppearance.BorderSize = 0
        Me.btnPros.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnPros.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPros.Font = New System.Drawing.Font("_Layiji MaHaNiYom V 1.2", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPros.ForeColor = System.Drawing.Color.Navy
        Me.btnPros.Image = Global.MiniProjectVB.My.Resources.Resources.Air3
        Me.btnPros.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnPros.Location = New System.Drawing.Point(344, 6)
        Me.btnPros.Name = "btnPros"
        Me.btnPros.Size = New System.Drawing.Size(160, 128)
        Me.btnPros.TabIndex = 0
        Me.btnPros.Text = "สินค้า"
        Me.btnPros.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnPros.UseVisualStyleBackColor = True
        '
        'btnProtype
        '
        Me.btnProtype.FlatAppearance.BorderSize = 0
        Me.btnProtype.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnProtype.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProtype.Font = New System.Drawing.Font("_Layiji MaHaNiYom V 1.2", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProtype.ForeColor = System.Drawing.Color.Navy
        Me.btnProtype.Image = CType(resources.GetObject("btnProtype.Image"), System.Drawing.Image)
        Me.btnProtype.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnProtype.Location = New System.Drawing.Point(178, 6)
        Me.btnProtype.Name = "btnProtype"
        Me.btnProtype.Size = New System.Drawing.Size(160, 128)
        Me.btnProtype.TabIndex = 0
        Me.btnProtype.Text = "ประเภทสินค้า"
        Me.btnProtype.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnProtype.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(848, 388)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmMain"
        Me.Text = "Main"
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnProtype As Button
    Friend WithEvents btnPros As Button
    Friend WithEvents btnCorp As Button
    Friend WithEvents btnDep As Button
    Friend WithEvents btnEmp As Button
    Friend WithEvents btnSell As Button
    Friend WithEvents btnCus As Button
End Class
