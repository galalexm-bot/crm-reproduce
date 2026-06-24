using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Security;
using System.Security.Permissions;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Xml;
using System.Xml.Serialization;
using Microsoft.Win32;

namespace EleWise.ELMA.XmlSerializers;

internal class TempAssembly
{
	internal class TempMethod
	{
		internal MethodInfo writeMethod;

		internal MethodInfo readMethod;

		internal string name;

		internal string ns;

		internal bool isSoap;

		internal string methodKey;
	}

	internal sealed class TempMethodDictionary : DictionaryBase
	{
		internal TempMethod this[string key] => (TempMethod)base.Dictionary[key];

		internal void Add(string key, TempMethod value)
		{
			base.Dictionary.Add(key, value);
		}
	}

	internal const string GeneratedAssemblyNamespace = "Microsoft.Xml.Serialization.GeneratedAssembly";

	private Assembly assembly;

	private bool pregeneratedAssmbly;

	private XmlSerializerImplementation contract;

	private Hashtable writerMethods;

	private Hashtable readerMethods;

	private TempMethodDictionary methods;

	private static object[] emptyObjectArray = new object[0];

	private Hashtable assemblies = new Hashtable();

	private static volatile FileIOPermission fileIOPermission;

	internal static bool UseLegacySerializerGeneration => true;

	internal XmlSerializerImplementation Contract
	{
		get
		{
			if (contract == null)
			{
				contract = (XmlSerializerImplementation)Activator.CreateInstance(GetTypeFromAssembly(assembly, "XmlSerializerContract"));
			}
			return contract;
		}
	}

	internal static FileIOPermission FileIOPermission
	{
		get
		{
			if (fileIOPermission == null)
			{
				fileIOPermission = new FileIOPermission(PermissionState.Unrestricted);
			}
			return fileIOPermission;
		}
	}

	internal bool NeedAssembyResolve
	{
		get
		{
			if (assemblies != null)
			{
				return assemblies.Count > 0;
			}
			return false;
		}
	}

	private TempAssembly()
	{
	}

	internal TempAssembly(XmlMapping[] xmlMappings, Type[] types, string defaultNamespace, string location, Evidence evidence)
	{
		if (true)
		{
			assembly = GenerateAssembly(xmlMappings, types, defaultNamespace, evidence, XmlSerializerCompilerParameters.Create(location), null, assemblies);
		}
		InitAssemblyMethods(xmlMappings);
	}

	internal TempAssembly(XmlMapping[] xmlMappings, Assembly assembly, XmlSerializerImplementation contract)
	{
		this.assembly = assembly;
		InitAssemblyMethods(xmlMappings);
		this.contract = contract;
		pregeneratedAssmbly = true;
	}

	internal TempAssembly(XmlSerializerImplementation contract)
	{
		this.contract = contract;
		pregeneratedAssmbly = true;
	}

	internal void InitAssemblyMethods(XmlMapping[] xmlMappings)
	{
		methods = new TempMethodDictionary();
		for (int i = 0; i < xmlMappings.Length; i++)
		{
			TempMethod tempMethod = new TempMethod();
			tempMethod.isSoap = xmlMappings[i].IsSoap;
			tempMethod.methodKey = xmlMappings[i].Key;
			if (xmlMappings[i] is XmlTypeMapping xmlTypeMapping)
			{
				tempMethod.name = xmlTypeMapping.ElementName;
				tempMethod.ns = xmlTypeMapping.Namespace;
			}
			methods.Add(xmlMappings[i].Key, tempMethod);
		}
	}

