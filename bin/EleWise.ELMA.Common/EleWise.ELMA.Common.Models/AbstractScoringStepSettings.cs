using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Serialization;

namespace EleWise.ELMA.Common.Models;

[Serializable]
[Component]
public abstract class AbstractScoringStepSettings : IScoringStepSettings
{
	[NonSerialized]
	private readonly IBLOBStore blobStore;

	public long Id { get; set; }

	public long PercentValue { get; set; }

	public string ColorCode { get; set; }

	public virtual string ScoringStepString => "AbstractScoringStepSettings";

	public AbstractScoringStepSettings()
	{
	}

	public AbstractScoringStepSettings(IBLOBStore blobStore)
	{
		Contract.ArgumentNotNull(blobStore, "blobStore");
		this.blobStore = blobStore;
	}

	public abstract bool Check(Guid typeUid);

	public void Delete(long stepId)
	{
		List<IScoringStepSettings> list = GetScoringStepSettings().ToList();
		IScoringStepSettings scoringStepSettings = list.FirstOrDefault((IScoringStepSettings m) => m.Id == stepId);
		if (scoringStepSettings != null)
		{
			list.Remove(scoringStepSettings);
		}
		blobStore.Save(ScoringStepString, ClassSerializationHelper.SerializeObject(list));
	}

	public IEnumerable<IScoringStepSettings> GetScoringStepSettings()
	{
		byte[] array = blobStore.LoadOrNull(ScoringStepString);
		if (array == null)
		{
			return new List<IScoringStepSettings>();
		}
		return ClassSerializationHelper.DeserializeObject(array) as List<IScoringStepSettings>;
	}

	public IScoringStepSettings LoadScoringStepSetting(long id)
	{
		return GetScoringStepSettings().FirstOrDefault((IScoringStepSettings m) => m.Id == id);
	}

	public virtual void Save()
	{
		List<IScoringStepSettings> list = GetScoringStepSettings().ToList();
		IScoringStepSettings scoringStepSettings = list.FirstOrDefault((IScoringStepSettings m) => m.Id == Id);
		if (scoringStepSettings != null)
		{
			list.Remove(scoringStepSettings);
		}
		Id = ((list.Count > 0) ? (list.Max((IScoringStepSettings m) => m.Id) + 1) : 1);
		list.Add(this);
		blobStore.Save(ScoringStepString, ClassSerializationHelper.SerializeObject(list));
	}
}
