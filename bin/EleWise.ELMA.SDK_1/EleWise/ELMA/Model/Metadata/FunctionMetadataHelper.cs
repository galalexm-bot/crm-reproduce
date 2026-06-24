// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.FunctionMetadataHelper
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using SG9KiyIbtdgGDf12qr;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Metadata
{
  /// <summary>Помощник для метаданных функций</summary>
  internal static class FunctionMetadataHelper
  {
    /// <summary>Prefix сборки для функций</summary>
    internal const string AssemblyPrefix = "__FunctionAssembly__";
    /// <summary>Имя модуля функций</summary>
    internal const string FunctionCode = "FunctionCode";
    /// <summary>Имя Executor-а</summary>
    internal const string Executor = "Executor";
    /// <summary>Имя метода</summary>
    internal const string MethodName = "Execute";
    private static FunctionMetadataHelper g9k2jpb14PfccHfFADaj;

    /// <summary>Полное имя типа Executor-а</summary>
    /// <param name="metadata">Метаданные функции</param>
    /// <returns>Полное имя типа Executor-а</returns>
    internal static string ExecutorTypeName(FunctionMetadata metadata) => metadata.Namespace + (string) FunctionMetadataHelper.jmQXcRb1AhoSZ2G38tja(-688192331 - 435440695 ^ -1123638598) + (string) FunctionMetadataHelper.Ww8F1Sb17LGFNTyessp4((object) metadata);

    /// <summary>Имя типа Executor-а</summary>
    /// <param name="metadata">Метаданные функции</param>
    /// <returns>Имя типа Executor-а</returns>
    internal static string ExecutorName(FunctionMetadata metadata) => (string) FunctionMetadataHelper.hxswXlb1xJs5qWCJJM3S((object) metadata) + (string) FunctionMetadataHelper.jmQXcRb1AhoSZ2G38tja(132912447 ^ 133099747);

    /// <summary>Имя серверной сборки</summary>
    /// <param name="metadata">Метаданные</param>
    /// <returns>Имя серверной сборки</returns>
    internal static string ServerAssemblyName(FunctionMetadata metadata) => (string) FunctionMetadataHelper.Wwjbbqb1mi25nyFR9HUZ((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(825385222 ^ 825263350), FunctionMetadataHelper.UgCZ0ab10CklsCMI0dA0((object) metadata), FunctionMetadataHelper.jmQXcRb1AhoSZ2G38tja(1669212571 ^ 1669215071), (object) metadata.Name);

    internal static object jmQXcRb1AhoSZ2G38tja(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object Ww8F1Sb17LGFNTyessp4([In] object obj0) => (object) FunctionMetadataHelper.ExecutorName((FunctionMetadata) obj0);

    internal static bool dAObZbb16C2xESQtdjxH() => FunctionMetadataHelper.g9k2jpb14PfccHfFADaj == null;

    internal static FunctionMetadataHelper onwJvbb1HngYlWXU7IDr() => FunctionMetadataHelper.g9k2jpb14PfccHfFADaj;

    internal static object hxswXlb1xJs5qWCJJM3S([In] object obj0) => (object) ((NamedMetadata) obj0).Name;

    internal static object UgCZ0ab10CklsCMI0dA0([In] object obj0) => (object) ((FunctionMetadata) obj0).Namespace;

    internal static object Wwjbbqb1mi25nyFR9HUZ(
      [In] object obj0,
      [In] object obj1,
      [In] object obj2,
      [In] object obj3)
    {
      return (object) ((string) obj0 + (string) obj1 + (string) obj2 + (string) obj3);
    }
  }
}
