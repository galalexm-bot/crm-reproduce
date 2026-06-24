using System;
using EleWise.ELMA.Core;

namespace EleWise.ELMA.Exceptions;

public class VariableNotFoundException : System.Exception
{
	private readonly string _003CVariableName_003Ek__BackingField;

	public string VariableName => _003CVariableName_003Ek__BackingField;

	public VariableNotFoundException()
	{
	}

	public VariableNotFoundException(string variableName)
		: base(SR.T("Не найдено значение переменной \"{0}\"", variableName))
	{
		_003CVariableName_003Ek__BackingField = variableName;
	}
}
