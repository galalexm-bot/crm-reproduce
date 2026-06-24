using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Common.Services;

[ExtensionPoint(ComponentType.All)]
public interface IHistoryIdentifierExtensionPoint
{
	bool Check(IHistoryIdParams parameters);

	string GetKey(IHistoryIdParams parameters);
}
