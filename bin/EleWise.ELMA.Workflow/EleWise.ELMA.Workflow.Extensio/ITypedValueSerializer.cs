using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.Workflow.ExtensionPoints;

[ExtensionPoint(ComponentType.All)]
[DeveloperApi(DeveloperApiType.ExtensionPoint)]
public interface ITypedValueSerializer
{
	bool CanUse(ITypeDescriptor descriptor);

	string SerializeTypedValue(object obj, bool isList, ITypeDescriptor descriptor);

	object DeserializeTypedValue(string stringValue, bool isList, ITypeDescriptor descriptor);

	Type GetType(ITypeDescriptor descriptor);

	bool IsListSupported(ITypeDescriptor descriptor);
}
