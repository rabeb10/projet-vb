<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_gestion
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txt_produit = New System.Windows.Forms.Label()
        Me.txt_prix = New System.Windows.Forms.Label()
        Me.txt_quantite = New System.Windows.Forms.Label()
        Me.txt_montant = New System.Windows.Forms.Label()
        Me.box_produits = New System.Windows.Forms.ComboBox()
        Me.box_quantite = New System.Windows.Forms.ComboBox()
        Me.box_prix = New System.Windows.Forms.TextBox()
        Me.box_montant = New System.Windows.Forms.TextBox()
        Me.btn_ajout = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_valider = New System.Windows.Forms.Button()
        Me.lbl_produit = New System.Windows.Forms.Label()
        Me.lbl_prix = New System.Windows.Forms.Label()
        Me.lbl_quantite = New System.Windows.Forms.Label()
        Me.lbl_montant = New System.Windows.Forms.Label()
        Me.btn_calculer = New System.Windows.Forms.Button()
        Me.btn_quitter = New System.Windows.Forms.Button()
        Me.lst_produit = New System.Windows.Forms.ListBox()
        Me.lst_prix = New System.Windows.Forms.ListBox()
        Me.lst_quantite = New System.Windows.Forms.ListBox()
        Me.lst_montant = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.total_prix = New System.Windows.Forms.TextBox()
        Me.total_quantite = New System.Windows.Forms.TextBox()
        Me.total_montant = New System.Windows.Forms.TextBox()
        Me.tva = New System.Windows.Forms.TextBox()
        Me.remise = New System.Windows.Forms.TextBox()
        Me.txt_tva = New System.Windows.Forms.Label()
        Me.txt_remise = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txt_produit
        '
        Me.txt_produit.AutoSize = True
        Me.txt_produit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_produit.Location = New System.Drawing.Point(31, 32)
        Me.txt_produit.Name = "txt_produit"
        Me.txt_produit.Size = New System.Drawing.Size(76, 24)
        Me.txt_produit.TabIndex = 0
        Me.txt_produit.Text = "Produit"
        '
        'txt_prix
        '
        Me.txt_prix.AutoSize = True
        Me.txt_prix.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_prix.Location = New System.Drawing.Point(32, 74)
        Me.txt_prix.Name = "txt_prix"
        Me.txt_prix.Size = New System.Drawing.Size(121, 24)
        Me.txt_prix.TabIndex = 1
        Me.txt_prix.Text = "Prix unitaire"
        '
        'txt_quantite
        '
        Me.txt_quantite.AutoSize = True
        Me.txt_quantite.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_quantite.Location = New System.Drawing.Point(32, 123)
        Me.txt_quantite.Name = "txt_quantite"
        Me.txt_quantite.Size = New System.Drawing.Size(88, 24)
        Me.txt_quantite.TabIndex = 2
        Me.txt_quantite.Text = "Quantité"
        '
        'txt_montant
        '
        Me.txt_montant.AutoSize = True
        Me.txt_montant.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_montant.Location = New System.Drawing.Point(33, 176)
        Me.txt_montant.Name = "txt_montant"
        Me.txt_montant.Size = New System.Drawing.Size(118, 24)
        Me.txt_montant.TabIndex = 3
        Me.txt_montant.Text = "Montant HT"
        '
        'box_produits
        '
        Me.box_produits.FormattingEnabled = True
        Me.box_produits.Items.AddRange(New Object() {"clavier", "souris", "uc"})
        Me.box_produits.Location = New System.Drawing.Point(159, 34)
        Me.box_produits.Name = "box_produits"
        Me.box_produits.Size = New System.Drawing.Size(121, 24)
        Me.box_produits.TabIndex = 4
        Me.box_produits.Text = "clavier"
        '
        'box_quantite
        '
        Me.box_quantite.FormattingEnabled = True
        Me.box_quantite.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8"})
        Me.box_quantite.Location = New System.Drawing.Point(159, 125)
        Me.box_quantite.Name = "box_quantite"
        Me.box_quantite.Size = New System.Drawing.Size(121, 24)
        Me.box_quantite.TabIndex = 5
        Me.box_quantite.Text = "1"
        '
        'box_prix
        '
        Me.box_prix.Location = New System.Drawing.Point(159, 76)
        Me.box_prix.Name = "box_prix"
        Me.box_prix.Size = New System.Drawing.Size(121, 22)
        Me.box_prix.TabIndex = 6
        '
        'box_montant
        '
        Me.box_montant.Location = New System.Drawing.Point(159, 176)
        Me.box_montant.Name = "box_montant"
        Me.box_montant.Size = New System.Drawing.Size(121, 22)
        Me.box_montant.TabIndex = 7
        '
        'btn_ajout
        '
        Me.btn_ajout.Location = New System.Drawing.Point(418, 32)
        Me.btn_ajout.Name = "btn_ajout"
        Me.btn_ajout.Size = New System.Drawing.Size(126, 38)
        Me.btn_ajout.TabIndex = 8
        Me.btn_ajout.Text = "Ajouter"
        Me.btn_ajout.UseVisualStyleBackColor = True
        '
        'btn_delete
        '
        Me.btn_delete.Location = New System.Drawing.Point(418, 76)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(126, 41)
        Me.btn_delete.TabIndex = 9
        Me.btn_delete.Text = "Supprimer"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'btn_valider
        '
        Me.btn_valider.Location = New System.Drawing.Point(418, 125)
        Me.btn_valider.Name = "btn_valider"
        Me.btn_valider.Size = New System.Drawing.Size(126, 39)
        Me.btn_valider.TabIndex = 10
        Me.btn_valider.Text = "Valider"
        Me.btn_valider.UseVisualStyleBackColor = True
        '
        'lbl_produit
        '
        Me.lbl_produit.AutoSize = True
        Me.lbl_produit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_produit.Location = New System.Drawing.Point(61, 240)
        Me.lbl_produit.Name = "lbl_produit"
        Me.lbl_produit.Size = New System.Drawing.Size(69, 20)
        Me.lbl_produit.TabIndex = 11
        Me.lbl_produit.Text = "Produit"
        '
        'lbl_prix
        '
        Me.lbl_prix.AutoSize = True
        Me.lbl_prix.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_prix.Location = New System.Drawing.Point(156, 240)
        Me.lbl_prix.Name = "lbl_prix"
        Me.lbl_prix.Size = New System.Drawing.Size(114, 20)
        Me.lbl_prix.TabIndex = 12
        Me.lbl_prix.Text = "Prix Unitaire"
        '
        'lbl_quantite
        '
        Me.lbl_quantite.AutoSize = True
        Me.lbl_quantite.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_quantite.Location = New System.Drawing.Point(308, 240)
        Me.lbl_quantite.Name = "lbl_quantite"
        Me.lbl_quantite.Size = New System.Drawing.Size(80, 20)
        Me.lbl_quantite.TabIndex = 13
        Me.lbl_quantite.Text = "Quantité"
        '
        'lbl_montant
        '
        Me.lbl_montant.AutoSize = True
        Me.lbl_montant.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_montant.Location = New System.Drawing.Point(451, 240)
        Me.lbl_montant.Name = "lbl_montant"
        Me.lbl_montant.Size = New System.Drawing.Size(107, 20)
        Me.lbl_montant.TabIndex = 14
        Me.lbl_montant.Text = "Montant HT"
        '
        'btn_calculer
        '
        Me.btn_calculer.Location = New System.Drawing.Point(761, 240)
        Me.btn_calculer.Name = "btn_calculer"
        Me.btn_calculer.Size = New System.Drawing.Size(100, 44)
        Me.btn_calculer.TabIndex = 15
        Me.btn_calculer.Text = "Calculer"
        Me.btn_calculer.UseVisualStyleBackColor = True
        '
        'btn_quitter
        '
        Me.btn_quitter.Location = New System.Drawing.Point(761, 290)
        Me.btn_quitter.Name = "btn_quitter"
        Me.btn_quitter.Size = New System.Drawing.Size(100, 49)
        Me.btn_quitter.TabIndex = 16
        Me.btn_quitter.Text = "Quitter"
        Me.btn_quitter.UseVisualStyleBackColor = True
        '
        'lst_produit
        '
        Me.lst_produit.FormattingEnabled = True
        Me.lst_produit.ItemHeight = 16
        Me.lst_produit.Location = New System.Drawing.Point(12, 274)
        Me.lst_produit.Name = "lst_produit"
        Me.lst_produit.Size = New System.Drawing.Size(120, 148)
        Me.lst_produit.TabIndex = 17
        '
        'lst_prix
        '
        Me.lst_prix.FormattingEnabled = True
        Me.lst_prix.ItemHeight = 16
        Me.lst_prix.Location = New System.Drawing.Point(150, 274)
        Me.lst_prix.Name = "lst_prix"
        Me.lst_prix.Size = New System.Drawing.Size(120, 148)
        Me.lst_prix.TabIndex = 18
        '
        'lst_quantite
        '
        Me.lst_quantite.FormattingEnabled = True
        Me.lst_quantite.ItemHeight = 16
        Me.lst_quantite.Location = New System.Drawing.Point(276, 274)
        Me.lst_quantite.Name = "lst_quantite"
        Me.lst_quantite.Size = New System.Drawing.Size(130, 148)
        Me.lst_quantite.TabIndex = 19
        '
        'lst_montant
        '
        Me.lst_montant.FormattingEnabled = True
        Me.lst_montant.ItemHeight = 16
        Me.lst_montant.Location = New System.Drawing.Point(418, 274)
        Me.lst_montant.Name = "lst_montant"
        Me.lst_montant.Size = New System.Drawing.Size(140, 148)
        Me.lst_montant.TabIndex = 20
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(57, 443)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 20)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Total :"
        '
        'total_prix
        '
        Me.total_prix.Location = New System.Drawing.Point(150, 441)
        Me.total_prix.Name = "total_prix"
        Me.total_prix.Size = New System.Drawing.Size(120, 22)
        Me.total_prix.TabIndex = 22
        '
        'total_quantite
        '
        Me.total_quantite.Location = New System.Drawing.Point(276, 441)
        Me.total_quantite.Name = "total_quantite"
        Me.total_quantite.Size = New System.Drawing.Size(130, 22)
        Me.total_quantite.TabIndex = 23
        '
        'total_montant
        '
        Me.total_montant.Location = New System.Drawing.Point(418, 443)
        Me.total_montant.Name = "total_montant"
        Me.total_montant.Size = New System.Drawing.Size(140, 22)
        Me.total_montant.TabIndex = 24
        '
        'tva
        '
        Me.tva.Location = New System.Drawing.Point(276, 483)
        Me.tva.Name = "tva"
        Me.tva.Size = New System.Drawing.Size(282, 22)
        Me.tva.TabIndex = 25
        '
        'remise
        '
        Me.remise.Location = New System.Drawing.Point(276, 528)
        Me.remise.Name = "remise"
        Me.remise.Size = New System.Drawing.Size(282, 22)
        Me.remise.TabIndex = 26
        '
        'txt_tva
        '
        Me.txt_tva.AutoSize = True
        Me.txt_tva.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_tva.Location = New System.Drawing.Point(158, 483)
        Me.txt_tva.Name = "txt_tva"
        Me.txt_tva.Size = New System.Drawing.Size(112, 20)
        Me.txt_tva.TabIndex = 27
        Me.txt_tva.Text = "TVA (20%) :"
        '
        'txt_remise
        '
        Me.txt_remise.AutoSize = True
        Me.txt_remise.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_remise.Location = New System.Drawing.Point(159, 528)
        Me.txt_remise.Name = "txt_remise"
        Me.txt_remise.Size = New System.Drawing.Size(72, 20)
        Me.txt_remise.TabIndex = 28
        Me.txt_remise.Text = "Remise"
        '
        'frm_gestion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(955, 562)
        Me.Controls.Add(Me.txt_remise)
        Me.Controls.Add(Me.txt_tva)
        Me.Controls.Add(Me.remise)
        Me.Controls.Add(Me.tva)
        Me.Controls.Add(Me.total_montant)
        Me.Controls.Add(Me.total_quantite)
        Me.Controls.Add(Me.total_prix)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lst_montant)
        Me.Controls.Add(Me.lst_quantite)
        Me.Controls.Add(Me.lst_prix)
        Me.Controls.Add(Me.lst_produit)
        Me.Controls.Add(Me.btn_quitter)
        Me.Controls.Add(Me.btn_calculer)
        Me.Controls.Add(Me.lbl_montant)
        Me.Controls.Add(Me.lbl_quantite)
        Me.Controls.Add(Me.lbl_prix)
        Me.Controls.Add(Me.lbl_produit)
        Me.Controls.Add(Me.btn_valider)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_ajout)
        Me.Controls.Add(Me.box_montant)
        Me.Controls.Add(Me.box_prix)
        Me.Controls.Add(Me.box_quantite)
        Me.Controls.Add(Me.box_produits)
        Me.Controls.Add(Me.txt_montant)
        Me.Controls.Add(Me.txt_quantite)
        Me.Controls.Add(Me.txt_prix)
        Me.Controls.Add(Me.txt_produit)
        Me.Name = "frm_gestion"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_produit As Label
    Friend WithEvents txt_prix As Label
    Friend WithEvents txt_quantite As Label
    Friend WithEvents txt_montant As Label
    Friend WithEvents box_produits As ComboBox
    Friend WithEvents box_quantite As ComboBox
    Friend WithEvents box_prix As TextBox
    Friend WithEvents box_montant As TextBox
    Friend WithEvents btn_ajout As Button
    Friend WithEvents btn_delete As Button
    Friend WithEvents btn_valider As Button
    Friend WithEvents lbl_produit As Label
    Friend WithEvents lbl_prix As Label
    Friend WithEvents lbl_quantite As Label
    Friend WithEvents lbl_montant As Label
    Friend WithEvents btn_calculer As Button
    Friend WithEvents btn_quitter As Button
    Friend WithEvents lst_produit As ListBox
    Friend WithEvents lst_prix As ListBox
    Friend WithEvents lst_quantite As ListBox
    Friend WithEvents lst_montant As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents total_prix As TextBox
    Friend WithEvents total_quantite As TextBox
    Friend WithEvents total_montant As TextBox
    Friend WithEvents tva As TextBox
    Friend WithEvents remise As TextBox
    Friend WithEvents txt_tva As Label
    Friend WithEvents txt_remise As Label
End Class