	internal static Assembly LoadGeneratedAssembly(Type type, string defaultNamespace, out XmlSerializerImplementation contract)
	{
		Assembly assembly = null;
		contract = null;
		string text = null;
		if (Microsoft.Win32.UnsafeNativeMethods.IsPackagedProcess.Value)
		{
			return null;
		}
		bool enabled = DiagnosticsSwitches.PregenEventLog.Enabled;
		object[] customAttributes = type.GetCustomAttributes(typeof(XmlSerializerAssemblyAttribute), inherit: false);
		if (customAttributes.Length == 0)
		{
			AssemblyName name = GetName(type.Assembly, copyName: true);
			text = (name.Name = Compiler.GetTempAssemblyName(name, defaultNamespace));
			name.CodeBase = null;
			name.CultureInfo = CultureInfo.InvariantCulture;
			try
			{
				assembly = Assembly.Load(name);
			}
			catch (Exception ex)
			{
				if (ex is ThreadAbortException || ex is StackOverflowException || ex is OutOfMemoryException)
				{
					throw;
				}
				if (enabled)
				{
					Log(ex.Message, EventLogEntryType.Information);
				}
				byte[] publicKeyToken = name.GetPublicKeyToken();
				if (publicKeyToken != null && publicKeyToken.Length != 0)
				{
					return null;
				}
				assembly = Assembly.LoadWithPartialName(text, null);
			}
			if (assembly == null)
			{
				if (enabled)
				{
					Log(Res.GetString("XmlPregenCannotLoad", text), EventLogEntryType.Information);
				}
				return null;
			}
			if (!IsSerializerVersionMatch(assembly, type, defaultNamespace, null))
			{
				if (enabled)
				{
					Log(Res.GetString("XmlSerializerExpiredDetails", text, type.FullName), EventLogEntryType.Error);
				}
				return null;
			}
		}
		else
		{
			XmlSerializerAssemblyAttribute xmlSerializerAssemblyAttribute = (XmlSerializerAssemblyAttribute)customAttributes[0];
			if (xmlSerializerAssemblyAttribute.AssemblyName != null && xmlSerializerAssemblyAttribute.CodeBase != null)
			{
				throw new InvalidOperationException(Res.GetString("XmlPregenInvalidXmlSerializerAssemblyAttribute", "AssemblyName", "CodeBase"));
			}
			if (xmlSerializerAssemblyAttribute.AssemblyName != null)
			{
				text = xmlSerializerAssemblyAttribute.AssemblyName;
				assembly = Assembly.LoadWithPartialName(text, null);
			}
			else if (xmlSerializerAssemblyAttribute.CodeBase != null && xmlSerializerAssemblyAttribute.CodeBase.Length > 0)
			{
				text = xmlSerializerAssemblyAttribute.CodeBase;
				assembly = Assembly.LoadFrom(text);
			}
			else
			{
				text = type.Assembly.FullName;
				assembly = type.Assembly;
			}
			if (assembly == null)
			{
				throw new FileNotFoundException(null, text);
			}
		}
		Type typeFromAssembly = GetTypeFromAssembly(assembly, "XmlSerializerContract");
		contract = (XmlSerializerImplementation)Activator.CreateInstance(typeFromAssembly);
		if (contract.CanSerialize(type))
		{
			return assembly;
		}
		if (enabled)
		{
			Log(Res.GetString("XmlSerializerExpiredDetails", text, type.FullName), EventLogEntryType.Error);
		}
		return null;
	}

	private static void Log(string message, EventLogEntryType type)
	{
		new EventLogPermission(PermissionState.Unrestricted).Assert();
		EventLog.WriteEntry("XmlSerializer", message, type);
	}

	private static AssemblyName GetName(Assembly assembly, bool copyName)
	{
		PermissionSet permissionSet = new PermissionSet(PermissionState.None);
		permissionSet.AddPermission(new FileIOPermission(PermissionState.Unrestricted));
		permissionSet.Assert();
		return assembly.GetName(copyName);
	}

	private static bool IsSerializerVersionMatch(Assembly serializer, Type type, string defaultNamespace, string location)
	{
		if (serializer == null)
		{
			return false;
		}
		object[] customAttributes = serializer.GetCustomAttributes(typeof(XmlSerializerVersionAttribute), inherit: false);
		if (customAttributes.Length != 1)
		{
			return false;
		}
		XmlSerializerVersionAttribute xmlSerializerVersionAttribute = (XmlSerializerVersionAttribute)customAttributes[0];
		if (xmlSerializerVersionAttribute.ParentAssemblyId == GenerateAssemblyId(type) && xmlSerializerVersionAttribute.Namespace == defaultNamespace)
		{
			return true;
		}
		return false;
	}

	private static string GenerateAssemblyId(Type type)
	{
		Module[] modules = type.Assembly.GetModules();
		ArrayList arrayList = new ArrayList();
		for (int i = 0; i < modules.Length; i++)
		{
			arrayList.Add(modules[i].ModuleVersionId.ToString());
		}
		arrayList.Sort();
		StringBuilder stringBuilder = new StringBuilder();
		for (int j = 0; j < arrayList.Count; j++)
		{
			stringBuilder.Append(arrayList[j].ToString());
			stringBuilder.Append(",");
		}
		return stringBuilder.ToString();
	}

