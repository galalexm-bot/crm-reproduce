using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;

namespace EleWise.ELMA.ScriptDesigner.ToolBoxItems;

[ExtensionPoint(ComponentType.All)]
public interface INewCodeItemToolBoxItem : ICodeItemPoint, IXsiType
{
}
