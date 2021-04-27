using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassicalNeuralNetworksLibrary.Schemas
{
    public class OutputLayer
    {
        public Dataset data { get; set; }
        public NetworkLayer lastHiddenLayer { get; set; }
        public double[] softmax()
        {
            double[] ProbabilityDistribution = new double[lastHiddenLayer.neurons.Count];
            double sum = 0.0;
            foreach(Neuron neuron in lastHiddenLayer.neurons)
            {
                double neuronOut = Math.Pow(Math.E, neuron.output);
                sum += neuronOut;
            }
            int p = 0;
            foreach (Neuron neuron in lastHiddenLayer.neurons)
            {
                double neuronOut = Math.Pow(Math.E, neuron.output);
                ProbabilityDistribution[p] = neuronOut / sum;
                p += 1;
            }
            Console.WriteLine(String.Join(", ", ProbabilityDistribution));
            return ProbabilityDistribution;
        }
        public double loss()
        {
            int index = 0, it = 0;
            foreach(int o in this.data.output)
            {
                if(o>0)
                {
                    index = it;
                }
                it += 1;
            }
            return -1 * Math.Log(data.inputs[index]);
        }

    }
}
