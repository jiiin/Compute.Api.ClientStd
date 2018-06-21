namespace DD.CBU.Compute.Api.ContractsStd.Drs
{
    using System;

    public partial class ConsistencyGroupSnapshotType
    {
        /// <remarks/>
        public DateTimeOffset createTimeOffset {
            get { return DateTimeOffset.Parse(createTime); }
        }
    }
}