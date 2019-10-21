﻿using System;

namespace Tests.UserTests
{
	//---------------------------------------------------------------------------------------------------
	// This code was generated by LinqToDB.
	//---------------------------------------------------------------------------------------------------
	using System;
	using System.Linq;
	using LinqToDB;

	using NUnit.Framework;
	using MCC.WMS.ServiceInterfaces.DTO;

	namespace MCC.Common.ServiceInterfaces.DTO
	{
		public interface IModifiedTimeStamp
		{
		}
	}

	namespace MCC.Common.ServiceInterfaces.DTO.Base
	{
		public class BasicDTO : MCC.Common.ServiceInterfaces.DTO.Base.BasicDTOwithoutID, MCC.Common.ServiceInterfaces.DTO.Base.IMccEntityState, MCC.Common.ServiceInterfaces.DTO.Base.IInterlinqDTO, MCC.Common.ServiceInterfaces.DTO.Base.IDTOWithId
		{
			public Guid Id { get; set; }
		}
	}

	namespace MCC.Common.ServiceInterfaces.DTO.Base
	{
		[System.Reflection.DefaultMemberAttribute("Item")]
		public class BasicDTOwithExtensionData : MCC.Common.ServiceInterfaces.DTO.Base.BasicDTO, MCC.Common.ServiceInterfaces.DTO.Base.IMccEntityState, MCC.Common.ServiceInterfaces.DTO.Base.IInterlinqDTO, MCC.Common.ServiceInterfaces.DTO.Base.IDTOWithId, MCC.Common.ServiceInterfaces.Interfaces.IExtensionData
		{
		}
	}

	namespace MCC.Common.ServiceInterfaces.DTO.Base
	{
		[System.Runtime.Serialization.KnownTypeAttribute("KnownTypes")]
		public class BasicDTOwithoutID : MCC.Common.ServiceInterfaces.DTO.Base.IMccEntityState, MCC.Common.ServiceInterfaces.DTO.Base.IInterlinqDTO
		{
		}
	}

	namespace MCC.Common.ServiceInterfaces.DTO.Base
	{
		public interface ICreatedTimeStamp
		{
		}
	}

	namespace MCC.Common.ServiceInterfaces.DTO.Base
	{
		public interface IDTOWithId
		{
		}
	}

	namespace MCC.Common.ServiceInterfaces.DTO.Base
	{
		public interface IHasArchiveTable
		{
		}
	}

	namespace MCC.Common.ServiceInterfaces.DTO.Base
	{
		public interface IInterlinqDTO
		{
		}
	}

	namespace MCC.Common.ServiceInterfaces.DTO.Base
	{
		public interface IMccEntityState
		{
		}
	}

	namespace MCC.Common.ServiceInterfaces.Interfaces
	{
		[System.Reflection.DefaultMemberAttribute("Item")]
		public interface IExtensionData
		{
		}
	}

	namespace MCC.WMS.ServiceInterfaces.DTO
	{
		[System.Runtime.Serialization.DataContractAttribute(Name = "WMS_GlobalTaskDTO")]
		public class GlobalTaskDTO : MCC.WMS.ServiceInterfaces.DTO.WmsBasicDTO<MCC.WMS.ServiceInterfaces.DTO.GlobalTaskDTO>, MCC.Common.ServiceInterfaces.DTO.Base.IMccEntityState, MCC.Common.ServiceInterfaces.DTO.Base.IInterlinqDTO, MCC.Common.ServiceInterfaces.DTO.Base.IDTOWithId, MCC.Common.ServiceInterfaces.Interfaces.IExtensionData, MCC.Common.ServiceInterfaces.DTO.IModifiedTimeStamp, MCC.Common.ServiceInterfaces.DTO.Base.ICreatedTimeStamp, MCC.Common.ServiceInterfaces.DTO.Base.IHasArchiveTable
		{
			public GlobalTaskDTO()
			{
				throw new NotImplementedException();
			}

			public GlobalTaskDTO(MCC.WMS.ServiceInterfaces.DTO.GlobalTaskDTO dto)
			{
				throw new NotImplementedException();
			}

