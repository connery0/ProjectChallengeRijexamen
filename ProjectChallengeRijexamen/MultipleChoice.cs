using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectChallengeRijexamen
{
    class MultipleChoice
    {
        private Vraag[] Vragen;
        private MC_Form ParentForm;
       // private string Naam;
       // private bool NieuwBestand;

        public MultipleChoice(MC_Form ParentForm, String Naam, Boolean NieuwBestand)
        {
            this.ParentForm = ParentForm;

            String FileName = "..\\..\\Vragen\\" + Naam+".txt";
            if (System.IO.File.Exists(FileName)==false)
            {
                ParentForm.ShowMessage("file not found");
              //  String Text=
                System.IO.File.Copy("..\\..\\Vragen\\Vragen.txt", ("..\\..\\Vragen\\" + Naam + ".txt")); 
            }

            setAantalVragen(Naam);
            setVragen(Naam);

            Vraag A = Vragen[0];
            String test = A.PrintVraag();
            ParentForm.ShowMessage(test);

            System.IO.StreamWriter objWriter;
            objWriter = new System.IO.StreamWriter("..\\..\\vragen\\Vragen2.txt");
            objWriter.Write("test");
            objWriter.Close();







            
        }

       
  

        private void setAantalVragen(String bestandsNaam)
        {
            System.IO.StreamReader myFile =
           new System.IO.StreamReader("..\\..\\Vragen\\" + bestandsNaam + ".txt");
            string myString = myFile.ReadToEnd();

            myFile.Close();
            int Lengte = myString.Split('\n').Length / 6;
            Vragen = new Vraag[Lengte];
        }

        private void setVragen(String bestandsNaam)
        {

            string line;
            int teller = 0;
            System.IO.StreamReader file = new System.IO.StreamReader("..\\..\\Vragen\\" + bestandsNaam + ".txt");
            while ((line = file.ReadLine()) != null)
            {
                Vragen[teller] = new Vraag(file.ReadLine(), file.ReadLine(), file.ReadLine(), file.ReadLine(), file.ReadLine());
                teller += 1;
            }
            file.Close();
        }


        public int getAantalVragen()
        {
            return Vragen.Length;
        }









    }
}
