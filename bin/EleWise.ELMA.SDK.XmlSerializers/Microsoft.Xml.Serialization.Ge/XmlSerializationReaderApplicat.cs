using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;
using EleWise.ELMA.Runtime.Cache;

namespace Microsoft.Xml.Serialization.GeneratedAssembly;

public class XmlSerializationReaderApplicationStartCache : XmlSerializationReader
{
	private string id2_Item;

	private string id3_AssemblyInfos;

	private string id7_string;

	private string id10_HashCode;

	private string id16_int;

	private string id1_ApplicationStartCache;

	private string id15_EnabledInterceptors;

	private string id11_IsComponentAssembly;

	private string id13_TypeInfoCache;

	private string id8_DynamicPublication;

	private string id19_IsServiceType;

	private string id9_AssemblyName;

	private string id12_TypeInfos;

	private string id18_IsComponentType;

	private string id17_DisabledInterceptors;

	private string id4_AssemblyInfoCache;

	private string id6_InterceptorNames;

	private string id5_Mappings;

	private string id14_TypeName;

	public object Read6_ApplicationStartCache()
	{
		object result = null;
		base.Reader.MoveToContent();
		if (base.Reader.NodeType == XmlNodeType.Element)
		{
			if ((object)base.Reader.LocalName != id1_ApplicationStartCache || (object)base.Reader.NamespaceURI != id2_Item)
			{
				throw CreateUnknownNodeException();
			}
			result = Read5_ApplicationStartCache(isNullable: true, checkType: true);
		}
		else
		{
			UnknownNode(null, ":ApplicationStartCache");
		}
		return result;
	}

