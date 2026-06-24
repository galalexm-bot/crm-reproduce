using System;
using System.Web;
using System.Web.SessionState;

namespace EleWise.ELMA.Web.Mvc.Modules;

[Serializable]
public class SessionItem
{
	public ISessionStateItemCollection Items;

	public HttpStaticObjectsCollection StaticObjects;

	public DateTime Expires;

	[NonSerialized]
	internal byte[] DataArray;
}
