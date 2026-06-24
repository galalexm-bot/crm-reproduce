// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Extensions.ClassMapExtensions
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Runtime.Db;
using NHibernate.Mapping.ByCode;

namespace EleWise.ELMA.Extensions
{
  public static class ClassMapExtensions
  {
    internal static ClassMapExtensions O9OtIDGxCuXABXBpUVFu;

    public static void SetGenerator(this IIdMapper mapping, string tableName, string idColumnName)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            goto label_3;
          case 2:
            IMapIdentityProvider currentThreadProvider = MapIdentityProvider.CurrentThreadProvider;
            if (currentThreadProvider == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 1 : 1;
              continue;
            }
            currentThreadProvider.SetGenerator(mapping, tableName, idColumnName);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 0 : 0;
            continue;
          default:
            goto label_7;
        }
      }
label_2:
      return;
label_3:
      return;
label_7:;
    }

    internal static bool ueutDiGxvS5nvNTd76db() => ClassMapExtensions.O9OtIDGxCuXABXBpUVFu == null;

    internal static ClassMapExtensions BrAvnfGx8h353E38tPen() => ClassMapExtensions.O9OtIDGxCuXABXBpUVFu;
  }
}
