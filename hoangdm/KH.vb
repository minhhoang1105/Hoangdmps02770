Public Class frmKH
    Private Sub FillKH()
        Dim Sql As String =
            <sql>
                SELECT * FROM KHACHHANG_PS02770
            </sql>
        Connect(Sql, "KHACHHANG_PS02770")
        bsKH.DataSource = ds.Tables("KHACHHANG_PS02770")
        dgvShow.DataSource = bsKH
        bsKH.ResetBindings(False)
    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        FillKH()
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        Dim Sql As String =
            <sql>
                insert into KHACHHANG_PS02770(MAKH, TENKH, DIACHIKH, NGAYSINHKH)
                values ('{0}', N'{1}', N'{2}', N'{3}')
            </sql>

        Sql = String.Format(Sql, txtmakh.Text, txtname.Text, txtdiachi.Text, txtdate.Text)

        ExecuteNonQuery(Sql)

        FillKH()

        txtmakh.Clear()
        txtname.Clear()
        txtdiachi.Clear()
        txtDate.Clear()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim Sql As String =
            <sql>
                UPDATE      KHACHHANG_PS02770
                SET         TENKH =N'{1}', DIACHIKH ='{2}', NGAYSINHKH ='{3}'
                WHERE        (MAKH = '{0}')
            </sql>

        Sql = String.Format(Sql, txtmakh.Text, txtname.Text, txtdiachi.Text, txtdate.Text)

        ExecuteNonQuery(Sql)

        FillKH()

        txtmakh.Clear()
        txtname.Clear()
        txtdiachi.Clear()
        txtDate.Clear()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim Sql As String =
            <sql>
                DELETE FROM KHACHHANG_PS02770
                WHERE        (MAKH = '{0}')
            </sql>
        Sql = String.Format(Sql, txtmakh.Text)

        ExecuteNonQuery(Sql)

        FillKH()

        txtmakh.Clear()
        txtname.Clear()
        txtdiachi.Clear()
        txtDate.Clear()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtmakh.Clear()
        txtname.Clear()
        txtdiachi.Clear()
        txtDate.Clear()
    End Sub

    Private Sub dgvShow_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvShow.CellContentClick
        Try
            Dim RowView As DataRowView = bsKH.Current
            Dim Row As DataRow = RowView.Row

            txtmakh.Text = Row("MAKH")
            txtname.Text = Row("TENKH")
            txtdiachi.Text = Row("DIACHIKH")
            txtDate.Text = Row("NGAYSINHKH")

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

    Private Sub frmKH_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Sql As String =
            <sql>
                SELECT * FROM KHACHHANG_PS02770
            </sql>
        Connect(Sql, "KHACHHANG_PS02770")
        bsKH.DataSource = ds.Tables("KHACHHANG_PS02770")
        dgvShow.DataSource = bsKH
        bsKH.ResetBindings(False)
    End Sub

    Private Sub txtdate_TextChanged(sender As Object, e As EventArgs)

    End Sub
End Class