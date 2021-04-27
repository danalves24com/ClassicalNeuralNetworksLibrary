using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassicalNeuralNetworksLibrary.Schemas
{
    public class InputLayer
    {
        public double[] inputs { get; set; }

        public InputLayer(double[] inputs)
        {
            this.inputs = inputs;
        }
    }
}
