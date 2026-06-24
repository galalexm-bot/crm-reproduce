using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Common.Components;
using EleWise.ELMA.Common.Enums;
using EleWise.ELMA.Common.ExtensionPoints;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Entities.EntityReferences;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Threading;
using NHibernate.Criterion;

namespace EleWise.ELMA.Common.Services;

[Service]
public class DuplicateService : IDuplicateService
{
	private readonly GlobalScoringSettingsModule scoringSettings;

	private readonly ISessionProvider sessionProvider;

	private IThreadPool threadPool;

	public DuplicateService(GlobalScoringSettingsModule scoringSettings, ISessionProvider sessionProvider)
	{
		Contract.ArgumentNotNull(scoringSettings, "scoringSettings");
		Contract.ArgumentNotNull(sessionProvider, "sessionProvider");
		this.scoringSettings = scoringSettings;
		this.sessionProvider = sessionProvider;
	}

	public ICollection<IDuplicate> GetPossibleDuplicates(ReferenceOnEntity reference)
	{
		if (reference != null)
		{
			return sessionProvider.GetSession("").CreateCriteria<IDuplicate>().Add((ICriterion)(object)Restrictions.Eq("EntityReference", (object)reference))
				.List<IDuplicate>();
		}
		return new List<IDuplicate>();
	}

	public void FillDuplicates(IEntity entity, IDuplicateHandler handler)
	{
		if (!(MetadataLoader.LoadMetadata(entity.GetType()) is EntityMetadata))
		{
			return;
		}
		List<PossibleDuplicate> possibleDuplicates = handler.GetPossibleDuplicates(entity);
		ReferenceOnEntity entityReference = ReferenceOnEntity.Create(entity);
		IDuplicateState duplicateState = InterfaceActivator.Create<IDuplicateState>();
		duplicateState.EntityReference = entityReference;
		if (possibleDuplicates.Any())
		{
			duplicateState.DuplicateStatus = DuplicateStatus.PossibleDuplicate;
			foreach (PossibleDuplicate item in possibleDuplicates)
			{
				IDuplicate duplicate = InterfaceActivator.Create<IDuplicate>();
				duplicate.EntityReference = entityReference;
				duplicate.EntityDuplicateReference = item.DuplicateReference;
				duplicate.DuplicateFields = item.PropertyList;
				duplicate.Weight = item.Weight;
				duplicate.Save();
			}
		}
		else
		{
			duplicateState.DuplicateStatus = DuplicateStatus.NotDuplicate;
		}
		duplicateState.DateOfScoring = DateTime.Now;
		duplicateState.Save();
	}

	public void ProcessEntity(IEntity entity)
	{
		Type type = entity.GetType();
		if (!(type != null) || !scoringSettings.Settings.IsGlobalScoringEnabled)
		{
			return;
		}
		EntityMetadata metadata = MetadataLoader.LoadMetadata(type) as EntityMetadata;
		IDuplicateHandler handler = ComponentManager.Current.GetExtensionPoints<IDuplicateHandler>().FirstOrDefault((IDuplicateHandler q) => q.IsScoringEnabled(metadata.Uid));
		if (handler == null)
		{
			return;
		}
		threadPool = threadPool ?? new ThreadSubPool("CheckDublicate.PoolSize", 3);
		threadPool.Queue(delegate
		{
			new BackgroundTask(delegate
			{
				FillDuplicates(entity, handler);
			}, typeof(IEntity), "BeforeSaveLead", SR.T("Выполнение действий, перед сохранением сущности с ID={0}", entity.GetId())).Execute();
		});
	}
}
