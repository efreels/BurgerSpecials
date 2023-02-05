Public Class Form1
    Private Sub btnPrime_Click(sender As Object, e As EventArgs) Handles btnPrime.Click
        'When user clicks Prime Beef button, Select Meal button becomes active
        'Prime Beef pictures is visible and Veggie Burger picture is invisible
        btnSelectMeal.Enabled = True
        picPrime.Visible = True
        picVeggie.Visible = False
    End Sub

    Private Sub btnVeggie_Click(sender As Object, e As EventArgs) Handles btnVeggie.Click
        'When user clicks Veggie button, Select Meal button becomes active
        'Veggie Burger picture is visible and Prime Beef picture is invisible
        btnSelectMeal.Enabled = True
        picPrime.Visible = False
        picVeggie.Visible = True
    End Sub

    Private Sub btnSelectMeal_Click(sender As Object, e As EventArgs) Handles btnSelectMeal.Click
        'All selection buttons (Prime Beef, Veggie, and SelectMeal) are disabled
        'Exit Window button is enabled.  Instructions label is invisible and confirmation label is visible
        btnSelectMeal.Enabled = False
        btnPrime.Enabled = False
        btnVeggie.Enabled = False
        btnExit.Enabled = True
        lblInstructions.Visible = False
        lblConfirmation.Visible = True
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Form is closed/program is ended.
        Close()
    End Sub
End Class
