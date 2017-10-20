Public Class Encuesta
    Public control_a As Integer = 0
    Public control_b As Integer = 0
    Private Sub Encuesta_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button1.BackColor = Color.DarkBlue

        control_a = control_a + 1
        Button1.Enabled = False
        Button2.Enabled = False


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Si2.Click
        control_a = control_a + 1
        Si2.BackColor = Color.DarkBlue
        Si2.Enabled = False
        No2.Enabled = False

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Si3.Click
        control_a = control_a + 1
        Si3.BackColor = Color.DarkBlue
        Si3.Enabled = False
        No3.Enabled = False

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Si4.Click
        control_a = control_a + 1
        Si4.BackColor = Color.DarkBlue
        Si4.Enabled = False
        No4.Enabled = False

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Si5.Click
        control_a = control_a + 1
        Si5.BackColor = Color.DarkBlue
        Si5.Enabled = False
        No5.Enabled = False

    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Si6.Click
        control_a = control_a + 1
        Si6.BackColor = Color.DarkBlue
        Si6.Enabled = False
        No6.Enabled = False

    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Si7.Click
        control_a = control_a + 1
        Si7.BackColor = Color.DarkBlue
        Si7.Enabled = False
        No7.Enabled = False


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        control_b = control_b + 1
        Button2.BackColor = Color.DarkBlue
        Button2.Enabled = False
        Button1.Enabled = False

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles No2.Click
        control_b = control_b + 1
        No2.BackColor = Color.DarkBlue
        No2.Enabled = False
        Si2.Enabled = False
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles No3.Click
        control_b = control_b + 1
        No3.BackColor = Color.DarkBlue
        No3.Enabled = False
        Si3.Enabled = False
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles No4.Click
        control_b = control_b + 1
        No4.BackColor = Color.DarkBlue
        No4.Enabled = False
        Si4.Enabled = False
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles No5.Click
        control_b = control_b + 1
        No5.BackColor = Color.DarkBlue
        No5.Enabled = False
        Si5.Enabled = False

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles No6.Click
        control_b = control_b + 1
        No6.BackColor = Color.DarkBlue
        No6.Enabled = False
        Si6.Enabled = False

    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles No7.Click
        control_b = control_b + 1
        No7.BackColor = Color.DarkBlue
        No7.Enabled = False
        Si7.Enabled = False

    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Me.Close()
        Form1.Show()

    End Sub

    Private Sub Resultados_Click(sender As Object, e As EventArgs) Handles Resultados.Click

        Resultado.Show()
        Resultado.TextBox1.Text = control_a
        Resultado.TextBox2.Text = control_b



        Me.Close()


    End Sub
End Class