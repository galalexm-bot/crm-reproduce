using System;
using System.Collections;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Model.Views.Toolbox;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Files.Previews.ViewItems;

[Serializable]
[DisplayName(typeof(__Resources_FilePreviewViewItem), "DisplayName")]
public class FilePreviewViewItem : ViewItem
{
	[Component(Order = 100)]
	private class ToolboxItem : AdditionalViewItemToolboxItem<FilePreviewViewItem>
	{
		private IEnumerable<IFilePreviewViewItemAvailable> filePreviewViewItemAvailable;

		internal static object FWq2O28FuQvaDBCdrT1k;

		public override string Name => (string)WDPalx8FKXooLSuIKMfr(yyrIi18FqJ0N6H23pd0H(0x6A81B9B4 ^ 0x6A824F3E));

		public ToolboxItem(IEnumerable<IFilePreviewViewItemAvailable> filePreviewViewItemAvailable)
		{
			SingletonReader.JJCZtPuTvSt();
			base._002Ector();
			this.filePreviewViewItemAvailable = filePreviewViewItemAvailable;
		}

		public override bool IsAvailable(IMetadata metadata)
		{
			//Discarded unreachable code: IL_005a, IL_008f, IL_009e, IL_00d4, IL_00e3, IL_0141, IL_0181, IL_018c, IL_019b
			int num = 2;
			int num2 = num;
			IEnumerator<IFilePreviewViewItemAvailable> enumerator = default(IEnumerator<IFilePreviewViewItemAvailable>);
			bool result = default(bool);
			while (true)
			{
				switch (num2)
				{
				case 2:
					enumerator = filePreviewViewItemAvailable.GetEnumerator();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
					{
						num2 = 1;
					}
					continue;
				case 1:
					try
					{
						while (true)
						{
							int num3;
							if (!AU6UyK8FiBgmRLogASil(enumerator))
							{
								num3 = 2;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
								{
									num3 = 0;
								}
								goto IL_0068;
							}
							goto IL_00ee;
							IL_0068:
							switch (num3)
							{
							case 3:
								return result;
							case 1:
							case 4:
								break;
							case 5:
								goto IL_00ee;
							default:
								goto IL_010a;
							case 2:
								goto end_IL_00a9;
							}
							continue;
							IL_010a:
							result = true;
							int num4 = 3;
							num3 = num4;
							goto IL_0068;
							IL_00ee:
							if (!DNxlsd8FSl4ukAUW3LsN(enumerator.Current, metadata))
							{
								num3 = 4;
								goto IL_0068;
							}
							goto IL_010a;
							continue;
							end_IL_00a9:
							break;
						}
					}
					finally
					{
						int num5;
						if (enumerator == null)
						{
							num5 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
							{
								num5 = 0;
							}
							goto IL_0145;
						}
						goto IL_015b;
						IL_015b:
						Gk3ltk8FRPyWjSt3MyIF(enumerator);
						num5 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
						{
							num5 = 1;
						}
						goto IL_0145;
						IL_0145:
						switch (num5)
						{
						default:
							goto end_IL_0120;
						case 2:
							break;
						case 0:
							goto end_IL_0120;
						case 1:
							goto end_IL_0120;
						}
						goto IL_015b;
						end_IL_0120:;
					}
					break;
				}
				break;
			}
			return false;
		}

		internal static bool DNxlsd8FSl4ukAUW3LsN(object P_0, object P_1)
		{
			return ((IFilePreviewViewItemAvailable)P_0).IsAvailable((IMetadata)P_1);
		}

		internal static bool AU6UyK8FiBgmRLogASil(object P_0)
		{
			return ((IEnumerator)P_0).MoveNext();
		}

		internal static void Gk3ltk8FRPyWjSt3MyIF(object P_0)
		{
			((IDisposable)P_0).Dispose();
		}

		internal static bool Diqso98FIcoQP79bdJIP()
		{
			return FWq2O28FuQvaDBCdrT1k == null;
		}

		internal static ToolboxItem geuLsd8FVSsmmKH8vBfJ()
		{
			return (ToolboxItem)FWq2O28FuQvaDBCdrT1k;
		}

		internal static object yyrIi18FqJ0N6H23pd0H(int _0020)
		{
			return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}

		internal static object WDPalx8FKXooLSuIKMfr(object P_0)
		{
			return SR.T((string)P_0);
		}
	}

	private static FilePreviewViewItem jSJtGRG3Ooodbm7iMqVY;

	public override bool IsValid(ViewType viewType, ViewItem parentViewItem)
	{
		//Discarded unreachable code: IL_002d, IL_003c
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (parentViewItem == null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			default:
				return uQyAE8G3P9Rw7PihhUcT(parentViewItem, this);
			case 1:
				return true;
			}
		}
	}

	public override bool IsChildValid(ViewItem childViewItem)
	{
		return false;
	}

	public FilePreviewViewItem()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		QM7AVrG31SO1hS631rbY();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool uQyAE8G3P9Rw7PihhUcT(object P_0, object P_1)
	{
		return ((ViewItem)P_0).IsChildValid((ViewItem)P_1);
	}

	internal static bool YqBGEyG32mPfWHgaXTm7()
	{
		return jSJtGRG3Ooodbm7iMqVY == null;
	}

	internal static FilePreviewViewItem tIsmZPG3eATTtJ6Dha3B()
	{
		return jSJtGRG3Ooodbm7iMqVY;
	}

	internal static void QM7AVrG31SO1hS631rbY()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
