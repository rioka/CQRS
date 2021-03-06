﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

#region Copyright
// -----------------------------------------------------------------------
// <copyright company="cdmdotnet Limited">
//     Copyright cdmdotnet Limited. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------
#endregion
using Cqrs.Domain;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Cqrs.Repositories;
using MyCompany.MyProject.Domain.Factories;
using MyCompany.MyProject.Domain.Inventory.Repositories.Queries.Strategies;

namespace MyCompany.MyProject.Domain.Inventory.Repositories
{
	[GeneratedCode("CQRS UML Code Generator", "1.500.523.412")]
	public partial class InventoryItemRepository : Repository<InventoryItemQueryStrategy, InventoryItemQueryStrategyBuilder, Entities.InventoryItemEntity>, IInventoryItemRepository
	{
		public InventoryItemRepository(IDomainDataStoreFactory dataStoreFactory, InventoryItemQueryStrategyBuilder inventoryItemQueryBuilder)
			: base(dataStoreFactory.GetInventoryItemDataStore, inventoryItemQueryBuilder)
		{
		}
	}
}
