Public Class Form1

    Private Sub mnuexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuexit.Click
        End
    End Sub

    Private Sub mnuabout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuabout.Click
        AboutBox1.Show()
    End Sub

    Private Sub convert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles convert.Click
        If NN.Text = "" Then MsgBox("اطلاعات وارد نشده است!", vbExclamation, "خطاي برنامه") : End
        If NN.Text < 1 Or NN.Text > 3999 Then MsgBox(" اين برنامه براي اعداد صحيح 1 تا 3999 طراحي شده است.", vbExclamation, "خطاي برنامه") : Exit Sub
        Dim r As String
        Dim n As Integer
        Dim temp As Integer
        n = NN.Text
        temp = n \ 1000
        Select Case temp
            Case 1
                r = r + "M"
            Case 2
                r = r + "MM"
            Case 3
                r = r + "MMM"
            Case Is > 3
                MsgBox(" اين برنامه براي اعداد صحيح 1 تا 3999 طراحي شده است.", vbInformation, "خطاي برنامه")
        End Select
        n = n Mod 1000
        temp = n \ 100
        Select Case temp
            Case 1
                r = r + "C"
            Case 2
                r = r + "CC"
            Case 3
                r = r + "CCC"
            Case 4
                r = r + "CD"
            Case 5
                r = r + "D"
            Case 6
                r = r + "DC"
            Case 7
                r = r + "DCC"
            Case 8
                r = r + "DCCC"
            Case 9
                r = r + "CM"
        End Select
        n = n Mod 100
        temp = n \ 10
        Select Case temp
            Case 1
                r = r + "X"
            Case 2
                r = r + "XX"
            Case 3
                r = r + "XXX"
            Case 4
                r = r + "XL"
            Case 5
                r = r + "L"
            Case 6
                r = r + "LX"
            Case 7
                r = r + "LXX"
            Case 8
                r = r + "LXXX"
            Case 9
                r = r + "XC"
        End Select
        n = n Mod 10
        temp = n \ 1
        Select Case temp
            Case 1
                r = r + "I"
            Case 2
                r = r + "II"
            Case 3
                r = r + "III"
            Case 4
                r = r + "IV"
            Case 5
                r = r + "V"
            Case 6
                r = r + "VI"
            Case 7
                r = r + "VII"
            Case 8
                r = r + "VIII"
            Case 9
                r = r + "IX"
        End Select
        n = n Mod 1
        RR.Text = r
    End Sub
End Class
