using System;


namespace R5T.T0038
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class Synchronicity : ISynchronicity
    {
        #region Static

        public static Synchronicity Instance { get; } = new();

        #endregion
    }
}