	private ApplicationStartCache Read5_ApplicationStartCache(bool isNullable, bool checkType)
	{
		XmlQualifiedName xmlQualifiedName = (checkType ? GetXsiType() : null);
		bool flag = false;
		if (isNullable)
		{
			flag = ReadNull();
		}
		if (checkType && !(xmlQualifiedName == null) && ((object)xmlQualifiedName.Name != id1_ApplicationStartCache || (object)xmlQualifiedName.Namespace != id2_Item))
		{
			throw CreateUnknownTypeException(xmlQualifiedName);
		}
		if (flag)
		{
			return null;
		}
		ApplicationStartCache applicationStartCache = new ApplicationStartCache();
		if (applicationStartCache.InterceptorNames == null)
		{
			applicationStartCache.InterceptorNames = new List<string>();
		}
		_ = applicationStartCache.InterceptorNames;
		bool[] array = new bool[4];
		while (base.Reader.MoveToNextAttribute())
		{
			if (!IsXmlnsAttribute(base.Reader.Name))
			{
				UnknownNode(applicationStartCache);
			}
		}
		base.Reader.MoveToElement();
		if (base.Reader.IsEmptyElement)
		{
			base.Reader.Skip();
			return applicationStartCache;
		}
		base.Reader.ReadStartElement();
		base.Reader.MoveToContent();
		int whileIterations = 0;
		int readerCount = base.ReaderCount;
		while (base.Reader.NodeType != XmlNodeType.EndElement && base.Reader.NodeType != 0)
		{
			if (base.Reader.NodeType == XmlNodeType.Element)
			{
				if ((object)base.Reader.LocalName == id3_AssemblyInfos && (object)base.Reader.NamespaceURI == id2_Item)
				{
					if (!ReadNull())
					{
						AssemblyInfoCache[] array2 = null;
						int num = 0;
						if (base.Reader.IsEmptyElement)
						{
							base.Reader.Skip();
						}
						else
						{
							base.Reader.ReadStartElement();
							base.Reader.MoveToContent();
							int whileIterations2 = 0;
							int readerCount2 = base.ReaderCount;
							while (base.Reader.NodeType != XmlNodeType.EndElement && base.Reader.NodeType != 0)
							{
								if (base.Reader.NodeType == XmlNodeType.Element)
								{
									if ((object)base.Reader.LocalName == id4_AssemblyInfoCache && (object)base.Reader.NamespaceURI == id2_Item)
									{
										array2 = (AssemblyInfoCache[])EnsureArrayIndex(array2, num, typeof(AssemblyInfoCache));
										array2[num++] = Read4_AssemblyInfoCache(isNullable: true, checkType: true);
									}
									else
									{
										UnknownNode(null, ":AssemblyInfoCache");
									}
								}
								else
								{
									UnknownNode(null, ":AssemblyInfoCache");
								}
								base.Reader.MoveToContent();
								CheckReaderCount(ref whileIterations2, ref readerCount2);
							}
							ReadEndElement();
						}
						applicationStartCache.AssemblyInfos = (AssemblyInfoCache[])ShrinkArray(array2, num, typeof(AssemblyInfoCache), isNullable: false);
					}
				}
				else if (!array[1] && (object)base.Reader.LocalName == id5_Mappings && (object)base.Reader.NamespaceURI == id2_Item)
				{
					applicationStartCache.Mappings = base.Reader.ReadElementString();
					array[1] = true;
				}
				else if ((object)base.Reader.LocalName == id6_InterceptorNames && (object)base.Reader.NamespaceURI == id2_Item)
				{
					if (!ReadNull())
					{
						if (applicationStartCache.InterceptorNames == null)
						{
							applicationStartCache.InterceptorNames = new List<string>();
						}
						List<string> interceptorNames = applicationStartCache.InterceptorNames;
						if (base.Reader.IsEmptyElement)
						{
							base.Reader.Skip();
						}
						else
						{
							base.Reader.ReadStartElement();
							base.Reader.MoveToContent();
							int whileIterations3 = 0;
							int readerCount3 = base.ReaderCount;
							while (base.Reader.NodeType != XmlNodeType.EndElement && base.Reader.NodeType != 0)
							{
								if (base.Reader.NodeType == XmlNodeType.Element)
								{
									if ((object)base.Reader.LocalName == id7_string && (object)base.Reader.NamespaceURI == id2_Item)
									{
										if (ReadNull())
										{
											interceptorNames.Add(null);
										}
										else
										{
											interceptorNames.Add(base.Reader.ReadElementString());
										}
									}
									else
									{
										UnknownNode(null, ":string");
									}
								}
								else
								{
									UnknownNode(null, ":string");
								}
								base.Reader.MoveToContent();
								CheckReaderCount(ref whileIterations3, ref readerCount3);
							}
							ReadEndElement();
						}
					}
				}
				else if (!array[3] && (object)base.Reader.LocalName == id8_DynamicPublication && (object)base.Reader.NamespaceURI == id2_Item)
				{
					if (base.Reader.IsEmptyElement)
					{
						base.Reader.Skip();
					}
					else
					{
						applicationStartCache.DynamicPublication = XmlConvert.ToBoolean(base.Reader.ReadElementString());
					}
					array[3] = true;
				}
				else
				{
					UnknownNode(applicationStartCache, ":AssemblyInfos, :Mappings, :InterceptorNames, :DynamicPublication");
				}
			}
			else
			{
				UnknownNode(applicationStartCache, ":AssemblyInfos, :Mappings, :InterceptorNames, :DynamicPublication");
			}
			base.Reader.MoveToContent();
			CheckReaderCount(ref whileIterations, ref readerCount);
		}
		ReadEndElement();
		return applicationStartCache;
	}