			[System.Runtime.Serialization.DataMemberAttribute()]
			public Guid ResourceID { get; set; }

			[System.Runtime.Serialization.DataMemberAttribute()]
			public Guid? StorageShelfSourceID { get; set; }

			[System.Runtime.Serialization.DataMemberAttribute()]
			public Guid? RPSourceID { get; set; }

			[System.Runtime.Serialization.DataMemberAttribute()]
			public Guid? StorageShelfDestinationID { get; set; }

			[System.Runtime.Serialization.DataMemberAttribute()]
			public Guid? RPDestinationID { get; set; }

			[System.Runtime.Serialization.DataMemberAttribute()]
			public Guid? RPOrigDestinationID { get; set; }

			[System.Runtime.Serialization.DataMemberAttribute()]
			public Guid? OutfeedTransportOrderID { get; set; }
		}
	}

	namespace MCC.WMS.ServiceInterfaces.DTO
	{
		[System.Runtime.Serialization.DataContractAttribute(Name = "WMS_OutfeedTransportOrderDTO")]
		public class OutfeedTransportOrderDTO : MCC.WMS.ServiceInterfaces.DTO.WmsBasicDTO<MCC.WMS.ServiceInterfaces.DTO.OutfeedTransportOrderDTO>, MCC.Common.ServiceInterfaces.DTO.Base.IMccEntityState, MCC.Common.ServiceInterfaces.DTO.Base.IInterlinqDTO, MCC.Common.ServiceInterfaces.DTO.Base.IDTOWithId, MCC.Common.ServiceInterfaces.Interfaces.IExtensionData, MCC.Common.ServiceInterfaces.DTO.IModifiedTimeStamp, MCC.Common.ServiceInterfaces.DTO.Base.ICreatedTimeStamp, MCC.Common.ServiceInterfaces.DTO.Base.IHasArchiveTable
		{
			public OutfeedTransportOrderDTO()
			{
				throw new NotImplementedException();
			}

			public OutfeedTransportOrderDTO(MCC.WMS.ServiceInterfaces.DTO.OutfeedTransportOrderDTO dto)
			{
				throw new NotImplementedException();
			}
		}
	}

	namespace MCC.WMS.ServiceInterfaces.DTO
	{
		[System.Runtime.Serialization.DataContractAttribute(Name = "WMS_StorageShelfDTO")]
		public class StorageShelfDTO : MCC.Common.ServiceInterfaces.DTO.Base.BasicDTOwithExtensionData, MCC.Common.ServiceInterfaces.DTO.Base.IMccEntityState, MCC.Common.ServiceInterfaces.DTO.Base.IInterlinqDTO, MCC.Common.ServiceInterfaces.DTO.Base.IDTOWithId, MCC.Common.ServiceInterfaces.Interfaces.IExtensionData, MCC.Common.ServiceInterfaces.DTO.IModifiedTimeStamp
		{
		}
	}

	namespace MCC.WMS.ServiceInterfaces.DTO
	{
		[System.Runtime.Serialization.DataContractAttribute(Name = "WMS_BasicDTO")]
		public abstract class WmsBasicDTO<T> : MCC.WMS.ServiceInterfaces.DTO.WmsBasicWithoutCustomFieldsDTO<T>, MCC.Common.ServiceInterfaces.DTO.Base.IMccEntityState, MCC.Common.ServiceInterfaces.DTO.Base.IInterlinqDTO, MCC.Common.ServiceInterfaces.DTO.Base.IDTOWithId, MCC.Common.ServiceInterfaces.Interfaces.IExtensionData, MCC.Common.ServiceInterfaces.DTO.IModifiedTimeStamp, MCC.Common.ServiceInterfaces.DTO.Base.ICreatedTimeStamp
		{
			public WmsBasicDTO()
			{
				throw new NotImplementedException();
			}

			public WmsBasicDTO(T dto)
			{
				throw new NotImplementedException();
			}
		}
	}

