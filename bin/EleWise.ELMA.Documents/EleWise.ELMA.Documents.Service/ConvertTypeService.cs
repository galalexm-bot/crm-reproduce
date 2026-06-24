using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using EleWise.ELMA.Common.Services;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Extensions;
using EleWise.ELMA.Documents.Managers;
using EleWise.ELMA.Documents.Models.ConvertType;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Model.Types.Convertors;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;

namespace EleWise.ELMA.Documents.Services;

[Service]
internal class ConvertTypeService : IConvertTypeService
{
	private class BlockMapping
	{
		public Guid TargetUid { get; set; }

		public Guid TargetTypeEntityUid { get; set; }

		public long SourceId { get; set; }

		public long TargetId { get; set; }
	}

	public IWatchEntityService WatchEntityService { get; set; }

	public ITransformationProvider Transform { get; set; }

	public FindReferenceService FindReference { get; set; }

	public IEnumerable<ITypeConvertor> TypeConvertors { get; set; }

	public IEnumerable<IConvertDocumentTypeUids> ConvertTypeUids { get; set; }

	public void Convert(IEntity entity, TypeMappingInfo mapping, Action<ConvertTypeProgressInfo> callback)
	{
		if (entity != null && mapping != null && mapping.TargetTypeInfo != null)
		{
			EntityMetadata sourceTypeMd = (EntityMetadata)MetadataLoader.LoadMetadata(entity.CastAsRealType().GetType());
			EntityMetadata entityMetadata = (EntityMetadata)MetadataLoader.LoadMetadata(mapping.TargetTypeInfo.Uid);
			ConvertTypeEntitiesInfo entitiesInfo = GetEntitiesInfo(sourceTypeMd, entityMetadata);
			callback?.Invoke(new ConvertTypeProgressInfo
			{
				Description = SR.T("Обновление данных.."),
				Percent = 1,
				Status = ConvertTypeStatus.UpdateData.ToString()
			});
			Dictionary<string, List<long>> recordsToDelete = UpdateAndInsert(entity, entitiesInfo, mapping);
			callback?.Invoke(new ConvertTypeProgressInfo
			{
				Description = SR.T("Обработка ссылок.."),
				Percent = 20,
				Status = ConvertTypeStatus.UpdateRefs.ToString()
			});
			UpdateReferences(entity, entitiesInfo, recordsToDelete);
			callback?.Invoke(new ConvertTypeProgressInfo
			{
				Description = SR.T("Обработка ссылок.."),
				Percent = 40,
				Status = ConvertTypeStatus.DeleteData.ToString()
			});
			Delete(entity, entitiesInfo, recordsToDelete);
			callback?.Invoke(new ConvertTypeProgressInfo
			{
				Description = SR.T("Обновление истории.."),
				Percent = 60,
				Status = ConvertTypeStatus.UpdateHistory.ToString()
			});
			UpdateHistory(entity, entitiesInfo);
			callback?.Invoke(new ConvertTypeProgressInfo
			{
				Description = SR.T("Обновление наблюдателей.."),
				Percent = 80,
				Status = ConvertTypeStatus.UpdateHistory.ToString()
			});
			UpdateWatches(entity, entityMetadata.Uid);
		}
	}

	private ConvertTypeEntitiesInfo GetEntitiesInfo(EntityMetadata sourceTypeMd, EntityMetadata targetTypeMd)
	{
		List<EntityMetadata> list = MetadataLoader.GetBaseClasses(sourceTypeMd).OfType<EntityMetadata>().ToList();
		list.Insert(0, sourceTypeMd);
		List<EntityMetadata> sourceBlocks = new List<EntityMetadata>();
		list.ForEach(delegate(EntityMetadata a)
		{
			EntityMetadata rootEntity2 = (EntityMetadata)MetadataLoader.LoadMetadata(a.Uid, inherit: false);
			sourceBlocks.AddRange(DocumentManager.Instance.GetChildBlocks(rootEntity2));
		});
		List<EntityMetadata> list2 = new List<EntityMetadata>(list);
		list2.AddRange(sourceBlocks);
		List<EntityMetadata> list3 = MetadataLoader.GetBaseClasses(targetTypeMd).OfType<EntityMetadata>().ToList();
		list3.Insert(0, targetTypeMd);
		List<EntityMetadata> targetBlocks = new List<EntityMetadata>();
		list3.ForEach(delegate(EntityMetadata a)
		{
			EntityMetadata rootEntity = (EntityMetadata)MetadataLoader.LoadMetadata(a.Uid, inherit: false);
			targetBlocks.AddRange(DocumentManager.Instance.GetChildBlocks(rootEntity));
		});
		new List<EntityMetadata>(list3).AddRange(targetBlocks);
		new List<EntityMetadata>();
		List<EntityMetadata> list4 = new List<EntityMetadata>();
		List<EntityMetadata> list5 = new List<EntityMetadata>();
		List<EntityMetadata> list6 = new List<EntityMetadata>();
		List<EntityMetadata> list7 = new List<EntityMetadata>();
		List<EntityMetadata> list8 = new List<EntityMetadata>();
		List<EntityMetadata> list9 = list.Intersect(list3).ToList();
		List<EntityMetadata> second = sourceBlocks.Intersect(targetBlocks).ToList();
		List<EntityMetadata> intersectEntities = list9.Concat(second).ToList();
		List<EntityMetadata> first = list3.Except(list9).ToList();
		list4 = list.Except(list9).ToList();
		list5 = targetBlocks.Except(second).ToList();
		list6 = sourceBlocks.Except(second).ToList();
		list7 = first.Concat(list5).ToList();
		list8 = list4.Concat(list6).ToList();
		return new ConvertTypeEntitiesInfo
		{
			EntitiesToInsert = list7,
			EntitiesToDelete = list8,
			IntersectEntities = intersectEntities,
			SourceEntities = list2,
			SourceBlocks = sourceBlocks,
			BlocksToInsert = list5,
			BlocksToDelete = list6,
			ClassesToDelete = list4,
			SourceTypeMd = sourceTypeMd,
			TargetTypeMd = targetTypeMd
		};
	}

