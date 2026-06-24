using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using EleWise.ELMA.BPMApps;
using EleWise.ELMA.BPMApps.Models;
using EleWise.ELMA.Memory;
using EleWise.ELMA.Packaging.ElmaStoreManifest;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Deploy.Extensions;

internal static class IBPMAppExtensions
{
	private static IBPMAppExtensions FCaaLYEDAADU5n8DjOQv;

	internal static void InputComponentManifest(this IBPMApp bpmApp, ElmaStoreComponentManifest componentManifest)
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
				wZDiPfEDyTpofrtfhRWA(bpmApp, componentManifest);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			case 2:
				GapJkcEDm72jwM3v3oW6(bpmApp, Aee0ddED0yLbh0BpVO0h(componentManifest));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	internal static void InputAppManifest(this IBPMApp bpmApp, BPMAppManifest bpmAppManifest)
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
				bpmApp.AppManifest = bpmAppManifest;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static void InputImage(this IBPMApp bpmApp, Image image)
	{
		//Discarded unreachable code: IL_00a7, IL_010a, IL_0142, IL_0151, IL_01ac, IL_01bb
		int num = 4;
		MemoryStream memoryStream = default(MemoryStream);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
					if (image == null)
					{
						num2 = 3;
						continue;
					}
					break;
				default:
					memoryStream = (MemoryStream)tOtJhDEDJdGcJ6pDIsWO();
					num2 = 2;
					continue;
				case 1:
				case 3:
					WoDiUfEDr65ra3CZojP1(bpmApp, null);
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
					{
						num2 = 2;
					}
					continue;
				case 5:
					return;
				case 2:
					try
					{
						avfo1HEDdFCRd4f3ATee(image, memoryStream, veksRlED9F4duZY2QGJ6());
						int num3 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
						{
							num3 = 1;
						}
						while (true)
						{
							switch (num3)
							{
							default:
								return;
							case 0:
								return;
							case 1:
								LSkYR4EDlSjfBjAEeF35(bpmApp, memoryStream.ToArray());
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
								{
									num3 = 0;
								}
								break;
							}
						}
					}
					finally
					{
						if (memoryStream != null)
						{
							int num4 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
							{
								num4 = 1;
							}
							while (true)
							{
								switch (num4)
								{
								case 1:
									((IDisposable)memoryStream).Dispose();
									num4 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
									{
										num4 = 0;
									}
									continue;
								case 0:
									break;
								}
								break;
							}
						}
					}
				case 7:
					break;
				case 6:
					goto end_IL_0012;
				}
				bpmApp.IconFileName = (string)Hs7hBLEDM12pM4pTBrGe(0x53FA00CE ^ 0x53FE8678);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0)
				{
					num2 = 0;
				}
				continue;
				end_IL_0012:
				break;
			}
			LSkYR4EDlSjfBjAEeF35(bpmApp, null);
			num = 5;
		}
	}

	internal static void InputFilesContent(this IBPMApp bpmApp, byte[] additionalFilesContent, byte[] helpFileContent)
	{
		//Discarded unreachable code: IL_00b6, IL_011b, IL_012a
		int num = 1;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					bpmApp.HelpFileContent = null;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0)
					{
						num2 = 4;
					}
					continue;
				case 6:
					if (helpFileContent.Length == 0)
					{
						num2 = 7;
						continue;
					}
					break;
				case 2:
					return;
				case 10:
					ieXgeMED5kiBMTywhyIA(bpmApp, additionalFilesContent);
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
					{
						num2 = 2;
					}
					continue;
				case 11:
					return;
				case 4:
				case 9:
					if (additionalFilesContent != null)
					{
						num2 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
						{
							num2 = 8;
						}
						continue;
					}
					goto IL_007f;
				case 1:
					if (helpFileContent == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 6;
				case 5:
					break;
				case 8:
					{
						if (additionalFilesContent.Length != 0)
						{
							num2 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
							{
								num2 = 10;
							}
							continue;
						}
						goto IL_007f;
					}
					IL_007f:
					ieXgeMED5kiBMTywhyIA(bpmApp, null);
					num2 = 11;
					continue;
				}
				break;
			}
			pOKOoFEDgowRgDkCakg1(bpmApp, helpFileContent);
			num = 9;
		}
	}

	internal static object Aee0ddED0yLbh0BpVO0h(object P_0)
	{
		return ((ElmaStoreComponentManifest)P_0).Title;
	}

	internal static void GapJkcEDm72jwM3v3oW6(object P_0, object P_1)
	{
		((IBPMApp)P_0).Title = (string)P_1;
	}

	internal static void wZDiPfEDyTpofrtfhRWA(object P_0, object P_1)
	{
		((IBPMApp)P_0).ComponentManifest = P_1;
	}

	internal static bool l9sxCWED7IZ0hvTK4c90()
	{
		return FCaaLYEDAADU5n8DjOQv == null;
	}

	internal static IBPMAppExtensions RuXtwIEDxOu4W2jBXRSG()
	{
		return FCaaLYEDAADU5n8DjOQv;
	}

	internal static object Hs7hBLEDM12pM4pTBrGe(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object tOtJhDEDJdGcJ6pDIsWO()
	{
		return MemoryHelper.GetMemoryStream();
	}

	internal static object veksRlED9F4duZY2QGJ6()
	{
		return ImageFormat.Png;
	}

	internal static void avfo1HEDdFCRd4f3ATee(object P_0, object P_1, object P_2)
	{
		((Image)P_0).Save((Stream)P_1, (ImageFormat)P_2);
	}

	internal static void LSkYR4EDlSjfBjAEeF35(object P_0, object P_1)
	{
		((IBPMApp)P_0).IconData = (byte[])P_1;
	}

	internal static void WoDiUfEDr65ra3CZojP1(object P_0, object P_1)
	{
		((IBPMApp)P_0).IconFileName = (string)P_1;
	}

	internal static void pOKOoFEDgowRgDkCakg1(object P_0, object P_1)
	{
		((IBPMApp)P_0).HelpFileContent = (byte[])P_1;
	}

	internal static void ieXgeMED5kiBMTywhyIA(object P_0, object P_1)
	{
		((IBPMApp)P_0).AdditionalFilesContent = (byte[])P_1;
	}
}
