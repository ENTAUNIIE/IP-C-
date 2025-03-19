using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace AP7
{
    public partial class Form2 : Form
    {
        string adressIP = global.adressIP;
        string cidr = global.cidr;
        string[] CIDR_tab_bin = new string[32];
        int[] CIDR_tab_deci = new int[int.Parse(global.cidr)];
        public Form2()
        {
            InitializeComponent();

        }

        private void tb_cidr2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

            // Recupere le CIDR 
            tb_cidr2.Text = global.cidr;

            // Convertir le CIDR en notation binaire du masque de sous-réseau
            string CIDR_tab_bin = new string('1', int.Parse(cidr)).PadRight(32, '0');

            tb_masque_bin.Text = CIDR_tab_bin;

            // Convertie le tableau binaire en notation décimale
            string masqueDecimal = "";
            for (int i = 0; i < 32; i += 8)
            {
                string octetBinaire = CIDR_tab_bin.Substring(i, 8);

                // Utiliser une conversion manuelle
                int octetDecimal = 0;
                int poids = 128;

                for (int j = 0; j < 8; j++)
                {
                    if (octetBinaire[j] == '1')
                    {
                        octetDecimal += poids;
                    }
                    poids /= 2;
                }

                masqueDecimal += octetDecimal.ToString();
                if (i < 24)
                {
                    masqueDecimal += ".";
                }
            }

            // Affiche la notation décimale du masque de sous-réseau dans la TextBox
            tb_masque_deci.Text = masqueDecimal;

            // affiche l'adresse réseau principale
            string[] adresseIPParts = adressIP.Split('.');
            string[] masqueParts = masqueDecimal.Split('.');

            // Effectuer un ET logique entre chaque octet de l'adresse IP et du masque
            string adresseReseauPrincipale = "";
            for (int i = 0; i < 4; i++)
            { 
                int octetIP = int.Parse(adresseIPParts[i]);
                int octetMasque = int.Parse(masqueParts[i]);
                int octetReseau = octetIP & octetMasque;
                adresseReseauPrincipale += octetReseau.ToString();
                if (i < 3)
                {
                    adresseReseauPrincipale += ".";
                }
            }

            // Afficher l'adresse réseau principale dans la TextBox
            tb_adresse_RP.Text = adresseReseauPrincipale;

            // Calculer et afficher le nombre d'hôtes maximum du sous-réseau
            int bitsHote = 32 - int.Parse(cidr);
            int nbHotesMax = (int)Math.Pow(2, bitsHote) - 1; // Exclure l'adresse réseau et l'adresse de diffusion

            tb_nb_hote.Text = nbHotesMax.ToString();

            // Déterminer la classe de l'adresse IP et l'afficher
            char classeIP = ClasseIP(adressIP);
            tb_classIP.Text = classeIP.ToString();
        }

        public char ClasseIP(string adresseIP)
        {
            string[] octets = adresseIP.Split('.');

            int premierOctet = int.Parse(octets[0]);

            if (premierOctet >= 1 && premierOctet <= 126)
            {
                return 'A';
            }
            else if (premierOctet >= 128 && premierOctet <= 191)
            {
                return 'B';
            }
            else if (premierOctet >= 192 && premierOctet <= 223)
            {
                return 'C';
            }
            else if (premierOctet >= 224 && premierOctet <= 239)
            {
                return 'D';
            }
            else if (premierOctet >= 240 && premierOctet <= 255)
            {
                return 'E';
            }
            else
            {
                return 'I'; // Invalide
            }

        }

        private void bt_calc_Click(object sender, EventArgs e)
        {
            // Récupérer le CIDR initial depuis global.cidr
            int cidrInitial = int.Parse(global.cidr);

            // Récupérer le nombre de sous-réseaux souhaité depuis tb_SR
            if (int.TryParse(tb_SR.Text, out int nbSousReseauxSouhaite) && nbSousReseauxSouhaite > 0)
            {
                // Calculer le nombre de bits nécessaires pour représenter le nombre de sous-réseaux souhaité
                int bitsNecessaires = 1;
                while (Math.Pow(2, bitsNecessaires) < nbSousReseauxSouhaite) // Math.pow = Calcul de puissance
                {
                    bitsNecessaires++;
                }

                // Calculer le nouveau CIDRpppppppppppppppppppppppppppppppppppppppppppppppp
                int nouveauCIDR = cidrInitial + bitsNecessaires;

                // Afficher le nouveau CIDR dans tb_nouvCIDR
                tb_nouvCIDR.Text = nouveauCIDR.ToString();
            }
            else
            {
                // Afficher un message d'erreur si le nombre de sous-réseaux souhaité n'est pas valide
                MessageBox.Show("Veuillez saisir un nombre de sous-réseaux souhaité valide.", "Erreur");
            }
        }

        private void bt_retour_Click(object sender, EventArgs e)
        {
            // Réinitialiser les données

            tb_masque_bin.Clear();
            tb_masque_deci.Clear();
            tb_adresse_RP.Clear();
            tb_nb_hote.Clear();
            tb_classIP.Clear();
            tb_SR.Clear();
            tb_nouvCIDR.Clear();


            // Fermer la Form2
            this.Close();
            Form1 Form1 = new Form1();
            Form1.Show();

        }
    }
}
