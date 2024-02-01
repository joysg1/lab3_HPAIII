Public Class Form2
    Dim intento As Integer
    Dim resp1 As String
    Dim resp2 As String
    Dim resp3 As String
    Dim aux1, aux2, aux3, aux4 As Integer
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        intento = Val(lbNumIntento.Text)
        intento = 0
        aux1 = 0
        aux2 = 0
        aux3 = 0
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Validar()


    End Sub


    Sub Quiz()

        Do While (intento <= 2 And aux4 <> 3)

            resp1 = InputBox("Distancia de la tierra a la Luna: ")
            If (resp1 = "384400 km") Then
                MsgBox("Respuesta correcta EXCELENTE")
                aux1 = 1

                resp2 = InputBox("Fecha de inicio Guerra de Coto")
                If (resp2 = "21 de febrero de 1921") Then
                    MsgBox("Respuesta correcta EXCELENTE")
                    aux2 = 1
                    resp3 = InputBox("Palabra mas larga del diccionario español")

                    If (resp3 = "electroencefalografista") Then
                        MsgBox("Respuesta correcta EXCELENTE")
                        aux3 = 1
                        aux4 = aux1 + aux2 + aux3
                        lbFinal.Text = "Felicitaciones a superado la prueba"

                    Else
                        MsgBox("Respuesta incorrecta")
                        IC()
                    End If
                Else
                    MsgBox("Respuesta incorrecta")
                    IC()
                End If
            Else
                MsgBox("Respuesta incorrecta")
                IC()
            End If






        Loop


    End Sub

    Sub Validar()
        If (intento = 0) Then
            intento = intento + 1
            MsgBox("Ya estas Listo?, da click nuevamente para empezar")
        ElseIf (intento <= 2) Then
            Quiz()
        Else

            MsgBox("Ya no dispone de mas intentos")
            lbFinal.Text = "Lo sentimos no ha superado la prueba"

        End If


        lbNumIntento.Text = intento



    End Sub

    Sub IC()
        intento = intento + 1
        lbNumIntento.Text = intento
    End Sub


End Class