	internal static Assembly GenerateAssembly(XmlMapping[] xmlMappings, Type[] types, string defaultNamespace, Evidence evidence, XmlSerializerCompilerParameters parameters, Assembly[] parentAssemblies, Hashtable assemblies)
	{
		FileIOPermission.Assert();
		Compiler compiler = new Compiler();
		try
		{
			Hashtable hashtable = new Hashtable();
			foreach (XmlMapping xmlMapping in xmlMappings)
			{
				hashtable[xmlMapping.Scope] = xmlMapping;
			}
			TypeScope[] array = new TypeScope[hashtable.Keys.Count];
			hashtable.Keys.CopyTo(array, 0);
			assemblies.Clear();
			Hashtable types2 = new Hashtable();
			TypeScope[] array2 = array;
			for (int i = 0; i < array2.Length; i++)
			{
				foreach (Type type3 in array2[i].Types)
				{
					compiler.AddImport(type3, types2);
					Assembly assembly = type3.Assembly;
					string fullName = assembly.FullName;
					if (assemblies[fullName] == null && !assembly.GlobalAssemblyCache)
					{
						assemblies[fullName] = assembly;
					}
				}
			}
			for (int j = 0; j < types.Length; j++)
			{
				compiler.AddImport(types[j], types2);
			}
			compiler.AddImport(typeof(object).Assembly);
			compiler.AddImport(typeof(IXmlSerializable).Assembly);
			compiler.AddImport(typeof(XmlSerializer).Assembly);
			IndentedWriter indentedWriter = new IndentedWriter(compiler.Source, compact: false);
			indentedWriter.WriteLine("#if _DYNAMIC_XMLSERIALIZER_COMPILATION");
			indentedWriter.WriteLine("[assembly:System.Security.AllowPartiallyTrustedCallers()]");
			indentedWriter.WriteLine("[assembly:System.Security.SecurityTransparent()]");
			indentedWriter.WriteLine("[assembly:System.Security.SecurityRules(System.Security.SecurityRuleSet.Level1)]");
			indentedWriter.WriteLine("#endif");
			if (types != null && types.Length != 0 && types[0] != null)
			{
				indentedWriter.WriteLine("[assembly:System.Reflection.AssemblyVersionAttribute(\"" + types[0].Assembly.GetName().Version.ToString() + "\")]");
			}
			if (parentAssemblies != null && types.Length != 0)
			{
				for (int k = 0; k < types.Length; k++)
				{
					Type type2 = types[k];
					if (!(type2 == null) && DynamicAssemblies.IsTypeDynamic(type2))
					{
						throw new InvalidOperationException(Res.GetString("XmlPregenTypeDynamic", types[k].FullName));
					}
				}
				indentedWriter.Write("[assembly:");
				indentedWriter.Write(typeof(XmlSerializerVersionAttribute).FullName);
				indentedWriter.Write("(");
				indentedWriter.Write("ParentAssemblyId=");
				ReflectionAwareCodeGen.WriteQuotedCSharpString(indentedWriter, GenerateAssemblyId(types[0]));
				indentedWriter.Write(", Version=");
				ReflectionAwareCodeGen.WriteQuotedCSharpString(indentedWriter, "1.0.0.0");
				if (defaultNamespace != null)
				{
					indentedWriter.Write(", Namespace=");
					ReflectionAwareCodeGen.WriteQuotedCSharpString(indentedWriter, defaultNamespace);
				}
				indentedWriter.WriteLine(")]");
			}
			CodeIdentifiers codeIdentifiers = new CodeIdentifiers();
			codeIdentifiers.AddUnique("XmlSerializationWriter", "XmlSerializationWriter");
			codeIdentifiers.AddUnique("XmlSerializationReader", "XmlSerializationReader");
			string text = null;
			if (types != null && types.Length == 1 && types[0] != null)
			{
				text = CodeIdentifier.MakeValid(types[0].Name);
				if (types[0].IsArray)
				{
					text += "Array";
				}
			}
			indentedWriter.WriteLine("namespace Microsoft.Xml.Serialization.GeneratedAssembly {");
			indentedWriter.Indent++;
			indentedWriter.WriteLine();
			int num = 0;
			array2 = array;
			foreach (TypeScope typeScope in array2)
			{
				foreach (TypeMapping item in (IEnumerable<TypeMapping>)new List<TypeMapping>(typeScope.unknownTypeMappings.Keys))
				{
					string text2 = "UnknownType_" + ++num;
					typeScope.unknownTypeMappings[item] = text2;
					indentedWriter.Write("internal sealed class ");
					indentedWriter.Write(text2);
					indentedWriter.Write(" : ");
					indentedWriter.Write(item.TypeDesc.CSharpName);
					indentedWriter.Write(", ");
					indentedWriter.Write(typeof(IUnknownType).FullName);
					indentedWriter.WriteLine(" {");
					indentedWriter.Indent++;
					indentedWriter.WriteLine();
					indentedWriter.WriteLine("private System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<string, string>> attributes;");
					indentedWriter.WriteLine();
					indentedWriter.WriteLine("private System.Collections.Generic.List<System.Xml.XmlNode> nodes;");
					indentedWriter.WriteLine();
					indentedWriter.WriteLine("public System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<string, string>> Attributes { get { return attributes; } set { attributes = value; } }");
					indentedWriter.WriteLine();
					indentedWriter.WriteLine("public System.Collections.Generic.List<System.Xml.XmlNode> Nodes { get { return nodes; } set { nodes = value; } }");
					indentedWriter.Indent--;
					indentedWriter.WriteLine("}");
					indentedWriter.WriteLine();
				}
			}
			string text3 = "XmlSerializationWriter" + text;
			text3 = codeIdentifiers.AddUnique(text3, text3);
			XmlSerializationWriterCodeGen xmlSerializationWriterCodeGen = new XmlSerializationWriterCodeGen(indentedWriter, array, "public", text3);
			xmlSerializationWriterCodeGen.GenerateBegin();
			string[] array3 = new string[xmlMappings.Length];
			for (int l = 0; l < xmlMappings.Length; l++)
			{
				array3[l] = xmlSerializationWriterCodeGen.GenerateElement(xmlMappings[l]);
			}
			xmlSerializationWriterCodeGen.GenerateEnd();
			indentedWriter.WriteLine();
			string text4 = "XmlSerializationReader" + text;
			text4 = codeIdentifiers.AddUnique(text4, text4);
			XmlSerializationReaderCodeGen xmlSerializationReaderCodeGen = new XmlSerializationReaderCodeGen(indentedWriter, array, "public", text4);
			xmlSerializationReaderCodeGen.GenerateBegin();
			string[] array4 = new string[xmlMappings.Length];
			for (int m = 0; m < xmlMappings.Length; m++)
			{
				array4[m] = xmlSerializationReaderCodeGen.GenerateElement(xmlMappings[m]);
			}
			xmlSerializationReaderCodeGen.GenerateEnd(array4, xmlMappings, types);
			string baseSerializer = xmlSerializationReaderCodeGen.GenerateBaseSerializer("XmlSerializer1", text4, text3, codeIdentifiers);
			Hashtable hashtable2 = new Hashtable();
			for (int n = 0; n < xmlMappings.Length; n++)
			{
				if (hashtable2[xmlMappings[n].Key] == null)
				{
					hashtable2[xmlMappings[n].Key] = xmlSerializationReaderCodeGen.GenerateTypedSerializer(array4[n], array3[n], xmlMappings[n], codeIdentifiers, baseSerializer, text4, text3);
				}
			}
			xmlSerializationReaderCodeGen.GenerateSerializerContract("XmlSerializerContract", xmlMappings, types, text4, array4, text3, array3, hashtable2);
			indentedWriter.Indent--;
			indentedWriter.WriteLine("}");
			return compiler.Compile(parentAssemblies, defaultNamespace, parameters, evidence);
		}
		finally
		{
			compiler.Close();
		}
	}

