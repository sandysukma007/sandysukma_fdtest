Book Management App
Aplikasi sederhana berbasis ASP.NET Core MVC untuk mengelola data buku, dilengkapi fitur CRUD, validasi, notifikasi, filtering, sorting, pagination, landing page publik, serta unit test dengan xUnit.

Cara Menjalankan Aplikasi
Clone repo:
git clone https://github.com/sandysukma007/sandysukma_fdtest.git

Jalankan migrasi database (jika belum):
Add-Migration Init
Update-Database

Jalankan aplikasi:
dotnet run

Buka browser dan akses:
https://localhost:44370

Menjalankan Unit Test
Pindah ke folder test (jika terpisah):
cd sandysukma_fdtest.Tests
Jalankan test:
dotnet test

Dependency yang Digunakan
ASP.NET Core MVC

Entity Framework Core (InMemory)
xUnit
Bootstrap 5
SweetAlert2
Microsoft.AspNetCore.Mvc.Testing

🖼️ Fitur Aplikasi
✅ Autentikasi user (Login/Logout)
✅ CRUD Buku (Tambah, Edit, Detail, Hapus)
✅ Upload Cover Buku
✅ Validasi Form (SweetAlert)
✅ Filter buku berdasarkan Judul, Penulis, Tanggal Upload, dan Rating
✅ Sorting Kolom
✅ Pagination (5 data per halaman)
✅ Landing Page khusus unauthenticated user
✅ Unit Testing dengan xUnit
