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
        SellDetailForm.Hide()
        AboutForm.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        itemupdateform.TopLevel = False
        Panel2.Controls.Add(itemupdateform)
        itemupdateform.BringToFront()
        itemupdateform.Show()
        itemaddform.Hide()
        'ItemUpdateForm.Hide()
        ItemDeleteForm.Hide()
        ItemViewForm.Hide()
        ItemSellForm.Hide()
        SellDetailForm.Hide()
        AboutForm.Hide()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        ItemDeleteForm.TopLevel = False
        Panel2.Controls.Add(ItemDeleteForm)
        ItemDeleteForm.BringToFront()
        ItemDeleteForm.Show()
        itemaddform.Hide()
        itemupdateform.Hide()
        'ItemDeleteForm.Hide()
        ItemViewForm.Hide()
        ItemSellForm.Hide()
        SellDetailForm.Hide()
        AboutForm.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btn_inventory.Click
        ItemViewForm.TopLevel = False
        Panel2.Controls.Add(ItemViewForm)
        ItemViewForm.BringToFront()
        ItemViewForm.Show()
        itemaddform.Hide()
        itemupdateform.Hide()
        ItemDeleteForm.Hide()
        'ItemViewForm.Hide()
        ItemSellForm.Hide()
        SellDetailForm.Hide()
        AboutForm.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btn_sell.Click
        ItemSellForm.TopLevel = False
        Panel2.Controls.Add(ItemSellForm)
        ItemSellForm.BringToFront()
        ItemSellForm.Show()
        itemaddform.Hide()
        itemupdateform.Hide()
        ItemDeleteForm.Hide()
        ItemViewForm.Hide()
        ' ItemSellForm.Hide()
        SellDetailForm.Hide()
        AboutForm.Hide()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btn_about.Click
        AboutForm.TopLevel = False
        Panel2.Controls.Add(AboutForm)
        AboutForm.BringToFront()
        AboutForm.Show()
        itemaddform.Hide()
        itemupdateform.Hide()
        ItemDeleteForm.Hide()
        ItemViewForm.Hide()
        ItemSellForm.Hide()
        SellDetailForm.Hide()
        'AboutForm.Hide()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btn_home.Click
        itemupdateform.Hide()
        ItemDeleteForm.Hide()
        ItemViewForm.Hide()
        ItemSellForm.Hide()
        AboutForm.Hide()
        SellDetailForm.Hide()
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles btn_sellDetail.Click
        SellDetailForm.TopLevel = False
        Panel2.Controls.Add(SellDetailForm)
        SellDetailForm.BringToFront()
        SellDetailForm.Show()
        itemaddform.Hide()
        ItemDeleteForm.Hide()
        ItemViewForm.Hide()
        ItemSellForm.Hide()
        AboutForm.Hide()
    End Sub

End Class