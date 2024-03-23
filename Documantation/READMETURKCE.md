# Currency MVC

Bu MVC projesi, [CurrencyWebAPI](https://github.com/tunahankilic48/CurrencyWebAPI) projesinden gelen verileri görselleþtirmeyi amaçlamaktadýr. Bunun için bir MVC projesi oluþturulmuþ, veriler API'dan çekilmiþ ve basit bir þekilde listelenmiþtir.

## Teknolojiler ve paketler

- .Net 8.0
- EntitiyFramework
- SignalR

## Baþlarken

Verilerin alýnabilmesi için program [CurrencyWebAPI](https://github.com/tunahankilic48/CurrencyWebAPI) projesi ile birlikte çalýþtýrýlmalýdýr. Verilerin doðru endpointten alýnabilmesi içinse [Currency Controller](https://github.com/tunahankilic48/CurrencyMVC/blob/master/CurrencyMVC/Controllers/CurrencyController.cs) içindeki ve currencyvalue [CurrencyValue.cshtml](https://github.com/tunahankilic48/CurrencyMVC/blob/master/CurrencyMVC/Views/Currency/CurrencyValue.cshtml) dosyasý içinde bulunan 28. satýrdaki url, Web API'nin URL'i ile deðiþtirilmelidir.

# Currency MVC