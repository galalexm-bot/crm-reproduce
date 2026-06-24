using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Diagrams;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Security.DTO.Models;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Types.Settings;
using EleWise.ELMA.Services;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Connectors;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Events;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.SubProcess;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Swimlanes;
using EleWise.ELMA.Workflow.BPMN.Models;
using EleWise.ELMA.Workflow.Diagrams;
using EleWise.ELMA.Workflow.Extensions;
using EleWise.ELMA.Workflow.Managers;
using EleWise.ELMA.Workflow.Models;
using EleWise.ELMA.Workflow.Properties;
using Iesi.Collections.Generic;
using j3AmrhgkCleVTGdEwA;
using Nevron.Diagram;
using Nevron.Diagram.Extensions;
using Nevron.GraphicsCore;
using NHibernate;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.BPMN;

public class ProcessDocumentationGenerator
{
	private string fileName;

	private IWorkflowProcess workflowProcess;

	private string documentPath;

	private GenerationSettings settings;

	private bool subFolders;

	public static string OK;

	internal static ProcessDocumentationGenerator RK7MMCOUYWmxAyURJ4TA;

	public bool DoInThread
	{
		[CompilerGenerated]
		get
		{
			return _003CDoInThread_003Ek__BackingField;
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
					_003CDoInThread_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f870ea690334e7ab7599d275d195e9a != 0)
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

	public List<string> Files { get; set; }

	private void GenerateResponsobilityMatrix(StringBuilder sb, StringBuilder contentSb)
	{
		//Discarded unreachable code: IL_020e, IL_021d, IL_0228, IL_02ff, IL_030e, IL_031e, IL_0431, IL_04a0, IL_0518, IL_0527, IL_05b3, IL_05bd, IL_05cd, IL_069d, IL_06ac, IL_06bc, IL_06cb, IL_070e, IL_071d, IL_0a1c, IL_0a54, IL_0a63, IL_0ae7, IL_0b1f
		int num = 17;
		ISet<IResponsibilityMatrixItem> responsibilityMatrix = default(ISet<IResponsibilityMatrixItem>);
		IMetadataRuntimeService service = default(IMetadataRuntimeService);
		IBPMNProcess iBPMNProcess = default(IBPMNProcess);
		IEnumerator<IResponsibilityMatrixItem> enumerator = default(IEnumerator<IResponsibilityMatrixItem>);
		ResponsibilityLevel responsibilityLevel = default(ResponsibilityLevel);
		_003C_003Ec__DisplayClass6_0 _003C_003Ec__DisplayClass6_ = default(_003C_003Ec__DisplayClass6_0);
		Type entityType = default(Type);
		string text = default(string);
		SwimlaneElement swimlaneElement = default(SwimlaneElement);
		long? workerId2 = default(long?);
		long? workerId = default(long?);
		object obj = default(object);
		Guid? swimlaneUid2 = default(Guid?);
		IResponsibilityMatrixItem responsibilityMatrixItem = default(IResponsibilityMatrixItem);
		Guid? swimlaneUid = default(Guid?);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 3:
				case 4:
					sb.Append((string)PFcoqfOUm1pZWxIM41fi(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2077784392 ^ -2077904056), oX7yTZOUy4hUPq8qPy25(dI7lLfOU06WQgMvuCvVk(-106528299 ^ -106646487)), dI7lLfOU06WQgMvuCvVk(0x51EF0063 ^ 0x51ED3653)));
					num2 = 9;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1c37d4e24e094858975336738e156495 == 0)
					{
						num2 = 9;
					}
					continue;
				case 11:
					AddMainMenuItem(contentSb, (string)dI7lLfOU06WQgMvuCvVk(-14356676 ^ -14230896), SR.T((string)dI7lLfOU06WQgMvuCvVk(-2122743969 ^ -2122626335)));
					num2 = 4;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cfe4a54387d744988feba4889229faf1 == 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					if (oX00LLOUJXUr4FDZmJ40(responsibilityMatrix) <= 0)
					{
						num = 5;
						break;
					}
					service = Locator.GetService<IMetadataRuntimeService>();
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f19dffab164a41148300de28b2deec39 == 0)
					{
						num2 = 1;
					}
					continue;
				case 7:
					ClK731OUtnLesg1htdrn(sb, HTMLUtility.InsertRowToTable(new string[5]
					{
						(string)oX7yTZOUy4hUPq8qPy25(dI7lLfOU06WQgMvuCvVk(-1638225214 ^ -1638357630)),
						(string)AUVWdmOUbF9nnLmOHnrU(ResponsibilityLevel.Owner),
						(string)AUVWdmOUbF9nnLmOHnrU(ResponsibilityLevel.Member),
						ResponsibilityLevel.Inform.GetDisplayName(),
						(string)oX7yTZOUy4hUPq8qPy25(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x651FE29D ^ 0x651FD309))
					}, isBold: true, null));
					num = 12;
					break;
				case 13:
					if (iBPMNProcess.ResponsibilityMatrix == null)
					{
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d843b0b7f23e489fb6d586d64b0a634a == 0)
						{
							num2 = 0;
						}
					}
					else
					{
						responsibilityMatrix = iBPMNProcess.ResponsibilityMatrix;
						num2 = 2;
					}
					continue;
				case 9:
					ClK731OUtnLesg1htdrn(sb, dI7lLfOU06WQgMvuCvVk(-1716458555 ^ -1716331091));
					num2 = 7;
					continue;
				case 8:
					return;
				case 17:
					iBPMNProcess = workflowProcess as IBPMNProcess;
					num2 = 16;
					continue;
				case 15:
					try
					{
						while (true)
						{
							IL_0682:
							int num3;
							if (!bywb0bOUL1GGqXZhTSj4(enumerator))
							{
								num3 = 18;
								goto IL_022c;
							}
							goto IL_03a0;
							IL_022c:
							while (true)
							{
								switch (num3)
								{
								case 8:
								case 17:
								case 20:
									responsibilityLevel = _003C_003Ec__DisplayClass6_.respMatrixItem.ResponsibilityLevel;
									num3 = 38;
									continue;
								case 1:
									entityType = H2jlV0OUBCwB2dENQItR(service, _003C_003Ec__DisplayClass6_.respMatrixItem.WorkerType, true);
									num3 = 40;
									continue;
								case 10:
									text = (string)PLVg7qOUdIGTNfN9TB6y(Pf4vfEOUDatn3NOrsTS9(swimlaneElement));
									num3 = 17;
									continue;
								case 4:
									text = (string)jiTtLoOUXRLcJWtYZ8a1(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1393899982 ^ -1394020182), oX7yTZOUy4hUPq8qPy25(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-106528299 ^ -106645645)));
									num3 = 12;
									continue;
								case 5:
									break;
								case 15:
								case 16:
								case 26:
									goto IL_03c7;
								case 2:
									if (workerId2 != workerId)
									{
										num3 = 15;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_558b46b4f4364838b08ac89d77f9a257 != 0)
										{
											num3 = 0;
										}
										continue;
									}
									goto IL_0682;
								case 24:
									obj = ylxc1oOUcJOKflHcoqnS(EntityHelper.GetEntityManager(entityType), _003C_003Ec__DisplayClass6_.respMatrixItem.WorkerId);
									num3 = 42;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_fb347e2c5dba4e0ca4d47098be7fd10c == 0)
									{
										num3 = 19;
									}
									continue;
								case 6:
									if (workerId.HasValue)
									{
										num3 = 24;
										continue;
									}
									goto case 42;
								case 12:
									if (obj == null)
									{
										num3 = 27;
										continue;
									}
									goto case 29;
								case 9:
									if (swimlaneElement == null)
									{
										num3 = 9;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6dd19c81ff5e41fb8db9b50574437301 == 0)
										{
											num3 = 20;
										}
										continue;
									}
									goto case 10;
								case 40:
									workerId = _003C_003Ec__DisplayClass6_.respMatrixItem.WorkerId;
									num3 = 6;
									continue;
								case 32:
									goto IL_04e3;
								case 3:
									swimlaneUid2 = responsibilityMatrixItem.SwimlaneUid;
									num3 = 36;
									continue;
								case 41:
									goto IL_0532;
								case 38:
									switch (responsibilityLevel)
									{
									case ResponsibilityLevel.Owner:
										goto IL_07c0;
									case ResponsibilityLevel.Member:
										goto IL_087d;
									case ResponsibilityLevel.Inform:
										goto IL_0934;
									}
									num3 = 23;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7ed81ca3cf804abbade4684f28f485d1 != 0)
									{
										num3 = 10;
									}
									continue;
								case 30:
									workerId2 = responsibilityMatrixItem.WorkerId;
									num3 = 39;
									continue;
								case 11:
									_003C_003Ec__DisplayClass6_.respMatrixItem = enumerator.Current;
									num3 = 28;
									continue;
								case 37:
									obj = null;
									num3 = 1;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b30151cb26574dfaa8f9d818b0352d3b == 0)
									{
										num3 = 0;
									}
									continue;
								case 29:
									if (swimlaneElement == null)
									{
										num3 = 22;
										continue;
									}
									goto case 25;
								case 13:
								case 22:
								case 27:
									if (obj == null)
									{
										num3 = 7;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a23e27b648a042f098a477c26c4beed1 != 0)
										{
											num3 = 9;
										}
										continue;
									}
									goto case 8;
								case 39:
									workerId = _003C_003Ec__DisplayClass6_.respMatrixItem.WorkerId;
									num3 = 1;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f870ea690334e7ab7599d275d195e9a != 0)
									{
										num3 = 2;
									}
									continue;
								case 28:
									if (responsibilityMatrixItem != null)
									{
										num3 = 1;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4459fbe344a947429d197733d274ef68 != 0)
										{
											num3 = 3;
										}
										continue;
									}
									goto IL_03c7;
								case 36:
									swimlaneUid = _003C_003Ec__DisplayClass6_.respMatrixItem.SwimlaneUid;
									num3 = 32;
									continue;
								case 7:
								case 19:
								case 21:
								case 23:
								case 34:
									goto IL_0682;
								case 42:
									swimlaneElement = ((IEnumerable)qcZXSvOUPntLFOy6myug(workflowProcess.Diagram)).OfType<SwimlaneElement>().FirstOrDefault(_003C_003Ec__DisplayClass6_._003CGenerateResponsobilityMatrix_003Eb__0);
									num3 = 4;
									continue;
								default:
									if (!F8dg7TOU5fruDbKlFbUk(JQ6ir1OUgIorSxVO877K(responsibilityMatrixItem), _003C_003Ec__DisplayClass6_.respMatrixItem.WorkerType))
									{
										num3 = 26;
										continue;
									}
									goto case 30;
								case 25:
									text = (string)xIvGXhOUuNrAQk0jhOoR(obj.ToString(), jiTtLoOUXRLcJWtYZ8a1(dI7lLfOU06WQgMvuCvVk(0x1145BED7 ^ 0x11478815), PLVg7qOUdIGTNfN9TB6y(swimlaneElement.Name)));
									num3 = 8;
									continue;
								case 31:
									goto IL_07a6;
								case 33:
									goto IL_07c0;
								case 35:
									goto IL_087d;
								case 14:
									goto IL_0934;
								case 18:
									goto end_IL_0682;
									IL_07c0:
									ClK731OUtnLesg1htdrn(sb, yvO4drOUHfuybdsvbHk1(new string[5]
									{
										text,
										OK,
										"",
										"",
										cjEK85OUnnMFMl3Rv5I3(_003C_003Ec__DisplayClass6_.respMatrixItem) ? OK : ""
									}, false, new string[5]
									{
										"",
										(string)dI7lLfOU06WQgMvuCvVk(0x157D5AF4 ^ 0x157F6C26),
										"",
										"",
										(string)dI7lLfOU06WQgMvuCvVk(--296112178 ^ 0x11A466E0)
									}));
									num3 = 34;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b74fcd91509d46c3a9661cffb0465df0 == 0)
									{
										num3 = 34;
									}
									continue;
									IL_0934:
									sb.Append((string)yvO4drOUHfuybdsvbHk1(new string[5]
									{
										text,
										"",
										"",
										OK,
										cjEK85OUnnMFMl3Rv5I3(_003C_003Ec__DisplayClass6_.respMatrixItem) ? OK : ""
									}, false, new string[5]
									{
										"",
										"",
										"",
										(string)dI7lLfOU06WQgMvuCvVk(0x350C0E8 ^ 0x352F63A),
										(string)dI7lLfOU06WQgMvuCvVk(-197778752 ^ -197913582)
									}));
									num3 = 19;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7d23dbc0284240b99ff34f0f55f345f6 == 0)
									{
										num3 = 21;
									}
									continue;
									IL_087d:
									sb.Append(HTMLUtility.InsertRowToTable(new string[5]
									{
										text,
										"",
										OK,
										"",
										_003C_003Ec__DisplayClass6_.respMatrixItem.IsCurator ? OK : ""
									}, isBold: false, new string[5]
									{
										"",
										"",
										(string)dI7lLfOU06WQgMvuCvVk(--1212129906 ^ 0x483D94A0),
										"",
										(string)dI7lLfOU06WQgMvuCvVk(-45832783 ^ -45706397)
									}));
									num3 = 7;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_71a41ac2fa884d27b721ae0509586eea == 0)
									{
										num3 = 5;
									}
									continue;
								}
								break;
								IL_04e3:
								if (swimlaneUid2.HasValue == swimlaneUid.HasValue)
								{
									if (!swimlaneUid2.HasValue)
									{
										num3 = 31;
										continue;
									}
									if (!F8dg7TOU5fruDbKlFbUk(swimlaneUid2.GetValueOrDefault(), swimlaneUid.GetValueOrDefault()))
									{
										goto IL_03c7;
									}
									goto IL_07a6;
								}
								num3 = 16;
								continue;
								IL_03c7:
								if (F8dg7TOU5fruDbKlFbUk(JQ6ir1OUgIorSxVO877K(_003C_003Ec__DisplayClass6_.respMatrixItem), Worker.Types.Property))
								{
									num3 = 19;
									continue;
								}
								goto IL_0532;
								IL_07a6:
								num3 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_75a2d0f780b04098ba855df5729e6c30 != 0)
								{
									num3 = 0;
								}
								continue;
								IL_0532:
								responsibilityMatrixItem = _003C_003Ec__DisplayClass6_.respMatrixItem;
								num3 = 1;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b30151cb26574dfaa8f9d818b0352d3b != 0)
								{
									num3 = 37;
								}
							}
							goto IL_03a0;
							IL_03a0:
							_003C_003Ec__DisplayClass6_ = new _003C_003Ec__DisplayClass6_0();
							num3 = 11;
							goto IL_022c;
							continue;
							end_IL_0682:
							break;
						}
					}
					finally
					{
						if (enumerator != null)
						{
							int num4 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a2041b18ca1f4a5cb8e5060163bfdb57 != 0)
							{
								num4 = 1;
							}
							while (true)
							{
								switch (num4)
								{
								case 1:
									AYnRdXOUfyyMwUNuUxpJ(enumerator);
									num4 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5816b3723c134946ad9294172266312e != 0)
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
					goto case 6;
				case 1:
					if (!LHBFprOUliQyCIRAWceE(settings))
					{
						num2 = 3;
						continue;
					}
					goto case 11;
				case 5:
					return;
				case 6:
					ClK731OUtnLesg1htdrn(sb, dI7lLfOU06WQgMvuCvVk(0xDF4D1F8 ^ 0xDF6E702));
					num2 = 8;
					continue;
				case 10:
					enumerator = ((IEnumerable<IResponsibilityMatrixItem>)responsibilityMatrix).GetEnumerator();
					num = 15;
					break;
				case 16:
					if (iBPMNProcess == null)
					{
						num2 = 14;
						continue;
					}
					goto case 13;
				case 0:
					return;
				case 14:
					return;
				case 12:
					responsibilityMatrixItem = null;
					num2 = 10;
					continue;
				}
				break;
			}
		}
	}

	private void GenerateContext(StringBuilder sb, StringBuilder contentSb)
	{
		//Discarded unreachable code: IL_0213, IL_0222, IL_022d, IL_02e2, IL_02f1, IL_02fc, IL_03ad, IL_03e5, IL_03f4, IL_0405, IL_0413, IL_04a2, IL_04d4, IL_050c, IL_051b, IL_05c0, IL_0615, IL_0645, IL_0685, IL_0694, IL_06a0, IL_06af, IL_06fc, IL_070f, IL_071e, IL_077f
		int num = 11;
		List<ProcessContext> list = default(List<ProcessContext>);
		List<ProcessContext>.Enumerator enumerator = default(List<ProcessContext>.Enumerator);
		bool flag = default(bool);
		ProcessContext current3 = default(ProcessContext);
		IEnumerator<EntityPropertyMetadata> enumerator2 = default(IEnumerator<EntityPropertyMetadata>);
		IEnumerator<TablePartMetadata> enumerator3 = default(IEnumerator<TablePartMetadata>);
		TablePartMetadata current2 = default(TablePartMetadata);
		EntityPropertyMetadata current = default(EntityPropertyMetadata);
		object obj = default(object);
		EntityMetadata entityMetadata = default(EntityMetadata);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 7:
					sb.Append((string)yvO4drOUHfuybdsvbHk1(new string[8]
					{
						(string)oX7yTZOUy4hUPq8qPy25(dI7lLfOU06WQgMvuCvVk(-768800937 ^ -768659439)),
						(string)oX7yTZOUy4hUPq8qPy25(dI7lLfOU06WQgMvuCvVk(-148495695 ^ -148630053)),
						(string)oX7yTZOUy4hUPq8qPy25(dI7lLfOU06WQgMvuCvVk(-14356676 ^ -14231366)),
						(string)oX7yTZOUy4hUPq8qPy25(dI7lLfOU06WQgMvuCvVk(-197778752 ^ -197913250)),
						(string)oX7yTZOUy4hUPq8qPy25(dI7lLfOU06WQgMvuCvVk(0x75BAD659 ^ 0x75B8E18F)),
						(string)oX7yTZOUy4hUPq8qPy25(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-683713632 ^ -683842638)),
						(string)oX7yTZOUy4hUPq8qPy25(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1574607501 ^ -1574478505)),
						(string)oX7yTZOUy4hUPq8qPy25(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1145BED7 ^ 0x114786EF))
					}, true, null));
					num2 = 6;
					continue;
				case 6:
					list = new List<ProcessContext>();
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a2041b18ca1f4a5cb8e5060163bfdb57 == 0)
					{
						num2 = 0;
					}
					continue;
				case 10:
					if (!settings.ContexOk)
					{
						num2 = 4;
						continue;
					}
					goto case 8;
				case 9:
					enumerator = list.GetEnumerator();
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f30401a2cff84771be092252e934fede == 0)
					{
						num2 = 0;
					}
					continue;
				case 8:
					AddMainMenuItem(contentSb, (string)dI7lLfOU06WQgMvuCvVk(0x17F0C5A2 ^ 0x17F0FA92), SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xDF4D1F8 ^ 0xDF53296)));
					num2 = 2;
					continue;
				case 3:
					ClK731OUtnLesg1htdrn(sb, dI7lLfOU06WQgMvuCvVk(-708128192 ^ -708254534));
					num2 = 12;
					continue;
				default:
					try
					{
						while (true)
						{
							IL_06ba:
							int num3;
							if (!enumerator.MoveNext())
							{
								num3 = 3;
								goto IL_0231;
							}
							goto IL_025b;
							IL_0231:
							while (true)
							{
								switch (num3)
								{
								case 6:
									break;
								case 4:
									flag = NM6VmHOUWgOl7FlcM8Ba(current3, VuBJ4YOU9ARFWyj1rngG(workflowProcess));
									num3 = 2;
									continue;
								case 2:
									enumerator2 = ((IEnumerable<EntityPropertyMetadata>)current3.EntityProperties).GetEnumerator();
									num3 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_de3723e1fdff427496b973d91a934ee2 == 0)
									{
										num3 = 0;
									}
									continue;
								case 1:
									enumerator3 = ((IEnumerable<TablePartMetadata>)current3.EntityTableParts).GetEnumerator();
									num3 = 5;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_43af423d081c48e3bc6cea30ce47523d != 0)
									{
										num3 = 0;
									}
									continue;
								case 5:
									try
									{
										while (true)
										{
											IL_0361:
											int num8;
											if (!bywb0bOUL1GGqXZhTSj4(enumerator3))
											{
												num8 = 2;
												if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_58fb165cafed422d973d4a7156526541 == 0)
												{
													num8 = 0;
												}
												goto IL_0300;
											}
											goto IL_031a;
											IL_031a:
											current2 = enumerator3.Current;
											num8 = 0;
											if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6e8c2dcf6eb644089ebbe42243c60e95 == 0)
											{
												num8 = 0;
											}
											goto IL_0300;
											IL_0300:
											while (true)
											{
												switch (num8)
												{
												case 1:
													break;
												default:
													GenerateTablePartRow(current2, sb, 0);
													num8 = 3;
													if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6782172e84504a7baf3163b8f6b2a916 != 0)
													{
														num8 = 1;
													}
													continue;
												case 3:
													goto IL_0361;
												case 2:
													goto end_IL_0361;
												}
												break;
											}
											goto IL_031a;
											continue;
											end_IL_0361:
											break;
										}
									}
									finally
									{
										if (enumerator3 != null)
										{
											int num9 = 0;
											if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3b4403f77a00495e957e5e4a6840e5d3 == 0)
											{
												num9 = 0;
											}
											while (true)
											{
												switch (num9)
												{
												default:
													AYnRdXOUfyyMwUNuUxpJ(enumerator3);
													num9 = 1;
													if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d2f119e188994b55be2499c193b880fb == 0)
													{
														num9 = 1;
													}
													continue;
												case 1:
													break;
												}
												break;
											}
										}
									}
									goto IL_06ba;
								default:
									try
									{
										while (true)
										{
											int num4;
											if (!bywb0bOUL1GGqXZhTSj4(enumerator2))
											{
												num4 = 1;
												if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_719514a5a8ae47ed84e5a777ead0dc9f == 0)
												{
													num4 = 0;
												}
												goto IL_0417;
											}
											goto IL_05ed;
											IL_05ed:
											current = enumerator2.Current;
											num4 = 3;
											if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6f64eb224ece438ba2f0bbd2f29cebfd == 0)
											{
												num4 = 3;
											}
											goto IL_0417;
											IL_0417:
											while (true)
											{
												switch (num4)
												{
												case 4:
												case 10:
													break;
												case 3:
													try
													{
														obj = TMQu7QOURvhFO1eEnb59(yLU0UiOUjEavxSYbldBU(current), true, true);
														int num5 = 0;
														if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_18b351a59a324c25b4f150a9771bcf69 == 0)
														{
															num5 = 0;
														}
														switch (num5)
														{
														case 0:
															break;
														}
													}
													catch
													{
														int num6 = 1;
														if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a2041b18ca1f4a5cb8e5060163bfdb57 == 0)
														{
															num6 = 0;
														}
														while (true)
														{
															switch (num6)
															{
															case 1:
																obj = null;
																num6 = 0;
																if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c559093b7320494babd70d164a6df42d == 0)
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
													goto case 2;
												default:
													if (entityMetadata == null)
													{
														num4 = 7;
														continue;
													}
													goto case 8;
												case 11:
													if (QLKUT7OU6CywWeSa8Njo(entityMetadata.TypeName, dI7lLfOU06WQgMvuCvVk(0xB7793C9 ^ 0xB77CB63)))
													{
														num4 = 6;
														continue;
													}
													break;
												case 8:
													if (!flag)
													{
														num4 = 9;
														if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4cc62744d0eb4cd68219b70dcad3e68e == 0)
														{
															num4 = 11;
														}
														continue;
													}
													goto case 6;
												case 5:
												case 7:
													GenerateEntityPropertyRow(current, sb, 0);
													num4 = 10;
													continue;
												case 6:
													GenerateEntityPropertyRow(current, sb, 0);
													num4 = 4;
													if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_938c6be4ea2248868d7ed5d0e3346006 == 0)
													{
														num4 = 0;
													}
													continue;
												case 2:
													entityMetadata = obj as EntityMetadata;
													num4 = 0;
													if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f91acf223c4b4303819d2f8f2fc6c8e1 != 0)
													{
														num4 = 0;
													}
													continue;
												case 9:
													goto IL_05ed;
												case 1:
													goto end_IL_0451;
												}
												break;
											}
											continue;
											end_IL_0451:
											break;
										}
									}
									finally
									{
										int num7;
										if (enumerator2 == null)
										{
											num7 = 1;
											if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_69cb4a76addb44f28bb765f059e441c7 == 0)
											{
												num7 = 1;
											}
											goto IL_0649;
										}
										goto IL_065f;
										IL_065f:
										AYnRdXOUfyyMwUNuUxpJ(enumerator2);
										num7 = 1;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e632863bfb124ba083e3ba9b363fd70e != 0)
										{
											num7 = 2;
										}
										goto IL_0649;
										IL_0649:
										switch (num7)
										{
										case 1:
											goto end_IL_0624;
										case 2:
											goto end_IL_0624;
										}
										goto IL_065f;
										end_IL_0624:;
									}
									goto case 1;
								case 7:
									goto IL_06ba;
								case 3:
									goto end_IL_06ba;
								}
								break;
							}
							goto IL_025b;
							IL_025b:
							current3 = enumerator.Current;
							num3 = 4;
							goto IL_0231;
							continue;
							end_IL_06ba:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator).Dispose();
						int num10 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d087ae72a2134de08266411226c5f060 != 0)
						{
							num10 = 0;
						}
						switch (num10)
						{
						case 0:
							break;
						}
					}
					goto case 3;
				case 11:
					if (VuBJ4YOU9ARFWyj1rngG(workflowProcess) != null)
					{
						num2 = 10;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4cc62744d0eb4cd68219b70dcad3e68e != 0)
						{
							num2 = 3;
						}
						continue;
					}
					return;
				case 5:
					break;
				case 12:
					return;
				case 2:
				case 4:
					ClK731OUtnLesg1htdrn(sb, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x350C0E8 ^ 0x352F518) + SR.T((string)dI7lLfOU06WQgMvuCvVk(0x628167BE ^ 0x628084D0)) + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1516552726 ^ -1516696838));
					num2 = 5;
					continue;
				case 1:
					ProcessDocumentationHelper.GetParentsContext(workflowProcess, list, thisContext: true);
					num2 = 9;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0fbdcdb2cea84e8d8852886ebe735d8f == 0)
					{
						num2 = 5;
					}
					continue;
				}
				break;
			}
			ClK731OUtnLesg1htdrn(sb, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6A69C5CD ^ 0x6A6BF3A5));
			num = 7;
		}
	}

	private void GenerateEntityPropertyRow(EntityPropertyMetadata property, StringBuilder sb, int paddingLeft)
	{
		//Discarded unreachable code: IL_0095, IL_00f0, IL_011f, IL_0151, IL_01c9
		int num = 6;
		int num2 = num;
		string text3 = default(string);
		string text2 = default(string);
		ITypeDescriptor typeDescriptor = default(ITypeDescriptor);
		string text = default(string);
		while (true)
		{
			object obj;
			switch (num2)
			{
			case 1:
				text3 = string.Format((string)dI7lLfOU06WQgMvuCvVk(-29981480 ^ -30098258), text2);
				num2 = 9;
				break;
			case 6:
				typeDescriptor = (ITypeDescriptor)M19phXOU35AGJK5PAvoY(Locator.GetServiceNotNull<IMetadataRuntimeService>(), EXANBJOUq8y8CPg3xXqk(property), property.SubTypeUid);
				num2 = 5;
				break;
			case 3:
				return;
			case 4:
				if (typeDescriptor is IPropertyTypeInfo)
				{
					num2 = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_eef7d2ca1c3c4b74aeb81172ed542639 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 7;
			case 7:
				if (paddingLeft > 0)
				{
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a23e27b648a042f098a477c26c4beed1 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 8;
			case 8:
				obj = "";
				goto IL_0206;
			case 2:
				try
				{
					text = (string)HgRnvwOUQcwyfmoTpVL2((IPropertyTypeInfo)typeDescriptor, property);
					int num3 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bd84f42638494cb6b4427f8e13ec59af != 0)
					{
						num3 = 0;
					}
					switch (num3)
					{
					case 0:
						break;
					}
				}
				catch
				{
					int num4 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_39af03d004af472bb66e60f46e79703a == 0)
					{
						num4 = 0;
					}
					while (true)
					{
						switch (num4)
						{
						default:
							text = (string)PFcoqfOUm1pZWxIM41fi(dI7lLfOU06WQgMvuCvVk(-1965291699 ^ -1965197461), oX7yTZOUy4hUPq8qPy25(dI7lLfOU06WQgMvuCvVk(0x1843E01F ^ 0x1841D6B9)), dI7lLfOU06WQgMvuCvVk(-1498811449 ^ -1498840049));
							num4 = 1;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3b4403f77a00495e957e5e4a6840e5d3 != 0)
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
				goto case 7;
			case 5:
				text = (string)tVI60qOUTioYETFCiYWO(typeDescriptor);
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a50dda04dedf4515816f963c67783c8f == 0)
				{
					num2 = 4;
				}
				break;
			default:
				obj = dI7lLfOU06WQgMvuCvVk(0x1843E01F ^ 0x1841D853);
				goto IL_0206;
			case 9:
				{
					sb.Append((string)yvO4drOUHfuybdsvbHk1(new string[8]
					{
						(string)oUEWPaOUki4x2khEd4qP(dI7lLfOU06WQgMvuCvVk(0x69063C81 ^ 0x69040425), OVWP4dOUCRQrwmGQ2TPe(ex6B4YOUpp4ZIC4kvvpc(property).ToString(), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6A69C5CD ^ 0x6A6BF5CF), ""), anbHIGOUMdIO2lvFMMS7(property)),
						(string)l0fMBlOUU0K8cDdLCWmi(property),
						text,
						(string)(F7WOM8OUVkSCAdqAfDCv(property) ? OK : dI7lLfOU06WQgMvuCvVk(-1108877388 ^ -1109006490)),
						(string)(property.Filterable ? OK : dI7lLfOU06WQgMvuCvVk(-17847711 ^ -17984845)),
						(string)(kAlU2JOUAv1d4XyP53xU(property) ? OK : dI7lLfOU06WQgMvuCvVk(0x75BAD659 ^ 0x75B8EE8B)),
						(string)(QysBBHOUGNu2pJLVeIGI(property) ? OK : dI7lLfOU06WQgMvuCvVk(-980570076 ^ -980449034)),
						(string)XBWaqvOU7DZYw4J3qXZy(property)
					}, false, new string[8]
					{
						(string)((paddingLeft > 0) ? jiTtLoOUXRLcJWtYZ8a1(dI7lLfOU06WQgMvuCvVk(0x1C7F6FED ^ 0x1C7D570D), paddingLeft) : ""),
						(string)((paddingLeft > 0) ? jiTtLoOUXRLcJWtYZ8a1(dI7lLfOU06WQgMvuCvVk(0x69063C81 ^ 0x69040461), paddingLeft) : ""),
						text2,
						text3,
						text3,
						text3,
						text3,
						text2
					}));
					num2 = 3;
					break;
				}
				IL_0206:
				text2 = (string)obj;
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_43af423d081c48e3bc6cea30ce47523d == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	private void GenerateTablePartRow(TablePartMetadata part, StringBuilder sb, int paddingLeft)
	{
		//Discarded unreachable code: IL_00a9, IL_00db, IL_00ea, IL_0126, IL_0135, IL_01a3, IL_01ad, IL_0251, IL_0291, IL_02a0, IL_02ac, IL_02bb
		int num = 2;
		IEnumerator<TablePartMetadata> enumerator = default(IEnumerator<TablePartMetadata>);
		string text2 = default(string);
		string text = default(string);
		int num3 = default(int);
		TablePartMetadata current = default(TablePartMetadata);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 8:
					enumerator = ((IEnumerable<TablePartMetadata>)part.EntityTableParts).GetEnumerator();
					num2 = 7;
					break;
				default:
					ClK731OUtnLesg1htdrn(sb, dI7lLfOU06WQgMvuCvVk(-1214182792 ^ -1214041304));
					num2 = 10;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b84ccb8b1bd147ef900b852047ecbf45 != 0)
					{
						num2 = 8;
					}
					break;
				case 1:
					text2 = string.Format((string)dI7lLfOU06WQgMvuCvVk(0x8D5763A ^ 0x8D74E4C), text);
					num2 = 9;
					break;
				case 11:
				case 13:
					if (num3 < wR6p6COUiodd1SfxSQdY(part.EntityProperties))
					{
						num2 = 4;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f30401a2cff84771be092252e934fede != 0)
						{
							num2 = 12;
						}
						break;
					}
					goto case 8;
				case 12:
				case 15:
					GenerateEntityPropertyRow(((IEnumerable<EntityPropertyMetadata>)part.EntityProperties).ElementAt(num3), sb, paddingLeft + 20);
					num2 = 4;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_db8eb3e90ad546d4b05544ab6326a49f == 0)
					{
						num2 = 4;
					}
					break;
				case 3:
					if (wR6p6COUiodd1SfxSQdY(part.EntityProperties) > 0)
					{
						num2 = 4;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d087ae72a2134de08266411226c5f060 == 0)
						{
							num2 = 5;
						}
						break;
					}
					goto case 6;
				case 7:
					try
					{
						while (true)
						{
							IL_01ee:
							int num4;
							if (!bywb0bOUL1GGqXZhTSj4(enumerator))
							{
								num4 = 3;
								goto IL_01b1;
							}
							goto IL_01cb;
							IL_01b1:
							while (true)
							{
								switch (num4)
								{
								case 2:
									break;
								case 1:
									goto IL_01ee;
								default:
									GenerateTablePartRow(current, sb, paddingLeft + 20);
									num4 = 1;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a2041b18ca1f4a5cb8e5060163bfdb57 == 0)
									{
										num4 = 1;
									}
									continue;
								case 3:
									goto end_IL_01ee;
								}
								break;
							}
							goto IL_01cb;
							IL_01cb:
							current = enumerator.Current;
							num4 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_eef7d2ca1c3c4b74aeb81172ed542639 == 0)
							{
								num4 = 0;
							}
							goto IL_01b1;
							continue;
							end_IL_01ee:
							break;
						}
					}
					finally
					{
						int num5;
						if (enumerator == null)
						{
							num5 = 1;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a9be7e056b4e4b6e863b634c418144f1 != 0)
							{
								num5 = 2;
							}
							goto IL_0255;
						}
						goto IL_026b;
						IL_026b:
						enumerator.Dispose();
						num5 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d087ae72a2134de08266411226c5f060 == 0)
						{
							num5 = 0;
						}
						goto IL_0255;
						IL_0255:
						switch (num5)
						{
						default:
							goto end_IL_0230;
						case 1:
							break;
						case 2:
							goto end_IL_0230;
						case 0:
							goto end_IL_0230;
						}
						goto IL_026b;
						end_IL_0230:;
					}
					goto default;
				case 6:
					if (((ICollection<TablePartMetadata>)part.EntityTableParts).Count <= 0)
					{
						return;
					}
					goto end_IL_0012;
				case 5:
				case 14:
					num3 = 2;
					num2 = 13;
					break;
				case 10:
					return;
				case 4:
					num3++;
					num2 = 11;
					break;
				case 2:
					text = (string)dI7lLfOU06WQgMvuCvVk(0x70EBB9F3 ^ 0x70E981BF);
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ffb1346d351f436b84bb1e9954c3bfa8 == 0)
					{
						num2 = 1;
					}
					break;
				case 9:
					ClK731OUtnLesg1htdrn(sb, yvO4drOUHfuybdsvbHk1(new string[8]
					{
						(string)oUEWPaOUki4x2khEd4qP(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1C663DA1 ^ 0x1C640505), ex6B4YOUpp4ZIC4kvvpc(part).ToString().Replace((string)dI7lLfOU06WQgMvuCvVk(--296112178 ^ 0x11A46030), ""), anbHIGOUMdIO2lvFMMS7(part)),
						(string)U8UZjhOU29YpFRPG95Mj(part),
						(string)((!string.IsNullOrWhiteSpace((string)l0fMBlOUU0K8cDdLCWmi(part))) ? UKbvEQOUoDSN2TaTBY4s(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-39189604 ^ -39306588), new object[1] { l0fMBlOUU0K8cDdLCWmi(part) }) : SR.T((string)dI7lLfOU06WQgMvuCvVk(0xA7339EE ^ 0xA7100C2))),
						(string)dI7lLfOU06WQgMvuCvVk(-768800937 ^ -768655483),
						(string)dI7lLfOU06WQgMvuCvVk(0x5DB28AD2 ^ 0x5DB0B200),
						(string)(part.Input ? OK : dI7lLfOU06WQgMvuCvVk(-29981480 ^ -30098422)),
						Fvqkc7OUFqaxNVAn5LQC(part) ? OK : SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x42311138 ^ 0x423329EA),
						part.Description
					}, false, new string[8]
					{
						(string)((paddingLeft > 0) ? jiTtLoOUXRLcJWtYZ8a1(dI7lLfOU06WQgMvuCvVk(0x1927DA93 ^ 0x1925E273), paddingLeft) : text),
						(string)((paddingLeft > 0) ? jiTtLoOUXRLcJWtYZ8a1(dI7lLfOU06WQgMvuCvVk(-949717965 ^ -949596973), paddingLeft) : text),
						text,
						text2,
						text2,
						text2,
						text2,
						text
					}));
					num2 = 3;
					break;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 14;
		}
	}

	private void GenerateScript(StringBuilder sb, StringBuilder contentSb)
	{
		//Discarded unreachable code: IL_00fb, IL_010a, IL_0141, IL_0150, IL_0179, IL_0199, IL_01a8, IL_024b, IL_03de, IL_042c, IL_0479, IL_0488
		int num = 3;
		IEnumerator enumerator = default(IEnumerator);
		string text = default(string);
		int num6 = default(int);
		string text2 = default(string);
		int num7 = default(int);
		Match match = default(Match);
		int num9 = default(int);
		string text4 = default(string);
		MatchCollection matchCollection = default(MatchCollection);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 6:
					ClK731OUtnLesg1htdrn(sb, dI7lLfOU06WQgMvuCvVk(0x5F534A5C ^ 0x5F51777A));
					num2 = 9;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_639c11c7bb65456db9f29c9c42f28bf7 == 0)
					{
						num2 = 9;
					}
					continue;
				case 5:
					goto end_IL_0012;
				case 3:
					if (workflowProcess.Context == null)
					{
						num2 = 2;
						continue;
					}
					goto case 1;
				case 13:
					ClK731OUtnLesg1htdrn(sb, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x747FFBE0 ^ 0x747DC6A4));
					num2 = 8;
					continue;
				case 2:
					return;
				case 15:
					ClK731OUtnLesg1htdrn(sb, dI7lLfOU06WQgMvuCvVk(-980570076 ^ -980675536));
					num2 = 13;
					continue;
				case 16:
					return;
				case 4:
					try
					{
						int num3 = 0;
						int num4 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b30151cb26574dfaa8f9d818b0352d3b != 0)
						{
							num4 = 1;
						}
						while (true)
						{
							switch (num4)
							{
							default:
								try
								{
									while (true)
									{
										IL_0255:
										int num5;
										if (!enumerator.MoveNext())
										{
											num5 = 6;
											goto IL_01b7;
										}
										goto IL_0208;
										IL_01b7:
										while (true)
										{
											switch (num5)
											{
											case 9:
												text = (string)HeVqrmOUwdsUDCjPSmXT(text, num6, text2);
												num5 = 2;
												continue;
											case 1:
												break;
											case 3:
												num7 = match.Index + num3;
												num5 = 11;
												continue;
											case 5:
											case 10:
												goto IL_0255;
											case 4:
											{
												string text3 = text.Substring(num6, num9 - num6 - 1);
												text4 = (string)PLVg7qOUdIGTNfN9TB6y(text3.Substring(w1HK49OUhyaLECAmuPQb(text3, ' ')));
												num5 = 8;
												continue;
											}
											case 7:
												num9 = oclssGOU1kVEcrYBwqRX(text, '(', num7);
												num5 = 4;
												if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_abfb511163674a3eae959fd60da8f319 != 0)
												{
													num5 = 3;
												}
												continue;
											case 8:
												text2 = (string)iewM7pOUEDldMGRIExqa(PFcoqfOUm1pZWxIM41fi(dI7lLfOU06WQgMvuCvVk(0x8D5763A ^ 0x8D74C96), text4, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-29981480 ^ -30097894)), Array.Empty<object>());
												num5 = 3;
												if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5d3bc916b5664717ac60544de077bd16 == 0)
												{
													num5 = 9;
												}
												continue;
											default:
												if (match == null)
												{
													num5 = 5;
													continue;
												}
												goto case 3;
											case 11:
											{
												num6 = Onhm7COUSvON2n2CpCF4(text, ' ', num7);
												int num8 = 7;
												num5 = num8;
												continue;
											}
											case 2:
												num3 += text2.Length;
												num5 = 10;
												if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3f508947b0d94af1961e5aa17a8a2044 != 0)
												{
													num5 = 7;
												}
												continue;
											case 6:
												goto end_IL_0255;
											}
											break;
										}
										goto IL_0208;
										IL_0208:
										match = O6o5vXOUxgfsCpDoD8O0(enumerator) as Match;
										num5 = 0;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f453500aaab143479696408f48a03c17 != 0)
										{
											num5 = 0;
										}
										goto IL_01b7;
										continue;
										end_IL_0255:
										break;
									}
								}
								finally
								{
									IDisposable disposable = enumerator as IDisposable;
									int num10 = 1;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_9269d021c6f148b6a1c4afb8cee03b6c != 0)
									{
										num10 = 1;
									}
									while (true)
									{
										switch (num10)
										{
										case 2:
											AYnRdXOUfyyMwUNuUxpJ(disposable);
											num10 = 0;
											if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1de08766357542bdb81146373079f817 == 0)
											{
												num10 = 0;
											}
											continue;
										case 1:
											if (disposable != null)
											{
												int num11 = 2;
												num10 = num11;
												continue;
											}
											break;
										case 0:
											break;
										}
										break;
									}
								}
								break;
							case 1:
								enumerator = matchCollection.GetEnumerator();
								num4 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f236c3d0fade492db73e8204df65377d == 0)
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
						int num12 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1733a11cae754a598119b94f8d9e4971 == 0)
						{
							num12 = 0;
						}
						while (true)
						{
							switch (num12)
							{
							default:
								jn3PmvOUzftQ1pdyC3ZY(Logger.Log, ex, SfplsROU4p36gvFJ4x3u(ex), Array.Empty<object>());
								num12 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6782172e84504a7baf3163b8f6b2a916 == 0)
								{
									num12 = 1;
								}
								continue;
							case 1:
								break;
							}
							break;
						}
					}
					goto default;
				case 11:
					sb.Append(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4943E3E4 ^ 0x4941D614) + (string)oX7yTZOUy4hUPq8qPy25(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6871CA ^ 0x6A48B2)) + (string)dI7lLfOU06WQgMvuCvVk(-398691253 ^ -398570041));
					num2 = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5c45a6e5a4614bfba7591d8a1c7ced1d == 0)
					{
						num2 = 5;
					}
					continue;
				case 7:
					ClK731OUtnLesg1htdrn(sb, dI7lLfOU06WQgMvuCvVk(0x37E97159 ^ 0x37EB4A87));
					num2 = 6;
					continue;
				case 1:
					if (o9FJ9QOUrYEypCOPn8yJ(WjrnBYOUaeOJmBlTIweM(rkilE2OUIyEZEIoBHlI8(workflowProcess))))
					{
						num2 = 16;
						continue;
					}
					break;
				case 12:
					if (QbKftSOUNla9tlXNyslB(matchCollection) > 0)
					{
						num2 = 4;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6d48f3b4557a49578bf7f5ef0517e0be == 0)
						{
							num2 = 4;
						}
						continue;
					}
					goto default;
				case 8:
					return;
				case 14:
					ClK731OUtnLesg1htdrn(sb, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1050383744 ^ -1050257484));
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5537a063960e465db83a04e35eea441b != 0)
					{
						num2 = 15;
					}
					continue;
				case 10:
					matchCollection = (MatchCollection)tyXqmHOUebdwBbeb8UXE(text, dI7lLfOU06WQgMvuCvVk(-865213812 ^ -865084596), RegexOptions.IgnoreCase);
					num2 = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6dd19c81ff5e41fb8db9b50574437301 == 0)
					{
						num2 = 12;
					}
					continue;
				case 9:
					ClK731OUtnLesg1htdrn(sb, text);
					num2 = 14;
					continue;
				default:
					ClK731OUtnLesg1htdrn(sb, dI7lLfOU06WQgMvuCvVk(-135674354 ^ -135529088));
					num2 = 4;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b876fa7b083748c8abf8c4b192a11078 != 0)
					{
						num2 = 7;
					}
					continue;
				case 17:
					break;
				}
				AddMainMenuItem(contentSb, (string)dI7lLfOU06WQgMvuCvVk(0x614274E3 ^ 0x61404D8B), (string)oX7yTZOUy4hUPq8qPy25(dI7lLfOU06WQgMvuCvVk(0x4943E3E4 ^ 0x4941DA9C)));
				num2 = 11;
				continue;
				end_IL_0012:
				break;
			}
			text = (string)WjrnBYOUaeOJmBlTIweM(rkilE2OUIyEZEIoBHlI8(workflowProcess));
			num = 10;
		}
	}

	private static void SaveFile(object path, object fileName, object text)
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
			{
				StreamWriter streamWriter = new StreamWriter((string)gp6m6mOVKML7jd4leSFT(path, fileName));
				MwW43fOVO0LI66c3Pw73(streamWriter, text);
				jZqEYhOVZIunubwsvPpF(streamWriter);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_639c11c7bb65456db9f29c9c42f28bf7 == 0)
				{
					num2 = 0;
				}
				break;
			}
			}
		}
	}

	private void AddActivityImages(string path, StringBuilder mapString, Element element, Point startPoint, Dictionary<string, StringBuilder> chaptersContent, Dictionary<string, StringBuilder> chaptersDescription)
	{
		if (element is BPMNFlowElement)
		{
			BPMNFlowElement bPMNFlowElement = element as BPMNFlowElement;
			Rectangle rectangle = new Rectangle((int)bPMNFlowElement.Location.X - startPoint.X, (int)bPMNFlowElement.Location.Y - startPoint.Y, (int)bPMNFlowElement.Size.Width, (int)bPMNFlowElement.Size.Height);
			mapString.Insert(0, string.Concat(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-862330810 ^ -862200546), rectangle.Left, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1050383744 ^ -1050349438), rectangle.Top, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1134D2C0 ^ 0x113448C2), rectangle.Right, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x651FE29D ^ 0x651F789F), rectangle.Bottom, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x13F63440 ^ 0x13F409D2), (bPMNFlowElement.Name.Trim() == "") ? bPMNFlowElement.DefaultName : bPMNFlowElement.Name, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6871CA ^ 0x6A4C62), bPMNFlowElement.Uid, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x438A0E43 ^ 0x438821B9)));
		}
		if (element is SwimlaneElement)
		{
			if (!chaptersDescription.ContainsKey(SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1430645277 ^ -1430771673))))
			{
				chaptersDescription.Add(SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1716629332 ^ -1716753048)), new StringBuilder());
			}
			GetDescSwimLane(element as SwimlaneElement, chaptersDescription[SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-39189604 ^ -39305640))]);
		}
		if (!(element is IDocumentable))
		{
			return;
		}
		IDocumentable documentable = element as IDocumentable;
		if (documentable.ChapterName == null)
		{
			return;
		}
		if (!chaptersContent.ContainsKey(documentable.ChapterName))
		{
			chaptersContent.Add(documentable.ChapterName, new StringBuilder());
		}
		if (!chaptersDescription.ContainsKey(documentable.ChapterName))
		{
			chaptersDescription.Add(documentable.ChapterName, new StringBuilder());
		}
		string nameLink = (string.IsNullOrWhiteSpace(documentable.Name) ? element.DefaultName : documentable.Name);
		string text = element.Uid.ToString();
		Bitmap bitmap = documentable.GetBitmap(workflowProcess.Diagram, element.Shape);
		string text2 = HTMLUtility.MakeValidFileName(element.Uid.ToString());
		bitmap.Save(Path.Combine(path, text2 + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-43932417 ^ -43804401)), ImageFormat.Png);
		AddFileWithCheck(Path.Combine(path, text2));
		chaptersDescription[documentable.ChapterName].Append(documentable.HtmlHeader(workflowProcess.Context, (int)OrganizationItemManager.Instance.Count(), subFolders, workflowProcess.Diagram, settings));
		List<ProcessContext> contexts = new List<ProcessContext>();
		ProcessDocumentationHelper.GetParentsContext(workflowProcess, contexts, thisContext: true);
		chaptersDescription[documentable.ChapterName].Append(documentable.HtmlBody(element, contexts, (int)OrganizationItemManager.Instance.Count(), subFolders, workflowProcess.Diagram, workflowProcess, settings));
		chaptersDescription[documentable.ChapterName].Append(documentable.HtmlFooter());
		if (documentable is InternalSubprocessElement internalSubprocessElement)
		{
			if (settings.SubProcessOk)
			{
				IProcessHeader processHeader = ProcessHeaderManager.Instance.LoadOrNull(internalSubprocessElement.ProcessHeaderId);
				if (processHeader != null)
				{
					string text3 = SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-106528299 ^ -106644439) + processHeader.Current.Uid.ToString() + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-360662087 ^ -360544851) + SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-10408775 ^ -10284405)) + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-495296780 ^ -495191344);
					chaptersContent[documentable.ChapterName].Append(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-106528299 ^ -106643555) + HTMLUtility.InsertHyperLink(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-949717965 ^ -949697875) + text, nameLink) + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-63028171 ^ -62968613) + text3 + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6F6D7B44 ^ 0x6F6F4850));
				}
			}
			else
			{
				chaptersContent[documentable.ChapterName].Append(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1134D2C0 ^ 0x1136EC88) + HTMLUtility.InsertHyperLink(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1712492721 ^ -1712465455) + text, nameLink) + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-949717965 ^ -949598425));
			}
		}
		else
		{
			chaptersContent[documentable.ChapterName].Append(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-801808857 ^ -801677201) + HTMLUtility.InsertHyperLink(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1516552726 ^ -1516532876) + text, nameLink) + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x361628FF ^ 0x36141BEB));
		}
		chaptersDescription[documentable.ChapterName].Append(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-980570076 ^ -980447570) + HTMLUtility.InsertHyperLink(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1776305410 ^ -1776450454), SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x101D10F ^ 0x103EFAB))) + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1436248540 ^ 0x55995732));
	}

	private void GenerateConnectorsDocs(StringBuilder linkString, StringBuilder mapString, Element element, Point startPoint, StringBuilder contentSb)
	{
		//Discarded unreachable code: IL_004a, IL_0059, IL_0064, IL_0107, IL_0147, IL_0156, IL_0162, IL_0171, IL_01be
		int num = 8;
		IEnumerator<Element> enumerator = default(IEnumerator<Element>);
		Element current = default(Element);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					try
					{
						while (true)
						{
							IL_00cb:
							int num3;
							if (!bywb0bOUL1GGqXZhTSj4(enumerator))
							{
								num3 = 3;
								goto IL_0068;
							}
							goto IL_0082;
							IL_0068:
							while (true)
							{
								switch (num3)
								{
								case 1:
									break;
								default:
									AddConnectorsImages(linkString, mapString, current, startPoint);
									num3 = 2;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a680afde07ce4ae5b71c411a1f75109b == 0)
									{
										num3 = 2;
									}
									continue;
								case 2:
									goto IL_00cb;
								case 3:
									goto end_IL_00cb;
								}
								break;
							}
							goto IL_0082;
							IL_0082:
							current = enumerator.Current;
							num3 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f30401a2cff84771be092252e934fede != 0)
							{
								num3 = 0;
							}
							goto IL_0068;
							continue;
							end_IL_00cb:
							break;
						}
					}
					finally
					{
						int num4;
						if (enumerator == null)
						{
							num4 = 1;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d7a51cf2841b436998bf3f4157fb2c9a != 0)
							{
								num4 = 0;
							}
							goto IL_010b;
						}
						goto IL_0121;
						IL_0121:
						AYnRdXOUfyyMwUNuUxpJ(enumerator);
						num4 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_08023922bb0e4e809e5cff73a2b04988 != 0)
						{
							num4 = 2;
						}
						goto IL_010b;
						IL_010b:
						switch (num4)
						{
						case 1:
							goto end_IL_00e6;
						case 2:
							goto end_IL_00e6;
						}
						goto IL_0121;
						end_IL_00e6:;
					}
					goto case 6;
				case 8:
					if (!gNSKsCOVv1bLNY7okLMh(settings))
					{
						num2 = 7;
						continue;
					}
					goto case 4;
				case 6:
					linkString.Append(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1436248540 ^ 0x55995498));
					num2 = 2;
					continue;
				case 2:
					return;
				case 9:
					break;
				case 1:
				case 7:
					linkString.Append((string)PFcoqfOUm1pZWxIM41fi(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4940763B ^ 0x494243CB), oX7yTZOUy4hUPq8qPy25(dI7lLfOU06WQgMvuCvVk(0x75BAD659 ^ 0x75B8E8A3)), dI7lLfOU06WQgMvuCvVk(0x2269BD32 ^ 0x226B823C)));
					num2 = 3;
					continue;
				case 5:
					enumerator = ((Diagram)Q49rAeOVYin0Jc3uHYUA(workflowProcess)).Elements.GetEnumerator();
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bb19f93c0a774f6cbdada859bba83212 == 0)
					{
						num2 = 0;
					}
					continue;
				case 4:
					AddMainMenuItem(contentSb, (string)dI7lLfOU06WQgMvuCvVk(-2077784392 ^ -2077826434), (string)oX7yTZOUy4hUPq8qPy25(dI7lLfOU06WQgMvuCvVk(0x70EBB9F3 ^ 0x70E98709)));
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bd84f42638494cb6b4427f8e13ec59af == 0)
					{
						num2 = 1;
					}
					continue;
				case 3:
					linkString.Append((string)dI7lLfOU06WQgMvuCvVk(0x56F860D7 ^ 0x56FA5F9F));
					num2 = 4;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3f8a84e2cb374827a50ba2cbcf11cf48 == 0)
					{
						num2 = 9;
					}
					continue;
				}
				break;
			}
			ClK731OUtnLesg1htdrn(linkString, yvO4drOUHfuybdsvbHk1(new string[6]
			{
				(string)oX7yTZOUy4hUPq8qPy25(dI7lLfOU06WQgMvuCvVk(0x5BCD23A0 ^ 0x5BCCC3D8)),
				(string)oX7yTZOUy4hUPq8qPy25(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1214182792 ^ -1214040818)),
				(string)oX7yTZOUy4hUPq8qPy25(dI7lLfOU06WQgMvuCvVk(--1212129906 ^ 0x483D9DF4)),
				SR.T((string)dI7lLfOU06WQgMvuCvVk(-1430645277 ^ -1430771087)),
				(string)oX7yTZOUy4hUPq8qPy25(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1965291699 ^ -1965146251)),
				(string)oX7yTZOUy4hUPq8qPy25(dI7lLfOU06WQgMvuCvVk(0x651FE29D ^ 0x651DDD37))
			}, true, null));
			num = 5;
		}
	}

	private void AddConnectorsImages(StringBuilder bodyString, StringBuilder mapString, Element element, Point startPoint)
	{
		//Discarded unreachable code: IL_0055, IL_0064, IL_0130, IL_013f, IL_014f, IL_0256, IL_0265, IL_0275, IL_02ed, IL_02fc, IL_035e, IL_03bc, IL_047b, IL_04d7, IL_0790, IL_07a3, IL_07b2
		int num = 1;
		int num2 = num;
		List<Connector>.Enumerator enumerator = default(List<Connector>.Enumerator);
		Point point = default(Point);
		Point point2 = default(Point);
		ConnectorHV connectorHV = default(ConnectorHV);
		int num5 = default(int);
		Connector current = default(Connector);
		int num4 = default(int);
		Rectangle rectangle = default(Rectangle);
		string text = default(string);
		int num7 = default(int);
		PointF pointF = default(PointF);
		PointF[] array = default(PointF[]);
		while (true)
		{
			switch (num2)
			{
			case 1:
				enumerator = element.InputConnectors.GetEnumerator();
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6d48f3b4557a49578bf7f5ef0517e0be != 0)
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
						num3 = 11;
						goto IL_0073;
					}
					goto IL_05a9;
					IL_0073:
					while (true)
					{
						switch (num3)
						{
						case 2:
						case 29:
							break;
						case 12:
						case 23:
							if (point.X > point2.X)
							{
								num3 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5816b3723c134946ad9294172266312e == 0)
								{
									num3 = 0;
								}
								continue;
							}
							goto case 25;
						case 14:
							point = new Point((int)((PointF[])GDRKTJOV8VDP82rmejxY(connectorHV))[num5].X - startPoint.X, (int)((PointF[])GDRKTJOV8VDP82rmejxY(connectorHV))[num5].Y - startPoint.Y);
							num3 = 19;
							continue;
						case 3:
							GetDescBPMLink(current, bodyString);
							num3 = 2;
							continue;
						case 16:
						{
							num4++;
							int num6 = 35;
							num3 = num6;
							continue;
						}
						case 19:
							if (point.X - point2.X != 0)
							{
								num3 = 7;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5c45a6e5a4614bfba7591d8a1c7ced1d == 0)
								{
									num3 = 12;
								}
								continue;
							}
							goto case 9;
						case 9:
							if (point.Y > point2.Y)
							{
								num3 = 22;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f19dffab164a41148300de28b2deec39 != 0)
								{
									num3 = 37;
								}
								continue;
							}
							goto case 24;
						case 17:
							point2 = new Point((int)((PointF[])GDRKTJOV8VDP82rmejxY(connectorHV))[num4].X - startPoint.X, (int)((PointF[])GDRKTJOV8VDP82rmejxY(connectorHV))[num4].Y - startPoint.Y);
							num3 = 14;
							continue;
						case 32:
						case 35:
							if (num4 >= ((Array)GDRKTJOV8VDP82rmejxY(connectorHV)).Length - 1)
							{
								num3 = 3;
								continue;
							}
							goto case 20;
						case 37:
							rectangle = new Rectangle(point2.X - 7, point2.Y, 14, point.Y - point2.Y);
							num3 = 15;
							continue;
						case 20:
							num5 = num4 + 1;
							num3 = 17;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6782172e84504a7baf3163b8f6b2a916 != 0)
							{
								num3 = 0;
							}
							continue;
						case 7:
							text = "";
							num3 = 6;
							continue;
						case 34:
							if (connectorHV == null)
							{
								num3 = 29;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cb262bcfe4074a1ab16e653815d57f28 == 0)
								{
									num3 = 13;
								}
								continue;
							}
							goto case 7;
						case 4:
						case 22:
							num7++;
							num3 = 33;
							continue;
						case 30:
							num7 = 0;
							num3 = 18;
							continue;
						case 21:
							num4 = 0;
							num3 = 32;
							continue;
						case 5:
						case 27:
							text = (string)DeXMxPOVsD04hUBfKL0E(new object[5]
							{
								text,
								dI7lLfOU06WQgMvuCvVk(0x17F0C5A2 ^ 0x17F08D28),
								pointF.X,
								dI7lLfOU06WQgMvuCvVk(0x6A69C5CD ^ 0x6A695FCF),
								pointF.Y
							});
							num3 = 22;
							continue;
						default:
							rectangle = new Rectangle(point2.X, point2.Y - 7, point.X - point2.X, 14);
							num3 = 28;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f870ea690334e7ab7599d275d195e9a == 0)
							{
								num3 = 15;
							}
							continue;
						case 18:
						case 33:
							if (num7 >= array.Length)
							{
								num3 = 9;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6e8c2dcf6eb644089ebbe42243c60e95 == 0)
								{
									num3 = 21;
								}
								continue;
							}
							goto case 26;
						case 26:
							pointF = array[num7];
							num3 = 36;
							continue;
						case 6:
							array = (PointF[])GDRKTJOV8VDP82rmejxY(connectorHV);
							num3 = 30;
							continue;
						case 13:
							connectorHV = current as ConnectorHV;
							num3 = 34;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_90dfe18b3d784ead92a1e4e4e2547482 == 0)
							{
								num3 = 32;
							}
							continue;
						case 10:
							text = (string)DeXMxPOVsD04hUBfKL0E(new object[4]
							{
								text,
								pointF.X,
								dI7lLfOU06WQgMvuCvVk(0x65B7F624 ^ 0x65B76C26),
								pointF.Y
							});
							num3 = 4;
							continue;
						case 25:
							rectangle = new Rectangle(point.X, point.Y - 7, point2.X - point.X, 14);
							num3 = 6;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ba57b850b1d34fd9bce66a583e71dc16 != 0)
							{
								num3 = 8;
							}
							continue;
						case 36:
							if (!o9FJ9QOUrYEypCOPn8yJ(text))
							{
								num3 = 5;
								continue;
							}
							goto case 10;
						case 1:
							goto IL_05a9;
						case 24:
							rectangle = new Rectangle(point.X - 7, point.Y, 14, point2.Y - point.Y);
							num3 = 31;
							continue;
						case 8:
						case 15:
						case 28:
						case 31:
							VOvSPsOV0HvX436LW0TS(mapString, 0, DeXMxPOVsD04hUBfKL0E(new object[13]
							{
								SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5F534A5C ^ 0x5F517704),
								rectangle.X,
								SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x651FE29D ^ 0x651F789F),
								rectangle.Y,
								dI7lLfOU06WQgMvuCvVk(0x56F860D7 ^ 0x56F8FAD5),
								rectangle.X + rectangle.Width,
								dI7lLfOU06WQgMvuCvVk(0x361628FF ^ 0x3616B2FD),
								rectangle.Y + rectangle.Height,
								SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2F44D93A ^ 0x2F46E4A8),
								((string)PLVg7qOUdIGTNfN9TB6y(Pf4vfEOUDatn3NOrsTS9(connectorHV)) == "") ? xIvGXhOUuNrAQk0jhOoR(dI7lLfOU06WQgMvuCvVk(-1574607501 ^ -1574479175), Pf4vfEOUDatn3NOrsTS9(waDkjsOVJrSXl3f2IY0G(connectorHV))) : Pf4vfEOUDatn3NOrsTS9(connectorHV),
								dI7lLfOU06WQgMvuCvVk(--1436248540 ^ 0x5599560E),
								ConvertGuid(dkBjQ2OVldm99PEfG5Pd(connectorHV)),
								dI7lLfOU06WQgMvuCvVk(-1108877388 ^ -1109004210)
							}));
							num3 = 16;
							continue;
						case 11:
							return;
						}
						break;
					}
					continue;
					IL_05a9:
					current = enumerator.Current;
					num3 = 13;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b876fa7b083748c8abf8c4b192a11078 == 0)
					{
						num3 = 6;
					}
					goto IL_0073;
				}
			}
			finally
			{
				((IDisposable)enumerator).Dispose();
				int num8 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3bb28bf622874b4689f9265e58d14823 == 0)
				{
					num8 = 0;
				}
				switch (num8)
				{
				case 0:
					break;
				}
			}
		}
	}

	private void GetDescSwimLane(SwimlaneElement bpmsl, StringBuilder descString)
	{
		//Discarded unreachable code: IL_019e, IL_01ad, IL_01b8, IL_024c, IL_025b, IL_0313, IL_0322, IL_03a3, IL_03f9, IL_0408, IL_04c4, IL_04d7, IL_0508, IL_0517, IL_05e4, IL_05f7, IL_0606, IL_0629, IL_06fe, IL_070d, IL_0740, IL_074f, IL_07b6, IL_087f, IL_088e, IL_0899, IL_0989, IL_099c, IL_09ab, IL_09bb, IL_09ca, IL_09da, IL_09e9, IL_0ab3, IL_0ac2
		int num = 24;
		EntityPropertyMetadata entityPropertyMetadata = default(EntityPropertyMetadata);
		_003C_003Ec__DisplayClass15_0 _003C_003Ec__DisplayClass15_ = default(_003C_003Ec__DisplayClass15_0);
		string text = default(string);
		string text3 = default(string);
		string text2 = default(string);
		EntityUserSettings entityUserSettings = default(EntityUserSettings);
		IOrganizationItem organizationItem2 = default(IOrganizationItem);
		List<Worker>.Enumerator enumerator = default(List<Worker>.Enumerator);
		_003C_003Ec__DisplayClass15_2 _003C_003Ec__DisplayClass15_4 = default(_003C_003Ec__DisplayClass15_2);
		IUserGroup userGroup = default(IUserGroup);
		EntityPropertyMetadata entityPropertyMetadata2 = default(EntityPropertyMetadata);
		_003C_003Ec__DisplayClass15_1 _003C_003Ec__DisplayClass15_3 = default(_003C_003Ec__DisplayClass15_1);
		IOrganizationItem organizationItem = default(IOrganizationItem);
		List<string> list2 = default(List<string>);
		_003C_003Ec__DisplayClass15_3 _003C_003Ec__DisplayClass15_2 = default(_003C_003Ec__DisplayClass15_3);
		IBusinessRoleType businessRoleType = default(IBusinessRoleType);
		IList<IBusinessRoleType> list = default(IList<IBusinessRoleType>);
		List<string>.Enumerator enumerator2 = default(List<string>.Enumerator);
		string current = default(string);
		SwimlaneType swimlaneType = default(SwimlaneType);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				object obj;
				switch (num2)
				{
				case 28:
					entityPropertyMetadata = ((IEnumerable<EntityPropertyMetadata>)((EntityMetadata)VuBJ4YOU9ARFWyj1rngG(workflowProcess)).EntityProperties).FirstOrDefault(_003C_003Ec__DisplayClass15_._003CGetDescSwimLane_003Eb__0);
					num2 = 26;
					continue;
				case 13:
					text = string.Empty;
					num2 = 28;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_69cb4a76addb44f28bb765f059e441c7 != 0)
					{
						num2 = 26;
					}
					continue;
				case 16:
					text3 = string.Empty;
					num2 = 13;
					continue;
				case 6:
					text2 = _003C_003Ec__DisplayClass15_.bpmsl.SwimlaneType.GetDisplayName();
					num = 16;
					break;
				case 26:
					if (entityPropertyMetadata != null)
					{
						num2 = 7;
						continue;
					}
					goto case 25;
				case 35:
					entityUserSettings = pG5EEyOV5kR8PNhAxONS(entityPropertyMetadata) as EntityUserSettings;
					num2 = 21;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a2041b18ca1f4a5cb8e5060163bfdb57 != 0)
					{
						num2 = 32;
					}
					continue;
				default:
					if (organizationItem2 == null)
					{
						num2 = 37;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c447ffb64be44c09b6fd398df506785b != 0)
						{
							num2 = 23;
						}
						continue;
					}
					goto case 12;
				case 14:
					try
					{
						while (true)
						{
							int num5;
							if (!enumerator.MoveNext())
							{
								num5 = 9;
								goto IL_01bc;
							}
							goto IL_029d;
							IL_01bc:
							while (true)
							{
								switch (num5)
								{
								case 24:
									_003C_003Ec__DisplayClass15_4 = new _003C_003Ec__DisplayClass15_2();
									num5 = 27;
									continue;
								case 11:
									if (userGroup != null)
									{
										num5 = 14;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f453500aaab143479696408f48a03c17 != 0)
										{
											num5 = 8;
										}
										continue;
									}
									goto default;
								case 16:
								case 21:
									break;
								case 22:
									goto IL_029d;
								case 12:
									entityPropertyMetadata2 = ((IEnumerable<EntityPropertyMetadata>)((EntityMetadata)VuBJ4YOU9ARFWyj1rngG(workflowProcess)).EntityProperties).FirstOrDefault(_003C_003Ec__DisplayClass15_3._003CGetDescSwimLane_003Eb__2);
									num5 = 23;
									continue;
								case 25:
									userGroup = ((AbstractNHEntityManager<IUserGroup, long>)A3doD0OVXJtkUH2QRDKb()).LoadOrNull(_003C_003Ec__DisplayClass15_3.worker.WorkerId);
									num5 = 11;
									continue;
								case 3:
								case 18:
									if (!F8dg7TOU5fruDbKlFbUk(YJM91XOVgJb6sqSPk6RS(_003C_003Ec__DisplayClass15_3.worker), rDnrjZOVBFbW8R0J0Ts5()))
									{
										num5 = 8;
										continue;
									}
									goto case 25;
								default:
									if (!o9FJ9QOUrYEypCOPn8yJ(_003C_003Ec__DisplayClass15_4.workGroupName))
									{
										num5 = 6;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_805f3361d2ba4dac8da4174f89314253 != 0)
										{
											num5 = 4;
										}
										continue;
									}
									break;
								case 4:
									if (organizationItem != null)
									{
										num5 = 8;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3bb28bf622874b4689f9265e58d14823 == 0)
										{
											num5 = 10;
										}
										continue;
									}
									goto default;
								case 8:
								case 17:
									if (!(YJM91XOVgJb6sqSPk6RS(_003C_003Ec__DisplayClass15_3.worker) == Worker.Types.Property))
									{
										num5 = 13;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e632863bfb124ba083e3ba9b363fd70e == 0)
										{
											num5 = 8;
										}
										continue;
									}
									goto case 12;
								case 27:
									_003C_003Ec__DisplayClass15_4.workGroupName = null;
									num5 = 20;
									continue;
								case 10:
									_003C_003Ec__DisplayClass15_4.workGroupName = (string)LpfXCqOVbGTeE8kDoCKc(organizationItem);
									num5 = 5;
									continue;
								case 6:
									if (list2.FirstOrDefault(_003C_003Ec__DisplayClass15_4._003CGetDescSwimLane_003Eb__1) != null)
									{
										num5 = 16;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c7fe5d092d804f7e91041fb2338cec1a == 0)
										{
											num5 = 21;
										}
										continue;
									}
									goto case 2;
								case 14:
									_003C_003Ec__DisplayClass15_4.workGroupName = (string)zSrkBJOVdalIgKFeiklW(userGroup);
									num5 = 26;
									continue;
								case 23:
									if (entityPropertyMetadata2 == null)
									{
										num5 = 7;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f276fa9c20d4dd889000f50d886a41e != 0)
										{
											num5 = 7;
										}
										continue;
									}
									goto case 1;
								case 19:
									_003C_003Ec__DisplayClass15_3.worker = enumerator.Current;
									num5 = 7;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ac5d16a577a84bb0b8ee3654769d2d33 == 0)
									{
										num5 = 24;
									}
									continue;
								case 15:
									organizationItem = ((AbstractNHEntityManager<IOrganizationItem, long>)YNa9YOOVcnhpEyxKnkRm()).LoadOrNull(ScTmFVOVPSxo5b4npGfl(_003C_003Ec__DisplayClass15_3.worker));
									num5 = 4;
									continue;
								case 2:
									list2.Add(_003C_003Ec__DisplayClass15_4.workGroupName);
									num5 = 16;
									continue;
								case 20:
									if (!F8dg7TOU5fruDbKlFbUk(YJM91XOVgJb6sqSPk6RS(_003C_003Ec__DisplayClass15_3.worker), rDnrjZOVBFbW8R0J0Ts5()))
									{
										num5 = 18;
										continue;
									}
									goto case 15;
								case 1:
									_003C_003Ec__DisplayClass15_4.workGroupName = (string)oUEWPaOUki4x2khEd4qP(dI7lLfOU06WQgMvuCvVk(--1756698829 ^ 0x68B43CDB), anbHIGOUMdIO2lvFMMS7(entityPropertyMetadata2), SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-980570076 ^ -980447268)));
									num5 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b74fcd91509d46c3a9661cffb0465df0 != 0)
									{
										num5 = 0;
									}
									continue;
								case 9:
									goto end_IL_0287;
								}
								break;
							}
							continue;
							IL_029d:
							_003C_003Ec__DisplayClass15_3 = new _003C_003Ec__DisplayClass15_1();
							num5 = 8;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d2d2252621ae43ad8d38af812176c290 != 0)
							{
								num5 = 19;
							}
							goto IL_01bc;
							continue;
							end_IL_0287:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator).Dispose();
						int num6 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a27e75af798c48d692c4325f43aa9e6b == 0)
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
				case 12:
					text = (string)LpfXCqOVbGTeE8kDoCKc(organizationItem2);
					num2 = 3;
					continue;
				case 21:
					_003C_003Ec__DisplayClass15_2.businessRoleType = (Guid?)xW3lOpOVDUFoi9DSHU8J(p9v6FpOVuyuGfsrY1EFa(_003C_003Ec__DisplayClass15_.bpmsl), SwimlaneElement.BusinessRoleType);
					num2 = 36;
					continue;
				case 5:
					businessRoleType = list.FirstOrDefault(_003C_003Ec__DisplayClass15_2._003CGetDescSwimLane_003Eb__3);
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4cc62744d0eb4cd68219b70dcad3e68e == 0)
					{
						num2 = 1;
					}
					continue;
				case 22:
					organizationItem2 = OrganizationItemManager.Instance.LoadOrNull(jZl3jpOVtxjxb4hF3Kjp(_003C_003Ec__DisplayClass15_.bpmsl));
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6782172e84504a7baf3163b8f6b2a916 != 0)
					{
						num2 = 0;
					}
					continue;
				case 7:
					if (!Hv4tcsOVylSb65yXV33G(anbHIGOUMdIO2lvFMMS7(entityPropertyMetadata)))
					{
						num = 29;
						break;
					}
					obj = l0fMBlOUU0K8cDdLCWmi(entityPropertyMetadata);
					goto IL_0b71;
				case 33:
					goto IL_06e4;
				case 8:
					goto IL_0718;
				case 23:
					_003C_003Ec__DisplayClass15_.bpmsl = bpmsl;
					num2 = 6;
					continue;
				case 29:
					obj = RLZ5RTOVmL7CN92leR4m(jiTtLoOUXRLcJWtYZ8a1(dI7lLfOU06WQgMvuCvVk(0x6871CA ^ 0x6A4E26), ex6B4YOUpp4ZIC4kvvpc(entityPropertyMetadata).ToString().Replace(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1514166050 ^ -1514301220), "")), anbHIGOUMdIO2lvFMMS7(entityPropertyMetadata));
					goto IL_0b71;
				case 32:
					if (entityUserSettings == null)
					{
						num2 = 2;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_805f3361d2ba4dac8da4174f89314253 == 0)
						{
							num2 = 4;
						}
						continue;
					}
					goto case 2;
				case 20:
					text2 = (string)xIvGXhOUuNrAQk0jhOoR(text2, jiTtLoOUXRLcJWtYZ8a1(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6C7F14 ^ 0x6E49D6), businessRoleType.DisplayName));
					num2 = 19;
					continue;
				case 38:
					if (entityPropertyMetadata == null)
					{
						num2 = 30;
						continue;
					}
					goto case 10;
				case 1:
					if (businessRoleType != null)
					{
						num2 = 17;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a27e75af798c48d692c4325f43aa9e6b != 0)
						{
							num2 = 20;
						}
						continue;
					}
					goto IL_0acd;
				case 17:
					return;
				case 10:
					if (pG5EEyOV5kR8PNhAxONS(entityPropertyMetadata) == null)
					{
						num = 18;
						break;
					}
					goto case 35;
				case 36:
					list = ((ComponentManager)MQtHvXOVnU25N9iIblnU()).GetExtensionPoints<IBusinessRoleType>() as IList<IBusinessRoleType>;
					num2 = 34;
					continue;
				case 15:
					try
					{
						while (true)
						{
							IL_08da:
							int num3;
							if (!enumerator2.MoveNext())
							{
								num3 = 3;
								goto IL_089d;
							}
							goto IL_08b7;
							IL_089d:
							while (true)
							{
								switch (num3)
								{
								case 1:
									break;
								default:
									goto IL_08da;
								case 2:
									text = (string)xIvGXhOUuNrAQk0jhOoR(text, o9FJ9QOUrYEypCOPn8yJ(text) ? jiTtLoOUXRLcJWtYZ8a1(dI7lLfOU06WQgMvuCvVk(0x614CF569 ^ 0x614C3F79), current) : string.Format((string)dI7lLfOU06WQgMvuCvVk(-862330810 ^ -862216118), current));
									num3 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d42a29e78d4a45518985de3631ade50c != 0)
									{
										num3 = 0;
									}
									continue;
								case 3:
									goto end_IL_08da;
								}
								break;
							}
							goto IL_08b7;
							IL_08b7:
							current = enumerator2.Current;
							num3 = 2;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4459fbe344a947429d197733d274ef68 == 0)
							{
								num3 = 2;
							}
							goto IL_089d;
							continue;
							end_IL_08da:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator2).Dispose();
						int num4 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f453500aaab143479696408f48a03c17 == 0)
						{
							num4 = 0;
						}
						switch (num4)
						{
						case 0:
							break;
						}
					}
					goto IL_0acd;
				case 34:
					if (list != null)
					{
						num2 = 5;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_abfb511163674a3eae959fd60da8f319 == 0)
						{
							num2 = 5;
						}
						continue;
					}
					goto IL_0acd;
				case 25:
					swimlaneType = _003C_003Ec__DisplayClass15_.bpmsl.SwimlaneType;
					num2 = 31;
					continue;
				case 31:
					switch (swimlaneType)
					{
					case SwimlaneType.Static:
						break;
					case SwimlaneType.BusinessRole:
						goto IL_06e4;
					case SwimlaneType.Dynamic:
						goto IL_0718;
					default:
						goto IL_0a44;
					case SwimlaneType.DynamicScript:
						goto IL_0acd;
					}
					goto case 22;
				case 24:
					_003C_003Ec__DisplayClass15_ = new _003C_003Ec__DisplayClass15_0();
					num2 = 23;
					continue;
				case 27:
					enumerator = entityUserSettings.Workers.GetEnumerator();
					num = 14;
					break;
				case 4:
				case 9:
				case 18:
				case 30:
					enumerator2 = list2.GetEnumerator();
					num2 = 15;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a680afde07ce4ae5b71c411a1f75109b == 0)
					{
						num2 = 5;
					}
					continue;
				case 3:
				case 11:
				case 19:
				case 37:
					goto IL_0acd;
				case 2:
					{
						if (entityUserSettings.Workers != null)
						{
							num2 = 27;
							continue;
						}
						goto case 4;
					}
					IL_0a44:
					num2 = 4;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cb262bcfe4074a1ab16e653815d57f28 != 0)
					{
						num2 = 11;
					}
					continue;
					IL_0acd:
					ClK731OUtnLesg1htdrn(descString, yvO4drOUHfuybdsvbHk1(new string[4]
					{
						(string)oUEWPaOUki4x2khEd4qP(dI7lLfOU06WQgMvuCvVk(-947937941 ^ -948066865), OVWP4dOUCRQrwmGQ2TPe(dkBjQ2OVldm99PEfG5Pd(_003C_003Ec__DisplayClass15_.bpmsl).ToString(), dI7lLfOU06WQgMvuCvVk(-2122743969 ^ -2122625187), ""), Pf4vfEOUDatn3NOrsTS9(_003C_003Ec__DisplayClass15_.bpmsl)),
						text2,
						text,
						text3
					}, false, null));
					num2 = 17;
					continue;
					IL_0718:
					list2 = new List<string>();
					num2 = 38;
					continue;
					IL_06e4:
					_003C_003Ec__DisplayClass15_2 = new _003C_003Ec__DisplayClass15_3();
					num = 21;
					break;
					IL_0b71:
					text3 = (string)obj;
					num = 25;
					break;
				}
				break;
			}
		}
	}

	private void CreateSubProccessDocs(ProcessDocumentationGenerator rootGenerator)
	{
		//Discarded unreachable code: IL_002f, IL_003e, IL_008e, IL_009d, IL_01ad, IL_01ed, IL_01fc, IL_0208, IL_0217
		int num = 2;
		int num2 = num;
		IEnumerator<IWorkflowProcess> enumerator = default(IEnumerator<IWorkflowProcess>);
		IWorkflowProcess workflowProcess = default(IWorkflowProcess);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				try
				{
					while (true)
					{
						IL_00c4:
						int num3;
						if (!bywb0bOUL1GGqXZhTSj4(enumerator))
						{
							num3 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f91acf223c4b4303819d2f8f2fc6c8e1 == 0)
							{
								num3 = 1;
							}
							goto IL_004d;
						}
						goto IL_00a8;
						IL_004d:
						while (true)
						{
							switch (num3)
							{
							case 1:
								return;
							case 2:
								if (!QIrUwoOVHi2jWlR65XnE(workflowProcess))
								{
									goto IL_007b;
								}
								goto default;
							case 3:
								break;
							case 4:
							case 5:
								goto IL_00c4;
							default:
							{
								ProcessDocumentationGenerator obj = new ProcessDocumentationGenerator(workflowProcess)
								{
									documentPath = rootGenerator.documentPath,
									subFolders = rootGenerator.subFolders,
									Files = rootGenerator.Files
								};
								GenerationSettings generationSettings = settings.Clone();
								generationSettings.ProcessId = workflowProcess.Id;
								generationSettings.ParentProcessUid = D47ZnIOVLWhW2uiBUYBe(rootGenerator.workflowProcess);
								obj.CreateDocumentation(workflowProcess, (string)(subFolders ? gp6m6mOVKML7jd4leSFT(rootGenerator.documentPath, W3BgcOOV9dKx1pXVh6NC(qLY3VyOVfxVopRF0pKF1(workflowProcess)).ToString()) : rootGenerator.documentPath), generationSettings, subFolders);
								num3 = 5;
								continue;
							}
							}
							break;
						}
						goto IL_00a8;
						IL_007b:
						int num4 = 4;
						goto IL_0049;
						IL_00a8:
						workflowProcess = enumerator.Current.CastAsRealType();
						num4 = 2;
						goto IL_0049;
						IL_0049:
						num3 = num4;
						goto IL_004d;
					}
				}
				finally
				{
					int num5;
					if (enumerator == null)
					{
						num5 = 2;
						goto IL_01b1;
					}
					goto IL_01c7;
					IL_01b1:
					switch (num5)
					{
					default:
						goto end_IL_019c;
					case 1:
						break;
					case 2:
						goto end_IL_019c;
					case 0:
						goto end_IL_019c;
					}
					goto IL_01c7;
					IL_01c7:
					enumerator.Dispose();
					num5 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bb19f93c0a774f6cbdada859bba83212 == 0)
					{
						num5 = 0;
					}
					goto IL_01b1;
					end_IL_019c:;
				}
			case 2:
				enumerator = ((IEnumerable<IWorkflowProcess>)this.workflowProcess.SubProcesses).GetEnumerator();
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bae4e393cddc4c98b9896b25c9e18c7d == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	private static bool CheckProcessContextExistence(object process)
	{
		//Discarded unreachable code: IL_004f, IL_0081, IL_00b9, IL_00c8
		bool flag = default(bool);
		switch (1)
		{
		case 1:
			try
			{
				flag = ((ProcessContext)VuBJ4YOU9ARFWyj1rngG(process)).CastAsRealType() != null;
				int num = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_938c6be4ea2248868d7ed5d0e3346006 == 0)
				{
					num = 0;
				}
				return num switch
				{
					0 => flag, 
					_ => flag, 
				};
			}
			catch (ObjectNotFoundException)
			{
				int num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_fb347e2c5dba4e0ca4d47098be7fd10c == 0)
				{
					num2 = 0;
				}
				while (true)
				{
					switch (num2)
					{
					case 1:
						flag = false;
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_eef7d2ca1c3c4b74aeb81172ed542639 == 0)
						{
							num2 = 0;
						}
						break;
					default:
						return flag;
					case 0:
						return flag;
					}
				}
			}
		default:
			return flag;
		}
	}

	private void GetDescBPMLink(Connector bpml, StringBuilder descString)
	{
		//Discarded unreachable code: IL_0123, IL_0132, IL_01ab, IL_01ba, IL_0335, IL_0350, IL_035a, IL_03b1, IL_03c0, IL_03e1, IL_03f4, IL_0403, IL_0583, IL_0623, IL_0747, IL_0756
		int num = 9;
		IConnectorSettingsExtensionElement connectorSettingsExtensionElement = default(IConnectorSettingsExtensionElement);
		_003C_003Ec__DisplayClass18_1 _003C_003Ec__DisplayClass18_2 = default(_003C_003Ec__DisplayClass18_1);
		Guid guid = default(Guid);
		_003C_003Ec__DisplayClass18_0 _003C_003Ec__DisplayClass18_ = default(_003C_003Ec__DisplayClass18_0);
		string text6 = default(string);
		string text5 = default(string);
		bool flag2 = default(bool);
		string text2 = default(string);
		bool flag = default(bool);
		string text = default(string);
		WorkflowForm workflowForm = default(WorkflowForm);
		string text4 = default(string);
		string text3 = default(string);
		StringBuilder stringBuilder = default(StringBuilder);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				object obj2;
				object obj3;
				object obj;
				switch (num2)
				{
				case 21:
					if (connectorSettingsExtensionElement == null)
					{
						num2 = 30;
						continue;
					}
					goto case 27;
				case 27:
					_003C_003Ec__DisplayClass18_2 = new _003C_003Ec__DisplayClass18_1();
					num2 = 10;
					continue;
				case 54:
					guid = dkBjQ2OVldm99PEfG5Pd(_003C_003Ec__DisplayClass18_.bpml.EndElement);
					num2 = 22;
					continue;
				case 55:
					guid = dkBjQ2OVldm99PEfG5Pd(u29ZApOVRsFaZX4dOxJJ(_003C_003Ec__DisplayClass18_.bpml));
					num2 = 14;
					continue;
				case 20:
					if (!Hv4tcsOVylSb65yXV33G(Pf4vfEOUDatn3NOrsTS9(_003C_003Ec__DisplayClass18_.bpml)))
					{
						num2 = 41;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f30401a2cff84771be092252e934fede == 0)
						{
							num2 = 25;
						}
						continue;
					}
					obj2 = GspGpOOVWRNbjdwqfKN1(waDkjsOVJrSXl3f2IY0G(_003C_003Ec__DisplayClass18_.bpml));
					goto IL_07b7;
				case 33:
				case 43:
					if (!(text6 == (string)GspGpOOVWRNbjdwqfKN1(waDkjsOVJrSXl3f2IY0G(_003C_003Ec__DisplayClass18_.bpml))))
					{
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d087ae72a2134de08266411226c5f060 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 42;
				case 14:
					text5 = guid.ToString();
					num = 19;
					break;
				case 37:
					if (waDkjsOVJrSXl3f2IY0G(_003C_003Ec__DisplayClass18_.bpml) is EndEventElement)
					{
						num2 = 6;
						continue;
					}
					goto default;
				case 24:
					flag2 = true;
					num = 39;
					break;
				case 44:
					text2 = (string)oX7yTZOUy4hUPq8qPy25(dI7lLfOU06WQgMvuCvVk(0x7AC609FE ^ 0x7AC449E4));
					num2 = 23;
					continue;
				case 1:
					flag = false;
					num2 = 28;
					continue;
				case 10:
					_003C_003Ec__DisplayClass18_2.formForConnector = connectorSettingsExtensionElement.ConnectorSettings.Where(_003C_003Ec__DisplayClass18_._003CGetDescBPMLink_003Eb__0).FirstOrDefault();
					num = 12;
					break;
				case 45:
					if (!string.IsNullOrWhiteSpace((string)Pf4vfEOUDatn3NOrsTS9(_003C_003Ec__DisplayClass18_.bpml.EndElement)))
					{
						num2 = 40;
						continue;
					}
					obj3 = GspGpOOVWRNbjdwqfKN1(_003C_003Ec__DisplayClass18_.bpml.EndElement);
					goto IL_07f1;
				case 42:
					text6 = (string)oX7yTZOUy4hUPq8qPy25(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6F6D7B44 ^ 0x6F6F3B24));
					num = 36;
					break;
				case 25:
					if (string.IsNullOrWhiteSpace(((Element)u29ZApOVRsFaZX4dOxJJ(_003C_003Ec__DisplayClass18_.bpml)).Name))
					{
						num = 53;
						break;
					}
					goto case 46;
				case 41:
					obj2 = _003C_003Ec__DisplayClass18_.bpml.Name;
					goto IL_07b7;
				case 40:
					obj3 = Pf4vfEOUDatn3NOrsTS9(waDkjsOVJrSXl3f2IY0G(_003C_003Ec__DisplayClass18_.bpml));
					goto IL_07f1;
				case 28:
					text6 = SR.T((string)dI7lLfOU06WQgMvuCvVk(-1430645277 ^ -1430760051));
					num2 = 51;
					continue;
				case 5:
					text = string.Empty;
					num2 = 10;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3bb28bf622874b4689f9265e58d14823 == 0)
					{
						num2 = 29;
					}
					continue;
				case 4:
					if (workflowForm == null)
					{
						num2 = 18;
						continue;
					}
					goto case 31;
				case 13:
					text4 = (string)oX7yTZOUy4hUPq8qPy25(dI7lLfOU06WQgMvuCvVk(-1108877388 ^ -1109024882));
					num2 = 34;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_67df302d7a2e4c95b7c8b62f21f3a833 != 0)
					{
						num2 = 2;
					}
					continue;
				case 50:
					text2 = (string)oX7yTZOUy4hUPq8qPy25(dI7lLfOU06WQgMvuCvVk(0xB7793C9 ^ 0xB75D3A9));
					num2 = 5;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a50dda04dedf4515816f963c67783c8f == 0)
					{
						num2 = 43;
					}
					continue;
				case 32:
					if (u29ZApOVRsFaZX4dOxJJ(_003C_003Ec__DisplayClass18_.bpml) == null)
					{
						num2 = 15;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f05298ca2a4a4a639a58bc7f7d9ff7b9 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 25;
				case 52:
					if (!eqIvuWOV6VlyKfVUe0AA(text2, GspGpOOVWRNbjdwqfKN1(waDkjsOVJrSXl3f2IY0G(_003C_003Ec__DisplayClass18_.bpml))))
					{
						num2 = 11;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d2d2252621ae43ad8d38af812176c290 == 0)
						{
							num2 = 7;
						}
						continue;
					}
					goto case 44;
				case 9:
					_003C_003Ec__DisplayClass18_ = new _003C_003Ec__DisplayClass18_0();
					num2 = 8;
					continue;
				case 47:
					connectorSettingsExtensionElement = _003C_003Ec__DisplayClass18_.bpml.StartElement as IConnectorSettingsExtensionElement;
					num2 = 21;
					continue;
				case 6:
					if (!eqIvuWOV6VlyKfVUe0AA(text2, GspGpOOVWRNbjdwqfKN1(waDkjsOVJrSXl3f2IY0G(_003C_003Ec__DisplayClass18_.bpml))))
					{
						num2 = 22;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_39af03d004af472bb66e60f46e79703a != 0)
						{
							num2 = 33;
						}
						continue;
					}
					goto case 50;
				case 19:
					if (u29ZApOVRsFaZX4dOxJJ(_003C_003Ec__DisplayClass18_.bpml) is StartEventElement)
					{
						num2 = 52;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b30151cb26574dfaa8f9d818b0352d3b == 0)
						{
							num2 = 23;
						}
						continue;
					}
					goto case 34;
				case 46:
					obj = Pf4vfEOUDatn3NOrsTS9(u29ZApOVRsFaZX4dOxJJ(_003C_003Ec__DisplayClass18_.bpml));
					goto IL_07d4;
				case 3:
					workflowForm = ((WorkflowFormsContainer)rHXxTZOVqAbfx8CQjQxc(workflowProcess)).Items.Find(_003C_003Ec__DisplayClass18_2._003CGetDescBPMLink_003Eb__1);
					num2 = 4;
					continue;
				case 15:
				case 48:
					flag2 = false;
					num2 = 9;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ba57b850b1d34fd9bce66a583e71dc16 != 0)
					{
						num2 = 13;
					}
					continue;
				case 7:
					flag2 = false;
					num2 = 32;
					continue;
				case 17:
					text4 = SR.T((string)dI7lLfOU06WQgMvuCvVk(0x614274E3 ^ 0x614034F9));
					num = 35;
					break;
				case 31:
					text3 = (string)iFGolPOV3sxseB65duZF(workflowForm);
					num2 = 26;
					continue;
				case 39:
					flag = true;
					num2 = 12;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a50dda04dedf4515816f963c67783c8f == 0)
					{
						num2 = 20;
					}
					continue;
				default:
					text3 = (string)PFcoqfOUm1pZWxIM41fi(dI7lLfOU06WQgMvuCvVk(0x157D5AF4 ^ 0x157C2AD2), oX7yTZOUy4hUPq8qPy25(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-947937941 ^ -948052487)), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1393899982 ^ -1393905158));
					num2 = 47;
					continue;
				case 34:
				case 35:
					if (waDkjsOVJrSXl3f2IY0G(_003C_003Ec__DisplayClass18_.bpml) != null)
					{
						num = 45;
						break;
					}
					goto case 1;
				case 8:
					_003C_003Ec__DisplayClass18_.bpml = bpml;
					num2 = 49;
					continue;
				case 2:
					text5 = string.Empty;
					num2 = 5;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6d48f3b4557a49578bf7f5ef0517e0be == 0)
					{
						num2 = 4;
					}
					continue;
				case 12:
					if (_003C_003Ec__DisplayClass18_2.formForConnector != null)
					{
						num2 = 3;
						continue;
					}
					goto case 18;
				case 11:
				case 23:
					if (eqIvuWOV6VlyKfVUe0AA(text4, GspGpOOVWRNbjdwqfKN1(u29ZApOVRsFaZX4dOxJJ(_003C_003Ec__DisplayClass18_.bpml))))
					{
						num2 = 17;
						continue;
					}
					goto case 34;
				case 38:
					flag = false;
					num2 = 7;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a9be7e056b4e4b6e863b634c418144f1 == 0)
					{
						num2 = 5;
					}
					continue;
				case 49:
					stringBuilder = new StringBuilder();
					num2 = 24;
					continue;
				case 16:
					return;
				case 29:
					if (!Up0NY2OVjvBKN3D1eyn9(settings))
					{
						num2 = 38;
						continue;
					}
					goto case 32;
				case 22:
					text = guid.ToString();
					num2 = 37;
					continue;
				case 53:
					obj = GspGpOOVWRNbjdwqfKN1(u29ZApOVRsFaZX4dOxJJ(_003C_003Ec__DisplayClass18_.bpml));
					goto IL_07d4;
				case 18:
				case 26:
				case 30:
					{
						ClK731OUtnLesg1htdrn(descString, HTMLUtility.InsertRowToTable(new string[6]
						{
							SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x56A753C9 ^ 0x56A51363) + ConvertGuid(dkBjQ2OVldm99PEfG5Pd(_003C_003Ec__DisplayClass18_.bpml)) + (string)dI7lLfOU06WQgMvuCvVk(-683713632 ^ -683861148) + text2,
							(string)(flag2 ? RLZ5RTOVmL7CN92leR4m((string)dI7lLfOU06WQgMvuCvVk(--727842433 ^ 0x2B61481F) + text5, (string)dI7lLfOU06WQgMvuCvVk(0xD305CC2 ^ 0xD326308) + text4) : text4),
							(string)(flag ? RLZ5RTOVmL7CN92leR4m(xIvGXhOUuNrAQk0jhOoR(dI7lLfOU06WQgMvuCvVk(0x46EA3D1 ^ 0x46E154F), text), xIvGXhOUuNrAQk0jhOoR(dI7lLfOU06WQgMvuCvVk(0xF400DF8 ^ 0xF423232), text6)) : text6),
							stringBuilder.ToString(),
							_003C_003Ec__DisplayClass18_.bpml.Description,
							text3
						}, isBold: false, null));
						num2 = 14;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f30401a2cff84771be092252e934fede != 0)
						{
							num2 = 16;
						}
						continue;
					}
					IL_07b7:
					text2 = (string)obj2;
					num2 = 2;
					continue;
					IL_07d4:
					text4 = (string)obj;
					num2 = 55;
					continue;
					IL_07f1:
					text6 = (string)obj3;
					num2 = 50;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_32f3e755437f4eacb85c8a0d536f83ea == 0)
					{
						num2 = 54;
					}
					continue;
				}
				break;
			}
		}
	}

	private void AddFileWithCheck(string filename)
	{
		//Discarded unreachable code: IL_0032
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
			case 2:
				return;
			case 3:
				Files.Add(filename);
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bd84f42638494cb6b4427f8e13ec59af == 0)
				{
					num2 = 2;
				}
				break;
			case 1:
				if (Files.Contains(filename))
				{
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_448e6815cb30438893079dcbb906fd65 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 3;
			}
		}
	}

	private void SavePictures(string pathImage)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 4:
				AddFileWithCheck((string)gp6m6mOVKML7jd4leSFT(pathImage, dI7lLfOU06WQgMvuCvVk(-885093259 ^ -885207903)));
				num2 = 3;
				break;
			case 2:
				return;
			case 3:
				AddFileWithCheck((string)gp6m6mOVKML7jd4leSFT(pathImage, dI7lLfOU06WQgMvuCvVk(-2077784392 ^ -2077899198)));
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_9570b4a70465495fba22c942f586465a == 0)
				{
					num2 = 2;
				}
				break;
			case 1:
				gVtMU2OVpUb7TaWnwF4X(uTZlGNOVTK78YWXlQLfq(), gp6m6mOVKML7jd4leSFT(pathImage, dI7lLfOU06WQgMvuCvVk(0x614274E3 ^ 0x61403437)), b6nQVIOVQhfYAMXWHXOm());
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_719514a5a8ae47ed84e5a777ead0dc9f != 0)
				{
					num2 = 0;
				}
				break;
			default:
				((Image)EIP2QFOVCvShBDwleCTQ()).Save((string)gp6m6mOVKML7jd4leSFT(pathImage, dI7lLfOU06WQgMvuCvVk(0xDF4D1F8 ^ 0xDF69102)), ImageFormat.Png);
				num2 = 4;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_545887e65739480a965b7ddfab7d0632 == 0)
				{
					num2 = 4;
				}
				break;
			}
		}
	}

	private static string ConvertGuid(Guid guid)
	{
		//Discarded unreachable code: IL_009c, IL_00ab
		int num = 2;
		int num2 = num;
		string text = default(string);
		while (true)
		{
			switch (num2)
			{
			case 2:
				text = guid.ToString();
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3b4403f77a00495e957e5e4a6840e5d3 == 0)
				{
					num2 = 1;
				}
				break;
			case 4:
				return text;
			case 3:
				text = (string)CkDBgCOVM8gs3RZOYbDJ(text, text.IndexOf((string)dI7lLfOU06WQgMvuCvVk(0x8D5763A ^ 0x8D74638)), 1);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_805f3361d2ba4dac8da4174f89314253 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				if (text.IndexOf((string)dI7lLfOU06WQgMvuCvVk(-11799394 ^ -11942756)) < 0)
				{
					num2 = 4;
					break;
				}
				goto case 3;
			}
		}
	}

	private Bitmap GetBitmap()
	{
		//Discarded unreachable code: IL_00c2, IL_00d1, IL_0222, IL_0231, IL_0297, IL_02cf
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		int num = 2;
		int num2 = num;
		IEnumerator<Element> enumerator = default(IEnumerator<Element>);
		int num6 = default(int);
		int height = default(int);
		int num5 = default(int);
		NShape val = default(NShape);
		int width = default(int);
		Size size = default(Size);
		Element current = default(Element);
		while (true)
		{
			switch (num2)
			{
			case 4:
				enumerator = ((Diagram)Q49rAeOVYin0Jc3uHYUA(workflowProcess)).Elements.GetEnumerator();
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_805f3361d2ba4dac8da4174f89314253 != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				num6 = (int)cgsSOmOVkCTtV69MUStS(workflowProcess.Diagram);
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ba57b850b1d34fd9bce66a583e71dc16 == 0)
				{
					num2 = 1;
				}
				break;
			case 3:
			{
				Bitmap bitmap = new Bitmap(num6, height);
				Graphics graphics = Graphics.FromImage(bitmap);
				UiSqboOVG10QX0alD0IV((object)new NCanvas(workflowProcess.Diagram.Document), graphics);
				return bitmap;
			}
			default:
				try
				{
					while (true)
					{
						int num3;
						if (!bywb0bOUL1GGqXZhTSj4(enumerator))
						{
							num3 = 5;
							goto IL_00e0;
						}
						goto IL_01c9;
						IL_00e0:
						while (true)
						{
							switch (num3)
							{
							case 4:
								num5 = (int)mtem0eOVVq2P4oLWN0UR(val).X + width + (int)uJ9MSmOVApWc9mtja7vD(val);
								num3 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bb19f93c0a774f6cbdada859bba83212 == 0)
								{
									num3 = 0;
								}
								continue;
							case 9:
								size = TextRenderer.MeasureText((string)Pf4vfEOUDatn3NOrsTS9(current), new Font(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-63028171 ^ -63175391), 9f));
								num3 = 4;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a680afde07ce4ae5b71c411a1f75109b != 0)
								{
									num3 = 7;
								}
								continue;
							case 3:
								if (!(current is FlowConnectorElement))
								{
									num3 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_75a2d0f780b04098ba855df5729e6c30 == 0)
									{
										num3 = 1;
									}
									continue;
								}
								goto case 6;
							case 1:
							case 2:
								break;
							case 8:
								goto IL_01c9;
							case 6:
								num6 = num5;
								num3 = 2;
								continue;
							default:
								if (num5 > num6)
								{
									num3 = 2;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5c45a6e5a4614bfba7591d8a1c7ced1d == 0)
									{
										num3 = 3;
									}
									continue;
								}
								break;
							case 7:
								width = size.Width;
								num3 = 4;
								continue;
							case 10:
							{
								val = (NShape)V3HCghOVUNLhO7KdqpLi(Q49rAeOVYin0Jc3uHYUA(workflowProcess), current);
								int num4 = 9;
								num3 = num4;
								continue;
							}
							case 5:
								goto end_IL_01b3;
							}
							break;
						}
						continue;
						IL_01c9:
						current = enumerator.Current;
						num3 = 10;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a50dda04dedf4515816f963c67783c8f != 0)
						{
							num3 = 4;
						}
						goto IL_00e0;
						continue;
						end_IL_01b3:
						break;
					}
				}
				finally
				{
					if (enumerator != null)
					{
						int num7 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cfe4a54387d744988feba4889229faf1 != 0)
						{
							num7 = 1;
						}
						while (true)
						{
							switch (num7)
							{
							case 1:
								AYnRdXOUfyyMwUNuUxpJ(enumerator);
								num7 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5816b3723c134946ad9294172266312e == 0)
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
				goto case 3;
			case 1:
				height = (int)workflowProcess.Diagram.Height;
				num2 = 4;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c559093b7320494babd70d164a6df42d == 0)
				{
					num2 = 4;
				}
				break;
			}
		}
	}

	public void CreateDocumentationInThread()
	{
		//Discarded unreachable code: IL_02a4, IL_0345, IL_0518, IL_0527, IL_06a8, IL_06bb, IL_0803, IL_0812, IL_0823, IL_0832, IL_08da, IL_091a, IL_0929, IL_0935, IL_0944, IL_0954, IL_0aba, IL_0ac9, IL_0d29, IL_0d38, IL_1021, IL_1030, IL_10a7, IL_10f9, IL_1264, IL_1273, IL_12b3, IL_139f, IL_13b2, IL_13c1, IL_1409, IL_1418, IL_143c, IL_145d, IL_146c, IL_15ef, IL_1727, IL_1736, IL_178e, IL_179d
		int num = 6;
		StringBuilder stringBuilder2 = default(StringBuilder);
		StringBuilder stringBuilder3 = default(StringBuilder);
		StringBuilder stringBuilder10 = default(StringBuilder);
		StringBuilder stringBuilder4 = default(StringBuilder);
		Point startPoint = default(Point);
		StringBuilder stringBuilder7 = default(StringBuilder);
		StringBuilder stringBuilder9 = default(StringBuilder);
		StringBuilder stringBuilder = default(StringBuilder);
		string text = default(string);
		KeyValuePair<string, StringBuilder> keyValuePair = default(KeyValuePair<string, StringBuilder>);
		Dictionary<string, StringBuilder> dictionary = default(Dictionary<string, StringBuilder>);
		Bitmap bitmap2 = default(Bitmap);
		Dictionary<string, StringBuilder>.Enumerator enumerator2 = default(Dictionary<string, StringBuilder>.Enumerator);
		KeyValuePair<string, StringBuilder> current3 = default(KeyValuePair<string, StringBuilder>);
		StringBuilder stringBuilder6 = default(StringBuilder);
		string text2 = default(string);
		IEnumerator<Element> enumerator = default(IEnumerator<Element>);
		Element current = default(Element);
		Dictionary<string, StringBuilder> dictionary2 = default(Dictionary<string, StringBuilder>);
		Bitmap bitmap = default(Bitmap);
		string text3 = default(string);
		IDocumentationChapter documentationChapter = default(IDocumentationChapter);
		StringBuilder stringBuilder5 = default(StringBuilder);
		StringBuilder stringBuilder8 = default(StringBuilder);
		KeyValuePair<string, StringBuilder> current2 = default(KeyValuePair<string, StringBuilder>);
		IEnumerable<IDocumentationChapter> extensionPoints = default(IEnumerable<IDocumentationChapter>);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 89:
					ClK731OUtnLesg1htdrn(stringBuilder2, dI7lLfOU06WQgMvuCvVk(--1436248540 ^ 0x55992E62));
					num2 = 12;
					continue;
				case 13:
					ClK731OUtnLesg1htdrn(stringBuilder3, PFcoqfOUm1pZWxIM41fi(dI7lLfOU06WQgMvuCvVk(0x70EBB9F3 ^ 0x70E9FCC7), oX7yTZOUy4hUPq8qPy25(dI7lLfOU06WQgMvuCvVk(0x4940763B ^ 0x494233A7)), dI7lLfOU06WQgMvuCvVk(0x65B7F624 ^ 0x65B5B390)));
					num = 77;
					break;
				case 12:
				case 49:
				case 52:
				case 81:
					ClK731OUtnLesg1htdrn(stringBuilder2, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1EA50FCC ^ 0x1EA74796));
					num2 = 88;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_46e05b4e09174e34a9c81741b8b77a2f != 0)
					{
						num2 = 14;
					}
					continue;
				case 71:
					GenerateConnectorsDocs(stringBuilder10, stringBuilder4, ((WorkflowDiagram)Q49rAeOVYin0Jc3uHYUA(workflowProcess)).GetStartElement(), startPoint, stringBuilder3);
					num2 = 73;
					continue;
				case 113:
					FPlp52OVhG9lPQg1YH9i(stringBuilder7, stringBuilder9);
					num2 = 22;
					continue;
				case 110:
					if (!F8dg7TOU5fruDbKlFbUk(nlyxDoOVNBN2tFoftXGA(settings), Guid.Empty))
					{
						num2 = 49;
						continue;
					}
					goto case 16;
				case 3:
					ClK731OUtnLesg1htdrn(stringBuilder, dI7lLfOU06WQgMvuCvVk(0x51EF0063 ^ 0x51ED4105));
					num2 = 53;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_90dfe18b3d784ead92a1e4e4e2547482 == 0)
					{
						num2 = 48;
					}
					continue;
				case 103:
					ClK731OUtnLesg1htdrn(stringBuilder, dI7lLfOU06WQgMvuCvVk(0x17F0C5A2 ^ 0x17F286C0));
					num2 = 66;
					continue;
				case 96:
					text = Path.Combine(documentPath, (string)jiTtLoOUXRLcJWtYZ8a1(dI7lLfOU06WQgMvuCvVk(0x246EEF98 ^ 0x246CAEA0), OVWP4dOUCRQrwmGQ2TPe(workflowProcess.Uid.ToString(), dI7lLfOU06WQgMvuCvVk(0x361628FF ^ 0x361418FD), "")));
					num2 = 106;
					continue;
				case 2:
				{
					StreamWriter streamWriter = new StreamWriter(fileName);
					AddFileWithCheck(fileName);
					MwW43fOVO0LI66c3Pw73(streamWriter, stringBuilder.ToString());
					jZqEYhOVZIunubwsvPpF(streamWriter);
					num2 = 78;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cb262bcfe4074a1ab16e653815d57f28 == 0)
					{
						num2 = 70;
					}
					continue;
				}
				case 69:
					stringBuilder9 = new StringBuilder();
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_764abb15e52f4036a7a81fce6cb70f30 != 0)
					{
						num2 = 1;
					}
					continue;
				case 15:
					ClK731OUtnLesg1htdrn(stringBuilder, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-862330810 ^ -862215270));
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_719514a5a8ae47ed84e5a777ead0dc9f == 0)
					{
						num2 = 0;
					}
					continue;
				case 53:
					ClK731OUtnLesg1htdrn(stringBuilder, dI7lLfOU06WQgMvuCvVk(-1716458555 ^ -1716332531));
					num = 27;
					break;
				case 4:
					keyValuePair = dictionary.FirstOrDefault();
					num2 = 9;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4ef74b4b7d13430e9d2f9b78cbdb367b == 0)
					{
						num2 = 42;
					}
					continue;
				case 62:
					if ((bitmap2 = EJfF8jOV1tUZ0DdFPgdj(settings) as Bitmap) == null)
					{
						num2 = 47;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bf623f11574746d6bf3837b66460c576 == 0)
						{
							num2 = 37;
						}
						continue;
					}
					goto case 37;
				case 29:
					if (!L5x8kVOVxYbnmfxg0sr8(nlyxDoOVNBN2tFoftXGA(settings), Guid.Empty))
					{
						num2 = 10;
						continue;
					}
					goto case 60;
				case 19:
					try
					{
						while (true)
						{
							IL_0656:
							int num9;
							if (!enumerator2.MoveNext())
							{
								num9 = 4;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6b089b0d02ae4d3186c8d2cb8a24d4d3 == 0)
								{
									num9 = 4;
								}
								goto IL_0536;
							}
							goto IL_061b;
							IL_061b:
							current3 = enumerator2.Current;
							num9 = 2;
							goto IL_0536;
							IL_0536:
							while (true)
							{
								switch (num9)
								{
								case 3:
									ClK731OUtnLesg1htdrn(current3.Value, dI7lLfOU06WQgMvuCvVk(-961162596 ^ -961027704));
									num9 = 6;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7de614af35034bd0a6867d08a2ee4a84 != 0)
									{
										num9 = 3;
									}
									continue;
								case 2:
								{
									current3.Value.Insert(0, (string)RLZ5RTOVmL7CN92leR4m(jiTtLoOUXRLcJWtYZ8a1(dI7lLfOU06WQgMvuCvVk(-43932417 ^ -43803885), OVWP4dOUCRQrwmGQ2TPe(current3.Key, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x51EF0063 ^ 0x51EE688D), "")), current3.Key));
									int num10 = 5;
									num9 = num10;
									continue;
								}
								case 6:
									stringBuilder3.Append(current3.Value);
									num9 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4459fbe344a947429d197733d274ef68 == 0)
									{
										num9 = 0;
									}
									continue;
								case 1:
									break;
								case 5:
									VOvSPsOV0HvX436LW0TS(current3.Value, 0, dI7lLfOU06WQgMvuCvVk(-683713632 ^ -683863668));
									num9 = 3;
									continue;
								default:
									goto IL_0656;
								case 4:
									goto end_IL_0656;
								}
								break;
							}
							goto IL_061b;
							continue;
							end_IL_0656:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator2).Dispose();
						int num11 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1733a11cae754a598119b94f8d9e4971 == 0)
						{
							num11 = 0;
						}
						switch (num11)
						{
						case 0:
							break;
						}
					}
					goto case 46;
				case 43:
					Atyvc6OV2uLfkrAC7WbN(text);
					num2 = 84;
					continue;
				case 97:
					text = (string)gp6m6mOVKML7jd4leSFT(documentPath, dI7lLfOU06WQgMvuCvVk(-1542190822 ^ -1542043598));
					num2 = 18;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1de08766357542bdb81146373079f817 == 0)
					{
						num2 = 7;
					}
					continue;
				case 114:
					FPlp52OVhG9lPQg1YH9i(stringBuilder7, stringBuilder10);
					num = 76;
					break;
				case 56:
					FPlp52OVhG9lPQg1YH9i(stringBuilder7, stringBuilder6);
					num2 = 48;
					continue;
				case 24:
					if (Bk22LoOVES05CXC1HrB6(settings))
					{
						num2 = 80;
						continue;
					}
					goto case 4;
				case 90:
					text2 = (string)O6LytAOViZvYx6cqNuLu(OVWP4dOUCRQrwmGQ2TPe(OVWP4dOUCRQrwmGQ2TPe(ScJ7pMOVoVZRUXPn57H5(qLY3VyOVfxVopRF0pKF1(workflowProcess)), dI7lLfOU06WQgMvuCvVk(-420003255 ^ -420072849), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4FD00585 ^ 0x4FD244CB)), dI7lLfOU06WQgMvuCvVk(-135674354 ^ -135679546), dI7lLfOU06WQgMvuCvVk(0x42311138 ^ 0x42335062)), BmJVLWOVFMrQUHaxlPXs());
					num2 = 36;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bb19f93c0a774f6cbdada859bba83212 == 0)
					{
						num2 = 31;
					}
					continue;
				case 40:
					FPlp52OVhG9lPQg1YH9i(stringBuilder, stringBuilder4);
					num2 = 92;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c559093b7320494babd70d164a6df42d == 0)
					{
						num2 = 79;
					}
					continue;
				case 32:
					try
					{
						while (true)
						{
							int num4;
							if (!bywb0bOUL1GGqXZhTSj4(enumerator))
							{
								int num3 = 3;
								num4 = num3;
								goto IL_0841;
							}
							goto IL_0891;
							IL_0841:
							while (true)
							{
								switch (num4)
								{
								case 1:
									AddActivityImages(text, stringBuilder4, current, startPoint, dictionary, dictionary2);
									num4 = 2;
									continue;
								case 2:
									break;
								default:
									goto IL_0891;
								case 3:
									goto end_IL_0877;
								}
								break;
							}
							continue;
							IL_0891:
							current = enumerator.Current;
							num4 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_de3723e1fdff427496b973d91a934ee2 == 0)
							{
								num4 = 1;
							}
							goto IL_0841;
							continue;
							end_IL_0877:
							break;
						}
					}
					finally
					{
						int num5;
						if (enumerator == null)
						{
							num5 = 1;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_9269d021c6f148b6a1c4afb8cee03b6c == 0)
							{
								num5 = 0;
							}
							goto IL_08de;
						}
						goto IL_08f4;
						IL_08f4:
						AYnRdXOUfyyMwUNuUxpJ(enumerator);
						num5 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4459fbe344a947429d197733d274ef68 != 0)
						{
							num5 = 0;
						}
						goto IL_08de;
						IL_08de:
						switch (num5)
						{
						default:
							goto end_IL_08b9;
						case 2:
							break;
						case 1:
							goto end_IL_08b9;
						case 0:
							goto end_IL_08b9;
						}
						goto IL_08f4;
						end_IL_08b9:;
					}
					goto case 28;
				case 20:
					stringBuilder4.Append((string)dI7lLfOU06WQgMvuCvVk(0x1927DA93 ^ 0x1925900F));
					num2 = 58;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a50dda04dedf4515816f963c67783c8f == 0)
					{
						num2 = 105;
					}
					continue;
				case 10:
				case 111:
					if (xFGjhxOVSkKsjVI2eDjM(settings))
					{
						num2 = 81;
						continue;
					}
					goto case 110;
				case 47:
				case 70:
					bitmap = GetBitmap();
					num2 = 58;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6fe3beca34a9422e873cd6ef331760ae != 0)
					{
						num2 = 50;
					}
					continue;
				case 92:
					FPlp52OVhG9lPQg1YH9i(stringBuilder, stringBuilder3);
					num2 = 17;
					continue;
				case 84:
				case 86:
					startPoint = default(Point);
					num2 = 7;
					continue;
				case 109:
					ClK731OUtnLesg1htdrn(stringBuilder, text2);
					num2 = 112;
					continue;
				case 104:
					ClK731OUtnLesg1htdrn(stringBuilder, dI7lLfOU06WQgMvuCvVk(-351369538 ^ -351484680));
					num2 = 8;
					continue;
				case 6:
					text = "";
					num = 5;
					break;
				case 78:
					return;
				case 87:
					if (!siidAiOVwiSt7bgLhFcH(settings))
					{
						num = 82;
						break;
					}
					goto case 44;
				case 38:
					stringBuilder3 = new StringBuilder();
					num2 = 25;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_58fb165cafed422d973d4a7156526541 == 0)
					{
						num2 = 24;
					}
					continue;
				case 46:
				case 55:
					stringBuilder10 = new StringBuilder();
					num2 = 71;
					continue;
				case 58:
					enumerator = ((ElementList)qcZXSvOUPntLFOy6myug(Q49rAeOVYin0Jc3uHYUA(workflowProcess))).GetEnumerator();
					num2 = 32;
					continue;
				case 14:
					WAFklqOV4b8TXlfb66RA(text, dI7lLfOU06WQgMvuCvVk(-1895853023 ^ -1895964829), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1716458555 ^ -1716346713));
					num2 = 17;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_67df302d7a2e4c95b7c8b62f21f3a833 == 0)
					{
						num2 = 100;
					}
					continue;
				case 79:
					dictionary2 = new Dictionary<string, StringBuilder>();
					num2 = 62;
					continue;
				case 107:
					FPlp52OVhG9lPQg1YH9i(stringBuilder, stringBuilder7);
					num2 = 64;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cfe7a0ffe67e4fea8e329ae6574ed2ca != 0)
					{
						num2 = 19;
					}
					continue;
				case 35:
					ClK731OUtnLesg1htdrn(stringBuilder, dI7lLfOU06WQgMvuCvVk(--1756698829 ^ 0x68B72C01));
					num2 = 104;
					continue;
				case 99:
					stringBuilder.Append((string)PFcoqfOUm1pZWxIM41fi(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1716629332 ^ -1716776492), oX7yTZOUy4hUPq8qPy25(dI7lLfOU06WQgMvuCvVk(0x614CF569 ^ 0x614EB4E3)), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-980570076 ^ -980422222)));
					num2 = 109;
					continue;
				case 82:
				case 116:
					ClK731OUtnLesg1htdrn(stringBuilder, dI7lLfOU06WQgMvuCvVk(-1647793954 ^ -1647647762));
					num2 = 75;
					continue;
				default:
					stringBuilder.Append((string)dI7lLfOU06WQgMvuCvVk(0x438A0E43 ^ 0x43884A15));
					num2 = 21;
					continue;
				case 30:
					ClK731OUtnLesg1htdrn(stringBuilder3, Tcc4aYOVrs4n9vH0wSnO(new string[5]
					{
						(string)dI7lLfOU06WQgMvuCvVk(-45832783 ^ -45686709),
						(string)OVWP4dOUCRQrwmGQ2TPe(text3, dI7lLfOU06WQgMvuCvVk(-351369538 ^ -351277488), ""),
						(string)dI7lLfOU06WQgMvuCvVk(0x1EA50FCC ^ 0x1EA72036),
						text3,
						SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(--601115071 ^ 0x23D60FA5)
					}));
					num2 = 69;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_eb7de45300244c968ac00be3ffdf3d29 == 0)
					{
						num2 = 55;
					}
					continue;
				case 95:
					text3 = (string)oX7yTZOUy4hUPq8qPy25(dI7lLfOU06WQgMvuCvVk(-720457373 ^ -720597849));
					num2 = 12;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6782172e84504a7baf3163b8f6b2a916 == 0)
					{
						num2 = 30;
					}
					continue;
				case 31:
					if (LHBFprOUliQyCIRAWceE(settings))
					{
						num2 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6fe3beca34a9422e873cd6ef331760ae == 0)
						{
							num2 = 9;
						}
						continue;
					}
					goto case 95;
				case 7:
					stringBuilder2 = new StringBuilder();
					num2 = 51;
					continue;
				case 93:
				case 115:
					if (!Up0NY2OVjvBKN3D1eyn9(settings))
					{
						num = 55;
						break;
					}
					goto case 41;
				case 117:
					documentationChapter.GenerateDocumentation(workflowProcess, subFolders, stringBuilder9, stringBuilder3);
					num = 61;
					break;
				case 17:
					ClK731OUtnLesg1htdrn(stringBuilder, dI7lLfOU06WQgMvuCvVk(0x42311138 ^ 0x42335BFE));
					num2 = 66;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0262725a60774e44a84fd2b93b79ee8a != 0)
					{
						num2 = 107;
					}
					continue;
				case 64:
					stringBuilder.Append(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1843E01F ^ 0x1841AAE5));
					num2 = 87;
					continue;
				case 74:
					enumerator2 = dictionary.GetEnumerator();
					num2 = 19;
					continue;
				case 83:
					FPlp52OVhG9lPQg1YH9i(stringBuilder, stringBuilder2);
					num2 = 40;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_764abb15e52f4036a7a81fce6cb70f30 != 0)
					{
						num2 = 2;
					}
					continue;
				case 67:
					ClK731OUtnLesg1htdrn(stringBuilder, dI7lLfOU06WQgMvuCvVk(-1542190822 ^ -1542042186));
					num2 = 38;
					continue;
				case 51:
					stringBuilder7 = new StringBuilder();
					num2 = 32;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_805f3361d2ba4dac8da4174f89314253 == 0)
					{
						num2 = 34;
					}
					continue;
				case 5:
					if (subFolders)
					{
						num2 = 97;
						continue;
					}
					goto case 96;
				case 16:
					ClK731OUtnLesg1htdrn(stringBuilder2, PFcoqfOUm1pZWxIM41fi(dI7lLfOU06WQgMvuCvVk(0x74AB4717 ^ 0x74A90005), RLZ5RTOVmL7CN92leR4m(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x12F686A ^ 0x12D2FE2), oX7yTZOUy4hUPq8qPy25(dI7lLfOU06WQgMvuCvVk(-682910880 ^ -683027630))), dI7lLfOU06WQgMvuCvVk(-1498811449 ^ -1498916909)));
					num2 = 89;
					continue;
				case 75:
					SavePictures(text);
					num = 14;
					break;
				case 66:
					ClK731OUtnLesg1htdrn(stringBuilder, dI7lLfOU06WQgMvuCvVk(0x56A753C9 ^ 0x56A51055));
					num2 = 15;
					continue;
				case 61:
				case 68:
				case 102:
					ClK731OUtnLesg1htdrn(stringBuilder2, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6871CA ^ 0x6A37FA));
					num2 = 23;
					continue;
				case 34:
					stringBuilder4 = new StringBuilder();
					num2 = 39;
					continue;
				case 41:
					enumerator2 = dictionary2.GetEnumerator();
					num2 = 55;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_be442748c2c44d33a71dd83576ab2ba4 != 0)
					{
						num2 = 59;
					}
					continue;
				case 94:
					GenerateScript(stringBuilder5, stringBuilder3);
					num2 = 98;
					continue;
				case 45:
					ClK731OUtnLesg1htdrn(stringBuilder2, dI7lLfOU06WQgMvuCvVk(-768800937 ^ -768651369));
					num2 = 101;
					continue;
				case 98:
					if (gNSKsCOVv1bLNY7okLMh(settings))
					{
						num = 114;
						break;
					}
					goto case 76;
				case 48:
				case 85:
					stringBuilder8 = new StringBuilder();
					num = 24;
					break;
				case 1:
					if (!L5iCUROVex2kUJvkEW5J(settings))
					{
						num2 = 102;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_eb7de45300244c968ac00be3ffdf3d29 == 0)
						{
							num2 = 87;
						}
						continue;
					}
					goto case 11;
				case 42:
					if (keyValuePair.Key == null)
					{
						num2 = 93;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cb262bcfe4074a1ab16e653815d57f28 == 0)
						{
							num2 = 4;
						}
						continue;
					}
					goto case 50;
				case 44:
					CreateSubProccessDocs(this);
					num = 116;
					break;
				case 54:
					if (documentationChapter == null)
					{
						num2 = 68;
						continue;
					}
					goto case 117;
				case 88:
					ClK731OUtnLesg1htdrn(stringBuilder2, dI7lLfOU06WQgMvuCvVk(0x101D10F ^ 0x103999B));
					num2 = 45;
					continue;
				case 50:
					AddMainMenuItem(stringBuilder3, keyValuePair.Key, (string)oX7yTZOUy4hUPq8qPy25(dI7lLfOU06WQgMvuCvVk(0x69063C81 ^ 0x690475DF)));
					num2 = 115;
					continue;
				case 22:
					if (!LHBFprOUliQyCIRAWceE(settings))
					{
						num2 = 85;
						continue;
					}
					goto case 56;
				case 23:
					ClK731OUtnLesg1htdrn(stringBuilder2, dI7lLfOU06WQgMvuCvVk(-17847711 ^ -17961741));
					num2 = 29;
					continue;
				case 59:
					try
					{
						while (true)
						{
							IL_134d:
							int num6;
							if (!enumerator2.MoveNext())
							{
								num6 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_67df302d7a2e4c95b7c8b62f21f3a833 == 0)
								{
									num6 = 5;
								}
								goto IL_1107;
							}
							goto IL_12df;
							IL_12df:
							current2 = enumerator2.Current;
							num6 = 6;
							goto IL_1107;
							IL_1107:
							while (true)
							{
								switch (num6)
								{
								case 8:
								{
									ClK731OUtnLesg1htdrn(stringBuilder7, yvO4drOUHfuybdsvbHk1(new string[4]
									{
										(string)oX7yTZOUy4hUPq8qPy25(dI7lLfOU06WQgMvuCvVk(-2057730233 ^ -2057580811)),
										(string)oX7yTZOUy4hUPq8qPy25(dI7lLfOU06WQgMvuCvVk(-420003255 ^ -420148329)),
										(string)oX7yTZOUy4hUPq8qPy25(dI7lLfOU06WQgMvuCvVk(-1393899982 ^ -1394044992)),
										(string)oX7yTZOUy4hUPq8qPy25(dI7lLfOU06WQgMvuCvVk(-351369538 ^ -351499778))
									}, true, null));
									int num7 = 3;
									num6 = num7;
									continue;
								}
								case 2:
								case 3:
									stringBuilder7.Append(current2.Value);
									num6 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_fb347e2c5dba4e0ca4d47098be7fd10c != 0)
									{
										num6 = 0;
									}
									continue;
								case 4:
									ClK731OUtnLesg1htdrn(stringBuilder7, dI7lLfOU06WQgMvuCvVk(0x75872B6 ^ 0x75A444C));
									num6 = 1;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a2041b18ca1f4a5cb8e5060163bfdb57 == 0)
									{
										num6 = 0;
									}
									continue;
								default:
									if (!(current2.Key == (string)oX7yTZOUy4hUPq8qPy25(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-768800937 ^ -768656749))))
									{
										num6 = 5;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6dd19c81ff5e41fb8db9b50574437301 == 0)
										{
											num6 = 7;
										}
										continue;
									}
									goto case 4;
								case 10:
									if (!eqIvuWOV6VlyKfVUe0AA(current2.Key, oX7yTZOUy4hUPq8qPy25(dI7lLfOU06WQgMvuCvVk(0x5F534A5C ^ 0x5F517798))))
									{
										num6 = 2;
										continue;
									}
									goto case 11;
								case 11:
									ClK731OUtnLesg1htdrn(stringBuilder7, dI7lLfOU06WQgMvuCvVk(0x65B7F624 ^ 0x65B5C04C));
									num6 = 8;
									continue;
								case 9:
									break;
								case 6:
									VOvSPsOV0HvX436LW0TS(current2.Value, 0, oUEWPaOUki4x2khEd4qP(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1965291699 ^ -1965142465), current2.Key, OVWP4dOUCRQrwmGQ2TPe(current2.Key, dI7lLfOU06WQgMvuCvVk(-432000546 ^ -431924944), "")));
									num6 = 10;
									continue;
								case 1:
								case 7:
									goto IL_134d;
								case 5:
									goto end_IL_134d;
								}
								break;
							}
							goto IL_12df;
							continue;
							end_IL_134d:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator2).Dispose();
						int num8 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f2d402219199402696ade21eab23d086 == 0)
						{
							num8 = 0;
						}
						switch (num8)
						{
						case 0:
							break;
						}
					}
					goto case 74;
				case 65:
					ClK731OUtnLesg1htdrn(stringBuilder2, dI7lLfOU06WQgMvuCvVk(0x1134D2C0 ^ 0x1136957E));
					num2 = 9;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e4c570270f54493d8f3f4763a72f63f7 == 0)
					{
						num2 = 52;
					}
					continue;
				case 76:
					FPlp52OVhG9lPQg1YH9i(stringBuilder7, stringBuilder5);
					num2 = 108;
					continue;
				case 37:
					bitmap = bitmap2;
					num = 28;
					break;
				case 73:
					stringBuilder4.Insert(0, (string)dI7lLfOU06WQgMvuCvVk(-763667953 ^ -763817887));
					num2 = 20;
					continue;
				case 108:
					ClK731OUtnLesg1htdrn(stringBuilder3, dI7lLfOU06WQgMvuCvVk(0xDF4D1F8 ^ 0xDF69B54));
					num2 = 83;
					continue;
				case 80:
					GenerateContext(stringBuilder8, stringBuilder3);
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_639c11c7bb65456db9f29c9c42f28bf7 == 0)
					{
						num2 = 57;
					}
					continue;
				case 28:
				case 72:
					if (L5iCUROVex2kUJvkEW5J(settings))
					{
						num2 = 113;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d87d9a74c9e14f96a288cc3620965fe0 != 0)
						{
							num2 = 107;
						}
						continue;
					}
					goto case 22;
				case 18:
				case 106:
					if (B6fdDLOV7dL7jykUiVbS(text))
					{
						num2 = 86;
						continue;
					}
					goto case 43;
				case 8:
					ClK731OUtnLesg1htdrn(stringBuilder, dI7lLfOU06WQgMvuCvVk(0x7AC609FE ^ 0x7AC44B50));
					num = 103;
					break;
				case 91:
					stringBuilder6 = new StringBuilder();
					num2 = 31;
					continue;
				case 33:
					AddFileWithCheck((string)gp6m6mOVKML7jd4leSFT(text, dI7lLfOU06WQgMvuCvVk(-1895853023 ^ -1895968997)));
					num2 = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e4c570270f54493d8f3f4763a72f63f7 == 0)
					{
						num2 = 2;
					}
					continue;
				case 57:
					FPlp52OVhG9lPQg1YH9i(stringBuilder7, stringBuilder8);
					num2 = 4;
					continue;
				case 77:
					ClK731OUtnLesg1htdrn(stringBuilder3, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6CC04061 ^ 0x6CC205A7));
					num2 = 91;
					continue;
				case 9:
					GenerateResponsobilityMatrix(stringBuilder6, stringBuilder3);
					num2 = 95;
					continue;
				case 60:
					stringBuilder2.Append((string)dI7lLfOU06WQgMvuCvVk(0x5BCD23A0 ^ 0x5BCF64B2) + (string)RLZ5RTOVmL7CN92leR4m(dI7lLfOU06WQgMvuCvVk(-720457373 ^ -720570645), oX7yTZOUy4hUPq8qPy25(dI7lLfOU06WQgMvuCvVk(-432000546 ^ -431851912))) + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4943E3E4 ^ 0x494247F0));
					num2 = 65;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3bb28bf622874b4689f9265e58d14823 != 0)
					{
						num2 = 42;
					}
					continue;
				case 39:
					extensionPoints = ((ComponentManager)MQtHvXOVnU25N9iIblnU()).GetExtensionPoints<IDocumentationChapter>();
					num = 90;
					break;
				case 63:
					stringBuilder.Append((string)dI7lLfOU06WQgMvuCvVk(-1647793954 ^ -1647665756));
					num2 = 67;
					continue;
				case 25:
					ClK731OUtnLesg1htdrn(stringBuilder3, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-885093259 ^ -885208927));
					num2 = 13;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d2d2252621ae43ad8d38af812176c290 == 0)
					{
						num2 = 0;
					}
					continue;
				case 27:
					ClK731OUtnLesg1htdrn(stringBuilder, dI7lLfOU06WQgMvuCvVk(0x595C500A ^ 0x595E63D2));
					num2 = 99;
					continue;
				case 101:
					dictionary = new Dictionary<string, StringBuilder>();
					num2 = 79;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d42a29e78d4a45518985de3631ade50c != 0)
					{
						num2 = 9;
					}
					continue;
				case 112:
					ClK731OUtnLesg1htdrn(stringBuilder, dI7lLfOU06WQgMvuCvVk(0x75872B6 ^ 0x75A332A));
					num2 = 26;
					continue;
				case 36:
					stringBuilder = new StringBuilder();
					num2 = 3;
					continue;
				case 105:
					stringBuilder5 = new StringBuilder();
					num = 94;
					break;
				case 26:
					ClK731OUtnLesg1htdrn(stringBuilder, jiTtLoOUXRLcJWtYZ8a1(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(--727842433 ^ 0x2B63BF31), subFolders ? "" : OVWP4dOUCRQrwmGQ2TPe(workflowProcess.Uid.ToString(), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x46EA3D1 ^ 0x46C93D3), "")));
					num2 = 6;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7d23dbc0284240b99ff34f0f55f345f6 == 0)
					{
						num2 = 35;
					}
					continue;
				case 21:
					ClK731OUtnLesg1htdrn(stringBuilder, DeXMxPOVsD04hUBfKL0E(new object[7]
					{
						text2,
						dI7lLfOU06WQgMvuCvVk(-801808857 ^ -801894739),
						(fwwNA5OVIt0Op87dwvTV(workflowProcess) > 0) ? DeXMxPOVsD04hUBfKL0E(new object[4]
						{
							oX7yTZOUy4hUPq8qPy25(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x350C0E8 ^ 0x352847C)),
							SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1514166050 ^ -1514225616),
							fwwNA5OVIt0Op87dwvTV(workflowProcess),
							SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7AC609FE ^ 0x7AC76110)
						}) : xIvGXhOUuNrAQk0jhOoR(oX7yTZOUy4hUPq8qPy25(dI7lLfOU06WQgMvuCvVk(--1212129906 ^ 0x483DE6F2)), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1386448964 ^ -1386463434)),
						oX7yTZOUy4hUPq8qPy25(dI7lLfOU06WQgMvuCvVk(-708128192 ^ -708274460)),
						dI7lLfOU06WQgMvuCvVk(0x5DB28AD2 ^ 0x5DB3E23C),
						((IWorkflowProcess)ipkwdPOVaL3xMMuieQjr(qLY3VyOVfxVopRF0pKF1(workflowProcess))).CreationDate,
						dI7lLfOU06WQgMvuCvVk(-25709590 ^ -25697128)
					}));
					num2 = 63;
					continue;
				case 11:
					documentationChapter = extensionPoints.FirstOrDefault((IDocumentationChapter m) => _003C_003Ec.lFqaNFvJIJMGr0oDOFvv(m) == DocumentationChapters.MetricAndInInndicator);
					num2 = 54;
					continue;
				case 100:
					gVtMU2OVpUb7TaWnwF4X(bitmap, gp6m6mOVKML7jd4leSFT(text, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-17847711 ^ -17960613)), (EJfF8jOV1tUZ0DdFPgdj(settings) is Bitmap) ? ImageFormat.Png : MGg0UUOVzcdZYbdZRwOf());
					num2 = 11;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a27e75af798c48d692c4325f43aa9e6b != 0)
					{
						num2 = 33;
					}
					continue;
				}
				break;
			}
		}
	}

	private void AddMainMenuItem(StringBuilder contentString, string link, string name)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				ClK731OUtnLesg1htdrn(contentString, dI7lLfOU06WQgMvuCvVk(0xDF4D1F8 ^ 0xDF6E2F0));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a680afde07ce4ae5b71c411a1f75109b == 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				ClK731OUtnLesg1htdrn(contentString, dI7lLfOU06WQgMvuCvVk(0x651FE29D ^ 0x651DD189));
				num2 = 3;
				continue;
			case 3:
				return;
			}
			ClK731OUtnLesg1htdrn(contentString, Tcc4aYOVrs4n9vH0wSnO(new string[5]
			{
				(string)dI7lLfOU06WQgMvuCvVk(0x13F63440 ^ 0x13F46F0C),
				link,
				SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x46EA3D1 ^ 0x46C8C2B),
				name,
				(string)dI7lLfOU06WQgMvuCvVk(0x17F0C5A2 ^ 0x17F16186)
			}));
			num2 = 2;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_dcdfd019631e458b9cb5fa34a16a2fe1 == 0)
			{
				num2 = 1;
			}
		}
	}

	public ProcessDocumentationGenerator(object obj)
	{
		//Discarded unreachable code: IL_001a, IL_001f
		gATlAiOAKmZ5IjfrwEyo();
		base._002Ector();
		int num = 2;
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				Files = new List<string>();
				num = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bae4e393cddc4c98b9896b25c9e18c7d != 0)
				{
					num = 0;
				}
				break;
			case 2:
				workflowProcess = obj as IWorkflowProcess;
				num = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3b4403f77a00495e957e5e4a6840e5d3 != 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public void CreateDocumentation(object wp, string path, GenerationSettings settings, bool subFolders)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 3:
				CreateDocumentationInThread();
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d7a51cf2841b436998bf3f4157fb2c9a == 0)
				{
					num2 = 7;
				}
				continue;
			case 4:
				this.settings = settings;
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5537a063960e465db83a04e35eea441b != 0)
				{
					num2 = 3;
				}
				continue;
			case 7:
				return;
			case 5:
				this.subFolders = subFolders;
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a50dda04dedf4515816f963c67783c8f != 0)
				{
					num2 = 2;
				}
				continue;
			case 6:
				return;
			case 1:
				workflowProcess = wp as IWorkflowProcess;
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bf623f11574746d6bf3837b66460c576 != 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				fileName = Path.Combine(documentPath, (string)(subFolders ? dI7lLfOU06WQgMvuCvVk(0x438A0E43 ^ 0x438855C1) : string.Format((string)dI7lLfOU06WQgMvuCvVk(0x5F534A5C ^ 0x5F511138), OVWP4dOUCRQrwmGQ2TPe(D47ZnIOVLWhW2uiBUYBe((IWorkflowProcess)wp).ToString(), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xF400DF8 ^ 0xF423DFA), ""))));
				num2 = 3;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_545887e65739480a965b7ddfab7d0632 == 0)
				{
					num2 = 4;
				}
				continue;
			}
			if (workflowProcess == null)
			{
				num2 = 6;
				continue;
			}
			documentPath = path;
			num2 = 5;
		}
	}

	static ProcessDocumentationGenerator()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				gATlAiOAKmZ5IjfrwEyo();
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f276fa9c20d4dd889000f50d886a41e == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return;
			default:
				OK = (string)oX7yTZOUy4hUPq8qPy25(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1050383744 ^ -1050267366));
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_639c11c7bb65456db9f29c9c42f28bf7 != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	internal static int oX00LLOUJXUr4FDZmJ40(object P_0)
	{
		return ((ICollection<IResponsibilityMatrixItem>)P_0).Count;
	}

	internal static bool LHBFprOUliQyCIRAWceE(object P_0)
	{
		return ((GenerationSettings)P_0).ResponsibilityMatrOk;
	}

	internal static object dI7lLfOU06WQgMvuCvVk(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object oX7yTZOUy4hUPq8qPy25(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static object PFcoqfOUm1pZWxIM41fi(object P_0, object P_1, object P_2)
	{
		return (string)P_0 + (string)P_1 + (string)P_2;
	}

	internal static object ClK731OUtnLesg1htdrn(object P_0, object P_1)
	{
		return ((StringBuilder)P_0).Append((string)P_1);
	}

	internal static object AUVWdmOUbF9nnLmOHnrU(Enum P_0)
	{
		return P_0.GetDisplayName();
	}

	internal static bool F8dg7TOU5fruDbKlFbUk(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}

	internal static Guid JQ6ir1OUgIorSxVO877K(object P_0)
	{
		return ((IResponsibilityMatrixItem)P_0).WorkerType;
	}

	internal static Type H2jlV0OUBCwB2dENQItR(object P_0, Guid P_1, bool P_2)
	{
		return ((IMetadataRuntimeService)P_0).GetTypeByUid(P_1, P_2);
	}

	internal static object ylxc1oOUcJOKflHcoqnS(object P_0, object P_1)
	{
		return ((IEntityManager)P_0).LoadOrNull(P_1);
	}

	internal static object qcZXSvOUPntLFOy6myug(object P_0)
	{
		return ((Diagram)P_0).Elements;
	}

	internal static object jiTtLoOUXRLcJWtYZ8a1(object P_0, object P_1)
	{
		return string.Format((string)P_0, P_1);
	}

	internal static object PLVg7qOUdIGTNfN9TB6y(object P_0)
	{
		return ((string)P_0).Trim();
	}

	internal static object xIvGXhOUuNrAQk0jhOoR(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static object Pf4vfEOUDatn3NOrsTS9(object P_0)
	{
		return ((Element)P_0).Name;
	}

	internal static bool cjEK85OUnnMFMl3Rv5I3(object P_0)
	{
		return ((IResponsibilityMatrixItem)P_0).IsCurator;
	}

	internal static object yvO4drOUHfuybdsvbHk1(object P_0, bool isBold, object P_2)
	{
		return HTMLUtility.InsertRowToTable((string[])P_0, isBold, (string[])P_2);
	}

	internal static bool bywb0bOUL1GGqXZhTSj4(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void AYnRdXOUfyyMwUNuUxpJ(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static bool NGN8d1OU8Ysf7p69vmZa()
	{
		return RK7MMCOUYWmxAyURJ4TA == null;
	}

	internal static ProcessDocumentationGenerator DK7ZMhOUsbDHWBToNEFd()
	{
		return RK7MMCOUYWmxAyURJ4TA;
	}

	internal static object VuBJ4YOU9ARFWyj1rngG(object P_0)
	{
		return ((IWorkflowProcess)P_0).Context;
	}

	internal static bool NM6VmHOUWgOl7FlcM8Ba(object P_0, object P_1)
	{
		return ((AbstractMetadata)P_0).Equals((AbstractMetadata)P_1);
	}

	internal static Guid yLU0UiOUjEavxSYbldBU(object P_0)
	{
		return ((PropertyMetadata)P_0).SubTypeUid;
	}

	internal static object TMQu7QOURvhFO1eEnb59(Guid P_0, bool P_1, bool P_2)
	{
		return MetadataLoader.LoadMetadata(P_0, P_1, P_2);
	}

	internal static bool QLKUT7OU6CywWeSa8Njo(object P_0, object P_1)
	{
		return (string)P_0 != (string)P_1;
	}

	internal static Guid EXANBJOUq8y8CPg3xXqk(object P_0)
	{
		return ((PropertyMetadata)P_0).TypeUid;
	}

	internal static object M19phXOU35AGJK5PAvoY(object P_0, Guid P_1, Guid P_2)
	{
		return ((IMetadataService)P_0).GetTypeDescriptor(P_1, P_2);
	}

	internal static object tVI60qOUTioYETFCiYWO(object P_0)
	{
		return ((ITypeDescriptor)P_0).Name;
	}

	internal static object HgRnvwOUQcwyfmoTpVL2(object P_0, object P_1)
	{
		return ((IPropertyTypeInfo)P_0).GetPropertyTypeDisplayName((PropertyMetadata)P_1);
	}

	internal static Guid ex6B4YOUpp4ZIC4kvvpc(object P_0)
	{
		return ((AbstractMetadata)P_0).Uid;
	}

	internal static object OVWP4dOUCRQrwmGQ2TPe(object P_0, object P_1, object P_2)
	{
		return ((string)P_0).Replace((string)P_1, (string)P_2);
	}

	internal static object anbHIGOUMdIO2lvFMMS7(object P_0)
	{
		return ((NamedMetadata)P_0).DisplayName;
	}

	internal static object oUEWPaOUki4x2khEd4qP(object P_0, object P_1, object P_2)
	{
		return string.Format((string)P_0, P_1, P_2);
	}

	internal static object l0fMBlOUU0K8cDdLCWmi(object P_0)
	{
		return ((NamedMetadata)P_0).Name;
	}

	internal static bool F7WOM8OUVkSCAdqAfDCv(object P_0)
	{
		return ((EntityPropertyMetadata)P_0).InFastSearch;
	}

	internal static bool kAlU2JOUAv1d4XyP53xU(object P_0)
	{
		return ((EntityPropertyMetadata)P_0).Input;
	}

	internal static bool QysBBHOUGNu2pJLVeIGI(object P_0)
	{
		return ((EntityPropertyMetadata)P_0).Output;
	}

	internal static object XBWaqvOU7DZYw4J3qXZy(object P_0)
	{
		return ((NamedMetadata)P_0).Description;
	}

	internal static object U8UZjhOU29YpFRPG95Mj(object P_0)
	{
		return ((TablePartMetadata)P_0).TablePartPropertyName;
	}

	internal static object UKbvEQOUoDSN2TaTBY4s(object P_0, object P_1)
	{
		return SR.T((string)P_0, (object[])P_1);
	}

	internal static bool Fvqkc7OUFqaxNVAn5LQC(object P_0)
	{
		return ((TablePartMetadata)P_0).Output;
	}

	internal static int wR6p6COUiodd1SfxSQdY(object P_0)
	{
		return ((ICollection<EntityPropertyMetadata>)P_0).Count;
	}

	internal static object rkilE2OUIyEZEIoBHlI8(object P_0)
	{
		return ((IWorkflowProcess)P_0).ScriptModule;
	}

	internal static object WjrnBYOUaeOJmBlTIweM(object P_0)
	{
		return ((ScriptModule)P_0).SourceCode;
	}

	internal static bool o9FJ9QOUrYEypCOPn8yJ(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object tyXqmHOUebdwBbeb8UXE(object P_0, object P_1, RegexOptions P_2)
	{
		return Regex.Matches((string)P_0, (string)P_1, P_2);
	}

	internal static int QbKftSOUNla9tlXNyslB(object P_0)
	{
		return ((MatchCollection)P_0).Count;
	}

	internal static object O6o5vXOUxgfsCpDoD8O0(object P_0)
	{
		return ((IEnumerator)P_0).Current;
	}

	internal static int Onhm7COUSvON2n2CpCF4(object P_0, char P_1, int P_2)
	{
		return ((string)P_0).LastIndexOf(P_1, P_2);
	}

	internal static int oclssGOU1kVEcrYBwqRX(object P_0, char P_1, int P_2)
	{
		return ((string)P_0).IndexOf(P_1, P_2);
	}

	internal static int w1HK49OUhyaLECAmuPQb(object P_0, char P_1)
	{
		return ((string)P_0).LastIndexOf(P_1);
	}

	internal static object iewM7pOUEDldMGRIExqa(object P_0, object P_1)
	{
		return string.Format((string)P_0, (object[])P_1);
	}

	internal static object HeVqrmOUwdsUDCjPSmXT(object P_0, int P_1, object P_2)
	{
		return ((string)P_0).Insert(P_1, (string)P_2);
	}

	internal static object SfplsROU4p36gvFJ4x3u(object P_0)
	{
		return ((Exception)P_0).Message;
	}

	internal static void jn3PmvOUzftQ1pdyC3ZY(object P_0, object P_1, object P_2, object P_3)
	{
		((ILogger)P_0).Error((Exception)P_1, (string)P_2, (object[])P_3);
	}

	internal static object gp6m6mOVKML7jd4leSFT(object P_0, object P_1)
	{
		return Path.Combine((string)P_0, (string)P_1);
	}

	internal static void MwW43fOVO0LI66c3Pw73(object P_0, object P_1)
	{
		((TextWriter)P_0).Write((string)P_1);
	}

	internal static void jZqEYhOVZIunubwsvPpF(object P_0)
	{
		((TextWriter)P_0).Close();
	}

	internal static bool gNSKsCOVv1bLNY7okLMh(object P_0)
	{
		return ((GenerationSettings)P_0).NotificationOk;
	}

	internal static object Q49rAeOVYin0Jc3uHYUA(object P_0)
	{
		return ((IWorkflowProcess)P_0).Diagram;
	}

	internal static object GDRKTJOV8VDP82rmejxY(object P_0)
	{
		return ((ConnectorHV)P_0).Points;
	}

	internal static object DeXMxPOVsD04hUBfKL0E(object P_0)
	{
		return string.Concat((object[])P_0);
	}

	internal static object waDkjsOVJrSXl3f2IY0G(object P_0)
	{
		return ((Connector)P_0).EndElement;
	}

	internal static Guid dkBjQ2OVldm99PEfG5Pd(object P_0)
	{
		return ((Element)P_0).Uid;
	}

	internal static object VOvSPsOV0HvX436LW0TS(object P_0, int P_1, object P_2)
	{
		return ((StringBuilder)P_0).Insert(P_1, (string)P_2);
	}

	internal static bool Hv4tcsOVylSb65yXV33G(object P_0)
	{
		return string.IsNullOrWhiteSpace((string)P_0);
	}

	internal static object RLZ5RTOVmL7CN92leR4m(object P_0, object P_1)
	{
		return HTMLUtility.InsertHyperLink((string)P_0, (string)P_1);
	}

	internal static long jZl3jpOVtxjxb4hF3Kjp(object P_0)
	{
		return ((SwimlaneElement)P_0).DepartmentId;
	}

	internal static object LpfXCqOVbGTeE8kDoCKc(object P_0)
	{
		return ((IOrganizationItem)P_0).Name;
	}

	internal static object pG5EEyOV5kR8PNhAxONS(object P_0)
	{
		return ((EntityPropertyMetadata)P_0).SimpleTypeSettings;
	}

	internal static Guid YJM91XOVgJb6sqSPk6RS(object P_0)
	{
		return ((Worker)P_0).WorkerType;
	}

	internal static Guid rDnrjZOVBFbW8R0J0Ts5()
	{
		return OrganizationItemDTO.MetadataUid;
	}

	internal static object YNa9YOOVcnhpEyxKnkRm()
	{
		return OrganizationItemManager.Instance;
	}

	internal static long ScTmFVOVPSxo5b4npGfl(object P_0)
	{
		return ((Worker)P_0).WorkerId;
	}

	internal static object A3doD0OVXJtkUH2QRDKb()
	{
		return UserGroupManager.Instance;
	}

	internal static object zSrkBJOVdalIgKFeiklW(object P_0)
	{
		return ((IUserGroup)P_0).Name;
	}

	internal static object p9v6FpOVuyuGfsrY1EFa(object P_0)
	{
		return ((Element)P_0).ExtendedSettings;
	}

	internal static object xW3lOpOVDUFoi9DSHU8J(object P_0, object P_1)
	{
		return ((ElementExtendedSettings)P_0)[(string)P_1];
	}

	internal static object MQtHvXOVnU25N9iIblnU()
	{
		return ComponentManager.Current;
	}

	internal static bool QIrUwoOVHi2jWlR65XnE(object P_0)
	{
		return CheckProcessContextExistence(P_0);
	}

	internal static Guid D47ZnIOVLWhW2uiBUYBe(object P_0)
	{
		return ((IWorkflowProcess)P_0).Uid;
	}

	internal static object qLY3VyOVfxVopRF0pKF1(object P_0)
	{
		return ((IWorkflowProcess)P_0).Header;
	}

	internal static Guid W3BgcOOV9dKx1pXVh6NC(object P_0)
	{
		return ((IProcessHeader)P_0).Uid;
	}

	internal static object GspGpOOVWRNbjdwqfKN1(object P_0)
	{
		return ((Element)P_0).DefaultName;
	}

	internal static bool Up0NY2OVjvBKN3D1eyn9(object P_0)
	{
		return ((GenerationSettings)P_0).TasksOk;
	}

	internal static object u29ZApOVRsFaZX4dOxJJ(object P_0)
	{
		return ((Connector)P_0).StartElement;
	}

	internal static bool eqIvuWOV6VlyKfVUe0AA(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static object rHXxTZOVqAbfx8CQjQxc(object P_0)
	{
		return ((IWorkflowProcess)P_0).Forms;
	}

	internal static object iFGolPOV3sxseB65duZF(object P_0)
	{
		return ((WorkflowForm)P_0).FormDisplayName;
	}

	internal static object uTZlGNOVTK78YWXlQLfq()
	{
		return Resources.BPMNProcess16;
	}

	internal static object b6nQVIOVQhfYAMXWHXOm()
	{
		return ImageFormat.Png;
	}

	internal static void gVtMU2OVpUb7TaWnwF4X(object P_0, object P_1, object P_2)
	{
		((Image)P_0).Save((string)P_1, (ImageFormat)P_2);
	}

	internal static object EIP2QFOVCvShBDwleCTQ()
	{
		return Resources.bg_menu;
	}

	internal static object CkDBgCOVM8gs3RZOYbDJ(object P_0, int P_1, int P_2)
	{
		return ((string)P_0).Remove(P_1, P_2);
	}

	internal static float cgsSOmOVkCTtV69MUStS(object P_0)
	{
		return ((Diagram)P_0).Width;
	}

	internal static object V3HCghOVUNLhO7KdqpLi(object P_0, object P_1)
	{
		return ((Diagram)P_0).CreateElementShape((Element)P_1);
	}

	internal static NRectangleF mtem0eOVVq2P4oLWN0UR(object P_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((NModel)P_0).get_Bounds();
	}

	internal static float uJ9MSmOVApWc9mtja7vD(object P_0)
	{
		return ((NModel)P_0).get_Width();
	}

	internal static void UiSqboOVG10QX0alD0IV(object P_0, object P_1)
	{
		((NCanvas)P_0).RenderToGraphics((Graphics)P_1);
	}

	internal static bool B6fdDLOV7dL7jykUiVbS(object P_0)
	{
		return Directory.Exists((string)P_0);
	}

	internal static object Atyvc6OV2uLfkrAC7WbN(object P_0)
	{
		return Directory.CreateDirectory((string)P_0);
	}

	internal static object ScJ7pMOVoVZRUXPn57H5(object P_0)
	{
		return ((IProcessHeader)P_0).Name;
	}

	internal static object BmJVLWOVFMrQUHaxlPXs()
	{
		return CultureInfo.InvariantCulture;
	}

	internal static object O6LytAOViZvYx6cqNuLu(object P_0, object P_1)
	{
		return ((string)P_0).ToString((IFormatProvider)P_1);
	}

	internal static long fwwNA5OVIt0Op87dwvTV(object P_0)
	{
		return ((IWorkflowProcess)P_0).VersionNumber;
	}

	internal static object ipkwdPOVaL3xMMuieQjr(object P_0)
	{
		return ((IProcessHeader)P_0).Current;
	}

	internal static object Tcc4aYOVrs4n9vH0wSnO(object P_0)
	{
		return string.Concat((string[])P_0);
	}

	internal static bool L5iCUROVex2kUJvkEW5J(object P_0)
	{
		return ((GenerationSettings)P_0).MetricsOk;
	}

	internal static Guid nlyxDoOVNBN2tFoftXGA(object P_0)
	{
		return ((GenerationSettings)P_0).ParentProcessUid;
	}

	internal static bool L5x8kVOVxYbnmfxg0sr8(Guid P_0, Guid P_1)
	{
		return P_0 != P_1;
	}

	internal static bool xFGjhxOVSkKsjVI2eDjM(object P_0)
	{
		return ((GenerationSettings)P_0).GenerationType;
	}

	internal static object EJfF8jOV1tUZ0DdFPgdj(object P_0)
	{
		return ((GenerationSettings)P_0).ImageDiagram;
	}

	internal static object FPlp52OVhG9lPQg1YH9i(object P_0, object P_1)
	{
		return ((StringBuilder)P_0).Append(P_1);
	}

	internal static bool Bk22LoOVES05CXC1HrB6(object P_0)
	{
		return ((GenerationSettings)P_0).ContexOk;
	}

	internal static bool siidAiOVwiSt7bgLhFcH(object P_0)
	{
		return ((GenerationSettings)P_0).SubProcessOk;
	}

	internal static void WAFklqOV4b8TXlfb66RA(object P_0, object P_1, object P_2)
	{
		SaveFile(P_0, P_1, P_2);
	}

	internal static object MGg0UUOVzcdZYbdZRwOf()
	{
		return ImageFormat.Bmp;
	}

	internal static void gATlAiOAKmZ5IjfrwEyo()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}
}
