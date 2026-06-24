using System;
using System.Activities;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Diagrams;
using EleWise.ELMA.Documents;
using EleWise.ELMA.Documents.Managers;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Connectors;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Events;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Plugins;
using EleWise.ELMA.Workflow.Diagrams.Activities;
using EleWise.ELMA.Workflow.ExtensionPoints;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.Activities.Plugins;

public class DocumentChangePermissionsActivity : BPMNActivity<DocumentChangePermissionsElement>
{
	[Component]
	private class Info : IWorkflowActivityInfo
	{
		internal static object kJalXyvHSjpqyjHVT6eA;

		public Type ActivityType => iA31amvHEdbYlxMwpmlX(typeof(DocumentChangePermissionsActivity).TypeHandle);

		public Type DiagramElementType => iA31amvHEdbYlxMwpmlX(typeof(DocumentChangePermissionsElement).TypeHandle);

		public Info()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			Xf4bmSvHwdSUXXhsPti0();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_719514a5a8ae47ed84e5a777ead0dc9f != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static Type iA31amvHEdbYlxMwpmlX(RuntimeTypeHandle P_0)
		{
			return Type.GetTypeFromHandle(P_0);
		}

		internal static void Xf4bmSvHwdSUXXhsPti0()
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		}

		internal static bool gLXEJFvH1IE01L5n4cEV()
		{
			return kJalXyvHSjpqyjHVT6eA == null;
		}

