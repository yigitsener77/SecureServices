# 🔐 SecureServices

`SecureServicesr`, C# projelerinde güvenli bir şekilde RESTful API'lere bağlanmayı kolaylaştırmak için geliştirilmiş yardımcı bir sınıftır. JWT Token, Bearer veya API Key ile yetkilendirme işlemlerini destekler.

---

## 🚀 Özellikler

- ✅ HTTP GET, POST, PUT, DELETE desteği
- 🔐 Bearer Token / API Key ile güvenli bağlantı
- 🌐 Base URL desteği
- 📦 JSON desteği (Newtonsoft.Json)
- 🧾 Basit hata ve yanıt yönetimi

---

## 🛠️ Kurulum

Proje klasörünüzde aşağıdaki komutları kullanarak yapılandırabilirsiniz:

```bash
dotnet new console -n SecureServices
cd SecureServices
dotnet add package Newtonsoft.Json
