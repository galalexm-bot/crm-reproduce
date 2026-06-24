// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.NH.CustomTypes.TypeSettingsInstanceDataNHType
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using System;
using System.IO;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Runtime.NH.CustomTypes
{
  [Serializable]
  public class TypeSettingsInstanceDataNHType : XmlSerializableType<TypeSettingsInstanceData>
  {
    private static TypeSettingsInstanceDataNHType V03gKtWmxWSfMl1nsZeI;

    public override bool Equals(object x, object y)
    {
      int num1 = 4;
      TypeSettingsInstanceData settingsInstanceData1;
      MemoryStream memoryStream1;
      while (true)
      {
        int num2 = num1;
        TypeSettingsInstanceData settingsInstanceData2;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_21;
            case 2:
              goto label_30;
            case 3:
              settingsInstanceData1 = y as TypeSettingsInstanceData;
              num2 = 10;
              continue;
            case 4:
              settingsInstanceData2 = x as TypeSettingsInstanceData;
              num2 = 3;
              continue;
            case 5:
              goto label_28;
            case 6:
              goto label_24;
            case 7:
              goto label_29;
            case 8:
              if (settingsInstanceData2 != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 1 : 0;
                continue;
              }
              goto label_28;
            case 9:
              goto label_3;
            case 10:
              if (settingsInstanceData2 != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 0 : 8;
                continue;
              }
              goto default;
            default:
              if (settingsInstanceData1 == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0 ? 1 : 2;
                continue;
              }
              goto case 8;
          }
        }
label_21:
        if (settingsInstanceData1 != null)
        {
          num1 = 7;
          continue;
        }
        goto label_28;
label_29:
        memoryStream1 = ClassSerializationHelper.SerializeObjectByXmlToMemoryStream((object) settingsInstanceData2);
        num1 = 9;
      }
label_3:
      bool flag;
      try
      {
        MemoryStream memoryStream2 = ClassSerializationHelper.SerializeObjectByXmlToMemoryStream((object) settingsInstanceData1);
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
          num3 = 0;
        switch (num3)
        {
          default:
            try
            {
              flag = TypeSettingsInstanceDataNHType.peflu7WmyjKlPYe3eYIK((object) memoryStream1, (object) memoryStream2);
              int num4 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
                num4 = 0;
              switch (num4)
              {
              }
            }
            finally
            {
              int num5;
              if (memoryStream2 == null)
                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 0 : 0;
              else
                goto label_13;
label_12:
              switch (num5)
              {
                case 2:
                  break;
                default:
              }
label_13:
              memoryStream2.Dispose();
              num5 = 1;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0)
              {
                num5 = 0;
                goto label_12;
              }
              else
                goto label_12;
            }
            break;
        }
      }
      finally
      {
        int num6;
        if (memoryStream1 == null)
          num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 1 : 1;
        else
          goto label_19;
label_18:
        switch (num6)
        {
          case 1:
          case 2:
        }
label_19:
        TypeSettingsInstanceDataNHType.fWrWpnWmMaj21Vc2EaHN((object) memoryStream1);
        num6 = 2;
        goto label_18;
      }
label_24:
      return flag;
label_28:
      return false;
label_30:
      return true;
    }

    /// <summary>
    /// Return a deep copy of the persistent state, stopping at entities and at collections.
    /// </summary>
    /// <param name="value">generally a collection element or entity field</param>
    /// <returns>a copy</returns>
    public override object DeepCopy(object value) => (object) ClassSerializationHelper.CloneObjectByXml<TypeSettingsInstanceData>((TypeSettingsInstanceData) value);

    /// <summary>
    /// During merge, replace the existing (<paramref name="target" />) value in the entity
    ///             we are merging to with a new (<paramref name="original" />) value from the detached
    ///             entity we are merging. For immutable objects, or null values, it is safe to simply
    ///             return the first parameter. For mutable objects, it is safe to return a copy of the
    ///             first parameter. For objects with component values, it might make sense to
    ///             recursively replace component values.
    /// </summary>
    /// <param name="original">the value from the detached entity being merged</param>
    /// <param name="target">the value in the managed entity</param>
    /// <param name="owner">the managed entity</param>
    /// <returns>the value to be merged</returns>
    public override object Replace(object original, object target, object owner) => (object) ClassSerializationHelper.CloneObjectByXml<TypeSettingsInstanceData>((TypeSettingsInstanceData) original);

    /// <summary>
    /// Reconstruct an object from the cacheable representation. At the very least this
    ///             method should perform a deep copy if the type is mutable. (optional operation)
    /// </summary>
    /// <param name="cached">the object to be cached</param>
    /// <param name="owner">the owner of the cached object</param>
    /// <returns>
    /// a reconstructed object from the cachable representation
    /// </returns>
    public override object Assemble(object cached, object owner) => cached;

    /// <summary>
    /// Transform the object into its cacheable representation. At the very least this
    ///             method should perform a deep copy if the type is mutable. That may not be enough
    ///             for some implementations, however; for example, associations must be cached as
    ///             identifier values. (optional operation)
    /// </summary>
    /// <param name="value">the object to be cached</param>
    /// <returns>a cacheable representation of the object</returns>
    public override object Disassemble(object value) => value;

    /// <summary>Are objects of this type mutable?</summary>
    public override bool IsMutable => true;

    public TypeSettingsInstanceDataNHType()
    {
      TypeSettingsInstanceDataNHType.C9BWL1WmJljJM25vGPVv();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool peflu7WmyjKlPYe3eYIK([In] object obj0, [In] object obj1) => ((MemoryStream) obj0).Compare((MemoryStream) obj1);

    internal static void fWrWpnWmMaj21Vc2EaHN([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static bool dAX8M1Wm0kDJt7640DSf() => TypeSettingsInstanceDataNHType.V03gKtWmxWSfMl1nsZeI == null;

    internal static TypeSettingsInstanceDataNHType aQyNhvWmmgDIsYm6VJnk() => TypeSettingsInstanceDataNHType.V03gKtWmxWSfMl1nsZeI;

    internal static void C9BWL1WmJljJM25vGPVv() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    /// <summary>
    /// Convention for NHibernate custom type TypeSettingsNHType
    /// </summary>
    public class Convention : AutoRegisterUserTypeConvention<TypeSettingsInstanceDataNHType>
    {
      private static TypeSettingsInstanceDataNHType.Convention h1lpNRQYxbg20SYuTZQs;

      public Convention()
      {
        TypeSettingsInstanceDataNHType.Convention.XhcZmLQYyPqYkTx0rmSu();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0)
          num = 0;
        switch (num)
        {
        }
      }

      internal static void XhcZmLQYyPqYkTx0rmSu() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

      internal static bool iM9BBWQY0U8Umr6NQYcr() => TypeSettingsInstanceDataNHType.Convention.h1lpNRQYxbg20SYuTZQs == null;

      internal static TypeSettingsInstanceDataNHType.Convention X8VoSRQYmRMu7ITaRY4T() => TypeSettingsInstanceDataNHType.Convention.h1lpNRQYxbg20SYuTZQs;
    }
  }
}
