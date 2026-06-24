using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using Orchard.ContentManagement.MetaData.Models;
using Orchard.ContentManagement.Records;

namespace Orchard.ContentManagement;

public class ContentItem : DynamicObject, IContent
{
	private readonly IList<ContentPart> _parts;

	ContentItem IContent.ContentItem => this;

	public dynamic Content => this;

	public int Id
	{
		get
		{
			if (Record != null)
			{
				return Record.Id;
			}
			return 0;
		}
	}

	public int Version
	{
		get
		{
			if (VersionRecord != null)
			{
				return VersionRecord.Number;
			}
			return 0;
		}
	}

	public string ContentType { get; set; }

	public ContentTypeDefinition TypeDefinition { get; set; }

	public ContentItemRecord Record
	{
		get
		{
			if (VersionRecord != null)
			{
				return VersionRecord.ContentItemRecord;
			}
			return null;
		}
	}

	public ContentItemVersionRecord VersionRecord { get; set; }

	public IEnumerable<ContentPart> Parts => _parts;

	public IContentManager ContentManager { get; set; }

	public ContentItem()
	{
		_parts = new List<ContentPart>();
	}

	public bool Has(Type partType)
	{
		if (!(partType == typeof(ContentItem)))
		{
			return _parts.Any(partType.IsInstanceOfType);
		}
		return true;
	}

	public IContent Get(Type partType)
	{
		if (partType == typeof(ContentItem))
		{
			return this;
		}
		return _parts.FirstOrDefault(partType.IsInstanceOfType);
	}

	public void Weld(ContentPart part)
	{
		part.ContentItem = this;
		_parts.Add(part);
	}

	public override bool TryGetMember(GetMemberBinder binder, out object result)
	{
		if (!base.TryGetMember(binder, out result))
		{
			foreach (ContentPart part in Parts)
			{
				if (part.PartDefinition.Name == binder.Name)
				{
					result = part;
					return true;
				}
			}
			result = null;
			return true;
		}
		return true;
	}
}
