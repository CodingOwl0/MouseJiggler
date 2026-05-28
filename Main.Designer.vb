<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.N_Main_Interval = New System.Windows.Forms.NumericUpDown()
        Me.Worker = New System.ComponentModel.BackgroundWorker()
        Me.B_Main_Start = New System.Windows.Forms.Button()
        Me.B_Main_Stop = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.N_Main_1 = New System.Windows.Forms.NumericUpDown()
        Me.N_Main_1b = New System.Windows.Forms.NumericUpDown()
        Me.N_Main_2 = New System.Windows.Forms.NumericUpDown()
        Me.N_Main_2b = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.C_Main_MakeClicks = New System.Windows.Forms.CheckBox()
        Me.C_RandomPosition = New System.Windows.Forms.CheckBox()
        CType(Me.N_Main_Interval, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.N_Main_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.N_Main_1b, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.N_Main_2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.N_Main_2b, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'N_Main_Interval
        '
        Me.N_Main_Interval.Location = New System.Drawing.Point(68, 15)
        Me.N_Main_Interval.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.N_Main_Interval.Minimum = New Decimal(New Integer() {5000, 0, 0, 0})
        Me.N_Main_Interval.Name = "N_Main_Interval"
        Me.N_Main_Interval.Size = New System.Drawing.Size(127, 20)
        Me.N_Main_Interval.TabIndex = 0
        Me.N_Main_Interval.Value = New Decimal(New Integer() {5000, 0, 0, 0})
        '
        'Worker
        '
        Me.Worker.WorkerSupportsCancellation = True
        '
        'B_Main_Start
        '
        Me.B_Main_Start.Location = New System.Drawing.Point(215, 12)
        Me.B_Main_Start.Name = "B_Main_Start"
        Me.B_Main_Start.Size = New System.Drawing.Size(97, 23)
        Me.B_Main_Start.TabIndex = 1
        Me.B_Main_Start.Text = "Start jiggle"
        Me.B_Main_Start.UseVisualStyleBackColor = True
        '
        'B_Main_Stop
        '
        Me.B_Main_Stop.Enabled = False
        Me.B_Main_Stop.Location = New System.Drawing.Point(215, 41)
        Me.B_Main_Stop.Name = "B_Main_Stop"
        Me.B_Main_Stop.Size = New System.Drawing.Size(97, 23)
        Me.B_Main_Stop.TabIndex = 2
        Me.B_Main_Stop.Text = "Stop"
        Me.B_Main_Stop.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 98)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(184, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "By  Luca Franziskowski.  2021 - 2022" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'N_Main_1
        '
        Me.N_Main_1.Location = New System.Drawing.Point(68, 44)
        Me.N_Main_1.Maximum = New Decimal(New Integer() {4000, 0, 0, 0})
        Me.N_Main_1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.N_Main_1.Name = "N_Main_1"
        Me.N_Main_1.Size = New System.Drawing.Size(47, 20)
        Me.N_Main_1.TabIndex = 4
        Me.N_Main_1.Value = New Decimal(New Integer() {500, 0, 0, 0})
        '
        'N_Main_1b
        '
        Me.N_Main_1b.Location = New System.Drawing.Point(148, 44)
        Me.N_Main_1b.Maximum = New Decimal(New Integer() {4000, 0, 0, 0})
        Me.N_Main_1b.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.N_Main_1b.Name = "N_Main_1b"
        Me.N_Main_1b.Size = New System.Drawing.Size(47, 20)
        Me.N_Main_1b.TabIndex = 5
        Me.N_Main_1b.Value = New Decimal(New Integer() {500, 0, 0, 0})
        '
        'N_Main_2
        '
        Me.N_Main_2.Location = New System.Drawing.Point(68, 70)
        Me.N_Main_2.Maximum = New Decimal(New Integer() {4000, 0, 0, 0})
        Me.N_Main_2.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.N_Main_2.Name = "N_Main_2"
        Me.N_Main_2.Size = New System.Drawing.Size(47, 20)
        Me.N_Main_2.TabIndex = 6
        Me.N_Main_2.Value = New Decimal(New Integer() {200, 0, 0, 0})
        '
        'N_Main_2b
        '
        Me.N_Main_2b.Location = New System.Drawing.Point(148, 70)
        Me.N_Main_2b.Maximum = New Decimal(New Integer() {4000, 0, 0, 0})
        Me.N_Main_2b.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.N_Main_2b.Name = "N_Main_2b"
        Me.N_Main_2b.Size = New System.Drawing.Size(47, 20)
        Me.N_Main_2b.TabIndex = 7
        Me.N_Main_2b.Value = New Decimal(New Integer() {200, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(125, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(17, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Y:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(125, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(17, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Y:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 46)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Pos. 1 X:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 72)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Pos. 2 X:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 17)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Interval:"
        '
        'C_Main_MakeClicks
        '
        Me.C_Main_MakeClicks.AutoSize = True
        Me.C_Main_MakeClicks.Location = New System.Drawing.Point(215, 71)
        Me.C_Main_MakeClicks.Name = "C_Main_MakeClicks"
        Me.C_Main_MakeClicks.Size = New System.Drawing.Size(83, 17)
        Me.C_Main_MakeClicks.TabIndex = 13
        Me.C_Main_MakeClicks.Text = "Make clicks"
        Me.C_Main_MakeClicks.UseVisualStyleBackColor = True
        '
        'C_RandomPosition
        '
        Me.C_RandomPosition.AutoSize = True
        Me.C_RandomPosition.Location = New System.Drawing.Point(215, 94)
        Me.C_RandomPosition.Name = "C_RandomPosition"
        Me.C_RandomPosition.Size = New System.Drawing.Size(105, 17)
        Me.C_RandomPosition.TabIndex = 14
        Me.C_RandomPosition.Text = "Random position"
        Me.C_RandomPosition.UseVisualStyleBackColor = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(324, 120)
        Me.Controls.Add(Me.C_RandomPosition)
        Me.Controls.Add(Me.C_Main_MakeClicks)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.N_Main_2b)
        Me.Controls.Add(Me.N_Main_2)
        Me.Controls.Add(Me.N_Main_1b)
        Me.Controls.Add(Me.N_Main_1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.B_Main_Stop)
        Me.Controls.Add(Me.B_Main_Start)
        Me.Controls.Add(Me.N_Main_Interval)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Main"
        Me.Text = "Mouse Jiggler"
        CType(Me.N_Main_Interval, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.N_Main_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.N_Main_1b, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.N_Main_2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.N_Main_2b, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents N_Main_Interval As NumericUpDown
    Friend WithEvents Worker As System.ComponentModel.BackgroundWorker
    Friend WithEvents B_Main_Start As Button
    Friend WithEvents B_Main_Stop As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents N_Main_1 As NumericUpDown
    Friend WithEvents N_Main_1b As NumericUpDown
    Friend WithEvents N_Main_2 As NumericUpDown
    Friend WithEvents N_Main_2b As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents C_Main_MakeClicks As CheckBox
    Friend WithEvents C_RandomPosition As CheckBox
End Class
