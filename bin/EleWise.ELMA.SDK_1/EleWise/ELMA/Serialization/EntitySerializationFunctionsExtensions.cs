// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Serialization.EntitySerializationFunctionsExtensions
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Serialization
{
  public static class EntitySerializationFunctionsExtensions
  {
    internal static EntitySerializationFunctionsExtensions Hvri1KBlsTRBNwCrYu9t;

    /// <summary>Скопировать с учетом настроек</summary>
    /// <param name="self"></param>
    /// <param name="newSettings">Новые настройки</param>
    /// <returns></returns>
    public static EntitySerializationFunctions Copy(
      this EntitySerializationFunctions self,
      object obj,
      ClassMetadata metadata,
      IPropertyMetadata propertyMetadata,
      EntitySerializationSettings oldSettings,
      EntitySerializationSettings newSettings)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (self.CopyForSettings == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 4 : 1;
              continue;
            }
            goto label_2;
          case 2:
            if (self != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0 ? 1 : 1;
              continue;
            }
            goto label_4;
          case 3:
            goto label_2;
          case 4:
            goto label_3;
          default:
            goto label_4;
        }
      }
label_2:
      return self.CopyForSettings(self, obj, metadata, propertyMetadata, oldSettings, newSettings);
label_3:
      return new EntitySerializationFunctions()
      {
        Filter = self.Filter,
        Serialize = self.Serialize,
        CopyForSettings = self.CopyForSettings
      };
label_4:
      return (EntitySerializationFunctions) null;
    }

    internal static bool uEfF6PBlcoO7h9TsV1cP() => EntitySerializationFunctionsExtensions.Hvri1KBlsTRBNwCrYu9t == null;

    internal static EntitySerializationFunctionsExtensions urD0WFBlzN3S7DZCcJ6V() => EntitySerializationFunctionsExtensions.Hvri1KBlsTRBNwCrYu9t;
  }
}
