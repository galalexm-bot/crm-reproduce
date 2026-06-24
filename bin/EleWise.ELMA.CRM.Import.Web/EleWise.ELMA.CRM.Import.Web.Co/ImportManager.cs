using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Aspose.Cells;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Enums;
using EleWise.ELMA.CRM.Extensions;
using EleWise.ELMA.CRM.Import.Web.Extensions;
using EleWise.ELMA.CRM.Import.Web.Models;
using EleWise.ELMA.CRM.Managers;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Types.Validation;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;
using Iesi.Collections;
using NHibernate;
using NHibernate.Criterion;

namespace EleWise.ELMA.CRM.Import.Web.Code;

public class ImportManager
{
	internal class MasterPropertyCheckList
	{
		public PropertyInfo Property { get; set; }

		public bool HasAssigments { get; set; }

		public bool HasNotAssignedRequiredProperty { get; set; }
	}

	private readonly string requsitesHeader = SR.T("Реквизиты");

	private readonly string contactHeader = SR.T("Контакт");

	private IEnumerable<IEntityImportEventHandler> eventHandlers;

	private Dictionary<IEntityImportEventHandler, object> importSessionData;

	private List<EleWise.ELMA.Security.Models.IUser> userDict;

	private List<ILeadType> leadTypeDict;

	private List<ILegalForm> legalFormDict;

	private List<IContractorIndustry> contractorIndustryDict;

	private List<IContractorRegion> contractorRegionDict;

	private List<ICountry> countryDict;

	private List<ILeadSource> leadSourceDict;

	private List<IMarketingActivity> marketingActivityList;

	private List<IContractorType> contractorTypeDict;

	private List<IClientDocumentType> clientDocumentTypeDict;

	private List<ICientType> clientTypeDict;

	private List<ICategory> categoryDict;

	private List<Tuple<Type, string, IEntity<long>>> universalDict = new List<Tuple<Type, string, IEntity<long>>>();

	private readonly Type entityType;

	private readonly Timers Timers;

	private readonly ISession Session;

	public ImportManager(Type type)
	{
		entityType = type;
		Timers = new Timers();
		Session = Locator.GetServiceNotNull<ISessionProvider>().GetSession("");
	}

	protected void InitDictionaries()
	{
		eventHandlers = from p in ComponentManager.Current.GetExtensionPoints<IEntityImportEventHandler>()
			where p.Type.IsAssignableFrom(entityType)
			select p;
		importSessionData = new Dictionary<IEntityImportEventHandler, object>();
		eventHandlers.Each(delegate(IEntityImportEventHandler handler)
		{
			importSessionData.Add(handler, handler.CreateImportSessionData(importSessionData));
		});
		userDict = UserManager.Instance.FindAll().ToList();
		leadTypeDict = LeadTypeManager.Instance.FindAll().ToList();
		legalFormDict = EntityManager<ILegalForm>.Instance.FindAll().ToList();
		contractorIndustryDict = EntityManager<IContractorIndustry>.Instance.FindAll().ToList();
		contractorRegionDict = EntityManager<IContractorRegion>.Instance.FindAll().ToList();
		countryDict = EntityManager<ICountry>.Instance.FindAll().ToList();
		leadSourceDict = EntityManager<ILeadSource>.Instance.FindAll().ToList();
		contractorTypeDict = EntityManager<IContractorType>.Instance.FindAll().ToList();
		clientDocumentTypeDict = EntityManager<IClientDocumentType>.Instance.FindAll().ToList();
		clientTypeDict = EntityManager<ICientType>.Instance.FindAll().ToList();
		categoryDict = EntityManager<ICategory>.Instance.FindAll().ToList();
		marketingActivityList = EntityManager<IMarketingActivity>.Instance.FindAll().ToList();
	}

	protected IEntity<long> CreateEntity(Type type)
	{
		Guid timerGuid = Timers.StartTimer(TimerType.CreateEntity);
		try
		{
			return (IEntity<long>)ModelHelper.GetEntityManager(type).Create();
		}
		finally
		{
			Timers.StopTimer(timerGuid);
		}
	}

	protected void LinkContactToEntity(object contact, PropertyInfo[] contactProps, PropertyInfo contactsProp, IEntity<long> entity)
	{
		if (entity is ILead)
		{
			object value = contactsProp.GetValue(entity, null);
			ISet val = (ISet)((value is ISet) ? value : null);
			if (val != null)
			{
				val.Add(contact);
			}
		}
		else if (entity is IContractor)
		{
			PropertyInfo propertyInfo = contactProps.FirstOrDefault((PropertyInfo p) => p.Name == "Contractor");
			if (propertyInfo != null)
			{
				propertyInfo.SetValue(contact, entity, null);
			}
			object value2 = contactsProp.GetValue(entity, null);
			ISet val2 = (ISet)((value2 is ISet) ? value2 : null);
			if (val2 != null)
			{
				val2.Add(contact);
			}
		}
	}

	protected IEnumerable GetContacts(IEntity<long> entity, PropertyInfo contactsProp)
	{
		if (entity is ILead)
		{
			object value = contactsProp.GetValue(entity, null);
			return (IEnumerable)((value is ISet) ? value : null);
		}
		if (entity is IContractor)
		{
			object value2 = contactsProp.GetValue(entity, null);
			return (IEnumerable)((value2 is ISet) ? value2 : null);
		}
		return null;
	}

	protected object CreateTarget(object entity, ReflectedEntityPropertyInfo entityProperty, string value = null)
	{
		Guid timerGuid = Timers.StartTimer(TimerType.CreateEntity);
		object obj = null;
		if (typeof(IMarketingActivity).IsAssignableFrom(entityProperty.MasterProperty.PropertyType))
		{
			obj = marketingActivityList.FirstOrDefault((IMarketingActivity q) => q.Name == value);
			if (obj == null)
			{
				obj = InterfaceActivator.Create(entityProperty.MasterProperty.PropertyType);
				((IMarketingActivity)obj).Name = value;
				marketingActivityList.Add(obj as IMarketingActivity);
			}
		}
		else if (typeof(IAddress).IsAssignableFrom(entityProperty.MasterProperty.PropertyType))
		{
			ICountryInfoExt countryInfoExt = ComponentManager.Current.GetExtensionPoints<ICountryInfoExt>().FirstOrDefault((ICountryInfoExt p) => p.NeedAdd(value));
			obj = ((countryInfoExt == null) ? InterfaceActivator.Create(entityProperty.MasterProperty.PropertyType) : InterfaceActivator.Create(countryInfoExt.GetAddressType()));
		}
		else
		{
			obj = InterfaceActivator.Create(entityProperty.MasterProperty.PropertyType);
		}
		Timers.StopTimer(timerGuid);
		entityProperty.MasterProperty.SetValue(entity, obj, null);
		return obj;
	}

	protected void SaveEntity(object entity)
	{
		Guid timerGuid = Timers.StartTimer(TimerType.SaveEntity);
		Session.SaveOrUpdate(entity);
		List<IAddress> list = new List<IAddress>();
		if (entity is IContractor contractor)
		{
			list.Add(contractor.LegalAddress);
			list.Add(contractor.PostalAddress);
			foreach (IContact item in (IEnumerable<IContact>)contractor.Contacts)
			{
				if (item != null)
				{
					list.Add(item.RegistrationAddress);
					list.Add(item.ResidenceAddress);
				}
			}
		}
		if (entity is ILead lead)
		{
			list.Add(lead.Address);
		}
		foreach (IAddress address in list)
		{
			if (address == null)
			{
				continue;
			}
			try
			{
				ComponentManager.Current.GetExtensionPoints<ICountryInfo>().FirstOrDefault((ICountryInfo p) => p.NeedAdd(address.Country.Name))?.Adding(address);
			}
			catch
			{
			}
		}
		Timers.StopTimer(timerGuid);
	}

