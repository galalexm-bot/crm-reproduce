using System;
using System.Collections.Generic;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.ScriptDesigner.CodeItems;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.ScriptDesigner.ToolBoxItems;

[Serializable]
public class ContextVariableCodeItemToolBoxItem : NewCodeItemToolBoxItem<VariableCodeItem>
{
	internal static ContextVariableCodeItemToolBoxItem yBCwZEIB2SEGE9HpX7f;

	public override string DisplayName
	{
		get
		{
			//Discarded unreachable code: IL_0035, IL_0044
			int num = 1;
			int num2 = num;
			List<string> displayNames = default(List<string>);
			while (true)
			{
				switch (num2)
				{
				case 2:
					base.DisplayNames = new List<string>();
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0)
					{
						num2 = 3;
					}
					break;
				case 1:
					if (base.DisplayNames != null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 2;
				case 4:
					return string.Join(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x17ADCCD8 ^ 0x17ADD61C), displayNames);
				default:
					displayNames = base.DisplayNames;
					num2 = 4;
					break;
				}
			}
		}
		set
		{
		}
	}

	public override string VariableName
	{
		get
		{
			//Discarded unreachable code: IL_0086, IL_0095, IL_00a0, IL_013b, IL_014e
			int num = 6;
			int num2 = num;
			List<string> list = default(List<string>);
			List<string>.Enumerator enumerator = default(List<string>.Enumerator);
			string current = default(string);
			while (true)
			{
				switch (num2)
				{
				case 2:
					list.Add(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1886646897 ^ -1886631527));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc != 0)
					{
						num2 = 0;
					}
					break;
				default:
					enumerator = base.PropertyNames.GetEnumerator();
					num2 = 4;
					break;
				case 4:
					try
					{
						while (true)
						{
							IL_00d1:
							int num3;
							if (!enumerator.MoveNext())
							{
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
								{
									num3 = 0;
								}
								goto IL_00a4;
							}
							goto IL_00be;
							IL_00be:
							current = enumerator.Current;
							num3 = 3;
							goto IL_00a4;
							IL_00a4:
							while (true)
							{
								switch (num3)
								{
								case 1:
									goto IL_00be;
								case 2:
									goto IL_00d1;
								case 3:
									list.Add((string)DFj4qxIhAGLu6tnn23H(current));
									num3 = 2;
									continue;
								case 0:
									break;
								}
								break;
							}
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator).Dispose();
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
						{
							num4 = 0;
						}
						switch (num4)
						{
						case 0:
							break;
						}
					}
					goto case 3;
				case 3:
					return string.Join((string)SVYR83IG7BfUWO86Py4(0x4DC2B14D ^ 0x4DC2AB89), list);
				case 5:
					base.PropertyNames = new List<string>();
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0)
					{
						num2 = 1;
					}
					break;
				case 1:
					list = new List<string>();
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
					{
						num2 = 1;
					}
					break;
				case 6:
					if (base.PropertyNames == null)
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
						{
							num2 = 5;
						}
						break;
					}
					goto case 1;
				}
			}
		}
		set
		{
		}
	}

	public override Guid GroupUid => ContextCodeItemToolBoxGroup.UID;

	public ContextVariableCodeItemToolBoxItem()
	{
		//Discarded unreachable code: IL_001a, IL_001f
		KCyo14IbEtbR6MF4unS();
		base._002Ector();
		int num = 2;
		while (true)
		{
			switch (num)
			{
			default:
				base.DisplayNames = new List<string>();
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
				{
					num = 1;
				}
				break;
			case 1:
				return;
			case 2:
				base.PropertyNames = new List<string>();
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	internal static void KCyo14IbEtbR6MF4unS()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool EaL858IWNfwCZfUPPEl()
	{
		return yBCwZEIB2SEGE9HpX7f == null;
	}

	internal static ContextVariableCodeItemToolBoxItem g7DOAaIo9st1YETtMLq()
	{
		return yBCwZEIB2SEGE9HpX7f;
	}

	internal static object DFj4qxIhAGLu6tnn23H(object P_0)
	{
		return ((string)P_0).ToTranslit();
	}

	internal static object SVYR83IG7BfUWO86Py4(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}
}
