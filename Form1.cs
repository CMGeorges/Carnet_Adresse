using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carnet_Adresse
{
    public partial class CATP1 : Form
    {
        ListeDeContact Liste = new ListeDeContact();

        public CATP1()
        {
            InitializeComponent();
            Utilitaire.OnloadList("Contact.txt", Liste, listContact);
        }
        

        private void btnNew_Click(object sender, EventArgs e)
        {
            FirstNBox.Clear();
            LastNBox.Clear();
            MiddleNBox.Clear();
            PhoneBox.Clear();
            EmailBox.Clear();
            AddressBox1.Clear();
            AddressBox2.Clear();
            CityBox.Clear();
            StateBox.Clear();
            ZipBox.Clear();
            CountryBox.Clear();

        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            listContact.ClearSelected();
        }

      

        private void btnSave_Click(object sender, EventArgs e)
        {

            Contact C1 = new Contact(LastNBox.Text, FirstNBox.Text, MiddleNBox.Text, PhoneBox.Text, EmailBox.Text, AddressBox1.Text, AddressBox2.Text, CityBox.Text, StateBox.Text, ZipBox.Text, CountryBox.Text);
            Utilitaire.Ajouter(Liste, C1);
            Utilitaire.UpdateList("Contact.txt", Liste, listContact);

        }

        private void listContact_DoubleClick(object sender, EventArgs e)
        {
            Cleared();
            if (listContact.SelectedItem.ToString() != null)
            {
                for (int i = 0; i < Liste.Carnet.Count; i++)
                {
                    if (listContact.SelectedItem.ToString() == Liste.Carnet[i].ToString())
                    {

                        FirstNBox.Text = Liste.Carnet[i].FirstName;
                        LastNBox.Text = Liste.Carnet[i].LastName;
                        MiddleNBox.Text = Liste.Carnet[i].MiddleName;
                        PhoneBox.Text = Liste.Carnet[i].Phone;
                        EmailBox.Text = Liste.Carnet[i].Email;
                        AddressBox1.Text = Liste.Carnet[i].Address1;
                        AddressBox2.Text = Liste.Carnet[i].Address2;
                        CityBox.Text = Liste.Carnet[i].City;
                        StateBox.Text = Liste.Carnet[i].State;
                        ZipBox.Text = Liste.Carnet[i].Zip;
                        CountryBox.Text = Liste.Carnet[i].Country;
                    }

                }
            }
        }

        private void Cleared()
        {
            FirstNBox.Clear();
            LastNBox.Clear();
            MiddleNBox.Clear();
            PhoneBox.Clear();
            EmailBox.Clear();
            AddressBox1.Clear();
            AddressBox2.Clear();
            CityBox.Clear();
            StateBox.Clear();
            ZipBox.Clear();
            CountryBox.Clear();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Liste.Carnet.Count; i++)
            {
                if (listContact.SelectedItem.ToString() == Liste.Carnet[i].ToString())
                {
                    Liste.Carnet[i].FirstName = FirstNBox.Text;
                    Liste.Carnet[i].LastName = LastNBox.Text;
                    Liste.Carnet[i].MiddleName = MiddleNBox.Text;
                    Liste.Carnet[i].Phone = PhoneBox.Text;
                    Liste.Carnet[i].Email = EmailBox.Text;
                    Liste.Carnet[i].Address1 = AddressBox1.Text;
                    Liste.Carnet[i].Address2 = AddressBox2.Text;
                    Liste.Carnet[i].City = CityBox.Text;
                    Liste.Carnet[i].State = StateBox.Text;
                    Liste.Carnet[i].Zip = ZipBox.Text;
                    Liste.Carnet[i].Country = CountryBox.Text;

                }

            }
            Utilitaire.UpdateList("Contact.txt", Liste, listContact);
            MessageBox.Show("Modifiaction enregistrée");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
          
            if (listContact.SelectedItem.ToString() != null)
            {
                for (int i = 0; i < Liste.Carnet.Count; i++)
                {
                    if (listContact.SelectedItem == Liste.Carnet[i])
                    {
                        Utilitaire.Retirer(Liste, Liste.Carnet[i]);
                    }
                }
            }
            Cleared();
            Utilitaire.UpdateList("Contact.txt", Liste, listContact);

        }

   
    }
}
