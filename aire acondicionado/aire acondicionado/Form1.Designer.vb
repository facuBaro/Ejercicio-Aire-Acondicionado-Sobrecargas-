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
        Panel1 = New Panel()
        txtTemperaturaInicial = New TextBox()
        Label8 = New Label()
        txtPais = New TextBox()
        txtFrigorias = New TextBox()
        txtMarca = New TextBox()
        btnAlta = New Button()
        RadioButtonFrioCalor = New RadioButton()
        RadioButtonFrioSolo = New RadioButton()
        Label4 = New Label()
        CheckBoxSplit = New CheckBox()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Panel2 = New Panel()
        lblPowerOn = New Label()
        Panel3 = New Panel()
        lblPoder = New Label()
        btnMax = New Button()
        btnMin = New Button()
        btnMenosPoder = New Button()
        btnMasPoder = New Button()
        btnPower = New Button()
        lblModelo = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.PowderBlue
        Panel1.Controls.Add(txtTemperaturaInicial)
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(txtPais)
        Panel1.Controls.Add(txtFrigorias)
        Panel1.Controls.Add(txtMarca)
        Panel1.Controls.Add(btnAlta)
        Panel1.Controls.Add(RadioButtonFrioCalor)
        Panel1.Controls.Add(RadioButtonFrioSolo)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(CheckBoxSplit)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(21, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(279, 290)
        Panel1.TabIndex = 0
        ' 
        ' txtTemperaturaInicial
        ' 
        txtTemperaturaInicial.Location = New Point(182, 144)
        txtTemperaturaInicial.Name = "txtTemperaturaInicial"
        txtTemperaturaInicial.Size = New Size(53, 23)
        txtTemperaturaInicial.TabIndex = 12
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(18, 147)
        Label8.Name = "Label8"
        Label8.Size = New Size(167, 15)
        Label8.TabIndex = 11
        Label8.Text = "Temperatura Inicial(opcional): "
        ' 
        ' txtPais
        ' 
        txtPais.Location = New Point(150, 169)
        txtPais.Name = "txtPais"
        txtPais.Size = New Size(100, 23)
        txtPais.TabIndex = 10
        ' 
        ' txtFrigorias
        ' 
        txtFrigorias.Location = New Point(152, 65)
        txtFrigorias.Name = "txtFrigorias"
        txtFrigorias.Size = New Size(100, 23)
        txtFrigorias.TabIndex = 9
        ' 
        ' txtMarca
        ' 
        txtMarca.Location = New Point(152, 27)
        txtMarca.Name = "txtMarca"
        txtMarca.Size = New Size(100, 23)
        txtMarca.TabIndex = 8
        ' 
        ' btnAlta
        ' 
        btnAlta.Location = New Point(182, 211)
        btnAlta.Name = "btnAlta"
        btnAlta.Size = New Size(75, 57)
        btnAlta.TabIndex = 7
        btnAlta.Text = "Alta"
        btnAlta.UseVisualStyleBackColor = True
        ' 
        ' RadioButtonFrioCalor
        ' 
        RadioButtonFrioCalor.AutoSize = True
        RadioButtonFrioCalor.Location = New Point(18, 236)
        RadioButtonFrioCalor.Name = "RadioButtonFrioCalor"
        RadioButtonFrioCalor.Size = New Size(78, 19)
        RadioButtonFrioCalor.TabIndex = 6
        RadioButtonFrioCalor.TabStop = True
        RadioButtonFrioCalor.Text = "Frío/Calor"
        RadioButtonFrioCalor.UseVisualStyleBackColor = True
        ' 
        ' RadioButtonFrioSolo
        ' 
        RadioButtonFrioSolo.AutoSize = True
        RadioButtonFrioSolo.Location = New Point(18, 211)
        RadioButtonFrioSolo.Name = "RadioButtonFrioSolo"
        RadioButtonFrioSolo.Size = New Size(71, 19)
        RadioButtonFrioSolo.TabIndex = 5
        RadioButtonFrioSolo.TabStop = True
        RadioButtonFrioSolo.Text = "Frio Solo"
        RadioButtonFrioSolo.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(103, 172)
        Label4.Name = "Label4"
        Label4.Size = New Size(31, 15)
        Label4.TabIndex = 4
        Label4.Text = "País:"
        ' 
        ' CheckBoxSplit
        ' 
        CheckBoxSplit.AutoSize = True
        CheckBoxSplit.Location = New Point(97, 110)
        CheckBoxSplit.Name = "CheckBoxSplit"
        CheckBoxSplit.Size = New Size(49, 19)
        CheckBoxSplit.TabIndex = 3
        CheckBoxSplit.Text = "Split"
        CheckBoxSplit.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(91, 68)
        Label3.Name = "Label3"
        Label3.Size = New Size(55, 15)
        Label3.TabIndex = 2
        Label3.Text = "Frigorías:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(103, 30)
        Label2.Name = "Label2"
        Label2.Size = New Size(43, 15)
        Label2.TabIndex = 1
        Label2.Text = "Marca:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(18, 15)
        Label1.Name = "Label1"
        Label1.Size = New Size(97, 15)
        Label1.TabIndex = 0
        Label1.Text = "Ingreso de datos:"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.Controls.Add(lblPowerOn)
        Panel2.Controls.Add(Panel3)
        Panel2.Controls.Add(btnMax)
        Panel2.Controls.Add(btnMin)
        Panel2.Controls.Add(btnMenosPoder)
        Panel2.Controls.Add(btnMasPoder)
        Panel2.Controls.Add(btnPower)
        Panel2.Controls.Add(lblModelo)
        Panel2.Controls.Add(Label6)
        Panel2.Controls.Add(Label5)
        Panel2.Location = New Point(370, 12)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(252, 290)
        Panel2.TabIndex = 1
        ' 
        ' lblPowerOn
        ' 
        lblPowerOn.AutoSize = True
        lblPowerOn.Location = New Point(114, 88)
        lblPowerOn.Name = "lblPowerOn"
        lblPowerOn.Size = New Size(12, 15)
        lblPowerOn.TabIndex = 9
        lblPowerOn.Text = "-"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        Panel3.Controls.Add(lblPoder)
        Panel3.Location = New Point(88, 111)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(92, 76)
        Panel3.TabIndex = 8
        ' 
        ' lblPoder
        ' 
        lblPoder.AutoSize = True
        lblPoder.Location = New Point(26, 36)
        lblPoder.Name = "lblPoder"
        lblPoder.Size = New Size(12, 15)
        lblPoder.TabIndex = 0
        lblPoder.Text = "-"
        ' 
        ' btnMax
        ' 
        btnMax.Location = New Point(164, 245)
        btnMax.Name = "btnMax"
        btnMax.Size = New Size(55, 31)
        btnMax.TabIndex = 7
        btnMax.Text = "Max"
        btnMax.UseVisualStyleBackColor = True
        ' 
        ' btnMin
        ' 
        btnMin.Location = New Point(49, 246)
        btnMin.Name = "btnMin"
        btnMin.Size = New Size(57, 30)
        btnMin.TabIndex = 6
        btnMin.Text = "Min"
        btnMin.UseVisualStyleBackColor = True
        ' 
        ' btnMenosPoder
        ' 
        btnMenosPoder.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnMenosPoder.Location = New Point(22, 201)
        btnMenosPoder.Name = "btnMenosPoder"
        btnMenosPoder.Size = New Size(44, 39)
        btnMenosPoder.TabIndex = 5
        btnMenosPoder.Text = "-"
        btnMenosPoder.UseVisualStyleBackColor = True
        ' 
        ' btnMasPoder
        ' 
        btnMasPoder.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnMasPoder.Location = New Point(196, 201)
        btnMasPoder.Name = "btnMasPoder"
        btnMasPoder.Size = New Size(44, 39)
        btnMasPoder.TabIndex = 4
        btnMasPoder.Text = "+"
        btnMasPoder.UseVisualStyleBackColor = True
        ' 
        ' btnPower
        ' 
        btnPower.Location = New Point(87, 201)
        btnPower.Name = "btnPower"
        btnPower.Size = New Size(93, 39)
        btnPower.TabIndex = 3
        btnPower.Text = "Power"
        btnPower.UseVisualStyleBackColor = True
        ' 
        ' lblModelo
        ' 
        lblModelo.AutoSize = True
        lblModelo.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblModelo.Location = New Point(104, 44)
        lblModelo.Name = "lblModelo"
        lblModelo.Size = New Size(16, 21)
        lblModelo.TabIndex = 2
        lblModelo.Text = "-"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(37, 50)
        Label6.Name = "Label6"
        Label6.Size = New Size(51, 15)
        Label6.TabIndex = 1
        Label6.Text = "Modelo:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(22, 15)
        Label5.Name = "Label5"
        Label5.Size = New Size(107, 15)
        Label5.TabIndex = 0
        Label5.Text = "Control De Equipo:"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Silver
        ClientSize = New Size(643, 327)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "Form1"
        Text = "Form1"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents CheckBoxSplit As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents RadioButtonFrioSolo As RadioButton
    Friend WithEvents RadioButtonFrioCalor As RadioButton
    Friend WithEvents txtPais As TextBox
    Friend WithEvents txtFrigorias As TextBox
    Friend WithEvents txtMarca As TextBox
    Friend WithEvents btnAlta As Button
    Friend WithEvents btnMenosPoder As Button
    Friend WithEvents btnMasPoder As Button
    Friend WithEvents btnPower As Button
    Friend WithEvents lblModelo As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblPoder As Label
    Friend WithEvents btnMax As Button
    Friend WithEvents btnMin As Button
    Friend WithEvents lblPowerOn As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtTemperaturaInicial As TextBox

End Class
