using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.NH.Listeners;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate.Event;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Security.Listeners;

public class UserGroupListener : EntityEventsListener
{
	internal static UserGroupListener w9sM5HRUuWuVUie2iUM;

	public override bool OnPreDelete(PreDeleteEvent @event)
	{
		//Discarded unreachable code: IL_0031
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 3:
				NQUIZbRtlwUGM7wflgH(this, @event);
				num2 = 2;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_66aae9daa3f84bb5931ed90b4759f85c == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				if (!(MIODbLRKE1xMaC6gqYy(@event) is IUserGroup))
				{
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_f4f2657bf7454f44b4829aa89c711f0d == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 3;
			default:
				return false;
			}
		}
	}

	public virtual void DeletePermissions(PreDeleteEvent @event)
	{
	}

	public void DeletePermission<T>(PreDeleteEvent @event, Expression<Func<T, object>> propExpr)
	{
		_003C_003Ec__DisplayClass2_0<T> CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass2_0<T>();
		ITransformationProvider serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
		CS_0024_003C_003E8__locals0.groupPropName = LinqUtils.NameOf(propExpr);
		EntityMetadata entityMetadata = (EntityMetadata)MetadataLoader.LoadMetadata(typeof(T));
		if (entityMetadata == null)
		{
			return;
		}
		string tableName = entityMetadata.TableName;
		PropertyMetadata propertyMetadata = entityMetadata.Properties.FirstOrDefault((PropertyMetadata p) => p.Name == CS_0024_003C_003E8__locals0.groupPropName);
		if (!string.IsNullOrWhiteSpace(tableName) && propertyMetadata != null)
		{
			string fieldName = ((SimpleTypeSettings)propertyMetadata.Settings).FieldName;
			if (!string.IsNullOrWhiteSpace(fieldName))
			{
				object id = ((IEntity)((AbstractPreDatabaseOperationEvent)@event).get_Entity()).GetId();
				serviceNotNull.BulkDelete(tableName, string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5FD42272 ^ 0x5FD47046), serviceNotNull.Dialect.QuoteIfNeeded(fieldName), serviceNotNull.ParameterSeparator), new Dictionary<string, object> { 
				{
					SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x417D81DE ^ 0x417DD388),
					id
				} });
			}
		}
	}

	public UserGroupListener()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a1a646659a464f3fa5c9aedc64725d72 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object MIODbLRKE1xMaC6gqYy(object P_0)
	{
		return ((AbstractPreDatabaseOperationEvent)P_0).get_Entity();
	}

	internal static void NQUIZbRtlwUGM7wflgH(object P_0, object P_1)
	{
		((UserGroupListener)P_0).DeletePermissions((PreDeleteEvent)P_1);
	}

	internal static bool zldALvRo51gD5DsHILl()
	{
		return w9sM5HRUuWuVUie2iUM == null;
	}

	internal static UserGroupListener QAfjxlRJ1ZYIkaltB7y()
	{
		return w9sM5HRUuWuVUie2iUM;
	}
}
