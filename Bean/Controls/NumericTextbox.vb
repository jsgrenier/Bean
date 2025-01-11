Imports Guna.UI2.WinForms

Public Class NumericTextbox
    Inherits Guna2TextBox

    Private _allowDecimals As Boolean = True

    Public Property AllowDecimals As Boolean
        Get
            Return _allowDecimals
        End Get
        Set(value As Boolean)
            _allowDecimals = value
        End Set
    End Property

    Private Sub Guna2NumericTextbox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        ' Allow only numbers, decimal separator (if allowed), and control keys
        If Not (Char.IsDigit(e.KeyChar) OrElse
                (e.KeyChar = "." AndAlso _allowDecimals AndAlso Not Me.Text.Contains(".")) OrElse
                Char.IsControl(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

End Class