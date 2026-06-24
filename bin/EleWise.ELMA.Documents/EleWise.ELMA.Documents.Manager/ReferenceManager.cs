using System;
using System.Collections.Generic;
using System.Security;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Documents.Managers;

public class ReferenceManager<T, TId> : DmsObjectManager<T, TId> where T : IReference, IEntity<TId>
{
	public override SecurityException CreateSecurityException(string text, object id)
	{
		IMetadata metadata = MetadataLoader.LoadMetadata(typeof(T));
		return new EntitySecurityException(text)
		{
			TypeUid = metadata.Uid,
			EntityId = Convert.ToInt64(id),
			Permissions = new List<Guid>
			{
				PermissionProvider.DocumentFullAccessPermission.Id,
				PermissionProvider.DocumentManagerAccessPermission.Id
			}
		};
	}
}
public class ReferenceManager : ReferenceManager<IReference, long>
{
	public new static ReferenceManager Instance => Locator.GetServiceNotNull<ReferenceManager>();
}
