# HouseRent

## Opis
Aplikacja HouseRent umożliwia za pomocą formularzy dodawanie, edytowanie oraz usuwanie domków. Formularze zawierają walidacje.\
Dostęp do formularzy mają jedynie użytkownicy zalogowani. Niezalogowani mogą jedynie przeglądać listę domków oraz korzystać z wyszukiwania.\
Dodatkowo aplikacja zawiera WebAPI REST, testy jednostkowe oraz wyszukiwanie na podstawie nazwy.

## Instalacja
1. W pliku [appsettings.json](./HouseRent/appsettings.json) w parametrze `DefaultConnection` zmienić ścieżkę do bazy danych `Server=<DOMYŚLNA BAZA DANYCH>`.
```json
"DefaultConnection": "Server=<DOMYŚLNA BAZA DANYCH>;Database=aspnet-HouseRent-8BD7900E-0FB0-4160-A41D-3E94FF90760D;Trusted_Connection=True;MultipleActiveResultSets=true""
```
