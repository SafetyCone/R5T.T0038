using System;


namespace R5T.T0038.X001
{
    public static class Instances
    {
        public static Magyar.T002.IExceptionGenerator ExceptionGenerator { get; } = Magyar.T002.ExceptionGenerator.Instance;
        public static Magyar.T002.IExceptionMessageGenerator ExceptionMessageGenerator { get; } = Magyar.T002.ExceptionMessageGenerator.Instance;
    }
}