using System;

using R5T.T0038;

using Instances = R5T.T0038.X001.Instances;
using Synchronicity = R5T.Magyar.Synchronicity;


namespace System
{
    public static class ISynchronicityExtensions
    {
        public static void EnsureSynchronicityIsSpecified(this ISynchronicity _,
            Synchronicity synchronicity)
        {
            var isUnspecified = _.IsUnspecified(synchronicity);
            if (isUnspecified)
            {
                throw Instances.ExceptionGenerator.SynchronicityWasUnspecified();
            }
        }

        public static bool IsAsynchronous(this ISynchronicity _,
            Synchronicity synchronicity)
        {
            var output = Synchronicity.Asynchronous == synchronicity;
            return output;
        }

        public static bool IsSynchronous(this ISynchronicity _,
            Synchronicity synchronicity)
        {
            var output = Synchronicity.Synchronous == synchronicity;
            return output;
        }

        public static bool IsUnspecified(this ISynchronicity _,
            Synchronicity synchronicity)
        {
            var output = Synchronicity.Unspecified == synchronicity;
            return output;
        }
    }
}
