using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.WebCompiler;

namespace EleWise.ELMA.Web.Mvc.Util;

public class WebCompilerCompiler : ICompiler
{
	private class AssemblyBuilder : EleWise.ELMA.Model.CodeGeneration.AssemblyBuilder
	{
		public IEnumerable<WebCompileDiagnostic> Diagnostics { get; private set; }

		protected override void ProcessErrors(IEnumerable<Diagnostic> diagnostics)
		{
			Diagnostics = diagnostics.Where((Diagnostic d) => d.Severity == DiagnosticSeverity.Error || d.Severity == DiagnosticSeverity.Warning).Select(ToWebCompileDiagnostic);
		}

		private static WebCompileDiagnostic ToWebCompileDiagnostic(Diagnostic diagnostic)
		{
			return new WebCompileDiagnostic
			{
				IsError = (diagnostic.Severity == DiagnosticSeverity.Error),
				Id = diagnostic.Id,
				Message = diagnostic.ToString(),
				Position = ((diagnostic.Location == null) ? null : new WebCompileDiagnosticPosition
				{
					FilePath = diagnostic.Location.FilePath,
					Character = diagnostic.Location.Character + 1,
					Line = diagnostic.Location.Line + 1
				})
			};
		}
	}

	public bool Compile(string assemblyName, IEnumerable<Tuple<string, string>> sourceCodes, IEnumerable<string> referencePaths, bool debug, out byte[] peRaw, out byte[] pdbRaw, out IEnumerable<WebCompileDiagnostic> diagnostics)
	{
		AssemblyBuilder builder = new AssemblyBuilder();
		try
		{
			builder.AssemblyName = assemblyName;
			sourceCodes.ForEach(delegate(Tuple<string, string> s)
			{
				builder.AddSourceCode(s.Item1);
			});
			referencePaths.ForEach(builder.AddReference);
			Assembly assembly = ComponentManager.FindLoadedAssembly("EleWise.ELMA.ConfigurationModel", isFullName: false);
			if (assembly != null)
			{
				builder.AddReference(ComponentManager.GetLoadedAssemblyRawAsStream(assembly));
			}
			assembly = ComponentManager.FindLoadedAssembly("EleWise.ELMA.DynamicModel", isFullName: false);
			if (assembly != null)
			{
				builder.AddReference(ComponentManager.GetLoadedAssemblyRawAsStream(assembly));
			}
			builder.Build(debug);
			peRaw = builder.AssemblyRaw;
			pdbRaw = builder.DebugRaw;
			diagnostics = builder.Diagnostics ?? Enumerable.Empty<WebCompileDiagnostic>();
			return peRaw != null;
		}
		finally
		{
			if (builder != null)
			{
				((IDisposable)builder).Dispose();
			}
		}
	}
}
