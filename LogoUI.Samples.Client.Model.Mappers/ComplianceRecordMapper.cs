using System;
using System.Linq;
using System.Net;
using LogoUI.Samples.Client.Data.Contracts;
using LogoUI.Samples.Client.Model.Contracts.Compliance;
using LogoUI.Samples.Client.Model.Shared;

namespace LogoUI.Samples.Client.Model.Mappers
{
    public class ComplianceRecordMapper
    {
        public static IComplianceRecord ToComplianceRecord(ComplianceRecordDto complianceRecordDto)
        {
            var addressParts = complianceRecordDto.IpAddress.Split(new[] {'.'}).Select(byte.Parse).ToArray();
            return new ComplianceRecord
            {
                Host = complianceRecordDto.Host,
                Information = complianceRecordDto.Information,
                IpAddress = new IPAddress(new[]
                {
                    addressParts[0], addressParts[1], addressParts[2], addressParts[3]
                }),
                LastDate = complianceRecordDto.LastDate,
                LoggedOnUser = UserContext.Current,
                Object = complianceRecordDto.Object,
                Status =
                    (ComplianceRecordStatus) Enum.Parse(typeof (ComplianceRecordStatus), complianceRecordDto.Status)
            };
        }
    }
}