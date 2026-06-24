using System;
using System.Linq;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Workflow.Validation;

public class ElementValidationHelper
{
	private IValidatable element;

	private static ElementValidationHelper ixxryeYfl19cNwsAvoe;

	public ElementValidationHelper(IValidatable element)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		Xm3f07Yj9O0ZRopVDo2();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5d3bc916b5664717ac60544de077bd16 != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
				this.element = element;
				num = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f2d402219199402696ade21eab23d086 == 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public ProcessValidationMessage CreateValidationError(string message)
	{
		return CreateValidationMessage(message, ProcessValidationMessageType.Error);
	}

	public ProcessValidationMessage CreateValidationWarning(string message)
	{
		return CreateValidationMessage(message, ProcessValidationMessageType.Warning);
	}

	public ProcessValidationMessage CreateValidationMessage(string message, ProcessValidationMessageType messageType)
	{
		ProcessValidationMessage processValidationMessage = new ProcessValidationMessage();
		NMPmqnYR4JRLZTEPYNm(processValidationMessage, messageType);
		XEqpqmY6sL1W6V5xg53(processValidationMessage, message);
		processValidationMessage.Object = element;
		return processValidationMessage;
	}

	public void ValidatePropertyExists(WorkflowProcessValidator validator, Guid propertyUid, string message, bool errorOnEmptyUid)
	{
		//Discarded unreachable code: IL_005b, IL_008b
		int num = 5;
		int num2 = num;
		_003C_003Ec__DisplayClass4_0 _003C_003Ec__DisplayClass4_ = default(_003C_003Ec__DisplayClass4_0);
		while (true)
		{
			switch (num2)
			{
			case 4:
				_003C_003Ec__DisplayClass4_.propertyUid = propertyUid;
				num2 = 3;
				continue;
			case 2:
				return;
			case 8:
				return;
			case 1:
				validator.Messages.Add(CreateValidationError(message));
				num2 = 7;
				continue;
			case 5:
				_003C_003Ec__DisplayClass4_ = new _003C_003Ec__DisplayClass4_0();
				num2 = 4;
				continue;
			case 6:
				validator.Messages.Add(CreateValidationError(message));
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_32f3e755437f4eacb85c8a0d536f83ea != 0)
				{
					num2 = 0;
				}
				continue;
			case 7:
				return;
			default:
				if (validator.AllProperties.Any(_003C_003Ec__DisplayClass4_._003CValidatePropertyExists_003Eb__0))
				{
					num2 = 8;
					continue;
				}
				goto case 6;
			case 3:
				if (!wUIr0qYqh4uwmMAcCGO(_003C_003Ec__DisplayClass4_.propertyUid, Guid.Empty))
				{
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0262725a60774e44a84fd2b93b79ee8a == 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			case 9:
				break;
			}
			if (!errorOnEmptyUid)
			{
				break;
			}
			num2 = 1;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_160bffb148c14c5da92d8d6ddf481bdc != 0)
			{
				num2 = 1;
			}
		}
	}

	public void ValidateProperty(WorkflowProcessValidator validator, Guid propertyUid, Func<IPropertyMetadata, bool> validationFunc, string message)
	{
		_003C_003Ec__DisplayClass5_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass5_0();
		CS_0024_003C_003E8__locals0.propertyUid = propertyUid;
		IPropertyMetadata propertyMetadata = validator.AllProperties.FirstOrDefault((IPropertyMetadata p1) => _003C_003Ec__DisplayClass5_0.zeQFZLZL1gB1f9dSIT6b(_003C_003Ec__DisplayClass5_0.KgfhThZLSP3qw1CiaagU(p1), CS_0024_003C_003E8__locals0.propertyUid));
		if (propertyMetadata != null && !validationFunc(propertyMetadata))
		{
			validator.Messages.Add(CreateValidationError(message));
		}
	}

	internal static void Xm3f07Yj9O0ZRopVDo2()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static bool LuY93NY9HIgAYTR6c0L()
	{
		return ixxryeYfl19cNwsAvoe == null;
	}

	internal static ElementValidationHelper EK314iYW3MjxYt9uJto()
	{
		return ixxryeYfl19cNwsAvoe;
	}

	internal static void NMPmqnYR4JRLZTEPYNm(object P_0, ProcessValidationMessageType value)
	{
		((ProcessValidationMessage)P_0).Type = value;
	}

	internal static void XEqpqmY6sL1W6V5xg53(object P_0, object P_1)
	{
		((ProcessValidationMessage)P_0).Message = (string)P_1;
	}

	internal static bool wUIr0qYqh4uwmMAcCGO(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}
}
