<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.basePrice = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tradeIn = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Chk3 = New System.Windows.Forms.CheckBox()
        Me.Chk2 = New System.Windows.Forms.CheckBox()
        Me.Chk1 = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Rad3 = New System.Windows.Forms.RadioButton()
        Me.Rad2 = New System.Windows.Forms.RadioButton()
        Me.Rad1 = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.subTotal = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTax = New System.Windows.Forms.TextBox()
        Me.Total = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Calculate = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Base Price:"
        '
        'basePrice
        '
        Me.basePrice.Location = New System.Drawing.Point(91, 34)
        Me.basePrice.Name = "basePrice"
        Me.basePrice.Size = New System.Drawing.Size(186, 20)
        Me.basePrice.TabIndex = 1
        Me.basePrice.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(371, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Trade-In Allowance:"
        '
        'tradeIn
        '
        Me.tradeIn.Location = New System.Drawing.Point(489, 34)
        Me.tradeIn.Name = "tradeIn"
        Me.tradeIn.Size = New System.Drawing.Size(186, 20)
        Me.tradeIn.TabIndex = 3
        Me.tradeIn.Text = "0"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Chk3)
        Me.GroupBox1.Controls.Add(Me.Chk2)
        Me.GroupBox1.Controls.Add(Me.Chk1)
        Me.GroupBox1.Location = New System.Drawing.Point(29, 93)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(248, 138)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Additional Accessories"
        '
        'Chk3
        '
        Me.Chk3.AutoSize = True
        Me.Chk3.Location = New System.Drawing.Point(20, 101)
        Me.Chk3.Name = "Chk3"
        Me.Chk3.Size = New System.Drawing.Size(125, 17)
        Me.Chk3.TabIndex = 2
        Me.Chk3.Text = "Computer Navigation"
        Me.Chk3.UseVisualStyleBackColor = True
        '
        'Chk2
        '
        Me.Chk2.AutoSize = True
        Me.Chk2.Location = New System.Drawing.Point(20, 66)
        Me.Chk2.Name = "Chk2"
        Me.Chk2.Size = New System.Drawing.Size(97, 17)
        Me.Chk2.TabIndex = 1
        Me.Chk2.Text = "Leather Interior"
        Me.Chk2.UseVisualStyleBackColor = True
        '
        'Chk1
        '
        Me.Chk1.AutoSize = True
        Me.Chk1.Location = New System.Drawing.Point(20, 32)
        Me.Chk1.Name = "Chk1"
        Me.Chk1.Size = New System.Drawing.Size(94, 17)
        Me.Chk1.TabIndex = 0
        Me.Chk1.Text = "Stereo System"
        Me.Chk1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Rad3)
        Me.GroupBox2.Controls.Add(Me.Rad2)
        Me.GroupBox2.Controls.Add(Me.Rad1)
        Me.GroupBox2.Location = New System.Drawing.Point(374, 93)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(248, 138)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Exterior Finish"
        '
        'Rad3
        '
        Me.Rad3.AutoSize = True
        Me.Rad3.Location = New System.Drawing.Point(19, 101)
        Me.Rad3.Name = "Rad3"
        Me.Rad3.Size = New System.Drawing.Size(123, 17)
        Me.Rad3.TabIndex = 2
        Me.Rad3.TabStop = True
        Me.Rad3.Text = "Customized Detailing"
        Me.Rad3.UseVisualStyleBackColor = True
        '
        'Rad2
        '
        Me.Rad2.AutoSize = True
        Me.Rad2.Location = New System.Drawing.Point(19, 65)
        Me.Rad2.Name = "Rad2"
        Me.Rad2.Size = New System.Drawing.Size(112, 17)
        Me.Rad2.TabIndex = 1
        Me.Rad2.TabStop = True
        Me.Rad2.Text = "Pearlized Detailing"
        Me.Rad2.UseVisualStyleBackColor = True
        '
        'Rad1
        '
        Me.Rad1.AutoSize = True
        Me.Rad1.Location = New System.Drawing.Point(19, 31)
        Me.Rad1.Name = "Rad1"
        Me.Rad1.Size = New System.Drawing.Size(112, 17)
        Me.Rad1.TabIndex = 0
        Me.Rad1.TabStop = True
        Me.Rad1.Text = "Standard Detailing"
        Me.Rad1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(115, 293)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "SUB-TOTAL:"
        '
        'subTotal
        '
        Me.subTotal.Location = New System.Drawing.Point(198, 290)
        Me.subTotal.Name = "subTotal"
        Me.subTotal.Size = New System.Drawing.Size(292, 20)
        Me.subTotal.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 354)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(180, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "SUB-TOTAL Less Sales Tax of 16%:"
        '
        'txtTax
        '
        Me.txtTax.Location = New System.Drawing.Point(198, 347)
        Me.txtTax.Name = "txtTax"
        Me.txtTax.Size = New System.Drawing.Size(292, 20)
        Me.txtTax.TabIndex = 10
        '
        'Total
        '
        Me.Total.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Total.Location = New System.Drawing.Point(198, 407)
        Me.Total.Name = "Total"
        Me.Total.Size = New System.Drawing.Size(292, 21)
        Me.Total.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 414)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(163, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "TOTAL Less any Trade-In Value:"
        '
        'btnClear
        '
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Location = New System.Drawing.Point(25, 488)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(153, 44)
        Me.btnClear.TabIndex = 13
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Calculate
        '
        Me.Calculate.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Calculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Calculate.Location = New System.Drawing.Point(209, 488)
        Me.Calculate.Name = "Calculate"
        Me.Calculate.Size = New System.Drawing.Size(255, 44)
        Me.Calculate.TabIndex = 14
        Me.Calculate.Text = "CALCULATE"
        Me.Calculate.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Location = New System.Drawing.Point(506, 488)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(153, 44)
        Me.btnClose.TabIndex = 15
        Me.btnClose.Text = "Exit"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(705, 588)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.Calculate)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Total)
        Me.Controls.Add(Me.txtTax)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.subTotal)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.tradeIn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.basePrice)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.Text = "VB Auto Center"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents basePrice As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tradeIn As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Chk3 As System.Windows.Forms.CheckBox
    Friend WithEvents Chk2 As System.Windows.Forms.CheckBox
    Friend WithEvents Chk1 As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Rad3 As System.Windows.Forms.RadioButton
    Friend WithEvents Rad2 As System.Windows.Forms.RadioButton
    Friend WithEvents Rad1 As System.Windows.Forms.RadioButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents subTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtTax As System.Windows.Forms.TextBox
    Friend WithEvents Total As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents Calculate As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button

End Class
