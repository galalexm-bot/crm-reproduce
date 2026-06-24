// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Hubs.Attributes.HubMethodNameAttribute
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Hubs.Attributes
{
  /// <summary>
  /// Атрибут, позволяющий задавать произвольное имя для метода хаба
  /// </summary>
  /// <remarks>Метод ОБЯЗАТЕЛЬНО должен быть virtual</remarks>
  [AttributeUsage(AttributeTargets.Method, Inherited = false)]
  public sealed class HubMethodNameAttribute : Attribute
  {
    internal static HubMethodNameAttribute RsKA2Lh5ZYngF32vVyMY;

    public HubMethodNameAttribute(string methodName)
    {
      HubMethodNameAttribute.VHDvlmh5VC7ipGsa2yeh();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            this.MethodName = methodName;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 == 0 ? 0 : 1;
            continue;
          default:
            HubMethodNameAttribute.hwUFech5itglV34O684M((object) methodName, HubMethodNameAttribute.BmylgEh5SQW0vXLNrFBI(-1290212282 ^ -644262414 ^ 1786914032));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0 ? 1 : 2;
            continue;
        }
      }
label_3:;
    }

    public string MethodName { get; }

    internal static void VHDvlmh5VC7ipGsa2yeh() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object BmylgEh5SQW0vXLNrFBI(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void hwUFech5itglV34O684M([In] object obj0, [In] object obj1) => Contract.ArgumentNotNullOrEmpty((string) obj0, (string) obj1);

    internal static bool LOQkZ4h5uNeGIKKRYS6I() => HubMethodNameAttribute.RsKA2Lh5ZYngF32vVyMY == null;

    internal static HubMethodNameAttribute MZTmO4h5IurAHH7RQIyn() => HubMethodNameAttribute.RsKA2Lh5ZYngF32vVyMY;
  }
}
