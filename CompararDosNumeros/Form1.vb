Public Class Form1

    
    Private Sub btnComparar1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnComparar1.Click
        If Val(txtNum1.Text) > Val(txtNum2.Text) Then
            lblR.Text = "El numero mayor es: " & Val(txtNum1.Text)
        Else
            lblR.Text = "El numero mayor es: " & Val(txtNum2.Text)
        End If
    End Sub

    Private Sub btnComparar2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnComparar2.Click
        If Val(txtNum3.Text) > Val(txtNum4.Text) Then
            If Val(txtNum3.Text) > Val(txtNum5.Text) Then
                lblR2.Text = "El numero mayor es: " & txtNum3.Text
            Else
                lblR2.Text = "El numero mayor es: " & txtNum5.Text
            End If
        Else
            If Val(txtNum4.Text) > Val(txtNum5.Text) Then
                lblR2.Text = "El numero mayor es: " & txtNum4.Text
            Else
                lblR2.Text = "El numero mayor es: " & txtNum5.Text
            End If
        End If
    End Sub

    Private Sub btnComparar3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnComparar3.Click
        If Val(txtNum6.Text) > (Val(txtNum7.Text)) And (Val(txtNum6.Text)) > (Val(txtNum8.Text)) And (Val(txtNum6.Text)) > (Val(txtNum9.Text)) Then
            Label12.Text = "es mayor " + txtNum6.Text
        End If
        If Val(txtNum7.Text) > (Val(txtNum6.Text)) And (Val(txtNum7.Text)) > (Val(txtNum8.Text)) And (Val(txtNum7.Text)) > (Val(txtNum9.Text)) Then
            Label12.Text = "es mayor " + txtNum7.Text
        End If
        If Val(txtNum8.Text) > (Val(txtNum6.Text)) And (Val(txtNum8.Text)) > (Val(txtNum7.Text)) And (Val(txtNum8.Text)) > (Val(txtNum9.Text)) Then
            Label12.Text = "es mayor " + txtNum8.Text
        End If
        If Val(txtNum9.Text) > (Val(txtNum6.Text)) And (Val(txtNum9.Text)) > (Val(txtNum7.Text)) And (Val(txtNum9.Text)) > (Val(txtNum8.Text)) Then
            Label12.Text = "es mayor " + txtNum9.Text
        End If


    End Sub
    'If Val(txtNum6.Text) > Val(txtNum7.Text) Then
    '      If Val(txtNum6.Text) > Val(txtNum8.Text) Then
    '          If Val(txtNum6.Text) > Val(txtNum9.Text) Then
    '              Label12.Text = "El numero mayor es: " + txtNum6.Text
    '          Else
    '              Label12.Text = "El numero mayor es: " + txtNum9.Text
    '          End If
    '      Else
    '          If Val(txtNum7.Text) > Val(txtNum8.Text) Then
    '              Label12.Text = "El numero mayor es: " + txtNum7.Text
    '          Else
    '              Label12.Text = "El numero mayor es: " + txtNum8.Text
    '          End If

    '          If Val(txtNum8.Text) > Val(txtNum9.Text) Then
    '              Label12.Text = "El numero mayor es: " + txtNum8.Text
    '          Else
    '              Label12.Text = "El numero mayor es: " + txtNum9.Text


    '          End If

    '          End If
    '      End If
End Class
