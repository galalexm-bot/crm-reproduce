using System.Linq;
using Orchard.ContentManagement.Records;
using Orchard.Data;

namespace Orchard.ContentManagement.Handlers;

public class StorageVersionFilter<TRecord> : StorageFilter<TRecord> where TRecord : ContentPartVersionRecord, new()
{
	public StorageVersionFilter(IRepository<TRecord> repository)
		: base(repository)
	{
	}

	protected override TRecord GetRecordCore(ContentItemVersionRecord versionRecord)
	{
		return _repository.Get(versionRecord.Id);
	}

	protected override TRecord CreateRecordCore(ContentItemVersionRecord versionRecord, TRecord record = null)
	{
		if (record == null)
		{
			record = new TRecord();
		}
		record.ContentItemRecord = versionRecord.ContentItemRecord;
		record.ContentItemVersionRecord = versionRecord;
		_repository.Create(record);
		return record;
	}

	protected override void Versioning(VersionContentContext context, ContentPart<TRecord> existing, ContentPart<TRecord> building)
	{
		_repository.Copy(existing.Record, building.Record);
		building.Record.ContentItemVersionRecord = context.BuildingItemVersionRecord;
		_repository.Create(building.Record);
	}

	protected override void Destroying(DestroyContentContext context, ContentPart<TRecord> instance)
	{
		ContentItemVersionRecord[] array = context.ContentItem.Record.Versions.ToArray();
		foreach (ContentItemVersionRecord contentItemVersionRecord in array)
		{
			TRecord val = _repository.Get(contentItemVersionRecord.Id);
			if (val != null)
			{
				_repository.Delete(val);
			}
		}
	}
}
