// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.PropertyHandlers.CalculateScriptChangePropertyIgnoreProvider
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;
using NHibernate.Engine;
using NHibernate.Event;
using NHibernate.Persister.Entity;
using System;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.PropertyHandlers
{
  /// <summary>
  /// Игнорировать изменение, если все изменённые поля автовычисляемы
  /// </summary>
  [Component]
  public class CalculateScriptChangePropertyIgnoreProvider : IChangePropertyHandlerIgnoreProvider
  {
    internal static CalculateScriptChangePropertyIgnoreProvider JqA4WqWsVOoSo43xF4dA;

    /// <inheritdoc />
    public bool CheckType(Guid typeUid) => MetadataLoader.LoadMetadata(typeUid) is IEntity;

    /// <inheritdoc />
    bool IChangePropertyHandlerIgnoreProvider.Ignore(PreUpdateEvent @event)
    {
      int num1 = 12;
      while (true)
      {
        int num2 = num1;
        PropertyMetadata propertyMetadata;
        int[] numArray1;
        int[] numArray2;
        int index1;
        int index2;
        EntityMetadata entityMetadata;
        string propertyName;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_18;
            case 2:
              if (propertyMetadata != null)
              {
                num2 = 14;
                continue;
              }
              goto label_21;
            case 3:
              goto label_19;
            case 4:
              if (entityMetadata != null)
              {
                num2 = 6;
                continue;
              }
              goto label_19;
            case 5:
              index2 = numArray2[index1];
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 0 : 0;
              continue;
            case 6:
              numArray2 = numArray1;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 0 : 1;
              continue;
            case 7:
              goto label_7;
            case 8:
            case 13:
              if (index1 >= numArray2.Length)
              {
                num2 = 7;
                continue;
              }
              goto case 5;
            case 9:
              entityMetadata = MetadataLoader.LoadMetadata(CalculateScriptChangePropertyIgnoreProvider.qjd235WsK3JIYW1iQSco((object) @event).GetType()) as EntityMetadata;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 4 : 4;
              continue;
            case 10:
              if (numArray1.Length != 0)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 1 : 9;
                continue;
              }
              goto label_16;
            case 11:
              if (numArray1 == null)
              {
                num2 = 20;
                continue;
              }
              goto case 10;
            case 12:
              goto label_8;
            case 14:
              if (!CalculateScriptChangePropertyIgnoreProvider.mt0duKWsnQX16sofuuYr(CalculateScriptChangePropertyIgnoreProvider.NOItk7WskmeKVq4mBhrp((object) propertyMetadata)))
              {
                num2 = 16;
                continue;
              }
              goto label_21;
            case 15:
            case 20:
              goto label_16;
            case 16:
              ++index1;
              num2 = 13;
              continue;
            case 17:
              // ISSUE: reference to a compiler-generated method
              propertyMetadata = entityMetadata.Properties.FirstOrDefault<PropertyMetadata>((Func<PropertyMetadata, bool>) (a => CalculateScriptChangePropertyIgnoreProvider.\u003C\u003Ec__DisplayClass1_0.iAWb2tCWVAMiRTnQ3GET((object) a.Name, (object) propertyName)));
              num2 = 2;
              continue;
            case 18:
              propertyName = @event.Persister.PropertyNames[index2];
              num2 = 17;
              continue;
            case 19:
              goto label_21;
            default:
              num2 = 18;
              continue;
          }
        }
label_8:
        numArray1 = (int[]) CalculateScriptChangePropertyIgnoreProvider.YgCw77WsTjVLFxnbTGMg(CalculateScriptChangePropertyIgnoreProvider.iR5IoIWsRKWxV9ZNFWwL((object) @event), (object) @event.State, CalculateScriptChangePropertyIgnoreProvider.vVLb7VWsqiGt3j4HMedv((object) @event), CalculateScriptChangePropertyIgnoreProvider.qjd235WsK3JIYW1iQSco((object) @event), CalculateScriptChangePropertyIgnoreProvider.IKtMwaWsXv0U4tS42D66((object) @event));
        num1 = 11;
        continue;
label_18:
        index1 = 0;
        num1 = 8;
      }
label_7:
      return true;
label_16:
      return false;
label_19:
      return false;
label_21:
      return false;
    }

    public CalculateScriptChangePropertyIgnoreProvider()
    {
      CalculateScriptChangePropertyIgnoreProvider.YiDp2QWsODAKomslYtXK();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool DpWnKiWsSYlwK45U4h7O() => CalculateScriptChangePropertyIgnoreProvider.JqA4WqWsVOoSo43xF4dA == null;

    internal static CalculateScriptChangePropertyIgnoreProvider B47f1rWsiA3D9NI8wPS8() => CalculateScriptChangePropertyIgnoreProvider.JqA4WqWsVOoSo43xF4dA;

    internal static object iR5IoIWsRKWxV9ZNFWwL([In] object obj0) => (object) ((AbstractPreDatabaseOperationEvent) obj0).Persister;

    internal static object vVLb7VWsqiGt3j4HMedv([In] object obj0) => (object) ((PreUpdateEvent) obj0).OldState;

    internal static object qjd235WsK3JIYW1iQSco([In] object obj0) => ((AbstractPreDatabaseOperationEvent) obj0).Entity;

    internal static object IKtMwaWsXv0U4tS42D66([In] object obj0) => (object) ((AbstractEvent) obj0).Session;

    internal static object YgCw77WsTjVLFxnbTGMg(
      [In] object obj0,
      [In] object obj1,
      [In] object obj2,
      [In] object obj3,
      [In] object obj4)
    {
      return (object) ((IEntityPersister) obj0).FindDirty((object[]) obj1, (object[]) obj2, obj3, (ISessionImplementor) obj4);
    }

    internal static object NOItk7WskmeKVq4mBhrp([In] object obj0) => (object) ((PropertyMetadata) obj0).CalculateScript;

    internal static bool mt0duKWsnQX16sofuuYr([In] object obj0) => string.IsNullOrWhiteSpace((string) obj0);

    internal static void YiDp2QWsODAKomslYtXK() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
