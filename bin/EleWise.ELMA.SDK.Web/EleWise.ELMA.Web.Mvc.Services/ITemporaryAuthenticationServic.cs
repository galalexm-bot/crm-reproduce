using System;
using System.Web;
using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.Web.Mvc.Services;

[DeveloperApi(DeveloperApiType.Service)]
public interface ITemporaryAuthenticationService
{
	void Add(TemporaryAuthenticationInfo info);

	void Remove(Guid key);

	TemporaryAuthenticationInfo Get(Guid key);

	TemporaryAuthenticationInfo GetFromContext(HttpContextBase context);
}
