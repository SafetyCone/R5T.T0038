using System;

using R5T.Magyar;


namespace R5T.T0038.X001
{
    public static class Instances
    {
        public static IExceptionGenerator ExceptionGenerator { get; } = Magyar.ExceptionGenerator.Instance;
        public static IExceptionMessageGenerator ExceptionMessageGenerator { get; } = Magyar.ExceptionMessageGenerator.Instance;
    }
}