	private static MethodInfo GetMethodFromType(Type type, string methodName, Assembly assembly)
	{
		MethodInfo method = type.GetMethod(methodName);
		if (method != null)
		{
			return method;
		}
		MissingMethodException ex = new MissingMethodException(type.FullName, methodName);
		if (assembly != null)
		{
			throw new InvalidOperationException(Res.GetString("XmlSerializerExpired", assembly.FullName, assembly.CodeBase), ex);
		}
		throw ex;
	}

	internal static Type GetTypeFromAssembly(Assembly assembly, string typeName)
	{
		typeName = "Microsoft.Xml.Serialization.GeneratedAssembly." + typeName;
		Type type = assembly.GetType(typeName);
		if (type == null)
		{
			throw new InvalidOperationException(Res.GetString("XmlMissingType", typeName, assembly.FullName));
		}
		return type;
	}

	internal bool CanRead(XmlMapping mapping, XmlReader xmlReader)
	{
		if (mapping == null)
		{
			return false;
		}
		if (mapping.Accessor.Any)
		{
			return true;
		}
		TempMethod tempMethod = methods[mapping.Key];
		return xmlReader.IsStartElement(tempMethod.name, tempMethod.ns);
	}

	private string ValidateEncodingStyle(string encodingStyle, string methodKey)
	{
		if (encodingStyle != null && encodingStyle.Length > 0)
		{
			if (!methods[methodKey].isSoap)
			{
				throw new InvalidOperationException(Res.GetString("XmlInvalidEncodingNotEncoded1", encodingStyle));
			}
			if (encodingStyle != "http://schemas.xmlsoap.org/soap/encoding/" && encodingStyle != "http://www.w3.org/2003/05/soap-encoding")
			{
				throw new InvalidOperationException(Res.GetString("XmlInvalidEncoding3", encodingStyle, "http://schemas.xmlsoap.org/soap/encoding/", "http://www.w3.org/2003/05/soap-encoding"));
			}
		}
		else if (methods[methodKey].isSoap)
		{
			encodingStyle = "http://schemas.xmlsoap.org/soap/encoding/";
		}
		return encodingStyle;
	}

