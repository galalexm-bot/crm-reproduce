using System;
using System.Collections.Generic;
using System.Linq;
using Autofac;
using Autofac.Core;
using EleWise.ELMA.Logging;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.Metadata;
using NHibernate.SqlCommand;
using NHibernate.Transform;
using Orchard.Caching;
using Orchard.ContentManagement.Handlers;
using Orchard.ContentManagement.MetaData;
using Orchard.ContentManagement.MetaData.Builders;
using Orchard.ContentManagement.MetaData.Models;
using Orchard.ContentManagement.Records;
using Orchard.Data;

namespace Orchard.ContentManagement;

public class DefaultContentManager : IContentManager, IDependency
{
	private readonly IComponentContext _context;

	private readonly IRepository<ContentTypeRecord> _contentTypeRepository;

	private readonly IRepository<ContentItemRecord> _contentItemRepository;

	private readonly IRepository<ContentItemVersionRecord> _contentItemVersionRepository;

	private readonly IContentDefinitionManager _contentDefinitionManager;

	private readonly ICacheManager _cacheManager;

	private readonly Func<IContentManagerSession> _contentManagerSession;

	private readonly Lazy<ITransactionManager> _transactionManager;

	private readonly Lazy<IEnumerable<IContentHandler>> _handlers;

	private readonly Lazy<IEnumerable<IIdentityResolverSelector>> _identityResolverSelectors;

	private readonly ISignals _signals;

	public ILogger Logger { get; set; }

	public IEnumerable<IContentHandler> Handlers => _handlers.Value;

	public DefaultContentManager(IComponentContext context, IRepository<ContentTypeRecord> contentTypeRepository, IRepository<ContentItemRecord> contentItemRepository, IRepository<ContentItemVersionRecord> contentItemVersionRepository, IContentDefinitionManager contentDefinitionManager, ICacheManager cacheManager, Func<IContentManagerSession> contentManagerSession, Lazy<ITransactionManager> transactionManager, Lazy<IEnumerable<IContentHandler>> handlers, Lazy<IEnumerable<IIdentityResolverSelector>> identityResolverSelectors, ISignals signals)
	{
		_context = context;
		_contentTypeRepository = contentTypeRepository;
		_contentItemRepository = contentItemRepository;
		_contentItemVersionRepository = contentItemVersionRepository;
		_contentDefinitionManager = contentDefinitionManager;
		_cacheManager = cacheManager;
		_contentManagerSession = contentManagerSession;
		_identityResolverSelectors = identityResolverSelectors;
		_signals = signals;
		_handlers = handlers;
		_transactionManager = transactionManager;
		Logger = NullLogger.Instance;
	}

	public virtual ContentItem New(string contentType)
	{
		ContentTypeDefinition contentTypeDefinition = _contentDefinitionManager.GetTypeDefinition(contentType);
		if (contentTypeDefinition == null)
		{
			contentTypeDefinition = new ContentTypeDefinitionBuilder().Named(contentType).Build();
		}
		ActivatingContentContext context = new ActivatingContentContext
		{
			ContentType = contentTypeDefinition.Name,
			Definition = contentTypeDefinition,
			Builder = new ContentItemBuilder(contentTypeDefinition)
		};
		Handlers.Invoke(delegate(IContentHandler handler)
		{
			handler.Activating(context);
		}, Logger);
		ActivatedContentContext context2 = new ActivatedContentContext
		{
			ContentType = contentType,
			ContentItem = context.Builder.Build()
		};
		context2.ContentItem.ContentManager = this;
		Handlers.Invoke(delegate(IContentHandler handler)
		{
			handler.Activated(context2);
		}, Logger);
		InitializingContentContext context3 = new InitializingContentContext
		{
			ContentType = context2.ContentType,
			ContentItem = context2.ContentItem
		};
		Handlers.Invoke(delegate(IContentHandler handler)
		{
			handler.Initializing(context3);
		}, Logger);
		Handlers.Invoke(delegate(IContentHandler handler)
		{
			handler.Initialized(context3);
		}, Logger);
		return context3.ContentItem;
	}

	public virtual ContentItem Get(int id, VersionOptions options)
	{
		return Get(id, options, QueryHints.Empty);
	}

