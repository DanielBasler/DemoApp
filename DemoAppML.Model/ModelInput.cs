// This file was auto-generated by ML.NET Model Builder. 

using Microsoft.ML.Data;

namespace DemoAppML.Model
{
    public class ModelInput
    {
        [ColumnName("Artikel_Nr"), LoadColumn(0)]
        public string Artikel_Nr { get; set; }


        [ColumnName("Lagerort"), LoadColumn(1)]
        public float Lagerort { get; set; }


        [ColumnName("Menge_In"), LoadColumn(2)]
        public float Menge_In { get; set; }


        [ColumnName("Menge_Out"), LoadColumn(3)]
        public float Menge_Out { get; set; }


        [ColumnName("Artikeltyp"), LoadColumn(4)]
        public string Artikeltyp { get; set; }


        [ColumnName("Gesamt_Artikelbestand"), LoadColumn(5)]
        public string Gesamt_Artikelbestand { get; set; }


    }
}