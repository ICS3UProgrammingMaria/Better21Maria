using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Better21Maria
{

    public partial class frmBetter21 : Form
    {
        //declare global variables
        int playerTotal = 0, dealerTotal;
        List<Image> listCardImages = new List<Image>();
        Random randomNumGen;


        public frmBetter21()
        {
            InitializeComponent();
            randomNumGen = new Random();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //deal initial cards
            playerTotal = DealCard(ref playerTotal, listCardImages);
            playerTotal = DealCard(ref playerTotal, listCardImages);

            dealerTotal = DealCard(ref dealerTotal, listCardImages);
            dealerTotal = DealCard(ref dealerTotal, listCardImages);

            for (int index = 0; index > listCardImages.Count(); index++)
            {
                listCardImages.RemoveAt(index);
            }

            //populate deck
            listCardImages.Add(Properties.Resources.AC);
            listCardImages.Add(Properties.Resources.AD);
            listCardImages.Add(Properties.Resources.AH);
            listCardImages.Add(Properties.Resources.AS);
            listCardImages.Add(Properties.Resources._2C);
            listCardImages.Add(Properties.Resources._2D);
            listCardImages.Add(Properties.Resources._2H);
            listCardImages.Add(Properties.Resources._2S);
            listCardImages.Add(Properties.Resources._3C);
            listCardImages.Add(Properties.Resources._3D);
            listCardImages.Add(Properties.Resources._3H);
            listCardImages.Add(Properties.Resources._3S);
            listCardImages.Add(Properties.Resources._4C);
            listCardImages.Add(Properties.Resources._4D);
            listCardImages.Add(Properties.Resources._4H);
            listCardImages.Add(Properties.Resources._4S);
            listCardImages.Add(Properties.Resources._5C);
            listCardImages.Add(Properties.Resources._5D);
            listCardImages.Add(Properties.Resources._5H);
            listCardImages.Add(Properties.Resources._5S);
            listCardImages.Add(Properties.Resources._6C);
            listCardImages.Add(Properties.Resources._6D);
            listCardImages.Add(Properties.Resources._6H);
            listCardImages.Add(Properties.Resources._6S);
            listCardImages.Add(Properties.Resources._7C);
            listCardImages.Add(Properties.Resources._7D);
            listCardImages.Add(Properties.Resources._7H);
            listCardImages.Add(Properties.Resources._7S);
            listCardImages.Add(Properties.Resources._8C);
            listCardImages.Add(Properties.Resources._8D);
            listCardImages.Add(Properties.Resources._8H);
            listCardImages.Add(Properties.Resources._8S);
            listCardImages.Add(Properties.Resources._9C);
            listCardImages.Add(Properties.Resources._9D);
            listCardImages.Add(Properties.Resources._9H);
            listCardImages.Add(Properties.Resources._9S);
            listCardImages.Add(Properties.Resources._10C);
            listCardImages.Add(Properties.Resources._10D);
            listCardImages.Add(Properties.Resources._10H);
            listCardImages.Add(Properties.Resources._10S);
            listCardImages.Add(Properties.Resources.JC);
            listCardImages.Add(Properties.Resources.JD);
            listCardImages.Add(Properties.Resources.JH);
            listCardImages.Add(Properties.Resources.JS);
            listCardImages.Add(Properties.Resources.KC);
            listCardImages.Add(Properties.Resources.KD);
            listCardImages.Add(Properties.Resources.KH);
            listCardImages.Add(Properties.Resources.KS);
            listCardImages.Add(Properties.Resources.QC);
            listCardImages.Add(Properties.Resources.QD);
            listCardImages.Add(Properties.Resources.QH);
            listCardImages.Add(Properties.Resources.QS);

        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //creates a new form 
            using (var form1 = new frmBetter21())
            {
                //shows new form and closes old
                Visible = false;
                form1.ShowDialog();
                Close();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private int DealCard(ref int total, List<Image>listCardImages)
        {
            //Declare local variables
            int index, currentTotal = 0;

            //generate a random number between 0 and list length
            index = randomNumGen.Next(1, listCardImages.Count() + 1);
            picCardp1.Image = listCardImages[index];
            picCardp2.Image = listCardImages[index];

            return currentTotal;
            
        }
    }
}
