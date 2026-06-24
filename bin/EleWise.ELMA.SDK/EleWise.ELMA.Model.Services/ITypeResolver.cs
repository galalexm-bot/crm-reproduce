using System;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Model.Services;

[ExtensionPoint(ComponentType.Server)]
public interface ITypeResolver
{
	Type GetTypeByUid(Guid uid);
}
