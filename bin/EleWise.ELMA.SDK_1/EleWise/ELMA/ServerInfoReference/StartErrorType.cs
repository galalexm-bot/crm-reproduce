// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ServerInfoReference.StartErrorType
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;

namespace EleWise.ELMA.ServerInfoReference
{
  /// <remarks />
  [GeneratedCode("System.Xml", "4.8.3761.0")]
  [XmlType(Namespace = "http://tempuri.org/")]
  [Serializable]
  public enum StartErrorType
  {
    /// <remarks />
    Fatal,
    /// <remarks />
    OlderVersion,
    /// <remarks />
    OtherConnections,
    /// <remarks />
    LastUpdateFault,
    /// <remarks />
    ConfigurationScriptsRecompileRequired,
  }
}
