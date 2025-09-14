Imports System.Reflection.Metadata

Public Class aire
    Private marca As String
    Private frigoria As Integer
    Private split As Boolean
    Private pais As String
    Private friosolo As Boolean
    Private temperatura As Integer
    Private encendido As Boolean
    Private temperaturaInicial As Integer

    Public Property temeraturaInicial2 As Integer
        Get
            Return temperaturaInicial
        End Get
        Set(value As Integer)
            If value <> 0 Then
                If friosolo2 = True Then
                    'Analizo para frioSolo
                    If value >= 18 And value <= 24 Then
                        temperaturaInicial = value
                        'Analizo para friosolo +split
                        If split2 = True Then

                            If value >= 17 And value <= 25 Then
                                temperaturaInicial = value
                            End If
                        End If
                    Else
                        MsgBox("Valor de temperatura invalido")
                    End If

                Else
                    'Analizo para frioCalor
                    If value >= 18 And value <= 30 Then
                        temperaturaInicial = value
                        'Analizo para frioCalor+Split
                        If split2 = True Then
                            If value >= 17 And value <= 31 Then
                                temperaturaInicial = value
                            End If
                        End If
                    Else
                        MsgBox("Valor de temperatura invalido")
                    End If

                End If
            Else
                temperaturaInicial = value
            End If

        End Set
    End Property
    Public Property marca2 As String
        Get
            Return marca
        End Get
        Set(value As String)
            Dim longitud As Integer
            Dim aux As Integer

            longitud = Len(value)
            For i = 0 To longitud - 1

                If IsNumeric(value(i)) Then
                    aux = aux + 1
                End If
            Next i
            If aux >= 1 Then
                MsgBox("Marca invalida, no debe contener valores numericos")

            Else
                marca = value
            End If
        End Set
    End Property
    Public Property frigoria2 As Integer
        Get
            Return frigoria
        End Get
        Set(value As Integer)
            If value > 0 Then
                frigoria = value
            Else
                MsgBox("Valor de Frigoria invalido")

            End If
        End Set
    End Property
    Public Property split2 As Boolean
        Get
            Return split
        End Get
        Set(value As Boolean)
            split = value
        End Set
    End Property
    Public Property pais2 As String
        Get
            Return pais
        End Get
        Set(value As String)
            Dim longitud As Integer
            Dim aux As Integer

            longitud = Len(value)
            For i = 0 To longitud - 1

                If IsNumeric(value(i)) Then
                    aux = aux + 1
                End If
            Next i
            If aux >= 1 Then
                MsgBox("Pais invalido, no debe contener valores numericos")

            Else
                pais = value.ToUpper()
            End If
        End Set
    End Property
    Public Property friosolo2 As Boolean
        Get
            Return friosolo
        End Get
        Set(value As Boolean)
            friosolo = value
        End Set
    End Property
    Public Property temperatura2 As Integer
        Get
            Return temperatura
        End Get
        Set(value As Integer)
            temperatura = value
        End Set
    End Property
    Public Property encendido2 As Boolean
        Get
            Return encendido
        End Get
        Set(value As Boolean)
            encendido = value
        End Set
    End Property
    Public Sub New(marca As String, frigorias As Integer, split As Boolean, pais As String, friosolo As Boolean, temperaturaInicial As Integer, encendido As Boolean)
        Me.marca2 = marca
        Me.frigoria2 = frigorias
        Me.split2 = split
        Me.pais2 = pais
        Me.friosolo2 = friosolo
        Me.temeraturaInicial2 = temperaturaInicial
        Me.encendido2 = encendido
    End Sub

    Public Sub New()

    End Sub
    Public Function InformarModelo(marca As String, frigorias As Integer, pais As String, friosolo As Boolean, split As Boolean) As String
        Dim modelo As String
        Dim letraspais As String
        Dim letrasmarca As String
        If pais.Length() >= 3 Then
            letraspais = pais.Substring(0, 3)
        Else
            letraspais = pais.Substring(0, pais.Length())
        End If
        If marca.Length() >= 3 Then
            letrasmarca = marca.Substring(0, 3)
        Else
            letrasmarca = marca.Substring(0, marca.Length())
        End If
        modelo = letrasmarca + Convert.ToString(frigorias) + letraspais
        If (friosolo = True) Then
            modelo = modelo + "/FS"
        Else
            modelo = modelo + "/FC"
        End If
        If (split = True) Then
            modelo = modelo + "/S"
        End If


        Return modelo
    End Function

    Public Function power(Estado As Boolean) As Boolean
        If (Estado = False) Then
            encendido = True

        Else
            encendido = False
        End If
        Return encendido
    End Function

    Public Function SUBIR() As Integer
        Dim temperaturaMax As Integer
        If friosolo = True Then

            If split = True Then
                temperaturaMax = 25
            Else
                temperaturaMax = 24
            End If
        Else

            If split = True Then
                temperaturaMax = 31
            Else

                temperaturaMax = 30
            End If
        End If
        Return temperaturaMax
    End Function

    Public Function BAJAR() As Integer
        Dim temperaturaMin As Integer
        If split = True Then
            temperaturaMin = 17

        Else
            temperaturaMin = 18
        End If
        Return temperaturaMin
    End Function

    Public Function SUBIR(temperaturaRecibida As Integer) As Integer

        If friosolo = True Then

            If split = True Then
                If temperaturaRecibida >= 17 And temperaturaRecibida < 25 Then
                    temperaturaRecibida = temperaturaRecibida + 1
                End If
            Else
                If temperaturaRecibida >= 18 And temperaturaRecibida < 24 Then
                    temperaturaRecibida = temperaturaRecibida + 1
                End If
            End If
        Else

            If split = True Then
                If temperaturaRecibida >= 17 And temperaturaRecibida < 31 Then
                    temperaturaRecibida = temperaturaRecibida + 1
                End If
            Else
                If temperaturaRecibida >= 18 And temperaturaRecibida < 30 Then
                    temperaturaRecibida = temperaturaRecibida + 1
                End If
            End If

        End If

        Return temperaturaRecibida
    End Function
    Public Function BAJAR(temperaturaRecibida As Integer) As Integer

        If friosolo = True Then

            If split = True Then
                If temperaturaRecibida > 17 And temperaturaRecibida <= 25 Then
                    temperaturaRecibida = temperaturaRecibida - 1
                End If
            Else
                If temperaturaRecibida > 18 And temperaturaRecibida <= 24 Then
                    temperaturaRecibida = temperaturaRecibida - 1
                End If
            End If
        Else

            If split = True Then
                If temperaturaRecibida > 17 And temperaturaRecibida <= 31 Then
                    temperaturaRecibida = temperaturaRecibida - 1
                End If
            Else
                If temperaturaRecibida > 18 And temperaturaRecibida <= 30 Then
                    temperaturaRecibida = temperaturaRecibida - 1
                End If
            End If

        End If

        Return temperaturaRecibida
    End Function


End Class
