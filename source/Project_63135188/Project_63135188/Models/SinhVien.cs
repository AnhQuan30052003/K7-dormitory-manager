//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Project_63135188.Models
{
  using System;
  using System.Collections.Generic;
  using System.ComponentModel;
  using System.ComponentModel.DataAnnotations;
  public partial class SinhVien
  {
    public string maSV { get; set; }
    public string hoSV { get; set; }
    public string tenSV { get; set; }
    public Nullable<bool> gioiTinh { get; set; }

    [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
    public Nullable<System.DateTime> ngaySinh { get; set; }
    public string lop { get; set; }
    public Nullable<bool> dongPhi { get; set; }
    public string anhSV { get; set; }
    public string queQuan { get; set; }
    public string sdtSV { get; set; }
    public string matKhau { get; set; }
    public string email { get; set; }
    public string maPhong { get; set; }
    
    public virtual Phong Phong { get; set; }
  }
}