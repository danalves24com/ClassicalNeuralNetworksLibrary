using ClassicalNeuralNetworksLibrary.Schemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassicalNeuralNetworksLibrary.Models
{
    public class ClassificationModel
    {
        private NeuralNetworkModel model = null;
        public void build(Configuration configuration)
        {

            NetworkLayer[] hiddenLayers = new NetworkLayer[configuration.hiddenLayersSize+1];
            int i = 0;
            int lastDim = configuration.inputDimension;
            foreach(int dim in configuration.hiddenLayersDimensions)
            {
                hiddenLayers[i] = new NetworkLayer(lastDim, dim);
                lastDim = dim;
                i += 1;
            }
            hiddenLayers[i] = new NetworkLayer(lastDim, configuration.outputDimension);
            model = new NeuralNetworkModel(
                
                hiddenLayers,
                new OutputLayer()                

            );            
        }


        public void train(Dataset dataset)
        {
            this.model.train(dataset);
        }

        public void forward(Dataset dataset)
        {
            model.inputLayer = new InputLayer(dataset.inputs);
            model.passData(dataset);
            model.Run();
        }
    }
}
