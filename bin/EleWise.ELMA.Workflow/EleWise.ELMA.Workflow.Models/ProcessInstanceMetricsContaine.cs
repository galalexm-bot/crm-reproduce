using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Workflow.CodeGeneration;
using EleWise.ELMA.Workflow.Mappings;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Models;

[Serializable]
[Uid("{e23b6366-eb24-41ab-8df4-20cce74df26e}")]
[MetadataType(typeof(EntityMetadata))]
[Entity("InstanceMetricsContainer")]
[DisplayName(typeof(__Resources_ProcessInstanceMetricsCollection), "DisplayName")]
[ClassMap(typeof(ProcessInstanceMetricsContainerMap))]
[BaseClass("{C40FD1D3-F5D9-4323-9E51-42EBFA77E6DC}")]
public class ProcessInstanceMetricsContainer : EntityMetadata, IProcessContext, IEntityMetadata, IRootMetadata, IMetadata, IXsiType, ICodeItemMetadata, IGroupedMetadata
{
	[Component]
	public class Info : IMetadataTypeInfo
	{
		private static Info vUZTgyv8TGrPOBHHjeVt;

		public string Name => (string)IvGNIBv8MWm7cgweqLXL(Vc3NdXv8CJ4NGEUm6mDh(-768800937 ^ -768614533));

		public string Description => string.Empty;

		public Type MetadataType => typeof(ProcessInstanceMetricsContainer);

		public Type GeneratorType => mDBXY5v8kVIY8pkjnUjJ(typeof(ProcessInstanceMetricsGenerator).TypeHandle);

		public Info()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_eef7d2ca1c3c4b74aeb81172ed542639 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static object Vc3NdXv8CJ4NGEUm6mDh(int _0020)
		{
			return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}

		internal static object IvGNIBv8MWm7cgweqLXL(object P_0)
		{
			return SR.T((string)P_0);
		}

		internal static bool CsOsqZv8QbLAM37FLDTw()
		{
			return vUZTgyv8TGrPOBHHjeVt == null;
		}

		internal static Info CbC2Frv8pwgq6EGnyYdP()
		{
			return vUZTgyv8TGrPOBHHjeVt;
		}

		internal static Type mDBXY5v8kVIY8pkjnUjJ(RuntimeTypeHandle P_0)
		{
			return System.Type.GetTypeFromHandle(P_0);
		}
	}

	public static class DefaultProperties
	{
		public static class WorkflowInstance
		{
			public const string UID = "{F9C6547C-9CA1-4E5F-8F46-F77DC52B6981}";

			public static readonly Guid Uid;

			public const string Name = "WorkflowInstance";

