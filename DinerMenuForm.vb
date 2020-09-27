'Ian Gunter
'RCET0265
'Fall 2020
'DinerMenu 
'https://github.com/IanGunter/DinerMenu.git

Option Explicit On
Option Strict On

Public Class DinerMenuForm

    'Private Sub Soupbutton_Click sets the code for when the button Soup is pressed 
    Private Sub SoupButton_Click(sender As Object, e As EventArgs) Handles SoupButton.Click

        'Write string into DisplaySpecialLabel
        DisplaySpecialLabel.Text = " *Soup of the Day*" & vbNewLine & "Creamy Meat Soup " & StrDup(3, vbNewLine) & "Thuck-cut chunks of seafood and stock provides a satisfying savoriness."

        'Set the Picture inside FoodPictureBox
        FoodPictureBox.Image = My.Resources.Creamy_meat_soup

    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub SaladButton_Click(sender As Object, e As EventArgs) Handles SaladButton.Click

        'Write string into DisplaySpecialLabel
        DisplaySpecialLabel.Text = " *Salad Special *" & vbNewLine & "Deku Leaf" & StrDup(3, vbNewLine) & "A single 1 Ft by 3 Ft leaf with your choice of dressing."

        'Set the Picture inside FoodPictureBox
        FoodPictureBox.Image = My.Resources.Deku_Leaf


    End Sub

    Private Sub FishButton_Click(sender As Object, e As EventArgs) Handles FishButton.Click

        'Write string into DisplaySpecialLabel
        DisplaySpecialLabel.Text = " *Fish Dinner Special *" & vbNewLine & "SeaFood Skewer" & StrDup(3, vbNewLine) & " The natural water in this medley of seafaring creatures makes for a delicious broth."

        'Set the Picture inside FoodPictureBox
        FoodPictureBox.Image = My.Resources.Seafood_skewer
    End Sub
End Class
