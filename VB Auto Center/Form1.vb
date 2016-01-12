Public Class Form1

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If MsgBox("Do you want to terminate the program?", MsgBoxStyle.YesNo, "Close Program?") = MsgBoxResult.Yes Then
            e.Cancel = False
        End If
    End Sub

    ' Calculate button
    Private Sub Calculate_Click(sender As Object, e As EventArgs) Handles Calculate.Click
        
        Try
            Dim Sum As Single
            Dim Difference As Int32
            Dim Base As Single = CSng(basePrice.Text)
            Dim Trade As Single = CSng(tradeIn.Text)
            Dim Stereo As Single = 0
            Dim LeatherInt As Single = 0
            Dim CompNav As Single = 0
            Dim Pearlized As Single = 0
            Dim CustomDetail As Single = 0

            If Chk1.Checked Then Stereo = 40000
            If Chk2.Checked Then LeatherInt = 150000
            If Chk3.Checked Then CompNav = 100000
            If Rad2.Checked Then Pearlized = 30000
            If Rad3.Checked Then CustomDetail = 50000
            If Base = 0 Then
                MsgBox("Base price cannot be NIL. Try again", MsgBoxStyle.OkOnly, "Error")
                Chk1.Checked = False
                Chk2.Checked = False
                Rad1.Checked = False
                Rad2.Checked = False
                Rad3.Checked = False
            Else
                Sum = Base + Stereo + LeatherInt + CompNav + Pearlized + CustomDetail
                subTotal.Text = Sum.ToString()
                If subTotal.Text = Sum.ToString() Then
                    txtTax.Text = Sum.ToString * 0.84
                End If
                Difference = Math.Abs(txtTax.Text - tradeIn.Text)
                Total.Text = Difference.ToString()

            End If
        Catch exc As Exception
            MsgBox("Base price cannot be EMPTY. Try again", MsgBoxStyle.OkOnly, "Error")
            Chk1.Checked = False
            Chk2.Checked = False
            Rad1.Checked = False
            Rad2.Checked = False
            Rad3.Checked = False
        Finally

        End Try

    End Sub

    'Exit button
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    'Clear button
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtTax.Clear()
        subTotal.Clear()
        Total.Clear()
        basePrice.Clear()
        basePrice.Text = 0
        tradeIn.Clear()
        tradeIn.Text = 0
        Chk1.Checked = False
        Chk2.Checked = False
        Rad1.Checked = False
        Rad2.Checked = False
        Rad3.Checked = False
    End Sub
End Class
