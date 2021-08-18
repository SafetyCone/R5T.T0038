using System;


namespace R5T.T0038.T001
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class ExecutedOrEnqueued : IExecutedOrEnqueued
    {
        #region Static

        public static ExecutedOrEnqueued Instance { get; } = new();

        #endregion
    }
}