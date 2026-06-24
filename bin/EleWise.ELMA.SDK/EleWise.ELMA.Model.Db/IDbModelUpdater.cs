using EleWise.ELMA.Runtime.Db;
using EleWise.ELMA.Runtime.Db.Actions;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;

namespace EleWise.ELMA.Model.Db;

public interface IDbModelUpdater : IActionsHolder
{
	ITransformationProvider Transform { get; }

	DbUpdateMarkerService MarkerService { get; }

	bool RecreateConstraints { get; }

	string GenerateForeignKeyName(string tableName, string columnName);

	string GeneratePrimaryKeyName(string tableName, string columnName);

	string GenerateDeletingColumnTemporaryName(string tableName, string columnName);

	string GetDeletingColumnTemporaryName(string tableName, string columnName);
}
