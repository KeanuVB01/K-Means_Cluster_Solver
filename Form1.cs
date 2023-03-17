namespace K_Means_Clustering_Solver
{
    public partial class Form1 : Form
    {
        double[,] datapoints = new double[20,2];
        int count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                double x = double.Parse(txtXPoint.Text);
                double y = double.Parse(txtYPoint.Text);

                datapoints[count,0] = x;
                datapoints[count,1] = y;

                count++;

                lblCurrent.Text = "Current: "+count.ToString();
                lbxPoints.Items.Add(count.ToString() + ")  ("+x.ToString()+";"+y.ToString()+")");


            }
            catch ( FormatException fm)
            {
                MessageBox.Show("Please enter a valid data point");
                return;
            }
            catch( Exception ex )
            {
                MessageBox.Show(ex.Message);
            }

            if (count == 20) { btnAdd.Enabled = false; }
            if (count >= 2) { btnSolve.Enabled = true; }
            txtXPoint.Clear();
            txtYPoint.Clear();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            count = 0;
            lbxPoints.Items.Clear();
            lblCurrent.Text = "Current: 0";
            rtxtOutput.Clear();
            txtXPoint.Clear();
            txtYPoint.Clear();
            btnAdd.Enabled = true;
            btnSolve.Enabled = false;

            for (int i=0;i<=count;i++)
            {
                for(int j=0;j<2;j++)
                {
                    datapoints[i, j] = 0;
                }
            }
            
        }

        private void btnSolve_Click(object sender, EventArgs e)
        {
            rtxtOutput.Clear();

            //Calculate Distance Matrix
            Double[,] d1 = new Double[20,2];
            Double[,] d2 = new Double[20, 2];
            int[,] g1 = new int[20, 2];
            int[,] g2 = new int[20, 2];
            Double[] c1 = new double[2];
            Double[] c2 = new double[2];

            c1[0] = datapoints[0, 0];
            c1[1] = datapoints[0, 1];
            c2[0] = datapoints[1, 0];
            c2[1] = datapoints[1, 1];


            //0=x-axis 1=y-axis

            double c10CalculationTop, c11CalculationTop, c20CalculationTop, c21CalculationTop;
            double c10CalculationBottom, c11CalculationBottom, c20CalculationBottom, c21CalculationBottom;

            bool exit = false;
            bool firstLoop = false;
            int endCount = 0;

            while (!exit)
            {
                if (!firstLoop)
                {
                    rtxtOutput.AppendText("\n\nIteration " + endCount.ToString());
                    rtxtOutput.AppendText("\n==============================");
                    rtxtOutput.AppendText("\nc1 = " + c1[0].ToString() + ";" + c1[1]);
                    rtxtOutput.AppendText("\nc2 = " + c2[0].ToString() + ";" + c2[1]);
                }
                
                for (int i = 0; i < count; i++)
                {

                    double d10Bracket1 = Math.Pow((datapoints[i, 0] - c1[0]), 2);
                    double d10Bracket2 = Math.Pow((datapoints[i, 1] - c1[1]), 2);
                    double d10BracketSum = d10Bracket1 + d10Bracket2;
                    d1[i, 0] = Math.Sqrt(d10BracketSum);

                    double d11Bracket1 = Math.Pow((datapoints[i, 0] - c2[0]), 2);
                    double d11Bracket2 = Math.Pow((datapoints[i, 1] - c2[1]), 2);
                    double d11BracketSum = d11Bracket1 + d11Bracket2;
                    d1[i, 1] = Math.Sqrt(d11BracketSum);

                    if (d1[i, 0] < d1[i, 1])
                    {
                        g1[i, 0] = 1;
                        g1[i, 1] = 0;
                    }
                    else
                    {
                        g1[i, 0] = 0;
                        g1[i, 1] = 1;
                    }
                }

                if (firstLoop)
                {
                    int countDiff1 = 0;
                    for(int i = 0; i < count; i++)
                    {
                        if (g1[i,0] != g2[i, 0]) { countDiff1++; }
                        if (g1[i, 1] != g2[i, 1]) { countDiff1++; }
                    }

                    if (countDiff1==0) { exit = true; }
                }

                endCount++;

                c10CalculationTop = 0;
                c11CalculationTop = 0;
                c20CalculationTop = 0;
                c21CalculationTop = 0;

                c10CalculationBottom = 0;
                c11CalculationBottom = 0;
                c20CalculationBottom = 0;
                c21CalculationBottom = 0;

                for (int i = 0; i < count; i++)
                {
                    if (g1[i, 0] == 0)
                    {
                        c20CalculationBottom++;
                        c21CalculationBottom++;
                        c20CalculationTop += datapoints[i, 0];
                        c21CalculationTop += datapoints[i, 1];
                    }
                    else
                    {
                        c10CalculationBottom++;
                        c11CalculationBottom++;
                        c10CalculationTop += datapoints[i, 0];
                        c11CalculationTop += datapoints[i, 1];
                    }
                }

                c1[0] = c10CalculationTop / c10CalculationBottom;
                c1[1] = c11CalculationTop / c11CalculationBottom;
                c2[0] = c20CalculationTop / c20CalculationBottom;
                c2[1] = c21CalculationTop / c21CalculationBottom;
                rtxtOutput.AppendText("\n\nIteration " + endCount.ToString());
                rtxtOutput.AppendText("\n==============================");
                rtxtOutput.AppendText("\nc1 = " + c1[0].ToString() + ";" + c1[1]);
                rtxtOutput.AppendText("\nc2 = " + c2[0].ToString() + ";" + c2[1]);

                firstLoop= true;

                for (int i = 0; i < count; i++)
                {
                    double d20Bracket1 = Math.Pow((datapoints[i, 0] - c1[0]), 2);
                    double d20Bracket2 = Math.Pow((datapoints[i, 1] - c1[1]), 2);
                    double d20BracketSum = d20Bracket1 + d20Bracket2;
                    d2[i, 0] = Math.Sqrt(d20BracketSum);

                    double d21Bracket1 = Math.Pow((datapoints[i, 0] - c2[0]), 2);
                    double d21Bracket2 = Math.Pow((datapoints[i, 1] - c2[1]), 2);
                    double d21BracketSum = d21Bracket1 + d21Bracket2;
                    d2[i, 1] = Math.Sqrt(d21BracketSum);

                    if (d2[i, 0] < d2[i, 1])
                    {
                        g2[i, 0] = 1;
                        g2[i, 1] = 0;
                    }
                    else
                    {
                        g2[i, 0] = 0;
                        g2[i, 1] = 1;
                    }
                }

                int countDiff = 0;
                for (int i = 0; i < count; i++)
                {
                    if (g1[i, 0] != g2[i, 0]) { countDiff++; }
                    if (g1[i, 1] != g2[i, 1]) { countDiff++; }
                }

                if (countDiff == 0) { exit = true; }
            }

            c10CalculationTop = 0;
            c11CalculationTop = 0;
            c20CalculationTop = 0;
            c21CalculationTop = 0;

            c10CalculationBottom = 0;
            c11CalculationBottom = 0;
            c20CalculationBottom = 0;
            c21CalculationBottom = 0;

            for (int i = 0; i < count; i++)
            {
                if (g1[i, 0] == 0)
                {
                    c20CalculationBottom++;
                    c21CalculationBottom++;
                    c20CalculationTop += datapoints[i, 0];
                    c21CalculationTop += datapoints[i, 1];
                }
                else
                {
                    c10CalculationBottom++;
                    c11CalculationBottom++;
                    c10CalculationTop += datapoints[i, 0];
                    c11CalculationTop += datapoints[i, 1];
                }
            }

            c1[0] = c10CalculationTop / c10CalculationBottom;
            c1[1] = c11CalculationTop / c11CalculationBottom;
            c2[0] = c20CalculationTop / c20CalculationBottom;
            c2[1] = c21CalculationTop / c21CalculationBottom;

            rtxtOutput.AppendText("\n\nFINAL RESULT");
            rtxtOutput.AppendText("\n=================================");
            rtxtOutput.AppendText("\ng1 = g2");
            rtxtOutput.AppendText("\nc1 = " + c1[0].ToString() + ";" + c1[1]);
            rtxtOutput.AppendText("\nc2 = " + c2[0].ToString() + ";" + c2[1]);

        }
    }
}