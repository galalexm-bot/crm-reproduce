using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Services;
using EleWise.ELMA.UI.Descriptors;
using EleWise.ELMA.UI.Metadata;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.UI.Services;

public class UIViewItemParams
{
	private string[] _items;

	internal static UIViewItemParams HCldXZsg9tslInwV2YO;

	public FormDescriptor FormDescriptor
	{
		[CompilerGenerated]
		get
		{
			return _003CFormDescriptor_003Ek__BackingField;
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
					_003CFormDescriptor_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public FormPartMetadata PartMetadata
	{
		[CompilerGenerated]
		get
		{
			return _003CPartMetadata_003Ek__BackingField;
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
					_003CPartMetadata_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	protected string[] Items => _items;

	protected virtual int TotalItemsCount => 3;

	public UIViewItemParams()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		Mr74mfsYKGNtGKvCMIT();
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

	public UIViewItemParams(string viewItemId)
	{
		//Discarded unreachable code: IL_002a, IL_00c6
		Mr74mfsYKGNtGKvCMIT();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
		{
			num = 0;
		}
		Guid guid2 = default(Guid);
		Guid guid = default(Guid);
		Guid metadataType = default(Guid);
		while (true)
		{
			int num2;
			switch (num)
			{
			case 9:
				throw new InvalidOperationException((string)MbZlpRszOUM7d06yyZi(hTu9lpsL3Zr8qdrm6E1(0x269E5FCA ^ 0x269E8814), guid2));
			case 7:
				PartMetadata = (FormPartMetadata)X5S8s0cBdh1UqV8WvuE(tkc4FfcFlohdStQjpEY(FormDescriptor), guid);
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
				{
					num = 1;
				}
				break;
			case 1:
				if (PartMetadata == null)
				{
					num2 = 10;
					goto IL_002f;
				}
				return;
			case 6:
				metadataType = new Guid(_items[0]);
				num = 8;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
				{
					num = 5;
				}
				break;
			case 10:
				throw new InvalidOperationException(string.Format((string)hTu9lpsL3Zr8qdrm6E1(0x66F566B6 ^ 0x66F5BE86), guid, nR5SGTcWAoUq51W2PgE(tkc4FfcFlohdStQjpEY(FormDescriptor))));
			case 8:
				guid2 = new Guid(_items[1]);
				num = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca != 0)
				{
					num = 3;
				}
				break;
			case 11:
				FormDescriptor = Locator.GetServiceNotNull<FormDescriptorProvider>().GetDescriptor(metadataType, guid2);
				num = 5;
				break;
			case 4:
				UnNP6WscwpchGTerX4J(_items.Length >= 3, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1411196499 ^ -1411248619) + 3);
				num = 6;
				break;
			case 5:
				if (FormDescriptor != null)
				{
					num = 7;
					break;
				}
				goto case 9;
			case 3:
				guid = new Guid(_items[2]);
				num = 11;
				break;
			case 2:
				_items = (string[])QqLNh4ssPFQDVnJAcmu(viewItemId, new char[1] { ';' });
				num2 = 4;
				goto IL_002f;
			default:
				{
					RByrQ0sU2nJ1S6lPQuC(viewItemId, hTu9lpsL3Zr8qdrm6E1(0x571EA399 ^ 0x571E7439));
					num = 2;
					break;
				}
				IL_002f:
				num = num2;
				break;
			}
		}
	}

	public override string ToString()
	{
		int num = 2;
		int num2 = num;
		List<object> list = default(List<object>);
		while (true)
		{
			switch (num2)
			{
			case 1:
				AddItems(list);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				list = new List<object>();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
				{
					num2 = 1;
				}
				continue;
			}
			return string.Join((string)hTu9lpsL3Zr8qdrm6E1(0x5F3078B6 ^ 0x5F302C6A), list.Select(delegate(object i)
			{
				//Discarded unreachable code: IL_002d, IL_003c
				int num3 = 1;
				int num4 = num3;
				while (true)
				{
					switch (num4)
					{
					case 2:
						return "";
					default:
						return i.ToString();
					case 1:
						if (i != null)
						{
							num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e != 0)
							{
								num4 = 0;
							}
							break;
						}
						goto case 2;
					}
				}
			}));
		}
	}

	protected virtual void AddItems(List<object> items)
	{
		items.Add((FormDescriptor != null) ? FormDescriptor.Metadata.GetTypeUid() : Guid.Empty);
		items.Add((FormDescriptor != null) ? FormDescriptor.Uid : Guid.Empty);
		items.Add((PartMetadata != null) ? PartMetadata.Uid : Guid.Empty);
	}

	internal static void Mr74mfsYKGNtGKvCMIT()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool fgGC8ys5jFsGKZoasot()
	{
		return HCldXZsg9tslInwV2YO == null;
	}

	internal static UIViewItemParams gD1HTYsjOk3QtlLXScp()
	{
		return HCldXZsg9tslInwV2YO;
	}

	internal static object hTu9lpsL3Zr8qdrm6E1(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void RByrQ0sU2nJ1S6lPQuC(object P_0, object P_1)
	{
		Contract.ArgumentNotNullOrEmpty((string)P_0, (string)P_1);
	}

	internal static object QqLNh4ssPFQDVnJAcmu(object P_0, object P_1)
	{
		return ((string)P_0).Split((char[])P_1);
	}

	internal static void UnNP6WscwpchGTerX4J(bool condition, object P_1)
	{
		Contract.CheckArgument(condition, (string)P_1);
	}

	internal static object MbZlpRszOUM7d06yyZi(object P_0, object P_1)
	{
		return string.Format((string)P_0, P_1);
	}

	internal static object tkc4FfcFlohdStQjpEY(object P_0)
	{
		return ((FormDescriptor)P_0).Metadata;
	}

	internal static object X5S8s0cBdh1UqV8WvuE(object P_0, Guid partUid)
	{
		return ((FormMetadata)P_0).GetPart(partUid);
	}

	internal static object nR5SGTcWAoUq51W2PgE(object P_0)
	{
		return ((NamedMetadata)P_0).Name;
	}
}
