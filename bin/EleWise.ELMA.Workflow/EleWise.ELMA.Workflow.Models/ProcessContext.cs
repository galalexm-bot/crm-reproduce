using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.UI.Metadata;
using EleWise.ELMA.Workflow.CodeGeneration;
using EleWise.ELMA.Workflow.Mappings;
using EleWise.ELMA.Workflow.Types;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Models;

[Serializable]
[ClassMap(typeof(ProcessContextMap))]
[Entity("ProcessContext")]
[BaseClass("{C40FD1D3-F5D9-4323-9E51-42EBFA77E6DC}")]
[DisplayName(typeof(__Resources_ProcessContext), "DisplayName")]
[MetadataType(typeof(EntityMetadata))]
[Uid("{A55C0516-4442-4D0D-AB40-17143DE835DF}")]
public class ProcessContext : EntityMetadata, IProcessContext, IEntityMetadata, IRootMetadata, IMetadata, IXsiType, ICodeItemMetadata, IGroupedMetadata
{
	[Component]
	private class Info : IMetadataTypeInfo
	{
		internal static object e0KJEjvYE8pAnVx05sMK;

		public string Name => SR.T((string)m5SvBuvYzVSdYCcDQJOU(0x65B7F624 ^ 0x65B7EB60));

		public string Description => string.Empty;

		public Type MetadataType => InterfaceActivator.TypeOf<ProcessContext>();

		public Type GeneratorType => S96PC8v8KZNuSVj3Gcce(typeof(ProcessContextGenerator).TypeHandle);

		public Info()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			qfhSwLv8Of4T8dIppy9F();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_43af423d081c48e3bc6cea30ce47523d == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static object m5SvBuvYzVSdYCcDQJOU(int _0020)
		{
			return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}

		internal static bool AFYxSnvYw70q76IQscLk()
		{
			return e0KJEjvYE8pAnVx05sMK == null;
		}

		internal static Info cy0MgfvY4fsSlOuh0BmX()
		{
			return (Info)e0KJEjvYE8pAnVx05sMK;
		}

		internal static Type S96PC8v8KZNuSVj3Gcce(RuntimeTypeHandle P_0)
		{
			return System.Type.GetTypeFromHandle(P_0);
		}

