using ClassicalNeuralNetworksLibrary.Schemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassicalNeuralNetworksLibrary.Models
{
    public class NeuralNetworkModel
    {
        public InputLayer inputLayer { get; set; }
        public NetworkLayer[] hiddenLayers {get;set;}
        public OutputLayer outputLayer { get; set; }
        public Dataset data { get; set; }
        public NeuralNetworkModel(NetworkLayer[] hiddenLayers, OutputLayer outputLayer)
        {
            this.inputLayer = inputLayer;
            this.hiddenLayers = hiddenLayers;
            outputLayer.lastHiddenLayer = hiddenLayers[hiddenLayers.Length-1];
            this.outputLayer = outputLayer;                        
        }


        public void train(Dataset datasets)
        {

            
        }


        
        public void passData(Dataset dataset)
        {
            this.data = dataset;
            this.inputLayer.inputs = dataset.inputs;
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
            outputLayer.data = this.data;
            outputLayer.lastHiddenLayer = lastLayer;
            outputLayer.softmax();
            loss = outputLayer.loss();
            Console.WriteLine("Loss: " + outputLayer.loss());
        }

        private double loss;

    }
}
