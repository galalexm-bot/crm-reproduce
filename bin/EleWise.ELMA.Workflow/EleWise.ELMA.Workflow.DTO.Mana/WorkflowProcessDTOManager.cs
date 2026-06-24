using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using AutoMapper;
using EleWise.ELMA.Diagrams;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Enums;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Model.Scripts.DTO.Models;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Runtime;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.Db.Migrator.Providers;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Services;
using EleWise.ELMA.Workflow.BPMN;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Connectors;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Swimlanes;
using EleWise.ELMA.Workflow.Components;
using EleWise.ELMA.Workflow.DTO.Models;
using EleWise.ELMA.Workflow.Managers;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.DTO.Managers;

public class WorkflowProcessDTOManager : DTOManager, IWorkflowProcessDTOManager, IConfigurationService
{
	private static WorkflowProcessDTOManager MRCZ7WxZaGpMJBMaGIs;

	public WorkflowProcessManager WorkflowProcessManager
	{
		[CompilerGenerated]
		get
		{
			return _003CWorkflowProcessManager_003Ek__BackingField;
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
					_003CWorkflowProcessManager_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c559093b7320494babd70d164a6df42d == 0)
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

	public IEnumerable<IFormDependencyExtension> FormDependencyExtensions { get; set; }

	public ITransformationProvider TransformationProvider
	{
		[CompilerGenerated]
		get
		{
			return _003CTransformationProvider_003Ek__BackingField;
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
					_003CTransformationProvider_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_67df302d7a2e4c95b7c8b62f21f3a833 == 0)
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
				case 0:
					return;
				case 1:
					_003CSessionProvider_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3ab79470996d472f815915b21f45aac1 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public virtual WorkflowProcessDTO Save(WorkflowProcessDTO process)
	{
		int num = 6;
		int num2 = num;
		IWorkflowProcess workflowProcess = default(IWorkflowProcess);
		while (true)
		{
			switch (num2)
			{
			case 4:
				IFfbSbxlNKDalprkgNT(Logger.Log, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x13F63440 ^ 0x13F76C56));
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_558b46b4f4364838b08ac89d77f9a257 != 0)
				{
					num2 = 0;
				}
				break;
			case 5:
				IFfbSbxlNKDalprkgNT(O8l07SxJhM7bF9RyQuX(), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4943E3E4 ^ 0x4942B4DA));
				num2 = 3;
				break;
			default:
				hL7eISxyNRFmKDu7BbG(workflowProcess);
				num2 = 8;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_58fb165cafed422d973d4a7156526541 == 0)
				{
					num2 = 4;
				}
				break;
			case 9:
				IFfbSbxlNKDalprkgNT(O8l07SxJhM7bF9RyQuX(), dfdEIDx8ySTPUXUtgc1(-1214182792 ^ -1214227068));
				num2 = 4;
				break;
			case 3:
				workflowProcess = (IWorkflowProcess)a09vAGx0fPeQyJdlCt6(process);
				num2 = 10;
				break;
			case 7:
				((ILogger)O8l07SxJhM7bF9RyQuX()).Debug(dfdEIDx8ySTPUXUtgc1(-1712492721 ^ -1712572191));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1de08766357542bdb81146373079f817 != 0)
				{
					num2 = 0;
				}
				break;
			case 10:
				IFfbSbxlNKDalprkgNT(O8l07SxJhM7bF9RyQuX(), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6A69C5CD ^ 0x6A6892B5));
				num2 = 7;
				break;
			case 2:
				IFfbSbxlNKDalprkgNT(Logger.Log, dfdEIDx8ySTPUXUtgc1(-25709590 ^ -25762764));
				num2 = 3;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3ab79470996d472f815915b21f45aac1 != 0)
				{
					num2 = 9;
				}
				break;
			case 6:
				D3IUKcxsiVFOUjvNfMI(process, dfdEIDx8ySTPUXUtgc1(0x75872B6 ^ 0x75862C4));
				num2 = 5;
				break;
			case 8:
				((ILogger)O8l07SxJhM7bF9RyQuX()).Debug(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1712492721 ^ -1712572283));
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_9570b4a70465495fba22c942f586465a != 0)
				{
					num2 = 2;
				}
				break;
			case 1:
			{
				WorkflowProcessDTO result = (WorkflowProcessDTO)hpmwhgxm6y2DU3JlEKc(workflowProcess, process, workflowProcess.GetType(), process.GetType());
				IFfbSbxlNKDalprkgNT(O8l07SxJhM7bF9RyQuX(), dfdEIDx8ySTPUXUtgc1(0x5F800F5B ^ 0x5F81570B));
				if (XosgBRxth7vOZKQyIee(workflowProcess) != null && E1QKIOxbRJST5336AT3(workflowProcess.Header) != null)
				{
					KhtqUmx5BiZmxlsAom6(((IProcessHeader)XosgBRxth7vOZKQyIee(workflowProcess)).ParentGroup);
				}
				return result;
			}
			}
		}
	}

	public virtual WorkflowProcessDTO LoadOrNull(long id)
	{
		int num = 1;
		int num2 = num;
		IWorkflowProcess workflowProcess = default(IWorkflowProcess);
		while (true)
		{
			switch (num2)
			{
			case 1:
				workflowProcess = WorkflowProcessManager.LoadOrNull(id);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d843b0b7f23e489fb6d586d64b0a634a != 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				return null;
			}
			if (workflowProcess == null)
			{
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ffb1346d351f436b84bb1e9954c3bfa8 == 0)
				{
					num2 = 2;
				}
				continue;
			}
			return (WorkflowProcessDTO)fUUqvOxg3PULW5KJ1eI(workflowProcess);
		}
	}

	public virtual WorkflowProcessDTO Load(long id)
	{
		return (WorkflowProcessDTO)fUUqvOxg3PULW5KJ1eI(WorkflowProcessManager.Load(id));
	}

	public virtual WorkflowProcessDTO LoadWithFillDependencies(long id)
	{
		int num = 2;
		int num2 = num;
		WorkflowProcessDTO workflowProcessDTO = default(WorkflowProcessDTO);
		while (true)
		{
			switch (num2)
			{
			case 1:
				xlqa6SxXDVsgqa5aPGs(new Thread(FillDependencies), new KeyValuePair<Guid, Guid>(TyAEvbxcaLkpdsT9qY4(workflowProcessDTO), ((ProcessHeaderDTO)ei087GxPOorJbHFLfNn(workflowProcessDTO)).Uid));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_9570b4a70465495fba22c942f586465a == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				workflowProcessDTO = (WorkflowProcessDTO)mvdDswxBi5NfbpB7GUR(this, id);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ba57b850b1d34fd9bce66a583e71dc16 != 0)
				{
					num2 = 1;
				}
				break;
			default:
				return workflowProcessDTO;
			}
		}
	}

	private void FillDependencies(object parameters)
	{
		//Discarded unreachable code: IL_007a, IL_0089, IL_0102, IL_0111, IL_01e5, IL_0250, IL_025f, IL_026e, IL_02d3, IL_033d, IL_036d, IL_03ad, IL_03bc, IL_03cb
		int num = 2;
		int num2 = num;
		IFormDependencyExtension formDependencyExtension = default(IFormDependencyExtension);
		CallContextSessionOwner callContextSessionOwner = default(CallContextSessionOwner);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				try
				{
					KeyValuePair<Guid, Guid> keyValuePair = (KeyValuePair<Guid, Guid>)parameters;
					int num3 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_eb7de45300244c968ac00be3ffdf3d29 != 0)
					{
						num3 = 4;
					}
					while (true)
					{
						switch (num3)
						{
						default:
							ooY2tTxuiQYhoDiWIyS(TransformationProvider);
							num3 = 1;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_545887e65739480a965b7ddfab7d0632 != 0)
							{
								num3 = 1;
							}
							continue;
						case 4:
							if (ev9d4KxdyLcNt25auun(keyValuePair.Key))
							{
								num3 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6e2e244178c44ea09cd756894b022a62 == 0)
								{
									num3 = 0;
								}
								continue;
							}
							return;
						case 2:
							break;
						case 5:
							return;
						case 1:
							try
							{
								object obj = lKWrAJxDW78ZB2NkjS1(SessionProvider, "");
								List<Guid> list = (from q in ((IQuery)c9yni7xHldLwDd56urO(((IQuery)YDl4UlxntjZlB3nQooc(obj, dfdEIDx8ySTPUXUtgc1(-708128192 ^ -708080954))).SetParameter<Guid>((string)dfdEIDx8ySTPUXUtgc1(0x246EEF98 ^ 0x246FB722), keyValuePair.Value), false)).List<object>()
									select ((Dialect)C55RPxxol0WQjS1lvaE(TransformationProvider)).GetGuid(q)).ToList();
								krV9xFxLJfdRdWAvKAb(((IQuery)YDl4UlxntjZlB3nQooc(obj, dfdEIDx8ySTPUXUtgc1(0x246EEF98 ^ 0x246FB746))).SetParameter<List<Guid>>((string)dfdEIDx8ySTPUXUtgc1(0xB7793C9 ^ 0xB76CAC7), list), false);
								gQ8Zhkxf7uv0XhRBn4G(obj, new Type[1] { InterfaceActivator.TypeOf<IFormDependency>() });
								int num4 = 5;
								while (true)
								{
									switch (num4)
									{
									case 1:
										if (formDependencyExtension != null)
										{
											num4 = 3;
											continue;
										}
										return;
									default:
										list.ForEach(formDependencyExtension.GenerateNewDependencies);
										num4 = 2;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_fb347e2c5dba4e0ca4d47098be7fd10c != 0)
										{
											num4 = 2;
										}
										continue;
									case 4:
										return;
									case 5:
										formDependencyExtension = FormDependencyExtensions.FirstOrDefault((IFormDependencyExtension q) => q is WorkflowFormDependencyExtension);
										num4 = 1;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_978f838cc41a4debb9700ede4b63f820 == 0)
										{
											num4 = 0;
										}
										continue;
									case 2:
										break;
									}
									break;
								}
							}
							catch (Exception ex)
							{
								int num5 = 2;
								while (true)
								{
									switch (num5)
									{
									case 1:
										jjUemsxWKstAQQ2NIdq(TransformationProvider);
										num5 = 0;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f30401a2cff84771be092252e934fede == 0)
										{
											num5 = 0;
										}
										continue;
									case 2:
										iJtJF4x9bvlA9RxD3Rm(O8l07SxJhM7bF9RyQuX(), ex);
										num5 = 1;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_639c11c7bb65456db9f29c9c42f28bf7 != 0)
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
							break;
						case 3:
							return;
						}
						VqGZeVxjrOgVPRONlTA(TransformationProvider);
						int num6 = 3;
						num3 = num6;
					}
				}
				finally
				{
					int num7;
					if (callContextSessionOwner == null)
					{
						num7 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bf623f11574746d6bf3837b66460c576 != 0)
						{
							num7 = 0;
						}
						goto IL_0371;
					}
					goto IL_0387;
					IL_0387:
					yfmP7TxRf6w2q2d5IZ7(callContextSessionOwner);
					num7 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_abfb511163674a3eae959fd60da8f319 != 0)
					{
						num7 = 1;
					}
					goto IL_0371;
					IL_0371:
					switch (num7)
					{
					default:
						goto end_IL_034c;
					case 2:
						break;
					case 0:
						goto end_IL_034c;
					case 1:
						goto end_IL_034c;
					}
					goto IL_0387;
					end_IL_034c:;
				}
			case 0:
				return;
			case 2:
				callContextSessionOwner = CallContextSessionOwner.Create();
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_eef7d2ca1c3c4b74aeb81172ed542639 == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public virtual bool Exist(Guid uid)
	{
		return WorkflowProcessManager.LoadOrNull(uid) != null;
	}

	public virtual string GetFormDisplayInfo(Guid objectUid, Guid formUid, FormDependencyDataType type)
	{
		//Discarded unreachable code: IL_00da, IL_01a7, IL_01b6, IL_020e, IL_029b, IL_03f0
		int num = 11;
		string text = default(string);
		WorkflowForm workflowForm = default(WorkflowForm);
		BPMNFlowElement bPMNFlowElement = default(BPMNFlowElement);
		IWorkflowProcess workflowProcess = default(IWorkflowProcess);
		_003C_003Ec__DisplayClass22_0 _003C_003Ec__DisplayClass22_ = default(_003C_003Ec__DisplayClass22_0);
		SwimlaneElement swimlaneElement = default(SwimlaneElement);
		string text2 = default(string);
		Element element = default(Element);
		FlowConnectorElement flowConnectorElement = default(FlowConnectorElement);
		while (true)
		{
			int num2 = num;
			object obj;
			while (true)
			{
				switch (num2)
				{
				case 9:
					text = (string)J1adQBx3vb7cTAJ4XRy(workflowForm);
					num2 = 28;
					continue;
				case 3:
					text = string.Empty;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c447ffb64be44c09b6fd398df506785b == 0)
					{
						num2 = 4;
					}
					continue;
				case 26:
					if (bPMNFlowElement != null)
					{
						num2 = 16;
						continue;
					}
					goto case 25;
				case 6:
				case 14:
					text = (string)hGUxl2xM6dccOfENVGi(text, NipdQHxCbTrght5i09n(bPMNFlowElement));
					num2 = 19;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b1ab9396b25b43af8f32e24b1948be96 != 0)
					{
						num2 = 19;
					}
					continue;
				case 23:
					workflowForm = ((WorkflowFormsContainer)dp5P1WxqSDXVL4omM3S(workflowProcess)).Items.FirstOrDefault(_003C_003Ec__DisplayClass22_._003CGetFormDisplayInfo_003Eb__0);
					num2 = 12;
					continue;
				case 5:
					if (bPMNFlowElement == null)
					{
						num2 = 15;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_26fa47f5bd8343debcae8b05a56a3ab5 == 0)
						{
							num2 = 6;
						}
						continue;
					}
					goto case 16;
				case 4:
					workflowProcess = WorkflowProcessManager.LoadOrNull(objectUid);
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d87d9a74c9e14f96a288cc3620965fe0 != 0)
					{
						num2 = 0;
					}
					continue;
				case 11:
					_003C_003Ec__DisplayClass22_ = new _003C_003Ec__DisplayClass22_0();
					num2 = 6;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6b089b0d02ae4d3186c8d2cb8a24d4d3 == 0)
					{
						num2 = 10;
					}
					continue;
				case 15:
					return text;
				case 16:
					swimlaneElement = (SwimlaneElement)P0AooOxpXqmNdVGAhuY(bPMNFlowElement, fnjjdXxQvYXLPYebMJU(workflowProcess));
					num2 = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f33560c5d18b4e10b24a458578aa60fd == 0)
					{
						num2 = 7;
					}
					continue;
				case 27:
					obj = SR.T((string)dfdEIDx8ySTPUXUtgc1(0x7AC609FE ^ 0x7AC72F9E));
					goto end_IL_0012;
				case 7:
					if (swimlaneElement == null)
					{
						num2 = 6;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_764abb15e52f4036a7a81fce6cb70f30 != 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 22;
				case 1:
					return text;
				default:
					if (workflowProcess == null)
					{
						num2 = 18;
						continue;
					}
					if (type != FormDependencyDataType.Child)
					{
						num2 = 27;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_eb7de45300244c968ac00be3ffdf3d29 == 0)
						{
							num2 = 12;
						}
						continue;
					}
					obj = K9CK30x6cOJ27thOyB7(dfdEIDx8ySTPUXUtgc1(0xDF4D1F8 ^ 0xDF588D0));
					goto end_IL_0012;
				case 24:
					return text;
				case 10:
					_003C_003Ec__DisplayClass22_.formUid = formUid;
					num2 = 3;
					continue;
				case 8:
				case 17:
				case 28:
					return (string)ePnbLFxVIxyKr0eU4CT(dfdEIDx8ySTPUXUtgc1(-1514166050 ^ -1514212980), text2, workflowProcess.Name, text);
				case 2:
					bPMNFlowElement = element as BPMNFlowElement;
					num2 = 26;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bae2bde9e5844c638021cdb56fc01122 != 0)
					{
						num2 = 15;
					}
					continue;
				case 19:
					if (flowConnectorElement == null)
					{
						num2 = 8;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_fb347e2c5dba4e0ca4d47098be7fd10c == 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				case 12:
					if (workflowForm != null)
					{
						num2 = 9;
						continue;
					}
					goto case 21;
				case 18:
					return text;
				case 22:
					text = (string)hGUxl2xM6dccOfENVGi(NipdQHxCbTrght5i09n(swimlaneElement), dfdEIDx8ySTPUXUtgc1(-1361036319 ^ -1360979835));
					num2 = 14;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_160bffb148c14c5da92d8d6ddf481bdc != 0)
					{
						num2 = 12;
					}
					continue;
				case 13:
					if (element != null)
					{
						flowConnectorElement = element as FlowConnectorElement;
						num2 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_46e05b4e09174e34a9c81741b8b77a2f == 0)
						{
							num2 = 2;
						}
					}
					else
					{
						num2 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f870ea690334e7ab7599d275d195e9a == 0)
						{
							num2 = 0;
						}
					}
					continue;
				case 21:
					element = workflowProcess.Diagram.Elements.FirstOrDefault(_003C_003Ec__DisplayClass22_._003CGetFormDisplayInfo_003Eb__1);
					num2 = 13;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bd84f42638494cb6b4427f8e13ec59af != 0)
					{
						num2 = 13;
					}
					continue;
				case 25:
					if (flowConnectorElement != null)
					{
						bPMNFlowElement = cPQGawxT2kI5p4PnoBp(flowConnectorElement) as BPMNFlowElement;
						num2 = 5;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f870ea690334e7ab7599d275d195e9a == 0)
						{
							num2 = 3;
						}
					}
					else
					{
						num2 = 24;
					}
					continue;
				case 20:
					break;
				}
				text = (string)LScYr2xU70PoEqdELGb(text, dfdEIDx8ySTPUXUtgc1(0x56A753C9 ^ 0x56A670AD), HKIG80xkx9r2MfTFGeA(flowConnectorElement.Name) ? (SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-135674354 ^ -135749818) + flowConnectorElement.EndElement) : NipdQHxCbTrght5i09n(flowConnectorElement));
				num2 = 17;
				continue;
				end_IL_0012:
				break;
			}
			text2 = (string)obj;
			num = 23;
		}
	}

	public virtual WorkflowProcessDTO LoadAsDraft(long id)
	{
		return (WorkflowProcessDTO)fUUqvOxg3PULW5KJ1eI(WorkflowProcessManager.LoadAsDraft(id));
	}

	public virtual WorkflowProcessDTO LoadDraft(long id)
	{
		return (WorkflowProcessDTO)R9QuW1xAsx1USIFaTy1(WorkflowProcessManager, id);
	}

	public virtual List<WorkflowHistoryItemDTO> LoadHistory(long processHeadId)
	{
		return (from i in WorkflowProcessManager.LoadHistory(processHeadId)
			select Mapper.Map<WorkflowProcessHistoryItem, WorkflowHistoryItemDTO>(i, new WorkflowHistoryItemDTO())).ToList();
	}

	public virtual List<WorkflowProcessDTO> LoadPublishedProcesses(string searchString)
	{
		WorkflowProcessFilter filter = new WorkflowProcessFilter
		{
			SearchString = searchString,
			Published = true
		};
		return (from h in WorkflowProcessManager.Find(filter, FetchOptions.All)
			select Mapper.Map<IWorkflowProcess, WorkflowProcessDTO>(h, new WorkflowProcessDTO())).ToList();
	}

	public virtual ScriptModuleDTO LoadScriptModuleForEdit(long processId)
	{
		return Mapper.Map<ScriptModule, ScriptModuleDTO>((ScriptModule)J0bavqxGk2oJBwbH9v8(WorkflowProcessManager, processId), new ScriptModuleDTO());
	}

	public virtual void SaveScriptModule(ScriptModuleDTO scriptModule)
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
				kNex7fx7oPPnHmcK7c2(Mapper.Map<ScriptModuleDTO, ScriptModule>(scriptModule));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5c45a6e5a4614bfba7591d8a1c7ced1d != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public virtual void PublishScriptModule(long processId, ScriptModuleDTO scriptModule)
	{
		int num = 1;
		int num2 = num;
		ScriptModule scriptModule2 = default(ScriptModule);
		while (true)
		{
			switch (num2)
			{
			case 1:
				scriptModule2 = Mapper.Map<ScriptModuleDTO, ScriptModule>(scriptModule);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_69cb4a76addb44f28bb765f059e441c7 != 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				WorkflowProcessManager.PublishScriptModule(processId, scriptModule2);
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bf623f11574746d6bf3837b66460c576 != 0)
				{
					num2 = 2;
				}
				break;
			default:
				kNex7fx7oPPnHmcK7c2(scriptModule2);
				num2 = 3;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bd84f42638494cb6b4427f8e13ec59af != 0)
				{
					num2 = 3;
				}
				break;
			case 2:
				return;
			}
		}
	}

	public virtual List<string> Documentation(ref GenerationSettings settings, bool isPublishing)
	{
		IWorkflowProcess workflowProcess = WorkflowProcessManager.Load(settings.ProcessId);
		ProcessDocumentationGenerator processDocumentationGenerator = new ProcessDocumentationGenerator(workflowProcess);
		if (isPublishing)
		{
			IRuntimeApplication service = Locator.GetService<IRuntimeApplication>();
			settings.ServerDirectory = string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-961162596 ^ -961246226), Path.GetDirectoryName(service.Configuration.Config.FilePath), settings.ProcessId);
		}
		else
		{
			string tempFileName = IOExtensions.GetTempFileName();
			settings.ServerDirectory = Path.Combine(Path.GetDirectoryName(tempFileName), Path.GetFileNameWithoutExtension(tempFileName));
		}
		string serverDirectory = settings.ServerDirectory;
		if (!Directory.Exists(serverDirectory))
		{
			Directory.CreateDirectory(serverDirectory);
		}
		processDocumentationGenerator.CreateDocumentation(workflowProcess, serverDirectory, settings, subFolders: true);
		return Directory.GetFiles(serverDirectory, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x63D6C913 ^ 0x63D790B3), SearchOption.AllDirectories).ToList();
	}

	public virtual byte[] GetFile(string path)
	{
		//Discarded unreachable code: IL_0050, IL_007b, IL_011f, IL_0132, IL_0141
		int num = 1;
		int num2 = num;
		byte[] array = default(byte[]);
		FileStream fileStream = default(FileStream);
		int num5 = default(int);
		int num6 = default(int);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return array;
			case 1:
				fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f2d402219199402696ade21eab23d086 != 0)
				{
					num2 = 0;
				}
				continue;
			}
			try
			{
				int num3 = (int)vD4cnwx2rpi9ra4bfQR(fileStream);
				int num4 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_be442748c2c44d33a71dd83576ab2ba4 == 0)
				{
					num4 = 0;
				}
				while (true)
				{
					switch (num4)
					{
					case 2:
						return array;
					case 3:
						num5 += num6;
						num4 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_719514a5a8ae47ed84e5a777ead0dc9f != 0)
						{
							num4 = 1;
						}
						break;
					default:
						array = new byte[num3];
						num4 = 4;
						break;
					case 4:
						num5 = 0;
						num4 = 5;
						break;
					case 1:
					case 5:
						if ((num6 = fileStream.Read(array, num5, num3 - num5)) <= 0)
						{
							num4 = 2;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b1ab9396b25b43af8f32e24b1948be96 != 0)
							{
								num4 = 2;
							}
							break;
						}
						goto case 3;
					}
				}
			}
			finally
			{
				fileStream.Close();
				int num7 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_90dfe18b3d784ead92a1e4e4e2547482 != 0)
				{
					num7 = 0;
				}
				switch (num7)
				{
				case 0:
					break;
				}
			}
		}
	}

	public virtual void RenameItem(long processId, long? draftId, string name)
	{
		WorkflowProcessManager.RenameItem(processId, draftId, name);
	}

	public WorkflowProcessDTOManager()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6e2e244178c44ea09cd756894b022a62 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool CMJfRexvOngH4SQRcwK()
	{
		return MRCZ7WxZaGpMJBMaGIs == null;
	}

	internal static WorkflowProcessDTOManager eqxIULxYYSyxev4mGlk()
	{
		return MRCZ7WxZaGpMJBMaGIs;
	}

	internal static object dfdEIDx8ySTPUXUtgc1(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void D3IUKcxsiVFOUjvNfMI(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static object O8l07SxJhM7bF9RyQuX()
	{
		return Logger.Log;
	}

	internal static void IFfbSbxlNKDalprkgNT(object P_0, object P_1)
	{
		((ILogger)P_0).Debug(P_1);
	}

	internal static object a09vAGx0fPeQyJdlCt6(object P_0)
	{
		return ((WorkflowProcessDTO)P_0).CreateEntity();
	}

	internal static void hL7eISxyNRFmKDu7BbG(object P_0)
	{
		((IEntity)P_0).Save();
	}

	internal static object hpmwhgxm6y2DU3JlEKc(object P_0, object P_1, Type P_2, Type P_3)
	{
		return Mapper.Map(P_0, P_1, P_2, P_3);
	}

	internal static object XosgBRxth7vOZKQyIee(object P_0)
	{
		return ((IWorkflowProcess)P_0).Header;
	}

	internal static object E1QKIOxbRJST5336AT3(object P_0)
	{
		return ((IProcessHeader)P_0).ParentGroup;
	}

	internal static void KhtqUmx5BiZmxlsAom6(object P_0)
	{
		((IEntity)P_0).Refresh();
	}

	internal static object fUUqvOxg3PULW5KJ1eI(object P_0)
	{
		return ((IWorkflowProcess)P_0).CreateDTO();
	}

	internal static object mvdDswxBi5NfbpB7GUR(object P_0, long id)
	{
		return ((WorkflowProcessDTOManager)P_0).Load(id);
	}

	internal static Guid TyAEvbxcaLkpdsT9qY4(object P_0)
	{
		return ((WorkflowProcessDTO)P_0).Uid;
	}

	internal static object ei087GxPOorJbHFLfNn(object P_0)
	{
		return ((WorkflowProcessDTO)P_0).Header;
	}

	internal static void xlqa6SxXDVsgqa5aPGs(object P_0, object P_1)
	{
		((Thread)P_0).Start(P_1);
	}

	internal static bool ev9d4KxdyLcNt25auun(Guid P_0)
	{
		return FormDependencyHelper.ExistFakeDependencies(P_0);
	}

	internal static void ooY2tTxuiQYhoDiWIyS(object P_0)
	{
		((ITransformationProvider)P_0).BeginTransaction();
	}

	internal static object lKWrAJxDW78ZB2NkjS1(object P_0, object P_1)
	{
		return ((ISessionProvider)P_0).GetSession((string)P_1);
	}

	internal static object YDl4UlxntjZlB3nQooc(object P_0, object P_1)
	{
		return ((ISession)P_0).GetNamedQuery((string)P_1);
	}

	internal static object c9yni7xHldLwDd56urO(object P_0, bool P_1)
	{
		return ((IQuery)P_0).CleanUpCache(P_1);
	}

	internal static int krV9xFxLJfdRdWAvKAb(object P_0, bool P_1)
	{
		return ((IQuery)P_0).ExecuteUpdate(P_1);
	}

	internal static void gQ8Zhkxf7uv0XhRBn4G(object P_0, object P_1)
	{
		((ISession)P_0).CleanUpCache((Type[])P_1);
	}

	internal static void iJtJF4x9bvlA9RxD3Rm(object P_0, object P_1)
	{
		((ILogger)P_0).Error(P_1);
	}

	internal static void jjUemsxWKstAQQ2NIdq(object P_0)
	{
		((ITransformationProvider)P_0).RollbackTransaction();
	}

	internal static void VqGZeVxjrOgVPRONlTA(object P_0)
	{
		((ITransformationProviderBase)P_0).CommitTransaction();
	}

	internal static void yfmP7TxRf6w2q2d5IZ7(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static object K9CK30x6cOJ27thOyB7(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static object dp5P1WxqSDXVL4omM3S(object P_0)
	{
		return ((IWorkflowProcess)P_0).Forms;
	}

	internal static object J1adQBx3vb7cTAJ4XRy(object P_0)
	{
		return ((WorkflowForm)P_0).FormDisplayName;
	}

	internal static object cPQGawxT2kI5p4PnoBp(object P_0)
	{
		return ((Connector)P_0).StartElement;
	}

	internal static object fnjjdXxQvYXLPYebMJU(object P_0)
	{
		return ((IWorkflowProcess)P_0).Diagram;
	}

	internal static object P0AooOxpXqmNdVGAhuY(object P_0, object P_1)
	{
		return ((BPMNFlowElement)P_0).GetSwimlane((Diagram)P_1);
	}

	internal static object NipdQHxCbTrght5i09n(object P_0)
	{
		return ((Element)P_0).Name;
	}

	internal static object hGUxl2xM6dccOfENVGi(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static bool HKIG80xkx9r2MfTFGeA(object P_0)
	{
		return string.IsNullOrWhiteSpace((string)P_0);
	}

	internal static object LScYr2xU70PoEqdELGb(object P_0, object P_1, object P_2)
	{
		return (string)P_0 + (string)P_1 + (string)P_2;
	}

	internal static object ePnbLFxVIxyKr0eU4CT(object P_0, object P_1, object P_2, object P_3)
	{
		return string.Format((string)P_0, P_1, P_2, P_3);
	}

	internal static object R9QuW1xAsx1USIFaTy1(object P_0, long P_1)
	{
		return ((WorkflowProcessManager<IWorkflowProcess>)P_0).LoadDraft(P_1);
	}

	internal static object J0bavqxGk2oJBwbH9v8(object P_0, long P_1)
	{
		return ((WorkflowProcessManager<IWorkflowProcess>)P_0).LoadScriptModuleForEdit(P_1);
	}

	internal static void kNex7fx7oPPnHmcK7c2(object P_0)
	{
		((Entity<long>)P_0).Save();
	}

	internal static long vD4cnwx2rpi9ra4bfQR(object P_0)
	{
		return ((Stream)P_0).Length;
	}

	internal static object C55RPxxol0WQjS1lvaE(object P_0)
	{
		return ((ITransformationProvider)P_0).Dialect;
	}
}
