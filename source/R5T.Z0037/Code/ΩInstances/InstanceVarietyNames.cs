using System;


namespace R5T.Z0037
{
    public class InstanceVarietyNames : IInstanceVarietyNames
    {
        #region Infrastructure

        public static IInstanceVarietyNames Instance { get; } = new InstanceVarietyNames();


        private InstanceVarietyNames()
        {
        }

        #endregion
    }
}
