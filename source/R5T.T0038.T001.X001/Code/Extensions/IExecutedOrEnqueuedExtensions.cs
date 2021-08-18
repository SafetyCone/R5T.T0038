using System;

using R5T.T0038.T001;


namespace System
{
    public static class IExecutedOrEnqueuedExtensions
    {
        /// <summary>
        /// Establishes that false is enqueued.
        /// </summary>
        public static bool Enqueued(this IExecutedOrEnqueued _)
        {
            return false;
        }

        /// <summary>
        /// Establishes that true is executed.
        /// </summary>
        public static bool Executed(this IExecutedOrEnqueued _)
        {
            return true;
        }

        /// <summary>
        /// Establishes that true is executed, and false is enqueued.
        /// </summary>
        public static bool WasEnqueued(this IExecutedOrEnqueued _,
            bool executedOrEnqueued)
        {
            var output = !executedOrEnqueued;
            return output;
        }

        /// <summary>
        /// Establishes that false is enqueued, and true is executed.
        /// </summary>
        public static bool WasExecuted(this IExecutedOrEnqueued _,
            bool executedOrEnqueued)
        {
            var output = executedOrEnqueued;
            return output;
        }
    }
}