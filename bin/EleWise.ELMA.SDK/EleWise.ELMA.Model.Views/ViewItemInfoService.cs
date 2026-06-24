using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading;
using EleWise.ELMA.ComponentModel;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Views;

[Service]
public class ViewItemInfoService : IInitHandler
{
	private List<ViewItemTypeInfo> viewItemTypes;

	private static ViewItemInfoService l6vkL3oPCseeyMcCyOkp;

	public IEnumerable<ViewItemTypeInfo> ViewItemTypes => viewItemTypes;

	public ViewItemTypeInfo GetInfo(Type viewItemType)
	{
		//Discarded unreachable code: IL_0056, IL_0065, IL_00da, IL_017d, IL_01bd, IL_01cc, IL_01d8, IL_01e7
		int num = 8;
		int num2 = num;
		_003C_003Ec__DisplayClass2_0 _003C_003Ec__DisplayClass2_ = default(_003C_003Ec__DisplayClass2_0);
		ViewItemTypeInfo viewItemTypeInfo = default(ViewItemTypeInfo);
		List<ViewItemTypeInfo> list = default(List<ViewItemTypeInfo>);
		bool lockTaken = default(bool);
		while (true)
		{
			switch (num2)
			{
			case 8:
				_003C_003Ec__DisplayClass2_ = new _003C_003Ec__DisplayClass2_0();
				num2 = 7;
				break;
			default:
				return viewItemTypeInfo;
			case 1:
				list = viewItemTypes;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc != 0)
				{
					num2 = 2;
				}
				break;
			case 3:
				if (viewItemTypeInfo != null)
				{
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
					{
						num2 = 5;
					}
					break;
				}
				goto case 1;
			case 4:
				try
				{
					Monitor.Enter(list, ref lockTaken);
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0)
					{
						num3 = 0;
					}
					while (true)
					{
						switch (num3)
						{
						case 1:
							return viewItemTypeInfo;
						case 3:
							UpdateInfos();
							num3 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 != 0)
							{
								num3 = 1;
							}
							break;
						case 2:
							viewItemTypes.Add(viewItemTypeInfo);
							num3 = 3;
							break;
						default:
							viewItemTypeInfo = new ViewItemTypeInfo(_003C_003Ec__DisplayClass2_.viewItemType);
							num3 = 2;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
							{
								num3 = 2;
							}
							break;
						}
					}
				}
				finally
				{
					int num4;
					if (!lockTaken)
					{
						num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
						{
							num4 = 0;
						}
						goto IL_0181;
					}
					goto IL_0197;
					IL_0197:
					DGkwawoPZBcbbRrvGAfL(list);
					num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
					{
						num4 = 2;
					}
					goto IL_0181;
					IL_0181:
					switch (num4)
					{
					default:
						goto end_IL_015c;
					case 1:
						break;
					case 0:
						goto end_IL_015c;
					case 2:
						goto end_IL_015c;
					}
					goto IL_0197;
					end_IL_015c:;
				}
			case 6:
				viewItemTypeInfo = viewItemTypes.FirstOrDefault(_003C_003Ec__DisplayClass2_._003CGetInfo_003Eb__0);
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
				{
					num2 = 2;
				}
				break;
			case 7:
				_003C_003Ec__DisplayClass2_.viewItemType = viewItemType;
				num2 = 6;
				break;
			case 2:
				lockTaken = false;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
				{
					num2 = 4;
				}
				break;
			}
		}
	}

	private void UpdateInfos()
	{
		//Discarded unreachable code: IL_0037, IL_0046, IL_014c, IL_0184, IL_0193
		int num = 4;
		int num2 = num;
		IEnumerator<ViewItemTypeInfo> enumerator = default(IEnumerator<ViewItemTypeInfo>);
		ViewItemTypeInfo current = default(ViewItemTypeInfo);
		IEnumerable<ViewItemTypeInfo> enumerable = default(IEnumerable<ViewItemTypeInfo>);
		while (true)
		{
			switch (num2)
			{
			case 1:
				return;
			case 2:
				try
				{
					while (true)
					{
						int num4;
						if (!YOqrohoPSuZioPDoNSIm(enumerator))
						{
							int num3 = 2;
							num4 = num3;
							goto IL_0055;
						}
						goto IL_0089;
						IL_0055:
						while (true)
						{
							switch (num4)
							{
							case 1:
								goto IL_0089;
							case 3:
								current.name = (string)(enumerable.Contains(current) ? ikGe5IoPV8A3qua8yeui(current.originalName, xJ6LQmoPuBhZrpr1pj5E(-1998538950 ^ -1998532592), Fj8LtqoPIo7RyYq8bAfj(current.ViewItemType), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x12A5FAC7 ^ 0x12A5E57B)) : current.originalName);
								num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
								{
									num4 = 0;
								}
								continue;
							case 2:
								goto end_IL_006f;
							}
							break;
						}
						continue;
						IL_0089:
						current = enumerator.Current;
						num4 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa != 0)
						{
							num4 = 3;
						}
						goto IL_0055;
						continue;
						end_IL_006f:
						break;
					}
				}
				finally
				{
					if (enumerator != null)
					{
						int num5 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
						{
							num5 = 1;
						}
						while (true)
						{
							switch (num5)
							{
							case 1:
								w2869KoPib3Bm6D8XFqG(enumerator);
								num5 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
								{
									num5 = 0;
								}
								continue;
							case 0:
								break;
							}
							break;
						}
					}
				}
				break;
			case 3:
				enumerator = enumerable.GetEnumerator();
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
				{
					num2 = 0;
				}
				continue;
			case 4:
				enumerable = (from i in viewItemTypes
					group i by i.originalName into g
					where g.Count() > 1
					select g).SelectMany((IGrouping<string, ViewItemTypeInfo> g) => g);
				num2 = 3;
				continue;
			}
			viewItemTypes = viewItemTypes.OrderBy((ViewItemTypeInfo i) => (string)_003C_003Ec.L34fOMCQ9Iu70a99eflD(i)).ToList();
			num2 = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
			{
				num2 = 0;
			}
		}
	}

	void IInitHandler.Init()
	{
	}

	void IInitHandler.InitComplete()
	{
		//Discarded unreachable code: IL_0040, IL_0084, IL_0093, IL_009e, IL_0147, IL_017f, IL_018e, IL_0216, IL_024e, IL_025d
		int num = 1;
		int num2 = num;
		List<ViewItemTypeInfo> list = default(List<ViewItemTypeInfo>);
		bool lockTaken = default(bool);
		IEnumerator<Type> enumerator = default(IEnumerator<Type>);
		Type current = default(Type);
		while (true)
		{
			switch (num2)
			{
			case 3:
				try
				{
					Monitor.Enter(list, ref lockTaken);
					int num3 = 2;
					while (true)
					{
						switch (num3)
						{
						default:
							return;
						case 1:
							UpdateInfos();
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
							{
								num3 = 0;
							}
							break;
						case 3:
							try
							{
								while (true)
								{
									int num4;
									if (!YOqrohoPSuZioPDoNSIm(enumerator))
									{
										num4 = 3;
										goto IL_00a2;
									}
									goto IL_00fe;
									IL_00a2:
									while (true)
									{
										switch (num4)
										{
										case 1:
											viewItemTypes.Add(new ViewItemTypeInfo(current));
											num4 = 1;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0)
											{
												num4 = 2;
											}
											continue;
										case 2:
											break;
										default:
											goto IL_00fe;
										case 3:
											goto end_IL_00e8;
										}
										break;
									}
									continue;
									IL_00fe:
									current = enumerator.Current;
									num4 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
									{
										num4 = 1;
									}
									goto IL_00a2;
									continue;
									end_IL_00e8:
									break;
								}
							}
							finally
							{
								if (enumerator != null)
								{
									int num5 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0)
									{
										num5 = 1;
									}
									while (true)
									{
										switch (num5)
										{
										case 1:
											w2869KoPib3Bm6D8XFqG(enumerator);
											num5 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0)
											{
												num5 = 0;
											}
											continue;
										case 0:
											break;
										}
										break;
									}
								}
							}
							goto case 1;
						case 2:
							enumerator = ComponentManager.Current.GetXsiTypes().Where(delegate(Type t)
							{
								//Discarded unreachable code: IL_0035, IL_0044, IL_0085, IL_0094
								int num7 = 2;
								int num8 = num7;
								while (true)
								{
									switch (num8)
									{
									case 3:
										return !t.IsGenericTypeDefinition;
									default:
										return false;
									case 4:
										if (t.IsAbstract)
										{
											num8 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
											{
												num8 = 0;
											}
											break;
										}
										goto case 3;
									case 2:
										if (!_003C_003Ec.vTnanXCQdyAiFsvFdrMp(typeof(ViewItem).TypeHandle).IsAssignableFrom(t))
										{
											num8 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0)
											{
												num8 = 1;
											}
											break;
										}
										goto case 4;
									}
								}
							}).GetEnumerator();
							num3 = 3;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
							{
								num3 = 3;
							}
							break;
						case 0:
							return;
						}
					}
				}
				finally
				{
					if (lockTaken)
					{
						int num6 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0)
						{
							num6 = 0;
						}
						while (true)
						{
							switch (num6)
							{
							case 1:
								DGkwawoPZBcbbRrvGAfL(list);
								num6 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
								{
									num6 = 0;
								}
								continue;
							case 0:
								break;
							}
							break;
						}
					}
				}
			default:
				lockTaken = false;
				num2 = 3;
				break;
			case 1:
				list = viewItemTypes;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return;
			}
		}
	}

	public ViewItemInfoService()
	{
		//Discarded unreachable code: IL_003a, IL_003f
		JvC19RoPR2NTMCXuFSn8();
		viewItemTypes = new List<ViewItemTypeInfo>();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void DGkwawoPZBcbbRrvGAfL(object P_0)
	{
		Monitor.Exit(P_0);
	}

	internal static bool R1xaw7oPvmuc6qJE5Iya()
	{
		return l6vkL3oPCseeyMcCyOkp == null;
	}

	internal static ViewItemInfoService M5nxc9oP86HDOnFTtwQ5()
	{
		return l6vkL3oPCseeyMcCyOkp;
	}

	internal static object xJ6LQmoPuBhZrpr1pj5E(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object Fj8LtqoPIo7RyYq8bAfj(object P_0)
	{
		return ((MemberInfo)P_0).Name;
	}

	internal static object ikGe5IoPV8A3qua8yeui(object P_0, object P_1, object P_2, object P_3)
	{
		return (string)P_0 + (string)P_1 + (string)P_2 + (string)P_3;
	}

	internal static bool YOqrohoPSuZioPDoNSIm(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void w2869KoPib3Bm6D8XFqG(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static void JvC19RoPR2NTMCXuFSn8()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