	namespace MCC.WMS.ServiceInterfaces.DTO
	{
		[System.Runtime.Serialization.DataContractAttribute(Name = "WMS_BasicDTO")]
		public abstract class WmsBasicWithoutCustomFieldsDTO<T> : MCC.Common.ServiceInterfaces.DTO.Base.BasicDTOwithExtensionData, MCC.Common.ServiceInterfaces.DTO.Base.IMccEntityState, MCC.Common.ServiceInterfaces.DTO.Base.IInterlinqDTO, MCC.Common.ServiceInterfaces.DTO.Base.IDTOWithId, MCC.Common.ServiceInterfaces.Interfaces.IExtensionData, MCC.Common.ServiceInterfaces.DTO.IModifiedTimeStamp, MCC.Common.ServiceInterfaces.DTO.Base.ICreatedTimeStamp
		{
			public WmsBasicWithoutCustomFieldsDTO()
			{
				throw new NotImplementedException();
			}

			public WmsBasicWithoutCustomFieldsDTO(T dto)
			{
				throw new NotImplementedException();
			}
		}
	}

	namespace MCC.WMS.ServiceInterfaces.DTO
	{
		[System.Runtime.Serialization.DataContractAttribute(Name = "WMS_GlobalTaskCombinedDTO")]
		public class WmsGlobalTaskCombinedDTO : MCC.Common.ServiceInterfaces.DTO.Base.IInterlinqDTO
		{
			[System.Runtime.Serialization.DataMemberAttribute()]
			public MCC.WMS.ServiceInterfaces.DTO.GlobalTaskDTO GlobalTask { get; set; }

			[System.Runtime.Serialization.DataMemberAttribute()]
			public MCC.WMS.ServiceInterfaces.DTO.WmsLoadCarrierDTO LoadCarrier { get; set; }

			[System.Runtime.Serialization.DataMemberAttribute()]
			public MCC.WMS.ServiceInterfaces.DTO.WmsResourcePointDTO Source { get; set; }

			[System.Runtime.Serialization.DataMemberAttribute()]
			public MCC.WMS.ServiceInterfaces.DTO.StorageShelfDTO SourceShelf { get; set; }

			[System.Runtime.Serialization.DataMemberAttribute()]
			public MCC.WMS.ServiceInterfaces.DTO.WmsResourcePointDTO Destination { get; set; }

			[System.Runtime.Serialization.DataMemberAttribute()]
			public MCC.WMS.ServiceInterfaces.DTO.StorageShelfDTO DestinationShelf { get; set; }

			[System.Runtime.Serialization.DataMemberAttribute()]
			public MCC.WMS.ServiceInterfaces.DTO.WmsResourcePointDTO OriginDestination { get; set; }

			[System.Runtime.Serialization.DataMemberAttribute()]
			public MCC.WMS.ServiceInterfaces.DTO.OutfeedTransportOrderDTO OutfeedTransportOrder { get; set; }
		}
	}

	namespace MCC.WMS.ServiceInterfaces.DTO
	{
		[System.Runtime.Serialization.DataContractAttribute(Name = "WMS_ResourceDTO")]
		public class WmsLoadCarrierDTO : MCC.WMS.ServiceInterfaces.DTO.WmsBasicDTO<MCC.WMS.ServiceInterfaces.DTO.WmsLoadCarrierDTO>, MCC.Common.ServiceInterfaces.DTO.Base.IMccEntityState, MCC.Common.ServiceInterfaces.DTO.Base.IInterlinqDTO, MCC.Common.ServiceInterfaces.DTO.Base.IDTOWithId, MCC.Common.ServiceInterfaces.Interfaces.IExtensionData, MCC.Common.ServiceInterfaces.DTO.IModifiedTimeStamp, MCC.Common.ServiceInterfaces.DTO.Base.ICreatedTimeStamp, MCC.Common.ServiceInterfaces.DTO.Base.IHasArchiveTable
		{
			public WmsLoadCarrierDTO()
			{
				throw new NotImplementedException();
			}

			public WmsLoadCarrierDTO(MCC.WMS.ServiceInterfaces.DTO.WmsLoadCarrierDTO dto)
			{
				throw new NotImplementedException();
			}
		}
	}

