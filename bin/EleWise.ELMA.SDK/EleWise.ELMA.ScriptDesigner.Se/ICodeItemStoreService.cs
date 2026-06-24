using System;
using System.Collections.Generic;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.ScriptDesigner.ToolBoxItems;

namespace EleWise.ELMA.ScriptDesigner.Services;

public interface ICodeItemStoreService
{
	void Initialize();

	void RegistrateActions();

	VariableCodeItemToolBoxItem LoadLocalVariableByUid(Guid variableUid);

	void RegistrateContextVariables(Guid uid, List<IMetadata> propertyList);

	void RemoveStoreLocalItem(Guid uid);

	void UpdateActions();
}
