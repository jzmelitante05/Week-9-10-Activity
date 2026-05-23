Public Class ProductsForm

    Private Sub ProductsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dgvProducts.Columns.Add("ProductName", "Product Name")
        dgvProducts.Columns.Add("Quantity", "Quantity")
        dgvProducts.Columns.Add("Price", "Price")

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        dgvProducts.Rows.Add("Laptop", 5, 35000)

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        If dgvProducts.SelectedRows.Count > 0 Then

            dgvProducts.Rows.RemoveAt(dgvProducts.SelectedRows(0).Index)

        Else

            MessageBox.Show("Select a row first.")

        End If

    End Sub

End Class
