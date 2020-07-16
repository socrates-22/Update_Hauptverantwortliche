using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Update_Hauptverantwortliche
{
    public partial class test_Hauptverant
    {
        public test_Hauptverant(test_Hauptverant copyEntry)
        {
            this.STICHTAG = copyEntry.STICHTAG;
            this.MANDANT = copyEntry.MANDANT;
            this.OBJEKTGES = copyEntry.OBJEKTGES;
            this.LIEGNR = copyEntry.LIEGNR;
            this.LIEGBEZ = copyEntry.LIEGBEZ;
            this.Objektschluessel_Liegenschaft = copyEntry.Objektschluessel_Liegenschaft;
            this.Buchungskreis = copyEntry.Buchungskreis;
            this.Hauptverantwortlich = copyEntry.Hauptverantwortlich;
        }

        public test_Hauptverant()
        {

        }

        public void Set_COO_AL(test_Hauptverant firstItem)
        {
            firstItem.User_Kategorie = "COO - AL";
            firstItem.User_Name_Vorname = "Siemens Harald";
            firstItem.Zweit_Prüfer_Berechtigt = "AL";
        }

        public void Set_COO_GF(test_Hauptverant firstItem)
        {
            firstItem.User_Kategorie = "COO - GF";
            firstItem.User_Name_Vorname = "Siemens Harald";
            firstItem.Zweit_Prüfer_Berechtigt = "GF";
        }

        public void Set_CEO_AL(test_Hauptverant firstItem)
        {
            firstItem.User_Kategorie = "CEO - AL";
            firstItem.User_Name_Vorname = "Baum Gregor";
            firstItem.Zweit_Prüfer_Berechtigt = "AL";
        }

        public void Set_Leitung_Finanzen_AL(test_Hauptverant firstItem)
        {
            firstItem.User_Kategorie = "Leitung Finanzen - AL";
            firstItem.User_Name_Vorname = "Acar Gökhan";
            firstItem.Zweit_Prüfer_Berechtigt = "AL";
        }
        public void Set_Leitung_Mietbetreuung_AL(test_Hauptverant firstItem)
        {
            firstItem.User_Kategorie = "Leitung Mietbetreuung - AL";
            firstItem.User_Name_Vorname = "Röske Melanie";
            firstItem.Zweit_Prüfer_Berechtigt = "AL";
        }
        public void Set_Leitung_Projektsteuerung_AL(test_Hauptverant firstItem)
        {
            firstItem.User_Kategorie = "Leitung Projektsteuerung - AL";
            firstItem.User_Name_Vorname = "Besser Fabian";
            firstItem.Zweit_Prüfer_Berechtigt = "AL";
        }
        public void Set_Leitung_Rechnungswesen_AL(test_Hauptverant firstItem)
        {
            firstItem.User_Kategorie = "Leitung Rechnungswesen - AL";
            firstItem.User_Name_Vorname = "Lange Holger";
            firstItem.Zweit_Prüfer_Berechtigt = "AL";
        }

        public void Set_Leitung_Recht_AL(test_Hauptverant firstItem)
        {
            firstItem.User_Kategorie = "Leitung Recht - AL";
            firstItem.User_Name_Vorname = "Stern Susanne";
            firstItem.Zweit_Prüfer_Berechtigt = "AL";
        }
    }
}
