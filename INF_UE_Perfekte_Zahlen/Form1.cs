using System.Text;

namespace INF_UE_Perfekte_Zahlen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            List<int> pA = new List<int>();
            List<int> pB = new List<int>();
            List<int> pC = new List<int>();
              List<int> pD = new List<int>();
              List<int> pE = new List<int>();
           

            for (int i = 1; i <= 10000; i++)
            {

                int sum = 0;
                for (int j = 1; j < i; j++)
                {
                    if (i % j == 0) sum += j;
                }

                //i+2  (Punkt a)
                int h1 = sum + 2;
                if (h1 == i)// pA.Add(i);
                    lbOa.Items.Add(i);


                //i+1  (Punkt b) 
                int h2 = sum + 1;
                if (h2 == i) //pB.Add(i);
                    lbOb.Items.Add(i);


                //Perfekte Zahlen (Punkt c)
                if (sum == i)
                {
                    pC.Add(i);
                    lbOutput.Items.Add(i);
                }

                //i-1  (Punkt d) 
                int h3 = sum - 1;
                if (h3 == i) //pD.Add(i);
                    lbOd.Items.Add(i);


                //i-2  (Punkt e) 
                int h4 = sum - 2;
                if (h4 == i) //pE.Add(i);
                    lbOe.Items.Add(i);



            }

        
            

        }
    }
}
