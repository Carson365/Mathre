' Sources:
' The AddMenuItemHandlers Sub (and some supporting code in the FormLoad sub) is sourced from https://social.msdn.microsoft.com/Forums/vstudio/2ac347d5-4946-4143-8d54-e136d5508f64
' Flag icons are sourced from the free icon set at https://www.iconfinder.com/iconsets/flags-37
'
Public Class FrmMathre
    '
    Public Shared StartingValue As String ' Define a global variable to store the starting value of the lblHelloWorld Label
    Public Shared SystemColor As String
    Public Shared colRemovedTabs As New TabControl()
    Public Shared tabSecretStorage As TabPage
    '
    Public Sub FormLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        tabSecretStorage = tabMathre.TabPages(3)
        colRemovedTabs.Controls.Add(tabSecretStorage)
        tabMathre.Controls.Remove(tabSecretStorage)
        mnuBaseLayer.Renderer = New ToolStripProfessionalRenderer(New MenuColorTable())
        Dim ColorKey As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("Software\Microsoft\Windows\DWM")
        SystemColor = ColorKey.GetValue("AccentColor") : ColorKey.Close()
        Me.KeyPreview = True ' Ensure key inputs on the form are being tracked
        StartingValue = grpHelloWorld.Controls.OfType(Of RadioButton)().FirstOrDefault(Function(radioButton) radioButton.Checked).Name
        For Each ToolStripMenuItem In mnuBaseLayer.Items ' Recursion point
            AddMenuItemHandlers(ToolStripMenuItem) ' Call on the next function to run
            CType(ToolStripMenuItem.DropDown, ToolStripDropDownMenu).ShowImageMargin = False
        Next ' Begin recursion
    End Sub
    Public Sub SystemColorChecker(sender As Object, e As EventArgs)
        Dim ColorKey As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("Software\Microsoft\Windows\DWM")
        SystemColor = ColorKey.GetValue("AccentColor") : ColorKey.Close()
    End Sub
    '
    Private Sub AddMenuItemHandlers(ToolStripMenuItem As ToolStripMenuItem) ' ToolStripMenuItem.DropDown.Keydown doesn't work unless you add an alias (ToolStripMenuItem) for ToolStripMenuItem.
        For Each ToolStripItem In ToolStripMenuItem.DropDownItems ' Recursion point
            If TypeOf ToolStripItem Is ToolStripMenuItem Then ' For the menu items that don't have key input tracking -
                AddHandler ToolStripMenuItem.DropDown.KeyDown, AddressOf KeyboardShortcuts ' - add a function to track key inputs (under the name of the main form's, for simplicity.
                AddMenuItemHandlers(CType(ToolStripItem, ToolStripMenuItem)) ' Call back to the above sub to repeat this code on the next menu item.
                CType(ToolStripItem.DropDown, ToolStripDropDownMenu).ShowImageMargin = False
            End If
        Next ' Begin recursion
    End Sub
    '
    Private Sub KeyboardShortcuts(sender As Object, e As KeyEventArgs) Handles Me.KeyDown ' Event handler for keypresses made within the form (which now includes keypresses from the menu items)
        If e.Control And e.KeyCode = Keys.S Then ' Add Control+S shortcut
            If tabMathre.TabPages.Contains(tabSecretStorage) Then
                colRemovedTabs.Controls.Add(tabSecretStorage)
                tabMathre.Controls.Remove(tabSecretStorage)
            Else
                tabMathre.Controls.Add(colRemovedTabs.TabPages(0))
                colRemovedTabs.Controls.Remove(tabSecretStorage)
                tabMathre.SelectedTab = tabSecretStorage
            End If
        End If
        If e.Control And e.KeyCode = Keys.R And mnuSecret.Enabled Then ' Add Control+R shortcut, dependent on the secret menu being enabled
            Call Buttons(mnuRandomify, Nothing) ' Use shortcut to quickly run the randomize function
        End If
        '
        If e.Control And e.Shift And e.KeyCode = Keys.R Then ' Add Control+Shift+R shortcut
            Call Buttons(mnuReset, Nothing) ' Use shortcut to reset the lblHelloWorld to its stored value by pressing the reset button.
        End If
        If txtSecretPassword.ContainsFocus And e.KeyCode = Keys.Enter Then
            Call SecretHandler(txtSecretPassword, Nothing)
        End If
    End Sub
    Private Sub SecretHandler(sender As Object, e As EventArgs) Handles btnSecretDisable.Click, btnSecretEnable.Click, btnSecretEnable.EnabledChanged ' Event handler for keypresses made within the form (which now includes keypresses from the menu items)
        If sender Is txtSecretPassword Then
            If txtSecretPassword.Text = "12345" Then
                btnSecretEnable.Enabled = True
                btnSecretDisable.Enabled = True
            Else
                btnSecretEnable.Enabled = False
                btnSecretDisable.Enabled = False
            End If
            If btnSecretEnable.Enabled = False Then
                mnuSecret.Enabled = False
            End If
        End If
        txtSecretPassword.Text = ""
        If sender Is btnSecretEnable Then
            mnuSecret.Enabled = True
            btnSecretEnable.Checked = True
        End If
        If sender Is btnSecretDisable Then
            mnuSecret.Enabled = False
            btnSecretDisable.Checked = True
        End If
        '
    End Sub
    '
    Private Sub Buttons(sender As Object, e As EventArgs) Handles mnuEnglish.Click, mnuFrench.Click, mnuGerman.Click, mnuReset.Click, mnuRandomify.Click, mnuExit.Click ' Event Handler for a press of the French button
        If sender Is btnEnglish Or sender Is mnuEnglish Then
            btnEnglish.Checked = True
            lblHelloWorld.Text = "Hello World" ' Sets lblHelloWorld to English
        ElseIf sender Is btnFrench Or sender Is mnuFrench Then
            btnFrench.Checked = True
            lblHelloWorld.Text = "Bonjour le Monde" ' Sets lblHelloWorld to French
        ElseIf sender Is btnGerman Or sender Is mnuGerman Then
            btnGerman.Checked = True
            lblHelloWorld.Text = "Hallo Welt" ' Sets lblHelloWorld to German
        ElseIf sender Is btnReset Or sender Is mnuReset Then
            Call Buttons(grpHelloWorld.Controls(StartingValue.ToString), Nothing) ' Call back to the Buttons Sub with the pre-stored initially checked radio button substituted as sender in order to reset both the buttons and the label to their initial value.
        ElseIf sender Is mnuRandomify Then
            lblHelloWorld.Text = CLng(((5 * ((0.5 + Rnd()) ^ 2)) + 55) ^ (2 + (5 * Rnd()))) ' Uses a random value between 0 and 1 with modification to 'randomify' the lblHelloWorld value.
        ElseIf sender Is mnuExit Then
            Me.Close()
        End If
    End Sub

    Private Class MenuColorTable
        Inherits ProfessionalColorTable
        Public Overrides ReadOnly Property MenuItemBorder As Color
            Get
                Return ColorTranslator.FromWin32(SystemColor)
            End Get
        End Property
        Public Overrides ReadOnly Property MenuItemSelected As Color
            Get
                Return ColorTranslator.FromWin32(SystemColor)
            End Get
        End Property
        Public Overrides ReadOnly Property MenuBorder As Color
            Get
                Return ColorTranslator.FromWin32(SystemColor)
            End Get
        End Property
        '
    End Class

    Private Sub btnSecretDisable_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub KeyboardShortcuts(sender As Object, e As EventArgs)

    End Sub
    '
    '
    '
    '
    '
    '
    '
    '
    '
    '
    '
    '
    '
    '
    '
    '
    '
    '
    '
    '
    '
    '
    '
    '
    '
End Class



Class Watcher
    Private Function Watcher()
        Do While Second(DateTime.Now) Mod 2 = 0
            Console.WriteLine(Second(DateTime.Now) Mod 2)
            'Dim ColorKey As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("Software\Microsoft\Windows\DWM")
            'SystemColor = ColorKey.GetValue("AccentColor") : ColorKey.Close()
        Loop
    End Function
End Class