	private AssemblyInfoCache Read4_AssemblyInfoCache(bool isNullable, bool checkType)
	{
		XmlQualifiedName xmlQualifiedName = (checkType ? GetXsiType() : null);
		bool flag = false;
		if (isNullable)
		{
			flag = ReadNull();
		}
		if (checkType && !(xmlQualifiedName == null) && ((object)xmlQualifiedName.Name != id4_AssemblyInfoCache || (object)xmlQualifiedName.Namespace != id2_Item))
		{
			throw CreateUnknownTypeException(xmlQualifiedName);
		}
		if (flag)
		{
			return null;
		}
		AssemblyInfoCache assemblyInfoCache = new AssemblyInfoCache();
		bool[] array = new bool[4];
		while (base.Reader.MoveToNextAttribute())
		{
			if (!IsXmlnsAttribute(base.Reader.Name))
			{
				UnknownNode(assemblyInfoCache);
			}
		}
		base.Reader.MoveToElement();
		if (base.Reader.IsEmptyElement)
		{
			base.Reader.Skip();
			return assemblyInfoCache;
		}
		base.Reader.ReadStartElement();
		base.Reader.MoveToContent();
		int whileIterations = 0;
		int readerCount = base.ReaderCount;
		while (base.Reader.NodeType != XmlNodeType.EndElement && base.Reader.NodeType != 0)
		{
			if (base.Reader.NodeType == XmlNodeType.Element)
			{
				if (!array[0] && (object)base.Reader.LocalName == id9_AssemblyName && (object)base.Reader.NamespaceURI == id2_Item)
				{
					assemblyInfoCache.AssemblyName = base.Reader.ReadElementString();
					array[0] = true;
				}
				else if (!array[1] && (object)base.Reader.LocalName == id10_HashCode && (object)base.Reader.NamespaceURI == id2_Item)
				{
					assemblyInfoCache.HashCode = base.Reader.ReadElementString();
					array[1] = true;
				}
				else if (!array[2] && (object)base.Reader.LocalName == id11_IsComponentAssembly && (object)base.Reader.NamespaceURI == id2_Item)
				{
					assemblyInfoCache.IsComponentAssembly = Read1_NullableOfBoolean(checkType: true);
					array[2] = true;
				}
				else if ((object)base.Reader.LocalName == id12_TypeInfos && (object)base.Reader.NamespaceURI == id2_Item)
				{
					if (!ReadNull())
					{
						TypeInfoCache[] array2 = null;
						int num = 0;
						if (base.Reader.IsEmptyElement)
						{
							base.Reader.Skip();
						}
						else
						{
							base.Reader.ReadStartElement();
							base.Reader.MoveToContent();
							int whileIterations2 = 0;
							int readerCount2 = base.ReaderCount;
							while (base.Reader.NodeType != XmlNodeType.EndElement && base.Reader.NodeType != 0)
							{
								if (base.Reader.NodeType == XmlNodeType.Element)
								{
									if ((object)base.Reader.LocalName == id13_TypeInfoCache && (object)base.Reader.NamespaceURI == id2_Item)
									{
										array2 = (TypeInfoCache[])EnsureArrayIndex(array2, num, typeof(TypeInfoCache));
										array2[num++] = Read3_TypeInfoCache(isNullable: true, checkType: true);
									}
									else
									{
										UnknownNode(null, ":TypeInfoCache");
									}
								}
								else
								{
									UnknownNode(null, ":TypeInfoCache");
								}
								base.Reader.MoveToContent();
								CheckReaderCount(ref whileIterations2, ref readerCount2);
							}
							ReadEndElement();
						}
						assemblyInfoCache.TypeInfos = (TypeInfoCache[])ShrinkArray(array2, num, typeof(TypeInfoCache), isNullable: false);
					}
				}
				else
				{
					UnknownNode(assemblyInfoCache, ":AssemblyName, :HashCode, :IsComponentAssembly, :TypeInfos");
				}
			}
			else
			{
				UnknownNode(assemblyInfoCache, ":AssemblyName, :HashCode, :IsComponentAssembly, :TypeInfos");
			}
			base.Reader.MoveToContent();
			CheckReaderCount(ref whileIterations, ref readerCount);
		}
		ReadEndElement();
		return assemblyInfoCache;
	}

