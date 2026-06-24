using System.Reflection;

namespace EleWise.ELMA.WebCompiler;

public delegate Assembly AssemblyLoader(byte[] assemblyRaw, byte[] debugRaw);
