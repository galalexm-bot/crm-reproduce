using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Metadata;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Documents.Components;

[Component]
public class DocumentSystemCryptoColumns : ISystemCryptoColumns
{
	public IEnumerable<string> PropertyNames
	{
		get
		{
			yield return LinqUtils.NameOf((Expression<Func<IDmsObject, object>>)((IDmsObject d) => d.Uid));
			yield return LinqUtils.NameOf((Expression<Func<IDmsObject, object>>)((IDmsObject d) => d.Folder));
			yield return LinqUtils.NameOf((Expression<Func<IDmsObject, object>>)((IDmsObject d) => d.OldFolder));
			yield return LinqUtils.NameOf((Expression<Func<IDmsObject, object>>)((IDmsObject d) => d.Permissions));
			yield return LinqUtils.NameOf((Expression<Func<IDmsObject, object>>)((IDmsObject d) => d.SortTypeId));
			yield return LinqUtils.NameOf((Expression<Func<IDmsObject, object>>)((IDmsObject d) => d.InheritPermissions));
			yield return LinqUtils.NameOf((Expression<Func<IDmsObject, object>>)((IDmsObject d) => d.Virtual));
			yield return LinqUtils.NameOf((Expression<Func<IDmsObject, object>>)((IDmsObject d) => d.IsArchived));
			yield return LinqUtils.NameOf((Expression<Func<IDmsObject, object>>)((IDmsObject d) => d.IsDeleted));
			yield return LinqUtils.NameOf((Expression<Func<IDmsObject, object>>)((IDmsObject d) => d.HardDelete));
			yield return LinqUtils.NameOf((Expression<Func<IDocument, object>>)((IDocument d) => d.CurrentVersion));
			yield return LinqUtils.NameOf((Expression<Func<IDocument, object>>)((IDocument d) => d.Encrypt));
			yield return LinqUtils.NameOf((Expression<Func<IDocument, object>>)((IDocument d) => d.EncryptDate));
			yield return LinqUtils.NameOf((Expression<Func<IDocument, object>>)((IDocument d) => d.EncryptUser));
			yield return LinqUtils.NameOf((Expression<Func<IDocument, object>>)((IDocument d) => d.Salt));
			yield return LinqUtils.NameOf((Expression<Func<IDocument, object>>)((IDocument d) => d.CryptoToken));
		}
	}

	public bool CheckMetadata(IMetadata metadata)
	{
		return metadata is DocumentMetadata;
	}
}
