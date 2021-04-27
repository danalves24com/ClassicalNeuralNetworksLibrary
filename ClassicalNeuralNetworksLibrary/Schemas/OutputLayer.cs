using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassicalNeuralNetworksLibrary.Schemas
{
    public class OutputLayer
    {
        public NetworkLayer lastHiddenLayer { get; set; }
        public double[] softmax()
        {
            double[] ProbabilityDistribution = new double[lastHiddenLayer.neurons.Count];
            double sum = 0.0;
            foreach(Neuron neuron in lastHiddenLayer.neurons)
            {
                double neuronOut = neuron.output;
                sum += neuronOut;
            }
            int p = 0;
            foreach (Neuron neuron in lastHiddenLayer.neurons)
            {
                double neuronOut = neuron.output;
                ProbabilityDistribution[p] = neuronOut / sum;
                p += 1;
            }
            return ProbabilityDistribution;
        }

    }
}
