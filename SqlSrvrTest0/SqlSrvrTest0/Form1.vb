Imports Microsoft.Data.SqlClient
Imports System.Configuration

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        KeyPreview = True
        StartPosition = FormStartPosition.CenterScreen
    End Sub
    Private Sub SavBtn_Click(sender As Object, e As EventArgs) Handles SavBtn.Click
        If Len(NmTxt.Text) <= 0 Then
            ToolStripLabel1.ForeColor = Color.Red
            ToolStripLabel1.Text = "Blanks are not allowed."
            NmTxt.Focus()
            Exit Sub
        End If
        Dim connectionString As String = ConfigurationManager.ConnectionStrings("DBConStr").ConnectionString
        Try
            Dim NewAcc As Accs = New Accs
            Dim N As Integer = NewAcc.AddNewAccount(NmTxt.Text, Img2Byte)
            Call PictureBox2_Click(sender, e)
            ToolStripLabel1.ForeColor = Color.Green
            ToolStripLabel1.Text = ("Saved " & N.ToString)
        Catch ex As SqlException
            ToolStripLabel1.ForeColor = Color.Red
            ToolStripLabel1.Text = ("Not Saved!")
            MsgBox(ex.Message)
        End Try

    End Sub
    Function Img2Byte() As Byte()
        If IsNothing(PictureBox1.Image) Then
            PictureBox1.Image = My.Resources.Clipboard
        End If
        Dim IMG As Bitmap = New Bitmap(PictureBox1.Image)
        Using MyStream As New IO.MemoryStream
            IMG.Save(MyStream, Imaging.ImageFormat.Jpeg)
            Return MyStream.GetBuffer
        End Using
    End Function
    Private Sub PictureBox1_MouseClick(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseClick
        If e.Button = MouseButtons.Left Then
            Dim UrlImg As Bitmap = New Bitmap(My.Resources.Clipboard)
            Dim OFD As OpenFileDialog = New OpenFileDialog
            With OFD
                .CheckFileExists = True
                .CheckPathExists = True
                .Filter = ("Image (*.jpg,*.jpeg,*.png)|*.jpg;*.jpeg;*.png|Icon (*.Ico)|*.Ico;*.Ico")
                .FilterIndex = 1
                .InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
                .Multiselect = False
            End With
            Try
                If OFD.ShowDialog = DialogResult.OK Then
                    UrlImg = Bitmap.FromFile(OFD.FileName)
                    If UrlImg.Size.Width > 32 AndAlso UrlImg.Height > 32 Then
                        MsgBox("images maximum size is 32 x 32.")
                        Exit Sub
                    End If
                    PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
                    PictureBox1.Image = UrlImg
                End If
            Catch ex As Exception
                MsgBox("Error : " & ex.Message, MsgBoxStyle.Critical)
                PictureBox1.Image = UrlImg
            End Try
        End If
    End Sub
    Private Sub Form1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = ChrW(Keys.Escape) Then Close()
    End Sub
    Sub loadDatan2Lstview()
        With ListView1
            .Clear()
            .View = View.Details
            .FullRowSelect = True

            .Columns.Add(text:="Accounts")
            Dim imglist As New ImageList
            .SmallImageList = imglist
            Dim connectionString As String = ConfigurationManager.ConnectionStrings("DBConStr").ConnectionString
            Try
                Using Con As SqlConnection = New SqlConnection(connectionString)
                    Using Cmd As SqlCommand = New SqlCommand("FetchAcc", Con) With {.CommandType = CommandType.StoredProcedure}
                        Con.Open()
                        Using RDR As SqlDataReader = Cmd.ExecuteReader
                            While RDR.Read
                                Dim Img = CType(RDR!AccIco, Byte())
                                Dim Mms As IO.MemoryStream = New IO.MemoryStream(Img)
                                imglist.Images.Add(key:=RDR!AccID.ToString, image:=Image.FromStream(Mms))
                                Mms.Flush()
                                Dim LstItm1 As New ListViewItem With {.Text = RDR!AccName, .ImageKey = RDR!AccID.ToString}
                                ListView1.Items.Add(LstItm1)
                                .Font = New Font("Times New Roman", 12, FontStyle.Regular)
                                .AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.ColumnContent)
                                .BorderStyle = BorderStyle.None
                                .GridLines = True
                                .HeaderStyle = ColumnHeaderStyle.Clickable
                                .HideSelection = False
                                .HotTracking = False
                                .HoverSelection = False
                                .Padding = New Padding(3)
                                .MultiSelect = False
                                .Scrollable = True
                                .Sort()
                                .Sorting = Windows.Forms.SortOrder.Ascending
                            End While
                        End Using
                    End Using
                End Using
            Catch ex As SqlException
                MsgBox(ex.Message)
            End Try
        End With
    End Sub
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        loadDatan2Lstview()
        ToolStripLabel1.Text = String.Empty
        ComboBox1.DataSource = Nothing
    End Sub
    Private Sub ClrBtn_Click(sender As Object, e As EventArgs) Handles ClrBtn.Click
        NmTxt.Text = String.Empty
        SavBtn.Enabled = True
        EditBtn.Enabled = False
        DelBtn.Enabled = False
        FindBtn.Enabled = False
        ListView1.Clear()
        ComboBox1.DataSource = Nothing
    End Sub
    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        Dim ThisAccID As Integer
        If Not ListView1.FocusedItem Is Nothing Then
            ThisAccID = Convert.ToInt32(ListView1.FocusedItem.ImageKey)
        Else
            Exit Sub
        End If
        Dim connectionString As String = ConfigurationManager.ConnectionStrings("DBConStr").ConnectionString
        Try
            Using Con As SqlConnection = New SqlConnection(connectionString)
                Using SqlCommand As SqlCommand = New SqlCommand("FetchByAccID", Con) With {.CommandType = CommandType.StoredProcedure}
                    With SqlCommand.Parameters
                        .Add(New SqlParameter("@Acc1", ThisAccID))
                    End With
                    Con.Open()
                    Using Rdr As SqlDataReader = SqlCommand.ExecuteReader
                        If Rdr.HasRows Then
                            While Rdr.Read
                                NmTxt.Text = Rdr!AccName
                                Dim Data As Byte() = (Rdr!AccIco)
                                Dim ms As New IO.MemoryStream(Data)
                                PictureBox1.Image = Image.FromStream(ms)
                                ms.Flush()
                                ms.Close()
                                ClrBtn.Enabled = True
                                SavBtn.Enabled = False
                                FindBtn.Enabled = False
                                EditBtn.Enabled = True
                                DelBtn.Enabled = True
                            End While
                        Else
                            SqlCommand.Dispose()
                            Rdr.Close()
                            Con.Close()
                            Exit Sub
                        End If
                    End Using
                End Using
                ComboBox1.DataSource = Nothing
                Dim ComboItms As Dictionary(Of Integer, String) = New Dictionary(Of Integer, String)
                ComboBox1.Items.Clear()
                'Dim Dtable As DataTable = New DataTable
                Using SqlCommand1 As SqlCommand = New SqlCommand("FetchLogByAccID", Con) With {.CommandType = CommandType.StoredProcedure}
                    With SqlCommand1.Parameters
                        .Add(New SqlParameter("@Acc1", ThisAccID))
                    End With
                    Using Rdr1 As SqlDataReader = SqlCommand1.ExecuteReader
                        If Rdr1.HasRows Then
                            While Rdr1.Read
                                ComboItms.Add(Rdr1!ID, Rdr1!LoginNm.ToString)
                            End While
                        Else
                            SqlCommand1.Dispose()
                            Rdr1.Close()
                            Con.Close()
                            Exit Sub
                        End If
                    End Using
                End Using
                ComboBox1.DataSource = New BindingSource(ComboItms, Nothing)
                ComboBox1.ValueMember = "Key"
                ComboBox1.DisplayMember = "Value"
                Call ClrBtn1_Click(sender, e)
            End Using
        Catch ex As SqlException
            ToolStripLabel1.ForeColor = Color.Red
            ToolStripLabel1.Text = ("Not Saved!")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub ComboBox1_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ComboBox1.SelectionChangeCommitted
        Dim ThisLogID As Integer
        ThisLogID = DirectCast(ComboBox1.SelectedItem, KeyValuePair(Of Integer, String)).Key
        Dim connectionString As String = ConfigurationManager.ConnectionStrings("DBConStr").ConnectionString
        Try
            Using Con As SqlConnection = New SqlConnection(connectionString)
                Using SqlCommand As SqlCommand = New SqlCommand("FetchLogins", Con) With {.CommandType = CommandType.StoredProcedure}
                    With SqlCommand.Parameters
                        .Add(New SqlParameter("@ID1", ThisLogID))
                    End With
                    Con.Open()
                    Using Rdr As SqlDataReader = SqlCommand.ExecuteReader
                        If Rdr.HasRows Then
                            While Rdr.Read
                                UsrTxt.Text = Rdr!LoginNm.ToString
                                PwdTxt.Text = Rdr!LoginPwd.ToString
                                DeTxt.Text = Rdr!Notes.ToString
                                ClrBtn1.Enabled = True
                                SavBtn1.Enabled = False
                                FndBtn1.Enabled = False
                                EditBtn1.Enabled = True
                                DelBtn1.Enabled = True
                            End While
                        Else
                            SqlCommand.Dispose()
                            Rdr.Close()
                            Con.Close()
                            Exit Sub
                        End If
                    End Using
                End Using
            End Using
        Catch ex As SqlException
            MsgBox("Err : " & ex.Message)
        End Try
    End Sub
    Private Sub EditBtn_Click(sender As Object, e As EventArgs) Handles EditBtn.Click
        Dim AccID1 As Integer = Nothing
        Integer.TryParse(ListView1.FocusedItem.ImageKey, AccID1)
        Dim connectionString As String = ConfigurationManager.ConnectionStrings("DBConStr").ConnectionString
        Try
            Using Con As SqlConnection = New SqlConnection(connectionString)
                Using SqlCommand As SqlCommand = New SqlCommand("UpdateAccByID", Con) With {.CommandType = CommandType.StoredProcedure}
                    With SqlCommand.Parameters
                        .Add(New SqlParameter("@AccID", AccID1))
                        .Add(New SqlParameter("@AccIco1", Img2Byte))
                        .Add(New SqlParameter("@Dt1", Now.Date))
                        .Add(New SqlParameter("@AccNm1", NmTxt.Text))
                    End With
                    ToolStripLabel1.ForeColor = Color.Green
                    Con.Open()
                    ToolStripLabel1.Text = ("Updated " & SqlCommand.ExecuteNonQuery)
                End Using
            End Using
        Catch ex As SqlException
            ToolStripLabel1.ForeColor = Color.Red
            ToolStripLabel1.Text = ("Not Updaed!")
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ClrBtn1_Click(sender As Object, e As EventArgs) Handles ClrBtn1.Click
        UsrTxt.Text = String.Empty
        PwdTxt.Text = String.Empty
        DeTxt.Text = String.Empty
        SavBtn1.Enabled = True
        EditBtn1.Enabled = False
        DelBtn1.Enabled = False
        FndBtn1.Enabled = False
    End Sub
    Private Sub SavBtn1_Click(sender As Object, e As EventArgs) Handles SavBtn1.Click
        If Len(UsrTxt.Text) <= 0 OrElse Len(PwdTxt.Text) <= 0 Then
            ToolStripLabel1.ForeColor = Color.Red
            ToolStripLabel1.Text = "Blanks are not allowed."
            UsrTxt.Focus()
            Exit Sub
        End If
        Dim connectionString As String = ConfigurationManager.ConnectionStrings("DBConStr").ConnectionString
        Try
            Using Con As SqlConnection = New SqlConnection(connectionString)
                Using SqlCommand As SqlCommand = New SqlCommand("SaveLogin", Con) With {.CommandType = CommandType.StoredProcedure}
                    Dim AccID1 As Integer = Convert.ToInt32(ListView1.FocusedItem.ImageKey)
                    Dim LoginNm1 As String
                    If Len(UsrTxt.Text) <= 0 Then
                        ToolStripLabel1.ForeColor = Color.Red
                        ToolStripLabel1.Text = "User Name is Blank!"
                        Con.Close()
                        Exit Sub
                    End If
                    Dim LoginPwd1 As String
                    If Len(PwdTxt.Text) <= 0 Then
                        ToolStripLabel1.ForeColor = Color.Red
                        ToolStripLabel1.Text = "Password is Blank!"
                        Con.Close()
                        Exit Sub
                    End If
                    LoginNm1 = UsrTxt.Text
                    LoginPwd1 = PwdTxt.Text
                    Dim Notes1 As String
                    If Len(DeTxt.Text) <= 0 Then
                        Notes1 = "Date Created : " & Now.Date.ToString("dd-MMMM-yyyy")
                    Else
                        Notes1 = DeTxt.Text
                    End If
                    Dim Dt1 As Date = Now.Date
                    With SqlCommand.Parameters
                        .Add(New SqlParameter("@AccID1", AccID1))
                        .Add(New SqlParameter("@LoginNm1", LoginNm1))
                        .Add(New SqlParameter("@LoginPwd1", loginPwd1))
                        .Add(New SqlParameter("@Notes", Notes1))
                        .Add(New SqlParameter("@DtCtrtd1", Now.Date))
                    End With
                    ToolStripLabel1.ForeColor = Color.Green
                    Con.Open()
                    ToolStripLabel1.Text = ("Saved " & SqlCommand.ExecuteNonQuery())
                End Using
            End Using
        Catch ex As SqlException
            ToolStripLabel1.ForeColor = Color.Red
            ToolStripLabel1.Text = ("Not Saved!")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub EditBtn1_Click(sender As Object, e As EventArgs) Handles EditBtn1.Click
        Dim LogID As Integer
        LogID = DirectCast(ComboBox1.SelectedItem, KeyValuePair(Of Integer, String)).Key
        Dim connectionString As String = ConfigurationManager.ConnectionStrings("DBConStr").ConnectionString
        Try
            Using Con As SqlConnection = New SqlConnection(connectionString)
                Using SqlCommand As SqlCommand = New SqlCommand("UpdateLogsByID", Con) With {.CommandType = CommandType.StoredProcedure}
                    Dim LoginNm1 As String
                    If Len(UsrTxt.Text) <= 0 Then
                        ToolStripLabel1.ForeColor = Color.Red
                        ToolStripLabel1.Text = "User Name is Blank!"
                        Con.Close()
                        Exit Sub
                    End If
                    Dim LoginPwd1 As String
                    If Len(PwdTxt.Text) <= 0 Then
                        ToolStripLabel1.ForeColor = Color.Red
                        ToolStripLabel1.Text = "Password is Blank!"
                        Con.Close()
                        Exit Sub
                    End If
                    LoginNm1 = UsrTxt.Text
                    LoginPwd1 = PwdTxt.Text
                    Dim Notes1 As String
                    If Len(DeTxt.Text) <= 0 Then
                        Notes1 = "Date Created : " & Now.Date.ToString("dd-MMMM-yyyy")
                    Else
                        Notes1 = DeTxt.Text
                    End If
                    Dim Dt1 As Date = Now.Date
                    With SqlCommand.Parameters
                        .Add(New SqlParameter("@ID1", LogID))
                        .Add(New SqlParameter("@LogNm1", LoginNm1))
                        .Add(New SqlParameter("@Pwd1", LoginPwd1))
                        .Add(New SqlParameter("@Nots1", Notes1))
                        .Add(New SqlParameter("@Dt1", Now.Date))
                    End With
                    ToolStripLabel1.ForeColor = Color.Green
                    Con.Open()
                    ToolStripLabel1.Text = ("Updated " & SqlCommand.ExecuteNonQuery)
                    Call ClrBtn1_Click(sender, e)
                End Using
            End Using
        Catch ex As SqlException
            ToolStripLabel1.ForeColor = Color.Red
            ToolStripLabel1.Text = ("Not Updaed!")
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub DelBtn_Click(sender As Object, e As EventArgs) Handles DelBtn.Click
        Dim ThisAccID As Integer
        If Not ListView1.FocusedItem Is Nothing Then
            ThisAccID = Convert.ToInt32(ListView1.FocusedItem.ImageKey)
        Else
            Exit Sub
        End If
        Dim connectionString As String = ConfigurationManager.ConnectionStrings("DBConStr").ConnectionString
        Dim Tra As SqlTransaction = Nothing
        Try
            Using Con As SqlConnection = New SqlConnection(connectionString)
                Con.Open()
                Tra = Con.BeginTransaction(IsolationLevel.ReadCommitted)
                Dim SqlCommand As SqlCommand = New SqlCommand("DelFrmAccByID", Con, Tra) With {.CommandType = CommandType.StoredProcedure}
                With SqlCommand.Parameters
                    .Add(New SqlParameter("@AccID1", ThisAccID))
                End With
                SqlCommand.ExecuteNonQuery()
                SqlCommand = New SqlCommand("DelFrmLogByID", Con, Tra) With {.CommandType = CommandType.StoredProcedure}
                With SqlCommand.Parameters
                    .Add(New SqlParameter("@AccID1", ThisAccID))
                End With
                SqlCommand.ExecuteNonQuery()
                ToolStripLabel1.ForeColor = Color.Green
                ToolStripLabel1.Text = ("Account and Logins Deleted.")
                Tra.Commit()
            End Using
        Catch ex As SqlException
            Tra.Rollback()
            ToolStripLabel1.ForeColor = Color.Red
            ToolStripLabel1.Text = ("Not Updaed!")
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub DelBtn1_Click(sender As Object, e As EventArgs) Handles DelBtn1.Click
        Dim ThisLogID As Integer
        If Not ComboBox1.SelectedItem Is Nothing Then
            ThisLogID = DirectCast(ComboBox1.SelectedItem, KeyValuePair(Of Integer, String)).Key
        Else
            Exit Sub
        End If
        Dim connectionString As String = ConfigurationManager.ConnectionStrings("DBConStr").ConnectionString
        Try
            Using Con As SqlConnection = New SqlConnection(connectionString)
                Using SqlCommand As SqlCommand = New SqlCommand("DelFrmLogsByID", Con) With {.CommandType = CommandType.StoredProcedure}
                    With SqlCommand.Parameters
                        .Add(New SqlParameter("@ID1", ThisLogID))
                    End With
                    Con.Open()
                    SqlCommand.ExecuteNonQuery()
                    ToolStripLabel1.ForeColor = Color.Green
                    ToolStripLabel1.Text = ("Logins Deleted.")
                End Using
            End Using
        Catch ex As SqlException
            ToolStripLabel1.ForeColor = Color.Red
            ToolStripLabel1.Text = ("Not Updaed!")
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
