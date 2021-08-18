using System;

using R5T.Magyar;


namespace System
{
    public static class IExceptionMessageGeneratorExtensions
    {
        public static string SynchronicityIsUnspecified(this IExceptionMessageGenerator _)
        {
            var output = "Synchronicity was unspecified";
            return output;
        }
    }
}
