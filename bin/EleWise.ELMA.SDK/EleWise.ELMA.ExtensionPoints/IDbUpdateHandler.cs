using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Runtime.Db;

namespace EleWise.ELMA.ExtensionPoints;

[DeveloperApi(DeveloperApiType.ExtensionPoint)]
[ExtensionPoint(ComponentType.Server)]
public interface IDbUpdateHandler
{
	Guid ProviderUid { get; }

	bool HasChanges { get; }

	bool NeedRecreateConstraints { get; }

	void CreateInitialStructures();

	void Init();

	void OnStart(DbUpdateParameters parameters);

	void OnTriggersDeleting(TriggersDeletingEventArgs e);

	void OnTriggersDeleted();

	void OnProceduresDeleting(ProceduresDeletingEventArgs e);

	void OnProceduresDeleted();

	void OnViewsDeleting(ViewsDeletingEventArgs e);

	void OnViewsDeleted();

	void OnIndexesDeleting(IndexesDeletingEventArgs e);

	void OnIndexesDeleted();

	void OnForeignKeysDeleting(ForeginKeysDeletingEventArgs e);

	void OnForeignKeysDeleted();

	void OnPrimaryKeysDeleting(PrimaryKeysDeletingEventArgs e);

	void OnPrimaryKeysDeleted();

	void OnTablesCreating(TablesCreatingEventArgs e);

	void OnTablesCreated();

	void OnTablesDeleting(TablesDeletingEventArgs e);

	void OnTablesDeleted();

	void OnForeignKeysCreating(ForeignKeysCreatingEventArgs e);

	void OnForeignKeysCreated();

	void OnPrimaryKeysCreating(PrimaryKeysCreatingEventArgs e);

	void OnPrimaryKeysCreated();

	void OnIndexesCreating(IndexesCreatingEventArgs e);

	void OnIndexesCreated();

	void OnViewsCreating(ViewsCreatingEventArgs e);

	void OnViewsCreated();

	void OnProceduresCreating(ProceduresCreatingEventArgs e);

	void OnProceduresCreated();

	void OnTriggersCreating(TriggersCreatingEventArgs e);

	void OnTriggersCreated();

	void OnComplete();
}
