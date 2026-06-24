using System;

namespace EleWise.ELMA.Model.Types;

public interface IPropertyTypeInfo
{
	string GetTypeDisplayName(Guid subTypeUid);
}
