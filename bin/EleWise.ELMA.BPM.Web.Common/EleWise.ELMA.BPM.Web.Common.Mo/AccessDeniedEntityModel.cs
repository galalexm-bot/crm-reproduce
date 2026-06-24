using System;
using System.Collections.Generic;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Mvc.Models;

namespace EleWise.ELMA.BPM.Web.Common.Models;

public class AccessDeniedEntityModel : AccessDeniedModel
{
	private Lazy<List<EleWise.ELMA.Security.IUser>> _admins;

	private Lazy<object> _entity;

	public List<EleWise.ELMA.Security.IUser> GetAdmins()
	{
		if (_admins == null)
		{
			_admins = new Lazy<List<EleWise.ELMA.Security.IUser>>(delegate
			{
				if (base.Exception != null)
				{
					EntitySecurityException ex = (EntitySecurityException)base.Exception;
					List<EleWise.ELMA.Security.IUser> usersByPermissions = Locator.GetServiceNotNull<ISecurityService>().GetUsersByPermissions(ex.TypeUid, ex.EntityId, ex.Permissions);
					usersByPermissions.RemoveAll((EleWise.ELMA.Security.IUser usr) => ((EleWise.ELMA.Security.Models.IUser)usr).Status == UserStatus.Blocked);
					return usersByPermissions;
				}
				return null;
			});
		}
		return _admins.Value;
	}

	public object GetEntity()
	{
		if (_entity == null)
		{
			_entity = new Lazy<object>(delegate
			{
				if (base.Exception == null)
				{
					return null;
				}
				object res = null;
				Locator.GetServiceNotNull<ISecurityService>().RunWithElevatedPrivilegies(delegate
				{
					EntitySecurityException ex = (EntitySecurityException)base.Exception;
					IEntityManager entityManager = EntityHelper.GetEntityManager(Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(ex.TypeUid));
					res = entityManager.Load(ex.EntityId);
				});
				return res;
			});
		}
		return _entity.Value;
	}
}
