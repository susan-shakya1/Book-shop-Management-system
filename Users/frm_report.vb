Public Class frm_report

                DataGridView1.Rows.Add(DataGridView1.Rows.Count + 1, dr.Item("transdate"), dr.Item("transno"), dr.Item("bookid"), dr.Item("bookname"), dr.Item("author"), dr.Item("price"), dr.Item("tax"), dr.Item("totalprice"), dr.Item("grandtotal"))
End Class