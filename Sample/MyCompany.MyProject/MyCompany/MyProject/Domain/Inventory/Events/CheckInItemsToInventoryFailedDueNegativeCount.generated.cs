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
using Cqrs.Events;

namespace MyCompany.MyProject.Domain.Inventory.Events
{
	[GeneratedCode("CQRS UML Code Generator", "1.500.480.367")]
	public  partial class CheckInItemsToInventoryFailedDueNegativeCount : IEvent<System.Guid>
	{
		#region Implementation of IEvent

		[DataMember]
		public Guid Id
		{
			get
			{
				return Rsn;
			}
			set
			{
				Rsn = value;
			}
		}

		[DataMember]
		public int Version { get; set; }

		[DataMember]
		public DateTimeOffset TimeStamp { get; set; }

		#endregion

		#region Implementation of IMessageWithAuthenticationToken<System.Guid>

		[DataMember]
		public System.Guid AuthenticationToken { get; set; }

		#endregion

		#region Implementation of IMessage

		[DataMember]
		public Guid CorrolationId { get; set; }

		#endregion

		[DataMember]
		public Guid Rsn { get; set; }

		[DataMember]
		public long Count { get; private set; }


		public CheckInItemsToInventoryFailedDueNegativeCount(Guid rsn, long count)
		{
			Rsn = rsn;
			Count = count;
		}
	}
}