	protected void DropDeletedFlag(object entity)
	{
		if (entity != null)
		{
			PropertyInfo propertyInfo = entity.GetType().GetReflectionProperties().FirstOrDefault((PropertyInfo p) => p.Name == "IsDeleted" && p.PropertyType == typeof(bool));
			if (propertyInfo != null)
			{
				propertyInfo.SetValue(entity, false, null);
			}
		}
	}

	protected IEntity<long> LoadEntity(Type entityType, PropertyInfo keyProp, string value)
	{
		Guid timerGuid = Timers.StartTimer(TimerType.LoadEntity);
		object obj = ConvertStringToKey(keyProp, value);
		ICriteria val = Session.CreateCriteria(entityType);
		if (obj is string)
		{
			PropertyMetadata propertyMetadata = ((EntityMetadata)MetadataLoader.LoadMetadata(entityType)).Properties.FirstOrDefault((PropertyMetadata p) => p.Name == keyProp.Name);
			if (propertyMetadata != null && propertyMetadata.Settings != null && propertyMetadata.Settings is StringSettings && !((StringSettings)propertyMetadata.Settings).MaxValue.HasValue)
			{
				val.Add((ICriterion)(object)ElmaRestrictions.Like(keyProp.Name, (string)obj, MatchMode.Exact));
			}
			else
			{
				val.Add((ICriterion)(object)Restrictions.Eq(keyProp.Name, obj));
			}
		}
		else
		{
			val.Add((ICriterion)(object)Restrictions.Eq(keyProp.Name, obj));
		}
		IEntity<long> entity = val.List().Cast<IEntity<long>>().FirstOrDefault();
		if (entity != null)
		{
			entity = entity.CastAsRealType();
		}
		Timers.StopTimer(timerGuid);
		return entity;
	}

	protected List<object> GetExistingKeyValues(Type entityType, PropertyInfo keyProp, List<string> values)
	{
		Guid timerGuid = Timers.StartTimer(TimerType.FindEntity);
		List<object> list = new List<object>();
		int num = 0;
		do
		{
			List<object> list2 = new List<object>();
			for (int i = num; i < num + 50 && i < values.Count; i++)
			{
				list2.Add(ConvertStringToKey(keyProp, values[i]));
			}
			if (list2.Any())
			{
				ICriteria val = Session.CreateCriteria(entityType);
				if (list2.First() is string)
				{
					PropertyMetadata propertyMetadata = ((EntityMetadata)MetadataLoader.LoadMetadata(entityType)).Properties.FirstOrDefault((PropertyMetadata p) => p.Name == keyProp.Name);
					if (propertyMetadata != null && propertyMetadata.Settings != null && propertyMetadata.Settings is StringSettings && !((StringSettings)propertyMetadata.Settings).MaxValue.HasValue)
					{
						val.Add((ICriterion)(object)NHibernateHelper.Or(list2.Select((object x) => ElmaRestrictions.Like(keyProp.Name, (string)x, MatchMode.Exact))));
					}
					else
					{
						val.Add((ICriterion)(object)Restrictions.In(keyProp.Name, list2.ToArray()));
					}
				}
				else
				{
					val.Add((ICriterion)(object)Restrictions.In(keyProp.Name, list2.ToArray()));
				}
				list.AddRange(val.SetProjection((IProjection[])(object)new IProjection[1] { (IProjection)Projections.Property(keyProp.Name) }).List<object>());
			}
			num += 50;
		}
		while (num < values.Count);
		Timers.StopTimer(timerGuid);
		return list;
	}

