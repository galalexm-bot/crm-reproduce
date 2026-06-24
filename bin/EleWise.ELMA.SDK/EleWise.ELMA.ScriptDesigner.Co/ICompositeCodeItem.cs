using System.Collections.Generic;

namespace EleWise.ELMA.ScriptDesigner.CodeItems;

public interface ICompositeCodeItem : ICodeItem
{
	List<CodeItem> Items { get; set; }

	IEnumerable<ICodeItem> GetAllItems();

	bool IsValidChild(ICodeItem codeItem);
}
