using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Workflow.Managers;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Workflow.Components;

[Component]
internal sealed class WorkflowLinkedFinder : WorkflowLinkedFinderBase
{
	internal static WorkflowLinkedFinder HlosJXOmnaRkgtiNfKEL;

	public WorkflowLinkedFinder(ProcessHeaderManager processHeaderManager)
	{
		//Discarded unreachable code: IL_002b, IL_0030
		owa7JJOmfW3eUQWbkles();
		base._002Ector(processHeaderManager);
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ba57b850b1d34fd9bce66a583e71dc16 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public override FindLinkedObjectsResult FindLinkedObjects(ICollection<ILinkedObject> objectsToSearch, LinkedObjectsContext context)
	{
		_003C_003Ec__DisplayClass1_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass1_0();
		CS_0024_003C_003E8__locals0._003C_003E4__this = this;
		CS_0024_003C_003E8__locals0.context = context;
		CS_0024_003C_003E8__locals0.resultObj = new FindLinkedObjectsResult();
		ICollection<IProcessHeader> processHeaders = GetProcessHeaders(objectsToSearch, CS_0024_003C_003E8__locals0.context);
		CS_0024_003C_003E8__locals0.subHeaders = new List<IProcessHeader>();
		processHeaders.ForEach(delegate(IProcessHeader header)
		{
			//Discarded unreachable code: IL_00df, IL_0116, IL_0125
			int num11 = 4;
			int num12 = num11;
			ClassMetadata classMetadata2 = default(ClassMetadata);
			IMetadata metadata2 = default(IMetadata);
			while (true)
			{
				switch (num12)
				{
				case 6:
					return;
				case 1:
				case 2:
				case 8:
					CS_0024_003C_003E8__locals0._003C_003E4__this.FillInternalSubProcessList(header, CS_0024_003C_003E8__locals0.subHeaders);
					num12 = 6;
					break;
				case 5:
					if ((classMetadata2 = metadata2 as ClassMetadata) == null)
					{
						num12 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6782172e84504a7baf3163b8f6b2a916 == 0)
						{
							num12 = 2;
						}
						break;
					}
					goto case 7;
				case 7:
					_003C_003Ec__DisplayClass1_0.VlU71ovOrZhGSOx5Nj6j(CS_0024_003C_003E8__locals0._003C_003E4__this, classMetadata2, CS_0024_003C_003E8__locals0.context, CS_0024_003C_003E8__locals0.resultObj);
					num12 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f19dffab164a41148300de28b2deec39 == 0)
					{
						num12 = 0;
					}
					break;
				case 3:
					if (metadata2 == null)
					{
						num12 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_18b351a59a324c25b4f150a9771bcf69 == 0)
						{
							num12 = 1;
						}
						break;
					}
					goto case 5;
				default:
					_003C_003Ec__DisplayClass1_0.MBN8ROvONelW5VussbVe(CS_0024_003C_003E8__locals0._003C_003E4__this, _003C_003Ec__DisplayClass1_0.KhfoFWvOe336qn5ROc20(classMetadata2), CS_0024_003C_003E8__locals0.context, CS_0024_003C_003E8__locals0.resultObj);
					num12 = 8;
					break;
				case 4:
					metadata2 = CS_0024_003C_003E8__locals0._003C_003E4__this.GetMetadata(_003C_003Ec__DisplayClass1_0.GTVhwqvOambpidmZpqkn(header), CS_0024_003C_003E8__locals0.context, CS_0024_003C_003E8__locals0.resultObj);
					num12 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1733a11cae754a598119b94f8d9e4971 != 0)
					{
						num12 = 3;
					}
					break;
				}
			}
		});
		CS_0024_003C_003E8__locals0.subHeaders.ForEach(delegate(IProcessHeader header)
		{
			//Discarded unreachable code: IL_0088
			int num9 = 5;
			int num10 = num9;
			ClassMetadata classMetadata = default(ClassMetadata);
			IMetadata metadata = default(IMetadata);
			while (true)
			{
				switch (num10)
				{
				case 3:
					_003C_003Ec__DisplayClass1_0.MBN8ROvONelW5VussbVe(CS_0024_003C_003E8__locals0._003C_003E4__this, _003C_003Ec__DisplayClass1_0.KhfoFWvOe336qn5ROc20(classMetadata), CS_0024_003C_003E8__locals0.context, CS_0024_003C_003E8__locals0.resultObj);
					num10 = 2;
					continue;
				case 5:
					metadata = (IMetadata)_003C_003Ec__DisplayClass1_0.js5vd5vOxcKQ8oXxd4K0(CS_0024_003C_003E8__locals0._003C_003E4__this, _003C_003Ec__DisplayClass1_0.GTVhwqvOambpidmZpqkn(header), CS_0024_003C_003E8__locals0.context);
					num10 = 4;
					continue;
				case 1:
					return;
				case 2:
					return;
				case 4:
					if (metadata == null)
					{
						return;
					}
					num10 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d42a29e78d4a45518985de3631ade50c == 0)
					{
						num10 = 0;
					}
					continue;
				default:
					if ((classMetadata = metadata as ClassMetadata) == null)
					{
						num10 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e9561fecdd4d49678d9f9ea7d295fb1b != 0)
						{
							num10 = 1;
						}
						continue;
					}
					break;
				case 6:
					break;
				}
				_003C_003Ec__DisplayClass1_0.VlU71ovOrZhGSOx5Nj6j(CS_0024_003C_003E8__locals0._003C_003E4__this, classMetadata, CS_0024_003C_003E8__locals0.context, CS_0024_003C_003E8__locals0.resultObj);
				num10 = 3;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_639c11c7bb65456db9f29c9c42f28bf7 != 0)
				{
					num10 = 0;
				}
			}
		});
		CS_0024_003C_003E8__locals0.headersToAdd = new List<IProcessHeader>();
		processHeaders.ForEach(delegate(IProcessHeader header)
		{
			int num7 = 1;
			int num8 = num7;
			while (true)
			{
				switch (num8)
				{
				default:
					return;
				case 1:
					CS_0024_003C_003E8__locals0._003C_003E4__this.FillSubProcessList(CS_0024_003C_003E8__locals0.context, header, CS_0024_003C_003E8__locals0.headersToAdd);
					num8 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_978f838cc41a4debb9700ede4b63f820 == 0)
					{
						num8 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		});
		CS_0024_003C_003E8__locals0.headersToAdd.ForEach(delegate(IProcessHeader header)
		{
			int num5 = 1;
			int num6 = num5;
			while (true)
			{
				switch (num6)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					_003C_003Ec__DisplayClass1_0.kKNwVKvOSxVeCcOqJW0u(CS_0024_003C_003E8__locals0._003C_003E4__this, CS_0024_003C_003E8__locals0.resultObj, CS_0024_003C_003E8__locals0.context, _003C_003Ec__DisplayClass1_0.GTVhwqvOambpidmZpqkn(header));
					num6 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f19dffab164a41148300de28b2deec39 == 0)
					{
						num6 = 0;
					}
					break;
				}
			}
		});
		processHeaders.ForEach(delegate(IProcessHeader header)
		{
			int num3 = 1;
			int num4 = num3;
			while (true)
			{
				switch (num4)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					CS_0024_003C_003E8__locals0.context.LoadedData[_003C_003Ec__DisplayClass1_0.GTVhwqvOambpidmZpqkn(header)] = header;
					num4 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e8980a9fd9d44c20920ffa276900c96f == 0)
					{
						num4 = 0;
					}
					break;
				}
			}
		});
		CS_0024_003C_003E8__locals0.headersToAdd.ForEach(delegate(IProcessHeader header)
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
					CS_0024_003C_003E8__locals0.context.LoadedData[_003C_003Ec__DisplayClass1_0.GTVhwqvOambpidmZpqkn(header)] = header;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1a2d7634479d44fb8d3718c31b05f73c != 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		});
		return CS_0024_003C_003E8__locals0.resultObj;
	}

	protected override IMetadata GetMetadataWithUid(Guid metadataId, LinkedObjectsContext context)
	{
		//Discarded unreachable code: IL_0039, IL_0048, IL_0059, IL_0087, IL_0096
		int num = 5;
		int num2 = num;
		IProcessHeader header = default(IProcessHeader);
		while (true)
		{
			object obj;
			switch (num2)
			{
			default:
				obj = null;
				goto IL_00d8;
			case 5:
				header = GetHeader(metadataId, context);
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3f8a84e2cb374827a50ba2cbcf11cf48 == 0)
				{
					num2 = 4;
				}
				break;
			case 1:
				return ((IWorkflowProcess)Pevh5COm9cNYbLdhhmvZ(header)).Context;
			case 2:
				return null;
			case 4:
				if (header != null)
				{
					num2 = 3;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_39af03d004af472bb66e60f46e79703a == 0)
					{
						num2 = 2;
					}
					break;
				}
				goto default;
			case 3:
				{
					obj = Pevh5COm9cNYbLdhhmvZ(header);
					goto IL_00d8;
				}
				IL_00d8:
				if (obj == null)
				{
					num2 = 2;
					break;
				}
				goto case 1;
			}
		}
	}

	private void FillSubProcessList(LinkedObjectsContext context, IProcessHeader header, List<IProcessHeader> headersToAdd)
	{
		using List<IProcessHeader>.Enumerator enumerator = ProcessHeaderManager.GetSubprocessTreeList(header.Uid, onlyExternal: true).GetEnumerator();
		while (enumerator.MoveNext())
		{
			_003C_003Ec__DisplayClass3_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass3_0();
			CS_0024_003C_003E8__locals0.headerSP = enumerator.Current;
			if (CS_0024_003C_003E8__locals0.headerSP != null && CS_0024_003C_003E8__locals0.headerSP.Status != WorkflowProcessStatus.Deleted && headersToAdd.All((IProcessHeader hdr) => _003C_003Ec__DisplayClass3_0.ArR78EvO4KTDLp8XbSAN(_003C_003Ec__DisplayClass3_0.I3JK8LvOws2ChxjRJVJb(CS_0024_003C_003E8__locals0.headerSP), _003C_003Ec__DisplayClass3_0.I3JK8LvOws2ChxjRJVJb(hdr))) && context.CheckedObjects.All((ILinkedObject c) => _003C_003Ec__DisplayClass3_0.hq6WUGvOz1950hmbBPWI(c) != _003C_003Ec__DisplayClass3_0.I3JK8LvOws2ChxjRJVJb(CS_0024_003C_003E8__locals0.headerSP)))
			{
				headersToAdd.Add(CS_0024_003C_003E8__locals0.headerSP);
			}
		}
	}

	private void FillInternalSubProcessList(IProcessHeader header, List<IProcessHeader> headersToAdd)
	{
		using IEnumerator<IProcessHeader> enumerator = ((IEnumerable<IProcessHeader>)header.SubHeaders).GetEnumerator();
		while (enumerator.MoveNext())
		{
			_003C_003Ec__DisplayClass4_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass4_0();
			CS_0024_003C_003E8__locals0.headerSP = enumerator.Current;
			if (CS_0024_003C_003E8__locals0.headerSP != null && CS_0024_003C_003E8__locals0.headerSP.Status != WorkflowProcessStatus.Deleted && headersToAdd.All((IProcessHeader hdr) => _003C_003Ec__DisplayClass4_0.aMXl6tvZ88TTd0g1o2gr(_003C_003Ec__DisplayClass4_0.TZ1gQKvZYHIdRdwWkEVF(CS_0024_003C_003E8__locals0.headerSP), _003C_003Ec__DisplayClass4_0.TZ1gQKvZYHIdRdwWkEVF(hdr))))
			{
				headersToAdd.Add(CS_0024_003C_003E8__locals0.headerSP);
				FillInternalSubProcessList(CS_0024_003C_003E8__locals0.headerSP, headersToAdd);
			}
		}
	}

	internal static void owa7JJOmfW3eUQWbkles()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static bool q14eljOmH3l4R2XTs2LI()
	{
		return HlosJXOmnaRkgtiNfKEL == null;
	}

	internal static WorkflowLinkedFinder iJsCKmOmLGwdOLak5Fc0()
	{
		return HlosJXOmnaRkgtiNfKEL;
	}

	internal static object Pevh5COm9cNYbLdhhmvZ(object P_0)
	{
		return ((IProcessHeader)P_0).Current;
	}
}
