using DryingHouse.Core.Domain;
using DryingHouse.Persistence;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace DryingHouse.Migrations
{
    using DryingHouse.Core;
    using DryingHouse.Core.Helper;
    using System;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<DryingHouse.Persistence.ProjectDataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ProjectDataContext projectDataContext)
        {
            //FirstUpdate(projectDataContext);
            //AddOrUpdateLanguageLibrary(projectDataContext);
        }

        private void AddOrUpdateLanguageLibrary(ProjectDataContext projectDataContext)
        {
            #region LanguageLibrary
            var languageLibrarys = new List<LanguageLibrary>
            {
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Điều khiển thiết bị cảnh báo",
                    English = "Enable to control alarm device",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Số giờ giám sát",
                    English = "A number of hour to monitoring",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Đếm thời gian reset",
                    English = "Reset Time",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Số lượng sản phẩm / LOT",
                    English = "A number of product / LOT",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Bạn không có quyền sử dụng chức năng này",
                    English = "You do not have permission to use this function",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Ứng dụng cần kết nối mạng để kích hoạt",
                    English = "The application requires a network connection to activate",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Ứng dụng cần quyền Quản trị để kích hoạt",
                    English = "Application needs Admin rights to activate",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Đăng ký sử dụng phần mềm",
                    English = "Register to use the software",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Dùng thử",
                    English = "Trial",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Dùng thử cho 1 máy tính",
                    English = "Try it on 1 computer",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Bản quyền",
                    English = "License",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Mã sản phẩm",
                    English = "Product code",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Ngày kích hoạt",
                    English = "Activation date",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Ngày hết hạn",
                    English = "Expiration date",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Còn lại",
                    English = "Left day",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Sau thời gian chỉ định chương trình sẽ bị vô hiệu",
                    English = "After the specified time the program will be disabled",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Để tiếp tục sử dụng, bạn nên mua giấy phép",
                    English = "To continue using, you should purchase a license",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Đăng ký",
                    English = "Registration",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Cổng COM",
                    English = "Port COM",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Tên công ty",
                    English = "Company name",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Tên máy in",
                    English = "Printer name",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Cấu hình",
                    English = "Setting",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Số lượng mã vạch đã in",
                    English = "Number of barcodes printed",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "SL sản phẩm đã sản xuất",
                    English = "Number of products produced",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Số lượng sản phẩm OK",
                    English = "Quantity of products OK",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Số lượng sản phẩm NG",
                    English = "Quantity of products NG",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Ngày",
                    English = "DateTime",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Ngày sản xuất",
                    English = "Produced date",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Kết quả sản xuất",
                    English = "Produced result",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Từ ngày",
                    English = "FromDate",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Đến ngày",
                    English = "ToDate",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "In thất bại",
                    English = "Print failed",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Thông báo",
                    English = "Notification",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Xác nhận",
                    English = "Confirmation",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Đăng nhập",
                    English = "Sign In",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Tài khoản",
                    English = "Username",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Mật khẩu",
                    English = "Password",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Lưu thông tin đăng nhập",
                    English = "Keep me signed in",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Quên mật khẩu",
                    English = "I forgot my password",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Mật khẩu không đúng",
                    English = "Incorrect password",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Tài khoản không tồn tại",
                    English = "Username does not exist",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Chương trình chính",
                    English = "Main Menu",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Hệ thống",
                    English = "System",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Danh mục",
                    English = "Category",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Chức năng",
                    English = "Function",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Báo cáo",
                    English = "Report",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Quản lý người dùng",
                    English = "User management",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Người dùng",
                    English = "Function",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Đổi mật khẩu",
                    English = "Change password",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Ngôn ngữ",
                    English = "Language",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Quản lý sản phẩm",
                    English = "Product Management",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Bước sấy",
                    English = "Drying Steps",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Danh sách ĐTV",
                    English = "Unit List",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Quản lý giờ sấy",
                    English = "Hour Drying Setup",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "In mã vạch",
                    English = "Register to print barcode",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Giám sát trạng thái",
                    English = "Production Monitoring",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Lịch sử xuất hàng",
                    English = "Shipping History",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Mật khẩu cũ",
                    English = "Old password",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Mật khẩu mới",
                    English = "New password",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Xác nhận mật khẩu",
                    English = "Confirm password",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Thư viện ngôn ngữ",
                    English = "Language Library",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Thêm (F1)",
                    English = "Add (F1)",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Sửa (F2)",
                    English = "Edit (F2)",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Xóa (F3)",
                    English = "Del (F3)",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Excel (F4)",
                    English = "Excel (F4)",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Lọc (F5)",
                    English = "Refresh (F5)",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Phân quyền (F6)",
                    English = "Authority (F6)",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Chương trình (F7)",
                    English = "Program(F7)",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Lưu (F1)",
                    English = "Save (F1)",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Đóng (ESC)",
                    English = "Close (ESC)",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Trạng thái",
                    English = "Status",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Tất cả",
                    English = "All",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Sử dụng",
                    English = "Using",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Ko sử dụng",
                    English = "No User",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Giới tính",
                    English = "Gender",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Nam",
                    English = "Male",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Nữ",
                    English = "Female",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Tên đầy đủ",
                    English = "FullName",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Điện thoại",
                    English = "Phone",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Địa chỉ",
                    English = "Address",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Ghi chú",
                    English = "Note",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Chọn",
                    English = "Select",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Mã",
                    English = "ID",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Nhóm quyền",
                    English = "Authority Group",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Tiếng Việt",
                    English = "Vietnamese",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Tiếng Anh",
                    English = "English",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Chức năng chương trình",
                    English = "Program Function Master",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Chương trình",
                    English = "Program",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Diễn giải",
                    English = "Explanation",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Chưa điền dữ liệu",
                    English = "No data entered",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Chưa chọn dữ liệu",
                    English = "No data selected",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Dữ liệu đã tồn tại",
                    English = "Data already exists",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Dữ liệu không đúng",
                    English = "The data is incorrect",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Mã bước sấy",
                    English = "Step No",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Tên bước sấy",
                    English = "Step Name",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Mã kho",
                    English = "Warehouse No",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Thời gian bắt đầu",
                    English = "Begin time",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Số giờ làm việc",
                    English = "Length hours of work",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "In lại (F2)",
                    English = "RePrint (F2)",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Lưu thành công",
                    English = "Save successfully",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Lưu thất bại",
                    English = "Save failed",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Bạn có muốn hủy thông tin này?",
                    English = "Do you want to cancel this information?",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Bạn có muốn xóa thông tin này?",
                    English = "Do you want to delete this information?",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Hủy thất bại",
                    English = "Cancel failed",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Xóa thất bại",
                    English = "Delete failed",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Ngày đăng ký",
                    English = "Regist date",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Ngày quét mã vạch",
                    English = "Scan barcode date",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Mã vạch",
                    English = "Barcode",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Lưu và in (F1)",
                    English = "Save and Print (F1)",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Lịch sử sản xuất",
                    English = "Production history",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Thống kê sản phẩm OK",
                    English = "Product report OK",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Thống kê sản phẩm NG",
                    English = "Product report NG",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Trạng thái sản xuất",
                    English = "Production Status",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Quét mã vạch (F1)",
                    English = "Scan barcode (F1)",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Số lượng",
                    English = "Quantity",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Trạng thái sản xuất",
                    English = "Production Status",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Chưa xử lý",
                    English = "None",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Đang xử lý",
                    English = "In progress",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Đã xong",
                    English = "Completed",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Bảo lưu",
                    English = "Hold",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Đã bị hủy",
                    English = "NoUse",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new LanguageLibrary
                {
                    Id = Guid.NewGuid().ToString(),
                    Vietnamese = "Đang dùng",
                    English = "Using",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                }
            };

            foreach (var languageLibrary in languageLibrarys)
                projectDataContext.LanguageLibraries.AddOrUpdate(a => a.Id, languageLibrary);
            #endregion
        }

        private void FirstUpdate(ProjectDataContext projectDataContext)
        {
            string defaultPassword1 = "1511";
            string defaultPassword2 = "quanly";
            string defaultPassword3 = "ca1";
            string defaultPassword4 = "ca2";
            string salt = SecurityHelper.CreateSalt(GlobalConstants.defaultSaltLength);
            string encryptedPassword1 = SecurityHelper.GenerateMD5(defaultPassword1, salt);
            string encryptedPassword2 = SecurityHelper.GenerateMD5(defaultPassword2, salt);
            string encryptedPassword3 = SecurityHelper.GenerateMD5(defaultPassword3, salt);
            string encryptedPassword4 = SecurityHelper.GenerateMD5(defaultPassword4, salt);

            #region Add Setting
            var settings = new List<Setting>
            {
                new Setting
                {
                    Id = Guid.NewGuid().ToString(),
                    DungSai = 5,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                }
            };

            foreach (var setting in settings)
                projectDataContext.Settings.Add(setting);
            #endregion


            #region Add Users
            string userID1 = Guid.NewGuid().ToString();
            string userID2 = Guid.NewGuid().ToString();
            string userID3 = Guid.NewGuid().ToString();
            string userID4 = Guid.NewGuid().ToString();
            var users = new List<User>
            {
                new User
                {
                    Id = userID1,
                    Username = "admin",
                    Salt = salt,
                    Password = encryptedPassword1,
                    FullName = "Administrator",
                    Gender = Core.GlobalConstants.GenderValue.Male,
                    Status = Core.GlobalConstants.StatusValue.Using,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new User
                {
                    Id = userID2,
                    Username = "quanly",
                    Salt = salt,
                    Password = encryptedPassword2,
                    FullName = "Quản lý",
                    Gender = Core.GlobalConstants.GenderValue.Male,
                    Status = Core.GlobalConstants.StatusValue.Using,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new User
                {
                    Id = userID3,
                    Username = "ca1",
                    Salt = salt,
                    Password = encryptedPassword3,
                    FullName = "Ca 1",
                    Gender = Core.GlobalConstants.GenderValue.Male,
                    Status = Core.GlobalConstants.StatusValue.Using,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new User
                {
                    Id = userID4,
                    Username = "ca2",
                    Salt = salt,
                    Password = encryptedPassword4,
                    FullName = "Ca 2",
                    Gender = Core.GlobalConstants.GenderValue.Male,
                    Status = Core.GlobalConstants.StatusValue.Using,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                }
            };

            foreach (var user in users)
                projectDataContext.Users.AddOrUpdate(a => a.Id, user);
            #endregion


            #region Add AuthorityGroup
            string authorityGroup1 = Guid.NewGuid().ToString();
            string authorityGroup2 = Guid.NewGuid().ToString();
            string authorityGroup3 = Guid.NewGuid().ToString();
            var authorityGroups = new List<AuthorityGroup>
            {
                new AuthorityGroup
                {
                    Id = authorityGroup1,
                    AuthorityGroupName = "Admin",
                    Sort = 0,
                    Status = Core.GlobalConstants.StatusValue.Using,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new AuthorityGroup
                {
                    Id = authorityGroup2,
                    AuthorityGroupName = "Manager",
                    Sort = 1,
                    Status = Core.GlobalConstants.StatusValue.Using,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new AuthorityGroup
                {
                    Id = authorityGroup3,
                    AuthorityGroupName = "Operator",
                    Sort = 2,
                    Status = Core.GlobalConstants.StatusValue.Using,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                }
            };

            foreach (var authorityGroup in authorityGroups)
                projectDataContext.AuthorityGroups.Add(authorityGroup);
            #endregion


            #region Add ProgramFunctionMaster
            var programFunctionMasters = new List<ProgramFunctionMaster>
            {
                new ProgramFunctionMaster
                {
                    Id = Guid.NewGuid().ToString(),
                    ProgramName = "User",
                    FunctionName = "View",
                    Explanation = "",
                    Status = Core.GlobalConstants.StatusValue.Using,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new ProgramFunctionMaster
                {
                    Id = Guid.NewGuid().ToString(),
                    ProgramName = "Language",
                    FunctionName = "View",
                    Explanation = "",
                    Status = Core.GlobalConstants.StatusValue.Using,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new ProgramFunctionMaster
                {
                    Id = Guid.NewGuid().ToString(),
                    ProgramName = "Setting",
                    FunctionName = "View",
                    Explanation = "",
                    Status = Core.GlobalConstants.StatusValue.Using,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new ProgramFunctionMaster
                {
                    Id = Guid.NewGuid().ToString(),
                    ProgramName = "PartNumber",
                    FunctionName = "View",
                    Explanation = "",
                    Status = Core.GlobalConstants.StatusValue.Using,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new ProgramFunctionMaster
                {
                    Id = Guid.NewGuid().ToString(),
                    ProgramName = "ProductMatrix",
                    FunctionName = "View",
                    Explanation = "",
                    Status = Core.GlobalConstants.StatusValue.Using,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new ProgramFunctionMaster
                {
                    Id = Guid.NewGuid().ToString(),
                    ProgramName = "Step",
                    FunctionName = "View",
                    Explanation = "",
                    Status = Core.GlobalConstants.StatusValue.Using,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new ProgramFunctionMaster
                {
                    Id = Guid.NewGuid().ToString(),
                    ProgramName = "Unit",
                    FunctionName = "View",
                    Explanation = "",
                    Status = Core.GlobalConstants.StatusValue.Using,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new ProgramFunctionMaster
                {
                    Id = Guid.NewGuid().ToString(),
                    ProgramName = "RegistBarcode",
                    FunctionName = "View",
                    Explanation = "",
                    Status = Core.GlobalConstants.StatusValue.Using,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new ProgramFunctionMaster
                {
                    Id = Guid.NewGuid().ToString(),
                    ProgramName = "Shipment",
                    FunctionName = "View",
                    Explanation = "",
                    Status = Core.GlobalConstants.StatusValue.Using,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new ProgramFunctionMaster
                {
                    Id = Guid.NewGuid().ToString(),
                    ProgramName = "Monitoring",
                    FunctionName = "View",
                    Explanation = "",
                    Status = Core.GlobalConstants.StatusValue.Using,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new ProgramFunctionMaster
                {
                    Id = Guid.NewGuid().ToString(),
                    ProgramName = "ProductionHistory",
                    FunctionName = "View",
                    Explanation = "",
                    Status = Core.GlobalConstants.StatusValue.Using,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new ProgramFunctionMaster
                {
                    Id = Guid.NewGuid().ToString(),
                    ProgramName = "QuantityOfProductsOK",
                    FunctionName = "View",
                    Explanation = "",
                    Status = Core.GlobalConstants.StatusValue.Using,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new ProgramFunctionMaster
                {
                    Id = Guid.NewGuid().ToString(),
                    ProgramName = "QuantityOfProductsNG",
                    FunctionName = "View",
                    Explanation = "",
                    Status = Core.GlobalConstants.StatusValue.Using,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new ProgramFunctionMaster
                {
                    Id = Guid.NewGuid().ToString(),
                    ProgramName = "ReportSyntheticRegistBarcode",
                    FunctionName = "View",
                    Explanation = "",
                    Status = Core.GlobalConstants.StatusValue.Using,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new ProgramFunctionMaster
                {
                    Id = Guid.NewGuid().ToString(),
                    ProgramName = "ReportSyntheticProductionPlan",
                    FunctionName = "View",
                    Explanation = "",
                    Status = Core.GlobalConstants.StatusValue.Using,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                }
            };

            foreach (var programFunctionMaster in programFunctionMasters)
                projectDataContext.ProgramFunctionMasters.AddOrUpdate(a => a.Id, programFunctionMaster);
            #endregion


            #region Add ProgramFunctionAuthority
            var programFunctionAuthoritys = new List<ProgramFunctionAuthority>
            {
                new ProgramFunctionAuthority
                {
                    Id = Guid.NewGuid().ToString(),
                    ProgramName = "User",
                    FunctionName = "View",
                    AuthorityGroupID = authorityGroup1,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new ProgramFunctionAuthority
                {
                    Id = Guid.NewGuid().ToString(),
                    ProgramName = "Language",
                    FunctionName = "View",
                    AuthorityGroupID = authorityGroup1,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new ProgramFunctionAuthority
                {
                    Id = Guid.NewGuid().ToString(),
                    ProgramName = "Setting",
                    FunctionName = "View",
                    AuthorityGroupID = authorityGroup1,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new ProgramFunctionAuthority
                {
                    Id = Guid.NewGuid().ToString(),
                    ProgramName = "PartNumber",
                    FunctionName = "View",
                    AuthorityGroupID = authorityGroup1,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new ProgramFunctionAuthority
                {
                    Id = Guid.NewGuid().ToString(),
                    ProgramName = "ProductMatrix",
                    FunctionName = "View",
                    AuthorityGroupID = authorityGroup1,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new ProgramFunctionAuthority
                {
                    Id = Guid.NewGuid().ToString(),
                    ProgramName = "Step",
                    FunctionName = "View",
                    AuthorityGroupID = authorityGroup1,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new ProgramFunctionAuthority
                {
                    Id = Guid.NewGuid().ToString(),
                    ProgramName = "Unit",
                    FunctionName = "View",
                    AuthorityGroupID = authorityGroup1,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new ProgramFunctionAuthority
                {
                    Id = Guid.NewGuid().ToString(),
                    ProgramName = "RegistBarcode",
                    FunctionName = "View",
                    AuthorityGroupID = authorityGroup1,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new ProgramFunctionAuthority
                {
                    Id = Guid.NewGuid().ToString(),
                    ProgramName = "Shipment",
                    FunctionName = "View",
                    AuthorityGroupID = authorityGroup1,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new ProgramFunctionAuthority
                {
                    Id = Guid.NewGuid().ToString(),
                    ProgramName = "Monitoring",
                    FunctionName = "View",
                    AuthorityGroupID = authorityGroup1,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new ProgramFunctionAuthority
                {
                    Id = Guid.NewGuid().ToString(),
                    ProgramName = "ProductionHistory",
                    FunctionName = "View",
                    AuthorityGroupID = authorityGroup1,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new ProgramFunctionAuthority
                {
                    Id = Guid.NewGuid().ToString(),
                    ProgramName = "QuantityOfProductsOK",
                    FunctionName = "View",
                    AuthorityGroupID = authorityGroup1,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new ProgramFunctionAuthority
                {
                    Id = Guid.NewGuid().ToString(),
                    ProgramName = "QuantityOfProductsNG",
                    FunctionName = "View",
                    AuthorityGroupID = authorityGroup1,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new ProgramFunctionAuthority
                {
                    Id = Guid.NewGuid().ToString(),
                    ProgramName = "ReportSyntheticRegistBarcode",
                    FunctionName = "View",
                    AuthorityGroupID = authorityGroup1,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new ProgramFunctionAuthority
                {
                    Id = Guid.NewGuid().ToString(),
                    ProgramName = "ReportSyntheticProductionPlan",
                    FunctionName = "View",
                    AuthorityGroupID = authorityGroup1,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new ProgramFunctionAuthority
                {
                    Id = Guid.NewGuid().ToString(),
                    ProgramName = "User",
                    FunctionName = "View",
                    AuthorityGroupID = authorityGroup2,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new ProgramFunctionAuthority
                {
                    Id = Guid.NewGuid().ToString(),
                    ProgramName = "Language",
                    FunctionName = "View",
                    AuthorityGroupID = authorityGroup2,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new ProgramFunctionAuthority
                {
                    Id = Guid.NewGuid().ToString(),
                    ProgramName = "Setting",
                    FunctionName = "View",
                    AuthorityGroupID = authorityGroup2,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new ProgramFunctionAuthority
                {
                    Id = Guid.NewGuid().ToString(),
                    ProgramName = "PartNumber",
                    FunctionName = "View",
                    AuthorityGroupID = authorityGroup2,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new ProgramFunctionAuthority
                {
                    Id = Guid.NewGuid().ToString(),
                    ProgramName = "ProductMatrix",
                    FunctionName = "View",
                    AuthorityGroupID = authorityGroup2,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new ProgramFunctionAuthority
                {
                    Id = Guid.NewGuid().ToString(),
                    ProgramName = "Step",
                    FunctionName = "View",
                    AuthorityGroupID = authorityGroup2,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new ProgramFunctionAuthority
                {
                    Id = Guid.NewGuid().ToString(),
                    ProgramName = "Unit",
                    FunctionName = "View",
                    AuthorityGroupID = authorityGroup2,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new ProgramFunctionAuthority
                {
                    Id = Guid.NewGuid().ToString(),
                    ProgramName = "RegistBarcode",
                    FunctionName = "View",
                    AuthorityGroupID = authorityGroup2,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new ProgramFunctionAuthority
                {
                    Id = Guid.NewGuid().ToString(),
                    ProgramName = "Shipment",
                    FunctionName = "View",
                    AuthorityGroupID = authorityGroup2,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new ProgramFunctionAuthority
                {
                    Id = Guid.NewGuid().ToString(),
                    ProgramName = "Monitoring",
                    FunctionName = "View",
                    AuthorityGroupID = authorityGroup2,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new ProgramFunctionAuthority
                {
                    Id = Guid.NewGuid().ToString(),
                    ProgramName = "ProductionHistory",
                    FunctionName = "View",
                    AuthorityGroupID = authorityGroup2,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new ProgramFunctionAuthority
                {
                    Id = Guid.NewGuid().ToString(),
                    ProgramName = "QuantityOfProductsOK",
                    FunctionName = "View",
                    AuthorityGroupID = authorityGroup2,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new ProgramFunctionAuthority
                {
                    Id = Guid.NewGuid().ToString(),
                    ProgramName = "QuantityOfProductsNG",
                    FunctionName = "View",
                    AuthorityGroupID = authorityGroup2,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new ProgramFunctionAuthority
                {
                    Id = Guid.NewGuid().ToString(),
                    ProgramName = "ReportSyntheticRegistBarcode",
                    FunctionName = "View",
                    AuthorityGroupID = authorityGroup2,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new ProgramFunctionAuthority
                {
                    Id = Guid.NewGuid().ToString(),
                    ProgramName = "ReportSyntheticProductionPlan",
                    FunctionName = "View",
                    AuthorityGroupID = authorityGroup2,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new ProgramFunctionAuthority
                {
                    Id = Guid.NewGuid().ToString(),
                    ProgramName = "Monitoring",
                    FunctionName = "View",
                    AuthorityGroupID = authorityGroup3,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                }
            };


            foreach (var programFunctionAuthority in programFunctionAuthoritys)
                projectDataContext.ProgramFunctionAuthorities.AddOrUpdate(a => a.Id, programFunctionAuthority);
            #endregion


            #region Add UserAuthority
            var userAuthoritys = new List<UserAuthority>
            {
                new UserAuthority
                {
                    Id = Guid.NewGuid().ToString(),
                    UserID = userID1,
                    AuthorityGroupID = authorityGroup1,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new UserAuthority
                {
                    Id = Guid.NewGuid().ToString(),
                    UserID = userID2,
                    AuthorityGroupID = authorityGroup2,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new UserAuthority
                {
                    Id = Guid.NewGuid().ToString(),
                    UserID = userID3,
                    AuthorityGroupID = authorityGroup3,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new UserAuthority
                {
                    Id = Guid.NewGuid().ToString(),
                    UserID = userID4,
                    AuthorityGroupID = authorityGroup3,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                }
            };

            foreach (var userAuthority in userAuthoritys)
                projectDataContext.UserAuthorities.AddOrUpdate(a => a.Id, userAuthority);
            #endregion


            #region Add Unit
            string unit1 = Guid.NewGuid().ToString();
            var units = new List<Unit>
            {
                new Unit
                {
                    Id = unit1,
                    UnitName = "Cái",
                    Status = Core.GlobalConstants.StatusValue.Using,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                }
            };

            foreach (var unit in units)
                projectDataContext.Units.Add(unit);
            #endregion



            #region Add Step
            var Steps = new List<Step>
            {
                new Step
                {
                    Id = Guid.NewGuid().ToString(),
                    StepNo = 1,
                    StepName = "NhaSay",
                    RequestScanIn = Core.GlobalConstants.RequestScanValue.Yes,
                    RequestScanOut = Core.GlobalConstants.RequestScanValue.Yes,
                    Status = Core.GlobalConstants.StatusValue.Using,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new Step
                {
                    Id = Guid.NewGuid().ToString(),
                    StepNo = 2,
                    StepName = "KhuVucCho",
                    RequestScanIn = Core.GlobalConstants.RequestScanValue.No,
                    RequestScanOut = Core.GlobalConstants.RequestScanValue.No,
                    Status = Core.GlobalConstants.StatusValue.Using,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new Step
                {
                    Id = Guid.NewGuid().ToString(),
                    StepNo = 3,
                    StepName = "MayKhuTinhDien",
                    RequestScanIn = Core.GlobalConstants.RequestScanValue.Yes,
                    RequestScanOut = Core.GlobalConstants.RequestScanValue.No,
                    Status = Core.GlobalConstants.StatusValue.Using,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new Step
                {
                    Id = Guid.NewGuid().ToString(),
                    StepNo = 4,
                    StepName = "NhaSay",
                    RequestScanIn = Core.GlobalConstants.RequestScanValue.Yes,
                    RequestScanOut = Core.GlobalConstants.RequestScanValue.Yes,
                    Status = Core.GlobalConstants.StatusValue.Using,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new Step
                {
                    Id = Guid.NewGuid().ToString(),
                    StepNo = 5,
                    StepName = "KhuVucCho",
                    RequestScanIn = Core.GlobalConstants.RequestScanValue.No,
                    RequestScanOut = Core.GlobalConstants.RequestScanValue.No,
                    Status = Core.GlobalConstants.StatusValue.Using,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                }
            };

            foreach (var Step in Steps)
                projectDataContext.Steps.Add(Step);
            #endregion


            #region Add Product
            string partNumber1 = "Product_01";
            string partNumber2 = "Product_02";
            string partNumber3 = "Product_03";
            var products = new List<Product>
            {
                new Product
                {
                    Id = Guid.NewGuid().ToString(),
                    PartNumber = partNumber1,
                    ProductName = partNumber1,
                    UnitId = unit1,
                    Status = Core.GlobalConstants.StatusValue.Using,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new Product
                {
                    Id = Guid.NewGuid().ToString(),
                    PartNumber = partNumber2,
                    ProductName = partNumber2,
                    UnitId = unit1,
                    Status = Core.GlobalConstants.StatusValue.Using,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new Product
                {
                    Id = Guid.NewGuid().ToString(),
                    PartNumber = partNumber3,
                    ProductName = partNumber3,
                    UnitId = unit1,
                    Status = Core.GlobalConstants.StatusValue.Using,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                }
            };

            foreach (var product in products)
                projectDataContext.Products.Add(product);
            #endregion


            #region Add Product Matrix
            var productMatrixs = new List<ProductMatrix>
            {
                new ProductMatrix
                {
                    Id = Guid.NewGuid().ToString(),
                    PartNumber = partNumber1,
                    StepNo = 1,
                    DryingTime = 8,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new ProductMatrix
                {
                    Id = Guid.NewGuid().ToString(),
                    PartNumber = partNumber1,
                    StepNo = 2,
                    DryingTime = 24,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new ProductMatrix
                {
                    Id = Guid.NewGuid().ToString(),
                    PartNumber = partNumber1,
                    StepNo = 3,
                    DryingTime = 0,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new ProductMatrix
                {
                    Id = Guid.NewGuid().ToString(),
                    PartNumber = partNumber1,
                    StepNo = 4,
                    DryingTime = 8,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new ProductMatrix
                {
                    Id = Guid.NewGuid().ToString(),
                    PartNumber = partNumber1,
                    StepNo = 5,
                    DryingTime = 24,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                }, new ProductMatrix
                {
                    Id = Guid.NewGuid().ToString(),
                    PartNumber = partNumber2,
                    StepNo = 1,
                    DryingTime = 8,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new ProductMatrix
                {
                    Id = Guid.NewGuid().ToString(),
                    PartNumber = partNumber2,
                    StepNo = 2,
                    DryingTime = 24,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new ProductMatrix
                {
                    Id = Guid.NewGuid().ToString(),
                    PartNumber = partNumber2,
                    StepNo = 3,
                    DryingTime = 0,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new ProductMatrix
                {
                    Id = Guid.NewGuid().ToString(),
                    PartNumber = partNumber2,
                    StepNo = 4,
                    DryingTime = 24,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new ProductMatrix
                {
                    Id = Guid.NewGuid().ToString(),
                    PartNumber = partNumber2,
                    StepNo = 5,
                    DryingTime = 0,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                }
            };

            foreach (var productMatrix in productMatrixs)
                projectDataContext.ProductMatrices.Add(productMatrix);
            #endregion


            #region Add RegistBarcode
            var RegistBarcodes = new List<RegistBarcode>
            {
                new RegistBarcode
                {
                    Id = Guid.NewGuid().ToString(),
                    RegistDate = DateTime.Now,
                    PartNumber = partNumber1,
                    SEQ = "0001",
                    LOT = "01",
                    Barcode = String.Format("{0}{1}{2}", partNumber1, DateTime.Now.ToString("yyMMdd"), "0001"),
                    Status = Core.GlobalConstants.StatusValue.Using,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new RegistBarcode
                {
                    Id = Guid.NewGuid().ToString(),
                    RegistDate = DateTime.Now,
                    PartNumber = partNumber1,
                    SEQ = "0002",
                    LOT = "01",
                    Barcode = String.Format("{0}{1}{2}", partNumber1, DateTime.Now.ToString("yyMMdd"), "0002"),
                    Status = Core.GlobalConstants.StatusValue.Using,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new RegistBarcode
                {
                    Id = Guid.NewGuid().ToString(),
                    RegistDate = DateTime.Now,
                    PartNumber = partNumber1,
                    SEQ = "0003",
                    LOT = "01",
                    Barcode = String.Format("{0}{1}{2}", partNumber1, DateTime.Now.ToString("yyMMdd"), "0003"),
                    Status = Core.GlobalConstants.StatusValue.Using,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new RegistBarcode
                {
                    Id = Guid.NewGuid().ToString(),
                    RegistDate = DateTime.Now,
                    PartNumber = partNumber2,
                    SEQ = "0001",
                    Barcode = String.Format("{0}{1}{2}", partNumber2, DateTime.Now.ToString("yyMMdd"), "0001"),
                    Status = Core.GlobalConstants.StatusValue.Using,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new RegistBarcode
                {
                    Id = Guid.NewGuid().ToString(),
                    RegistDate = DateTime.Now,
                    PartNumber = partNumber2,
                    SEQ = "0002",
                    Barcode = String.Format("{0}{1}{2}", partNumber2, DateTime.Now.ToString("yyMMdd"), "0002"),
                    Status = Core.GlobalConstants.StatusValue.Using,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new RegistBarcode
                {
                    Id = Guid.NewGuid().ToString(),
                    RegistDate = DateTime.Now,
                    PartNumber = partNumber2,
                    SEQ = "0003",
                    Barcode = String.Format("{0}{1}{2}", partNumber2, DateTime.Now.ToString("yyMMdd"), "0003"),
                    Status = Core.GlobalConstants.StatusValue.Using,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                },
                new RegistBarcode
                {
                    Id = Guid.NewGuid().ToString(),
                    RegistDate = DateTime.Now,
                    PartNumber = partNumber3,
                    SEQ = "0001",
                    Barcode = String.Format("{0}{1}{2}", partNumber3, DateTime.Now.ToString("yyMMdd"), "0001"),
                    Status = Core.GlobalConstants.StatusValue.Using,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Administrator"
                }
            };

            foreach (var RegistBarcode in RegistBarcodes)
                projectDataContext.RegistBarcodes.Add(RegistBarcode);
            #endregion
        }
    }
}
