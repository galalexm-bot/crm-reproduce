using System;
using System.CodeDom;
using System.Collections.Generic;

namespace EleWise.ELMA.ScriptDesigner.CodeItems;

public interface ICodeItem
{
	string Name { get; set; }

	Guid Uid { get; set; }

	void InitNew(ICodeItem parent);

	bool IsValidParent(ICodeItem codeItem);

	CodeStatement ToCodeStatement();

	CodeExpression ToCodeExpression();

	CodeStatement[] ToCodeStatementList();

	List<Type> GetValidToInsert();
}
