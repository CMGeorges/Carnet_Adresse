using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carnet_Adresse
{
	internal static class ManipFichier
    {
		


		public static void Lecture(string v, ListeDeContact listing)
		{
			StreamReader reader = null;
			try
			{
				//Lire le fichier source avec l'utilisation d'un streamreader
				reader = new StreamReader(v);
				string data = null;
				//int t;
				//while((t = reader.Read()) != -1)//charractère par charactère
				while ((data = reader.ReadLine()) != null)
				{
					//Console.Write((char)t);
					//Console.WriteLine(data);
					Contact C1 = Utilitaire.ParseLigne(data);
					listing.AjouterContact(C1);
					//Utilitaire.Ajouter(listing, C1);

				}
            }
            catch (FileNotFoundException e)
            {
				MessageBox.Show("Erreur fichier");
            }
			catch (IOException e)
			{
				MessageBox.Show("Erreur fichier");

			}
			finally
			{
				if (reader != null)
				{
					reader.Close();
				}
			}
		}

		internal static void Ecriture(string v, ListeDeContact list)
		{
			//Ecriture de fichier en sortir StreamWriter
			StreamWriter writer = null;
			

			try
			{

				writer = new StreamWriter(v);
				//Ecriture
				foreach (Contact item in list.Carnet)
				{
					writer.WriteLine(Utilitaire.FormerLigne(item));
				}


			}
			catch (IOException e)
			{

				MessageBox.Show(e.Message);
			}
			finally
			{
				if (writer != null)
				{
					writer.Close();
				}
			}
		}
	}
}
