Public Class Form1
    Dim n1 As Integer
    Dim cuadrados As Integer
    Dim cubos As Integer
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Validar()



    End Sub

    Sub Validar()
        n1 = Val(tbNumero.Text)
        If (n1 <= 0) Then
            MsgBox("Favor verifique los datos")
        Else
            Calculo()

        End If
    End Sub

    Sub Calculo()
        n1 = Val(tbNumero.Text)
        cuadrados = 0
        cubos = 0
        For i = 1 To n1
            MsgBox("Recorrido # " & i)
            If (i Mod 2 = 0) Then
                cuadrados = cuadrados + Math.Pow(i, 2)

            Else
                cubos = cubos + Math.Pow(i, 3)



            End If


        Next

        If (cuadrados > 50) Then
            listResult.Items.Add("La sumatoria de los cuadrados de los numeros pares es " + Str(cuadrados) + " >50")
        End If
        If (cubos > 50) Then
            listResult.Items.Add("La sumatoria de los cubos de los numeros impares es " + Str(cubos) + " >50")
        End If



    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub listResult_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listResult.SelectedIndexChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnSig_Click(sender As Object, e As EventArgs) Handles btnSig.Click
        Form2.Show()
        Me.Hide()

    End Sub
End Class
