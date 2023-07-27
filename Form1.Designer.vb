<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        Button2 = New Button()
        Label6 = New Label()
        Label4 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.HUI
        PictureBox1.Location = New Point(-1, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(802, 455)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.ActiveBorder
        Label1.Font = New Font("Algerian", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(12, 62)
        Label1.Name = "Label1"
        Label1.Size = New Size(509, 30)
        Label1.TabIndex = 2
        Label1.Text = "Ingrese el Capital del prestamo"
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = SystemColors.ActiveBorder
        TextBox1.Location = New Point(12, 95)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(299, 23)
        TextBox1.TabIndex = 3
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = SystemColors.ActiveBorder
        TextBox2.Location = New Point(12, 170)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(299, 23)
        TextBox2.TabIndex = 4
        ' 
        ' TextBox3
        ' 
        TextBox3.BackColor = SystemColors.ActiveBorder
        TextBox3.Location = New Point(12, 246)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(299, 23)
        TextBox3.TabIndex = 5
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = SystemColors.ActiveBorder
        Label2.Font = New Font("Algerian", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(12, 137)
        Label2.Name = "Label2"
        Label2.Size = New Size(391, 30)
        Label2.TabIndex = 6
        Label2.Text = "Ingrese el Interes Anual"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = SystemColors.ActiveBorder
        Label3.Font = New Font("Algerian", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(12, 213)
        Label3.Name = "Label3"
        Label3.Size = New Size(410, 30)
        Label3.TabIndex = 7
        Label3.Text = "Ingrese el numero de Años"
        ' 
        ' Button2
        ' 
        Button2.BackColor = SystemColors.ActiveBorder
        Button2.Font = New Font("Algerian", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.Location = New Point(12, 295)
        Button2.Name = "Button2"
        Button2.Size = New Size(273, 37)
        Button2.TabIndex = 10
        Button2.Text = "Calcular cuota"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = SystemColors.ActiveBorder
        Label6.Font = New Font("Algerian", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(12, 335)
        Label6.Name = "Label6"
        Label6.Size = New Size(30, 30)
        Label6.TabIndex = 12
        Label6.Text = "="
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = SystemColors.ActiveBorder
        Label4.Font = New Font("Algerian", 21.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(7, 8)
        Label4.Name = "Label4"
        Label4.Size = New Size(185, 32)
        Label4.TabIndex = 13
        Label4.Text = "Bienvenido"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label4)
        Controls.Add(Label6)
        Controls.Add(Button2)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Name = "Form1"
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
End Class
