using System.Collections.Generic;
using System.Data;
using System.Runtime.CompilerServices;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Services;
using EleWise.ELMA.Workflow.Constants;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Listeners;

[Component]
internal class ObservedContextPropertyUoWEventsListener : IUnitOfWorkEventListener
{
	private static ObservedContextPropertyUoWEventsListener eV9XTj6MP5Rl3rmk10G;

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
				case 0:
					return;
				case 1:
					_003CTransformationProvider_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_85ba8d91af394836ac86666c40b1e150 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public void OnStartUnitofWork(IUnitOfWork unitOfWork)
	{
	}

	public void OnPreFlushUnitofWork(IUnitOfWork unitOfWork, IEnumerable<object> entities)
	{
	}

	public void OnPostFlushUnitofWork(IUnitOfWork unitOfWork)
	{
		//Discarded unreachable code: IL_007d, IL_012a, IL_015f, IL_016e, IL_01dd, IL_022b, IL_02c1, IL_02d0, IL_02df
		int num = 17;
		int num2 = num;
		DataTable value2 = default(DataTable);
		DataTable value3 = default(DataTable);
		BulkDeleteArg value = default(BulkDeleteArg);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 15:
				if (aJPJLk6ASCVcKTnCUaU(OImjYv6V9DYrNx7KBFY(value2)) <= 0)
				{
					num2 = 4;
					break;
				}
				goto case 2;
			case 11:
				wG4mYg62PAvB9I6XmPo(TransformationProvider, dtHUBn67gLZayLxKkik(-432000546 ^ -431991354), value3, false);
				num2 = 6;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a23e27b648a042f098a477c26c4beed1 == 0)
				{
					num2 = 6;
				}
				break;
			case 10:
				pu75vR6GjcNkN6chyVG(ObjectStartableByRouteConstant.DeleteKey);
				num2 = 3;
				break;
			case 13:
				if (value3 == null)
				{
					num2 = 8;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6fe3beca34a9422e873cd6ef331760ae != 0)
					{
						num2 = 8;
					}
					break;
				}
				goto case 14;
			case 21:
				if (value2 == null)
				{
					num2 = 9;
					break;
				}
				goto case 15;
			case 0:
				return;
			case 7:
				return;
			case 19:
				if (value == null)
				{
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c447ffb64be44c09b6fd398df506785b == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 20;
			case 17:
				if (!ContextVars.TryGetValue<DataTable>(ObjectStartableByRouteConstant.InsertKey, out value3))
				{
					num2 = 16;
					break;
				}
				goto case 13;
			case 20:
				if (TP4oEE6okyEK5EYdFwa(value.Clauses) <= 0)
				{
					return;
				}
				num2 = 10;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a680afde07ce4ae5b71c411a1f75109b == 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				C1vry96FhG5laGvDRHr(TransformationProvider, value);
				num2 = 7;
				break;
			case 6:
			case 8:
			case 16:
			case 22:
				if (!ContextVars.TryGetValue<DataTable>(ObjectStartableByRouteConstant.UpdateKey, out value2))
				{
					num2 = 18;
					break;
				}
				goto case 21;
			case 2:
				ContextVars.Remove(ObjectStartableByRouteConstant.UpdateKey);
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1733a11cae754a598119b94f8d9e4971 == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				TransformationProvider.BulkUpdate((string)dtHUBn67gLZayLxKkik(0xB7793C9 ^ 0xB77F7D1), value2, new List<ColumnLink>
				{
					new ColumnLink((string)dtHUBn67gLZayLxKkik(-432000546 ^ -431982792)),
					new ColumnLink((string)dtHUBn67gLZayLxKkik(0x101D10F ^ 0x101C197)),
					new ColumnLink((string)dtHUBn67gLZayLxKkik(-1028861977 ^ -1028871575))
				});
				num2 = 12;
				break;
			case 5:
				pu75vR6GjcNkN6chyVG(ObjectStartableByRouteConstant.InsertKey);
				num2 = 11;
				break;
			case 4:
			case 9:
			case 12:
			case 18:
				if (!ContextVars.TryGetValue<BulkDeleteArg>(ObjectStartableByRouteConstant.DeleteKey, out value))
				{
					return;
				}
				num2 = 19;
				break;
			case 14:
				if (aJPJLk6ASCVcKTnCUaU(OImjYv6V9DYrNx7KBFY(value3)) <= 0)
				{
					num2 = 22;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_448e6815cb30438893079dcbb906fd65 == 0)
					{
						num2 = 6;
					}
					break;
				}
				goto case 5;
			}
		}
	}

	public void OnPreCommitUnitofWork(IUnitOfWork unitOfWork)
	{
	}

	public void OnPostCommitUnitofWork(IUnitOfWork unitOfWork)
	{
	}

	public void OnPostRollbackUnitofWork(IUnitOfWork unitOfWork)
	{
	}

	public void OnDisposeUnitofWork(IUnitOfWork unitOfWork)
	{
	}

	public ObservedContextPropertyUoWEventsListener()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		HW2cH96it3pPmtTxsRh();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6d48f3b4557a49578bf7f5ef0517e0be == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool hRHjnb6kSYmL7P9w6RG()
	{
		return eV9XTj6MP5Rl3rmk10G == null;
	}

	internal static ObservedContextPropertyUoWEventsListener oFHVAU6UohHgxGchw45()
	{
		return eV9XTj6MP5Rl3rmk10G;
	}

	internal static object OImjYv6V9DYrNx7KBFY(object P_0)
	{
		return ((DataTable)P_0).Rows;
	}

	internal static int aJPJLk6ASCVcKTnCUaU(object P_0)
	{
		return ((InternalDataCollectionBase)P_0).Count;
	}

	internal static void pu75vR6GjcNkN6chyVG(object P_0)
	{
		ContextVars.Remove((string)P_0);
	}

	internal static object dtHUBn67gLZayLxKkik(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void wG4mYg62PAvB9I6XmPo(object P_0, object P_1, object P_2, bool P_3)
	{
		((ITransformationProvider)P_0).BulkInsert((string)P_1, (DataTable)P_2, P_3);
	}

	internal static int TP4oEE6okyEK5EYdFwa(object P_0)
	{
		return ((List<BulkDeleteArg.Clause>)P_0).Count;
	}

	internal static int C1vry96FhG5laGvDRHr(object P_0, object P_1)
	{
		return ((ITransformationProvider)P_0).BulkDelete((BulkDeleteArg)P_1);
	}

	internal static void HW2cH96it3pPmtTxsRh()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}
}
