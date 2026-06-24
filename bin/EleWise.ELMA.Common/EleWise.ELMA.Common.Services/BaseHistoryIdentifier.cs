using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Common.Services;

[Component(Order = int.MaxValue)]
internal sealed class BaseHistoryIdentifier : IHistoryIdentifierExtensionPoint
{
	public bool Check(IHistoryIdParams parameters)
	{
		return true;
	}

	public string GetKey(IHistoryIdParams parameters)
	{
		return "CommonHistoryOrder_276b318d-08ad-401b-85d0-5b7418c5a7a8";
	}
}
