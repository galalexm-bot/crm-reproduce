using System;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Exceptions;
using EleWise.ELMA.Documents.Managers;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Files;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Documents.Components;

[Component(Order = 100)]
public class DocumentBinaryFileParentEntity : IBinaryFileParentEntity
{
	public IEntity GetEntity(BinaryFile file)
	{
		InstanceOf<IDocumentVersionFilter> instanceOf = new InstanceOf<IDocumentVersionFilter>();
		instanceOf.New.File = file;
		instanceOf.New.DisableSecurity = true;
		IDocumentVersionFilter @new = instanceOf.New;
		IDocumentVersion documentVersion = DocumentVersionManager.Instance.Find(@new, new FetchOptions(0, 1)).FirstOrDefault();
		if (documentVersion == null || documentVersion.Document == null)
		{
			return null;
		}
		return documentVersion.Document.CastAsRealType();
	}

	public SystemException CreateEncryptException(object id)
	{
		return new EncryptDocumentException(Convert.ToInt64(id));
	}
}
