using System;

using R5T.Magyar.T002;

using Instances = R5T.T0038.X001.Instances;


namespace System
{
    public static class IExceptionGeneratorExtensions
    {
        public static Exception SynchronicityWasUnspecified(this IExceptionGenerator _)
        {
            var message = Instances.ExceptionMessageGenerator.SynchronicityIsUnspecified();

            var output = new Exception(message);
            return output;
        }
    }
}
