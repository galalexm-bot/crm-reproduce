// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Attributes.OwnerPropertyUidAttribute
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Attributes
{
  /// <summary>Указывает уникальный идентификатор свойства-владельца</summary>
  [AttributeUsage(AttributeTargets.Property)]
  public class OwnerPropertyUidAttribute : Attribute
  {
    private Guid value;
    internal static OwnerPropertyUidAttribute M4fJnNo8UCCgtGFew2tZ;

    /// <summary>Ctor</summary>
    /// <param name="value">Уникальный идентификатор свойства-владельца</param>
    public OwnerPropertyUidAttribute(string value)
    {
      OwnerPropertyUidAttribute.D9SVQPo8zrh7hBdHhGvK();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.value = !OwnerPropertyUidAttribute.IEJ5MYoZFhpI57DF5bPJ((object) value) ? new Guid(value) : Guid.Empty;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    /// <summary>Уникальный идентификатор свойства-владельца</summary>
    public Guid Value => this.value;

    internal static void D9SVQPo8zrh7hBdHhGvK() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool IEJ5MYoZFhpI57DF5bPJ([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static bool vb2kjio8svTUwIKc6KHZ() => OwnerPropertyUidAttribute.M4fJnNo8UCCgtGFew2tZ == null;

    internal static OwnerPropertyUidAttribute nnEc6Ko8cRAJc4Habysv() => OwnerPropertyUidAttribute.M4fJnNo8UCCgtGFew2tZ;
  }
}
