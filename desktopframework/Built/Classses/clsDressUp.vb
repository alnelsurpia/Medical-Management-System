Public Class clsDressUp
    Public Class clsDarkDress
        Private oDark As New clsThemes.DarkBlueThemes

        Public Sub DressUp(ByVal obj As MenuStrip)
            obj.BackColor = oDark.BackColor1
            obj.ForeColor = oDark.ForeColor
        End Sub

        Public Sub DressUp(ByVal obj As Label)
            obj.BackColor = Color.Transparent
            obj.ForeColor = oDark.ForeColor
        End Sub

        Public Sub DressUp(ByVal obj As Lybra.Forms.Controls.GradientPanelXP)
            obj.BackColor1 = oDark.BackColor1
            obj.BackColor2 = oDark.BackColor2
            ChangeColorLabel(obj)

        End Sub

        Public Sub DressUp(ByVal obj As Lybra.Forms.Controls.HoverButtonBand)
            obj.BackColor1 = oDark.BackColor1
            obj.BackColor2 = oDark.BackColor2
        End Sub

        Private Sub ChangeColorLabel(ByVal C As Control)

            Dim Ctrl As Control 'Declare generic control object

            For Each Ctrl In C.Controls
                Select Case TypeName(Ctrl)
                    Case "Label" 'Do the following code if control is a Text Box
                        Ctrl.ForeColor = oDark.ForeColor
                    Case Else
                        If Ctrl.Controls.Count > 0 Then 'Check for container control
                            ChangeColorLabel(Ctrl) 'Recursively call sub for controls in container
                        End If
                End Select
            Next Ctrl
        End Sub

        

    End Class

    Public Class clsLightDress
        Private oDark As New clsThemes.LightBlueThemes

        Public Sub DressUp(ByVal obj As MenuStrip)
            obj.BackColor = oDark.BackColor1
            obj.ForeColor = oDark.ForeColor
        End Sub

        Public Sub DressUp(ByVal obj As Lybra.Forms.Controls.GradientPanelXP)
            obj.BackColor1 = oDark.BackColor1
            obj.BackColor2 = oDark.BackColor2
        End Sub

        Public Sub DressUp(ByVal obj As Lybra.Forms.Controls.HoverButtonBand)
            obj.BackColor1 = oDark.BackColor1
            obj.BackColor2 = oDark.BackColor2
        End Sub

        Public Sub PaintForm(ByVal e As System.Windows.Forms.PaintEventArgs, ByVal frm As Form)
            Dim y As Integer = 0
            Dim x As Integer = 0
            Dim wid As Integer = frm.Width
            Dim hgt As Integer = frm.Height
            ' Make a rectangle that shades from black to white.
            Dim black_white_brush As New Drawing2D.LinearGradientBrush(New Point(x, y), New Point(x + wid, y), _
            oDark.BackColor2, oDark.BackColor1)
            e.Graphics.FillRectangle(black_white_brush, _
            x, y, wid, hgt)
        End Sub

    End Class
End Class
