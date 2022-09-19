<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMain
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.DgvTxtId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DgvTxtFirst = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DgvTxtLast = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DgvCbxGender = New System.Windows.Forms.DataGridViewComboBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DgvTxtId, Me.DgvTxtFirst, Me.DgvTxtLast, Me.DgvCbxGender})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(789, 397)
        Me.DataGridView1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 415)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Refresh"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(369, 415)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Delete"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(726, 415)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Save"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'DgvTxtId
        '
        Me.DgvTxtId.DataPropertyName = "student_id"
        Me.DgvTxtId.HeaderText = "Id"
        Me.DgvTxtId.Name = "DgvTxtId"
        Me.DgvTxtId.ReadOnly = True
        Me.DgvTxtId.Width = 75
        '
        'DgvTxtFirst
        '
        Me.DgvTxtFirst.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DgvTxtFirst.DataPropertyName = "student_first"
        Me.DgvTxtFirst.HeaderText = "First Name"
        Me.DgvTxtFirst.Name = "DgvTxtFirst"
        '
        'DgvTxtLast
        '
        Me.DgvTxtLast.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DgvTxtLast.DataPropertyName = "student_last"
        Me.DgvTxtLast.HeaderText = "Last Name"
        Me.DgvTxtLast.Name = "DgvTxtLast"
        '
        'DgvCbxGender
        '
        Me.DgvCbxGender.DataPropertyName = "gender_id"
        Me.DgvCbxGender.HeaderText = "Gender"
        Me.DgvCbxGender.Name = "DgvCbxGender"
        Me.DgvCbxGender.Width = 125
        '
        'FrmMain
        '
        Me.AcceptButton = Me.Button3
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(813, 450)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "FrmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MySQL CRUD"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents DgvTxtId As DataGridViewTextBoxColumn
    Friend WithEvents DgvTxtFirst As DataGridViewTextBoxColumn
    Friend WithEvents DgvTxtLast As DataGridViewTextBoxColumn
    Friend WithEvents DgvCbxGender As DataGridViewComboBoxColumn
End Class
