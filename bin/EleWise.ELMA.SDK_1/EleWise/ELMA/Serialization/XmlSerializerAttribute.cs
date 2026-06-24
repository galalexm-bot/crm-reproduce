// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Serialization.XmlSerializerAttribute
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Serialization
{
  /// <summary>
  /// Атрибут указывает сериализатор для типа. Используется для оптимизации сериализации (т.к. генерация нового сериализатора занимает немало времени)
  /// </summary>
  public class XmlSerializerAttribute : Attribute
  {
    private string typeName;
    internal static XmlSerializerAttribute dlaI2UBrK2yTwSChgAi4;

    /// <summary>Ctor</summary>
    /// <param name="typeName">Имя типа сериализатора</param>
    public XmlSerializerAttribute(string typeName)
    {
      XmlSerializerAttribute.oeRjoiBrk1dfDEg8JvWb();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.typeName = typeName;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 1 : 1;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Тип сериализатора</summary>
    public Type SerializerType
    {
      get
      {
        Type type = XmlSerializerAttribute.CVG0kCBrnV7PTDdJp3Y2((object) this.typeName);
        return !XmlSerializerAttribute.jFnerjBrOfkwdyrvTgqo(type, (Type) null) ? type : throw new TypeLoadException(string.Format((string) XmlSerializerAttribute.pMXgnaBr2CCJwFMBmBC5(-688192331 - 435440695 ^ -1123561896), (object) this.typeName));
      }
    }

    internal static void oeRjoiBrk1dfDEg8JvWb() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool XEVO85BrXm9I4J3oMXNp() => XmlSerializerAttribute.dlaI2UBrK2yTwSChgAi4 == null;

    internal static XmlSerializerAttribute nQ1afnBrT6CqcEQQkrwC() => XmlSerializerAttribute.dlaI2UBrK2yTwSChgAi4;

    internal static Type CVG0kCBrnV7PTDdJp3Y2([In] object obj0) => Type.GetType((string) obj0);

    internal static bool jFnerjBrOfkwdyrvTgqo([In] Type obj0, [In] Type obj1) => obj0 == obj1;

    internal static object pMXgnaBr2CCJwFMBmBC5(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);
  }
}
