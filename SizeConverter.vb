Public Class SizeConverter
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged, TextBox4.Enter
        'this disabes the textbox from being able to change the text
        TextBox1.Enabled = False
    End Sub
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        'this disabes the textbox from being able to change the text
        TextBox2.Enabled = False
    End Sub
    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        'this disabes the textbox from being able to change the text
        TextBox3.Enabled = False
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'this calls the help form to guide the user
        Call msg()
        TextBox4.Focus()
    End Sub
    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs)
        'this disabes the textbox from being able to change the text
        TextBox5.Enabled = False
        TextBox6.Enabled = False
        TextBox8.Enabled = False
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged
        'this disabes the textbox from being able to change the text
        TextBox6.Enabled = False
        TextBox4.Enabled = False
        TextBox8.Enabled = False
    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged
        'this disabes the textbox from being able to change the text
        TextBox5.Enabled = False
        TextBox4.Enabled = False
        TextBox8.Enabled = False
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'All this is for the conversion
        'This is for UK size
        If TextBox4.Text = "5" Then
            TextBox5.Text = "38"
            TextBox8.Text = "5.5"
            TextBox6.Text = "23.5"
        End If
        If TextBox4.Text = "5.5" Then
            TextBox5.Text = "38.7"
            TextBox8.Text = "6"
            TextBox6.Text = "24"
        End If
        If TextBox4.Text = "6" Then
            TextBox5.Text = "39.3"
            TextBox8.Text = "6.5"
            TextBox6.Text = "24.5"
        End If
        If TextBox4.Text = "6.5" Then
            TextBox5.Text = "40"
            TextBox8.Text = "7"
            TextBox6.Text = "25"
        End If
        If TextBox4.Text = "7" Then
            TextBox5.Text = "40.5"
            TextBox8.Text = "7.5"
            TextBox6.Text = "25.5"
        End If
        If TextBox4.Text = "7.5" Then
            TextBox5.Text = "41"
            TextBox8.Text = "8"
            TextBox6.Text = "26"
        End If
        If TextBox4.Text = "8" Then
            TextBox5.Text = "42"
            TextBox8.Text = "8.5"
            TextBox6.Text = "26.5"
        End If
        If TextBox4.Text = "8.5" Then
            TextBox5.Text = "42.5"
            TextBox8.Text = "9"
            TextBox6.Text = "27"
        End If
        If TextBox4.Text = "9" Then
            TextBox5.Text = "43"
            TextBox8.Text = "9.5"
            TextBox6.Text = "27.5"
        End If
        If TextBox4.Text = "9.5" Then
            TextBox5.Text = "44"
            TextBox8.Text = "10"
            TextBox6.Text = "28"
        End If
        If TextBox4.Text = "10" Then
            TextBox5.Text = "44.4"
            TextBox8.Text = "10.5"
            TextBox6.Text = "28.5"
        End If
        If TextBox4.Text = "10.5" Then
            TextBox5.Text = "45"
            TextBox8.Text = "11"
            TextBox6.Text = "29"
        End If
        If TextBox4.Text = "11" Then
            TextBox5.Text = "46"
            TextBox8.Text = "11.5"
            TextBox6.Text = "29.5"
        End If
        If TextBox4.Text = "11.5" Then
            TextBox5.Text = "46.5"
            TextBox8.Text = "12"
            TextBox6.Text = "30"
        End If
        If TextBox4.Text = "12" Then
            TextBox5.Text = "47"
            TextBox8.Text = "12.5"
            TextBox6.Text = "30.5"
        End If



        'This is for European size

        If TextBox5.Text = "38" Then
            TextBox4.Text = "5"
            TextBox8.Text = "5.5"
            TextBox6.Text = "23.5"
        End If
        If TextBox5.Text = "38.7" Then
            TextBox4.Text = "5.5"
            TextBox8.Text = "6"
            TextBox6.Text = "24"
        End If
        If TextBox5.Text = "39.3" Then
            TextBox4.Text = "6"
            TextBox8.Text = "6.5"
            TextBox6.Text = "24.5"
        End If
        If TextBox5.Text = "40" Then
            TextBox4.Text = "6.5"
            TextBox8.Text = "7"
            TextBox6.Text = "25"
        End If
        If TextBox5.Text = "40.5" Then
            TextBox4.Text = "7"
            TextBox8.Text = "7.5"
            TextBox6.Text = "25.5"
        End If
        If TextBox5.Text = "41" Then
            TextBox4.Text = "7.5"
            TextBox8.Text = "8"
            TextBox6.Text = "26"
        End If
        If TextBox5.Text = "42" Then
            TextBox4.Text = "8"
            TextBox8.Text = "8.5"
            TextBox6.Text = "26.5"
        End If
        If TextBox5.Text = "42.5" Then
            TextBox4.Text = "8.5"
            TextBox8.Text = "9"
            TextBox6.Text = "27"
        End If
        If TextBox5.Text = "43" Then
            TextBox4.Text = "9"
            TextBox8.Text = "9.5"
            TextBox6.Text = "27.5"
        End If
        If TextBox5.Text = "44" Then
            TextBox4.Text = "9.5"
            TextBox8.Text = "10"
            TextBox6.Text = "28"
        End If
        If TextBox5.Text = "44.4" Then
            TextBox4.Text = "10"
            TextBox8.Text = "10.5"
            TextBox6.Text = "28.5"
        End If
        If TextBox5.Text = "45" Then
            TextBox4.Text = "10.5"
            TextBox8.Text = "11"
            TextBox6.Text = "29"
        End If
        If TextBox5.Text = "46" Then
            TextBox4.Text = "11"
            TextBox8.Text = "11.5"
            TextBox6.Text = "29.5"
        End If
        If TextBox5.Text = "46.5" Then
            TextBox4.Text = "11.5"
            TextBox8.Text = "12"
            TextBox6.Text = "30"
        End If
        If TextBox5.Text = "47" Then
            TextBox4.Text = "12"
            TextBox8.Text = "12.5"
            TextBox6.Text = "30.5"
        End If




        'This is for USA size

        If TextBox8.Text = "5.5" Then
            TextBox4.Text = "5"
            TextBox5.Text = "38"
            TextBox6.Text = "23.5"
        End If
        If TextBox8.Text = "6" Then
            TextBox4.Text = "5.5"
            TextBox5.Text = "38.7"
            TextBox6.Text = "24"
        End If
        If TextBox8.Text = "6.5" Then
            TextBox4.Text = "6"
            TextBox5.Text = "39.3"
            TextBox6.Text = "24.5"
        End If
        If TextBox8.Text = "7" Then
            TextBox4.Text = "6.5"
            TextBox5.Text = "40"
            TextBox6.Text = "25"
        End If
        If TextBox8.Text = "7.5" Then
            TextBox4.Text = "7"
            TextBox5.Text = "40.5"
            TextBox6.Text = "25.5"
        End If
        If TextBox8.Text = "8" Then
            TextBox4.Text = "7.5"
            TextBox5.Text = "41"
            TextBox6.Text = "26"
        End If
        If TextBox8.Text = "8.5" Then
            TextBox4.Text = "8"
            TextBox5.Text = "42"
            TextBox6.Text = "26.5"
        End If
        If TextBox8.Text = "9" Then
            TextBox4.Text = "8.5"
            TextBox5.Text = "42.5"
            TextBox6.Text = "27"
        End If
        If TextBox8.Text = "9.5" Then
            TextBox4.Text = "9"
            TextBox5.Text = "43"
            TextBox6.Text = "27.5"
        End If
        If TextBox8.Text = "10" Then
            TextBox4.Text = "9.5"
            TextBox5.Text = "44"
            TextBox6.Text = "28"
        End If
        If TextBox8.Text = "10.5" Then
            TextBox4.Text = "10"
            TextBox5.Text = "44.4"
            TextBox6.Text = "28.5"
        End If
        If TextBox8.Text = "11" Then
            TextBox4.Text = "10.5"
            TextBox5.Text = "45"
            TextBox6.Text = "29"
        End If
        If TextBox8.Text = "11.5" Then
            TextBox4.Text = "11"
            TextBox5.Text = "46"
            TextBox6.Text = "29.5"
        End If
        If TextBox8.Text = "12" Then
            TextBox4.Text = "11.5"
            TextBox5.Text = "46.5"
            TextBox6.Text = "30"
        End If
        If TextBox8.Text = "12.5" Then
            TextBox4.Text = "12"
            TextBox5.Text = "47"
            TextBox6.Text = "30.5"
        End If




        'This is for Japanese size
        If TextBox6.Text = "23.5" Then
            TextBox4.Text = "5"
            TextBox5.Text = "38"
            TextBox8.Text = "5.5"
        End If
        If TextBox6.Text = "24" Then
            TextBox4.Text = "5.5"
            TextBox5.Text = "38.7"
            TextBox8.Text = "6"
        End If
        If TextBox6.Text = "24.5" Then
            TextBox4.Text = "6"
            TextBox5.Text = "39.3"
            TextBox8.Text = "6.5"
        End If
        If TextBox6.Text = "25" Then
            TextBox4.Text = "6.5"
            TextBox5.Text = "40"
            TextBox8.Text = "7"
        End If
        If TextBox6.Text = "25.5" Then
            TextBox4.Text = "7"
            TextBox5.Text = "40.5"
            TextBox8.Text = "7.5"
        End If
        If TextBox6.Text = "26" Then
            TextBox4.Text = "7.5"
            TextBox5.Text = "41"
            TextBox8.Text = "8"
        End If
        If TextBox6.Text = "26.5" Then
            TextBox4.Text = "8"
            TextBox5.Text = "42"
            TextBox8.Text = "8.5"
        End If
        If TextBox6.Text = "27" Then
            TextBox4.Text = "8.5"
            TextBox5.Text = "42.5"
            TextBox8.Text = "9"
        End If
        If TextBox6.Text = "27.5" Then
            TextBox4.Text = "9"
            TextBox5.Text = "43"
            TextBox8.Text = "9.5"
        End If
        If TextBox6.Text = "28" Then
            TextBox4.Text = "9.5"
            TextBox5.Text = "44"
            TextBox8.Text = "10"
        End If
        If TextBox6.Text = "28.5" Then
            TextBox4.Text = "10"
            TextBox5.Text = "44.4"
            TextBox8.Text = "10.5"
        End If
        If TextBox6.Text = "29" Then
            TextBox4.Text = "10.5"
            TextBox5.Text = "45"
            TextBox8.Text = "11"
        End If
        If TextBox6.Text = "29.5" Then
            TextBox4.Text = "11"
            TextBox5.Text = "46"
            TextBox6.Text = "29.5"
        End If
        If TextBox6.Text = "30" Then
            TextBox4.Text = "11.5"
            TextBox5.Text = "46.5"
            TextBox8.Text = "12"
        End If
        If TextBox6.Text = "30.5" Then
            TextBox4.Text = "12"
            TextBox5.Text = "47"
            TextBox8.Text = "12.5"
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'this is for the textboxes to clear so the user cnn convert again
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox8.Clear()
        'this enables the texboxes to be interfered with and changed
        TextBox4.Enabled = True
        TextBox5.Enabled = True
        TextBox6.Enabled = True
        TextBox8.Enabled = True
    End Sub
    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged
        'this disabes the textbox from being able to change the text
        TextBox7.Enabled = False
    End Sub
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Call ne()
    End Sub

    Private Sub ExitToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem1.Click
        Call clse()
    End Sub

End Class

