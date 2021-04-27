using PowerArgs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassicalNeuralNetworksLibrary.Schemas
{
    public class NetworkLayer
    {
        public int inputSize { get; set; } = 1;
        public int size { get; set; } = 1;

        public double[] inputs { get; set; }
        public double[] outputs { get; set; }

        public List<Neuron> neurons { get; set; }

        public NetworkLayer(int inputSize, int size)
        {
            neurons = new List<Neuron>();
            this.inputSize = inputSize;
            this.size = size;
            this.inputs = inputs;
            for(int d = 0;d < size;d+=1)
            {
                neurons.Add(new Neuron().init(inputSize));
            }
        }


        public void log()
        {

           
            

        }

        public void forward(double[] inputs)
        {
            this.inputs = inputs;
            outputs = new double[this.neurons.Count];

            int i = 0;
            foreach(Neuron neuron in this.neurons)
            {
                neuron.pass(inputs);
                outputs[i] = neuron.output;
                i += 1;
            }
            this.log();
        }

    }
}
