<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBill
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
        Me.cboMonths = New System.Windows.Forms.ComboBox()
        Me.btnStatistics = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblSavings = New System.Windows.Forms.Label()
        Me.lblMaxSavings = New System.Windows.Forms.Label()
        Me.lblAverageSavings = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboMonths
        '
        Me.cboMonths.FormattingEnabled = True
        Me.cboMonths.ItemHeight = 20
        Me.cboMonths.Location = New System.Drawing.Point(423, 154)
        Me.cboMonths.Name = "cboMonths"
        Me.cboMonths.Size = New System.Drawing.Size(177, 28)
        Me.cboMonths.TabIndex = 0
        '
        'btnStatistics
        '
        Me.btnStatistics.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnStatistics.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStatistics.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnStatistics.Location = New System.Drawing.Point(232, 344)
        Me.btnStatistics.Name = "btnStatistics"
        Me.btnStatistics.Size = New System.Drawing.Size(258, 44)
        Me.btnStatistics.TabIndex = 1
        Me.btnStatistics.Text = "Display Statistics"
        Me.btnStatistics.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WeeklyAssignment8.My.Resources.Resources.smarthome
        Me.PictureBox1.Location = New System.Drawing.Point(-1, -3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(320, 267)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Black", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(381, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(266, 93)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Smart Home Electric Savings"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblSavings
        '
        Me.lblSavings.AutoSize = True
        Me.lblSavings.Font = New System.Drawing.Font("Segoe UI Black", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSavings.Location = New System.Drawing.Point(142, 291)
        Me.lblSavings.Name = "lblSavings"
        Me.lblSavings.Size = New System.Drawing.Size(348, 28)
        Me.lblSavings.TabIndex = 4
        Me.lblSavings.Text = "XXXXXXXXXXXXXXXXXXXXXXXX"
        '
        'lblMaxSavings
        '
        Me.lblMaxSavings.AutoSize = True
        Me.lblMaxSavings.Font = New System.Drawing.Font("Segoe UI Black", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaxSavings.Location = New System.Drawing.Point(142, 466)
        Me.lblMaxSavings.Name = "lblMaxSavings"
        Me.lblMaxSavings.Size = New System.Drawing.Size(348, 28)
        Me.lblMaxSavings.TabIndex = 5
        Me.lblMaxSavings.Text = "XXXXXXXXXXXXXXXXXXXXXXXX"
        '
        'lblAverageSavings
        '
        Me.lblAverageSavings.AutoSize = True
        Me.lblAverageSavings.Font = New System.Drawing.Font("Segoe UI Black", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAverageSavings.Location = New System.Drawing.Point(142, 405)
        Me.lblAverageSavings.Name = "lblAverageSavings"
        Me.lblAverageSavings.Size = New System.Drawing.Size(348, 28)
        Me.lblAverageSavings.TabIndex = 6
        Me.lblAverageSavings.Text = "XXXXXXXXXXXXXXXXXXXXXXXX"
        '
        'frmBill
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AntiqueWhite
        Me.ClientSize = New System.Drawing.Size(720, 539)
        Me.Controls.Add(Me.lblAverageSavings)
        Me.Controls.Add(Me.lblMaxSavings)
        Me.Controls.Add(Me.lblSavings)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnStatistics)
        Me.Controls.Add(Me.cboMonths)
        Me.Name = "frmBill"
        Me.Text = "Smart Home Application"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cboMonths As ComboBox
    Friend WithEvents btnStatistics As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblSavings As Label
    Friend WithEvents lblMaxSavings As Label
    Friend WithEvents lblAverageSavings As Label
End Class
