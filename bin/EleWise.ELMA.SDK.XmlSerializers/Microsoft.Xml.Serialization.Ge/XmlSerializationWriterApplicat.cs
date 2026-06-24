using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;
using EleWise.ELMA.Runtime.Cache;

namespace Microsoft.Xml.Serialization.GeneratedAssembly;

public class XmlSerializationWriterApplicationStartCache : XmlSerializationWriter
{
	public void Write5_ApplicationStartCache(object o)
	{
		WriteStartDocument();
		if (o == null)
		{
			WriteNullTagLiteral("ApplicationStartCache", "");
			return;
		}
		TopLevelElement();
		Write4_ApplicationStartCache("ApplicationStartCache", "", (ApplicationStartCache)o, isNullable: true, needType: false);
	}

	private void Write4_ApplicationStartCache(string n, string ns, ApplicationStartCache o, bool isNullable, bool needType)
	{
		if (o == null)
		{
			if (isNullable)
			{
				WriteNullTagLiteral(n, ns);
			}
			return;
		}
		if (!needType)
		{
			Type type = o.GetType();
			if (!(type == typeof(ApplicationStartCache)))
			{
				throw CreateUnknownTypeException(o);
			}
		}
		WriteStartElement(n, ns, o, writePrefixed: false, null);
		if (needType)
		{
			WriteXsiType("ApplicationStartCache", "");
		}
		AssemblyInfoCache[] assemblyInfos = o.AssemblyInfos;
		if (assemblyInfos != null)
		{
			WriteStartElement("AssemblyInfos", "", null, writePrefixed: false);
			for (int i = 0; i < assemblyInfos.Length; i++)
			{
				Write3_AssemblyInfoCache("AssemblyInfoCache", "", assemblyInfos[i], isNullable: true, needType: false);
			}
			WriteEndElement();
		}
		WriteElementString("Mappings", "", o.Mappings);
		List<string> interceptorNames = o.InterceptorNames;
		if (interceptorNames != null)
		{
			WriteStartElement("InterceptorNames", "", null, writePrefixed: false);
			for (int j = 0; j < ((ICollection)interceptorNames).Count; j++)
			{
				WriteNullableStringLiteral("string", "", interceptorNames[j]);
			}
			WriteEndElement();
		}
		if (!o.DynamicPublication)
		{
			WriteElementStringRaw("DynamicPublication", "", XmlConvert.ToString(o.DynamicPublication));
		}
		WriteEndElement(o);
	}

	private void Write3_AssemblyInfoCache(string n, string ns, AssemblyInfoCache o, bool isNullable, bool needType)
	{
		if (o == null)
		{
			if (isNullable)
			{
				WriteNullTagLiteral(n, ns);
			}
			return;
		}
		if (!needType)
		{
			Type type = o.GetType();
			if (!(type == typeof(AssemblyInfoCache)))
			{
				throw CreateUnknownTypeException(o);
			}
		}
		WriteStartElement(n, ns, o, writePrefixed: false, null);
		if (needType)
		{
			WriteXsiType("AssemblyInfoCache", "");
		}
		WriteElementString("AssemblyName", "", o.AssemblyName);
		WriteElementString("HashCode", "", o.HashCode);
		if (o.IsComponentAssembly.HasValue)
		{
			WriteNullableStringLiteralRaw("IsComponentAssembly", "", XmlConvert.ToString(o.IsComponentAssembly.Value));
		}
		else
		{
			WriteNullTagLiteral("IsComponentAssembly", "");
		}
		TypeInfoCache[] typeInfos = o.TypeInfos;
		if (typeInfos != null)
		{
			WriteStartElement("TypeInfos", "", null, writePrefixed: false);
			for (int i = 0; i < typeInfos.Length; i++)
			{
				Write2_TypeInfoCache("TypeInfoCache", "", typeInfos[i], isNullable: true, needType: false);
			}
			WriteEndElement();
		}
		WriteEndElement(o);
	}

	private void Write2_TypeInfoCache(string n, string ns, TypeInfoCache o, bool isNullable, bool needType)
	{
		if (o == null)
		{
			if (isNullable)
			{
				WriteNullTagLiteral(n, ns);
			}
			return;
		}
		if (!needType)
		{
			Type type = o.GetType();
			if (!(type == typeof(TypeInfoCache)))
			{
				throw CreateUnknownTypeException(o);
			}
		}
		WriteStartElement(n, ns, o, writePrefixed: false, null);
		if (needType)
		{
			WriteXsiType("TypeInfoCache", "");
		}
		WriteElementString("TypeName", "", o.TypeName);
		List<int> enabledInterceptors = o.EnabledInterceptors;
		if (enabledInterceptors != null)
		{
			WriteStartElement("EnabledInterceptors", "", null, writePrefixed: false);
			for (int i = 0; i < ((ICollection)enabledInterceptors).Count; i++)
			{
				WriteElementStringRaw("int", "", XmlConvert.ToString(enabledInterceptors[i]));
			}
			WriteEndElement();
		}
		List<int> disabledInterceptors = o.DisabledInterceptors;
		if (disabledInterceptors != null)
		{
			WriteStartElement("DisabledInterceptors", "", null, writePrefixed: false);
			for (int j = 0; j < ((ICollection)disabledInterceptors).Count; j++)
			{
				WriteElementStringRaw("int", "", XmlConvert.ToString(disabledInterceptors[j]));
			}
			WriteEndElement();
		}
		if (o.IsComponentType.HasValue)
		{
			WriteNullableStringLiteralRaw("IsComponentType", "", XmlConvert.ToString(o.IsComponentType.Value));
		}
		else
		{
			WriteNullTagLiteral("IsComponentType", "");
		}
		if (o.IsServiceType.HasValue)
		{
			WriteNullableStringLiteralRaw("IsServiceType", "", XmlConvert.ToString(o.IsServiceType.Value));
		}
		else
		{
			WriteNullTagLiteral("IsServiceType", "");
		}
		WriteEndElement(o);
	}

	protected override void InitCallbacks()
	{
	}
}
