Module WindowPageManager
    '######################################################################
    ' INPUT VALIDATION
    '######################################################################
    Public Function validNumber(str As String) As Boolean
        If IsNumeric(str) Then
            Return True
        End If
        Return False
    End Function

    Public Function isEmptyInput(ByRef input As TextBox, Optional message As String = "Input Required!") As Boolean
        If String.IsNullOrEmpty(input.Text.Trim) Then
            MsgBox(message, MsgBoxStyle.Exclamation, "Empty Input!")
            Return True
        End If
        Return False
    End Function

    Public Function validInputs(ByRef texts As TextBox())
        For Each t In texts
            Dim message As String = $"Input Required for {t.Name.ToUpper.Replace("_", " ")}"
            If isEmptyInput(t, message) Then
                Return False
            End If
        Next
        Return True
    End Function
    '######################################################################




    '######################################################################
    ' WINDOW and CONTROL MANIPULATION
    '######################################################################
    '#  Takes a list of textbox and iterates it to clear each instance
    '######################################################################
    Public Sub ClearAll(ts As Object())
        Try
            For Each t In ts
                Select Case t.GetType()
                    Case GetType(TextBox)
                        t.Text = ""
                    Case GetType(ComboBox)
                        t.SelectedIndex = -1
                    Case GetType(CheckBox)
                        t.Checked = False
                    Case GetType(RadioButton)
                        t.Checked = False
                    Case GetType(DateTimePicker)
                        t.Value = Now
                    Case GetType(PictureBox)
                        t.Image = Nothing
                End Select

            Next
        Catch ex As Exception

    End Try
    End Sub

    Public Sub ToggleControls(ByRef controls As Control(), state As Boolean, Optional visible As Boolean = False)
        If Not visible Then visible = state
        For Each control In controls
            control.Enabled = state
            control.Visible = visible
        Next
    End Sub

    Public Sub ButtonHoverEvents(ByRef btns As Button())
        For Each btn In btns
            btn.ForeColor = Color.SteelBlue
            RemoveHandler btn.MouseEnter, AddressOf HoverEvents
            RemoveHandler btn.MouseLeave, AddressOf HoverEvents
            AddHandler btn.MouseEnter, AddressOf HoverEvents
            AddHandler btn.MouseLeave, AddressOf HoverEvents
        Next
    End Sub

    Public Sub DictionaryOfControls(ByRef controls As Control(), ByRef data As Dictionary(Of String, Object))
        For Each control In controls
            data(control.Name) = control
        Next
    End Sub

    Public Sub PrintDictionary(ByRef data As Dictionary(Of String, Object))
        Dim log As String = ""
        For Each item In data
            log &= vbNewLine & ($"{item.Key} : {item.Value}")
        Next
        MsgBox(log)
    End Sub

    Public Sub SelectCellRow(sender As Object, e As DataGridViewCellEventArgs)
        Dim cell As DataGridViewCell = CType(sender, DataGridView).CurrentCell
        If cell Is Nothing Then Return

        Dim row As DataGridViewRow = cell.OwningRow
        row.Selected = True
        row.DefaultCellStyle.SelectionBackColor = Color.LightSteelBlue

    End Sub

    '######################################################################

    '######################################################################
    '#  Manges the page switch by swapping the existing panel
    '######################################################################

    Private pages As Dictionary(Of String, Panel) = New Dictionary(Of String, Panel)
    Public activeForeColor As Color = Color.Black
    Public inactiveForeColor As Color = Color.White


    Public prevPage As Panel = Nothing
    Public currentPage As Panel = Nothing
    Public Sub switchPanel(ByRef newPage As Panel, current As Panel)
        If newPage Is current Then
            Return
        End If

        If pages.Keys.Contains(newPage.Name) Then current = pages(newPage.Name)
        current.ForeColor = inactiveForeColor

        current.Hide()
        newPage.Parent = current.Parent
        newPage.Dock = DockStyle.Fill
        newPage.Show()
        newPage.Focus()
        newPage.ForeColor = activeForeColor

        pages(newPage.Name) = newPage
        prevPage = current
        currentPage = newPage
    End Sub

    Dim toggleHover As Boolean = False
    Public Sub HoverEvents(sender As Object, e As EventArgs)
        toggleHover = Not toggleHover
        If sender.GetType() Is GetType(Button) Then
            HoverOnButton(CType(sender, Button), toggleHover)
        End If
    End Sub

    Public Sub HoverOnButton(button As Button, state As Boolean)
        Try
            Select Case state
                Case True
                    button.BackColor = Color.Azure
                    button.FlatAppearance.BorderSize += 1
                Case False

                    button.BackColor = Color.Transparent
                    button.FlatAppearance.BorderSize -= 1
            End Select
        Catch ex As Exception

        End Try
    End Sub



    '######################################################################
    Public Function DataRowToDictionary(row As DataRow) As Dictionary(Of String, Object)
        Dim dictionary As New Dictionary(Of String, Object)()

        For Each column As DataColumn In row.Table.Columns
            Dim columnName As String = column.ColumnName
            Dim value As Object = row(columnName)
            dictionary.Add(columnName, value)
        Next

        Return dictionary
    End Function
    Public Function DictionariesAreEqual(dict1 As Dictionary(Of String, Object), dict2 As Dictionary(Of String, Object)) As Boolean
        If dict1 Is Nothing AndAlso dict2 Is Nothing Then
            Return True
        End If

        If dict1 Is Nothing OrElse dict2 Is Nothing Then
            Return False
        End If

        If dict1.Count <> dict2.Count Then
            Return False
        End If

        For Each kvp As KeyValuePair(Of String, Object) In dict1
            Dim key As String = kvp.Key
            Dim value1 As Object = kvp.Value
            Dim value2 As Object = Nothing

            If dict2.TryGetValue(key, value2) Then
                If Not Equals(value1, value2) Then
                    Return False
                End If
            Else
                Return False
            End If
        Next

        Return True
    End Function

End Module
