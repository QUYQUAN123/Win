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

namespace QLNganHang
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="QLNganHang")]
	public partial class DataQLNganHangDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertSoTietKiem(SoTietKiem instance);
    partial void UpdateSoTietKiem(SoTietKiem instance);
    partial void DeleteSoTietKiem(SoTietKiem instance);
    partial void InsertTaiKhoan(TaiKhoan instance);
    partial void UpdateTaiKhoan(TaiKhoan instance);
    partial void DeleteTaiKhoan(TaiKhoan instance);
    partial void InsertTinDung(TinDung instance);
    partial void UpdateTinDung(TinDung instance);
    partial void DeleteTinDung(TinDung instance);
    #endregion
		
		public DataQLNganHangDataContext() : 
				base(global::QLNganHang.Properties.Settings.Default.QLNganHangConnectionString1, mappingSource)
		{
			OnCreated();
		}
		
		public DataQLNganHangDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataQLNganHangDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataQLNganHangDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataQLNganHangDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<SoTietKiem> SoTietKiems
		{
			get
			{
				return this.GetTable<SoTietKiem>();
			}
		}
		
		public System.Data.Linq.Table<TaiKhoan> TaiKhoans
		{
			get
			{
				return this.GetTable<TaiKhoan>();
			}
		}
		
		public System.Data.Linq.Table<TinDung> TinDungs
		{
			get
			{
				return this.GetTable<TinDung>();
			}
		}
		
		public System.Data.Linq.Table<LaiXuat> LaiXuats
		{
			get
			{
				return this.GetTable<LaiXuat>();
			}
		}
		
		public System.Data.Linq.Table<View_KhachHang> View_KhachHangs
		{
			get
			{
				return this.GetTable<View_KhachHang>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.SoTietKiem")]
	public partial class SoTietKiem : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MaSo;
		
		private string _TenKH;
		
		private string _MaKH;
		
		private string _SDT;
		
		private string _Cccd;
		
		private System.Nullable<decimal> _TienGui;
		
		private System.DateTime _NgayGui;
		
		private int _KyHan;
		
		private decimal _LaiXuat;
		
		private System.Nullable<int> _DaThanhToan;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaSoChanging(string value);
    partial void OnMaSoChanged();
    partial void OnTenKHChanging(string value);
    partial void OnTenKHChanged();
    partial void OnMaKHChanging(string value);
    partial void OnMaKHChanged();
    partial void OnSDTChanging(string value);
    partial void OnSDTChanged();
    partial void OnCccdChanging(string value);
    partial void OnCccdChanged();
    partial void OnTienGuiChanging(System.Nullable<decimal> value);
    partial void OnTienGuiChanged();
    partial void OnNgayGuiChanging(System.DateTime value);
    partial void OnNgayGuiChanged();
    partial void OnKyHanChanging(int value);
    partial void OnKyHanChanged();
    partial void OnLaiXuatChanging(decimal value);
    partial void OnLaiXuatChanged();
    partial void OnDaThanhToanChanging(System.Nullable<int> value);
    partial void OnDaThanhToanChanged();
    #endregion
		
		public SoTietKiem()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaSo", DbType="VarChar(255) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MaSo
		{
			get
			{
				return this._MaSo;
			}
			set
			{
				if ((this._MaSo != value))
				{
					this.OnMaSoChanging(value);
					this.SendPropertyChanging();
					this._MaSo = value;
					this.SendPropertyChanged("MaSo");
					this.OnMaSoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenKH", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
		public string TenKH
		{
			get
			{
				return this._TenKH;
			}
			set
			{
				if ((this._TenKH != value))
				{
					this.OnTenKHChanging(value);
					this.SendPropertyChanging();
					this._TenKH = value;
					this.SendPropertyChanged("TenKH");
					this.OnTenKHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaKH", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
		public string MaKH
		{
			get
			{
				return this._MaKH;
			}
			set
			{
				if ((this._MaKH != value))
				{
					this.OnMaKHChanging(value);
					this.SendPropertyChanging();
					this._MaKH = value;
					this.SendPropertyChanged("MaKH");
					this.OnMaKHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SDT", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
		public string SDT
		{
			get
			{
				return this._SDT;
			}
			set
			{
				if ((this._SDT != value))
				{
					this.OnSDTChanging(value);
					this.SendPropertyChanging();
					this._SDT = value;
					this.SendPropertyChanged("SDT");
					this.OnSDTChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Cccd", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
		public string Cccd
		{
			get
			{
				return this._Cccd;
			}
			set
			{
				if ((this._Cccd != value))
				{
					this.OnCccdChanging(value);
					this.SendPropertyChanging();
					this._Cccd = value;
					this.SendPropertyChanged("Cccd");
					this.OnCccdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TienGui", DbType="Money")]
		public System.Nullable<decimal> TienGui
		{
			get
			{
				return this._TienGui;
			}
			set
			{
				if ((this._TienGui != value))
				{
					this.OnTienGuiChanging(value);
					this.SendPropertyChanging();
					this._TienGui = value;
					this.SendPropertyChanged("TienGui");
					this.OnTienGuiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgayGui", DbType="Date NOT NULL")]
		public System.DateTime NgayGui
		{
			get
			{
				return this._NgayGui;
			}
			set
			{
				if ((this._NgayGui != value))
				{
					this.OnNgayGuiChanging(value);
					this.SendPropertyChanging();
					this._NgayGui = value;
					this.SendPropertyChanged("NgayGui");
					this.OnNgayGuiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_KyHan", DbType="Int NOT NULL")]
		public int KyHan
		{
			get
			{
				return this._KyHan;
			}
			set
			{
				if ((this._KyHan != value))
				{
					this.OnKyHanChanging(value);
					this.SendPropertyChanging();
					this._KyHan = value;
					this.SendPropertyChanged("KyHan");
					this.OnKyHanChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LaiXuat", DbType="Decimal(4,2) NOT NULL")]
		public decimal LaiXuat
		{
			get
			{
				return this._LaiXuat;
			}
			set
			{
				if ((this._LaiXuat != value))
				{
					this.OnLaiXuatChanging(value);
					this.SendPropertyChanging();
					this._LaiXuat = value;
					this.SendPropertyChanged("LaiXuat");
					this.OnLaiXuatChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DaThanhToan", DbType="Int")]
		public System.Nullable<int> DaThanhToan
		{
			get
			{
				return this._DaThanhToan;
			}
			set
			{
				if ((this._DaThanhToan != value))
				{
					this.OnDaThanhToanChanging(value);
					this.SendPropertyChanging();
					this._DaThanhToan = value;
					this.SendPropertyChanged("DaThanhToan");
					this.OnDaThanhToanChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TaiKhoan")]
	public partial class TaiKhoan : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _SoTK;
		
		private string _SoTKhoanTK;
		
		private string _MaKH;
		
		private string _TenKH;
		
		private string _SDT;
		
		private string _Cccd;
		
		private decimal _SoDu;
		
		private decimal _SoTienVay;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnSoTKChanging(string value);
    partial void OnSoTKChanged();
    partial void OnSoTKhoanTKChanging(string value);
    partial void OnSoTKhoanTKChanged();
    partial void OnMaKHChanging(string value);
    partial void OnMaKHChanged();
    partial void OnTenKHChanging(string value);
    partial void OnTenKHChanged();
    partial void OnSDTChanging(string value);
    partial void OnSDTChanged();
    partial void OnCccdChanging(string value);
    partial void OnCccdChanged();
    partial void OnSoDuChanging(decimal value);
    partial void OnSoDuChanged();
    partial void OnSoTienVayChanging(decimal value);
    partial void OnSoTienVayChanged();
    #endregion
		
		public TaiKhoan()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoTK", DbType="VarChar(255) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string SoTK
		{
			get
			{
				return this._SoTK;
			}
			set
			{
				if ((this._SoTK != value))
				{
					this.OnSoTKChanging(value);
					this.SendPropertyChanging();
					this._SoTK = value;
					this.SendPropertyChanged("SoTK");
					this.OnSoTKChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoTKhoanTK", DbType="VarChar(255)")]
		public string SoTKhoanTK
		{
			get
			{
				return this._SoTKhoanTK;
			}
			set
			{
				if ((this._SoTKhoanTK != value))
				{
					this.OnSoTKhoanTKChanging(value);
					this.SendPropertyChanging();
					this._SoTKhoanTK = value;
					this.SendPropertyChanged("SoTKhoanTK");
					this.OnSoTKhoanTKChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaKH", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
		public string MaKH
		{
			get
			{
				return this._MaKH;
			}
			set
			{
				if ((this._MaKH != value))
				{
					this.OnMaKHChanging(value);
					this.SendPropertyChanging();
					this._MaKH = value;
					this.SendPropertyChanged("MaKH");
					this.OnMaKHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenKH", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
		public string TenKH
		{
			get
			{
				return this._TenKH;
			}
			set
			{
				if ((this._TenKH != value))
				{
					this.OnTenKHChanging(value);
					this.SendPropertyChanging();
					this._TenKH = value;
					this.SendPropertyChanged("TenKH");
					this.OnTenKHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SDT", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
		public string SDT
		{
			get
			{
				return this._SDT;
			}
			set
			{
				if ((this._SDT != value))
				{
					this.OnSDTChanging(value);
					this.SendPropertyChanging();
					this._SDT = value;
					this.SendPropertyChanged("SDT");
					this.OnSDTChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Cccd", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
		public string Cccd
		{
			get
			{
				return this._Cccd;
			}
			set
			{
				if ((this._Cccd != value))
				{
					this.OnCccdChanging(value);
					this.SendPropertyChanging();
					this._Cccd = value;
					this.SendPropertyChanged("Cccd");
					this.OnCccdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoDu", DbType="Money NOT NULL")]
		public decimal SoDu
		{
			get
			{
				return this._SoDu;
			}
			set
			{
				if ((this._SoDu != value))
				{
					this.OnSoDuChanging(value);
					this.SendPropertyChanging();
					this._SoDu = value;
					this.SendPropertyChanged("SoDu");
					this.OnSoDuChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoTienVay", DbType="Money NOT NULL")]
		public decimal SoTienVay
		{
			get
			{
				return this._SoTienVay;
			}
			set
			{
				if ((this._SoTienVay != value))
				{
					this.OnSoTienVayChanging(value);
					this.SendPropertyChanging();
					this._SoTienVay = value;
					this.SendPropertyChanged("SoTienVay");
					this.OnSoTienVayChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TinDung")]
	public partial class TinDung : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MaTD;
		
		private string _TenKH;
		
		private System.Nullable<decimal> _ThuNhap;
		
		private string _Cccd;
		
		private string _LoaiThe;
		
		private decimal _HanMuc;
		
		private System.DateTime _NgayTra;
		
		private double _LaiXuatTD;
		
		private System.Nullable<decimal> _NoTD;
		
		private System.Nullable<decimal> _NoXau;
		
		private string _SoLan;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaTDChanging(string value);
    partial void OnMaTDChanged();
    partial void OnTenKHChanging(string value);
    partial void OnTenKHChanged();
    partial void OnThuNhapChanging(System.Nullable<decimal> value);
    partial void OnThuNhapChanged();
    partial void OnCccdChanging(string value);
    partial void OnCccdChanged();
    partial void OnLoaiTheChanging(string value);
    partial void OnLoaiTheChanged();
    partial void OnHanMucChanging(decimal value);
    partial void OnHanMucChanged();
    partial void OnNgayTraChanging(System.DateTime value);
    partial void OnNgayTraChanged();
    partial void OnLaiXuatTDChanging(double value);
    partial void OnLaiXuatTDChanged();
    partial void OnNoTDChanging(System.Nullable<decimal> value);
    partial void OnNoTDChanged();
    partial void OnNoXauChanging(System.Nullable<decimal> value);
    partial void OnNoXauChanged();
    partial void OnSoLanChanging(string value);
    partial void OnSoLanChanged();
    #endregion
		
		public TinDung()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaTD", DbType="VarChar(255) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MaTD
		{
			get
			{
				return this._MaTD;
			}
			set
			{
				if ((this._MaTD != value))
				{
					this.OnMaTDChanging(value);
					this.SendPropertyChanging();
					this._MaTD = value;
					this.SendPropertyChanged("MaTD");
					this.OnMaTDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenKH", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
		public string TenKH
		{
			get
			{
				return this._TenKH;
			}
			set
			{
				if ((this._TenKH != value))
				{
					this.OnTenKHChanging(value);
					this.SendPropertyChanging();
					this._TenKH = value;
					this.SendPropertyChanged("TenKH");
					this.OnTenKHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ThuNhap", DbType="Money")]
		public System.Nullable<decimal> ThuNhap
		{
			get
			{
				return this._ThuNhap;
			}
			set
			{
				if ((this._ThuNhap != value))
				{
					this.OnThuNhapChanging(value);
					this.SendPropertyChanging();
					this._ThuNhap = value;
					this.SendPropertyChanged("ThuNhap");
					this.OnThuNhapChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Cccd", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
		public string Cccd
		{
			get
			{
				return this._Cccd;
			}
			set
			{
				if ((this._Cccd != value))
				{
					this.OnCccdChanging(value);
					this.SendPropertyChanging();
					this._Cccd = value;
					this.SendPropertyChanged("Cccd");
					this.OnCccdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LoaiThe", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
		public string LoaiThe
		{
			get
			{
				return this._LoaiThe;
			}
			set
			{
				if ((this._LoaiThe != value))
				{
					this.OnLoaiTheChanging(value);
					this.SendPropertyChanging();
					this._LoaiThe = value;
					this.SendPropertyChanged("LoaiThe");
					this.OnLoaiTheChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HanMuc", DbType="Money NOT NULL")]
		public decimal HanMuc
		{
			get
			{
				return this._HanMuc;
			}
			set
			{
				if ((this._HanMuc != value))
				{
					this.OnHanMucChanging(value);
					this.SendPropertyChanging();
					this._HanMuc = value;
					this.SendPropertyChanged("HanMuc");
					this.OnHanMucChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgayTra", DbType="Date NOT NULL")]
		public System.DateTime NgayTra
		{
			get
			{
				return this._NgayTra;
			}
			set
			{
				if ((this._NgayTra != value))
				{
					this.OnNgayTraChanging(value);
					this.SendPropertyChanging();
					this._NgayTra = value;
					this.SendPropertyChanged("NgayTra");
					this.OnNgayTraChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LaiXuatTD", DbType="Float NOT NULL")]
		public double LaiXuatTD
		{
			get
			{
				return this._LaiXuatTD;
			}
			set
			{
				if ((this._LaiXuatTD != value))
				{
					this.OnLaiXuatTDChanging(value);
					this.SendPropertyChanging();
					this._LaiXuatTD = value;
					this.SendPropertyChanged("LaiXuatTD");
					this.OnLaiXuatTDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NoTD", DbType="Money")]
		public System.Nullable<decimal> NoTD
		{
			get
			{
				return this._NoTD;
			}
			set
			{
				if ((this._NoTD != value))
				{
					this.OnNoTDChanging(value);
					this.SendPropertyChanging();
					this._NoTD = value;
					this.SendPropertyChanged("NoTD");
					this.OnNoTDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NoXau", DbType="Money")]
		public System.Nullable<decimal> NoXau
		{
			get
			{
				return this._NoXau;
			}
			set
			{
				if ((this._NoXau != value))
				{
					this.OnNoXauChanging(value);
					this.SendPropertyChanging();
					this._NoXau = value;
					this.SendPropertyChanged("NoXau");
					this.OnNoXauChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoLan", DbType="VarChar(255)")]
		public string SoLan
		{
			get
			{
				return this._SoLan;
			}
			set
			{
				if ((this._SoLan != value))
				{
					this.OnSoLanChanging(value);
					this.SendPropertyChanging();
					this._SoLan = value;
					this.SendPropertyChanged("SoLan");
					this.OnSoLanChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.LaiXuat")]
	public partial class LaiXuat
	{
		
		private int _KyHan;
		
		private decimal _LaiXuatVay;
		
		private decimal _LaiXuatGui;
		
		public LaiXuat()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_KyHan", DbType="Int NOT NULL")]
		public int KyHan
		{
			get
			{
				return this._KyHan;
			}
			set
			{
				if ((this._KyHan != value))
				{
					this._KyHan = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LaiXuatVay", DbType="Decimal(4,2) NOT NULL")]
		public decimal LaiXuatVay
		{
			get
			{
				return this._LaiXuatVay;
			}
			set
			{
				if ((this._LaiXuatVay != value))
				{
					this._LaiXuatVay = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LaiXuatGui", DbType="Decimal(4,2) NOT NULL")]
		public decimal LaiXuatGui
		{
			get
			{
				return this._LaiXuatGui;
			}
			set
			{
				if ((this._LaiXuatGui != value))
				{
					this._LaiXuatGui = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.View_KhachHang")]
	public partial class View_KhachHang
	{
		
		private string _SoTK;
		
		private decimal _SoDu;
		
		private string _MaKH;
		
		private string _TenKH;
		
		private System.DateTime _NgaySinh;
		
		private string _SDT;
		
		private string _Email;
		
		private string _Cccd;
		
		private string _DiaChi;
		
		private string _Expr1;
		
		public View_KhachHang()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoTK", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
		public string SoTK
		{
			get
			{
				return this._SoTK;
			}
			set
			{
				if ((this._SoTK != value))
				{
					this._SoTK = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoDu", DbType="Money NOT NULL")]
		public decimal SoDu
		{
			get
			{
				return this._SoDu;
			}
			set
			{
				if ((this._SoDu != value))
				{
					this._SoDu = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaKH", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
		public string MaKH
		{
			get
			{
				return this._MaKH;
			}
			set
			{
				if ((this._MaKH != value))
				{
					this._MaKH = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenKH", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
		public string TenKH
		{
			get
			{
				return this._TenKH;
			}
			set
			{
				if ((this._TenKH != value))
				{
					this._TenKH = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgaySinh", DbType="Date NOT NULL")]
		public System.DateTime NgaySinh
		{
			get
			{
				return this._NgaySinh;
			}
			set
			{
				if ((this._NgaySinh != value))
				{
					this._NgaySinh = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SDT", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
		public string SDT
		{
			get
			{
				return this._SDT;
			}
			set
			{
				if ((this._SDT != value))
				{
					this._SDT = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this._Email = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Cccd", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
		public string Cccd
		{
			get
			{
				return this._Cccd;
			}
			set
			{
				if ((this._Cccd != value))
				{
					this._Cccd = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DiaChi", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
		public string DiaChi
		{
			get
			{
				return this._DiaChi;
			}
			set
			{
				if ((this._DiaChi != value))
				{
					this._DiaChi = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Expr1", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
		public string Expr1
		{
			get
			{
				return this._Expr1;
			}
			set
			{
				if ((this._Expr1 != value))
				{
					this._Expr1 = value;
				}
			}
		}
	}
}
#pragma warning restore 1591