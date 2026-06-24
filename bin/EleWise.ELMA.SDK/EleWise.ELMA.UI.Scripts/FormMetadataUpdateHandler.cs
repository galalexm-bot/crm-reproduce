using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Model.Transformations;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Model.Views.Toolbar;
using EleWise.ELMA.Scripts.Models;
using EleWise.ELMA.UI.Metadata;
using EleWise.ELMA.UI.Models;
using j3AmrhgkCleVTGdEwA;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.UI.Scripts;

[Component]
internal abstract class FormMetadataUpdateHandler : IMetadataUpdateHandler
{
	internal static FormMetadataUpdateHandler sM7DfOrBsi0mRFfAE3m;

	protected abstract string OnLoadScriptName { get; }

	protected abstract string ItemViewModelTypeName { get; }

	public abstract bool Check(IMetadata metadata);

	public void UpdateMetadata(IMetadataUpdateResult updateResult)
	{
		//Discarded unreachable code: IL_0149, IL_0158, IL_0163, IL_021d, IL_0230, IL_023f, IL_0288
		int num = 9;
		int num2 = num;
		ComponentMetadata componentMetadata = default(ComponentMetadata);
		FormPartMetadata content = default(FormPartMetadata);
		ComponentMetadataItem componentMetadataItem = default(ComponentMetadataItem);
		List<PropertyMetadata>.Enumerator enumerator = default(List<PropertyMetadata>.Enumerator);
		PropertyMetadata current = default(PropertyMetadata);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 2:
				AdditionalMetadataActions((FormMetadata)dVjlPRrvVq5X37SMaZW(updateResult), componentMetadata);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0)
				{
					num2 = 0;
				}
				continue;
			case 6:
				return;
			case 7:
				content = GetContent(updateResult);
				num2 = 10;
				continue;
			case 8:
				if (componentMetadataItem == null)
				{
					return;
				}
				num2 = 7;
				continue;
			case 4:
				enumerator = ((ClassMetadata)MrqR0HrbcpOZmygTdOe(content)).Properties.GetEnumerator();
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
				{
					num2 = 4;
				}
				continue;
			case 3:
				drI8OErCKEvsEppV7cN(H9wAp3rhRixiAKGTMh0(componentMetadata), (FormViewItem)jhjd7QrQgDm82pob9Aj(CeoNSMrfeKUhGhvEX5w(content)));
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0)
				{
					num2 = 0;
				}
				continue;
			case 10:
				componentMetadata = (ComponentMetadata)componentMetadataItem.Metadata;
				num2 = 4;
				continue;
			case 9:
				componentMetadataItem = updateResult.Entities.FirstOrDefault() as ComponentMetadataItem;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
				{
					num2 = 8;
				}
				continue;
			case 5:
				try
				{
					while (true)
					{
						IL_01a8:
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
							{
								num3 = 0;
							}
							goto IL_0167;
						}
						goto IL_01ce;
						IL_01ce:
						current = enumerator.Current;
						num3 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
						{
							num3 = 2;
						}
						goto IL_0167;
						IL_0167:
						while (true)
						{
							switch (num3)
							{
							case 2:
								((ClassMetadata)PpyWa5rG8jgdFsMjA0R(H9wAp3rhRixiAKGTMh0(componentMetadata))).Properties.Add((PropertyMetadata)y5an62rES0egbuGCM5Z(current));
								num3 = 3;
								continue;
							case 3:
								goto IL_01a8;
							case 1:
								goto IL_01ce;
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
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
					{
						num4 = 0;
					}
					switch (num4)
					{
					case 0:
						break;
					}
				}
				break;
			case 1:
				break;
			}
			ProcessTableParts(content.Context.TableParts, componentMetadata, PpyWa5rG8jgdFsMjA0R(H9wAp3rhRixiAKGTMh0(componentMetadata)));
			num2 = 2;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0)
			{
				num2 = 3;
			}
		}
	}

	public void UpdateForm(IMetadataUpdateResult updateResult, Guid formUid)
	{
		//Discarded unreachable code: IL_00e3, IL_00f7, IL_0106, IL_022c, IL_02ab, IL_0302, IL_0546, IL_0555, IL_058b, IL_05b0, IL_05bf, IL_0663, IL_069d, IL_06b0, IL_06bf, IL_0765, IL_0863, IL_0872, IL_08cf, IL_08e2
		int num = 3;
		int num2 = num;
		List<ToolbarItem>.Enumerator enumerator = default(List<ToolbarItem>.Enumerator);
		FormViewItem formViewItem = default(FormViewItem);
		List<ViewItem>.Enumerator enumerator2 = default(List<ViewItem>.Enumerator);
		PropertyViewItem propertyViewItem = default(PropertyViewItem);
		ButtonViewItem buttonViewItem = default(ButtonViewItem);
		ComponentMetadata componentMetadata = default(ComponentMetadata);
		_003C_003Ec__DisplayClass2_0 _003C_003Ec__DisplayClass2_ = default(_003C_003Ec__DisplayClass2_0);
		TablePartMetadata tablePartMetadata2 = default(TablePartMetadata);
		TablePartMetadata tablePartMetadata = default(TablePartMetadata);
		string text = default(string);
		Guid? metadataUid = default(Guid?);
		string text2 = default(string);
		ViewItem current = default(ViewItem);
		PropertyMetadata propertyMetadata = default(PropertyMetadata);
		FormContextMetadata formContextMetadata = default(FormContextMetadata);
		FormPartMetadata formPartMetadata = default(FormPartMetadata);
		Button button = default(Button);
		while (true)
		{
			object obj;
			switch (num2)
			{
			case 6:
				enumerator = ((RootToolbarItem)IPGHcArNpO0rK6ENjkJ(formViewItem)).GetAllItems(ignoreHide: false).ToList().GetEnumerator();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
				{
					num2 = 0;
				}
				continue;
			case 3:
			{
				ComponentMetadataItem obj2 = updateResult.Entities.FirstOrDefault() as ComponentMetadataItem;
				if (obj2 == null)
				{
					num2 = 2;
					continue;
				}
				obj = sx9QCrr87fDlWQpjd62(obj2);
				break;
			}
			case 9:
				YvDakZrtMadynhdy26m(formViewItem, RuntimeVersion.Version2);
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
				{
					num2 = 2;
				}
				continue;
			case 10:
				return;
			case 4:
				try
				{
					while (true)
					{
						int num6;
						if (!enumerator2.MoveNext())
						{
							num6 = 4;
							goto IL_0115;
						}
						goto IL_03b3;
						IL_0115:
						while (true)
						{
							int num7;
							switch (num6)
							{
							case 31:
								if (((EventedList<ViewItem>)UEtUAvrnTgIEthkKCEI(propertyViewItem)).Count <= 0)
								{
									num6 = 14;
									continue;
								}
								goto case 26;
							case 35:
								buttonViewItem.ScriptName = GetNewScriptMethodName(dZJLaQrPUf7cfyTxMbo(buttonViewItem), VY87cbrqrpr0h7WOyB9(componentMetadata));
								num6 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 != 0)
								{
									num6 = 9;
								}
								continue;
							case 39:
								_003C_003Ec__DisplayClass2_.propertyUid = MsCIegrVuscyMVFg0M9(propertyViewItem);
								num6 = 16;
								continue;
							case 23:
								_003C_003Ec__DisplayClass2_ = new _003C_003Ec__DisplayClass2_0();
								num6 = 32;
								continue;
							default:
								if (tablePartMetadata2 == null)
								{
									num6 = 7;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
									{
										num6 = 15;
									}
									continue;
								}
								goto case 19;
							case 21:
							{
								List<ComputedValue> dynamicProperties2 = buttonViewItem.DynamicProperties;
								ComputedValue computedValue2 = new ComputedValue();
								oWtdKlr2LXEqh4vIEwi(computedValue2, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1426094279 ^ -1426111025));
								EvlL9jre6s6xutCVxrb(computedValue2, ComputedValueType.Function);
								dynamicProperties2.Add(computedValue2);
								num6 = 35;
								continue;
							}
							case 38:
								VM7mMxrTesSPsFbr0tR(B20yE5rIyHevNQd7Sei(propertyViewItem), CodeType.Server);
								num6 = 34;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
								{
									num6 = 1;
								}
								continue;
							case 27:
								if (tablePartMetadata != null)
								{
									num6 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e != 0)
									{
										num6 = 2;
									}
									continue;
								}
								goto case 10;
							case 5:
								bJfuJlrOZffNN5s76bu(propertyViewItem);
								num6 = 18;
								continue;
							case 20:
								if (Td9p0IrSKVU9ohu72C6(text))
								{
									num6 = 7;
									continue;
								}
								goto case 1;
							case 37:
								if (!metadataUid.HasValue)
								{
									num7 = 11;
									goto IL_0111;
								}
								return;
							case 10:
							case 12:
								((ViewAttributes)B20yE5rIyHevNQd7Sei(propertyViewItem)).OnViewLoadScriptName = (string)xALCBRrKhwkZ0BQI4ua(text2, VY87cbrqrpr0h7WOyB9(componentMetadata));
								num7 = 31;
								goto IL_0111;
							case 16:
								text = propertyViewItem.Attributes.OnChangeScriptName;
								num6 = 19;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
								{
									num6 = 20;
								}
								continue;
							case 14:
							case 18:
							case 28:
							case 36:
								break;
							case 22:
								goto IL_03b3;
							case 1:
							case 15:
							case 17:
								wkXidwrXj7IWSg06oll(B20yE5rIyHevNQd7Sei(propertyViewItem), xALCBRrKhwkZ0BQI4ua(text, VY87cbrqrpr0h7WOyB9(componentMetadata)));
								num6 = 38;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
								{
									num6 = 7;
								}
								continue;
							case 2:
								text2 = tablePartMetadata.OnViewLoadScriptName;
								num6 = 10;
								continue;
							case 34:
								text2 = (string)o4RVf5rkKycPEjBv5mH(propertyViewItem.Attributes);
								num6 = 33;
								continue;
							case 6:
								if ((propertyViewItem = current as PropertyViewItem) != null)
								{
									num6 = 23;
									continue;
								}
								goto case 8;
							case 7:
								propertyMetadata = formContextMetadata.Properties.FirstOrDefault(_003C_003Ec__DisplayClass2_._003CUpdateForm_003Eb__0);
								num6 = 22;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
								{
									num6 = 30;
								}
								continue;
							case 3:
								tablePartMetadata2 = formContextMetadata.TableParts.FirstOrDefault(_003C_003Ec__DisplayClass2_._003CUpdateForm_003Eb__1);
								num6 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
								{
									num6 = 0;
								}
								continue;
							case 9:
								SAqTv5r1g6PvyF9LDSc(buttonViewItem, CodeType.Server);
								num6 = 19;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
								{
									num6 = 28;
								}
								continue;
							case 30:
								if (propertyMetadata != null)
								{
									num6 = 13;
									continue;
								}
								goto case 3;
							case 11:
								if (propertyViewItem.PropertyParents.Count > 0)
								{
									num7 = 25;
									goto IL_0111;
								}
								goto case 5;
							case 26:
								metadataUid = propertyViewItem.MetadataUid;
								num6 = 37;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
								{
									num6 = 23;
								}
								continue;
							case 24:
								formContextMetadata = (FormContextMetadata)MrqR0HrbcpOZmygTdOe(formPartMetadata);
								num6 = 39;
								continue;
							case 32:
								if (B20yE5rIyHevNQd7Sei(propertyViewItem) != null)
								{
									num6 = 18;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
									{
										num6 = 24;
									}
									continue;
								}
								break;
							case 25:
								return;
							case 33:
								if (!Td9p0IrSKVU9ohu72C6(text2))
								{
									num6 = 12;
									continue;
								}
								goto case 29;
							case 29:
								tablePartMetadata = formContextMetadata.TableParts.FirstOrDefault(_003C_003Ec__DisplayClass2_._003CUpdateForm_003Eb__2);
								num6 = 27;
								continue;
							case 19:
								text = (string)tdjmrcrRnKujflQdhNP(tablePartMetadata2);
								num6 = 6;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0)
								{
									num6 = 17;
								}
								continue;
							case 8:
								if ((buttonViewItem = current as ButtonViewItem) == null)
								{
									num6 = 36;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 != 0)
									{
										num6 = 21;
									}
									continue;
								}
								goto case 21;
							case 13:
								text = (string)QFtvdtriSDvn1EaG8bG(propertyMetadata);
								num6 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
								{
									num6 = 1;
								}
								continue;
							case 4:
								goto end_IL_039d;
								IL_0111:
								num6 = num7;
								continue;
							}
							break;
						}
						continue;
						IL_03b3:
						current = enumerator2.Current;
						num6 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
						{
							num6 = 6;
						}
						goto IL_0115;
						continue;
						end_IL_039d:
						break;
					}
				}
				finally
				{
					((IDisposable)enumerator2).Dispose();
					int num8 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
					{
						num8 = 0;
					}
					switch (num8)
					{
					case 0:
						break;
					}
				}
				goto case 11;
			case 13:
				if (componentMetadata != null)
				{
					formPartMetadata = (FormPartMetadata)jCd7xhrZX6mQ06lq4Jx(this, updateResult);
					num2 = 7;
					continue;
				}
				num2 = 10;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
				{
					num2 = 10;
				}
				continue;
			default:
				OhHl1krDaVqgOFOU7Nw(formViewItem, OnLoadScriptName);
				num2 = 9;
				continue;
			case 11:
				if (formViewItem.Toolbar == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
					{
						num2 = 0;
					}
					continue;
				}
				goto case 6;
			case 5:
				return;
			case 12:
				enumerator2 = formViewItem.GetAllItems(ignoreHide: false).ToList().GetEnumerator();
				num2 = 4;
				continue;
			case 7:
				formViewItem = (FormViewItem)xobluAruT4OY4FHo96T(H9wAp3rhRixiAKGTMh0(componentMetadata));
				num2 = 12;
				continue;
			case 1:
				try
				{
					while (true)
					{
						IL_087d:
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
							{
								num3 = 0;
							}
							goto IL_0773;
						}
						goto IL_0834;
						IL_0834:
						button = enumerator.Current as Button;
						num3 = 2;
						goto IL_0773;
						IL_0773:
						while (true)
						{
							switch (num3)
							{
							case 2:
								if (button == null)
								{
									int num4 = 3;
									num3 = num4;
									continue;
								}
								goto case 1;
							case 7:
								button.ScriptName = (string)xALCBRrKhwkZ0BQI4ua(MOc0umrpFhC3moYbLYE(button), VY87cbrqrpr0h7WOyB9(componentMetadata));
								num3 = 3;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
								{
									num3 = 5;
								}
								continue;
							case 1:
							{
								List<ComputedValue> dynamicProperties = button.DynamicProperties;
								ComputedValue computedValue = new ComputedValue();
								oWtdKlr2LXEqh4vIEwi(computedValue, rWV6Arr33cqBQRkeYxX(-978351861 ^ -978367971));
								EvlL9jre6s6xutCVxrb(computedValue, ComputedValueType.Function);
								dynamicProperties.Add(computedValue);
								num3 = 7;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
								{
									num3 = 7;
								}
								continue;
							}
							case 4:
								goto IL_0834;
							case 5:
								Usye9lraC9JxpfW81h8(button, CodeType.Server);
								num3 = 6;
								continue;
							case 3:
							case 6:
								goto IL_087d;
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
					int num5 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 != 0)
					{
						num5 = 0;
					}
					switch (num5)
					{
					case 0:
						break;
					}
				}
				goto default;
			case 2:
				obj = null;
				break;
			}
			componentMetadata = obj as ComponentMetadata;
			num2 = 13;
		}
	}

	public void UpdateScriptModules(IMetadataUpdateResult updateResult)
	{
		//Discarded unreachable code: IL_0248, IL_02e4, IL_02f3, IL_0303, IL_0312, IL_0334, IL_0343, IL_03fc, IL_040b, IL_042b, IL_043a, IL_059d, IL_0663, IL_0672, IL_0681, IL_06e6, IL_06f5, IL_0704, IL_0714, IL_078c, IL_0805, IL_08aa, IL_0989, IL_0998, IL_09e4, IL_0acd, IL_0adc, IL_0bd0, IL_0bfc, IL_0e39, IL_0e48, IL_0ed8, IL_0ee7
		//IL_02a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_038a: Unknown result type (might be due to invalid IL or missing references)
		//IL_039e: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03db: Unknown result type (might be due to invalid IL or missing references)
		//IL_0495: Unknown result type (might be due to invalid IL or missing references)
		//IL_049c: Expected O, but got Unknown
		//IL_04a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0728: Unknown result type (might be due to invalid IL or missing references)
		//IL_0732: Unknown result type (might be due to invalid IL or missing references)
		//IL_0737: Unknown result type (might be due to invalid IL or missing references)
		//IL_0766: Unknown result type (might be due to invalid IL or missing references)
		//IL_076b: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f8: Expected O, but got Unknown
		//IL_09bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a2b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a84: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a89: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a8f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ab7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0abc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b20: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b25: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b2b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b43: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b48: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c2b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c30: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c4e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c53: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c71: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c76: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cfc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d01: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d21: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d26: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d2c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0da4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0db2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e7c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e7e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ea9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eae: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f6d: Unknown result type (might be due to invalid IL or missing references)
		int num = 94;
		MethodDeclarationSyntax val10 = default(MethodDeclarationSyntax);
		MemberDeclarationSyntax current4 = default(MemberDeclarationSyntax);
		_003C_003Ec__DisplayClass3_0 _003C_003Ec__DisplayClass3_ = default(_003C_003Ec__DisplayClass3_0);
		List<MemberDeclarationSyntax> list2 = default(List<MemberDeclarationSyntax>);
		NamespaceDeclarationSyntax val5 = default(NamespaceDeclarationSyntax);
		SyntaxToken val3 = default(SyntaxToken);
		string text5 = default(string);
		Enumerator<ParameterSyntax> enumerator2 = default(Enumerator<ParameterSyntax>);
		SeparatedSyntaxList<ParameterSyntax> parameters = default(SeparatedSyntaxList<ParameterSyntax>);
		Enumerator<MemberDeclarationSyntax> enumerator3 = default(Enumerator<MemberDeclarationSyntax>);
		SyntaxList<MemberDeclarationSyntax> members = default(SyntaxList<MemberDeclarationSyntax>);
		UsingDirectiveSyntax current2 = default(UsingDirectiveSyntax);
		Enumerator<UsingDirectiveSyntax> enumerator = default(Enumerator<UsingDirectiveSyntax>);
		int num4 = default(int);
		SeparatedSyntaxList<ParameterSyntax> val12 = default(SeparatedSyntaxList<ParameterSyntax>);
		ParameterSyntax current3 = default(ParameterSyntax);
		NamespaceDeclarationSyntax val6 = default(NamespaceDeclarationSyntax);
		CompilationUnitSyntax val14 = default(CompilationUnitSyntax);
		List<ClassDeclarationSyntax> list3 = default(List<ClassDeclarationSyntax>);
		string text3 = default(string);
		ClassDeclarationSyntax val2 = default(ClassDeclarationSyntax);
		List<MemberDeclarationSyntax> list = default(List<MemberDeclarationSyntax>);
		MethodDeclarationSyntax val11 = default(MethodDeclarationSyntax);
		int num3 = default(int);
		ClassDeclarationSyntax val7 = default(ClassDeclarationSyntax);
		MemberDeclarationSyntax current = default(MemberDeclarationSyntax);
		ClassDeclarationSyntax val4 = default(ClassDeclarationSyntax);
		List<UsingDirectiveSyntax> list4 = default(List<UsingDirectiveSyntax>);
		ParameterSyntax val16 = default(ParameterSyntax);
		SyntaxTokenList val8 = default(SyntaxTokenList);
		_003C_003Ec__DisplayClass3_1 _003C_003Ec__DisplayClass3_2 = default(_003C_003Ec__DisplayClass3_1);
		string[] array = default(string[]);
		string text = default(string);
		string text2 = default(string);
		CompilationUnitSyntax val = default(CompilationUnitSyntax);
		string text7 = default(string);
		string text4 = default(string);
		NamespaceDeclarationSyntax val13 = default(NamespaceDeclarationSyntax);
		ClassDeclarationSyntax val15 = default(ClassDeclarationSyntax);
		SyntaxList<UsingDirectiveSyntax> usings = default(SyntaxList<UsingDirectiveSyntax>);
		string text6 = default(string);
		ComponentMetadataItem componentMetadataItem = default(ComponentMetadataItem);
		SyntaxToken val9 = default(SyntaxToken);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				object obj;
				switch (num2)
				{
				case 57:
					val10 = (MethodDeclarationSyntax)(object)((current4 is MethodDeclarationSyntax) ? current4 : null);
					num2 = 48;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0)
					{
						num2 = 67;
					}
					continue;
				case 61:
					if (_003C_003Ec__DisplayClass3_.newScriptModule != null)
					{
						num2 = 102;
						continue;
					}
					return;
				case 67:
					if (val10 != null)
					{
						num2 = 18;
						continue;
					}
					goto case 16;
				case 4:
					list2 = new List<MemberDeclarationSyntax>();
					num2 = 53;
					continue;
				case 36:
					if (val5 == null)
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
						{
							num2 = 29;
						}
						continue;
					}
					goto case 41;
				case 30:
					if (LbDodyr586pN13ZjWlR(((object)(SyntaxToken)(ref val3)).ToString(), text5))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 38;
				case 60:
					enumerator2 = parameters.GetEnumerator();
					num2 = 73;
					continue;
				case 106:
					enumerator3 = members.GetEnumerator();
					num2 = 113;
					continue;
				case 87:
				case 100:
					current2 = enumerator.get_Current();
					num2 = 7;
					continue;
				case 40:
				case 45:
					if (num4 != -1)
					{
						num2 = 8;
						continue;
					}
					goto case 70;
				case 82:
				{
					MemberDeclarationSyntax obj3 = members.FirstOrDefault();
					val5 = (NamespaceDeclarationSyntax)(object)((obj3 is NamespaceDeclarationSyntax) ? obj3 : null);
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
					{
						num2 = 3;
					}
					continue;
				}
				case 89:
					return;
				case 94:
					_003C_003Ec__DisplayClass3_ = new _003C_003Ec__DisplayClass3_0();
					num2 = 93;
					continue;
				case 10:
					val12 = default(SeparatedSyntaxList<ParameterSyntax>);
					num2 = 50;
					continue;
				case 88:
					val12 = val12.Add(current3);
					num2 = 49;
					continue;
				case 54:
				case 58:
				case 85:
					val12 = val12.Add(current3);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
					{
						num2 = 0;
					}
					continue;
				case 53:
					members = val6.get_Members();
					num2 = 106;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
					{
						num2 = 61;
					}
					continue;
				case 14:
					num4 = -1;
					num = 40;
					break;
				case 21:
				case 90:
					current4 = enumerator3.get_Current();
					num2 = 57;
					continue;
				case 5:
					return;
				case 102:
					val14 = (CompilationUnitSyntax)CSharpSyntaxTree.ParseText(_003C_003Ec__DisplayClass3_.oldScriptModule.SourceCode, (CSharpParseOptions)COWXvVr60lNhJrVyDAY(vkKrYmr4r9WpZvw8jH6(), (LanguageVersion)7), "", (Encoding)null, (ImmutableDictionary<string, ReportDiagnostic>)null, default(CancellationToken)).GetRoot(default(CancellationToken));
					num2 = 71;
					continue;
				case 65:
					members = val14.get_Members();
					num2 = 97;
					continue;
				case 2:
				case 23:
				case 37:
					if (enumerator3.MoveNext())
					{
						num2 = 21;
						continue;
					}
					goto case 72;
				case 92:
					if (list3.Count > 1)
					{
						num2 = 35;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
						{
							num2 = 65;
						}
						continue;
					}
					goto case 29;
				case 52:
					if (_003C_003Ec__DisplayClass3_.oldScriptModule != null)
					{
						num2 = 10;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
						{
							num2 = 28;
						}
						continue;
					}
					return;
				case 103:
					text3 = ((string)fmUDr7rrrfRUlZkEhxq(fmUDr7rrrfRUlZkEhxq(WEoim0rlVRR30pfgGI0(vTdNW6rdPwODiIETfGj(current3).ToString()), rWV6Arr33cqBQRkeYxX(0x92F12D5 ^ 0x92F5BF7), ""), rWV6Arr33cqBQRkeYxX(-70037984 ^ -70037110), "")).Replace((string)vbpkyrrgxGCfCgPtnds(), "");
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
					{
						num2 = 34;
					}
					continue;
				case 74:
					members = ((TypeDeclarationSyntax)val2).get_Members();
					num2 = 101;
					continue;
				default:
					if (enumerator2.MoveNext())
					{
						num2 = 31;
						continue;
					}
					goto case 76;
				case 31:
				case 48:
					current3 = enumerator2.get_Current();
					num2 = 103;
					continue;
				case 64:
					list.Add((MemberDeclarationSyntax)(object)val11);
					num2 = 23;
					continue;
				case 70:
				case 114:
					num3++;
					num2 = 47;
					continue;
				case 9:
					if ((val7 = (ClassDeclarationSyntax)(object)((current is ClassDeclarationSyntax) ? current : null)) != null)
					{
						num = 11;
						break;
					}
					goto case 38;
				case 97:
				{
					MemberDeclarationSyntax obj4 = members.FirstOrDefault();
					val6 = (NamespaceDeclarationSyntax)(object)((obj4 is NamespaceDeclarationSyntax) ? obj4 : null);
					num2 = 105;
					continue;
				}
				case 8:
					if (num3 <= num4)
					{
						num2 = 114;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 66;
				case 26:
					if (val4 == null)
					{
						num2 = 63;
						continue;
					}
					list4 = new List<UsingDirectiveSyntax>();
					num2 = 56;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
					{
						num2 = 84;
					}
					continue;
				case 110:
					val16 = (ParameterSyntax)kGeHEHrL7Og3sAN9spx(current3, SyntaxNodeExtensions.WithTrailingTrivia<TypeSyntax>((TypeSyntax)MHDFxJrjJgXhXaoJ9UP(rWV6Arr33cqBQRkeYxX(-1979251663 ^ -1979201787), 0, true), qCMWjarYd22ntNehs2r(vTdNW6rdPwODiIETfGj(current3))));
					num = 51;
					break;
				case 51:
					val12 = val12.Add(SyntaxNodeExtensions.WithTrailingTrivia<ParameterSyntax>(val16, ((CSharpSyntaxNode)current3).GetTrailingTrivia()));
					num = 69;
					break;
				case 39:
					num3 = 0;
					num2 = 46;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
					{
						num2 = 21;
					}
					continue;
				case 17:
				case 18:
					val8 = UNV9okr0AQ3mkIvt0s3(val10);
					num2 = 48;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
					{
						num2 = 108;
					}
					continue;
				case 19:
					_003C_003Ec__DisplayClass3_2.oldUsingName = RXsW06r7fXKiOOaD7eW(current2).ToString();
					num = 80;
					break;
				case 22:
				case 96:
					current = enumerator3.get_Current();
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
					{
						num2 = 9;
					}
					continue;
				case 99:
					_003C_003Ec__DisplayClass3_.newScriptModule.SourceCode = string.Join((string)vbpkyrrgxGCfCgPtnds(), array);
					num = 89;
					break;
				case 66:
					array[num3] = (string)hquljLgB1VwXei7iToX(rWV6Arr33cqBQRkeYxX(-1852837372 ^ -1852838482), text);
					num2 = 70;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
					{
						num2 = 13;
					}
					continue;
				case 111:
					if (!LbDodyr586pN13ZjWlR(text, rWV6Arr33cqBQRkeYxX(0x307E9FD1 ^ 0x307E5C41)))
					{
						num2 = 45;
						continue;
					}
					goto case 14;
				case 59:
					if (!LbDodyr586pN13ZjWlR(((object[])ClscPLrUqvnrJy1wHI8(text3, new char[1] { '<' }))[0], text2))
					{
						num2 = 50;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
						{
							num2 = 54;
						}
						continue;
					}
					goto case 88;
				case 27:
					return;
				case 29:
				case 43:
				case 95:
					array = (string[])nj4XDBgFtKGH2sXNEJX(fmUDr7rrrfRUlZkEhxq(UMB2lyrzdiff8p1T5d2(val), text7 + (string)rWV6Arr33cqBQRkeYxX(-1638402543 ^ -1638404907), ""), new string[1] { (string)vbpkyrrgxGCfCgPtnds() }, StringSplitOptions.None);
					num = 77;
					break;
				case 6:
					text7 = (string)WDAIHarxL0MR7HLB8GN(this, updateResult);
					num2 = 32;
					continue;
				case 68:
					text4 = (string)cbC7XQrMfYOQYc4YaFo(this, updateResult);
					num2 = 59;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
					{
						num2 = 79;
					}
					continue;
				case 81:
					list4.Add(current2);
					num2 = 24;
					continue;
				case 50:
					parameters = ((BaseParameterListSyntax)iSkaTcr9LaRmDwN1Ite(val10)).get_Parameters();
					num2 = 60;
					continue;
				case 3:
					if (val6 == null)
					{
						num2 = 95;
						continue;
					}
					goto case 36;
				case 33:
					num4 = num3 + 1;
					num2 = 42;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
					{
						num2 = 111;
					}
					continue;
				case 35:
					val = SyntaxNodeExtensions.ReplaceNode<CompilationUnitSyntax>(val, (SyntaxNode)(object)val5, (SyntaxNode)(object)val13);
					num = 43;
					break;
				case 80:
					if (((IEnumerable<UsingDirectiveSyntax>)(object)val.get_Usings()).FirstOrDefault(_003C_003Ec__DisplayClass3_2._003CUpdateScriptModules_003Eb__3) != null)
					{
						num2 = 109;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
						{
							num2 = 82;
						}
						continue;
					}
					goto case 81;
				case 44:
					text = array[num3];
					num2 = 75;
					continue;
				case 78:
				{
					CompilationUnitSyntax obj6 = SyntaxNodeExtensions.ReplaceNode<CompilationUnitSyntax>(val, (SyntaxNode)(object)val4, (SyntaxNode)(object)val15);
					usings = val.get_Usings();
					val = obj6.WithUsings(usings.AddRange((IEnumerable<UsingDirectiveSyntax>)list4));
					num2 = 92;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
					{
						num2 = 11;
					}
					continue;
				}
				case 105:
					members = val.get_Members();
					num2 = 82;
					continue;
				case 77:
					num4 = -1;
					num2 = 22;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
					{
						num2 = 39;
					}
					continue;
				case 34:
					if (!(text3 == text6))
					{
						num2 = 20;
						continue;
					}
					goto case 110;
				case 72:
				{
					ClassDeclarationSyntax obj7 = val4;
					members = ((TypeDeclarationSyntax)val4).get_Members();
					val15 = obj7.WithMembers(members.AddRange((IEnumerable<MemberDeclarationSyntax>)list));
					num2 = 78;
					continue;
				}
				case 11:
					val3 = ((BaseTypeDeclarationSyntax)val7).get_Identifier();
					num2 = 30;
					continue;
				case 93:
					_003C_003Ec__DisplayClass3_.oldScriptModule = updateResult.ScriptModules.FirstOrDefault();
					num2 = 52;
					continue;
				case 71:
					list3 = ((SyntaxNode)val14).DescendantNodes((Func<SyntaxNode, bool>)null, false).OfType<ClassDeclarationSyntax>().ToList();
					num2 = 13;
					continue;
				case 7:
					_003C_003Ec__DisplayClass3_2 = new _003C_003Ec__DisplayClass3_1();
					num2 = 19;
					continue;
				case 75:
					if (LbDodyr586pN13ZjWlR(text.Trim(), rWV6Arr33cqBQRkeYxX(0x7EC153F ^ 0x7ECD675)))
					{
						num2 = 33;
						continue;
					}
					goto case 111;
				case 15:
					return;
				case 28:
					componentMetadataItem = updateResult.Entities.FirstOrDefault() as ComponentMetadataItem;
					num2 = 112;
					continue;
				case 42:
					text6 = (string)mi5wNbryEBj6TbuDyHx(this, updateResult);
					num2 = 57;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
					{
						num2 = 68;
					}
					continue;
				case 101:
					enumerator3 = members.GetEnumerator();
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
					{
						num2 = 1;
					}
					continue;
				case 41:
					val3 = liMSIjrcM7xvGO0Shyr(val2);
					num2 = 107;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
					{
						num2 = 4;
					}
					continue;
				case 55:
					enumerator = usings.GetEnumerator();
					num2 = 27;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
					{
						num2 = 104;
					}
					continue;
				case 13:
					val2 = list3.FirstOrDefault(_003C_003Ec__DisplayClass3_._003CUpdateScriptModules_003Eb__0);
					num2 = 56;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de != 0)
					{
						num2 = 4;
					}
					continue;
				case 63:
					return;
				case 24:
				case 104:
				case 109:
					if (enumerator.MoveNext())
					{
						num2 = 100;
						continue;
					}
					goto case 6;
				case 84:
					usings = val14.get_Usings();
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
					{
						num2 = 55;
					}
					continue;
				case 62:
				{
					NamespaceDeclarationSyntax obj5 = val5;
					members = val5.get_Members();
					val13 = obj5.WithMembers(members.AddRange((IEnumerable<MemberDeclarationSyntax>)list2));
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
					{
						num2 = 35;
					}
					continue;
				}
				case 32:
					list = new List<MemberDeclarationSyntax>();
					num2 = 74;
					continue;
				case 107:
					text5 = ((object)(SyntaxToken)(ref val3)).ToString();
					num2 = 4;
					continue;
				case 1:
				case 25:
				case 113:
					if (enumerator3.MoveNext())
					{
						num2 = 15;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
						{
							num2 = 22;
						}
						continue;
					}
					goto case 62;
				case 76:
					val11 = (MethodDeclarationSyntax)uIFwRwrsCw5FXV9rdX4(val11, SyntaxNodeExtensions.WithTrailingTrivia<ParameterListSyntax>(SyntaxFactory.ParameterList(val12), qCMWjarYd22ntNehs2r(iSkaTcr9LaRmDwN1Ite(val11))));
					num2 = 64;
					continue;
				case 83:
				case 86:
					if (!text3.Contains((string)rWV6Arr33cqBQRkeYxX(-576149596 ^ -576133022)))
					{
						num2 = 58;
						continue;
					}
					goto case 59;
				case 20:
					if (!LbDodyr586pN13ZjWlR(text3, text4))
					{
						num2 = 29;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 != 0)
						{
							num2 = 83;
						}
						continue;
					}
					goto case 110;
				case 38:
					list2.Add(current);
					num2 = 25;
					continue;
				case 56:
					if (val2 != null)
					{
						val = (CompilationUnitSyntax)J6wtPNrArWqgM58V4OP(CSharpSyntaxTree.ParseText((string)vvZ7hyrHQJfEKntXuFL(_003C_003Ec__DisplayClass3_.newScriptModule), (CSharpParseOptions)COWXvVr60lNhJrVyDAY(vkKrYmr4r9WpZvw8jH6(), (LanguageVersion)7), "", (Encoding)null, (ImmutableDictionary<string, ReportDiagnostic>)null, default(CancellationToken)), default(CancellationToken));
						num2 = 91;
						continue;
					}
					num = 27;
					break;
				case 79:
					text2 = (string)ih9fXhrJNRt1QARXQXC(this);
					num2 = 10;
					continue;
				case 98:
					val11 = val10.WithModifiers(EfRHVurmIoKp5rGR2i0(val9));
					num2 = 42;
					continue;
				case 16:
					list.Add(current4);
					num2 = 37;
					continue;
				case 108:
					val9 = ((SyntaxTokenList)(ref val8)).First();
					num2 = 98;
					continue;
				case 46:
				case 47:
					if (num3 >= array.Length)
					{
						num = 99;
						break;
					}
					goto case 44;
				case 112:
					_003C_003Ec__DisplayClass3_.newScriptModule = (ScriptModule)((componentMetadataItem != null) ? jwFDDyrw0XeTWakf6ZD(componentMetadataItem) : null);
					num2 = 61;
					continue;
				case 91:
				{
					ClassDeclarationSyntax obj2 = ((SyntaxNode)val).DescendantNodes((Func<SyntaxNode, bool>)null, false).OfType<ClassDeclarationSyntax>().ToList()
						.FirstOrDefault(_003C_003Ec__DisplayClass3_._003CUpdateScriptModules_003Eb__1);
					if (obj2 == null)
					{
						num2 = 12;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
						{
							num2 = 2;
						}
						continue;
					}
					obj = ((IEnumerable)(object)((TypeDeclarationSyntax)obj2).get_Members()).OfType<ClassDeclarationSyntax>().FirstOrDefault(delegate(ClassDeclarationSyntax q)
					{
						//IL_0025: Unknown result type (might be due to invalid IL or missing references)
						//IL_002a: Unknown result type (might be due to invalid IL or missing references)
						int num5 = 1;
						int num6 = num5;
						SyntaxToken val17 = default(SyntaxToken);
						while (true)
						{
							switch (num6)
							{
							case 1:
								val17 = _003C_003Ec.qfwoJEfjNhg0okqJ5PMM(q);
								num6 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
								{
									num6 = 0;
								}
								break;
							default:
								return _003C_003Ec.aMPKuifjpvurkGkFFkxq(((object)(SyntaxToken)(ref val17)).ToString(), _003C_003Ec.lLQIbEfj3ZqTyUuYl8cX(--1418440330 ^ 0x548ABF68));
							}
						}
					});
					goto IL_0fa3;
				}
				case 12:
					{
						obj = null;
						goto IL_0fa3;
					}
					IL_0fa3:
					val4 = (ClassDeclarationSyntax)obj;
					num2 = 26;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
					{
						num2 = 26;
					}
					continue;
				}
				break;
			}
		}
	}

	protected abstract string GetMetadataName(IMetadataUpdateResult updateResult);

	protected abstract FormPartMetadata GetContent(IMetadataUpdateResult updateResult);

	protected abstract string GetViewModelTypeName(IMetadataUpdateResult updateResult);

	protected abstract string GetLoadViewModelTypeName(IMetadataUpdateResult updateResult);

	protected virtual void AdditionalMetadataActions(FormMetadata formMetadata, ComponentMetadata componentMetadata)
	{
	}

	protected static ViewModelPropertyMetadata CloneToViewModelPropertyMetadata(PropertyMetadata propertyMetadata)
	{
		ViewModelPropertyMetadata viewModelPropertyMetadata = ClonePropertyMetadata<ViewModelPropertyMetadata>(propertyMetadata);
		llKYIYgWt3NRycrXZbk(viewModelPropertyMetadata, false);
		viewModelPropertyMetadata.ClientOnly = false;
		khO4JigoL4GyUFJ6NUL(viewModelPropertyMetadata, null);
		return viewModelPropertyMetadata;
	}

	private static void UpdateNestedPropertyViewItem(object propertyViewItem)
	{
		//Discarded unreachable code: IL_002e, IL_0038, IL_00cd, IL_00f2, IL_0101, IL_01fa, IL_0232, IL_0241
		int num = 1;
		int num2 = num;
		IEnumerator<PropertyViewItem> enumerator = default(IEnumerator<PropertyViewItem>);
		PropertyViewItem current = default(PropertyViewItem);
		while (true)
		{
			switch (num2)
			{
			case 1:
				enumerator = ((IEnumerable)UEtUAvrnTgIEthkKCEI(propertyViewItem)).OfType<PropertyViewItem>().GetEnumerator();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				return;
			}
			try
			{
				while (true)
				{
					int num3;
					if (!enumerator.MoveNext())
					{
						num3 = 6;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
						{
							num3 = 3;
						}
						goto IL_003c;
					}
					goto IL_0122;
					IL_0122:
					current = enumerator.Current;
					num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
					{
						num3 = 1;
					}
					goto IL_003c;
					IL_003c:
					while (true)
					{
						switch (num3)
						{
						case 9:
							break;
						case 3:
							current.PropertyParents.Add(MsCIegrVuscyMVFg0M9(propertyViewItem));
							num3 = 5;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
							{
								num3 = 0;
							}
							continue;
						case 1:
							if (current.PropertyParents != null)
							{
								num3 = 8;
								continue;
							}
							goto default;
						default:
							current.PropertyParents = new List<Guid>();
							num3 = 2;
							continue;
						case 11:
							goto IL_0122;
						case 5:
							if (ANtxYkghj88QxxXL3br(UEtUAvrnTgIEthkKCEI(current)) > 0)
							{
								num3 = 4;
								continue;
							}
							break;
						case 7:
						case 8:
							beN7DCgb0QRmEbycXxL(current.PropertyParents);
							num3 = 5;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
							{
								num3 = 10;
							}
							continue;
						case 4:
							bJfuJlrOZffNN5s76bu(current);
							num3 = 9;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 != 0)
							{
								num3 = 2;
							}
							continue;
						case 2:
						case 10:
							current.PropertyParents.AddRange(((PropertyViewItem)propertyViewItem).PropertyParents);
							num3 = 3;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
							{
								num3 = 2;
							}
							continue;
						case 6:
							return;
						}
						break;
					}
				}
			}
			finally
			{
				if (enumerator != null)
				{
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
					{
						num4 = 0;
					}
					while (true)
					{
						switch (num4)
						{
						default:
							enumerator.Dispose();
							num4 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
							{
								num4 = 0;
							}
							continue;
						case 1:
							break;
						}
						break;
					}
				}
			}
		}
	}

	private static PropertyMetadata CloneToPropertyMetadata(object propertyMetadata)
	{
		return ClonePropertyMetadata<PropertyMetadata>(propertyMetadata);
	}

	private static string GetNewScriptMethodName(object oldMethodName, Guid componentMetadataUid)
	{
		//Discarded unreachable code: IL_00ab, IL_00bc
		int num = 4;
		int num2 = num;
		string text = default(string);
		string name = default(string);
		while (true)
		{
			object obj;
			switch (num2)
			{
			case 1:
				if (!eAm4JmgGmZa8gEh62hy(text, rWV6Arr33cqBQRkeYxX(0x1DE3DD89 ^ 0x1DE3C23F)))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				obj = NfhNJdgEvye7B4YVOOF(text, 0, text.IndexOf('('));
				break;
			case 4:
				if (!Td9p0IrSKVU9ohu72C6(oldMethodName))
				{
					num2 = 3;
					continue;
				}
				goto case 2;
			case 5:
			{
				ScriptMethodInfo obj2 = new ScriptMethodInfo
				{
					Name = name,
					CodeType = CodeType.Server
				};
				zwTfAwgffHKtB1YxFq4(obj2, componentMetadataUid);
				return (string)k1kgTogQfJIVNtTAQHn(obj2);
			}
			default:
				obj = text;
				break;
			case 2:
				return string.Empty;
			case 3:
				text = (string)((object[])nj4XDBgFtKGH2sXNEJX(oldMethodName, new string[1] { (string)rWV6Arr33cqBQRkeYxX(0x1A33FE36 ^ 0x1A333D90) }, StringSplitOptions.None))[0];
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
				{
					num2 = 1;
				}
				continue;
			}
			name = (string)obj;
			num2 = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
			{
				num2 = 5;
			}
		}
	}

	private static T ClonePropertyMetadata<T>(object propertyMetadata) where T : PropertyMetadata, new()
	{
		return new T
		{
			Description = ((NamedMetadata)propertyMetadata).Description,
			Groupable = ((PropertyMetadata)propertyMetadata).Groupable,
			Handlers = ((PropertyMetadata)propertyMetadata).Handlers,
			Id = ((Entity<long>)propertyMetadata).Id,
			Images = ((NamedMetadata)propertyMetadata).Images,
			Internal = ((AbstractMetadata)propertyMetadata).Internal,
			Name = ((NamedMetadata)propertyMetadata).Name,
			Nullable = ((PropertyMetadata)propertyMetadata).Nullable,
			Order = ((PropertyMetadata)propertyMetadata).Order,
			Required = ((PropertyMetadata)propertyMetadata).Required,
			Settings = ((PropertyMetadata)propertyMetadata).Settings,
			Sortable = ((PropertyMetadata)propertyMetadata).Sortable,
			Uid = ((AbstractMetadata)propertyMetadata).Uid,
			AdditionalAttributes = ((PropertyMetadata)propertyMetadata).AdditionalAttributes,
			CalculateScript = ((PropertyMetadata)propertyMetadata).CalculateScript,
			CalculateType = ((PropertyMetadata)propertyMetadata).CalculateType,
			DeclaringType = ((PropertyMetadata)propertyMetadata).DeclaringType,
			DisplayName = ((NamedMetadata)propertyMetadata).DisplayName,
			ModuleUid = ((AbstractMetadata)propertyMetadata).ModuleUid,
			NamedImages = ((NamedMetadata)propertyMetadata).NamedImages,
			TypeResolver = ((PropertyMetadata)propertyMetadata).TypeResolver,
			TypeUid = ((PropertyMetadata)propertyMetadata).TypeUid,
			SubTypeUid = ((PropertyMetadata)propertyMetadata).SubTypeUid,
			ViewSettings = ((PropertyMetadata)propertyMetadata).ViewSettings,
			XmlComments = ((NamedDocumentedMetadata)propertyMetadata).XmlComments,
			OwnerPropertyUid = ((PropertyMetadata)propertyMetadata).OwnerPropertyUid,
			TableCellAlignment = ((PropertyMetadata)propertyMetadata).TableCellAlignment,
			TableColumnWidth = ((PropertyMetadata)propertyMetadata).TableColumnWidth,
			OnChangeScriptName = ((PropertyMetadata)propertyMetadata).OnChangeScriptName,
			SQLFormula = ((PropertyMetadata)propertyMetadata).SQLFormula,
			IsSystem = false
		};
	}

	private static void ProcessTableParts(List<TablePartMetadata> tableParts, object componentMetadata, object tablePartPropertyOwner)
	{
		if (tableParts.Count > 0)
		{
			throw new InvalidOperationException(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x42643203 ^ 0x4264F1B3)));
		}
		foreach (TablePartMetadata tablePart in tableParts)
		{
			DataClassMetadata dataClassMetadata = new DataClassMetadata(Guid.Empty);
			dataClassMetadata.InitNew();
			dataClassMetadata.Internal = true;
			dataClassMetadata.Namespace = ((ComponentMetadata)componentMetadata).Namespace;
			dataClassMetadata.Name = tablePart.Name;
			dataClassMetadata.DisplayName = tablePart.DisplayName;
			dataClassMetadata.Description = tablePart.Description;
			TableView tableView = tablePart.TableViews.FirstOrDefault();
			TableView tableView2 = dataClassMetadata.TableViews.FirstOrDefault();
			if (tableView != null && tableView2 != null)
			{
				tableView2.Customizable = tableView.Customizable;
				tableView2.Groupable = tableView.Groupable;
				tableView2.Pageable = tableView.Pageable;
				tableView2.Reorderable = tableView.Reorderable;
				tableView2.Resizeable = tableView.Resizeable;
				tableView2.Sortable = tableView.Sortable;
				tableView2.CanAdd = tableView.CanAdd;
				tableView2.CanDelete = tableView.CanDelete;
				tableView2.CanEdit = tableView.CanEdit;
				tableView2.GroupDescriptors = tableView.GroupDescriptors;
				tableView2.PageSize = tableView.PageSize;
				tableView2.ShowHeader = tableView.ShowHeader;
				tableView2.SortDescriptors = tableView.SortDescriptors;
				tableView2.ViewType = tableView.ViewType;
				tableView2.AddRowMode = tableView.AddRowMode;
				tableView2.EditRowMode = tableView.EditRowMode;
			}
			foreach (PropertyMetadata property in tablePart.Properties)
			{
				if (!(property.Name == z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x35C0467B ^ 0x35C0D64D)))
				{
					dataClassMetadata.Properties.Add(CloneToPropertyMetadata(property));
				}
			}
			PropertyMetadata propertyMetadata = ((tablePartPropertyOwner is DataClassMetadata) ? new PropertyMetadata() : new ViewModelPropertyMetadata());
			propertyMetadata.Uid = tablePart.TablePartPropertyUid;
			propertyMetadata.Name = tablePart.TablePartPropertyName;
			propertyMetadata.DisplayName = tablePart.DisplayName;
			propertyMetadata.TypeUid = DataClassDescriptor.UID;
			propertyMetadata.SubTypeUid = dataClassMetadata.Uid;
			propertyMetadata.Description = tablePart.Description;
			if (propertyMetadata.Settings is DataClassSettings dataClassSettings)
			{
				dataClassSettings.RelationType = RelationType.ManyToMany;
				dataClassSettings.DisplayType = DataClassDisplayType.Table;
			}
			((ClassMetadata)tablePartPropertyOwner).Properties.Add(propertyMetadata);
			((ComponentMetadata)componentMetadata).DataClasses.Add(dataClassMetadata);
			ProcessTableParts(tablePart.TableParts, componentMetadata, dataClassMetadata);
		}
	}

	protected FormMetadataUpdateHandler()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object MrqR0HrbcpOZmygTdOe(object P_0)
	{
		return ((FormPartMetadata)P_0).Context;
	}

	internal static object H9wAp3rhRixiAKGTMh0(object P_0)
	{
		return ((ComponentMetadata)P_0).Content;
	}

	internal static object PpyWa5rG8jgdFsMjA0R(object P_0)
	{
		return ((ComponentContentMetadata)P_0).Context;
	}

	internal static object y5an62rES0egbuGCM5Z(object P_0)
	{
		return CloneToViewModelPropertyMetadata((PropertyMetadata)P_0);
	}

	internal static object CeoNSMrfeKUhGhvEX5w(object P_0)
	{
		return ((FormPartMetadata)P_0).View;
	}

	internal static object jhjd7QrQgDm82pob9Aj(object P_0)
	{
		return ((ViewItem)P_0).Clone();
	}

	internal static void drI8OErCKEvsEppV7cN(object P_0, object P_1)
	{
		((ComponentContentMetadata)P_0).View = (FormViewItem)P_1;
	}

	internal static object dVjlPRrvVq5X37SMaZW(object P_0)
	{
		return ((IMetadataUpdateResult)P_0).Metadata;
	}

	internal static bool FHJDx6rWslVLPrBtAy1()
	{
		return sM7DfOrBsi0mRFfAE3m == null;
	}

	internal static FormMetadataUpdateHandler KYmLTmroYWhsemYbuQ8()
	{
		return sM7DfOrBsi0mRFfAE3m;
	}

	internal static object sx9QCrr87fDlWQpjd62(object P_0)
	{
		return ((ComponentMetadataItem)P_0).Metadata;
	}

	internal static object jCd7xhrZX6mQ06lq4Jx(object P_0, object P_1)
	{
		return ((FormMetadataUpdateHandler)P_0).GetContent((IMetadataUpdateResult)P_1);
	}

	internal static object xobluAruT4OY4FHo96T(object P_0)
	{
		return ((ComponentContentMetadata)P_0).View;
	}

	internal static object B20yE5rIyHevNQd7Sei(object P_0)
	{
		return ((PropertyViewItem)P_0).Attributes;
	}

	internal static Guid MsCIegrVuscyMVFg0M9(object P_0)
	{
		return ((PropertyViewItem)P_0).PropertyUid;
	}

	internal static bool Td9p0IrSKVU9ohu72C6(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object QFtvdtriSDvn1EaG8bG(object P_0)
	{
		return ((PropertyMetadata)P_0).OnChangeScriptName;
	}

	internal static object tdjmrcrRnKujflQdhNP(object P_0)
	{
		return ((TablePartMetadata)P_0).OnChangeScriptName;
	}

	internal static Guid VY87cbrqrpr0h7WOyB9(object P_0)
	{
		return ((AbstractMetadata)P_0).Uid;
	}

	internal static object xALCBRrKhwkZ0BQI4ua(object P_0, Guid componentMetadataUid)
	{
		return GetNewScriptMethodName(P_0, componentMetadataUid);
	}

	internal static void wkXidwrXj7IWSg06oll(object P_0, object P_1)
	{
		((ViewAttributes)P_0).OnChangeScriptName = (string)P_1;
	}

	internal static void VM7mMxrTesSPsFbr0tR(object P_0, CodeType value)
	{
		((ViewAttributes)P_0).OnChangeCodeType = value;
	}

	internal static object o4RVf5rkKycPEjBv5mH(object P_0)
	{
		return ((ViewAttributes)P_0).OnViewLoadScriptName;
	}

	internal static object UEtUAvrnTgIEthkKCEI(object P_0)
	{
		return ((RootViewItem)P_0).Items;
	}

	internal static void bJfuJlrOZffNN5s76bu(object P_0)
	{
		UpdateNestedPropertyViewItem(P_0);
	}

	internal static void oWtdKlr2LXEqh4vIEwi(object P_0, object P_1)
	{
		((ComputedValue)P_0).Name = (string)P_1;
	}

	internal static void EvlL9jre6s6xutCVxrb(object P_0, ComputedValueType value)
	{
		((ComputedValue)P_0).ComputedValueType = value;
	}

	internal static object dZJLaQrPUf7cfyTxMbo(object P_0)
	{
		return ((ButtonViewItem)P_0).ScriptName;
	}

	internal static void SAqTv5r1g6PvyF9LDSc(object P_0, CodeType value)
	{
		((ButtonViewItem)P_0).CodeType = value;
	}

	internal static object IPGHcArNpO0rK6ENjkJ(object P_0)
	{
		return ((FormViewItem)P_0).Toolbar;
	}

	internal static object rWV6Arr33cqBQRkeYxX(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object MOc0umrpFhC3moYbLYE(object P_0)
	{
		return ((Button)P_0).ScriptName;
	}

	internal static void Usye9lraC9JxpfW81h8(object P_0, CodeType value)
	{
		((Button)P_0).CodeType = value;
	}

	internal static void OhHl1krDaVqgOFOU7Nw(object P_0, object P_1)
	{
		((FormView)P_0).OnLoadScriptName = (string)P_1;
	}

	internal static void YvDakZrtMadynhdy26m(object P_0, RuntimeVersion value)
	{
		((FormViewItem)P_0).RuntimeVersion = value;
	}

	internal static object jwFDDyrw0XeTWakf6ZD(object P_0)
	{
		return ((ComponentMetadataItem)P_0).ScriptModule;
	}

	internal static object vkKrYmr4r9WpZvw8jH6()
	{
		return CSharpParseOptions.get_Default();
	}

	internal static object COWXvVr60lNhJrVyDAY(object P_0, LanguageVersion P_1)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((CSharpParseOptions)P_0).WithLanguageVersion(P_1);
	}

	internal static object vvZ7hyrHQJfEKntXuFL(object P_0)
	{
		return ((ScriptModule)P_0).SourceCode;
	}

	internal static object J6wtPNrArWqgM58V4OP(object P_0, CancellationToken P_1)
	{
		return ((SyntaxTree)P_0).GetRoot(P_1);
	}

	internal static object RXsW06r7fXKiOOaD7eW(object P_0)
	{
		return ((UsingDirectiveSyntax)P_0).get_Name();
	}

	internal static object WDAIHarxL0MR7HLB8GN(object P_0, object P_1)
	{
		return ((FormMetadataUpdateHandler)P_0).GetMetadataName((IMetadataUpdateResult)P_1);
	}

	internal static SyntaxTokenList UNV9okr0AQ3mkIvt0s3(object P_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((MemberDeclarationSyntax)P_0).get_Modifiers();
	}

	internal static SyntaxTokenList EfRHVurmIoKp5rGR2i0(SyntaxToken P_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		return SyntaxTokenList.Create(P_0);
	}

	internal static object mi5wNbryEBj6TbuDyHx(object P_0, object P_1)
	{
		return ((FormMetadataUpdateHandler)P_0).GetViewModelTypeName((IMetadataUpdateResult)P_1);
	}

	internal static object cbC7XQrMfYOQYc4YaFo(object P_0, object P_1)
	{
		return ((FormMetadataUpdateHandler)P_0).GetLoadViewModelTypeName((IMetadataUpdateResult)P_1);
	}

	internal static object ih9fXhrJNRt1QARXQXC(object P_0)
	{
		return ((FormMetadataUpdateHandler)P_0).ItemViewModelTypeName;
	}

	internal static object iSkaTcr9LaRmDwN1Ite(object P_0)
	{
		return ((BaseMethodDeclarationSyntax)P_0).get_ParameterList();
	}

	internal static object vTdNW6rdPwODiIETfGj(object P_0)
	{
		return ((ParameterSyntax)P_0).get_Type();
	}

	internal static object WEoim0rlVRR30pfgGI0(object P_0)
	{
		return ((string)P_0).Trim();
	}

	internal static object fmUDr7rrrfRUlZkEhxq(object P_0, object P_1, object P_2)
	{
		return ((string)P_0).Replace((string)P_1, (string)P_2);
	}

	internal static object vbpkyrrgxGCfCgPtnds()
	{
		return Environment.NewLine;
	}

	internal static bool LbDodyr586pN13ZjWlR(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static object MHDFxJrjJgXhXaoJ9UP(object P_0, int P_1, bool P_2)
	{
		return SyntaxFactory.ParseTypeName((string)P_0, P_1, P_2);
	}

	internal static SyntaxTriviaList qCMWjarYd22ntNehs2r(object P_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((CSharpSyntaxNode)P_0).GetTrailingTrivia();
	}

	internal static object kGeHEHrL7Og3sAN9spx(object P_0, object P_1)
	{
		return ((ParameterSyntax)P_0).WithType((TypeSyntax)P_1);
	}

	internal static object ClscPLrUqvnrJy1wHI8(object P_0, object P_1)
	{
		return ((string)P_0).Split((char[])P_1);
	}

	internal static object uIFwRwrsCw5FXV9rdX4(object P_0, object P_1)
	{
		return ((MethodDeclarationSyntax)P_0).WithParameterList((ParameterListSyntax)P_1);
	}

	internal static SyntaxToken liMSIjrcM7xvGO0Shyr(object P_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((BaseTypeDeclarationSyntax)P_0).get_Identifier();
	}

	internal static object UMB2lyrzdiff8p1T5d2(object P_0)
	{
		return ((SyntaxNode)P_0).ToFullString();
	}

	internal static object nj4XDBgFtKGH2sXNEJX(object P_0, object P_1, StringSplitOptions P_2)
	{
		return ((string)P_0).Split((string[])P_1, P_2);
	}

	internal static object hquljLgB1VwXei7iToX(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static void llKYIYgWt3NRycrXZbk(object P_0, bool value)
	{
		((ViewModelPropertyMetadata)P_0).Input = value;
	}

	internal static void khO4JigoL4GyUFJ6NUL(object P_0, object P_1)
	{
		((ViewModelPropertyMetadata)P_0).ComputedValue = (ComputedValue)P_1;
	}

	internal static void beN7DCgb0QRmEbycXxL(object P_0)
	{
		((List<Guid>)P_0).Clear();
	}

	internal static int ANtxYkghj88QxxXL3br(object P_0)
	{
		return ((EventedList<ViewItem>)P_0).Count;
	}

	internal static bool eAm4JmgGmZa8gEh62hy(object P_0, object P_1)
	{
		return ((string)P_0).Contains((string)P_1);
	}

	internal static object NfhNJdgEvye7B4YVOOF(object P_0, int P_1, int P_2)
	{
		return ((string)P_0).Substring(P_1, P_2);
	}

	internal static void zwTfAwgffHKtB1YxFq4(object P_0, Guid value)
	{
		((ScriptMethodInfo)P_0).MetadataUid = value;
	}

	internal static object k1kgTogQfJIVNtTAQHn(object P_0)
	{
		return ScriptMethodInfoHelper.Serialize((ScriptMethodInfo)P_0);
	}
}