	protected bool SetEntityPropertyValue(IEntity<long> entity, ReflectedEntityPropertyInfo entityProperty, string value, bool allowAddToDict, bool saveEntity, List<LogMessage> logMessages, string infoTemplate)
	{
		//IL_0593: Unknown result type (might be due to invalid IL or missing references)
		//IL_059a: Expected O, but got Unknown
		//IL_08a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ad: Expected O, but got Unknown
		//IL_0985: Unknown result type (might be due to invalid IL or missing references)
		//IL_098c: Expected O, but got Unknown
		//IL_1834: Unknown result type (might be due to invalid IL or missing references)
		//IL_183b: Expected O, but got Unknown
		if (eventHandlers.Any((IEntityImportEventHandler handler) => handler.SetEntityPropertyValue(entity, entityProperty, value, allowAddToDict, saveEntity, logMessages, infoTemplate, importSessionData[handler])))
		{
			return true;
		}
		if (entity == null || entityProperty.Property == null || string.IsNullOrEmpty(value))
		{
			return false;
		}
		object obj = ((entityProperty.MasterProperty == null) ? entity : entityProperty.MasterProperty.GetValue(entity, null));
		if (obj == null)
		{
			obj = CreateTarget(entity, entityProperty, value);
			if (saveEntity && obj is IEntity)
			{
				((IEntity)obj).Save();
			}
		}
		if (typeof(ILegalForm).IsAssignableFrom(entityProperty.Property.PropertyType))
		{
			ILegalForm legalForm = legalFormDict.FirstOrDefault(delegate(ILegalForm x)
			{
				string obj2 = ((x.ShortName != null) ? x.ShortName.ToUpper() : string.Empty);
				string text2 = ((x.LongName != null) ? x.LongName.ToUpper() : string.Empty);
				return obj2.Equals(value.ToUpper()) || text2.Equals(value.ToUpper());
			});
			if (legalForm == null)
			{
				if (allowAddToDict)
				{
					legalForm = InterfaceActivator.Create<ILegalForm>();
					legalForm.ShortName = value;
					legalForm.LongName = value;
					legalFormDict.Add(legalForm);
					if (saveEntity)
					{
						SaveEntity(legalForm);
					}
					logMessages.Add(new LogMessage
					{
						MessageType = LogMessageType.RecordAdded,
						Message = string.Format(infoTemplate, SR.T("Организационно-правовая форма \"{0}\" не найдена и будет добавлена.", value))
					});
				}
				else
				{
					logMessages.Add(new LogMessage
					{
						MessageType = LogMessageType.Info,
						Message = string.Format(infoTemplate, SR.T("Организационно-правовая форма \"{0}\" не найдена.", value))
					});
				}
			}
			if (legalForm != null)
			{
				entityProperty.Property.SetValue(obj, legalForm, null);
				return true;
			}
		}
		else if (typeof(EleWise.ELMA.Security.IUser).IsAssignableFrom(entityProperty.Property.PropertyType))
		{
			EleWise.ELMA.Security.Models.IUser user = userDict.FirstOrDefault((EleWise.ELMA.Security.Models.IUser x) => x.UserName == value || x.FullName == value);
			if (user != null)
			{
				entityProperty.Property.SetValue(obj, user, null);
				return true;
			}
			logMessages.Add(new LogMessage
			{
				MessageType = LogMessageType.Info,
				Message = string.Format(infoTemplate, SR.T("Пользователь \"{0}\" не найден.", value))
			});
		}
		else
		{
			if (typeof(LeadStatus).IsAssignableFrom(entityProperty.Property.PropertyType))
			{
				LeadStatus leadStatus = LeadStatus.New;
				if (value.ToUpper() == SR.T("В работе").ToUpper())
				{
					leadStatus = LeadStatus.InHand;
				}
				else if (value.ToUpper() == SR.T("Разговор не состоялся").ToUpper())
				{
					leadStatus = LeadStatus.ConversationNotStart;
				}
				else if (value.ToUpper() == SR.T("Новый").ToUpper())
				{
					leadStatus = LeadStatus.New;
				}
				else if (value.ToUpper() == SR.T("Квалифицированный").ToUpper())
				{
					leadStatus = LeadStatus.Qualified;
				}
				else if (value.ToUpper() == SR.T("Неквалифицированный").ToUpper())
				{
					leadStatus = LeadStatus.Unqualified;
				}
				entityProperty.Property.SetValue(obj, leadStatus, null);
				return true;
			}
			if (typeof(IEnumerable<ILeadType>).IsAssignableFrom(entityProperty.Property.PropertyType))
			{
				List<string> list = (from x in value.Split(';', ',')
					select x.Trim()).ToList();
				List<ILeadType> list2 = new List<ILeadType>();
				foreach (string item in list)
				{
					bool flag = false;
					foreach (ILeadType item2 in leadTypeDict)
					{
						if (item2.Type.ToUpper() == item.ToUpper())
						{
							list2.Add(item2);
							flag = true;
							break;
						}
					}
					if (flag)
					{
						continue;
					}
					if (allowAddToDict)
					{
						ILeadType leadType = InterfaceActivator.Create<ILeadType>();
						leadType.Type = item;
						leadTypeDict.Add(leadType);
						if (saveEntity)
						{
							SaveEntity(leadType);
						}
						list2.Add(leadType);
						logMessages.Add(new LogMessage
						{
							MessageType = LogMessageType.RecordAdded,
							Message = string.Format(infoTemplate, SR.T("Тип потенциального клиента \"{0}\" не найден и будет добавлен.", item))
						});
					}
					else
					{
						logMessages.Add(new LogMessage
						{
							MessageType = LogMessageType.Info,
							Message = string.Format(infoTemplate, SR.T("Тип потенциального клиента \"{0}\" не найден.", item))
						});
					}
				}
				if (list2.Any())
				{
					ISet val = (ISet)entityProperty.Property.GetValue(obj, null);
					val.Clear();
					foreach (ILeadType item3 in list2)
					{
						val.Add((object)item3);
					}
					return true;
				}
			}
			else if (typeof(IContractorIndustry).IsAssignableFrom(entityProperty.Property.PropertyType))
			{
				IContractorIndustry contractorIndustry = contractorIndustryDict.FirstOrDefault(delegate(IContractorIndustry i)
				{
					string value8 = ((!string.IsNullOrEmpty(i.Industry)) ? i.Industry.ToUpper() : string.Empty);
					return value.ToUpper().Equals(value8);
				});
				if (contractorIndustry == null)
				{
					if (allowAddToDict)
					{
						contractorIndustry = InterfaceActivator.Create<IContractorIndustry>();
						contractorIndustry.Industry = value;
						contractorIndustryDict.Add(contractorIndustry);
						if (saveEntity)
						{
							SaveEntity(contractorIndustry);
						}
						logMessages.Add(new LogMessage
						{
							MessageType = LogMessageType.RecordAdded,
							Message = string.Format(infoTemplate, SR.T("Отрасль \"{0}\" не найдена и будет добавлена.", value))
						});
					}
					else
					{
						logMessages.Add(new LogMessage
						{
							MessageType = LogMessageType.Info,
							Message = string.Format(infoTemplate, SR.T("Отрасль \"{0}\" не найдена", value))
						});
					}
				}
				if (contractorIndustry != null)
				{
					entityProperty.Property.SetValue(obj, contractorIndustry, null);
					return true;
				}
			}
			else if (typeof(IContractorRegion).IsAssignableFrom(entityProperty.Property.PropertyType))
			{
				IContractorRegion contractorRegion = contractorRegionDict.FirstOrDefault(delegate(IContractorRegion i)
				{
					string value7 = ((!string.IsNullOrEmpty(i.Region)) ? i.Region.ToUpper() : string.Empty);
					return value.ToUpper().Equals(value7);
				});
				if (contractorRegion == null)
				{
					if (allowAddToDict)
					{
						contractorRegion = InterfaceActivator.Create<IContractorRegion>();
						contractorRegion.Region = value;
						contractorRegionDict.Add(contractorRegion);
						if (saveEntity)
						{
							SaveEntity(contractorRegion);
						}
						logMessages.Add(new LogMessage
						{
							MessageType = LogMessageType.RecordAdded,
							Message = string.Format(infoTemplate, SR.T("Регион \"{0}\" не найден и будет добавлен.", value))
						});
					}
					else
					{
						logMessages.Add(new LogMessage
						{
							MessageType = LogMessageType.Info,
							Message = string.Format(infoTemplate, SR.T("Регион \"{0}\" не найден.", value))
						});
					}
				}
				if (contractorRegion != null)
				{
					entityProperty.Property.SetValue(obj, contractorRegion, null);
					return true;
				}
			}
			else if (typeof(IEnumerable<IPhone>).IsAssignableFrom(entityProperty.Property.PropertyType))
			{
				List<string> list3 = (from x in value.Split(';', ',')
					select x.Trim()).ToList();
				if (list3.Any())
				{
					ISet val2 = (ISet)entityProperty.Property.GetValue(obj, null);
					val2.Clear();
					foreach (string item4 in list3)
					{
						IPhone phone = InterfaceActivator.Create<IPhone>();
						phone.PhoneString = item4;
						val2.Add((object)phone);
					}
					return true;
				}
			}
			else if (typeof(IEnumerable<IEmail>).IsAssignableFrom(entityProperty.Property.PropertyType))
			{
				List<string> list4 = (from x in value.Split(';', ',')
					select x.Trim()).ToList();
				if (list4.Any())
				{
					ISet val3 = (ISet)entityProperty.Property.GetValue(obj, null);
					val3.Clear();
					foreach (string item5 in list4)
					{
						IEmail email = InterfaceActivator.Create<IEmail>();
						email.EmailString = item5;
						val3.Add((object)email);
					}
					return true;
				}
			}
			else if (typeof(ICountry).IsAssignableFrom(entityProperty.Property.PropertyType))
			{
				ICountry country = countryDict.FirstOrDefault(delegate(ICountry i)
				{
					string value6 = ((!string.IsNullOrEmpty(i.Name)) ? i.Name.ToUpper() : string.Empty);
					return value.ToUpper().Equals(value6);
				});
				if (country == null)
				{
					if (allowAddToDict)
					{
						country = InterfaceActivator.Create<ICountry>();
						country.Name = value;
						long num = (countryDict.Any() ? countryDict.Max((ICountry c) => c.CountryCode) : 0);
						num = (country.CountryCode = num + 1);
						countryDict.Add(country);
						if (saveEntity)
						{
							SaveEntity(country);
						}
						logMessages.Add(new LogMessage
						{
							MessageType = LogMessageType.RecordAdded,
							Message = string.Format(infoTemplate, SR.T("Страна \"{0}\" не найдена и будет добавлена.", value))
						});
					}
					else
					{
						logMessages.Add(new LogMessage
						{
							MessageType = LogMessageType.Info,
							Message = string.Format(infoTemplate, SR.T("Страна \"{0}\" не найдена.", value))
						});
					}
				}
				if (country != null)
				{
					entityProperty.Property.SetValue(obj, country, null);
					return true;
				}
			}
			else if (typeof(AppartmentType?).IsAssignableFrom(entityProperty.Property.PropertyType))
			{
				foreach (object value9 in Enum.GetValues(typeof(AppartmentType)))
				{
					if (EnumHelper.GetDisplayName(value9).Equals(value))
					{
						entityProperty.Property.SetValue(obj, value9, null);
						return true;
					}
				}
				logMessages.Add(new LogMessage
				{
					MessageType = LogMessageType.Info,
					Message = string.Format(infoTemplate, SR.T("Тип помещения \"{0}\" не найден. Будет использован тип 'Квартира'.", value))
				});
			}
			else if (typeof(ILeadSource).IsAssignableFrom(entityProperty.Property.PropertyType))
			{
				ILeadSource leadSource = leadSourceDict.FirstOrDefault(delegate(ILeadSource i)
				{
					string value5 = ((!string.IsNullOrEmpty(i.Name)) ? i.Name.ToUpper() : string.Empty);
					return value.ToUpper().Equals(value5);
				});
				if (leadSource == null)
				{
					if (allowAddToDict)
					{
						leadSource = InterfaceActivator.Create<ILeadSource>();
						leadSource.Name = value;
						leadSourceDict.Add(leadSource);
						if (saveEntity)
						{
							SaveEntity(leadSource);
						}
						logMessages.Add(new LogMessage
						{
							MessageType = LogMessageType.RecordAdded,
							Message = string.Format(infoTemplate, SR.T("Источник возможности \"{0}\" не найден и будет добавлен.", value))
						});
					}
					else
					{
						logMessages.Add(new LogMessage
						{
							MessageType = LogMessageType.Info,
							Message = string.Format(infoTemplate, SR.T("Источник возможности \"{0}\" не найден.", value))
						});
					}
				}
				if (leadSource != null)
				{
					entityProperty.Property.SetValue(obj, leadSource, null);
					return true;
				}
			}
			else
			{
				if (typeof(long?).IsAssignableFrom(entityProperty.Property.PropertyType))
				{
					if (!string.IsNullOrEmpty(value))
					{
						long num3 = Convert.ToInt64(value);
						entityProperty.Property.SetValue(obj, num3, null);
					}
					else
					{
						entityProperty.Property.SetValue(obj, null, null);
					}
					return true;
				}
				if (typeof(long).IsAssignableFrom(entityProperty.Property.PropertyType))
				{
					if (!string.IsNullOrEmpty(value))
					{
						long num4 = Convert.ToInt64(value);
						entityProperty.Property.SetValue(obj, num4, null);
						return true;
					}
				}
				else if (typeof(DateTime).IsAssignableFrom(entityProperty.Property.PropertyType))
				{
					if (!string.IsNullOrEmpty(value))
					{
						DateTime dateTime = Convert.ToDateTime(value);
						entityProperty.Property.SetValue(obj, dateTime, null);
						return true;
					}
				}
				else
				{
					if (typeof(DateTime?).IsAssignableFrom(entityProperty.Property.PropertyType))
					{
						if (!string.IsNullOrEmpty(value))
						{
							DateTime dateTime2 = Convert.ToDateTime(value);
							entityProperty.Property.SetValue(obj, dateTime2, null);
						}
						else
						{
							entityProperty.Property.SetValue(obj, null, null);
						}
						return true;
					}
					if (typeof(double).IsAssignableFrom(entityProperty.Property.PropertyType))
					{
						if (!string.IsNullOrEmpty(value))
						{
							double num5 = Convert.ToDouble(value);
							entityProperty.Property.SetValue(obj, num5, null);
							return true;
						}
					}
					else
					{
						if (typeof(double?).IsAssignableFrom(entityProperty.Property.PropertyType))
						{
							if (!string.IsNullOrEmpty(value))
							{
								double num6 = Convert.ToDouble(value);
								entityProperty.Property.SetValue(obj, num6, null);
							}
							else
							{
								entityProperty.Property.SetValue(obj, null, null);
							}
							return true;
						}
						if (typeof(bool).IsAssignableFrom(entityProperty.Property.PropertyType))
						{
							if (!string.IsNullOrEmpty(value))
							{
								string text = value.ToUpper();
								bool flag2 = text.Equals(SR.T("Да").ToUpper()) || text.Equals("TRUE") || value.Equals("1") || (!text.Equals(SR.T("Нет").ToUpper()) && !text.Equals("FALSE") && !value.Equals("0") && Convert.ToBoolean(value));
								entityProperty.Property.SetValue(obj, flag2, null);
								return true;
							}
						}
						else
						{
							if (typeof(bool?).IsAssignableFrom(entityProperty.Property.PropertyType))
							{
								if (!string.IsNullOrEmpty(value))
								{
									bool flag3 = value.ToUpper().Equals(SR.T("Да").ToUpper()) || value.ToUpper().Equals("TRUE") || value.Equals("1") || (!value.ToUpper().Equals(SR.T("Нет").ToUpper()) && !value.ToUpper().Equals("FALSE") && !value.Equals("0") && Convert.ToBoolean(value));
									entityProperty.Property.SetValue(obj, flag3, null);
								}
								else
								{
									entityProperty.Property.SetValue(obj, null, null);
								}
								return true;
							}
							if (typeof(Money).IsAssignableFrom(entityProperty.Property.PropertyType))
							{
								Money money = default(Money);
								money.Value = Convert.ToDouble(value);
								Money money2 = money;
								entityProperty.Property.SetValue(obj, money2, null);
								return true;
							}
							if (typeof(IContractorType).IsAssignableFrom(entityProperty.Property.PropertyType))
							{
								IContractorType contractorType = contractorTypeDict.FirstOrDefault(delegate(IContractorType i)
								{
									string value4 = ((!string.IsNullOrEmpty(i.Name)) ? i.Name.ToUpper() : string.Empty);
									return value.ToUpper().Equals(value4);
								});
								if (contractorType == null)
								{
									if (allowAddToDict)
									{
										contractorType = InterfaceActivator.Create<IContractorType>();
										contractorType.Name = value;
										contractorTypeDict.Add(contractorType);
										if (saveEntity)
										{
											SaveEntity(contractorType);
										}
										logMessages.Add(new LogMessage
										{
											MessageType = LogMessageType.RecordAdded,
											Message = string.Format(infoTemplate, SR.T("Тип клиента \"{0}\" не найден и будет добавлен.", value))
										});
									}
									else
									{
										logMessages.Add(new LogMessage
										{
											MessageType = LogMessageType.Info,
											Message = string.Format(infoTemplate, SR.T("Тип клиента \"{0}\" не найден.", value))
										});
									}
								}
								if (contractorType != null)
								{
									entityProperty.Property.SetValue(obj, contractorType, null);
									return true;
								}
							}
							else if (typeof(IClientDocumentType).IsAssignableFrom(entityProperty.Property.PropertyType))
							{
								IClientDocumentType clientDocumentType = clientDocumentTypeDict.FirstOrDefault(delegate(IClientDocumentType i)
								{
									string value3 = ((!string.IsNullOrEmpty(i.Name)) ? i.Name.ToUpper() : string.Empty);
									return value.ToUpper().Equals(value3);
								});
								if (clientDocumentType == null)
								{
									if (allowAddToDict)
									{
										clientDocumentType = InterfaceActivator.Create<IClientDocumentType>();
										clientDocumentType.Name = value;
										clientDocumentTypeDict.Add(clientDocumentType);
										if (saveEntity)
										{
											SaveEntity(clientDocumentType);
										}
										logMessages.Add(new LogMessage
										{
											MessageType = LogMessageType.RecordAdded,
											Message = string.Format(infoTemplate, SR.T("Тип документа клиента \"{0}\" не найден и будет добавлен.", value))
										});
									}
									else
									{
										logMessages.Add(new LogMessage
										{
											MessageType = LogMessageType.Info,
											Message = string.Format(infoTemplate, SR.T("Тип документа клиента \"{0}\" не найден.", value))
										});
									}
								}
								if (clientDocumentType != null)
								{
									entityProperty.Property.SetValue(obj, clientDocumentType, null);
									return true;
								}
							}
							else
							{
								if (typeof(ContactPriority).IsAssignableFrom(entityProperty.Property.PropertyType))
								{
									ContactPriority contactPriority = ContactPriority.Medium;
									if (value.ToUpper() == SR.T("Высокий").ToUpper())
									{
										contactPriority = ContactPriority.High;
									}
									else if (value.ToUpper() == SR.T("Низкий").ToUpper())
									{
										contactPriority = ContactPriority.Low;
									}
									entityProperty.Property.SetValue(obj, contactPriority, null);
									return true;
								}
								if (typeof(ICientType).IsAssignableFrom(entityProperty.Property.PropertyType))
								{
									ICientType cientType = clientTypeDict.FirstOrDefault(delegate(ICientType i)
									{
										string value2 = ((!string.IsNullOrEmpty(i.Name)) ? i.Name.ToUpper() : string.Empty);
										return value.ToUpper().Equals(value2);
									});
									if (cientType == null)
									{
										if (allowAddToDict)
										{
											cientType = InterfaceActivator.Create<ICientType>();
											cientType.Name = value;
											clientTypeDict.Add(cientType);
											if (saveEntity)
											{
												SaveEntity(cientType);
											}
											logMessages.Add(new LogMessage
											{
												MessageType = LogMessageType.RecordAdded,
												Message = string.Format(infoTemplate, SR.T("Тип контакта \"{0}\" не найден и будет добавлен.", value))
											});
										}
										else
										{
											logMessages.Add(new LogMessage
											{
												MessageType = LogMessageType.Info,
												Message = string.Format(infoTemplate, SR.T("Тип контакта \"{0}\" не найден.", value))
											});
										}
									}
									if (cientType != null)
									{
										entityProperty.Property.SetValue(obj, cientType, null);
										return true;
									}
								}
								else if (typeof(IMarketingActivity).IsAssignableFrom(entityProperty.Property.PropertyType))
								{
									Guid timerGuid = Timers.StartTimer(TimerType.FindEntity);
									IMarketingActivity marketingActivity = EntityManager<IMarketingActivity>.Instance.Find((IMarketingActivity i) => i.Name == value).FirstOrDefault();
									Timers.StopTimer(timerGuid);
									if (marketingActivity == null && allowAddToDict)
									{
										marketingActivity = EntityManager<IMarketingActivity>.Instance.Create();
										marketingActivity.Name = value;
										if (saveEntity)
										{
											SaveEntity(marketingActivity);
										}
									}
									if (marketingActivity != null)
									{
										entityProperty.Property.SetValue(obj, marketingActivity, null);
										return true;
									}
								}
								else
								{
									if (!typeof(IEnumerable<ICategory>).IsAssignableFrom(entityProperty.Property.PropertyType))
									{
										if (typeof(Guid).IsAssignableFrom(entityProperty.Property.PropertyType))
										{
											entityProperty.Property.SetValue(obj, Guid.Parse(value), null);
											return true;
										}
										entityProperty.Property.SetValue(obj, value, null);
										return true;
									}
									List<string> list5 = (from x in value.Split(';', ',')
										select x.Trim()).ToList();
									List<ICategory> list6 = new List<ICategory>();
									foreach (string item6 in list5)
									{
										bool flag4 = false;
										foreach (ICategory item7 in categoryDict)
										{
											if (item7.Name.ToUpper() == item6.ToUpper())
											{
												list6.Add(item7);
												flag4 = true;
												break;
											}
										}
										if (!flag4)
										{
											logMessages.Add(new LogMessage
											{
												MessageType = LogMessageType.Info,
												Message = string.Format(infoTemplate, SR.T("Категория \"{0}\" не найдена в справочнике.", item6))
											});
										}
									}
									if (list6.Any())
									{
										ISet val4 = (ISet)entityProperty.Property.GetValue(obj, null);
										val4.Clear();
										foreach (ICategory item8 in list6)
										{
											val4.Add((object)item8);
										}
										return true;
									}
								}
							}
						}
					}
				}
			}
		}
		return false;
	}

