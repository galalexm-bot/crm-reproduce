using System;

namespace EleWise.ELMA.Model.Metadata.Services;

public interface IQualifiedTypeNameResolverService
{
	string GetQualifiedTypeName(Type type);

	Type GetType(string qualifiedTypeName);
}
