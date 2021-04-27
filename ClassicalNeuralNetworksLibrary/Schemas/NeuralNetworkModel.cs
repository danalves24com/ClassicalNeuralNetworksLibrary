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
            outputLayer.lastHiddenLayer = hiddenLayers[hiddenLayers.Length-1];
            this.outputLayer = outputLayer;
            
        }

        public void Run()
        {
            NetworkLayer lastLayer = null;
            double[] previousOutput = inputLayer.inputs;
            foreach(NetworkLayer layer in this.hiddenLayers)
            {
                layer.forward(previousOutput);
                previousOutput = layer.outputs;
                lastLayer = layer;
            }
            outputLayer.lastHiddenLayer = lastLayer;
            outputLayer.softmax();
        }

    }
}
