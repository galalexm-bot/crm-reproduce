using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Web;
using EleWise.ELMA.Cache.Attributes;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Files;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Documents.Managers;

[DeveloperApi(DeveloperApiType.Manager)]
public class WebDocumentManager<T, TId> : DocumentManager<T, TId> where T : IWebDocument, IEntity<TId>
{
	public IEnumerable<ITextContentExtractor> TextExtractors { get; set; }

	[ContextCache]
	public virtual bool IsWebDocument(IDocument document)
	{
		if (document == null)
		{
			return false;
		}
		return document.CastAsRealType() is IWebDocument;
	}

	[ContextCache]
	public virtual bool IsWebDocument(Guid typeUid)
	{
		return GetWebDocumentTypes(onlyChild: false).Any((ClassMetadata t) => t.Uid == typeUid);
	}

	[ContextCache]
	public virtual bool HasUserAttributes(IDocument document)
	{
		if (document == null)
		{
			return false;
		}
		if (document.TypeUid != InterfaceActivator.UID<IWebDocument>())
		{
			return true;
		}
		IMetadataRuntimeService serviceNotNull = Locator.GetServiceNotNull<IMetadataRuntimeService>();
		EntityMetadata entityMetadata = (EntityMetadata)InterfaceActivator.LoadMetadata<IWebDocument>();
		if (entityMetadata.ImplementedExtensionUids == null)
		{
			return false;
		}
		foreach (Guid item in entityMetadata.ImplementedExtensionUids.Where((Guid extensionUid) => extensionUid.IsConfigMetadata()))
		{
			Type typeByUid = serviceNotNull.GetTypeByUid(item, loadImplementation: false);
			if (typeByUid != null)
			{
				return typeByUid.GetReflectionProperties()?.Any() ?? false;
			}
		}
		return false;
	}

	[ContextCache]
	public virtual IEnumerable<ClassMetadata> GetWebDocumentTypes(bool onlyChild = true)
	{
		ClassMetadata classMetadata = (ClassMetadata)InterfaceActivator.LoadMetadata<IWebDocument>();
		List<ClassMetadata> childClasses = MetadataLoader.GetChildClasses(classMetadata);
		if (!onlyChild)
		{
			childClasses.Insert(0, classMetadata);
		}
		return childClasses;
	}

	public virtual IDocumentVersion CreateFromFile(BinaryFile file, IDocumentVersion version = null)
	{
		if (version == null)
		{
			version = InterfaceActivator.Create<IDocumentVersion>();
		}
		version.Content = new HtmlString(GetContentFromFile(file) ?? string.Empty);
		return version;
	}

	public virtual string GetContentFromFile(BinaryFile file)
	{
		using Stream stream = file.GetContent();
		string ext = file.Extension;
		ITextContentExtractor obj = TextExtractors.FirstOrDefault((ITextContentExtractor l) => l.Extensions.Contains(ext)) ?? TextExtractors.First();
		string text = obj.GetText(stream) ?? "";
		if (obj.NeedHtmlClear && !string.IsNullOrEmpty(text))
		{
			text = text.GetClearBodyFromHtml();
		}
		return text;
	}
}
[DeveloperApi(DeveloperApiType.Manager)]
public class WebDocumentManager : WebDocumentManager<IWebDocument, long>
{
	public new static WebDocumentManager Instance => Locator.GetServiceNotNull<WebDocumentManager>();
}
