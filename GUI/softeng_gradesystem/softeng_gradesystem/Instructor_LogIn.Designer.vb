<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Instructor_LogIn
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Last = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.First = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Midd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ex = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ID1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StudentName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quiz1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quiz2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quiz3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Mid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 159.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 183.0!))
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(53, 64)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(394, 21)
        Me.TableLayoutPanel1.TabIndex = 9
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.Last, Me.First, Me.Midd, Me.Ex})
        Me.DataGridView2.Location = New System.Drawing.Point(41, 31)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(631, 18)
        Me.DataGridView2.TabIndex = 8
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
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.LineShape1.BorderWidth = 3
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 26
        Me.LineShape1.X2 = 690
        Me.LineShape1.Y1 = 18
        Me.LineShape1.Y2 = 18
        '
        'LineShape2
        '
        Me.LineShape2.BorderColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.LineShape2.BorderWidth = 3
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 26
        Me.LineShape2.X2 = 690
        Me.LineShape2.Y1 = 58
        Me.LineShape2.Y2 = 58
        '
        'LineShape3
        '
        Me.LineShape3.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.LineShape3.BorderWidth = 3
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = 41
        Me.LineShape3.X2 = 675
        Me.LineShape3.Y1 = 91
        Me.LineShape3.Y2 = 91
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape3, Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(720, 317)
        Me.ShapeContainer1.TabIndex = 10
        Me.ShapeContainer1.TabStop = False
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(467, 64)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(88, 21)
        Me.ComboBox1.TabIndex = 11
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(572, 64)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(88, 21)
        Me.ComboBox2.TabIndex = 12
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlDark
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID1, Me.StudentName, Me.Quiz1, Me.Quiz2, Me.Quiz3, Me.Mid})
        Me.DataGridView1.Location = New System.Drawing.Point(43, 119)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(617, 126)
        Me.DataGridView1.TabIndex = 13
        '
        'ID1
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.ID1.DefaultCellStyle = DataGridViewCellStyle3
        Me.ID1.HeaderText = "ID Number"
        Me.ID1.Name = "ID1"
        '
        'StudentName
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.StudentName.DefaultCellStyle = DataGridViewCellStyle4
        Me.StudentName.HeaderText = "Student Name"
        Me.StudentName.Name = "StudentName"
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
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button1.Location = New System.Drawing.Point(587, 276)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(121, 29)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "LOG OUT"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Instructor_LogIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(720, 317)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "Instructor_LogIn"
        Me.Text = "Instructor_LogIn"
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Last As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents First As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Midd As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ex As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape3 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents ID1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StudentName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Quiz1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Quiz2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Quiz3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Mid As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
