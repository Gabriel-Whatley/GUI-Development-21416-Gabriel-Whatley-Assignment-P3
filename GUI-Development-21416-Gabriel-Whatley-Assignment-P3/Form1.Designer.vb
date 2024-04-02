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
        rdio_fruit = New RadioButton()
        rdio_sausage = New RadioButton()
        rdio_veggie = New RadioButton()
        rdio_pinwheel = New RadioButton()
        rdio_singl_shrimp = New RadioButton()
        Label1 = New Label()
        Label2 = New Label()
        rdio_pickup_pay = New RadioButton()
        rdio_pre_pay = New RadioButton()
        Label3 = New Label()
        textbox_input = New TextBox()
        btn_calc = New Button()
        btn_clear = New Button()
        lbl_output = New Label()
        Panel1 = New Panel()
        Panel2 = New Panel()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
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
        ' rdio_fruit
        ' 
        rdio_fruit.AutoSize = True
        rdio_fruit.Font = New Font("Courier New", 10F, FontStyle.Bold)
        rdio_fruit.Location = New Point(13, 113)
        rdio_fruit.Name = "rdio_fruit"
        rdio_fruit.Size = New Size(121, 20)
        rdio_fruit.TabIndex = 4
        rdio_fruit.TabStop = True
        rdio_fruit.Text = "Fruit $29.99"
        rdio_fruit.UseVisualStyleBackColor = True
        ' 
        ' rdio_sausage
        ' 
        rdio_sausage.AutoSize = True
        rdio_sausage.Font = New Font("Courier New", 10F, FontStyle.Bold)
        rdio_sausage.Location = New Point(13, 88)
        rdio_sausage.Name = "rdio_sausage"
        rdio_sausage.Size = New Size(225, 20)
        rdio_sausage.TabIndex = 3
        rdio_sausage.TabStop = True
        rdio_sausage.Text = "Sausage and Cheese $49.99"
        rdio_sausage.UseVisualStyleBackColor = True
        ' 
        ' rdio_veggie
        ' 
        rdio_veggie.AutoSize = True
        rdio_veggie.Font = New Font("Courier New", 10F, FontStyle.Bold)
        rdio_veggie.Location = New Point(13, 63)
        rdio_veggie.Name = "rdio_veggie"
        rdio_veggie.Size = New Size(129, 20)
        rdio_veggie.TabIndex = 2
        rdio_veggie.TabStop = True
        rdio_veggie.Text = "Veggie $29.99"
        rdio_veggie.UseVisualStyleBackColor = True
        ' 
        ' rdio_pinwheel
        ' 
        rdio_pinwheel.AutoSize = True
        rdio_pinwheel.Font = New Font("Courier New", 10F, FontStyle.Bold)
        rdio_pinwheel.Location = New Point(13, 38)
        rdio_pinwheel.Name = "rdio_pinwheel"
        rdio_pinwheel.Size = New Size(193, 20)
        rdio_pinwheel.TabIndex = 1
        rdio_pinwheel.TabStop = True
        rdio_pinwheel.Text = "Pinwheel Wraps $59.99"
        rdio_pinwheel.UseVisualStyleBackColor = True
        ' 
        ' rdio_singl_shrimp
        ' 
        rdio_singl_shrimp.AutoSize = True
        rdio_singl_shrimp.Font = New Font("Courier New", 10F, FontStyle.Bold)
        rdio_singl_shrimp.Location = New Point(13, 13)
        rdio_singl_shrimp.Name = "rdio_singl_shrimp"
        rdio_singl_shrimp.Size = New Size(201, 20)
        rdio_singl_shrimp.TabIndex = 0
        rdio_singl_shrimp.TabStop = True
        rdio_singl_shrimp.Text = "A Single Shrimp $49.99"
        rdio_singl_shrimp.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Freestyle Script", 60F, FontStyle.Bold)
        Label1.Location = New Point(51, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(223, 95)
        Label1.TabIndex = 2
        Label1.Text = "Catering"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(113, 89)
        Label2.Name = "Label2"
        Label2.Size = New Size(98, 21)
        Label2.TabIndex = 3
        Label2.Text = "Star Market"
        ' 
        ' rdio_pickup_pay
        ' 
        rdio_pickup_pay.AutoSize = True
        rdio_pickup_pay.Font = New Font("Courier New", 10F, FontStyle.Bold)
        rdio_pickup_pay.Location = New Point(13, 39)
        rdio_pickup_pay.Name = "rdio_pickup_pay"
        rdio_pickup_pay.Size = New Size(145, 20)
        rdio_pickup_pay.TabIndex = 1
        rdio_pickup_pay.TabStop = True
        rdio_pickup_pay.Text = "Pay upon Pickup"
        rdio_pickup_pay.UseVisualStyleBackColor = True
        ' 
        ' rdio_pre_pay
        ' 
        rdio_pre_pay.AutoSize = True
        rdio_pre_pay.Font = New Font("Courier New", 10F, FontStyle.Bold)
        rdio_pre_pay.Location = New Point(13, 13)
        rdio_pre_pay.Name = "rdio_pre_pay"
        rdio_pre_pay.Size = New Size(81, 20)
        rdio_pre_pay.TabIndex = 0
        rdio_pre_pay.TabStop = True
        rdio_pre_pay.Text = "Pre-Pay"
        rdio_pre_pay.UseVisualStyleBackColor = True
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
        textbox_input.TextAlign = HorizontalAlignment.Center
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
        lbl_output.Location = New Point(71, 399)
        lbl_output.Name = "lbl_output"
        lbl_output.Size = New Size(95, 21)
        lbl_output.TabIndex = 9
        lbl_output.Text = "Please Pay:"
        ' 
        ' Panel1
        ' 
        Panel1.AutoSize = True
        Panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink
        Panel1.BackColor = Color.PapayaWhip
        Panel1.Controls.Add(rdio_fruit)
        Panel1.Controls.Add(rdio_singl_shrimp)
        Panel1.Controls.Add(rdio_sausage)
        Panel1.Controls.Add(rdio_pinwheel)
        Panel1.Controls.Add(rdio_veggie)
        Panel1.Location = New Point(36, 132)
        Panel1.Name = "Panel1"
        Panel1.Padding = New Padding(10)
        Panel1.Size = New Size(251, 146)
        Panel1.TabIndex = 10
        ' 
        ' Panel2
        ' 
        Panel2.AutoSize = True
        Panel2.AutoSizeMode = AutoSizeMode.GrowAndShrink
        Panel2.BackColor = Color.PapayaWhip
        Panel2.Controls.Add(rdio_pickup_pay)
        Panel2.Controls.Add(rdio_pre_pay)
        Panel2.Location = New Point(71, 301)
        Panel2.Name = "Panel2"
        Panel2.Padding = New Padding(10)
        Panel2.Size = New Size(171, 72)
        Panel2.TabIndex = 11
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Wheat
        ClientSize = New Size(697, 462)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(lbl_output)
        Controls.Add(btn_clear)
        Controls.Add(btn_calc)
        Controls.Add(textbox_input)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Name = "Form1"
        Text = "Catering"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents rdio_fruit As RadioButton
    Friend WithEvents rdio_sausage As RadioButton
    Friend WithEvents rdio_veggie As RadioButton
    Friend WithEvents rdio_pinwheel As RadioButton
    Friend WithEvents rdio_singl_shrimp As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents rdio_pickup_pay As RadioButton
    Friend WithEvents rdio_pre_pay As RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents textbox_input As TextBox
    Friend WithEvents btn_calc As Button
    Friend WithEvents btn_clear As Button
    Friend WithEvents lbl_output As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel

End Class
