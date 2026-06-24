using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Diagrams;
using EleWise.ELMA.Memory;
using EleWise.ELMA.Services;
using EleWise.ELMA.Workflow.Diagrams;
using EleWise.ELMA.Workflow.Diagrams.Activities;
using EleWise.ELMA.Workflow.Models;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Services;

internal static class WorkflowInstanceStateHelper
{
	internal static WorkflowInstanceStateHelper N9J4bKMEEc6v3o2ApZD;

	public static byte[] GetChangedWorkflowInstanceState(IWorkflowInstance instance, IWorkflowProcess newProcess)
	{
		//Discarded unreachable code: IL_009c, IL_00d4, IL_00f3, IL_0123, IL_0132, IL_0161, IL_01c0, IL_01df, IL_01ee, IL_021b, IL_022a, IL_02ae
		int num = 4;
		XmlDocument xmlDocument = default(XmlDocument);
		MemoryStream memoryStream2 = default(MemoryStream);
		MemoryStream memoryStream = default(MemoryStream);
		byte[] result = default(byte[]);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 5:
					if (vhDcVnkOy3E6xlj5AlT(instance) != null)
					{
						num2 = 9;
						continue;
					}
					goto case 10;
				case 10:
					return Array.Empty<byte>();
				case 9:
					xmlDocument = new XmlDocument();
					num = 7;
					break;
				case 8:
					try
					{
						dUaICUkY1jpEgQ8uCdg(xmlDocument, memoryStream2);
						int num5 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ba57b850b1d34fd9bce66a583e71dc16 != 0)
						{
							num5 = 0;
						}
						switch (num5)
						{
						case 0:
							break;
						}
					}
					finally
					{
						int num6;
						if (memoryStream2 == null)
						{
							num6 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cb262bcfe4074a1ab16e653815d57f28 == 0)
							{
								num6 = 0;
							}
							goto IL_00d8;
						}
						goto IL_0101;
						IL_0101:
						TtIRwmk8GCRfgorN0Uh(memoryStream2);
						num6 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ffb1346d351f436b84bb1e9954c3bfa8 == 0)
						{
							num6 = 1;
						}
						goto IL_00d8;
						IL_00d8:
						switch (num6)
						{
						default:
							goto end_IL_00b3;
						case 0:
							goto end_IL_00b3;
						case 2:
							break;
						case 1:
							goto end_IL_00b3;
						}
						goto IL_0101;
						end_IL_00b3:;
					}
					goto default;
				case 2:
					try
					{
						fnZLjyky7ypePHiKGqT(xmlDocument, memoryStream);
						int num3 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d2f119e188994b55be2499c193b880fb != 0)
						{
							num3 = 1;
						}
						while (true)
						{
							switch (num3)
							{
							case 1:
								result = memoryStream.ToArray();
								num3 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1733a11cae754a598119b94f8d9e4971 == 0)
								{
									num3 = 0;
								}
								break;
							default:
								return result;
							case 0:
								return result;
							}
						}
					}
					finally
					{
						int num4;
						if (memoryStream == null)
						{
							num4 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5816b3723c134946ad9294172266312e == 0)
							{
								num4 = 0;
							}
							goto IL_01c4;
						}
						goto IL_01f9;
						IL_01f9:
						TtIRwmk8GCRfgorN0Uh(memoryStream);
						num4 = 2;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a9be7e056b4e4b6e863b634c418144f1 == 0)
						{
							num4 = 0;
						}
						goto IL_01c4;
						IL_01c4:
						switch (num4)
						{
						default:
							goto end_IL_019f;
						case 0:
							goto end_IL_019f;
						case 1:
							break;
						case 2:
							goto end_IL_019f;
						}
						goto IL_01f9;
						end_IL_019f:;
					}
				case 1:
					return result;
				default:
					xmlDocument = (XmlDocument)gPdUBsklXXrjHj7OWru(xmlDocument, hkhwNfkJ67R3LxJ0mMi(N1eSlWkskdL6dBw2BgG(instance)), hkhwNfkJ67R3LxJ0mMi(newProcess));
					num2 = 6;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c7fe5d092d804f7e91041fb2338cec1a != 0)
					{
						num2 = 2;
					}
					continue;
				case 4:
					E9nlAZkKSgTSW5rHluL(instance, nnyRWTMzW60HOTVbEBA(0x42311138 ^ 0x4231483E));
					num2 = 3;
					continue;
				case 7:
					memoryStream2 = (MemoryStream)etRL3MkvCsaBckteWhA(gtL5JxkZDissTRmWUOi(vhDcVnkOy3E6xlj5AlT(instance)), false);
					num2 = 8;
					continue;
				case 6:
					memoryStream = (MemoryStream)LWmFMAk0aBMDlmpfkBB();
					num = 2;
					break;
				case 3:
					Contract.ArgumentNotNull(newProcess, (string)nnyRWTMzW60HOTVbEBA(0x3C1FFB55 ^ 0x3C1F078B));
					num2 = 5;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5d3bc916b5664717ac60544de077bd16 != 0)
					{
						num2 = 5;
					}
					continue;
				}
				break;
			}
		}
	}

	private static XmlDocument FixActivityId(object xmldoc, object oldDiagram, object newDiagram)
	{
		//Discarded unreachable code: IL_00d5, IL_0279, IL_0288, IL_049e, IL_04eb, IL_0545
		int num = 14;
		IWorkflowRootActivityInfo workflowRootActivityInfo = default(IWorkflowRootActivityInfo);
		_003C_003Ec__DisplayClass1_0 _003C_003Ec__DisplayClass1_ = default(_003C_003Ec__DisplayClass1_0);
		IEnumerator enumerator = default(IEnumerator);
		List<WorkflowActivity> activities2 = default(List<WorkflowActivity>);
		List<WorkflowActivity> activities = default(List<WorkflowActivity>);
		IWorkflowRootActivityInfo workflowRootActivityInfo2 = default(IWorkflowRootActivityInfo);
		WorkflowRootActivity workflowRootActivity = default(WorkflowRootActivity);
		Element element = default(Element);
		int num4 = default(int);
		XmlNode xmlNode = default(XmlNode);
		_003C_003Ec__DisplayClass1_1 _003C_003Ec__DisplayClass1_2 = default(_003C_003Ec__DisplayClass1_1);
		int num6 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 5:
					E9nlAZkKSgTSW5rHluL(xmldoc, nnyRWTMzW60HOTVbEBA(-935313063 ^ -935281233));
					num2 = 16;
					continue;
				case 18:
					if (workflowRootActivityInfo == null)
					{
						num2 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ecf910d183864897a7c8ec77e01689a4 == 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 15;
				case 11:
					Contract.ArgumentNotNull(_003C_003Ec__DisplayClass1_.newDiagram, (string)nnyRWTMzW60HOTVbEBA(0x75872B6 ^ 0x7588FA8));
					num2 = 10;
					continue;
				case 3:
					enumerator = (IEnumerator)nmOG07kcOF9nSVkUTuV(u6UGvdkByCZYs65iGFu(xmldoc, nnyRWTMzW60HOTVbEBA(0x37F755F5 ^ 0x37F7A8C3)));
					num2 = 12;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bae2bde9e5844c638021cdb56fc01122 == 0)
					{
						num2 = 17;
					}
					continue;
				case 8:
					lXvypnkgckfoXyP6uSn(activities2);
					num2 = 3;
					continue;
				case 9:
					_003C_003Ec__DisplayClass1_.newDiagram = (WorkflowDiagram)newDiagram;
					num2 = 5;
					continue;
				case 6:
					lXvypnkgckfoXyP6uSn(activities);
					num2 = 8;
					continue;
				case 10:
					workflowRootActivityInfo2 = ((ComponentManager)cgMHFFkmUlOa6rT2qrS()).GetExtensionPoints<IWorkflowRootActivityInfo>().FirstOrDefault(_003C_003Ec__DisplayClass1_._003CFixActivityId_003Eb__0);
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5816b3723c134946ad9294172266312e == 0)
					{
						num2 = 0;
					}
					continue;
				case 7:
					if (workflowRootActivityInfo2 == null)
					{
						num2 = 2;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_43af423d081c48e3bc6cea30ce47523d != 0)
						{
							num2 = 2;
						}
						continue;
					}
					goto case 18;
				case 13:
					_003C_003Ec__DisplayClass1_.oldDiagram = (WorkflowDiagram)oldDiagram;
					num2 = 9;
					continue;
				case 4:
				{
					WorkflowRootActivity obj = (WorkflowRootActivity)Ec2PvXktUklKVG0sCa4(tgedpKkbWlO5SRyMZaV(workflowRootActivityInfo));
					UmaFpxk5r9GB9kw1fW4(workflowRootActivity, _003C_003Ec__DisplayClass1_.oldDiagram);
					UmaFpxk5r9GB9kw1fW4(obj, _003C_003Ec__DisplayClass1_.newDiagram);
					activities = workflowRootActivity.Activities;
					activities2 = obj.Activities;
					num2 = 5;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b30151cb26574dfaa8f9d818b0352d3b != 0)
					{
						num2 = 6;
					}
					continue;
				}
				case 16:
					Contract.ArgumentNotNull(_003C_003Ec__DisplayClass1_.oldDiagram, (string)nnyRWTMzW60HOTVbEBA(-1574607501 ^ -1574594443));
					num2 = 8;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_08023922bb0e4e809e5cff73a2b04988 != 0)
					{
						num2 = 11;
					}
					continue;
				case 17:
					try
					{
						while (true)
						{
							int num3;
							if (!aPO5bIkHv9SdeME281M(enumerator))
							{
								num3 = 9;
								goto IL_0297;
							}
							goto IL_03f7;
							IL_0456:
							element = (Element)zgKmHNkdPEI5nUacimw(activities[num4 - 2]);
							int num5 = 5;
							goto IL_0293;
							IL_03f7:
							xmlNode = (XmlNode)ds3VZfkPuXeSplAoT3a(enumerator);
							num5 = 2;
							goto IL_0293;
							IL_0293:
							num3 = num5;
							goto IL_0297;
							IL_0297:
							while (true)
							{
								switch (num3)
								{
								case 1:
									_003C_003Ec__DisplayClass1_2.oldActivityUid = NREm1skuEgshjmRwhUS(zgKmHNkdPEI5nUacimw(activities[num4 - 2]));
									num3 = 4;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e9561fecdd4d49678d9f9ea7d295fb1b == 0)
									{
										num3 = 8;
									}
									continue;
								case 6:
									break;
								case 10:
									goto IL_0319;
								case 3:
									num4 = DecodeIntegerFromBase64(uCbrIAkX3yXKsgx9NLA(xmlNode));
									num3 = 4;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a680afde07ce4ae5b71c411a1f75109b == 0)
									{
										num3 = 4;
									}
									continue;
								case 8:
									num6 = activities2.FindIndex(_003C_003Ec__DisplayClass1_2._003CFixActivityId_003Eb__2) + 2;
									num3 = 10;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_eb7de45300244c968ac00be3ffdf3d29 == 0)
									{
										num3 = 7;
									}
									continue;
								case 5:
									throw new IndexOutOfRangeException(SR.T((string)nnyRWTMzW60HOTVbEBA(0x37F755F5 ^ 0x37F7A8A7), element.Name, NREm1skuEgshjmRwhUS(element)));
								case 7:
									goto IL_03f7;
								case 4:
									if (num4 != 1)
									{
										num3 = 1;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_08023922bb0e4e809e5cff73a2b04988 == 0)
										{
											num3 = 0;
										}
										continue;
									}
									break;
								case 2:
									_003C_003Ec__DisplayClass1_2 = new _003C_003Ec__DisplayClass1_1();
									num3 = 3;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bae4e393cddc4c98b9896b25c9e18c7d != 0)
									{
										num3 = 1;
									}
									continue;
								default:
									goto IL_0456;
								case 9:
									return (XmlDocument)xmldoc;
								}
								break;
								IL_0319:
								if (num6 == 1)
								{
									num3 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f870ea690334e7ab7599d275d195e9a == 0)
									{
										num3 = 0;
									}
									continue;
								}
								BF9wgFknEUJKZFUWnHd(xmlNode, Wgf4DBkDAJsrBbaEbam(num6));
								num3 = 6;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d42a29e78d4a45518985de3631ade50c != 0)
								{
									num3 = 2;
								}
							}
						}
					}
					finally
					{
						IDisposable disposable = enumerator as IDisposable;
						int num7 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_160bffb148c14c5da92d8d6ddf481bdc == 0)
						{
							num7 = 1;
						}
						while (true)
						{
							switch (num7)
							{
							case 1:
								if (disposable != null)
								{
									num7 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f453500aaab143479696408f48a03c17 == 0)
									{
										num7 = 0;
									}
									continue;
								}
								break;
							default:
								disposable.Dispose();
								num7 = 2;
								continue;
							case 2:
								break;
							}
							break;
						}
					}
				case 1:
				case 2:
				case 12:
					throw new InvalidOperationException((string)fv1viKkLYUnXt7PxVI3(nnyRWTMzW60HOTVbEBA(-1638225214 ^ -1638247274)));
				case 15:
					workflowRootActivity = (WorkflowRootActivity)Ec2PvXktUklKVG0sCa4(workflowRootActivityInfo2.ActivityType);
					num2 = 4;
					continue;
				case 14:
					_003C_003Ec__DisplayClass1_ = new _003C_003Ec__DisplayClass1_0();
					num2 = 13;
					continue;
				}
				break;
			}
			workflowRootActivityInfo = ((ComponentManager)cgMHFFkmUlOa6rT2qrS()).GetExtensionPoints<IWorkflowRootActivityInfo>().FirstOrDefault(_003C_003Ec__DisplayClass1_._003CFixActivityId_003Eb__1);
			num = 7;
		}
	}

	private static int DecodeIntegerFromBase64(object encoded)
	{
		//Discarded unreachable code: IL_007b, IL_008a, IL_0095, IL_015a, IL_019a, IL_01a9, IL_01b5
		int num = 1;
		int num2 = num;
		int num3 = default(int);
		IEnumerator<byte> enumerator = default(IEnumerator<byte>);
		byte current = default(byte);
		while (true)
		{
			switch (num2)
			{
			case 1:
				num3 = 0;
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e4c570270f54493d8f3f4763a72f63f7 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				enumerator = ((IEnumerable<byte>)iMogEMkfdgJTOOYng9s(encoded)).Reverse().GetEnumerator();
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bae4e393cddc4c98b9896b25c9e18c7d == 0)
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
						if (!aPO5bIkHv9SdeME281M(enumerator))
						{
							num4 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d843b0b7f23e489fb6d586d64b0a634a == 0)
							{
								num4 = 0;
							}
							goto IL_0099;
						}
						goto IL_00dd;
						IL_00dd:
						current = enumerator.Current;
						num4 = 4;
						goto IL_0099;
						IL_0099:
						while (true)
						{
							switch (num4)
							{
							case 1:
								break;
							case 2:
								goto IL_00dd;
							case 4:
								num3 <<= 7;
								num4 = 3;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4cc62744d0eb4cd68219b70dcad3e68e == 0)
								{
									num4 = 3;
								}
								continue;
							case 3:
								num3 |= current & 0x7F;
								num4 = 1;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_43af423d081c48e3bc6cea30ce47523d != 0)
								{
									num4 = 1;
								}
								continue;
							default:
								return num3;
							case 0:
								return num3;
							}
							break;
						}
					}
				}
				finally
				{
					int num5;
					if (enumerator == null)
					{
						num5 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5816b3723c134946ad9294172266312e == 0)
						{
							num5 = 1;
						}
						goto IL_015e;
					}
					goto IL_0174;
					IL_0174:
					enumerator.Dispose();
					num5 = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bd84f42638494cb6b4427f8e13ec59af != 0)
					{
						num5 = 2;
					}
					goto IL_015e;
					IL_015e:
					switch (num5)
					{
					case 1:
						goto end_IL_0139;
					case 2:
						goto end_IL_0139;
					}
					goto IL_0174;
					end_IL_0139:;
				}
			case 3:
				return num3;
			}
		}
	}

	private static string EncodeIntegerToBase64(int value)
	{
		//Discarded unreachable code: IL_0041, IL_007a, IL_0089
		int num = 4;
		List<byte> list = default(List<byte>);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
					break;
				default:
					if ((value & 0xFFFFFF80u) != 0L)
					{
						num2 = 6;
						continue;
					}
					goto case 2;
				case 2:
					list.Add((byte)value);
					num2 = 7;
					continue;
				case 5:
				case 6:
					list.Add((byte)(((uint)value & 0x7Fu) | 0x80u));
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bf623f11574746d6bf3837b66460c576 != 0)
					{
						num2 = 1;
					}
					continue;
				case 1:
					value >>= 7;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_eb7de45300244c968ac00be3ffdf3d29 != 0)
					{
						num2 = 0;
					}
					continue;
				case 7:
					return Convert.ToBase64String((byte[])khsoOXk9BJ3hwS2NKCE(list));
				}
				break;
			}
			list = new List<byte>();
			num = 3;
		}
	}

	internal static object nnyRWTMzW60HOTVbEBA(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void E9nlAZkKSgTSW5rHluL(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static object vhDcVnkOy3E6xlj5AlT(object P_0)
	{
		return ((IWorkflowInstance)P_0).State;
	}

	internal static object gtL5JxkZDissTRmWUOi(object P_0)
	{
		return ((IWorkflowInstanceState)P_0).State;
	}

	internal static object etRL3MkvCsaBckteWhA(object P_0, bool P_1)
	{
		return MemoryHelper.GetMemoryStream((byte[])P_0, P_1);
	}

	internal static void dUaICUkY1jpEgQ8uCdg(object P_0, object P_1)
	{
		((XmlDocument)P_0).Load((Stream)P_1);
	}

	internal static void TtIRwmk8GCRfgorN0Uh(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static object N1eSlWkskdL6dBw2BgG(object P_0)
	{
		return ((IWorkflowInstance)P_0).Process;
	}

	internal static object hkhwNfkJ67R3LxJ0mMi(object P_0)
	{
		return ((IWorkflowProcess)P_0).Diagram;
	}

	internal static object gPdUBsklXXrjHj7OWru(object P_0, object P_1, object P_2)
	{
		return FixActivityId(P_0, P_1, P_2);
	}

	internal static object LWmFMAk0aBMDlmpfkBB()
	{
		return MemoryHelper.GetMemoryStream();
	}

	internal static void fnZLjyky7ypePHiKGqT(object P_0, object P_1)
	{
		((XmlDocument)P_0).Save((Stream)P_1);
	}

	internal static bool Ck3f5gMwKxunYDUXl9n()
	{
		return N9J4bKMEEc6v3o2ApZD == null;
	}

	internal static WorkflowInstanceStateHelper WPHoWKM4IgJ3m4NwMWO()
	{
		return N9J4bKMEEc6v3o2ApZD;
	}

	internal static object cgMHFFkmUlOa6rT2qrS()
	{
		return ComponentManager.Current;
	}

	internal static object Ec2PvXktUklKVG0sCa4(Type P_0)
	{
		return Locator.GetServiceNotNull(P_0);
	}

	internal static Type tgedpKkbWlO5SRyMZaV(object P_0)
	{
		return ((IWorkflowRootActivityInfo)P_0).ActivityType;
	}

	internal static void UmaFpxk5r9GB9kw1fW4(object P_0, object P_1)
	{
		((WorkflowRootActivity)P_0).LoadFromDiagram((WorkflowDiagram)P_1);
	}

	internal static void lXvypnkgckfoXyP6uSn(object P_0)
	{
		((List<WorkflowActivity>)P_0).Reverse();
	}

	internal static object u6UGvdkByCZYs65iGFu(object P_0, object P_1)
	{
		return ((XmlDocument)P_0).GetElementsByTagName((string)P_1);
	}

	internal static object nmOG07kcOF9nSVkUTuV(object P_0)
	{
		return ((XmlNodeList)P_0).GetEnumerator();
	}

	internal static object ds3VZfkPuXeSplAoT3a(object P_0)
	{
		return ((IEnumerator)P_0).Current;
	}

	internal static object uCbrIAkX3yXKsgx9NLA(object P_0)
	{
		return ((XmlNode)P_0).InnerText;
	}

	internal static object zgKmHNkdPEI5nUacimw(object P_0)
	{
		return ((WorkflowActivity)P_0).Element;
	}

	internal static Guid NREm1skuEgshjmRwhUS(object P_0)
	{
		return ((Element)P_0).Uid;
	}

	internal static object Wgf4DBkDAJsrBbaEbam(int value)
	{
		return EncodeIntegerToBase64(value);
	}

	internal static void BF9wgFknEUJKZFUWnHd(object P_0, object P_1)
	{
		((XmlNode)P_0).InnerText = (string)P_1;
	}

	internal static bool aPO5bIkHv9SdeME281M(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static object fv1viKkLYUnXt7PxVI3(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static object iMogEMkfdgJTOOYng9s(object P_0)
	{
		return Convert.FromBase64String((string)P_0);
	}

	internal static object khsoOXk9BJ3hwS2NKCE(object P_0)
	{
		return ((List<byte>)P_0).ToArray();
	}
}