	private TypeInfoCache Read3_TypeInfoCache(bool isNullable, bool checkType)
	{
		XmlQualifiedName xmlQualifiedName = (checkType ? GetXsiType() : null);
		bool flag = false;
		if (isNullable)
		{
			flag = ReadNull();
		}
		if (checkType && !(xmlQualifiedName == null) && ((object)xmlQualifiedName.Name != id13_TypeInfoCache || (object)xmlQualifiedName.Namespace != id2_Item))
		{
			throw CreateUnknownTypeException(xmlQualifiedName);
		}
		if (flag)
		{
			return null;
		}
		TypeInfoCache typeInfoCache = new TypeInfoCache();
		if (typeInfoCache.EnabledInterceptors == null)
		{
			typeInfoCache.EnabledInterceptors = new List<int>();
		}
		_ = typeInfoCache.EnabledInterceptors;
		if (typeInfoCache.DisabledInterceptors == null)
		{
			typeInfoCache.DisabledInterceptors = new List<int>();
		}
		_ = typeInfoCache.DisabledInterceptors;
		bool[] array = new bool[5];
		while (base.Reader.MoveToNextAttribute())
		{
			if (!IsXmlnsAttribute(base.Reader.Name))
			{
				UnknownNode(typeInfoCache);
			}
		}
		base.Reader.MoveToElement();
		if (base.Reader.IsEmptyElement)
		{
			base.Reader.Skip();
			return typeInfoCache;
		}
		base.Reader.ReadStartElement();
		base.Reader.MoveToContent();
		int whileIterations = 0;
		int readerCount = base.ReaderCount;
		while (base.Reader.NodeType != XmlNodeType.EndElement && base.Reader.NodeType != 0)
		{
			if (base.Reader.NodeType == XmlNodeType.Element)
			{
				if (!array[0] && (object)base.Reader.LocalName == id14_TypeName && (object)base.Reader.NamespaceURI == id2_Item)
				{
					typeInfoCache.TypeName = base.Reader.ReadElementString();
					array[0] = true;
				}
				else if ((object)base.Reader.LocalName == id15_EnabledInterceptors && (object)base.Reader.NamespaceURI == id2_Item)
				{
					if (!ReadNull())
					{
						if (typeInfoCache.EnabledInterceptors == null)
						{
							typeInfoCache.EnabledInterceptors = new List<int>();
						}
						List<int> enabledInterceptors = typeInfoCache.EnabledInterceptors;
						if (base.Reader.IsEmptyElement)
						{
							base.Reader.Skip();
						}
						else
						{
							base.Reader.ReadStartElement();
							base.Reader.MoveToContent();
							int whileIterations2 = 0;
							int readerCount2 = base.ReaderCount;
							while (base.Reader.NodeType != XmlNodeType.EndElement && base.Reader.NodeType != 0)
							{
								if (base.Reader.NodeType == XmlNodeType.Element)
								{
									if ((object)base.Reader.LocalName == id16_int && (object)base.Reader.NamespaceURI == id2_Item)
									{
										enabledInterceptors.Add(XmlConvert.ToInt32(base.Reader.ReadElementString()));
									}
									else
									{
										UnknownNode(null, ":int");
									}
								}
								else
								{
									UnknownNode(null, ":int");
								}
								base.Reader.MoveToContent();
								CheckReaderCount(ref whileIterations2, ref readerCount2);
							}
							ReadEndElement();
						}
					}
				}
				else if ((object)base.Reader.LocalName == id17_DisabledInterceptors && (object)base.Reader.NamespaceURI == id2_Item)
				{
					if (!ReadNull())
					{
						if (typeInfoCache.DisabledInterceptors == null)
						{
							typeInfoCache.DisabledInterceptors = new List<int>();
						}
						List<int> disabledInterceptors = typeInfoCache.DisabledInterceptors;
						if (base.Reader.IsEmptyElement)
						{
							base.Reader.Skip();
						}
						else
						{
							base.Reader.ReadStartElement();
							base.Reader.MoveToContent();
							int whileIterations3 = 0;
							int readerCount3 = base.ReaderCount;
							while (base.Reader.NodeType != XmlNodeType.EndElement && base.Reader.NodeType != 0)
							{
								if (base.Reader.NodeType == XmlNodeType.Element)
								{
									if ((object)base.Reader.LocalName == id16_int && (object)base.Reader.NamespaceURI == id2_Item)
									{
										disabledInterceptors.Add(XmlConvert.ToInt32(base.Reader.ReadElementString()));
									}
									else
									{
										UnknownNode(null, ":int");
									}
								}
								else
								{
									UnknownNode(null, ":int");
								}
								base.Reader.MoveToContent();
								CheckReaderCount(ref whileIterations3, ref readerCount3);
							}
							ReadEndElement();
						}
					}
				}
				else if (!array[3] && (object)base.Reader.LocalName == id18_IsComponentType && (object)base.Reader.NamespaceURI == id2_Item)
				{
					typeInfoCache.IsComponentType = Read1_NullableOfBoolean(checkType: true);
					array[3] = true;
				}
				else if (!array[4] && (object)base.Reader.LocalName == id19_IsServiceType && (object)base.Reader.NamespaceURI == id2_Item)
				{
					typeInfoCache.IsServiceType = Read1_NullableOfBoolean(checkType: true);
					array[4] = true;
				}
				else
				{
					UnknownNode(typeInfoCache, ":TypeName, :EnabledInterceptors, :DisabledInterceptors, :IsComponentType, :IsServiceType");
				}
			}
			else
			{
				UnknownNode(typeInfoCache, ":TypeName, :EnabledInterceptors, :DisabledInterceptors, :IsComponentType, :IsServiceType");
			}
			base.Reader.MoveToContent();
			CheckReaderCount(ref whileIterations, ref readerCount);
		}
		ReadEndElement();
		return typeInfoCache;
	}

