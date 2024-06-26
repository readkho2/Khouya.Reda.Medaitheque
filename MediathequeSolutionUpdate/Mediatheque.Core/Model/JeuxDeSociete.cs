﻿namespace Mediatheque.Core.Model
{
    public class JeuxDeSociete : ObjetDePret
    {
        public JeuxDeSociete(string titreDeLObjet, int ageMini, int ageMaxi, string editeur, TypeJeuxDeSociete type) : base(titreDeLObjet)
        {
            AgeMinimum = ageMini;
            AgeMaximum = ageMaxi;
            Editeur = editeur;
            TypeJeux = type;
        }

        public int AgeMinimum { get; set; }
        public int AgeMaximum { get; set; }
        public string Editeur { get; set; }
        public TypeJeuxDeSociete TypeJeux { get; set; }
        public string Nom { get; set; }

    }
}
