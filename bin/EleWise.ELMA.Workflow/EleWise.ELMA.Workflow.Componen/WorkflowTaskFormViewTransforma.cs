using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Diagrams;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Transformations;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Tasks.Models;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Tasks;
using EleWise.ELMA.Workflow.ExtensionPoints;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Components;

public class WorkflowTaskFormViewTransformate
{
	internal static WorkflowTaskFormViewTransformate CpsnC2O58KFMIwgkMh05;

	public static FormViewItemTransformation GetTransformation(EntityMetadata metadata, ViewType viewType)
	{
		//Discarded unreachable code: IL_037f, IL_0407, IL_0416, IL_049f
		int num = 1;
		ColumnsLayoutViewItem columnsLayoutViewItem = default(ColumnsLayoutViewItem);
		FormView formView2 = default(FormView);
		TabViewItem tabViewItem = default(TabViewItem);
		PanelViewItem item2 = default(PanelViewItem);
		FormViewItemTransformation formViewItemTransformation = default(FormViewItemTransformation);
		PanelViewItem item = default(PanelViewItem);
		FormView formView = default(FormView);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 6:
					((EventedList<ViewItem>)iisFj0O5dUCMONZmIvP1(columnsLayoutViewItem)).Add((ViewItem)new ColumnViewItem
					{
						Uid = new Guid(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-683713632 ^ -683762278))
					});
					num = 15;
					break;
				case 7:
					if (formView2 == null)
					{
						num2 = 6;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bf623f11574746d6bf3837b66460c576 != 0)
						{
							num2 = 13;
						}
						continue;
					}
					goto case 19;
				case 4:
					((EventedList<ViewItem>)iisFj0O5dUCMONZmIvP1(tabViewItem)).Add((ViewItem)item2);
					num2 = 18;
					continue;
				case 2:
				{
					ColumnsLayoutViewItem columnsLayoutViewItem2 = new ColumnsLayoutViewItem();
					gNJ8pZO5bTK0xv0A5xTR(columnsLayoutViewItem2, new Guid((string)zX95TgO5mFQC8E3ElWef(0x8D5763A ^ 0x8D4B398)));
					columnsLayoutViewItem = columnsLayoutViewItem2;
					num2 = 14;
					continue;
				}
				case 20:
					formViewItemTransformation.Items.Add(ViewItemTransformation.Add(new Guid((string)zX95TgO5mFQC8E3ElWef(-1498811449 ^ -1498872543)), item, null, new Guid((string)zX95TgO5mFQC8E3ElWef(0x1AF6F1F2 ^ 0x1AF732B4))));
					num2 = 19;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bae2bde9e5844c638021cdb56fc01122 == 0)
					{
						num2 = 25;
					}
					continue;
				case 22:
					RvEXvjO5yJJaL6Ko0sOn(tabViewItem, HideEmptyEnum.HideEmpty);
					num2 = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b4c7ccafb1de4af2aa93fb9f2842508b == 0)
					{
						num2 = 2;
					}
					continue;
				case 12:
					return null;
				case 16:
					formViewItemTransformation.Items.Add(ViewItemTransformation.Add(new Guid(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-790221436 ^ -790107658)), tabViewItem, new Guid((string)zX95TgO5mFQC8E3ElWef(-1514166050 ^ -1514247072)), new Guid((string)zX95TgO5mFQC8E3ElWef(-148495695 ^ -148379717))));
					num2 = 3;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d843b0b7f23e489fb6d586d64b0a634a == 0)
					{
						num2 = 0;
					}
					continue;
				case 19:
					if (formView2.UseRazorView)
					{
						num2 = 10;
						continue;
					}
					goto case 13;
				case 1:
					if (nO6O9OO5lTXFTvlyHVKN(metadata) != ClassFormsScheme.FormConstructor)
					{
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_be442748c2c44d33a71dd83576ab2ba4 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 21;
				case 3:
					if (cDuPppO5XaD6YHO9ulyp(formView))
					{
						num2 = 9;
						continue;
					}
					goto case 22;
				case 11:
				{
					PanelViewItem panelViewItem2 = new PanelViewItem();
					gNJ8pZO5bTK0xv0A5xTR(panelViewItem2, new Guid((string)zX95TgO5mFQC8E3ElWef(-45832783 ^ -45783517)));
					panelViewItem2.CustomViewName = (string)paxb43O55YgJL1Bl8NsU(formView2);
					item = panelViewItem2;
					num2 = 20;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0fbdcdb2cea84e8d8852886ebe735d8f == 0)
					{
						num2 = 14;
					}
					continue;
				}
				case 10:
					formViewItemTransformation.Items.Add((ViewItemTransformation)SIU6UNO5tAFCPjWNHmXp(new Guid((string)zX95TgO5mFQC8E3ElWef(-1303601216 ^ -1303552890))));
					num2 = 11;
					continue;
				case 13:
				case 25:
					if (formView == null)
					{
						num2 = 17;
						continue;
					}
					goto case 23;
				case 26:
				{
					object obj2 = iisFj0O5dUCMONZmIvP1(columnsLayoutViewItem);
					ColumnViewItem columnViewItem = new ColumnViewItem();
					gNJ8pZO5bTK0xv0A5xTR(columnViewItem, new Guid(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1145BED7 ^ 0x11447B39)));
					((EventedList<ViewItem>)obj2).Add((ViewItem)columnViewItem);
					num2 = 6;
					continue;
				}
				case 8:
				case 17:
				case 18:
					if (formViewItemTransformation.Items.Any())
					{
						return formViewItemTransformation;
					}
					num2 = 12;
					continue;
				case 15:
					formViewItemTransformation.Items.Add(ViewItemTransformation.Move(bklV18O5ubdZmGef0UIx(columnsLayoutViewItem), new Guid((string)zX95TgO5mFQC8E3ElWef(-1542190822 ^ -1542074468))));
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5816b3723c134946ad9294172266312e == 0)
					{
						num2 = 8;
					}
					continue;
				case 14:
					((EventedList<ViewItem>)iisFj0O5dUCMONZmIvP1(tabViewItem)).Add((ViewItem)columnsLayoutViewItem);
					num2 = 26;
					continue;
				case 24:
					formViewItemTransformation.Uid = new Guid((string)zX95TgO5mFQC8E3ElWef(-1574607501 ^ -1574633985));
					num2 = 7;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0262725a60774e44a84fd2b93b79ee8a == 0)
					{
						num2 = 3;
					}
					continue;
				case 9:
				{
					PanelViewItem panelViewItem = new PanelViewItem();
					gNJ8pZO5bTK0xv0A5xTR(panelViewItem, new Guid((string)zX95TgO5mFQC8E3ElWef(-1776305410 ^ -1776386136)));
					panelViewItem.CustomViewName = formView.RazorTabViewName;
					item2 = panelViewItem;
					num = 4;
					break;
				}
				default:
					if (viewType != ViewType.Edit)
					{
						num = 21;
						break;
					}
					formViewItemTransformation = new FormViewItemTransformation();
					num2 = 27;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b876fa7b083748c8abf8c4b192a11078 == 0)
					{
						num2 = 26;
					}
					continue;
				case 21:
				{
					FormViewItemTransformation result = new FormViewItemTransformation();
					FormViewItem formViewItem = (FormViewItem)NWZhAlO50F6gwO4LWfkj(metadata.DefaultForms, ViewType.Edit);
					if (formViewItem != null)
					{
						if (formViewItem.FindItems(ignoreHide: true, delegate(ViewItem a)
						{
							int num5 = 1;
							int num6 = num5;
							Guid guid = default(Guid);
							while (true)
							{
								switch (num6)
								{
								default:
									return guid.Equals(new Guid((string)_003C_003Ec.xN13xkvv0lO4BrD53j3w(-43932417 ^ -43814021)));
								case 1:
									guid = _003C_003Ec.hB1ZKEvvl4dtK4NPA6Yn(a);
									num6 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ac5d16a577a84bb0b8ee3654769d2d33 != 0)
									{
										num6 = 0;
									}
									break;
								}
							}
						}).FirstOrDefault() is TabViewItem tabViewItem2)
						{
							RvEXvjO5yJJaL6Ko0sOn(tabViewItem2, HideEmptyEnum.ShowEmpty);
						}
						if (formViewItem.FindItems(ignoreHide: true, delegate(ViewItem a)
						{
							int num3 = 1;
							int num4 = num3;
							Guid uid = default(Guid);
							while (true)
							{
								switch (num4)
								{
								default:
									return uid.Equals(new Guid(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-667465279 ^ -667574767)));
								case 1:
									uid = a.Uid;
									num4 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_85ba8d91af394836ac86666c40b1e150 == 0)
									{
										num4 = 0;
									}
									break;
								}
							}
						}).FirstOrDefault() is TabViewItem tabViewItem3)
						{
							RvEXvjO5yJJaL6Ko0sOn(tabViewItem3, HideEmptyEnum.ShowEmpty);
						}
					}
					return result;
				}
				case 27:
					formView2 = metadata.FormViews.FirstOrDefault(delegate(FormView v)
					{
						int num7 = 1;
						int num8 = num7;
						while (true)
						{
							switch (num8)
							{
							case 1:
								if (v.ViewType != ViewType.Display)
								{
									return false;
								}
								num8 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f33560c5d18b4e10b24a458578aa60fd != 0)
								{
									num8 = 0;
								}
								break;
							default:
								return v.ViewInCommon;
							}
						}
					});
					num2 = 5;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bb19f93c0a774f6cbdada859bba83212 == 0)
					{
						num2 = 4;
					}
					continue;
				case 5:
					formView = metadata.FormViews.FirstOrDefault(delegate(FormView v)
					{
						int num9 = 1;
						int num10 = num9;
						while (true)
						{
							switch (num10)
							{
							default:
								return v.ViewInTab;
							case 1:
								if (_003C_003Ec.pxfEKlvvyV5stm4GIQ6Y(v) != ViewType.Display)
								{
									return false;
								}
								num10 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_75a2d0f780b04098ba855df5729e6c30 != 0)
								{
									num10 = 0;
								}
								break;
							}
						}
					});
					num2 = 5;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_545887e65739480a965b7ddfab7d0632 == 0)
					{
						num2 = 24;
					}
					continue;
				case 23:
				{
					TabViewItem obj = new TabViewItem
					{
						Uid = new Guid(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1716458555 ^ -1716443109)),
						Caption = (string)(SW66DPO5BOE0sAq4KFYH(yeRewyO5g8EusKUfnVM3(formView)) ? SR.T((string)zX95TgO5mFQC8E3ElWef(-684210684 ^ -684326354)) : WSbNSmO5csLqdjWOxrhS(formView.ViewInTabName))
					};
					cMtkAsO5PX6sPHB2hGxw(obj, zX95TgO5mFQC8E3ElWef(-1514166050 ^ -1514247030));
					tabViewItem = obj;
					num2 = 13;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f870ea690334e7ab7599d275d195e9a != 0)
					{
						num2 = 16;
					}
					continue;
				}
				}
				break;
			}
		}
	}

	public static FormViewItemTransformation GetTaskSettingsTransformation(UserTaskElement element)
	{
		//Discarded unreachable code: IL_013d, IL_014c, IL_0374
		int num = 13;
		FormViewItemTransformation formViewItemTransformation = default(FormViewItemTransformation);
		PanelViewItem item = default(PanelViewItem);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 18:
					if (!string.IsNullOrEmpty((string)WiiZTIO5jNxc5cQglnYt(RbBppLO5W93vp4HnHves(element))))
					{
						num2 = 17;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0fbdcdb2cea84e8d8852886ebe735d8f != 0)
						{
							num2 = 21;
						}
						continue;
					}
					goto case 11;
				case 3:
					if (RbBppLO5W93vp4HnHves(element) != null)
					{
						num2 = 9;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0fbdcdb2cea84e8d8852886ebe735d8f != 0)
						{
							num2 = 18;
						}
						continue;
					}
					goto case 11;
				case 19:
					formViewItemTransformation.Items.Add((ViewItemTransformation)SIU6UNO5tAFCPjWNHmXp(new Guid(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1028861977 ^ -1028847307))));
					num2 = 5;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_9269d021c6f148b6a1c4afb8cee03b6c != 0)
					{
						num2 = 15;
					}
					continue;
				case 16:
					formViewItemTransformation.Items.Add((ViewItemTransformation)SIU6UNO5tAFCPjWNHmXp(new Guid((string)zX95TgO5mFQC8E3ElWef(0x37F755F5 ^ 0x37F69DBB))));
					num2 = 3;
					continue;
				default:
					if (!xTD4d4O59wbmUR0lvvFD(dTkYZ9O5DWWgNSJhjGac(element)))
					{
						num2 = 16;
						continue;
					}
					goto case 3;
				case 4:
					formViewItemTransformation.Items.Add((ViewItemTransformation)SIU6UNO5tAFCPjWNHmXp(new Guid((string)zX95TgO5mFQC8E3ElWef(-106528299 ^ -106477889))));
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d843b0b7f23e489fb6d586d64b0a634a == 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
				case 8:
					if (!bNhivkO5HY5xwidq4KAC(dTkYZ9O5DWWgNSJhjGac(element)))
					{
						num2 = 7;
						continue;
					}
					goto case 6;
				case 9:
					if (!element.FormSettings.ShowCommonInfo)
					{
						num2 = 19;
						continue;
					}
					goto case 15;
				case 17:
					formViewItemTransformation.Items.Add(ViewItemTransformation.Move(new Guid(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-63028171 ^ -62923591)), new Guid((string)zX95TgO5mFQC8E3ElWef(-2057730233 ^ -2057813927)), new Guid((string)zX95TgO5mFQC8E3ElWef(0x75872B6 ^ 0x7588450)), new Guid((string)zX95TgO5mFQC8E3ElWef(0x37F755F5 ^ 0x37F69187))));
					num2 = 5;
					continue;
				case 13:
					if (element.FormSettings == null)
					{
						num = 12;
						break;
					}
					formViewItemTransformation = new FormViewItemTransformation();
					num2 = 4;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7d23dbc0284240b99ff34f0f55f345f6 == 0)
					{
						num2 = 9;
					}
					continue;
				case 11:
					if (!formViewItemTransformation.Items.Any())
					{
						num2 = 10;
						continue;
					}
					return formViewItemTransformation;
				case 15:
					if (k7p6c5O5nWTdX5P172U5(dTkYZ9O5DWWgNSJhjGac(element)))
					{
						num2 = 2;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b84ccb8b1bd147ef900b852047ecbf45 == 0)
						{
							num2 = 8;
						}
						continue;
					}
					goto case 17;
				case 1:
				{
					PanelViewItem panelViewItem = new PanelViewItem();
					gNJ8pZO5bTK0xv0A5xTR(panelViewItem, new Guid((string)zX95TgO5mFQC8E3ElWef(-432000546 ^ -431884696)));
					panelViewItem.CustomViewName = (string)WtCR5tO5LqkN1sZcIZqX(dTkYZ9O5DWWgNSJhjGac(element));
					panelViewItem.UseOriginalModel = true;
					item = panelViewItem;
					num2 = 14;
					continue;
				}
				case 6:
					if (PkbuTvO5fu15aManhLyA(WtCR5tO5LqkN1sZcIZqX(element.FormSettings)))
					{
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ac5d16a577a84bb0b8ee3654769d2d33 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 4;
				case 5:
					formViewItemTransformation.Items.Add((ViewItemTransformation)SIU6UNO5tAFCPjWNHmXp(new Guid((string)zX95TgO5mFQC8E3ElWef(-2125897096 ^ -2125945334))));
					num2 = 2;
					continue;
				case 10:
					return null;
				case 14:
					formViewItemTransformation.Items.Add(ViewItemTransformation.Add(new Guid(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x42311138 ^ 0x4230D93A)), item));
					num2 = 20;
					continue;
				case 12:
					return null;
				case 21:
				{
					List<ViewItemTransformation> items = formViewItemTransformation.Items;
					Guid itemUid = new Guid((string)zX95TgO5mFQC8E3ElWef(0x56F860D7 ^ 0x56F9F85B));
					ParameterExpression parameterExpression = (ParameterExpression)cGaItnO5RmZlU3bOG4Tj(typeof(FormViewItem), zX95TgO5mFQC8E3ElWef(0x63D6C913 ^ 0x63D66C5D));
					items.Add(ViewItemTransformation<FormViewItem>.SetPropertyValue(itemUid, Expression.Lambda<Func<FormViewItem, string>>((Expression)bweXjJO5qxS1WQWXOTqU(parameterExpression, (MethodInfo)PMW8hnO56GenGqSZjYJG((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), (string)WiiZTIO5jNxc5cQglnYt(RbBppLO5W93vp4HnHves(element))));
					num = 11;
					break;
				}
				}
				break;
			}
		}
	}

	public static FormView GetViewItem(IWorkflowTaskBase task)
	{
		//Discarded unreachable code: IL_00a5, IL_00b4, IL_0100, IL_019c, IL_0242
		int num = 18;
		_003C_003Ec__DisplayClass2_0 _003C_003Ec__DisplayClass2_ = default(_003C_003Ec__DisplayClass2_0);
		FormView formView = default(FormView);
		IWorkflowProcess workflowProcess = default(IWorkflowProcess);
		IElementWithFormConstructorView elementWithFormConstructorView = default(IElementWithFormConstructorView);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				object obj;
				switch (num2)
				{
				case 18:
					_003C_003Ec__DisplayClass2_ = new _003C_003Ec__DisplayClass2_0();
					num2 = 17;
					continue;
				case 11:
				case 12:
					return formView;
				default:
					if (formView != null)
					{
						num2 = 3;
						continue;
					}
					goto case 11;
				case 3:
					formView = (FormView)FVxHlrO57wZ4sAiG6uUa(formView);
					num2 = 11;
					continue;
				case 7:
					formView = (FormView)xjXynsO5Ae3Gv8kkJmrg(((ComponentManager)rY82fUO5VF9cRAogoWCJ()).GetExtensionPoints<IElementWithViewTransformation>().First(_003C_003Ec__DisplayClass2_._003CGetViewItem_003Eb__1), _003C_003Ec__DisplayClass2_.element, _003C_003Ec__DisplayClass2_.task);
					num2 = 13;
					continue;
				case 5:
					obj = null;
					break;
				case 1:
					workflowProcess = (IWorkflowProcess)KXB2r9O5Q3BfqW4W4uGB(gleZwXO5TljpbbmoRoPk(_003C_003Ec__DisplayClass2_.task.WorkflowBookmark));
					num2 = 4;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6b089b0d02ae4d3186c8d2cb8a24d4d3 != 0)
					{
						num2 = 2;
					}
					continue;
				case 2:
					return null;
				case 8:
					_003C_003Ec__DisplayClass2_.element = ((IEnumerable<Element>)qAeCQVO5pvZvq4APMWl7(((IWorkflowProcess)KXB2r9O5Q3BfqW4W4uGB(gleZwXO5TljpbbmoRoPk(CFlGLwO53mCLyMoifQ5i(_003C_003Ec__DisplayClass2_.task)))).Diagram)).FirstOrDefault(_003C_003Ec__DisplayClass2_._003CGetViewItem_003Eb__0) as IElementWithView;
					num2 = 10;
					continue;
				case 10:
					if (_003C_003Ec__DisplayClass2_.element == null)
					{
						num2 = 9;
						continue;
					}
					elementWithFormConstructorView = _003C_003Ec__DisplayClass2_.element as IElementWithFormConstructorView;
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_67df302d7a2e4c95b7c8b62f21f3a833 == 0)
					{
						num2 = 1;
					}
					continue;
				case 9:
					return null;
				case 15:
					if (UaBDS6O5MLlQe2taBNJt(k45yNYO5CVw6R3KBioMl(elementWithFormConstructorView), Guid.Empty))
					{
						num2 = 9;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_160bffb148c14c5da92d8d6ddf481bdc == 0)
						{
							num2 = 14;
						}
						continue;
					}
					goto case 5;
				case 17:
					_003C_003Ec__DisplayClass2_.task = task;
					num2 = 6;
					continue;
				case 6:
					if (_003C_003Ec__DisplayClass2_.task != null)
					{
						goto end_IL_0012;
					}
					goto case 2;
				case 4:
					if (elementWithFormConstructorView != null)
					{
						num2 = 15;
						continue;
					}
					goto case 5;
				case 16:
					if (formView == null)
					{
						num2 = 2;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_08023922bb0e4e809e5cff73a2b04988 != 0)
						{
							num2 = 7;
						}
						continue;
					}
					goto case 13;
				case 13:
					if (tyhDpGO5G5xnd6JXDh5E(_003C_003Ec__DisplayClass2_.task))
					{
						num2 = 12;
						continue;
					}
					goto default;
				case 14:
					obj = QiCPqyO5UOA9g82757QT(GuYY1RO5ksETki68PdPF(workflowProcess), elementWithFormConstructorView.FormUid, workflowProcess, false);
					break;
				}
				formView = (FormView)obj;
				num2 = 16;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f19dffab164a41148300de28b2deec39 == 0)
				{
					num2 = 1;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 8;
		}
	}

	public static FormView GetViewItem(IWorkflowTaskBase task, Guid formUid)
	{
		//Discarded unreachable code: IL_007c, IL_008b
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (task != null)
				{
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d42a29e78d4a45518985de3631ade50c != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto default;
			default:
				return null;
			case 1:
				return (FormView)QiCPqyO5UOA9g82757QT(GuYY1RO5ksETki68PdPF(KXB2r9O5Q3BfqW4W4uGB(((IWorkflowBookmark)CFlGLwO53mCLyMoifQ5i(task)).Instance)), formUid, KXB2r9O5Q3BfqW4W4uGB(gleZwXO5TljpbbmoRoPk(task.WorkflowBookmark)), false);
			}
		}
	}

	public WorkflowTaskFormViewTransformate()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		YAJ7cXO5278ij7bToewW();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_be442748c2c44d33a71dd83576ab2ba4 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static ClassFormsScheme nO6O9OO5lTXFTvlyHVKN(object P_0)
	{
		return ((ClassMetadata)P_0).FormsScheme;
	}

	internal static object NWZhAlO50F6gwO4LWfkj(object P_0, ViewType P_1)
	{
		return ((ClassDefaultForms)P_0).GetForm(P_1);
	}

	internal static void RvEXvjO5yJJaL6Ko0sOn(object P_0, HideEmptyEnum P_1)
	{
		((RootViewItem)P_0).HideEmptySettings = P_1;
	}

	internal static object zX95TgO5mFQC8E3ElWef(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object SIU6UNO5tAFCPjWNHmXp(Guid P_0)
	{
		return ViewItemTransformation.Hide(P_0);
	}

	internal static void gNJ8pZO5bTK0xv0A5xTR(object P_0, Guid P_1)
	{
		((ViewItem)P_0).Uid = P_1;
	}

	internal static object paxb43O55YgJL1Bl8NsU(object P_0)
	{
		return ((FormView)P_0).RazorCommonViewName;
	}

	internal static object yeRewyO5g8EusKUfnVM3(object P_0)
	{
		return ((FormView)P_0).ViewInTabName;
	}

	internal static bool SW66DPO5BOE0sAq4KFYH(object P_0)
	{
		return string.IsNullOrWhiteSpace((string)P_0);
	}

	internal static object WSbNSmO5csLqdjWOxrhS(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static void cMtkAsO5PX6sPHB2hGxw(object P_0, object P_1)
	{
		((ViewItem)P_0).Name = (string)P_1;
	}

	internal static bool cDuPppO5XaD6YHO9ulyp(object P_0)
	{
		return ((FormView)P_0).UseRazorView;
	}

	internal static object iisFj0O5dUCMONZmIvP1(object P_0)
	{
		return ((RootViewItem)P_0).Items;
	}

	internal static Guid bklV18O5ubdZmGef0UIx(object P_0)
	{
		return ((ViewItem)P_0).Uid;
	}

	internal static bool KsUP4SO5sJZpm7lrP4wm()
	{
		return CpsnC2O58KFMIwgkMh05 == null;
	}

	internal static WorkflowTaskFormViewTransformate cYLKjRO5J6j6eRXNw9nX()
	{
		return CpsnC2O58KFMIwgkMh05;
	}

	internal static object dTkYZ9O5DWWgNSJhjGac(object P_0)
	{
		return ((UserTaskElement)P_0).FormSettings;
	}

	internal static bool k7p6c5O5nWTdX5P172U5(object P_0)
	{
		return ((UserTaskFormSettings)P_0).ShowTabs;
	}

	internal static bool bNhivkO5HY5xwidq4KAC(object P_0)
	{
		return ((UserTaskFormSettings)P_0).UseCustomView;
	}

	internal static object WtCR5tO5LqkN1sZcIZqX(object P_0)
	{
		return ((UserTaskFormSettings)P_0).CustomViewName;
	}

	internal static bool PkbuTvO5fu15aManhLyA(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static bool xTD4d4O59wbmUR0lvvFD(object P_0)
	{
		return ((UserTaskFormSettings)P_0).ShowConnectorButtons;
	}

	internal static object RbBppLO5W93vp4HnHves(object P_0)
	{
		return ((UserTaskElement)P_0).View;
	}

	internal static object WiiZTIO5jNxc5cQglnYt(object P_0)
	{
		return ((FormView)P_0).OnLoadScriptName;
	}

	internal static object cGaItnO5RmZlU3bOG4Tj(Type P_0, object P_1)
	{
		return Expression.Parameter(P_0, (string)P_1);
	}

	internal static object PMW8hnO56GenGqSZjYJG(RuntimeMethodHandle P_0)
	{
		return MethodBase.GetMethodFromHandle(P_0);
	}

	internal static object bweXjJO5qxS1WQWXOTqU(object P_0, object P_1)
	{
		return Expression.Property((Expression)P_0, (MethodInfo)P_1);
	}

	internal static object CFlGLwO53mCLyMoifQ5i(object P_0)
	{
		return ((IWorkflowTaskBase)P_0).WorkflowBookmark;
	}

	internal static object gleZwXO5TljpbbmoRoPk(object P_0)
	{
		return ((IWorkflowBookmark)P_0).Instance;
	}

	internal static object KXB2r9O5Q3BfqW4W4uGB(object P_0)
	{
		return ((IWorkflowInstance)P_0).Process;
	}

	internal static object qAeCQVO5pvZvq4APMWl7(object P_0)
	{
		return ((Diagram)P_0).Elements;
	}

	internal static Guid k45yNYO5CVw6R3KBioMl(object P_0)
	{
		return ((IElementWithFormConstructorView)P_0).FormUid;
	}

	internal static bool UaBDS6O5MLlQe2taBNJt(Guid P_0, Guid P_1)
	{
		return P_0 != P_1;
	}

	internal static object GuYY1RO5ksETki68PdPF(object P_0)
	{
		return ((IWorkflowProcess)P_0).Forms;
	}

	internal static object QiCPqyO5UOA9g82757QT(object P_0, Guid formUid, object P_2, bool checkExists)
	{
		return ((WorkflowFormsContainer)P_0).CreateFormViewItem(formUid, (IWorkflowProcess)P_2, checkExists);
	}

	internal static object rY82fUO5VF9cRAogoWCJ()
	{
		return ComponentManager.Current;
	}

	internal static object xjXynsO5Ae3Gv8kkJmrg(object P_0, object P_1, object P_2)
	{
		return ((IElementWithViewTransformation)P_0).GetFormView((IElementWithView)P_1, (IWorkflowTaskBase)P_2);
	}

	internal static bool tyhDpGO5G5xnd6JXDh5E(object P_0)
	{
		return ((ITaskBase)P_0).CanExecute();
	}

	internal static object FVxHlrO57wZ4sAiG6uUa(object P_0)
	{
		return ((FormView)P_0).CloneAsReadOnly();
	}

	internal static void YAJ7cXO5278ij7bToewW()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}
}
