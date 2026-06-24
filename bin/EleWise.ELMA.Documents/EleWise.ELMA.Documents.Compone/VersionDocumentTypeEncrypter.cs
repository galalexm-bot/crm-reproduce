using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Managers;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types.Encrypters;
using EleWise.ELMA.Model.Types.Helpers;
using EleWise.ELMA.Security;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Documents.Components;

[Component(Order = 50)]
public class VersionDocumentTypeEncrypter : BaseTypeEncrypter
{
	public override bool CheckType(object obj, IMetadata propertyMetadata)
	{
		if (propertyMetadata is PropertyMetadata propertyMetadata2)
		{
			return propertyMetadata2.SubTypeUid == InterfaceActivator.UID<IDocumentVersion>(loadImplementation: false);
		}
		return false;
	}

	protected override string ObjectToString(object obj, IMetadata propertyMetadata)
	{
		if (obj == null)
		{
			return string.Empty;
		}
		return ClassSerializationHelper.SerializeObjectByXml(new EntityWrapper((IEntity)obj));
	}

	public override string Encrypt(object obj, string password, string salt, IMetadata propertyMetadata)
	{
		if (!(obj is IDocumentVersion version))
		{
			return null;
		}
		string plainText = ObjectToString(obj, propertyMetadata);
		DocumentVersionManager.Instance.Encrypt(version, password);
		return EncryptionHelper.Encrypt(plainText, salt, password);
	}

	public override object Decrypt(string encrypted, string password, string salt, IMetadata propertyMetadata)
	{
		string obj = EncryptionHelper.Decrypt(encrypted, salt, password);
		IDocumentVersion documentVersion = (IDocumentVersion)GetObjectFromString(obj, propertyMetadata);
		if (documentVersion == null)
		{
			return null;
		}
		DocumentVersionManager.Instance.Decrypt(documentVersion, password);
		return documentVersion;
	}

	protected override object GetObjectFromString(string obj, IMetadata propertyMetadata)
	{
		if (string.IsNullOrEmpty(obj))
		{
			return null;
		}
		EntityWrapper entityWrapper = ClassSerializationHelper.DeserializeObjectByXml<EntityWrapper>(obj);
		IMetadataRuntimeService service = Locator.GetService<IMetadataRuntimeService>();
		if (service == null)
		{
			return null;
		}
		Type typeByUid = service.GetTypeByUid(entityWrapper.TypeUid);
		IEntityManager manager = ModelHelper.GetEntityManager(typeByUid);
		if (manager != null)
		{
			object res = null;
			Locator.GetServiceNotNull<ISecurityService>().RunWithElevatedPrivilegies(delegate
			{
				res = manager.LoadOrNull(entityWrapper.Id);
				manager.Refresh(res);
			});
			return res;
		}
		return null;
	}
}
