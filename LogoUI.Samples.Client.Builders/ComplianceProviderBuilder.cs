﻿using System;
using System.Collections.Generic;
using Attest.Fake.Builders;
using Attest.Fake.Moq;
using LogoUI.Samples.Client.Data.Contracts;
using LogoUI.Samples.Client.Model.Contracts.Compliance;
using LogoUI.Samples.Client.Model.Mappers;
using LogoUI.Samples.Client.Providers.Contracts;

namespace LogoUI.Samples.Client.Builders
{
    public class ComplianceProviderBuilder : FakeBuilderBase<IComplianceProvider>
    {
        private static readonly string[] AppNames =
        {
            "Security Update for Windows",
            "Skype",
            "TeamViewer",
            "USB Removable Storage",
            "WebEx",
            "Windows Live Messenger",
            "Windows Messenger",
            "WinPcap",
            "WinSCP",
            "Wireshark",
            "Google Talk",
        };

        readonly Random _random = new Random();

        private int _complianceRecordCount;

        private ComplianceProviderBuilder() : base(FakeFactoryFactory.CreateFakeFactory())
        {
            
        }

        public static ComplianceProviderBuilder CreateBuilder()
        {
            return new ComplianceProviderBuilder();
        }

        public ComplianceProviderBuilder WithComplianceRecord()
        {
            _complianceRecordCount++;
            return this;
        }

        public ComplianceProviderBuilder WithComplianceRecord(int numberOfComplianceRecordsToAdd)
        {
            _complianceRecordCount+=numberOfComplianceRecordsToAdd;
            return this;
        }

        protected override void SetupFake()
        {
            FakeService.SetupWithResult(t => t.GetComplianceRecords(It.IsAny<DateTime?>(), It.IsAny<DateTime?>()),
                GenerateComplianceRecords());
        }

        private IEnumerable<IComplianceRecord> GenerateComplianceRecords()
        {
            for (int i = 0; i < _complianceRecordCount; i++)
            {
                yield return GenerateComplianceRecord(_random, i);
            }
        }

        private static IComplianceRecord GenerateComplianceRecord(Random rnd, int index)
        {
            byte hostIndex = (byte)rnd.Next(1, 4);

            var result = new ComplianceRecordDto
            {
                LastDate = new DateTime(2012, 1, 1) + new TimeSpan(rnd.Next(0, 100000000) * 1000),
                Host = "HOST" + hostIndex,
                IpAddress = "192.168.0." + hostIndex,
                Object = AppNames[rnd.Next(AppNames.Length)],
                Status = rnd.Next(2) == 0 ? "Installed" : "NotInstalled",
                Information = "Record N " + (index + 1)
            };

            return ComplianceRecordMapper.ToComplianceRecord(result);
        }
    }
}
