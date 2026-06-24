using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.ScriptDesigner.CodeItems;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.ScriptDesigner.ToolBoxItems;

[Component]
public abstract class CodeItemToolBoxItem : ICodeItemToolBoxItem, ICodeItemPoint
{
	private static CodeItemToolBoxItem MIeQVxuLgbeqNMNRl38;

	public abstract string Name { get; set; }

	public string ToolTipFooter
	{
		[CompilerGenerated]
		get
		{
			return _003CToolTipFooter_003Ek__BackingField;
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
					_003CToolTipFooter_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public string ToolTipBody
	{
		[CompilerGenerated]
		get
		{
			return _003CToolTipBody_003Ek__BackingField;
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
					_003CToolTipBody_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
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

	public string ToolTipHeader
	{
		[CompilerGenerated]
		get
		{
			return _003CToolTipHeader_003Ek__BackingField;
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
					_003CToolTipHeader_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public abstract Type CodeItemType { get; set; }

	public abstract Guid GroupUid { get; }

	public virtual Image Image => null;

	public string Path
	{
		[CompilerGenerated]
		get
		{
			return _003CPath_003Ek__BackingField;
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
					_003CPath_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public string DisplayName
	{
		[CompilerGenerated]
		get
		{
			return _003CDisplayName_003Ek__BackingField;
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
					_003CDisplayName_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
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

	public string VariableName
	{
		[CompilerGenerated]
		get
		{
			return _003CVariableName_003Ek__BackingField;
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
					_003CVariableName_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
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

	public Type VariableType
	{
		[CompilerGenerated]
		get
		{
			return _003CVariableType_003Ek__BackingField;
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
					_003CVariableType_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
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

	public string Description
	{
		[CompilerGenerated]
		get
		{
			return _003CDescription_003Ek__BackingField;
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
					_003CDescription_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 != 0)
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

	public bool IsLocal
	{
		[CompilerGenerated]
		get
		{
			return _003CIsLocal_003Ek__BackingField;
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
					_003CIsLocal_003Ek__BackingField = value;
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
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public abstract ICodeItem CreateCodeItem();

	public abstract bool IsAvailable(IMetadata metadata);

	protected CodeItemToolBoxItem()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool vMelvJuUNslqFfaadHm()
	{
		return MIeQVxuLgbeqNMNRl38 == null;
	}

	internal static CodeItemToolBoxItem qLURyCusUsR0Epddsbp()
	{
		return MIeQVxuLgbeqNMNRl38;
	}
}
public abstract class CodeItemToolBoxItem<TCodeItem> : CodeItemToolBoxItem where TCodeItem : ICodeItem
{
	private static object uPepYfucPv1vZKBjnTk;

	public override Type CodeItemType
	{
		get
		{
			return typeof(TCodeItem);
		}
		set
		{
		}
	}

	public override string Name
	{
		get
		{
			//Discarded unreachable code: IL_006d, IL_0078, IL_0093
			int num = 5;
			int num2 = num;
			ViewItemInfoService viewItemInfoService = default(ViewItemInfoService);
			ViewItemTypeInfo viewItemTypeInfo = default(ViewItemTypeInfo);
			while (true)
			{
				object obj2;
				object obj;
				switch (num2)
				{
				default:
					if (viewItemInfoService == null)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
						{
							num2 = 0;
						}
						continue;
					}
					obj2 = viewItemInfoService.GetInfo(typeof(TCodeItem));
					break;
				case 2:
					return string.Empty;
				case 1:
					obj2 = null;
					break;
				case 6:
					obj = null;
					goto IL_00b6;
				case 3:
					if (viewItemTypeInfo != null)
					{
						return viewItemTypeInfo.Name;
					}
					num2 = 2;
					continue;
				case 5:
					if (Locator.Initialized)
					{
						num2 = 4;
						continue;
					}
					goto case 6;
				case 4:
					{
						obj = Locator.GetService<ViewItemInfoService>();
						goto IL_00b6;
					}
					IL_00b6:
					viewItemInfoService = (ViewItemInfoService)obj;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				viewItemTypeInfo = (ViewItemTypeInfo)obj2;
				num2 = 3;
			}
		}
		set
		{
		}
	}

	public override ICodeItem CreateCodeItem()
	{
		int num = 1;
		int num2 = num;
		TCodeItem val = default(TCodeItem);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return val;
			case 1:
				val = Activator.CreateInstance<TCodeItem>();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				val.InitNew(null);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	public override bool IsAvailable(IMetadata metadata)
	{
		return ViewItemMetadataAttribute.IsAvailable<TCodeItem>(metadata);
	}

	protected CodeItemToolBoxItem()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool ILV7FduzBbn2dBDmvIb()
	{
		return uPepYfucPv1vZKBjnTk == null;
	}

	internal static object trPS3IIFLcUi8TwiNaO()
	{
		return uPepYfucPv1vZKBjnTk;
	}
}