	private bool? Read1_NullableOfBoolean(bool checkType)
	{
		bool? result = null;
		if (ReadNull())
		{
			return result;
		}
		return XmlConvert.ToBoolean(base.Reader.ReadElementString());
	}

	protected override void InitCallbacks()
	{
	}

	protected override void InitIDs()
	{
		id2_Item = base.Reader.NameTable.Add("");
		id3_AssemblyInfos = base.Reader.NameTable.Add("AssemblyInfos");
		id7_string = base.Reader.NameTable.Add("string");
		id10_HashCode = base.Reader.NameTable.Add("HashCode");
		id16_int = base.Reader.NameTable.Add("int");
		id1_ApplicationStartCache = base.Reader.NameTable.Add("ApplicationStartCache");
		id15_EnabledInterceptors = base.Reader.NameTable.Add("EnabledInterceptors");
		id11_IsComponentAssembly = base.Reader.NameTable.Add("IsComponentAssembly");
		id13_TypeInfoCache = base.Reader.NameTable.Add("TypeInfoCache");
		id8_DynamicPublication = base.Reader.NameTable.Add("DynamicPublication");
		id19_IsServiceType = base.Reader.NameTable.Add("IsServiceType");
		id9_AssemblyName = base.Reader.NameTable.Add("AssemblyName");
		id12_TypeInfos = base.Reader.NameTable.Add("TypeInfos");
		id18_IsComponentType = base.Reader.NameTable.Add("IsComponentType");
		id17_DisabledInterceptors = base.Reader.NameTable.Add("DisabledInterceptors");
		id4_AssemblyInfoCache = base.Reader.NameTable.Add("AssemblyInfoCache");
		id6_InterceptorNames = base.Reader.NameTable.Add("InterceptorNames");
		id5_Mappings = base.Reader.NameTable.Add("Mappings");
		id14_TypeName = base.Reader.NameTable.Add("TypeName");
	}
}
