using Bridge;
using EleWise.ELMA.Api.Attributes;

namespace EleWise.ELMA.Api.Models;

[SimpleSerialize]
[ObjectLiteral]
internal sealed class ConnectorDataWrapper
{
	private ConnectorData[] _003CConnectorData_003Ek__BackingField;

	public ConnectorData[] ConnectorData
	{
		get
		{
			return _003CConnectorData_003Ek__BackingField;
		}
		set
		{
			_003CConnectorData_003Ek__BackingField = value;
		}
	}
}
