// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Attributes.PublicApiObsoleteInNodeAttribute
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Model.Attributes
{
  /// <summary>
  /// Атрибут для пометки дженериковых методов PublicAPI устаревшими
  /// </summary>
  [AttributeUsage(AttributeTargets.Method, Inherited = false, AllowMultiple = true)]
  public class PublicApiObsoleteInNodeAttribute : Attribute
  {
    private readonly string parentPath;
    private readonly string message;
    private readonly bool throwError;
    internal static PublicApiObsoleteInNodeAttribute LVUW1yoQhyqlfSN80cfd;

    public PublicApiObsoleteInNodeAttribute(string parentPath)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      this.\u002Ector(parentPath, (string) null);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0)
        num = 0;
      switch (num)
      {
      }
    }

    public PublicApiObsoleteInNodeAttribute(string parentPath, string message)
    {
      PublicApiObsoleteInNodeAttribute.YetIXloQfNs6m0In9dAo();
      // ISSUE: explicit constructor call
      this.\u002Ector(parentPath, message, false);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    public PublicApiObsoleteInNodeAttribute(string parentPath, string message, bool throwError)
    {
      PublicApiObsoleteInNodeAttribute.YetIXloQfNs6m0In9dAo();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.throwError = throwError;
            num = 2;
            continue;
          case 2:
            goto label_2;
          case 3:
            this.parentPath = parentPath;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 0 : 0;
            continue;
          default:
            this.message = message;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0 ? 1 : 1;
            continue;
        }
      }
label_2:;
    }

    public string Message => this.message;

    public bool ThrowError => this.throwError;

    public string ParentPath => this.parentPath;

    internal static bool Gm0sRKoQGL48Z0JrrcBu() => PublicApiObsoleteInNodeAttribute.LVUW1yoQhyqlfSN80cfd == null;

    internal static PublicApiObsoleteInNodeAttribute zFC7yRoQEPpxKryPD7pe() => PublicApiObsoleteInNodeAttribute.LVUW1yoQhyqlfSN80cfd;

    internal static void YetIXloQfNs6m0In9dAo() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
