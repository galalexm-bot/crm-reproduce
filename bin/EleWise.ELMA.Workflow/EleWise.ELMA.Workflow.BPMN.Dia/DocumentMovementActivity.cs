using System;
using System.Activities;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Diagrams;
using EleWise.ELMA.Documents.Audit;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Connectors;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Events;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Plugins;
using EleWise.ELMA.Workflow.Diagrams.Activities;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.Activities.Plugins;

public class DocumentMovementActivity : BPMNActivity<DocumentMovementElement>
{
	[Component]
	private class Info : IWorkflowActivityInfo
	{
		private static object mA0Z3LvHoB3MCPt6gBwg;

		public Type ActivityType => typeof(DocumentMovementActivity);

		public Type DiagramElementType => typeof(DocumentMovementElement);

		public Info()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			LtJtagvHI3mRJQUSOTgj();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c7fe5d092d804f7e91041fb2338cec1a == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static void LtJtagvHI3mRJQUSOTgj()
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		}

		internal static bool mpeF6VvHF54ggx0QuWeR()
		{
			return mA0Z3LvHoB3MCPt6gBwg == null;
		}

		internal static Info GJl3Z9vHi1OVVXWb62AA()
		{
			return (Info)mA0Z3LvHoB3MCPt6gBwg;
		}
	}

	internal static DocumentMovementActivity nKWtmTZBRUFsu3qDwGBG;

	public IEntityActionHandler EntityActionHandler
	{
		[CompilerGenerated]
		get
		{
			return _003CEntityActionHandler_003Ek__BackingField;
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
				case 0:
					return;
				case 1:
					_003CEntityActionHandler_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7ed81ca3cf804abbade4684f28f485d1 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	protected override void Execute(NativeActivityContext context)
	{
		//Discarded unreachable code: IL_00a5, IL_00b4, IL_00bf, IL_017f, IL_0192, IL_01eb, IL_01f5, IL_0271, IL_02a4, IL_02e2, IL_02f1, IL_0328, IL_033b
		int num = 4;
		int num2 = num;
		List<Exception>.Enumerator enumerator2 = default(List<Exception>.Enumerator);
		List<Exception> list = default(List<Exception>);
		FlowConnectorElement flowConnectorElement = default(FlowConnectorElement);
		IWorkflowInstance workflowInstance = default(IWorkflowInstance);
		Exception current2 = default(Exception);
		List<DocumentMovementInfo>.Enumerator enumerator = default(List<DocumentMovementInfo>.Enumerator);
		DocumentMovementInfo current = default(DocumentMovementInfo);
		CompositeExceptionForProcesses compositeExceptionForProcesses = default(CompositeExceptionForProcesses);
		while (true)
		{
			switch (num2)
			{
			case 8:
				return;
			case 5:
				return;
			case 1:
				enumerator2 = list.GetEnumerator();
				num2 = 14;
				break;
			case 6:
				if (flowConnectorElement == null)
				{
					eRsp8cZBMLrHdqkPmmB7(workflowInstance);
					num2 = 9;
				}
				else
				{
					num2 = 13;
				}
				break;
			case 14:
				try
				{
					while (true)
					{
						int num7;
						if (!enumerator2.MoveNext())
						{
							num7 = 3;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5537a063960e465db83a04e35eea441b == 0)
							{
								num7 = 0;
							}
							goto IL_00c3;
						}
						goto IL_0103;
						IL_0103:
						current2 = enumerator2.Current;
						num7 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f33560c5d18b4e10b24a458578aa60fd != 0)
						{
							num7 = 0;
						}
						goto IL_00c3;
						IL_00c3:
						while (true)
						{
							switch (num7)
							{
							case 2:
								break;
							case 1:
								goto IL_0103;
							default:
								zMUbMdZBQrVywVfVvEXV(Logger.Log, current2.Message, current2);
								num7 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5d3bc916b5664717ac60544de077bd16 == 0)
								{
									num7 = 2;
								}
								continue;
							case 3:
								goto end_IL_00dd;
							}
							break;
						}
						continue;
						end_IL_00dd:
						break;
					}
				}
				finally
				{
					((IDisposable)enumerator2).Dispose();
					int num8 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bae4e393cddc4c98b9896b25c9e18c7d == 0)
					{
						num8 = 0;
					}
					switch (num8)
					{
					case 0:
						break;
					}
				}
				goto case 6;
			case 17:
				return;
			case 15:
				if (bqwjOuZBTf8Y1S3tCP5W(list) <= 0)
				{
					eRsp8cZBMLrHdqkPmmB7(workflowInstance);
					num2 = 13;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5537a063960e465db83a04e35eea441b != 0)
					{
						num2 = 18;
					}
				}
				else
				{
					num2 = 6;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f276fa9c20d4dd889000f50d886a41e != 0)
					{
						num2 = 7;
					}
				}
				break;
			case 10:
				try
				{
					while (true)
					{
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 3;
							goto IL_01f9;
						}
						goto IL_0229;
						IL_01f9:
						switch (num3)
						{
						case 2:
							goto IL_0229;
						case 1:
							try
							{
								MoveFile(current, workflowInstance);
								int num4 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_160bffb148c14c5da92d8d6ddf481bdc == 0)
								{
									num4 = 0;
								}
								switch (num4)
								{
								case 0:
									break;
								}
							}
							catch (Exception item)
							{
								int num5 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e8980a9fd9d44c20920ffa276900c96f == 0)
								{
									num5 = 0;
								}
								while (true)
								{
									switch (num5)
									{
									default:
										list.Add(item);
										num5 = 0;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5d3bc916b5664717ac60544de077bd16 == 0)
										{
											num5 = 1;
										}
										continue;
									case 1:
										break;
									}
									break;
								}
							}
							break;
						case 3:
							goto end_IL_0213;
						}
						continue;
						IL_0229:
						current = enumerator.Current;
						num3 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_db8eb3e90ad546d4b05544ab6326a49f == 0)
						{
							num3 = 1;
						}
						goto IL_01f9;
						continue;
						end_IL_0213:
						break;
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
					int num6 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_39af03d004af472bb66e60f46e79703a == 0)
					{
						num6 = 0;
					}
					switch (num6)
					{
					case 0:
						break;
					}
				}
				goto case 15;
			case 18:
				ContinueOnDefaultConnector(context);
				num2 = 5;
				break;
			case 3:
				workflowInstance = (IWorkflowInstance)ckOpB2ZB3QYPYgjfZTcC(this, context);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_71a41ac2fa884d27b721ae0509586eea == 0)
				{
					num2 = 0;
				}
				break;
			case 11:
				mPO5IXZBkKkAFD7a6doe(this, context, flowConnectorElement);
				num2 = 8;
				break;
			case 16:
				compositeExceptionForProcesses = new CompositeExceptionForProcesses();
				num2 = 12;
				break;
			case 2:
				eRsp8cZBMLrHdqkPmmB7(workflowInstance);
				num2 = 11;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a50dda04dedf4515816f963c67783c8f != 0)
				{
					num2 = 2;
				}
				break;
			case 4:
				list = new List<Exception>();
				num2 = 3;
				break;
			case 13:
				workflowInstance.Context.SetPropertyValue(GsqjdhZBphHXE0kWaTe1(flowConnectorElement), new ExceptionData(0, (string)ASWpVCZBC5wPD9DBCwp2(compositeExceptionForProcesses), compositeExceptionForProcesses));
				num2 = 2;
				break;
			case 12:
				compositeExceptionForProcesses.Exceptions = list;
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f33560c5d18b4e10b24a458578aa60fd == 0)
				{
					num2 = 1;
				}
				break;
			default:
				enumerator = base.Element.Actions.GetEnumerator();
				num2 = 10;
				break;
			case 9:
				ContinueOnDefaultConnector(context);
				num2 = 17;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6d48f3b4557a49578bf7f5ef0517e0be == 0)
				{
					num2 = 5;
				}
				break;
			case 7:
				flowConnectorElement = base.Element.ExceptionOutputFlows.FirstOrDefault((FlowConnectorElement e) => _003C_003Ec.wHxaIqvHxvv752wrdWOT(e) == EventTrigger.ErrorCatch);
				num2 = 16;
				break;
			}
		}
	}

	private void MoveFile(DocumentMovementInfo action, IWorkflowInstance instance)
	{
		//Discarded unreachable code: IL_016d, IL_017c, IL_0187, IL_023e, IL_0276, IL_0285
		int num = 7;
		int num2 = num;
		object obj = default(object);
		IDocument document = default(IDocument);
		IFolder folder = default(IFolder);
		string text = default(string);
		IEnumerator<IDocument> enumerator = default(IEnumerator<IDocument>);
		IDocument current = default(IDocument);
		while (true)
		{
			switch (num2)
			{
			case 9:
				return;
			case 7:
				obj = XseLYxZBAEmE7HynbXbF(nwGqfyZBUPg41ZPMLbrp(instance), TqSfDmZBV6ELRSffMQ6H(action));
				num2 = 6;
				break;
			case 2:
				ChangeFolder(document, folder, mNkj6KZBGB9tsxJUmewo(action));
				num2 = 9;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f8ecc99a1f4a4b6abc73e9b50261ea83 == 0)
				{
					num2 = 5;
				}
				break;
			case 10:
				text = GetProperty(instance, TqSfDmZBV6ELRSffMQ6H(action)).DisplayName;
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_61395ebf330446ac8ce99b55ee3acfa9 != 0)
				{
					num2 = 1;
				}
				break;
			default:
				throw new Exception((string)mROW0lZBiWxLhfG5lCbi(lxePX0ZBF1yx4jKf5vIh(-885093259 ^ -885246621), new object[1] { text }));
			case 1:
				if (!(obj is IDocument))
				{
					if (obj is IEnumerable)
					{
						num2 = 5;
						break;
					}
					goto default;
				}
				num2 = 4;
				break;
			case 3:
				enumerator = (obj as IEnumerable).Cast<IDocument>().GetEnumerator();
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6b089b0d02ae4d3186c8d2cb8a24d4d3 == 0)
				{
					num2 = 8;
				}
				break;
			case 4:
				document = obj as IDocument;
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cb262bcfe4074a1ab16e653815d57f28 == 0)
				{
					num2 = 2;
				}
				break;
			case 8:
				try
				{
					while (true)
					{
						IL_01f2:
						int num3;
						if (!KLfd43ZB27ChUji3kHjR(enumerator))
						{
							num3 = 3;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_75a2d0f780b04098ba855df5729e6c30 != 0)
							{
								num3 = 0;
							}
							goto IL_018b;
						}
						goto IL_01cf;
						IL_01cf:
						current = enumerator.Current;
						num3 = 2;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1b8b735647da470aa2d45d64d6f538d1 != 0)
						{
							num3 = 2;
						}
						goto IL_018b;
						IL_018b:
						while (true)
						{
							switch (num3)
							{
							case 3:
								return;
							case 2:
								ChangeFolder(current, folder, mNkj6KZBGB9tsxJUmewo(action));
								num3 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_60c5782a184b457aa78da2e5c62d4e27 == 0)
								{
									num3 = 0;
								}
								continue;
							case 1:
								break;
							default:
								goto IL_01f2;
							}
							break;
						}
						goto IL_01cf;
					}
				}
				finally
				{
					if (enumerator != null)
					{
						int num4 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_764abb15e52f4036a7a81fce6cb70f30 != 0)
						{
							num4 = 0;
						}
						while (true)
						{
							switch (num4)
							{
							default:
								yH4aeMZBoyMS8rDyrkY8(enumerator);
								num4 = 1;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_fb347e2c5dba4e0ca4d47098be7fd10c != 0)
								{
									num4 = 1;
								}
								continue;
							case 1:
								break;
							}
							break;
						}
					}
				}
			case 5:
				if (B1WLv0ZB74wAoRymkytQ(obj as ISet<IDocument>) > 0)
				{
					num2 = 3;
					break;
				}
				goto default;
			case 6:
				folder = GetFolder(action, instance);
				num2 = 10;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f8ecc99a1f4a4b6abc73e9b50261ea83 == 0)
				{
					num2 = 3;
				}
				break;
			}
		}
	}

	private IFolder GetFolder(DocumentMovementInfo action, IWorkflowInstance instance)
	{
		//Discarded unreachable code: IL_00a6, IL_0205, IL_0231, IL_0240
		int num = 1;
		long? folderId = default(long?);
		IFolder folder = default(IFolder);
		string text = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					if (u7GPKaZBIjeGOxFpQvyw(action) == DocumentMovementInfo.Folder.contextVar)
					{
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a50dda04dedf4515816f963c67783c8f == 0)
						{
							num2 = 0;
						}
						continue;
					}
					folderId = action.FolderId;
					num2 = 4;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a23e27b648a042f098a477c26c4beed1 == 0)
					{
						num2 = 1;
					}
					continue;
				case 10:
					folderId = action.FolderId;
					num2 = 5;
					continue;
				case 4:
					if (!folderId.HasValue)
					{
						num2 = 12;
						continue;
					}
					goto case 10;
				case 11:
					throw new Exception((string)mROW0lZBiWxLhfG5lCbi(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-961162596 ^ -961058668), new object[1] { action.FolderId.Value.ToString() }));
				case 2:
					return folder;
				case 9:
					throw new Exception((string)mROW0lZBiWxLhfG5lCbi(lxePX0ZBF1yx4jKf5vIh(0x12F686A ^ 0x12DD118), new object[1] { text }));
				case 3:
					text = (string)bb8lyqZBrW7ueBeUtK4S(GetProperty(instance, dQmrCcZBaDJXXkbEwsRC(action)));
					num2 = 7;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bd84f42638494cb6b4427f8e13ec59af == 0)
					{
						num2 = 8;
					}
					continue;
				case 6:
				case 12:
					throw new Exception((string)Em8TPZZBe9tSuwbFMCa6(lxePX0ZBF1yx4jKf5vIh(-1498811449 ^ -1498723827)));
				case 13:
					break;
				case 7:
					if (folder == null)
					{
						num2 = 11;
						continue;
					}
					goto case 2;
				case 5:
					if (folderId.Value >= 1)
					{
						num2 = 13;
						continue;
					}
					goto case 6;
				case 8:
					if (folder != null)
					{
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b74fcd91509d46c3a9661cffb0465df0 == 0)
						{
							num2 = 2;
						}
						continue;
					}
					goto case 9;
				default:
					folder = ((Entity<long>)nwGqfyZBUPg41ZPMLbrp(instance)).GetPropertyValue<IFolder>(action.FolderGuid);
					num2 = 3;
					continue;
				}
				break;
			}
			IEntityManager<IFolder> instance2 = EntityManager<IFolder>.Instance;
			folderId = action.FolderId;
			folder = instance2.LoadOrNull(folderId.Value);
			num = 7;
		}
	}

	private void ChangeFolder(IDocument document, IFolder folder, bool InheritPermissions)
	{
		//Discarded unreachable code: IL_013c, IL_014b
		int num = 9;
		int num2 = num;
		DmsObjectMoveActionEventArgs e = default(DmsObjectMoveActionEventArgs);
		IFolder folder2 = default(IFolder);
		while (true)
		{
			switch (num2)
			{
			case 3:
				BgW5naZBxAk3QmrKWTtE(document, false);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1733a11cae754a598119b94f8d9e4971 != 0)
				{
					num2 = 0;
				}
				break;
			case 8:
				fFV7cbZBNcDCutWE6BHd(document, folder);
				num2 = 6;
				break;
			case 6:
				if (InheritPermissions)
				{
					num2 = 5;
					break;
				}
				goto case 3;
			case 1:
				EntityActionHandler.ActionExecuted(e);
				num2 = 4;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f19dffab164a41148300de28b2deec39 == 0)
				{
					num2 = 1;
				}
				break;
			case 9:
				folder2 = document.Folder;
				num2 = 8;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_9269d021c6f148b6a1c4afb8cee03b6c == 0)
				{
					num2 = 2;
				}
				break;
			case 2:
			{
				Guid actionUid = GNroNwZBSkUgUV1G4xp3();
				DmsObjectMoveInfo dmsObjectMoveInfo = new DmsObjectMoveInfo();
				NopPliZB1mpTpEUGTUjZ(dmsObjectMoveInfo, folder2.Id);
				XACBGyZBhU4QYMxJJ9iE(dmsObjectMoveInfo, folder.Id);
				e = new DmsObjectMoveActionEventArgs(document, document, actionUid, dmsObjectMoveInfo);
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6f64eb224ece438ba2f0bbd2f29cebfd == 0)
				{
					num2 = 1;
				}
				break;
			}
			case 5:
				BgW5naZBxAk3QmrKWTtE(document, true);
				num2 = 7;
				break;
			case 4:
				return;
			default:
				document.Save();
				num2 = 2;
				break;
			}
		}
	}

	public DocumentMovementActivity()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		Tkcx5eZBELirLYDr16Jm();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d7a51cf2841b436998bf3f4157fb2c9a == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object ckOpB2ZB3QYPYgjfZTcC(object P_0, object P_1)
	{
		return ((WorkflowActivity)P_0).GetInstance((NativeActivityContext)P_1);
	}

	internal static int bqwjOuZBTf8Y1S3tCP5W(object P_0)
	{
		return ((List<Exception>)P_0).Count;
	}

	internal static void zMUbMdZBQrVywVfVvEXV(object P_0, object P_1, object P_2)
	{
		((ILogger)P_0).Error(P_1, (Exception)P_2);
	}

	internal static Guid GsqjdhZBphHXE0kWaTe1(object P_0)
	{
		return ((FlowConnectorElement)P_0).ContextExceptionVar;
	}

	internal static object ASWpVCZBC5wPD9DBCwp2(object P_0)
	{
		return ((Exception)P_0).Message;
	}

	internal static void eRsp8cZBMLrHdqkPmmB7(object P_0)
	{
		((IEntity)P_0).Save();
	}

	internal static void mPO5IXZBkKkAFD7a6doe(object P_0, object P_1, object P_2)
	{
		((WorkflowActivity)P_0).ContinueOnConnector((NativeActivityContext)P_1, (Connector)P_2);
	}

	internal static bool yVacusZB69Lp5MpEnByh()
	{
		return nKWtmTZBRUFsu3qDwGBG == null;
	}

	internal static DocumentMovementActivity aWkEnKZBq45OgwT5kkSV()
	{
		return nKWtmTZBRUFsu3qDwGBG;
	}

	internal static object nwGqfyZBUPg41ZPMLbrp(object P_0)
	{
		return ((IWorkflowInstance)P_0).Context;
	}

	internal static Guid TqSfDmZBV6ELRSffMQ6H(object P_0)
	{
		return ((DocumentMovementInfo)P_0).Document;
	}

	internal static object XseLYxZBAEmE7HynbXbF(object P_0, Guid P_1)
	{
		return ((Entity<long>)P_0).GetPropertyValue(P_1);
	}

	internal static bool mNkj6KZBGB9tsxJUmewo(object P_0)
	{
		return ((DocumentMovementInfo)P_0).InheritRights;
	}

	internal static int B1WLv0ZB74wAoRymkytQ(object P_0)
	{
		return ((ICollection<IDocument>)P_0).Count;
	}

	internal static bool KLfd43ZB27ChUji3kHjR(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void yH4aeMZBoyMS8rDyrkY8(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static object lxePX0ZBF1yx4jKf5vIh(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object mROW0lZBiWxLhfG5lCbi(object P_0, object P_1)
	{
		return SR.T((string)P_0, (object[])P_1);
	}

	internal static DocumentMovementInfo.Folder u7GPKaZBIjeGOxFpQvyw(object P_0)
	{
		return ((DocumentMovementInfo)P_0).FolderType;
	}

	internal static Guid dQmrCcZBaDJXXkbEwsRC(object P_0)
	{
		return ((DocumentMovementInfo)P_0).FolderGuid;
	}

	internal static object bb8lyqZBrW7ueBeUtK4S(object P_0)
	{
		return ((NamedMetadata)P_0).DisplayName;
	}

	internal static object Em8TPZZBe9tSuwbFMCa6(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static void fFV7cbZBNcDCutWE6BHd(object P_0, object P_1)
	{
		((IDmsObject)P_0).Folder = (IFolder)P_1;
	}

	internal static void BgW5naZBxAk3QmrKWTtE(object P_0, bool P_1)
	{
		((IDmsObject)P_0).InheritPermissions = P_1;
	}

	internal static Guid GNroNwZBSkUgUV1G4xp3()
	{
		return DmsObjectActions.MoveGuid;
	}

	internal static void NopPliZB1mpTpEUGTUjZ(object P_0, long P_1)
	{
		((DmsObjectMoveInfo)P_0).OldFolderId = P_1;
	}

	internal static void XACBGyZBhU4QYMxJJ9iE(object P_0, long P_1)
	{
		((DmsObjectMoveInfo)P_0).NewFolderId = P_1;
	}

	internal static void Tkcx5eZBELirLYDr16Jm()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}
}