	public virtual ContentItem Get(int id, VersionOptions options, QueryHints hints)
	{
		IContentManagerSession contentManagerSession = _contentManagerSession();
		ContentItemVersionRecord contentItemVersionRecord = null;
		ContentItem item;
		if (options.VersionRecordId != 0)
		{
			if (contentManagerSession.RecallVersionRecordId(options.VersionRecordId, out item))
			{
				return item;
			}
			contentItemVersionRecord = _contentItemVersionRepository.Get(options.VersionRecordId);
		}
		else if (contentManagerSession.RecallContentRecordId(id, out item))
		{
			if (options.IsPublished)
			{
				return item;
			}
			contentItemVersionRecord = item.VersionRecord;
		}
		else
		{
			contentItemVersionRecord = GetManyImplementation(hints, id, options).LastOrDefault();
		}
		if (contentItemVersionRecord == null)
		{
			ContentItemRecord contentItemRecord = _contentItemRepository.Get(id);
			if (contentItemRecord == null)
			{
				return null;
			}
			contentItemVersionRecord = GetVersionRecord(options, contentItemRecord);
			if (contentItemVersionRecord == null)
			{
				return null;
			}
		}
		if (contentManagerSession.RecallVersionRecordId(contentItemVersionRecord.Id, out item))
		{
			return item;
		}
		item = New(contentItemVersionRecord.ContentItemRecord.ContentType.Name);
		item.VersionRecord = contentItemVersionRecord;
		contentManagerSession.Store(item);
		LoadContentContext context = new LoadContentContext(item);
		Handlers.Invoke(delegate(IContentHandler handler)
		{
			handler.Loading(context);
		}, Logger);
		Handlers.Invoke(delegate(IContentHandler handler)
		{
			handler.Loaded(context);
		}, Logger);
		return item;
	}

	private ContentItemVersionRecord GetVersionRecord(VersionOptions options, ContentItemRecord itemRecord)
	{
		if (options.IsPublished)
		{
			return itemRecord.Versions.FirstOrDefault((ContentItemVersionRecord x) => x.Published) ?? _contentItemVersionRepository.Get((ContentItemVersionRecord x) => x.ContentItemRecord == itemRecord && x.Published);
		}
		if (options.IsLatest)
		{
			return itemRecord.Versions.FirstOrDefault((ContentItemVersionRecord x) => x.Latest) ?? _contentItemVersionRepository.Get((ContentItemVersionRecord x) => x.ContentItemRecord == itemRecord && x.Latest);
		}
		if (options.IsDraft)
		{
			return itemRecord.Versions.FirstOrDefault((ContentItemVersionRecord x) => x.Latest && !x.Published) ?? _contentItemVersionRepository.Get((ContentItemVersionRecord x) => x.ContentItemRecord == itemRecord && x.Latest && !x.Published);
		}
		return null;
	}

	private IEnumerable<ContentItemVersionRecord> GetManyImplementation(QueryHints hints, int id, VersionOptions options)
	{
		//IL_0343: Unknown result type (might be due to invalid IL or missing references)
		//IL_034d: Expected O, but got Unknown
		ISession session = _transactionManager.Value.GetSession();
		ICriteria val = session.CreateCriteria(typeof(ContentItemVersionRecord));
		ICriteria val2 = val.CreateCriteria("ContentItemRecord");
		val2.Add((ICriterion)(object)Restrictions.Eq("Id", (object)id));
		if (options.IsPublished)
		{
			val.Add((ICriterion)(object)Restrictions.Eq("Published", (object)true));
		}
		else if (options.IsLatest)
		{
			val.Add((ICriterion)(object)Restrictions.Eq("Latest", (object)true));
		}
		else if (options.IsDraft)
		{
			val.Add((ICriterion)(object)Restrictions.And((ICriterion)(object)Restrictions.Eq("Published", (object)false), (ICriterion)(object)Restrictions.Eq("Latest", (object)true)));
		}
		val.SetFetchMode("ContentItemRecord", (FetchMode)2);
		val.SetFetchMode("ContentItemRecord.ContentType", (FetchMode)2);
		IClassMetadata classMetadata = session.get_SessionFactory().GetClassMetadata(typeof(ContentItemRecord));
		IClassMetadata classMetadata2 = session.get_SessionFactory().GetClassMetadata(typeof(ContentItemVersionRecord));
		if (hints != QueryHints.Empty)
		{
			var hintDictionary = (from hint in hints.Records
				select new
				{
					Hint = hint,
					Segments = hint.Split('.')
				} into item
				group item by item.Segments.FirstOrDefault()).ToDictionary(grouping => grouping.Key, StringComparer.InvariantCultureIgnoreCase);
			foreach (var item in classMetadata2.get_PropertyNames().Where(hintDictionary.ContainsKey).SelectMany((string key) => hintDictionary[key]))
			{
				val.SetFetchMode(item.Hint, (FetchMode)2);
				item.Segments.Take(item.Segments.Count() - 1).Aggregate<string, ICriteria>(val, ExtendCriteria);
			}
			foreach (var item2 in classMetadata.get_PropertyNames().Where(hintDictionary.ContainsKey).SelectMany((string key) => hintDictionary[key]))
			{
				val.SetFetchMode("ContentItemRecord." + item2.Hint, (FetchMode)2);
				item2.Segments.Take(item2.Segments.Count() - 1).Aggregate<string, ICriteria>(val2, ExtendCriteria);
			}
			if (hintDictionary.SelectMany(x => x.Value).Any(x => x.Segments.Count() > 1))
			{
				val.SetResultTransformer((IResultTransformer)new DistinctRootEntityResultTransformer());
			}
		}
		val2.SetCacheable(true);
		return val.List<ContentItemVersionRecord>();
	}

