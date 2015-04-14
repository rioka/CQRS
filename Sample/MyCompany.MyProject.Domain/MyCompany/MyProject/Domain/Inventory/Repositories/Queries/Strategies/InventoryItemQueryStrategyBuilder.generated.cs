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
using Cqrs.Configuration;
using Cqrs.Authentication;
using Cqrs.Repositories.Queries;
using MyCompany.MyProject.Domain.Factories;

namespace MyCompany.MyProject.Domain.Inventory.Repositories.Queries.Strategies
{
	[GeneratedCode("CQRS UML Code Generator", "1.500.480.367")]
	public partial class InventoryItemQueryStrategyBuilder : QueryBuilder<InventoryItemQueryStrategy, Entities.InventoryItemEntity>, IInventoryItemQueryStrategyBuilder
	{
		public InventoryItemQueryStrategyBuilder(IDomainDataStoreFactory dataStoreFactory, IDependencyResolver dependencyResolver)
			: base(dataStoreFactory.GetInventoryItemDataStore(), dependencyResolver)
		{
		}

		#region Overrides of QueryBuilder<InventoryItemQueryStrategy,Entities.InventoryItemEntity>

		protected override IQueryable<Entities.InventoryItemEntity> GeneratePredicate(QueryPredicate queryPredicate, IQueryable<Entities.InventoryItemEntity> leftHandQueryable = null)
		{
			InventoryItemQueryStrategy queryStrategy = GetNullQueryStrategy();
			SortedSet<QueryParameter> parameters = queryPredicate.Parameters;

			IQueryable<Entities.InventoryItemEntity> resultingQueryable = null;
			if (queryPredicate.Name == GetFunctionName<Guid>(queryStrategy.WithRsn))
			{
				OnGeneratePredicateWithRsn(queryPredicate, leftHandQueryable, parameters, ref resultingQueryable);
				GeneratePredicateWithRsn(parameters, leftHandQueryable, ref resultingQueryable);
				OnGeneratedPredicateWithRsn(queryPredicate, leftHandQueryable, parameters, ref resultingQueryable);
				return resultingQueryable;
			}

			resultingQueryable
				= GeneratePredicateWithPermissionScopeAny<ISingleSignOnToken>(queryPredicate, leftHandQueryable)
				?? GeneratePredicateWithPermissionScopeUser<ISingleSignOnToken>(queryPredicate, leftHandQueryable)
				?? GeneratePredicateWithPermissionScopeCompany<ISingleSignOnToken>(queryPredicate, leftHandQueryable)
				?? GeneratePredicateWithPermissionScopeCompanyAndUser<ISingleSignOnToken>(queryPredicate, leftHandQueryable);

			if (resultingQueryable != null)
				return resultingQueryable;

			throw new InvalidOperationException("No known predicate could be generated.");
		}

		#endregion

		partial void OnGeneratePredicateWithRsn(QueryPredicate queryPredicate, IQueryable<Entities.InventoryItemEntity> leftHandQueryable, SortedSet<QueryParameter> parameters, ref IQueryable<Entities.InventoryItemEntity> resultingQueryable);

		partial void GeneratePredicateWithRsn(SortedSet<QueryParameter> parameters, IQueryable<Entities.InventoryItemEntity> leftHandQueryable, ref IQueryable<Entities.InventoryItemEntity> resultingQueryable);

		partial void OnGeneratedPredicateWithRsn(QueryPredicate queryPredicate, IQueryable<Entities.InventoryItemEntity> leftHandQueryable, SortedSet<QueryParameter> parameters, ref IQueryable<Entities.InventoryItemEntity> resultingQueryable);


		protected override void ApplySorting(InventoryItemQueryStrategy queryStrategy, ref IQueryable<Entities.InventoryItemEntity> queryable)
		{
			var orderQueryable = (IOrderedQueryable<Entities.InventoryItemEntity>)queryable;

			int index = 0;
			foreach (Func<int, InventoryItemQueryStrategy> sortingMethod in queryStrategy.SortingList)
			{

			}
			queryable = orderQueryable;
		}

	}
}
