using System;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Runtime.Db.ExtensionPoints;

[ExtensionPoint(ComponentType.All)]
public interface IUpdateIsGroupColumnExtension
{
	Guid ProviderUid { get; }

	void Execute(string tableName, string isGroupColumnName, string parentColumnName);
}
