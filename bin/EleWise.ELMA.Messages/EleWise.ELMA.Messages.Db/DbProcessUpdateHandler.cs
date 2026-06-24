using System;
using EleWise.ELMA.Runtime.Db;

namespace EleWise.ELMA.Messages.Db;

public class DbProcessUpdateHandler : DbUpdateHandler
{
	public override Guid ProviderUid => Guid.Empty;

	public override bool HasChanges => false;

	public override bool NeedRecreateConstraints => false;

	public override void OnProceduresDeleting(ProceduresDeletingEventArgs e)
	{
		base.OnProceduresDeleting(e);
		e.SkipNames.Add(string.Format("G_{0}", "Feed"));
	}
}
