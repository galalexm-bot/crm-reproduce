using System.Collections.Generic;
using System.Linq;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.SqlCommand;
using Orchard.Caching;
using Orchard.ContentManagement.Records;
using Orchard.Data;
using Orchard.Utility.Extensions;

namespace Orchard.ContentManagement;

public class DefaultContentQuery : IContentQuery
{
	private class ContentQuery<T> : IContentQuery<T>, IContentQuery where T : IContent
	{
		protected readonly DefaultContentQuery _query;

		public IContentManager ContentManager => _query.ContentManager;

		public ContentQuery(DefaultContentQuery query)
		{
			_query = query;
		}

		IContentQuery<TPart> IContentQuery.ForPart<TPart>()
		{
			return new ContentQuery<TPart>(_query);
		}

		IContentQuery<T> IContentQuery<T>.ForType(params string[] contentTypes)
		{
			_query.ForType(contentTypes);
			return this;
		}

		IEnumerable<T> IContentQuery<T>.List()
		{
			return _query.Slice(0, 0).AsPart<T>();
		}
	}

	private readonly ITransactionManager _transactionManager;

	private ISession _session;

	private ICriteria _itemVersionCriteria;

	private VersionOptions _versionOptions;

	private ICacheManager _cacheManager;

	private ISignals _signals;

	private IRepository<ContentTypeRecord> _contentTypeRepository;

	public IContentManager ContentManager { get; private set; }

	public DefaultContentQuery(IContentManager contentManager, ITransactionManager transactionManager, ICacheManager cacheManager, ISignals signals, IRepository<ContentTypeRecord> contentTypeRepository)
	{
		_transactionManager = transactionManager;
		ContentManager = contentManager;
		_cacheManager = cacheManager;
		_signals = signals;
		_contentTypeRepository = contentTypeRepository;
	}

	private ISession BindSession()
	{
		if (_session == null)
		{
			_session = _transactionManager.GetSession();
		}
		return _session;
	}

	private ICriteria BindCriteriaByPath(ICriteria criteria, string path)
	{
		return criteria.GetCriteriaByPath(path) ?? criteria.CreateCriteria(path);
	}

	private ICriteria BindTypeCriteria()
	{
		return BindCriteriaByPath(BindItemCriteria(), "ContentType");
	}

	private ICriteria BindItemCriteria()
	{
		return BindCriteriaByPath(BindItemVersionCriteria(), "ContentItemRecord");
	}

	private ICriteria BindItemVersionCriteria()
	{
		if (_itemVersionCriteria == null)
		{
			_itemVersionCriteria = BindSession().CreateCriteria<ContentItemVersionRecord>();
			_itemVersionCriteria.SetCacheable(true);
		}
		return _itemVersionCriteria;
	}

	private void ForType(params string[] contentTypeNames)
	{
		if (contentTypeNames != null)
		{
			if (contentTypeNames.Length == 1)
			{
				BindTypeCriteria().Add((ICriterion)(object)Restrictions.Eq("Name", (object)contentTypeNames[0]));
			}
			else
			{
				BindTypeCriteria().Add((ICriterion)(object)Restrictions.InG<string>("Name", (IEnumerable<string>)contentTypeNames));
			}
		}
	}

	private IEnumerable<ContentItem> Slice(int skip, int count)
	{
		ICriteria val = BindItemVersionCriteria();
		val.ApplyVersionOptionsRestrictions(_versionOptions);
		val.SetFetchMode("ContentItemRecord", (FetchMode)2);
		val.SetFetchMode("ContentItemRecord.ContentType", (FetchMode)2);
		if (skip != 0)
		{
			val = val.SetFirstResult(skip);
		}
		if (count != 0)
		{
			val = val.SetMaxResults(count);
		}
		return (from x in val.List<ContentItemVersionRecord>()
			select ContentManager.Get(x.ContentItemRecord.Id, VersionOptions.VersionRecord(x.Id))).ToReadOnlyCollection();
	}

	private static ICriteria ExtendCriteria(ICriteria criteria, string segment)
	{
		return criteria.GetCriteriaByPath(segment) ?? criteria.CreateCriteria(segment, (JoinType)1);
	}

	IContentQuery<TPart> IContentQuery.ForPart<TPart>()
	{
		return new ContentQuery<TPart>(this);
	}
}
