<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pizza104
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPostcode = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtQuantity = New System.Windows.Forms.TextBox()
        Me.BtnAddStud = New System.Windows.Forms.Button()
        Me.txtStList = New System.Windows.Forms.ListBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ChkTop1 = New System.Windows.Forms.CheckBox()
        Me.ChkTop2 = New System.Windows.Forms.CheckBox()
        Me.ChkTop3 = New System.Windows.Forms.CheckBox()
        Me.radThin = New System.Windows.Forms.RadioButton()
        Me.radCrispy = New System.Windows.Forms.RadioButton()
        Me.radFat = New System.Windows.Forms.RadioButton()
        Me.ChkTop4 = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cboHour = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cboMinute = New System.Windows.Forms.ComboBox()
        Me.dteDelivery = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtStreet = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtSuburb = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtPhone = New System.Windows.Forms.MaskedTextBox()
        Me.txtToppedPrice = New System.Windows.Forms.TextBox()
        Me.txtTotalPrice = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.chkPaid = New System.Windows.Forms.CheckBox()
        Me.txtTop4 = New System.Windows.Forms.TextBox()
        Me.txtTop3 = New System.Windows.Forms.TextBox()
        Me.txtTop2 = New System.Windows.Forms.TextBox()
        Me.txtTop1 = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtBasePrice = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(36, 56)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(100, 20)
        Me.txtFirstName.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Enter Order Details"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "First Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(142, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Last Name"
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(142, 56)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(100, 20)
        Me.txtLastName.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(351, 133)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Delivery Date"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(247, 84)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Postcode"
        '
        'txtPostcode
        '
        Me.txtPostcode.Location = New System.Drawing.Point(247, 103)
        Me.txtPostcode.Name = "txtPostcode"
        Me.txtPostcode.Size = New System.Drawing.Size(100, 20)
        Me.txtPostcode.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(352, 84)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Quantity"
        '
        'TxtQuantity
        '
        Me.TxtQuantity.Location = New System.Drawing.Point(355, 103)
        Me.TxtQuantity.Name = "TxtQuantity"
        Me.TxtQuantity.Size = New System.Drawing.Size(205, 20)
        Me.TxtQuantity.TabIndex = 15
        Me.TxtQuantity.Text = "1"
        '
        'BtnAddStud
        '
        Me.BtnAddStud.Location = New System.Drawing.Point(463, 220)
        Me.BtnAddStud.Name = "BtnAddStud"
        Me.BtnAddStud.Size = New System.Drawing.Size(97, 23)
        Me.BtnAddStud.TabIndex = 20
        Me.BtnAddStud.Text = "Add Order"
        Me.BtnAddStud.UseVisualStyleBackColor = True
        '
        'txtStList
        '
        Me.txtStList.FormattingEnabled = True
        Me.txtStList.Location = New System.Drawing.Point(39, 249)
        Me.txtStList.Name = "txtStList"
        Me.txtStList.Size = New System.Drawing.Size(521, 134)
        Me.txtStList.TabIndex = 15
        Me.txtStList.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(39, 225)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "List of Orders"
        '
        'ChkTop1
        '
        Me.ChkTop1.AutoSize = True
        Me.ChkTop1.Location = New System.Drawing.Point(154, 134)
        Me.ChkTop1.Name = "ChkTop1"
        Me.ChkTop1.Size = New System.Drawing.Size(76, 17)
        Me.ChkTop1.TabIndex = 10
        Me.ChkTop1.Text = "Anchovies"
        Me.ChkTop1.UseVisualStyleBackColor = True
        '
        'ChkTop2
        '
        Me.ChkTop2.AutoSize = True
        Me.ChkTop2.Location = New System.Drawing.Point(154, 157)
        Me.ChkTop2.Name = "ChkTop2"
        Me.ChkTop2.Size = New System.Drawing.Size(55, 17)
        Me.ChkTop2.TabIndex = 11
        Me.ChkTop2.Text = "Olives"
        Me.ChkTop2.UseVisualStyleBackColor = True
        '
        'ChkTop3
        '
        Me.ChkTop3.AutoSize = True
        Me.ChkTop3.Location = New System.Drawing.Point(154, 180)
        Me.ChkTop3.Name = "ChkTop3"
        Me.ChkTop3.Size = New System.Drawing.Size(75, 17)
        Me.ChkTop3.TabIndex = 12
        Me.ChkTop3.Text = "Cabanossi"
        Me.ChkTop3.UseVisualStyleBackColor = True
        '
        'radThin
        '
        Me.radThin.AutoSize = True
        Me.radThin.Checked = True
        Me.radThin.Location = New System.Drawing.Point(39, 151)
        Me.radThin.Name = "radThin"
        Me.radThin.Size = New System.Drawing.Size(46, 17)
        Me.radThin.TabIndex = 7
        Me.radThin.TabStop = True
        Me.radThin.Text = "Thin"
        Me.radThin.UseVisualStyleBackColor = True
        '
        'radCrispy
        '
        Me.radCrispy.AutoSize = True
        Me.radCrispy.Location = New System.Drawing.Point(39, 174)
        Me.radCrispy.Name = "radCrispy"
        Me.radCrispy.Size = New System.Drawing.Size(53, 17)
        Me.radCrispy.TabIndex = 8
        Me.radCrispy.Text = "Crispy"
        Me.radCrispy.UseVisualStyleBackColor = True
        '
        'radFat
        '
        Me.radFat.AutoSize = True
        Me.radFat.Location = New System.Drawing.Point(39, 197)
        Me.radFat.Name = "radFat"
        Me.radFat.Size = New System.Drawing.Size(40, 17)
        Me.radFat.TabIndex = 9
        Me.radFat.Text = "Fat"
        Me.radFat.UseVisualStyleBackColor = True
        '
        'ChkTop4
        '
        Me.ChkTop4.AutoSize = True
        Me.ChkTop4.Location = New System.Drawing.Point(154, 203)
        Me.ChkTop4.Name = "ChkTop4"
        Me.ChkTop4.Size = New System.Drawing.Size(70, 17)
        Me.ChkTop4.TabIndex = 13
        Me.ChkTop4.Text = "Pamesan"
        Me.ChkTop4.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(36, 132)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 13)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Pizza Base"
        '
        'cboHour
        '
        Me.cboHour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboHour.FormattingEnabled = True
        Me.cboHour.Items.AddRange(New Object() {"10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20"})
        Me.cboHour.Location = New System.Drawing.Point(354, 193)
        Me.cboHour.Name = "cboHour"
        Me.cboHour.Size = New System.Drawing.Size(100, 21)
        Me.cboHour.TabIndex = 17
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(351, 177)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(85, 13)
        Me.Label9.TabIndex = 26
        Me.Label9.Text = "Hour (24 hr time)"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(460, 177)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(39, 13)
        Me.Label10.TabIndex = 28
        Me.Label10.Text = "Minute"
        '
        'cboMinute
        '
        Me.cboMinute.FormattingEnabled = True
        Me.cboMinute.Items.AddRange(New Object() {"00", "15", "30", "45"})
        Me.cboMinute.Location = New System.Drawing.Point(463, 193)
        Me.cboMinute.Name = "cboMinute"
        Me.cboMinute.Size = New System.Drawing.Size(97, 21)
        Me.cboMinute.TabIndex = 18
        Me.cboMinute.Text = "00"
        '
        'dteDelivery
        '
        Me.dteDelivery.Location = New System.Drawing.Point(354, 149)
        Me.dteDelivery.Name = "dteDelivery"
        Me.dteDelivery.Size = New System.Drawing.Size(206, 20)
        Me.dteDelivery.TabIndex = 16
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(35, 84)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(76, 13)
        Me.Label11.TabIndex = 31
        Me.Label11.Text = "Street Address"
        '
        'txtStreet
        '
        Me.txtStreet.Location = New System.Drawing.Point(35, 103)
        Me.txtStreet.Name = "txtStreet"
        Me.txtStreet.Size = New System.Drawing.Size(100, 20)
        Me.txtStreet.TabIndex = 3
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(141, 84)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(41, 13)
        Me.Label12.TabIndex = 33
        Me.Label12.Text = "Suburb"
        '
        'txtSuburb
        '
        Me.txtSuburb.Location = New System.Drawing.Point(141, 103)
        Me.txtSuburb.Name = "txtSuburb"
        Me.txtSuburb.Size = New System.Drawing.Size(100, 20)
        Me.txtSuburb.TabIndex = 4
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(247, 37)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(78, 13)
        Me.Label13.TabIndex = 35
        Me.Label13.Text = "Phone Number"
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(247, 56)
        Me.txtPhone.Mask = "0000-000-000"
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(100, 20)
        Me.txtPhone.TabIndex = 2
        '
        'txtToppedPrice
        '
        Me.txtToppedPrice.Location = New System.Drawing.Point(247, 149)
        Me.txtToppedPrice.Name = "txtToppedPrice"
        Me.txtToppedPrice.ReadOnly = True
        Me.txtToppedPrice.Size = New System.Drawing.Size(100, 20)
        Me.txtToppedPrice.TabIndex = 37
        Me.txtToppedPrice.TabStop = False
        '
        'txtTotalPrice
        '
        Me.txtTotalPrice.Location = New System.Drawing.Point(247, 193)
        Me.txtTotalPrice.Name = "txtTotalPrice"
        Me.txtTotalPrice.ReadOnly = True
        Me.txtTotalPrice.Size = New System.Drawing.Size(100, 20)
        Me.txtTotalPrice.TabIndex = 38
        Me.txtTotalPrice.TabStop = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(247, 177)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(58, 13)
        Me.Label14.TabIndex = 39
        Me.Label14.Text = "Total Price"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(247, 132)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(71, 13)
        Me.Label15.TabIndex = 40
        Me.Label15.Text = "Topped Price"
        '
        'chkPaid
        '
        Me.chkPaid.AutoSize = True
        Me.chkPaid.Location = New System.Drawing.Point(248, 224)
        Me.chkPaid.Name = "chkPaid"
        Me.chkPaid.Size = New System.Drawing.Size(47, 17)
        Me.chkPaid.TabIndex = 19
        Me.chkPaid.Text = "Paid"
        Me.chkPaid.UseVisualStyleBackColor = True
        '
        'txtTop4
        '
        Me.txtTop4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTop4.Location = New System.Drawing.Point(105, 204)
        Me.txtTop4.Name = "txtTop4"
        Me.txtTop4.ReadOnly = True
        Me.txtTop4.Size = New System.Drawing.Size(41, 13)
        Me.txtTop4.TabIndex = 42
        Me.txtTop4.TabStop = False
        Me.txtTop4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTop3
        '
        Me.txtTop3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTop3.Location = New System.Drawing.Point(105, 181)
        Me.txtTop3.Name = "txtTop3"
        Me.txtTop3.ReadOnly = True
        Me.txtTop3.Size = New System.Drawing.Size(41, 13)
        Me.txtTop3.TabIndex = 43
        Me.txtTop3.TabStop = False
        Me.txtTop3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTop2
        '
        Me.txtTop2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTop2.Location = New System.Drawing.Point(105, 158)
        Me.txtTop2.Name = "txtTop2"
        Me.txtTop2.ReadOnly = True
        Me.txtTop2.Size = New System.Drawing.Size(41, 13)
        Me.txtTop2.TabIndex = 44
        Me.txtTop2.TabStop = False
        Me.txtTop2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTop1
        '
        Me.txtTop1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTop1.Location = New System.Drawing.Point(105, 135)
        Me.txtTop1.Name = "txtTop1"
        Me.txtTop1.ReadOnly = True
        Me.txtTop1.Size = New System.Drawing.Size(41, 13)
        Me.txtTop1.TabIndex = 45
        Me.txtTop1.TabStop = False
        Me.txtTop1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(352, 37)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(86, 13)
        Me.Label16.TabIndex = 47
        Me.Label16.Text = "Base Pizza Price"
        '
        'txtBasePrice
        '
        Me.txtBasePrice.Location = New System.Drawing.Point(355, 56)
        Me.txtBasePrice.Name = "txtBasePrice"
        Me.txtBasePrice.ReadOnly = True
        Me.txtBasePrice.Size = New System.Drawing.Size(205, 20)
        Me.txtBasePrice.TabIndex = 46
        Me.txtBasePrice.TabStop = False
        '
        'Pizza104
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(611, 391)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txtBasePrice)
        Me.Controls.Add(Me.txtTop1)
        Me.Controls.Add(Me.txtTop2)
        Me.Controls.Add(Me.txtTop3)
        Me.Controls.Add(Me.txtTop4)
        Me.Controls.Add(Me.chkPaid)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtTotalPrice)
        Me.Controls.Add(Me.txtToppedPrice)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtSuburb)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtStreet)
        Me.Controls.Add(Me.dteDelivery)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cboMinute)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cboHour)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.ChkTop4)
        Me.Controls.Add(Me.radFat)
        Me.Controls.Add(Me.radCrispy)
        Me.Controls.Add(Me.radThin)
        Me.Controls.Add(Me.ChkTop3)
        Me.Controls.Add(Me.ChkTop2)
        Me.Controls.Add(Me.ChkTop1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtStList)
        Me.Controls.Add(Me.BtnAddStud)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TxtQuantity)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtPostcode)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtFirstName)
        Me.Name = "Pizza104"
        Me.Text = "v1.05 Pizza Ordering App"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtPostcode As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtQuantity As TextBox
    Friend WithEvents BtnAddStud As Button


    Friend WithEvents txtStList As ListBox
    Friend WithEvents Label8 As Label
    Friend WithEvents ChkTop1 As CheckBox
    Friend WithEvents ChkTop2 As CheckBox
    Friend WithEvents ChkTop3 As CheckBox
    Friend WithEvents radThin As RadioButton
    Friend WithEvents radCrispy As RadioButton
    Friend WithEvents radFat As RadioButton
    Friend WithEvents ChkTop4 As CheckBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cboHour As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents cboMinute As ComboBox
    Friend WithEvents dteDelivery As DateTimePicker
    Friend WithEvents Label11 As Label
    Friend WithEvents txtStreet As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtSuburb As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtPhone As MaskedTextBox
    Friend WithEvents txtToppedPrice As TextBox
    Friend WithEvents txtTotalPrice As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents chkPaid As CheckBox
    Friend WithEvents txtTop4 As TextBox
    Friend WithEvents txtTop3 As TextBox
    Friend WithEvents txtTop2 As TextBox
    Friend WithEvents txtTop1 As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txtBasePrice As TextBox
End Class
