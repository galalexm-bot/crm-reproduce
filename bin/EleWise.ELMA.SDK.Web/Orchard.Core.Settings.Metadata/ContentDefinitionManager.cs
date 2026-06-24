using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using EleWise.ELMA.Logging;
using Orchard.Caching;
using Orchard.ContentManagement.MetaData;
using Orchard.ContentManagement.MetaData.Builders;
using Orchard.ContentManagement.MetaData.Models;
using Orchard.ContentManagement.MetaData.Services;
using Orchard.Core.Settings.Metadata.Records;
using Orchard.Data;
using Orchard.Exceptions;

namespace Orchard.Core.Settings.Metadata;

public class ContentDefinitionManager : Component, IContentDefinitionManager, IDependency
{
	private const string ContentDefinitionSignal = "ContentDefinitionManager";

	private readonly ICacheManager _cacheManager;

	private readonly ISignals _signals;

	private readonly IRepository<ContentTypeDefinitionRecord> _typeDefinitionRepository;

	private readonly IRepository<ContentPartDefinitionRecord> _partDefinitionRepository;

	private readonly IRepository<ContentFieldDefinitionRecord> _fieldDefinitionRepository;

	private readonly ISettingsFormatter _settingsFormatter;

	public ContentDefinitionManager(ICacheManager cacheManager, ISignals signals, IRepository<ContentTypeDefinitionRecord> typeDefinitionRepository, IRepository<ContentPartDefinitionRecord> partDefinitionRepository, IRepository<ContentFieldDefinitionRecord> fieldDefinitionRepository, ISettingsFormatter settingsFormatter)
	{
		_cacheManager = cacheManager;
		_signals = signals;
		_typeDefinitionRepository = typeDefinitionRepository;
		_partDefinitionRepository = partDefinitionRepository;
		_fieldDefinitionRepository = fieldDefinitionRepository;
		_settingsFormatter = settingsFormatter;
	}

	public ContentTypeDefinition GetTypeDefinition(string name)
	{
		if (string.IsNullOrWhiteSpace(name))
		{
			return null;
		}
		IDictionary<string, ContentTypeDefinition> dictionary = AcquireContentTypeDefinitions();
		if (dictionary.ContainsKey(name))
		{
			return dictionary[name];
		}
		return null;
	}

	public void DeleteTypeDefinition(string name)
	{
		ContentTypeDefinitionRecord contentTypeDefinitionRecord = _typeDefinitionRepository.Table.SingleOrDefault((ContentTypeDefinitionRecord x) => x.Name == name);
		if (contentTypeDefinitionRecord != null)
		{
			_typeDefinitionRepository.Delete(contentTypeDefinitionRecord);
		}
		TriggerContentDefinitionSignal();
	}

	public void DeletePartDefinition(string name)
	{
		foreach (ContentTypeDefinition item in from typeDefinition in ListTypeDefinitions()
			where typeDefinition.Parts.Any((ContentTypePartDefinition part) => part.PartDefinition.Name == name)
			select typeDefinition)
		{
			this.AlterTypeDefinition(item.Name, delegate(ContentTypeDefinitionBuilder builder)
			{
				builder.RemovePart(name);
			});
		}
		ContentPartDefinitionRecord contentPartDefinitionRecord = _partDefinitionRepository.Table.SingleOrDefault((ContentPartDefinitionRecord x) => x.Name == name);
		if (contentPartDefinitionRecord != null)
		{
			_partDefinitionRepository.Delete(contentPartDefinitionRecord);
		}
		TriggerContentDefinitionSignal();
	}

	public ContentPartDefinition GetPartDefinition(string name)
	{
		if (string.IsNullOrWhiteSpace(name))
		{
			return null;
		}
		IDictionary<string, ContentPartDefinition> dictionary = AcquireContentPartDefinitions();
		if (dictionary.ContainsKey(name))
		{
			return dictionary[name];
		}
		return null;
	}

	public IEnumerable<ContentTypeDefinition> ListTypeDefinitions()
	{
		return AcquireContentTypeDefinitions().Values;
	}

	public IEnumerable<ContentPartDefinition> ListPartDefinitions()
	{
		return AcquireContentPartDefinitions().Values;
	}

	public IEnumerable<ContentFieldDefinition> ListFieldDefinitions()
	{
		return AcquireContentFieldDefinitions().Values;
	}

	public void StoreTypeDefinition(ContentTypeDefinition contentTypeDefinition)
	{
		Apply(contentTypeDefinition, Acquire(contentTypeDefinition));
		TriggerContentDefinitionSignal();
	}