	private static ICriteria ExtendCriteria(ICriteria criteria, string segment)
	{
		return criteria.GetCriteriaByPath(segment) ?? criteria.CreateCriteria(segment, (JoinType)1);
	}

	public virtual void Create(ContentItem contentItem)
	{
		Create(contentItem, VersionOptions.Published);
	}

	public virtual void Create(ContentItem contentItem, VersionOptions options)
	{
		if (contentItem.VersionRecord == null)
		{
			contentItem.VersionRecord = new ContentItemVersionRecord
			{
				ContentItemRecord = new ContentItemRecord(),
				Number = 1,
				Latest = true,
				Published = true
			};
		}
		contentItem.VersionRecord.ContentItemRecord.Versions.Add(contentItem.VersionRecord);
		if (options.IsDraft)
		{
			contentItem.VersionRecord.Published = false;
		}
		_contentItemRepository.Create(contentItem.Record);
		_contentItemVersionRepository.Create(contentItem.VersionRecord);
		CreateContentContext context = new CreateContentContext(contentItem);
		Handlers.Invoke(delegate(IContentHandler handler)
		{
			handler.Creating(context);
		}, Logger);
		contentItem.VersionRecord.ContentItemRecord.ContentType = AcquireContentTypeRecord(contentItem.ContentType);
		Handlers.Invoke(delegate(IContentHandler handler)
		{
			handler.Created(context);
		}, Logger);
		if (options.IsPublished)
		{
			PublishContentContext publishContext = new PublishContentContext(contentItem, null);
			Handlers.Invoke(delegate(IContentHandler handler)
			{
				handler.Publishing(publishContext);
			}, Logger);
			Handlers.Invoke(delegate(IContentHandler handler)
			{
				handler.Published(publishContext);
			}, Logger);
		}
	}

	public ContentItem ResolveIdentity(ContentIdentity contentIdentity)
	{
		IOrderedEnumerable<IdentityResolverSelectorResult> orderedEnumerable = from x in _identityResolverSelectors.Value
			select x.GetResolver(contentIdentity) into x
			where x != null
			orderby x.Priority descending
			select x;
		if (!orderedEnumerable.Any())
		{
			return null;
		}
		IEnumerable<ContentItem> enumerable = null;
		foreach (IdentityResolverSelectorResult item in orderedEnumerable)
		{
			ContentItem[] array = item.Resolve(contentIdentity).ToArray();
			enumerable = ((enumerable != null) ? enumerable.Intersect(array).ToArray() : array);
			if (enumerable.Count() == 1)
			{
				return enumerable.First();
			}
		}
		return enumerable.FirstOrDefault();
	}

	public ContentItemMetadata GetItemMetadata(IContent content)
	{
		GetContentItemMetadataContext context = new GetContentItemMetadataContext
		{
			ContentItem = content.ContentItem,
			Metadata = new ContentItemMetadata()
		};
		Handlers.Invoke(delegate(IContentHandler handler)
		{
			handler.GetContentItemMetadata(context);
		}, Logger);
		return context.Metadata;
	}

	public IContentQuery<ContentItem> Query()
	{
		return ResolutionExtensions.Resolve<IContentQuery>(_context, (Parameter[])(object)new Parameter[1] { (Parameter)TypedParameter.From<IContentManager>((IContentManager)this) }).ForPart<ContentItem>();
	}

	private ContentTypeRecord AcquireContentTypeRecord(string contentType)
	{
		int id = _cacheManager.Get(contentType + "_Record", preventConcurrentCalls: true, delegate(AcquireContext<string> ctx)
		{
			ctx.Monitor(_signals.When(contentType + "_Record"));
			ContentTypeRecord contentTypeRecord2 = _contentTypeRepository.Get((ContentTypeRecord x) => x.Name == contentType);
			if (contentTypeRecord2 == null)
			{
				contentTypeRecord2 = new ContentTypeRecord
				{
					Name = contentType
				};
				_contentTypeRepository.Create(contentTypeRecord2);
			}
			return contentTypeRecord2.Id;
		});
		ContentTypeRecord contentTypeRecord = _contentTypeRepository.Get(id);
		if (contentTypeRecord != null && contentTypeRecord.Name.Equals(contentType, StringComparison.OrdinalIgnoreCase))
		{
			return contentTypeRecord;
		}
		_signals.Trigger(contentType + "_Record");
		return AcquireContentTypeRecord(contentType);
	}
}
