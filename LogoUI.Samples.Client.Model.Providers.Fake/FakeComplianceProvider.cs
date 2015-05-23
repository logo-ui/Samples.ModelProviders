﻿using System;
using System.Collections.Generic;
using System.Threading;
using Attest.Fake.Builders;
using LogoUI.Samples.Client.Model.Contracts.Compliance;
using LogoUI.Samples.Client.Model.Providers.Contracts;
using LogoUI.Samples.Fake.Builders;

namespace LogoUI.Samples.Client.Model.Providers.Fake
{
    class FakeComplianceProvider : FakeProviderBase<ComplianceProviderBuilder,IComplianceProvider>, IComplianceProvider
    {
        private const int ComplianceRecordCount = 100;

        public IEnumerable<IComplianceRecord> GetComplianceRecords(DateTime? startTime, DateTime? endTime)
        {
            var provider = GetService(ComplianceProviderBuilder.CreateBuilder,
                t => t.WithComplianceRecord(ComplianceRecordCount));
            foreach (var complianceRecord in provider.GetComplianceRecords(startTime, endTime))
            {
                Thread.Sleep(5);
                yield return complianceRecord;                
            }           
        }
    }
}
