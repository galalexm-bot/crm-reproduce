using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using EleWise.ELMA.Common;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Globalization;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Transformations;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Views;

[Serializable]
[DebuggerTypeProxy(typeof(DebugView))]
[EleWise.ELMA.Model.Attributes.DisplayName(typeof(__Resources_PropertyViewItem), "DisplayName")]
public class PropertyViewItem : RootViewItem, IFocusable, IViewItemWithPropertyParents, ICustomViewNameViewItem
{
	public new sealed class DebugView
	{
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly PropertyViewItem viewItem;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private IPropertyMetadata property;

		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
		private readonly RootViewItem.DebugView _rootViewItemDebugView;

		internal static DebugView spa6u7CvTSUiEJ794R8P;

		public IPropertyMetadata Property
		{
			get
			{
				//Discarded unreachable code: IL_0050, IL_006f, IL_00d4, IL_00e3
				int num = 8;
				_003C_003Ec__DisplayClass5_0 _003C_003Ec__DisplayClass5_ = default(_003C_003Ec__DisplayClass5_0);
				while (true)
				{
					int num2 = num;
					while (true)
					{
						Guid guid;
						switch (num2)
						{
						default:
							guid = m1piaRCv2m5OHvPD8nbP(property);
							goto IL_0124;
						case 3:
							break;
						case 2:
						case 5:
							return property;
						case 7:
							if (property is ITablePartMetadata)
							{
								num2 = 4;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
								{
									num2 = 4;
								}
								continue;
							}
							goto default;
						case 8:
							if (property != null)
							{
								num2 = 3;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
								{
									num2 = 7;
								}
								continue;
							}
							break;
						case 6:
							_003C_003Ec__DisplayClass5_.service = (IMetadataService)BUHgvZCvNnRpdGk7EArF();
							num2 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
							{
								num2 = 0;
							}
							continue;
						case 4:
							guid = ywP0ENCvevAE91emb7Ht((ITablePartMetadata)property);
							goto IL_0124;
						case 1:
							{
								property = (from m in new ClassMetadata[1] { ((ViewItem.DebugView)VfpCXtCv3pkUmoWSxhle(_rootViewItemDebugView)).Metadata }.If(_003C_003Ec__DisplayClass5_.service != null, _003C_003Ec__DisplayClass5_._003Cget_Property_003Eb__0)
									where m != null
									select m).Select(delegate(ClassMetadata m)
								{
									//Discarded unreachable code: IL_0075, IL_0084
									int num3 = 3;
									IEntityMetadata entityMetadata = default(IEntityMetadata);
									IPropertyMetadata propertyMetadata = default(IPropertyMetadata);
									while (true)
									{
										int num4 = num3;
										while (true)
										{
											switch (num4)
											{
											case 3:
												break;
											case 6:
												if (entityMetadata == null)
												{
													num4 = 4;
													continue;
												}
												goto case 1;
											case 4:
											case 5:
												return propertyMetadata;
											case 1:
												propertyMetadata = entityMetadata.GetPropertiesAndTableParts().OfType<ITablePartMetadata>().FirstOrDefault((ITablePartMetadata tp) => PBOn0vCvA7cUPMjbKT10(ywP0ENCvevAE91emb7Ht(tp), viewItem.PropertyUid));
												num4 = 5;
												continue;
											default:
												entityMetadata = m as IEntityMetadata;
												num4 = 6;
												continue;
											case 2:
												if (propertyMetadata == null)
												{
													num4 = 0;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
													{
														num4 = 0;
													}
													continue;
												}
												goto case 4;
											}
											break;
										}
										propertyMetadata = m.Properties.FirstOrDefault((PropertyMetadata p) => p.Uid == viewItem.PropertyUid);
										num3 = 2;
									}
								}).FirstOrDefault((IPropertyMetadata p) => p != null);
								num2 = 2;
								continue;
							}
							IL_0124:
							if (!oYxMkiCv1TSS3sC0WPVN(guid, WCJObVCvPmKsBh0u8YQA(viewItem)))
							{
								num2 = 5;
								continue;
							}
							break;
						}
						break;
					}
					_003C_003Ec__DisplayClass5_ = new _003C_003Ec__DisplayClass5_0();
					num = 6;
				}
			}
		}

		public bool? ReadOnly => viewItem.Attributes.ReadOnly;

		public bool FullReadOnly => ft6pUjCvaDilxEtKWMUA(BUh4fvCvp07PNMFHJgv9(viewItem));

		public bool Required => ((ViewAttributes)BUh4fvCvp07PNMFHJgv9(viewItem)).Required;

		public bool Visible => ywf57nCvDv9DQ1ahPWRo(BUh4fvCvp07PNMFHJgv9(viewItem));

		public ViewAttributes Attributes => (ViewAttributes)BUh4fvCvp07PNMFHJgv9(viewItem);

		public string CustomViewName
		{
			get
			{
				return (string)S3FEoOCvtsEc6UDNeKOI(viewItem);
			}
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
						oxg4oxCvwLobU27JCbOp(viewItem, value);
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public DebugView(PropertyViewItem viewItem)
		{
			//Discarded unreachable code: IL_002a, IL_002f
			Pa2e6qCvOTFa2fGdii4j();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
			{
				num = 0;
			}
			while (true)
			{
				switch (num)
				{
				case 2:
					return;
				case 1:
					this.viewItem = viewItem;
					num = 2;
					continue;
				}
				_rootViewItemDebugView = new RootViewItem.DebugView(viewItem);
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
				{
					num = 1;
				}
			}
		}

		public override string ToString()
		{
			return (string)DdBmMhCvHcWm3k4kRgwy(viewItem, (Property != null) ? hZYaipCv6fND2PR4CWmV(aqy744Cv4ukxXjGHT4Yg(--1418440330 ^ 0x548BC9A0), Property, aqy744Cv4ukxXjGHT4Yg(-521266112 ^ -521272324)) : null);
		}

		internal static void Pa2e6qCvOTFa2fGdii4j()
		{
			SingletonReader.JJCZtPuTvSt();
		}

		internal static bool Js3RFICvkGoQmwsKOFj1()
		{
			return spa6u7CvTSUiEJ794R8P == null;
		}

		internal static DebugView yTNb0MCvnUZvZCGJ7vae()
		{
			return spa6u7CvTSUiEJ794R8P;
		}

		internal static Guid m1piaRCv2m5OHvPD8nbP(object P_0)
		{
			return ((IMetadata)P_0).Uid;
		}

		internal static Guid ywP0ENCvevAE91emb7Ht(object P_0)
		{
			return ((ITablePartMetadata)P_0).TablePartPropertyUid;
		}

		internal static Guid WCJObVCvPmKsBh0u8YQA(object P_0)
		{
			return ((PropertyViewItem)P_0).PropertyUid;
		}

		internal static bool oYxMkiCv1TSS3sC0WPVN(Guid P_0, Guid P_1)
		{
			return P_0 != P_1;
		}

		internal static object BUHgvZCvNnRpdGk7EArF()
		{
			return MetadataServiceContext.ServiceOrNull;
		}

		internal static object VfpCXtCv3pkUmoWSxhle(object P_0)
		{
			return ((RootViewItem.DebugView)P_0).viewItemDebugView;
		}

		internal static object BUh4fvCvp07PNMFHJgv9(object P_0)
		{
			return ((PropertyViewItem)P_0).Attributes;
		}

		internal static bool ft6pUjCvaDilxEtKWMUA(object P_0)
		{
			return ((ViewAttributes)P_0).FullReadOnly;
		}

		internal static bool ywf57nCvDv9DQ1ahPWRo(object P_0)
		{
			return ((ViewAttributes)P_0).Visible;
		}

		internal static object S3FEoOCvtsEc6UDNeKOI(object P_0)
		{
			return ((PropertyViewItem)P_0).CustomViewName;
		}

		internal static void oxg4oxCvwLobU27JCbOp(object P_0, object P_1)
		{
			((PropertyViewItem)P_0).CustomViewName = (string)P_1;
		}

		internal static object aqy744Cv4ukxXjGHT4Yg(int _0020)
		{
			return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}

		internal static object hZYaipCv6fND2PR4CWmV(object P_0, object P_1, object P_2)
		{
			return string.Concat(P_0, P_1, P_2);
		}

		internal static object DdBmMhCvHcWm3k4kRgwy(object P_0, object P_1)
		{
			return string.Concat(P_0, P_1);
		}

		internal static bool PBOn0vCvA7cUPMjbKT10(Guid P_0, Guid P_1)
		{
			return P_0 == P_1;
		}
	}

	private class AttributesChangeableProperties : IAttributesChangeableProperties
	{
		internal static object fF1veSCv7FG7ne6j4JQ8;

		public string[] GetProperties()
		{
			string[] array = new string[16];
			ParameterExpression parameterExpression = (ParameterExpression)A9UpJrCvyvrd3Foigvp9(typeof(ViewAttributes), MqChLOCvm1hT96IOGgUv(-398663332 ^ -398923310));
			array[0] = LinqUtils.NameOf(Expression.Lambda<Func<ViewAttributes, object>>(Expression.Convert(Expression.Property(parameterExpression, (MethodInfo)u8JRQlCvMMlKDq4DxO49((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), ANgfdfCvJIUB5hfWbuO5(typeof(object).TypeHandle)), new ParameterExpression[1] { parameterExpression }));
			parameterExpression = Expression.Parameter(ANgfdfCvJIUB5hfWbuO5(typeof(ViewAttributes).TypeHandle), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-475857671 ^ -475597705));
			array[1] = LinqUtils.NameOf(Expression.Lambda<Func<ViewAttributes, object>>((Expression)AwkQZnCvdOPislPq5JJ8(PCCCx2Cv9tKNk1GUSXff(parameterExpression, (MethodInfo)u8JRQlCvMMlKDq4DxO49((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), ANgfdfCvJIUB5hfWbuO5(typeof(object).TypeHandle)), new ParameterExpression[1] { parameterExpression }));
			parameterExpression = Expression.Parameter(ANgfdfCvJIUB5hfWbuO5(typeof(ViewAttributes).TypeHandle), (string)MqChLOCvm1hT96IOGgUv(-3333094 ^ -3593068));
			array[2] = LinqUtils.NameOf(Expression.Lambda<Func<ViewAttributes, object>>((Expression)AwkQZnCvdOPislPq5JJ8(Expression.Property(parameterExpression, (MethodInfo)u8JRQlCvMMlKDq4DxO49((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), typeof(object)), new ParameterExpression[1] { parameterExpression }));
			parameterExpression = (ParameterExpression)A9UpJrCvyvrd3Foigvp9(ANgfdfCvJIUB5hfWbuO5(typeof(ViewAttributes).TypeHandle), MqChLOCvm1hT96IOGgUv(-1638402543 ^ -1638662497));
			array[3] = LinqUtils.NameOf(Expression.Lambda<Func<ViewAttributes, object>>(Expression.Property(parameterExpression, (MethodInfo)u8JRQlCvMMlKDq4DxO49((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }));
			parameterExpression = (ParameterExpression)A9UpJrCvyvrd3Foigvp9(ANgfdfCvJIUB5hfWbuO5(typeof(ViewAttributes).TypeHandle), MqChLOCvm1hT96IOGgUv(0x571EA399 ^ 0x571AAB17));
			array[4] = LinqUtils.NameOf(Expression.Lambda<Func<ViewAttributes, object>>((Expression)PCCCx2Cv9tKNk1GUSXff(parameterExpression, (MethodInfo)u8JRQlCvMMlKDq4DxO49((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }));
			parameterExpression = (ParameterExpression)A9UpJrCvyvrd3Foigvp9(typeof(ViewAttributes), MqChLOCvm1hT96IOGgUv(0x571EA399 ^ 0x571AAB17));
			array[5] = LinqUtils.NameOf(Expression.Lambda<Func<ViewAttributes, object>>((Expression)PCCCx2Cv9tKNk1GUSXff(parameterExpression, (MethodInfo)u8JRQlCvMMlKDq4DxO49((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }));
			array[6] = (string)MqChLOCvm1hT96IOGgUv(-629844702 ^ -630141328);
			parameterExpression = Expression.Parameter(ANgfdfCvJIUB5hfWbuO5(typeof(ViewAttributes).TypeHandle), (string)MqChLOCvm1hT96IOGgUv(-978351861 ^ -978615931));
			array[7] = LinqUtils.NameOf(Expression.Lambda<Func<ViewAttributes, object>>((Expression)PCCCx2Cv9tKNk1GUSXff(parameterExpression, (MethodInfo)u8JRQlCvMMlKDq4DxO49((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }));
			parameterExpression = Expression.Parameter(ANgfdfCvJIUB5hfWbuO5(typeof(ViewAttributes).TypeHandle), (string)MqChLOCvm1hT96IOGgUv(0x68BBB53E ^ 0x68BFBDB0));
			array[8] = LinqUtils.NameOf(Expression.Lambda<Func<ViewAttributes, object>>(Expression.Convert((Expression)PCCCx2Cv9tKNk1GUSXff(parameterExpression, (MethodInfo)u8JRQlCvMMlKDq4DxO49((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), ANgfdfCvJIUB5hfWbuO5(typeof(object).TypeHandle)), new ParameterExpression[1] { parameterExpression }));
			parameterExpression = Expression.Parameter(typeof(ViewAttributes), (string)MqChLOCvm1hT96IOGgUv(-521266112 ^ -521530162));
			array[9] = LinqUtils.NameOf(Expression.Lambda<Func<ViewAttributes, object>>((Expression)PCCCx2Cv9tKNk1GUSXff(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }));
			parameterExpression = (ParameterExpression)A9UpJrCvyvrd3Foigvp9(ANgfdfCvJIUB5hfWbuO5(typeof(ViewAttributes).TypeHandle), MqChLOCvm1hT96IOGgUv(0x66F566B6 ^ 0x66F16E38));
			array[10] = LinqUtils.NameOf(Expression.Lambda<Func<ViewAttributes, object>>((Expression)AwkQZnCvdOPislPq5JJ8(PCCCx2Cv9tKNk1GUSXff(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), ANgfdfCvJIUB5hfWbuO5(typeof(object).TypeHandle)), new ParameterExpression[1] { parameterExpression }));
			parameterExpression = (ParameterExpression)A9UpJrCvyvrd3Foigvp9(ANgfdfCvJIUB5hfWbuO5(typeof(ViewAttributes).TypeHandle), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1837662597 ^ -1837926667));
			array[11] = LinqUtils.NameOf(Expression.Lambda<Func<ViewAttributes, object>>((Expression)PCCCx2Cv9tKNk1GUSXff(parameterExpression, (MethodInfo)u8JRQlCvMMlKDq4DxO49((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }));
			parameterExpression = (ParameterExpression)A9UpJrCvyvrd3Foigvp9(ANgfdfCvJIUB5hfWbuO5(typeof(ViewAttributes).TypeHandle), MqChLOCvm1hT96IOGgUv(0x2ACE37D ^ 0x2A8EBF3));
			array[12] = LinqUtils.NameOf(Expression.Lambda<Func<ViewAttributes, object>>(Expression.Property(parameterExpression, (MethodInfo)u8JRQlCvMMlKDq4DxO49((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }));
			parameterExpression = (ParameterExpression)A9UpJrCvyvrd3Foigvp9(ANgfdfCvJIUB5hfWbuO5(typeof(ViewAttributes).TypeHandle), MqChLOCvm1hT96IOGgUv(-1638402543 ^ -1638662497));
			array[13] = LinqUtils.NameOf(Expression.Lambda<Func<ViewAttributes, object>>((Expression)PCCCx2Cv9tKNk1GUSXff(parameterExpression, (MethodInfo)u8JRQlCvMMlKDq4DxO49((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }));
			array[14] = (string)MqChLOCvm1hT96IOGgUv(0x17ADCCD8 ^ 0x17A857AE);
			array[15] = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-787452571 ^ -787089677);
			return array;
		}

		public AttributesChangeableProperties()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			gVK6kmCvlmGa9TuMbA2i();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static object MqChLOCvm1hT96IOGgUv(int _0020)
		{
			return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}

		internal static object A9UpJrCvyvrd3Foigvp9(Type P_0, object P_1)
		{
			return Expression.Parameter(P_0, (string)P_1);
		}

		internal static object u8JRQlCvMMlKDq4DxO49(RuntimeMethodHandle P_0)
		{
			return MethodBase.GetMethodFromHandle(P_0);
		}

		internal static Type ANgfdfCvJIUB5hfWbuO5(RuntimeTypeHandle P_0)
		{
			return Type.GetTypeFromHandle(P_0);
		}

		internal static object PCCCx2Cv9tKNk1GUSXff(object P_0, object P_1)
		{
			return Expression.Property((Expression)P_0, (MethodInfo)P_1);
		}

		internal static object AwkQZnCvdOPislPq5JJ8(object P_0, Type P_1)
		{
			return Expression.Convert((Expression)P_0, P_1);
		}

		internal static bool XJ8x25Cvxd1upcSKPsoj()
		{
			return fF1veSCv7FG7ne6j4JQ8 == null;
		}

		internal static AttributesChangeableProperties uXtD1BCv0xQOjp6C3bB3()
		{
			return (AttributesChangeableProperties)fF1veSCv7FG7ne6j4JQ8;
		}

		internal static void gVK6kmCvlmGa9TuMbA2i()
		{
			SingletonReader.JJCZtPuTvSt();
		}
	}

	private Guid? propertyUid;

	internal static PropertyViewItem aybM4qoNgFmvTBSZEtk1;

	[XmlElement("Property")]
	public virtual Guid PropertyUid
	{
		get
		{
			//Discarded unreachable code: IL_0045, IL_0054, IL_007e, IL_008d, IL_00de
			int num = 4;
			int num2 = num;
			Guid? guid = default(Guid?);
			while (true)
			{
				switch (num2)
				{
				case 8:
					if (!uid.HasValue)
					{
						num2 = 7;
						break;
					}
					goto case 5;
				case 6:
					if (guid.HasValue)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
						{
							num2 = 1;
						}
						break;
					}
					goto default;
				case 5:
					propertyUid = Uid;
					num2 = 2;
					break;
				default:
					return Guid.Empty;
				case 1:
					return guid.GetValueOrDefault();
				case 4:
					if (propertyUid.HasValue)
					{
						num2 = 3;
						break;
					}
					goto case 8;
				case 2:
				case 3:
				case 7:
					guid = propertyUid;
					num2 = 6;
					break;
				}
			}
		}
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
					propertyUid = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[XmlElement("Attributes")]
	[EleWise.ELMA.Globalization.Localizable]
	[EleWise.ELMA.Model.Transformations.ChangeableProperty(typeof(AttributesChangeableProperties))]
	public ViewAttributes Attributes
	{
		[CompilerGenerated]
		get
		{
			return _003CAttributes_003Ek__BackingField;
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
					_003CAttributes_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
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

	[DefaultValue(false)]
	public bool IsCustom
	{
		[CompilerGenerated]
		get
		{
			return _003CIsCustom_003Ek__BackingField;
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
					_003CIsCustom_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[EleWise.ELMA.Model.Transformations.ChangeableProperty]
	[DefaultValue("")]
	public string CustomViewName
	{
		[CompilerGenerated]
		get
		{
			return _003CCustomViewName_003Ek__BackingField;
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
					_003CCustomViewName_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
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

	[XmlIgnore]
	public RootViewItem ParentPropertyViewItem
	{
		get
		{
			//Discarded unreachable code: IL_006f, IL_007e, IL_008e, IL_00d6, IL_011b
			int num = 1;
			int num2 = num;
			RootViewItem rootViewItem = default(RootViewItem);
			while (true)
			{
				switch (num2)
				{
				case 5:
					if (!(rootViewItem is FormViewItem))
					{
						num2 = 6;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
						{
							num2 = 5;
						}
						break;
					}
					goto case 2;
				case 9:
					if (rootViewItem is PropertyViewItem)
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 5;
				case 4:
				case 6:
					rootViewItem = (RootViewItem)mTVMiPoNUHgZtWb97kwG(rootViewItem);
					num2 = 3;
					break;
				default:
					if (rootViewItem == null)
					{
						num2 = 7;
						break;
					}
					goto case 9;
				case 2:
				case 7:
				case 8:
					return rootViewItem;
				case 1:
					rootViewItem = base.Parent;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[EleWise.ELMA.Model.Transformations.ChangeableProperty]
	[DefaultValue(false)]
	public bool EditableInTable
	{
		[CompilerGenerated]
		get
		{
			return _003CEditableInTable_003Ek__BackingField;
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
					_003CEditableInTable_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
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

	[DefaultValue(false)]
	public bool OverrideEditableInTable
	{
		[CompilerGenerated]
		get
		{
			return _003COverrideEditableInTable_003Ek__BackingField;
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
					_003COverrideEditableInTable_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public List<Guid> PropertyParents { get; set; }

	[DefaultValue(FocusableType.None)]
	[EleWise.ELMA.Model.Transformations.ChangeableProperty]
	public FocusableType FocusableType
	{
		[CompilerGenerated]
		get
		{
			return _003CFocusableType_003Ek__BackingField;
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
					_003CFocusableType_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
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

	public override bool? ReadOnly
	{
		get
		{
			bool? result = Attributes?.ReadOnly;
			if (!result.HasValue)
			{
				if (!(base.Parent is PropertyViewItem))
				{
					return null;
				}
				return false;
			}
			return result;
		}
		set
		{
			if (Attributes == null)
			{
				Attributes = new ViewAttributes();
			}
			Attributes.ReadOnly = value;
		}
	}

	[EleWise.ELMA.Model.Transformations.ChangeableProperty]
	[XmlElement("TypeSettings")]
	public PropertiesContainer TypeSettings
	{
		[CompilerGenerated]
		get
		{
			return _003CTypeSettings_003Ek__BackingField;
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
					_003CTypeSettings_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	private bool IsReadOnlyProperty(PropertyViewItem property)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (!oS5NxroNYkl76P6SYMje(property))
				{
					return false;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
				{
					num2 = 0;
				}
				continue;
			}
			return property.GetAllProperties(ignoreHide: false).All(delegate(PropertyViewItem p)
			{
				//Discarded unreachable code: IL_003b, IL_004a
				int num3 = 1;
				int num4 = num3;
				while (true)
				{
					switch (num4)
					{
					case 2:
						return IsReadOnlyProperty(p);
					case 3:
						return false;
					case 1:
						if (!p.IsCustom)
						{
							num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
							{
								num4 = 0;
							}
							break;
						}
						goto case 2;
					default:
						if (t54Mwqo3BhZiBO0fg8HZ(p))
						{
							num4 = 3;
							break;
						}
						goto case 2;
					}
				}
			});
		}
	}

	public PropertyViewItem()
	{
		//Discarded unreachable code: IL_002a
		HyKig9oNLfba1EIREhra();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
		{
			num = 3;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 4:
				TypeSettings = new PropertiesContainer();
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
				{
					num = 1;
				}
				break;
			case 3:
				Attributes = new ViewAttributes();
				num = 4;
				break;
			case 0:
				return;
			case 1:
			{
				CustomViewName = "";
				int num2 = 2;
				num = num2;
				break;
			}
			case 2:
				PropertyParents = new List<Guid>();
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public virtual bool IsMainPropertyViewItem()
	{
		//Discarded unreachable code: IL_006d, IL_007c, IL_008c, IL_009b
		int num = 13;
		PropertyViewItem[] equalPropertiesFromForm = default(PropertyViewItem[]);
		FormViewItem formViewItem = default(FormViewItem);
		PropertyViewItem propertyViewItem = default(PropertyViewItem);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 12:
					return false;
				case 5:
					if (equalPropertiesFromForm.Length == 1)
					{
						num2 = 10;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
						{
							num2 = 8;
						}
						continue;
					}
					goto IL_00e2;
				case 13:
					if (!IsReadOnlyProperty(this))
					{
						formViewItem = base.FormViewItem;
						num2 = 7;
					}
					else
					{
						num2 = 12;
					}
					continue;
				case 4:
					return true;
				default:
					if (!oS5NxroNYkl76P6SYMje(propertyViewItem))
					{
						num2 = 6;
						continue;
					}
					goto case 11;
				case 11:
					return IsReadOnly();
				case 6:
					return false;
				case 2:
					return true;
				case 8:
					equalPropertiesFromForm = GetEqualPropertiesFromForm(formViewItem);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0)
					{
						num2 = 1;
					}
					continue;
				case 3:
					if (propertyViewItem == null)
					{
						return false;
					}
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
					{
						num2 = 9;
					}
					continue;
				case 10:
					if (equalPropertiesFromForm[0] == this)
					{
						num2 = 4;
						continue;
					}
					goto IL_00e2;
				case 7:
					if (formViewItem != null)
					{
						num2 = 8;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
						{
							num2 = 4;
						}
						continue;
					}
					goto case 2;
				case 9:
					if (propertyViewItem == this)
					{
						return true;
					}
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0)
					{
						num2 = 0;
					}
					continue;
				case 1:
					{
						if (equalPropertiesFromForm.Length != 0)
						{
							break;
						}
						goto case 4;
					}
					IL_00e2:
					propertyViewItem = equalPropertiesFromForm.FirstOrDefault(delegate(PropertyViewItem p)
					{
						//Discarded unreachable code: IL_005a, IL_008f, IL_009e
						int num3 = 4;
						while (true)
						{
							int num4 = num3;
							while (true)
							{
								switch (num4)
								{
								case 2:
									if (p is PropertyDescriptionViewItem)
									{
										num4 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
										{
											num4 = 0;
										}
										continue;
									}
									goto case 1;
								case 4:
									if (p is PropertyCaptionViewItem)
									{
										break;
									}
									goto case 2;
								case 1:
									return !IsReadOnlyProperty(p);
								default:
									return false;
								}
								break;
							}
							num3 = 3;
						}
					});
					num2 = 3;
					continue;
				}
				break;
			}
			num = 5;
		}
	}

	private static string GetKeyString(IEnumerable<Guid> uids)
	{
		return uids.Aggregate("", (string current, Guid item) => current + item.ToString(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1921202237 ^ -1921206323)));
	}

	[IteratorStateMachine(typeof(_003CFullProperyUid_003Ed__9))]
	internal IEnumerable<Guid> FullProperyUid()
	{
		//yield-return decompiler failed: Missing enumeratorCtor.Body
		return new _003CFullProperyUid_003Ed__9(-2)
		{
			_003C_003E4__this = this
		};
	}

	internal PropertyViewItem[] GetEqualPropertiesFromForm(FormViewItem formViewItem)
	{
		int num = 2;
		int num2 = num;
		PropertyViewItem[] value = default(PropertyViewItem[]);
		_003C_003Ec__DisplayClass10_0 _003C_003Ec__DisplayClass10_ = default(_003C_003Ec__DisplayClass10_0);
		while (true)
		{
			switch (num2)
			{
			default:
				return value;
			case 1:
				_003C_003Ec__DisplayClass10_.formViewItem = formViewItem;
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				_003C_003Ec__DisplayClass10_ = new _003C_003Ec__DisplayClass10_0();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				if (!ContextVars.GetOrAdd(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1633514411 ^ -1633622765), _003C_003Ec__DisplayClass10_._003CGetEqualPropertiesFromForm_003Eb__0).TryGetValue(GetKeyString(FullProperyUid()), out value))
				{
					return new PropertyViewItem[0];
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public virtual bool ShouldSerializePropertyParents()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return PropertyParents.Count > 0;
			case 1:
				if (PropertyParents == null)
				{
					return false;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public override bool ShouldSerializeReadOnly()
	{
		return false;
	}

	public override void CopyFrom(ViewItem viewItem)
	{
		//Discarded unreachable code: IL_0071, IL_0080
		int num = 5;
		PropertyViewItem propertyViewItem = default(PropertyViewItem);
		while (true)
		{
			int num2 = num;
			ViewAttributes attributes;
			while (true)
			{
				switch (num2)
				{
				case 4:
					propertyViewItem = viewItem as PropertyViewItem;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					return;
				case 3:
					return;
				case 1:
					if (propertyViewItem == null)
					{
						num2 = 2;
						break;
					}
					goto default;
				case 5:
					base.CopyFrom(viewItem);
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
					{
						num2 = 3;
					}
					break;
				default:
					attributes = ((propertyViewItem.Attributes != null) ? ClassSerializationHelper.CloneObjectByXml((ViewAttributes)oiT7Y5oNsuVeOggjnnWK(propertyViewItem)) : null);
					goto end_IL_0012;
				case 6:
					TypeSettings = ((propertyViewItem.TypeSettings != null) ? ClassSerializationHelper.CloneObjectByXml((PropertiesContainer)VDv4UBoNcGXt43Giyvqx(propertyViewItem)) : null);
					num2 = 3;
					break;
				}
				continue;
				end_IL_0012:
				break;
			}
			Attributes = attributes;
			num = 6;
		}
	}

	public override void ReplacePropertyUid(Dictionary<Guid, Guid> ReplaceContextVar)
	{
		base.ReplacePropertyUid(ReplaceContextVar);
		Guid value = Guid.Empty;
		if (ReplaceContextVar.TryGetValue(PropertyUid, out value))
		{
			PropertyUid = value;
		}
		if (base.Parent is PropertyViewItem propertyViewItem && ReplaceContextVar.TryGetValue(propertyViewItem.PropertyUid, out value))
		{
			propertyViewItem.PropertyUid = value;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeTypeSettings()
	{
		//Discarded unreachable code: IL_0065, IL_0074
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (TypeSettings == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			case 2:
				return TypeSettings.GetProperties().Any();
			default:
				return false;
			}
		}
	}

	public virtual void TypeSettingsAction(TypeSettings typeSettings)
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
				u4a7vioNzHn1GJQfrfLj(typeSettings, TypeSettings);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public override bool IsValid(ViewType viewType, ViewItem parentViewItem)
	{
		//Discarded unreachable code: IL_007f, IL_008e, IL_00b3, IL_00c2, IL_00d1, IL_011b, IL_012a
		int num = 5;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 8:
				if (!parentViewItem.IsChildValid(this))
				{
					num2 = 9;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
					{
						num2 = 9;
					}
					break;
				}
				goto case 2;
			case 7:
				if (parentViewItem != null)
				{
					num2 = 8;
					break;
				}
				goto case 4;
			case 2:
				if (parentViewItem is ColumnViewItem)
				{
					num2 = 6;
					break;
				}
				goto default;
			case 1:
				return parentViewItem is PropertyViewItem;
			case 3:
			case 6:
				return true;
			case 9:
				return false;
			case 4:
				return true;
			default:
				if (parentViewItem is CellViewItem)
				{
					num2 = 3;
					break;
				}
				goto case 1;
			case 5:
				if (Hide)
				{
					num2 = 4;
					break;
				}
				goto case 7;
			}
		}
	}

	protected internal override void SetReadOnly()
	{
		base.SetReadOnly();
	}

	protected internal override void SetReadOnly(bool value)
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
				base.SetReadOnly(value);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	protected internal override void SetReadOnly(bool value, bool recursive)
	{
		//Discarded unreachable code: IL_0079, IL_00aa, IL_00b9, IL_0142
		int num = 9;
		bool? readOnly = default(bool?);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 5:
					ReadOnly = value;
					num2 = 10;
					continue;
				case 1:
					EditableInTable = false;
					num2 = 2;
					continue;
				case 4:
					readOnly = base.FormViewItem.ReadOnly;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc != 0)
					{
						num2 = 0;
					}
					continue;
				case 7:
					return;
				case 3:
					Attributes.ReadOnly = value;
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
					{
						num2 = 1;
					}
					continue;
				case 2:
					return;
				case 10:
					if (!value)
					{
						return;
					}
					num2 = 4;
					continue;
				default:
					if (readOnly.HasValue)
					{
						num2 = 11;
						continue;
					}
					break;
				case 9:
					base.SetReadOnly(value, recursive);
					num2 = 8;
					continue;
				case 8:
					if (Attributes != null)
					{
						num2 = 3;
						continue;
					}
					goto case 5;
				case 11:
					if (!readOnly.GetValueOrDefault())
					{
						break;
					}
					goto case 1;
				case 6:
					break;
				}
				break;
			}
			num = 7;
		}
	}

	public override bool IsReadOnly()
	{
		//Discarded unreachable code: IL_003e, IL_005a, IL_0069
		int num = 3;
		int num2 = num;
		bool? flag = default(bool?);
		bool? flag3 = default(bool?);
		while (true)
		{
			bool? flag2;
			switch (num2)
			{
			case 2:
				flag = null;
				num2 = 5;
				break;
			case 1:
			case 4:
				return base.IsReadOnly();
			default:
				return true;
			case 6:
				if (!flag3.HasValue)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
					{
						num2 = 4;
					}
					break;
				}
				if (flag3.GetValueOrDefault())
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 1;
			case 3:
			{
				ViewAttributes attributes = Attributes;
				if (attributes == null)
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
					{
						num2 = 1;
					}
					break;
				}
				flag2 = attributes.ReadOnly;
				goto IL_00db;
			}
			case 5:
				{
					flag2 = flag;
					goto IL_00db;
				}
				IL_00db:
				flag3 = flag2;
				num2 = 6;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public override bool IsChildValid(ViewItem childViewItem)
	{
		return childViewItem is PropertyViewItem;
	}

	protected internal override void SetVisible(bool visible)
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
				base.SetVisible(visible);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	protected internal override void SetVisible(bool visible, bool recursive)
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
				base.SetVisible(visible, recursive);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				XfSHGHo3FIiSL0u2b0vT(Attributes, visible);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public override bool IsVisible()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return base.IsVisible();
			case 2:
			{
				ViewAttributes attributes = Attributes;
				if (attributes == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
					{
						num2 = 1;
					}
					continue;
				}
				if (!attributes.Visible)
				{
					return false;
				}
				break;
			}
			case 1:
				break;
			}
			num2 = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
			{
				num2 = 0;
			}
		}
	}

	internal static bool oS5NxroNYkl76P6SYMje(object P_0)
	{
		return ((RootViewItem)P_0).IsReadOnly();
	}

	internal static bool C9SSFOoN5OAvok4RMXw1()
	{
		return aybM4qoNgFmvTBSZEtk1 == null;
	}

	internal static PropertyViewItem D22TjAoNj4kVkDs8ivpw()
	{
		return aybM4qoNgFmvTBSZEtk1;
	}

	internal static void HyKig9oNLfba1EIREhra()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object mTVMiPoNUHgZtWb97kwG(object P_0)
	{
		return ((ViewItem)P_0).Parent;
	}

	internal static object oiT7Y5oNsuVeOggjnnWK(object P_0)
	{
		return ((PropertyViewItem)P_0).Attributes;
	}

	internal static object VDv4UBoNcGXt43Giyvqx(object P_0)
	{
		return ((PropertyViewItem)P_0).TypeSettings;
	}

	internal static void u4a7vioNzHn1GJQfrfLj(object P_0, object P_1)
	{
		((TypeSettings)P_0).SetTypeSettings((PropertiesContainer)P_1);
	}

	internal static void XfSHGHo3FIiSL0u2b0vT(object P_0, bool value)
	{
		((ViewAttributes)P_0).Visible = value;
	}

	internal static bool t54Mwqo3BhZiBO0fg8HZ(object P_0)
	{
		return ((ViewItem)P_0).Hide;
	}
}
