Public Class Form1
    Private Sub btnDisplay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisplay.Click
        Dim lotSize, numOfPay, userAnswer As Integer
        Dim weeklyFee, serCharge, perPay, totalPay As Double
        Dim fmt As String = "{0,-28}{1,-10:C}"
        'if the lotSize is blank
        If txtBox.Text = "" Then
            'display an error message
            MessageBox.Show("Please enter the value for the Lot size!", "Error Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            lotSize = CInt(txtBox.Text)
            If lotSize <= 0 Then
                MessageBox.Show("Enter a positive number!")
                'End If
                If (lotSize > 600) Then
                    weeklyFee = 50
                ElseIf (lotSize >= 400) Then
                    weeklyFee = 40
                Else
                    weeklyFee = 30
                End If
                If rad1.Checked = True Then
                    numOfPay = 1
                    serCharge = 0
                ElseIf rad2.Checked = True Then
                    numOfPay = 2
                    serCharge = 5
                Else
                    numOfPay = 20
                    serCharge = 3
                End If
            End If
            perPay = weeklyFee * 20 / numOfPay + serCharge
                totalPay = perPay * numOfPay
                'use a message box confirm the inputs with the user
                userAnswer = MessageBox.Show("Are you sure you want to submit?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If userAnswer = vbYes Then
                    'print the results
                    lstBox.Items.Clear()
                    lstBox.Items.Add(String.Format(fmt, "The Lot Size", lotSize & " (Sq Ft)"))
                    lstBox.Items.Add(String.Format(fmt, "Number fo Payments", numOfPay))
                    lstBox.Items.Add(String.Format(fmt, "Weekly Fee", weeklyFee))
                    lstBox.Items.Add(String.Format(fmt, "Service Charge", serCharge))
                    ' Else
                End If
            End If
        ' End If
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'set the first radio button on
        rad1.Checked = True
    End Sub
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'clear the ListBox control
        lstBox.Items.Clear()
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'close the Application
        Application.Exit()
    End Sub
End Class
