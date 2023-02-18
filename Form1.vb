Imports Newtonsoft.Json.Linq

Public Class Form1

    Dim Question_Id As Integer
    Dim answered As Boolean

    Public Sub SetLabels(id As Integer)
        Dim JsonData As String
        Dim Json As Object

        JsonData = My.Computer.FileSystem.ReadAllText("wwm_data.json")
        Json = Newtonsoft.Json.Linq.JObject.Parse(JsonData)
        Txt_question_id.Text = "Frage: " + id.ToString
        Txt_question.Text = "Frage: " + Json.Item(id.ToString)("question").ToString
        Txt_Money.Text = Json.Item(id.ToString)("money").ToString + "  €"

        Cmd_choice_A.Text = "A: " + Json.Item(id.ToString)("answers")("A").ToString
        Cmd_choice_B.Text = "B: " + Json.Item(id.ToString)("answers")("B").ToString
        Cmd_choice_C.Text = "C: " + Json.Item(id.ToString)("answers")("C").ToString
        Cmd_choice_D.Text = "D: " + Json.Item(id.ToString)("answers")("D").ToString

        Cmd_choice_A.BackColor = DefaultBackColor
        Cmd_choice_B.BackColor = DefaultBackColor
        Cmd_choice_C.BackColor = DefaultBackColor
        Cmd_choice_D.BackColor = DefaultBackColor

    End Sub

    Public Function ValidateSolution(tag As String) As Boolean
        Dim JsonData As String
        Dim Json As Object
        Dim answer As String

        JsonData = My.Computer.FileSystem.ReadAllText("wwm_data.json")
        Json = Newtonsoft.Json.Linq.JObject.Parse(JsonData)
        answer = Json.Item("aswers")(Question_Id.ToString).ToString
        If answer = tag Then
            Return True
        End If

        Return False
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Question_Id = 1
        SetLabels(Question_Id)

    End Sub
    Private Sub Cmd_choice_A_Click(sender As Object, e As EventArgs) Handles Cmd_choice_A.Click
        If ValidateSolution("A") Then
            Cmd_choice_A.BackColor = Color.Green
            answered = True
        Else
            Cmd_choice_A.BackColor = Color.Red
        End If
    End Sub

    Private Sub Cmd_choice_B_Click(sender As Object, e As EventArgs) Handles Cmd_choice_B.Click
        If ValidateSolution("B") Then
            Cmd_choice_B.BackColor = Color.Green
            answered = True
        Else
            Cmd_choice_B.BackColor = Color.Red
        End If
    End Sub

    Private Sub Cmd_choice_C_Click(sender As Object, e As EventArgs) Handles Cmd_choice_C.Click
        If ValidateSolution("C") Then
            Cmd_choice_C.BackColor = Color.Green
            answered = True
        Else
            Cmd_choice_C.BackColor = Color.Red
        End If
    End Sub

    Private Sub Cmd_choice_D_Click(sender As Object, e As EventArgs) Handles Cmd_choice_D.Click
        If ValidateSolution("D") Then
            Cmd_choice_D.BackColor = Color.Green
            answered = True
        Else
            Cmd_choice_D.BackColor = Color.Red
        End If
    End Sub

    Private Sub Cmd_Next_Click(sender As Object, e As EventArgs) Handles Cmd_Next.Click
        If answered Then
            If Question_Id < 15 Then
                Question_Id = Question_Id + 1
                SetLabels(Question_Id)
                answered = False
            Else
                Txt_question.Text = "You have won"
                Txt_question_id.Text = ""
                Cmd_choice_A.Visible = False
                Cmd_choice_B.Visible = False
                Cmd_choice_C.Visible = False
                Cmd_choice_D.Visible = False

                Cmd_Next.Visible = False
                Cmd_Replay.Visible = True

            End If
        End If
    End Sub

    Private Sub Cmd_Replay_Click(sender As Object, e As EventArgs) Handles Cmd_Replay.Click
        Question_Id = 1
        SetLabels(Question_Id)

        Cmd_choice_A.Visible = True
        Cmd_choice_B.Visible = True
        Cmd_choice_C.Visible = True
        Cmd_choice_D.Visible = True

        Cmd_Next.Visible = True
        Cmd_Replay.Visible = False
    End Sub
End Class
