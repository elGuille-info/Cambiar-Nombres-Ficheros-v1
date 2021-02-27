<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.grbGrupo1 = New System.Windows.Forms.GroupBox()
        Me.txtExtensiones1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.chkProces1 = New System.Windows.Forms.CheckBox()
        Me.btnExaminar1 = New System.Windows.Forms.Button()
        Me.txtDir1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.btnProcesar = New System.Windows.Forms.Button()
        Me.bgwProc1 = New System.ComponentModel.BackgroundWorker()
        Me.bgwProc2 = New System.ComponentModel.BackgroundWorker()
        Me.bgwProc3 = New System.ComponentModel.BackgroundWorker()
        Me.txtTexto1 = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.chkProces2 = New System.Windows.Forms.CheckBox()
        Me.btnExaminar2 = New System.Windows.Forms.Button()
        Me.chkProces3 = New System.Windows.Forms.CheckBox()
        Me.btnExaminar3 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.btnExaminar = New System.Windows.Forms.Button()
        Me.optAñadirPrincipio = New System.Windows.Forms.RadioButton()
        Me.optCambiar = New System.Windows.Forms.RadioButton()
        Me.optAñadirFinal = New System.Windows.Forms.RadioButton()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.chkNoDuplicar = New System.Windows.Forms.CheckBox()
        Me.optQuitarFinal = New System.Windows.Forms.RadioButton()
        Me.optQuitarPrincipio = New System.Windows.Forms.RadioButton()
        Me.grbGrupo2 = New System.Windows.Forms.GroupBox()
        Me.txtExtensiones2 = New System.Windows.Forms.TextBox()
        Me.txtDir2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.grbGrupo3 = New System.Windows.Forms.GroupBox()
        Me.txtExtensiones3 = New System.Windows.Forms.TextBox()
        Me.txtDir3 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.grbGrupo0 = New System.Windows.Forms.GroupBox()
        Me.txtExtensiones = New System.Windows.Forms.TextBox()
        Me.txtDir = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtTexto2 = New System.Windows.Forms.TextBox()
        Me.bgwProc = New System.ComponentModel.BackgroundWorker()
        Me.LabelStatus = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.grbGrupo1.SuspendLayout()
        Me.grbGrupo2.SuspendLayout()
        Me.grbGrupo3.SuspendLayout()
        Me.grbGrupo0.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'grbGrupo1
        '
        Me.grbGrupo1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grbGrupo1.Controls.Add(Me.txtExtensiones1)
        Me.grbGrupo1.Controls.Add(Me.Label4)
        Me.grbGrupo1.Controls.Add(Me.chkProces1)
        Me.grbGrupo1.Controls.Add(Me.btnExaminar1)
        Me.grbGrupo1.Controls.Add(Me.txtDir1)
        Me.grbGrupo1.Controls.Add(Me.Label1)
        Me.grbGrupo1.Location = New System.Drawing.Point(12, 105)
        Me.grbGrupo1.Margin = New System.Windows.Forms.Padding(3, 6, 3, 3)
        Me.grbGrupo1.Name = "grbGrupo1"
        Me.grbGrupo1.Size = New System.Drawing.Size(589, 81)
        Me.grbGrupo1.TabIndex = 1
        Me.grbGrupo1.TabStop = False
        '
        'txtExtensiones1
        '
        Me.txtExtensiones1.Location = New System.Drawing.Point(126, 48)
        Me.txtExtensiones1.Name = "txtExtensiones1"
        Me.txtExtensiones1.Size = New System.Drawing.Size(142, 20)
        Me.txtExtensiones1.TabIndex = 5
        Me.txtExtensiones1.Text = "*.mp3"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(12, 51)
        Me.Label4.Margin = New System.Windows.Forms.Padding(3)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 20)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Filtro:"
        Me.ToolTip1.SetToolTip(Me.Label4, "Filtro a usar, con comodines * o ?")
        '
        'chkProces1
        '
        Me.chkProces1.AutoSize = True
        Me.chkProces1.Location = New System.Drawing.Point(6, -1)
        Me.chkProces1.Name = "chkProces1"
        Me.chkProces1.Size = New System.Drawing.Size(218, 17)
        Me.chkProces1.TabIndex = 0
        Me.chkProces1.Text = "Incluir también este directorio al procesar"
        Me.ToolTip1.SetToolTip(Me.chkProces1, " Marca esta opción para incluir los ficheros de ese directorio al Procesar ")
        Me.chkProces1.UseVisualStyleBackColor = True
        '
        'btnExaminar1
        '
        Me.btnExaminar1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExaminar1.Location = New System.Drawing.Point(557, 20)
        Me.btnExaminar1.Name = "btnExaminar1"
        Me.btnExaminar1.Size = New System.Drawing.Size(26, 23)
        Me.btnExaminar1.TabIndex = 3
        Me.btnExaminar1.Text = "..."
        Me.ToolTip1.SetToolTip(Me.btnExaminar1, " Selecciona el directorio con los mp3 a procesar ")
        Me.btnExaminar1.UseVisualStyleBackColor = True
        '
        'txtDir1
        '
        Me.txtDir1.AllowDrop = True
        Me.txtDir1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDir1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtDir1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem
        Me.txtDir1.Location = New System.Drawing.Point(126, 22)
        Me.txtDir1.Name = "txtDir1"
        Me.txtDir1.Size = New System.Drawing.Size(425, 20)
        Me.txtDir1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(12, 25)
        Me.Label1.Margin = New System.Windows.Forms.Padding(3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Directorio:"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProgressBar1.Location = New System.Drawing.Point(12, 562)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(508, 19)
        Me.ProgressBar1.TabIndex = 5
        '
        'btnProcesar
        '
        Me.btnProcesar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnProcesar.Location = New System.Drawing.Point(526, 587)
        Me.btnProcesar.Name = "btnProcesar"
        Me.btnProcesar.Size = New System.Drawing.Size(75, 23)
        Me.btnProcesar.TabIndex = 7
        Me.btnProcesar.Text = "Procesar"
        Me.ToolTip1.SetToolTip(Me.btnProcesar, " Procesar los ficheros de los directorios indicados ")
        Me.btnProcesar.UseVisualStyleBackColor = True
        '
        'bgwProc1
        '
        '
        'bgwProc2
        '
        '
        'bgwProc3
        '
        '
        'txtTexto1
        '
        Me.txtTexto1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTexto1.Location = New System.Drawing.Point(126, 22)
        Me.txtTexto1.Name = "txtTexto1"
        Me.txtTexto1.Size = New System.Drawing.Size(425, 20)
        Me.txtTexto1.TabIndex = 1
        '
        'chkProces2
        '
        Me.chkProces2.AutoSize = True
        Me.chkProces2.Location = New System.Drawing.Point(6, -1)
        Me.chkProces2.Name = "chkProces2"
        Me.chkProces2.Size = New System.Drawing.Size(218, 17)
        Me.chkProces2.TabIndex = 0
        Me.chkProces2.Text = "Incluir también este directorio al procesar"
        Me.ToolTip1.SetToolTip(Me.chkProces2, " Marca esta opción para incluir los ficheros de ese directorio al Procesar ")
        Me.chkProces2.UseVisualStyleBackColor = True
        '
        'btnExaminar2
        '
        Me.btnExaminar2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExaminar2.Location = New System.Drawing.Point(557, 20)
        Me.btnExaminar2.Name = "btnExaminar2"
        Me.btnExaminar2.Size = New System.Drawing.Size(26, 23)
        Me.btnExaminar2.TabIndex = 3
        Me.btnExaminar2.Text = "..."
        Me.ToolTip1.SetToolTip(Me.btnExaminar2, " Selecciona el directorio con los mp3 a procesar ")
        Me.btnExaminar2.UseVisualStyleBackColor = True
        '
        'chkProces3
        '
        Me.chkProces3.AutoSize = True
        Me.chkProces3.Location = New System.Drawing.Point(6, -1)
        Me.chkProces3.Name = "chkProces3"
        Me.chkProces3.Size = New System.Drawing.Size(218, 17)
        Me.chkProces3.TabIndex = 0
        Me.chkProces3.Text = "Incluir también este directorio al procesar"
        Me.ToolTip1.SetToolTip(Me.chkProces3, " Marca esta opción para incluir los ficheros de ese directorio al Procesar ")
        Me.chkProces3.UseVisualStyleBackColor = True
        '
        'btnExaminar3
        '
        Me.btnExaminar3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExaminar3.Location = New System.Drawing.Point(557, 20)
        Me.btnExaminar3.Name = "btnExaminar3"
        Me.btnExaminar3.Size = New System.Drawing.Size(26, 23)
        Me.btnExaminar3.TabIndex = 3
        Me.btnExaminar3.Text = "..."
        Me.ToolTip1.SetToolTip(Me.btnExaminar3, " Selecciona el directorio con los mp3 a procesar ")
        Me.btnExaminar3.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(12, 51)
        Me.Label5.Margin = New System.Windows.Forms.Padding(3)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Filtro:"
        Me.ToolTip1.SetToolTip(Me.Label5, "Filtro a usar, con comodines * o ?")
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(12, 51)
        Me.Label6.Margin = New System.Windows.Forms.Padding(3)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(106, 20)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Filtro:"
        Me.ToolTip1.SetToolTip(Me.Label6, "Filtro a usar, con comodines * o ?")
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(12, 51)
        Me.Label7.Margin = New System.Windows.Forms.Padding(3)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(106, 20)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Filtro:"
        Me.ToolTip1.SetToolTip(Me.Label7, "Filtro a usar, con comodines * o ?")
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoCheck = False
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Checked = True
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.Location = New System.Drawing.Point(6, -1)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(194, 17)
        Me.CheckBox1.TabIndex = 0
        Me.CheckBox1.TabStop = False
        Me.CheckBox1.Text = "Este directorio SIEMPRE se incluirá"
        Me.ToolTip1.SetToolTip(Me.CheckBox1, " Marca esta opción para incluir los ficheros de ese directorio al Procesar ")
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'btnExaminar
        '
        Me.btnExaminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExaminar.Location = New System.Drawing.Point(557, 20)
        Me.btnExaminar.Name = "btnExaminar"
        Me.btnExaminar.Size = New System.Drawing.Size(26, 23)
        Me.btnExaminar.TabIndex = 3
        Me.btnExaminar.Text = "..."
        Me.ToolTip1.SetToolTip(Me.btnExaminar, " Selecciona el directorio con los mp3 a procesar ")
        Me.btnExaminar.UseVisualStyleBackColor = True
        '
        'optAñadirPrincipio
        '
        Me.optAñadirPrincipio.AutoSize = True
        Me.optAñadirPrincipio.Location = New System.Drawing.Point(126, 74)
        Me.optAñadirPrincipio.Name = "optAñadirPrincipio"
        Me.optAñadirPrincipio.Size = New System.Drawing.Size(108, 17)
        Me.optAñadirPrincipio.TabIndex = 4
        Me.optAñadirPrincipio.Text = "Añadir al principio"
        Me.ToolTip1.SetToolTip(Me.optAñadirPrincipio, "Añadir al principio del nombre del fichero el texto indicado en 'Texto 1'")
        Me.optAñadirPrincipio.UseVisualStyleBackColor = True
        '
        'optCambiar
        '
        Me.optCambiar.AutoSize = True
        Me.optCambiar.Checked = True
        Me.optCambiar.Location = New System.Drawing.Point(359, 120)
        Me.optCambiar.Name = "optCambiar"
        Me.optCambiar.Size = New System.Drawing.Size(155, 17)
        Me.optCambiar.TabIndex = 9
        Me.optCambiar.TabStop = True
        Me.optCambiar.Text = "Cambiar 'Text 1' por 'Text 2'"
        Me.ToolTip1.SetToolTip(Me.optCambiar, "Si el contenido del primer cuadro de texto (Text 1) está en el nombre del fichero" &
        ", " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "se cambiará por el indicado en el segundo cuadro de texto  (Texto 2)." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Si no" &
        " está, no se hará nada.")
        Me.optCambiar.UseVisualStyleBackColor = True
        '
        'optAñadirFinal
        '
        Me.optAñadirFinal.AutoSize = True
        Me.optAñadirFinal.Location = New System.Drawing.Point(126, 97)
        Me.optAñadirFinal.Name = "optAñadirFinal"
        Me.optAñadirFinal.Size = New System.Drawing.Size(88, 17)
        Me.optAñadirFinal.TabIndex = 5
        Me.optAñadirFinal.Text = "Añadir al final"
        Me.ToolTip1.SetToolTip(Me.optAñadirFinal, "Añadir al final del nombre del fichero el texto indicado en 'Texto 1'")
        Me.optAñadirFinal.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(12, 51)
        Me.Label10.Margin = New System.Windows.Forms.Padding(3)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(106, 20)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Texto 2 (poner):"
        Me.ToolTip1.SetToolTip(Me.Label10, "Al final se puede indicar un espacio, " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "si se indica más de un espacio, se dejará" &
        " solo uno." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(12, 25)
        Me.Label9.Margin = New System.Windows.Forms.Padding(3)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(106, 20)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Texto 1:"
        Me.ToolTip1.SetToolTip(Me.Label9, "Al final se puede indicar un espacio, " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "si se indica más de un espacio, se dejará" &
        " solo uno.")
        '
        'chkNoDuplicar
        '
        Me.chkNoDuplicar.AutoSize = True
        Me.chkNoDuplicar.Checked = True
        Me.chkNoDuplicar.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkNoDuplicar.Location = New System.Drawing.Point(359, 75)
        Me.chkNoDuplicar.Name = "chkNoDuplicar"
        Me.chkNoDuplicar.Size = New System.Drawing.Size(156, 17)
        Me.chkNoDuplicar.TabIndex = 8
        Me.chkNoDuplicar.Text = "No añadir si ya está el texto"
        Me.ToolTip1.SetToolTip(Me.chkNoDuplicar, resources.GetString("chkNoDuplicar.ToolTip"))
        Me.chkNoDuplicar.UseVisualStyleBackColor = True
        '
        'optQuitarFinal
        '
        Me.optQuitarFinal.AutoSize = True
        Me.optQuitarFinal.Location = New System.Drawing.Point(126, 143)
        Me.optQuitarFinal.Name = "optQuitarFinal"
        Me.optQuitarFinal.Size = New System.Drawing.Size(92, 17)
        Me.optQuitarFinal.TabIndex = 7
        Me.optQuitarFinal.Text = "Quitar del final"
        Me.ToolTip1.SetToolTip(Me.optQuitarFinal, "Quitar del final del nombre del fichero el texto indicado en 'Texto 1'")
        Me.optQuitarFinal.UseVisualStyleBackColor = True
        '
        'optQuitarPrincipio
        '
        Me.optQuitarPrincipio.AutoSize = True
        Me.optQuitarPrincipio.Location = New System.Drawing.Point(126, 120)
        Me.optQuitarPrincipio.Name = "optQuitarPrincipio"
        Me.optQuitarPrincipio.Size = New System.Drawing.Size(112, 17)
        Me.optQuitarPrincipio.TabIndex = 6
        Me.optQuitarPrincipio.Text = "Quitar del principio"
        Me.ToolTip1.SetToolTip(Me.optQuitarPrincipio, "Quitar del principio del nombre del fichero el texto indicado en 'Texto 1'")
        Me.optQuitarPrincipio.UseVisualStyleBackColor = True
        '
        'grbGrupo2
        '
        Me.grbGrupo2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grbGrupo2.Controls.Add(Me.txtExtensiones2)
        Me.grbGrupo2.Controls.Add(Me.Label5)
        Me.grbGrupo2.Controls.Add(Me.chkProces2)
        Me.grbGrupo2.Controls.Add(Me.btnExaminar2)
        Me.grbGrupo2.Controls.Add(Me.txtDir2)
        Me.grbGrupo2.Controls.Add(Me.Label2)
        Me.grbGrupo2.Location = New System.Drawing.Point(12, 195)
        Me.grbGrupo2.Margin = New System.Windows.Forms.Padding(3, 6, 3, 3)
        Me.grbGrupo2.Name = "grbGrupo2"
        Me.grbGrupo2.Size = New System.Drawing.Size(589, 81)
        Me.grbGrupo2.TabIndex = 2
        Me.grbGrupo2.TabStop = False
        '
        'txtExtensiones2
        '
        Me.txtExtensiones2.Location = New System.Drawing.Point(126, 48)
        Me.txtExtensiones2.Name = "txtExtensiones2"
        Me.txtExtensiones2.Size = New System.Drawing.Size(142, 20)
        Me.txtExtensiones2.TabIndex = 5
        Me.txtExtensiones2.Text = "*.txt"
        '
        'txtDir2
        '
        Me.txtDir2.AllowDrop = True
        Me.txtDir2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDir2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtDir2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem
        Me.txtDir2.Location = New System.Drawing.Point(126, 22)
        Me.txtDir2.Name = "txtDir2"
        Me.txtDir2.Size = New System.Drawing.Size(425, 20)
        Me.txtDir2.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(12, 25)
        Me.Label2.Margin = New System.Windows.Forms.Padding(3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Directorio:"
        '
        'grbGrupo3
        '
        Me.grbGrupo3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grbGrupo3.Controls.Add(Me.txtExtensiones3)
        Me.grbGrupo3.Controls.Add(Me.Label6)
        Me.grbGrupo3.Controls.Add(Me.chkProces3)
        Me.grbGrupo3.Controls.Add(Me.btnExaminar3)
        Me.grbGrupo3.Controls.Add(Me.txtDir3)
        Me.grbGrupo3.Controls.Add(Me.Label3)
        Me.grbGrupo3.Location = New System.Drawing.Point(12, 285)
        Me.grbGrupo3.Margin = New System.Windows.Forms.Padding(3, 6, 3, 3)
        Me.grbGrupo3.Name = "grbGrupo3"
        Me.grbGrupo3.Size = New System.Drawing.Size(585, 81)
        Me.grbGrupo3.TabIndex = 3
        Me.grbGrupo3.TabStop = False
        '
        'txtExtensiones3
        '
        Me.txtExtensiones3.Location = New System.Drawing.Point(126, 48)
        Me.txtExtensiones3.Name = "txtExtensiones3"
        Me.txtExtensiones3.Size = New System.Drawing.Size(142, 20)
        Me.txtExtensiones3.TabIndex = 5
        Me.txtExtensiones3.Text = "*.md"
        '
        'txtDir3
        '
        Me.txtDir3.AllowDrop = True
        Me.txtDir3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDir3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtDir3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem
        Me.txtDir3.Location = New System.Drawing.Point(126, 22)
        Me.txtDir3.Name = "txtDir3"
        Me.txtDir3.Size = New System.Drawing.Size(425, 20)
        Me.txtDir3.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(12, 25)
        Me.Label3.Margin = New System.Windows.Forms.Padding(3)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 20)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Directorio:"
        '
        'grbGrupo0
        '
        Me.grbGrupo0.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grbGrupo0.Controls.Add(Me.txtExtensiones)
        Me.grbGrupo0.Controls.Add(Me.Label7)
        Me.grbGrupo0.Controls.Add(Me.CheckBox1)
        Me.grbGrupo0.Controls.Add(Me.btnExaminar)
        Me.grbGrupo0.Controls.Add(Me.txtDir)
        Me.grbGrupo0.Controls.Add(Me.Label8)
        Me.grbGrupo0.Location = New System.Drawing.Point(12, 15)
        Me.grbGrupo0.Margin = New System.Windows.Forms.Padding(3, 6, 3, 3)
        Me.grbGrupo0.Name = "grbGrupo0"
        Me.grbGrupo0.Size = New System.Drawing.Size(589, 81)
        Me.grbGrupo0.TabIndex = 0
        Me.grbGrupo0.TabStop = False
        '
        'txtExtensiones
        '
        Me.txtExtensiones.Location = New System.Drawing.Point(126, 48)
        Me.txtExtensiones.Name = "txtExtensiones"
        Me.txtExtensiones.Size = New System.Drawing.Size(142, 20)
        Me.txtExtensiones.TabIndex = 5
        Me.txtExtensiones.Text = "*.txt; *.md"
        '
        'txtDir
        '
        Me.txtDir.AllowDrop = True
        Me.txtDir.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDir.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtDir.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem
        Me.txtDir.Location = New System.Drawing.Point(126, 22)
        Me.txtDir.Name = "txtDir"
        Me.txtDir.Size = New System.Drawing.Size(425, 20)
        Me.txtDir.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(12, 25)
        Me.Label8.Margin = New System.Windows.Forms.Padding(3)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(109, 20)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Directorio:"
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.Controls.Add(Me.optQuitarFinal)
        Me.GroupBox4.Controls.Add(Me.optQuitarPrincipio)
        Me.GroupBox4.Controls.Add(Me.chkNoDuplicar)
        Me.GroupBox4.Controls.Add(Me.optAñadirFinal)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.txtTexto2)
        Me.GroupBox4.Controls.Add(Me.optCambiar)
        Me.GroupBox4.Controls.Add(Me.optAñadirPrincipio)
        Me.GroupBox4.Controls.Add(Me.txtTexto1)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 372)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(589, 172)
        Me.GroupBox4.TabIndex = 4
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Texto a poner o cambiar"
        '
        'txtTexto2
        '
        Me.txtTexto2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTexto2.Location = New System.Drawing.Point(126, 48)
        Me.txtTexto2.Name = "txtTexto2"
        Me.txtTexto2.Size = New System.Drawing.Size(425, 20)
        Me.txtTexto2.TabIndex = 3
        '
        'bgwProc
        '
        '
        'LabelStatus
        '
        Me.LabelStatus.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelStatus.BackColor = System.Drawing.SystemColors.Info
        Me.LabelStatus.Location = New System.Drawing.Point(12, 587)
        Me.LabelStatus.Margin = New System.Windows.Forms.Padding(3)
        Me.LabelStatus.Name = "LabelStatus"
        Me.LabelStatus.Size = New System.Drawing.Size(508, 23)
        Me.LabelStatus.TabIndex = 6
        Me.LabelStatus.Text = "Label11"
        Me.LabelStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Timer1
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(613, 622)
        Me.Controls.Add(Me.LabelStatus)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.grbGrupo0)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.grbGrupo3)
        Me.Controls.Add(Me.btnProcesar)
        Me.Controls.Add(Me.grbGrupo2)
        Me.Controls.Add(Me.grbGrupo1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(560, 660)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Cambiar los nombres de los ficheros"
        Me.grbGrupo1.ResumeLayout(False)
        Me.grbGrupo1.PerformLayout()
        Me.grbGrupo2.ResumeLayout(False)
        Me.grbGrupo2.PerformLayout()
        Me.grbGrupo3.ResumeLayout(False)
        Me.grbGrupo3.PerformLayout()
        Me.grbGrupo0.ResumeLayout(False)
        Me.grbGrupo0.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grbGrupo1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDir1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents chkProces1 As System.Windows.Forms.CheckBox
    Friend WithEvents btnExaminar1 As System.Windows.Forms.Button
    Friend WithEvents btnProcesar As System.Windows.Forms.Button
    Friend WithEvents bgwProc1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents bgwProc2 As System.ComponentModel.BackgroundWorker
    Friend WithEvents bgwProc3 As System.ComponentModel.BackgroundWorker
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents txtTexto1 As System.Windows.Forms.TextBox
    Friend WithEvents grbGrupo2 As GroupBox
    Friend WithEvents chkProces2 As CheckBox
    Friend WithEvents btnExaminar2 As Button
    Friend WithEvents txtDir2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents grbGrupo3 As GroupBox
    Friend WithEvents chkProces3 As CheckBox
    Friend WithEvents btnExaminar3 As Button
    Friend WithEvents txtDir3 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtExtensiones1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtExtensiones2 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtExtensiones3 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents grbGrupo0 As GroupBox
    Friend WithEvents txtExtensiones As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents btnExaminar As Button
    Friend WithEvents txtDir As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents optCambiar As RadioButton
    Friend WithEvents optAñadirPrincipio As RadioButton
    Friend WithEvents txtTexto2 As TextBox
    Friend WithEvents optAñadirFinal As RadioButton
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents bgwProc As System.ComponentModel.BackgroundWorker
    Friend WithEvents LabelStatus As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents chkNoDuplicar As CheckBox
    Friend WithEvents optQuitarFinal As RadioButton
    Friend WithEvents optQuitarPrincipio As RadioButton
End Class
