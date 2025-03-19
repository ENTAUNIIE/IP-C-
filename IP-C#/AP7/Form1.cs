namespace AP7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_ip_Click(object sender, EventArgs e)
        {
            // Recupere l'adresse IP depuis le TextBox
            string adressIP = tb_ip.Text;
            global.adressIP = adressIP;

            //divise l'adresse IP en Partie utilisant le point comme délimiteur
            string[] parties = adressIP.Split('.');

            //Verifie s'il y a exactement 4 parties
            if (parties.Length == 4)
            {
                //COnvertie chaque partie en nombre entier
                bool adressValide = true;
                foreach (string part in parties)
                {
                    if (!int.TryParse(part, out int valeur))
                    {
                        adressValide = false;
                        break;
                    }

                    //Verifie que la valeur est entre 0 et 255 
                    if (valeur < 0 || valeur > 255)
                    {
                        adressValide = false;
                        break;
                    }

                }
                if (adressValide)
                {

                    string cidr = tb_cidr.Text;
                    global.cidr = cidr;

                    // Tente de convertir la valeur du CIDR en un entier (int)
                    // Vérifie si la conversion réussit et si la valeur est entre 0 et 32 inclus
                    if (int.TryParse(cidr, out int cidrValeur) && cidrValeur >= 0 && cidrValeur <= 32)
                    {

                        MessageBox.Show("Adresse IP Valide avec CIDR");
                    }
                    else
                    {
                        tb_ip.Clear();
                        tb_cidr.Clear();
                        MessageBox.Show("Adresse IP avec CIDR non valide . Veuillez verifier les valeurs");
                    }
                    // Convertir chaque partie de l'adresse IP en binaire
                    string adresseIPBinaire = "";
                    foreach (string part in parties)
                    {
                        int valeur = int.Parse(part);
                        string binaire = Convert.ToString(valeur, 2).PadLeft(8, '0');
                        adresseIPBinaire += binaire;
                    }

                    // Afficher le résultat dans la textbox adresse binaire 
                    tb_binaire.Text = adresseIPBinaire;




                }




                else
                {
                    tb_ip.Clear();
                    MessageBox.Show("Adresse IP non Valide. Veuillez verifier les valeurs ");

                }
                bt_suivant.Enabled = true;


            }

            else
            {
                tb_ip.Clear();
                MessageBox.Show("L'adresse IP doit contenir 4 parties");
            }

        }

        private void tb_ip_TextChanged(object sender, EventArgs e)
        {
            if (tb_ip.Text != "" && tb_cidr.Text != "")
            {
                bt_ip.Enabled = true;
            }
        }

        private void tb_cidr_TextChanged(object sender, EventArgs e)
        {
            if (tb_ip.Text != "" && tb_cidr.Text != "")
            {
                bt_ip.Enabled = true;
            }
        }

        private void bt_suivant_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();





        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tb_cidr.Clear();
            tb_ip.Clear();
            tb_binaire.Clear();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}




//// Ressource utilisé
///stackoverflow.com
///learn.microsoft.com
///chatgpt
///medium.com
///openclassroom.com