	private Dictionary<string, List<long>> UpdateAndInsert(IEntity sourceEntity, ConvertTypeEntitiesInfo entitiesInfo, TypeMappingInfo mappingInfo)
	{
		long? num = sourceEntity.GetId() as long?;
		if (!num.HasValue)
		{
			throw new Exception(SR.T("Не удалось найти id типа для конвертируемой сущноcти {0}", sourceEntity));
		}
		Dictionary<string, List<long>> dictionary = new Dictionary<string, List<long>>();
		if (entitiesInfo == null || mappingInfo == null || !num.HasValue)
		{
			return dictionary;
		}
		List<EntityMetadata> intersectEntities = entitiesInfo.IntersectEntities;
		List<EntityMetadata> entitiesToInsert = entitiesInfo.EntitiesToInsert;
		List<EntityMetadata> sourceEntities = entitiesInfo.SourceEntities;
		List<EntityMetadata> sourceBlocks = entitiesInfo.SourceBlocks;
		List<EntityMetadata> blocksToInsert = entitiesInfo.BlocksToInsert;
		EntityMetadata sourceTypeMd = entitiesInfo.SourceTypeMd;
		EntityMetadata targetTypeMd = entitiesInfo.TargetTypeMd;
		List<ToManyUpdateOperation> list = new List<ToManyUpdateOperation>();
		List<ToManyUpdateOperation> list2 = new List<ToManyUpdateOperation>();
		List<ToManyDeleteOperation> list3 = new List<ToManyDeleteOperation>();
		List<ToManyInsertOperation> list4 = new List<ToManyInsertOperation>();
		IEnumerable<ITypeConvertor> typeConvertors = TypeConvertors;
		List<Guid> list5 = ConvertTypeUids.Select((IConvertDocumentTypeUids m) => m.GetTypesDescriptor()).ToList();
		Dictionary<string, List<long>> dictionary2 = new Dictionary<string, List<long>>();
		List<BlockMapping> list6 = new List<BlockMapping>();
		EntityMetadata rootEntity = (EntityMetadata)MetadataLoader.LoadMetadata(sourceEntity.GetType(), inherit: false);
		foreach (EntityMetadata ent in intersectEntities.Concat(entitiesToInsert))
		{
			EntityMetadata currTypeEntity = (EntityMetadata)MetadataLoader.LoadMetadata(ent.Uid, inherit: false);
			string tableName = currTypeEntity.TableName;
			Dictionary<long, long?> currentSourceIds;
			if (currTypeEntity is TablePartMetadata)
			{
				PropertyMappingInfo currentSourceEntityMap = mappingInfo.PropertyMappings.FirstOrDefault((PropertyMappingInfo x) => x.NewPropertyInfo.Uid == ent.Uid);
				if (currentSourceEntityMap == null || !currentSourceEntityMap.EnableConvert || currentSourceEntityMap.OldPropertyInfo.Uid == Guid.Empty)
				{
					continue;
				}
				EntityMetadata entityMetadata = sourceEntities.First((EntityMetadata x) => x.Uid == currentSourceEntityMap.OldPropertyInfo.Uid);
				currentSourceIds = GetPropertyValuesFromEntity(num.Value, rootEntity, sourceEntities, entityMetadata, entityMetadata.Properties.First((PropertyMetadata x) => x.Name == "Parent")).ToDictionary((KeyValuePair<long, object> x) => x.Key, (KeyValuePair<long, object> v) => (long?)v.Value);
				if (currentSourceIds.Count == 0)
				{
					continue;
				}
			}
			else
			{
				currentSourceIds = new Dictionary<long, long?>();
				currentSourceIds.Add(num.Value, null);
			}
			Dictionary<string, List<Guid>> dictionary3 = new Dictionary<string, List<Guid>>();
			IEnumerable<PropertyMetadata> enumerable;
			if (!(currTypeEntity is TablePartMetadata))
			{
				IEnumerable<PropertyMetadata> properties = currTypeEntity.Properties;
				enumerable = properties;
			}
			else
			{
				enumerable = currTypeEntity.Properties.Where((PropertyMetadata w) => w.Name != "Parent" && w.Name != "Uid");
			}
			foreach (EntityPropertyMetadata currPropertyMetadata in enumerable)
			{
				PropertyMappingInfo propertyMappingInfo = mappingInfo.PropertyMappings.FirstOrDefault((PropertyMappingInfo m) => m.NewPropertyInfo.Uid == currPropertyMetadata.Uid);
				if (propertyMappingInfo.NewPropertyInfo.Uid != propertyMappingInfo.OldPropertyInfo.Uid)
				{
					string tableName2 = EntityPropertyMetadata.GetTableName(tableName, currPropertyMetadata.TableNumber);
					if (!dictionary3.ContainsKey(tableName2))
					{
						dictionary3.Add(tableName2, new List<Guid>());
						dictionary.Add(tableName2, new List<long>());
						dictionary2.Add(tableName2, new List<long>());
					}
					dictionary3[tableName2].Add(currPropertyMetadata.Uid);
				}
			}
			if (entitiesToInsert.Contains(ent) && dictionary3.Count == 0)
			{
				dictionary3.Add(tableName, new List<Guid>());
			}
			foreach (KeyValuePair<string, List<Guid>> item2 in dictionary3)
			{
				List<string> list7 = new List<string>(item2.Value.Count);
				List<PropertyMetadata> list8 = new List<PropertyMetadata>(item2.Value.Count);
				List<object> list9 = new List<object>(item2.Value.Count);
				List<List<object>> list10 = new List<List<object>>(item2.Value.Count);
				List<object> values = ((IEnumerable<KeyValuePair<long, long?>>)currentSourceIds).Select((Func<KeyValuePair<long, long?>, object>)((KeyValuePair<long, long?> x) => x.Key)).ToList();
				string fkFieldName = string.Empty;
				EntityMetadata parentBlockEntity = null;
				Dictionary<long, object> dictionary4 = null;
				List<Guid> list11 = new List<Guid>();
				if (currTypeEntity is TablePartMetadata)
				{
					parentBlockEntity = GetParentEntity(sourceEntities.Concat(entitiesToInsert).ToList(), currTypeEntity, out fkFieldName, isTablePart: true);
					dictionary4 = GetPropertyValuesFromEntity(num.Value, entitiesToInsert.Contains(ent) ? targetTypeMd : sourceTypeMd, sourceBlocks.Concat(blocksToInsert).ToList(), parentBlockEntity);
					foreach (KeyValuePair<long, long?> currentSourceId in currentSourceIds)
					{
						BlockMapping blockMapping = list6.FirstOrDefault((BlockMapping x) => x.SourceId == currentSourceId.Value && x.TargetTypeEntityUid == parentBlockEntity.Uid);
						List<object> list12 = new List<object>();
						List<string> list13 = new List<string>();
						list13.Add("Parent");
						list12.Add((blockMapping != null) ? new long?(blockMapping.TargetId) : num);
						Guid guid = Guid.NewGuid();
						list11.Add(guid);
						list13.Add("Uid");
						list12.Add(guid);
						Transform.Insert(Transform.Dialect.QuoteIfNeeded(item2.Key), list13.ToArray(), list12.ToArray(), isNeedInsertId: true);
						list6.Add(new BlockMapping
						{
							TargetUid = guid,
							SourceId = currentSourceId.Key,
							TargetTypeEntityUid = currTypeEntity.Uid
						});
					}
					if (list11.Count > 0)
					{
						Dictionary<string, object> parameters;
						string sql = CreateSelectQueryString("Id", "Uid", item2.Key, ((IEnumerable<Guid>)list11).Select((Func<Guid, object>)((Guid x) => x)).ToList(), out parameters);
						using IDataReader dataReader = Transform.ExecuteQuery(sql, parameters);
						while (dataReader.Read())
						{
							long @int = dataReader.GetInt64(dataReader.GetOrdinal("Id"));
							Guid targetUid = Transform.Dialect.GetGuid(dataReader[dataReader.GetOrdinal("Uid")]);
							dictionary2[item2.Key].Add(@int);
							BlockMapping blockMapping2 = list6.FirstOrDefault((BlockMapping x) => x.TargetUid == targetUid);
							if (blockMapping2 != null)
							{
								blockMapping2.TargetId = @int;
							}
						}
					}
				}
				foreach (Guid propUid in item2.Value)
				{
					PropertyMetadata targetPropMetadata = currTypeEntity.Properties.FirstOrDefault((PropertyMetadata m) => m.Uid == propUid);
					EntitySettings targetPropSetts = targetPropMetadata.Settings as EntitySettings;
					PropertyMappingInfo currPropMap = mappingInfo.PropertyMappings.FirstOrDefault((PropertyMappingInfo m) => m.NewPropertyInfo.Uid == propUid && m.EnableConvert);
					if (targetPropSetts != null && targetPropSetts.RelationType == RelationType.OneToMany)
					{
						EntityMetadata entityMetadata2 = (EntityMetadata)MetadataLoader.LoadMetadata(targetPropMetadata.SubTypeUid, inherit: false);
						PropertyMetadata propertyMetadata = entityMetadata2.Properties.FirstOrDefault((PropertyMetadata m) => m.Uid == targetPropSetts.KeyColumnUid);
						string name = propertyMetadata.Name;
						string tableName3 = entityMetadata2.TableName;
						string tableName4 = EntityPropertyMetadata.GetTableName(tableName3, ((EntityPropertyMetadata)propertyMetadata).TableNumber);
						bool flag = false;
						if (currPropMap != null && currPropMap.OldPropertyInfo.Uid != Guid.Empty)
						{
							PropertyMetadata propertyMetadataFromEntities = GetPropertyMetadataFromEntities(sourceEntities, currPropMap.OldPropertyInfo.Uid);
							EntitySettings sourcePropSetts2 = (EntitySettings)propertyMetadataFromEntities.Settings;
							bool flag2 = !mappingInfo.PropertyMappings.Any((PropertyMappingInfo m) => m.NewPropertyInfo.Uid == currPropMap.OldPropertyInfo.Uid && m.EnableConvert);
							if (sourcePropSetts2.RelationType == RelationType.OneToMany)
							{
								PropertyMetadata propertyMetadata2 = entityMetadata2.Properties.FirstOrDefault((PropertyMetadata m) => m.Uid == sourcePropSetts2.KeyColumnUid);
								string name2 = propertyMetadata2.Name;
								string tableName5 = EntityPropertyMetadata.GetTableName(tableName3, ((EntityPropertyMetadata)propertyMetadata2).TableNumber);
								if (tableName5 != tableName4 || name2 != name)
								{
									Dictionary<string, object> parameters2;
									string sql2 = CreateSelectQueryString("Id", name2, tableName5, values, out parameters2);
									using IDataReader dataReader2 = Transform.ExecuteQuery(sql2, parameters2);
									int num2 = 0;
									while (dataReader2.Read())
									{
										num2++;
										long int2 = dataReader2.GetInt64(dataReader2.GetOrdinal("Id"));
										long int3 = dataReader2.GetInt64(dataReader2.GetOrdinal(name2));
										if (flag2)
										{
											list.Add(new ToManyUpdateOperation
											{
												TableName = tableName5,
												WhereFieldName = "Id",
												WhereId = int2,
												Columns = new string[1] { name2 },
												Values = new object[1]
											});
										}
										list2.Add(new ToManyUpdateOperation
										{
											TableName = tableName4,
											WhereFieldName = "Id",
											WhereId = int2,
											Columns = new string[1] { name },
											Values = new object[1] { int3 }
										});
									}
									if (num2 == 0)
									{
										flag = true;
									}
								}
							}
							else if (sourcePropSetts2.RelationType == RelationType.ManyToMany || sourcePropSetts2.RelationType == RelationType.ManyToManyInverse)
							{
								string text = ((sourcePropSetts2.RelationType == RelationType.ManyToMany) ? sourcePropSetts2.ParentColumnName : sourcePropSetts2.ChildColumnName);
								string text2 = ((sourcePropSetts2.RelationType == RelationType.ManyToMany) ? sourcePropSetts2.ChildColumnName : sourcePropSetts2.ParentColumnName);
								string relationTableName = sourcePropSetts2.RelationTableName;
								Dictionary<string, object> parameters3;
								string sql3 = CreateSelectQueryString(text2, text, relationTableName, values, out parameters3);
								using IDataReader dataReader3 = Transform.ExecuteQuery(sql3, parameters3);
								int num3 = 0;
								while (dataReader3.Read())
								{
									long int4 = dataReader3.GetInt64(dataReader3.GetOrdinal(text2));
									long int5 = dataReader3.GetInt64(dataReader3.GetOrdinal(text));
									if (flag2)
									{
										list3.Add(new ToManyDeleteOperation
										{
											TableName = relationTableName,
											WhereField1Name = text,
											Where1Id = int5,
											WhereField2Name = text2,
											Where2Id = int4
										});
									}
									list2.Add(new ToManyUpdateOperation
									{
										TableName = tableName4,
										WhereFieldName = "Id",
										WhereId = int4,
										Columns = new string[1] { name },
										Values = new object[1] { int5 }
									});
								}
								if (num3 == 0)
								{
									flag = true;
								}
							}
						}
						else
						{
							flag = true;
						}
						if (!flag)
						{
							continue;
						}
						Dictionary<string, object> parameters4;
						string sql4 = CreateSelectQueryString("Id", name, tableName4, values, out parameters4);
						using IDataReader dataReader4 = Transform.ExecuteQuery(sql4, parameters4);
						while (dataReader4.Read())
						{
							long int6 = dataReader4.GetInt64(dataReader4.GetOrdinal("Id"));
							list.Add(new ToManyUpdateOperation
							{
								TableName = tableName4,
								WhereFieldName = "Id",
								WhereId = int6,
								Columns = new string[1] { name },
								Values = new object[1]
							});
						}
					}
					else if (targetPropSetts != null && (targetPropSetts.RelationType == RelationType.ManyToMany || targetPropSetts.RelationType == RelationType.ManyToManyInverse))
					{
						string parentFieldName = ((targetPropSetts.RelationType == RelationType.ManyToMany) ? targetPropSetts.ParentColumnName : targetPropSetts.ChildColumnName);
						string childFieldName = ((targetPropSetts.RelationType == RelationType.ManyToMany) ? targetPropSetts.ChildColumnName : targetPropSetts.ParentColumnName);
						string relationTableName2 = targetPropSetts.RelationTableName;
						if (currPropMap == null || !(currPropMap.OldPropertyInfo.Uid != Guid.Empty))
						{
							continue;
						}
						PropertyMetadata propertyMetadataFromEntities2 = GetPropertyMetadataFromEntities(sourceEntities, currPropMap.OldPropertyInfo.Uid);
						EntitySettings sourcePropSetts = (EntitySettings)propertyMetadataFromEntities2.Settings;
						bool flag3 = !mappingInfo.PropertyMappings.Any((PropertyMappingInfo m) => m.NewPropertyInfo.Uid == currPropMap.OldPropertyInfo.Uid && m.EnableConvert);
						if (sourcePropSetts.RelationType == RelationType.OneToMany)
						{
							EntityMetadata obj = (EntityMetadata)MetadataLoader.LoadMetadata(propertyMetadataFromEntities2.SubTypeUid, inherit: false);
							PropertyMetadata propertyMetadata3 = obj.Properties.FirstOrDefault((PropertyMetadata m) => m.Uid == sourcePropSetts.KeyColumnUid);
							string name3 = propertyMetadata3.Name;
							string tableName6 = EntityPropertyMetadata.GetTableName(obj.TableName, ((EntityPropertyMetadata)propertyMetadata3).TableNumber);
							Dictionary<string, object> parameters5;
							string sql5 = CreateSelectQueryString("Id", name3, tableName6, values, out parameters5);
							using IDataReader dataReader5 = Transform.ExecuteQuery(sql5, parameters5);
							int num4 = 0;
							while (dataReader5.Read())
							{
								num4++;
								long int7 = dataReader5.GetInt64(dataReader5.GetOrdinal("Id"));
								long currId2 = dataReader5.GetInt64(dataReader5.GetOrdinal(name3));
								if (flag3)
								{
									list.Add(new ToManyUpdateOperation
									{
										TableName = tableName6,
										WhereFieldName = "Id",
										WhereId = int7,
										Columns = new string[1] { name3 },
										Values = new object[1]
									});
								}
								list4.Add(new ToManyInsertOperation
								{
									TableName = relationTableName2,
									ParentFieldName = parentFieldName,
									ChildFieldName = childFieldName,
									ParentId = ((currTypeEntity is TablePartMetadata) ? list6.First((BlockMapping x) => x.SourceId == currId2 && x.TargetTypeEntityUid == currTypeEntity.Uid).TargetId : currId2),
									ChildId = int7,
									ParentTableName = tableName
								});
							}
						}
						else
						{
							if (sourcePropSetts.RelationType != RelationType.ManyToMany && sourcePropSetts.RelationType != RelationType.ManyToManyInverse)
							{
								continue;
							}
							string text3 = ((sourcePropSetts.RelationType == RelationType.ManyToMany) ? sourcePropSetts.ParentColumnName : sourcePropSetts.ChildColumnName);
							string text4 = ((sourcePropSetts.RelationType == RelationType.ManyToMany) ? sourcePropSetts.ChildColumnName : sourcePropSetts.ParentColumnName);
							string relationTableName3 = sourcePropSetts.RelationTableName;
							Dictionary<string, object> parameters6;
							string sql6 = CreateSelectQueryString(text4, text3, relationTableName3, values, out parameters6);
							using IDataReader dataReader6 = Transform.ExecuteQuery(sql6, parameters6);
							while (dataReader6.Read())
							{
								long int8 = dataReader6.GetInt64(dataReader6.GetOrdinal(text4));
								long currId = dataReader6.GetInt64(dataReader6.GetOrdinal(text3));
								if (flag3)
								{
									list3.Add(new ToManyDeleteOperation
									{
										TableName = relationTableName3,
										WhereField1Name = text3,
										Where1Id = currId,
										WhereField2Name = text4,
										Where2Id = int8
									});
								}
								list4.Add(new ToManyInsertOperation
								{
									TableName = relationTableName2,
									ParentFieldName = parentFieldName,
									ChildFieldName = childFieldName,
									ParentId = ((currTypeEntity is TablePartMetadata) ? list6.First((BlockMapping x) => x.SourceId == currId && x.TargetTypeEntityUid == currTypeEntity.Uid).TargetId : currId),
									ChildId = int8,
									ParentTableName = tableName
								});
							}
						}
					}
					else
					{
						if (targetPropSetts != null && targetPropSetts.RelationType != 0)
						{
							continue;
						}
						list8.Add(targetPropMetadata);
						if (!(targetPropMetadata.Settings is SimpleTypeSettings simpleTypeSettings))
						{
							continue;
						}
						string fieldName = simpleTypeSettings.FieldName;
						if (string.IsNullOrEmpty(fieldName))
						{
							continue;
						}
						list7.Add(fieldName);
						object obj2 = null;
						object item = null;
						Dictionary<long, object> dictionary5 = new Dictionary<long, object>();
						List<object> newValues = new List<object>();
						if (currPropMap != null && currPropMap.OldPropertyInfo.Uid != Guid.Empty)
						{
							PropertyMetadata sourcePropMetadata = null;
							if (currTypeEntity.CastAsRealType() is TablePartMetadata)
							{
								sourcePropMetadata = GetPropertyMetadataFromEntities(sourceBlocks, currPropMap.OldPropertyInfo.Uid);
								EntityMetadata parentEntityForProperty = GetParentEntityForProperty(sourceBlocks, sourcePropMetadata);
								dictionary5 = GetPropertyValuesFromEntity(num.Value, sourceTypeMd, sourceBlocks, parentEntityForProperty, sourcePropMetadata);
								string tableName7 = EntityPropertyMetadata.GetTableName(parentEntityForProperty.TableName, ((EntityPropertyMetadata)sourcePropMetadata).TableNumber);
								if (dictionary2.ContainsKey(tableName7))
								{
									foreach (long item3 in dictionary2[tableName7])
									{
										dictionary5.Remove(item3);
									}
								}
							}
							else
							{
								sourcePropMetadata = sourceTypeMd.Properties.FirstOrDefault((PropertyMetadata m) => m.Uid == currPropMap.OldPropertyInfo.Uid);
								object obj3 = sourceEntity.GetPropertyValue(currPropMap.OldPropertyInfo.Uid).CastAsRealType();
								if (sourcePropMetadata.TypeUid == DropDownListDescriptor.UID && obj3 != null)
								{
									obj2 = obj3.ToString();
									DropDownListSettings dropDownListSettings = targetPropMetadata.Settings as DropDownListSettings;
									if (dropDownListSettings.SelectOnly && !dropDownListSettings.Items.Select((DropDownItem m) => m.ToString().ToLower()).ToList().Contains(obj3.ToString().ToLower()))
									{
										obj2 = null;
									}
								}
								else if (sourcePropMetadata.TypeUid == EnumDescriptor.UID && obj3 != null)
								{
									obj2 = (int)obj3;
								}
								else if ((sourcePropMetadata.SubTypeUid == Guid.Empty && !list5.Contains(sourcePropMetadata.TypeUid)) || obj3 == null)
								{
									obj2 = obj3;
								}
								else if (ConvertTypeUids.Any((IConvertDocumentTypeUids m) => sourcePropMetadata.TypeUid == m.GetTypesDescriptor()))
								{
									obj2 = ConvertTypeUids.FirstOrDefault((IConvertDocumentTypeUids m) => sourcePropMetadata.TypeUid == m.GetTypesDescriptor()).GetUid(obj3);
								}
								else
								{
									try
									{
										obj2 = (obj3 as IEntity).GetId();
									}
									catch (Exception exception)
									{
										Logger.Log.Error(SR.T("Не удалось найти дескриптор типа для конвертируемого свойства {0}", sourcePropMetadata.DisplayName), exception);
										throw new Exception(SR.T("Не удалось найти дескриптор типа для конвертируемого свойства {0}", sourcePropMetadata.DisplayName));
									}
								}
							}
							if (targetPropMetadata.TypeUid != Guid.Empty && targetPropMetadata.SubTypeUid == Guid.Empty && targetPropMetadata.TypeUid != sourcePropMetadata.TypeUid)
							{
								ITypeConvertor convertor = typeConvertors.FirstOrDefault((ITypeConvertor c) => c.TargetTypeUids.Contains(targetPropMetadata.TypeUid) && c.SourceTypeUids.Contains(sourcePropMetadata.TypeUid));
								if (convertor != null)
								{
									dictionary5.ForEach(delegate(KeyValuePair<long, object> a)
									{
										newValues.Add(convertor.DoConvert(a.Value));
									});
									item = convertor.DoConvert(obj2);
								}
							}
							else
							{
								item = obj2;
								newValues = dictionary5.Select((KeyValuePair<long, object> p) => p.Value).ToList();
							}
						}
						if (currTypeEntity.CastAsRealType() is TablePartMetadata)
						{
							list10.Add(new List<object>(newValues));
						}
						else
						{
							list9.Add(item);
						}
					}
				}
				if (list10.Count > 0)
				{
					int num5 = list10.Select((List<object> m) => m.Count).Max();
					foreach (List<object> item4 in list10)
					{
						if (item4.Count < num5)
						{
							item4.AddRange(new object[num5 - item4.Count]);
						}
					}
				}
				if (currTypeEntity is TablePartMetadata)
				{
					foreach (KeyValuePair<long, object> item5 in dictionary4)
					{
						_ = item5;
						if (list10.Count <= 0)
						{
							continue;
						}
						int count = list10[0].Count;
						if (count == 0)
						{
							continue;
						}
						int i;
						for (i = 0; i < count; i++)
						{
							List<object> tempValues = new List<object>(list10.Count);
							List<string> tempColumns = new List<string>(list7);
							foreach (List<object> item6 in list10)
							{
								tempValues.Add(item6[i]);
							}
							List<int> list14 = new List<int>();
							int correctIndex = 0;
							for (int j = 0; j < tempValues.Count; j++)
							{
								if (tempValues[j] == null || tempValues[j] is DBNull)
								{
									list14.Add(j);
								}
							}
							list14.ForEach(delegate(int a)
							{
								tempColumns.RemoveAt(a - correctIndex);
								tempValues.RemoveAt(a - correctIndex);
								correctIndex++;
							});
							if (tempColumns.Count == tempValues.Count && tempColumns.Count != 0)
							{
								Transform.Update(Transform.Dialect.QuoteIfNeeded(item2.Key), tempColumns.ToArray(), tempValues.ToArray(), string.Format("{0} = {1}", Transform.Dialect.QuoteIfNeeded("Id"), list6.First((BlockMapping x) => x.SourceId == currentSourceIds.ToList()[i].Key).TargetId));
							}
						}
					}
				}
				else if (entitiesToInsert.Contains(ent))
				{
					list7.Add("Id");
					list9.Add(num);
					Transform.Insert(Transform.Dialect.QuoteIfNeeded(item2.Key), list7.ToArray(), list9.ToArray());
				}
				else if (intersectEntities.Contains(ent) && list7.Count > 0 && list9.Count > 0)
				{
					Transform.Update(Transform.Dialect.QuoteIfNeeded(item2.Key), list7.ToArray(), list9.ToArray(), string.Format("{0} = {1}", Transform.Dialect.QuoteIfNeeded("Id"), num));
				}
			}
		}
		foreach (ToManyDeleteOperation item7 in list3)
		{
			string sql7 = $"delete from {Transform.Dialect.QuoteIfNeeded(item7.TableName)} where {Transform.Dialect.QuoteIfNeeded(item7.WhereField1Name)} = {item7.Where1Id} and {Transform.Dialect.QuoteIfNeeded(item7.WhereField2Name)} = {item7.Where2Id}";
			Transform.ExecuteNonQuery(sql7);
		}
		foreach (ToManyUpdateOperation item8 in list.Concat(list2))
		{
			Transform.Update(Transform.Dialect.QuoteIfNeeded(item8.TableName), item8.Columns, item8.Values, $"{Transform.Dialect.QuoteIfNeeded(item8.WhereFieldName)} = {item8.WhereId}");
		}
		foreach (ToManyInsertOperation item9 in list4)
		{
			Transform.Insert(item9.TableName, new string[2] { item9.ParentFieldName, item9.ChildFieldName }, new object[2] { item9.ParentId, item9.ChildId });
		}
		return dictionary;
	}

