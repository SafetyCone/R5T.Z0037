using System;


namespace R5T.Z0037
{
    public class InstanceVarietyDescriptors : IInstanceVarietyDescriptors
    {
        #region Infrastructure

        public static IInstanceVarietyDescriptors Instance { get; } = new InstanceVarietyDescriptors();


        private InstanceVarietyDescriptors()
        {
        }

        #endregion
    }
}
