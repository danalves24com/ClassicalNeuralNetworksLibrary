using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassicalNeuralNetworksLibrary.Schemas
{
    public class Neuron
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
                this.output += produc>0?produc:0.0;
                index += 1;
            }



            return output;
        }


        public double optimizeWeights()
        {
            double localDerivative = 0.0;

            return 0.01;
        }


        public Neuron(double[] weights, double bias)
        {
            this.weights = weights;
            this.bias = bias;
        }


        public Neuron init(int dims)
        {
            this.weights = new double[dims];
            int index = 0;
            foreach(double w in weights)
            {
                weights[index] = new Random().NextDouble();
                index += 1;
            }
            this.bias = 0;
            return this;
        }

        public Neuron()
        {

        }


    }
}
