Public Class Dashboard
    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        itemaddform.TopLevel = False
        Panel2.Controls.Add(itemaddform)
        itemaddform.BringToFront()
        itemaddform.Show()
        'itemaddform.Hide()
        itemupdateform.Hide()
        ItemDeleteForm.Hide()
        ItemViewForm.Hide()
        ItemSellForm.Hide()
        SellDetailForm.Hide()
        AboutForm.Hide()
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
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

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
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

    Private Sub btn_inventory_Click(sender As Object, e As EventArgs) Handles btn_inventory.Click
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

    Private Sub btn_sell_Click(sender As Object, e As EventArgs) Handles btn_sell.Click
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

    Private Sub btn_about_Click(sender As Object, e As EventArgs) Handles btn_about.Click
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
    End Sub

    Private Sub btn_sellDetail_Click(sender As Object, e As EventArgs) Handles btn_sellDetail.Click
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

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        AboutForm.TopLevel = False
        Panel2.Controls.Add(AboutForm)
        AboutForm.BringToFront()
        AboutForm.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        itemaddform.TopLevel = False
        Panel2.Controls.Add(itemaddform)
        itemaddform.BringToFront()
        itemaddform.Show()
    End Sub
End Class