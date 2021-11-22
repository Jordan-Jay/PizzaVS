Public Class Pizza103
    'set up a record or "class" for a student
    Class STUDENT
        Public studID As Int16
        Public firstName As String
        Public lastName As String
        Public deliveryDate As Date
        Public postcode As String
        Public quantity As Byte
        Public phoneNo As String
        Public street As String
        Public suburb As String
        Public hour As Byte
        Public minute As Byte
        Public paid As Boolean
        Public pizzaBase As String
        Public top1 As Boolean
        Public top2 As Boolean
        Public top3 As Boolean
        Public top4 As Boolean
    End Class
    Dim students(9) As STUDENT
    Dim studentCount As Integer = 0
    Dim basePrice As Single
    Dim top1Price As Single
    Dim top2Price As Single
    Dim top3Price As Single
    Dim top4Price As Single
    Dim toppedPrice As Single

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'allocate memory
        For i = 0 To 9
            students(i) = New STUDENT
        Next
        'load default prices
        basePrice = 10
        top1Price = 0.3
        top2Price = 0.45
        top3Price = 0.9
        top4Price = 1.3

        'display prices
        txtBasePrice.Text = FormatCurrency(basePrice)
        txtTop1.Text = FormatCurrency(top1Price)
        txtTop2.Text = FormatCurrency(top2Price)
        txtTop3.Text = FormatCurrency(top3Price)
        txtTop4.Text = FormatCurrency(top4Price)

        'load 4 test records
        students(0).studID = 1
        students(0).firstName = "Hungry"
        students(0).lastName = "Harry"
        students(0).deliveryDate = "28/10/21 6:30:00 PM"
        students(0).postcode = "2037"
        students(0).quantity = 2
        students(0).phoneNo = "0243-232-232"
        students(0).paid = True
        students(0).street = "25 Taylor St"
        students(0).suburb = "Glebe"
        students(0).pizzaBase = "Fat"
        students(0).top1 = True
        students(0).top2 = False
        students(0).top3 = True
        students(0).top4 = True
        students(1).studID = 2
        students(1).firstName = "Bart"
        students(1).lastName = "Simpson"
        students(1).deliveryDate = "29/10/21 4:45:00 PM"
        students(1).postcode = "2037"
        students(1).quantity = 3
        students(1).phoneNo = "0243-444-555"
        students(1).paid = True
        students(1).street = "20 Taylor St"
        students(1).suburb = "Glebe"
        students(1).pizzaBase = "Thin"
        students(1).top1 = False
        students(1).top2 = True
        students(1).top3 = True
        students(1).top4 = True
        students(2).studID = 3
        students(2).firstName = "Homer"
        students(2).lastName = "Simpson"
        students(2).deliveryDate = "29/10/21 4:45:00 PM"
        students(2).postcode = "2037"
        students(2).quantity = 3
        students(2).phoneNo = "0243-666-777"
        students(2).paid = False
        students(2).street = "19 Taylor St"
        students(2).suburb = "Glebe"
        students(2).pizzaBase = "Thin"
        students(2).top1 = False
        students(2).top2 = True
        students(2).top3 = True
        students(2).top4 = True
        'set the student count to the number of students which have been entered
        studentCount = 4
        displayList()
        CalcToppedPrice()
        CalcTotalPrice()
    End Sub
    Private Sub btnAddStud_Click(sender As Object, e As EventArgs) Handles btnAddStud.Click
        students(studentCount).studID = studentCount + 1 'allocate the new student ID to an incremented value
        'place text from text boxes into the array - first students(0), then students(1), students(2) etc
        students(studentCount).firstName = txtFirstName.Text
        students(studentCount).lastName = txtLastName.Text
        students(studentCount).phoneNo = txtPhone.Text
        students(studentCount).street = txtStreet.Text
        students(studentCount).suburb = txtSuburb.Text
        students(studentCount).quantity = txtQuantity.Text
        students(studentCount).deliveryDate = dteDelivery.Text & " " & cboHour.Text & ":" & cboMinute.Text
        studentCount += 1
        'return text boxes to blank ready for next entry
        txtFirstName.Text = ""
        txtLastName.Text = ""
        txtPhone.Text = ""
        txtStreet.Text = ""
        txtSuburb.Text = ""
        txtPostcode.Text = ""
        txtQuantity.Text = 1
        dteDelivery.Text = ""
        cboHour.Text = "10"
        cboMinute.Text = "00"
        radThin.Checked = False
        radCrispy.Checked = False
        radFat.Checked = False
        chkTop1.Checked = False
        chkTop2.Checked = False
        chkTop3.Checked = False
        chkTop4.Checked = False
        displayList()
    End Sub
    Private Sub displayList()
        'clear the list box as it keeps the earlier loop
        txtStList.Items.Clear()
        'loop through the array to print all rows
        For i = 0 To studentCount - 1
            txtStList.Items.Add(students(i).studID & " - " & students(i).firstName & " - " &
                              UCase(students(i).lastName) & " - " & students(i).deliveryDate & " - " &
                              students(i).street & "-" & students(i).suburb & "-" &
                              students(i).postcode & " - " & students(i).quantity &
                              students(i).pizzaBase & "-A " & students(i).top1 & ": O " &
                              students(i).top2 & ": C " & students(i).top3 & ": P " &
                              students(i).top4 & ": Del " & students(i).deliveryDate)
        Next
    End Sub

    Private Sub CalcToppedPrice()
        toppedPrice = basePrice
        If chkTop1.Checked Then
            toppedPrice += top1Price
        End If
        If chkTop2.Checked Then
            toppedPrice += top2Price
        End If
        If chkTop3.Checked Then
            toppedPrice += top3Price
        End If
        If chkTop4.Checked Then
            toppedPrice += top4Price
        End If
        txtToppedPrice.Text = FormatCurrency(toppedPrice)
    End Sub

    Private Sub chkTop1_CheckedChanged(sender As Object, e As EventArgs) Handles chkTop1.CheckedChanged
        CalcToppedPrice()
        CalcTotalPrice()
    End Sub

    Private Sub chkTop2_CheckedChanged(sender As Object, e As EventArgs) Handles chkTop2.CheckedChanged
        CalcToppedPrice()
        CalcTotalPrice()
    End Sub

    Private Sub chkTop3_CheckedChanged(sender As Object, e As EventArgs) Handles chkTop3.CheckedChanged
        CalcToppedPrice()
        CalcTotalPrice()
    End Sub

    Private Sub chkTop4_CheckedChanged(sender As Object, e As EventArgs) Handles chkTop4.CheckedChanged
        CalcToppedPrice()
        CalcTotalPrice()
    End Sub

    Private Sub CalcTotalPrice()
        txtTotalPrice.Text = FormatCurrency(toppedPrice * CInt(txtQuantity.Text))
    End Sub

    Private Sub txtQuantity_TextChanged(sender As Object, e As EventArgs) Handles txtQuantity.TextChanged
        CalcTotalPrice()
    End Sub

    'Private Sub radThin_CheckedChanged(sender As Object, e As EventArgs) Handles radThin.CheckedChanged
    '    If radThin.Checked Then
    '        students(studentCount).pizzaBase = "Thin"
    '    End If
    'End Sub

    'Private Sub radCrispy_CheckedChanged(sender As Object, e As EventArgs) Handles radCrispy.CheckedChanged
    '    If radCrispy.Checked Then
    '        students(studentCount).pizzaBase = "Crispy"
    '    End If
    'End Sub

    'Private Sub radFat_CheckedChanged(sender As Object, e As EventArgs) Handles radFat.CheckedChanged
    '    If radFat.Checked Then
    '        students(studentCount).pizzaBase = "Fat"
    '    End If
    'End Sub
End Class
