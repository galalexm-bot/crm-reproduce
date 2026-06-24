using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Serialization;

namespace EleWise.ELMA.Common.Models;

[Serializable]
[Component]
public abstract class AbstractScoringSettings : IScoringSettings
{
	[NonSerialized]
	private readonly IBLOBStore blobStore;

	public virtual string ScoringSettingsString => "AbstractScoringSettings";

	public long Id { get; set; }

	public virtual Guid TypeUid { get; set; }

	public Guid DuplicateTypeUid { get; set; }

	public Guid Property { get; set; }

	public Guid DuplicateProperty { get; set; }

	public long PercentValue { get; set; }

	public AbstractScoringSettings()
	{
	}

	public AbstractScoringSettings(IBLOBStore blobStore)
	{
		Contract.ArgumentNotNull(blobStore, "blobStore");
		this.blobStore = blobStore;
	}

	public abstract bool Check(Guid typeUid);

	public virtual void Save()
	{
		List<IScoringSettings> list = GetScoringSettings().ToList();
		IScoringSettings scoringSettings = list.FirstOrDefault((IScoringSettings m) => m.Id == Id);
		if (scoringSettings != null)
		{
			list.Remove(scoringSettings);
		}
		Id = ((list.Count > 0) ? (list.Max((IScoringSettings m) => m.Id) + 1) : 1);
		list.Add(this);
		blobStore.Save(ScoringSettingsString, ClassSerializationHelper.SerializeObject(list));
	}

	public void Delete(long settingId)
	{
		List<IScoringSettings> list = GetScoringSettings().ToList();
		IScoringSettings scoringSettings = list.FirstOrDefault((IScoringSettings m) => m.Id == settingId);
		if (scoringSettings != null)
		{
			list.Remove(scoringSettings);
		}
		blobStore.Save(ScoringSettingsString, ClassSerializationHelper.SerializeObject(list));
	}

	public bool IsNew()
	{
		return LoadScoringSetting(Id) == null;
	}

	public virtual IEnumerable<IScoringSettings> GetScoringSettings()
	{
		if (!(ClassSerializationHelper.DeserializeObject(blobStore.LoadOrNull(ScoringSettingsString)) is List<IScoringSettings> result))
		{
			return new List<IScoringSettings>();
		}
		return result;
	}

	public virtual IScoringSettings LoadScoringSetting(long id)
	{
		return GetScoringSettings().FirstOrDefault((IScoringSettings m) => m.Id == id);
	}

	public string GetDuplicateName(Guid DuplicateTypeUid)
	{
		return (MetadataLoader.LoadMetadata(DuplicateTypeUid) as EntityMetadata).DisplayName;
	}

	public string GetDuplicateProperty(Guid DuplicateTypeUid, Guid DuplicateProperty)
	{
		return ((EntityPropertyMetadata)(MetadataLoader.LoadMetadata(DuplicateTypeUid) as EntityMetadata).Properties.FirstOrDefault((PropertyMetadata x) => x.Uid == DuplicateProperty)).DisplayName;
	}

	public abstract IEnumerable<Guid> GetPossibleDuplicatesUids();

	public IEnumerable<ClassMetadata> GetPossibleDuplicatesMetadata()
	{
		List<ClassMetadata> list = new List<ClassMetadata>();
		IEnumerable<Guid> possibleDuplicatesUids = GetPossibleDuplicatesUids();
		if (possibleDuplicatesUids.Any())
		{
			foreach (Guid item in possibleDuplicatesUids)
			{
				list.Add(MetadataLoader.LoadMetadata(item) as ClassMetadata);
				list.AddRange(MetadataLoader.GetChildClasses(MetadataLoader.LoadMetadata(item) as ClassMetadata));
			}
			return list;
		}
		return list;
	}
}