			private static WorkflowInstance SR5dcbvQBCyBwmpITcEa;

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
						kL2ttDvQXCO08QVglMKC();
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3f508947b0d94af1961e5aa17a8a2044 != 0)
						{
							num2 = 0;
						}
						break;
					default:
						Uid = new Guid((string)POvwKUvQdN5fC0AgGb71(0x628167BE ^ 0x62839DCE));
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f30401a2cff84771be092252e934fede != 0)
						{
							num2 = 2;
						}
						break;
					}
				}
			}

			internal static void kL2ttDvQXCO08QVglMKC()
			{
				j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
			}

			internal static object POvwKUvQdN5fC0AgGb71(int _0020)
			{
				return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
			}

			internal static bool Hh4be5vQc6ruDp7naQmu()
			{
				return SR5dcbvQBCyBwmpITcEa == null;
			}

			internal static WorkflowInstance SNatB6vQPebOhbmH2nI4()
			{
				return SR5dcbvQBCyBwmpITcEa;
			}
		}
	}

	private class _DefaultProperties
	{
		internal static object e52vLPv8GBOHY8pWd7WS;

		[SystemProperty]
		[EntityProperty]
		[DisplayName(typeof(__Resources_DefaultProperties), "P_WorkflowInstance_DisplayName")]
		[View(ViewType = ViewType.Create, Visibility = Visibility.Hidden)]
		[View(ViewType = ViewType.List, Visibility = Visibility.ForceHidden)]
		[View(ViewType = ViewType.Edit, Visibility = Visibility.Hidden)]
		[View(ViewType = ViewType.Display, Visibility = Visibility.Hidden)]
		[EntitySettings(FieldName = "WorkflowInstance")]
		[Property("{72ED98CA-F260-4671-9BCD-FF1D80235F47}", "ae8e2269-5077-4bb3-a8dd-62e5d130f009")]
		[Uid("{F9C6547C-9CA1-4E5F-8F46-F77DC52B6981}")]
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
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_db8eb3e90ad546d4b05544ab6326a49f == 0)
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

		public _DefaultProperties()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			TfMFrFv8oBFxVFt2P1oy();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f33560c5d18b4e10b24a458578aa60fd == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static bool vn3RUiv87j8oQ3iHDQMG()
		{
			return e52vLPv8GBOHY8pWd7WS == null;
		}

		internal static _DefaultProperties XSoAg1v82XxQW2Y4e88Z()
		{
			return (_DefaultProperties)e52vLPv8GBOHY8pWd7WS;
		}

		internal static void TfMFrFv8oBFxVFt2P1oy()
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		}
	}

	private class __Resources_DefaultProperties
	{
		private static object y2RYetv8FL7SNv1oM1dC;

		public static string P_WorkflowInstance_DisplayName => (string)BdLAowv8rRoiMXa6r5dD(VE7cPxv8aF5u7oFenC0g(-720457373 ^ -720409659));

		public __Resources_DefaultProperties()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5c45a6e5a4614bfba7591d8a1c7ced1d != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static object VE7cPxv8aF5u7oFenC0g(int _0020)
		{
			return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}

		internal static object BdLAowv8rRoiMXa6r5dD(object P_0)
		{
			return SR.T((string)P_0);
		}

		internal static bool nSs5RYv8iJav8h9YLBBQ()
		{
			return y2RYetv8FL7SNv1oM1dC == null;
		}

		internal static __Resources_DefaultProperties DtKnI6v8IZVVq5e4erNC()
		{
			return (__Resources_DefaultProperties)y2RYetv8FL7SNv1oM1dC;
		}
	}

	public new const string UID_S = "{e23b6366-eb24-41ab-8df4-20cce74df26e}";

	private static Guid _UID;

	private static EntityMetadata _defMetadata;

	private static ProcessInstanceMetricsContainer PSBJ6SOfWMlBqukkEacT;

	public override Guid TypeUid
	{
		get
		{
			return _UID;
		}
		set
		{
		}
	}

	[EntityProperty]
	[Property("{9B9AAC17-22BB-425C-AA93-9C02C5146965}")]
	[XmlElement("AssemblyName")]
	[Uid("{0FDE0F30-1463-4E12-B706-079C1182EDE3}")]
	[StringSettings(FieldName = "AssemblyName")]
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
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c7fe5d092d804f7e91041fb2338cec1a != 0)
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

	[Uid("{9BCA64B7-7B07-46F6-81BC-983244CEA91D}")]
	[EntityProperty]
	[BlobSettings(FieldName = "AssemblyRaw")]
	[Property("{1911B22D-0CE2-4743-832F-6A44CB0357FE}")]
	[XmlElement("AssemblyRaw", IsNullable = true)]
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
				case 1:
					_003CAssemblyRaw_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ba57b850b1d34fd9bce66a583e71dc16 == 0)
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

	public override PropertyMetadata CreateProperty(bool initNew = false)
	{
		ProcessInstanceMetric processInstanceMetric = new ProcessInstanceMetric();
		Dkn5WUOfqUheqK42R6YR(processInstanceMetric, JUqB5IOf64SpeektRUyp());
		return processInstanceMetric;
	}

	public virtual void CreateAndCheckDefaultProperties()
	{
		//Discarded unreachable code: IL_005d, IL_006c, IL_0077, IL_00f3, IL_012a, IL_020c, IL_021b, IL_02d5, IL_02e4, IL_0358, IL_0367, IL_03eb, IL_04b4, IL_04c7, IL_04d6
		int num = 2;
		List<PropertyMetadata>.Enumerator enumerator = default(List<PropertyMetadata>.Enumerator);
		_003C_003Ec__DisplayClass15_0 _003C_003Ec__DisplayClass15_ = default(_003C_003Ec__DisplayClass15_0);
		PropertyMetadata propertyMetadata2 = default(PropertyMetadata);
		int index = default(int);
		PropertyMetadata propertyMetadata = default(PropertyMetadata);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 5:
					break;
				default:
					try
					{
						while (true)
						{
							int num3;
							if (!enumerator.MoveNext())
							{
								num3 = 2;
								goto IL_007b;
							}
							goto IL_02bf;
							IL_007b:
							while (true)
							{
								int num4;
								switch (num3)
								{
								case 23:
									num4 = 0;
									goto IL_047c;
								case 4:
									_003C_003Ec__DisplayClass15_.defProp = (EntityPropertyMetadata)enumerator.Current;
									num3 = 16;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1de08766357542bdb81146373079f817 == 0)
									{
										num3 = 5;
									}
									continue;
								default:
									if (pviJI3OfVF3ClaYyAHh0(kHR9sEOfkOIcQFtRwF6R(propertyMetadata2), kHR9sEOfkOIcQFtRwF6R(_003C_003Ec__DisplayClass15_.defProp)))
									{
										num3 = 8;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ffb1346d351f436b84bb1e9954c3bfa8 != 0)
										{
											num3 = 8;
										}
										continue;
									}
									goto case 10;
								case 5:
								case 20:
									if (kHR9sEOfkOIcQFtRwF6R(_003C_003Ec__DisplayClass15_.defProp) != null)
									{
										num3 = 0;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_9269d021c6f148b6a1c4afb8cee03b6c == 0)
										{
											num3 = 0;
										}
										continue;
									}
									break;
								case 10:
									GRJGLhOfUPLSVgHGwZOS(propertyMetadata2, kHR9sEOfkOIcQFtRwF6R(_003C_003Ec__DisplayClass15_.defProp));
									num3 = 13;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5537a063960e465db83a04e35eea441b == 0)
									{
										num3 = 7;
									}
									continue;
								case 12:
									Properties.Add(propertyMetadata2);
									num3 = 18;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bd84f42638494cb6b4427f8e13ec59af != 0)
									{
										num3 = 2;
									}
									continue;
								case 7:
									MtYeXdOfCkpkssv2dUnN(propertyMetadata2, _003C_003Ec__DisplayClass15_.defProp.Name);
									num3 = 14;
									continue;
								case 16:
									propertyMetadata2 = Properties.Find(_003C_003Ec__DisplayClass15_._003CCreateAndCheckDefaultProperties_003Eb__0);
									num3 = 1;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_fb347e2c5dba4e0ca4d47098be7fd10c == 0)
									{
										num3 = 0;
									}
									continue;
								case 15:
									Properties.Insert(index, propertyMetadata2);
									num3 = 9;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_32f3e755437f4eacb85c8a0d536f83ea == 0)
									{
										num3 = 22;
									}
									continue;
								case 8:
								case 13:
								case 19:
									break;
								case 11:
									if (!VOsxeGOfThN7d7lItRbf(propertyMetadata2))
									{
										num3 = 9;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6d48f3b4557a49578bf7f5ef0517e0be == 0)
										{
											num3 = 4;
										}
										continue;
									}
									goto case 12;
								case 3:
									goto IL_02bf;
								case 14:
									w9AL7fOfMx5p0LMVUGN1(propertyMetadata2, _003C_003Ec__DisplayClass15_.defProp.IsSystem);
									num3 = 2;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b30151cb26574dfaa8f9d818b0352d3b != 0)
									{
										num3 = 17;
									}
									continue;
								case 6:
								case 18:
								case 22:
									if (O8t3j3OfpWyDqFmQW8Ys(propertyMetadata2.Name, f4A37QOfQN7i5tT9UUIH(_003C_003Ec__DisplayClass15_.defProp)))
									{
										num3 = 5;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f453500aaab143479696408f48a03c17 == 0)
										{
											num3 = 7;
										}
										continue;
									}
									goto case 14;
								case 17:
									if (kHR9sEOfkOIcQFtRwF6R(propertyMetadata2) != null)
									{
										num3 = 3;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_69cb4a76addb44f28bb765f059e441c7 == 0)
										{
											num3 = 20;
										}
										continue;
									}
									goto case 21;
								case 24:
									if (propertyMetadata == null)
									{
										num3 = 18;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_719514a5a8ae47ed84e5a777ead0dc9f != 0)
										{
											num3 = 23;
										}
										continue;
									}
									num4 = Properties.IndexOf(propertyMetadata) + 1;
									goto IL_047c;
								case 21:
									GRJGLhOfUPLSVgHGwZOS(propertyMetadata2, kHR9sEOfkOIcQFtRwF6R(_003C_003Ec__DisplayClass15_.defProp));
									num3 = 19;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d843b0b7f23e489fb6d586d64b0a634a == 0)
									{
										num3 = 4;
									}
									continue;
								case 1:
									if (propertyMetadata2 != null)
									{
										num3 = 6;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f236c3d0fade492db73e8204df65377d != 0)
										{
											num3 = 6;
										}
										continue;
									}
									goto case 25;
								case 25:
									propertyMetadata2 = ClassSerializationHelper.CloneObjectByXml(_003C_003Ec__DisplayClass15_.defProp);
									num3 = 11;
									continue;
								case 9:
									propertyMetadata = Properties.LastOrDefault(delegate(PropertyMetadata p)
									{
										int num6 = 1;
										int num7 = num6;
										while (true)
										{
											switch (num7)
											{
											case 1:
												if (_003C_003Ec.DhFdnMvsKQ6tKdfFLF1m(p))
												{
													return true;
												}
												num7 = 0;
												if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_160bffb148c14c5da92d8d6ddf481bdc != 0)
												{
													num7 = 0;
												}
												break;
											default:
												return _003C_003Ec.wUwtnkvsOXfEs4BGyVS7(p.OwnerPropertyUid, Guid.Empty);
											}
										}
									});
									num3 = 24;
									continue;
								case 2:
									return;
									IL_047c:
									index = num4;
									num3 = 15;
									continue;
								}
								break;
							}
							continue;
							IL_02bf:
							_003C_003Ec__DisplayClass15_ = new _003C_003Ec__DisplayClass15_0();
							num3 = 4;
							goto IL_007b;
						}
					}
					finally
					{
						((IDisposable)enumerator).Dispose();
						int num5 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d2d2252621ae43ad8d38af812176c290 == 0)
						{
							num5 = 0;
						}
						switch (num5)
						{
						case 0:
							break;
						}
					}
				case 3:
					enumerator = _defMetadata.Properties.GetEnumerator();
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_71a41ac2fa884d27b721ae0509586eea != 0)
					{
						num2 = 0;
					}
					continue;
				case 1:
					_defMetadata = new ProcessInstanceMetricsContainer();
					num2 = 5;
					continue;
				case 4:
					return;
				case 2:
					if (_defMetadata == null)
					{
						num2 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5537a063960e465db83a04e35eea441b == 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 3;
				}
				break;
			}
			_defMetadata.LoadFromType(mhKXttOf3dmsnSX399Xa(typeof(_DefaultProperties).TypeHandle));
			num = 3;
		}
	}

	public ProcessInstanceMetricsContainer()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6e2e244178c44ea09cd756894b022a62 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static ProcessInstanceMetricsContainer()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 2:
				UtYoWDOfAYvGZKyeu8Qb();
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_db8eb3e90ad546d4b05544ab6326a49f != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				_UID = new Guid((string)eAghdZOfGU494vlMWJVQ(-1638225214 ^ -1638223206));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_60c5782a184b457aa78da2e5c62d4e27 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static bool MCT5nLOfjg7e82YPhvkh()
	{
		return PSBJ6SOfWMlBqukkEacT == null;
	}

	internal static ProcessInstanceMetricsContainer opIfLHOfRRfw8T0WLooZ()
	{
		return PSBJ6SOfWMlBqukkEacT;
	}

	internal static Guid JUqB5IOf64SpeektRUyp()
	{
		return Guid.NewGuid();
	}

	internal static void Dkn5WUOfqUheqK42R6YR(object P_0, Guid P_1)
	{
		((AbstractMetadata)P_0).Uid = P_1;
	}

	internal static Type mhKXttOf3dmsnSX399Xa(RuntimeTypeHandle P_0)
	{
		return System.Type.GetTypeFromHandle(P_0);
	}

	internal static bool VOsxeGOfThN7d7lItRbf(object P_0)
	{
		return ((PropertyMetadata)P_0).IsSystem;
	}

	internal static object f4A37QOfQN7i5tT9UUIH(object P_0)
	{
		return ((NamedMetadata)P_0).Name;
	}

	internal static bool O8t3j3OfpWyDqFmQW8Ys(object P_0, object P_1)
	{
		return (string)P_0 != (string)P_1;
	}

	internal static void MtYeXdOfCkpkssv2dUnN(object P_0, object P_1)
	{
		((NamedMetadata)P_0).Name = (string)P_1;
	}

	internal static void w9AL7fOfMx5p0LMVUGN1(object P_0, bool P_1)
	{
		((PropertyMetadata)P_0).IsSystem = P_1;
	}

	internal static object kHR9sEOfkOIcQFtRwF6R(object P_0)
	{
		return ((PropertyMetadata)P_0).ViewSettings;
	}

	internal static void GRJGLhOfUPLSVgHGwZOS(object P_0, object P_1)
	{
		((PropertyMetadata)P_0).ViewSettings = (PropertyViewSettings)P_1;
	}

	internal static bool pviJI3OfVF3ClaYyAHh0(object P_0, object P_1)
	{
		return ((PropertyViewSettings)P_0).Equals((PropertyViewSettings)P_1);
	}

	internal static void UtYoWDOfAYvGZKyeu8Qb()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static object eAghdZOfGU494vlMWJVQ(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}
}
