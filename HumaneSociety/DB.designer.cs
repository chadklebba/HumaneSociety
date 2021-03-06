﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HumaneSociety
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="HumaneSociety")]
	public partial class DBDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertAnimal(Animal instance);
    partial void UpdateAnimal(Animal instance);
    partial void DeleteAnimal(Animal instance);
    partial void InsertAdopter(Adopter instance);
    partial void UpdateAdopter(Adopter instance);
    partial void DeleteAdopter(Adopter instance);
    #endregion
		
		public DBDataContext() : 
				base(global::HumaneSociety.Properties.Settings.Default.HumaneSocietyConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DBDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DBDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DBDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DBDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Animal> Animals
		{
			get
			{
				return this.GetTable<Animal>();
			}
		}
		
		public System.Data.Linq.Table<Adopter> Adopters
		{
			get
			{
				return this.GetTable<Adopter>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Animal")]
	public partial class Animal : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _animalClass;
		
		private string _type;
		
		private System.Nullable<int> _roomNumber;
		
		private bool _adoptedStatus;
		
		private System.Nullable<int> _cost;
		
		private bool _hasShots;
		
		private string _foodNeeded;
		
		private int _id;
		
		private string _name;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnanimalClassChanging(string value);
    partial void OnanimalClassChanged();
    partial void OntypeChanging(string value);
    partial void OntypeChanged();
    partial void OnroomNumberChanging(System.Nullable<int> value);
    partial void OnroomNumberChanged();
    partial void OnadoptedStatusChanging(bool value);
    partial void OnadoptedStatusChanged();
    partial void OncostChanging(System.Nullable<int> value);
    partial void OncostChanged();
    partial void OnhasShotsChanging(bool value);
    partial void OnhasShotsChanged();
    partial void OnfoodNeededChanging(string value);
    partial void OnfoodNeededChanged();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    #endregion
		
		public Animal()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_animalClass", DbType="VarChar(50)")]
		public string animalClass
		{
			get
			{
				return this._animalClass;
			}
			set
			{
				if ((this._animalClass != value))
				{
					this.OnanimalClassChanging(value);
					this.SendPropertyChanging();
					this._animalClass = value;
					this.SendPropertyChanged("animalClass");
					this.OnanimalClassChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_type", DbType="VarChar(50)")]
		public string type
		{
			get
			{
				return this._type;
			}
			set
			{
				if ((this._type != value))
				{
					this.OntypeChanging(value);
					this.SendPropertyChanging();
					this._type = value;
					this.SendPropertyChanged("type");
					this.OntypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_roomNumber", DbType="Int")]
		public System.Nullable<int> roomNumber
		{
			get
			{
				return this._roomNumber;
			}
			set
			{
				if ((this._roomNumber != value))
				{
					this.OnroomNumberChanging(value);
					this.SendPropertyChanging();
					this._roomNumber = value;
					this.SendPropertyChanged("roomNumber");
					this.OnroomNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_adoptedStatus", DbType="Bit NOT NULL")]
		public bool adoptedStatus
		{
			get
			{
				return this._adoptedStatus;
			}
			set
			{
				if ((this._adoptedStatus != value))
				{
					this.OnadoptedStatusChanging(value);
					this.SendPropertyChanging();
					this._adoptedStatus = value;
					this.SendPropertyChanged("adoptedStatus");
					this.OnadoptedStatusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_cost", DbType="Int")]
		public System.Nullable<int> cost
		{
			get
			{
				return this._cost;
			}
			set
			{
				if ((this._cost != value))
				{
					this.OncostChanging(value);
					this.SendPropertyChanging();
					this._cost = value;
					this.SendPropertyChanged("cost");
					this.OncostChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_hasShots", DbType="Bit NOT NULL")]
		public bool hasShots
		{
			get
			{
				return this._hasShots;
			}
			set
			{
				if ((this._hasShots != value))
				{
					this.OnhasShotsChanging(value);
					this.SendPropertyChanging();
					this._hasShots = value;
					this.SendPropertyChanged("hasShots");
					this.OnhasShotsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_foodNeeded", DbType="VarChar(50)")]
		public string foodNeeded
		{
			get
			{
				return this._foodNeeded;
			}
			set
			{
				if ((this._foodNeeded != value))
				{
					this.OnfoodNeededChanging(value);
					this.SendPropertyChanging();
					this._foodNeeded = value;
					this.SendPropertyChanged("foodNeeded");
					this.OnfoodNeededChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string name
		{
			get
			{
				return this._name;
			}
			set
			{
				if ((this._name != value))
				{
					this.OnnameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("name");
					this.OnnameChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Adopter")]
	public partial class Adopter : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _adpoterID;
		
		private string _firstName;
		
		private string _lastName;
		
		private string _address;
		
		private string _phone;
		
		private string _email;
		
		private System.Nullable<bool> _otherPets;
		
		private System.Nullable<bool> _kids;
		
		private string _housing;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnadpoterIDChanging(int value);
    partial void OnadpoterIDChanged();
    partial void OnfirstNameChanging(string value);
    partial void OnfirstNameChanged();
    partial void OnlastNameChanging(string value);
    partial void OnlastNameChanged();
    partial void OnaddressChanging(string value);
    partial void OnaddressChanged();
    partial void OnphoneChanging(string value);
    partial void OnphoneChanged();
    partial void OnemailChanging(string value);
    partial void OnemailChanged();
    partial void OnotherPetsChanging(System.Nullable<bool> value);
    partial void OnotherPetsChanged();
    partial void OnkidsChanging(System.Nullable<bool> value);
    partial void OnkidsChanged();
    partial void OnhousingChanging(string value);
    partial void OnhousingChanged();
    #endregion
		
		public Adopter()
		{
            
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_adpoterID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int adpoterID
		{
			get
			{
				return this._adpoterID;
			}
			set
			{
				if ((this._adpoterID != value))
				{
					this.OnadpoterIDChanging(value);
					this.SendPropertyChanging();
					this._adpoterID = value;
					this.SendPropertyChanged("adpoterID");
					this.OnadpoterIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_firstName", DbType="VarChar(50)")]
		public string firstName
		{
			get
			{
				return this._firstName;
			}
			set
			{
				if ((this._firstName != value))
				{
					this.OnfirstNameChanging(value);
					this.SendPropertyChanging();
					this._firstName = value;
					this.SendPropertyChanged("firstName");
					this.OnfirstNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_lastName", DbType="VarChar(50)")]
		public string lastName
		{
			get
			{
				return this._lastName;
			}
			set
			{
				if ((this._lastName != value))
				{
					this.OnlastNameChanging(value);
					this.SendPropertyChanging();
					this._lastName = value;
					this.SendPropertyChanged("lastName");
					this.OnlastNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_address", DbType="NVarChar(50)")]
		public string address
		{
			get
			{
				return this._address;
			}
			set
			{
				if ((this._address != value))
				{
					this.OnaddressChanging(value);
					this.SendPropertyChanging();
					this._address = value;
					this.SendPropertyChanged("address");
					this.OnaddressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_phone", DbType="VarChar(50)")]
		public string phone
		{
			get
			{
				return this._phone;
			}
			set
			{
				if ((this._phone != value))
				{
					this.OnphoneChanging(value);
					this.SendPropertyChanging();
					this._phone = value;
					this.SendPropertyChanged("phone");
					this.OnphoneChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_email", DbType="VarChar(50)")]
		public string email
		{
			get
			{
				return this._email;
			}
			set
			{
				if ((this._email != value))
				{
					this.OnemailChanging(value);
					this.SendPropertyChanging();
					this._email = value;
					this.SendPropertyChanged("email");
					this.OnemailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_otherPets", DbType="Bit")]
		public System.Nullable<bool> otherPets
		{
			get
			{
				return this._otherPets;
			}
			set
			{
				if ((this._otherPets != value))
				{
					this.OnotherPetsChanging(value);
					this.SendPropertyChanging();
					this._otherPets = value;
					this.SendPropertyChanged("otherPets");
					this.OnotherPetsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_kids", DbType="Bit")]
		public System.Nullable<bool> kids
		{
			get
			{
				return this._kids;
			}
			set
			{
				if ((this._kids != value))
				{
					this.OnkidsChanging(value);
					this.SendPropertyChanging();
					this._kids = value;
					this.SendPropertyChanged("kids");
					this.OnkidsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_housing", DbType="VarChar(50)")]
		public string housing
		{
			get
			{
				return this._housing;
			}
			set
			{
				if ((this._housing != value))
				{
					this.OnhousingChanging(value);
					this.SendPropertyChanging();
					this._housing = value;
					this.SendPropertyChanged("housing");
					this.OnhousingChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591
