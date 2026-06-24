using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Workflow.Services;

[Service]
internal sealed class WorkflowProcessDependencyService : IWorkflowProcessDependencyService
{
	private readonly IDependencyService dependencyService;

	private readonly ISearchMetadataService searchMetadataService;

	internal static WorkflowProcessDependencyService Gfgbw9k10nHS2cI2SZB;

	public WorkflowProcessDependencyService(IDependencyService dependencyService, ISearchMetadataService searchMetadataService)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		jpHraqkwoENPO16yDrk();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1c37d4e24e094858975336738e156495 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				this.dependencyService = dependencyService;
				num = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_58fb165cafed422d973d4a7156526541 == 0)
				{
					num = 0;
				}
				break;
			case 2:
				return;
			default:
				this.searchMetadataService = searchMetadataService;
				num = 2;
				break;
			}
		}
	}

	public void CollectDependencies(IWorkflowProcess process)
	{
		//Discarded unreachable code: IL_0182, IL_01fa, IL_0219, IL_0228, IL_0255
		int num = 7;
		ProcessContext context = default(ProcessContext);
		List<ProcessContext> list = default(List<ProcessContext>);
		_003C_003Ec__DisplayClass3_0 _003C_003Ec__DisplayClass3_ = default(_003C_003Ec__DisplayClass3_0);
		MetadataServiceContext metadataServiceContext = default(MetadataServiceContext);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 5:
					return;
				case 3:
					if (oLYOe6k4OtTfB4YIFcX(context) != null)
					{
						list = new List<ProcessContext>();
						num2 = 4;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1b8b735647da470aa2d45d64d6f538d1 != 0)
						{
							num2 = 4;
						}
					}
					else
					{
						num2 = 5;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f870ea690334e7ab7599d275d195e9a == 0)
						{
							num2 = 0;
						}
					}
					continue;
				case 6:
					_003C_003Ec__DisplayClass3_.process = process;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_be442748c2c44d33a71dd83576ab2ba4 == 0)
					{
						num2 = 0;
					}
					continue;
				case 4:
					GetAllContexts(_003C_003Ec__DisplayClass3_.process, list);
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f19dffab164a41148300de28b2deec39 == 0)
					{
						num2 = 0;
					}
					continue;
				case 1:
					metadataServiceContext = MetadataServiceContext.Extend(((IEnumerable<IMetadata>)searchMetadataService.GetPublishedDataClasses().ToList()).Concat((IEnumerable<IMetadata>)list).Concat(searchMetadataService.GetPublishedFunctions()).Concat(searchMetadataService.GetPublishedComponents()));
					num2 = 8;
					continue;
				case 8:
					try
					{
						IEnumerable<FormViewItem> forms = from f in ((WorkflowFormsContainer)oYq1vPkzpwWwEjKw3R4(_003C_003Ec__DisplayClass3_.process)).Items.Select(_003C_003Ec__DisplayClass3_._003CCollectDependencies_003Eb__0)
							where _003C_003Ec.LRbeXDZ25vVPQ5p9XysQ(f) == RuntimeVersion.Version2
							select f;
						int num3 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f19dffab164a41148300de28b2deec39 != 0)
						{
							num3 = 1;
						}
						while (true)
						{
							switch (num3)
							{
							default:
								return;
							case 1:
								msddfYUK5sqyV4K3YJt(_003C_003Ec__DisplayClass3_.process, dependencyService.GetClassMetadataDependencies(context.ViewModelMetadata, null, forms));
								num3 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b876fa7b083748c8abf8c4b192a11078 != 0)
								{
									num3 = 0;
								}
								break;
							case 0:
								return;
							}
						}
					}
					finally
					{
						int num4;
						if (metadataServiceContext == null)
						{
							num4 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e9561fecdd4d49678d9f9ea7d295fb1b != 0)
							{
								num4 = 0;
							}
							goto IL_01fe;
						}
						goto IL_0233;
						IL_0233:
						UHmSQjUOD8WtHaNHjAK(metadataServiceContext);
						num4 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d7a51cf2841b436998bf3f4157fb2c9a == 0)
						{
							num4 = 1;
						}
						goto IL_01fe;
						IL_01fe:
						switch (num4)
						{
						default:
							goto end_IL_01d9;
						case 0:
							goto end_IL_01d9;
						case 2:
							break;
						case 1:
							goto end_IL_01d9;
						}
						goto IL_0233;
						end_IL_01d9:;
					}
				case 2:
					return;
				case 7:
					_003C_003Ec__DisplayClass3_ = new _003C_003Ec__DisplayClass3_0();
					num2 = 6;
					continue;
				}
				break;
			}
			context = _003C_003Ec__DisplayClass3_.process.Context;
			num = 3;
		}
	}

	private void GetAllContexts(IWorkflowProcess process, IList<ProcessContext> contextList)
	{
		ProcessContext context = process.Context;
		if (context.ViewModelMetadata == null)
		{
			return;
		}
		ProcessContext processContext = ClassSerializationHelper.CloneObjectByXml(context);
		processContext.Properties.Clear();
		processContext.Properties.AddRange((IEnumerable<PropertyMetadata>)context.EntityProperties);
		processContext.TableParts.Clear();
		processContext.TableParts.AddRange((IEnumerable<TablePartMetadata>)context.EntityTableParts);
		foreach (TablePartMetadata tablePart in processContext.TableParts)
		{
			CopyTableParts(tablePart);
		}
		contextList.Add(processContext);
		if (process.Parent != null)
		{
			GetAllContexts(process.Parent, contextList);
		}
	}

	private static void CopyTableParts(object metadata)
	{
		//Discarded unreachable code: IL_00d1, IL_00e0, IL_0171, IL_0184, IL_0193
		int num = 5;
		int num2 = num;
		List<TablePartMetadata>.Enumerator enumerator = default(List<TablePartMetadata>.Enumerator);
		while (true)
		{
			switch (num2)
			{
			case 5:
				DggBMXUZkx0tD9bToBQ(((ClassMetadata)metadata).Properties);
				num2 = 4;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cb262bcfe4074a1ab16e653815d57f28 == 0)
				{
					num2 = 4;
				}
				break;
			case 4:
				((ClassMetadata)metadata).Properties.AddRange((IEnumerable<PropertyMetadata>)((EntityMetadata)metadata).EntityProperties);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bd84f42638494cb6b4427f8e13ec59af == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				((EntityMetadata)metadata).TableParts.AddRange((IEnumerable<TablePartMetadata>)((EntityMetadata)metadata).EntityTableParts);
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_85ba8d91af394836ac86666c40b1e150 != 0)
				{
					num2 = 2;
				}
				break;
			case 3:
				return;
			case 2:
				enumerator = ((EntityMetadata)metadata).TableParts.GetEnumerator();
				num2 = 6;
				break;
			case 6:
				try
				{
					while (true)
					{
						int num4;
						if (!enumerator.MoveNext())
						{
							int num3 = 2;
							num4 = num3;
							goto IL_00ef;
						}
						goto IL_011f;
						IL_00ef:
						switch (num4)
						{
						case 2:
							return;
						case 1:
							goto IL_011f;
						}
						continue;
						IL_011f:
						CopyTableParts(enumerator.Current);
						num4 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5816b3723c134946ad9294172266312e == 0)
						{
							num4 = 0;
						}
						goto IL_00ef;
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
					int num5 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_545887e65739480a965b7ddfab7d0632 != 0)
					{
						num5 = 0;
					}
					switch (num5)
					{
					case 0:
						break;
					}
				}
			default:
				((EntityMetadata)metadata).TableParts.Clear();
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f91acf223c4b4303819d2f8f2fc6c8e1 == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	internal static void jpHraqkwoENPO16yDrk()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static bool n7cnMfkhOVmqbyXEFVG()
	{
		return Gfgbw9k10nHS2cI2SZB == null;
	}

	internal static WorkflowProcessDependencyService irAuOAkE9C3QoK7PICI()
	{
		return Gfgbw9k10nHS2cI2SZB;
	}

	internal static object oLYOe6k4OtTfB4YIFcX(object P_0)
	{
		return ((EntityMetadata)P_0).ViewModelMetadata;
	}

	internal static object oYq1vPkzpwWwEjKw3R4(object P_0)
	{
		return ((IWorkflowProcess)P_0).Forms;
	}

	internal static void msddfYUK5sqyV4K3YJt(object P_0, object P_1)
	{
		((IWorkflowProcess)P_0).Dependencies = P_1;
	}

	internal static void UHmSQjUOD8WtHaNHjAK(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static void DggBMXUZkx0tD9bToBQ(object P_0)
	{
		((List<PropertyMetadata>)P_0).Clear();
	}
}