	protected ReflectedEntityPropertyInfo GetEntityPropertyByHeader(string masterPropName, string slavePropName, Type type)
	{
		if (string.IsNullOrEmpty(masterPropName) || string.IsNullOrEmpty(slavePropName))
		{
			return null;
		}
		ReflectedEntityPropertyInfo reflectedEntityPropertyInfo = eventHandlers.Select((IEntityImportEventHandler handler) => handler.GetEntityPropertyByHeader(masterPropName, slavePropName, type, importSessionData[handler])).FirstOrDefault((ReflectedEntityPropertyInfo p) => p != null);
		if (reflectedEntityPropertyInfo != null)
		{
			return reflectedEntityPropertyInfo;
		}
		EntityMetadata entityMetadata = (EntityMetadata)MetadataLoader.LoadMetadata(type);
		if (masterPropName == requsitesHeader || masterPropName == contactHeader)
		{
			PropertyMetadata propertyMetadata = entityMetadata.Properties.FirstOrDefault((PropertyMetadata p) => p.DisplayName.Equals(slavePropName));
			if (propertyMetadata != null)
			{
				return new ReflectedEntityPropertyInfo
				{
					MasterProperty = null,
					MasterPropertyDisplayName = null,
					Property = type.GetReflectionProperty(propertyMetadata.Name),
					PropertyDisplayName = slavePropName,
					PropertyUid = propertyMetadata.Uid
				};
			}
		}
		else
		{
			PropertyMetadata propertyMetadata2 = entityMetadata.Properties.FirstOrDefault((PropertyMetadata p) => p.DisplayName.Equals(masterPropName));
			if (propertyMetadata2 != null)
			{
				PropertyInfo reflectionProperty = type.GetReflectionProperty(propertyMetadata2.Name);
				if (reflectionProperty != null)
				{
					PropertyMetadata propertyMetadata3 = ((EntityMetadata)MetadataLoader.LoadMetadata(reflectionProperty.PropertyType)).Properties.FirstOrDefault((PropertyMetadata p) => p.DisplayName.Equals(slavePropName));
					if (propertyMetadata3 != null)
					{
						return new ReflectedEntityPropertyInfo
						{
							MasterProperty = reflectionProperty,
							MasterPropertyDisplayName = masterPropName,
							Property = reflectionProperty.PropertyType.GetReflectionProperty(propertyMetadata3.Name),
							PropertyDisplayName = slavePropName,
							PropertyUid = propertyMetadata3.Uid
						};
					}
				}
			}
		}
		return null;
	}

