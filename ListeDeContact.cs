using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carnet_Adresse
{
    internal class ListeDeContact:ListBox
    {

        public List<Contact> Carnet { get; set; }
        public ListeDeContact()
        {
            Carnet = new List<Contact>();
        }


        internal void AjouterContact(Contact c1)
        {
            Carnet.Add(c1);
        }
    }


    
}
