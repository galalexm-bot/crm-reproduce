using System;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Ranges;

namespace EleWise.ELMA.Security.Models.API;

[FilterFor(typeof(IPublicClientCacheToken))]
public interface IPublicClientCacheTokenFilter : IEntityFilter
{
	IPublicClientSession Session { get; set; }

	Guid? TokenKey { get; set; }

	DateTimeRange LastAccess { get; set; }
}
