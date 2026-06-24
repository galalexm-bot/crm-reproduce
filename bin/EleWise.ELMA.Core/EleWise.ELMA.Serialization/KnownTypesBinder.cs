using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Model.Views.Toolbar;
using Newtonsoft.Json.Serialization;

namespace EleWise.ELMA.Serialization;

public sealed class KnownTypesBinder : ISerializationBinder
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();

		public static Func<System.Type, string> _003C_003E9__2_0;

		internal string _003CGetFullName_003Eb__2_0(System.Type arg)
		{
			return "[" + GetFullName(arg) + "]";
		}
	}

	public System.Type BindToType(string assemblyName, string typeName)
	{
		System.Type type = System.Type.GetType(typeName);
		if (type == null)
		{
			if (typeName == "EleWise.ELMA.Model.Views.Toolbar.Toolbar")
			{
				return typeof(ToolbarViewItem);
			}
			if (typeName == "EleWise.ELMA.Model.Views.Toolbar.Group")
			{
				return typeof(GroupViewItem);
			}
			if (typeName == "EleWise.ELMA.Model.Views.Toolbar.Button")
			{
				return typeof(ButtonViewItem);
			}
			if (typeName == "EleWise.ELMA.Model.Views.Toolbar.Separator")
			{
				return typeof(SeparatorViewItem);
			}
			if (typeName == "EleWise.ELMA.Model.Views.Toolbar.DynamicListToolbarItem")
			{
				return typeof(DynamicListViewItem);
			}
			if (typeName == "EleWise.ELMA.Model.Views.Toolbar.DynamicSlotToolbarItem")
			{
				return typeof(DynamicSlotViewItem);
			}
			if (typeName == "EleWise.ELMA.Model.Views.Toolbar.SlotToolbarItem")
			{
				return typeof(SlotViewItem);
			}
			if (!typeName.Contains("ViewItem"))
			{
				return typeof(UnknownTypeObject);
			}
			return typeof(UnknownTypeViewItem);
		}
		return type;
	}

	public void BindToName(System.Type serializedType, out string assemblyName, out string typeName)
	{
		assemblyName = ((serializedType.get_Assembly().get_FullName() == "EleWise.ELMA.Core.Builder") ? "" : serializedType.get_Assembly().get_FullName());
		typeName = GetFullName(serializedType);
	}

	internal static string GetFullName(System.Type serializedType)
	{
		if (!serializedType.get_IsGenericType())
		{
			return serializedType.get_FullName();
		}
		return serializedType.GetGenericTypeDefinition().get_FullName() + "[" + string.Join(", ", (System.Collections.Generic.IEnumerable<string>)Enumerable.Select<System.Type, string>((System.Collections.Generic.IEnumerable<System.Type>)serializedType.GetGenericArguments(), (Func<System.Type, string>)((System.Type arg) => "[" + GetFullName(arg) + "]"))) + "]";
	}
}
