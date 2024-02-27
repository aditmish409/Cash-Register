using System;
using System.Text;
using System.Drawing;
using System.Data;
using System.Threading.Tasks;
using System.Linq;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace Cash_Register
{
    public partial class Form1 : Form
    { 
        double sneakerPrice = 120;
        double slidePrice = 80;
        double bootPrice = 100;
        int numOfSneakers = 0;
        int numOfSlides = 0;
        int numOfBoots = 0;
        double taxRate = 0.13;
        double subTotal = 0;
        double taxAmount = 0;
        double totalPrice = 0;
        double tendered = 0;
        double change = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void calculateTotalsbutton_Click(object sender, EventArgs e)
        {
            try
            {
                numOfSneakers = Convert.ToInt16(sneakersInput.Text);
                numOfSlides = Convert.ToInt16(slidesInput.Text);
                numOfBoots = Convert.ToInt16(bootsInput.Text);

                subTotal = sneakerPrice * numOfSneakers + slidePrice * numOfSlides + bootPrice * numOfBoots;
                subtotalOutput.Text = $"{subTotal.ToString("C")}";

                taxAmount = subTotal * taxRate;
                taxOutput.Text = $"{taxAmount.ToString("C")}";

                totalPrice = subTotal + taxAmount;
                totalOutput.Text = $"{totalPrice.ToString("C")}";

                SoundPlayer player = new SoundPlayer(Properties.Resources.Mouse_Click);
                player.Play();
            }

            catch
            {
                subTotal = sneakerPrice * numOfSneakers + slidePrice * numOfSlides + bootPrice * numOfBoots;
                subtotalOutput.Text = $"{subTotal.ToString("Error")}";

                taxAmount = subTotal * taxRate;
                taxOutput.Text = $"{taxAmount.ToString("Error")}";

                totalPrice = subTotal + taxAmount;
                totalOutput.Text = totalPrice.ToString("Error");

                SoundPlayer player = new SoundPlayer(Properties.Resources.Error);
                player.Play();
            }

            }

        private void calculateChangebutton_Click(object sender, EventArgs e)
        {
            try
            {
                tendered = Convert.ToDouble(tenderedInput.Text);

                change = tendered - totalPrice;
                changeOutput.Text = $"{change.ToString("C")}";

                SoundPlayer player = new SoundPlayer(Properties.Resources.Cha_Ching);
                player.Play();

                if (tendered < totalPrice)
                {
                    changeOutput.Text = "No Funds";

                    SoundPlayer player2 = new SoundPlayer(Properties.Resources.Error);
                    player2.Play();
                }
            }

            catch
            {
                change = tendered - totalPrice;
                changeOutput.Text = $"{change.ToString("Error")}";

                SoundPlayer player2 = new SoundPlayer(Properties.Resources.Error);
                player2.Play();
            }
            }

        private void printReceiptbutton_Click(object sender, EventArgs e)
        {
            this.Size = new Size(816, 673);

            receiptOutput.Text = $"                       Foot 4 Life!";
            receiptOutput.Text += $"\n\nOrder Number 2110";
            receiptOutput.Text += $"\nFebruary 23, 2024";
            receiptOutput.Text += $"\n\nSneakers                x{numOfSneakers} @                  ${sneakerPrice}";
            receiptOutput.Text += $"\nSlides                    x{numOfSlides} @                  ${slidePrice}";
            receiptOutput.Text += $"\nBoots                    x{numOfBoots} @                  ${bootPrice}";
            receiptOutput.Text += $"\n\nSubtotal                                         ${subTotal}";
            receiptOutput.Text += $"\nTax                                                ${taxAmount}";
            receiptOutput.Text += $"\nTotal                                             ${totalPrice}";
            receiptOutput.Text += $"\n\nTendered                                      ${tendered}";
            receiptOutput.Text += $"\nChange                                      {change.ToString("C")}";
            receiptOutput.Text += $"\n\nThank You for Buying From Foot 4 Less!";
            SoundPlayer player = new SoundPlayer(Properties.Resources.Print_Receipt);
            player.Play();
           
            if (numOfBoots > 10 || numOfSlides > 10 || numOfSneakers > 10)
            {
                receiptOutput.Text = $"    YOUR SHOES ARE FLYING AWAY!";
            }
            
            if (numOfSneakers < 1)
            {
                receiptOutput.Text = $"                       Foot 4 Life!";
                receiptOutput.Text += $"\n\nOrder Number 2110";
                receiptOutput.Text += $"\nFebruary 23, 2024";
                receiptOutput.Text += $"\n\n";
                receiptOutput.Text += $"\nSlides                    x{numOfSlides} @                  ${slidePrice}";
                receiptOutput.Text += $"\nBoots                    x{numOfBoots} @                  ${bootPrice}";
                receiptOutput.Text += $"\n\nSubtotal                                         ${subTotal}";
                receiptOutput.Text += $"\nTax                                                ${taxAmount}";
                receiptOutput.Text += $"\nTotal                                             ${totalPrice}";
                receiptOutput.Text += $"\n\nTendered                                      ${tendered}";
                receiptOutput.Text += $"\nChange                                      {change.ToString("C")}";
                receiptOutput.Text += $"\n\nThank You for Buying From Foot 4 Less!";
            }

            if (numOfBoots < 1)
            {
                receiptOutput.Text = $"                       Foot 4 Life!";
                receiptOutput.Text += $"\n\nOrder Number 2110";
                receiptOutput.Text += $"\nFebruary 23, 2024";
                receiptOutput.Text += $"\n\nSneakers                x{numOfSneakers} @                  ${sneakerPrice}";
                receiptOutput.Text += $"\nSlides                    x{numOfSlides} @                  ${slidePrice}";
                receiptOutput.Text += $"\n";
                receiptOutput.Text += $"\n\nSubtotal                                         ${subTotal}";
                receiptOutput.Text += $"\nTax                                                ${taxAmount}";
                receiptOutput.Text += $"\nTotal                                             ${totalPrice}";
                receiptOutput.Text += $"\n\nTendered                                      ${tendered}";
                receiptOutput.Text += $"\nChange                                      {change.ToString("C")}";
                receiptOutput.Text += $"\n\nThank You for Buying From Foot 4 Less!";
            }

            if (numOfSlides < 1)
            {
                receiptOutput.Text = $"                       Foot 4 Life!";
                receiptOutput.Text += $"\n\nOrder Number 2110";
                receiptOutput.Text += $"\nFebruary 23, 2024";
                receiptOutput.Text += $"\n\nSneakers                x{numOfSneakers} @                  ${sneakerPrice}";
                receiptOutput.Text += $"\n";
                receiptOutput.Text += $"\nBoots                    x{numOfBoots} @                  ${bootPrice}";
                receiptOutput.Text += $"\n\nSubtotal                                         ${subTotal}";
                receiptOutput.Text += $"\nTax                                                ${taxAmount}";
                receiptOutput.Text += $"\nTotal                                             ${totalPrice}";
                receiptOutput.Text += $"\n\nTendered                                      ${tendered}";
                receiptOutput.Text += $"\nChange                                      {change.ToString("C")}";
                receiptOutput.Text += $"\n\nThank You for Buying From Foot 4 Less!";
            }
            }

        private void newReceipt_Click(object sender, EventArgs e)
        {
            this.Size = new Size(395, 646);
            sneakersInput.Text = $"";
            slidesInput.Text = $"";
            bootsInput.Text = $"";
            tenderedInput.Text = $"";
            subtotalOutput.Text = $"";
            taxOutput.Text = $"";
            totalOutput.Text = $"";
            changeOutput.Text = $"";
            receiptOutput.Text = $"";
            receiptOutput.Text += $"";
            receiptOutput.Text += $"";
            receiptOutput.Text += $"";
            receiptOutput.Text += $"";
            receiptOutput.Text += $"";
            receiptOutput.Text += $"";
            receiptOutput.Text += $"";
            receiptOutput.Text += $"";
            receiptOutput.Text += $"";
            receiptOutput.Text += $"";
            receiptOutput.Text += $"";
        }
    }
}
