using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassicalNeuralNetworksLibrary.Schemas
{
    class Neuron
    {
        public double[] weights { get; set; }
        public double output { get; set; }
        public double bias { get; set; }
        public double pass(double[] inputs)
        {
            this.output = this.bias;
            int index = 0;
            foreach(double inp in inputs)
            {
                double produc = inp * weights[index];
                this.output += produc;
                index += 1;
            }

            return output;
        }

        public Neuron(double[] weights, double bias)
        {
            this.weights = weights;
            this.bias = bias;
        }


        public void init(int dims)
        {
            this.weights = new double[dims];
            this.bias = 0;
        }

        public Neuron()
        {

        }


    }
}
