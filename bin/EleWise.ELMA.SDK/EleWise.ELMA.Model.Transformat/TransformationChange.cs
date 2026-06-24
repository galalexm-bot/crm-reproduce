using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using EleWise.ELMA.Helpers;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Transformations
{
	[Serializable]
	[DebuggerDisplay("ItemUid: {Uid}, PropertyName: {PropertyName}, Value: {Value}", Type = "Change")]
	[DebuggerTypeProxy(typeof(TransformationChange<, , , >.DebugView))]
	[XmlInclude(typeof(TransformationChangeRemoveValue))]
	public class TransformationChange<TItem, TTransformation, TUid, TNullUid> : BaseTransformation<TItem, TUid> where TItem : class where TTransformation : Transformation<TItem, TTransformation, TUid, TNullUid>, new()
	{
		public sealed class DebugView
		{
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private readonly TransformationChange<TItem, TTransformation, TUid, TNullUid> transformation;

			private static object Li3df4CB5tlH4m8ZN4bJ;

			public TUid ItemUid => transformation.Uid;

			public string PropertyName => transformation.PropertyName;

			public object Value => transformation.Value;

			public DebugView(TransformationChange<TItem, TTransformation, TUid, TNullUid> transformation)
			{
				SingletonReader.JJCZtPuTvSt();
				base._002Ector();
				this.transformation = transformation;
			}

			internal static bool W3CjLwCBjCkXnAElvIpF()
			{
				return Li3df4CB5tlH4m8ZN4bJ == null;
			}

			internal static object dE3srpCBYSFKhAnbHMvH()
			{
				return Li3df4CB5tlH4m8ZN4bJ;
			}
		}

		internal static object a7UVZkWUkrB3IKt3U8w7;

		public string PropertyName
		{
			[CompilerGenerated]
			get
			{
				return _003CPropertyName_003Ek__BackingField;
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
						_003CPropertyName_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 != 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public object Value
		{
			[CompilerGenerated]
			get
			{
				return _003CValue_003Ek__BackingField;
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
						_003CValue_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		[XmlAttribute("Type")]
		[DefaultValue("")]
		public string TypeName
		{
			[CompilerGenerated]
			get
			{
				return _003CTypeName_003Ek__BackingField;
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
						_003CTypeName_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0)
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
		public bool Localizable
		{
			[CompilerGenerated]
			get
			{
				return _003CLocalizable_003Ek__BackingField;
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
						_003CLocalizable_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		private static bool CheckProperty(PropertyInfo property, string[] propertyNames)
		{
			//Discarded unreachable code: IL_00a5, IL_01b7
			int num = 4;
			int num2 = num;
			object[] customAttributes = default(object[]);
			_003C_003Ec__DisplayClass17_0 _003C_003Ec__DisplayClass17_ = default(_003C_003Ec__DisplayClass17_0);
			List<string> list = default(List<string>);
			while (true)
			{
				switch (num2)
				{
				case 2:
					if (!customAttributes.Any())
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
						{
							num2 = 9;
						}
						break;
					}
					if (propertyNames.Length != 0)
					{
						num2 = 5;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e != 0)
						{
							num2 = 7;
						}
						break;
					}
					goto default;
				case 4:
					_003C_003Ec__DisplayClass17_ = new _003C_003Ec__DisplayClass17_0();
					num2 = 3;
					break;
				case 5:
					return list.Any(_003C_003Ec__DisplayClass17_._003CCheckProperty_003Eb__2);
				case 12:
					if (string.IsNullOrEmpty(propertyNames[0]))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 6;
				case 1:
					return true;
				case 13:
					if (!list.Contains(_003C_003Ec__DisplayClass17_.shortPropertyName))
					{
						_003C_003Ec__DisplayClass17_.shortPropertyName += z2jc63fLkugS1X8Q9N.tE1kD1vbB(-488881205 ^ -488875761);
						num2 = 5;
						break;
					}
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
					{
						num2 = 1;
					}
					break;
				default:
					return true;
				case 10:
					_003C_003Ec__DisplayClass17_.shortPropertyName = string.Join(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1FFEF86A ^ 0x1FFEE2AE), propertyNames);
					num2 = 11;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
					{
						num2 = 9;
					}
					break;
				case 3:
					customAttributes = property.GetCustomAttributes(typeof(ChangeablePropertyAttribute), inherit: true);
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
					{
						num2 = 0;
					}
					break;
				case 7:
					if (propertyNames.Length == 1)
					{
						num2 = 12;
						break;
					}
					goto case 6;
				case 9:
					return false;
				case 6:
					if (!property.PropertyType.IsInheritOrSame<IPropertiesContainer>())
					{
						num2 = 10;
						break;
					}
					goto default;
				case 11:
					list = (from ChangeablePropertyAttribute a in customAttributes
						where a.SubProperties != null
						select a).SelectMany((ChangeablePropertyAttribute a) => a.SubProperties).ToList();
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
					{
						num2 = 13;
					}
					break;
				}
			}
		}

		public override void Apply(TItem formViewItem)
		{
			ApplyReturn(formViewItem);
		}

		public TItem ApplyReturn(TItem rootItem, TTransformation instance = null)
		{
			return StaticApply(rootItem, base.Uid, PropertyName, Value, instance);
		}

		public static TItem StaticApply(TItem formViewItem, TUid uid, string propertyName, object value, TTransformation instance = null)
		{
			TItem val = (instance ?? Transformation<TItem, TTransformation, TUid, TNullUid>.Instance).FindItem(formViewItem, uid);
			if (val == null)
			{
				return null;
			}
			string[] source = propertyName.Split('.');
			string text = source.FirstOrDefault();
			if (text == null)
			{
				return null;
			}
			PropertyInfo reflectionProperty = val.GetType().GetReflectionProperty(text);
			if (reflectionProperty == null)
			{
				return null;
			}
			source = source.Skip(1).ToArray();
			if (!CheckProperty(reflectionProperty, source))
			{
				return null;
			}
			object obj = val;
			if (reflectionProperty.GetValue(obj, null) is IPropertiesContainer propertiesContainer && source.Length == 1)
			{
				if (value is TransformationChangeRemoveValue)
				{
					propertiesContainer.RemoveProperty(source[0]);
				}
				else
				{
					propertiesContainer.SetPropertyValue(source[0], null, value);
				}
				return val;
			}
			string[] array = source;
			foreach (string name in array)
			{
				obj = reflectionProperty.GetValue(obj, null);
				if (obj == null)
				{
					return null;
				}
				reflectionProperty = obj.GetType().GetReflectionProperty(name);
				if (reflectionProperty == null)
				{
					return null;
				}
			}
			if (!reflectionProperty.PropertyType.IsInstanceOfType(value) && value is IConvertible)
			{
				TypeConverter converter = TypeDescriptor.GetConverter(reflectionProperty.PropertyType);
				if (converter.CanConvertFrom(value.GetType()))
				{
					value = converter.ConvertFrom(value);
				}
			}
			reflectionProperty.SetValue(obj, value, null);
			return val;
		}

		public override IEnumerable<string> GetLocalizableStrings()
		{
			List<string> list = new List<string>();
			IEnumerable<string> localizableStrings = base.GetLocalizableStrings();
			if (localizableStrings != null)
			{
				list.AddRange(localizableStrings);
			}
			StaticGetLocalizableStrings(list, Localizable, Value);
			return list;
		}

		public static void StaticGetLocalizableStrings(List<string> allStrings, bool Localizable, object Value)
		{
			if (Localizable && Value is string && !string.IsNullOrEmpty((string)Value) && !allStrings.Contains((string)Value))
			{
				allStrings.Add((string)Value);
			}
		}

		public override void ApplyLocalization()
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					base.ApplyLocalization();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
					{
						num2 = 0;
					}
					break;
				default:
					Value = StaticApplyLocalization(Localizable, Value);
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 != 0)
					{
						num2 = 2;
					}
					break;
				case 2:
					return;
				}
			}
		}

		public static object StaticApplyLocalization(bool Localizable, object Value)
		{
			//Discarded unreachable code: IL_00a2, IL_00b1
			int num = 4;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					if (string.IsNullOrEmpty((string)Value))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
						{
							num2 = 1;
						}
						continue;
					}
					return SR.T((string)Value);
				case 2:
					if (Value is string)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				case 4:
					if (!Localizable)
					{
						num2 = 3;
						continue;
					}
					goto case 2;
				case 1:
				case 3:
					break;
				}
				break;
			}
			return Value;
		}

		public TransformationChange()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			SingletonReader.JJCZtPuTvSt();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static bool ogGv8PWUnbfsCPAwp7XX()
		{
			return a7UVZkWUkrB3IKt3U8w7 == null;
		}

		internal static object Lktb02WUOpwQ94TeFfSx()
		{
			return a7UVZkWUkrB3IKt3U8w7;
		}
	}
}
namespace EleWise.ELMA.Model.Transformations.Struct
{
	[Serializable]
	public class TransformationChange<TItem, TTransformation, TUid> : TransformationChange<TItem, TTransformation, TUid, TUid?> where TItem : class where TTransformation : Transformation<TItem, TTransformation, TUid>, new()where TUid : struct
	{
		private static object IAXTPTWUJCthqZ3QYCEw;

		public TransformationChange()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			SingletonReader.JJCZtPuTvSt();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static bool tgutwOWU91q8Q3ElyyjJ()
		{
			return IAXTPTWUJCthqZ3QYCEw == null;
		}

		internal static object nvR95OWUdm8ZMSFdjLjT()
		{
			return IAXTPTWUJCthqZ3QYCEw;
		}
	}
}
namespace EleWise.ELMA.Model.Transformations.Class
{
	[Serializable]
	public class TransformationChange<TItem, TTransformation, TUid> : TransformationChange<TItem, TTransformation, TUid, TUid> where TItem : class where TTransformation : Transformation<TItem, TTransformation, TUid>, new()where TUid : class
	{
		internal static object XAxJ3VWsEtppGTLLSQVN;

		public TransformationChange()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			SingletonReader.JJCZtPuTvSt();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static bool Fdp0RmWsfw5Us1krq7mB()
		{
			return XAxJ3VWsEtppGTLLSQVN == null;
		}

		internal static object liVQgQWsQ7U2dWfnmlIe()
		{
			return XAxJ3VWsEtppGTLLSQVN;
		}
	}
}
