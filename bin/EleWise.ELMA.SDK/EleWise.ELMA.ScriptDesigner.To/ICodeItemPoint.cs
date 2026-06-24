using System;
using System.Drawing;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.ScriptDesigner.CodeItems;

namespace EleWise.ELMA.ScriptDesigner.ToolBoxItems;

public interface ICodeItemPoint
{
	string Name { get; set; }

	Type CodeItemType { get; }

	Guid GroupUid { get; }

	Image Image { get; }

	string Path { get; set; }

	string DisplayName { get; set; }

	string VariableName { get; set; }

	Type VariableType { get; set; }

	string Description { get; set; }

	bool IsLocal { get; set; }

	Guid Uid { get; set; }

	ICodeItem CreateCodeItem();

	bool IsAvailable(IMetadata metadata);
}
