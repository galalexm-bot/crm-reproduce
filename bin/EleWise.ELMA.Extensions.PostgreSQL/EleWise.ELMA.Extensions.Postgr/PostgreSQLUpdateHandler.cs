using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Runtime.Db;

namespace EleWise.ELMA.Extensions.PostgreSQL;

[Component]
internal class PostgreSQLUpdateHandler : DbUpdateHandler
{
	public override Guid ProviderUid => PostgreSQLProvider.UID;

	public override bool HasChanges => false;

	public override bool NeedRecreateConstraints => false;

	public override void OnViewsDeleting(ViewsDeletingEventArgs e)
	{
		base.OnViewsDeleting(e);
		e.SkipNames.Add("pg_stat_statements");
	}
}
