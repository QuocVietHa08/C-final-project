#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BaiTapLon
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="QuanLyDocGia_DoiTuong")]
	public partial class dbDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertDocGia(DocGia instance);
    partial void UpdateDocGia(DocGia instance);
    partial void DeleteDocGia(DocGia instance);
    partial void InsertDoiTuong(DoiTuong instance);
    partial void UpdateDoiTuong(DoiTuong instance);
    partial void DeleteDoiTuong(DoiTuong instance);
    partial void InsertTaiKhoan(TaiKhoan instance);
    partial void UpdateTaiKhoan(TaiKhoan instance);
    partial void DeleteTaiKhoan(TaiKhoan instance);
    #endregion
		
		public dbDataContext() : 
				base(global::BaiTapLon.Properties.Settings.Default.QuanLyDocGia_DoiTuongConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public dbDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public dbDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public dbDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public dbDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<DocGia> DocGias
		{
			get
			{
				return this.GetTable<DocGia>();
			}
		}
		
		public System.Data.Linq.Table<DoiTuong> DoiTuongs
		{
			get
			{
				return this.GetTable<DoiTuong>();
			}
		}
		
		public System.Data.Linq.Table<TaiKhoan> TaiKhoans
		{
			get
			{
				return this.GetTable<TaiKhoan>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.DocGia")]
	public partial class DocGia : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MaDocGia;
		
		private string _HoTen;
		
		private string _GioiTinh;
		
		private string _NgaySinh;
		
		private string _MaDoiTuong;
		
		private string _NgayCap;
		
		private string _NgayHetHan;
		
		private EntityRef<DoiTuong> _DoiTuong;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaDocGiaChanging(string value);
    partial void OnMaDocGiaChanged();
    partial void OnHoTenChanging(string value);
    partial void OnHoTenChanged();
    partial void OnGioiTinhChanging(string value);
    partial void OnGioiTinhChanged();
    partial void OnNgaySinhChanging(string value);
    partial void OnNgaySinhChanged();
    partial void OnMaDoiTuongChanging(string value);
    partial void OnMaDoiTuongChanged();
    partial void OnNgayCapChanging(string value);
    partial void OnNgayCapChanged();
    partial void OnNgayHetHanChanging(string value);
    partial void OnNgayHetHanChanged();
    #endregion
		
		public DocGia()
		{
			this._DoiTuong = default(EntityRef<DoiTuong>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaDocGia", DbType="NVarChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MaDocGia
		{
			get
			{
				return this._MaDocGia;
			}
			set
			{
				if ((this._MaDocGia != value))
				{
					this.OnMaDocGiaChanging(value);
					this.SendPropertyChanging();
					this._MaDocGia = value;
					this.SendPropertyChanged("MaDocGia");
					this.OnMaDocGiaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HoTen", DbType="NVarChar(30)")]
		public string HoTen
		{
			get
			{
				return this._HoTen;
			}
			set
			{
				if ((this._HoTen != value))
				{
					this.OnHoTenChanging(value);
					this.SendPropertyChanging();
					this._HoTen = value;
					this.SendPropertyChanged("HoTen");
					this.OnHoTenChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GioiTinh", DbType="NVarChar(10)")]
		public string GioiTinh
		{
			get
			{
				return this._GioiTinh;
			}
			set
			{
				if ((this._GioiTinh != value))
				{
					this.OnGioiTinhChanging(value);
					this.SendPropertyChanging();
					this._GioiTinh = value;
					this.SendPropertyChanged("GioiTinh");
					this.OnGioiTinhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgaySinh", DbType="NVarChar(10)")]
		public string NgaySinh
		{
			get
			{
				return this._NgaySinh;
			}
			set
			{
				if ((this._NgaySinh != value))
				{
					this.OnNgaySinhChanging(value);
					this.SendPropertyChanging();
					this._NgaySinh = value;
					this.SendPropertyChanged("NgaySinh");
					this.OnNgaySinhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaDoiTuong", DbType="NVarChar(10)")]
		public string MaDoiTuong
		{
			get
			{
				return this._MaDoiTuong;
			}
			set
			{
				if ((this._MaDoiTuong != value))
				{
					if (this._DoiTuong.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaDoiTuongChanging(value);
					this.SendPropertyChanging();
					this._MaDoiTuong = value;
					this.SendPropertyChanged("MaDoiTuong");
					this.OnMaDoiTuongChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgayCap", DbType="NVarChar(10)")]
		public string NgayCap
		{
			get
			{
				return this._NgayCap;
			}
			set
			{
				if ((this._NgayCap != value))
				{
					this.OnNgayCapChanging(value);
					this.SendPropertyChanging();
					this._NgayCap = value;
					this.SendPropertyChanged("NgayCap");
					this.OnNgayCapChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgayHetHan", DbType="NVarChar(10)")]
		public string NgayHetHan
		{
			get
			{
				return this._NgayHetHan;
			}
			set
			{
				if ((this._NgayHetHan != value))
				{
					this.OnNgayHetHanChanging(value);
					this.SendPropertyChanging();
					this._NgayHetHan = value;
					this.SendPropertyChanged("NgayHetHan");
					this.OnNgayHetHanChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="DoiTuong_DocGia", Storage="_DoiTuong", ThisKey="MaDoiTuong", OtherKey="MaDoiTuong", IsForeignKey=true)]
		public DoiTuong DoiTuong
		{
			get
			{
				return this._DoiTuong.Entity;
			}
			set
			{
				DoiTuong previousValue = this._DoiTuong.Entity;
				if (((previousValue != value) 
							|| (this._DoiTuong.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._DoiTuong.Entity = null;
						previousValue.DocGias.Remove(this);
					}
					this._DoiTuong.Entity = value;
					if ((value != null))
					{
						value.DocGias.Add(this);
						this._MaDoiTuong = value.MaDoiTuong;
					}
					else
					{
						this._MaDoiTuong = default(string);
					}
					this.SendPropertyChanged("DoiTuong");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.DoiTuong")]
	public partial class DoiTuong : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MaDoiTuong;
		
		private string _TenDoiTuong;
		
		private EntitySet<DocGia> _DocGias;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaDoiTuongChanging(string value);
    partial void OnMaDoiTuongChanged();
    partial void OnTenDoiTuongChanging(string value);
    partial void OnTenDoiTuongChanged();
    #endregion
		
		public DoiTuong()
		{
			this._DocGias = new EntitySet<DocGia>(new Action<DocGia>(this.attach_DocGias), new Action<DocGia>(this.detach_DocGias));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaDoiTuong", DbType="NVarChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MaDoiTuong
		{
			get
			{
				return this._MaDoiTuong;
			}
			set
			{
				if ((this._MaDoiTuong != value))
				{
					this.OnMaDoiTuongChanging(value);
					this.SendPropertyChanging();
					this._MaDoiTuong = value;
					this.SendPropertyChanged("MaDoiTuong");
					this.OnMaDoiTuongChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenDoiTuong", DbType="NVarChar(30)")]
		public string TenDoiTuong
		{
			get
			{
				return this._TenDoiTuong;
			}
			set
			{
				if ((this._TenDoiTuong != value))
				{
					this.OnTenDoiTuongChanging(value);
					this.SendPropertyChanging();
					this._TenDoiTuong = value;
					this.SendPropertyChanged("TenDoiTuong");
					this.OnTenDoiTuongChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="DoiTuong_DocGia", Storage="_DocGias", ThisKey="MaDoiTuong", OtherKey="MaDoiTuong")]
		public EntitySet<DocGia> DocGias
		{
			get
			{
				return this._DocGias;
			}
			set
			{
				this._DocGias.Assign(value);
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
		
		private void attach_DocGias(DocGia entity)
		{
			this.SendPropertyChanging();
			entity.DoiTuong = this;
		}
		
		private void detach_DocGias(DocGia entity)
		{
			this.SendPropertyChanging();
			entity.DoiTuong = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TaiKhoan")]
	public partial class TaiKhoan : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _TaiKhoanId;
		
		private string _TenTaiKhoan;
		
		private string _MatKhauTaiKhoan;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnTaiKhoanIdChanging(string value);
    partial void OnTaiKhoanIdChanged();
    partial void OnTenTaiKhoanChanging(string value);
    partial void OnTenTaiKhoanChanged();
    partial void OnMatKhauTaiKhoanChanging(string value);
    partial void OnMatKhauTaiKhoanChanged();
    #endregion
		
		public TaiKhoan()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TaiKhoanId", DbType="NVarChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string TaiKhoanId
		{
			get
			{
				return this._TaiKhoanId;
			}
			set
			{
				if ((this._TaiKhoanId != value))
				{
					this.OnTaiKhoanIdChanging(value);
					this.SendPropertyChanging();
					this._TaiKhoanId = value;
					this.SendPropertyChanged("TaiKhoanId");
					this.OnTaiKhoanIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenTaiKhoan", DbType="NVarChar(30)")]
		public string TenTaiKhoan
		{
			get
			{
				return this._TenTaiKhoan;
			}
			set
			{
				if ((this._TenTaiKhoan != value))
				{
					this.OnTenTaiKhoanChanging(value);
					this.SendPropertyChanging();
					this._TenTaiKhoan = value;
					this.SendPropertyChanged("TenTaiKhoan");
					this.OnTenTaiKhoanChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MatKhauTaiKhoan", DbType="NVarChar(30)")]
		public string MatKhauTaiKhoan
		{
			get
			{
				return this._MatKhauTaiKhoan;
			}
			set
			{
				if ((this._MatKhauTaiKhoan != value))
				{
					this.OnMatKhauTaiKhoanChanging(value);
					this.SendPropertyChanging();
					this._MatKhauTaiKhoan = value;
					this.SendPropertyChanged("MatKhauTaiKhoan");
					this.OnMatKhauTaiKhoanChanged();
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
