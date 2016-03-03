Public Class SP
    Private Sub FillSP()
        Dim Sql As String =
            <sql>
                SELECT * FROM SANPHAM_PS02770
            </sql>
        Connect(Sql, "SANPHAM_PS02770")
        bsSP.DataSource = ds.Tables("SANPHAM_PS02770")
        dgvShow.DataSource = bsSP
        bsSP.ResetBindings(False)
    End Sub
    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click

    End Sub

    Private Sub SP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Sql As String =
            <sql>
                SELECT * FROM SANPHAM_PS02770
            </sql>
        Connect(Sql, "SANPHAM_PS02770")
        bsSP.DataSource = ds.Tables("SANPHAM_PS02770")
        dgvShow.DataSource = bsSP
        bsSP.ResetBindings(False)
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        Dim Sql As String =
           <sql>
                insert into SANPHAM_PS02770(MASP, TENSP, GIASP, MALOAISP)
                values ('{0}', N'{1}', '{2}', '{3}')
            </sql>

        Sql = String.Format(Sql, txtmasp.Text, txtnamesp.Text, txtgia.Text, txtmaloai.Text)

        ExecuteNonQuery(Sql)

        FillSP()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim Sql As String =
            <sql>
                UPDATE      SANPHAM_PS02770
                SET         TENSP =N'{1}', GIASP ='{2}', MALOAISP ='{3}'
                WHERE        (MASP = '{0}')
            </sql>

        Sql = String.Format(Sql, txtmasp.Text, txtnamesp.Text, txtgia.Text, txtmaloai.Text)

        ExecuteNonQuery(Sql)

        FillSP()
    End Sub

    Private Sub dgvShow_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvShow.CellContentClick
        Try
            Dim RowView As DataRowView = bsSP.Current
            Dim Row As DataRow = RowView.Row

            txtmasp.Text = Row("MASP")
            txtnamesp.Text = Row("TENSP")
            txtgia.Text = Row("GIASP")
            txtmaloai.Text = Row("MALOAISP")

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim Sql As String =
           <sql>
                DELETE FROM SANPHAM_PS02770
                WHERE        (MASP = '{0}')
            </sql>
        Sql = String.Format(Sql, txtmasp.Text)

        ExecuteNonQuery(Sql)

        FillSP()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtgia.Clear()
        txtmaloai.Clear()
        txtmasp.Clear()
        txtnamesp.Clear()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class