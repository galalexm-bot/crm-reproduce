using System;
using Bridge;

namespace EleWise.ELMA.Core.React.UI.Helpers;

public static class HashHelper
{
	[Template("elmaComponents.MD5.getHash({s})")]
	public static extern string GetHash(string s);

	public static Guid GenNewGuid(this Guid uid, string secret = "")
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		Guid result = default(Guid);
		Guid.TryParse(GetHash(((object)(Guid)(ref uid)).ToString() + "-" + secret), ref result);
		return result;
	}
}
