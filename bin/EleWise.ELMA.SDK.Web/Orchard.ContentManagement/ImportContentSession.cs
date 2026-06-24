using System;
using System.Collections.Generic;
using System.Linq;

namespace Orchard.ContentManagement;

public class ImportContentSession
{
	private readonly IContentManager _contentManager;

	private readonly Dictionary<ContentIdentity, int> _identities;

	private readonly Dictionary<ContentIdentity, string> _contentTypes;

	private readonly Dictionary<int, int> _draftVersionRecordIds;

	private readonly List<ContentIdentity> _allIdentitiesForImport;

	private readonly Dictionary<ContentIdentity, bool> _allIdentitiesForImportStatus;

	private readonly Queue<ContentIdentity> _dependencyIdentities;

	private int _startIndex;

	private int _batchSize = 100;

	private int _currentIndex;

	public ImportContentSession(IContentManager contentManager)
	{
		ContentIdentity.ContentIdentityEqualityComparer comparer = new ContentIdentity.ContentIdentityEqualityComparer();
		_contentManager = contentManager;
		_identities = new Dictionary<ContentIdentity, int>(comparer);
		_contentTypes = new Dictionary<ContentIdentity, string>(comparer);
		_draftVersionRecordIds = new Dictionary<int, int>();
		_allIdentitiesForImport = new List<ContentIdentity>();
		_allIdentitiesForImportStatus = new Dictionary<ContentIdentity, bool>(comparer);
		_dependencyIdentities = new Queue<ContentIdentity>();
	}

	public void Set(string id, string contentType)
	{
		ContentIdentity contentIdentity = new ContentIdentity(id);
		_contentTypes[contentIdentity] = contentType;
		_allIdentitiesForImport.Add(contentIdentity);
		_allIdentitiesForImportStatus[contentIdentity] = false;
	}

	public void InitializeBatch(int startIndex, int batchSize)
	{
		_currentIndex = (_startIndex = startIndex);
		_batchSize = batchSize;
	}

	public ContentIdentity GetNextInBatch()
	{
		if (_dependencyIdentities.Any())
		{
			ContentIdentity contentIdentity = _dependencyIdentities.Dequeue();
			_allIdentitiesForImportStatus[contentIdentity] = true;
			return contentIdentity;
		}
		while (_currentIndex < _allIdentitiesForImport.Count && _allIdentitiesForImportStatus[_allIdentitiesForImport[_currentIndex]])
		{
			_currentIndex++;
		}
		if (_currentIndex < _startIndex + _batchSize && _currentIndex < _allIdentitiesForImport.Count)
		{
			ContentIdentity contentIdentity = _allIdentitiesForImport[_currentIndex];
			_allIdentitiesForImportStatus[contentIdentity] = true;
			_currentIndex++;
			return contentIdentity;
		}
		return null;
	}

	public ContentItem Get(string id, string contentTypeHint = null)
	{
		return Get(id, VersionOptions.Latest, contentTypeHint);
	}

	public ContentItem Get(string id, VersionOptions versionOptions, string contentTypeHint = null)
	{
		ContentIdentity contentIdentity = new ContentIdentity(id);
		if (_identities.ContainsKey(contentIdentity))
		{
			if (_draftVersionRecordIds.ContainsKey(_identities[contentIdentity]))
			{
				versionOptions = VersionOptions.VersionRecord(_draftVersionRecordIds[_identities[contentIdentity]]);
			}
			ContentItem contentItem = _contentManager.Get(_identities[contentIdentity], versionOptions);
			if (contentTypeHint == null || contentItem.ContentType == contentTypeHint)
			{
				return contentItem;
			}
		}
		ContentItem contentItem2 = _contentManager.ResolveIdentity(contentIdentity);
		if (contentItem2 != null)
		{
			contentItem2 = _contentManager.Get(contentItem2.Id, versionOptions);
		}
		if (contentItem2 == null && _identities.ContainsKey(contentIdentity))
		{
			contentItem2 = _contentManager.Get(_identities[contentIdentity], versionOptions);
		}
		if (contentItem2 != null)
		{
			_identities[contentIdentity] = contentItem2.Id;
			return contentItem2;
		}
		if (_allIdentitiesForImportStatus.ContainsKey(contentIdentity))
		{
			string contentType = (_contentTypes.ContainsKey(contentIdentity) ? _contentTypes[contentIdentity] : contentTypeHint);
			if (!_contentTypes.ContainsKey(contentIdentity))
			{
				throw new ArgumentException("Unknown content type for " + id);
			}
			ContentItem contentItem3 = _contentManager.Create(contentType, VersionOptions.Draft);
			_identities[contentIdentity] = contentItem3.Id;
			_draftVersionRecordIds[contentItem3.Id] = contentItem3.VersionRecord.Id;
			if (_allIdentitiesForImportStatus.ContainsKey(contentIdentity) && !_allIdentitiesForImportStatus[contentIdentity])
			{
				_dependencyIdentities.Enqueue(contentIdentity);
			}
			return contentItem3;
		}
		return null;
	}
}
