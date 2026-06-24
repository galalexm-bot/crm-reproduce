using System;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Common.ExtensionPoints;

[ExtensionPoint(ComponentType.Server)]
internal interface IFixUpdateIdFieldFSFileForObjectExtension
{
	Guid ProviderUid { get; }

	void CreateTemplateTable();

	void RemoveTemplateTable();

	void UpdateData(string tableName, string fieldName);
}
