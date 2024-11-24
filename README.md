# ASP.NET MVC - Baza Studentów

## Opis projektu

Projekt to aplikacja webowa napisana w technologii **ASP.NET MVC**, która pozwala na zarządzanie bazą danych studentów. Umożliwia dodawanie, edytowanie, usuwanie oraz przeglądanie informacji o studentach. Aplikacja może być używana np. w systemach zarządzania uczelniami lub innymi instytucjami edukacyjnymi.

## Struktura projektu

- **`Controllers/`**  
  Kontrolery odpowiedzialne za logikę aplikacji. Zarządzają żądaniami HTTP i odpowiadają za przekazywanie danych do widoków.

- **`Models/`**  
  Modele danych i klasy Entity Framework. Odpowiadają za strukturę danych i logikę biznesową aplikacji.

- **`Views/`**  
  Widoki (HTML + Razor) używane do prezentacji danych użytkownikowi. Zawierają pliki odpowiadające za interfejs użytkownika.

- **`wwwroot/`**  
  Zasoby statyczne, takie jak pliki CSS, JavaScript, obrazy, ikony, itp.

- **`Migrations/`**  
  Pliki migracji generowane przez Entity Framework, używane do zarządzania zmianami w strukturze bazy danych.

- **`appsettings.json`**  
  Plik konfiguracyjny aplikacji, zawierający ustawienia, takie jak ConnectionString do bazy danych.

- **`Startup.cs`**  
  Plik startowy aplikacji, definiujący konfigurację aplikacji, rejestrowanie usług i middleware.

- **`Program.cs`**  
  Punkt wejścia aplikacji, odpowiedzialny za uruchomienie serwera.

- **`Data/`**  
  Folder zawierający klasy związane z obsługą bazy danych, takie jak kontekst Entity Framework (`DbContext`).


## Funkcjonalności

- **Wyświetlanie listy studentów**  
  Możliwość sortowania i filtrowania danych.

- **Dodawanie nowych studentów**  
  Formularz umożliwiający wprowadzenie informacji takich jak: imię, nazwisko, numer indeksu, wydział, kierunek studiów.

- **Edytowanie istniejących danych**  
  Edycja danych studenta poprzez formularz.

- **Usuwanie studentów oraz pracowników**  
  Usuwanie rekordów z bazy.

- **Szczegóły studenta**  
  Widok prezentujący szczegółowe informacje o wybranym studencie.

## Technologie i narzędzia

- **ASP.NET MVC**  
  Framework webowy użyty do budowy aplikacji.

- **Entity Framework**  
  Do obsługi bazy danych i ORM.

- **SQL Server**  
  Relacyjna baza danych do przechowywania informacji o studentach.

- **Visual Studio**  
  IDE użyte do rozwoju aplikacji.

## Rozszerzenia

Możliwe przyszłe funkcjonalności:

- **Autoryzacja i uwierzytelnianie użytkowników**  
  Logowanie administratorów i innych użytkowników.

- **Eksport danych studentów do pliku**  
  Obsługa formatów CSV, Excel, PDF.

- **Import danych z pliku CSV**  
  Wczytywanie danych studentów z pliku.

- **Obsługa wielu języków (internationalization)**  
  Tłumaczenie aplikacji na różne języki.

## Autorzy

- **Imię i Nazwisko**  
  Kamila Błaszczyna  
  [https://github.com/kamilabla]

  Kinga Alibożek
  [https://github.com/kingaa1]

