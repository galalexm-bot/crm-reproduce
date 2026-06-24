using System;

namespace EleWise.ELMA.Web.Mvc.Html;

[Serializable]
internal class NameAlreadyUsedException : Exception
{
	public NameAlreadyUsedException()
	{
	}

	public NameAlreadyUsedException(string message)
		: base(message)
	{
	}
}