	protected object ConvertStringToKey(PropertyInfo keyProp, string value)
	{
		object result = null;
		if (typeof(long).IsAssignableFrom(keyProp.PropertyType))
		{
			result = Convert.ToInt64(value);
		}
		else if (typeof(long?).IsAssignableFrom(keyProp.PropertyType))
		{
			if (!string.IsNullOrEmpty(value))
			{
				result = Convert.ToInt64(value);
			}
		}
		else if (typeof(string).IsAssignableFrom(keyProp.PropertyType))
		{
			result = value;
		}
		else
		{
			if (!typeof(Guid).IsAssignableFrom(keyProp.PropertyType))
			{
				throw new Exception(SR.T("Неподдерживаемый тип ключевого поля"));
			}
			result = Guid.Parse(value);
		}
		return result;
	}

	protected bool AssignProperties(IEntity<long> fromEntity, IEntity<long> toEntity, List<PropertyAssignInfo> assignInfo)
	{
		bool result = false;
		foreach (PropertyAssignInfo item in assignInfo)
		{
			if (!item.Assigned)
			{
				continue;
			}
			try
			{
				object obj;
				object obj2;
				if (item.Property.MasterProperty != null)
				{
					obj = item.Property.MasterProperty.GetValue(fromEntity, null);
					obj2 = item.Property.MasterProperty.GetValue(toEntity, null);
				}
				else
				{
					obj = fromEntity;
					obj2 = toEntity;
				}
				object value = item.Property.Property.GetValue(obj2, null);
				object value2 = item.Property.Property.GetValue(obj, null);
				item.Property.Property.SetValue(obj2, value2, null);
				if ((value == null || !value.Equals(value2)) && value != value2)
				{
					result = true;
				}
			}
			catch (Exception ex)
			{
				throw new Exception(SR.T("Ошибка переноса свойства {0} сущности {1}. {2}", item.Property, fromEntity, ex.Message));
			}
		}
		return result;
	}

