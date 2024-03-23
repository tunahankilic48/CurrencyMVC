# Currency MVC

Bu MVC projesi, [CurrencyWebAPI](https://github.com/tunahankilic48/CurrencyWebAPI) projesinden gelen verileri görselleştirmeyi amaçlamaktadır. Bunun için bir MVC projesi oluşturulmuş, veriler API'dan çekilmiş ve basit bir şekilde listelenmiştir.

## Teknolojiler ve paketler

- .Net 8.0
- EntitiyFramework
- SignalR

## Başlarken

Verilerin alınabilmesi için program [CurrencyWebAPI](https://github.com/tunahankilic48/CurrencyWebAPI) projesi ile birlikte çalıştırılmalıdır. Verilerin doğru endpointlerden alınabilmesi içinse [Currency Controller](https://github.com/tunahankilic48/CurrencyMVC/blob/master/CurrencyMVC/Controllers/CurrencyController.cs) içindeki URL'ler ve [CurrencyValue.cshtml](https://github.com/tunahankilic48/CurrencyMVC/blob/master/CurrencyMVC/Views/Currency/CurrencyValue.cshtml) dosyası içinde bulunan 28. satırdaki URL, Web API'nin URL'i ile değiştirilmelidir.

# Currency MVC
