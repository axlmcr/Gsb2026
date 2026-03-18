namespace Metier
{
    public class Session
    {
        public string NomVisiteur { get; }

        // collections d'objets métier

        public List<Motif> LesMotifs { get; }
        public List<TypePraticien> LesTypesPraticien { get; }
        public List<Specialite> LesSpecialites { get; }
        public List<Famille> LesFamilles { get; }

        public List<Medicament> LesMedicaments { get; }

        public List<Ville> MesVilles { get; }
        public List<Praticien> MesPraticiens { get; }
        public List<Visite> MesVisites { get; }

        public Session(
            string nom,
            List<Motif> lesMotifs,
            List<TypePraticien> lesTypesPraticien,
            List<Specialite> lesSpecialites,
            List<Famille> lesFamilles,
            List<Medicament> lesMedicaments,
            List<Ville> mesVilles,
            List<Praticien> mesPraticiens,
            List<Visite> mesVisites)
        {
            NomVisiteur = nom;

            LesMotifs = lesMotifs;
            LesTypesPraticien = lesTypesPraticien;
            LesSpecialites = lesSpecialites;
            LesFamilles = lesFamilles;

            LesMedicaments = lesMedicaments;

            MesVilles = mesVilles;
            MesPraticiens = mesPraticiens;
            MesVisites = mesVisites;
        }
    }
}
