// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Transformations.IPropertiesContainer
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using System.Collections.Generic;

namespace EleWise.ELMA.Model.Transformations
{
  public interface IPropertiesContainer
  {
    IEnumerable<string> GetProperties();

    object GetPropertyValue(string propertyName, object[] index);

    void SetPropertyValue(string propertyName, object[] index, object value);

    void RemoveProperty(string propertyName);

    bool IsEmpty();
  }
}
