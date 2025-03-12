// See https://aka.ms/new-console-template for more information
using AACsharp_Assignment_Access_Modifiers;

Console.WriteLine("Hello, World!");


User user = new User();

user.setAdSoyad("Celal KORUCU");
user.setYas(23);
user.email = "celalkorucu@gmail.com";

user.bilgileriGoster();

// Public : Her yerden erişebileceğimiz değerler
// Private : Yalnızca bulunduğumumz dosyadaki değerlere erişebilmemizi sağlayan keyword
// Protected : Sadece tanımlı sınıf ve ondan miraz alan değerler
// internal : Aynı proje içerisinde yer alanlar erişebilir

// OOP'deki rolü : Erişim belirleyiciler kapsülleme kısmında kullanılır
// Veri gizliliği ve kod güvenliği sağlar