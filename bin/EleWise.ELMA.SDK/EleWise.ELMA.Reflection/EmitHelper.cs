using System;
using System.Reflection;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Reflection;

internal static class EmitHelper
{
	internal interface IILAdapter
	{
		void Ldc_I4_S(sbyte b);

		void Ldc_I4(int i);

		void Ldc_I4_M1();

		void Ldc_I4_0();

		void Ldc_I4_1();

		void Ldc_I4_2();

		void Ldc_I4_3();

		void Ldc_I4_4();

		void Ldc_I4_5();

		void Ldc_I4_6();

		void Ldc_I4_7();

		void Ldc_I4_8();

		void Newobj(ConstructorInfo ctor);
	}

	private static readonly ConstructorInfo GuidCtor;

	private static EmitHelper Rg2c19Bk7GJeGUSCpypR;

	internal static void Emit_Ldc_I4(this IILAdapter il, int arg)
	{
		//Discarded unreachable code: IL_0133, IL_01be
		int num = 5;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 3:
				if (arg > 127)
				{
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
					{
						num2 = 13;
					}
					continue;
				}
				break;
			case 10:
				return;
			case 13:
				Q922qPBkgbPX107P81qf(il, arg);
				num2 = 7;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0)
				{
					num2 = 6;
				}
				continue;
			case 9:
				return;
			case 6:
				return;
			case 4:
				if (arg >= -128)
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
					{
						num2 = 3;
					}
					continue;
				}
				goto case 13;
			case 17:
				return;
			case 11:
				return;
			case 15:
				il.Ldc_I4_M1();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
				{
					num2 = 1;
				}
				continue;
			case 12:
				return;
			case 16:
				return;
			case 5:
				switch (arg)
				{
				case 3:
					NNGQuEBkM5b29SVMkNP9(il);
					num2 = 14;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
					{
						num2 = 16;
					}
					continue;
				case 8:
					il.Ldc_I4_8();
					num2 = 6;
					continue;
				case 1:
					ufuvngBkydMimoHX9IqT(il);
					num2 = 14;
					continue;
				case -1:
					break;
				case 6:
					dF5WtTBkdVt0ARDmQ9gc(il);
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
					{
						num2 = 2;
					}
					continue;
				case 4:
					eYf0ptBkJLOPUT6xcXum(il);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
					{
						num2 = 0;
					}
					continue;
				default:
					num2 = 4;
					continue;
				case 0:
					zC3pXGBkmCDpDmjUZK0F(il);
					num2 = 11;
					continue;
				case 7:
					C5m4fbBklawHbAKh3KUk(il);
					num2 = 16;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0)
					{
						num2 = 17;
					}
					continue;
				case 5:
					I5EF4hBk9YdOZxJLZj39(il);
					num2 = 12;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
					{
						num2 = 3;
					}
					continue;
				case 2:
					il.Ldc_I4_2();
					num2 = 9;
					continue;
				}
				goto case 15;
			case 7:
				return;
			case 2:
				break;
			case 1:
				return;
			case 8:
				return;
			case 0:
				return;
			case 14:
				return;
			}
			I2TRyVBkrWWh24wpnNXD(il, (sbyte)arg);
			num2 = 10;
		}
	}

	internal static void Emit_Ldc_Guid(this IILAdapter il, Guid uid)
	{
		int num = 19;
		byte arg10 = default(byte);
		byte arg8 = default(byte);
		byte[] array = default(byte[]);
		ushort arg = default(ushort);
		int arg5 = default(int);
		byte arg6 = default(byte);
		byte arg7 = default(byte);
		ushort arg9 = default(ushort);
		byte arg11 = default(byte);
		byte arg3 = default(byte);
		byte arg4 = default(byte);
		byte arg2 = default(byte);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 20:
					fKsVhGBkjyI6JuWPtUqM(il, GuidCtor);
					num2 = 15;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
					{
						num2 = 15;
					}
					continue;
				case 16:
					zPdHnNBk5rLd6KtJXQjj(il, arg10);
					num2 = 20;
					continue;
				case 2:
					arg8 = array[8];
					num2 = 13;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
					{
						num2 = 14;
					}
					continue;
				case 3:
					zPdHnNBk5rLd6KtJXQjj(il, arg);
					num2 = 9;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
					{
						num2 = 17;
					}
					continue;
				case 19:
					array = uid.ToByteArray();
					num2 = 18;
					continue;
				case 18:
					arg5 = (array[3] << 24) | (array[2] << 16) | (array[1] << 8) | array[0];
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
					{
						num2 = 1;
					}
					continue;
				case 14:
					arg6 = array[9];
					num2 = 10;
					continue;
				case 23:
					arg7 = array[11];
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
					{
						num2 = 4;
					}
					continue;
				case 1:
					arg9 = (ushort)((array[5] << 8) | array[4]);
					num2 = 11;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
					{
						num2 = 1;
					}
					continue;
				case 4:
					arg11 = array[12];
					num2 = 24;
					continue;
				case 22:
					zPdHnNBk5rLd6KtJXQjj(il, arg3);
					num2 = 16;
					continue;
				case 6:
					zPdHnNBk5rLd6KtJXQjj(il, arg11);
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
					{
						num2 = 7;
					}
					continue;
				case 12:
					zPdHnNBk5rLd6KtJXQjj(il, arg4);
					num2 = 21;
					continue;
				case 8:
					arg10 = array[15];
					num2 = 5;
					continue;
				case 15:
					return;
				default:
					zPdHnNBk5rLd6KtJXQjj(il, arg9);
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
					{
						num2 = 3;
					}
					continue;
				case 17:
					zPdHnNBk5rLd6KtJXQjj(il, arg8);
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
					{
						num2 = 9;
					}
					continue;
				case 21:
					zPdHnNBk5rLd6KtJXQjj(il, arg7);
					num2 = 6;
					continue;
				case 9:
					zPdHnNBk5rLd6KtJXQjj(il, arg6);
					num2 = 12;
					continue;
				case 5:
					zPdHnNBk5rLd6KtJXQjj(il, arg5);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0)
					{
						num2 = 0;
					}
					continue;
				case 24:
					arg2 = array[13];
					num2 = 13;
					continue;
				case 10:
					arg4 = array[10];
					num = 23;
					break;
				case 13:
					arg3 = array[14];
					num2 = 8;
					continue;
				case 7:
					zPdHnNBk5rLd6KtJXQjj(il, arg2);
					num = 22;
					break;
				case 11:
					arg = (ushort)((array[7] << 8) | array[6]);
					num2 = 2;
					continue;
				}
				break;
			}
		}
	}

	static EmitHelper()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				GuidCtor = typeof(Guid).GetConstructor(new Type[11]
				{
					typeof(int),
					QrQHSOBkLE6eh4WeG7Ue(typeof(short).TypeHandle),
					typeof(short),
					QrQHSOBkLE6eh4WeG7Ue(typeof(byte).TypeHandle),
					typeof(byte),
					QrQHSOBkLE6eh4WeG7Ue(typeof(byte).TypeHandle),
					QrQHSOBkLE6eh4WeG7Ue(typeof(byte).TypeHandle),
					QrQHSOBkLE6eh4WeG7Ue(typeof(byte).TypeHandle),
					QrQHSOBkLE6eh4WeG7Ue(typeof(byte).TypeHandle),
					QrQHSOBkLE6eh4WeG7Ue(typeof(byte).TypeHandle),
					QrQHSOBkLE6eh4WeG7Ue(typeof(byte).TypeHandle)
				});
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				Chp88xBkYgGJa5gI9YUh();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
				{
					num2 = 1;
				}
				break;
			case 0:
				return;
			}
		}
	}

	internal static void zC3pXGBkmCDpDmjUZK0F(object P_0)
	{
		((IILAdapter)P_0).Ldc_I4_0();
	}

	internal static void ufuvngBkydMimoHX9IqT(object P_0)
	{
		((IILAdapter)P_0).Ldc_I4_1();
	}

	internal static void NNGQuEBkM5b29SVMkNP9(object P_0)
	{
		((IILAdapter)P_0).Ldc_I4_3();
	}

	internal static void eYf0ptBkJLOPUT6xcXum(object P_0)
	{
		((IILAdapter)P_0).Ldc_I4_4();
	}

	internal static void I5EF4hBk9YdOZxJLZj39(object P_0)
	{
		((IILAdapter)P_0).Ldc_I4_5();
	}

	internal static void dF5WtTBkdVt0ARDmQ9gc(object P_0)
	{
		((IILAdapter)P_0).Ldc_I4_6();
	}

	internal static void C5m4fbBklawHbAKh3KUk(object P_0)
	{
		((IILAdapter)P_0).Ldc_I4_7();
	}

	internal static void I2TRyVBkrWWh24wpnNXD(object P_0, sbyte b)
	{
		((IILAdapter)P_0).Ldc_I4_S(b);
	}

	internal static void Q922qPBkgbPX107P81qf(object P_0, int i)
	{
		((IILAdapter)P_0).Ldc_I4(i);
	}

	internal static bool jgvbdqBkxk54JOWhwCVm()
	{
		return Rg2c19Bk7GJeGUSCpypR == null;
	}

	internal static EmitHelper bh16rwBk0aHLqdSL5sml()
	{
		return Rg2c19Bk7GJeGUSCpypR;
	}

	internal static void zPdHnNBk5rLd6KtJXQjj(object P_0, int arg)
	{
		((IILAdapter)P_0).Emit_Ldc_I4(arg);
	}

	internal static void fKsVhGBkjyI6JuWPtUqM(object P_0, object P_1)
	{
		((IILAdapter)P_0).Newobj((ConstructorInfo)P_1);
	}

	internal static void Chp88xBkYgGJa5gI9YUh()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static Type QrQHSOBkLE6eh4WeG7Ue(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}
}
