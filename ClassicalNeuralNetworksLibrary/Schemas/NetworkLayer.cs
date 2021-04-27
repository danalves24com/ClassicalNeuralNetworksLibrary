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
            DataTable table = new DataTable();
            table.Columns.Add("inputs");
            table.Columns.Add("outputs");

            int i = 0;
            foreach(double input in this.inputs)
            {
                DataRow row = table.NewRow();
                row[0] = input;
                row[1] = neurons[i].output;
                Console.WriteLine("{0} ==> {1}", input, neurons[i].output);
                table.Rows.Add(row);
                i += 1;
            }

            Console.WriteLine(table.ToString());

        }

        public void forward(double[] inputs)
        {
            this.inputs = inputs;
            foreach(Neuron neuron in this.neurons)
            {
                neuron.pass(inputs);
            }
            this.log();
        }

    }
}
