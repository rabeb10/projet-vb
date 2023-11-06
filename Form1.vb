Public Class frm_gestion
    Private Sub frm_gestion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Public txt_produit As String
        Public txt_prix As Integer
        Public txt_quantite As Integer
        Public txt_montant As Integer
        Public total_prix As Integer
        Public total_quantite As Integer
        Public total_montant As Integer
        Public tva As Integer
        Public remise As Integer
    Private Sub init()
        box_prix.Clear()
        box_montant.Clear()
        box_produits.Text = "quel produit ?"
        box_quantite.Text = "choisir la quantite"
        total_prix.Clear()
        total_quantite.Clear()
        total_montant.Clear()
        tva.Clear()
        remise.Clear()
    End Sub

    Private Sub btn_ajout_Click(sender As Object, e As EventArgs) Handles btn_ajout.Click
        box_prix.items.add(new_produit)
        Dim new_produit = box_produits.Text
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        init()
    End Sub

    Private Sub btn_valider_Click(sender As Object, e As EventArgs) Handles btn_valider.Click
        Dim box_prix As String = box_prix.text
        Dim box_montant As String = box_montant.text
        init()
    End Sub

    Private Sub btn_calculer_Click(sender As Object, e As EventArgs) Handles btn_calculer.Click
        If (lst_prix > 0) Then
            lst_montant = box_prix * box_quantite.SelectedItem
        End If
        remise = total_montant - (total_montant * 10) / 100
        If (total_montant > 1000) Then
            remise = total_montant * 10 / 100
            total_montant = total_montant - remise

        End If
    End Sub

    Private Sub lst_produit_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lst_produit.SelectedIndexChanged
        If lst_produit.SelectedIndex <> -1 Then
            lst_produit.Text = lst_produit.SelectedItem.ToString()

        End If
    End Sub

    Private Sub lst_prix_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lst_prix.SelectedIndexChanged
        If lst_prix.SelectedIndex <> -1 Then
            lst_prix.Text = lst_prix.SelectedItem.ToString()

        End If
    End Sub

    Private Sub lst_quantite_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lst_quantite.SelectedIndexChanged
        If lst_quantite.SelectedIndex <> -1 Then
            lst_quantite.Text = lst_quantite.SelectedItem.ToString()

        End If
    End Sub

    Private Sub lst_montant_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lst_montant.SelectedIndexChanged
        If lst_montant.SelectedIndex <> -1 Then
            lst_montant.Text = lst_montant.SelectedItem.ToString()

        End If
    End Sub
End Class