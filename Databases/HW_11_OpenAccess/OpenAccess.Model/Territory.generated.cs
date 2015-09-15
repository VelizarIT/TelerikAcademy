#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Data.Common;
using System.Collections.Generic;
using Telerik.OpenAccess;
using Telerik.OpenAccess.Metadata;
using Telerik.OpenAccess.Data.Common;
using Telerik.OpenAccess.Metadata.Fluent;
using Telerik.OpenAccess.Metadata.Fluent.Advanced;
using Framework;
using OpenAccess.Model;


namespace OpenAccess.Model	
{
	public partial class Territory : NotificationObject
	{
		private string _territoryID;
		public virtual string TerritoryID 
		{ 
		    get
		    {
		        return this._territoryID;
		    }
		    set
		    {
				if(this.TerritoryID == value)
				{
					return;
				}
		
		        this._territoryID = value;
				this.RaisePropertyChanged("TerritoryID");
		    }
		}
		
		private string _territoryDescription;
		public virtual string TerritoryDescription 
		{ 
		    get
		    {
		        return this._territoryDescription;
		    }
		    set
		    {
				if(this.TerritoryDescription == value)
				{
					return;
				}
		
		        this._territoryDescription = value;
				this.RaisePropertyChanged("TerritoryDescription");
		    }
		}
		
		private int _regionID;
		public virtual int RegionID 
		{ 
		    get
		    {
		        return this._regionID;
		    }
		    set
		    {
				if(this.RegionID == value)
				{
					return;
				}
		
		        this._regionID = value;
				this.RaisePropertyChanged("RegionID");
		    }
		}
		
		private Region _region;
		public virtual Region Region 
		{ 
		    get
		    {
		        return this._region;
		    }
		    set
		    {
				if(this.Region == value)
				{
					return;
				}
		
		        this._region = value;
				this.RaisePropertyChanged("Region");
		    }
		}
		
		private IList<Employee> _employees = new List<Employee>();
		public virtual IList<Employee> Employees 
		{ 
		    get
		    {
		        return this._employees;
		    }
		}
		
	}
}
