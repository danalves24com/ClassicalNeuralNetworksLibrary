using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassicalNeuralNetworksLibrary.Schemas
{
    public class Configuration
    {
        public int[] hiddenLayersDimensions { get; set; }
        public int hiddenLayersSize { get; set; }
        public int inputDimension { get; set; }
        public int outputDimension { get; set; }
        public Configuration(int[] hiddenLayersDimensions, int inputDims, int outputDims)
        {
            this.hiddenLayersDimensions = hiddenLayersDimensions;
            this.hiddenLayersSize = hiddenLayersDimensions.Length;
            this.inputDimension = inputDims;
            this.outputDimension = outputDims;
        }

    }
}
