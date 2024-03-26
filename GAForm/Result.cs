using ScottPlot;
using System;
using System.Windows.Forms.DataVisualization.Charting;

namespace GAForm
{
    public partial class Result : Form
    {
        static Random random = new Random();
        private List<double> bestFitnessValues;


        public Result()
        {
            InitializeComponent();
            bestFitnessValues = new List<double>();

            formsPlot1.Plot.Axes.Title.Label.ForeColor = Colors.White;
            formsPlot1.Plot.Axes.Title.Label.FontName = Fonts.Sans;
            formsPlot1.Plot.XLabel("Generation");
            formsPlot1.Plot.Axes.Left.Label.ForeColor = Colors.White;
            formsPlot1.Plot.Axes.Left.Label.FontName = Fonts.Sans;
            formsPlot1.Plot.YLabel("Fitness");
            formsPlot1.Plot.Axes.Bottom.Label.ForeColor = Colors.White;
            formsPlot1.Plot.Axes.Bottom.Label.FontName = Fonts.Sans;
            formsPlot1.Plot.Title("Convergence");
            formsPlot1.Plot.Axes.Color(Colors.White);
            formsPlot1.Plot.DataBackground.Color = ScottPlot.Color.FromHex("#343F56");

        }


        private void Result_load(object sender, EventArgs e)
        {

        }
        static List<DNA> InitializePopulation(int populationSize)
        {
            List<DNA> population = new List<DNA>();

            for (int i = 0; i < populationSize; i++)
            {
                double x = random.NextDouble() * 9 - 4.5;
                double y = random.NextDouble() * 9 - 4.5;

                DNA DNA = new DNA(x, y);
                population.Add(DNA);
            }

            return population;
        }

        static List<DNA> EvolvePopulation(List<DNA> population, float crossoverRate, float mutationRate, int eliteSize)
        {
            List<DNA> newPopulation = new List<DNA>();

            population = population.OrderBy(DNA => DNA.Fitness).ToList();

            for (int i = 0; i < eliteSize; i++)
            {
                newPopulation.Add(population[i]);
            }

            while (newPopulation.Count < population.Count)
            {
                DNA parent1 = SelectParent(population);
                DNA parent2 = SelectParent(population);

                DNA child = Crossover(parent1, parent2, crossoverRate);

                Mutate(child, mutationRate);

                newPopulation.Add(child);
            }

            return newPopulation;
        }

        static DNA SelectParent(List<DNA> population)
        {
            int tournamentSize = 4;

            List<DNA> tournamentParticipants = new List<DNA>();

            for (int i = 0; i < tournamentSize; i++)
            {
                int randomIndex = random.Next(population.Count);
                tournamentParticipants.Add(population[randomIndex]);
            }

            DNA winner = tournamentParticipants.OrderBy(DNA => DNA.Fitness).First();
            return winner;
        }


        static DNA Crossover(DNA parent1, DNA parent2, float crossoverRate)
        {
            if (random.NextDouble() < crossoverRate)
            {
                double crossoverPoint = random.NextDouble();
                double x = parent1.X * crossoverPoint + parent2.X * (1 - crossoverPoint);
                double y = parent1.Y * crossoverPoint + parent2.Y * (1 - crossoverPoint);

                return new DNA(x, y);
            }
            else
            {
                return parent1;
            }
        }
        static void Mutate(DNA DNA, float mutationRate)
        {
            if (random.NextDouble() < mutationRate)
            {
                DNA.X += random.NextDouble() * 0.2 - 0.1;
                DNA.X = Math.Max(-4.5, Math.Min(4.5, DNA.X));
                DNA.Y += random.NextDouble() * 0.2 - 0.1;
                DNA.Y = Math.Max(-4.5, Math.Min(4.5, DNA.Y));
            }
        }
        private void ExecBtn_Click(object sender, EventArgs e)
        {
            //int populationSize = Convert.ToInt32(PoptxtBox.Text);
            //int generations = Convert.ToInt32(GentxtBox.Text);
            //int eliteSize = Convert.ToInt32(ElitetxtBox.Text);
            //float crossoverRate = Convert.ToSingle(CrossovertxtBox.Text);
            //float mutationRate = Convert.ToSingle(MuttxtBox.Text);

            //int populationSize = 50;
            //int generations = 250;
            //float crossoverRate = 0.7f;
            //float mutationRate = 0.4f;
            //int eliteSize = 4;


            int populationSize;
            int generations;
            int eliteSize;
            float crossoverRate;
            float mutationRate;

            if (!int.TryParse(PoptxtBox.Text, out populationSize) || string.IsNullOrWhiteSpace(PoptxtBox.Text))
            {
                MessageBox.Show("Error: Population size must be a non-empty integer.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!float.TryParse(CrossovertxtBox.Text, out crossoverRate) || string.IsNullOrWhiteSpace(CrossovertxtBox.Text))
            {
                MessageBox.Show("Error: Crossover rate must be a non-empty float.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!float.TryParse(MuttxtBox.Text, out mutationRate) || string.IsNullOrWhiteSpace(MuttxtBox.Text))
            {
                MessageBox.Show("Error: Mutation rate must be a non-empty float.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(ElitetxtBox.Text, out eliteSize) || string.IsNullOrWhiteSpace(ElitetxtBox.Text))
            {
                MessageBox.Show("Error: Elite size must be a non-empty integer.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(GentxtBox.Text, out generations) || string.IsNullOrWhiteSpace(GentxtBox.Text))
            {
                MessageBox.Show("Error: Generations must be a non-empty integer.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //chart1.Series["Fitness"].Points.Clear();

            List<DNA> population = InitializePopulation(populationSize);

            population = EvolvePopulation(population, crossoverRate, mutationRate, eliteSize);



            for (int i = 0; i < generations; i++)
            {
                population = EvolvePopulation(population, crossoverRate, mutationRate, eliteSize);

                double bestFitness = population.Min(DNA => DNA.Fitness);
                bestFitnessValues.Add(bestFitness);

                //chart1.Series["Fitness"].Points.AddXY(i, bestFitness);

                formsPlot1.Plot.Axes.SetLimits(0, 10, -0.0001, 0.0001);
                formsPlot1.Plot.Axes.AutoScaleExpand();
                //formsPlot1.Plot.Add.Scatter(i, bestFitness); //Scatter

                formsPlot1.Plot.Add.Signal(bestFitnessValues); //Wave
                formsPlot1.Refresh();
            }

            //dataGridView1.DataSource = population; //Kontrol

            var bestSolution = population.OrderBy(DNA => DNA.Fitness).First();
            BestGenesX.Text = $"{bestSolution.X}";
            BestGenesY.Text = $"{bestSolution.Y}";
            BestGeneFitVal.Text = $"{bestSolution.Fitness}";
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }


    class DNA : IComparable<DNA>
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Fitness { get; private set; }

        public DNA(double x, double y)
        {
            X = x;
            Y = y;
            CalculateFitness();
        }

        private void CalculateFitness()
        {
            double result = Math.Pow((1.5 - X + X * Y), 2) + Math.Pow((2.25 - X + X * Math.Pow(Y, 2)), 2) + Math.Pow((2.625 - X + X * Math.Pow(Y, 3)), 2);
            //Fitness = 1 / result;
            Fitness = result;
        }

        public int CompareTo(DNA other)
        {
            if (other == null)
                return 1;
            return Fitness.CompareTo(other.Fitness);
        }

    }
}





