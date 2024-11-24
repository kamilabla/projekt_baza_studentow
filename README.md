# ASP.NET MVC - Baza Studentów

## Opis projektu

Projekt to aplikacja webowa napisana w technologii **ASP.NET MVC**, która pozwala na zarządzanie bazą danych studentów. Umożliwia dodawanie, edytowanie, usuwanie oraz przeglądanie informacji o studentach oraz pracownikach. Aplikacja może być używana np. w systemach zarządzania uczelniami lub innymi instytucjami edukacyjnymi.

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

- **Strona startowa**
  Na stronie startowej mamy możliwość przejść do jednej z dostępnych zakładek.
  
<img width="839" alt="image" src="https://github.com/user-attachments/assets/32efbbbc-a1ba-4e14-a87b-149cffa43d8f">

- **Wyświetlanie listy studentów**  
  W zakładce 'Student' mamy możliwość sortowania i filtrowania danych studentów.
  
<img width="799" alt="image" src="https://github.com/user-attachments/assets/893b57ca-58b9-4ab8-8325-8855daacb9e8">

  Analogicznie w zakładce 'Pracownik'.

  <img width="794" alt="image" src="https://github.com/user-attachments/assets/9ccacfc5-e738-4549-9a5d-403dc29f408e">


- **Dodawanie nowych studentów**  
  Formularz umożliwiający wprowadzenie informacji takich jak: imię, nazwisko, data dołączenia oraz nazwę grupy studenta.

  <img width="312" alt="image" src="https://github.com/user-attachments/assets/4f301430-90c3-4cfd-98be-8f01b7571f56">

- **Edytowanie istniejących danych**  
  Edycja danych studenta poprzez formularz.

<img width="314" alt="image" src="https://github.com/user-attachments/assets/1539bf07-d68e-407f-b0a9-518061bf0e64">

- **Usuwanie studentów oraz pracowników**  
  Usuwanie rekordów z bazy.
  
<img width="389" alt="image" src="https://github.com/user-attachments/assets/a63fb873-dab9-4e6e-80d8-1b483732f86f">

- **Szczegóły studenta**  
  Widok prezentujący szczegółowe informacje o wybranym studencie.
  
<img width="257" alt="image" src="https://github.com/user-attachments/assets/957a791c-311e-41b7-bbcb-031ef5681014">

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

