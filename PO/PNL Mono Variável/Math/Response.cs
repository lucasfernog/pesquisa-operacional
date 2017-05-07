using System.Collections.Generic;

namespace PNL_Mono_Variável.Math
{
    public class Response
    {
        public List<Step> Steps { get; set; }
        public double X { get; set; }
        public double FunctionValue { get; set; }

        public Response()
        {
            Steps = new List<Step>();
        }
    }
}
