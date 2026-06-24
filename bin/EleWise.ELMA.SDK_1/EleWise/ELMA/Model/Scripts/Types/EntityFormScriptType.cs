// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Scripts.Types.EntityFormScriptType
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System.Collections.Generic;

namespace EleWise.ELMA.Model.Scripts.Types
{
  /// <summary>
  /// Базовый класс для типов сценариев динамических форм сущностей
  /// </summary>
  public abstract class EntityFormScriptType : ScriptTypeBase
  {
    internal static EntityFormScriptType sVRp7Abk1V5nMIZA4pes;

    public override ScriptMethodDeclaration GenerateMethod(
      string name,
      IDictionary<string, object> generationParams = null)
    {
      ScriptMethodDeclaration method = new ScriptMethodDeclaration()
      {
        Name = name
      };
      string type = this.GetEntityTypeName(generationParams);
      method.Parameters.Add(new ScriptMethodParameter(this.GetEntityParameterName(generationParams), type));
      if (this.GetParameterValue(generationParams, z2jc63fLkugS1X8Q9N.tE1kD1vbB(1514961705 ^ 1514976305)) is TablePartMetadata parameterValue)
      {
        type = parameterValue.TypeName;
        method.Parameters.Add(new ScriptMethodParameter(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-710283084 ^ -537863435 ^ 173638207), type));
      }
      method.Parameters.Add(new ScriptMethodParameter(z2jc63fLkugS1X8Q9N.tE1kD1vbB(132912447 ^ 132968153), string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1994213607 >> 4 ^ 124719820), (object) type)));
      return method;
    }

    protected virtual string GetEntityTypeName(IDictionary<string, object> generationParams) => !(this.GetParameterValue(generationParams, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-542721635 ^ -542738585)) is ClassMetadata parameterValue) ? z2jc63fLkugS1X8Q9N.tE1kD1vbB(-710283084 ^ -537863435 ^ 173633213) : parameterValue.TypeName;

    protected virtual string GetEntityParameterName(IDictionary<string, object> generationParams) => z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1088304168 ^ -1088329860);

    protected EntityFormScriptType()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool p3cdqkbkNPRBrw9KtYHT() => EntityFormScriptType.sVRp7Abk1V5nMIZA4pes == null;

    internal static EntityFormScriptType u45uihbk3BfdsnBtWjWH() => EntityFormScriptType.sVRp7Abk1V5nMIZA4pes;

    /// <summary>Имена параметров для генерации методов</summary>
    public static class Parameters
    {
      /// <summary>Имя параметра, хранящего метаданные сущности</summary>
      public const string ClassMetadata = "ClassMetadata";
      /// <summary>
      /// Имя параметра, хранящего метаданные блока (если форма задается для него)
      /// </summary>
      public const string TablePartMetadata = "TablePartMetadata";
    }
  }
}
