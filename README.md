# Phần mềm quản lý Ký túc xá K7

# Hướng dẫn sử dụng
## Tạo cơ sở dữ liệu
* Vào *folder Sql* để lấy file *Project_63135188.sql*

* Mở *Sql server* lên và *chạy các lệnh trong file*

## Đổi tên trong Sql server
* Truy cập theo đường dẫn:
*source/Project_63135188/Project_63135188/Web.config*

* Tìm dòng:
<add name="Project_63135188Entities" connectionString="metadata=res://*/Models.Model_63135188.csdl|res://*/Models.Model_63135188.ssdl|res://*/Models.Model_63135188.msl;provider=System.Data.SqlClient;provider connection string=&quot;data source=ADMIN\SQLEXPRESS;initial catalog=Project_63135188;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework&quot;" providerName="System.Data.EntityClient" />

* *Thay thế giá trị* của *data source* thành tên Sql server trên máy bạn