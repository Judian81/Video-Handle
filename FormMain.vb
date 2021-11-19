
Namespace VideoHandle
    Partial Public Class FormMain
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub GetAspectRatioSize(source As String, ByRef width As Integer, ByRef height As Integer)
            Try
                Dim s = source.Split(" "c)
                Dim ar As Single = Single.Parse(s(2)) / Single.Parse(s(3))
                Dim c_ar As Single = CSng(width) / CSng(height)
                If ar < c_ar Then
                    width = CInt(Math.Truncate(CSng(height) * (ar)))
                Else
                    height = CInt(Math.Truncate(CSng(width) / (ar)))
                End If
            Catch
            End Try
        End Sub

        Private Sub BtnPlayLoop_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPlayLoop.Click
            Dim filename As String = Me.TextBox2.Text
            Dim Pcommand As String
            Dim m As New MciPlayer()
            Pcommand = "close " & "media-player"
            m.MCISendString(Pcommand)
            Pcommand = "open " & Chr(34) & filename & Chr(34) & " type mpegvideo alias " & "media-player" & " parent " & Me.PictureBox1.Handle.ToString() & " style child"
            m.MCISendString(Pcommand)
            Pcommand = "where " & "media-player" & " source"
            Dim s2 As String = m.MCISendString(Pcommand)
            Dim width As Integer = 390
            Dim height As Integer = 360
            Dim left As Integer
            Dim top As Integer
            GetAspectRatioSize(s2, width, height)
            If width < Me.PictureBox1.Width Then
                left = (Me.PictureBox1.Width - left) / 2
            End If
            If (height < Me.PictureBox1.Height) Then
                top = (Me.PictureBox1.Height - height) / 2
            Else
                top = 0
            End If
            Pcommand = "put " & "media-player" & " window at " & left & " " & top & " " & width & " " & height
            m.MCISendString(Pcommand)
            Pcommand = "play " & "media-player" & " repeat"
            m.MCISendString(Pcommand)
            Pcommand = "status " & "media-player" & " length"
            Dim s1 As String = m.MCISendString(Pcommand)
            Pcommand = "setaudio " & "media-player" & " off"
            m.MCISendString(Pcommand)
        End Sub

        Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
            Dim Pcommand As String
            Dim m As New MciPlayer()
            Pcommand = Me.TextBox1.Text
            m.MCISendString(Pcommand)
        End Sub

        Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Me.Text = Me.Handle.ToString()
            Me.Label2.Text = Me.PictureBox1.Handle.ToString
        End Sub

        Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
            Dim filename As String = Me.TextBox2.Text
            Dim Pcommand As String
            Dim m As New MciPlayer()
            Pcommand = "where " & "media-player" & " source"
            Dim s2 As String = m.MCISendString(Pcommand)
            Dim width As Integer = 188
            Dim height As Integer = 188
            Dim left As Integer
            Dim top As Integer
            GetAspectRatioSize(s2, width, height)
            If width < Me.PictureBox1.Width Then
                left = (Me.PictureBox1.Width - left) / 2
            End If
            If (height < Me.PictureBox1.Height) Then
                top = (Me.PictureBox1.Height - height) / 2
            Else
                top = 0
            End If
            Me.Label3.Text = "video width: " & width
            Me.Label4.Text = "video height: " & height
            Me.Label5.Text = "origin size: " & s2
            Pcommand = "put " & "media-player" & " destination at " & left & " " & top & " " & width & " " & height
            m.MCISendString(Pcommand)
        End Sub
    End Class
End Namespace