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

namespace Remote_Banking_System
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="MainServer")]
	public partial class RemoteBankDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertUser(User instance);
    partial void UpdateUser(User instance);
    partial void DeleteUser(User instance);
    partial void InsertAdmin(Admin instance);
    partial void UpdateAdmin(Admin instance);
    partial void DeleteAdmin(Admin instance);
    partial void InsertAccount(Account instance);
    partial void UpdateAccount(Account instance);
    partial void DeleteAccount(Account instance);
    partial void InsertBalance(Balance instance);
    partial void UpdateBalance(Balance instance);
    partial void DeleteBalance(Balance instance);
    #endregion
		
		public RemoteBankDataContext() : 
				base(global::Remote_Banking_System.Properties.Settings.Default.MainServerConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public RemoteBankDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public RemoteBankDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public RemoteBankDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public RemoteBankDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<User> Users
		{
			get
			{
				return this.GetTable<User>();
			}
		}
		
		public System.Data.Linq.Table<Admin> Admins
		{
			get
			{
				return this.GetTable<Admin>();
			}
		}
		
		public System.Data.Linq.Table<Account> Accounts
		{
			get
			{
				return this.GetTable<Account>();
			}
		}
		
		public System.Data.Linq.Table<Balance> Balances
		{
			get
			{
				return this.GetTable<Balance>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.[User]")]
	public partial class User : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _name;
		
		private string _phoneno;
		
		private string _address;
		
		private string _password;
		
		private string _gender;
		
		private string _accounttype;
		
		private EntitySet<Account> _Accounts;
		
		private EntitySet<Balance> _Balances;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    partial void OnphonenoChanging(string value);
    partial void OnphonenoChanged();
    partial void OnaddressChanging(string value);
    partial void OnaddressChanged();
    partial void OnpasswordChanging(string value);
    partial void OnpasswordChanged();
    partial void OngenderChanging(string value);
    partial void OngenderChanged();
    partial void OnaccounttypeChanging(string value);
    partial void OnaccounttypeChanged();
    #endregion
		
		public User()
		{
			this._Accounts = new EntitySet<Account>(new Action<Account>(this.attach_Accounts), new Action<Account>(this.detach_Accounts));
			this._Balances = new EntitySet<Balance>(new Action<Balance>(this.attach_Balances), new Action<Balance>(this.detach_Balances));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_phoneno", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string phoneno
		{
			get
			{
				return this._phoneno;
			}
			set
			{
				if ((this._phoneno != value))
				{
					this.OnphonenoChanging(value);
					this.SendPropertyChanging();
					this._phoneno = value;
					this.SendPropertyChanged("phoneno");
					this.OnphonenoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_address", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_password", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string password
		{
			get
			{
				return this._password;
			}
			set
			{
				if ((this._password != value))
				{
					this.OnpasswordChanging(value);
					this.SendPropertyChanging();
					this._password = value;
					this.SendPropertyChanged("password");
					this.OnpasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_gender", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string gender
		{
			get
			{
				return this._gender;
			}
			set
			{
				if ((this._gender != value))
				{
					this.OngenderChanging(value);
					this.SendPropertyChanging();
					this._gender = value;
					this.SendPropertyChanged("gender");
					this.OngenderChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_accounttype", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string accounttype
		{
			get
			{
				return this._accounttype;
			}
			set
			{
				if ((this._accounttype != value))
				{
					this.OnaccounttypeChanging(value);
					this.SendPropertyChanging();
					this._accounttype = value;
					this.SendPropertyChanged("accounttype");
					this.OnaccounttypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_Account", Storage="_Accounts", ThisKey="Id", OtherKey="AccountId")]
		public EntitySet<Account> Accounts
		{
			get
			{
				return this._Accounts;
			}
			set
			{
				this._Accounts.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_Balance", Storage="_Balances", ThisKey="Id", OtherKey="BalanceId")]
		public EntitySet<Balance> Balances
		{
			get
			{
				return this._Balances;
			}
			set
			{
				this._Balances.Assign(value);
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
		
		private void attach_Accounts(Account entity)
		{
			this.SendPropertyChanging();
			entity.User = this;
		}
		
		private void detach_Accounts(Account entity)
		{
			this.SendPropertyChanging();
			entity.User = null;
		}
		
		private void attach_Balances(Balance entity)
		{
			this.SendPropertyChanging();
			entity.User = this;
		}
		
		private void detach_Balances(Balance entity)
		{
			this.SendPropertyChanging();
			entity.User = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Admin")]
	public partial class Admin : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _AdminId;
		
		private string _Name;
		
		private string _Password;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnAdminIdChanging(int value);
    partial void OnAdminIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    #endregion
		
		public Admin()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AdminId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int AdminId
		{
			get
			{
				return this._AdminId;
			}
			set
			{
				if ((this._AdminId != value))
				{
					this.OnAdminIdChanging(value);
					this.SendPropertyChanging();
					this._AdminId = value;
					this.SendPropertyChanged("AdminId");
					this.OnAdminIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Password
		{
			get
			{
				return this._Password;
			}
			set
			{
				if ((this._Password != value))
				{
					this.OnPasswordChanging(value);
					this.SendPropertyChanging();
					this._Password = value;
					this.SendPropertyChanged("Password");
					this.OnPasswordChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Account")]
	public partial class Account : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _AccountId;
		
		private int _accountno;
		
		private string _Status;
		
		private EntityRef<User> _User;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnAccountIdChanging(int value);
    partial void OnAccountIdChanged();
    partial void OnaccountnoChanging(int value);
    partial void OnaccountnoChanged();
    partial void OnStatusChanging(string value);
    partial void OnStatusChanged();
    #endregion
		
		public Account()
		{
			this._User = default(EntityRef<User>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AccountId", DbType="Int NOT NULL")]
		public int AccountId
		{
			get
			{
				return this._AccountId;
			}
			set
			{
				if ((this._AccountId != value))
				{
					if (this._User.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnAccountIdChanging(value);
					this.SendPropertyChanging();
					this._AccountId = value;
					this.SendPropertyChanged("AccountId");
					this.OnAccountIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_accountno", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int accountno
		{
			get
			{
				return this._accountno;
			}
			set
			{
				if ((this._accountno != value))
				{
					this.OnaccountnoChanging(value);
					this.SendPropertyChanging();
					this._accountno = value;
					this.SendPropertyChanged("accountno");
					this.OnaccountnoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Status", DbType="VarChar(50)")]
		public string Status
		{
			get
			{
				return this._Status;
			}
			set
			{
				if ((this._Status != value))
				{
					this.OnStatusChanging(value);
					this.SendPropertyChanging();
					this._Status = value;
					this.SendPropertyChanged("Status");
					this.OnStatusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_Account", Storage="_User", ThisKey="AccountId", OtherKey="Id", IsForeignKey=true)]
		public User User
		{
			get
			{
				return this._User.Entity;
			}
			set
			{
				User previousValue = this._User.Entity;
				if (((previousValue != value) 
							|| (this._User.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._User.Entity = null;
						previousValue.Accounts.Remove(this);
					}
					this._User.Entity = value;
					if ((value != null))
					{
						value.Accounts.Add(this);
						this._AccountId = value.Id;
					}
					else
					{
						this._AccountId = default(int);
					}
					this.SendPropertyChanged("User");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Balance")]
	public partial class Balance : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _BalanceId;
		
		private int _Accno;
		
		private double _Account_Balance;
		
		private System.Nullable<double> _Loan;
		
		private EntityRef<User> _User;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnBalanceIdChanging(int value);
    partial void OnBalanceIdChanged();
    partial void OnAccnoChanging(int value);
    partial void OnAccnoChanged();
    partial void OnAccount_BalanceChanging(double value);
    partial void OnAccount_BalanceChanged();
    partial void OnLoanChanging(System.Nullable<double> value);
    partial void OnLoanChanged();
    #endregion
		
		public Balance()
		{
			this._User = default(EntityRef<User>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BalanceId", DbType="Int NOT NULL")]
		public int BalanceId
		{
			get
			{
				return this._BalanceId;
			}
			set
			{
				if ((this._BalanceId != value))
				{
					if (this._User.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnBalanceIdChanging(value);
					this.SendPropertyChanging();
					this._BalanceId = value;
					this.SendPropertyChanged("BalanceId");
					this.OnBalanceIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Accno", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Accno
		{
			get
			{
				return this._Accno;
			}
			set
			{
				if ((this._Accno != value))
				{
					this.OnAccnoChanging(value);
					this.SendPropertyChanging();
					this._Accno = value;
					this.SendPropertyChanged("Accno");
					this.OnAccnoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Account Balance]", Storage="_Account_Balance", DbType="Float NOT NULL")]
		public double Account_Balance
		{
			get
			{
				return this._Account_Balance;
			}
			set
			{
				if ((this._Account_Balance != value))
				{
					this.OnAccount_BalanceChanging(value);
					this.SendPropertyChanging();
					this._Account_Balance = value;
					this.SendPropertyChanged("Account_Balance");
					this.OnAccount_BalanceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Loan", DbType="Float")]
		public System.Nullable<double> Loan
		{
			get
			{
				return this._Loan;
			}
			set
			{
				if ((this._Loan != value))
				{
					this.OnLoanChanging(value);
					this.SendPropertyChanging();
					this._Loan = value;
					this.SendPropertyChanged("Loan");
					this.OnLoanChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_Balance", Storage="_User", ThisKey="BalanceId", OtherKey="Id", IsForeignKey=true)]
		public User User
		{
			get
			{
				return this._User.Entity;
			}
			set
			{
				User previousValue = this._User.Entity;
				if (((previousValue != value) 
							|| (this._User.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._User.Entity = null;
						previousValue.Balances.Remove(this);
					}
					this._User.Entity = value;
					if ((value != null))
					{
						value.Balances.Add(this);
						this._BalanceId = value.Id;
					}
					else
					{
						this._BalanceId = default(int);
					}
					this.SendPropertyChanged("User");
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