	namespace MCC.WMS.ServiceInterfaces.DTO
	{
		[System.Runtime.Serialization.DataContractAttribute(Name = "WMS_ResourcePointDTO")]
		public class WmsResourcePointDTO : MCC.Common.ServiceInterfaces.DTO.Base.BasicDTOwithExtensionData, MCC.Common.ServiceInterfaces.DTO.Base.IMccEntityState, MCC.Common.ServiceInterfaces.DTO.Base.IInterlinqDTO, MCC.Common.ServiceInterfaces.DTO.Base.IDTOWithId, MCC.Common.ServiceInterfaces.Interfaces.IExtensionData
		{
		}
	}

	namespace Tests.UserTests
	{
		[TestFixture]
		public class Issue1347Tests : TestBase
		{
			class LimitedSources : IncludeDataSourcesAttribute
			{
				public LimitedSources() : base(TestProvName.AllSQLite)
				{
				}
			}

			[Test]
			public void Test5([LimitedSources]string context)
			{
				using (var s = GetDataContext(context))
				{
					var gts = s.GetTable<GlobalTaskDTO>().Union(
						s.GetTable<GlobalTaskDTO>()
							.TableName(
								"WMS_GlobalTaskA"));

					var lcs = s.GetTable<WmsLoadCarrierDTO>().Union(
						s.GetTable<WmsLoadCarrierDTO>()
							.TableName(
								"WMS_LoadCarrierA"));

					var qry = from g in gts
							  join res in lcs on g.ResourceID equals res.Id into reslist
							  from res in reslist.DefaultIfEmpty()
							  select new WmsGlobalTaskCombinedDTO()
								  { GlobalTask = g, LoadCarrier = res };

					Console.WriteLine(qry.ToString());
				}
			}

			[Test]
			public void Test4([LimitedSources] string context)
			{
				using (var s = GetDataContext(context))
				{
					var gts = s.GetTable<GlobalTaskDTO>().Union(
						s.GetTable<GlobalTaskDTO>()
							.TableName(
								"WMS_GlobalTaskA"));

					var qry = from g in gts
						join source1 in s.GetTable<WmsResourcePointDTO>() on g.RPSourceID equals source1.Id into
							source1List
						select new WmsGlobalTaskCombinedDTO()
						{
							GlobalTask = g,
						};

					Console.WriteLine(qry.ToString());
				}
			}

			[Test]
			public void Test3([LimitedSources] string context)
			{
				using (var s = GetDataContext(context))
				{
					var gts = s.GetTable<GlobalTaskDTO>().Union(
						s.GetTable<GlobalTaskDTO>()
							.TableName(
								"WMS_GlobalTaskA"));

						var qry = from g in gts
						join source1 in s.GetTable<WmsResourcePointDTO>() on g.RPSourceID equals source1.Id into
							source1List
						from source in source1List.DefaultIfEmpty()
						join sourceShelf1 in s.GetTable<StorageShelfDTO>() on g.StorageShelfSourceID equals sourceShelf1
							.Id into sourceShelf1List
						from sourceShelf in sourceShelf1List.DefaultIfEmpty()
						join dest1 in s.GetTable<WmsResourcePointDTO>() on g.RPDestinationID equals dest1.Id into
							destList
						from dest in destList.DefaultIfEmpty()
						join destShelf1 in s.GetTable<StorageShelfDTO>() on g.StorageShelfDestinationID equals
							destShelf1.Id into destShelf1List
						from destShelf in destShelf1List.DefaultIfEmpty()
						join origdest1 in s.GetTable<WmsResourcePointDTO>() on g.RPOrigDestinationID equals origdest1.Id
							into origdestList
						from origdest in origdestList.DefaultIfEmpty()
						select new WmsGlobalTaskCombinedDTO()
						{
							GlobalTask = g, Source = source, SourceShelf = sourceShelf,
							Destination = dest, DestinationShelf = destShelf, OriginDestination = origdest
						};
					
					Console.WriteLine(qry.ToString());
				}
			}

