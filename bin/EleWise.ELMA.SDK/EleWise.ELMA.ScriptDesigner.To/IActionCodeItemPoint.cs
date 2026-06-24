using System.Collections.Generic;
using System.Drawing;

namespace EleWise.ELMA.ScriptDesigner.ToolBoxItems;

public interface IActionCodeItemPoint
{
	string Name { get; set; }

	int Order { get; set; }

	string DisplayName { get; set; }

	string Description { get; set; }

	List<DesignerParameterInfo> Parameters { get; set; }

	DesignerParameterInfo ReturnType { get; set; }

	string CallPath { get; set; }

	Image Image { get; set; }
}
