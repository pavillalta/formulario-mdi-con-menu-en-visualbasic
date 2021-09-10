Imports System.Runtime.InteropServices
Public Class Form1
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Me.Close()
    End Sub

    Private Sub BtnMaximizar_Click(sender As Object, e As EventArgs) Handles BtnMaximizar.Click
        BtnMaximizar.Visible = False
        BtnRestaurar.Visible = True
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub BtnRestaurar_Click(sender As Object, e As EventArgs) Handles BtnRestaurar.Click
        BtnRestaurar.Visible = False
        BtnMaximizar.Visible = True
        Me.WindowState = FormWindowState.Normal




    End Sub

    Private Sub BtnMinimizar_Click(sender As Object, e As EventArgs) Handles BtnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub PanelPrincipal_Paint(sender As Object, e As PaintEventArgs) Handles PanelPrincipal.Paint

    End Sub

    Private Sub PanelPrincipal_MouseMove(sender As Object, e As MouseEventArgs) Handles PanelPrincipal.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub TmOcultar_Tick(sender As Object, e As EventArgs) Handles TmOcultar.Tick
        If Panelmenu.Width <= 60 Then
            Me.TmOcultar.Enabled = False
        Else
            Me.Panelmenu.Width = Panelmenu.Width - 20
        End If
    End Sub

    Private Sub TmMostrar_Tick(sender As Object, e As EventArgs) Handles TmMostrar.Tick
        If Panelmenu.Width >= 220 Then
            Me.TmMostrar.Enabled = False
        Else
            Me.Panelmenu.Width = Panelmenu.Width + 20
        End If
    End Sub

    Private Sub Btnmenu_Click(sender As Object, e As EventArgs) Handles Btnmenu.Click
        If Panelmenu.Width = 220 Then
            TmOcultar.Enabled = True
        ElseIf Panelmenu.Width = 60 Then
            TmMostrar.Enabled = True
        End If
    End Sub

    Private Sub AbrirFormEnPanel(ByVal Formhijo As Object)

        If Me.PanelContenedor.Controls.Count > 0 Then
            Me.PanelContenedor.Controls.RemoveAt(0)
        End If
        Dim fh As Form = TryCast(Formhijo, Form)
        fh.TopLevel = False
        fh.FormBorderStyle = FormBorderStyle.None
        fh.Dock = DockStyle.Fill
        Me.PanelContenedor.Controls.Add(fh)
        Me.PanelContenedor.Tag = fh
        fh.Show()

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles BtnProducto.Click
        AbrirFormEnPanel(New Producto)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnClientes.Click
        AbrirFormEnPanel(New Clientes)
    End Sub

    Private Sub BtnVentas_Click(sender As Object, e As EventArgs) Handles BtnVentas.Click
        AbrirFormEnPanel(New Ventas)
    End Sub
    'Raul Geovanni Rivera lovo'
    Private Sub BtnCompras_Click(sender As Object, e As EventArgs) Handles BtnCompras.Click
        AbrirFormEnPanel(New Compras)


    End Sub
End Class
