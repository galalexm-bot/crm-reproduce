using System.Collections.Generic;
using EleWise.ELMA.Common.Managers;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Security;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Common.Components;

[Component(Order = 10000000)]
public class PeriodicalEntityPostCommitListener : IUnitOfWorkEventListener
{
	internal class UpdatePeriodicalEntityItem
	{
		public IPeriodicalEntityManager Manager { get; set; }

		public IPeriodicalEntity Entity { get; set; }

		public bool ContinueFromLastDate { get; set; }
	}

	internal const string UpdatePeriodicalEntityContextVarName = "PeriodicalEntity_UpdatePeriodicalEntity";

	internal const string UpdatePeriodicalEntityCommitedContextVarName = "PeriodicalEntity_UpdatePeriodicalEntity_Commited";

	public void OnStartUnitofWork(IUnitOfWork unitOfWork)
	{
	}

	public void OnPreFlushUnitofWork(IUnitOfWork unitOfWork, IEnumerable<object> entities)
	{
	}

	public void OnPostFlushUnitofWork(IUnitOfWork unitOfWork)
	{
	}

	public void OnPreCommitUnitofWork(IUnitOfWork unitOfWork)
	{
	}

	public void OnPostCommitUnitofWork(IUnitOfWork unitOfWork)
	{
		ContextVars.Set("PeriodicalEntity_UpdatePeriodicalEntity_Commited", value: true);
	}

	public void OnPostRollbackUnitofWork(IUnitOfWork unitOfWork)
	{
	}

	public void OnDisposeUnitofWork(IUnitOfWork unitOfWork)
	{
		if (!ContextVars.TryGetValue<List<UpdatePeriodicalEntityItem>>("PeriodicalEntity_UpdatePeriodicalEntity", out var value) || !(ContextVars.TryGetValue<bool>("PeriodicalEntity_UpdatePeriodicalEntity_Commited", out var value2) && value2))
		{
			return;
		}
		ContextVars.Set<List<UpdatePeriodicalEntityItem>>("PeriodicalEntity_UpdatePeriodicalEntity", null);
		if (value == null)
		{
			return;
		}
		ISecurityService serviceNotNull = Locator.GetServiceNotNull<ISecurityService>();
		foreach (UpdatePeriodicalEntityItem item2 in value)
		{
			UpdatePeriodicalEntityItem item1 = item2;
			serviceNotNull.RunWithElevatedPrivilegies(delegate
			{
				item1.Manager.CreatingPeriodicEntities(item1.Entity, item1.ContinueFromLastDate);
			});
		}
	}

	public static void AddUpdatePeriodicalEntity(IPeriodicalEntityManager manager, IPeriodicalEntity entity, bool continueFromLastDate)
	{
		ContextVars.GetOrAdd("PeriodicalEntity_UpdatePeriodicalEntity", () => new List<UpdatePeriodicalEntityItem>()).Add(new UpdatePeriodicalEntityItem
		{
			Manager = manager,
			Entity = entity,
			ContinueFromLastDate = continueFromLastDate
		});
	}
}
