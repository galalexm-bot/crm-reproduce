using System;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.ScriptDesigner.ToolBoxItems;

[ExtensionPoint(ComponentType.All)]
public interface ICodeItemToolBoxGroup
{
	Guid GroupUid { get; }

	Guid ParentGroupUid { get; }

	string Name { get; }
}
