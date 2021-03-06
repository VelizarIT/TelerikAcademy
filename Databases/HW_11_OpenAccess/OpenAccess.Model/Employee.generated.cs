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
	public partial class Employee : NotificationObject
	{
		private int _employeeID;
		public virtual int EmployeeID 
		{ 
		    get
		    {
		        return this._employeeID;
		    }
		    set
		    {
				if(this.EmployeeID == value)
				{
					return;
				}
		
		        this._employeeID = value;
				this.RaisePropertyChanged("EmployeeID");
		    }
		}
		
		private string _lastName;
		public virtual string LastName 
		{ 
		    get
		    {
		        return this._lastName;
		    }
		    set
		    {
				if(this.LastName == value)
				{
					return;
				}
		
		        this._lastName = value;
				this.RaisePropertyChanged("LastName");
		    }
		}
		
		private string _firstName;
		public virtual string FirstName 
		{ 
		    get
		    {
		        return this._firstName;
		    }
		    set
		    {
				if(this.FirstName == value)
				{
					return;
				}
		
		        this._firstName = value;
				this.RaisePropertyChanged("FirstName");
		    }
		}
		
		private string _title;
		public virtual string Title 
		{ 
		    get
		    {
		        return this._title;
		    }
		    set
		    {
				if(this.Title == value)
				{
					return;
				}
		
		        this._title = value;
				this.RaisePropertyChanged("Title");
		    }
		}
		
		private string _titleOfCourtesy;
		public virtual string TitleOfCourtesy 
		{ 
		    get
		    {
		        return this._titleOfCourtesy;
		    }
		    set
		    {
				if(this.TitleOfCourtesy == value)
				{
					return;
				}
		
		        this._titleOfCourtesy = value;
				this.RaisePropertyChanged("TitleOfCourtesy");
		    }
		}
		
		private DateTime? _birthDate;
		public virtual DateTime? BirthDate 
		{ 
		    get
		    {
		        return this._birthDate;
		    }
		    set
		    {
				if(this.BirthDate == value)
				{
					return;
				}
		
		        this._birthDate = value;
				this.RaisePropertyChanged("BirthDate");
		    }
		}
		
		private DateTime? _hireDate;
		public virtual DateTime? HireDate 
		{ 
		    get
		    {
		        return this._hireDate;
		    }
		    set
		    {
				if(this.HireDate == value)
				{
					return;
				}
		
		        this._hireDate = value;
				this.RaisePropertyChanged("HireDate");
		    }
		}
		
		private string _address;
		public virtual string Address 
		{ 
		    get
		    {
		        return this._address;
		    }
		    set
		    {
				if(this.Address == value)
				{
					return;
				}
		
		        this._address = value;
				this.RaisePropertyChanged("Address");
		    }
		}
		
		private string _city;
		public virtual string City 
		{ 
		    get
		    {
		        return this._city;
		    }
		    set
		    {
				if(this.City == value)
				{
					return;
				}
		
		        this._city = value;
				this.RaisePropertyChanged("City");
		    }
		}
		
		private string _region;
		public virtual string Region 
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
		
		private string _postalCode;
		public virtual string PostalCode 
		{ 
		    get
		    {
		        return this._postalCode;
		    }
		    set
		    {
				if(this.PostalCode == value)
				{
					return;
				}
		
		        this._postalCode = value;
				this.RaisePropertyChanged("PostalCode");
		    }
		}
		
		private string _country;
		public virtual string Country 
		{ 
		    get
		    {
		        return this._country;
		    }
		    set
		    {
				if(this.Country == value)
				{
					return;
				}
		
		        this._country = value;
				this.RaisePropertyChanged("Country");
		    }
		}
		
		private string _homePhone;
		public virtual string HomePhone 
		{ 
		    get
		    {
		        return this._homePhone;
		    }
		    set
		    {
				if(this.HomePhone == value)
				{
					return;
				}
		
		        this._homePhone = value;
				this.RaisePropertyChanged("HomePhone");
		    }
		}
		
		private string _extension;
		public virtual string Extension 
		{ 
		    get
		    {
		        return this._extension;
		    }
		    set
		    {
				if(this.Extension == value)
				{
					return;
				}
		
		        this._extension = value;
				this.RaisePropertyChanged("Extension");
		    }
		}
		
		private byte[] _photo;
		public virtual byte[] Photo 
		{ 
		    get
		    {
		        return this._photo;
		    }
		    set
		    {
				if(this.Photo == value)
				{
					return;
				}
		
		        this._photo = value;
				this.RaisePropertyChanged("Photo");
		    }
		}
		
		private string _notes;
		public virtual string Notes 
		{ 
		    get
		    {
		        return this._notes;
		    }
		    set
		    {
				if(this.Notes == value)
				{
					return;
				}
		
		        this._notes = value;
				this.RaisePropertyChanged("Notes");
		    }
		}
		
		private int? _reportsTo;
		public virtual int? ReportsTo 
		{ 
		    get
		    {
		        return this._reportsTo;
		    }
		    set
		    {
				if(this.ReportsTo == value)
				{
					return;
				}
		
		        this._reportsTo = value;
				this.RaisePropertyChanged("ReportsTo");
		    }
		}
		
		private string _photoPath;
		public virtual string PhotoPath 
		{ 
		    get
		    {
		        return this._photoPath;
		    }
		    set
		    {
				if(this.PhotoPath == value)
				{
					return;
				}
		
		        this._photoPath = value;
				this.RaisePropertyChanged("PhotoPath");
		    }
		}
		
		private Employee _employee1;
		public virtual Employee Employee1 
		{ 
		    get
		    {
		        return this._employee1;
		    }
		    set
		    {
				if(this.Employee1 == value)
				{
					return;
				}
		
		        this._employee1 = value;
				this.RaisePropertyChanged("Employee1");
		    }
		}
		
		private IList<Territory> _territories = new List<Territory>();
		public virtual IList<Territory> Territories 
		{ 
		    get
		    {
		        return this._territories;
		    }
		}
		
		private IList<Order> _orders = new List<Order>();
		public virtual IList<Order> Orders 
		{ 
		    get
		    {
		        return this._orders;
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
