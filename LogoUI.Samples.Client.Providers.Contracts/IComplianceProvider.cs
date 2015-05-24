using System;
using System.Collections.Generic;
using LogoUI.Samples.Client.Model.Contracts.Compliance;

namespace LogoUI.Samples.Client.Providers.Contracts
{
    public interface IComplianceProvider
    {
        IEnumerable<IComplianceRecord> GetComplianceRecords(DateTime? startTime, DateTime? endTime);
    }
}
