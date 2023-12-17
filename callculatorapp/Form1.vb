Public Class Form1

    Dim firstvalue, seconvalue, result As Double
    Dim op As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnBS.Click
        If (txtDisplay.Text.Length > 0) Then
            txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1, 1)
        End If

        If (txtDisplay.Text = "") Then
            txtDisplay.Text = "0"
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnCE.Click
        txtDisplay.Text = "0"
    End Sub

    Private Sub Number_Click(sender As Object, e As EventArgs) Handles btn9.Click, btn8.Click, btn7.Click, btn3.Click, btn2.Click, btn1.Click, btn6.Click, btn5.Click, btn4.Click, btnDT.Click, btnZ.Click
        Dim b As Button = sender

        If (txtDisplay.Text = "0") Then
            txtDisplay.Text = ""
            txtDisplay.Text = b.Text

        ElseIf (b.Text = ".") Then
            If (Not txtDisplay.Text.Contains(".")) Then
                txtDisplay.Text = txtDisplay.Text + b.Text
            End If

        Else
            txtDisplay.Text = txtDisplay.Text + b.Text
        End If
    End Sub

    Private Sub Operator_Click(sender As Object, e As EventArgs) Handles btnP.Click, btnD.Click, btnM.Click, btnA.Click
        Dim b As Button = sender

        firstvalue = txtDisplay.Text
        op = b.Text
        txtDisplay.Text = ""
    End Sub

    Private Sub btnE_Click(sender As Object, e As EventArgs) Handles btnE.Click
        seconvalue = txtDisplay.Text
        If op = "+" Then
            result = firstvalue + seconvalue
            txtDisplay.Text = result

        ElseIf op = "-" Then
            result = firstvalue - seconvalue
            txtDisplay.Text = result

        ElseIf op = "*" Then
            result = firstvalue * seconvalue
            txtDisplay.Text = result

        ElseIf op = "/" Then
            result = firstvalue / seconvalue
            txtDisplay.Text = result

        End If
    End Sub

    Private Sub btnPM_Click(sender As Object, e As EventArgs) Handles btnPM.Click
        If (txtDisplay.Text.Contains("-")) Then
            txtDisplay.Text = txtDisplay.Text.Remove(0, 1)

        Else
            txtDisplay.Text = "-" + txtDisplay.Text
        End If
    End Sub

    Private Sub btnC_Click(sender As Object, e As EventArgs) Handles btnC.Click
        txtDisplay.Text = "0"
    End Sub
End Class
