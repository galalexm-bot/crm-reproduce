using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Actions;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Model.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Event;
using NHibernate.Persister.Entity;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Runtime.NH.Listeners;

[Component]
public class EntityActionRaiseEventListener : PostFlushEventListener
{
	internal static EntityActionRaiseEventListener rOpcLeW7IDQH3gFmSHEV;

	public IEntityActionHandler EntityActionHandler
	{
		[CompilerGenerated]
		get
		{
			return _003CEntityActionHandler_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					_003CEntityActionHandler_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	public override void OnPostInsert(PostInsertEvent @event)
	{
		//Discarded unreachable code: IL_00c7
		int num = 4;
		int num2 = num;
		EntityActionEventArgs entityActionEventArgs = default(EntityActionEventArgs);
		IEntity entity = default(IEntity);
		while (true)
		{
			switch (num2)
			{
			case 6:
				if (entityActionEventArgs != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
					{
						num2 = 0;
					}
					break;
				}
				return;
			default:
				XL1dShW7qf5kYTEuH9wx(EntityActionHandler, entityActionEventArgs);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
				{
					num2 = 1;
				}
				break;
			case 4:
				entity = ki75mOW7i8fcQIEgmQEU(@event) as IEntity;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
				{
					num2 = 3;
				}
				break;
			case 2:
				return;
			case 5:
				entityActionEventArgs = (EntityActionEventArgs)nPAXKAW7RGfoU4brVUoF(null, entity, DefaultEntityActions.CreateGuid);
				num2 = 6;
				break;
			case 1:
				return;
			case 3:
				if (entity == null)
				{
					return;
				}
				num2 = 5;
				break;
			}
		}
	}

	public override void OnPostUpdate(PostUpdateEvent @event)
	{
		//Discarded unreachable code: IL_00f8, IL_012b, IL_0195, IL_01a4, IL_01f9, IL_0228, IL_02c5, IL_02d4, IL_0378, IL_0387, IL_03a8
		int num = 11;
		string text = default(string);
		int num3 = default(int);
		IEntity entity2 = default(IEntity);
		IEntity entity = default(IEntity);
		PropertyInfo propertyInfo = default(PropertyInfo);
		EditEntityActionEventArgs editEntityActionEventArgs = default(EditEntityActionEventArgs);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 12:
				case 14:
					text = (string)((object[])JFbIWNW7OWbiQnCn3fj2(WnmbduW7XhSB1Ceevi4M(@event)))[num3];
					num2 = 20;
					continue;
				case 7:
					return;
				case 6:
					entity2 = (IEntity)psRJm5W7nWHeafsc6Ygt(entity.CastAsRealType().GetType().GetTypeWithoutProxy());
					num2 = 19;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
					{
						num2 = 9;
					}
					continue;
				case 5:
					try
					{
						propertyInfo.SetValue(entity2, ((object[])jg7wZNW7K9HVKFJS9C6S(@event))[num3], null);
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
						{
							num4 = 0;
						}
						switch (num4)
						{
						case 0:
							break;
						}
					}
					catch (Exception exception)
					{
						int num5 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
						{
							num5 = 1;
						}
						while (true)
						{
							switch (num5)
							{
							case 1:
								((ILogger)uKp21CW7P1Q3j5IOPd44()).Error(TE0LOHW71Gk3mTrH1239(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1979251663 ^ -1979374615), text, entity2.GetType().FullName), exception);
								num5 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 != 0)
								{
									num5 = 0;
								}
								continue;
							case 0:
								break;
							}
							break;
						}
					}
					goto case 21;
				case 13:
					return;
				case 4:
					if (jg7wZNW7K9HVKFJS9C6S(@event) == null)
					{
						num2 = 15;
						continue;
					}
					goto case 18;
				case 20:
					propertyInfo = (PropertyInfo)tn29KTW720KDAxDiM3MD(entity2.CastAsRealType().GetType(), text);
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
					{
						num2 = 8;
					}
					continue;
				case 21:
				case 22:
					num3++;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
					{
						num2 = 1;
					}
					continue;
				case 15:
					return;
				case 8:
					if (!(propertyInfo != null))
					{
						num2 = 22;
						continue;
					}
					goto case 16;
				case 17:
					if (editEntityActionEventArgs == null)
					{
						return;
					}
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
					{
						num2 = 0;
					}
					continue;
				case 16:
					if (uZatRIW7eEkwHwTcFerM(propertyInfo))
					{
						num2 = 5;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
						{
							num2 = 4;
						}
						continue;
					}
					goto case 21;
				case 11:
					entity = ki75mOW7i8fcQIEgmQEU(@event) as IEntity;
					num2 = 10;
					continue;
				case 1:
				case 2:
					if (num3 < ((Array)jg7wZNW7K9HVKFJS9C6S(@event)).Length)
					{
						num2 = 14;
						continue;
					}
					goto case 9;
				case 3:
					return;
				case 9:
					editEntityActionEventArgs = (EditEntityActionEventArgs)EEqwvXW7NONjhPDUM08j(entity2, entity, JFbIWNW7OWbiQnCn3fj2(((AbstractPostDatabaseOperationEvent)@event).get_Persister()));
					num2 = 12;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0)
					{
						num2 = 17;
					}
					continue;
				case 18:
					if (@event.get_OldState().Length != 0)
					{
						if (!rvYgIbW7kHaaxU2AwVBk(((AbstractEvent)@event).get_Session(), WnmbduW7XhSB1Ceevi4M(@event), jg7wZNW7K9HVKFJS9C6S(@event), q8xxO6W7TRCwhwaUSPJ4(@event), ki75mOW7i8fcQIEgmQEU(@event)))
						{
							return;
						}
						num2 = 6;
					}
					else
					{
						num2 = 3;
					}
					continue;
				case 10:
					if (entity == null)
					{
						return;
					}
					num2 = 4;
					continue;
				case 19:
					num3 = 0;
					num2 = 2;
					continue;
				}
				break;
			}
			XL1dShW7qf5kYTEuH9wx(EntityActionHandler, editEntityActionEventArgs);
			num = 13;
		}
	}

	public override void OnPostDelete(PostDeleteEvent @event)
	{
		int num = 2;
		int num2 = num;
		IEntity entity = default(IEntity);
		EntityActionEventArgs entityActionEventArgs = default(EntityActionEventArgs);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				if (entity == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0)
					{
						num2 = 0;
					}
					break;
				}
				entityActionEventArgs = EntityActionEventArgs.TryCreate(entity, null, DefaultEntityActions.DeleteGuid);
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
				{
					num2 = 4;
				}
				break;
			case 4:
				if (entityActionEventArgs != null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0)
					{
						num2 = 5;
					}
					break;
				}
				return;
			case 0:
				return;
			case 5:
				XL1dShW7qf5kYTEuH9wx(EntityActionHandler, entityActionEventArgs);
				num2 = 3;
				break;
			case 3:
				return;
			case 2:
				entity = ki75mOW7i8fcQIEgmQEU(@event) as IEntity;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public EntityActionRaiseEventListener()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		MG7HYLW731hynOcHR7ml();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool XrwjRsW7VSHhfy7DgWKG()
	{
		return rOpcLeW7IDQH3gFmSHEV == null;
	}

	internal static EntityActionRaiseEventListener ywrDunW7S1KGQ2wyZ9AU()
	{
		return rOpcLeW7IDQH3gFmSHEV;
	}

	internal static object ki75mOW7i8fcQIEgmQEU(object P_0)
	{
		return ((AbstractPostDatabaseOperationEvent)P_0).get_Entity();
	}

	internal static object nPAXKAW7RGfoU4brVUoF(object P_0, object P_1, Guid actionUid)
	{
		return EntityActionEventArgs.TryCreate((IEntity)P_0, (IEntity)P_1, actionUid);
	}

	internal static void XL1dShW7qf5kYTEuH9wx(object P_0, object P_1)
	{
		((IEntityActionHandler)P_0).ActionExecuted((EntityActionEventArgs)P_1);
	}

	internal static object jg7wZNW7K9HVKFJS9C6S(object P_0)
	{
		return ((PostUpdateEvent)P_0).get_OldState();
	}

	internal static object WnmbduW7XhSB1Ceevi4M(object P_0)
	{
		return ((AbstractPostDatabaseOperationEvent)P_0).get_Persister();
	}

	internal static object q8xxO6W7TRCwhwaUSPJ4(object P_0)
	{
		return ((PostUpdateEvent)P_0).get_State();
	}

	internal static bool rvYgIbW7kHaaxU2AwVBk(object P_0, object P_1, object P_2, object P_3, object P_4)
	{
		return ((ISession)P_0).IsDirtyEntity((IEntityPersister)P_1, (object[])P_2, (object[])P_3, P_4);
	}

	internal static object psRJm5W7nWHeafsc6Ygt(Type t)
	{
		return InterfaceActivator.Create(t);
	}

	internal static object JFbIWNW7OWbiQnCn3fj2(object P_0)
	{
		return ((IEntityPersister)P_0).get_PropertyNames();
	}

	internal static object tn29KTW720KDAxDiM3MD(Type type, object P_1)
	{
		return type.GetReflectionProperty((string)P_1);
	}

	internal static bool uZatRIW7eEkwHwTcFerM(object P_0)
	{
		return ((PropertyInfo)P_0).CanWrite;
	}

	internal static object uKp21CW7P1Q3j5IOPd44()
	{
		return Logger.Log;
	}

	internal static object TE0LOHW71Gk3mTrH1239(object P_0, object P_1, object P_2)
	{
		return string.Format((string)P_0, P_1, P_2);
	}

	internal static object EEqwvXW7NONjhPDUM08j(object P_0, object P_1, object P_2)
	{
		return EditEntityActionEventArgs.TryCreate((IEntity)P_0, (IEntity)P_1, (string[])P_2);
	}

	internal static void MG7HYLW731hynOcHR7ml()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
