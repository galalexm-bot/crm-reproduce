using System;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.Tasks.Components;

public class SubtaskFieldTypeAttribute : Attribute
{
	private CreateSubtaskSettingTypes fieldType;

	public CreateSubtaskSettingTypes FieldType => fieldType;

	public SubtaskFieldTypeAttribute(CreateSubtaskSettingTypes type)
	{
		fieldType = type;
	}
}
