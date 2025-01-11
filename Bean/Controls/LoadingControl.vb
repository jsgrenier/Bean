Imports System.Drawing.Drawing2D
Imports System.ComponentModel

Public Class LoadingControl
    Inherits UserControl

    Private angle As Integer = 0
    Private timer As Timer

    Private _arcColor As Color = Color.FromArgb(255, 0, 122, 204)
    Private _backgroundColor As Color = Color.FromArgb(100, 0, 122, 204)
    Private _arcThickness As Integer = 5
    Private _arcLength As Integer = 120
    Private _padding As Integer = 10

    Public Sub New()
        Me.DoubleBuffered = True
        Me.SetStyle(ControlStyles.ResizeRedraw, True)
        Me.SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
        Me.SetStyle(ControlStyles.AllPaintingInWmPaint, True)
        Me.SetStyle(ControlStyles.UserPaint, True)

        timer = New Timer()
        AddHandler timer.Tick, AddressOf Timer_Tick
        timer.Interval = 16 ' Approximately 60 FPS
    End Sub

    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        MyBase.OnPaint(e)

        Dim g As Graphics = e.Graphics
        g.SmoothingMode = SmoothingMode.AntiAlias

        Dim rect As New Rectangle(_padding, _padding, Me.Width - 1 - 2 * _padding, Me.Height - 1 - 2 * _padding)
        Dim pen As New Pen(_backgroundColor, _arcThickness)

        ' Draw the background circle
        g.DrawArc(pen, rect, 0, 360)

        ' Draw the animated arc
        pen.Color = _arcColor
        g.DrawArc(pen, rect, angle, _arcLength)

        pen.Dispose()
    End Sub

    Private Sub Timer_Tick(ByVal sender As Object, ByVal e As EventArgs)
        angle += 5 ' Smaller increment for smoother rotation
        If angle >= 360 Then
            angle = 0
        End If
        Me.Invalidate()
    End Sub

    Public Sub Start()
        timer.Start()
    End Sub

    Public Sub [Stop]()
        timer.Stop()
    End Sub

    <Category("Appearance")>
    Public Property ArcColor As Color
        Get
            Return _arcColor
        End Get
        Set(ByVal value As Color)
            _arcColor = value
            Me.Invalidate()
        End Set
    End Property

    <Category("Appearance")>
    Public Property BackgroundColor As Color
        Get
            Return _backgroundColor
        End Get
        Set(ByVal value As Color)
            _backgroundColor = value
            Me.Invalidate()
        End Set
    End Property

    <Category("Appearance")>
    Public Property ArcThickness As Integer
        Get
            Return _arcThickness
        End Get
        Set(ByVal value As Integer)
            _arcThickness = value
            Me.Invalidate()
        End Set
    End Property

    <Category("Appearance")>
    Public Property ArcLength As Integer
        Get
            Return _arcLength
        End Get
        Set(ByVal value As Integer)
            _arcLength = value
            Me.Invalidate()
        End Set
    End Property

    <Category("Appearance")>
    Public Property PaddingSize As Integer
        Get
            Return _padding
        End Get
        Set(ByVal value As Integer)
            _padding = value
            Me.Invalidate()
        End Set
    End Property

    <Category("Appearance")>
    Public Property AnimationSpeed As Integer
        Get
            Return timer.Interval
        End Get
        Set(ByVal value As Integer)
            If value > 0 Then
                timer.Interval = value
            End If
        End Set
    End Property
End Class
