using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.ExportHelper;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Services;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Managers;

[DeveloperApi(DeveloperApiType.Manager)]
public class CustomActivityFolderManager : EntityManager<ICustomActivityFolder, long>
{
	private static CustomActivityFolderManager xlFkKWKDATdJ7J00Eyc;

	[NotNull]
	public new static CustomActivityFolderManager Instance => Locator.GetServiceNotNull<CustomActivityFolderManager>();

	public CustomActivityManager CustomActivityManager
	{
		[CompilerGenerated]
		get
		{
			return _003CCustomActivityManager_003Ek__BackingField;
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
					_003CCustomActivityManager_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_c3ae8e111f574ce9b09d9ed725c1ab53 == 0)
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

	public CustomActivityHeaderManager CustomActivityHeaderManager
	{
		[CompilerGenerated]
		get
		{
			return _003CCustomActivityHeaderManager_003Ek__BackingField;
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
				case 0:
					return;
				case 1:
					_003CCustomActivityHeaderManager_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_2a731ad20cd44175bde6db1171290626 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public IEnumerable<ICustomActivityFolder> LoadRootFolders()
	{
		return CreateCriteria().Add((ICriterion)(object)Restrictions.IsNull(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3D87FABF ^ 0x3D87ADAB))).List<ICustomActivityFolder>();
	}

	[Transaction]
	public virtual void Delete(long folderId)
	{
		int num = 2;
		int num2 = num;
		ICustomActivityFolder customActivityFolder = default(ICustomActivityFolder);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 3:
				return;
			case 2:
				customActivityFolder = LoadOrNull(folderId);
				num2 = 1;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_67ef56456b804d908fd1218d899249dc == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				if (customActivityFolder != null)
				{
					Delete(customActivityFolder);
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_2d82a778b0ee4fc0915a368d2259a8f3 == 0)
					{
						num2 = 0;
					}
				}
				else
				{
					num2 = 3;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public override ExportRuleList ExportRules()
	{
		int num = 1;
		int num2 = num;
		Type type = default(Type);
		while (true)
		{
			switch (num2)
			{
			case 1:
				type = InterfaceActivator.TypeOf<ICustomActivityFolder>();
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_98890646a18d4a91b352a4ea5d1be319 == 0)
				{
					num2 = 0;
				}
				continue;
			}
			ExportRuleList exportRuleList = new ExportRuleList();
			ExportRule obj = new ExportRule
			{
				ParentType = type
			};
			Eb7hy4KYn9tRoGRtvVP(obj, IsEgVKKaG6WOIbMCQuM(-138431307 ^ -138416359));
			Jjo4d8KvJZHP4nLaVLS(obj, ExportRuleType.Export);
			exportRuleList.Add(obj);
			ExportRule exportRule = new ExportRule();
			Gy9Rw3KPOaAOn6Vm7gE(exportRule, type);
			Eb7hy4KYn9tRoGRtvVP(exportRule, IsEgVKKaG6WOIbMCQuM(0x2B6686C0 ^ 0x2B66D1D4));
			Jjo4d8KvJZHP4nLaVLS(exportRule, ExportRuleType.Export);
			exportRuleList.Add(exportRule);
			ExportRule exportRule2 = new ExportRule();
			Gy9Rw3KPOaAOn6Vm7gE(exportRule2, type);
			Eb7hy4KYn9tRoGRtvVP(exportRule2, IsEgVKKaG6WOIbMCQuM(0x5DD795B3 ^ 0x5DD7C3CF));
			Jjo4d8KvJZHP4nLaVLS(exportRule2, ExportRuleType.Export);
			exportRuleList.Add(exportRule2);
			ExportRule obj2 = new ExportRule
			{
				ParentType = type,
				PropertyName = (string)IsEgVKKaG6WOIbMCQuM(0x2C817E00 ^ 0x2C81256A)
			};
			Jjo4d8KvJZHP4nLaVLS(obj2, ExportRuleType.Export);
			exportRuleList.Add(obj2);
			ExportRule obj3 = new ExportRule
			{
				ParentType = type
			};
			Eb7hy4KYn9tRoGRtvVP(obj3, IsEgVKKaG6WOIbMCQuM(-465190147 ^ -465200845));
			Jjo4d8KvJZHP4nLaVLS(obj3, ExportRuleType.Export);
			exportRuleList.Add(obj3);
			ExportRule obj4 = new ExportRule
			{
				ParentType = type
			};
			Eb7hy4KYn9tRoGRtvVP(obj4, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1CF99A4A ^ 0x1CF9C998));
			Jjo4d8KvJZHP4nLaVLS(obj4, ExportRuleType.Export);
			exportRuleList.Add(obj4);
			return exportRuleList;
		}
	}

	public IEnumerable<ICustomActivityFolder> LoadFoldersByName(string headerName, ICustomActivityFolder parentFolder = null)
	{
		return LoadFoldersByName(headerName, ignoreCase: false, parentFolder);
	}

	public IEnumerable<ICustomActivityFolder> LoadFoldersByName(string headerName, bool ignoreCase, ICustomActivityFolder parentFolder = null)
	{
		ICriteria obj = base.Session.CreateCriteria(InterfaceActivator.TypeOf<ICustomActivityFolder>());
		obj.Add((ICriterion)(object)(ignoreCase ? ElmaRestrictions.InsensitiveLike(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-769877317 ^ -769864505), headerName) : ElmaRestrictions.Like(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-478552651 ^ -478573623), headerName)));
		obj.Add((ICriterion)((parentFolder != null) ? ((object)Restrictions.Eq(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(--47835757 ^ 0x2D9BD79), (object)parentFolder)) : ((object)Restrictions.IsNull(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x138E9AEB ^ 0x138ECDFF)))));
		return obj.List<ICustomActivityFolder>();
	}

	public string GenerateNewName(string oldName, ICustomActivityFolder parentFolder = null, string postfix = null, string split = " ")
	{
		//Discarded unreachable code: IL_00ae, IL_00bd, IL_00e7, IL_014b, IL_015a
		int num = 2;
		IEnumerable<ICustomActivityFolder> enumerable = default(IEnumerable<ICustomActivityFolder>);
		string text2 = default(string);
		string text = default(string);
		long num3 = default(long);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 10:
					enumerable = LoadFoldersByName(text2, ignoreCase: true, parentFolder);
					num2 = 4;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_48279d3d45e2437b9907d478ce5a47b1 == 0)
					{
						num2 = 0;
					}
					continue;
				case 1:
					text2 = text;
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_ec7d0b62d0f94d70bbee4df19d5df325 == 0)
					{
						num2 = 10;
					}
					continue;
				case 7:
					num3++;
					num2 = 12;
					continue;
				case 6:
					break;
				default:
					if (enumerable.Any())
					{
						num2 = 5;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_476f57418da6445caf8a3854ac0b8f67 == 0)
						{
							num2 = 4;
						}
						continue;
					}
					goto case 3;
				case 11:
				case 12:
					if (enumerable == null)
					{
						num2 = 3;
						continue;
					}
					goto default;
				case 5:
					if (num3 < long.MaxValue)
					{
						num2 = 9;
						continue;
					}
					goto case 3;
				case 3:
				case 8:
					return text2;
				case 4:
					num3 = 1L;
					num2 = 11;
					continue;
				case 2:
					text = (string)yNirNfK9YN0oJI4mOeV(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x77F4B0AB ^ 0x77F4E641), oldName, (postfix != null) ? NetXKGK41HTWCNPD5uF(split, postfix) : "");
					num2 = 1;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_67ef56456b804d908fd1218d899249dc != 0)
					{
						num2 = 0;
					}
					continue;
				case 9:
				case 13:
					text2 = (string)WJMLZ0KcP5DQnnNBymT(IsEgVKKaG6WOIbMCQuM(--192118127 ^ 0xB732B95), (LZMVCXKTix3D5MPplRU(text) + num3.ToString().Length + 3 > 2000) ? text.Substring(1, 2000 - LZMVCXKTix3D5MPplRU(num3.ToString()) - 3) : text, num3, split);
					num2 = 6;
					continue;
				}
				break;
			}
			enumerable = LoadFoldersByName(text2, ignoreCase: true, parentFolder);
			num = 7;
		}
	}

	[PublicApiMember]
	public override void Delete(ICustomActivityFolder folder)
	{
		//Discarded unreachable code: IL_00e0, IL_00ef, IL_00fa, IL_0198, IL_01d0, IL_01df, IL_026a, IL_0279, IL_0284, IL_0312, IL_034a
		int num = 1;
		IEnumerator<ICustomActivityFolder> enumerator2 = default(IEnumerator<ICustomActivityFolder>);
		_003C_003Ec__DisplayClass16_0 _003C_003Ec__DisplayClass16_ = default(_003C_003Ec__DisplayClass16_0);
		IEnumerator<ICustomActivityHeader> enumerator = default(IEnumerator<ICustomActivityHeader>);
		while (true)
		{
			int num2 = num;
			ParameterExpression parameterExpression;
			while (true)
			{
				switch (num2)
				{
				case 2:
					parameterExpression = Expression.Parameter(typeof(ICustomActivityFolder), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-138431307 ^ -138416301));
					enumerator2 = ((AbstractNHEntityManager<ICustomActivityFolder, long>)this).Find(Expression.Lambda<Func<ICustomActivityFolder, bool>>((Expression)j5xZg5KkiudxkDcxwXG(Expression.Property(parameterExpression, (MethodInfo)cBba26Kdi5ELZHcCm4U((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), KVOIuZKSrmg9YgMVW9y(Expression.Constant(_003C_003Ec__DisplayClass16_, typeof(_003C_003Ec__DisplayClass16_0)), I64IcaKjP4WTvjEDSK9((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/))), new ParameterExpression[1] { parameterExpression })).GetEnumerator();
					num2 = 5;
					continue;
				case 4:
					base.Delete(_003C_003Ec__DisplayClass16_.folder);
					num2 = 7;
					continue;
				case 5:
					try
					{
						while (true)
						{
							int num5;
							if (!USmO9GKAbbUYvptp5L3(enumerator2))
							{
								num5 = 0;
								if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_8ed00be219534188ad23e215449e3f62 == 0)
								{
									num5 = 2;
								}
								goto IL_00fe;
							}
							goto IL_013a;
							IL_013a:
							ICustomActivityFolder current2 = enumerator2.Current;
							rsbVh0KUhLP5eBRp9Sk(current2, PmA4wAKbsmBi2FNHvX0(_003C_003Ec__DisplayClass16_.folder));
							M1cqcIKmTX693Aors8X(current2);
							num5 = 0;
							if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_7ae8403b9a8240c5b9d009904e9a6779 == 0)
							{
								num5 = 0;
							}
							goto IL_00fe;
							IL_00fe:
							switch (num5)
							{
							case 1:
								goto IL_013a;
							case 2:
								goto end_IL_0114;
							}
							continue;
							end_IL_0114:
							break;
						}
					}
					finally
					{
						if (enumerator2 != null)
						{
							int num6 = 0;
							if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_1f93f2934a244aa9a51974d0e91035bb == 0)
							{
								num6 = 0;
							}
							while (true)
							{
								switch (num6)
								{
								default:
									LMFGfGKpU5kRNTJm86F(enumerator2);
									num6 = 1;
									if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_19817a6c27b8478eb2c8f07b7fca8477 == 0)
									{
										num6 = 1;
									}
									continue;
								case 1:
									break;
								}
								break;
							}
						}
					}
					break;
				case 1:
					_003C_003Ec__DisplayClass16_ = new _003C_003Ec__DisplayClass16_0();
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_aaa603dc29cf4b6d80fd77debf189b8d == 0)
					{
						num2 = 0;
					}
					continue;
				case 7:
					return;
				case 3:
					vYdnYxKNM0QCSO1jVgE(_003C_003Ec__DisplayClass16_.folder, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-796330436 ^ -796337880));
					num2 = 2;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_e496a9998cf542ff98d1a5e001d6c664 != 0)
					{
						num2 = 2;
					}
					continue;
				default:
					_003C_003Ec__DisplayClass16_.folder = folder;
					num2 = 2;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_2180cded74a649d583efc1ab91959551 == 0)
					{
						num2 = 3;
					}
					continue;
				case 8:
					try
					{
						while (true)
						{
							int num3;
							if (!enumerator.MoveNext())
							{
								num3 = 2;
								goto IL_0288;
							}
							goto IL_029e;
							IL_0288:
							switch (num3)
							{
							case 1:
								break;
							default:
								continue;
							case 2:
								goto end_IL_02d6;
							}
							goto IL_029e;
							IL_029e:
							ICustomActivityHeader current = enumerator.Current;
							dK7UVRK6jYLGmgelNFv(current, PmA4wAKbsmBi2FNHvX0(_003C_003Ec__DisplayClass16_.folder));
							current.Save();
							num3 = 0;
							if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_cc6425824e2145d58580462376bc9992 == 0)
							{
								num3 = 0;
							}
							goto IL_0288;
							continue;
							end_IL_02d6:
							break;
						}
					}
					finally
					{
						if (enumerator != null)
						{
							int num4 = 0;
							if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_54bd71afa46f40208dd1bf6a7ffae8c6 == 0)
							{
								num4 = 0;
							}
							while (true)
							{
								switch (num4)
								{
								default:
									enumerator.Dispose();
									num4 = 1;
									if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_b9495424a4ef4f809c30bcc362ac3faa == 0)
									{
										num4 = 1;
									}
									continue;
								case 1:
									break;
								}
								break;
							}
						}
					}
					goto case 4;
				case 6:
					break;
				}
				break;
			}
			CustomActivityHeaderManager customActivityHeaderManager = CustomActivityHeaderManager;
			parameterExpression = (ParameterExpression)RHJAh4KnsNqBQEIiVnF(qkfE1dKGL0bcfJqP9Dk(typeof(ICustomActivityHeader).TypeHandle), IsEgVKKaG6WOIbMCQuM(0x27A6CAB5 ^ 0x27A69159));
			enumerator = customActivityHeaderManager.Find(Expression.Lambda<Func<ICustomActivityHeader, bool>>((Expression)j5xZg5KkiudxkDcxwXG(avPEpmKyO5PZK0p4fli(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), Expression.Field((Expression)h2SrH2KOsvlUh56Dthg(_003C_003Ec__DisplayClass16_, qkfE1dKGL0bcfJqP9Dk(typeof(_003C_003Ec__DisplayClass16_0).TypeHandle)), (FieldInfo)I64IcaKjP4WTvjEDSK9((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/))), new ParameterExpression[1] { parameterExpression })).GetEnumerator();
			num = 8;
		}
	}

	public CustomActivityFolderManager()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.reZueBLff7();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_77bc2455d9c3443ca1c76a1788888437 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool lbGjkMKKHb6hdS3qHIM()
	{
		return xlFkKWKDATdJ7J00Eyc == null;
	}

	internal static CustomActivityFolderManager wEtgmnKMbL1RB6GTJlN()
	{
		return xlFkKWKDATdJ7J00Eyc;
	}

	internal static object IsEgVKKaG6WOIbMCQuM(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void Eb7hy4KYn9tRoGRtvVP(object P_0, object P_1)
	{
		((ExportRule)P_0).PropertyName = (string)P_1;
	}

	internal static void Jjo4d8KvJZHP4nLaVLS(object P_0, ExportRuleType P_1)
	{
		((ExportRule)P_0).ExportRuleType = P_1;
	}

	internal static void Gy9Rw3KPOaAOn6Vm7gE(object P_0, Type P_1)
	{
		((ExportRule)P_0).ParentType = P_1;
	}

	internal static object NetXKGK41HTWCNPD5uF(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static object yNirNfK9YN0oJI4mOeV(object P_0, object P_1, object P_2)
	{
		return string.Format((string)P_0, P_1, P_2);
	}

	internal static int LZMVCXKTix3D5MPplRU(object P_0)
	{
		return ((string)P_0).Length;
	}

	internal static object WJMLZ0KcP5DQnnNBymT(object P_0, object P_1, object P_2, object P_3)
	{
		return string.Format((string)P_0, P_1, P_2, P_3);
	}

	internal static void vYdnYxKNM0QCSO1jVgE(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static object cBba26Kdi5ELZHcCm4U(RuntimeMethodHandle P_0)
	{
		return MethodBase.GetMethodFromHandle(P_0);
	}

	internal static object I64IcaKjP4WTvjEDSK9(RuntimeFieldHandle P_0)
	{
		return FieldInfo.GetFieldFromHandle(P_0);
	}

	internal static object KVOIuZKSrmg9YgMVW9y(object P_0, object P_1)
	{
		return Expression.Field((Expression)P_0, (FieldInfo)P_1);
	}

	internal static object j5xZg5KkiudxkDcxwXG(object P_0, object P_1)
	{
		return Expression.Equal((Expression)P_0, (Expression)P_1);
	}

	internal static object PmA4wAKbsmBi2FNHvX0(object P_0)
	{
		return ((ICustomActivityFolder)P_0).Folder;
	}

	internal static void rsbVh0KUhLP5eBRp9Sk(object P_0, object P_1)
	{
		((ICustomActivityFolder)P_0).Folder = (ICustomActivityFolder)P_1;
	}

	internal static void M1cqcIKmTX693Aors8X(object P_0)
	{
		((IEntity)P_0).Save();
	}

	internal static bool USmO9GKAbbUYvptp5L3(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void LMFGfGKpU5kRNTJm86F(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static Type qkfE1dKGL0bcfJqP9Dk(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object RHJAh4KnsNqBQEIiVnF(Type P_0, object P_1)
	{
		return Expression.Parameter(P_0, (string)P_1);
	}

	internal static object avPEpmKyO5PZK0p4fli(object P_0, object P_1)
	{
		return Expression.Property((Expression)P_0, (MethodInfo)P_1);
	}

	internal static object h2SrH2KOsvlUh56Dthg(object P_0, Type P_1)
	{
		return Expression.Constant(P_0, P_1);
	}

	internal static void dK7UVRK6jYLGmgelNFv(object P_0, object P_1)
	{
		((ICustomActivityHeader)P_0).Folder = (ICustomActivityFolder)P_1;
	}
}
