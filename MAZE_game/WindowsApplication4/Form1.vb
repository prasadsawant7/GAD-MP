Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show("This are the following instruction")
        MessageBox.Show("Avoid the red line!")
        MessageBox.Show("Go to the finish before the time is over")
        MessageBox.Show("Press  W-up,  S-down, A-left, and D-right")
        MessageBox.Show("Are you ready? press  OK!")



        Form2.Show()
        Me.Hide()
        Form2.Label1.Text = 60
        Form2.Timer1.Start()
        Form2.PictureBox2.Top = 79
        Form2.PictureBox2.Left = 116



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form3.Show()
        Me.Hide()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MessageBox.Show("Welcome to the MAZE!")

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If MessageBox.Show("would you like to try again?", "GAME OVER", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

            Me.Close()

        Else
        End If

    End Sub
End Class
