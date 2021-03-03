using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carnet_Adresse
{
    internal static class Utilitaire
    {
        
        //Rajout de contact
        public static void Ajouter(ListeDeContact carnet,Contact c)
        {
            if(VérifierContact(carnet, c) == true)
            {
                MessageBox.Show("Contact existe déjà!! " + c.ToString());
            }
            else if (VérifierContact(carnet, c) != true)
            {
                carnet.AjouterContact(c);
                MessageBox.Show("Nouveau Contact rajouté!!");
            }
            



        }
        //suppresion de contact
        public static void Retirer(ListeDeContact carnet, Contact c)
        {
            carnet.Carnet.Remove(c);
            MessageBox.Show("Contact Supprimé!! ");
        }
        //vérifier si contact existe
        public static bool VérifierContact(ListeDeContact carnet, Contact c)
        {
            string exist = null;
            foreach (Contact co in carnet.Carnet)
            {
                if (c.Equals(co))//((co.LastName == c.LastName) && (co.FirstName == c.FirstName))
                {
                   exist = "y";
                }
                else
                {
                    exist = "n";
                }
            }
            if (exist == "y")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        internal static Contact ParseLigne(string data)
        {

            CultureInfo cultures = new CultureInfo("en-CA");//reconnaissance de caractère(système d'écriture)
            string[] tokens = data.Split(',');
            string FName = tokens[0];
            string MName = tokens[1];
            string LName = tokens[2];
            string Phone = tokens[3];
            string Address1 = tokens[4];
            string Address2 = tokens[5];
            string  City = tokens[6];
            string State = tokens[7];
            string Country = tokens[8];
            string ZIP = tokens[9];
            string Email = tokens[10];
            
            return new Contact(LName,FName,MName,Phone,Email,Address1,Address2,City,State,ZIP,Country);


            /*ParseLigne "split" prend une string --> un objet|Deservialiser
             * L'inverse est Servialiser*/

        }

        internal static string FormerLigne(Contact item)
        {
            //Serialisation
            return item.FirstName + "," + item.MiddleName + "," + item.LastName + "," + item.Phone 
                + "," + item.Address1 + "," + item.Address2 + "," + item.City + "," 
                + item.State + "," + item.Country + "," + item.Zip + "," + item.Email ;
        }
        //Loading du carnet.txt au démarrage
        internal static void OnloadList(string fichier, ListeDeContact list, ListBox listb)
        {
            listb.BeginUpdate();
            ManipFichier.Lecture(fichier, list);
            foreach (Contact item in list.Carnet)
            {
                listb.Items.Add(item);
            }
            listb.EndUpdate();
        }
        //Mise a jour du carnet
        internal static void UpdateList(string fichier, ListeDeContact list,ListBox listb)
        {
            listb.BeginUpdate();
            
            ManipFichier.Ecriture(fichier, list);
            listb.Items.Clear();
            list.Carnet.Clear();
            ManipFichier.Lecture(fichier, list);
            //var sortie = from s in list.Carnet
            //             select s.LastName
                         
            foreach (Contact item in list.Carnet)
            {
                listb.Items.Add(item);
            }            
            listb.EndUpdate();
        }
    }
}
