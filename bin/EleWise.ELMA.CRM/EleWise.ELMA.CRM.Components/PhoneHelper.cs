using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Model.Entities.EntityReferences;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;
using NHibernate;

namespace EleWise.ELMA.CRM.Components;

public static class PhoneHelper
{
	private static Regex numberRgx = new Regex("[^0-9]");

	private static Guid? workPhonePropGuid;

	private static Guid? mobilePhonePropGuid;

	private static ISession Session => Locator.GetServiceNotNull<ISessionProvider>().GetSession("");

	private static ITransformationProvider TransformationProvider => Locator.GetServiceNotNull<ITransformationProvider>();

	private static Guid WorkPhonePropGuid
	{
		get
		{
			Guid? guid = workPhonePropGuid;
			if (!guid.HasValue)
			{
				Guid? guid2 = (workPhonePropGuid = InterfaceActivator.PropertyUid((IUser u) => u.WorkPhone));
				return guid2.Value;
			}
			return guid.GetValueOrDefault();
		}
	}

	private static Guid MobilePhonePropGuid
	{
		get
		{
			Guid? guid = mobilePhonePropGuid;
			if (!guid.HasValue)
			{
				Guid? guid2 = (mobilePhonePropGuid = InterfaceActivator.PropertyUid((IUser u) => u.MobilePhone));
				return guid2.Value;
			}
			return guid.GetValueOrDefault();
		}
	}

	public static string GetFormatedPhone(IPhone model)
	{
		return GetFormatedPhone(model.PhoneString);
	}

	public static string GetFormatedPhone(string phone)
	{
		if (string.IsNullOrEmpty(phone))
		{
			return phone;
		}
		string text = numberRgx.Replace(phone, "");
		if (phone.IndexOf('+') == 0)
		{
			return text.Insert(0, "+");
		}
		return text;
	}

	public static void UserPhonesInsertOrUpdate(IUser user)
	{
		ICollection<IPhone> source = EntityManager<IPhone>.Instance.Find((IPhone u) => u.ReferenceOnEntity == new ReferenceOnEntity
		{
			Object = user
		});
		IPhone phone = source.FirstOrDefault((IPhone p) => p.PropertyGuid.Equals(WorkPhonePropGuid));
		IPhone phone2 = source.FirstOrDefault((IPhone p) => p.PropertyGuid.Equals(MobilePhonePropGuid));
		UpdatePhoneEntity(user, phone, user.WorkPhone, WorkPhonePropGuid);
		UpdatePhoneEntity(user, phone2, user.MobilePhone, MobilePhonePropGuid);
	}

	private static void UpdatePhoneEntity(IUser user, IPhone phone, string userPhone, Guid propertyGuid)
	{
		bool flag = user.Status != UserStatus.Active;
		if (phone != null)
		{
			if (string.IsNullOrEmpty(userPhone))
			{
				phone.Delete();
				return;
			}
			if (phone.PhoneString != userPhone)
			{
				phone.PhoneString = userPhone;
			}
			if (phone.IsDeleted != flag)
			{
				phone.IsDeleted = flag;
			}
			phone.Save();
		}
		else if (!string.IsNullOrEmpty(userPhone))
		{
			CreateNewPhone(user, userPhone, propertyGuid, flag);
		}
	}

	private static void CreateNewPhone(IUser user, string phone, Guid propertyUid, bool isDeleted)
	{
		IPhone phone2 = InterfaceActivator.Create<IPhone>();
		phone2.PhoneString = phone;
		phone2.DisplayName = user.GetShortName();
		phone2.ReferenceOnEntity = new ReferenceOnEntity
		{
			Object = user
		};
		phone2.IsDeleted = isDeleted;
		phone2.PropertyGuid = propertyUid;
		phone2.Save();
	}

	public static void DeleteUserPhones(IUser user)
	{
		((IQuery)Session.CreateSQLQuery(string.Format("DELETE FROM {0} WHERE {1}=? AND {2}=?", TransformationProvider.Dialect.QuoteIfNeeded("Phone"), TransformationProvider.Dialect.QuoteIfNeeded("ReferenceOnEntityTU"), TransformationProvider.Dialect.QuoteIfNeeded("ReferenceOnEntityOI")))).SetParameter<Guid>(0, InterfaceActivator.UID<IUser>()).SetParameter<long>(1, user.Id).ExecuteUpdate(cleanUpCache: false);
		Session.CleanUpCache(typeof(IPhone));
	}
}
