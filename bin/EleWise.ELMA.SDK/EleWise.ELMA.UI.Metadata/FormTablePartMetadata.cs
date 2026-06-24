using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.UI.Metadata;

[Serializable]
public class FormTablePartMetadata : TablePartMetadata
{
	private static FormTablePartMetadata LBA5OJBE6qeFZbmmEkGU;

	public override void LoadFromType(Type type, bool inherit = true)
	{
		//Discarded unreachable code: IL_0060, IL_006f, IL_0118, IL_0158, IL_0167, IL_0173, IL_01c6
		int num = 1;
		int num2 = num;
		IEnumerator<PropertyInfo> enumerator = default(IEnumerator<PropertyInfo>);
		PropertyInfo current = default(PropertyInfo);
		EntityMetadata entityMetadata = default(EntityMetadata);
		while (true)
		{
			switch (num2)
			{
			case 6:
				base.LoadFromType(type, inherit);
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				try
				{
					while (true)
					{
						int num4;
						if (!RiPwlkBE04933lecahOs(enumerator))
						{
							int num3 = 2;
							num4 = num3;
							goto IL_007e;
						}
						goto IL_00df;
						IL_007e:
						while (true)
						{
							switch (num4)
							{
							case 3:
								ik11ZZBExFpUcPorZQ1G(current, this, current.GetValue(entityMetadata, null), null);
								num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
								{
									num4 = 0;
								}
								continue;
							case 1:
								goto IL_00df;
							case 2:
								return;
							}
							break;
						}
						continue;
						IL_00df:
						current = enumerator.Current;
						num4 = 3;
						goto IL_007e;
					}
				}
				finally
				{
					int num5;
					if (enumerator == null)
					{
						num5 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
						{
							num5 = 2;
						}
						goto IL_011c;
					}
					goto IL_0132;
					IL_0132:
					enumerator.Dispose();
					num5 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 != 0)
					{
						num5 = 0;
					}
					goto IL_011c;
					IL_011c:
					switch (num5)
					{
					default:
						goto end_IL_00f7;
					case 1:
						break;
					case 2:
						goto end_IL_00f7;
					case 0:
						goto end_IL_00f7;
					}
					goto IL_0132;
					end_IL_00f7:;
				}
			default:
				if (entityMetadata != null)
				{
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 6;
			case 1:
				entityMetadata = (EntityMetadata)aScoXkBE7eVlmPVxgnHI(type);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				return;
			case 3:
				return;
			case 5:
				enumerator = GetType().GetProperties().Where(delegate(PropertyInfo p)
				{
					//Discarded unreachable code: IL_0035, IL_004d
					int num6 = 1;
					int num7 = num6;
					while (true)
					{
						switch (num7)
						{
						case 4:
							return _003C_003Ec.fb4H4QQbCapuecgPDmcI(p);
						default:
							return false;
						case 1:
							if (((Array)_003C_003Ec.VIYOobQbQRb88ksTwu4c(p)).Length != 0)
							{
								num7 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
								{
									num7 = 0;
								}
								break;
							}
							goto case 3;
						case 3:
							if (!p.CanRead)
							{
								num7 = 2;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
								{
									num7 = 0;
								}
								break;
							}
							goto case 4;
						}
					}
				}).GetEnumerator();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	public override TablePartMetadata CreateTablePart()
	{
		int num = 2;
		_003C_003Ec__DisplayClass1_0 _003C_003Ec__DisplayClass1_ = default(_003C_003Ec__DisplayClass1_0);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					loFoXwBEy9TBXsYOSjXP(_003C_003Ec__DisplayClass1_.tp, EntityMetadataType.Entity);
					num2 = 5;
					continue;
				case 1:
					_003C_003Ec__DisplayClass1_.tp = new FormTablePartMetadata();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
					{
						num2 = 0;
					}
					continue;
				case 4:
					return _003C_003Ec__DisplayClass1_.tp;
				case 5:
					break;
				case 2:
					_003C_003Ec__DisplayClass1_ = new _003C_003Ec__DisplayClass1_0();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0)
					{
						num2 = 1;
					}
					continue;
				default:
					F3aGtXBEmSR900t9HW9s(_003C_003Ec__DisplayClass1_.tp);
					num2 = 3;
					continue;
				}
				break;
			}
			MIhZNtBEJFikP3quV6gl(_003C_003Ec__DisplayClass1_.tp.Properties.First(_003C_003Ec__DisplayClass1_._003CCreateTablePart_003Eb__0), SRBVQZBEMWQwTAHtVvm3(this));
			num = 4;
		}
	}

	public FormTablePartMetadata()
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

	internal static object aScoXkBE7eVlmPVxgnHI(Type type)
	{
		return FormContextMetadata.FindMetadata(type);
	}

	internal static void ik11ZZBExFpUcPorZQ1G(object P_0, object P_1, object P_2, object P_3)
	{
		((PropertyInfo)P_0).SetValue(P_1, P_2, (object[])P_3);
	}

	internal static bool RiPwlkBE04933lecahOs(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static bool SungliBEH68AeFD7K5gL()
	{
		return LBA5OJBE6qeFZbmmEkGU == null;
	}

	internal static FormTablePartMetadata uedLA6BEAnguL9jRLF6o()
	{
		return LBA5OJBE6qeFZbmmEkGU;
	}

	internal static void F3aGtXBEmSR900t9HW9s(object P_0)
	{
		((AbstractMetadata)P_0).InitNew();
	}

	internal static void loFoXwBEy9TBXsYOSjXP(object P_0, EntityMetadataType value)
	{
		((EntityMetadata)P_0).Type = value;
	}

	internal static Guid SRBVQZBEMWQwTAHtVvm3(object P_0)
	{
		return ((AbstractMetadata)P_0).Uid;
	}

	internal static void MIhZNtBEJFikP3quV6gl(object P_0, Guid value)
	{
		((PropertyMetadata)P_0).SubTypeUid = value;
	}
}
