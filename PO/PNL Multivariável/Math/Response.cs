using PNL_Multivariável.Math;
using System.Collections.Generic;

namespace PNL_Mono_Variável.Math
{
    public interface IResponse
    {
        object StepsList { get; }
        int StepsCount { get; }
        Vector<double> X { get; set; }
        double FunctionValue { get; set; }
        string error { get; set; }
    }

    public class Response<T> : IResponse where T : Step
    {
        public List<T> Steps { get; set; }
        public object StepsList
        {
            get
            {
                return Steps;
            }
        }
        public int StepsCount
        {
            get
            {
                return Steps.Count;
            }
        }
        public Vector<double> X { get; set; }
        public double FunctionValue { get; set; }

        public string error { get; set; } = string.Empty;

        public Response()
        {
            Steps = new List<T>();
        }
    }
}
