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
        rdio_durian = New RadioButton()
        rdio_grits = New RadioButton()
        rdio_sushi = New RadioButton()
        rdio_boyardee = New RadioButton()
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
        pnl_dish_selection = New Panel()
        pnl_payment_type = New Panel()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        pnl_dish_selection.SuspendLayout()
        pnl_payment_type.SuspendLayout()
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
        ' rdio_durian
        ' 
        rdio_durian.AutoSize = True
        rdio_durian.Font = New Font("Courier New", 10F, FontStyle.Bold)
        rdio_durian.Location = New Point(13, 113)
        rdio_durian.Name = "rdio_durian"
        rdio_durian.Size = New Size(129, 20)
        rdio_durian.TabIndex = 4
        rdio_durian.TabStop = True
        rdio_durian.Text = "Durian $29.99"
        rdio_durian.UseVisualStyleBackColor = True
        ' 
        ' rdio_grits
        ' 
        rdio_grits.AutoSize = True
        rdio_grits.Font = New Font("Courier New", 10F, FontStyle.Bold)
        rdio_grits.Location = New Point(13, 88)
        rdio_grits.Name = "rdio_grits"
        rdio_grits.Size = New Size(201, 20)
        rdio_grits.TabIndex = 3
        rdio_grits.TabStop = True
        rdio_grits.Text = "Expensive Grits $49.99"
        rdio_grits.UseVisualStyleBackColor = True
        ' 
        ' rdio_sushi
        ' 
        rdio_sushi.AutoSize = True
        rdio_sushi.Font = New Font("Courier New", 10F, FontStyle.Bold)
        rdio_sushi.Location = New Point(13, 63)
        rdio_sushi.Name = "rdio_sushi"
        rdio_sushi.Size = New Size(121, 20)
        rdio_sushi.TabIndex = 2
        rdio_sushi.TabStop = True
        rdio_sushi.Text = "Sushi $29.99"
        rdio_sushi.UseVisualStyleBackColor = True
        ' 
        ' rdio_boyardee
        ' 
        rdio_boyardee.AutoSize = True
        rdio_boyardee.Font = New Font("Courier New", 10F, FontStyle.Bold)
        rdio_boyardee.Location = New Point(13, 38)
        rdio_boyardee.Name = "rdio_boyardee"
        rdio_boyardee.Size = New Size(185, 20)
        rdio_boyardee.TabIndex = 1
        rdio_boyardee.TabStop = True
        rdio_boyardee.Text = "Chef Boyardee $59.99"
        rdio_boyardee.UseVisualStyleBackColor = True
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
        ' pnl_dish_selection
        ' 
        pnl_dish_selection.AutoSize = True
        pnl_dish_selection.AutoSizeMode = AutoSizeMode.GrowAndShrink
        pnl_dish_selection.BackColor = Color.PapayaWhip
        pnl_dish_selection.Controls.Add(rdio_durian)
        pnl_dish_selection.Controls.Add(rdio_singl_shrimp)
        pnl_dish_selection.Controls.Add(rdio_grits)
        pnl_dish_selection.Controls.Add(rdio_boyardee)
        pnl_dish_selection.Controls.Add(rdio_sushi)
        pnl_dish_selection.Location = New Point(36, 132)
        pnl_dish_selection.Name = "pnl_dish_selection"
        pnl_dish_selection.Padding = New Padding(10)
        pnl_dish_selection.Size = New Size(227, 146)
        pnl_dish_selection.TabIndex = 10
        ' 
        ' pnl_payment_type
        ' 
        pnl_payment_type.AutoSize = True
        pnl_payment_type.AutoSizeMode = AutoSizeMode.GrowAndShrink
        pnl_payment_type.BackColor = Color.PapayaWhip
        pnl_payment_type.Controls.Add(rdio_pickup_pay)
        pnl_payment_type.Controls.Add(rdio_pre_pay)
        pnl_payment_type.Location = New Point(71, 301)
        pnl_payment_type.Name = "pnl_payment_type"
        pnl_payment_type.Padding = New Padding(10)
        pnl_payment_type.Size = New Size(171, 72)
        pnl_payment_type.TabIndex = 11
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Wheat
        ClientSize = New Size(697, 462)
        Controls.Add(pnl_payment_type)
        Controls.Add(pnl_dish_selection)
        Controls.Add(lbl_output)
        Controls.Add(btn_clear)
        Controls.Add(btn_calc)
        Controls.Add(textbox_input)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Catering"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        pnl_dish_selection.ResumeLayout(False)
        pnl_dish_selection.PerformLayout()
        pnl_payment_type.ResumeLayout(False)
        pnl_payment_type.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents rdio_durian As RadioButton
    Friend WithEvents rdio_grits As RadioButton
    Friend WithEvents rdio_sushi As RadioButton
    Friend WithEvents rdio_boyardee As RadioButton
    Friend WithEvents rdio_singl_shrimp As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents rdio_pickup_pay As RadioButton
    Friend WithEvents rdio_pre_pay As RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents textbox_input As TextBox
    Friend WithEvents btn_calc As Button
    Friend WithEvents btn_clear As Button
    Friend WithEvents lbl_output As Label
    Friend WithEvents pnl_dish_selection As Panel
    Friend WithEvents pnl_payment_type As Panel

End Class