	internal object InvokeReader(XmlMapping mapping, XmlReader xmlReader, XmlDeserializationEvents events, string encodingStyle)
	{
		XmlSerializationReader xmlSerializationReader = null;
		try
		{
			encodingStyle = ValidateEncodingStyle(encodingStyle, mapping.Key);
			xmlSerializationReader = Contract.Reader;
			xmlSerializationReader.Init(xmlReader, events, encodingStyle, this);
			if (methods[mapping.Key].readMethod == null)
			{
				if (readerMethods == null)
				{
					readerMethods = Contract.ReadMethods;
				}
				string text = (string)readerMethods[mapping.Key];
				if (text == null)
				{
					throw new InvalidOperationException(Res.GetString("XmlNotSerializable", mapping.Accessor.Name));
				}
				methods[mapping.Key].readMethod = GetMethodFromType(xmlSerializationReader.GetType(), text, pregeneratedAssmbly ? assembly : null);
			}
			return methods[mapping.Key].readMethod.Invoke(xmlSerializationReader, emptyObjectArray);
		}
		catch (SecurityException innerException)
		{
			throw new InvalidOperationException(Res.GetString("XmlNoPartialTrust"), innerException);
		}
		finally
		{
			xmlSerializationReader?.Dispose();
		}
	}

	internal void InvokeWriter(XmlMapping mapping, XmlWriter xmlWriter, object o, XmlSerializerNamespaces namespaces, string encodingStyle, string id)
	{
		XmlSerializationWriter xmlSerializationWriter = null;
		try
		{
			encodingStyle = ValidateEncodingStyle(encodingStyle, mapping.Key);
			xmlSerializationWriter = Contract.Writer;
			xmlSerializationWriter.Init(xmlWriter, namespaces, encodingStyle, id, this);
			if (methods[mapping.Key].writeMethod == null)
			{
				if (writerMethods == null)
				{
					writerMethods = Contract.WriteMethods;
				}
				string text = (string)writerMethods[mapping.Key];
				if (text == null)
				{
					throw new InvalidOperationException(Res.GetString("XmlNotSerializable", mapping.Accessor.Name));
				}
				methods[mapping.Key].writeMethod = GetMethodFromType(xmlSerializationWriter.GetType(), text, pregeneratedAssmbly ? assembly : null);
			}
			methods[mapping.Key].writeMethod.Invoke(xmlSerializationWriter, new object[1] { o });
		}
		catch (SecurityException innerException)
		{
			throw new InvalidOperationException(Res.GetString("XmlNoPartialTrust"), innerException);
		}
		finally
		{
			xmlSerializationWriter?.Dispose();
		}
	}

	internal Assembly GetReferencedAssembly(string name)
	{
		if (assemblies == null || name == null)
		{
			return null;
		}
		return (Assembly)assemblies[name];
	}
}
