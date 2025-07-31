
# 📚 EduCore

EduCore là hệ thống quản lý khóa học gồm Backend (ASP.NET Core) và Frontend (Razor Pages). Ứng dụng được chia theo mô hình nhiều tầng rõ ràng: Domain, Application, Infrastructure, Presentation và FrontEnd.

---


## 📁 Cấu trúc thư mục

```
EduCore
│
├── BackEnd
│   ├── Application
│   ├── Application.Tests
│   ├── Domain
│   ├── Infrastructure
│   └── Presentation
│
├── FrontEnd
│   └── RazorPageApp
│
└── README.md
```

---

## 🚀 Hướng dẫn thiết lập dự án

### ✅ Yêu cầu:

- [.NET 8 SDK](https://dotnet.microsoft.com/download)
- SQL Server hoặc Docker
- Visual Studio / VS Code

---

## 🐳 Run SQL Server with Docker (Optional)

```powershell
$sa_password ="[sa password here]"
docker run -e "ACCEPT_EULA=Y" -e "MSSQL_SA_PASSWORD=$sa_password" `
    -p 1433:1433 -v sqlvolume:/var/opt/mssql `
    -d --rm --name mssql `
    mcr.microsoft.com/mssql/server:2022-latest
```

---

## 🔐 Cấu hình chuỗi kết nối bằng User Secrets

### Bước 1: Di chuyển đến thư mục chứa project `Presentation.csproj`

```bash
cd BackEnd/Presentation
dotnet user-secrets init
```

### Bước 2: Thêm chuỗi kết nối một cách an toàn

```powershell
# Nhập mật khẩu
$sa_password ="[sa password here]"
# Lưu vào user-secrets
dotnet user-secrets set "ConnectionStrings:DefaultConnection" "Server=localhost;Database=EduCoreDb;User Id=sa;Password=$sa_password;TrustServerCertificate=True"

## 🧪 Chạy ứng dụng

```bash
# Cập nhật database (EF Core)
dotnet ef database update --project Infrastructure --startup-project Presentation

# Chạy start up multi project vs hoặc chạy từng project  Backend
dotnet run --project BackEnd/Presentation

# (Tùy chọn) Chạy Frontend Razor Pages
dotnet run --project FrontEnd/RazorPageApp
```

---

## 🧪 Unit Test

```bash
dotnet test BackEnd/Application.Tests
```

---

## 📦 Các lệnh thường dùng

| Lệnh | Mô tả |
|------|-------|
| `dotnet restore` | Phục hồi package |
| `dotnet build` | Biên dịch solution |
| `dotnet run --project <project>` | Chạy project |
| `dotnet ef migrations add <name>` | Tạo migration mới |
| `dotnet ef database update` | Cập nhật DB theo migration |

---

## 📌 Ghi chú

- User Secrets lưu tại:
  - Windows: `%APPDATA%\Microsoft\UserSecrets`
  - macOS/Linux: `~/.microsoft/usersecrets`
- Secrets chỉ dùng cho **phát triển (development)**, không triển khai sản phẩm.

---

## 📮 Liên hệ

- Dev: [Your Name]
- Email: [youremail@example.com]

---

> © 2025 EduCore Project. All rights reserved.