	public void StorePartDefinition(ContentPartDefinition contentPartDefinition)
	{
		Apply(contentPartDefinition, Acquire(contentPartDefinition));
		TriggerContentDefinitionSignal();
	}

	private void MonitorContentDefinitionSignal(AcquireContext<string> ctx)
	{
		ctx.Monitor(_signals.When("ContentDefinitionManager"));
	}

	private void TriggerContentDefinitionSignal()
	{
		_signals.Trigger("ContentDefinitionManager");
	}

	private IDictionary<string, ContentTypeDefinition> AcquireContentTypeDefinitions()
	{
		return _cacheManager.Get("ContentTypeDefinitions", preventConcurrentCalls: true, delegate(AcquireContext<string> ctx)
		{
			MonitorContentDefinitionSignal(ctx);
			AcquireContentPartDefinitions();
			return _typeDefinitionRepository.Table.FetchMany((ContentTypeDefinitionRecord x) => x.ContentTypePartDefinitionRecords).ThenFetch((ContentTypePartDefinitionRecord x) => x.ContentPartDefinitionRecord).Select(Build)
				.ToDictionary((ContentTypeDefinition x) => x.Name, (ContentTypeDefinition y) => y, StringComparer.OrdinalIgnoreCase);
		});
	}

	private IDictionary<string, ContentPartDefinition> AcquireContentPartDefinitions()
	{
		return _cacheManager.Get("ContentPartDefinitions", preventConcurrentCalls: true, delegate(AcquireContext<string> ctx)
		{
			MonitorContentDefinitionSignal(ctx);
			return _partDefinitionRepository.Table.FetchMany((ContentPartDefinitionRecord x) => x.ContentPartFieldDefinitionRecords).ThenFetch((ContentPartFieldDefinitionRecord x) => x.ContentFieldDefinitionRecord).Select(Build)
				.ToDictionary((ContentPartDefinition x) => x.Name, (ContentPartDefinition y) => y, StringComparer.OrdinalIgnoreCase);
		});
	}

	private IDictionary<string, ContentFieldDefinition> AcquireContentFieldDefinitions()
	{
		return _cacheManager.Get("ContentFieldDefinitions", preventConcurrentCalls: true, delegate(AcquireContext<string> ctx)
		{
			MonitorContentDefinitionSignal(ctx);
			return _fieldDefinitionRepository.Table.Select(Build).ToDictionary((ContentFieldDefinition x) => x.Name, (ContentFieldDefinition y) => y);
		});
	}

	private ContentTypeDefinitionRecord Acquire(ContentTypeDefinition contentTypeDefinition)
	{
		ContentTypeDefinitionRecord contentTypeDefinitionRecord = _typeDefinitionRepository.Table.SingleOrDefault((ContentTypeDefinitionRecord x) => x.Name == contentTypeDefinition.Name);
		if (contentTypeDefinitionRecord == null)
		{
			contentTypeDefinitionRecord = new ContentTypeDefinitionRecord
			{
				Name = contentTypeDefinition.Name,
				DisplayName = contentTypeDefinition.DisplayName
			};
			_typeDefinitionRepository.Create(contentTypeDefinitionRecord);
		}
		return contentTypeDefinitionRecord;
	}

	private ContentPartDefinitionRecord Acquire(ContentPartDefinition contentPartDefinition)
	{
		ContentPartDefinitionRecord contentPartDefinitionRecord = _partDefinitionRepository.Table.SingleOrDefault((ContentPartDefinitionRecord x) => x.Name == contentPartDefinition.Name);
		if (contentPartDefinitionRecord == null)
		{
			contentPartDefinitionRecord = new ContentPartDefinitionRecord
			{
				Name = contentPartDefinition.Name
			};
			_partDefinitionRepository.Create(contentPartDefinitionRecord);
		}
		return contentPartDefinitionRecord;
	}

	private ContentFieldDefinitionRecord Acquire(ContentFieldDefinition contentFieldDefinition)
	{
		ContentFieldDefinitionRecord contentFieldDefinitionRecord = _fieldDefinitionRepository.Table.SingleOrDefault((ContentFieldDefinitionRecord x) => x.Name == contentFieldDefinition.Name);
		if (contentFieldDefinitionRecord == null)
		{
			contentFieldDefinitionRecord = new ContentFieldDefinitionRecord
			{
				Name = contentFieldDefinition.Name
			};
			_fieldDefinitionRepository.Create(contentFieldDefinitionRecord);
		}
		return contentFieldDefinitionRecord;
	}

