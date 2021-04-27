using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassicalNeuralNetworksLibrary.Schemas
{
    public class Dataset
    {
        public double[] inputs;
        public double[] output;

        public Dataset(double[] inputs, double[] output)
        {
            this.inputs = inputs;
            this.output = output;
        }
    }
}
