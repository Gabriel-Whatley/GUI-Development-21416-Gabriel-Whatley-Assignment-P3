<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        PictureBox1 = New PictureBox()
        GroupBox1 = New GroupBox()
        RadioButton7 = New RadioButton()
        RadioButton6 = New RadioButton()
        RadioButton5 = New RadioButton()
        RadioButton4 = New RadioButton()
        RadioButton3 = New RadioButton()
        Label1 = New Label()
        Label2 = New Label()
        GroupBox2 = New GroupBox()
        RadioButton2 = New RadioButton()
        RadioButton1 = New RadioButton()
        Label3 = New Label()
        textbox_input = New TextBox()
        btn_calc = New Button()
        btn_clear = New Button()
        lbl_output = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.platter
        PictureBox1.Location = New Point(318, 10)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(362, 260)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(RadioButton7)
        GroupBox1.Controls.Add(RadioButton6)
        GroupBox1.Controls.Add(RadioButton5)
        GroupBox1.Controls.Add(RadioButton4)
        GroupBox1.Controls.Add(RadioButton3)
        GroupBox1.Location = New Point(18, 121)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(276, 177)
        GroupBox1.TabIndex = 1
        GroupBox1.TabStop = False
        GroupBox1.Text = "GroupBox1"
        ' 
        ' RadioButton7
        ' 
        RadioButton7.AutoSize = True
        RadioButton7.Font = New Font("Courier New", 10F, FontStyle.Bold)
        RadioButton7.Location = New Point(21, 129)
        RadioButton7.Name = "RadioButton7"
        RadioButton7.Size = New Size(121, 20)
        RadioButton7.TabIndex = 4
        RadioButton7.TabStop = True
        RadioButton7.Text = "Fruit $29.99"
        RadioButton7.UseVisualStyleBackColor = True
        ' 
        ' RadioButton6
        ' 
        RadioButton6.AutoSize = True
        RadioButton6.Font = New Font("Courier New", 10F, FontStyle.Bold)
        RadioButton6.Location = New Point(21, 104)
        RadioButton6.Name = "RadioButton6"
        RadioButton6.Size = New Size(225, 20)
        RadioButton6.TabIndex = 3
        RadioButton6.TabStop = True
        RadioButton6.Text = "Sausage and Cheese $49.99"
        RadioButton6.UseVisualStyleBackColor = True
        ' 
        ' RadioButton5
        ' 
        RadioButton5.AutoSize = True
        RadioButton5.Font = New Font("Courier New", 10F, FontStyle.Bold)
        RadioButton5.Location = New Point(21, 79)
        RadioButton5.Name = "RadioButton5"
        RadioButton5.Size = New Size(129, 20)
        RadioButton5.TabIndex = 2
        RadioButton5.TabStop = True
        RadioButton5.Text = "Veggie $29.99"
        RadioButton5.UseVisualStyleBackColor = True
        ' 
        ' RadioButton4
        ' 
        RadioButton4.AutoSize = True
        RadioButton4.Font = New Font("Courier New", 10F, FontStyle.Bold)
        RadioButton4.Location = New Point(21, 54)
        RadioButton4.Name = "RadioButton4"
        RadioButton4.Size = New Size(193, 20)
        RadioButton4.TabIndex = 1
        RadioButton4.TabStop = True
        RadioButton4.Text = "Pinwheel Wraps $59.99"
        RadioButton4.UseVisualStyleBackColor = True
        ' 
        ' RadioButton3
        ' 
        RadioButton3.AutoSize = True
        RadioButton3.Font = New Font("Courier New", 10F, FontStyle.Bold)
        RadioButton3.Location = New Point(21, 29)
        RadioButton3.Name = "RadioButton3"
        RadioButton3.Size = New Size(193, 20)
        RadioButton3.TabIndex = 0
        RadioButton3.TabStop = True
        RadioButton3.Text = "Gourmet Cheese $49.99"
        RadioButton3.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(105, 21)
        Label1.Name = "Label1"
        Label1.Size = New Size(127, 37)
        Label1.TabIndex = 2
        Label1.Text = "Catering"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(118, 68)
        Label2.Name = "Label2"
        Label2.Size = New Size(98, 21)
        Label2.TabIndex = 3
        Label2.Text = "Star Market"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(RadioButton2)
        GroupBox2.Controls.Add(RadioButton1)
        GroupBox2.Location = New Point(75, 336)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(172, 79)
        GroupBox2.TabIndex = 4
        GroupBox2.TabStop = False
        GroupBox2.Text = "GroupBox2"
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Font = New Font("Courier New", 10F, FontStyle.Bold)
        RadioButton2.Location = New Point(14, 48)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(145, 20)
        RadioButton2.TabIndex = 1
        RadioButton2.TabStop = True
        RadioButton2.Text = "Pay upon Pickup"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Font = New Font("Courier New", 10F, FontStyle.Bold)
        RadioButton1.Location = New Point(14, 22)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(81, 20)
        RadioButton1.TabIndex = 0
        RadioButton1.TabStop = True
        RadioButton1.Text = "Pre-Pay"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label3.Location = New Point(379, 304)
        Label3.Name = "Label3"
        Label3.Size = New Size(118, 21)
        Label3.TabIndex = 5
        Label3.Text = "Loyalty Points"
        ' 
        ' textbox_input
        ' 
        textbox_input.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        textbox_input.Location = New Point(503, 301)
        textbox_input.Name = "textbox_input"
        textbox_input.Size = New Size(100, 29)
        textbox_input.TabIndex = 6
        ' 
        ' btn_calc
        ' 
        btn_calc.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btn_calc.Location = New Point(379, 352)
        btn_calc.Name = "btn_calc"
        btn_calc.Size = New Size(118, 38)
        btn_calc.TabIndex = 7
        btn_calc.Text = "Calculate"
        btn_calc.UseVisualStyleBackColor = True
        ' 
        ' btn_clear
        ' 
        btn_clear.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btn_clear.Location = New Point(503, 352)
        btn_clear.Name = "btn_clear"
        btn_clear.Size = New Size(118, 38)
        btn_clear.TabIndex = 8
        btn_clear.Text = "Clear"
        btn_clear.UseVisualStyleBackColor = True
        ' 
        ' lbl_output
        ' 
        lbl_output.AutoSize = True
        lbl_output.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        lbl_output.Location = New Point(39, 468)
        lbl_output.Name = "lbl_output"
        lbl_output.Size = New Size(95, 21)
        lbl_output.TabIndex = 9
        lbl_output.Text = "Please Pay:"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(697, 525)
        Controls.Add(lbl_output)
        Controls.Add(btn_clear)
        Controls.Add(btn_calc)
        Controls.Add(textbox_input)
        Controls.Add(Label3)
        Controls.Add(GroupBox2)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(GroupBox1)
        Controls.Add(PictureBox1)
        Name = "Form1"
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents RadioButton7 As RadioButton
    Friend WithEvents RadioButton6 As RadioButton
    Friend WithEvents RadioButton5 As RadioButton
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents textbox_input As TextBox
    Friend WithEvents btn_calc As Button
    Friend WithEvents btn_clear As Button
    Friend WithEvents lbl_output As Label

End Class
