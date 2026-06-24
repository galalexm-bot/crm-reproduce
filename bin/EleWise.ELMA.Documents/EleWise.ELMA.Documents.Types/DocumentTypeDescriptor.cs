using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Metadata;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Serialization;

namespace EleWise.ELMA.Documents.Types;

[Component(Order = 500)]
public class DocumentTypeDescriptor : EntityDescriptor
{
	protected static string CurrentVersionPropertyName = LinqUtils.NameOf((Expression<Func<IDocument, object>>)((IDocument a) => a.CurrentVersion));

	public const string FolderVariableKey = "FolderContextVariable";

	public const string RestrictFolderChangeVariableKey = "RestrictFolderChangeVariable";

	public new const string UID_S = "{A3A41AE4-30E2-4C46-BBA2-EE55EFDC7B90}";

	public new static readonly Guid UID = new Guid("{A3A41AE4-30E2-4C46-BBA2-EE55EFDC7B90}");

	public override Guid Uid => UID;

	public override string Name => SR.T("Документы");

	public EntityDescriptor EntityDescriptor { get; set; }

	protected override bool IsSupportedMetadataType(Type type, ClassMetadata classMetadata)
	{
		return type == typeof(DocumentMetadata);
	}

	public override string GetTypeDisplayName(Guid subTypeUid)
	{
		ClassMetadata metadata = GetMetadata(subTypeUid);
		return string.Format("{0} ({1})", SR.T(metadata.GetDisplayName()), SR.T("Документ"));
	}

	public override bool IsPublicApplicationEditorEnabled(Guid subTypeUid)
	{
		return true;
	}

	public new object SerializeSimple(object value, Type valueType, EntitySerializationSettings settings)
	{
		if (typeof(IDocument).IsAssignableFrom(valueType))
		{
			IDictionary<string, object> dictionary = base.SerializeSimple(value, valueType, settings) as IDictionary<string, object>;
			if (value is IDocument document && dictionary != null && !dictionary.ContainsKey(CurrentVersionPropertyName) && document.CurrentVersion?.Document != null)
			{
				object value2 = EntityDescriptor.SerializeSimple(document.CurrentVersion);
				dictionary.Add(CurrentVersionPropertyName, value2);
			}
			return dictionary;
		}
		return base.SerializeSimple(value, valueType, settings);
	}
}
