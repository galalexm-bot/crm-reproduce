using System;
using System.Collections.Generic;
using System.Reflection;
using EleWise.ELMA.Common.Services;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Mappings.ReplaceUidsAtPropertyMapService;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.ExtensionPoints;

[Service(EnableInterceptors = false, InjectProperties = false, Scope = ServiceScope.Transient)]
internal sealed class ExternalSubprocessUidReplaceServiceExtension : IReplaceUidAtPropertyMapServiceExtension
{
	private bool reverseOrder;

	private IWorkflowInstance leftContextInstance;

	private IWorkflowInstance rightContextInstance;

	private bool? isSupportedVar;

	private bool dictInitialized;

	private bool blobExists;

	private SerializableDictionary<Guid, Guid> uidDictionary;

	private string blobStorePathKey;

	private BlobStore blobStore;

	private bool initialized;

	internal static ExternalSubprocessUidReplaceServiceExtension U0fv2SIiHqgufFq9by8;

	private BlobStore BlobStore
	{
		get
		{
			int num = 1;
			int num2 = num;
			BlobStore blobStore = default(BlobStore);
			BlobStore obj;
			while (true)
			{
				switch (num2)
				{
				default:
					blobStore = (this.blobStore = Locator.GetServiceNotNull<BlobStore>());
					num2 = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_26fa47f5bd8343debcae8b05a56a3ab5 == 0)
					{
						num2 = 1;
					}
					continue;
				case 1:
					obj = this.blobStore;
					if (obj != null)
					{
						break;
					}
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_58fb165cafed422d973d4a7156526541 == 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					obj = blobStore;
					break;
				}
				break;
			}
			return obj;
		}
	}

	private bool IsSupported
	{
		get
		{
			//Discarded unreachable code: IL_0031, IL_0040
			int num = 2;
			int num2 = num;
			bool? flag = default(bool?);
			while (true)
			{
				switch (num2)
				{
				default:
					return false;
				case 3:
					return flag.GetValueOrDefault();
				case 2:
					flag = isSupportedVar;
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c559093b7320494babd70d164a6df42d == 0)
					{
						num2 = 0;
					}
					break;
				case 1:
					if (flag.HasValue)
					{
						num2 = 3;
						break;
					}
					goto default;
				}
			}
		}
	}

	public void Init(object objLeft, object objRight)
	{
		//Discarded unreachable code: IL_00e1, IL_00ed, IL_01cb, IL_01fd, IL_0223, IL_0232, IL_0241, IL_02a7, IL_02b6, IL_02c6, IL_02d5, IL_02fd, IL_037a, IL_0395, IL_0424
		int num = 7;
		Guid guid2 = default(Guid);
		Guid? guid3 = default(Guid?);
		IWorkflowInstance parentInstance2 = default(IWorkflowInstance);
		Guid? guid = default(Guid?);
		WorkflowInstanceContext workflowInstanceContext = default(WorkflowInstanceContext);
		IWorkflowInstance parentInstance = default(IWorkflowInstance);
		WorkflowInstanceContext workflowInstanceContext2 = default(WorkflowInstanceContext);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				Guid? guid4;
				Guid? guid5;
				switch (num2)
				{
				case 18:
					guid2 = wWEreAIr6xcUdptbFh2(rightContextInstance);
					num2 = 34;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3ab79470996d472f815915b21f45aac1 == 0)
					{
						num2 = 9;
					}
					continue;
				case 13:
					guid4 = guid3;
					goto IL_0482;
				case 5:
				case 16:
					if (parentInstance2 == null)
					{
						num2 = 25;
						continue;
					}
					guid5 = wWEreAIr6xcUdptbFh2(parentInstance2);
					goto IL_04c7;
				case 35:
					if (guid.HasValue)
					{
						num2 = 33;
						continue;
					}
					goto case 36;
				case 23:
					rightContextInstance = GetWorkflowInstance(workflowInstanceContext, out parentInstance);
					num2 = 10;
					continue;
				case 20:
					workflowInstanceContext2 = objLeft as WorkflowInstanceContext;
					num2 = 15;
					continue;
				case 27:
					blobStorePathKey = string.Format((string)pkvOSJINHLum72ptlkV(0x738ABA6E ^ 0x738BEBDC), wWEreAIr6xcUdptbFh2(rightContextInstance), leftContextInstance.SubProcessElementUid, leftContextInstance.Uid);
					num = 22;
					break;
				case 17:
					if (parentInstance == null)
					{
						num2 = 14;
						continue;
					}
					guid4 = wWEreAIr6xcUdptbFh2(parentInstance);
					goto IL_0482;
				case 1:
					isSupportedVar = true;
					num2 = 28;
					continue;
				case 15:
					workflowInstanceContext = objRight as WorkflowInstanceContext;
					num2 = 24;
					continue;
				case 7:
					if (!initialized)
					{
						num2 = 6;
						continue;
					}
					return;
				case 4:
					return;
				case 26:
					return;
				case 8:
					leftContextInstance = GetWorkflowInstance(workflowInstanceContext2, out parentInstance2);
					num2 = 23;
					continue;
				case 37:
					if (!guid.HasValue)
					{
						num2 = 9;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_43af423d081c48e3bc6cea30ce47523d == 0)
						{
							num2 = 32;
						}
						continue;
					}
					if (UuCCjAIe70cRMNVtyB9(guid2, guid.GetValueOrDefault()))
					{
						goto case 12;
					}
					goto case 32;
				case 34:
					if (guid.HasValue)
					{
						num2 = 35;
						continue;
					}
					goto case 9;
				case 12:
					isSupportedVar = true;
					num = 3;
					break;
				case 19:
					return;
				case 31:
					guid2 = leftContextInstance.Uid;
					num2 = 17;
					continue;
				case 29:
					return;
				case 6:
					isSupportedVar = false;
					num2 = 20;
					continue;
				case 24:
					if (workflowInstanceContext2 == null)
					{
						return;
					}
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0991fd79553c4ecc82e8b5cb79c2bff2 != 0)
					{
						num2 = 0;
					}
					continue;
				default:
					if (workflowInstanceContext == null)
					{
						return;
					}
					num2 = 8;
					continue;
				case 25:
					guid3 = null;
					num2 = 30;
					continue;
				case 3:
					reverseOrder = false;
					num2 = 2;
					continue;
				case 30:
					guid5 = guid3;
					goto IL_04c7;
				case 28:
					reverseOrder = true;
					num2 = 27;
					continue;
				case 21:
					if (rightContextInstance == null)
					{
						return;
					}
					num2 = 31;
					continue;
				case 2:
					blobStorePathKey = (string)r2ChkVIx6iK1HgcfZwD(pkvOSJINHLum72ptlkV(0x46EA3D1 ^ 0x46FF263), wWEreAIr6xcUdptbFh2(leftContextInstance), rightContextInstance.SubProcessElementUid, wWEreAIr6xcUdptbFh2(rightContextInstance));
					num2 = 9;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f33560c5d18b4e10b24a458578aa60fd != 0)
					{
						num2 = 1;
					}
					continue;
				case 9:
				case 11:
				case 22:
					initialized = true;
					num2 = 4;
					continue;
				case 10:
					if (leftContextInstance == null)
					{
						return;
					}
					num2 = 21;
					continue;
				case 14:
					guid3 = null;
					num2 = 13;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_32f3e755437f4eacb85c8a0d536f83ea != 0)
					{
						num2 = 9;
					}
					continue;
				case 32:
					num2 = 5;
					continue;
				case 33:
					if (!UuCCjAIe70cRMNVtyB9(guid.GetValueOrDefault(), guid2))
					{
						goto case 9;
					}
					goto case 36;
				case 36:
					{
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_dcdfd019631e458b9cb5fa34a16a2fe1 != 0)
						{
							num2 = 1;
						}
						continue;
					}
					IL_0482:
					guid = guid4;
					num2 = 27;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5c45a6e5a4614bfba7591d8a1c7ced1d == 0)
					{
						num2 = 37;
					}
					continue;
					IL_04c7:
					guid = guid5;
					num2 = 18;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bae4e393cddc4c98b9896b25c9e18c7d != 0)
					{
						num2 = 13;
					}
					continue;
				}
				break;
			}
		}
	}

	public bool GetUidReplace(Guid uid, out Guid? newUid)
	{
		//Discarded unreachable code: IL_0081, IL_0090, IL_00a3, IL_01a3, IL_01b2, IL_01c2
		int num = 16;
		bool flag = default(bool);
		Guid value = default(Guid);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 9:
					return false;
				case 4:
				case 10:
					return flag;
				default:
					uidDictionary.Add(uid, newUid.Value);
					num2 = 5;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_85ba8d91af394836ac86666c40b1e150 == 0)
					{
						num2 = 2;
					}
					break;
				case 3:
				case 13:
					newUid = C5ikMuIS1KYNLl1VsKN();
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5816b3723c134946ad9294172266312e != 0)
					{
						num2 = 0;
					}
					break;
				case 7:
					return false;
				case 11:
					if (dictInitialized)
					{
						num2 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bb19f93c0a774f6cbdada859bba83212 == 0)
						{
							num2 = 1;
						}
						break;
					}
					goto case 2;
				case 15:
					if (IsSupported)
					{
						goto end_IL_0012;
					}
					goto case 7;
				case 1:
				case 6:
					if (!reverseOrder)
					{
						num2 = 13;
						break;
					}
					goto case 8;
				case 16:
					newUid = null;
					num2 = 3;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1a2d7634479d44fb8d3718c31b05f73c != 0)
					{
						num2 = 15;
					}
					break;
				case 2:
					InitDict();
					num2 = 6;
					break;
				case 8:
					if (uidDictionary != null)
					{
						flag = uidDictionary.TryGetValue(uid, out value);
						num2 = 12;
					}
					else
					{
						num2 = 9;
					}
					break;
				case 14:
					newUid = value;
					num2 = 4;
					break;
				case 12:
					if (flag)
					{
						num2 = 14;
						break;
					}
					goto case 4;
				case 5:
					flag = true;
					num2 = 3;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f870ea690334e7ab7599d275d195e9a != 0)
					{
						num2 = 10;
					}
					break;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 11;
		}
	}

	public void EndWork()
	{
		//Discarded unreachable code: IL_005d, IL_006c, IL_00c8
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 4:
				ClearBlob();
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ecf910d183864897a7c8ec77e01689a4 == 0)
				{
					num2 = 0;
				}
				break;
			case 5:
				return;
			case 3:
				if (IsSupported)
				{
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_58f735bab6d046fe96f749ec2e269a96 != 0)
					{
						num2 = 2;
					}
					break;
				}
				return;
			case 6:
				return;
			case 2:
				if (!reverseOrder)
				{
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1b8b735647da470aa2d45d64d6f538d1 == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 4;
			case 0:
				return;
			case 1:
				SaveDictToBlob();
				num2 = 5;
				break;
			}
		}
	}

	private IWorkflowInstance GetWorkflowInstance(WorkflowInstanceContext context, out IWorkflowInstance parentInstance)
	{
		int num = 2;
		int num2 = num;
		IWorkflowInstance workflowInstance = default(IWorkflowInstance);
		while (true)
		{
			switch (num2)
			{
			default:
				return workflowInstance;
			case 2:
			{
				object obj = TYruv3I1VXn9VcsOclZ(context.GetType(), pkvOSJINHLum72ptlkV(0xDF4D1F8 ^ 0xDF48952));
				z6ZQ0SIhEYyZCocW76t(obj, pkvOSJINHLum72ptlkV(0x101D10F ^ 0x10080D1));
				workflowInstance = guZEssIE1DQQ7phqi5q(obj, context, null) as IWorkflowInstance;
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1de08766357542bdb81146373079f817 == 0)
				{
					num2 = 1;
				}
				break;
			}
			case 1:
				parentInstance = (IWorkflowInstance)((workflowInstance != null) ? Y7OjnSIw8H5ZDxSJxoB(workflowInstance) : null);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_805f3361d2ba4dac8da4174f89314253 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private void InitDict()
	{
		//Discarded unreachable code: IL_0126, IL_0135
		int num = 7;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 7:
				if (reverseOrder)
				{
					num2 = 6;
					break;
				}
				goto default;
			default:
				uidDictionary = new SerializableDictionary<Guid, Guid>();
				num2 = 3;
				break;
			case 1:
				uidDictionary = SwapKeysAndValues(uidDictionary);
				num2 = 5;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_719514a5a8ae47ed84e5a777ead0dc9f == 0)
				{
					num2 = 3;
				}
				break;
			case 4:
				return;
			case 6:
				LoadDictFromBlob();
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d42a29e78d4a45518985de3631ade50c != 0)
				{
					num2 = 1;
				}
				break;
			case 8:
				uidDictionary = new SerializableDictionary<Guid, Guid>();
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0262725a60774e44a84fd2b93b79ee8a == 0)
				{
					num2 = 1;
				}
				break;
			case 2:
			case 3:
				dictInitialized = true;
				num2 = 4;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d087ae72a2134de08266411226c5f060 != 0)
				{
					num2 = 3;
				}
				break;
			case 5:
				if (uidDictionary == null)
				{
					num2 = 8;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6d48f3b4557a49578bf7f5ef0517e0be != 0)
					{
						num2 = 8;
					}
					break;
				}
				goto case 2;
			}
		}
	}

	private void LoadDictFromBlob()
	{
		//Discarded unreachable code: IL_0072, IL_0081
		int num = 6;
		int num2 = num;
		byte[] array = default(byte[]);
		while (true)
		{
			switch (num2)
			{
			case 5:
				array = BlobStore.LoadOrNull(blobStorePathKey);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f276fa9c20d4dd889000f50d886a41e == 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				return;
			case 6:
				PCD9r4I4w4YZTYmkvsr(blobStorePathKey, pkvOSJINHLum72ptlkV(0x56F860D7 ^ 0x56F932E5));
				num2 = 5;
				break;
			default:
				if (array != null)
				{
					num2 = 7;
					break;
				}
				goto case 4;
			case 8:
				uidDictionary = kO00tOIznIjwsIcODqJ(array) as SerializableDictionary<Guid, Guid>;
				num2 = 4;
				break;
			case 1:
				a4uYQTaKA84ufe7TNvo(Logger.Log, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1386448964 ^ -1386404374), new object[1] { blobStorePathKey });
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_90dfe18b3d784ead92a1e4e4e2547482 != 0)
				{
					num2 = 2;
				}
				break;
			case 7:
				blobExists = true;
				num2 = 8;
				break;
			case 4:
				if (uidDictionary != null)
				{
					num2 = 3;
					break;
				}
				goto case 1;
			case 2:
				return;
			}
		}
	}

	private void SaveDictToBlob()
	{
		//Discarded unreachable code: IL_0112
		int num = 7;
		int num2 = num;
		byte[] array = default(byte[]);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				if (kjuixhaOKHe6D1foR0Y(uidDictionary) == 0)
				{
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_fb347e2c5dba4e0ca4d47098be7fd10c == 0)
					{
						num2 = 0;
					}
				}
				else
				{
					array = (byte[])wtdmj1aZsQT1lBCaEWh(uidDictionary);
					num2 = 5;
				}
				break;
			case 0:
				return;
			case 5:
				uQAyP0avPYbvwV9ANFg(BlobStore, blobStorePathKey, array);
				num2 = 3;
				break;
			case 1:
				z6ZQ0SIhEYyZCocW76t(uidDictionary, pkvOSJINHLum72ptlkV(0x4943E3E4 ^ 0x4942B076));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_9269d021c6f148b6a1c4afb8cee03b6c != 0)
				{
					num2 = 2;
				}
				break;
			case 4:
				PCD9r4I4w4YZTYmkvsr(blobStorePathKey, pkvOSJINHLum72ptlkV(-1712492721 ^ -1712571011));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e632863bfb124ba083e3ba9b363fd70e != 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				return;
			case 6:
				return;
			case 7:
				if (!dictInitialized)
				{
					num2 = 6;
					break;
				}
				goto case 4;
			}
		}
	}

	private void ClearBlob()
	{
		//Discarded unreachable code: IL_0090, IL_009f
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 3:
				return;
			case 4:
				return;
			default:
				if (!blobExists)
				{
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1b8b735647da470aa2d45d64d6f538d1 != 0)
					{
						num2 = 4;
					}
					continue;
				}
				break;
			case 1:
				PCD9r4I4w4YZTYmkvsr(blobStorePathKey, pkvOSJINHLum72ptlkV(0x75872B6 ^ 0x7592084));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bf623f11574746d6bf3837b66460c576 == 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				break;
			}
			BlobStore.Remove(blobStorePathKey);
			num2 = 3;
		}
	}

	private static SerializableDictionary<Guid, Guid> SwapKeysAndValues(SerializableDictionary<Guid, Guid> dictionary)
	{
		if (dictionary == null || dictionary.Count == 0)
		{
			return dictionary;
		}
		SerializableDictionary<Guid, Guid> serializableDictionary = new SerializableDictionary<Guid, Guid>();
		foreach (KeyValuePair<Guid, Guid> item in dictionary)
		{
			serializableDictionary.Add(item.Value, item.Key);
		}
		return serializableDictionary;
	}

	public ExternalSubprocessUidReplaceServiceExtension()
	{
		//Discarded unreachable code: IL_003a, IL_003f
		mTb95UaYwd0PmlmbDA7();
		blobStorePathKey = string.Empty;
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0262725a60774e44a84fd2b93b79ee8a == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool VNJ5BiIIZa49U5EOSjB()
	{
		return U0fv2SIiHqgufFq9by8 == null;
	}

	internal static ExternalSubprocessUidReplaceServiceExtension xPNdVEIahwBFCwH83mM()
	{
		return U0fv2SIiHqgufFq9by8;
	}

	internal static Guid wWEreAIr6xcUdptbFh2(object P_0)
	{
		return ((IWorkflowInstance)P_0).Uid;
	}

	internal static bool UuCCjAIe70cRMNVtyB9(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}

	internal static object pkvOSJINHLum72ptlkV(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object r2ChkVIx6iK1HgcfZwD(object P_0, object P_1, object P_2, object P_3)
	{
		return string.Format((string)P_0, P_1, P_2, P_3);
	}

	internal static Guid C5ikMuIS1KYNLl1VsKN()
	{
		return Guid.NewGuid();
	}

	internal static object TYruv3I1VXn9VcsOclZ(Type P_0, object P_1)
	{
		return P_0.GetReflectionProperty((string)P_1);
	}

	internal static void z6ZQ0SIhEYyZCocW76t(object P_0, object P_1)
	{
		Contract.NotNull(P_0, (string)P_1);
	}

	internal static object guZEssIE1DQQ7phqi5q(object P_0, object P_1, object P_2)
	{
		return ((PropertyInfo)P_0).GetValue(P_1, (object[])P_2);
	}

	internal static object Y7OjnSIw8H5ZDxSJxoB(object P_0)
	{
		return ((IWorkflowInstance)P_0).ParentInstance;
	}

	internal static void PCD9r4I4w4YZTYmkvsr(object P_0, object P_1)
	{
		Contract.NotNullOrEmpty((string)P_0, (string)P_1);
	}

	internal static object kO00tOIznIjwsIcODqJ(object P_0)
	{
		return ClassSerializationHelper.DeserializeObject((byte[])P_0);
	}

	internal static void a4uYQTaKA84ufe7TNvo(object P_0, object P_1, object P_2)
	{
		((ILogger)P_0).ErrorFormat((string)P_1, (object[])P_2);
	}

	internal static int kjuixhaOKHe6D1foR0Y(object P_0)
	{
		return ((Dictionary<Guid, Guid>)P_0).Count;
	}

	internal static object wtdmj1aZsQT1lBCaEWh(object P_0)
	{
		return ClassSerializationHelper.SerializeObject(P_0);
	}

	internal static void uQAyP0avPYbvwV9ANFg(object P_0, object P_1, object P_2)
	{
		((BlobStore)P_0).Save((string)P_1, (byte[])P_2);
	}

	internal static void mTb95UaYwd0PmlmbDA7()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}
}