			[Test]
			public void Test2([LimitedSources]string context)
			{
				using (var s = GetDataContext(context))
				{
					var gts = s.GetTable<GlobalTaskDTO>().Union(
						s.GetTable<GlobalTaskDTO>()
							.TableName(
								"WMS_GlobalTaskA"));

					var lcs = s.GetTable<WmsLoadCarrierDTO>().Union(
						s.GetTable<WmsLoadCarrierDTO>()
							.TableName(
								"WMS_LoadCarrierA"));

					var ots = s.GetTable<OutfeedTransportOrderDTO>().Union(
						s.GetTable<OutfeedTransportOrderDTO>()
							.TableName(
								"WMS_OutfeedTransportOrderA"));

					var qry = from g in gts
						join source1 in s.GetTable<WmsResourcePointDTO>() on g.RPSourceID equals source1.Id into source1List
						from source in source1List.DefaultIfEmpty()
						join sourceShelf1 in s.GetTable<StorageShelfDTO>() on g.StorageShelfSourceID equals sourceShelf1.Id into sourceShelf1List
						from sourceShelf in sourceShelf1List.DefaultIfEmpty()
						join dest1 in s.GetTable<WmsResourcePointDTO>() on g.RPDestinationID equals dest1.Id into destList
						from dest in destList.DefaultIfEmpty()
						join destShelf1 in s.GetTable<StorageShelfDTO>() on g.StorageShelfDestinationID equals destShelf1.Id into destShelf1List
						from destShelf in destShelf1List.DefaultIfEmpty()
						join origdest1 in s.GetTable<WmsResourcePointDTO>() on g.RPOrigDestinationID equals origdest1.Id into origdestList
						from origdest in origdestList.DefaultIfEmpty()
						join res in lcs on g.ResourceID equals res.Id into reslist
						from res in reslist.DefaultIfEmpty()
						join outfeed1 in ots on g.OutfeedTransportOrderID equals outfeed1.Id into outfeed1List
						from outfeed in outfeed1List.DefaultIfEmpty()
						select new WmsGlobalTaskCombinedDTO() { GlobalTask = g, LoadCarrier = res, Source = source, SourceShelf = sourceShelf, Destination = dest, DestinationShelf = destShelf, OriginDestination = origdest, OutfeedTransportOrder = outfeed };

					Console.WriteLine(qry.ToString());
				}
			}

