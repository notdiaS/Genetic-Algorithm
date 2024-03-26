using System;
using System.Collections.Generic;
using System.Linq;

namespace GeneticAlgorithm
{
    class Program
    {
        static Random random = new Random();

        static void Main(string[] args)
        {
            int populationSize = 10;
            int generations = 1000;
            float crossoverRate = 0.7f;
            float mutationRate = 0.1f;

            List<Chromosome> population = InitializePopulation(populationSize);

            for (int i = 0; i < generations; i++)
            {
                population = EvolvePopulation(population, crossoverRate, mutationRate);
                Console.WriteLine($"Generation {i + 1}, Best Fitness: {population[0].Fitness}");
            }

            Console.WriteLine($"Best solution found: x = {population[0].X}, y = {population[0].Y}");
        }

        static List<Chromosome> InitializePopulation(int populationSize)
        {
            List<Chromosome> population = new List<Chromosome>();

            for (int i = 0; i < populationSize; i++)
            {
                double x = random.NextDouble() * 9 - 4.5; // -4.5 ile 4.5 arasında rastgele bir x değeri seç
                double y = random.NextDouble() * 9 - 4.5; // -4.5 ile 4.5 arasında rastgele bir y değeri seç

                Chromosome chromosome = new Chromosome(x, y); // x ve y değerleriyle yeni bir kromozom oluştur
                population.Add(chromosome);
            }

            return population;
        }


        static List<Chromosome> EvolvePopulation(List<Chromosome> population, float crossoverRate, float mutationRate)
        {
            List<Chromosome> newPopulation = new List<Chromosome>();

            population.Sort();

            int eliteSize = 2;

            for (int i = 0; i < eliteSize; i++)
            {
                newPopulation.Add(population[i]);
            }

            while (newPopulation.Count < population.Count)
            {
                Chromosome parent1 = SelectParent(population);
                Chromosome parent2 = SelectParent(population);

                Chromosome child = Crossover(parent1, parent2, crossoverRate);

                Mutate(child, mutationRate);

                newPopulation.Add(child);
            }

            return newPopulation;
        }

        static Chromosome SelectParent(List<Chromosome> population)
        {
            double totalFitness = population.Sum(chromosome => chromosome.Fitness);
            double randomNumber = random.NextDouble() * totalFitness;

            double cumulativeProbability = 0;
            foreach (var chromosome in population)
            {
                cumulativeProbability += chromosome.Fitness;
                if (cumulativeProbability > randomNumber)
                {
                    return chromosome;
                }
            }

            return population.Last();
        }

        static Chromosome Crossover(Chromosome parent1, Chromosome parent2, float crossoverRate)
        {
            if (random.NextDouble() < crossoverRate)
            {
                double crossoverPoint = random.NextDouble(); // Random crossover point
                double x = parent1.X * crossoverPoint + parent2.X * (1 - crossoverPoint);
                double y = parent1.Y * crossoverPoint + parent2.Y * (1 - crossoverPoint);

                return new Chromosome(x, y);
            }
            else
            {
                return parent1; // No crossover
            }
        }

        static void Mutate(Chromosome chromosome, float mutationRate)
        {
            if (random.NextDouble() < mutationRate)
            {
                chromosome.X += random.NextDouble() * 0.2 - 0.1; // Mutate x
                chromosome.X = Math.Max(-4.5, Math.Min(4.5, chromosome.X)); // X değerini -4.5 ve 4.5 arasında sınırla
                chromosome.Y += random.NextDouble() * 0.2 - 0.1; // Mutate y
                chromosome.Y = Math.Max(-4.5, Math.Min(4.5, chromosome.Y)); // Y değerini -4.5 ve 4.5 arasında sınırla
            }
        }
    }

    class Chromosome : IComparable<Chromosome>
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Fitness { get; private set; }

        public Chromosome(double x, double y)
        {
            X = x;
            Y = y;
            CalculateFitness();
        }

        private void CalculateFitness()
        {
            // Example fitness function: Minimizing the function f(x,y) = (1.5 - x + x*y)^2 + (2.25 - x +x*y^2)^2 + (2.625 - x + x*y^3)^2
            double result = Math.Pow((1.5 - X + X * Y), 2) + Math.Pow((2.25 - X + X * Math.Pow(Y, 2)), 2) + Math.Pow((2.625 - X + X * Math.Pow(Y, 3)), 2);
            Fitness = 1 / result; // Minimizing fitness, so taking inverse
        }

        public int CompareTo(Chromosome other)
        {
            // Sort chromosomes by fitness in descending order
            if (other == null)
                return 1;
            return Fitness.CompareTo(other.Fitness);
        }
    
    }
}
