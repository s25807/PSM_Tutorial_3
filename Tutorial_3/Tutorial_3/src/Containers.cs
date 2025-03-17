using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tut3
{
    public abstract class Container
    {
        static protected int totalNContainers = 0;
        protected string serialNumber;
        private double cargoWeight;
        private double heightCM;
        private double tareWeightKG;
        private double depthCM;
        private double maximumPayloadKG;

        public Container(double cargoWeightInput, double heightCMInput, double tareWeightKGInput, double depthCMInput, double maximumPayloadKGInput)
        {
            this.cargoWeight = cargoWeightInput;
            this.heightCM = heightCMInput;
            this.tareWeightKG = tareWeightKGInput;
            this.depthCM = depthCMInput;
            this.maximumPayloadKG = maximumPayloadKGInput;
        }

        protected abstract void SetSerialNumber();
        public override String ToString()
        {
            return this.serialNumber;
        }
    }

    public class LiquidContainer : Container
    {
        public LiquidContainer(double cargoWeightInput, double heightCMInput, double tareWeightKGInput, double depthCMInput, double maximumPayloadKGInput) : base(cargoWeightInput, heightCMInput, tareWeightKGInput, depthCMInput, maximumPayloadKGInput)
        {
            SetSerialNumber();
        }


        protected override void SetSerialNumber()
        {
            ++totalNContainers;
        }
        public override String ToString()
        {
            Console.WriteLine(this.serialNumber);
            return this.serialNumber;
        }
    }
}
