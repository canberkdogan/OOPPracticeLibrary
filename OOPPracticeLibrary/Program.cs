using OOPPracticeLibrary;

Library book1 = new Library();
book1 = new Library("Adı Aylin", "Ayşe", "Kulin",398 ,"Remzi Kitabevi" );

Library book2 = new Library();

book2.Bookname = "Modern Ortadoğu Tarihi";
book2._authorName = "William Lennon";
book2._authorSurname = "Cleveland";
book2.PageNum = 634;
book2.Publisher = "Agora Kitaplığı";


book1.DisplayProduct();
book2.DisplayProduct();



/*
1. Sınıflar (Classes)
OOP'de sınıf, bir nesnenin şablonudur. İçinde özellikler ve davranışlar tanımlanır. Nesneler, bu sınıflardan oluşturulur.

2. Özellikler (Properties)
Özellikler, bir nesnenin durumunu temsil eden verilere kontrollü erişim sağlar. get ve set erişimcileri ile veriler okunabilir veya yazılabilir.

3. new Anahtar Kelimesi
new anahtar kelimesi, bir sınıftan yeni bir nesne oluşturur ve bellekte bu nesne için yer ayırır.

4. Yapıcılar (Constructors)
Yapıcılar, bir nesne ilk oluşturulduğunda çalışan özel metotlardır. Nesnenin başlangıç durumunu ayarlamak için kullanılırlar.
*/

