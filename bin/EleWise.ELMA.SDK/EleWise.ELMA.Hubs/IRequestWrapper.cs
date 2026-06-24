using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Threading.Tasks;

namespace EleWise.ELMA.Hubs;

public interface IRequestWrapper
{
	Uri Url { get; }

	string LocalPath { get; }

	INameValueCollectionWrapper QueryString { get; }

	INameValueCollectionWrapper Headers { get; }

	IDictionary<string, ICookieWrapper> Cookies { get; }

	IPrincipal User { get; }

	IDictionary<string, object> Environment { get; }

	Task<INameValueCollectionWrapper> ReadForm();
}
