// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.DefaultProperties.DefaultProperty
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.DefaultProperties
{
  /// <summary>Базовый класс свойства по умолчанию</summary>
  [Component]
  public abstract class DefaultProperty : IDefaultProperty
  {
    private static DefaultProperty gbOM9lWjgQM7tDu6TY93;

    /// <summary>Имя свойства (для текущей культуры)</summary>
    public abstract string Name { get; }

    /// <summary>Guid свойства</summary>
    public virtual Guid Uid => DefaultProperty.pZhFlJWjL4Vcnyf0jKhd(DefaultProperty.tKhyjjWjYNxjgd5Pyete((object) this));

    /// <summary>
    /// Включена ли галочка использования данного свойства по умолчанию (по умолчанию False)
    /// </summary>
    public virtual bool DefaultChecked => false;

    /// <summary>Доступно ли свойство</summary>
    /// <param name="classMetadata">Метаданные класса</param>
    /// <param name="allProperties">Список всех свойств и блоков (включая унаследованные)</param>
    /// <returns>True, если доступно</returns>
    public virtual bool IsAvailableFor(ClassMetadata classMetadata, List<IMetadata> allProperties = null)
    {
      Contract.ArgumentNotNull((object) classMetadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2112703338 ^ -2112832910));
      List<PropertyMetadata> source1 = new List<PropertyMetadata>();
      List<TablePartMetadata> source2 = new List<TablePartMetadata>();
      if (allProperties != null)
      {
        foreach (IMetadata allProperty in allProperties)
        {
          PropertyMetadata propertyMetadata = allProperty as PropertyMetadata;
          TablePartMetadata tablePartMetadata = allProperty as TablePartMetadata;
          if (propertyMetadata != null)
            source1.Add(propertyMetadata);
          if (tablePartMetadata != null)
            source2.Add(tablePartMetadata);
        }
      }
      return source1.FirstOrDefault<PropertyMetadata>((Func<PropertyMetadata, bool>) (p => DefaultProperty.MPDk5NWYZB41Q5ZlCFUF(DefaultProperty.yAVqvWWY8d5VQI3vOZTe((object) p), DefaultProperty.bx2BuqWjceHsJV7hmRWJ((object) this)))) == null && source2.FirstOrDefault<TablePartMetadata>((Func<TablePartMetadata, bool>) (p => DefaultProperty.MPDk5NWYZB41Q5ZlCFUF((object) p.Name, DefaultProperty.bx2BuqWjceHsJV7hmRWJ((object) this)))) == null;
    }

    /// <summary>Инициализировать метаданные свойства</summary>
    /// <param name="classMetadata">Метаданные класса</param>
    /// <param name="propertyMetadata">Метаданные свойства</param>
    public virtual void InitProperty(ClassMetadata classMetadata, PropertyMetadata propertyMetadata)
    {
      int num = 6;
      EntityPropertyMetadata propertyMetadata1;
      while (true)
      {
        switch (num)
        {
          case 1:
          case 11:
            if (DefaultProperty.BxmOU6WYv1KidXlvVmyW(DefaultProperty.gI40mIWYCGf2ibmSBMtZ((object) this), Guid.Empty))
            {
              num = 10;
              continue;
            }
            goto label_2;
          case 2:
            goto label_9;
          case 3:
            DefaultProperty.waAXabWYQ2lkfLa8YQ7q((object) propertyMetadata1, DefaultProperty.sQAI3AWYfCeoJUF4bm0n((object) this));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 1 : 1;
            continue;
          case 4:
            DefaultProperty.NbAWBRWYF6dfVqAkX0xW((object) propertyMetadata, DefaultProperty.FMcBkeWjzZ73L5nRig9T((object) this));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 == 0 ? 7 : 12;
            continue;
          case 5:
            DefaultProperty.PpwHYFWjswwJ8gptyprY((object) propertyMetadata, DefaultProperty.GekawmWjUBuvNhBBVUwk(~289714581 ^ -289732808));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c == 0 ? 0 : 0;
            continue;
          case 6:
            Contract.ArgumentNotNull((object) classMetadata, (string) DefaultProperty.GekawmWjUBuvNhBBVUwk(-1317790512 ^ -1317662156));
            num = 5;
            continue;
          case 7:
            DefaultProperty.j4NxJkWYoOfSZyQjoWBR((object) propertyMetadata, DefaultProperty.yCkCsKWYWUIkH9sg3eo0((object) this));
            num = 9;
            continue;
          case 8:
            propertyMetadata1 = propertyMetadata as EntityPropertyMetadata;
            num = 14;
            continue;
          case 9:
            DefaultProperty.pYEIYlWYh4KCjx8VSStF((object) propertyMetadata, DefaultProperty.l5cocyWYbHQVGRbQsBNq((object) this));
            num = 13;
            continue;
          case 10:
            propertyMetadata.Handlers.Add(new PropertyHandlerInfo()
            {
              HandlerUid = DefaultProperty.gI40mIWYCGf2ibmSBMtZ((object) this)
            });
            num = 2;
            continue;
          case 12:
            DefaultProperty.pVKZ1LWYBLFyheyTKiQ9((object) propertyMetadata, (object) this.PropertyDescription);
            num = 7;
            continue;
          case 13:
            DefaultProperty.DUDkgcWYE2HG2u1YZ19M((object) propertyMetadata, DefaultProperty.fv7LuUWYGWCTedineGiD((object) this, (object) classMetadata, (object) propertyMetadata));
            num = 8;
            continue;
          case 14:
            if (propertyMetadata1 == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 11 : 4;
              continue;
            }
            goto case 3;
          default:
            propertyMetadata.Name = (string) DefaultProperty.bx2BuqWjceHsJV7hmRWJ((object) this);
            num = 4;
            continue;
        }
      }
label_9:
      return;
label_2:;
    }

    /// <summary>
    /// Определяет имя свойства, по которому определяется доступность свойства (в методе IsAvailableFor)
    /// </summary>
    protected abstract string PropertyName { get; }

    /// <summary>
    /// Определяет отображаемое имя свойства (по умолчанию равно значению свойства Name)
    /// </summary>
    protected virtual string PropertyDisplayName => this.Name;

    /// <summary>Описание свойства (по умолчанию пустое)</summary>
    protected virtual string PropertyDescription => string.Empty;

    /// <summary>UID типа данных</summary>
    protected abstract Guid TypeUid { get; }

    /// <summary>UID подтипа</summary>
    protected virtual Guid SubTypeUid => Guid.Empty;

    /// <summary>Обязательность заполнения (по умолчанию False)</summary>
    protected virtual bool Required => false;

    /// <summary>Доступно ли свойство для фильтра (по умолчанию False)</summary>
    protected virtual bool Filterable => false;

    /// <summary>UID обработчика (по умолчанию отсутствует)</summary>
    protected virtual Guid HandlerUid => Guid.Empty;

    /// <summary>Получить настройки типа данных</summary>
    /// <param name="classMetadata">Метаданные класса</param>
    /// <param name="propertyMetadata">Метаданные свойства</param>
    /// <returns>Настройки типа данных</returns>
    protected abstract TypeSettings GetTypeSettings(
      ClassMetadata classMetadata,
      PropertyMetadata propertyMetadata);

    protected DefaultProperty()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object tKhyjjWjYNxjgd5Pyete([In] object obj0) => (object) ((DefaultProperty) obj0).Name;

    internal static Guid pZhFlJWjL4Vcnyf0jKhd([In] object obj0) => ((string) obj0).GetDeterministicGuid();

    internal static bool mjfjrbWj5CvuIDkQ7RrS() => DefaultProperty.gbOM9lWjgQM7tDu6TY93 == null;

    internal static DefaultProperty L4ofJTWjjVXMKsojBm2j() => DefaultProperty.gbOM9lWjgQM7tDu6TY93;

    internal static object GekawmWjUBuvNhBBVUwk(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void PpwHYFWjswwJ8gptyprY([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static object bx2BuqWjceHsJV7hmRWJ([In] object obj0) => (object) ((DefaultProperty) obj0).PropertyName;

    internal static object FMcBkeWjzZ73L5nRig9T([In] object obj0) => (object) ((DefaultProperty) obj0).PropertyDisplayName;

    internal static void NbAWBRWYF6dfVqAkX0xW([In] object obj0, [In] object obj1) => ((NamedMetadata) obj0).DisplayName = (string) obj1;

    internal static void pVKZ1LWYBLFyheyTKiQ9([In] object obj0, [In] object obj1) => ((NamedMetadata) obj0).Description = (string) obj1;

    internal static Guid yCkCsKWYWUIkH9sg3eo0([In] object obj0) => ((DefaultProperty) obj0).TypeUid;

    internal static void j4NxJkWYoOfSZyQjoWBR([In] object obj0, Guid value) => ((PropertyMetadata) obj0).TypeUid = value;

    internal static Guid l5cocyWYbHQVGRbQsBNq([In] object obj0) => ((DefaultProperty) obj0).SubTypeUid;

    internal static void pYEIYlWYh4KCjx8VSStF([In] object obj0, Guid value) => ((PropertyMetadata) obj0).SubTypeUid = value;

    internal static object fv7LuUWYGWCTedineGiD([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((DefaultProperty) obj0).GetTypeSettings((ClassMetadata) obj1, (PropertyMetadata) obj2);

    internal static void DUDkgcWYE2HG2u1YZ19M([In] object obj0, [In] object obj1) => ((PropertyMetadata) obj0).Settings = (TypeSettings) obj1;

    internal static bool sQAI3AWYfCeoJUF4bm0n([In] object obj0) => ((DefaultProperty) obj0).Filterable;

    internal static void waAXabWYQ2lkfLa8YQ7q([In] object obj0, bool value) => ((EntityPropertyMetadata) obj0).Filterable = value;

    internal static Guid gI40mIWYCGf2ibmSBMtZ([In] object obj0) => ((DefaultProperty) obj0).HandlerUid;

    internal static bool BxmOU6WYv1KidXlvVmyW([In] Guid obj0, [In] Guid obj1) => obj0 != obj1;

    internal static object yAVqvWWY8d5VQI3vOZTe([In] object obj0) => (object) ((NamedMetadata) obj0).Name;

    internal static bool MPDk5NWYZB41Q5ZlCFUF([In] object obj0, [In] object obj1) => (string) obj0 == (string) obj1;
  }
}