		internal static Info YRckjkvHhBhSqBe4L7bP()
		{
			return (Info)kJalXyvHSjpqyjHVT6eA;
		}
	}

	private static DocumentChangePermissionsActivity ovwUdVZBwlYNj0lCerqX;

	public ISessionProvider SessionProvider
	{
		[CompilerGenerated]
		get
		{
			return _003CSessionProvider_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					_003CSessionProvider_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a680afde07ce4ae5b71c411a1f75109b != 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	public IEnumerable<IDocumentChangePermissions> DocumentChangePermissions { get; set; }

	protected override void Execute(NativeActivityContext context)
	{
		//Discarded unreachable code: IL_00b7, IL_00c6, IL_00d1, IL_0114, IL_0147, IL_0185, IL_01f4, IL_0207, IL_0311, IL_03a7, IL_03b6, IL_0475, IL_0488
		int num = 1;
		int num2 = num;
		IWorkflowInstance instance = default(IWorkflowInstance);
		List<DocumentChangePermissionsInfo>.Enumerator enumerator2 = default(List<DocumentChangePermissionsInfo>.Enumerator);
		DocumentChangePermissionsInfo current2 = default(DocumentChangePermissionsInfo);
		List<Exception> list = default(List<Exception>);
		FlowConnectorElement flowConnectorElement = default(FlowConnectorElement);
		CompositeExceptionForProcesses compositeExceptionForProcesses = default(CompositeExceptionForProcesses);
		List<Exception>.Enumerator enumerator = default(List<Exception>.Enumerator);
		Exception current = default(Exception);
		while (true)
		{
			switch (num2)
			{
			case 9:
				return;
			case 13:
				return;
			case 12:
				jW94sSZc8Flmd3SFtUVf(instance);
				num2 = 19;
				continue;
			case 10:
				ContinueOnDefaultConnector(context);
				num2 = 13;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b84ccb8b1bd147ef900b852047ecbf45 != 0)
				{
					num2 = 2;
				}
				continue;
			case 14:
				try
				{
					while (true)
					{
						int num6;
						if (!enumerator2.MoveNext())
						{
							num6 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_abfb511163674a3eae959fd60da8f319 == 0)
							{
								num6 = 0;
							}
							goto IL_00d5;
						}
						goto IL_018f;
						IL_018f:
						current2 = enumerator2.Current;
						num6 = 2;
						goto IL_00d5;
						IL_00d5:
						switch (num6)
						{
						case 2:
							try
							{
								ChangePermission(instance, current2);
								int num7 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_61395ebf330446ac8ce99b55ee3acfa9 != 0)
								{
									num7 = 0;
								}
								switch (num7)
								{
								case 0:
									break;
								}
							}
							catch (Exception item)
							{
								int num8 = 1;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6dd19c81ff5e41fb8db9b50574437301 == 0)
								{
									num8 = 1;
								}
								while (true)
								{
									switch (num8)
									{
									case 1:
										list.Add(item);
										num8 = 0;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3f8a84e2cb374827a50ba2cbcf11cf48 != 0)
										{
											num8 = 0;
										}
										continue;
									case 0:
										break;
									}
									break;
								}
							}
							continue;
						case 1:
							goto IL_018f;
						case 3:
							continue;
						case 0:
							break;
						}
						break;
					}
				}
				finally
				{
					((IDisposable)enumerator2).Dispose();
					int num9 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f236c3d0fade492db73e8204df65377d == 0)
					{
						num9 = 0;
					}
					switch (num9)
					{
					case 0:
						break;
					}
				}
				goto case 16;
			case 18:
				return;
			case 11:
				jW94sSZc8Flmd3SFtUVf(instance);
				num2 = 10;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ffb1346d351f436b84bb1e9954c3bfa8 != 0)
				{
					num2 = 2;
				}
				continue;
			case 19:
				YANZgVZcsmWLrOvspUjk(this, context, flowConnectorElement);
				num2 = 9;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_558b46b4f4364838b08ac89d77f9a257 != 0)
				{
					num2 = 8;
				}
				continue;
			case 3:
				if (flowConnectorElement == null)
				{
					jW94sSZc8Flmd3SFtUVf(instance);
					num2 = 8;
					continue;
				}
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cfe4a54387d744988feba4889229faf1 == 0)
				{
					num2 = 1;
				}
				continue;
			case 2:
				tgdr3kZcYsZP3jL6JJwm(M3ArsIZcZFRCKgaCRPQu(instance), CMK0duZcvUdX8961UuLZ(flowConnectorElement), new ExceptionData(0, compositeExceptionForProcesses.Message, compositeExceptionForProcesses));
				num2 = 12;
				continue;
			case 16:
				if (IdB8MmZcKOGfEfJxV9Bl(list) <= 0)
				{
					num2 = 5;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_de3723e1fdff427496b973d91a934ee2 == 0)
					{
						num2 = 11;
					}
					continue;
				}
				break;
			case 1:
				list = new List<Exception>();
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d2d2252621ae43ad8d38af812176c290 == 0)
				{
					num2 = 0;
				}
				continue;
			case 8:
				ContinueOnDefaultConnector(context);
				num2 = 18;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a680afde07ce4ae5b71c411a1f75109b == 0)
				{
					num2 = 13;
				}
				continue;
			case 5:
				compositeExceptionForProcesses.Exceptions = list;
				num2 = 6;
				continue;
			case 15:
				compositeExceptionForProcesses = new CompositeExceptionForProcesses();
				num2 = 5;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5537a063960e465db83a04e35eea441b == 0)
				{
					num2 = 0;
				}
				continue;
			case 4:
				enumerator2 = base.Element.Actions.GetEnumerator();
				num2 = 14;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0991fd79553c4ecc82e8b5cb79c2bff2 != 0)
				{
					num2 = 0;
				}
				continue;
			case 6:
				enumerator = list.GetEnumerator();
				num2 = 7;
				continue;
			default:
				instance = GetInstance(context);
				num2 = 4;
				continue;
			case 7:
				try
				{
					while (true)
					{
						IL_03df:
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b84ccb8b1bd147ef900b852047ecbf45 != 0)
							{
								num3 = 0;
							}
							goto IL_03c5;
						}
						goto IL_0426;
						IL_0426:
						current = enumerator.Current;
						num3 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3bb28bf622874b4689f9265e58d14823 != 0)
						{
							num3 = 0;
						}
						goto IL_03c5;
						IL_03c5:
						while (true)
						{
							switch (num3)
							{
							case 2:
								goto IL_03df;
							case 1:
							{
								((ILogger)hQDbE1ZcOWRSxvjkPvL1()).Error(current.Message, current);
								int num4 = 2;
								num3 = num4;
								continue;
							}
							case 3:
								goto IL_0426;
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
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ecf910d183864897a7c8ec77e01689a4 == 0)
					{
						num5 = 0;
					}
					switch (num5)
					{
					case 0:
						break;
					}
				}
				goto case 3;
			case 17:
				break;
			}
			flowConnectorElement = base.Element.ExceptionOutputFlows.FirstOrDefault((FlowConnectorElement e) => e.Trigger == EventTrigger.ErrorCatch);
			num2 = 15;
		}
	}

	private void ChangePermission(IWorkflowInstance instance, DocumentChangePermissionsInfo action)
	{
		//Discarded unreachable code: IL_00b4, IL_00c3, IL_00ce, IL_0187, IL_01d4, IL_01e3, IL_028b, IL_029a, IL_035d, IL_0370, IL_037f, IL_03b0, IL_03e8, IL_03f7, IL_048c, IL_049b, IL_04bd
		int num = 6;
		int num2 = num;
		List<IEntity> allHolders = default(List<IEntity>);
		_003C_003Ec__DisplayClass10_0 _003C_003Ec__DisplayClass10_ = default(_003C_003Ec__DisplayClass10_0);
		IEnumerator<IDocument> enumerator = default(IEnumerator<IDocument>);
		IDocument current = default(IDocument);
		List<IEntity>.Enumerator enumerator2 = default(List<IEntity>.Enumerator);
		Guid typeRoleId = default(Guid);
		Permission permissionId = default(Permission);
		IEntity current2 = default(IEntity);
		EleWise.ELMA.Security.Models.IUser holder = default(EleWise.ELMA.Security.Models.IUser);
		string text = default(string);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 13:
				allHolders = GetAllHolders(_003C_003Ec__DisplayClass10_.action.Roles, instance);
				num2 = 11;
				break;
			case 4:
				_003C_003Ec__DisplayClass10_.documents = GetAllDocuments(_003C_003Ec__DisplayClass10_.documentPropertyValue as IEnumerable, _003C_003Ec__DisplayClass10_.action.ApplyToRelated);
				num2 = 9;
				break;
			case 10:
				try
				{
					while (true)
					{
						int num3;
						if (!elwjqmZcgKlyxjVK87xE(enumerator))
						{
							num3 = 1;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cfe4a54387d744988feba4889229faf1 == 0)
							{
								num3 = 0;
							}
							goto IL_00d2;
						}
						goto IL_013d;
						IL_013d:
						current = enumerator.Current;
						num3 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1c37d4e24e094858975336738e156495 != 0)
						{
							num3 = 0;
						}
						goto IL_00d2;
						IL_00d2:
						while (true)
						{
							switch (num3)
							{
							default:
								enumerator2 = allHolders.GetEnumerator();
								num3 = 5;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_46e05b4e09174e34a9c81741b8b77a2f != 0)
								{
									num3 = 2;
								}
								continue;
							case 3:
								break;
							case 2:
								goto IL_013d;
							case 4:
								current.Save();
								num3 = 1;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_46e05b4e09174e34a9c81741b8b77a2f == 0)
								{
									num3 = 3;
								}
								continue;
							case 5:
								try
								{
									while (true)
									{
										int num4;
										if (!enumerator2.MoveNext())
										{
											num4 = 7;
											goto IL_0195;
										}
										goto IL_024e;
										IL_0195:
										while (true)
										{
											switch (num4)
											{
											case 8:
												typeRoleId = QjSRHxZcb9g9Ts2DEq0u(CommonRoleTypes.Author);
												num4 = 0;
												if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d843b0b7f23e489fb6d586d64b0a634a != 0)
												{
													num4 = 0;
												}
												continue;
											case 4:
											case 6:
												break;
											case 10:
												ChangePermissions(j3f1LQZc5lFijsoS0uat(_003C_003Ec__DisplayClass10_.action), current, permissionId, current2, typeRoleId);
												num4 = 4;
												continue;
											case 11:
												goto IL_024e;
											case 9:
												if (current2 != null)
												{
													int num5 = 5;
													num4 = num5;
													continue;
												}
												goto case 3;
											case 2:
											case 5:
												typeRoleId = GetTypeRoleId(current2);
												num4 = 10;
												if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bf623f11574746d6bf3837b66460c576 == 0)
												{
													num4 = 6;
												}
												continue;
											case 1:
												typeRoleId = Guid.Empty;
												num4 = 3;
												if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_764abb15e52f4036a7a81fce6cb70f30 == 0)
												{
													num4 = 9;
												}
												continue;
											case 3:
												holder = (EleWise.ELMA.Security.Models.IUser)UtOvpEZctJp751OKCX8S(current);
												num4 = 7;
												if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_978f838cc41a4debb9700ede4b63f820 != 0)
												{
													num4 = 8;
												}
												continue;
											default:
												ChangePermissions(j3f1LQZc5lFijsoS0uat(_003C_003Ec__DisplayClass10_.action), current, permissionId, holder, typeRoleId);
												num4 = 6;
												continue;
											case 7:
												goto end_IL_0214;
											}
											break;
										}
										continue;
										IL_024e:
										current2 = enumerator2.Current;
										num4 = 0;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d7a51cf2841b436998bf3f4157fb2c9a == 0)
										{
											num4 = 1;
										}
										goto IL_0195;
										continue;
										end_IL_0214:
										break;
									}
								}
								finally
								{
									((IDisposable)enumerator2).Dispose();
									int num6 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_639c11c7bb65456db9f29c9c42f28bf7 == 0)
									{
										num6 = 0;
									}
									switch (num6)
									{
									case 0:
										break;
									}
								}
								goto case 4;
							case 1:
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
						int num7 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5816b3723c134946ad9294172266312e != 0)
						{
							num7 = 1;
						}
						while (true)
						{
							switch (num7)
							{
							case 1:
								DEXhnoZcBhSPdJggfbRm(enumerator);
								num7 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f91acf223c4b4303819d2f8f2fc6c8e1 == 0)
								{
									num7 = 0;
								}
								continue;
							case 0:
								break;
							}
							break;
						}
					}
				}
			case 14:
				if (_003C_003Ec__DisplayClass10_.documentPropertyValue is IDocument)
				{
					num2 = 7;
					break;
				}
				goto case 2;
			case 15:
				if ((_003C_003Ec__DisplayClass10_.documentPropertyValue as IEnumerable<IDocument>).Any())
				{
					num2 = 4;
					break;
				}
				goto case 12;
			case 11:
				_003C_003Ec__DisplayClass10_.documentPropertyValue = u7ETrHZcJktkOIRhV4QA(M3ArsIZcZFRCKgaCRPQu(instance), _003C_003Ec__DisplayClass10_.action.Documents);
				num2 = 8;
				break;
			case 7:
				DocumentChangePermissions.ForEach(_003C_003Ec__DisplayClass10_._003CChangePermission_003Eb__0);
				num2 = 16;
				break;
			case 5:
				_003C_003Ec__DisplayClass10_.action = action;
				num2 = 13;
				break;
			case 8:
				text = (string)gjSL7UZc0X6HSGBFrleq(GetProperty(instance, UWq2jdZclIjrhcRWtovW(_003C_003Ec__DisplayClass10_.action)));
				num2 = 3;
				break;
			case 0:
				return;
			case 6:
				_003C_003Ec__DisplayClass10_ = new _003C_003Ec__DisplayClass10_0();
				num2 = 5;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c447ffb64be44c09b6fd398df506785b != 0)
				{
					num2 = 4;
				}
				break;
			case 3:
				_003C_003Ec__DisplayClass10_.documents = new List<IDocument>();
				num2 = 7;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cfe4a54387d744988feba4889229faf1 != 0)
				{
					num2 = 14;
				}
				break;
			case 12:
				throw new Exception((string)WrWyxPZcyFJcS6dRiv5b(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x13F63440 ^ 0x13F49A8A), new object[1] { text }));
			case 9:
			case 16:
				permissionId = GetPermissionId(i3d4WAZcmI0XGnsqpHYh(_003C_003Ec__DisplayClass10_.action));
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b30151cb26574dfaa8f9d818b0352d3b == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				if (_003C_003Ec__DisplayClass10_.documentPropertyValue is IEnumerable)
				{
					num2 = 15;
					break;
				}
				goto case 12;
			case 1:
				enumerator = (from x in _003C_003Ec__DisplayClass10_.documents
					group x by x.Id into x
					select x.First()).GetEnumerator();
				num2 = 10;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6f64eb224ece438ba2f0bbd2f29cebfd == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	private List<IEntity> GetAllHolders(List<DocumentChangePermissionsInfoRole> holderList, IWorkflowInstance instance)
	{
		List<IEntity> list = new List<IEntity>();
		foreach (DocumentChangePermissionsInfoRole holder in holderList)
		{
			if (holder.Role == DocumentChangePermissionsInfo.RoleType.Structure)
			{
				IOrganizationItem organizationItem = EntityManager<IOrganizationItem>.Instance.LoadOrNull(holder.ObjectGuid);
				if (organizationItem != null)
				{
					list.Add(organizationItem);
				}
			}
			if (holder.Role == DocumentChangePermissionsInfo.RoleType.Group)
			{
				IUserGroup userGroup = EntityManager<IUserGroup>.Instance.LoadOrNull(holder.ObjectGuid);
				if (userGroup != null)
				{
					list.Add(userGroup);
				}
			}
			if (holder.Role == DocumentChangePermissionsInfo.RoleType.ContextVarUser || holder.Role == DocumentChangePermissionsInfo.RoleType.ContextVarStructure || holder.Role == DocumentChangePermissionsInfo.RoleType.ContextVarGroup)
			{
				list.AddRange(GetListFromContextVar(holder.ObjectGuid, instance));
			}
			if (holder.Role == DocumentChangePermissionsInfo.RoleType.Author)
			{
				list.Add(null);
			}
		}
		return list;
	}

	private IEnumerable<IEntity> GetListFromContextVar(Guid roleGuid, IWorkflowInstance instance)
	{
		List<IEntity> list = new List<IEntity>();
		if (roleGuid == Guid.Empty)
		{
			Logger.Log.Error(SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4940763B ^ 0x4942CC65)));
			return list;
		}
		PropertyMetadata property = GetProperty(instance, roleGuid);
		if (property == null)
		{
			Logger.Log.Error(SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2122743969 ^ -2122594819), roleGuid, instance.Context.GetType().FullName));
			return list;
		}
		PropertyInfo reflectionProperty = instance.Context.GetType().GetReflectionProperty(property.Name);
		if (reflectionProperty == null)
		{
			Logger.Log.Error(SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x46EA3D1 ^ 0x46C18C5), property.Name, instance.Context.GetType().FullName));
			return list;
		}
		object value = reflectionProperty.GetValue(instance.Context, null);
		if (value is IEntity item)
		{
			list.Add(item);
			return list;
		}
		if (value is IEnumerable source)
		{
			list = source.OfType<IEntity>().ToList();
		}
		if (!list.Any())
		{
			Logger.Log.Error(SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x595C500A ^ 0x595EFEC0), property.DisplayName));
		}
		return list;
	}

	private Guid GetTypeRoleId(IEntity holder)
	{
		//Discarded unreachable code: IL_0056, IL_0065
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (holder is EleWise.ELMA.Security.Models.IUser)
				{
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e4c570270f54493d8f3f4763a72f63f7 == 0)
					{
						num2 = 1;
					}
					break;
				}
				if (!(holder is IUserGroup))
				{
					num2 = 3;
					break;
				}
				goto default;
			default:
				return QjSRHxZcb9g9Ts2DEq0u(CommonRoleTypes.Group);
			case 3:
				return QjSRHxZcb9g9Ts2DEq0u(CommonRoleTypes.OrganizationItem);
			case 1:
				return QjSRHxZcb9g9Ts2DEq0u(CommonRoleTypes.User);
			}
		}
	}

	private List<IDocument> GetAllDocuments(IEnumerable documents, bool applyToRelated)
	{
		List<IDocument> list = new List<IDocument>();
		foreach (IDocument document in documents)
		{
			list.Add(document);
			if (!applyToRelated)
			{
				continue;
			}
			foreach (IDocumentLink alLink in DocumentLinkManager.Instance.GetAlLinks(document.Id))
			{
				list.Add(alLink.LinkedDocument);
			}
		}
		return list;
	}

	private List<IDocument> GetAllDocuments(IDocument document, bool applyToRelated)
	{
		List<IDocument> list = new List<IDocument>();
		list.Add(document);
		if (applyToRelated)
		{
			foreach (IDocumentLink alLink in DocumentLinkManager.Instance.GetAlLinks(document.Id))
			{
				list.Add(alLink.LinkedDocument);
			}
			return list;
		}
		return list;
	}

	private Permission GetPermissionId(DocumentChangePermissionsInfo.PermissionType permissions)
	{
		//Discarded unreachable code: IL_004b, IL_005a
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return EleWise.ELMA.Documents.PermissionProvider.DocumentViewPermission;
			default:
				return EleWise.ELMA.Documents.PermissionProvider.DocumentFullAccessPermission;
			case 1:
				{
					switch (permissions)
					{
					case DocumentChangePermissionsInfo.PermissionType.Load:
						break;
					case DocumentChangePermissionsInfo.PermissionType.Download:
						return EleWise.ELMA.Documents.PermissionProvider.DocumentLoadPermission;
					case DocumentChangePermissionsInfo.PermissionType.Edit:
						return EleWise.ELMA.Documents.PermissionProvider.DocumentEditPermission;
					case DocumentChangePermissionsInfo.PermissionType.Issue:
						return EleWise.ELMA.Documents.PermissionProvider.DocumentManagerAccessPermission;
					default:
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d843b0b7f23e489fb6d586d64b0a634a == 0)
						{
							num2 = 0;
						}
						goto end_IL_0012;
					}
					goto case 2;
				}
				end_IL_0012:
				break;
			}
		}
	}

	private IDmsObjectPermission GetDmsObjectPermission(IDocument document, Guid permissionId, IEntity holder, Guid typeRoleId)
	{
		InstanceOf<IDmsObjectPermission> instanceOf = new InstanceOf<IDmsObjectPermission>();
		jRnLAtZccGvN7ymZDJye(instanceOf.New, document);
		omhQReZcPmAdHbX39S7W(instanceOf.New, permissionId);
		instanceOf.New.TypeRoleId = typeRoleId;
		HSUIbAZcXnlaNSbP4E1s(instanceOf.New, holder);
		return instanceOf.New;
	}

	private void ChangePermissions(DocumentChangePermissionsInfo.ActionType actionType, IDocument document, Permission permission, IEntity holder, Guid typeRoleId)
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				if (actionType == DocumentChangePermissionsInfo.ActionType.Add)
				{
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e8980a9fd9d44c20920ffa276900c96f == 0)
					{
						num2 = 0;
					}
					break;
				}
				RemovePermissions(document, permission, holder, typeRoleId);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d87d9a74c9e14f96a288cc3620965fe0 == 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				return;
			case 0:
				return;
			case 1:
				AddPermissions(document, permission, holder, typeRoleId);
				num2 = 3;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1b8b735647da470aa2d45d64d6f538d1 != 0)
				{
					num2 = 3;
				}
				break;
			}
		}
	}

	private void AddPermissions(IDocument document, Permission permission, IEntity holder, Guid typeRoleId)
	{
		//Discarded unreachable code: IL_0097, IL_00a6, IL_00b6, IL_01a4, IL_01cd, IL_01dc
		int num = 18;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 22:
					AddPermission(document, EleWise.ELMA.Documents.PermissionProvider.DocumentLoadPermission, holder, typeRoleId, equalUser: true);
					num2 = 6;
					continue;
				case 19:
					AddPermission(document, EleWise.ELMA.Documents.PermissionProvider.DocumentViewPermission, holder, typeRoleId, equalUser: true);
					num2 = 7;
					continue;
				case 3:
					AddPermission(document, EleWise.ELMA.Documents.PermissionProvider.DocumentViewPermission, holder, typeRoleId, equalUser: true);
					num2 = 12;
					continue;
				case 12:
					AddPermission(document, EleWise.ELMA.Documents.PermissionProvider.DocumentLoadPermission, holder, typeRoleId, equalUser: true);
					num2 = 2;
					continue;
				case 8:
					AddPermission(document, EleWise.ELMA.Documents.PermissionProvider.DocumentManagerAccessPermission, holder, typeRoleId, equalUser: true);
					num2 = 11;
					continue;
				case 6:
					return;
				case 1:
				case 14:
					if (!ltYno7ZcuDjI5K8ZApmU(fvCPB6ZcdHRhaKho47lH(permission), fvCPB6ZcdHRhaKho47lH(EleWise.ELMA.Documents.PermissionProvider.DocumentManagerAccessPermission)))
					{
						num2 = 5;
						continue;
					}
					goto case 3;
				case 21:
					AddPermission(document, EleWise.ELMA.Documents.PermissionProvider.DocumentViewPermission, holder, typeRoleId, equalUser: true);
					num2 = 15;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f30401a2cff84771be092252e934fede == 0)
					{
						num2 = 7;
					}
					continue;
				case 4:
				case 16:
					if (!ltYno7ZcuDjI5K8ZApmU(permission.Id, fvCPB6ZcdHRhaKho47lH(EleWise.ELMA.Documents.PermissionProvider.DocumentLoadPermission)))
					{
						return;
					}
					num = 22;
					break;
				default:
					AddPermission(document, EleWise.ELMA.Documents.PermissionProvider.DocumentViewPermission, holder, typeRoleId, equalUser: true);
					num2 = 4;
					continue;
				case 15:
					AddPermission(document, EleWise.ELMA.Documents.PermissionProvider.DocumentLoadPermission, holder, typeRoleId, equalUser: true);
					num = 10;
					break;
				case 10:
					AddPermission(document, EleWise.ELMA.Documents.PermissionProvider.DocumentEditPermission, holder, typeRoleId, equalUser: true);
					num2 = 8;
					continue;
				case 2:
					AddPermission(document, EleWise.ELMA.Documents.PermissionProvider.DocumentManagerAccessPermission, holder, typeRoleId, equalUser: true);
					num2 = 3;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6dd19c81ff5e41fb8db9b50574437301 == 0)
					{
						num2 = 13;
					}
					continue;
				case 18:
					if (!ltYno7ZcuDjI5K8ZApmU(fvCPB6ZcdHRhaKho47lH(permission), fvCPB6ZcdHRhaKho47lH(EleWise.ELMA.Documents.PermissionProvider.DocumentFullAccessPermission)))
					{
						num2 = 17;
						continue;
					}
					goto case 20;
				case 9:
					AddPermission(document, EleWise.ELMA.Documents.PermissionProvider.DocumentEditPermission, holder, typeRoleId, equalUser: true);
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1de08766357542bdb81146373079f817 == 0)
					{
						num2 = 0;
					}
					continue;
				case 20:
					AddPermission(document, permission, holder, typeRoleId);
					num2 = 21;
					continue;
				case 11:
				case 17:
					if (!ltYno7ZcuDjI5K8ZApmU(fvCPB6ZcdHRhaKho47lH(permission), EleWise.ELMA.Documents.PermissionProvider.DocumentEditPermission.Id))
					{
						num2 = 14;
						continue;
					}
					goto case 19;
				case 5:
				case 13:
					if (!ltYno7ZcuDjI5K8ZApmU(fvCPB6ZcdHRhaKho47lH(permission), fvCPB6ZcdHRhaKho47lH(EleWise.ELMA.Documents.PermissionProvider.DocumentViewPermission)))
					{
						num2 = 16;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0fbdcdb2cea84e8d8852886ebe735d8f == 0)
						{
							num2 = 6;
						}
						continue;
					}
					goto default;
				case 7:
					AddPermission(document, EleWise.ELMA.Documents.PermissionProvider.DocumentLoadPermission, holder, typeRoleId, equalUser: true);
					num = 9;
					break;
				}
				break;
			}
		}
	}

	private void AddPermission(IDocument document, Permission permission, IEntity holder, Guid typeRoleId, bool equalUser = false)
	{
		//Discarded unreachable code: IL_007d, IL_008d, IL_00d4, IL_01c9, IL_01d8, IL_01e8, IL_01f7, IL_0256
		int num = 19;
		int num2 = num;
		_003C_003Ec__DisplayClass20_0 _003C_003Ec__DisplayClass20_ = default(_003C_003Ec__DisplayClass20_0);
		while (true)
		{
			switch (num2)
			{
			case 13:
				return;
			case 16:
				return;
			case 9:
				_003C_003Ec__DisplayClass20_.service = Locator.GetServiceNotNull<ISecurityService>();
				num2 = 7;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_160bffb148c14c5da92d8d6ddf481bdc != 0)
				{
					num2 = 7;
				}
				break;
			case 7:
				_003C_003Ec__DisplayClass20_.hasPermission = true;
				num2 = 6;
				break;
			case 19:
				_003C_003Ec__DisplayClass20_ = new _003C_003Ec__DisplayClass20_0();
				num2 = 18;
				break;
			case 12:
				Ss8plHZcnAC4o0p3NXZA(_003C_003Ec__DisplayClass20_.service, new Action(_003C_003Ec__DisplayClass20_._003CAddPermission_003Eb__0));
				num2 = 3;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f2d402219199402696ade21eab23d086 == 0)
				{
					num2 = 3;
				}
				break;
			case 6:
				if (!(_003C_003Ec__DisplayClass20_.holder is EleWise.ELMA.Security.Models.IUser))
				{
					num2 = 22;
					break;
				}
				goto case 14;
			case 17:
				_003C_003Ec__DisplayClass20_.document.Permissions.Add(GetDmsObjectPermission(_003C_003Ec__DisplayClass20_.document, fvCPB6ZcdHRhaKho47lH(_003C_003Ec__DisplayClass20_.permission), _003C_003Ec__DisplayClass20_.holder, _003C_003Ec__DisplayClass20_.typeRoleId));
				num2 = 16;
				break;
			case 18:
				_003C_003Ec__DisplayClass20_.holder = holder;
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_9269d021c6f148b6a1c4afb8cee03b6c != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				_003C_003Ec__DisplayClass20_.permission = permission;
				num2 = 21;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_805f3361d2ba4dac8da4174f89314253 != 0)
				{
					num2 = 6;
				}
				break;
			case 2:
			case 11:
			case 22:
				if (((IEnumerable<IDmsObjectPermission>)_003C_003Ec__DisplayClass20_.document.Permissions).FirstOrDefault(_003C_003Ec__DisplayClass20_._003CAddPermission_003Eb__1) == null)
				{
					num2 = 5;
					break;
				}
				goto case 4;
			case 21:
				_003C_003Ec__DisplayClass20_.document = document;
				num2 = 20;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b876fa7b083748c8abf8c4b192a11078 == 0)
				{
					num2 = 15;
				}
				break;
			case 14:
				if (!equalUser)
				{
					num2 = 10;
					break;
				}
				goto case 2;
			case 5:
			case 15:
				_003C_003Ec__DisplayClass20_.hasPermission = false;
				num2 = 8;
				break;
			default:
				if (_003C_003Ec__DisplayClass20_.hasPermission)
				{
					num2 = 13;
					break;
				}
				goto case 17;
			case 4:
				_003C_003Ec__DisplayClass20_.hasPermission = true;
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_26fa47f5bd8343debcae8b05a56a3ab5 != 0)
				{
					num2 = 0;
				}
				break;
			case 10:
				if (!V8kbc4ZcDsCC0PXJkQfE(_003C_003Ec__DisplayClass20_.typeRoleId, QjSRHxZcb9g9Ts2DEq0u(CommonRoleTypes.Author)))
				{
					num2 = 11;
					break;
				}
				goto case 12;
			case 20:
				_003C_003Ec__DisplayClass20_.typeRoleId = typeRoleId;
				num2 = 9;
				break;
			}
		}
	}

	private void RemovePermissions(IDocument document, Permission permission, IEntity holder, Guid typeRoleId)
	{
		//Discarded unreachable code: IL_00cd, IL_0152
		int num = 4;
		List<Guid> permissionsId5 = default(List<Guid>);
		List<Guid> permissionsId3 = default(List<Guid>);
		List<Guid> permissionsId4 = default(List<Guid>);
		List<Guid> permissionsId = default(List<Guid>);
		List<Guid> permissionsId2 = default(List<Guid>);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					RemovePermission(document, permissionsId5, holder, typeRoleId);
					num = 8;
					break;
				case 8:
				case 13:
					if (ltYno7ZcuDjI5K8ZApmU(fvCPB6ZcdHRhaKho47lH(permission), fvCPB6ZcdHRhaKho47lH(EleWise.ELMA.Documents.PermissionProvider.DocumentFullAccessPermission)))
					{
						num2 = 15;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b84ccb8b1bd147ef900b852047ecbf45 == 0)
						{
							num2 = 16;
						}
						continue;
					}
					return;
				case 15:
					RemovePermission(document, permissionsId3, holder, typeRoleId);
					num2 = 12;
					continue;
				case 4:
					if (ltYno7ZcuDjI5K8ZApmU(fvCPB6ZcdHRhaKho47lH(permission), fvCPB6ZcdHRhaKho47lH(EleWise.ELMA.Documents.PermissionProvider.DocumentViewPermission)))
					{
						num2 = 3;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_fb347e2c5dba4e0ca4d47098be7fd10c == 0)
						{
							num2 = 2;
						}
						continue;
					}
					goto case 1;
				case 17:
					return;
				case 14:
					permissionsId5 = new List<Guid>
					{
						fvCPB6ZcdHRhaKho47lH(EleWise.ELMA.Documents.PermissionProvider.DocumentManagerAccessPermission),
						fvCPB6ZcdHRhaKho47lH(EleWise.ELMA.Documents.PermissionProvider.DocumentFullAccessPermission)
					};
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_75a2d0f780b04098ba855df5729e6c30 == 0)
					{
						num2 = 0;
					}
					continue;
				case 11:
					RemovePermission(document, permissionsId4, holder, typeRoleId);
					num2 = 17;
					continue;
				case 7:
				case 9:
					if (!(fvCPB6ZcdHRhaKho47lH(permission) == EleWise.ELMA.Documents.PermissionProvider.DocumentManagerAccessPermission.Id))
					{
						num = 13;
						break;
					}
					goto case 14;
				case 10:
					permissionsId = new List<Guid>
					{
						fvCPB6ZcdHRhaKho47lH(EleWise.ELMA.Documents.PermissionProvider.DocumentEditPermission),
						EleWise.ELMA.Documents.PermissionProvider.DocumentFullAccessPermission.Id
					};
					num2 = 6;
					continue;
				case 5:
					RemovePermission(document, permissionsId2, holder, typeRoleId);
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6f64eb224ece438ba2f0bbd2f29cebfd == 0)
					{
						num2 = 1;
					}
					continue;
				case 16:
					permissionsId4 = new List<Guid> { fvCPB6ZcdHRhaKho47lH(EleWise.ELMA.Documents.PermissionProvider.DocumentFullAccessPermission) };
					num2 = 9;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_558b46b4f4364838b08ac89d77f9a257 == 0)
					{
						num2 = 11;
					}
					continue;
				case 12:
					if (!ltYno7ZcuDjI5K8ZApmU(permission.Id, fvCPB6ZcdHRhaKho47lH(EleWise.ELMA.Documents.PermissionProvider.DocumentEditPermission)))
					{
						num2 = 9;
						continue;
					}
					goto case 10;
				case 2:
					permissionsId3 = new List<Guid>
					{
						fvCPB6ZcdHRhaKho47lH(EleWise.ELMA.Documents.PermissionProvider.DocumentFullAccessPermission),
						fvCPB6ZcdHRhaKho47lH(EleWise.ELMA.Documents.PermissionProvider.DocumentManagerAccessPermission),
						fvCPB6ZcdHRhaKho47lH(EleWise.ELMA.Documents.PermissionProvider.DocumentEditPermission),
						fvCPB6ZcdHRhaKho47lH(EleWise.ELMA.Documents.PermissionProvider.DocumentLoadPermission)
					};
					num2 = 15;
					continue;
				case 3:
					permissionsId2 = new List<Guid>
					{
						fvCPB6ZcdHRhaKho47lH(EleWise.ELMA.Documents.PermissionProvider.DocumentFullAccessPermission),
						fvCPB6ZcdHRhaKho47lH(EleWise.ELMA.Documents.PermissionProvider.DocumentManagerAccessPermission),
						fvCPB6ZcdHRhaKho47lH(EleWise.ELMA.Documents.PermissionProvider.DocumentEditPermission),
						EleWise.ELMA.Documents.PermissionProvider.DocumentLoadPermission.Id,
						fvCPB6ZcdHRhaKho47lH(EleWise.ELMA.Documents.PermissionProvider.DocumentViewPermission)
					};
					num2 = 5;
					continue;
				case 1:
					if (ltYno7ZcuDjI5K8ZApmU(fvCPB6ZcdHRhaKho47lH(permission), fvCPB6ZcdHRhaKho47lH(EleWise.ELMA.Documents.PermissionProvider.DocumentLoadPermission)))
					{
						num2 = 2;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_46e05b4e09174e34a9c81741b8b77a2f != 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 12;
				case 6:
					RemovePermission(document, permissionsId, holder, typeRoleId);
					num2 = 7;
					continue;
				}
				break;
			}
		}
	}

	private void RemovePermission(IDocument document, List<Guid> permissionsId, IEntity holder, Guid typeRoleId)
	{
		_003C_003Ec__DisplayClass22_0 _003C_003Ec__DisplayClass22_ = new _003C_003Ec__DisplayClass22_0();
		_003C_003Ec__DisplayClass22_.document = document;
		_003C_003Ec__DisplayClass22_.typeRoleId = typeRoleId;
		_003C_003Ec__DisplayClass22_.holder = holder;
		ISession session = SessionProvider.GetSession("");
		using (List<Guid>.Enumerator enumerator = permissionsId.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				_003C_003Ec__DisplayClass22_1 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass22_1();
				CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1 = _003C_003Ec__DisplayClass22_;
				CS_0024_003C_003E8__locals0.permissionId = enumerator.Current;
				foreach (IDmsObjectPermission item in ((IEnumerable<IDmsObjectPermission>)CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.document.Permissions).Where(delegate(IDmsObjectPermission d)
				{
					//Discarded unreachable code: IL_0045, IL_0054, IL_0112, IL_0121, IL_0130
					int num = 7;
					while (true)
					{
						int num2 = num;
						while (true)
						{
							switch (num2)
							{
							case 1:
								return _003C_003Ec__DisplayClass22_1.MV5CRRvLfsrMOAgekO8n(d) == CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.holder;
							case 2:
							case 3:
							case 6:
								return false;
							default:
								if (((IEntity<long>)_003C_003Ec__DisplayClass22_1.gkAMrTvLnbKvlb47XFMH(d)).Id == CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.document.Id)
								{
									num2 = 5;
									break;
								}
								goto case 2;
							case 4:
								if (_003C_003Ec__DisplayClass22_1.ypJ9g1vLDUOwaCFTY66h(d) == CS_0024_003C_003E8__locals0.permissionId)
								{
									num2 = 8;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0991fd79553c4ecc82e8b5cb79c2bff2 != 0)
									{
										num2 = 6;
									}
									break;
								}
								goto case 2;
							case 5:
								if (!_003C_003Ec__DisplayClass22_1.u7ybBovLL9KmXv9QSQbZ(_003C_003Ec__DisplayClass22_1.IhwtH8vLHoxjkxGyHtQc(d), CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.typeRoleId))
								{
									goto end_IL_0012;
								}
								goto case 1;
							case 7:
								if (_003C_003Ec__DisplayClass22_1.uDSoSJvLumfumtourBbe(d) != null)
								{
									num2 = 6;
									break;
								}
								goto case 4;
							case 8:
								if (_003C_003Ec__DisplayClass22_1.gkAMrTvLnbKvlb47XFMH(d) == null)
								{
									num2 = 3;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3bb28bf622874b4689f9265e58d14823 != 0)
									{
										num2 = 2;
									}
									break;
								}
								goto default;
							}
							continue;
							end_IL_0012:
							break;
						}
						num = 2;
					}
				}).ToList())
				{
					((ICollection<IDmsObjectPermission>)CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.document.Permissions).Remove(item);
				}
			}
		}
		_003C_003Ec__DisplayClass22_.document.Save();
		session.Flush();
	}

	public DocumentChangePermissionsActivity()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3ab79470996d472f815915b21f45aac1 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool Td8RN0ZB4FbCshkjnqiD()
	{
		return ovwUdVZBwlYNj0lCerqX == null;
	}

	internal static DocumentChangePermissionsActivity VYc4FnZBzdu68y8StQda()
	{
		return ovwUdVZBwlYNj0lCerqX;
	}

	internal static int IdB8MmZcKOGfEfJxV9Bl(object P_0)
	{
		return ((List<Exception>)P_0).Count;
	}

	internal static object hQDbE1ZcOWRSxvjkPvL1()
	{
		return Logger.Log;
	}

	internal static object M3ArsIZcZFRCKgaCRPQu(object P_0)
	{
		return ((IWorkflowInstance)P_0).Context;
	}

	internal static Guid CMK0duZcvUdX8961UuLZ(object P_0)
	{
		return ((FlowConnectorElement)P_0).ContextExceptionVar;
	}

	internal static void tgdr3kZcYsZP3jL6JJwm(object P_0, Guid P_1, object P_2)
	{
		((Entity<long>)P_0).SetPropertyValue(P_1, P_2);
	}

	internal static void jW94sSZc8Flmd3SFtUVf(object P_0)
	{
		((IEntity)P_0).Save();
	}

	internal static void YANZgVZcsmWLrOvspUjk(object P_0, object P_1, object P_2)
	{
		((WorkflowActivity)P_0).ContinueOnConnector((NativeActivityContext)P_1, (Connector)P_2);
	}

	internal static object u7ETrHZcJktkOIRhV4QA(object P_0, Guid P_1)
	{
		return ((Entity<long>)P_0).GetPropertyValue(P_1);
	}

	internal static Guid UWq2jdZclIjrhcRWtovW(object P_0)
	{
		return ((DocumentChangePermissionsInfo)P_0).Documents;
	}

	internal static object gjSL7UZc0X6HSGBFrleq(object P_0)
	{
		return ((NamedMetadata)P_0).DisplayName;
	}

	internal static object WrWyxPZcyFJcS6dRiv5b(object P_0, object P_1)
	{
		return SR.T((string)P_0, (object[])P_1);
	}

	internal static DocumentChangePermissionsInfo.PermissionType i3d4WAZcmI0XGnsqpHYh(object P_0)
	{
		return ((DocumentChangePermissionsInfo)P_0).Permissions;
	}

	internal static object UtOvpEZctJp751OKCX8S(object P_0)
	{
		return ((IDmsObject)P_0).CreationAuthor;
	}

	internal static Guid QjSRHxZcb9g9Ts2DEq0u(object P_0)
	{
		return ((PermissionRoleType)P_0).Id;
	}

	internal static DocumentChangePermissionsInfo.ActionType j3f1LQZc5lFijsoS0uat(object P_0)
	{
		return ((DocumentChangePermissionsInfo)P_0).Action;
	}

	internal static bool elwjqmZcgKlyxjVK87xE(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void DEXhnoZcBhSPdJggfbRm(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static void jRnLAtZccGvN7ymZDJye(object P_0, object P_1)
	{
		((IDmsObjectPermission)P_0).DmsObject = (IDmsObject)P_1;
	}

	internal static void omhQReZcPmAdHbX39S7W(object P_0, Guid P_1)
	{
		((IDmsObjectPermission)P_0).PermissionId = P_1;
	}

	internal static void HSUIbAZcXnlaNSbP4E1s(object P_0, object P_1)
	{
		((IInstanceSettingsPermissionHolder)P_0).Assigned = (IEntity)P_1;
	}

	internal static Guid fvCPB6ZcdHRhaKho47lH(object P_0)
	{
		return ((Permission)P_0).Id;
	}

	internal static bool ltYno7ZcuDjI5K8ZApmU(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}

	internal static bool V8kbc4ZcDsCC0PXJkQfE(Guid P_0, Guid P_1)
	{
		return P_0 != P_1;
	}

	internal static void Ss8plHZcnAC4o0p3NXZA(object P_0, object P_1)
	{
		((ISecurityService)P_0).RunWithUsualPrivilegies((Action)P_1);
	}
}
