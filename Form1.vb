Public Class Form1

    Dim s As Integer = 5
    Dim m As Integer = 5

    Dim level As Integer = 1

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If level = 1 Then
            Timer1.Enabled = False
            Dim result As DialogResult = MessageBox.Show("Good Job. Ready for level 2?",
                                                         "Congratulations",
                                                         MessageBoxButtons.YesNo)

            If result = DialogResult.Yes Then
                Timer2.Enabled = True
                level += 1
            Else
                MessageBox.Show("Thank You for playing our game." _
                                + Environment.NewLine +
                                "Now closing the game",
                                "Thank You")
                End
            End If
        ElseIf level = 2 Then
            Timer2.Enabled = False

            Dim result As DialogResult = MessageBox.Show("Good Job. Ready for level 3?",
                                                         "Congratulations",
                                                         MessageBoxButtons.YesNo)

            If result = DialogResult.Yes Then
                Timer3.Enabled = True
                level += 1
            Else
                MessageBox.Show("Thank You for playing our game." _
                                + Environment.NewLine +
                                "Now closing the game",
                                "Thank You")
                End
            End If
        ElseIf level = 3 Then
            Timer3.Enabled = False

            Dim result As DialogResult = MessageBox.Show("You have beaten the game. Play Again?",
                                                         "Congratulations",
                                                          MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                Timer1.Enabled = True
                level = 1
            Else
                MessageBox.Show("Thank You for playing our game." _
                                + Environment.NewLine +
                                "Now closing the game",
                                "Thank You")
                End
            End If
        End If


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        PictureBox1.Location = New Point(PictureBox1.Location.X + m, PictureBox1.Location.Y + s)

        Dim upperbound As Integer = 8
        Dim lowerbound As Integer = 3
        Dim neglowerbound As Integer = -3
        Dim negupperbound As Integer = -8
        Randomize()

        If PictureBox1.Location.X > Panel1.Width - 60 Then
            m = CInt(Math.Floor((negupperbound - neglowerbound + 1) * Rnd())) + neglowerbound
        End If
        If PictureBox1.Location.X < 0 Then
            m = CInt(Math.Floor((upperbound - lowerbound + 1) * Rnd())) + lowerbound
        End If
        If PictureBox1.Location.Y > Panel1.Height - 85 Then
            s = CInt(Math.Floor((negupperbound - neglowerbound + 1) * Rnd())) + neglowerbound
        End If
        If PictureBox1.Location.Y < 0 Then
            s = CInt(Math.Floor((upperbound - lowerbound + 1) * Rnd())) + lowerbound
        End If
        'PictureBox1.Top += speedV
        'PictureBox1.Left += speedH

        'If PictureBox1.Top <= 0 Then
        '    speedV = -speedV
        'ElseIf PictureBox1.Top >= Me.ClientSize.Height - Picturebox1.height Then
        '    speedV = -speedV
        'End If

        'If PictureBox1.Left <= 0 Then
        '    speedH = -speedH
        'ElseIf PictureBox1.Left >= Me.ClientSize.Width - PictureBox1.Width Then
        '    speedH = -speedH
        'End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        PictureBox1.Location = New Point(PictureBox1.Location.X + m, PictureBox1.Location.Y + s)

        Dim upperbound As Integer = 10
        Dim lowerbound As Integer = 5
        Dim neglowerbound As Integer = -10
        Dim negupperbound As Integer = -5
        Randomize()

        If PictureBox1.Location.X > Panel1.Width - 60 Then
            m = CInt(Math.Floor((negupperbound - neglowerbound + 1) * Rnd())) + neglowerbound
        End If
        If PictureBox1.Location.X < 0 Then
            m = CInt(Math.Floor((upperbound - lowerbound + 1) * Rnd())) + lowerbound
        End If
        If PictureBox1.Location.Y > Panel1.Height - 85 Then
            s = CInt(Math.Floor((negupperbound - neglowerbound + 1) * Rnd())) + neglowerbound
        End If
        If PictureBox1.Location.Y < 0 Then
            s = CInt(Math.Floor((upperbound - lowerbound + 1) * Rnd())) + lowerbound
        End If
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        PictureBox1.Location = New Point(PictureBox1.Location.X + m, PictureBox1.Location.Y + s)

        Dim upperbound As Integer = 12
        Dim lowerbound As Integer = 7
        Dim neglowerbound As Integer = -12
        Dim negupperbound As Integer = -7
        Randomize()

        If PictureBox1.Location.X > Panel1.Width - 60 Then
            m = CInt(Math.Floor((negupperbound - neglowerbound + 1) * Rnd())) + neglowerbound
        End If
        If PictureBox1.Location.X < 0 Then
            m = CInt(Math.Floor((upperbound - lowerbound + 1) * Rnd())) + lowerbound
        End If
        If PictureBox1.Location.Y > Panel1.Height - 85 Then
            s = CInt(Math.Floor((negupperbound - neglowerbound + 1) * Rnd())) + neglowerbound
        End If
        If PictureBox1.Location.Y < 0 Then
            s = CInt(Math.Floor((upperbound - lowerbound + 1) * Rnd())) + lowerbound
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Me.Enabled = False
        Me.Hide()
        Form2.Show()
    End Sub
End Class