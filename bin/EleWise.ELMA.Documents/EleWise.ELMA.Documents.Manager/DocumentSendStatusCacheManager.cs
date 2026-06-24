using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Documents.Metadata;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Documents.Managers;

public class DocumentSendStatusCacheManager : EntityManager<IDocumentSendStatusCache, long>
{
	public new static DocumentSendStatusCacheManager Instance => Locator.GetServiceNotNull<DocumentSendStatusCacheManager>();

	public ILockManager LockManager { get; set; }

	[Transaction]
	public virtual void Recreate()
	{
		EntityMetadata entityMetadata = (EntityMetadata)InterfaceActivator.LoadMetadata<IDocumentSendStatusCache>();
		ITransformationProvider serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
		for (short num = entityMetadata.LastTableNumber; num >= 0; num = (short)(num - 1))
		{
			serviceNotNull.ExecuteNonQuery($"delete from {serviceNotNull.Dialect.QuoteIfNeeded(EntityPropertyMetadata.GetTableName(entityMetadata.TableName, num))}");
		}
		IMetadataRuntimeService runtimeMetadataService = Locator.GetServiceNotNull<IMetadataRuntimeService>();
		List<Type> list = (from m in base.MetadataRuntimeService.GetMetadataList().OfType<DocumentMetadata>()
			where m.ControlOnSending
			select runtimeMetadataService.GetTypeByUid(m.Uid)).Distinct().ToList();
		InstanceOf<IDocumentFilter> instanceOf = new InstanceOf<IDocumentFilter>();
		instanceOf.New.DisableSecurity = true;
		IDocumentFilter @new = instanceOf.New;
		foreach (Type item in list)
		{
			foreach (IDocument item2 in EntityHelper.GetEntityManager(item).Find(@new, FetchOptions.All))
			{
				if (item2 is ISendableDocument sendableDocument)
				{
					InstanceOf<IDocumentSendStatusCache> instanceOf2 = new InstanceOf<IDocumentSendStatusCache>();
					instanceOf2.New.Document = item2;
					instanceOf2.New.SendDate = sendableDocument.SendDate;
					instanceOf2.New.ScanCopy = sendableDocument.SendScanCopy;
					instanceOf2.New.SendDocumentType = sendableDocument.SendDocumentType;
					instanceOf2.New.SendNumber = sendableDocument.SendNumber;
					instanceOf2.New.SendStatus = sendableDocument.SendStatus;
					instanceOf2.New.SendUser = sendableDocument.SendUser;
					instanceOf2.New.Save();
				}
			}
		}
	}

	[Transaction]
	public virtual void CreateOrUpdateByDocument(IDocument document)
	{
		if (!(document is ISendableDocument sendableDocument))
		{
			return;
		}
		string lockName = $"EleWise.ELMA.Documents.Managers.DocumentSendStatusCacheManager-{document.Id}";
		using (LockManager.Lock(lockName))
		{
			InstanceOf<IDocumentSendStatusCacheFilter> instanceOf = new InstanceOf<IDocumentSendStatusCacheFilter>();
			instanceOf.New.Document = document;
			IDocumentSendStatusCache obj = Find(instanceOf.New, new FetchOptions(0, 1)).FirstOrDefault() ?? InterfaceActivator.Create<IDocumentSendStatusCache>();
			obj.Document = document;
			obj.SendDate = sendableDocument.SendDate;
			obj.ScanCopy = sendableDocument.SendScanCopy;
			obj.SendDocumentType = sendableDocument.SendDocumentType;
			obj.SendNumber = sendableDocument.SendNumber;
			obj.SendStatus = sendableDocument.SendStatus;
			obj.SendUser = sendableDocument.SendUser;
			obj.Save();
			base.Session.Flush();
		}
	}
}
