Public Class frm
    Private Sub btnMain_Click(sender As Object, e As EventArgs) Handles btnMain.Click
        If btnMain.Text = "Check" Or btnMain.Text = "Incorrect, reenter." Then
            checkNames()
        ElseIf btnMain.Text = "Enter" Or btnMain.Text = "Incorrect, please try again." Then
            checkNumber()
        ElseIf btnMain.Text = "Correct!" Then
            emptyText()
        End If

    End Sub

    'Write a visual basic program that has one label, and one textbox and a button.
    'The label starts With “Last name".
    'The textbox start out blank. 
    'The button should be labeled "check".
    'If the user enters the programmer's (that’s you) last name in the textbox and clicks the check button then 
    'the label changes To "N-number" And the button label becomes "enter",  
    'If the user clicks the check button And the last name Is wrong Then 
    'the button 's label changes to "incorrect reenter".  
    'Once the correct last name Is entered Then
    'If the user enters the programmer's (that's you) N-number in the textbox and clicks the button
    'the textbox becomes read only And the button's label becomes "correct", 
    'If the N-number In the textbox Is wrong 
    'the button's label becomes "incorrect try again" and everything else remains the same.

    Function checkNames()
        If String.Equals(txtMain.Text, "Gomez") Then
            btnMain.Text = "Enter"
            lblMain.Text = "N-Number"
        Else
            btnMain.Text = "Incorrect, reenter."
        End If

    End Function

    Function checkNumber()
        If String.Equals(txtMain.Text, "Gomez N00875564") Then
            btnMain.Text = "Correct!"
        Else
            btnMain.Text = "Incorrect, please try again."
        End If

        If String.Equals(txtMain.Text, "") Then
            Reset()
        End If

    End Function

    Function emptyText()
        txtMain.Text = ""
        btnMain.Text = "Check"
        lblMain.Text = "Last Name"
    End Function

End Class
