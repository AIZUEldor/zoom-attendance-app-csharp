# 📊 Zoom Attendance Console Application  
Zoom darslaridagi qatnashuvchilar ma’lumotlarini CSV/Excel fayldan o‘qib, ular bo‘yicha qidiruv, filtr, statistika va tahlillarni ko‘rsatib beradigan C# Console dastur.

---

## 🧩 Loyihaning asosiy imkoniyatlari

### ✔ Barcha qatnashuvchilarni ko‘rish  
### ✔ Ism bo‘yicha qidirish  
### ✔ Email bo‘yicha qidirish  
### ✔ Faqat mehmonlarni ko‘rish (Host)  
### ✔ Kutish zalida bo‘lganlarni ko‘rish (Waiting Room)  
### ✔ Eng ko‘p qatnashgan TOP-5 ishtirokchilar  
### ✔ Umumiy qatnashuvchilar sonini ko‘rish  
### ✔ CSV/Excel fayldan avtomatik o‘qish  

---

## 📁 Loyihaning Arxitekturasi (Clean Architecture modeli)

ZoomAttendanceApp
│
├── ZoomAttendanceApp.Domain
│ └── Models
│ ├── Attendance.cs
│ ├── ExternalAttendance.cs
│ └── Student.cs
│
├── ZoomAttendanceApp.Infrastructure
│ └── Data
│ └── ExcelContext.cs ← CSV/Exceldan ma’lumot o‘quvchi qatlam
│
├── ZoomAttendanceApp.Application
│ └── Services
│ ├── AttendanceService.cs
│ └── ExternalAttendanceService.cs ← Filtr, qidiruv va tahlillar shu yerda
│
└── ZoomAttendanceApp.Client
└── Program.cs ← Menyuli Console UI

yaml
Копировать код

---

## 🎮 Konsol dasturi menyusi

========================================
ZOOM ATTENDANCE BOSHQARUV MENYUSI
Barcha qatnashuvchilarni ko‘rish

Ism bo‘yicha qidirish

Email bo‘yicha qidirish

Faqat mehmonlarni ko‘rish

Kutish zalida bo‘lganlarni ko‘rish

Eng ko‘p qatnashganlarni ko‘rish

Qatnashuvchilar sonini ko‘rish

Dasturdan chiqish

yaml
Копировать код

---

## 📦 O‘rnatish va Ishga Tushirish

### 1️⃣ Repozitoriyani yuklab olish

```bash
git clone https://github.com/<your-username>/ZoomAttendanceApp.git
2️⃣ CSV/Excel faylni joylashtirish
Faylni shu adresga qo‘ying:

makefile
Копировать код
C:\Users\Acer\Desktop\Attandence\fixed_attendance.csv
Dastur avtomatik o‘qiydi.

3️⃣ Dastur ishga tushirish
arduino
Копировать код
cd ZoomAttendanceApp/ZoomAttendanceApp.Client
dotnet run
📚 Texnologiyalar
C# .NET 8

Clean Architecture

CSV/Excel o‘qish

Console UI

Layered Architecture (Domain–Infrastructure–Application–Client)

🧠 Foydalanish maqsadi
Bu dastur quyidagilar uchun juda qulay:

👨‍🏫 O‘qituvchilar — dars qatnashuvini tekshirish

🏫 Universitet va maktablar — Zoom statistikasi

📈 Tahlilchilar — ishtirokchilarning davomiyligini tahlil qilish

🧑‍💻 Backend o‘rganuvchilar — arxitekturani o‘rganish

🏗 Kelajakdagi rejalar
 Excelga hisobot yozib berish

 Grafik statistikalar (pie chart, bar chart)

 Web API versiyasi

 Telegram bot orqali natijalarni chiqarish

🤝 Muallif
Eldor Ro‘ziyev
GitHub: https://github.com/<your-username>

Agar loyiha yoqsa ⭐ yulduzcha bosing!

yaml
Копировать код

---

# 📌 Xohlasang README ichiga **GIF qo‘shib beraman**  
Masalan:

- Dastur qanday ishlashini ko‘rsatadigan terminal GIF
- Arxitektura diagrammasi
- Fayl o‘qilishi jarayoni

Agar xohlasang GIF yasab, README ichiga joylab ham beraman.






