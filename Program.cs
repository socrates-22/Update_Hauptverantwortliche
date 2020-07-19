using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Update_Hauptverantwortliche
{
    class Program
    {
        static void Main(string[] args)
        {
            using(DOCUWARE_TABELLENEntities context = new DOCUWARE_TABELLENEntities())
            {
                List<double?> result = context.test_Hauptverant.Select(x => x.Objektschluessel_Liegenschaft).Distinct().ToList();
                var GroupResult = context.test_Hauptverant.GroupBy(x => x.Objektschluessel_Liegenschaft).ToList();

                //Console.WriteLine(string.Join(Environment.NewLine, result));

                foreach (var item in GroupResult)
                {
                    Test_Hauptverant firstItem = item.First();
                    Test_Hauptverant newEntry = new Test_Hauptverant(firstItem);

                    newEntry.Set_COO_AL(newEntry);
                    context.test_Hauptverant.Add(newEntry);
                    
                    newEntry = new Test_Hauptverant(firstItem);
                    newEntry.Set_COO_GF(newEntry);
                    context.test_Hauptverant.Add(newEntry);

                    newEntry = new Test_Hauptverant(firstItem);
                    newEntry.Set_CEO_AL(newEntry);
                    context.test_Hauptverant.Add(newEntry);

                    newEntry = new Test_Hauptverant(firstItem);
                    newEntry.Set_Leitung_Finanzen_AL(newEntry);
                    context.test_Hauptverant.Add(newEntry);

                    newEntry = new Test_Hauptverant(firstItem);
                    newEntry.Set_Leitung_Mietbetreuung_AL(newEntry);
                    context.test_Hauptverant.Add(newEntry);

                    newEntry = new Test_Hauptverant(firstItem);
                    newEntry.Set_Leitung_Projektsteuerung_AL(newEntry);
                    context.test_Hauptverant.Add(newEntry);

                    newEntry = new Test_Hauptverant(firstItem);
                    newEntry.Set_Leitung_Rechnungswesen_AL(newEntry);
                    context.test_Hauptverant.Add(newEntry);

                    newEntry = new Test_Hauptverant(firstItem);
                    newEntry.Set_Leitung_Recht_AL(newEntry);
                    context.test_Hauptverant.Add(newEntry);
                }
               
                context.SaveChanges();

                Console.ReadLine();

            }

        }
    }
}
