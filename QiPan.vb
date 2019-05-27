Public Class QiPan

    Dim basemake(12, 12) As Integer
    Dim mouse As Boolean = True
    Dim out As Boolean = True
    Dim move As Byte = 1
    Dim mousepointer As Point

    Sub Clear()
        Dim i, j As Integer
        For i = 0 To 12
            For j = 0 To 12
                basemake(i, j) = 0
            Next
        Next
        move = 1
        Me.Invalidate()
    End Sub
    Property OnSetting() As Boolean
        Get
            Return mouse
        End Get
        Set(ByVal value As Boolean)
            mouse = value
            Refresh()
        End Set
    End Property
    Property OnSettingPoint() As Point
        Get
            Return Me.mousepointer
        End Get
        Set(ByVal value As Point)
            If mousepointer <> value Then
                If value.X > 12 Or value.Y > 12 Then
                    out = True
                Else
                    out = False
                    mousepointer = value
                    Refresh()
                End If
            End If
        End Set
    End Property
    Sub SetPoint(ByVal x As Integer, ByVal y As Integer)
        If basemake(x, y) = 0 Then
            basemake(x, y) = move
            If move = 1 Then
                move = 2
            ElseIf move = 2 Then
                move = 1
            End If
        End If
        Refresh()
    End Sub

    Private Sub QiPan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.DoubleBuffered = True
        Me.BackgroundImage = New Bitmap(260, 260)
    End Sub
    Private Sub QiPan_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseClick
        Me.SetPoint(Me.OnSettingPoint.X, Me.OnSettingPoint.Y)
    End Sub
    Private Sub QiPan_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.MouseLeave
        Me.out = True
        Refresh()
    End Sub
    Private Sub QiPan_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        Me.OnSettingPoint = New Point(e.X \ 20, e.Y \ 20)
    End Sub
    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        MyBase.OnPaint(e)
        Dim i, j As Integer
        Dim g As Graphics = e.Graphics
        For i = 0 To 12
            g.DrawLine(Pens.Black, 10, 10 + 20 * i, 250, 10 + 20 * i)
        Next
        For i = 0 To 12
            g.DrawLine(Pens.Black, 10 + 20 * i, 10, 10 + 20 * i, 250)
        Next
        For i = 0 To 12
            For j = 0 To 12
                If basemake(i, j) = 1 Then
                    g.FillEllipse(Brushes.Black, New RectangleF(5 + 20 * i, 5 + 20 * j, 10, 10))
                    g.DrawEllipse(Pens.Black, New RectangleF(5 + 20 * i, 5 + 20 * j, 10, 10))
                ElseIf basemake(i, j) = 2 Then
                    g.FillEllipse(Brushes.White, New RectangleF(5 + 20 * i, 5 + 20 * j, 10, 10))
                    g.DrawEllipse(Pens.Black, New RectangleF(5 + 20 * i, 5 + 20 * j, 10, 10))
                End If
            Next
        Next
        If OnSetting = True And basemake(mousepointer.X, mousepointer.Y) = 0 And out = False Then
            If move = 1 Then
                g.FillEllipse(Brushes.Black, New RectangleF(5 + 20 * mousepointer.X, 5 + 20 * mousepointer.Y, 10, 10))
                g.DrawEllipse(Pens.Black, New RectangleF(5 + 20 * mousepointer.X, 5 + 20 * mousepointer.Y, 10, 10))
                g.DrawRectangle(Pens.Blue, New Rectangle(5 + 20 * mousepointer.X, 5 + 20 * mousepointer.Y, 10, 10))
            ElseIf move = 2 Then
                g.FillEllipse(Brushes.White, New RectangleF(5 + 20 * mousepointer.X, 5 + 20 * mousepointer.Y, 10, 10))
                g.DrawEllipse(Pens.Black, New RectangleF(5 + 20 * mousepointer.X, 5 + 20 * mousepointer.Y, 10, 10))
                g.DrawRectangle(Pens.Blue, New Rectangle(5 + 20 * mousepointer.X, 5 + 20 * mousepointer.Y, 10, 10))
            End If
        End If
    End Sub

End Class
