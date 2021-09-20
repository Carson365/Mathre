Public Class CustomGroupBox
    Inherits GroupBox
    Public Property BorderColor As Color
        Get
            Return ColorTranslator.FromWin32(FrmMathre.SystemColor)
        End Get
        Set
            Me.Invalidate()
            If DesignMode Then Me.Parent?.Invalidate(Me.Bounds)
        End Set
    End Property
    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        Dim rect = New Rectangle(0, 0, ClientSize.Width, ClientSize.Height)
        ControlPaint.DrawBorder(e.Graphics, rect, BorderColor, ButtonBorderStyle.Solid)
        rect.Inflate(-1, -1)
        ControlPaint.DrawBorder(e.Graphics, rect, BorderColor, ButtonBorderStyle.Solid)
    End Sub
End Class