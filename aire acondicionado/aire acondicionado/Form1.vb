Public Class Form1
    Dim Encendido As Boolean
    Dim split As Boolean
    Dim friosolo As Boolean
    Dim aire As aire
    Public Sub ActivarBotones()
        btnMasPoder.Enabled = True
        btnMax.Enabled = True
        btnMenosPoder.Enabled = True
        btnMin.Enabled = True
        btnPower.Enabled = True
    End Sub
    Public Sub ValidarTemperatura()
        btnMasPoder.Enabled = False
        btnMax.Enabled = False
        btnMenosPoder.Enabled = False
        btnMin.Enabled = False
        btnPower.Enabled = False
        Dim temperaturAire As Integer = Val(txtTemperaturaInicial.Text)
        If temperaturAire = 0 Then
            ActivarBotones()
        Else
            If aire.friosolo2 = True Then
                If aire.split2 = True Then
                    If temperaturAire >= 17 And temperaturAire <= 25 Then
                        ActivarBotones()


                    End If
                Else
                    If temperaturAire >= 18 And temperaturAire <= 24 Then
                        ActivarBotones()
                    End If
                End If
            Else
                If aire.split2 = True Then
                    If temperaturAire >= 17 And temperaturAire <= 31 Then
                        ActivarBotones()

                    End If
                Else
                    If temperaturAire >= 18 And temperaturAire <= 30 Then
                        ActivarBotones()
                    End If
                End If
            End If
        End If

    End Sub
    Private Sub RadioButtonFrioSolo_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonFrioSolo.CheckedChanged

    End Sub

    Private Sub btnPower_Click(sender As Object, e As EventArgs) Handles btnPower.Click



        Encendido = aire.power(Encendido)
        Select Case Encendido
            Case True
                lblPowerOn.Text = "On"
                If aire.temeraturaInicial2 <> 0 Then
                    lblPoder.Text = txtTemperaturaInicial.Text
                End If
                lblModelo.Text = aire.InformarModelo(txtMarca.Text, txtFrigorias.Text, txtPais.Text, friosolo, split)
            Case False
                lblPowerOn.Text = "Off"
                lblPoder.Text = "-"
                lblModelo.Text = "-"
        End Select

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnMasPoder.Enabled = False
        btnMax.Enabled = False
        btnMenosPoder.Enabled = False
        btnMin.Enabled = False
        btnPower.Enabled = False
    End Sub

    Private Sub btnAlta_Click(sender As Object, e As EventArgs) Handles btnAlta.Click
        aire = Nothing
        lblModelo.Text = ""
        lblPowerOn.Text = "Off"
        lblPoder.Text = "-"
        Encendido = False
        If RadioButtonFrioCalor.Checked = True Or RadioButtonFrioSolo.Checked = True Then
            If RadioButtonFrioSolo.Checked = True Then
                friosolo = True
            Else
                friosolo = False
            End If
            If CheckBoxSplit.Checked = True Then
                split = True
            Else
                split = False
            End If
            aire = New aire(txtMarca.Text, txtFrigorias.Text, split, txtPais.Text, friosolo, Val(txtTemperaturaInicial.Text), Encendido)
            ValidarTemperatura()
        Else
            MsgBox("Debe seleccionar entre frioSolo y frioCalor")
        End If


    End Sub

    Private Sub btnMasPoder_Click(sender As Object, e As EventArgs) Handles btnMasPoder.Click
        If txtTemperaturaInicial.Text <> "" Then
            lblPoder.Text = aire.SUBIR(Val(lblPoder.Text))
        Else
            lblPoder.Text = aire.SUBIR()
        End If

    End Sub

    Private Sub btnMenosPoder_Click(sender As Object, e As EventArgs) Handles btnMenosPoder.Click
        If txtTemperaturaInicial.Text <> "" Then
            lblPoder.Text = aire.BAJAR(Val(lblPoder.Text))
        Else
            lblPoder.Text = aire.BAJAR()
        End If

    End Sub

    Private Sub btnMin_Click(sender As Object, e As EventArgs) Handles btnMin.Click
        lblPoder.Text = aire.BAJAR()
    End Sub

    Private Sub btnMax_Click(sender As Object, e As EventArgs) Handles btnMax.Click
        lblPoder.Text = aire.SUBIR()
    End Sub
End Class
