using System;

namespace RNATranscriptionModule
{
    public static class RnaTranscription
    {
        public static string ToRna(string nucleotide)
        {
            string rna;
            rna = nucleotide.Replace("G", "c").Replace("C", "g").Replace("T", "a").Replace("A", "u");
            return rna.ToUpper();
        }
    }
}
