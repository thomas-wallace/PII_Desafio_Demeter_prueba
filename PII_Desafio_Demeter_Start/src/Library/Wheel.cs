namespace Ucu.Poo.Cars
{
    /// <summary>
    /// Representa una rueda de un auto.
    /// </summary>
    public class Wheel
    {
        /// <summary>
        /// El freno de la rueda.
        /// </summary>
        public Break Break { get; private set; } = new Break();
    
    public int CountWheelFaultySensors()
    {
        
        int faultyCount = 0;
        for (int i = 0; i < 4; i++)
        {
            if (this.Break.Sensor.IsFaulty)
            {
                faultyCount++;
            }
        }
        
        return faultyCount;

    }

    }
}