using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Globalization;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Transformations;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.XmlSerializers;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Views;

[Serializable]
[EleWise.ELMA.Model.Attributes.DisplayName(typeof(__Resources_ViewItem), "DisplayName")]
[Component]
[DebuggerTypeProxy(typeof(DebugView))]
[XmlUnknownTypesSupport]
public abstract class ViewItem : IXsiType, IXsiRoot
{
	public sealed class DebugView
	{
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly ViewItem viewItem;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private ClassMetadata metadata;

		internal static DebugView UmO4KqC80r22f8XnLb2C;

		public Guid? Uid
		{
			get
			{
				return viewItem.uid;
			}
			set
			{
				viewItem.uid = value;
			}
		}

		public string Name
		{
			get
			{
				return viewItem.Name;
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
						ThSmQmC89KV6hn9NuOpZ(viewItem, value);
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public bool Hide
		{
			get
			{
				return yQRebMC8d4L7BXWjQie8(viewItem);
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
						viewItem.Hide = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public RootViewItem Parent => (RootViewItem)prKlQkC8lhNiFIIdlw2a(viewItem);

		public ClassMetadata Metadata
		{
			get
			{
				//Discarded unreachable code: IL_0081
				int num = 5;
				int num2 = num;
				Guid? metadataUid = default(Guid?);
				ClassMetadata classMetadata = default(ClassMetadata);
				ClassMetadata classMetadata2;
				while (true)
				{
					switch (num2)
					{
					default:
						metadataUid = ((RootViewItem)CFNHTIC8rVaOrVJfIIrS(viewItem)).MetadataUid;
						classMetadata = (metadata = (ClassMetadata)MetadataLoader.LoadMetadata(metadataUid.Value));
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
						{
							num2 = 1;
						}
						continue;
					case 4:
						if (metadataUid.HasValue)
						{
							num2 = 2;
							continue;
						}
						goto case 3;
					case 5:
						metadataUid = ((RootViewItem)CFNHTIC8rVaOrVJfIIrS(viewItem)).MetadataUid;
						num2 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0)
						{
							num2 = 4;
						}
						continue;
					case 3:
						return null;
					case 2:
						classMetadata2 = metadata;
						if (classMetadata2 == null)
						{
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
							{
								num2 = 0;
							}
							continue;
						}
						break;
					case 1:
						classMetadata2 = classMetadata;
						break;
					}
					break;
				}
				return classMetadata2;
			}
		}

		public DebugView(ViewItem viewItem)
		{
			//Discarded unreachable code: IL_002a, IL_002f
			zq6rNUC8MdZ8jwCUg5g0();
			base._002Ector();
			int num = 2;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
			{
				num = 0;
			}
			while (true)
			{
				switch (num)
				{
				case 2:
					if (viewItem == null)
					{
						num = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
						{
							num = 0;
						}
						break;
					}
					this.viewItem = viewItem;
					num = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
					{
						num = 1;
					}
					break;
				case 1:
					return;
				default:
					throw new ArgumentNullException((string)n2XHt6C8J3g7dQcqCd9k(0x6DC147B0 ^ 0x6DC1E6E8));
				}
			}
		}

		internal static void zq6rNUC8MdZ8jwCUg5g0()
		{
			SingletonReader.JJCZtPuTvSt();
		}

		internal static object n2XHt6C8J3g7dQcqCd9k(int _0020)
		{
			return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}

		internal static bool Hib3jwC8mgZMCZ5oeCLj()
		{
			return UmO4KqC80r22f8XnLb2C == null;
		}

		internal static DebugView aqDqOSC8yv5Lw2lC3q9d()
		{
			return UmO4KqC80r22f8XnLb2C;
		}

		internal static void ThSmQmC89KV6hn9NuOpZ(object P_0, object P_1)
		{
			((ViewItem)P_0).Name = (string)P_1;
		}

		internal static bool yQRebMC8d4L7BXWjQie8(object P_0)
		{
			return ((ViewItem)P_0).Hide;
		}

		internal static object prKlQkC8lhNiFIIdlw2a(object P_0)
		{
			return ((ViewItem)P_0).Parent;
		}

		internal static object CFNHTIC8rVaOrVJfIIrS(object P_0)
		{
			return ((ViewItem)P_0).FormViewItem;
		}
	}

	internal Guid? uid;

	private static readonly ConcurrentDictionary<string, object> CompiledProperties;

	private static ViewItem QuoKito36f9JlPbwZX82;

	[EleWise.ELMA.Model.Transformations.ChangeableProperty]
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

	[XmlElement("Uid")]
	public virtual Guid Uid
	{
		get
		{
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					if (!uid.HasValue)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
						{
							num2 = 1;
						}
						continue;
					}
					break;
				case 1:
					uid = OrOEawo3x2oZKss0EcDl();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			}
			return uid.Value;
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
					uid = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[DefaultValue(false)]
	[XmlElement("Hide")]
	public virtual bool Hide
	{
		[CompilerGenerated]
		get
		{
			return _003CHide_003Ek__BackingField;
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
					_003CHide_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
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

	[XmlElement("HideMode")]
	[DefaultValue(ViewItemHideMode.None)]
	[EleWise.ELMA.Model.Transformations.ChangeableProperty]
	public ViewItemHideMode HideMode
	{
		[CompilerGenerated]
		get
		{
			return _003CHideMode_003Ek__BackingField;
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
					_003CHideMode_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[EleWise.ELMA.Globalization.Localizable]
	public List<ComputedValue> DynamicProperties { get; set; }

	[XmlIgnore]
	public RootViewItem Parent
	{
		[CompilerGenerated]
		get
		{
			return _003CParent_003Ek__BackingField;
		}
		[CompilerGenerated]
		internal set
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
					_003CParent_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[XmlIgnore]
	public ILayoutViewItem ParentLayout => FindParent<ILayoutViewItem>(Parent);

	[XmlIgnore]
	public FormViewItem FormViewItem => FindParent<FormViewItem>(this);

	[XmlIgnore]
	public ViewItem Root
	{
		get
		{
			//Discarded unreachable code: IL_0039, IL_006c
			int num = 1;
			int num2 = num;
			ViewItem viewItem = default(ViewItem);
			while (true)
			{
				switch (num2)
				{
				case 1:
					viewItem = this;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
					{
						num2 = 0;
					}
					break;
				case 5:
					return viewItem;
				default:
					if (d9vNCto3mQ1X1H9etXu5(viewItem) != null)
					{
						num2 = 4;
						break;
					}
					goto case 5;
				case 3:
				case 4:
					viewItem = viewItem.Parent;
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0)
					{
						num2 = 2;
					}
					break;
				}
			}
		}
	}

	[XmlIgnore]
	public ViewItem TransformatedViewItem
	{
		[CompilerGenerated]
		get
		{
			return _003CTransformatedViewItem_003Ek__BackingField;
		}
		[CompilerGenerated]
		private set
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
					_003CTransformatedViewItem_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public virtual IEnumerable<string> GetLocalizableStrings()
	{
		return LocalizableAttributeHelper.GetStrings(this);
	}

	public virtual void ApplyLocalization()
	{
		icKIOTo37CgDZW2uN4SZ(this);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeUid()
	{
		return uid.HasValue;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public virtual bool ShouldSerializeDynamicProperties()
	{
		return lM2d6Ko30qZQPefNdynq(DynamicProperties) > 0;
	}

	public ViewItem Transformate(ViewItemTransformation transformation)
	{
		//Discarded unreachable code: IL_00a3, IL_00b2
		int num = 3;
		int num2 = num;
		ViewItem viewItem = default(ViewItem);
		while (true)
		{
			switch (num2)
			{
			case 1:
			case 5:
				return viewItem;
			default:
				transformation.Apply(viewItem);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
				{
					num2 = 1;
				}
				break;
			case 4:
				if (transformation == null)
				{
					num2 = 5;
					break;
				}
				goto default;
			case 2:
				oGShuAo3ySXhYBx7jCd4(viewItem, this);
				num2 = 4;
				break;
			case 3:
				viewItem = ClassSerializationHelper.CloneObjectByXml(this);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	public bool IsUid(Guid uid)
	{
		//Discarded unreachable code: IL_0061, IL_0070, IL_0099, IL_00a8
		int num = 4;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
					if (WQeVEWo3MHAsIgqU33DY(this) == uid)
					{
						break;
					}
					goto case 1;
				default:
					return RUEtASo3JeFJ4CKYij0B(TransformatedViewItem, uid);
				case 2:
					return false;
				case 3:
					return true;
				case 1:
					if (TransformatedViewItem == null)
					{
						goto end_IL_0012;
					}
					goto default;
				}
				num2 = 3;
				continue;
				end_IL_0012:
				break;
			}
			num = 2;
		}
	}

	public virtual bool IsValid(ViewType viewType, ViewItem parentViewItem)
	{
		return false;
	}

	public virtual bool IsChildValid(ViewItem childViewItem)
	{
		return false;
	}

	public virtual void OnAdding(RootViewItem parent)
	{
	}

	public virtual void OnAdded(RootViewItem parent)
	{
	}

	public virtual void OnRemoving(RootViewItem parent)
	{
	}

	public virtual void OnRemoved(RootViewItem parent)
	{
	}

	protected internal virtual void SetVisible(bool visible)
	{
	}

	public virtual void FullCopyFrom(ViewItem viewItem)
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
				N1F71Oo39q2potfMtJxU(this, viewItem);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public virtual void CopyFrom(ViewItem viewItem)
	{
		//Discarded unreachable code: IL_005f, IL_00f0, IL_0124, IL_01eb, IL_01fe, IL_020d
		int num = 1;
		int num2 = num;
		List<PropertyInfo>.Enumerator enumerator = default(List<PropertyInfo>.Enumerator);
		PropertyInfo current = default(PropertyInfo);
		PropertyInfo property = default(PropertyInfo);
		object value = default(object);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 3:
				try
				{
					while (true)
					{
						IL_016c:
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 5;
							goto IL_006d;
						}
						goto IL_0144;
						IL_006d:
						while (true)
						{
							switch (num3)
							{
							case 11:
								if (!P0ul1Qo3liItHl2UNg6m(current))
								{
									num3 = 10;
									continue;
								}
								goto case 2;
							case 8:
								property = viewItem.GetType().GetProperty((string)jBt1IRo3dXP1xVpd5FOf(current));
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
								{
									num3 = 0;
								}
								continue;
							case 4:
								value = DKK6q3o35GQPaIM8k2vh(property, viewItem, null);
								num3 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
								{
									num3 = 1;
								}
								continue;
							case 2:
								if (KIsopKo3r6KAk4rIfBUh(property))
								{
									num3 = 9;
									continue;
								}
								goto IL_016c;
							case 6:
								break;
							case 1:
								current.SetValue(this, value, null);
								num3 = 7;
								continue;
							case 3:
							case 7:
							case 10:
								goto IL_016c;
							default:
								if (!(property != null))
								{
									num3 = 3;
									continue;
								}
								goto case 11;
							case 9:
								if (gmXYQ5o3gEA74ujnMpgU(current).IsAssignableFrom(property.PropertyType))
								{
									int num4 = 4;
									num3 = num4;
									continue;
								}
								goto IL_016c;
							case 5:
								return;
							}
							break;
						}
						goto IL_0144;
						IL_0144:
						current = enumerator.Current;
						num3 = 8;
						goto IL_006d;
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
					int num5 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
					{
						num5 = 0;
					}
					switch (num5)
					{
					case 0:
						break;
					}
				}
			case 1:
				if (viewItem != null)
				{
					enumerator = GetPropertiesForCopy().ToList().GetEnumerator();
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
					{
						num2 = 3;
					}
				}
				else
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
					{
						num2 = 0;
					}
				}
				break;
			case 2:
				return;
			}
		}
	}

	public virtual void ReplacePropertyUid(Dictionary<Guid, Guid> ReplaceContextVar)
	{
	}

	public ViewItem CreateCopy(bool copyUid)
	{
		//Discarded unreachable code: IL_0082, IL_0091
		int num = 4;
		int num2 = num;
		ViewItem viewItem = default(ViewItem);
		while (true)
		{
			switch (num2)
			{
			case 1:
				dsTJFJo3LoJ8p5USM89O(viewItem, WQeVEWo3MHAsIgqU33DY(this));
				num2 = 5;
				break;
			case 3:
				N1F71Oo39q2potfMtJxU(viewItem, this);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				if (!copyUid)
				{
					num2 = 2;
					break;
				}
				goto case 1;
			case 4:
				viewItem = (ViewItem)TsjjmVo3Y6GpruR5GPBE(DgGua4o3jb3bMQgEeMeH(this));
				num2 = 3;
				break;
			case 2:
			case 5:
				return viewItem;
			}
		}
	}

	public ViewItem Clone()
	{
		return ClassSerializationHelper.CloneObjectByXml(this);
	}

	public virtual void InitNew(ViewItem parent)
	{
		//Discarded unreachable code: IL_0069, IL_00d3, IL_01a4, IL_01b3
		int num = 13;
		string text2 = default(string);
		List<string> otherItemNames = default(List<string>);
		int num3 = default(int);
		string text = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 15:
					text2 = (string)OUb48To3zZBASyZnXZN4(this);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0)
					{
						num2 = 1;
					}
					break;
				case 5:
					otherItemNames = GetOtherItemNames(this, tdtXRdo3cL6IQKnYgBUj(parent));
					num2 = 15;
					break;
				case 1:
					num3 = 1;
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
					{
						num2 = 8;
					}
					break;
				case 10:
					return;
				case 17:
					Name = text;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				case 12:
					return;
				case 8:
				case 14:
					if (num3 <= 1000000)
					{
						num2 = 7;
						break;
					}
					goto case 2;
				case 6:
				case 16:
					if (parent == null)
					{
						return;
					}
					num2 = 11;
					break;
				case 13:
					if (SZ3nRio3U6rFoGKF1JPE(Name))
					{
						if (!xMuU7vo3smW3NKg8jfvm(WQeVEWo3MHAsIgqU33DY(this), Guid.Empty))
						{
							num2 = 6;
							break;
						}
						goto case 3;
					}
					num2 = 12;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
					{
						num2 = 9;
					}
					break;
				case 11:
					if (!SZ3nRio3U6rFoGKF1JPE(Name))
					{
						return;
					}
					num2 = 5;
					break;
				case 2:
					Name = (string)gL2OLIopWRJWo1KxWasn(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-289714582 ^ -289855604), WQeVEWo3MHAsIgqU33DY(this).ToString(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1822890472 ^ -1822942128)));
					num2 = 10;
					break;
				case 3:
					dsTJFJo3LoJ8p5USM89O(this, OrOEawo3x2oZKss0EcDl());
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
					{
						num2 = 16;
					}
					break;
				case 4:
				case 7:
					text = (string)iG1CZmopFQ0GRflZnjum(text2, num3);
					num2 = 9;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 != 0)
					{
						num2 = 5;
					}
					break;
				case 9:
					if (otherItemNames.Contains((string)Do5mqxopBmN5IZre8cdW(text)))
					{
						num3++;
						num = 14;
						goto end_IL_0012;
					}
					num2 = 17;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0)
					{
						num2 = 16;
					}
					break;
				}
				continue;
				end_IL_0012:
				break;
			}
		}
	}

	public virtual bool IsNameValid(string name, out string validationError)
	{
		return IsNameValid(name, null, out validationError);
	}

	public virtual bool IsNameValid(string name, ViewItem parent, out string validationError)
	{
		//Discarded unreachable code: IL_0041, IL_00f2, IL_0101
		int num = 6;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 5:
				if (!SZ3nRio3U6rFoGKF1JPE(name))
				{
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			case 6:
				validationError = string.Empty;
				num2 = 5;
				break;
			case 2:
				validationError = (string)Is6Xapopb9BUfiObmOiv(lIvLSCopoWtUB3AA1bpY(-957824448 ^ -957699148));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
				{
					num2 = 1;
				}
				break;
			case 7:
				validationError = (string)Is6Xapopb9BUfiObmOiv(lIvLSCopoWtUB3AA1bpY(0x3C5338FF ^ 0x3C5152D5));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				return false;
			case 4:
				return true;
			case 1:
				return false;
			case 3:
				if (!GetOtherItemNames(this, (parent != null) ? tdtXRdo3cL6IQKnYgBUj(parent) : Root).Contains((string)Do5mqxopBmN5IZre8cdW(name)))
				{
					num2 = 4;
					break;
				}
				goto case 7;
			}
		}
	}

	public override string ToString()
	{
		int num = 1;
		int num2 = num;
		string text;
		while (true)
		{
			switch (num2)
			{
			case 1:
				text = Name;
				if (text == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			default:
				text = string.Empty;
				break;
			}
			break;
		}
		return text;
	}

	protected ViewItem()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				DynamicProperties = new List<ComputedValue>();
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	protected internal virtual void SetReadOnly()
	{
	}

	protected internal virtual void SetReadOnly(bool value)
	{
	}

	protected virtual string GetDefaultName()
	{
		//Discarded unreachable code: IL_0039, IL_0048, IL_0109
		int num = 1;
		int num2 = num;
		string text = default(string);
		while (true)
		{
			switch (num2)
			{
			case 3:
			case 4:
				return text;
			case 5:
				return (string)nvVtKMopfM1stwydrkbb(text, 0, ErAu54opE17CxlBgaYRb(text) - ((string)lIvLSCopoWtUB3AA1bpY(--1867379187 ^ 0x6F4FCF75)).Length);
			case 1:
				text = (string)jBt1IRo3dXP1xVpd5FOf(DgGua4o3jb3bMQgEeMeH(this));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				if (text.EndsWith((string)lIvLSCopoWtUB3AA1bpY(0x6A81B9B4 ^ 0x6A838732)))
				{
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 3;
			default:
				if (!lRo4h3opGCObA4SvRGVw(GetType(), DmRsN3ophsuiOovVNYp4(typeof(ViewItem).TypeHandle)))
				{
					num2 = 3;
					break;
				}
				goto case 2;
			}
		}
	}

	protected virtual IEnumerable<PropertyInfo> GetPropertiesForCopy()
	{
		return GetType().GetProperties().Where(delegate(PropertyInfo p)
		{
			//Discarded unreachable code: IL_0071, IL_0080
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					if (AttributeHelper<XmlIgnoreAttribute>.GetAttribute(p, inherited: true) != null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 2;
				case 2:
					return _003C_003Ec.vD8J08C8slcTVCAwh9vT(_003C_003Ec.wHMVfqC8Lev92xI11rTL(p), _003C_003Ec.zQujvoC8UEd4Vi0Ql4a6(-398663332 ^ -398684466));
				default:
					return false;
				}
			}
		});
	}

	private static Func<T, object> Compile<T>(Expression<Func<T, object>> prop)
	{
		string key = string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x571EA399 ^ 0x571CC9E1), typeof(T).AssemblyQualifiedName, prop.ToString());
		if (CompiledProperties.TryGetValue(key, out var value))
		{
			return (Func<T, object>)value;
		}
		Func<T, object> func = prop.Compile();
		CompiledProperties[key] = func;
		return func;
	}

	private static List<string> GetOtherItemNames(object thisViewItem, object root)
	{
		_003C_003Ec__DisplayClass64_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass64_0();
		CS_0024_003C_003E8__locals0.thisViewItem = (ViewItem)thisViewItem;
		return ((root is RootViewItem rootViewItem) ? (from i in rootViewItem.GetAllItems(ignoreHide: false)
			where i != CS_0024_003C_003E8__locals0.thisViewItem
			select i).ToArray() : new ViewItem[0]).Select(delegate(ViewItem i)
		{
			//Discarded unreachable code: IL_0064, IL_0073
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return string.Empty;
				case 1:
					return (string)_003C_003Ec.Y3oJONC8zldfk0Rp5Ndv(_003C_003Ec.bQY2gJC8cfqa0qqNFAny(i));
				case 2:
					if (i.Name != null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
						{
							num2 = 1;
						}
						break;
					}
					goto default;
				}
			}
		}).ToList();
	}

	private T FindParent<T>(ViewItem startItem) where T : class
	{
		ViewItem viewItem = startItem;
		while (viewItem != null && !(viewItem is T))
		{
			viewItem = viewItem.Parent;
		}
		return viewItem as T;
	}

	static ViewItem()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				CompiledProperties = new ConcurrentDictionary<string, object>();
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
				{
					num2 = 2;
				}
				break;
			case 1:
				WeXwpNopQm9iYgSZW3yc();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return;
			}
		}
	}

	internal static void icKIOTo37CgDZW2uN4SZ(object P_0)
	{
		LocalizableAttributeHelper.Localize(P_0);
	}

	internal static bool TFDrXdo3HTlW4ugvMUtR()
	{
		return QuoKito36f9JlPbwZX82 == null;
	}

	internal static ViewItem uE3spLo3A5uQhtCOhicT()
	{
		return QuoKito36f9JlPbwZX82;
	}

	internal static Guid OrOEawo3x2oZKss0EcDl()
	{
		return Guid.NewGuid();
	}

	internal static int lM2d6Ko30qZQPefNdynq(object P_0)
	{
		return ((List<ComputedValue>)P_0).Count;
	}

	internal static object d9vNCto3mQ1X1H9etXu5(object P_0)
	{
		return ((ViewItem)P_0).Parent;
	}

	internal static void oGShuAo3ySXhYBx7jCd4(object P_0, object P_1)
	{
		((ViewItem)P_0).TransformatedViewItem = (ViewItem)P_1;
	}

	internal static Guid WQeVEWo3MHAsIgqU33DY(object P_0)
	{
		return ((ViewItem)P_0).Uid;
	}

	internal static bool RUEtASo3JeFJ4CKYij0B(object P_0, Guid uid)
	{
		return ((ViewItem)P_0).IsUid(uid);
	}

	internal static void N1F71Oo39q2potfMtJxU(object P_0, object P_1)
	{
		((ViewItem)P_0).CopyFrom((ViewItem)P_1);
	}

	internal static object jBt1IRo3dXP1xVpd5FOf(object P_0)
	{
		return ((MemberInfo)P_0).Name;
	}

	internal static bool P0ul1Qo3liItHl2UNg6m(object P_0)
	{
		return ((PropertyInfo)P_0).CanWrite;
	}

	internal static bool KIsopKo3r6KAk4rIfBUh(object P_0)
	{
		return ((PropertyInfo)P_0).CanRead;
	}

	internal static Type gmXYQ5o3gEA74ujnMpgU(object P_0)
	{
		return ((PropertyInfo)P_0).PropertyType;
	}

	internal static object DKK6q3o35GQPaIM8k2vh(object P_0, object P_1, object P_2)
	{
		return ((PropertyInfo)P_0).GetValue(P_1, (object[])P_2);
	}

	internal static Type DgGua4o3jb3bMQgEeMeH(object P_0)
	{
		return P_0.GetType();
	}

	internal static object TsjjmVo3Y6GpruR5GPBE(Type P_0)
	{
		return Activator.CreateInstance(P_0);
	}

	internal static void dsTJFJo3LoJ8p5USM89O(object P_0, Guid value)
	{
		((ViewItem)P_0).Uid = value;
	}

	internal static bool SZ3nRio3U6rFoGKF1JPE(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static bool xMuU7vo3smW3NKg8jfvm(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}

	internal static object tdtXRdo3cL6IQKnYgBUj(object P_0)
	{
		return ((ViewItem)P_0).Root;
	}

	internal static object OUb48To3zZBASyZnXZN4(object P_0)
	{
		return ((ViewItem)P_0).GetDefaultName();
	}

	internal static object iG1CZmopFQ0GRflZnjum(object P_0, object P_1)
	{
		return string.Concat(P_0, P_1);
	}

	internal static object Do5mqxopBmN5IZre8cdW(object P_0)
	{
		return ((string)P_0).ToLower();
	}

	internal static object gL2OLIopWRJWo1KxWasn(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static object lIvLSCopoWtUB3AA1bpY(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object Is6Xapopb9BUfiObmOiv(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static Type DmRsN3ophsuiOovVNYp4(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static bool lRo4h3opGCObA4SvRGVw(Type P_0, Type P_1)
	{
		return P_0 != P_1;
	}

	internal static int ErAu54opE17CxlBgaYRb(object P_0)
	{
		return ((string)P_0).Length;
	}

	internal static object nvVtKMopfM1stwydrkbb(object P_0, int P_1, int P_2)
	{
		return ((string)P_0).Substring(P_1, P_2);
	}

	internal static void WeXwpNopQm9iYgSZW3yc()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
