using System;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Ranges;

namespace EleWise.ELMA.Security.Models;

[FilterFor(typeof(IUserCertificate))]
public interface IUserCertificateFilter : IEntityFilter
{
	IUser User { get; set; }

	DateTimeRange CreationDate { get; set; }

	string Name { get; set; }

	Guid? CryptoActionGuid { get; set; }

	Guid? CryptoProviderGuid { get; set; }
}
