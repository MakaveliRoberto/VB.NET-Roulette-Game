Public Class Form1
    Dim num As Integer
    Dim bet As Integer
    Dim coins As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub ButtonODD_Click(sender As Object, e As EventArgs) Handles ButtonODD.Click

        num = Math.Ceiling(Rnd() * 36)
        lbl_num.Text = num
        bet = txt_bet.Text

        If cx_off.Checked = False Then
            If num = 1 Or num = 3 Or num = 5 Or num = 7 Or num = 9 Or num = 11 Or num = 13 Or num = 15 Or num = 17 Or num = 19 Or num = 21 Or num = 23 Or num = 25 Or num = 27 Or num = 29 Or num = 31 Or num = 33 Or num = 35 Then
                coins = coins + bet
                lbl_num.BackColor = Color.Green
                MessageBox.Show("You Win !")
            Else
                coins = coins - bet
                lbl_num.BackColor = Color.Blue
                MessageBox.Show("You Lost !")
            End If
        ElseIf cx_off.Checked = True Then
            If num = 1 Or num = 3 Or num = 5 Or num = 7 Or num = 9 Or num = 11 Or num = 13 Or num = 15 Or num = 17 Or num = 19 Or num = 21 Or num = 23 Or num = 25 Or num = 27 Or num = 29 Or num = 31 Or num = 33 Or num = 35 Then
                coins = coins + bet
                lbl_num.BackColor = Color.Green
            Else
                coins = coins - bet
                lbl_num.BackColor = Color.Blue
            End If
        End If
        If txt_bet.Text = "" Then
            MessageBox.Show("You didnt put a bet!")
        End If
        lbl_coins.Text = coins
    End Sub


    Private Sub ButtonRED_Click(sender As Object, e As EventArgs) Handles ButtonRED.Click


        num = Math.Ceiling(Rnd() * 36)
        lbl_num.Text = num
        bet = txt_bet.Text

        If cx_off.Checked = False Then

            If num = 1 Or num = 3 Or num = 5 Or num = 7 Or num = 9 Or num = 12 Or num = 14 Or num = 16 Or num = 18 Or num = 21 Or num = 23 Or num = 25 Or num = 27 Or num = 28 Or num = 30 Or num = 32 Or num = 34 Or num = 36 Then
                coins = coins + bet
                lbl_num.BackColor = Color.Red
                MessageBox.Show("You Win !")
            ElseIf num = 2 Or num = 4 Or num = 6 Or num = 8 Or num = 10 Or num = 11 Or num = 13 Or num = 15 Or num = 17 Or num = 19 Or num = 20 Or num = 22 Or num = 24 Or num = 26 Or num = 29 Or num = 31 Or num = 33 Or num = 35 Then
                coins = coins - bet
                lbl_num.BackColor = Color.Black
                MessageBox.Show("You Lost!")
            End If
        ElseIf cx_off.Checked = True Then
            If num = 1 Or num = 3 Or num = 5 Or num = 7 Or num = 9 Or num = 12 Or num = 14 Or num = 16 Or num = 18 Or num = 21 Or num = 23 Or num = 25 Or num = 27 Or num = 28 Or num = 30 Or num = 32 Or num = 34 Or num = 36 Then
                coins = coins + bet
                lbl_num.BackColor = Color.Red
            ElseIf num = 2 Or num = 4 Or num = 6 Or num = 8 Or num = 10 Or num = 11 Or num = 13 Or num = 15 Or num = 17 Or num = 19 Or num = 20 Or num = 22 Or num = 24 Or num = 26 Or num = 29 Or num = 31 Or num = 33 Or num = 35 Then
                coins = coins - bet
                lbl_num.BackColor = Color.Black
            End If
        End If
        If txt_bet.Text = "" Then
            MessageBox.Show("You didnt put a bet!")
        End If
        lbl_coins.Text = coins
    End Sub
    Private Sub ButtonBlack_Click(sender As Object, e As EventArgs) Handles ButtonBlack.Click


        num = Math.Ceiling(Rnd() * 36)
        lbl_num.Text = num
        bet = txt_bet.Text
        If cx_off.Checked = False Then
            If num = 1 Or num = 3 Or num = 5 Or num = 7 Or num = 9 Or num = 12 Or num = 14 Or num = 16 Or num = 18 Or num = 21 Or num = 23 Or num = 25 Or num = 27 Or num = 28 Or num = 30 Or num = 32 Or num = 34 Or num = 36 Then
                coins = coins - bet
                lbl_num.BackColor = Color.Red
                MessageBox.Show("You Lost!")
            ElseIf num = 2 Or num = 4 Or num = 6 Or num = 8 Or num = 10 Or num = 11 Or num = 13 Or num = 15 Or num = 17 Or num = 19 Or num = 20 Or num = 22 Or num = 24 Or num = 26 Or num = 29 Or num = 31 Or num = 33 Or num = 35 Then
                coins = coins + bet
                lbl_num.BackColor = Color.Black
                MessageBox.Show("You Win !")
            End If
        ElseIf cx_off.Checked = True Then
            If num = 1 Or num = 3 Or num = 5 Or num = 7 Or num = 9 Or num = 12 Or num = 14 Or num = 16 Or num = 18 Or num = 21 Or num = 23 Or num = 25 Or num = 27 Or num = 28 Or num = 30 Or num = 32 Or num = 34 Or num = 36 Then
                coins = coins - bet
                lbl_num.BackColor = Color.Red
            ElseIf num = 2 Or num = 4 Or num = 6 Or num = 8 Or num = 10 Or num = 11 Or num = 13 Or num = 15 Or num = 17 Or num = 19 Or num = 20 Or num = 22 Or num = 24 Or num = 26 Or num = 29 Or num = 31 Or num = 33 Or num = 35 Then
                coins = coins + bet
                lbl_num.BackColor = Color.Black
            End If
        End If
        If txt_bet.Text = "" Then
            MessageBox.Show("You didnt put a bet!")
        End If
        lbl_coins.Text = coins
    End Sub
    Private Sub ButtonEven_Click(sender As Object, e As EventArgs) Handles ButtonEven.Click

        num = Math.Ceiling(Rnd() * 36)
        lbl_num.Text = num
        bet = txt_bet.Text

        If cx_off.Checked = False Then
            If num = 0 Or num = 2 Or num = 4 Or num = 6 Or num = 8 Or num = 10 Or num = 12 Or num = 14 Or num = 16 Or num = 18 Or num = 20 Or num = 22 Or num = 24 Or num = 26 Or num = 28 Or num = 30 Or num = 32 Or num = 34 Or num = 36 Then
                coins = coins + bet
                lbl_num.BackColor = Color.Green
                MessageBox.Show("You Win !")
            Else
                coins = coins - bet
                lbl_num.BackColor = Color.Blue
                MessageBox.Show("You Lost !")
            End If
        ElseIf cx_off.Checked = True Then
            If num = 0 Or num = 2 Or num = 4 Or num = 6 Or num = 8 Or num = 10 Or num = 12 Or num = 14 Or num = 16 Or num = 18 Or num = 20 Or num = 22 Or num = 24 Or num = 26 Or num = 28 Or num = 30 Or num = 32 Or num = 34 Or num = 36 Then
                coins = coins + bet
                lbl_num.BackColor = Color.Green
            Else
                coins = coins - bet
                lbl_num.BackColor = Color.Blue
            End If
        End If
        If txt_bet.Text = "" Then
            MessageBox.Show("You didnt put a bet!")
        End If
        lbl_coins.Text = coins
    End Sub

    Private Sub Button37_Click(sender As Object, e As EventArgs) Handles Button37.Click
        coins = coins + 100
        lbl_coins.Text = coins
    End Sub
    Function Rednum(numb)


        num = Math.Ceiling(Rnd() * 36)
        lbl_num.Text = num
        bet = txt_bet.Text
        If cx_off.Checked = False Then
            If num = (numb) Then
                coins = coins + bet * 16
                lbl_num.BackColor = Color.Red
                MessageBox.Show("You Win !")
            Else
                coins = coins - bet
                lbl_num.BackColor = Color.Black
                MessageBox.Show("You Lost !")
            End If
        ElseIf cx_off.Checked = True Then
            If num = (numb) Then
                coins = coins + bet * 16
                lbl_num.BackColor = Color.Red
            Else
                coins = coins - bet
                lbl_num.BackColor = Color.Black
            End If
        End If
        lbl_coins.Text = coins
        Return coins
        If txt_bet.Text = "" Then
            MessageBox.Show("You didnt put a bet!")
        End If
    End Function
    Function Blacknum(numb)


        num = Math.Ceiling(Rnd() * 36)
        lbl_num.Text = num
        bet = txt_bet.Text
        If cx_off.Checked = False Then
            If num = (numb) Then
                coins = coins + bet * 16
                lbl_num.BackColor = Color.Black
                MessageBox.Show("You Win !")
            Else
                coins = coins - bet
                lbl_num.BackColor = Color.Red
                MessageBox.Show("You Lost !")
            End If
        ElseIf cx_off.Checked = True Then
            If num = (numb) Then
                coins = coins + bet * 16
                lbl_num.BackColor = Color.Black
            Else
                coins = coins - bet
                lbl_num.BackColor = Color.Red
            End If
        End If
        lbl_coins.Text = coins
        Return coins
        If txt_bet.Text = "" Then
            MessageBox.Show("You didnt put a bet!")
        End If
    End Function

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Rednum(3)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Rednum(5)
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Rednum(9)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Rednum(7)
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Rednum(12)
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Rednum(14)
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        Rednum(18)
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Rednum(16)
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        Rednum(21)
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        Rednum(23)
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        Rednum(25)
    End Sub

    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click
        Rednum(27)
    End Sub

    Private Sub Button30_Click(sender As Object, e As EventArgs) Handles Button30.Click
        Rednum(30)
    End Sub

    Private Sub Button28_Click(sender As Object, e As EventArgs) Handles Button28.Click
        Rednum(28)
    End Sub

    Private Sub Button32_Click(sender As Object, e As EventArgs) Handles Button32.Click
        Rednum(32)
    End Sub

    Private Sub Button36_Click(sender As Object, e As EventArgs) Handles Button36.Click
        Rednum(36)
    End Sub

    Private Sub Button34_Click(sender As Object, e As EventArgs) Handles Button34.Click
        Rednum(34)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Blacknum(2)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Blacknum(4)
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Rednum(1)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Blacknum(6)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Blacknum(8)
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Blacknum(11)
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Blacknum(10)
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Blacknum(15)
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Blacknum(13)
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Blacknum(17)
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        Blacknum(20)
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        Blacknum(19)
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        Blacknum(24)
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        Blacknum(22)
    End Sub

    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
        Blacknum(26)
    End Sub

    Private Sub Button29_Click(sender As Object, e As EventArgs) Handles Button29.Click
        Blacknum(29)
    End Sub

    Private Sub Button33_Click(sender As Object, e As EventArgs) Handles Button33.Click
        Blacknum(33)
    End Sub

    Private Sub Button31_Click(sender As Object, e As EventArgs) Handles Button31.Click
        Blacknum(31)
    End Sub

    Private Sub Button35_Click(sender As Object, e As EventArgs) Handles Button35.Click
        Blacknum(35)
    End Sub
End Class

