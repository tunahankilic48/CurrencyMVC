# Currency MVC

Bu MVC projesi, [CurrencyWebAPI](https://github.com/tunahankilic48/CurrencyWebAPI) projesinden gelen verileri g�rselle�tirmeyi ama�lamaktad�r. Bunun i�in bir MVC projesi olu�turulmu�, veriler API'dan �ekilmi� ve basit bir �ekilde listelenmi�tir.

## Teknolojiler ve paketler

- .Net 8.0
- EntitiyFramework
- SignalR

## Ba�larken

Verilerin al�nabilmesi i�in program [CurrencyWebAPI](https://github.com/tunahankilic48/CurrencyWebAPI) projesi ile birlikte �al��t�r�lmal�d�r. Verilerin do�ru endpointten al�nabilmesi i�inse [Currency Controller](https://github.com/tunahankilic48/CurrencyMVC/blob/master/CurrencyMVC/Controllers/CurrencyController.cs) i�indeki ve currencyvalue [CurrencyValue.cshtml](https://github.com/tunahankilic48/CurrencyMVC/blob/master/CurrencyMVC/Views/Currency/CurrencyValue.cshtml) dosyas� i�inde bulunan 28. sat�rdaki url, Web API'nin URL'i ile de�i�tirilmelidir.

# Currency MVC