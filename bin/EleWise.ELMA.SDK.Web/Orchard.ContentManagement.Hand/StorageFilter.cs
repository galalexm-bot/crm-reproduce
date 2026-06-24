using System;
using Orchard.ContentManagement.Records;
using Orchard.Data;

namespace Orchard.ContentManagement.Handlers;

public static class StorageFilter
{
	public static StorageFilter<TRecord> For<TRecord>(IRepository<TRecord> repository) where TRecord : ContentPartRecord, new()
	{
		if (typeof(TRecord).IsSubclassOf(typeof(ContentPartVersionRecord)))
		{
			return (StorageFilter<TRecord>)Activator.CreateInstance(typeof(StorageVersionFilter<>).MakeGenericType(typeof(TRecord)), repository);
		}
		return new StorageFilter<TRecord>(repository);
	}
}
public class StorageFilter<TRecord> : StorageFilterBase<ContentPart<TRecord>> where TRecord : ContentPartRecord, new()
{
	protected readonly IRepository<TRecord> _repository;

	public StorageFilter(IRepository<TRecord> repository)
	{
		if (GetType() == typeof(StorageFilter<TRecord>) && typeof(TRecord).IsSubclassOf(typeof(ContentPartVersionRecord)))
		{
			throw new ArgumentException($"Use {typeof(StorageVersionFilter<>).Name} (or {typeof(StorageFilter).Name}.For<TRecord>()) for versionable record types", "repository");
		}
		_repository = repository;
	}

	protected virtual TRecord GetRecordCore(ContentItemVersionRecord versionRecord)
	{
		return _repository.Get(versionRecord.ContentItemRecord.Id);
	}

	protected virtual TRecord CreateRecordCore(ContentItemVersionRecord versionRecord, TRecord record = null)
	{
		if (record == null)
		{
			record = new TRecord();
		}
		record.ContentItemRecord = versionRecord.ContentItemRecord;
		_repository.Create(record);
		return record;
	}

	protected override void Activated(ActivatedContentContext context, ContentPart<TRecord> instance)
	{
		if (instance.Record != null)
		{
			throw new InvalidOperationException($"Having more than one storage filter for a given part ({typeof(ContentPart<TRecord>).FullName}) is invalid.");
		}
		instance.Record = new TRecord();
	}

	protected override void Creating(CreateContentContext context, ContentPart<TRecord> instance)
	{
		CreateRecordCore(context.ContentItemVersionRecord, instance.Record);
	}

	protected override void Loading(LoadContentContext context, ContentPart<TRecord> instance)
	{
		ContentItemVersionRecord versionRecord = context.ContentItemVersionRecord;
		instance._record.Loader(() => GetRecordCore(versionRecord) ?? CreateRecordCore(versionRecord));
	}

	protected override void Versioning(VersionContentContext context, ContentPart<TRecord> existing, ContentPart<TRecord> building)
	{
		building.Record = existing.Record;
	}

	protected override void Destroying(DestroyContentContext context, ContentPart<TRecord> instance)
	{
		_repository.Delete(instance.Record);
	}
}
