using System;
using System.Collections.Generic;
using System.Security;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.BPM.Web.Common.Security;

[Component]
public class EntitySecurityExceptionIgnoreProvider : IExceptionIgnoreProvider
{
	public IEnumerable<Type> Exceptions
	{
		get
		{
			yield return typeof(SecurityException);
		}
	}
}
