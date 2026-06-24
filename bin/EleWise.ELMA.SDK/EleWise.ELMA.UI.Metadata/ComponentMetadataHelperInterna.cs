using System;
using System.Collections.Generic;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Model.Views.Toolbar;
using EleWise.ELMA.Scripts.Models;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.UI.Metadata;

internal static class ComponentMetadataHelperInternal
{
	internal const string AssemblyPrefix = "__ComponentAssembly__";

	internal static ComponentMetadataHelperInternal fZYAYaBb7Cq797VAl4VP;

	internal static string ServerEmulationAssemblyName(ComponentMetadata metadata)
	{
		return (string)G147tNBbJDSJkgrrCkv1(ReMQvMBbmCRHMythLFtY(0x5F3078B6 ^ 0x5F309254), ReMQvMBbmCRHMythLFtY(-1317790512 ^ -1317734798), XSPWChBbyjMAZlWl8cM5(metadata), zyxJYfBbMb7yK7ISqHXF());
	}

	internal static string ControllerTypeName(ComponentMetadata metadata)
	{
		return (string)RmhkKnBb92iPAh9EBvV0(XSPWChBbyjMAZlWl8cM5(metadata), ReMQvMBbmCRHMythLFtY(-1939377524 ^ -1939367822));
	}

	internal static string ContextTypeName(ComponentMetadata metadata)
	{
		return (string)EUYtgpBbgGSu7owZoosS(metadata.FullTypeName, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1767720453 ^ -1767705051), sIhFy6BbrsDswkrEF9Hj(SYWKTMBbl0FBLxY13hkG(m4sIIbBbd2daoVxdWyG9(metadata))));
	}

	internal static void ReplaceOldUids(ComponentMetadata metadata, Guid oldMetadataUid)
	{
		//Discarded unreachable code: IL_006a, IL_0079, IL_00d5, IL_00e4, IL_00ef, IL_0185, IL_0194, IL_01e1, IL_01f4, IL_0203, IL_0254, IL_0267, IL_0276, IL_02ca, IL_0489, IL_0498, IL_04a3, IL_0553, IL_058b, IL_059a, IL_05ed, IL_05fc, IL_067d, IL_068c, IL_06bd, IL_06fd, IL_070c, IL_0718
		int num = 2;
		IEnumerator<ViewItem> enumerator = default(IEnumerator<ViewItem>);
		FormViewItem view = default(FormViewItem);
		List<EleWise.ELMA.Model.Dependencies.ComponentDependency>.Enumerator enumerator3 = default(List<EleWise.ELMA.Model.Dependencies.ComponentDependency>.Enumerator);
		List<InputComputedValue>.Enumerator enumerator4 = default(List<InputComputedValue>.Enumerator);
		ActionValue actionValue = default(ActionValue);
		Toolbar toolbar = default(Toolbar);
		FormViewItem formViewItem = default(FormViewItem);
		PropertyViewItem propertyViewItem = default(PropertyViewItem);
		ButtonViewItem buttonViewItem = default(ButtonViewItem);
		ViewItem current = default(ViewItem);
		IEnumerator<ToolbarItem> enumerator2 = default(IEnumerator<ToolbarItem>);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					enumerator = view.GetAllItems(ignoreHide: false).Concat(view).GetEnumerator();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
					{
						num2 = 3;
					}
					continue;
				case 4:
					try
					{
						while (true)
						{
							int num9;
							if (!enumerator3.MoveNext())
							{
								int num8 = 3;
								num9 = num8;
								goto IL_0088;
							}
							goto IL_00a2;
							IL_0088:
							switch (num9)
							{
							case 1:
								break;
							default:
								try
								{
									while (true)
									{
										int num10;
										if (!enumerator4.MoveNext())
										{
											num10 = 4;
											goto IL_00f3;
										}
										goto IL_0145;
										IL_0111:
										actionValue.MethodName = (string)PmidbmBbYiZY61bl0N76(actionValue.MethodName, metadata.Uid, oldMetadataUid);
										num10 = 1;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
										{
											num10 = 1;
										}
										goto IL_00f3;
										IL_0145:
										InputComputedValue current3 = enumerator4.Current;
										k2H7x9BhoHke2PX3Vmau(current3, PmidbmBbYiZY61bl0N76(eeei1nBhWisiF7wH696l(current3), lSrgp7BbjaX7svq8u4j7(metadata), oldMetadataUid));
										if ((actionValue = qTlQSDBhb0qL1vyFML1X(current3) as ActionValue) == null)
										{
											num10 = 2;
											goto IL_00f3;
										}
										goto IL_0111;
										IL_00f3:
										switch (num10)
										{
										case 3:
											goto IL_0145;
										case 1:
										case 2:
											continue;
										case 4:
											goto end_IL_019f;
										}
										goto IL_0111;
										continue;
										end_IL_019f:
										break;
									}
								}
								finally
								{
									((IDisposable)enumerator4).Dispose();
									int num11 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
									{
										num11 = 0;
									}
									switch (num11)
									{
									case 0:
										break;
									}
								}
								continue;
							case 2:
								continue;
							case 3:
								return;
							}
							goto IL_00a2;
							IL_00a2:
							enumerator4 = enumerator3.Current.Inputs.GetEnumerator();
							num9 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
							{
								num9 = 0;
							}
							goto IL_0088;
						}
					}
					finally
					{
						((IDisposable)enumerator3).Dispose();
						int num12 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
						{
							num12 = 0;
						}
						switch (num12)
						{
						case 0:
							break;
						}
					}
				case 2:
					view = ((ComponentContentMetadata)m4sIIbBbd2daoVxdWyG9(metadata)).View;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e != 0)
					{
						num2 = 1;
					}
					continue;
				case 0:
					return;
				case 5:
					break;
				case 3:
					try
					{
						while (true)
						{
							IL_0662:
							int num3;
							if (!enumerator.MoveNext())
							{
								num3 = 9;
								goto IL_02d8;
							}
							goto IL_0460;
							IL_02d8:
							while (true)
							{
								switch (num3)
								{
								case 2:
									toolbar = (Toolbar)FddqtoBbs2g8lSSxPU5L(formViewItem);
									num3 = 14;
									continue;
								case 13:
									((ViewAttributes)RDj3T4BbzsQ1CKPynsBA(propertyViewItem)).OnChangeScriptName = (string)PmidbmBbYiZY61bl0N76(BVApZIBhFIwpaZdy89l5(RDj3T4BbzsQ1CKPynsBA(propertyViewItem)), lSrgp7BbjaX7svq8u4j7(metadata), oldMetadataUid);
									num3 = 5;
									continue;
								case 12:
									ReplaceDynamicPropertiesOldUids(toolbar.DynamicProperties, metadata.Uid, oldMetadataUid);
									num3 = 17;
									continue;
								case 4:
									if ((buttonViewItem = current as ButtonViewItem) != null)
									{
										num3 = 6;
										continue;
									}
									goto case 16;
								case 6:
									LlldD1BbLCqcVR7yTCFT(buttonViewItem, PmidbmBbYiZY61bl0N76(tfJC0RBb5UJw5OUAWtti(buttonViewItem), lSrgp7BbjaX7svq8u4j7(metadata), oldMetadataUid));
									num3 = 16;
									continue;
								case 14:
									if (toolbar == null)
									{
										num3 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
										{
											num3 = 0;
										}
										continue;
									}
									goto case 12;
								case 17:
									enumerator2 = toolbar.GetAllItems(ignoreHide: false).GetEnumerator();
									num3 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
									{
										num3 = 15;
									}
									continue;
								default:
									if ((propertyViewItem = current as PropertyViewItem) != null)
									{
										num3 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
										{
											num3 = 1;
										}
										continue;
									}
									goto case 8;
								case 3:
									TdqOSVBbUfxh25J9vNbQ(formViewItem, PmidbmBbYiZY61bl0N76(formViewItem.OnLoadScriptName, lSrgp7BbjaX7svq8u4j7(metadata), oldMetadataUid));
									num3 = 2;
									continue;
								case 10:
									break;
								case 15:
									try
									{
										while (true)
										{
											int num5;
											if (!enumerator2.MoveNext())
											{
												num5 = 2;
												goto IL_04a7;
											}
											goto IL_04d3;
											IL_04a7:
											switch (num5)
											{
											case 1:
												break;
											default:
												goto IL_04d3;
											case 2:
												goto end_IL_04bd;
											}
											continue;
											IL_04d3:
											ToolbarItem current2 = enumerator2.Current;
											if (current2 is Button button)
											{
												button.ScriptName = (string)PmidbmBbYiZY61bl0N76(button.ScriptName, lSrgp7BbjaX7svq8u4j7(metadata), oldMetadataUid);
											}
											ReplaceDynamicPropertiesOldUids(current2.DynamicProperties, metadata.Uid, oldMetadataUid);
											num5 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0)
											{
												num5 = 1;
											}
											goto IL_04a7;
											continue;
											end_IL_04bd:
											break;
										}
									}
									finally
									{
										if (enumerator2 != null)
										{
											int num6 = 1;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
											{
												num6 = 0;
											}
											while (true)
											{
												switch (num6)
												{
												case 1:
													Eama3eBbcZZhkpHS1fIc(enumerator2);
													num6 = 0;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 != 0)
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
									goto default;
								case 8:
								case 11:
									ReplaceDynamicPropertiesOldUids(current.DynamicProperties, metadata.Uid, oldMetadataUid);
									num3 = 7;
									continue;
								case 1:
									if (RDj3T4BbzsQ1CKPynsBA(propertyViewItem) == null)
									{
										num3 = 11;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
										{
											num3 = 10;
										}
										continue;
									}
									goto case 13;
								case 16:
									if ((formViewItem = current as FormViewItem) != null)
									{
										int num4 = 3;
										num3 = num4;
										continue;
									}
									goto default;
								case 5:
									((ViewAttributes)RDj3T4BbzsQ1CKPynsBA(propertyViewItem)).ValidationScriptName = (string)PmidbmBbYiZY61bl0N76(ESZUHrBhBnxZNyfgq38o(RDj3T4BbzsQ1CKPynsBA(propertyViewItem)), lSrgp7BbjaX7svq8u4j7(metadata), oldMetadataUid);
									num3 = 8;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
									{
										num3 = 7;
									}
									continue;
								case 7:
									goto IL_0662;
								case 9:
									goto end_IL_0662;
								}
								break;
							}
							goto IL_0460;
							IL_0460:
							current = enumerator.Current;
							num3 = 2;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
							{
								num3 = 4;
							}
							goto IL_02d8;
							continue;
							end_IL_0662:
							break;
						}
					}
					finally
					{
						int num7;
						if (enumerator == null)
						{
							num7 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
							{
								num7 = 1;
							}
							goto IL_06c1;
						}
						goto IL_06d7;
						IL_06d7:
						Eama3eBbcZZhkpHS1fIc(enumerator);
						num7 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
						{
							num7 = 0;
						}
						goto IL_06c1;
						IL_06c1:
						switch (num7)
						{
						default:
							goto end_IL_069c;
						case 2:
							break;
						case 1:
							goto end_IL_069c;
						case 0:
							goto end_IL_069c;
						}
						goto IL_06d7;
						end_IL_069c:;
					}
					break;
				}
				break;
			}
			enumerator3 = metadata.ComponentDependencies.GetEnumerator();
			num = 4;
		}
	}

	private static void ReplaceDynamicPropertiesOldUids(List<ComputedValue> list, Guid newMetadataUid, Guid oldMetadataUid)
	{
		foreach (ComputedValue item in list)
		{
			item.MethodName = GetNewScriptMethodName(item.MethodName, newMetadataUid, oldMetadataUid);
			if (item.Value is ActionValue actionValue)
			{
				actionValue.MethodName = GetNewScriptMethodName(actionValue.MethodName, newMetadataUid, oldMetadataUid);
			}
		}
	}

	private static string GetNewScriptMethodName(object oldMethodName, Guid componentMetadataUid, Guid oldMetadataUid)
	{
		//Discarded unreachable code: IL_009f, IL_00ae, IL_0141
		int num = 5;
		int num2 = num;
		ScriptMethodInfo scriptMethodInfo = default(ScriptMethodInfo);
		while (true)
		{
			switch (num2)
			{
			case 5:
				if (quaVbgBhhi8EUovlqJOB(oldMethodName))
				{
					num2 = 4;
					continue;
				}
				break;
			case 6:
				if (scriptMethodInfo == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0)
					{
						num2 = 0;
					}
					continue;
				}
				goto case 3;
			case 1:
			case 4:
				return (string)oldMethodName;
			default:
				return (string)oldMethodName;
			case 3:
				if (!J4tVh4BhEygCMytQJ7MS(Re4RywBhGwWVCshnQE48(scriptMethodInfo), oldMetadataUid))
				{
					fQRWI1Bhf2vQXca1bk3B(scriptMethodInfo, componentMetadataUid);
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
					{
						num2 = 7;
					}
				}
				else
				{
					num2 = 2;
				}
				continue;
			case 7:
				return (string)xpcdKBBhQIaam6VUnUNw(scriptMethodInfo);
			case 8:
				break;
			}
			if (((string)oldMethodName).StartsWith((string)ReMQvMBbmCRHMythLFtY(-1108654032 ^ -1108655156)))
			{
				scriptMethodInfo = ScriptMethodInfoHelper.Deserialize((string)oldMethodName);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
				{
					num2 = 6;
				}
			}
			else
			{
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
				{
					num2 = 1;
				}
			}
		}
	}

	internal static object ReMQvMBbmCRHMythLFtY(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object XSPWChBbyjMAZlWl8cM5(object P_0)
	{
		return ((ComponentMetadata)P_0).FullTypeName;
	}

	internal static Guid zyxJYfBbMb7yK7ISqHXF()
	{
		return Guid.NewGuid();
	}

	internal static object G147tNBbJDSJkgrrCkv1(object P_0, object P_1, object P_2, object P_3)
	{
		return string.Format((string)P_0, P_1, P_2, P_3);
	}

	internal static bool sVoxYmBbxCGRmxpsk4qS()
	{
		return fZYAYaBb7Cq797VAl4VP == null;
	}

	internal static ComponentMetadataHelperInternal p7AaQZBb0SHlSmCEFwee()
	{
		return fZYAYaBb7Cq797VAl4VP;
	}

	internal static object RmhkKnBb92iPAh9EBvV0(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static object m4sIIbBbd2daoVxdWyG9(object P_0)
	{
		return ((ComponentMetadata)P_0).Content;
	}

	internal static object SYWKTMBbl0FBLxY13hkG(object P_0)
	{
		return ((ComponentContentMetadata)P_0).Context;
	}

	internal static object sIhFy6BbrsDswkrEF9Hj(object P_0)
	{
		return ((NamedMetadata)P_0).Name;
	}

	internal static object EUYtgpBbgGSu7owZoosS(object P_0, object P_1, object P_2)
	{
		return (string)P_0 + (string)P_1 + (string)P_2;
	}

	internal static object tfJC0RBb5UJw5OUAWtti(object P_0)
	{
		return ((ButtonViewItem)P_0).ScriptName;
	}

	internal static Guid lSrgp7BbjaX7svq8u4j7(object P_0)
	{
		return ((AbstractMetadata)P_0).Uid;
	}

	internal static object PmidbmBbYiZY61bl0N76(object P_0, Guid componentMetadataUid, Guid oldMetadataUid)
	{
		return GetNewScriptMethodName(P_0, componentMetadataUid, oldMetadataUid);
	}

	internal static void LlldD1BbLCqcVR7yTCFT(object P_0, object P_1)
	{
		((ButtonViewItem)P_0).ScriptName = (string)P_1;
	}

	internal static void TdqOSVBbUfxh25J9vNbQ(object P_0, object P_1)
	{
		((FormView)P_0).OnLoadScriptName = (string)P_1;
	}

	internal static object FddqtoBbs2g8lSSxPU5L(object P_0)
	{
		return ((FormViewItem)P_0).Toolbar;
	}

	internal static void Eama3eBbcZZhkpHS1fIc(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static object RDj3T4BbzsQ1CKPynsBA(object P_0)
	{
		return ((PropertyViewItem)P_0).Attributes;
	}

	internal static object BVApZIBhFIwpaZdy89l5(object P_0)
	{
		return ((ViewAttributes)P_0).OnChangeScriptName;
	}

	internal static object ESZUHrBhBnxZNyfgq38o(object P_0)
	{
		return ((ViewAttributes)P_0).ValidationScriptName;
	}

	internal static object eeei1nBhWisiF7wH696l(object P_0)
	{
		return ((ComputedValue)P_0).MethodName;
	}

	internal static void k2H7x9BhoHke2PX3Vmau(object P_0, object P_1)
	{
		((ComputedValue)P_0).MethodName = (string)P_1;
	}

	internal static object qTlQSDBhb0qL1vyFML1X(object P_0)
	{
		return ((ComputedValue)P_0).Value;
	}

	internal static bool quaVbgBhhi8EUovlqJOB(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static Guid Re4RywBhGwWVCshnQE48(object P_0)
	{
		return ((ScriptMethodInfo)P_0).MetadataUid;
	}

	internal static bool J4tVh4BhEygCMytQJ7MS(Guid P_0, Guid P_1)
	{
		return P_0 != P_1;
	}

	internal static void fQRWI1Bhf2vQXca1bk3B(object P_0, Guid value)
	{
		((ScriptMethodInfo)P_0).MetadataUid = value;
	}

	internal static object xpcdKBBhQIaam6VUnUNw(object P_0)
	{
		return ScriptMethodInfoHelper.Serialize((ScriptMethodInfo)P_0);
	}
}