	private void Apply(ContentTypeDefinition model, ContentTypeDefinitionRecord record)
	{
		record.DisplayName = model.DisplayName;
		record.Settings = _settingsFormatter.Map(model.Settings).ToString();
		foreach (ContentTypePartDefinitionRecord item in record.ContentTypePartDefinitionRecords.Where((ContentTypePartDefinitionRecord partDefinitionRecord) => model.Parts.All((ContentTypePartDefinition part) => partDefinitionRecord.ContentPartDefinitionRecord.Name != part.PartDefinition.Name)).ToList())
		{
			record.ContentTypePartDefinitionRecords.Remove(item);
		}
		foreach (ContentTypePartDefinition part in model.Parts)
		{
			string partName = part.PartDefinition.Name;
			ContentTypePartDefinitionRecord contentTypePartDefinitionRecord = record.ContentTypePartDefinitionRecords.SingleOrDefault((ContentTypePartDefinitionRecord r) => r.ContentPartDefinitionRecord.Name == partName);
			if (contentTypePartDefinitionRecord == null)
			{
				contentTypePartDefinitionRecord = new ContentTypePartDefinitionRecord
				{
					ContentPartDefinitionRecord = Acquire(part.PartDefinition)
				};
				record.ContentTypePartDefinitionRecords.Add(contentTypePartDefinitionRecord);
			}
			Apply(part, contentTypePartDefinitionRecord);
		}
	}

	private void Apply(ContentTypePartDefinition model, ContentTypePartDefinitionRecord record)
	{
		record.Settings = Compose(_settingsFormatter.Map(model.Settings));
	}

	private void Apply(ContentPartDefinition model, ContentPartDefinitionRecord record)
	{
		record.Settings = _settingsFormatter.Map(model.Settings).ToString();
		foreach (ContentPartFieldDefinitionRecord item in record.ContentPartFieldDefinitionRecords.Where((ContentPartFieldDefinitionRecord partFieldDefinitionRecord) => model.Fields.All((ContentPartFieldDefinition partField) => partFieldDefinitionRecord.Name != partField.Name)).ToList())
		{
			record.ContentPartFieldDefinitionRecords.Remove(item);
		}
		foreach (ContentPartFieldDefinition field in model.Fields)
		{
			string fieldName = field.Name;
			ContentPartFieldDefinitionRecord contentPartFieldDefinitionRecord = record.ContentPartFieldDefinitionRecords.SingleOrDefault((ContentPartFieldDefinitionRecord r) => r.Name == fieldName);
			if (contentPartFieldDefinitionRecord == null)
			{
				contentPartFieldDefinitionRecord = new ContentPartFieldDefinitionRecord
				{
					ContentFieldDefinitionRecord = Acquire(field.FieldDefinition),
					Name = field.Name
				};
				record.ContentPartFieldDefinitionRecords.Add(contentPartFieldDefinitionRecord);
			}
			Apply(field, contentPartFieldDefinitionRecord);
		}
	}

	private void Apply(ContentPartFieldDefinition model, ContentPartFieldDefinitionRecord record)
	{
		record.Settings = Compose(_settingsFormatter.Map(model.Settings));
	}

	private ContentTypeDefinition Build(ContentTypeDefinitionRecord source)
	{
		return new ContentTypeDefinition(source.Name, source.DisplayName, source.ContentTypePartDefinitionRecords.Select(Build), _settingsFormatter.Map(Parse(source.Settings)));
	}

	private ContentTypePartDefinition Build(ContentTypePartDefinitionRecord source)
	{
		return new ContentTypePartDefinition(Build(source.ContentPartDefinitionRecord), _settingsFormatter.Map(Parse(source.Settings)));
	}

	private ContentPartDefinition Build(ContentPartDefinitionRecord source)
	{
		return new ContentPartDefinition(source.Name, source.ContentPartFieldDefinitionRecords.Select(Build), _settingsFormatter.Map(Parse(source.Settings)));
	}

	private ContentPartFieldDefinition Build(ContentPartFieldDefinitionRecord source)
	{
		return new ContentPartFieldDefinition(Build(source.ContentFieldDefinitionRecord), source.Name, _settingsFormatter.Map(Parse(source.Settings)));
	}

	private ContentFieldDefinition Build(ContentFieldDefinitionRecord source)
	{
		return new ContentFieldDefinition(source.Name);
	}

	private XElement Parse(string settings)
	{
		if (string.IsNullOrEmpty(settings))
		{
			return null;
		}
		try
		{
			return XElement.Parse(settings);
		}
		catch (Exception ex)
		{
			if (ex.IsFatal())
			{
				throw;
			}
			base.Logger.Error(ex, "Unable to parse settings xml");
			return null;
		}
	}

	private static string Compose(XElement map)
	{
		return map?.ToString();
	}
}