		internal static void qfhSwLv8Of4T8dIppy9F()
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		}
	}

	public static class DefaultProperties
	{
		public static class WorkflowInstance
		{
			public const string UID = "{F9C6547C-9CA1-4E5F-8F46-F77DC52B6981}";

			public static readonly Guid Uid;

			public const string Name = "WorkflowInstance";

			internal static WorkflowInstance eIuB3xvQtQx8gne5vKcG;

			static WorkflowInstance()
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 2:
						return;
					case 1:
						j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f8ecc99a1f4a4b6abc73e9b50261ea83 == 0)
						{
							num2 = 0;
						}
						break;
					default:
						Uid = new Guid((string)IqsfAxvQgvdww8DSEJoP(-1895853023 ^ -1895993775));
						num2 = 2;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_71a41ac2fa884d27b721ae0509586eea == 0)
						{
							num2 = 1;
						}
						break;
					}
				}
			}

			internal static object IqsfAxvQgvdww8DSEJoP(int _0020)
			{
				return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
			}

			internal static bool v2iyDOvQb79qhRj88Uy7()
			{
				return eIuB3xvQtQx8gne5vKcG == null;
			}

			internal static WorkflowInstance rgLFhJvQ5C60JledNPZm()
			{
				return eIuB3xvQtQx8gne5vKcG;
			}
		}
	}

	private class _DefaultProperties
	{
		private static object FtQeekv88ZQ6LR11rbrV;

		[View(ViewType = ViewType.Edit, Visibility = Visibility.Hidden)]
		[View(ViewType = ViewType.List, Visibility = Visibility.ForceHidden)]
		[SystemProperty]
		[View(ViewType = ViewType.Display, Visibility = Visibility.Hidden)]
		[DisplayName(typeof(__Resources_DefaultProperties), "P_WorkflowInstance_DisplayName")]
		[Uid("{F9C6547C-9CA1-4E5F-8F46-F77DC52B6981}")]
		[Property("{72ED98CA-F260-4671-9BCD-FF1D80235F47}", "ae8e2269-5077-4bb3-a8dd-62e5d130f009")]
		[EntitySettings(FieldName = "WorkflowInstance")]
		[EntityProperty]
		[View(ViewType = ViewType.Create, Visibility = Visibility.Hidden)]
		public object WorkflowInstance
		{
			[CompilerGenerated]
			get
			{
				return _003CWorkflowInstance_003Ek__BackingField;
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
						_003CWorkflowInstance_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5d3bc916b5664717ac60544de077bd16 != 0)
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

		[SystemProperty]
		[View(ViewType = ViewType.All, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
		[EntityProperty]
		[Uid("0c78f84c-d808-4e11-8fa3-bf49bf6cd7fb")]
		[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
		[NotNull]
		[DisplayName(typeof(__Resources_DefaultProperties), "P_Uid_DisplayName")]
		[GuidSettings(FieldName = "Uid")]
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
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6f64eb224ece438ba2f0bbd2f29cebfd == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public _DefaultProperties()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f236c3d0fade492db73e8204df65377d == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static bool lVHYchv8skWUG4GLYhEI()
		{
			return FtQeekv88ZQ6LR11rbrV == null;
		}

		internal static _DefaultProperties coAsuQv8JarxPJyQW0Ag()
		{
			return (_DefaultProperties)FtQeekv88ZQ6LR11rbrV;
		}
	}

	private class __Resources_DefaultProperties
	{
		internal static object ky9vCFv8l7N7YYrn3LQm;

		public static string P_WorkflowInstance_DisplayName => (string)Y7CwOev8tbPeTfde973f(Oge0H6v8m5QPhih4tbMm(-1600060848 ^ -1600071434));

		public static string P_Uid_DisplayName => (string)Y7CwOev8tbPeTfde973f(Oge0H6v8m5QPhih4tbMm(-1638225214 ^ -1638172360));

		public __Resources_DefaultProperties()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			h8daP8v8bVqZHZKNSHXF();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4ef74b4b7d13430e9d2f9b78cbdb367b == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static object Oge0H6v8m5QPhih4tbMm(int _0020)
		{
			return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}

		internal static object Y7CwOev8tbPeTfde973f(object P_0)
		{
			return SR.T((string)P_0);
		}

		internal static bool UanNNBv80wUk1WZi2Z3d()
		{
			return ky9vCFv8l7N7YYrn3LQm == null;
		}

		internal static __Resources_DefaultProperties m50MLQv8y1P73dOybvXW()
		{
			return (__Resources_DefaultProperties)ky9vCFv8l7N7YYrn3LQm;
		}

		internal static void h8daP8v8bVqZHZKNSHXF()
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		}
	}

	public const string WorkflowTaskPropertyName = "WorkflowTask";

	public static readonly Guid ProcessContextUid;

	public new const string UID_S = "{A55C0516-4442-4D0D-AB40-17143DE835DF}";

	private static EntityMetadata _defMetadata;

	internal static ProcessContext xALC7vOH12EN0oZFvjmq;

	public override Guid TypeUid
	{
		get
		{
			return ProcessContextUid;
		}
		set
		{
		}
	}

	[Property("{9B9AAC17-22BB-425C-AA93-9C02C5146965}")]
	[EntityProperty]
	[StringSettings(MaxValueString = "2000", FieldName = "AssemblyName")]
	[XmlElement("AssemblyName")]
	[Uid("{8DB53DEE-0001-4ADA-988F-E167E9C19413}")]
	public virtual string AssemblyName
	{
		[CompilerGenerated]
		get
		{
			return _003CAssemblyName_003Ek__BackingField;
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
					_003CAssemblyName_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d87d9a74c9e14f96a288cc3620965fe0 != 0)
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

	[XmlElement("AssemblyRaw", IsNullable = true)]
	[EntityProperty]
	[BlobSettings(FieldName = "AssemblyRaw")]
	[Property("{1911B22D-0CE2-4743-832F-6A44CB0357FE}")]
	[Uid("{0DCFB744-5571-4F9E-B2B4-97D5CA0807C2}")]
	public virtual byte[] AssemblyRaw
	{
		[CompilerGenerated]
		get
		{
			return _003CAssemblyRaw_003Ek__BackingField;
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
					_003CAssemblyRaw_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d42a29e78d4a45518985de3631ade50c != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[Property("{1911B22D-0CE2-4743-832F-6A44CB0357FE}")]
	[XmlElement("DocumentationRaw", IsNullable = true)]
	[BlobSettings(FieldName = "DocumentationRaw")]
	[Uid("{EBA86F8B-B179-4389-A74F-8AE08A945AAF}")]
	[EntityProperty]
	public virtual byte[] DocumentationRaw
	{
		[CompilerGenerated]
		get
		{
			return _003CDocumentationRaw_003Ek__BackingField;
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
					_003CDocumentationRaw_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c447ffb64be44c09b6fd398df506785b != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public override PropertyMetadata CreateProperty(bool initNew = false)
	{
		EntityPropertyMetadata entityPropertyMetadata = new EntityPropertyMetadata();
		zZjnbAOH4EftCJk2SK5v(entityPropertyMetadata, Np7uleOHwGhc2Sra1Ilx());
		return entityPropertyMetadata;
	}

	public virtual void CreateAndCheckDefaultProperties()
	{
		//Discarded unreachable code: IL_003d, IL_00f0, IL_01a3, IL_01b2, IL_01e9, IL_01f8, IL_0318, IL_0327, IL_0354, IL_0380, IL_0414, IL_044b, IL_045a, IL_04f5, IL_0508, IL_0517
		int num = 4;
		int num2 = num;
		List<PropertyMetadata>.Enumerator enumerator = default(List<PropertyMetadata>.Enumerator);
		_003C_003Ec__DisplayClass20_0 _003C_003Ec__DisplayClass20_ = default(_003C_003Ec__DisplayClass20_0);
		PropertyMetadata propertyMetadata2 = default(PropertyMetadata);
		PropertyMetadata propertyMetadata = default(PropertyMetadata);
		int index = default(int);
		while (true)
		{
			switch (num2)
			{
			case 6:
				_defMetadata = new EntityMetadata();
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_85ba8d91af394836ac86666c40b1e150 == 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				if (_defMetadata != null)
				{
					num2 = 3;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e4c570270f54493d8f3f4763a72f63f7 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 6;
			default:
				_defMetadata.LoadFromType(dcgchgOHzv8d7BUhhBkL(typeof(_DefaultProperties).TypeHandle));
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_9570b4a70465495fba22c942f586465a == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
			case 3:
				enumerator = _defMetadata.Properties.GetEnumerator();
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bb19f93c0a774f6cbdada859bba83212 != 0)
				{
					num2 = 2;
				}
				break;
			case 5:
				return;
			case 2:
				try
				{
					while (true)
					{
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 1;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_eef7d2ca1c3c4b74aeb81172ed542639 == 0)
							{
								num3 = 0;
							}
							goto IL_0102;
						}
						goto IL_0203;
						IL_0203:
						_003C_003Ec__DisplayClass20_ = new _003C_003Ec__DisplayClass20_0();
						num3 = 2;
						goto IL_0102;
						IL_0102:
						while (true)
						{
							int num4;
							switch (num3)
							{
							case 1:
								return;
							case 4:
							case 11:
								break;
							case 7:
							case 18:
							case 20:
								if (x0qlDnOLOn23vPhV0URD(JXgI1FOLKvUJCDaT15Lb(propertyMetadata2), JXgI1FOLKvUJCDaT15Lb(_003C_003Ec__DisplayClass20_.defProp)))
								{
									num3 = 26;
									continue;
								}
								goto case 17;
							case 3:
								goto IL_0203;
							case 21:
								wVIH3nOLsBnOEs7jeqHM(propertyMetadata2, U1KUVuOL8felLUCs6Mwh(_003C_003Ec__DisplayClass20_.defProp));
								num3 = 4;
								continue;
							case 17:
								Rj4KVxOLYxUQIbVWT7xX(propertyMetadata2, ODQZWbOLvhvEeQ3XNogM(_003C_003Ec__DisplayClass20_.defProp));
								num3 = 25;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_719514a5a8ae47ed84e5a777ead0dc9f == 0)
								{
									num3 = 11;
								}
								continue;
							case 19:
								if (propertyMetadata2 != null)
								{
									num3 = 20;
									continue;
								}
								goto case 13;
							case 10:
								propertyMetadata2 = Properties.Find(_003C_003Ec__DisplayClass20_._003CCreateAndCheckDefaultProperties_003Eb__0);
								num3 = 19;
								continue;
							case 26:
								WKm6GHOLZ4SmLsqGAilY(propertyMetadata2, JXgI1FOLKvUJCDaT15Lb(_003C_003Ec__DisplayClass20_.defProp));
								num3 = 17;
								continue;
							case 14:
							case 22:
								Properties.Add(propertyMetadata2);
								num3 = 18;
								continue;
							case 9:
								if (!n122OWOLJuN0tW5Y1gW9(U1KUVuOL8felLUCs6Mwh(propertyMetadata2), _003C_003Ec__DisplayClass20_.defProp.ViewSettings))
								{
									num3 = 24;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_69cb4a76addb44f28bb765f059e441c7 != 0)
									{
										num3 = 13;
									}
									continue;
								}
								break;
							case 8:
								if (propertyMetadata != null)
								{
									int num5 = 23;
									num3 = num5;
									continue;
								}
								goto case 6;
							case 2:
								_003C_003Ec__DisplayClass20_.defProp = (EntityPropertyMetadata)enumerator.Current;
								num3 = 10;
								continue;
							case 13:
								propertyMetadata2 = ClassSerializationHelper.CloneObjectByXml(_003C_003Ec__DisplayClass20_.defProp);
								num3 = 15;
								continue;
							case 5:
								Properties.Insert(index, propertyMetadata2);
								num3 = 7;
								continue;
							case 12:
							case 16:
								if (_003C_003Ec__DisplayClass20_.defProp.ViewSettings != null)
								{
									num3 = 3;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ac5d16a577a84bb0b8ee3654769d2d33 == 0)
									{
										num3 = 9;
									}
									continue;
								}
								break;
							case 25:
								if (U1KUVuOL8felLUCs6Mwh(propertyMetadata2) != null)
								{
									num3 = 16;
									continue;
								}
								goto case 21;
							case 15:
								if (propertyMetadata2.IsSystem)
								{
									num3 = 14;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1a2d7634479d44fb8d3718c31b05f73c == 0)
									{
										num3 = 12;
									}
									continue;
								}
								goto default;
							case 6:
								num4 = 0;
								goto IL_04ad;
							case 24:
								wVIH3nOLsBnOEs7jeqHM(propertyMetadata2, _003C_003Ec__DisplayClass20_.defProp.ViewSettings);
								num3 = 11;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f30401a2cff84771be092252e934fede == 0)
								{
									num3 = 5;
								}
								continue;
							default:
								propertyMetadata = Properties.LastOrDefault(delegate(PropertyMetadata p)
								{
									int num7 = 1;
									int num8 = num7;
									while (true)
									{
										switch (num8)
										{
										default:
											return _003C_003Ec.ybSO1Lv8nhv2JIiZarRZ(p) != Guid.Empty;
										case 1:
											if (p.IsSystem)
											{
												return true;
											}
											num8 = 0;
											if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4ef74b4b7d13430e9d2f9b78cbdb367b != 0)
											{
												num8 = 0;
											}
											break;
										}
									}
								});
								num3 = 8;
								continue;
							case 23:
								{
									num4 = Properties.IndexOf(propertyMetadata) + 1;
									goto IL_04ad;
								}
								IL_04ad:
								index = num4;
								num3 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d7a51cf2841b436998bf3f4157fb2c9a == 0)
								{
									num3 = 5;
								}
								continue;
							}
							break;
						}
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
					int num6 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b84ccb8b1bd147ef900b852047ecbf45 == 0)
					{
						num6 = 0;
					}
					switch (num6)
					{
					case 0:
						break;
					}
				}
			}
		}
	}

	protected internal virtual void MarkPropertyAsDeleted(PropertyMetadata propertyMetadata, long versionNumber)
	{
		//Discarded unreachable code: IL_00c2
		int num = 5;
		int num2 = num;
		PropertyMetadataAdditionalAttribute propertyMetadataAdditionalAttribute2 = default(PropertyMetadataAdditionalAttribute);
		Parameter[] array = default(Parameter[]);
		while (true)
		{
			switch (num2)
			{
			case 6:
				return;
			case 5:
				CwYjAOOLl9lN7hlZ0xYC(propertyMetadata, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-642713667 ^ -642716303));
				num2 = 4;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0262725a60774e44a84fd2b93b79ee8a == 0)
				{
					num2 = 1;
				}
				break;
			case 7:
				propertyMetadata.AdditionalAttributes = new PropertyMetadataAdditionalAttribute[1] { propertyMetadataAdditionalAttribute2 };
				num2 = 3;
				break;
			case 4:
				array = new Parameter[1]
				{
					new Parameter(string.Empty, versionNumber)
				};
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b1ab9396b25b43af8f32e24b1948be96 != 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				return;
			case 2:
				hH3FsTOLtdsYbNCoZECG(propertyMetadata, ((IEnumerable<PropertyMetadataAdditionalAttribute>)y4H0gZOLmLGQlApWY2qI(propertyMetadata)).Concat(new PropertyMetadataAdditionalAttribute[1] { propertyMetadataAdditionalAttribute2 }).ToArray());
				num2 = 6;
				break;
			default:
				if (y4H0gZOLmLGQlApWY2qI(propertyMetadata) != null)
				{
					num2 = 2;
					break;
				}
				goto case 7;
			case 1:
			{
				PropertyMetadataAdditionalAttribute propertyMetadataAdditionalAttribute = new PropertyMetadataAdditionalAttribute();
				RswgE1OL0ExRC4dP85X2(propertyMetadataAdditionalAttribute, ProcessContextDeletedPropertyAttribute.FullName);
				UsFnqdOLypfQ1ugwkkW1(propertyMetadataAdditionalAttribute, array);
				propertyMetadataAdditionalAttribute2 = propertyMetadataAdditionalAttribute;
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6782172e84504a7baf3163b8f6b2a916 == 0)
				{
					num2 = 0;
				}
				break;
			}
			}
		}
	}

	public override DataClassMetadata CreateViewModelMetadata()
	{
		object obj = hhdg5NOLbVspJikQV23J(this);
		((ClassMetadata)obj).Properties.Add(CreateWorkflowTaskProperty());
		return (DataClassMetadata)obj;
	}

	protected override ViewModelPropertyMetadata CreateModelProperty()
	{
		ViewModelPropertyMetadata obj = new ViewModelPropertyMetadata
		{
			Uid = Np7uleOHwGhc2Sra1Ilx(),
			Name = (string)RASI5yOL55Ik2QYiQ9Di(0x246EEF98 ^ 0x246F530C),
			DisplayName = (string)zmKxKZOLgkdpqAeETFHJ(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1647793954 ^ -1647752272))
		};
		kS7x7POLBrS6JE7txSO9(obj, ProcessParametersTypeDescriptor.UID);
		olFKXdOLPZkOOSYC3of7(obj, BA8UWtOLc8Bgl1MqWGqq(this));
		obj.IsSystem = true;
		return obj;
	}

	internal static ViewModelPropertyMetadata CreateWorkflowTaskProperty()
	{
		ViewModelPropertyMetadata viewModelPropertyMetadata = new ViewModelPropertyMetadata();
		zZjnbAOH4EftCJk2SK5v(viewModelPropertyMetadata, Guid.NewGuid());
		viewModelPropertyMetadata.Name = SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6F6D7B44 ^ 0x6F6C8380);
		A4kYCaOLX3MDJJhCbqX1(viewModelPropertyMetadata, SR.T((string)RASI5yOL55Ik2QYiQ9Di(0x4943E3E4 ^ 0x49421278)));
		kS7x7POLBrS6JE7txSO9(viewModelPropertyMetadata, ProcessParametersTypeDescriptor.UID);
		olFKXdOLPZkOOSYC3of7(viewModelPropertyMetadata, InterfaceActivator.UID<IWorkflowTask>());
		Rj4KVxOLYxUQIbVWT7xX(viewModelPropertyMetadata, true);
		return viewModelPropertyMetadata;
	}

	public ProcessContext()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		xtN05NOLdgS7Is1xJTrl();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d2f119e188994b55be2499c193b880fb == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static ProcessContext()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4459fbe344a947429d197733d274ef68 != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				ProcessContextUid = new Guid((string)RASI5yOL55Ik2QYiQ9Di(0x4943E3E4 ^ 0x4943FF10));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bb19f93c0a774f6cbdada859bba83212 != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	internal static bool mQGvO0OHhaj04GEOhKiR()
	{
		return xALC7vOH12EN0oZFvjmq == null;
	}

	internal static ProcessContext l1f0GqOHE9vOpq0YZaPG()
	{
		return xALC7vOH12EN0oZFvjmq;
	}

	internal static Guid Np7uleOHwGhc2Sra1Ilx()
	{
		return Guid.NewGuid();
	}

	internal static void zZjnbAOH4EftCJk2SK5v(object P_0, Guid P_1)
	{
		((AbstractMetadata)P_0).Uid = P_1;
	}

	internal static Type dcgchgOHzv8d7BUhhBkL(RuntimeTypeHandle P_0)
	{
		return System.Type.GetTypeFromHandle(P_0);
	}

	internal static object JXgI1FOLKvUJCDaT15Lb(object P_0)
	{
		return ((NamedMetadata)P_0).Name;
	}

	internal static bool x0qlDnOLOn23vPhV0URD(object P_0, object P_1)
	{
		return (string)P_0 != (string)P_1;
	}

	internal static void WKm6GHOLZ4SmLsqGAilY(object P_0, object P_1)
	{
		((NamedMetadata)P_0).Name = (string)P_1;
	}

	internal static bool ODQZWbOLvhvEeQ3XNogM(object P_0)
	{
		return ((PropertyMetadata)P_0).IsSystem;
	}

	internal static void Rj4KVxOLYxUQIbVWT7xX(object P_0, bool P_1)
	{
		((PropertyMetadata)P_0).IsSystem = P_1;
	}

	internal static object U1KUVuOL8felLUCs6Mwh(object P_0)
	{
		return ((PropertyMetadata)P_0).ViewSettings;
	}

	internal static void wVIH3nOLsBnOEs7jeqHM(object P_0, object P_1)
	{
		((PropertyMetadata)P_0).ViewSettings = (PropertyViewSettings)P_1;
	}

	internal static bool n122OWOLJuN0tW5Y1gW9(object P_0, object P_1)
	{
		return ((PropertyViewSettings)P_0).Equals((PropertyViewSettings)P_1);
	}

	internal static void CwYjAOOLl9lN7hlZ0xYC(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static void RswgE1OL0ExRC4dP85X2(object P_0, object P_1)
	{
		((PropertyMetadataAdditionalAttribute)P_0).AddtibuteName = (string)P_1;
	}

	internal static void UsFnqdOLypfQ1ugwkkW1(object P_0, object P_1)
	{
		((PropertyMetadataAdditionalAttribute)P_0).Parameters = (Parameter[])P_1;
	}

	internal static object y4H0gZOLmLGQlApWY2qI(object P_0)
	{
		return ((PropertyMetadata)P_0).AdditionalAttributes;
	}

	internal static void hH3FsTOLtdsYbNCoZECG(object P_0, object P_1)
	{
		((PropertyMetadata)P_0).AdditionalAttributes = (PropertyMetadataAdditionalAttribute[])P_1;
	}

	internal static object hhdg5NOLbVspJikQV23J(object P_0)
	{
		return ((EntityMetadata)P_0).CreateViewModelMetadata();
	}

	internal static object RASI5yOL55Ik2QYiQ9Di(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object zmKxKZOLgkdpqAeETFHJ(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static void kS7x7POLBrS6JE7txSO9(object P_0, Guid P_1)
	{
		((PropertyMetadata)P_0).TypeUid = P_1;
	}

	internal static Guid BA8UWtOLc8Bgl1MqWGqq(object P_0)
	{
		return ((AbstractMetadata)P_0).Uid;
	}

	internal static void olFKXdOLPZkOOSYC3of7(object P_0, Guid P_1)
	{
		((PropertyMetadata)P_0).SubTypeUid = P_1;
	}

	internal static void A4kYCaOLX3MDJJhCbqX1(object P_0, object P_1)
	{
		((NamedMetadata)P_0).DisplayName = (string)P_1;
	}

	internal static void xtN05NOLdgS7Is1xJTrl()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}
}
