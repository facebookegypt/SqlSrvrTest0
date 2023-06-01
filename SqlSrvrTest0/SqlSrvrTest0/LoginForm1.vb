Imports LoginLibrary.DataClasses
Imports LoginLibrary.SecurityClasses
'Server Name : EVRY1FALLS
'SERVER Ver. : 16.0.1050
'Database Name : Accounts
Public Class LoginForm1
    ''' <summary>
    ''' Toggle visibility of password
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            PasswordTextBox.PasswordChar = "*"c
            CheckBox1.Text = "Show Password!"
        Else
            PasswordTextBox.PasswordChar = ControlChars.NullChar
            CheckBox1.Text = "Hide Password!"
        End If
    End Sub
    ''' <summary>
    ''' Perform login
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub OK_Click(sender As Object, e As EventArgs) Handles OK.Click

        If Not String.IsNullOrWhiteSpace(UsernameTextBox.Text) AndAlso Not String.IsNullOrWhiteSpace(PasswordTextBox.Text) Then
            'Server Name, DataBase Name
            Dim ops = New DatabaseUser("evry1falls", "Accounts")
            Dim tester = New Encryption

            ' encrypt user name and password
            Dim userNameBytes = tester.Encrypt(UsernameTextBox.Text, "111")
            Dim passwordBytes = tester.Encrypt(PasswordTextBox.Text, "111")

            Dim results = ops.Login(userNameBytes, passwordBytes)

            '
            ' Login recognized (does not know if the user has proper permissions to the tables at this point)
            '
            If results.Success Then
                Hide()
                Dim mainForm As New Form1(userNameBytes, passwordBytes)
                mainForm.ShowDialog()
            Else
                MessageBox.Show(results.Message)
            End If
        Else
            MessageBox.Show("Incomplete information to continue.")
        End If
    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        Close()
    End Sub

    Private Sub LoginForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckBox1.Checked = True
        CheckBox1.Text = "Show Password!"
    End Sub
End Class
