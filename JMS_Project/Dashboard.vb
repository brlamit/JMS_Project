Public Class Dashboard

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        'itemaddform.Show()
        itemaddform.TopLevel = False
        Panel2.Controls.Add(itemaddform)
        itemaddform.BringToFront()
        itemaddform.Show()
        'itemaddform.Hide()
        ItemUpdateForm.Hide()
        ItemDeleteForm.Hide()
        ItemViewForm.Hide()
        ItemSellForm.Hide()
        AboutForm.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ItemUpdateForm.TopLevel = False
        Panel2.Controls.Add(ItemUpdateForm)
        ItemUpdateForm.BringToFront()
        ItemUpdateForm.Show()
        itemaddform.Hide()
        'ItemUpdateForm.Hide()
        ItemDeleteForm.Hide()
        ItemViewForm.Hide()
        ItemSellForm.Hide()
        AboutForm.Hide()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ItemDeleteForm.TopLevel = False
        Panel2.Controls.Add(ItemDeleteForm)
        ItemDeleteForm.BringToFront()
        ItemDeleteForm.Show()
        itemaddform.Hide()
        ItemUpdateForm.Hide()
        'ItemDeleteForm.Hide()
        ItemViewForm.Hide()
        ItemSellForm.Hide()
        AboutForm.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ItemViewForm.TopLevel = False
        Panel2.Controls.Add(ItemViewForm)
        ItemViewForm.BringToFront()
        ItemViewForm.Show()
        itemaddform.Hide()
        ItemUpdateForm.Hide()
        ItemDeleteForm.Hide()
        'ItemViewForm.Hide()
        ItemSellForm.Hide()
        AboutForm.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ItemSellForm.TopLevel = False
        Panel2.Controls.Add(ItemSellForm)
        ItemSellForm.BringToFront()
        ItemSellForm.Show()
        itemaddform.Hide()
        ItemUpdateForm.Hide()
        ItemDeleteForm.Hide()
        ItemViewForm.Hide()
        ' ItemSellForm.Hide()
        AboutForm.Hide()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        AboutForm.TopLevel = False
        Panel2.Controls.Add(AboutForm)
        AboutForm.BringToFront()
        AboutForm.Show()
        itemaddform.Hide()
        ItemUpdateForm.Hide()
        ItemDeleteForm.Hide()
        ItemViewForm.Hide()
        ItemSellForm.Hide()
        'AboutForm.Hide()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        ItemUpdateForm.Hide()
        ItemDeleteForm.Hide()
        ItemViewForm.Hide()
        ItemSellForm.Hide()
        AboutForm.Hide()
    End Sub
End Class