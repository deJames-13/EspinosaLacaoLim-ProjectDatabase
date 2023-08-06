Imports MySql.Data.MySqlClient
Imports System.Data.Common

Module AdminQueries
    Dim query As String = ""
    Dim values As String = ""
    Dim msg As String = ""
    Dim username As String = ""
    '
    ' To View Orders in Admin Dashboard
    '
    Public order_query As String = ""

    '
    ' SET ORDER STATUS
    '
    Public Sub SetOrderStatus(id As Integer, status As String)
        query = $"
        UPDATE `order_has_product` SET
        status = ""{status}""
        WHERE order_id = {id};
        "
        ExecuteQuery(query)
    End Sub


    '
    ' HANDLES Admin Queries
    '
    Public Function AdminTransactions(data As Dictionary(Of String, Object)) As Integer
        '
        '  DATA dictionary should have
        '  (0) - Action
        '  (1) - User Data Dict Object
        '
        If Not data.Keys.Contains("action") Then Return 0

        username = current_user("username")
        query = ""


        Select Case data("action")

            '
            ' Manage Orders
            '
            Case "manage_orders"
                data.Remove("action")
                values = GetValues(data)
                query &= $"INSERT INTO user_manages_order SET {values}, managed_date = NOW()"

                msg = "Order Managed Successfully!"

            '
            ' QUERY FOR CREATING NEW ITEM
            '

            Case "new_item"

                values = GetValues(data("item"))
                query &= $"
                INSERT INTO product SET
                {values},
                created_at = NOW(),
                created_by = ""{username}"",
                last_modified_at = NOW(),
                last_modified_by = ""{username}""
                ;
                "

                msg = "Item Added Successfully!"

            Case "update_item"
                values = GetValues(data("item"))

                query &= $"
                UPDATE product SET
                {values},
                last_modified_at = NOW(),
                last_modified_by = ""{username}""
                WHERE id = {data("id")};
                "


                msg = "Item Updated Successfully!"

            Case "delete_item"

                query &= $"
                -- CASCADE IS ON
                -- DELETE FROM order_has_product WHERE  product_id = {data("id")};
                -- DELETE FROM cart WHERE product_id = {data("id")};
                DELETE FROM product WHERE id = {data("id")};
                "

                msg = "Item Deleted Successfully!"


            '
            ' Query FOR CREATING NEW USER
            ' 
            ' USER DATA dictionary should have
            ' (0) - User Data Dict Object
            ' (1) - User Pass 
            Case "new_user"
                values = GetValues(data("user"))
                query &= $"
                INSERT INTO user SET 
                {values},
                created_at = NOW()
                ;
                INSERT INTO login
                SET 
                id = {data("user")("id")},
                username = ""{data("user")("username")}"",
                password = ""{data("password")}"";
                ;
                "
                msg = "User Created Successfully!"

            '
            ' Query for Updating User Info
            '
            Case "update_user"
                values = GetValues(data("user"))
                query &= $"
                UPDATE user SET {values} WHERE id = {data("id")};    
                UPDATE login SET username = ""{data("user")("username")}"", password = ""{data("password")}"" WHERE id = {data("id")};
                "
                msg = "User Info Updated Successfully!"
            '
            ' Query for Deleting User
            '
            Case "delete_user"
                query &= $"
                -- CASCADE IS ON
                -- DELETE FROM user_has_schedule WHERE user_id = {data("id")};
                -- DELETE FROM user_has_salary WHERE user_id = {data("id")};
                -- DELETE FROM login WHERE id = {data("id")};
                DELETE FROM user WHERE id = {data("id")};   
                "
                msg = "User Deleted Successfully!"


            '
            ' Query for Creating New Schedule
            '
            Case "new_schedule"
                Dim schedule_info As String = GetValues(data("schedule_info"))
                Dim schedule As String = GetValues(data("schedule"))

                query &= $"

                INSERT INTO schedule_info SET
                {schedule_info};

                INSERT INTO user_has_schedules SET
                {schedule},
                created_at = NOW(),
                created_by = ""{username}""
                ;
                "
                msg = "Schedule Added Successfully!"


        End Select

        'MsgBox(query)

        Try
            ExecuteNonQuery(query)

            MsgBox(msg, MsgBoxStyle.Information, "Action Success")
        Catch ex As Exception
            msg = ex.Message
            If ex.Message.Contains("You have an error in your SQL syntax") Then
                msg = "Invalid Input Detected!"
            End If

            MsgBox(msg, MsgBoxStyle.Exclamation, "Application Error")
            Return -1
        End Try
        Return 1
    End Function


    '
    ' Provides Employee info in String
    '
    Private Function GetValues(data As Dictionary(Of String, Object)) As String

        Dim values As String = ""
        For Each key In data.Keys
            If key = "created_at" Then Continue For
            If IsDBNull(data(key)) Then Continue For

            Dim value As String = data(key).ToString
            values &= $"{vbNewLine}{vbTab}{key}=""{value.Replace("""", """""")}"","
        Next
        values = values.TrimEnd(",")

        Return values
    End Function

    '
    ' PAYROLL CODE 
    '
    Public Salary_And_Benefits_ID As String
    Public Sub InsPR()
        Salary_And_Benefits_ID = GetLastId("salary") + 1
        Dim statement1 As String
        Dim statement2 As String
        Dim statement4 As String
        Dim TaxStatement As String
        Dim statement As String = "SELECT u.id AS EMPLOYEE_ID,u.username,  u.first_name, s.id AS Salary_id , uhs.payGrade , s.hoursWorked,b.id AS Benefits_id, b.pagIbig, b.sss, b.philHealth, s.gross_amount, s.net_amount AS Total, uhs.created_at
                                    FROM user AS u
                                    JOIN user_has_salary AS uhs ON uhs.user_id = u.id
                                    JOIN salary AS s ON s.id = uhs.salary_id
                                    JOIN benefits AS b ON b.id = s.benefits_id
                                    ORDER BY u.id ASC;"


        statement1 = $"INSERT INTO
                        benefits(id)
                        VALUES 
                        ({Salary_And_Benefits_ID});"

        statement2 = $"INSERT INTO
                        salary(id, benefits_id, hoursWorked)
                        VALUES
                        ({Salary_And_Benefits_ID},{Salary_And_Benefits_ID}, {PayrollPage.Work_Hours.Text});"



        statement4 = $"INSERT INTO user_has_salary(user_id, salary_id, payGrade, created_at) 
                        SELECT u.id, {Salary_And_Benefits_ID} , {PayrollPage.Pay_Grade.Text}, NOW()
                        FROM user AS u
                        WHERE u.username = ""{PayrollPage.Username.Text}"";"

        If PayrollPage.Pay_Grade.Text >= 86.805902777777774 Then
            TaxStatement = $"UPDATE salary
            SET tax_percentage = 0.15
            WHERE id = {Salary_And_Benefits_ID};"
        Else
            TaxStatement = $"UPDATE salary
SET tax_percentage = 0.00
WHERE id = {Salary_And_Benefits_ID};"
        End If
        Try

            dtablefill(statement1 + statement2 + statement4 + TaxStatement)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        PayrollPage.payrollGrid.DataSource = dtablefill(statement)
    End Sub

    Public Sub Comp()
        Dim statement1 As String
        Dim statement As String = "SELECT u.id AS EMPLOYEE_ID,u.username,  u.first_name, s.id AS Salary_id , uhs.payGrade , s.hoursWorked,b.id AS Benefits_id, b.pagIbig, b.sss, b.philHealth, s.gross_amount, s.net_amount AS Total, uhs.created_at
                                    FROM user AS u
                                    JOIN user_has_salary AS uhs ON uhs.user_id = u.id
                                    JOIN salary AS s ON s.id = uhs.salary_id
                                    JOIN benefits AS b ON b.id = s.benefits_id
                                    ORDER BY u.id ASC;"


        statement1 = $"UPDATE salary AS s
                    JOIN user_has_salary AS uhs ON s.id = uhs.salary_id
                    JOIN user AS u ON u.id = uhs.user_id
                    SET s.gross_amount = uhs.payGrade * s.hoursWorked;

                    UPDATE benefits AS b
                    JOIN salary AS s ON s.benefits_id = b.id
                    SET b.philHealth = 0.04 * s.gross_amount,
                    b.sss = 0.045 * s.gross_amount,
                    b.pagibig = 0.02 * s.gross_amount ;

                    UPDATE salary  AS s
                    JOIN benefits AS b ON s.benefits_id = b.id
                    SET s.net_amount = s.gross_amount - (b.sss + b.pagIbig + b.philHealth + (s.tax_percentage * s.gross_amount)) ;"


        Try

            dtablefill(statement1)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        PayrollPage.payrollGrid.DataSource = dtablefill(statement)
    End Sub

    Public Sub Clearr()
        PayrollPage.Employee_Name.Clear()
        PayrollPage.Username.Clear()
        PayrollPage.Pay_Grade.Clear()
        PayrollPage.Work_Hours.Clear()
        PayrollPage.Gross_Salary.Clear()
        PayrollPage.Net_Salary.Clear()


    End Sub

    Public Sub Del()
        Dim statement As String
        Dim statement1 As String = "SELECT u.id AS EMPLOYEE_ID,u.username,  u.first_name, s.id AS Salary_id , uhs.payGrade , s.hoursWorked,b.id AS Benefits_id, b.pagIbig, b.sss, b.philHealth, s.gross_amount, s.net_amount AS Total, uhs.created_at
                                    FROM user AS u
                                    JOIN user_has_salary AS uhs ON uhs.user_id = u.id
                                    JOIN salary AS s ON s.id = uhs.salary_id
                                    JOIN benefits AS b ON b.id = s.benefits_id
                                    ORDER BY u.id ASC;"

        statement = $"DELETE uhs
                    FROM user_has_salary AS uhs
                    JOIN user AS u ON u.id = uhs.user_id
                    WHERE u.username = '{PayrollPage.Username.Text}' AND uhs.salary_id = {Salary_And_Benefits_ID} ;
                    
                    DELETE FROM benefits
                    WHERE id = {Salary_And_Benefits_ID};

                    DELETE FROM salary
                    WHERE id = {Salary_And_Benefits_ID};
                    
                    "
        Try
            MessageBox.Show(statement)
            dtablefill(statement)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        PayrollPage.payrollGrid.DataSource = dtablefill(statement1)
    End Sub





End Module