	protected bool IsRequiredField(PropertyInfo property)
	{
		return Attribute.IsDefined(property, typeof(RequiredFieldAttribute));
	}

	protected bool CheckAnyAssignProp(Type type, List<PropertyAssignInfo> assignInfo, PropertyInfo[] skipProps)
	{
		List<MasterPropertyCheckList> list = new List<MasterPropertyCheckList>();
		foreach (PropertyAssignInfo item2 in assignInfo)
		{
			if (!list.Any((MasterPropertyCheckList x) => x.Property == item2.Property.MasterProperty) && item2.Property.MasterProperty != null)
			{
				list.Add(new MasterPropertyCheckList
				{
					Property = item2.Property.MasterProperty
				});
			}
		}
		foreach (MasterPropertyCheckList item3 in list)
		{
			MasterPropertyCheckList masterProperty = item3;
			foreach (PropertyAssignInfo item4 in assignInfo.Where((PropertyAssignInfo item) => item.Property.MasterProperty == masterProperty.Property))
			{
				if (item4.Assigned && (skipProps == null || !skipProps.Contains(item4.Property.Property)))
				{
					return true;
				}
			}
		}
		foreach (PropertyAssignInfo item5 in assignInfo.Where((PropertyAssignInfo item) => item.Property.MasterProperty == null))
		{
			if (item5.Assigned && (skipProps == null || !skipProps.Contains(item5.Property.Property)))
			{
				return true;
			}
		}
		return false;
	}

	protected bool CheckRequiredProps(Type type, List<PropertyAssignInfo> assignInfo, List<LogMessage> logMessages, string infoTemplate, PropertyInfo[] skipProps)
	{
		bool result = true;
		List<string> list = new List<string>();
		List<MasterPropertyCheckList> list2 = new List<MasterPropertyCheckList>();
		foreach (PropertyAssignInfo item2 in assignInfo)
		{
			if (!list2.Any((MasterPropertyCheckList x) => x.Property == item2.Property.MasterProperty) && item2.Property.MasterProperty != null)
			{
				list2.Add(new MasterPropertyCheckList
				{
					Property = item2.Property.MasterProperty
				});
			}
		}
		bool flag;
		bool flag2;
		foreach (MasterPropertyCheckList item3 in list2)
		{
			MasterPropertyCheckList masterProperty = item3;
			list.Clear();
			flag = false;
			flag2 = false;
			foreach (PropertyAssignInfo item4 in assignInfo.Where((PropertyAssignInfo item) => item.Property.MasterProperty == masterProperty.Property))
			{
				if (item4.Assigned && (skipProps == null || !skipProps.Contains(item4.Property.Property)))
				{
					flag = true;
				}
				if (!item4.Assigned && IsRequiredField(item4.Property.Property))
				{
					flag2 = true;
					list.Add($"[{((item4.Property.MasterProperty != null) ? item4.Property.MasterPropertyDisplayName : requsitesHeader)}].[{item4.Property.PropertyDisplayName}]");
				}
			}
			item3.HasAssigments = flag;
			item3.HasNotAssignedRequiredProperty = flag2;
			if (flag && flag2)
			{
				logMessages.Add(new LogMessage
				{
					MessageType = LogMessageType.Error,
					Message = string.Format(infoTemplate, SR.T("Не заполнены обязательные поля: {0}", string.Join("; ", list)))
				});
				result = false;
			}
		}
		list.Clear();
		flag = list2.Any((MasterPropertyCheckList x) => x.HasAssigments);
		flag2 = false;
		foreach (PropertyAssignInfo item5 in assignInfo.Where((PropertyAssignInfo item) => item.Property.MasterProperty == null))
		{
			if (item5.Assigned && (skipProps == null || !skipProps.Contains(item5.Property.Property)))
			{
				flag = true;
			}
			if (!item5.Assigned && IsRequiredField(item5.Property.Property))
			{
				flag2 = true;
				list.Add($"[{((item5.Property.MasterProperty != null) ? item5.Property.MasterPropertyDisplayName : requsitesHeader)}].[{item5.Property.PropertyDisplayName}]");
			}
		}
		if (flag && flag2)
		{
			logMessages.Add(new LogMessage
			{
				MessageType = LogMessageType.Error,
				Message = string.Format(infoTemplate, SR.T("Не заполнены обязательные поля: {0}", string.Join("; ", list)))
			});
			result = false;
		}
		return result;
	}

