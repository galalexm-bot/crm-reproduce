using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Deploy.ExportHelper;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.DTO;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.Db.Migrator.Providers;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Services;
using EleWise.ELMA.UI.DTO.Models;
using EleWise.ELMA.UI.Models;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.SqlCommand;
using NHibernate.Transform;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.UI.Managers;

public class FormMetadataItemHeaderManager : EntityManager<IFormMetadataItemHeader, long>
{
	internal class HeaderDescriptorInfo
	{
		internal static HeaderDescriptorInfo PLQ3qBQh55W9gEUpLIWB;

		public long Id
		{
			[CompilerGenerated]
			get
			{
				return _003CId_003Ek__BackingField;
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
						_003CId_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public Guid Uid
		{
			[CompilerGenerated]
			get
			{
				return _003CUid_003Ek__BackingField;
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
						_003CUid_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public string Name
		{
			[CompilerGenerated]
			get
			{
				return _003CName_003Ek__BackingField;
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
						_003CName_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
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

		public long? PublishedId { get; set; }

		public long? EmulationId { get; set; }

		public HeaderDescriptorInfo()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			QIUsSfQhLhwLWqAfPerO();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static bool p9HuebQhj2ia2FGyTZTF()
		{
			return PLQ3qBQh55W9gEUpLIWB == null;
		}

		internal static HeaderDescriptorInfo LrjnOBQhYipCBFaAjFeT()
		{
			return PLQ3qBQh55W9gEUpLIWB;
		}

		internal static void QIUsSfQhLhwLWqAfPerO()
		{
			SingletonReader.JJCZtPuTvSt();
		}
	}

	internal static class PropertyNames
	{
		public static readonly string Id;

		public static readonly string Uid;

		public static readonly string Name;

		public static readonly string DisplayName;

		public static readonly string MetadataType;

		public static readonly string Published;

		public static readonly string PublishedId;

		public static readonly string Emulation;

		public static readonly string EmulationId;

		internal static PropertyNames VivZZ3QhU3r0BBD4uGAB;

		static PropertyNames()
		{
			int num = 15;
			ParameterExpression parameterExpression = default(ParameterExpression);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 17:
						parameterExpression = Expression.Parameter(kUFAMpQGBqmXHCZF4srf(typeof(HeaderDescriptorInfo).TypeHandle), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x31326106 ^ 0x3132CDB2));
						num2 = 12;
						continue;
					case 7:
						Name = LinqUtils.NameOf(Expression.Lambda<Func<IFormMetadataItemHeader, object>>((Expression)upGTW7QGhF0tSNx1dTNY(parameterExpression, (MethodInfo)WJmKSaQGoZcKuW23MBEU((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }));
						num2 = 10;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
						{
							num2 = 19;
						}
						continue;
					case 14:
						parameterExpression = Expression.Parameter(typeof(IFormMetadataItemHeader), (string)sQvIm9QGFiSDoSxMdM8i(0x34A6D230 ^ 0x34A67E84));
						num2 = 3;
						continue;
					case 13:
						Emulation = LinqUtils.NameOf(Expression.Lambda<Func<IFormMetadataItemHeader, object>>((Expression)upGTW7QGhF0tSNx1dTNY(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }));
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
						{
							num2 = 0;
						}
						continue;
					case 10:
						parameterExpression = Expression.Parameter(kUFAMpQGBqmXHCZF4srf(typeof(IFormMetadataItemHeader).TypeHandle), (string)sQvIm9QGFiSDoSxMdM8i(0x1C9495B4 ^ 0x1C943900));
						num2 = 5;
						continue;
					case 9:
						parameterExpression = (ParameterExpression)bgDEfAQGW1vK8PsWaMmm(typeof(IFormMetadataItemHeader), sQvIm9QGFiSDoSxMdM8i(-1978478350 ^ -1978500026));
						num2 = 13;
						continue;
					case 18:
						EmulationId = LinqUtils.NameOf(Expression.Lambda<Func<HeaderDescriptorInfo, object>>((Expression)fccuDtQGbkX1JoGwDoVa(Expression.Property(parameterExpression, (MethodInfo)WJmKSaQGoZcKuW23MBEU((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), kUFAMpQGBqmXHCZF4srf(typeof(object).TypeHandle)), new ParameterExpression[1] { parameterExpression }));
						num2 = 4;
						continue;
					case 3:
						Id = LinqUtils.NameOf(Expression.Lambda<Func<IFormMetadataItemHeader, object>>(Expression.Convert(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, typeof(IEntity<long>).TypeHandle)), kUFAMpQGBqmXHCZF4srf(typeof(object).TypeHandle)), new ParameterExpression[1] { parameterExpression }));
						num2 = 11;
						continue;
					case 4:
						return;
					case 12:
						PublishedId = LinqUtils.NameOf(Expression.Lambda<Func<HeaderDescriptorInfo, object>>(Expression.Convert(Expression.Property(parameterExpression, (MethodInfo)WJmKSaQGoZcKuW23MBEU((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), typeof(object)), new ParameterExpression[1] { parameterExpression }));
						num2 = 9;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
						{
							num2 = 3;
						}
						continue;
					case 6:
						DisplayName = LinqUtils.NameOf(Expression.Lambda<Func<IFormMetadataItemHeader, object>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }));
						num2 = 2;
						continue;
					default:
						parameterExpression = (ParameterExpression)bgDEfAQGW1vK8PsWaMmm(typeof(IFormMetadataItemHeader), sQvIm9QGFiSDoSxMdM8i(-1876063057 ^ -1876090853));
						num2 = 7;
						continue;
					case 19:
						parameterExpression = Expression.Parameter(typeof(IFormMetadataItemHeader), (string)sQvIm9QGFiSDoSxMdM8i(-1123633026 ^ -1123674934));
						num2 = 6;
						continue;
					case 5:
						Published = LinqUtils.NameOf(Expression.Lambda<Func<IFormMetadataItemHeader, object>>((Expression)upGTW7QGhF0tSNx1dTNY(parameterExpression, (MethodInfo)WJmKSaQGoZcKuW23MBEU((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }));
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
						{
							num2 = 17;
						}
						continue;
					case 2:
						parameterExpression = (ParameterExpression)bgDEfAQGW1vK8PsWaMmm(kUFAMpQGBqmXHCZF4srf(typeof(IFormMetadataItemHeader).TypeHandle), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4DC2B14D ^ 0x4DC21DF9));
						num2 = 8;
						continue;
					case 1:
						parameterExpression = Expression.Parameter(kUFAMpQGBqmXHCZF4srf(typeof(HeaderDescriptorInfo).TypeHandle), (string)sQvIm9QGFiSDoSxMdM8i(0x3B36AB09 ^ 0x3B3607BD));
						num2 = 18;
						continue;
					case 8:
						MetadataType = LinqUtils.NameOf(Expression.Lambda<Func<IFormMetadataItemHeader, object>>((Expression)fccuDtQGbkX1JoGwDoVa(upGTW7QGhF0tSNx1dTNY(parameterExpression, (MethodInfo)WJmKSaQGoZcKuW23MBEU((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), kUFAMpQGBqmXHCZF4srf(typeof(object).TypeHandle)), new ParameterExpression[1] { parameterExpression }));
						num2 = 10;
						continue;
					case 16:
						Uid = LinqUtils.NameOf(Expression.Lambda<Func<IFormMetadataItemHeader, object>>((Expression)fccuDtQGbkX1JoGwDoVa(Expression.Property(parameterExpression, (MethodInfo)WJmKSaQGoZcKuW23MBEU((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), kUFAMpQGBqmXHCZF4srf(typeof(object).TypeHandle)), new ParameterExpression[1] { parameterExpression }));
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
						{
							num2 = 0;
						}
						continue;
					case 11:
						parameterExpression = (ParameterExpression)bgDEfAQGW1vK8PsWaMmm(kUFAMpQGBqmXHCZF4srf(typeof(IFormMetadataItemHeader).TypeHandle), sQvIm9QGFiSDoSxMdM8i(-583745292 ^ -583766976));
						num2 = 14;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a != 0)
						{
							num2 = 16;
						}
						continue;
					case 15:
						break;
					}
					break;
				}
				RDyYxFQhzredLhp7VNml();
				num = 14;
			}
		}

		internal static void RDyYxFQhzredLhp7VNml()
		{
			SingletonReader.JJCZtPuTvSt();
		}

		internal static object sQvIm9QGFiSDoSxMdM8i(int _0020)
		{
			return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}

		internal static Type kUFAMpQGBqmXHCZF4srf(RuntimeTypeHandle P_0)
		{
			return Type.GetTypeFromHandle(P_0);
		}

		internal static object bgDEfAQGW1vK8PsWaMmm(Type P_0, object P_1)
		{
			return Expression.Parameter(P_0, (string)P_1);
		}

		internal static object WJmKSaQGoZcKuW23MBEU(RuntimeMethodHandle P_0)
		{
			return MethodBase.GetMethodFromHandle(P_0);
		}

		internal static object fccuDtQGbkX1JoGwDoVa(object P_0, Type P_1)
		{
			return Expression.Convert((Expression)P_0, P_1);
		}

		internal static object upGTW7QGhF0tSNx1dTNY(object P_0, object P_1)
		{
			return Expression.Property((Expression)P_0, (MethodInfo)P_1);
		}

		internal static bool aZUAPjQhst8ktKNMNjBE()
		{
			return VivZZ3QhU3r0BBD4uGAB == null;
		}

		internal static PropertyNames AjJbobQhc6NwhGwydgGE()
		{
			return VivZZ3QhU3r0BBD4uGAB;
		}
	}

	private static FormMetadataItemHeaderManager DRf8Z6BvSCEA6JyRedR4;

	public virtual long GetPublishingVersionNumber(long headerId)
	{
		//Discarded unreachable code: IL_00b4, IL_00e5, IL_00f4
		int num = 4;
		object obj = default(object);
		ITransformationProvider service = default(ITransformationProvider);
		string text = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 8:
					if (obj == null)
					{
						num2 = 2;
						break;
					}
					goto case 1;
				case 7:
					return 1L;
				case 3:
					service = Locator.GetService<ITransformationProvider>();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0)
					{
						num2 = 0;
					}
					break;
				case 4:
					if (headerId > 0)
					{
						goto end_IL_0012;
					}
					goto case 7;
				case 2:
				case 5:
					return 1L;
				case 1:
					if (!(obj is DBNull))
					{
						return Convert.ToInt64(obj) + 1;
					}
					num2 = 5;
					break;
				case 6:
					obj = vSoK2PBvkvCOx49odq2J(L6nhZjBvTGU5xOfpPXdA(base.Session, text));
					num2 = 8;
					break;
				default:
					text = (string)a5glHBBvX2caV1PMDtnk(yEGiMZBvqfxbdq0jGVBv(0x20261A4F ^ 0x2026EDFF), (service != null) ? AJ9pE6BvKfErHBZnsNfd(service.Dialect, yEGiMZBvqfxbdq0jGVBv(-1998538950 ^ -1998585464)) : yEGiMZBvqfxbdq0jGVBv(0x76DD48E ^ 0x76D623C), headerId);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 != 0)
					{
						num2 = 6;
					}
					break;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 3;
		}
	}

	public IEnumerable<IFormMetadataItemHeader> LoadRootHeaders()
	{
		return CreateCriteria().Add((ICriterion)(object)Restrictions.IsNull(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x34185E55 ^ 0x34188C97))).List<IFormMetadataItemHeader>();
	}

	public IEnumerable<IFormMetadataItemHeader> LoadRootHeaders(Guid metadataType)
	{
		return CreateCriteria().Add((ICriterion)(object)Restrictions.IsNull(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1411196499 ^ -1411249297))).Add((ICriterion)(object)Restrictions.Eq(PropertyNames.MetadataType, (object)metadataType)).List<IFormMetadataItemHeader>();
	}

	[Transaction]
	public virtual void Delete(long headerId)
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
				X8G9geBvnE27rA28TMnn(Load(headerId));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public virtual bool ValidateName(long headerId, Guid metadataType, string name, out string errorMessage)
	{
		return ValidateName((ICriterion)qYyJwBBvOSEg1pI6KHkF(PropertyNames.Id, headerId), metadataType, name, out errorMessage);
	}

	public virtual bool ValidateName(Guid headerUid, Guid metadataType, string name, out string errorMessage)
	{
		return ValidateName((ICriterion)qYyJwBBvOSEg1pI6KHkF(PropertyNames.Uid, headerUid), metadataType, name, out errorMessage);
	}

	public virtual bool ValidateDisplayName(long headerId, Guid metadataType, string displayName, out string errorMessage)
	{
		return ValidateDisplayName((ICriterion)qYyJwBBvOSEg1pI6KHkF(PropertyNames.Id, headerId), metadataType, displayName, out errorMessage);
	}

	public virtual bool ValidateDisplayName(Guid headerUid, Guid metadataType, string displayName, out string errorMessage)
	{
		return ValidateDisplayName((ICriterion)qYyJwBBvOSEg1pI6KHkF(PropertyNames.Uid, headerUid), metadataType, displayName, out errorMessage);
	}

	public override ExportRuleList ExportRules()
	{
		int num = 4;
		ExportRuleList exportRuleList = default(ExportRuleList);
		Type type = default(Type);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 8:
				{
					ExportRuleList exportRuleList9 = exportRuleList;
					ExportRule exportRule = new ExportRule
					{
						ParentType = type
					};
					ExportRule exportRule9 = exportRule;
					ParameterExpression parameterExpression = (ParameterExpression)cbxsgiBv1lTG42EvgVM2(typeof(IFormMetadataItemHeader), yEGiMZBvqfxbdq0jGVBv(-488881205 ^ -488837249));
					D4ae3SBvN8Ltpi3LLNYN(exportRule9, LinqUtils.NameOf(Expression.Lambda<Func<IFormMetadataItemHeader, object>>((Expression)Sacda3BvaTg0k3bRmdIB(parameterExpression, (MethodInfo)VyLk5QBvpOVPQcW1renO((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression })));
					d8U9ZVBv3K3WJhBw6HAI(exportRule, ExportRuleType.Export);
					exportRuleList9.Add(exportRule);
					num2 = 10;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
					{
						num2 = 6;
					}
					continue;
				}
				case 1:
					return exportRuleList;
				case 9:
				{
					ExportRuleList exportRuleList6 = exportRuleList;
					ExportRule exportRule = new ExportRule();
					ejhhCPBvewAOIEbXZUuS(exportRule, type);
					ExportRule exportRule6 = exportRule;
					ParameterExpression parameterExpression = (ParameterExpression)cbxsgiBv1lTG42EvgVM2(mQdZO7BvPewtgbCxfOu6(typeof(IFormMetadataItemHeader).TypeHandle), yEGiMZBvqfxbdq0jGVBv(0x35C0467B ^ 0x35C0EACF));
					D4ae3SBvN8Ltpi3LLNYN(exportRule6, LinqUtils.NameOf(Expression.Lambda<Func<IFormMetadataItemHeader, object>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression })));
					d8U9ZVBv3K3WJhBw6HAI(exportRule, ExportRuleType.Export);
					exportRuleList6.Add(exportRule);
					num2 = 7;
					continue;
				}
				case 3:
					break;
				case 4:
					type = dQxQ89Bv2dJs3oXD1aFJ(this);
					num2 = 3;
					continue;
				case 5:
				{
					ExportRuleList exportRuleList8 = exportRuleList;
					ExportRule exportRule = new ExportRule();
					ejhhCPBvewAOIEbXZUuS(exportRule, type);
					ExportRule exportRule8 = exportRule;
					ParameterExpression parameterExpression = Expression.Parameter(mQdZO7BvPewtgbCxfOu6(typeof(IFormMetadataItemHeader).TypeHandle), (string)yEGiMZBvqfxbdq0jGVBv(0x4EDCBA32 ^ 0x4EDC1686));
					D4ae3SBvN8Ltpi3LLNYN(exportRule8, LinqUtils.NameOf(Expression.Lambda<Func<IFormMetadataItemHeader, object>>((Expression)Sacda3BvaTg0k3bRmdIB(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression })));
					d8U9ZVBv3K3WJhBw6HAI(exportRule, ExportRuleType.Export);
					exportRuleList8.Add(exportRule);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
					{
						num2 = 2;
					}
					continue;
				}
				default:
				{
					ExportRuleList exportRuleList7 = exportRuleList;
					ExportRule exportRule = new ExportRule();
					ejhhCPBvewAOIEbXZUuS(exportRule, type);
					ExportRule exportRule7 = exportRule;
					ParameterExpression parameterExpression = (ParameterExpression)cbxsgiBv1lTG42EvgVM2(mQdZO7BvPewtgbCxfOu6(typeof(IFormMetadataItemHeader).TypeHandle), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-538519530 ^ -538544990));
					D4ae3SBvN8Ltpi3LLNYN(exportRule7, LinqUtils.NameOf(Expression.Lambda<Func<IFormMetadataItemHeader, object>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression })));
					d8U9ZVBv3K3WJhBw6HAI(exportRule, ExportRuleType.Export);
					exportRuleList7.Add(exportRule);
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
					{
						num2 = 1;
					}
					continue;
				}
				case 6:
				{
					ExportRuleList exportRuleList5 = exportRuleList;
					ExportRule exportRule = new ExportRule();
					ejhhCPBvewAOIEbXZUuS(exportRule, type);
					ExportRule exportRule5 = exportRule;
					ParameterExpression parameterExpression = (ParameterExpression)cbxsgiBv1lTG42EvgVM2(mQdZO7BvPewtgbCxfOu6(typeof(IFormMetadataItemHeader).TypeHandle), yEGiMZBvqfxbdq0jGVBv(0x7247028A ^ 0x7247AE3E));
					D4ae3SBvN8Ltpi3LLNYN(exportRule5, LinqUtils.NameOf(Expression.Lambda<Func<IFormMetadataItemHeader, object>>((Expression)mDbInqBvDsUYfPdiqt9r(Expression.Property(parameterExpression, (MethodInfo)VyLk5QBvpOVPQcW1renO((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), typeof(object)), new ParameterExpression[1] { parameterExpression })));
					exportRule.ExportRuleType = ExportRuleType.Export;
					exportRuleList5.Add(exportRule);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
					{
						num2 = 1;
					}
					continue;
				}
				case 10:
				{
					ExportRuleList exportRuleList4 = exportRuleList;
					ExportRule exportRule = new ExportRule();
					ejhhCPBvewAOIEbXZUuS(exportRule, type);
					ExportRule exportRule4 = exportRule;
					ParameterExpression parameterExpression = (ParameterExpression)cbxsgiBv1lTG42EvgVM2(typeof(IFormMetadataItemHeader), yEGiMZBvqfxbdq0jGVBv(-1751176224 ^ -1751152812));
					D4ae3SBvN8Ltpi3LLNYN(exportRule4, LinqUtils.NameOf(Expression.Lambda<Func<IFormMetadataItemHeader, object>>((Expression)mDbInqBvDsUYfPdiqt9r(Sacda3BvaTg0k3bRmdIB(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), mQdZO7BvPewtgbCxfOu6(typeof(object).TypeHandle)), new ParameterExpression[1] { parameterExpression })));
					d8U9ZVBv3K3WJhBw6HAI(exportRule, ExportRuleType.Export);
					exportRuleList4.Add(exportRule);
					num2 = 6;
					continue;
				}
				case 7:
				{
					ExportRuleList exportRuleList3 = exportRuleList;
					ExportRule exportRule = new ExportRule();
					ejhhCPBvewAOIEbXZUuS(exportRule, type);
					ExportRule exportRule3 = exportRule;
					ParameterExpression parameterExpression = Expression.Parameter(typeof(IFormMetadataItemHeader), (string)yEGiMZBvqfxbdq0jGVBv(-210725949 ^ -210747529));
					D4ae3SBvN8Ltpi3LLNYN(exportRule3, LinqUtils.NameOf(Expression.Lambda<Func<IFormMetadataItemHeader, object>>((Expression)Sacda3BvaTg0k3bRmdIB(parameterExpression, (MethodInfo)VyLk5QBvpOVPQcW1renO((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression })));
					d8U9ZVBv3K3WJhBw6HAI(exportRule, ExportRuleType.Export);
					exportRuleList3.Add(exportRule);
					num2 = 5;
					continue;
				}
				case 2:
				{
					ExportRuleList exportRuleList2 = exportRuleList;
					ExportRule exportRule = new ExportRule();
					ejhhCPBvewAOIEbXZUuS(exportRule, type);
					ExportRule exportRule2 = exportRule;
					ParameterExpression parameterExpression = (ParameterExpression)cbxsgiBv1lTG42EvgVM2(mQdZO7BvPewtgbCxfOu6(typeof(IFormMetadataItemHeader).TypeHandle), yEGiMZBvqfxbdq0jGVBv(-2107978722 ^ -2108006230));
					exportRule2.PropertyName = LinqUtils.NameOf(Expression.Lambda<Func<IFormMetadataItemHeader, object>>(Expression.Convert((Expression)Sacda3BvaTg0k3bRmdIB(parameterExpression, (MethodInfo)VyLk5QBvpOVPQcW1renO((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), typeof(object)), new ParameterExpression[1] { parameterExpression }));
					d8U9ZVBv3K3WJhBw6HAI(exportRule, ExportRuleType.Export);
					exportRuleList2.Add(exportRule);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
					{
						num2 = 0;
					}
					continue;
				}
				}
				break;
			}
			exportRuleList = new ExportRuleList();
			num = 9;
		}
	}

	internal HeaderDescriptorInfo GetPublishedHeaderDescriptorInfo(Guid uid)
	{
		return ((ICriteria)vjteVRBvtre5pvnOpwYw(CreatePublishedHeaderDescriptorInfos(), qYyJwBBvOSEg1pI6KHkF(PropertyNames.Uid, uid))).List<HeaderDescriptorInfo>().FirstOrDefault();
	}

	internal IEnumerable<HeaderDescriptorInfo> GetPublishedHeaderDescriptorInfos(Guid metadataType)
	{
		return CreatePublishedHeaderDescriptorInfos().Add((ICriterion)(object)Restrictions.Eq(PropertyNames.MetadataType, (object)metadataType)).Add((ICriterion)(object)Restrictions.Or((ICriterion)(object)Restrictions.IsNotNull(PropertyNames.Published), (ICriterion)(object)Restrictions.IsNotNull(PropertyNames.Emulation))).List<HeaderDescriptorInfo>();
	}

	internal ICriteria CreatePublishedHeaderDescriptorInfos()
	{
		return (ICriteria)CHTVdBBv7cFW74RA5cno(YWhRqaBvAOiMARrgGWlC(hxyaMaBv4tS1Sd8EUpeV(hxyaMaBv4tS1Sd8EUpeV(bOt9XTBvwTJCbmO1S5PX(this, null), PropertyNames.Published, yEGiMZBvqfxbdq0jGVBv(-787452571 ^ -787442349), (JoinType)1), PropertyNames.Emulation, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-629844702 ^ -629822110), (JoinType)1), new IProjection[5]
		{
			(IProjection)LkV1muBvHG7AsTHrZ5ei(uPdOo0Bv6s23k4elRTLQ(PropertyNames.Id), PropertyNames.Id),
			Projections.Alias((IProjection)uPdOo0Bv6s23k4elRTLQ(PropertyNames.Uid), PropertyNames.Uid),
			(IProjection)LkV1muBvHG7AsTHrZ5ei(uPdOo0Bv6s23k4elRTLQ(PropertyNames.Name), PropertyNames.Name),
			(IProjection)LkV1muBvHG7AsTHrZ5ei(uPdOo0Bv6s23k4elRTLQ(yEGiMZBvqfxbdq0jGVBv(0x638095EB ^ 0x63806DA1)), PropertyNames.PublishedId),
			(IProjection)LkV1muBvHG7AsTHrZ5ei(Projections.Property((string)yEGiMZBvqfxbdq0jGVBv(0x5A4C7B29 ^ 0x5A4C8373)), PropertyNames.EmulationId)
		}), new AliasToBeanResultTransformer(mQdZO7BvPewtgbCxfOu6(typeof(HeaderDescriptorInfo).TypeHandle)));
	}

	internal IEnumerable<FormMetadataItemHeaderDTO> LoadHeaderDTOList(Guid metadataType)
	{
		ICriteria obj = CreateCriteria();
		ParameterExpression parameterExpression = Expression.Parameter(typeof(IFormMetadataItemHeader), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138958856 ^ -2138914996));
		ICriteria obj2 = obj.Add((ICriterion)(object)Restrictions.Eq(LinqUtils.NameOf(Expression.Lambda<Func<IFormMetadataItemHeader, object>>(Expression.Convert(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), typeof(object)), new ParameterExpression[1] { parameterExpression })), (object)metadataType));
		parameterExpression = Expression.Parameter(typeof(IFormMetadataItemHeader), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1DE3DD89 ^ 0x1DE3713D));
		ICriteria obj3 = obj2.CreateAlias(LinqUtils.NameOf(Expression.Lambda<Func<IFormMetadataItemHeader, object>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression })), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-398663332 ^ -398715172), (JoinType)1);
		parameterExpression = Expression.Parameter(typeof(IFormMetadataItemHeader), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-561074844 ^ -561118768));
		ICriteria obj4 = obj3.CreateAlias(LinqUtils.NameOf(Expression.Lambda<Func<IFormMetadataItemHeader, object>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression })), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x34185E55 ^ 0x3418A63F), (JoinType)1);
		parameterExpression = Expression.Parameter(typeof(IFormMetadataItemHeader), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1217523399 ^ -1217479283));
		ICriteria obj5 = obj4.CreateAlias(LinqUtils.NameOf(Expression.Lambda<Func<IFormMetadataItemHeader, object>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression })), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-195614443 ^ -195571421), (JoinType)1);
		IProjection[] array = new IProjection[13];
		parameterExpression = Expression.Parameter(typeof(IFormMetadataItemHeader), z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1360331293 ^ 0x5115F59D));
		PropertyProjection obj6 = Projections.Property(LinqUtils.NameOf(Expression.Lambda<Func<IFormMetadataItemHeader, object>>(Expression.Convert(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, typeof(IEntity<long>).TypeHandle)), typeof(object)), new ParameterExpression[1] { parameterExpression })));
		parameterExpression = Expression.Parameter(typeof(FormMetadataItemHeaderDTO), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1710575414 ^ -1710602422));
		array[0] = Projections.Alias((IProjection)(object)obj6, LinqUtils.NameOf(Expression.Lambda<Func<FormMetadataItemHeaderDTO, object>>(Expression.Convert(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, typeof(EntityDTO<long>).TypeHandle)), typeof(object)), new ParameterExpression[1] { parameterExpression })));
		parameterExpression = Expression.Parameter(typeof(IFormMetadataItemHeader), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x10E41EDB ^ 0x10E4E95B));
		PropertyProjection obj7 = Projections.Property(LinqUtils.NameOf(Expression.Lambda<Func<IFormMetadataItemHeader, object>>(Expression.Convert(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), typeof(object)), new ParameterExpression[1] { parameterExpression })));
		parameterExpression = Expression.Parameter(typeof(FormMetadataItemHeaderDTO), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1217523399 ^ -1217468743));
		array[1] = Projections.Alias((IProjection)(object)obj7, LinqUtils.NameOf(Expression.Lambda<Func<FormMetadataItemHeaderDTO, object>>(Expression.Convert(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), typeof(object)), new ParameterExpression[1] { parameterExpression })));
		parameterExpression = Expression.Parameter(typeof(IFormMetadataItemHeader), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1DE3DD89 ^ 0x1DE32A09));
		PropertyProjection obj8 = Projections.Property(LinqUtils.NameOf(Expression.Lambda<Func<IFormMetadataItemHeader, object>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression })));
		parameterExpression = Expression.Parameter(typeof(FormMetadataItemHeaderDTO), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-345420348 ^ -345392572));
		array[2] = Projections.Alias((IProjection)(object)obj8, LinqUtils.NameOf(Expression.Lambda<Func<FormMetadataItemHeaderDTO, object>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression })));
		parameterExpression = Expression.Parameter(typeof(IFormMetadataItemHeader), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-541731959 ^ -541776887));
		PropertyProjection obj9 = Projections.Property(LinqUtils.NameOf(Expression.Lambda<Func<IFormMetadataItemHeader, object>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression })));
		parameterExpression = Expression.Parameter(typeof(FormMetadataItemHeaderDTO), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7E6E5A0B ^ 0x7E6EAD8B));
		array[3] = Projections.Alias((IProjection)(object)obj9, LinqUtils.NameOf(Expression.Lambda<Func<FormMetadataItemHeaderDTO, object>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression })));
		PropertyProjection obj10 = Projections.Property(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1411196499 ^ -1411243557));
		parameterExpression = Expression.Parameter(typeof(FormMetadataItemHeaderDTO), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-475857671 ^ -475919495));
		array[4] = Projections.Alias((IProjection)(object)obj10, LinqUtils.NameOf(Expression.Lambda<Func<FormMetadataItemHeaderDTO, object>>(Expression.Convert(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), typeof(object)), new ParameterExpression[1] { parameterExpression })));
		parameterExpression = Expression.Parameter(typeof(IFormMetadataItemHeader), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3C5338FF ^ 0x3C53CF7F));
		PropertyProjection obj11 = Projections.Property(LinqUtils.NameOf(Expression.Lambda<Func<IFormMetadataItemHeader, object>>(Expression.Convert(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), typeof(object)), new ParameterExpression[1] { parameterExpression })));
		parameterExpression = Expression.Parameter(typeof(FormMetadataItemHeaderDTO), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-643786247 ^ -643797383));
		array[5] = Projections.Alias((IProjection)(object)obj11, LinqUtils.NameOf(Expression.Lambda<Func<FormMetadataItemHeaderDTO, object>>(Expression.Convert(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), typeof(object)), new ParameterExpression[1] { parameterExpression })));
		parameterExpression = Expression.Parameter(typeof(IFormMetadataItemHeader), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-345420348 ^ -345392572));
		PropertyProjection obj12 = Projections.Property(LinqUtils.NameOf(Expression.Lambda<Func<IFormMetadataItemHeader, object>>(Expression.Convert(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), typeof(object)), new ParameterExpression[1] { parameterExpression })));
		parameterExpression = Expression.Parameter(typeof(FormMetadataItemHeaderDTO), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1921202237 ^ -1921241021));
		array[6] = Projections.Alias((IProjection)(object)obj12, LinqUtils.NameOf(Expression.Lambda<Func<FormMetadataItemHeaderDTO, object>>(Expression.Convert(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), typeof(object)), new ParameterExpression[1] { parameterExpression })));
		parameterExpression = Expression.Parameter(typeof(IFormMetadataItemHeader), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-488881205 ^ -488852405));
		PropertyProjection obj13 = Projections.Property(LinqUtils.NameOf(Expression.Lambda<Func<IFormMetadataItemHeader, object>>(Expression.Convert(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), typeof(object)), new ParameterExpression[1] { parameterExpression })));
		parameterExpression = Expression.Parameter(typeof(FormMetadataItemHeaderDTO), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x35C0467B ^ 0x35C0B1FB));
		array[7] = Projections.Alias((IProjection)(object)obj13, LinqUtils.NameOf(Expression.Lambda<Func<FormMetadataItemHeaderDTO, object>>(Expression.Convert(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), typeof(object)), new ParameterExpression[1] { parameterExpression })));
		parameterExpression = Expression.Parameter(typeof(IFormMetadataItemHeader), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-889460160 ^ -889512512));
		PropertyProjection obj14 = Projections.Property(LinqUtils.NameOf(Expression.Lambda<Func<IFormMetadataItemHeader, object>>(Expression.Convert(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), typeof(object)), new ParameterExpression[1] { parameterExpression })));
		parameterExpression = Expression.Parameter(typeof(FormMetadataItemHeaderDTO), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x49E27B8A ^ 0x49E28C0A));
		array[8] = Projections.Alias((IProjection)(object)obj14, LinqUtils.NameOf(Expression.Lambda<Func<FormMetadataItemHeaderDTO, object>>(Expression.Convert(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), typeof(object)), new ParameterExpression[1] { parameterExpression })));
		string text = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1146510045 ^ -1146528351);
		parameterExpression = Expression.Parameter(typeof(IFormMetadataItemHeader), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3B36AB09 ^ 0x3B365C89));
		PropertyProjection obj15 = Projections.Property(text + LinqUtils.NameOf(Expression.Lambda<Func<IFormMetadataItemHeader, object>>(Expression.Convert(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, typeof(IEntity<long>).TypeHandle)), typeof(object)), new ParameterExpression[1] { parameterExpression })));
		parameterExpression = Expression.Parameter(typeof(FormMetadataItemHeaderDTO), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-35995181 ^ -36030893));
		array[9] = Projections.Alias((IProjection)(object)obj15, LinqUtils.NameOf(Expression.Lambda<Func<FormMetadataItemHeaderDTO, object>>(Expression.Convert(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), typeof(object)), new ParameterExpression[1] { parameterExpression })));
		string text2 = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2099751081 ^ -2099728427);
		parameterExpression = Expression.Parameter(typeof(IFormMetadataItemHeader), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-488881205 ^ -488852405));
		PropertyProjection obj16 = Projections.Property(text2 + LinqUtils.NameOf(Expression.Lambda<Func<IFormMetadataItemHeader, object>>(Expression.Convert(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), typeof(object)), new ParameterExpression[1] { parameterExpression })));
		parameterExpression = Expression.Parameter(typeof(FormMetadataItemHeaderDTO), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1123633026 ^ -1123659778));
		array[10] = Projections.Alias((IProjection)(object)obj16, LinqUtils.NameOf(Expression.Lambda<Func<FormMetadataItemHeaderDTO, object>>(Expression.Convert(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), typeof(object)), new ParameterExpression[1] { parameterExpression })));
		string text3 = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-629844702 ^ -629822030);
		parameterExpression = Expression.Parameter(typeof(IFormMetadataItemHeader), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x20261A4F ^ 0x2026EDCF));
		PropertyProjection obj17 = Projections.Property(text3 + LinqUtils.NameOf(Expression.Lambda<Func<IFormMetadataItemHeader, object>>(Expression.Convert(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, typeof(IEntity<long>).TypeHandle)), typeof(object)), new ParameterExpression[1] { parameterExpression })));
		parameterExpression = Expression.Parameter(typeof(FormMetadataItemHeaderDTO), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3B36AB09 ^ 0x3B365C89));
		array[11] = Projections.Alias((IProjection)(object)obj17, LinqUtils.NameOf(Expression.Lambda<Func<FormMetadataItemHeaderDTO, object>>(Expression.Convert(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), typeof(object)), new ParameterExpression[1] { parameterExpression })));
		string text4 = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-867826612 ^ -867762980);
		parameterExpression = Expression.Parameter(typeof(IFormMetadataItemHeader), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1637C429 ^ 0x163733A9));
		PropertyProjection obj18 = Projections.Property(text4 + LinqUtils.NameOf(Expression.Lambda<Func<IFormMetadataItemHeader, object>>(Expression.Convert(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), typeof(object)), new ParameterExpression[1] { parameterExpression })));
		parameterExpression = Expression.Parameter(typeof(FormMetadataItemHeaderDTO), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1334993905 ^ -1335006321));
		array[12] = Projections.Alias((IProjection)(object)obj18, LinqUtils.NameOf(Expression.Lambda<Func<FormMetadataItemHeaderDTO, object>>(Expression.Convert(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), typeof(object)), new ParameterExpression[1] { parameterExpression })));
		return obj5.SetProjection((IProjection[])(object)array).SetResultTransformer((IResultTransformer)(object)new AliasToBeanResultTransformer(typeof(FormMetadataItemHeaderDTO))).List<FormMetadataItemHeaderDTO>();
	}

	internal virtual ICriteria ValidateNameCriteria(string name)
	{
		return (ICriteria)YWhRqaBvAOiMARrgGWlC(vjteVRBvtre5pvnOpwYw(bOt9XTBvwTJCbmO1S5PX(this, null), ElmaRestrictions.InsensitiveLike((IProjection)uPdOo0Bv6s23k4elRTLQ(PropertyNames.Name), name)), new IProjection[1] { (IProjection)YraW1uBvxs2Rltvr7Xxb(PropertyNames.Id) });
	}

	protected virtual bool ValidateName(ICriterion compareCriterion, Guid metadataType, string name, out string errorMessage)
	{
		//Discarded unreachable code: IL_0225, IL_0234
		int num = 8;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				errorMessage = (string)Ck6nMBBvyAdL1jLJZhfp(yEGiMZBvqfxbdq0jGVBv(0x1ECE530A ^ 0x1ECEA250));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
				{
					num2 = 3;
				}
				break;
			case 10:
				errorMessage = SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1822890472 ^ -1822944172), name);
				num2 = 11;
				break;
			case 2:
				return false;
			case 11:
				return false;
			case 3:
				return false;
			case 8:
				EoBpmbBv0v9Psw304n79(compareCriterion, yEGiMZBvqfxbdq0jGVBv(0x1C9495B4 ^ 0x1C946482));
				num2 = 7;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
				{
					num2 = 7;
				}
				break;
			case 5:
				errorMessage = (string)Ck6nMBBvyAdL1jLJZhfp(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x49E27B8A ^ 0x49E28316));
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
				{
					num2 = 2;
				}
				break;
			case 1:
				errorMessage = SR.T((string)yEGiMZBvqfxbdq0jGVBv(-957824448 ^ -957859052), name);
				num2 = 4;
				break;
			case 7:
				errorMessage = null;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
				{
					num2 = 6;
				}
				break;
			case 6:
				if (!hkNXNmBvmFEGlaedJrJP(name))
				{
					if (PDPsVDBvMuf4svq19DBR(name))
					{
						if (Convert.ToInt64(UiWeESBvdLfT2gd6DI0o(vjteVRBvtre5pvnOpwYw(vjteVRBvtre5pvnOpwYw(kSsVWABvJr8D2kqcO5ki(this, name), qYyJwBBvOSEg1pI6KHkF(PropertyNames.MetadataType, metadataType)), kc6NiJBv9shAtXrpuSG4(compareCriterion)))) > 0)
						{
							num2 = 9;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
							{
								num2 = 10;
							}
							break;
						}
						if (YBrxuCBvrFAnxQjSuwvA(UiWeESBvdLfT2gd6DI0o(VNFgOABvlMPP7tVsB45U(Locator.GetServiceNotNull<ComponentMetadataItemHeaderManager>(), name))) <= 0)
						{
							num2 = 9;
							break;
						}
						goto case 1;
					}
					num2 = 5;
					break;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				return false;
			case 9:
				return true;
			}
		}
	}

	protected virtual bool ValidateDisplayName(ICriterion compareCriterion, Guid metadataType, string displayName, out string errorMessage)
	{
		//Discarded unreachable code: IL_0049, IL_0058
		int num = 6;
		_003C_003Ec__DisplayClass17_0 _003C_003Ec__DisplayClass17_ = default(_003C_003Ec__DisplayClass17_0);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 5:
					_003C_003Ec__DisplayClass17_.displayName = displayName;
					num2 = 4;
					continue;
				case 1:
					return false;
				case 9:
					if (!hkNXNmBvmFEGlaedJrJP(_003C_003Ec__DisplayClass17_.displayName))
					{
						if (!((ICriteria)vjteVRBvtre5pvnOpwYw(vjteVRBvtre5pvnOpwYw(bOt9XTBvwTJCbmO1S5PX(this, null), qYyJwBBvOSEg1pI6KHkF(PropertyNames.MetadataType, metadataType)), Restrictions.Not(compareCriterion))).SetProjection((IProjection[])(object)new IProjection[1] { (IProjection)uPdOo0Bv6s23k4elRTLQ(PropertyNames.DisplayName) }).List<string>().Any(_003C_003Ec__DisplayClass17_._003CValidateDisplayName_003Eb__0))
						{
							num2 = 7;
							continue;
						}
						break;
					}
					num2 = 8;
					continue;
				case 3:
					return false;
				case 7:
					return true;
				case 8:
					errorMessage = SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1824388195 ^ -1824327367));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
					{
						num2 = 1;
					}
					continue;
				case 4:
					EoBpmbBv0v9Psw304n79(compareCriterion, yEGiMZBvqfxbdq0jGVBv(-16752921 ^ -16732207));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
					{
						num2 = 2;
					}
					continue;
				case 2:
					errorMessage = null;
					num2 = 9;
					continue;
				case 6:
					_003C_003Ec__DisplayClass17_ = new _003C_003Ec__DisplayClass17_0();
					num2 = 5;
					continue;
				}
				break;
			}
			errorMessage = SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-97972138 ^ -97918316));
			num = 3;
		}
	}

	public FormMetadataItemHeaderManager()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		MLQhiJBvgAMKfdwXtkd2();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object yEGiMZBvqfxbdq0jGVBv(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object AJ9pE6BvKfErHBZnsNfd(object P_0, object P_1)
	{
		return ((Dialect)P_0).QuoteIfNeeded((string)P_1);
	}

	internal static object a5glHBBvX2caV1PMDtnk(object P_0, object P_1, object P_2)
	{
		return string.Format((string)P_0, P_1, P_2);
	}

	internal static object L6nhZjBvTGU5xOfpPXdA(object P_0, object P_1)
	{
		return ((ISession)P_0).CreateSQLQuery((string)P_1);
	}

	internal static object vSoK2PBvkvCOx49odq2J(object P_0)
	{
		return ((IQuery)P_0).UniqueResult();
	}

	internal static bool b2iZpZBviQfq1UNBBIqO()
	{
		return DRf8Z6BvSCEA6JyRedR4 == null;
	}

	internal static FormMetadataItemHeaderManager JL93TaBvR67pZNT8j1AL()
	{
		return DRf8Z6BvSCEA6JyRedR4;
	}

	internal static void X8G9geBvnE27rA28TMnn(object P_0)
	{
		((IEntity)P_0).Delete();
	}

	internal static object qYyJwBBvOSEg1pI6KHkF(object P_0, object P_1)
	{
		return Restrictions.Eq((string)P_0, P_1);
	}

	internal static Type dQxQ89Bv2dJs3oXD1aFJ(object P_0)
	{
		return ((EntityManager<IFormMetadataItemHeader, long>)P_0).ImplementationType;
	}

	internal static void ejhhCPBvewAOIEbXZUuS(object P_0, Type value)
	{
		((ExportRule)P_0).ParentType = value;
	}

	internal static Type mQdZO7BvPewtgbCxfOu6(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object cbxsgiBv1lTG42EvgVM2(Type P_0, object P_1)
	{
		return Expression.Parameter(P_0, (string)P_1);
	}

	internal static void D4ae3SBvN8Ltpi3LLNYN(object P_0, object P_1)
	{
		((ExportRule)P_0).PropertyName = (string)P_1;
	}

	internal static void d8U9ZVBv3K3WJhBw6HAI(object P_0, ExportRuleType value)
	{
		((ExportRule)P_0).ExportRuleType = value;
	}

	internal static object VyLk5QBvpOVPQcW1renO(RuntimeMethodHandle P_0)
	{
		return MethodBase.GetMethodFromHandle(P_0);
	}

	internal static object Sacda3BvaTg0k3bRmdIB(object P_0, object P_1)
	{
		return Expression.Property((Expression)P_0, (MethodInfo)P_1);
	}

	internal static object mDbInqBvDsUYfPdiqt9r(object P_0, Type P_1)
	{
		return Expression.Convert((Expression)P_0, P_1);
	}

	internal static object vjteVRBvtre5pvnOpwYw(object P_0, object P_1)
	{
		return ((ICriteria)P_0).Add((ICriterion)P_1);
	}

	internal static object bOt9XTBvwTJCbmO1S5PX(object P_0, object P_1)
	{
		return ((EntityManager<IFormMetadataItemHeader, long>)P_0).CreateCriteria((IEntityFilter)P_1);
	}

	internal static object hxyaMaBv4tS1Sd8EUpeV(object P_0, object P_1, object P_2, JoinType P_3)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		return ((ICriteria)P_0).CreateAlias((string)P_1, (string)P_2, P_3);
	}

	internal static object uPdOo0Bv6s23k4elRTLQ(object P_0)
	{
		return Projections.Property((string)P_0);
	}

	internal static object LkV1muBvHG7AsTHrZ5ei(object P_0, object P_1)
	{
		return Projections.Alias((IProjection)P_0, (string)P_1);
	}

	internal static object YWhRqaBvAOiMARrgGWlC(object P_0, object P_1)
	{
		return ((ICriteria)P_0).SetProjection((IProjection[])P_1);
	}

	internal static object CHTVdBBv7cFW74RA5cno(object P_0, object P_1)
	{
		return ((ICriteria)P_0).SetResultTransformer((IResultTransformer)P_1);
	}

	internal static object YraW1uBvxs2Rltvr7Xxb(object P_0)
	{
		return Projections.Count((string)P_0);
	}

	internal static void EoBpmbBv0v9Psw304n79(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static bool hkNXNmBvmFEGlaedJrJP(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object Ck6nMBBvyAdL1jLJZhfp(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static bool PDPsVDBvMuf4svq19DBR(object P_0)
	{
		return ((string)P_0).IsValidIdentifier();
	}

	internal static object kSsVWABvJr8D2kqcO5ki(object P_0, object P_1)
	{
		return ((FormMetadataItemHeaderManager)P_0).ValidateNameCriteria((string)P_1);
	}

	internal static object kc6NiJBv9shAtXrpuSG4(object P_0)
	{
		return Restrictions.Not((ICriterion)P_0);
	}

	internal static object UiWeESBvdLfT2gd6DI0o(object P_0)
	{
		return ((ICriteria)P_0).UniqueResult();
	}

	internal static object VNFgOABvlMPP7tVsB45U(object P_0, object P_1)
	{
		return ((ComponentMetadataItemHeaderManager)P_0).ValidateNameCriteria((string)P_1);
	}

	internal static long YBrxuCBvrFAnxQjSuwvA(object P_0)
	{
		return Convert.ToInt64(P_0);
	}

	internal static void MLQhiJBvgAMKfdwXtkd2()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
