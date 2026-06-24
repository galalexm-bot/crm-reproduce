using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using EleWise.ELMA.Globalization;
using EleWise.ELMA.Messaging;
using EleWise.ELMA.Notifications.Impl.TemplateGenerator;
using EleWise.ELMA.Runtime.Settings;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Templates;
using EleWise.TemplateGenerator;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Notifications.Impl;

public abstract class NotificationTemplateBase : INotificationTemplate
{
	private static TimeSpan totalGenTime;

	internal static NotificationTemplateBase dAt48pD2K458JDw6TSE;

	public abstract NotificationTemplateFileInfo FileInfo { get; }

	public abstract string Name { get; }

	public abstract List<NotificationRecipientSet> RecipientSets { get; }

	public abstract bool? RecipientSetsClear { get; }

	public abstract string Channels { get; }

	public abstract NotificationTemplateBase ChannelsTemplateBase { get; }

	public abstract string URL { get; }

	public abstract NotificationTemplateBase URLTemplateBase { get; }

	public abstract NotificationTemplateObject ObjectTemplate { get; }

	public virtual IEnumerable<IMessageBase> Generate(INotification notification)
	{
		_003C_003Ec__DisplayClass0_0 _003C_003Ec__DisplayClass0_ = new _003C_003Ec__DisplayClass0_0();
		_003C_003Ec__DisplayClass0_._003C_003E4__this = this;
		Contract.ArgumentNotNull(notification, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-138018305 ^ -137984015));
		_003C_003Ec__DisplayClass0_.messageManager = Locator.GetServiceNotNull<IMessageManager>();
		List<IMessageBase> list = new List<IMessageBase>();
		_003C_003Ec__DisplayClass0_.allRecipients = new List<long>();
		IAuthenticationService serviceNotNull = Locator.GetServiceNotNull<IAuthenticationService>();
		_003C_003Ec__DisplayClass0_.currentUser = serviceNotNull.GetCurrentUser();
		NotificationManager serviceNotNull2 = Locator.GetServiceNotNull<NotificationManager>();
		List<long> ignoredUserIds = serviceNotNull2.GetIgnoredUserIds();
		List<long> forceSendUserIds = serviceNotNull2.GetForceSendUserIds();
		List<IUser> additionalSendUsers = serviceNotNull2.GetAdditionalSendUsers();
		ILocalizationService serviceNotNull3 = Locator.GetServiceNotNull<ILocalizationService>();
		ITimeZoneService serviceNotNull4 = Locator.GetServiceNotNull<ITimeZoneService>();
		if (notification is EventNotification)
		{
			EventNotification eventNotification = (EventNotification)notification;
			if (eventNotification.ExtendedProperties.ContainsKey(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1867379187 ^ 0x6F4D77D9)) && eventNotification.ExtendedProperties[z2jc63fLkugS1X8Q9N.tE1kD1vbB(-561074844 ^ -561108146)] is IUser currentUser)
			{
				_003C_003Ec__DisplayClass0_.currentUser = currentUser;
			}
		}
		IEnumerable<NotificationRecipientSet> enumerable;
		if (additionalSendUsers.Count == 0)
		{
			IEnumerable<NotificationRecipientSet> recipientSets = RecipientSets;
			enumerable = recipientSets;
		}
		else
		{
			enumerable = RecipientSets.Union(new NotificationRecipientSet[1]
			{
				new NotificationRecipientSetFromUsers(additionalSendUsers)
			});
		}
		foreach (NotificationRecipientSet item in enumerable)
		{
			_003C_003Ec__DisplayClass0_1 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass0_1();
			CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1 = _003C_003Ec__DisplayClass0_;
			IUser[] array = item.GetRecipients(notification).OfType<IUser>().Where(delegate(IUser r)
			{
				//Discarded unreachable code: IL_004d, IL_005c
				int num6 = 1;
				int num7 = num6;
				while (true)
				{
					switch (num7)
					{
					case 1:
						if (r == null)
						{
							num7 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
							{
								num7 = 0;
							}
							break;
						}
						goto case 2;
					case 2:
						return !CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.allRecipients.Contains((long)r.GetId());
					default:
						return false;
					}
				}
			})
				.ToArray();
			if (!array.Any())
			{
				continue;
			}
			CS_0024_003C_003E8__locals0.dataSource = new NotificationGenerationData(notification);
			CS_0024_003C_003E8__locals0.dataSource[z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1921202237 ^ -1921236603)] = item.Name;
			CS_0024_003C_003E8__locals0.dataSource[z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1870892489 ^ -1870859179)] = CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.currentUser;
			if (Locator.Initialized && Locator.GetService<CommonSettingsModule>() != null)
			{
				CS_0024_003C_003E8__locals0.dataSource[z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x463A0F3C ^ 0x463A894E)] = z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x53FA00CE ^ 0x53FA864A);
			}
			List<IUser> list2 = new List<IUser>();
			List<string> list3 = (from c in SR.GetCultureNames()
				select (string)_003C_003Ec.tlMVWuflBPji4pr7ELv7(c)).ToList();
			CS_0024_003C_003E8__locals0.messageKindDictionary = new Dictionary<long, Tuple<int, CultureInfo>>();
			bool flag = item.SendToAuthorOnly || IsSendToAuthor(CS_0024_003C_003E8__locals0.dataSource);
			IUser[] array2 = array;
			foreach (IUser user in array2)
			{
				if (!CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.allRecipients.Contains((long)user.GetId()) && (!item.SendToAuthorOnly || user == CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.currentUser) && ((user == CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.currentUser && flag) || !ignoredUserIds.Contains((long)user.GetId())))
				{
					long num = (long)user.GetId();
					CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.allRecipients.Add(num);
					list2.Add(user);
					int offset = serviceNotNull4.GetUserTimeZone(user).Offset;
					CultureInfo cultureInfo = serviceNotNull3.Load(user);
					if (!list3.Contains(cultureInfo.Name))
					{
						cultureInfo = SR.GetDefaultCulture() ?? SR.KeyCultureInfo;
					}
					CS_0024_003C_003E8__locals0.messageKindDictionary.Add(num, new Tuple<int, CultureInfo>(offset, cultureInfo));
				}
			}
			CS_0024_003C_003E8__locals0.messageTemplates = new Dictionary<Tuple<int, string>, IMessage>();
			foreach (Tuple<int, CultureInfo> item2 in CS_0024_003C_003E8__locals0.messageKindDictionary.Values.Distinct())
			{
				_003C_003Ec__DisplayClass0_2 CS_0024_003C_003E8__locals1 = new _003C_003Ec__DisplayClass0_2();
				CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals2 = CS_0024_003C_003E8__locals0;
				CS_0024_003C_003E8__locals1.offset = item2.Item1;
				CS_0024_003C_003E8__locals1.culture = item2.Item2;
				SR.RunWithCulture(CS_0024_003C_003E8__locals1.culture, delegate
				{
					//Discarded unreachable code: IL_0613, IL_0622
					int num4 = 4;
					int num5 = num4;
					IMessage message3 = default(IMessage);
					while (true)
					{
						switch (num5)
						{
						case 1:
						{
							NotificationTemplateBase _003C_003E4__this3 = CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1._003C_003E4__this;
							IMessage message6 = message3;
							ParameterExpression parameterExpression = (ParameterExpression)_003C_003Ec__DisplayClass0_2.JDckurfd621DjstOJest(_003C_003Ec__DisplayClass0_2.D6JPHrfd4uljniJV8yHE(typeof(IMessage).TypeHandle), z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1333735954 ^ 0x4F7D48BC));
							_003C_003E4__this3.GenerateMessagePart(message6, Expression.Lambda<Func<IMessage, string>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), (string)_003C_003Ec__DisplayClass0_2.BdGvLDfdrTiIUPkRRaji(CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1._003C_003E4__this, CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals2.dataSource), (NotificationTemplateBase)_003C_003Ec__DisplayClass0_2.WfSAp4fdgYHafyGhgFjk(CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1._003C_003E4__this, CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals2.dataSource), CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals2.dataSource, CS_0024_003C_003E8__locals1.offset, TemplateRenderMode.HTML);
							num5 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
							{
								num5 = 0;
							}
							break;
						}
						case 2:
						{
							NotificationTemplateBase _003C_003E4__this5 = CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1._003C_003E4__this;
							IMessage message8 = message3;
							ParameterExpression parameterExpression = (ParameterExpression)_003C_003Ec__DisplayClass0_2.JDckurfd621DjstOJest(typeof(IMessage), _003C_003Ec__DisplayClass0_2.U8Vpimfd7Su9N7FwYsxo(-867826612 ^ -867926302));
							_003C_003E4__this5.GenerateMessagePart(message8, Expression.Lambda<Func<IMessage, string>>(Expression.Property(parameterExpression, (MethodInfo)_003C_003Ec__DisplayClass0_2.f9U8mSfdHi4KT6T3oZpy((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), (string)_003C_003Ec__DisplayClass0_2.fWPFsSfdyenMDhU2MY4m(CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1._003C_003E4__this), (NotificationTemplateBase)_003C_003Ec__DisplayClass0_2.EjQIo6fdMD9G6pihvew3(CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1._003C_003E4__this), CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals2.dataSource, CS_0024_003C_003E8__locals1.offset);
							num5 = 11;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
							{
								num5 = 14;
							}
							break;
						}
						case 7:
						case 8:
							CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals2.messageTemplates.Add(new Tuple<int, string>(CS_0024_003C_003E8__locals1.offset, (string)_003C_003Ec__DisplayClass0_2.wxAOOPfdUcHbZ8i8phjZ(CS_0024_003C_003E8__locals1.culture)), message3);
							num5 = 10;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
							{
								num5 = 8;
							}
							break;
						case 6:
						{
							NotificationTemplateBase _003C_003E4__this9 = CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1._003C_003E4__this;
							IMessage message12 = message3;
							ParameterExpression parameterExpression = (ParameterExpression)_003C_003Ec__DisplayClass0_2.JDckurfd621DjstOJest(typeof(IMessage), _003C_003Ec__DisplayClass0_2.U8Vpimfd7Su9N7FwYsxo(-1334993905 ^ -1334843743));
							_003C_003E4__this9.GenerateMessagePart(message12, Expression.Lambda<Func<IMessage, string>>((Expression)_003C_003Ec__DisplayClass0_2.DsZwd8fdxZT7m3BmPdSE(parameterExpression, (MethodInfo)_003C_003Ec__DisplayClass0_2.f9U8mSfdHi4KT6T3oZpy((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), (string)_003C_003Ec__DisplayClass0_2.F1aK6kfddlG9pRGExOfo(CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1._003C_003E4__this, CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals2.dataSource), (NotificationTemplateBase)_003C_003Ec__DisplayClass0_2.GPGdIlfdlsteP8uqnrVp(CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1._003C_003E4__this, CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals2.dataSource), CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals2.dataSource, CS_0024_003C_003E8__locals1.offset);
							num5 = 5;
							break;
						}
						case 10:
							return;
						case 14:
						{
							NotificationTemplateBase _003C_003E4__this8 = CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1._003C_003E4__this;
							IMessage message11 = message3;
							ParameterExpression parameterExpression = (ParameterExpression)_003C_003Ec__DisplayClass0_2.JDckurfd621DjstOJest(_003C_003Ec__DisplayClass0_2.D6JPHrfd4uljniJV8yHE(typeof(IMessage).TypeHandle), _003C_003Ec__DisplayClass0_2.U8Vpimfd7Su9N7FwYsxo(-3333094 ^ -3187020));
							_003C_003E4__this8.GenerateMessagePart(message11, Expression.Lambda<Func<IMessage, string>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), (string)_003C_003Ec__DisplayClass0_2.CEEbV1fdJVNUFVitmtG0(CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1._003C_003E4__this, CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals2.dataSource), (NotificationTemplateBase)_003C_003Ec__DisplayClass0_2.D1Ir4xfd9VuJDU4qYjpq(CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1._003C_003E4__this, CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals2.dataSource), CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals2.dataSource, CS_0024_003C_003E8__locals1.offset);
							num5 = 6;
							break;
						}
						case 4:
							message3 = (IMessage)_003C_003Ec__DisplayClass0_2.wIvfbxfdwWY0JIgEAJqL(CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1.messageManager);
							num5 = 3;
							break;
						case 3:
						{
							NotificationTemplateBase _003C_003E4__this7 = CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1._003C_003E4__this;
							IMessage message10 = message3;
							ParameterExpression parameterExpression = (ParameterExpression)_003C_003Ec__DisplayClass0_2.JDckurfd621DjstOJest(_003C_003Ec__DisplayClass0_2.D6JPHrfd4uljniJV8yHE(typeof(IMessage).TypeHandle), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x53FA00CE ^ 0x53F87A60));
							_003C_003E4__this7.GenerateMessagePart(message10, Expression.Lambda<Func<IMessage, string>>(Expression.Property(parameterExpression, (MethodInfo)_003C_003Ec__DisplayClass0_2.f9U8mSfdHi4KT6T3oZpy((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), (string)_003C_003Ec__DisplayClass0_2.XbyllifdAw5fA3f5yBtj(CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1._003C_003E4__this, CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals2.dataSource), CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1._003C_003E4__this.GetAuthorTemplateBase(CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals2.dataSource), CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals2.dataSource, CS_0024_003C_003E8__locals1.offset);
							num5 = 12;
							break;
						}
						default:
						{
							NotificationTemplateBase _003C_003E4__this6 = CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1._003C_003E4__this;
							IMessage message9 = message3;
							ParameterExpression parameterExpression = (ParameterExpression)_003C_003Ec__DisplayClass0_2.JDckurfd621DjstOJest(_003C_003Ec__DisplayClass0_2.D6JPHrfd4uljniJV8yHE(typeof(IMessage).TypeHandle), _003C_003Ec__DisplayClass0_2.U8Vpimfd7Su9N7FwYsxo(0x61EC0CB8 ^ 0x61EE7616));
							_003C_003E4__this6.GenerateMessagePart(message9, Expression.Lambda<Func<IMessage, CustomMessage[]>>((Expression)_003C_003Ec__DisplayClass0_2.DsZwd8fdxZT7m3BmPdSE(parameterExpression, (MethodInfo)_003C_003Ec__DisplayClass0_2.f9U8mSfdHi4KT6T3oZpy((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1._003C_003E4__this.GetCustomMessages(CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals2.dataSource), (NotificationTemplateBase)_003C_003Ec__DisplayClass0_2.O9jBFsfd54vegNCMJlnQ(CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1._003C_003E4__this, CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals2.dataSource), CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals2.dataSource, CS_0024_003C_003E8__locals1.offset, TemplateRenderMode.HTML);
							num5 = 13;
							break;
						}
						case 13:
							if (_003C_003Ec__DisplayClass0_2.Rfu1fcfdjYRi5dnU45lZ(CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1._003C_003E4__this) == null)
							{
								num5 = 7;
								break;
							}
							goto case 11;
						case 5:
						{
							NotificationTemplateBase _003C_003E4__this4 = CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1._003C_003E4__this;
							IMessage message7 = message3;
							ParameterExpression parameterExpression = (ParameterExpression)_003C_003Ec__DisplayClass0_2.JDckurfd621DjstOJest(_003C_003Ec__DisplayClass0_2.D6JPHrfd4uljniJV8yHE(typeof(IMessage).TypeHandle), _003C_003Ec__DisplayClass0_2.U8Vpimfd7Su9N7FwYsxo(-16752921 ^ -16636855));
							_003C_003E4__this4.GenerateMessagePart(message7, Expression.Lambda<Func<IMessage, string>>((Expression)_003C_003Ec__DisplayClass0_2.DsZwd8fdxZT7m3BmPdSE(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), (string)_003C_003Ec__DisplayClass0_2.F1aK6kfddlG9pRGExOfo(CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1._003C_003E4__this, CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals2.dataSource), (NotificationTemplateBase)_003C_003Ec__DisplayClass0_2.GPGdIlfdlsteP8uqnrVp(CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1._003C_003E4__this, CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals2.dataSource), CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals2.dataSource, CS_0024_003C_003E8__locals1.offset, TemplateRenderMode.HTML);
							num5 = 9;
							break;
						}
						case 9:
						{
							NotificationTemplateBase _003C_003E4__this2 = CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1._003C_003E4__this;
							IMessage message5 = message3;
							ParameterExpression parameterExpression = (ParameterExpression)_003C_003Ec__DisplayClass0_2.JDckurfd621DjstOJest(typeof(IMessage), _003C_003Ec__DisplayClass0_2.U8Vpimfd7Su9N7FwYsxo(-2138160520 ^ -2138294058));
							_003C_003E4__this2.GenerateMessagePart(message5, Expression.Lambda<Func<IMessage, string>>((Expression)_003C_003Ec__DisplayClass0_2.DsZwd8fdxZT7m3BmPdSE(parameterExpression, (MethodInfo)_003C_003Ec__DisplayClass0_2.f9U8mSfdHi4KT6T3oZpy((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), (string)_003C_003Ec__DisplayClass0_2.BdGvLDfdrTiIUPkRRaji(CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1._003C_003E4__this, CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals2.dataSource), (NotificationTemplateBase)_003C_003Ec__DisplayClass0_2.WfSAp4fdgYHafyGhgFjk(CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1._003C_003E4__this, CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals2.dataSource), CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals2.dataSource, CS_0024_003C_003E8__locals1.offset);
							num5 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
							{
								num5 = 1;
							}
							break;
						}
						case 11:
							_003C_003Ec__DisplayClass0_2.clAypKfdL7Wk0jfThPu2(message3, _003C_003Ec__DisplayClass0_2.BoXDQJfdYmghQJ7YRWH8(_003C_003Ec__DisplayClass0_2.Rfu1fcfdjYRi5dnU45lZ(CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1._003C_003E4__this), CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals2.dataSource));
							num5 = 8;
							break;
						case 12:
						{
							NotificationTemplateBase _003C_003E4__this = CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1._003C_003E4__this;
							IMessage message4 = message3;
							ParameterExpression parameterExpression = (ParameterExpression)_003C_003Ec__DisplayClass0_2.JDckurfd621DjstOJest(_003C_003Ec__DisplayClass0_2.D6JPHrfd4uljniJV8yHE(typeof(IMessage).TypeHandle), _003C_003Ec__DisplayClass0_2.U8Vpimfd7Su9N7FwYsxo(-1487388570 ^ -1487258936));
							_003C_003E4__this.GenerateMessagePart(message4, Expression.Lambda<Func<IMessage, string>>((Expression)_003C_003Ec__DisplayClass0_2.DsZwd8fdxZT7m3BmPdSE(parameterExpression, (MethodInfo)_003C_003Ec__DisplayClass0_2.f9U8mSfdHi4KT6T3oZpy((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), (string)_003C_003Ec__DisplayClass0_2.M5qp2Efd0g11aqU2oXmE(CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1._003C_003E4__this), (NotificationTemplateBase)_003C_003Ec__DisplayClass0_2.IJqnRRfdmvY9GsErhHQK(CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1._003C_003E4__this), CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals2.dataSource, CS_0024_003C_003E8__locals1.offset);
							num5 = 2;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
							{
								num5 = 2;
							}
							break;
						}
						}
					}
				});
			}
			foreach (IGrouping<Tuple<int, string>, IUser> item3 in list2.GroupBy(delegate(IUser i)
			{
				Tuple<int, CultureInfo> tuple = CS_0024_003C_003E8__locals0.messageKindDictionary[(long)i.GetId()];
				return new Tuple<int, string>(tuple.Item1, tuple.Item2.Name);
			}).ToList())
			{
				IMessage message = CS_0024_003C_003E8__locals0.messageTemplates[item3.Key];
				IMessage message2 = CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.messageManager.Create();
				message2.Author = CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.currentUser;
				message2.AuthorText = message.AuthorText;
				message2.Channels = message.Channels;
				message2.Recipient = item3.ToList();
				message2.URL = message.URL;
				message2.Subject = message.Subject;
				message2.ShortMessageText = message.ShortMessageText;
				message2.ShortMessageHtml = message.ShortMessageHtml;
				message2.FullMessageText = message.FullMessageText;
				message2.FullMessageHtml = message.FullMessageHtml;
				message2.ObjectId = message.ObjectId;
				message2.SendToAuthor = flag || (CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.currentUser != null && item3.Any(delegate(IUser u)
				{
					//Discarded unreachable code: IL_004d, IL_005c
					int num2 = 2;
					int num3 = num2;
					while (true)
					{
						switch (num3)
						{
						case 2:
							if (u == null)
							{
								num3 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
								{
									num3 = 1;
								}
								break;
							}
							goto default;
						default:
							return (long)_003C_003Ec__DisplayClass0_0.txpjR0fde5m8W0r0YKOK(u) == (long)_003C_003Ec__DisplayClass0_0.txpjR0fde5m8W0r0YKOK(CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.currentUser);
						case 1:
							return false;
						}
					}
				}) && forceSendUserIds.Contains((long)CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.currentUser.GetId()));
				message2.CustomMessages = message.CustomMessages;
				INotificationMessageHandler serviceNotNull5 = Locator.GetServiceNotNull<INotificationMessageHandler>();
				if (notification is IEventNotification eventNotification2)
				{
					message2.ObjectUid = ((eventNotification2.Object != null) ? new Guid?(eventNotification2.Object.Uid) : null);
					message2.ActionUid = ((eventNotification2.Action != null) ? new Guid?(eventNotification2.Action.Uid) : null);
				}
				if (message2.ObjectUid.HasValue && message2.ObjectId != null && message2.ActionUid.HasValue)
				{
					message2.Delayed = CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.messageManager.IsDelayed(message2.ObjectUid.Value, message2.ObjectId, message2.ActionUid.Value);
				}
				serviceNotNull5.ProcessNotificationToMessage(notification, message2);
				list.Add(message2);
			}
		}
		return list;
	}

	public abstract bool CheckFilter(INotification notification);

	public abstract string GetAuthor(object notificationDataSource);

	public abstract bool IsAuthorOverride(object notificationDataSource);

	public abstract NotificationTemplateBase GetAuthorTemplateBase(object notificationDataSource);

	public abstract string GetSubject(object notificationDataSource);

	public abstract bool IsSubjectOverride(object notificationDataSource);

	public abstract NotificationTemplateBase GetSubjectTemplateBase(object notificationDataSource);

	public abstract string GetShortMessage(object notificationDataSource);

	public abstract bool IsShortMessageOverride(object notificationDataSource);

	public abstract NotificationTemplateBase GetShortMessageTemplateBase(object notificationDataSource);

	public abstract string GetFullMessage(object notificationDataSource);

	public abstract bool IsFullMessageOverride(object notificationDataSource);

	public abstract NotificationTemplateBase GetFullMessageTemplateBase(object notificationDataSource);

	public abstract CustomMessage[] GetCustomMessages(object notificationDataSource);

	public abstract NotificationTemplateBase GetCustomMessagesTemplateBase(object notificationDataSource);

	public abstract bool IsSendToAuthor(object notificationDataSource);

	protected void GenerateMessagePart(IMessage message, Expression<Func<IMessage, string>> messageProperty, string template, NotificationTemplateBase templateBase, object dataSource, int offset, TemplateRenderMode renderMode = TemplateRenderMode.Default)
	{
		PropertyInfo propertyInfo = ((messageProperty.Body as MemberExpression) ?? throw new Exception(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1867198571 ^ -1867233013))).Member as PropertyInfo;
		if (propertyInfo == null)
		{
			throw new Exception(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-957824448 ^ -957856590));
		}
		try
		{
			DateTime now = DateTime.Now;
			string value = ((!string.IsNullOrEmpty(template)) ? new NotificationTemplateGenerator(template, templateBase, renderMode)
			{
				Provider = 
				{
					TemplateTimeZoneOffset = offset
				}
			}.Generate(dataSource) : string.Empty);
			totalGenTime += DateTime.Now - now;
			propertyInfo.SetValue(message, value, null);
		}
		catch (Exception innerException)
		{
			throw new Exception(string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1876063057 ^ -1876096005), propertyInfo.Name), innerException);
		}
	}

	protected void GenerateMessagePart(IMessage message, Expression<Func<IMessage, CustomMessage[]>> messageProperty, CustomMessage[] templates, NotificationTemplateBase templateBase, object dataSource, int offset, TemplateRenderMode renderMode = TemplateRenderMode.Default)
	{
		_003C_003Ec__DisplayClass36_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass36_0();
		CS_0024_003C_003E8__locals0.templateBase = templateBase;
		CS_0024_003C_003E8__locals0.renderMode = renderMode;
		CS_0024_003C_003E8__locals0.offset = offset;
		CS_0024_003C_003E8__locals0.dataSource = dataSource;
		PropertyInfo propertyInfo = ((messageProperty.Body as MemberExpression) ?? throw new Exception(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x57A5235E ^ 0x57A5A5C0))).Member as PropertyInfo;
		if (propertyInfo == null)
		{
			throw new Exception(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x571EA399 ^ 0x571E256B));
		}
		try
		{
			DateTime now = DateTime.Now;
			if (templates == null || !templates.Any())
			{
				return;
			}
			List<CustomMessage> list = templates.Select(delegate(CustomMessage t)
			{
				int num = 2;
				int num2 = num;
				NotificationTemplateGenerator notificationTemplateGenerator = default(NotificationTemplateGenerator);
				while (true)
				{
					switch (num2)
					{
					default:
						return new CustomMessage
						{
							Key = t.Key,
							Content = (string)_003C_003Ec__DisplayClass36_0.aiDiy1flEQDXH5aYOwaB(notificationTemplateGenerator, CS_0024_003C_003E8__locals0.dataSource)
						};
					case 1:
						((IGeneratorProvider)_003C_003Ec__DisplayClass36_0.d7EHKcflGp2LKetyEVZa(notificationTemplateGenerator)).TemplateTimeZoneOffset = CS_0024_003C_003E8__locals0.offset;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
						{
							num2 = 0;
						}
						break;
					case 2:
						notificationTemplateGenerator = new NotificationTemplateGenerator(t.Content, CS_0024_003C_003E8__locals0.templateBase, CS_0024_003C_003E8__locals0.renderMode);
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0)
						{
							num2 = 1;
						}
						break;
					}
				}
			}).ToList();
			totalGenTime += DateTime.Now - now;
			propertyInfo.SetValue(message, list.ToArray(), null);
		}
		catch (Exception innerException)
		{
			throw new Exception(string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-978351861 ^ -978383265), propertyInfo.Name), innerException);
		}
	}

	public override string ToString()
	{
		return (string)ApA6ftDaknufGp9qM48(H61YwpDNtaBFiBZtxE0(wKVO8UD1QPQGFKENrAt(this)), mE9wd9D3Drp4jO1Q5A7(-2099751081 ^ -2099760377), TqhT3DDpwHraE9uKvor(this));
	}

	protected NotificationTemplateBase()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		sw4YKxDDkZY4jnkKj05();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static NotificationTemplateBase()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				totalGenTime = TimeSpan.Zero;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				sw4YKxDDkZY4jnkKj05();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return;
			}
		}
	}

	internal static object wKVO8UD1QPQGFKENrAt(object P_0)
	{
		return ((NotificationTemplateBase)P_0).FileInfo;
	}

	internal static object H61YwpDNtaBFiBZtxE0(object P_0)
	{
		return ((NotificationTemplateFileInfo)P_0).Name;
	}

	internal static object mE9wd9D3Drp4jO1Q5A7(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object TqhT3DDpwHraE9uKvor(object P_0)
	{
		return ((NotificationTemplateBase)P_0).Name;
	}

	internal static object ApA6ftDaknufGp9qM48(object P_0, object P_1, object P_2)
	{
		return (string)P_0 + (string)P_1 + (string)P_2;
	}

	internal static bool dAoVF4DeKyMBpiFEaIB()
	{
		return dAt48pD2K458JDw6TSE == null;
	}

	internal static NotificationTemplateBase d8gZ3CDPfljsZ7AMOhD()
	{
		return dAt48pD2K458JDw6TSE;
	}

	internal static void sw4YKxDDkZY4jnkKj05()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