	private string CreateSelectQueryString(string selectParam, string conditionParam, string tableName, List<object> values, out Dictionary<string, object> parameters)
	{
		parameters = new Dictionary<string, object>(values.Count);
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < values.Count; i++)
		{
			string text = "param" + i;
			parameters[text] = values[i];
			stringBuilder.Append(Transform.ParameterSeparator).Append(text);
			if (i < values.Count - 1)
			{
				stringBuilder.Append(", ");
			}
		}
		return string.Format("select {0}, {2} from {1} where {2} in ( {3} )", Transform.Dialect.QuoteIfNeeded(selectParam), Transform.Dialect.QuoteIfNeeded(tableName), Transform.Dialect.QuoteIfNeeded(conditionParam), stringBuilder);
	}

	private void UpdateReferences(IEntity sourceEntity, ConvertTypeEntitiesInfo entitiesInfo, Dictionary<string, List<long>> recordsToDelete)
	{
		long? num = sourceEntity.GetId() as long?;
		if (!num.HasValue)
		{
			return;
		}
		List<EntityMetadata> entitiesToDelete = entitiesInfo.EntitiesToDelete;
		List<EntityMetadata> blocksToDelete = entitiesInfo.BlocksToDelete;
		List<EntityMetadata> sourceBlocks = entitiesInfo.SourceBlocks;
		foreach (EntityMetadata item in entitiesToDelete)
		{
			foreach (FindReferenceService.Reference item2 in (from m in FindReference.GetReferences(item.FullTypeName, all: true).ToList()
				where !blocksToDelete.Select((EntityMetadata n) => n.Uid).ToList().Contains(m.EntityMetadata.Uid)
				select m).ToList())
			{
				EntitySettings entitySettings = (EntitySettings)item2.PropertyMetadata.Settings;
				if (item2.ReferenceType == FindReferenceService.ReferenceEnum.Simple)
				{
					Dictionary<string, List<long>> andAddIdToDeleteList = GetAndAddIdToDeleteList(item2.EntityMetadata, item2.EntityMetadata, sourceBlocks.Concat(new List<EntityMetadata> { item2.EntityMetadata }).ToList(), num.Value);
					if (((EntitySettings)item2.PropertyMetadata.Settings).CascadeMode == CascadeMode.AllDeleteOrphan)
					{
						andAddIdToDeleteList.ForEach(delegate(KeyValuePair<string, List<long>> a)
						{
							recordsToDelete.Add(a.Key, a.Value);
						});
						continue;
					}
					foreach (KeyValuePair<string, List<long>> item3 in andAddIdToDeleteList)
					{
						foreach (long item4 in item3.Value)
						{
							string sql = string.Format("update {0} set {1} = null where {2} = {3}", Transform.Dialect.QuoteIfNeeded(item3.Key), Transform.Dialect.QuoteIfNeeded(entitySettings.FieldName), Transform.Dialect.QuoteIfNeeded("Id"), item4);
							Transform.ExecuteNonQuery(sql);
						}
					}
				}
				else if (item2.ReferenceType == FindReferenceService.ReferenceEnum.ManyToMany)
				{
					string sql2 = $"delete from {Transform.Dialect.QuoteIfNeeded(entitySettings.RelationTableName)} where {Transform.Dialect.QuoteIfNeeded(entitySettings.ChildColumnName)} = {num.Value}";
					Transform.ExecuteNonQuery(sql2);
				}
			}
		}
	}

	private void Delete(IEntity sourceEntity, ConvertTypeEntitiesInfo entitiesInfo, Dictionary<string, List<long>> recordsToDelete)
	{
		long? num = sourceEntity.GetId() as long?;
		if (!num.HasValue)
		{
			return;
		}
		List<EntityMetadata> blocksToDelete = entitiesInfo.BlocksToDelete;
		List<EntityMetadata> sourceBlocks = entitiesInfo.SourceBlocks;
		List<EntityMetadata> classesToDelete = entitiesInfo.ClassesToDelete;
		EntityMetadata sourceTypeMd = entitiesInfo.SourceTypeMd;
		foreach (EntityMetadata item in blocksToDelete)
		{
			EntityMetadata entityMetadata = (EntityMetadata)MetadataLoader.LoadMetadata(item.Uid, inherit: false);
			foreach (KeyValuePair<string, List<long>> andAddIdToDelete in GetAndAddIdToDeleteList(entityMetadata, sourceTypeMd, sourceBlocks, num.Value))
			{
				foreach (long item2 in andAddIdToDelete.Value)
				{
					RemoveDependencies(entityMetadata, item2);
				}
				recordsToDelete.Add(andAddIdToDelete.Key, andAddIdToDelete.Value);
			}
		}
		foreach (KeyValuePair<string, List<long>> item3 in recordsToDelete.Reverse())
		{
			foreach (long item4 in item3.Value)
			{
				string sql = string.Format("delete from {0} where {1} = {2}", Transform.Dialect.QuoteIfNeeded(item3.Key), Transform.Dialect.QuoteIfNeeded("Id"), item4);
				Transform.ExecuteNonQuery(sql);
			}
		}
		foreach (EntityMetadata item5 in classesToDelete)
		{
			string empty = string.Empty;
			EntityMetadata entityMetadata2 = (EntityMetadata)MetadataLoader.LoadMetadata(item5.Uid, inherit: false);
			for (int i = 0; i <= entityMetadata2.LastTableNumber; i++)
			{
				string tableName = EntityPropertyMetadata.GetTableName(entityMetadata2.TableName, i);
				foreach (PropertyMetadata property in entityMetadata2.Properties)
				{
					EntitySettings propSettings = property.Settings as EntitySettings;
					if (propSettings == null)
					{
						continue;
					}
					if (propSettings.RelationType == RelationType.OneToMany)
					{
						if (MetadataLoader.LoadMetadata(property.SubTypeUid, inherit: false) is EntityMetadata entityMetadata3)
						{
							PropertyMetadata propertyMetadata = entityMetadata3.Properties.FirstOrDefault((PropertyMetadata m) => m.Uid == propSettings.KeyColumnUid);
							string name = propertyMetadata.Name;
							string tableName2 = EntityPropertyMetadata.GetTableName(entityMetadata3.TableName, ((EntityPropertyMetadata)propertyMetadata).TableNumber);
							empty = $"update {Transform.Dialect.QuoteIfNeeded(tableName2)} set {Transform.Dialect.QuoteIfNeeded(name)} = null Where {Transform.Dialect.QuoteIfNeeded(name)} = {num.Value}";
							Transform.ExecuteNonQuery(empty);
						}
					}
					else if (propSettings.RelationType == RelationType.ManyToMany || propSettings.RelationType == RelationType.ManyToManyInverse)
					{
						string name2 = ((propSettings.RelationType == RelationType.ManyToMany) ? propSettings.ParentColumnName : propSettings.ChildColumnName);
						string relationTableName = propSettings.RelationTableName;
						empty = $"update {Transform.Dialect.QuoteIfNeeded(relationTableName)} set {Transform.Dialect.QuoteIfNeeded(name2)} = null Where {Transform.Dialect.QuoteIfNeeded(name2)} = {num.Value}";
						Transform.ExecuteNonQuery(empty);
					}
				}
				empty = string.Format("delete from {0} where {1} = {2}", Transform.Dialect.QuoteIfNeeded(tableName), Transform.Dialect.QuoteIfNeeded("Id"), num.Value);
				Transform.ExecuteNonQuery(empty);
			}
		}
	}

	private void RemoveDependencies(EntityMetadata currTypeEntity, long? sourceId)
	{
		string empty = string.Empty;
		for (int i = 0; i <= currTypeEntity.LastTableNumber; i++)
		{
			EntityPropertyMetadata.GetTableName(currTypeEntity.TableName, i);
			foreach (PropertyMetadata property in currTypeEntity.Properties)
			{
				EntitySettings propSettings = property.Settings as EntitySettings;
				if (propSettings == null)
				{
					continue;
				}
				if (propSettings.RelationType == RelationType.OneToMany)
				{
					if (MetadataLoader.LoadMetadata(property.SubTypeUid, inherit: false) is EntityMetadata entityMetadata)
					{
						PropertyMetadata propertyMetadata = entityMetadata.Properties.FirstOrDefault((PropertyMetadata m) => m.Uid == propSettings.KeyColumnUid);
						string name = propertyMetadata.Name;
						string tableName = EntityPropertyMetadata.GetTableName(entityMetadata.TableName, ((EntityPropertyMetadata)propertyMetadata).TableNumber);
						empty = $"delete {Transform.Dialect.QuoteIfNeeded(tableName)} Where {Transform.Dialect.QuoteIfNeeded(name)} = {sourceId.Value}";
						Transform.ExecuteNonQuery(empty);
					}
				}
				else if (propSettings.RelationType == RelationType.ManyToMany || propSettings.RelationType == RelationType.ManyToManyInverse)
				{
					string name2 = ((propSettings.RelationType == RelationType.ManyToMany) ? propSettings.ParentColumnName : propSettings.ChildColumnName);
					string relationTableName = propSettings.RelationTableName;
					empty = $"delete {Transform.Dialect.QuoteIfNeeded(relationTableName)} Where {Transform.Dialect.QuoteIfNeeded(name2)} = {sourceId.Value}";
					Transform.ExecuteNonQuery(empty);
				}
			}
		}
	}

	private void UpdateHistory(IEntity sourceEntity, ConvertTypeEntitiesInfo entitiesInfo)
	{
		long? num = sourceEntity.GetId() as long?;
		if (num.HasValue)
		{
			Guid uid = entitiesInfo.TargetTypeMd.Uid;
			Dictionary<string, object> dictionary = new Dictionary<string, object>();
			dictionary.Add("parameter01", entitiesInfo.SourceTypeMd.Uid);
			Transform.Update("EntityActionHistory", new string[1] { "ActionObjectUid" }, new object[1] { uid }, string.Format("ActionObjectUid = {0} and ActionObjectId = {1}", Transform.ParameterSeparator + "parameter01", num.Value), dictionary);
			Transform.Update("EntityModelHistory", new string[1] { "ObjectTypeUid" }, new object[1] { uid }, string.Format("ObjectTypeUid = {0} and ObjectId = {1}", Transform.ParameterSeparator + "parameter01", num.Value), dictionary);
		}
	}

	private void UpdateWatches(IEntity entity, Guid targetTypeUid)
	{
		if (entity is IInheritable)
		{
			Guid typeUid = ((IInheritable)entity).TypeUid;
			Dictionary<string, object> dictionary = new Dictionary<string, object>();
			dictionary.Add("parameter01", typeUid);
			dictionary.Add("parameter02", entity.GetId().ToString());
			Transform.Update("Watch", new string[1] { "TypeUid" }, new object[1] { targetTypeUid }, string.Format("TypeUid = {0} and EntityId = {1}", Transform.ParameterSeparator + "parameter01", Transform.ParameterSeparator + "parameter02"), dictionary);
			Transform.Update("Watch", new string[1] { "ParentTypeUid" }, new object[1] { targetTypeUid }, string.Format("ParentTypeUid = {0} and ParentEntityId = {1}", Transform.ParameterSeparator + "parameter01", Transform.ParameterSeparator + "parameter02"), dictionary);
			WatchEntityService.ClearForObject(typeUid, entity.GetId());
		}
	}

	private PropertyMetadata GetPropertyMetadataFromEntities(List<EntityMetadata> sourceEntities, Guid propertyUid)
	{
		PropertyMetadata propertyMetadata = null;
		foreach (EntityMetadata sourceEntity in sourceEntities)
		{
			propertyMetadata = sourceEntity.Properties.FirstOrDefault((PropertyMetadata m) => m.Uid == propertyUid);
			if (propertyMetadata != null)
			{
				return propertyMetadata;
			}
		}
		return propertyMetadata;
	}

	private EntityMetadata GetParentEntityForProperty(List<EntityMetadata> sourceEntities, PropertyMetadata property)
	{
		foreach (EntityMetadata sourceEntity in sourceEntities)
		{
			if (sourceEntity.Properties.FirstOrDefault((PropertyMetadata m) => m.Uid == property.Uid) != null)
			{
				return sourceEntity;
			}
		}
		return null;
	}

	private Dictionary<long, object> GetPropertyValuesFromEntity(long id, EntityMetadata rootEntity, List<EntityMetadata> entities, EntityMetadata lowerEntity, PropertyMetadata propertyMetadata = null)
	{
		if (!entities.Contains(rootEntity))
		{
			entities.Add(rootEntity);
		}
		Dictionary<long, object> dictionary = new Dictionary<long, object>();
		string format = "select {4}.* from {0} \n {5} where {1}.{2} = {3}";
		string format2 = " inner join {0} on {1}.{2} = {3}.{4} \n";
		string text = string.Empty;
		List<Pair<string, string>> list = new List<Pair<string, string>>();
		EntityMetadata entityMetadata = lowerEntity;
		while (entityMetadata != null && entityMetadata.Uid != rootEntity.Uid)
		{
			string first = ((entityMetadata == lowerEntity && propertyMetadata != null) ? EntityPropertyMetadata.GetTableName(entityMetadata.TableName, ((EntityPropertyMetadata)propertyMetadata).TableNumber) : entityMetadata.TableName);
			string fkFieldName = string.Empty;
			entityMetadata = GetParentEntity(entities, entityMetadata, out fkFieldName, entityMetadata is TablePartMetadata);
			list.Insert(0, new Pair<string, string>(first, fkFieldName));
		}
		list.Insert(0, new Pair<string, string>(rootEntity.TableName, string.Empty));
		Pair<string, string> pair = new Pair<string, string>(string.Empty, string.Empty);
		for (int i = 0; i < list.Count; i++)
		{
			Pair<string, string> pair2 = list[i];
			if (i != 0)
			{
				text += string.Format(format2, Transform.Dialect.QuoteIfNeeded(pair2.First), Transform.Dialect.QuoteIfNeeded(pair2.First), Transform.Dialect.QuoteIfNeeded(pair2.Second), Transform.Dialect.QuoteIfNeeded(pair.First), Transform.Dialect.QuoteIfNeeded("Id"));
			}
			pair = pair2;
		}
		string sql = string.Format(format, Transform.Dialect.QuoteIfNeeded(rootEntity.TableName), Transform.Dialect.QuoteIfNeeded(rootEntity.TableName), Transform.Dialect.QuoteIfNeeded("Id"), id, Transform.Dialect.QuoteIfNeeded(list.LastOrDefault().First), text);
		using IDataReader dataReader = Transform.ExecuteQuery(sql);
		while (dataReader.Read())
		{
			dictionary.Add(dataReader.GetInt64(dataReader.GetOrdinal("Id")), (propertyMetadata != null) ? dataReader.GetValue(dataReader.GetOrdinal(((SimpleTypeSettings)propertyMetadata.Settings).FieldName)) : null);
		}
		return dictionary;
	}

	private EntityMetadata GetParentEntity(List<EntityMetadata> sourceEntities, EntityMetadata entity, out string fkFieldName, bool isTablePart = false)
	{
		foreach (EntityMetadata currEnt in sourceEntities)
		{
			if (entity.CastAsRealType() is TablePartMetadata && currEnt.TableParts.FirstOrDefault((TablePartMetadata m) => m.Uid == entity.Uid) != null)
			{
				fkFieldName = "Parent";
				return currEnt;
			}
			if (isTablePart)
			{
				continue;
			}
			PropertyMetadata propertyMetadata = currEnt.Properties.FirstOrDefault((PropertyMetadata m) => m.SubTypeUid == entity.ImplementationUid && entity.ImplementationUid != Guid.Empty);
			if (propertyMetadata != null)
			{
				Guid keyUid = ((EntitySettings)propertyMetadata.Settings).KeyColumnUid;
				fkFieldName = entity.Properties.FirstOrDefault((PropertyMetadata m) => m.Uid == keyUid).Name;
				return currEnt;
			}
			propertyMetadata = entity.Properties.FirstOrDefault((PropertyMetadata m) => m.SubTypeUid == currEnt.ImplementationUid && currEnt.ImplementationUid != Guid.Empty);
			if (propertyMetadata != null)
			{
				fkFieldName = propertyMetadata.Name;
				return currEnt;
			}
		}
		fkFieldName = string.Empty;
		return null;
	}

	private Dictionary<string, List<long>> GetAndAddIdToDeleteList(EntityMetadata currentEntity, EntityMetadata rootEntity, List<EntityMetadata> entities, long docId)
	{
		Dictionary<string, List<long>> dictionary = new Dictionary<string, List<long>>();
		foreach (KeyValuePair<long, object> item in GetPropertyValuesFromEntity(docId, rootEntity, entities, currentEntity))
		{
			for (int i = 0; i <= currentEntity.LastTableNumber; i++)
			{
				string tableName = EntityPropertyMetadata.GetTableName(currentEntity.TableName, i);
				if (dictionary.ContainsKey(tableName))
				{
					dictionary[tableName].Add(item.Key);
					continue;
				}
				dictionary[tableName] = new List<long> { item.Key };
			}
		}
		return dictionary;
	}
}
