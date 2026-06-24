using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Export;
using EleWise.ELMA.Deploy.Manifest;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Packaging.ElmaStoreManifest;
using EleWise.ELMA.Workflow.Managers;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Workflow.Deploy.Manifest;

[Component]
public class ProcessesManifestChapterCreator : IManifestChapterCreator
{
	private static ProcessesManifestChapterCreator xXZ56p4AjHqAKEsHxsP;

	public void Resolve(ConfigExportSettings settings, ExportedObjectsDescription desc)
	{
		//Discarded unreachable code: IL_00c9, IL_00d8, IL_013e, IL_014d, IL_0158, IL_0260, IL_0273, IL_0282, IL_0292, IL_02a1, IL_0357, IL_0366, IL_0471, IL_0484, IL_0493, IL_04a3, IL_04f4, IL_0508, IL_0517, IL_0522, IL_06c8, IL_06db, IL_06ea, IL_06f9
		int num = 10;
		WorkflowExportSetting workflowExportSetting = default(WorkflowExportSetting);
		ProcessHeaderManager instance = default(ProcessHeaderManager);
		List<Guid>.Enumerator enumerator2 = default(List<Guid>.Enumerator);
		Guid current3 = default(Guid);
		List<IProcessHeader> list = default(List<IProcessHeader>);
		IProcessHeader processHeader2 = default(IProcessHeader);
		HashSet<Guid> hashSet = default(HashSet<Guid>);
		List<IProcessHeader>.Enumerator enumerator = default(List<IProcessHeader>.Enumerator);
		List<long>.Enumerator enumerator3 = default(List<long>.Enumerator);
		IProcessHeader processHeader = default(IProcessHeader);
		long current2 = default(long);
		IProcessHeader current = default(IProcessHeader);
		ProcessManifest processManifest = default(ProcessManifest);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 16:
				case 20:
					if (workflowExportSetting.ProcessesUids != null)
					{
						num2 = 6;
						continue;
					}
					goto case 3;
				case 2:
				case 23:
					instance = ProcessHeaderManager.Instance;
					num2 = 14;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_39af03d004af472bb66e60f46e79703a == 0)
					{
						num2 = 9;
					}
					continue;
				default:
					if (workflowExportSetting == null)
					{
						num2 = 19;
						continue;
					}
					goto case 13;
				case 13:
					if (!shc7hb4o5b2dYPLaf79(workflowExportSetting))
					{
						num2 = 3;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1c37d4e24e094858975336738e156495 != 0)
						{
							num2 = 17;
						}
						continue;
					}
					goto case 15;
				case 15:
					if (workflowExportSetting.ProcessesIds != null)
					{
						num2 = 23;
						continue;
					}
					goto case 7;
				case 10:
					if (SQM0RE42OhSuASF5QOP(settings) != null)
					{
						num = 9;
						break;
					}
					return;
				case 1:
					try
					{
						while (true)
						{
							IL_0195:
							int num8;
							if (!enumerator2.MoveNext())
							{
								num8 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_75a2d0f780b04098ba855df5729e6c30 == 0)
								{
									num8 = 0;
								}
								goto IL_015c;
							}
							goto IL_01d3;
							IL_01d3:
							current3 = enumerator2.Current;
							num8 = 6;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0991fd79553c4ecc82e8b5cb79c2bff2 != 0)
							{
								num8 = 0;
							}
							goto IL_015c;
							IL_015c:
							while (true)
							{
								switch (num8)
								{
								case 1:
									list.Add(processHeader2);
									num8 = 3;
									continue;
								case 2:
									goto IL_0195;
								case 6:
									if (!hashSet.Contains(current3))
									{
										num8 = 5;
										continue;
									}
									goto IL_0195;
								case 4:
									goto IL_01d3;
								case 3:
									hashSet.Add(uvM9qH4FTbUTSimMOJM(processHeader2));
									num8 = 2;
									continue;
								case 5:
									processHeader2 = instance.Load(current3);
									num8 = 1;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3f508947b0d94af1961e5aa17a8a2044 == 0)
									{
										num8 = 1;
									}
									continue;
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
						((IDisposable)enumerator2).Dispose();
						int num9 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_545887e65739480a965b7ddfab7d0632 == 0)
						{
							num9 = 0;
						}
						switch (num9)
						{
						case 0:
							break;
						}
					}
					goto case 3;
				case 17:
					return;
				case 14:
					list = new List<IProcessHeader>();
					num2 = 11;
					continue;
				case 18:
					return;
				case 19:
					return;
				case 22:
					return;
				case 7:
					if (workflowExportSetting.ProcessesUids == null)
					{
						num2 = 22;
						continue;
					}
					goto case 2;
				case 3:
					enumerator = list.GetEnumerator();
					num2 = 5;
					continue;
				case 4:
					return;
				case 9:
					workflowExportSetting = settings.CustomSettings[WorkflowExportConsts.ExportExtensionUid] as WorkflowExportSetting;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1de08766357542bdb81146373079f817 == 0)
					{
						num2 = 0;
					}
					continue;
				case 11:
					hashSet = new HashSet<Guid>();
					num2 = 12;
					continue;
				case 21:
					enumerator3 = workflowExportSetting.ProcessesIds.GetEnumerator();
					num2 = 8;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6782172e84504a7baf3163b8f6b2a916 != 0)
					{
						num2 = 0;
					}
					continue;
				case 8:
					try
					{
						while (true)
						{
							int num6;
							if (!enumerator3.MoveNext())
							{
								int num5 = 4;
								num6 = num5;
								goto IL_0375;
							}
							goto IL_0422;
							IL_0375:
							while (true)
							{
								switch (num6)
								{
								default:
									list.Add(processHeader);
									num6 = 5;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6b089b0d02ae4d3186c8d2cb8a24d4d3 != 0)
									{
										num6 = 4;
									}
									continue;
								case 1:
									break;
								case 3:
									processHeader = instance.Load(current2);
									num6 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8a6cf36da0b84f319a7cf27018f28f5b == 0)
									{
										num6 = 0;
									}
									continue;
								case 5:
									hashSet.Add(uvM9qH4FTbUTSimMOJM(processHeader));
									num6 = 1;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_58fb165cafed422d973d4a7156526541 == 0)
									{
										num6 = 1;
									}
									continue;
								case 2:
									goto IL_0422;
								case 4:
									goto end_IL_03ba;
								}
								break;
							}
							continue;
							IL_0422:
							current2 = enumerator3.Current;
							num6 = 2;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_764abb15e52f4036a7a81fce6cb70f30 == 0)
							{
								num6 = 3;
							}
							goto IL_0375;
							continue;
							end_IL_03ba:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator3).Dispose();
						int num7 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_08023922bb0e4e809e5cff73a2b04988 == 0)
						{
							num7 = 0;
						}
						switch (num7)
						{
						case 0:
							break;
						}
					}
					goto case 16;
				case 12:
					if (workflowExportSetting.ProcessesIds == null)
					{
						num = 20;
						break;
					}
					goto case 21;
				case 6:
					enumerator2 = workflowExportSetting.ProcessesUids.GetEnumerator();
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6fe3beca34a9422e873cd6ef331760ae == 0)
					{
						num2 = 1;
					}
					continue;
				case 5:
					try
					{
						while (true)
						{
							IL_05ef:
							int num3;
							if (!enumerator.MoveNext())
							{
								num3 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1733a11cae754a598119b94f8d9e4971 == 0)
								{
									num3 = 0;
								}
								goto IL_0526;
							}
							goto IL_05cc;
							IL_05cc:
							current = enumerator.Current;
							num3 = 4;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f30401a2cff84771be092252e934fede != 0)
							{
								num3 = 4;
							}
							goto IL_0526;
							IL_0526:
							while (true)
							{
								switch (num3)
								{
								default:
									return;
								case 0:
									return;
								case 3:
								{
									ProcessManifest processManifest2 = processManifest;
									EntityManifest entityManifest = new EntityManifest();
									m7PQW24NrjbTC7cPXa0(entityManifest, OTbeJi4e7lgCW42XADC(QVwYYy4rhKJ34Iwiyw0(current)));
									entityManifest.Name = ((NamedMetadata)QVwYYy4rhKJ34Iwiyw0(current)).Name;
									IOmN5g4SeFGoZymXwTK(entityManifest, Qu5uYp4xtgEMBJlMYjv(QVwYYy4rhKJ34Iwiyw0(current)));
									entityManifest.Namespace = (string)M6FdlO41nwvUUMjHHCr(QVwYYy4rhKJ34Iwiyw0(current));
									YB8KS34E36sjm9Xol2F(entityManifest, PjK2Fb4hqsoj2ZKG5Gq(QVwYYy4rhKJ34Iwiyw0(current)));
									MRaTqh4weaKvuqcKjDu(processManifest2, entityManifest);
									num3 = 2;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6b089b0d02ae4d3186c8d2cb8a24d4d3 != 0)
									{
										num3 = 0;
									}
									continue;
								}
								case 1:
									break;
								case 5:
									goto IL_05ef;
								case 2:
									((ElmaStoreComponentManifest)SQM0RE42OhSuASF5QOP(settings)).Processes.Add(processManifest);
									num3 = 5;
									continue;
								case 6:
									if (QVwYYy4rhKJ34Iwiyw0(current) != null)
									{
										num3 = 3;
										continue;
									}
									goto case 2;
								case 4:
								{
									ProcessManifest obj = new ProcessManifest
									{
										Id = uvM9qH4FTbUTSimMOJM(current),
										Name = current.Name
									};
									y5BgSY4aodOT6qYlp8X(obj, (rqG9tJ4i8b6eruG0etq(current) != null) ? ylghRv4IPbj5EWNDq1N(rqG9tJ4i8b6eruG0etq(current)) : 0);
									processManifest = obj;
									num3 = 6;
									continue;
								}
								}
								break;
							}
							goto IL_05cc;
						}
					}
					finally
					{
						((IDisposable)enumerator).Dispose();
						int num4 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_18b351a59a324c25b4f150a9771bcf69 == 0)
						{
							num4 = 0;
						}
						switch (num4)
						{
						case 0:
							break;
						}
					}
				}
				break;
			}
		}
	}

	public ProcessesManifestChapterCreator()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		HiOGYC44dI7ePZcotHU();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_71a41ac2fa884d27b721ae0509586eea == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object SQM0RE42OhSuASF5QOP(object P_0)
	{
		return ((ConfigExportSettings)P_0).Manifest;
	}

	internal static bool shc7hb4o5b2dYPLaf79(object P_0)
	{
		return ((WorkflowExportSetting)P_0).ExportProcesses;
	}

	internal static Guid uvM9qH4FTbUTSimMOJM(object P_0)
	{
		return ((IProcessHeader)P_0).Uid;
	}

	internal static object rqG9tJ4i8b6eruG0etq(object P_0)
	{
		return ((IProcessHeader)P_0).Published;
	}

	internal static long ylghRv4IPbj5EWNDq1N(object P_0)
	{
		return ((IWorkflowProcess)P_0).VersionNumber;
	}

	internal static void y5BgSY4aodOT6qYlp8X(object P_0, long P_1)
	{
		((ProcessManifest)P_0).Version = P_1;
	}

	internal static object QVwYYy4rhKJ34Iwiyw0(object P_0)
	{
		return ((IProcessHeader)P_0).Context;
	}

	internal static Guid OTbeJi4e7lgCW42XADC(object P_0)
	{
		return ((EntityMetadata)P_0).TypeUid;
	}

	internal static void m7PQW24NrjbTC7cPXa0(object P_0, Guid P_1)
	{
		((EntityManifest)P_0).Uid = P_1;
	}

	internal static object Qu5uYp4xtgEMBJlMYjv(object P_0)
	{
		return ((NamedMetadata)P_0).DisplayName;
	}

	internal static void IOmN5g4SeFGoZymXwTK(object P_0, object P_1)
	{
		((EntityManifest)P_0).DisplayName = (string)P_1;
	}

	internal static object M6FdlO41nwvUUMjHHCr(object P_0)
	{
		return ((ClassMetadata)P_0).Namespace;
	}

	internal static object PjK2Fb4hqsoj2ZKG5Gq(object P_0)
	{
		return ((EntityMetadata)P_0).TableName;
	}

	internal static void YB8KS34E36sjm9Xol2F(object P_0, object P_1)
	{
		((EntityManifest)P_0).TableName = (string)P_1;
	}

	internal static void MRaTqh4weaKvuqcKjDu(object P_0, object P_1)
	{
		((ProcessManifest)P_0).Context = (EntityManifest)P_1;
	}

	internal static bool H8ttuV4Gyvqxeo32U8R()
	{
		return xXZ56p4AjHqAKEsHxsP == null;
	}

	internal static ProcessesManifestChapterCreator c11CTk47AkhNWtQMcsj()
	{
		return xXZ56p4AjHqAKEsHxsP;
	}

	internal static void HiOGYC44dI7ePZcotHU()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}
}
