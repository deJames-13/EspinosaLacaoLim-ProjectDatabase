Module LoginController

    Public new_user_info As Dictionary(Of String, String)
    'Dim f As LogInForm = LogInForm

    '
    ' CHECK IF SERVER IS CONNECTED
    '
    Public Function isConnected() As Boolean
        Return CreateConnection()
    End Function

    '
    ' CHECK IF USER EXISTS
    '
    Public Function userExists(name As String, Optional table As String = "customer") As Boolean

        Dim findUser As String = $"Select * FROM {table} WHERE username='{name}'"


        Dim dt As DataTable = ExecuteQuery(findUser)
        If dt Is Nothing Then
            Return False
        End If
        If dt.Rows.Count > 0 Then
            Return True
        End If
        Return False

    End Function

    '
    ' CHECK USER CREDENTIALS
    '
    Public Function isValidUser(username As String, pass As String, Optional table As String = "customer") As Boolean

        If table = "user" Then table = "login"
        Dim dt As DataTable = SelectWhere(table, $"username='{username}'", "username, password")

        If dt.Rows.Count = 0 Then
            MsgBox("User doesn't exist! Please create an account first!.", MsgBoxStyle.Exclamation, "Login error.")
            Return False
        End If


        If dt.Rows(0)("password") <> pass Then
            MsgBox("Incorrect password!", MsgBoxStyle.Exclamation, "Login error.")
            Return False
        End If

        Return True
    End Function


End Module
