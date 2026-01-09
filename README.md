 Zoom Attendance App
 Loyiha haqida

**Zoom Attendance App** — bu Zoom darslari yoki yig‘ilishlarida qatnashuvchilarni boshqarish uchun yaratilgan **C# Console Application**. Ushbu loyiha orqali foydalanuvchilarni ko‘rish, qidirish, qo‘shish, o‘chirish va tahlil qilish mumkin.

Loyiha **Clean Architecture** tamoyillariga yaqin holda tashkil etilgan bo‘lib, `Domain`, `Application`, `Infrastructure` qatlamlariga ajratilgan.

---

## 🛠 Texnologiyalar

* **C# (.NET Console Application)**
* **EPPlus** (Excel bilan ishlash uchun)
* **LINQ**
* **OOP (Encapsulation, Abstraction)**
 Loyiha strukturasi

ZoomAttendanceApp
│
├── Domain
│   └── Models
│       └── ExternalAttendance.cs
│
├── Application
│   └── Services
│       ├── StudentServise.cs
│       ├── AttendanceService.cs
│       └── ExternalAttendanceService.cs
│
├── Infrastructure
│   └── Data
│       └── ExcelContext.cs
│
└── Program.cs

> **Eslatma:** `FullNameWithCode` maydoni masalan: `Eldor Roziyev 1244` — oxirgi raqam **student code** sifatida ishlatiladi.

## ▶️ Dasturni ishga tushirish

1. Repozitoriyani clone qiling:
git clone https://github.com/username/ZoomAttendanceApp.git


2. Visual Studio orqali oching
3. `Program.cs` faylini ishga tushiring
4. Konsolda menyu orqali ishlang

## 👨‍💻 Muallif

**Eldor**
C# Backend Developer (Junior)











