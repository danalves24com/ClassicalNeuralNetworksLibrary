using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassicalNeuralNetworksLibrary.Schemas
{
    public class NeuralNetworkModel
    {
        public InputLayer inputLayer { get; set; }
        public NetworkLayer[] hiddenLayers {get;set;}
        public OutputLayer outputLayer { get; set; }

        public NeuralNetworkModel(InputLayer inputLayer, NetworkLayer[] hiddenLayers, OutputLayer outputLayer)
        {
            this.inputLayer = inputLayer;
            this.hiddenLayers = hiddenLayers;
            this.outputLayer = outputLayer;
        }

        public void Run()
        {

        }

    }
}
