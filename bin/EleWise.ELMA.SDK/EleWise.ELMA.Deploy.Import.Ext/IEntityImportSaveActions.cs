using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Import.Links;
using EleWise.ELMA.Model.Entities;

namespace EleWise.ELMA.Deploy.Import.ExtensionPoints;

[ExtensionPoint(ComponentType.All)]
public interface IEntityImportSaveActions
{
	bool IsSupported(Guid typeGuid);

	bool CanBeSaved(Dictionary<string, object> propValues, ImportEntityCanBeSavedData data);

	List<TestImportMessages> ExecPreSaveActions(IEntity entity, ImportEntityPreSaveData data);

	void ExecPostSaveActions(IEntity entity, Type type, Dictionary<string, object> values, Dictionary<string, string> serviceData, LinksDictionary links);

	void ExecSaveActions(IEntity entity, Dictionary<string, string> serviceData);

	void TestRead(ImportTestReadData data, ImportTestReadResult result);

	IEnumerable<ILinksDictionaryItem> RecoveryLinks(IEntity entity, Guid entityUid, LinksDictionary linksDictionary);
}
