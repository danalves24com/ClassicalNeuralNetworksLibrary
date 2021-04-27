﻿using System;
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
            outputLayer.lastHiddenLayer = hiddenLayers[hiddenLayers.Length];
            this.outputLayer = outputLayer;
            
        }

        public void Run()
        {
            double[] prviousOutput = inputLayer.inputs;
            foreach(NetworkLayer layer in this.hiddenLayers)
            {
                layer.forward(prviousOutput);
                
            }
        }

    }
}
