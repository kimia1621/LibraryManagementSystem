# Library Management System 📚

یک پروژه ساده‌ی API با استفاده از ASP.NET Core و Entity Framework برای مدیریت کتابخانه.

این پروژه شامل قابلیت‌های:
- احراز هویت ساده (Basic Authentication)
- انجام عملیات CRUD برای مدیریت کتاب‌ها

می‌باشد و با اصول برنامه‌نویسی شی‌گرا (OOP) پیاده‌سازی شده است.

---

## ویژگی‌ها ✨

- ساختار تمیز و قابل فهم
- احراز هویت پایه (Basic)
- ثبت، ویرایش، حذف و مشاهده کتاب‌ها
- پیاده‌سازی شده با ASP.NET Core 6 و Entity Framework Core

---

## تکنولوژی‌های استفاده شده 🛠

- ASP.NET Core
- Entity Framework Core
- C#
- LINQ
- Basic Authentication

---

## نحوه اجرا ⚙️

1. پروژه را Clone کنید:
   ```bash
   git clone https://github.com/your-username/your-repository-name.git
   
2. پروژه را در Visual Studio یا VS Code باز کنید.

3. پایگاه داده را ایجاد کنید:

- از Package Manager Console استفاده کنید و دستور زیر را وارد کنید:

  ```
  Update-Database
  ```

4. برنامه را اجرا کنید.  
می‌توانید با ابزارهایی مانند Postman، API را تست کنید.

---

## 🔌 مسیرهای API
GET /api/books دریافت لیست کتاب‌ها
GET /api/books/{id} دریافت اطلاعات یک کتاب
POST /api/books افزودن کتاب جدید
PUT /api/books/{id} ویرایش اطلاعات کتاب
DELETE /api/books/{id} حذف کتاب

> برای استفاده از این مسیرها باید احراز هویت Basic انجام شود.

---

## 👩‍💻 اعضای تیم

- کیمیا آدل‌فر  
- مرضیه تاجایی  

---

## 📄 لایسنس

این پروژه صرفاً برای اهداف آموزشی دانشگاهی تهیه شده و فاقد لایسنس رسمی است.