	public void ImportToModel(string importFileName, ImportResultModel model, ImportOptions options, bool saveEntity)
	{
		//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
		Guid timerGuid = Timers.StartTimer(TimerType.Total);
		IUnitOfWork unitOfWork = null;
		if (saveEntity)
		{
			IUnitOfWorkManager serviceNotNull = Locator.GetServiceNotNull<IUnitOfWorkManager>();
			if (!serviceNotNull.HasActiveTransaction(string.Empty))
			{
				unitOfWork = serviceNotNull.Create(string.Empty, transactional: true);
			}
		}
		try
		{
			if (importFileName == null)
			{
				throw new Exception(SR.T("Файл не указан"));
			}
			EntityMetadata entityMetadata = (EntityMetadata)MetadataLoader.LoadMetadata(entityType);
			PropertyInfo[] reflectionProperties = entityType.GetReflectionProperties();
			PropertyMetadata keyMetaProp = entityMetadata.Properties.FirstOrDefault((PropertyMetadata x) => x.Name.Equals(options.KeyFieldName));
			PropertyInfo keyProp = reflectionProperties.FirstOrDefault((PropertyInfo x) => x.Name.Equals(keyMetaProp.Name));
			PropertyInfo propertyInfo = reflectionProperties.FirstOrDefault((PropertyInfo x) => x.Name.Equals("Contacts"));
			Type type = InterfaceActivator.TypeOf(propertyInfo.PropertyType.GetGenericArguments().FirstOrDefault());
			PropertyInfo[] reflectionProperties2 = type.GetReflectionProperties();
			PropertyInfo propertyInfo2 = reflectionProperties2.FirstOrDefault((PropertyInfo p) => p.Name == "Name");
			PropertyInfo propertyInfo3 = reflectionProperties2.FirstOrDefault((PropertyInfo p) => p.Name == "Surname");
			PropertyInfo propertyInfo4 = reflectionProperties2.FirstOrDefault((PropertyInfo p) => p.Name == "Firstname");
			PropertyInfo propertyInfo5 = reflectionProperties2.FirstOrDefault((PropertyInfo p) => p.Name == "Middlename");
			List<PropertyAssignInfo> list = new List<PropertyAssignInfo>();
			List<PropertyAssignInfo> list2 = new List<PropertyAssignInfo>();
			Cells cells = new Workbook(importFileName).get_Worksheets().get_Item(0).get_Cells();
			InitDictionaries();
			model.Entities = new List<IEntity<long>>();
			List<long> list3 = new List<long>();
			int maxDataRow = cells.get_MaxDataRow();
			int i = 0;
			int num = -1;
			int num2 = -1;
			string text = cells.get_Item(0, 0).get_StringValue().Trim();
			for (; !string.IsNullOrWhiteSpace(cells.get_Item(1, i).get_StringValue()); i++)
			{
				if (!string.IsNullOrEmpty(cells.get_Item(0, i).get_StringValue().Trim()))
				{
					text = cells.get_Item(0, i).get_StringValue().Trim();
				}
				string text2 = cells.get_Item(1, i).get_StringValue().Trim();
				if (num < 0 && text == requsitesHeader && text2.Equals(keyMetaProp.DisplayName))
				{
					num = i;
				}
				if (num2 < 0 && text == contactHeader)
				{
					num2 = i;
				}
				ReflectedEntityPropertyInfo reflectedEntityPropertyInfo = null;
				reflectedEntityPropertyInfo = ((!(text != requsitesHeader) || !(text != contactHeader)) ? GetEntityPropertyByHeader(text, text2, (num2 >= 0) ? type : entityType) : GetEntityPropertyByHeader((num2 >= 0) ? contactHeader : requsitesHeader, text, (num2 >= 0) ? type : entityType));
				if (reflectedEntityPropertyInfo != null)
				{
					if (num2 >= 0 && !model.TemplateContactPropertyUids.Contains(reflectedEntityPropertyInfo.PropertyUid))
					{
						model.TemplateContactPropertyUids.Add(reflectedEntityPropertyInfo.PropertyUid);
					}
					if (num2 < 0 && !model.TemplatePropertyUids.Contains(reflectedEntityPropertyInfo.PropertyUid))
					{
						model.TemplatePropertyUids.Add(reflectedEntityPropertyInfo.PropertyUid);
					}
				}
				else
				{
					list3.Add(i);
					model.LogMessages.Add(new LogMessage
					{
						MessageType = LogMessageType.Error,
						Message = SR.T("Колонка {0}. Будет игнорироваться. Неизвестный реквизит [{1}].[{2}].", i, text, text2)
					});
				}
			}
			if (num < 0)
			{
				throw new Exception(SR.T("Колонка с ключевым полем не найдена."));
			}
			List<string> list4 = new List<string>();
			foreach (PropertyMetadata prop in entityMetadata.Properties)
			{
				if (!model.TemplatePropertyUids.Contains(prop.Uid) && IsRequiredField(reflectionProperties.FirstOrDefault((PropertyInfo x) => x.Name.Equals(prop.Name))))
				{
					list4.Add($"[{requsitesHeader}].[{prop.DisplayName}]");
				}
			}
			if (list4.Any())
			{
				throw new Exception(SR.T("Отсутствуют колонки с обязательными полями: {0}.", string.Join(", ", list4)));
			}
			List<object> list5 = null;
			if (!options.OverwriteExisting)
			{
				List<string> list6 = new List<string>();
				for (int j = 2; j <= maxDataRow; j++)
				{
					string text3 = cells.get_Item(j, num).get_StringValue().Trim();
					if (!string.IsNullOrEmpty(text3))
					{
						list6.Add(text3);
					}
				}
				list5 = GetExistingKeyValues(entityType, keyProp, list6);
			}
			for (int k = 2; k <= maxDataRow; k++)
			{
				list.Clear();
				list2.Clear();
				string text4 = cells.get_Item(k, num).get_StringValue().Trim();
				if (string.IsNullOrEmpty(text4))
				{
					model.LogMessages.Add(new LogMessage
					{
						MessageType = LogMessageType.Info,
						Message = SR.T("Строка {0}. Будет пропущена. Ключевое поле не содержит значения.", k + 1)
					});
					continue;
				}
				IEntity<long> entity2;
				bool flag;
				if (options.OverwriteExisting)
				{
					entity2 = LoadEntity(entityType, keyProp, text4);
					flag = entity2 != null;
				}
				else
				{
					entity2 = null;
					flag = list5?.Contains(ConvertStringToKey(keyProp, text4)) ?? false;
				}
				IEntity<long> entity3 = null;
				Guid timerGuid2 = Timers.StartTimer(TimerType.CreateEntity);
				if (typeof(ILead).IsAssignableFrom(entityType))
				{
					entity3 = EntityManager<ILeadContact>.Instance.Create();
					((ILeadContact)entity3).Email.Add(InterfaceActivator.Create<IEmail>());
					((ILeadContact)entity3).Phone.Add(InterfaceActivator.Create<IPhone>());
				}
				else if (typeof(IContractor).IsAssignableFrom(entityType))
				{
					entity3 = EntityManager<IContact>.Instance.Create();
					((IContact)entity3).Email.Add(InterfaceActivator.Create<IEmail>());
					((IContact)entity3).Phone.Add(InterfaceActivator.Create<IPhone>());
				}
				Timers.StopTimer(timerGuid2);
				if (num2 >= 0)
				{
					for (int l = num2; l < i; l++)
					{
						if (!string.IsNullOrEmpty(cells.get_Item(0, l).get_StringValue().Trim()))
						{
							text = cells.get_Item(0, l).get_StringValue().Trim();
						}
						if (list3.Contains(l))
						{
							continue;
						}
						string text5 = cells.get_Item(1, l).get_StringValue().Trim();
						if (!string.IsNullOrEmpty(text5))
						{
							string text6 = cells.get_Item(k, l).get_StringValue().Trim();
							ReflectedEntityPropertyInfo entityPropertyByHeader = GetEntityPropertyByHeader(text, text5, type);
							try
							{
								bool assigned = SetEntityPropertyValue(entity3, entityPropertyByHeader, text6, options.AllowAddToDictionary, saveEntity, model.LogMessages, SR.T("Строка {0}. {{0}}", k + 1));
								list.Add(new PropertyAssignInfo
								{
									Property = entityPropertyByHeader,
									Assigned = assigned
								});
							}
							catch (Exception)
							{
								model.LogMessages.Add(new LogMessage
								{
									MessageType = LogMessageType.Error,
									Message = SR.T("Строка {0}. Ошибка записи свойства [{1}].[{2}]. Значение: \"{3}\".", k + 1, text, text5, text6)
								});
							}
						}
					}
				}
				if (CheckAnyAssignProp(type, list, null))
				{
					if (CheckRequiredProps(type, list, model.LogMessages, SR.T("Строка {0}. {{0}}", k + 1), null))
					{
						propertyInfo2.SetValue(entity3, string.Join(" ", (string)propertyInfo4.GetValue(entity3, null), (string)propertyInfo5.GetValue(entity3, null), (string)propertyInfo3.GetValue(entity3, null)).Trim(), null);
						if (string.IsNullOrEmpty((string)propertyInfo2.GetValue(entity3, null)))
						{
							entity3 = null;
						}
					}
					else
					{
						entity3 = null;
					}
				}
				else
				{
					entity3 = null;
				}
				object x2 = ConvertStringToKey(keyProp, text4);
				IEntity<long> entity4 = model.Entities.FirstOrDefault((IEntity<long> item) => x2.Equals(keyProp.GetValue(item, null)));
				IEntity<long> entity;
				if (entity4 != null)
				{
					entity = entity4;
					if (entity3 == null)
					{
						model.LogMessages.Add(new LogMessage
						{
							MessageType = LogMessageType.Info,
							Message = SR.T("Строка {0}. \"{1}\" пропущен (встречался ранее).", k + 1, entity.ToString())
						});
						continue;
					}
					IEnumerable contacts = GetContacts(entity, propertyInfo);
					bool flag2 = false;
					foreach (object item in contacts)
					{
						if (!(propertyInfo2.GetValue(item, null) as string).Equals(propertyInfo2.GetValue(entity3, null)))
						{
							continue;
						}
						if (options.OverwriteExisting)
						{
							if (AssignProperties(entity3, (IEntity<long>)item, list))
							{
								model.UpdatedContacts.Add(((IEntity<long>)item).Id);
							}
							flag2 = true;
							if (saveEntity)
							{
								DropDeletedFlag(item);
								SaveEntity(item);
							}
						}
						else
						{
							model.LogMessages.Add(new LogMessage
							{
								MessageType = LogMessageType.Info,
								Message = SR.T("Строка {0}. \"{1}\" пропущен (уже существует).", k + 1, propertyInfo2.GetValue(entity3, null))
							});
						}
					}
					if (!flag2)
					{
						LinkContactToEntity(entity3, reflectionProperties2, propertyInfo, entity);
					}
				}
				else if (!flag)
				{
					entity = CreateEntity(entityType);
					eventHandlers.ForEach(delegate(IEntityImportEventHandler h)
					{
						h.OnCreate(entity, importSessionData[h]);
					});
					if (entity3 != null)
					{
						LinkContactToEntity(entity3, reflectionProperties2, propertyInfo, entity);
					}
					SetEntityPropertyValue(entity, new ReflectedEntityPropertyInfo
					{
						Property = keyProp
					}, text4, options.AllowAddToDictionary, saveEntity, model.LogMessages, SR.T("Строка {0}. {{0}}", k + 1));
				}
				else
				{
					if (!options.OverwriteExisting)
					{
						model.LogMessages.Add(new LogMessage
						{
							MessageType = LogMessageType.Info,
							Message = SR.T("Строка {0}. \"{1}\" будет пропущен (уже существует).", k + 1, text4)
						});
						continue;
					}
					entity = entity2;
					IEnumerable contacts2 = GetContacts(entity, propertyInfo);
					if (entity3 != null)
					{
						bool flag3 = false;
						foreach (object item2 in contacts2)
						{
							if (!(propertyInfo2.GetValue(item2, null) as string).Equals(propertyInfo2.GetValue(entity3, null)))
							{
								continue;
							}
							if (options.OverwriteExisting)
							{
								if (AssignProperties(entity3, (IEntity<long>)item2, list))
								{
									model.UpdatedContacts.Add(((IEntity<long>)item2).Id);
								}
								flag3 = true;
								if (saveEntity)
								{
									DropDeletedFlag(item2);
									SaveEntity(item2);
								}
							}
							else
							{
								model.LogMessages.Add(new LogMessage
								{
									MessageType = LogMessageType.Info,
									Message = SR.T("Строка {0}. \"{1}\" пропущен (уже существует).", k + 1, propertyInfo2.GetValue(entity3, null))
								});
							}
						}
						if (!flag3)
						{
							LinkContactToEntity(entity3, reflectionProperties2, propertyInfo, entity);
						}
					}
					model.LogMessages.Add(new LogMessage
					{
						MessageType = LogMessageType.Info,
						Message = SR.T("Строка {0}. \"{1}\" уже существует. Будет предпринята попытка обновления реквизитов.", k + 1, entity.ToString())
					});
				}
				bool flag4 = false;
				int num3 = ((num2 >= 0) ? num2 : (cells.get_MaxColumn() + 1));
				for (int m = 0; m < num3; m++)
				{
					if (!string.IsNullOrEmpty(cells.get_Item(0, m).get_StringValue().Trim()))
					{
						text = cells.get_Item(0, m).get_StringValue().Trim();
					}
					if (list3.Contains(m))
					{
						continue;
					}
					string text7 = cells.get_Item(1, m).get_StringValue().Trim();
					if (string.IsNullOrEmpty(text7))
					{
						continue;
					}
					string text8 = cells.get_Item(k, m).get_StringValue().Trim();
					ReflectedEntityPropertyInfo entityPropertyByHeader2 = GetEntityPropertyByHeader(text, text7, entityType);
					try
					{
						bool flag5 = SetEntityPropertyValue(entity, entityPropertyByHeader2, text8, options.AllowAddToDictionary, saveEntity, model.LogMessages, SR.T("Строка {0}. {{0}}", k + 1));
						list2.Add(new PropertyAssignInfo
						{
							Property = entityPropertyByHeader2,
							Assigned = flag5
						});
						if (!flag4 && flag5 && (!(text == requsitesHeader) || !(text7 == keyMetaProp.DisplayName)))
						{
							flag4 = true;
						}
					}
					catch (Exception)
					{
						model.LogMessages.Add(new LogMessage
						{
							MessageType = LogMessageType.Error,
							Message = SR.T("Строка {0}. Ошибка записи свойства [{1}].[{2}]. Значение: \"{3}\".", k + 1, text, text7, text8)
						});
					}
				}
				if (!CheckRequiredProps(entityType, list2, model.LogMessages, SR.T("Строка {0}. {{0}}", k + 1), (entity3 == null || entity4 == null) ? null : new PropertyInfo[1] { keyProp }))
				{
					continue;
				}
				if (entity4 == null)
				{
					eventHandlers.ForEach(delegate(IEntityImportEventHandler h)
					{
						h.AfterParse(entity, importSessionData[h]);
					});
					try
					{
						eventHandlers.ForEach(delegate(IEntityImportEventHandler h)
						{
							h.CheckRequiredProperties(entity, importSessionData[h]);
						});
					}
					catch (Exception ex3)
					{
						model.LogMessages.Add(new LogMessage
						{
							MessageType = LogMessageType.Error,
							Message = SR.T("Строка {0}. {1}", k + 1, ex3.Message)
						});
						continue;
					}
					model.Entities.Add(entity);
				}
				if (saveEntity)
				{
					DropDeletedFlag(entity);
					SaveEntity(entity);
				}
			}
		}
		catch (Exception ex4)
		{
			model.LogMessages.Add(new LogMessage
			{
				MessageType = LogMessageType.Error,
				Message = ex4.Message
			});
		}
		if (unitOfWork != null)
		{
			Guid timerGuid3 = Timers.StartTimer(TimerType.SaveEntity);
			unitOfWork.Commit();
			Timers.StopTimer(timerGuid3);
		}
		Timers.StopTimer(timerGuid);
		model.TotalTime = Timers.TotalTime;
	}
}