			[Test]
			public void Test([LimitedSources]string context)
			{
				using (var db = GetDataContext(context))
				{
					var query = db.GetTable<MCC.WMS.ServiceInterfaces.DTO.GlobalTaskDTO>()
						.Union(
							db.GetTable<MCC.WMS.ServiceInterfaces.DTO.GlobalTaskDTO>()
								.TableName(
									"WMS_GlobalTaskA")
								.TableName(
									"WMS_GlobalTaskA"))
						.GroupJoin(
							db.GetTable<MCC.WMS.ServiceInterfaces.DTO.WmsResourcePointDTO>(),
							g => g.RPSourceID,
							source1 => (Guid?)source1.Id,
							(g, source1List) => new
							{
								g = g,
								source1List = source1List
							})
						.SelectMany(
							tp0 => tp0.source1List
								.DefaultIfEmpty(),
							(tp0, source) => new
							{
								tp0 = tp0,
								source = source
							})
						.GroupJoin(
							db.GetTable<MCC.WMS.ServiceInterfaces.DTO.StorageShelfDTO>(),
							tp1 => tp1.tp0.g.StorageShelfSourceID,
							sourceShelf1 => (Guid?)sourceShelf1.Id,
							(tp1, sourceShelf1List) => new
							{
								tp1 = tp1,
								sourceShelf1List = sourceShelf1List
							})
						.SelectMany(
							tp2 => tp2.sourceShelf1List
								.DefaultIfEmpty(),
							(tp2, sourceShelf) => new
							{
								tp2 = tp2,
								sourceShelf = sourceShelf
							})
						.GroupJoin(
							db.GetTable<MCC.WMS.ServiceInterfaces.DTO.WmsResourcePointDTO>(),
							tp3 => tp3.tp2.tp1.tp0.g.RPDestinationID,
							dest1 => (Guid?)dest1.Id,
							(tp3, destList) => new
							{
								tp3 = tp3,
								destList = destList
							})
						.SelectMany(
							tp4 => tp4.destList
								.DefaultIfEmpty(),
							(tp4, dest) => new
							{
								tp4 = tp4,
								dest = dest
							})
						.GroupJoin(
							db.GetTable<MCC.WMS.ServiceInterfaces.DTO.StorageShelfDTO>(),
							tp5 => tp5.tp4.tp3.tp2.tp1.tp0.g.StorageShelfDestinationID,
							destShelf1 => (Guid?)destShelf1.Id,
							(tp5, destShelf1List) => new
							{
								tp5 = tp5,
								destShelf1List = destShelf1List
							})
						.SelectMany(
							tp6 => tp6.destShelf1List
								.DefaultIfEmpty(),
							(tp6, destShelf) => new
							{
								tp6 = tp6,
								destShelf = destShelf
							})
						.GroupJoin(
							db.GetTable<MCC.WMS.ServiceInterfaces.DTO.WmsResourcePointDTO>(),
							tp7 => tp7.tp6.tp5.tp4.tp3.tp2.tp1.tp0.g.RPOrigDestinationID,
							origdest1 => (Guid?)origdest1.Id,
							(tp7, origdestList) => new
							{
								tp7 = tp7,
								origdestList = origdestList
							})
						.SelectMany(
							tp8 => tp8.origdestList
								.DefaultIfEmpty(),
							(tp8, origdest) => new
							{
								tp8 = tp8,
								origdest = origdest
							})
						.GroupJoin(
							db.GetTable<MCC.WMS.ServiceInterfaces.DTO.WmsLoadCarrierDTO>()
								.Union(
									db.GetTable<MCC.WMS.ServiceInterfaces.DTO.WmsLoadCarrierDTO>()
										.TableName(
											"WMS_ResourceA")
										.TableName(
											"WMS_ResourceA")),
							tp9 => tp9.tp8.tp7.tp6.tp5.tp4.tp3.tp2.tp1.tp0.g.ResourceID,
							res => res.Id,
							(tp9, reslist) => new
							{
								tp9 = tp9,
								reslist = reslist
							})
						.SelectMany(
							tp10 => tp10.reslist
								.DefaultIfEmpty(),
							(tp10, res) => new
							{
								tp10 = tp10,
								res = res
							})
						.GroupJoin(
							db.GetTable<MCC.WMS.ServiceInterfaces.DTO.OutfeedTransportOrderDTO>()
								.Union(
									db.GetTable<MCC.WMS.ServiceInterfaces.DTO.OutfeedTransportOrderDTO>()
										.TableName(
											"WMS_OutfeedTransportOrderA")
										.TableName(
											"WMS_OutfeedTransportOrderA")),
							tp11 => tp11.tp10.tp9.tp8.tp7.tp6.tp5.tp4.tp3.tp2.tp1.tp0.g.OutfeedTransportOrderID,
							outfeed1 => (Guid?)outfeed1.Id,
							(tp11, outfeed1List) => new
							{
								tp11 = tp11,
								outfeed1List = outfeed1List
							})
						.SelectMany(
							tp12 => tp12.outfeed1List
								.DefaultIfEmpty(),
							(tp12, outfeed) => new MCC.WMS.ServiceInterfaces.DTO.WmsGlobalTaskCombinedDTO()
							{
								GlobalTask = tp12.tp11.tp10.tp9.tp8.tp7.tp6.tp5.tp4.tp3.tp2.tp1.tp0.g,
								LoadCarrier = tp12.tp11.res,
								Source = tp12.tp11.tp10.tp9.tp8.tp7.tp6.tp5.tp4.tp3.tp2.tp1.source,
								SourceShelf = tp12.tp11.tp10.tp9.tp8.tp7.tp6.tp5.tp4.tp3.sourceShelf,
								Destination = tp12.tp11.tp10.tp9.tp8.tp7.tp6.tp5.dest,
								DestinationShelf = tp12.tp11.tp10.tp9.tp8.tp7.destShelf,
								OriginDestination = tp12.tp11.tp10.tp9.origdest,
								OutfeedTransportOrder = outfeed
							});

					var str = query.ToString();
					Console.WriteLine(str);
				}
			}
		}
	}

}
