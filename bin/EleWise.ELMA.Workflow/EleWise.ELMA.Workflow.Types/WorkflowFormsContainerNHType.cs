using System;
using System.IO;
using System.Linq.Expressions;
using System.Reflection;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Types;

[Serializable]
public class WorkflowFormsContainerNHType : WorkflowProcessXmlSerializableType<WorkflowFormsContainer>
{
	internal static WorkflowFormsContainerNHType cUYbDC8CsopWfZBO55o;

	public override Expression<Func<IWorkflowProcess, WorkflowFormsContainer>> PropertyGetter
	{
		get
		{
			ParameterExpression parameterExpression = Expression.Parameter(typeof(IWorkflowProcess), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x51EF0063 ^ 0x51EF0FD9));
			return Expression.Lambda<Func<IWorkflowProcess, WorkflowFormsContainer>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression });
		}
	}

	protected override bool IsEmpty(WorkflowFormsContainer obj)
	{
		//Discarded unreachable code: IL_002d, IL_003c
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return obj.IsEmpty;
			default:
				return true;
			case 1:
				if (obj == null)
				{
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_85ba8d91af394836ac86666c40b1e150 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			}
		}
	}

	protected override WorkflowFormsContainer LoadObjectFromStream(Stream stream)
	{
		//Discarded unreachable code: IL_0076, IL_00ae, IL_00e6, IL_00f5
		int num = 1;
		int num2 = num;
		StreamReader streamReader = default(StreamReader);
		WorkflowFormsContainer result = default(WorkflowFormsContainer);
		while (true)
		{
			switch (num2)
			{
			case 1:
				streamReader = new StreamReader(stream);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_75a2d0f780b04098ba855df5729e6c30 == 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				return result;
			}
			try
			{
				result = (WorkflowFormsContainer)cLhON38U4niLls2Qeag(streamReader.ReadToEnd());
				int num3 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_de3723e1fdff427496b973d91a934ee2 == 0)
				{
					num3 = 0;
				}
				return num3 switch
				{
					0 => result, 
					_ => result, 
				};
			}
			finally
			{
				if (streamReader != null)
				{
					int num4 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0991fd79553c4ecc82e8b5cb79c2bff2 != 0)
					{
						num4 = 1;
					}
					while (true)
					{
						switch (num4)
						{
						case 1:
							c5FsqW8VYF1CduVeaP7(streamReader);
							num4 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b4c7ccafb1de4af2aa93fb9f2842508b != 0)
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
		}
	}

	protected override object GetNullObject()
	{
		return new WorkflowFormsContainer();
	}

	public WorkflowFormsContainerNHType()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		pL45s88AvI2XTgERKWo();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f05298ca2a4a4a639a58bc7f7d9ff7b9 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool Oxd9N28M3WUv1LUl2KD()
	{
		return cUYbDC8CsopWfZBO55o == null;
	}

	internal static WorkflowFormsContainerNHType ulZwOX8kXqLQxPUV9G4()
	{
		return cUYbDC8CsopWfZBO55o;
	}

	internal static object cLhON38U4niLls2Qeag(object P_0)
	{
		return WorkflowFormsContainer.DeserializeByXml((string)P_0);
	}

	internal static void c5FsqW8VYF1CduVeaP7(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static void pL45s88AvI2XTgERKWo()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}
}
