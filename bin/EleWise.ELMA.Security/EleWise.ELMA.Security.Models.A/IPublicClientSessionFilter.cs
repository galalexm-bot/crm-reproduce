using System;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Ranges;

namespace EleWise.ELMA.Security.Models.API;

[FilterFor(typeof(IPublicClientSession))]
public interface IPublicClientSessionFilter : IEntityFilter
{
	Guid? AuthToken { get; set; }

	IPublicApplicationToken ClientToken { get; set; }

	IPublicApplication Application { get; set; }

	IUser AuthUser { get; set; }

	DateTimeRange LastAccess { get; set; }

	string SessionToken { get; set; }
}
