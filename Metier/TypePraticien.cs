// ------------------------------------------
// Nom du fichier : typePraticien.cs
// Objet : Définition de la classe TypePraticien
// Auteur : M. Verghote
// ------------------------------------------

namespace Metier
{
    public class TypePraticien
    {
        // Constructeur
        public TypePraticien(string id, string libelle)
         => (Id, Libelle) = (id, libelle);
        

        // Propriétés automatiques
        public string Id { get; set; }
        public string Libelle { get; set; }
    }
}
