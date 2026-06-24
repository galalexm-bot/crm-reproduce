using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Db;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;

namespace EleWise.ELMA.Runtime.Db.Actions;

[ExtensionPoint(ServiceScope.Application, ComponentType.All)]
public interface IDbCreateTableActionExtender
{
	void Extend(IDbModelUpdater updater, ITransformationProvider transform, Table table);
}
