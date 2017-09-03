using System.Collections.Generic;

namespace BIAI.Network
{
    public interface INeuron
    {
        IDictionary<INeuron, double> Activators { get; }
        IDictionary<INeuron, double> Outputs { get; }
        double Delta { get; }
        double Value { get; }
    }
}
