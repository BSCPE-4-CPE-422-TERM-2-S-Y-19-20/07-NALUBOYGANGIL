<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Student_LogIn
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.SubjectCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubjectDes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Unit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quiz1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quiz2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quiz3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Mid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Last = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.First = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Midd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ex = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlDark
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SubjectCode, Me.SubjectDes, Me.Unit, Me.Quiz1, Me.Quiz2, Me.Quiz3, Me.Mid})
        Me.DataGridView1.Location = New System.Drawing.Point(37, 105)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(617, 126)
        Me.DataGridView1.TabIndex = 2
        '
        'SubjectCode
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.SubjectCode.DefaultCellStyle = DataGridViewCellStyle7
        Me.SubjectCode.HeaderText = "Subject Code"
        Me.SubjectCode.Name = "SubjectCode"
        '
        'SubjectDes
        '
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.SubjectDes.DefaultCellStyle = DataGridViewCellStyle8
        Me.SubjectDes.HeaderText = "Subject Description"
        Me.SubjectDes.Name = "SubjectDes"
        '
        'Unit
        '
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Unit.DefaultCellStyle = DataGridViewCellStyle9
        Me.Unit.HeaderText = "Units"
        Me.Unit.Name = "Unit"
        '
        'Quiz1
        '
        Me.Quiz1.HeaderText = "Quiz 1"
        Me.Quiz1.Name = "Quiz1"
        '
        'Quiz2
        '
        Me.Quiz2.HeaderText = "Quiz 2"
        Me.Quiz2.Name = "Quiz2"
        '
        'Quiz3
        '
        Me.Quiz3.HeaderText = "Quiz 3"
        Me.Quiz3.Name = "Quiz3"
        '
        'Mid
        '
        Me.Mid.HeaderText = "Midterms"
        Me.Mid.Name = "Mid"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape3, Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(698, 303)
        Me.ShapeContainer1.TabIndex = 3
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape3
        '
        Me.LineShape3.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.LineShape3.BorderWidth = 3
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = 34
        Me.LineShape3.X2 = 668
        Me.LineShape3.Y1 = 83
        Me.LineShape3.Y2 = 83
        '
        'LineShape2
        '
        Me.LineShape2.BorderColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.LineShape2.BorderWidth = 3
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 19
        Me.LineShape2.X2 = 683
        Me.LineShape2.Y1 = 50
        Me.LineShape2.Y2 = 50
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.LineShape1.BorderWidth = 3
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 19
        Me.LineShape1.X2 = 683
        Me.LineShape1.Y1 = 10
        Me.LineShape1.Y2 = 10
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.Last, Me.First, Me.Midd, Me.Ex})
        Me.DataGridView2.Location = New System.Drawing.Point(37, 23)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(631, 18)
        Me.DataGridView2.TabIndex = 4
        '
        'ID
        '
        Me.ID.DividerWidth = 1
        Me.ID.FillWeight = 120.0!
        Me.ID.Frozen = True
        Me.ID.HeaderText = "ID Number"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ID.Width = 84
        '
        'Last
        '
        Me.Last.DividerWidth = 1
        Me.Last.HeaderText = "Last Name"
        Me.Last.Name = "Last"
        Me.Last.Width = 150
        '
        'First
        '
        Me.First.DividerWidth = 1
        Me.First.HeaderText = "First Name"
        Me.First.Name = "First"
        Me.First.ReadOnly = True
        Me.First.Width = 150
        '
        'Midd
        '
        Me.Midd.DividerWidth = 1
        Me.Midd.HeaderText = "Middle Name"
        Me.Midd.Name = "Midd"
        Me.Midd.ReadOnly = True
        Me.Midd.Width = 150
        '
        'Ex
        '
        Me.Ex.DividerWidth = 1
        Me.Ex.HeaderText = "Ext."
        Me.Ex.Name = "Ex"
        Me.Ex.ReadOnly = True
        Me.Ex.Width = 85
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button1.Location = New System.Drawing.Point(562, 258)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(121, 29)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "LOG OUT"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(533, 56)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(128, 22)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "CURRICULUM"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 164.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 178.0!))
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(80, 56)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(422, 21)
        Me.TableLayoutPanel1.TabIndex = 7
        '
        'Student_LogIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(698, 303)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "Student_LogIn"
        Me.ShowIcon = False
        Me.Text = "Student_LogIn"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents SubjectCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SubjectDes As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Unit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Quiz1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Quiz2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Quiz3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Mid As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape3 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Last As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents First As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Midd As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ex As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
End Class
