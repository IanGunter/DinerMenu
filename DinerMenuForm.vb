'Ian Gunter
'RCET0265
'Fall 2020
'DinerMenu 
'



Public Class DinerMenuForm
    Private Sub SoupButton_Click(sender As Object, e As EventArgs) Handles SoupButton.Click
        DisplaySpecialLabel.Text = " *Soup of the Day*" & vbNewLine & "Creamy Meat Soup " & StrDup(3, vbNewLine) & "Thuck-cut chunks of seafood and stock provides a satisfying savoriness."

        FoodPictureBox.Image = My.Resources.Creamy_meat_soup

    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub SaladButton_Click(sender As Object, e As EventArgs) Handles SaladButton.Click
        DisplaySpecialLabel.Text = " *Salad Special *" & vbNewLine & "Deku Leaf" & StrDup(3, vbNewLine) & "A single 1 Ft by 3 Ft leaf with your choice of dressing."

        FoodPictureBox.Image = My.Resources.Deku_Leaf


    End Sub

    Private Sub FishButton_Click(sender As Object, e As EventArgs) Handles FishButton.Click
        DisplaySpecialLabel.Text = " *Fish Dinner Special *" & vbNewLine & "SeaFood Skewer" & StrDup(3, vbNewLine) & " The natural water in this medley of seafaring creatures makes for a delicious broth."

        FoodPictureBox.Image = My.Resources.Seafood_skewer
    End Sub
End Class
