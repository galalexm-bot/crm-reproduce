using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Mappings;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Model.Scripts.Entities;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Workflow.Managers;
using EleWise.ELMA.Workflow.Models;
using EleWise.ELMA.Workflow.Scripts;
using EleWise.ELMA.Workflow.ViewItems;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Components;

[Component]
internal sealed class ProcessContextUpdateHandler : BaseMetadataUpdateHandler
{
	private readonly WorkflowProcessManager processManager;

	internal static ProcessContextUpdateHandler pY3ZY1Ol0gFAvpP9uoJ6;

	public ProcessContextUpdateHandler(WorkflowProcessManager processManager)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		P66w8EOltZV143VeAV4T();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b1ab9396b25b43af8f32e24b1948be96 != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				this.processManager = processManager;
				num = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e8980a9fd9d44c20920ffa276900c96f != 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public override bool Check(IMetadata metadata)
	{
		return metadata is ProcessContext;
	}

	public override void UpdateMetadata(IMetadataUpdateResult updateResult)
	{
		//Discarded unreachable code: IL_00a1, IL_00b0
		int num = 3;
		int num2 = num;
		ProcessContext processContext = default(ProcessContext);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				return;
			case 4:
				processContext.ViewModelMetadata = (DataClassMetadata)guoRbZOl5iUiuDEsa3Cn(processContext);
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6e8c2dcf6eb644089ebbe42243c60e95 == 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				processContext = updateResult.Metadata as ProcessContext;
				num2 = 2;
				break;
			case 0:
				return;
			case 5:
				if (kE2kDjOlbfiwaMKcD7tB(processContext) != null)
				{
					return;
				}
				num2 = 4;
				break;
			case 2:
				if (processContext == null)
				{
					return;
				}
				num2 = 5;
				break;
			}
		}
	}

	public override void UpdateForm(IMetadataUpdateResult updateResult, Guid formUid)
	{
		//Discarded unreachable code: IL_009b, IL_00aa, IL_0120, IL_01c3, IL_01e5, IL_0237, IL_0246, IL_0255, IL_0265, IL_0274, IL_033a, IL_034d, IL_04d0, IL_04df, IL_05a0
		int num = 7;
		int num2 = num;
		FormViewItemTransformation formViewItemTransformation = default(FormViewItemTransformation);
		WorkflowTaskForm workflowTaskForm = default(WorkflowTaskForm);
		List<ViewItemTransformation>.Enumerator enumerator = default(List<ViewItemTransformation>.Enumerator);
		Dictionary<Guid, PropertyViewItem> dictionary = default(Dictionary<Guid, PropertyViewItem>);
		PropertyViewItem propertyViewItem2 = default(PropertyViewItem);
		ViewItemTransformationAdd viewItemTransformationAdd = default(ViewItemTransformationAdd);
		GridViewItem gridViewItem = default(GridViewItem);
		ViewItem viewItem = default(ViewItem);
		PropertyViewItem propertyViewItem = default(PropertyViewItem);
		ButtonViewItem buttonViewItem = default(ButtonViewItem);
		Guid modelPropertyUid = default(Guid);
		EntityMetadata taskMetadata = default(EntityMetadata);
		PropertyViewItem value = default(PropertyViewItem);
		_003C_003Ec__DisplayClass4_0 _003C_003Ec__DisplayClass4_ = default(_003C_003Ec__DisplayClass4_0);
		PropertyMetadata propertyMetadata = default(PropertyMetadata);
		IWorkflowProcess workflowProcess = default(IWorkflowProcess);
		ViewItemTransformationChange item = default(ViewItemTransformationChange);
		ProcessContext processContext = default(ProcessContext);
		while (true)
		{
			switch (num2)
			{
			case 22:
				if ((formViewItemTransformation = (FormViewItemTransformation)bNHpxbOlffFc0qqFnZ9G(workflowTaskForm)) != null)
				{
					num2 = 20;
					continue;
				}
				return;
			case 8:
				try
				{
					while (true)
					{
						IL_01a8:
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 10;
							goto IL_00b9;
						}
						goto IL_012a;
						IL_00b9:
						while (true)
						{
							switch (num3)
							{
							case 8:
								break;
							default:
								dictionary[e7DgjFOlRxDLlq0m41u0(propertyViewItem2)] = propertyViewItem2;
								num3 = 4;
								continue;
							case 18:
								if (viewItemTransformationAdd == null)
								{
									num3 = 12;
									continue;
								}
								goto case 3;
							case 16:
								if ((gridViewItem = viewItem as GridViewItem) != null)
								{
									num3 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cb262bcfe4074a1ab16e653815d57f28 != 0)
									{
										num3 = 1;
									}
									continue;
								}
								goto IL_01a8;
							case 6:
							{
								propertyViewItem2 = propertyViewItem;
								int num4 = 14;
								num3 = num4;
								continue;
							}
							case 2:
							case 4:
							case 7:
							case 12:
								goto IL_01a8;
							case 20:
							case 21:
								UpdateButtonViewItem(buttonViewItem, modelPropertyUid);
								num3 = 7;
								continue;
							case 1:
							case 9:
								UpdateGridViewItem(gridViewItem, taskMetadata);
								num3 = 2;
								continue;
							case 15:
								if ((buttonViewItem = viewItem as ButtonViewItem) != null)
								{
									num3 = 20;
									continue;
								}
								goto case 19;
							case 3:
								viewItem = (ViewItem)cV7bVnOlWhts8ttsetya(viewItemTransformationAdd);
								num3 = 13;
								continue;
							case 5:
								BTmQprOljLef6abKZLjf(propertyViewItem2, value);
								num3 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1b8b735647da470aa2d45d64d6f538d1 == 0)
								{
									num3 = 0;
								}
								continue;
							case 17:
								UpdatePropertyViewItem(propertyViewItem2, modelPropertyUid);
								num3 = 11;
								continue;
							case 13:
								if (viewItem != null)
								{
									num3 = 15;
									continue;
								}
								goto IL_01a8;
							case 19:
								if ((propertyViewItem = viewItem as PropertyViewItem) == null)
								{
									num3 = 16;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1733a11cae754a598119b94f8d9e4971 == 0)
									{
										num3 = 0;
									}
									continue;
								}
								goto case 6;
							case 14:
								if (dictionary.TryGetValue(viewItemTransformationAdd.Uid, out value))
								{
									num3 = 5;
									continue;
								}
								goto case 17;
							case 10:
								goto end_IL_01a8;
							}
							break;
						}
						goto IL_012a;
						IL_012a:
						viewItemTransformationAdd = enumerator.Current as ViewItemTransformationAdd;
						num3 = 18;
						goto IL_00b9;
						continue;
						end_IL_01a8:
						break;
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
					int num5 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b1ab9396b25b43af8f32e24b1948be96 == 0)
					{
						num5 = 0;
					}
					switch (num5)
					{
					case 0:
						break;
					}
				}
				goto case 15;
			case 6:
				_003C_003Ec__DisplayClass4_.formUid = formUid;
				num2 = 2;
				continue;
			case 9:
				if (propertyMetadata != null)
				{
					num2 = 4;
					continue;
				}
				return;
			case 14:
				if (workflowProcess != null)
				{
					num2 = 23;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_805f3361d2ba4dac8da4174f89314253 != 0)
					{
						num2 = 12;
					}
					continue;
				}
				return;
			case 19:
				return;
			case 4:
			{
				WorkflowProcessManager workflowProcessManager = processManager;
				ParameterExpression parameterExpression = Expression.Parameter(Sndf5oOlBeQBC0EtRhaC(typeof(IWorkflowProcess).TypeHandle), (string)keIMsVOlcThpKrl5dyFy(0x1C7F6FED ^ 0x1C7F6057));
				workflowProcess = workflowProcessManager.Find(Expression.Lambda<Func<IWorkflowProcess, bool>>((Expression)sY6USQOlnLY3BsQiqe1w(Expression.Property((Expression)eIB3y8OlXYu0cVBfiV6n(parameterExpression, (MethodInfo)VcLDUfOlP7sKI1R2GZP9((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (MethodInfo)wxSc44Old2gBejv5uhOU((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, typeof(Entity<long>).TypeHandle)), eIB3y8OlXYu0cVBfiV6n(OuMQB6OlDAAWXaO5aeij(Expression.Constant(_003C_003Ec__DisplayClass4_, typeof(_003C_003Ec__DisplayClass4_0)), mHwHPaOluTJ43UdlOnQA((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/)), (MethodInfo)wxSc44Old2gBejv5uhOU((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, typeof(Entity<long>).TypeHandle))), new ParameterExpression[1] { parameterExpression }), (FetchOptions)uYktVvOlHXr9vhskL541()).FirstOrDefault();
				num2 = 14;
				continue;
			}
			case 10:
				formViewItemTransformation.Items.Add(item);
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4cc62744d0eb4cd68219b70dcad3e68e == 0)
				{
					num2 = 1;
				}
				continue;
			case 18:
				return;
			case 21:
				return;
			case 7:
				_003C_003Ec__DisplayClass4_ = new _003C_003Ec__DisplayClass4_0();
				num2 = 6;
				continue;
			case 1:
				return;
			case 11:
				return;
			case 5:
				modelPropertyUid = xeZyW8Ol9eFq5xaCUec8(propertyMetadata);
				num2 = 15;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7d23dbc0284240b99ff34f0f55f345f6 == 0)
				{
					num2 = 17;
				}
				continue;
			case 12:
				if (workflowTaskForm == null)
				{
					return;
				}
				num2 = 14;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ba57b850b1d34fd9bce66a583e71dc16 != 0)
				{
					num2 = 22;
				}
				continue;
			case 2:
				processContext = (_003C_003Ec__DisplayClass4_.context = IhbgCjOlg4gQEJb3OVCT(updateResult) as ProcessContext);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_719514a5a8ae47ed84e5a777ead0dc9f != 0)
				{
					num2 = 0;
				}
				continue;
			case 17:
				dictionary = new Dictionary<Guid, PropertyViewItem>();
				num2 = 3;
				continue;
			case 23:
				if (eRypUQOlLEj7qvGOgswQ(workflowProcess) == null)
				{
					num2 = 18;
					continue;
				}
				goto case 13;
			case 20:
				taskMetadata = (EntityMetadata)InterfaceActivator.LoadMetadata<IWorkflowTask>();
				num2 = 5;
				continue;
			case 3:
				enumerator = formViewItemTransformation.Items.GetEnumerator();
				num2 = 8;
				continue;
			case 13:
				if (workflowProcess.Forms.Items != null)
				{
					workflowTaskForm = ((WorkflowFormsContainer)eRypUQOlLEj7qvGOgswQ(workflowProcess)).Items.OfType<WorkflowTaskForm>().FirstOrDefault(_003C_003Ec__DisplayClass4_._003CUpdateForm_003Eb__2);
					num2 = 12;
				}
				else
				{
					num2 = 21;
				}
				continue;
			case 15:
				item = (ViewItemTransformationChange)NaF4itOl6N92G9AVVIN5(this, _003C_003Ec__DisplayClass4_.formUid);
				num2 = 10;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a2041b18ca1f4a5cb8e5060163bfdb57 == 0)
				{
					num2 = 7;
				}
				continue;
			default:
				if (processContext == null)
				{
					num2 = 7;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_18b351a59a324c25b4f150a9771bcf69 == 0)
					{
						num2 = 11;
					}
					continue;
				}
				break;
			case 16:
				break;
			}
			propertyMetadata = ((ClassMetadata)kE2kDjOlbfiwaMKcD7tB(_003C_003Ec__DisplayClass4_.context)).Properties.Find((PropertyMetadata property) => _003C_003Ec.YUVRUhvOlSL9F9Rh63kJ(_003C_003Ec.GSSxGBvOs8rhQ8sWkSm2(property), _003C_003Ec.HpgIEJvOJNNpcPO27Vnx(-105863102 ^ -105835306)));
			num2 = 9;
		}
	}

	public override void UpdateScriptModules(IMetadataUpdateResult updateResult)
	{
		//Discarded unreachable code: IL_0036, IL_0040, IL_0129, IL_0161, IL_0170
		int num = 4;
		IEnumerator<ScriptModule> enumerator = default(IEnumerator<ScriptModule>);
		string text = default(string);
		ProcessContext processContext = default(ProcessContext);
		ScriptModule current = default(ScriptModule);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					try
					{
						while (true)
						{
							IL_00bd:
							int num3;
							if (!enumerator.MoveNext())
							{
								num3 = 3;
								goto IL_0044;
							}
							goto IL_0062;
							IL_0044:
							while (true)
							{
								switch (num3)
								{
								case 2:
									break;
								default:
									text = (string)MLD3JmOl3fbSgFRPP0b9(EcocadOlqld2lOoJvlww(processContext), keIMsVOlcThpKrl5dyFy(-768800937 ^ -768830761));
									num3 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b74fcd91509d46c3a9661cffb0465df0 == 0)
									{
										num3 = 1;
									}
									continue;
								case 4:
									goto IL_00bd;
								case 1:
									Q2B6XCOlpjswp60KFSNp(current, hPpUdROlQHQEn1wZNs4A(this, OsoOjvOlT3WSbhapRFyQ(current), text));
									num3 = 2;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b4c7ccafb1de4af2aa93fb9f2842508b != 0)
									{
										num3 = 4;
									}
									continue;
								case 3:
									return;
								}
								break;
							}
							goto IL_0062;
							IL_0062:
							current = enumerator.Current;
							num3 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3bb28bf622874b4689f9265e58d14823 != 0)
							{
								num3 = 0;
							}
							goto IL_0044;
						}
					}
					finally
					{
						if (enumerator != null)
						{
							int num4 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_db8eb3e90ad546d4b05544ab6326a49f != 0)
							{
								num4 = 0;
							}
							while (true)
							{
								switch (num4)
								{
								default:
									CfgMpwOlC8iOmVwvPAIb(enumerator);
									num4 = 1;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_639c11c7bb65456db9f29c9c42f28bf7 != 0)
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
				case 4:
					if ((processContext = IhbgCjOlg4gQEJb3OVCT(updateResult) as ProcessContext) == null)
					{
						return;
					}
					goto end_IL_0012;
				case 3:
					if (kE2kDjOlbfiwaMKcD7tB(processContext) != null)
					{
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1a2d7634479d44fb8d3718c31b05f73c != 0)
						{
							num2 = 0;
						}
						continue;
					}
					return;
				case 1:
					return;
				}
				enumerator = updateResult.ScriptModules.Where(delegate(ScriptModule sm)
				{
					//Discarded unreachable code: IL_006f, IL_007e, IL_00d1, IL_00db, IL_00ea, IL_00fa, IL_0109
					int num5 = 1;
					int num6 = num5;
					Guid? guid2 = default(Guid?);
					Guid uID = default(Guid);
					Guid? guid3 = default(Guid?);
					while (true)
					{
						Guid? guid;
						switch (num6)
						{
						case 5:
							if (guid2.HasValue)
							{
								num6 = 7;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3ab79470996d472f815915b21f45aac1 == 0)
								{
									num6 = 3;
								}
								continue;
							}
							goto case 9;
						case 3:
							uID = ProcessScriptModuleType.UID;
							num6 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a9be7e056b4e4b6e863b634c418144f1 != 0)
							{
								num6 = 5;
							}
							continue;
						case 1:
							if (sm != null)
							{
								num6 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_18b351a59a324c25b4f150a9771bcf69 == 0)
								{
									num6 = 0;
								}
								continue;
							}
							goto case 4;
						case 8:
							guid = guid3;
							break;
						case 9:
							return false;
						case 7:
							if (guid2.HasValue)
							{
								num6 = 6;
								continue;
							}
							goto case 2;
						case 4:
							guid3 = null;
							num6 = 8;
							continue;
						case 2:
							return true;
						case 6:
							return _003C_003Ec.RT5tGBvOyJFaKtRhJ1bm(guid2.GetValueOrDefault(), uID);
						default:
							guid = _003C_003Ec.OBPhF7vO0tUbQoVQ1ny9(sm);
							break;
						}
						guid2 = guid;
						num6 = 3;
					}
				}).GetEnumerator();
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f19dffab164a41148300de28b2deec39 == 0)
				{
					num2 = 0;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 3;
		}
	}

	private static void UpdatePropertyViewItem(object propertyViewItem, Guid modelPropertyUid)
	{
		//Discarded unreachable code: IL_0084, IL_0093
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 3:
				if (((PropertyViewItem)propertyViewItem).PropertyParents == null)
				{
					num2 = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b84ccb8b1bd147ef900b852047ecbf45 != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 1;
			default:
				((PropertyViewItem)propertyViewItem).PropertyParents.Add(modelPropertyUid);
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3b4403f77a00495e957e5e4a6840e5d3 == 0)
				{
					num2 = 5;
				}
				break;
			case 1:
				HVxLWlOlMitpUqo8ENgy(((PropertyViewItem)propertyViewItem).PropertyParents);
				num2 = 4;
				break;
			case 2:
				((PropertyViewItem)propertyViewItem).PropertyParents = new List<Guid>();
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b4c7ccafb1de4af2aa93fb9f2842508b == 0)
				{
					num2 = 0;
				}
				break;
			case 5:
				return;
			}
		}
	}

	private static void UpdateNestedPropertyViewItem(object propertyViewItem, object parentPropertyViewItem)
	{
		//Discarded unreachable code: IL_00d3, IL_00e2
		int num = 5;
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
			case 2:
				((PropertyViewItem)propertyViewItem).PropertyParents.AddRange(((PropertyViewItem)parentPropertyViewItem).PropertyParents);
				num2 = 3;
				break;
			case 6:
				HVxLWlOlMitpUqo8ENgy(((PropertyViewItem)propertyViewItem).PropertyParents);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bb19f93c0a774f6cbdada859bba83212 != 0)
				{
					num2 = 1;
				}
				break;
			case 5:
				if (((PropertyViewItem)propertyViewItem).PropertyParents == null)
				{
					num2 = 4;
					break;
				}
				goto case 6;
			case 4:
				((PropertyViewItem)propertyViewItem).PropertyParents = new List<Guid>();
				num2 = 2;
				break;
			case 3:
				((PropertyViewItem)propertyViewItem).PropertyParents.Add(kOZuKjOlkFRB4jl24CLu(parentPropertyViewItem));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e8980a9fd9d44c20920ffa276900c96f != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private static void UpdateButtonViewItem(object buttonViewItem, Guid modelPropertyUid)
	{
		//Discarded unreachable code: IL_0182
		int num = 6;
		FormBindingModel formBindingModel = default(FormBindingModel);
		string[] array = default(string[]);
		string actionId = default(string);
		string text = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 6:
					if (AaQYCTOlU6cAd47JUE1n(((ButtonViewItem)buttonViewItem).ActionTypeProviderId, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2077784392 ^ -2077872112)))
					{
						num2 = 5;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_46e05b4e09174e34a9c81741b8b77a2f == 0)
						{
							num2 = 5;
						}
						continue;
					}
					return;
				case 4:
					formBindingModel = ClassSerializationHelper.DeserializeObjectByXml<FormBindingModel>(array.ElementAt(array.Length - 2));
					num2 = 3;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6fe3beca34a9422e873cd6ef331760ae == 0)
					{
						num2 = 8;
					}
					continue;
				case 2:
					if (LyLT4LOlVWT9XyhB38Ji(actionId))
					{
						num2 = 10;
						continue;
					}
					break;
				case 3:
					return;
				case 10:
					return;
				case 5:
					actionId = ((ButtonViewItem)buttonViewItem).ActionId;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4ef74b4b7d13430e9d2f9b78cbdb367b == 0)
					{
						num2 = 2;
					}
					continue;
				default:
					text = (string)sjExmXOlGZMwn13efphi(formBindingModel, true);
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_eef7d2ca1c3c4b74aeb81172ed542639 != 0)
					{
						num2 = 1;
					}
					continue;
				case 1:
					array[array.Length - 2] = text;
					num2 = 9;
					continue;
				case 9:
					goto end_IL_0012;
				case 8:
					HtEP78OlADHG9nwHKjAZ(formBindingModel, new Guid[1] { modelPropertyUid });
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_32f3e755437f4eacb85c8a0d536f83ea == 0)
					{
						num2 = 0;
					}
					continue;
				case 7:
					break;
				}
				array = actionId.Split(new string[1] { (string)keIMsVOlcThpKrl5dyFy(-432000546 ^ -431913258) }, StringSplitOptions.None);
				num2 = 4;
				continue;
				end_IL_0012:
				break;
			}
			((ButtonViewItem)buttonViewItem).ActionId = (string)YXtp11Ol76NE6jJbHiEH(keIMsVOlcThpKrl5dyFy(0x17F0C5A2 ^ 0x17F172AA), array);
			num = 3;
		}
	}

	private static void UpdateGridViewItem(object gridViewItem, object taskMetadata)
	{
		//Discarded unreachable code: IL_003e, IL_015e, IL_0171, IL_0180, IL_01b2
		int num = 6;
		int num2 = num;
		List<PropertyMetadata>.Enumerator enumerator = default(List<PropertyMetadata>.Enumerator);
		string text3 = default(string);
		PropertyMetadata current = default(PropertyMetadata);
		string text = default(string);
		string text2 = default(string);
		while (true)
		{
			switch (num2)
			{
			case 4:
				try
				{
					while (true)
					{
						IL_00f5:
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 1;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_67df302d7a2e4c95b7c8b62f21f3a833 != 0)
							{
								num3 = 0;
							}
							goto IL_004c;
						}
						goto IL_011b;
						IL_0048:
						int num4;
						num3 = num4;
						goto IL_004c;
						IL_004c:
						while (true)
						{
							switch (num3)
							{
							case 3:
								break;
							case 2:
								text3 = (string)keIMsVOlcThpKrl5dyFy(0x75BAD659 ^ 0x75BB6139) + (string)EcocadOlqld2lOoJvlww(current);
								num3 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b30151cb26574dfaa8f9d818b0352d3b == 0)
								{
									num3 = 0;
								}
								continue;
							default:
								text = (string)GjIXkZOlonjZXZVDXotG(text, text2, text3);
								num3 = 5;
								continue;
							case 5:
								goto IL_00f5;
							case 4:
								goto IL_011b;
							case 1:
								goto end_IL_00f5;
							}
							break;
						}
						text2 = (string)keIMsVOlcThpKrl5dyFy(-197778752 ^ -197683816) + current.Name;
						num4 = 2;
						goto IL_0048;
						IL_011b:
						current = enumerator.Current;
						num4 = 3;
						goto IL_0048;
						continue;
						end_IL_00f5:
						break;
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
					int num5 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_18b351a59a324c25b4f150a9771bcf69 != 0)
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
			default:
				xi0brSOlFOeLy5MuIyNT(gridViewItem, text);
				num2 = 2;
				break;
			case 6:
				if (taskMetadata != null)
				{
					num2 = 5;
					break;
				}
				return;
			case 2:
				return;
			case 1:
				enumerator = ((ClassMetadata)taskMetadata).Properties.GetEnumerator();
				num2 = 4;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f236c3d0fade492db73e8204df65377d != 0)
				{
					num2 = 3;
				}
				break;
			case 3:
				return;
			case 5:
				text = (string)JQqv1pOl2t8NyrxJNcfl(gridViewItem);
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6dd19c81ff5e41fb8db9b50574437301 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static void P66w8EOltZV143VeAV4T()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static bool SYoHSTOlyR1gcSj8bZO3()
	{
		return pY3ZY1Ol0gFAvpP9uoJ6 == null;
	}

	internal static ProcessContextUpdateHandler WmyRe9OlmVCSd5wrJDpd()
	{
		return pY3ZY1Ol0gFAvpP9uoJ6;
	}

	internal static object kE2kDjOlbfiwaMKcD7tB(object P_0)
	{
		return ((EntityMetadata)P_0).ViewModelMetadata;
	}

	internal static object guoRbZOl5iUiuDEsa3Cn(object P_0)
	{
		return ((EntityMetadata)P_0).CreateViewModelMetadata();
	}

	internal static object IhbgCjOlg4gQEJb3OVCT(object P_0)
	{
		return ((IMetadataUpdateResult)P_0).Metadata;
	}

	internal static Type Sndf5oOlBeQBC0EtRhaC(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object keIMsVOlcThpKrl5dyFy(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object VcLDUfOlP7sKI1R2GZP9(RuntimeMethodHandle P_0)
	{
		return MethodBase.GetMethodFromHandle(P_0);
	}

	internal static object eIB3y8OlXYu0cVBfiV6n(object P_0, object P_1)
	{
		return Expression.Property((Expression)P_0, (MethodInfo)P_1);
	}

	internal static object wxSc44Old2gBejv5uhOU(RuntimeMethodHandle P_0, RuntimeTypeHandle P_1)
	{
		return MethodBase.GetMethodFromHandle(P_0, P_1);
	}

	internal static object mHwHPaOluTJ43UdlOnQA(RuntimeFieldHandle P_0)
	{
		return FieldInfo.GetFieldFromHandle(P_0);
	}

	internal static object OuMQB6OlDAAWXaO5aeij(object P_0, object P_1)
	{
		return Expression.Field((Expression)P_0, (FieldInfo)P_1);
	}

	internal static object sY6USQOlnLY3BsQiqe1w(object P_0, object P_1)
	{
		return Expression.Equal((Expression)P_0, (Expression)P_1);
	}

	internal static object uYktVvOlHXr9vhskL541()
	{
		return FetchOptions.First;
	}

	internal static object eRypUQOlLEj7qvGOgswQ(object P_0)
	{
		return ((IWorkflowProcess)P_0).Forms;
	}

	internal static object bNHpxbOlffFc0qqFnZ9G(object P_0)
	{
		return ((WorkflowTaskForm)P_0).Transformation;
	}

	internal static Guid xeZyW8Ol9eFq5xaCUec8(object P_0)
	{
		return ((AbstractMetadata)P_0).Uid;
	}

	internal static object cV7bVnOlWhts8ttsetya(object P_0)
	{
		return ((ViewItemTransformationAdd)P_0).Item;
	}

	internal static void BTmQprOljLef6abKZLjf(object P_0, object P_1)
	{
		UpdateNestedPropertyViewItem(P_0, P_1);
	}

	internal static Guid e7DgjFOlRxDLlq0m41u0(object P_0)
	{
		return ((ViewItem)P_0).Uid;
	}

	internal static object NaF4itOl6N92G9AVVIN5(object P_0, Guid P_1)
	{
		return ((BaseMetadataUpdateHandler)P_0).CreateViewItemTransformationChange(P_1);
	}

	internal static object EcocadOlqld2lOoJvlww(object P_0)
	{
		return ((NamedMetadata)P_0).Name;
	}

	internal static object MLD3JmOl3fbSgFRPP0b9(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static object OsoOjvOlT3WSbhapRFyQ(object P_0)
	{
		return ((ScriptModule)P_0).SourceCode;
	}

	internal static object hPpUdROlQHQEn1wZNs4A(object P_0, object P_1, object P_2)
	{
		return ((BaseMetadataUpdateHandler)P_0).UpdateServerSourceCode((string)P_1, (string)P_2);
	}

	internal static void Q2B6XCOlpjswp60KFSNp(object P_0, object P_1)
	{
		((ScriptModule)P_0).SourceCode = (string)P_1;
	}

	internal static void CfgMpwOlC8iOmVwvPAIb(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static void HVxLWlOlMitpUqo8ENgy(object P_0)
	{
		((List<Guid>)P_0).Clear();
	}

	internal static Guid kOZuKjOlkFRB4jl24CLu(object P_0)
	{
		return ((PropertyViewItem)P_0).PropertyUid;
	}

	internal static bool AaQYCTOlU6cAd47JUE1n(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static bool LyLT4LOlVWT9XyhB38Ji(object P_0)
	{
		return string.IsNullOrWhiteSpace((string)P_0);
	}

	internal static void HtEP78OlADHG9nwHKjAZ(object P_0, object P_1)
	{
		((FormBindingModel)P_0).PropertyParents = (Guid[])P_1;
	}

	internal static object sjExmXOlGZMwn13efphi(object P_0, bool P_1)
	{
		return ClassSerializationHelper.SerializeObjectByXml(P_0, P_1);
	}

	internal static object YXtp11Ol76NE6jJbHiEH(object P_0, object P_1)
	{
		return string.Join((string)P_0, (string[])P_1);
	}

	internal static object JQqv1pOl2t8NyrxJNcfl(object P_0)
	{
		return ((GridViewItem)P_0).Query;
	}

	internal static object GjIXkZOlonjZXZVDXotG(object P_0, object P_1, object P_2)
	{
		return ((string)P_0).Replace((string)P_1, (string)P_2);
	}

	internal static void xi0brSOlFOeLy5MuIyNT(object P_0, object P_1)
	{
		((GridViewItem)P_0).Query = (string)P_1;
	}
}
