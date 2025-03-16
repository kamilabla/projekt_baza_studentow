# ASP.NET MVC - Baza Studentów

## Description

Projekt to aplikacja webowa napisana w technologii **ASP.NET MVC**, która pozwala na zarządzanie bazą danych studentów. Umożliwia dodawanie, edytowanie, usuwanie oraz przeglądanie informacji o studentach oraz pracownikach. Aplikacja może być używana np. w systemach zarządzania uczelniami lub innymi instytucjami edukacyjnymi.

Web application written using **ASP.NET MVC**, which enables managing a database of students' information. It allows adding, editing, deleting and looking through information about students and staff. This application could potentially be used in academic systems or other educational institutions.

## Project structure

- **`Controllers/`**  
  Kontrolery odpowiedzialne za logikę aplikacji. Zarządzają żądaniami HTTP i odpowiadają za przekazywanie danych do widoków.

  Controllers are responsible for logic behind application. They manage HTTP requests and transfer data to Views.

- **`Models/`**  
  Modele danych i klasy Entity Framework. Odpowiadają za strukturę danych i logikę biznesową aplikacji.

  Models are responsible for data structure and business logic of the application.

- **`Views/`**  
  Widoki (HTML + Razor) używane do prezentacji danych użytkownikowi. Zawierają pliki odpowiadające za interfejs użytkownika.

  Views are used to present data to the user (user interface).

- **`Program.cs`**  
  Punkt wejścia aplikacji, odpowiedzialny za uruchomienie serwera.

  Main point of the application, responsible for launching server.

- **`Data/`**  
  Folder zawierający klasy związane z obsługą bazy danych, takie jak kontekst Entity Framework (`DbContext`).

  Directory containing classes that are related to database management, like Entity Framework context.


## Funkcjonalności

- **Strona startowa**
  Na stronie startowej mamy możliwość przejść do jednej z dostępnych zakładek.
  
<img width="839" alt="image" src="https://github.com/user-attachments/assets/32efbbbc-a1ba-4e14-a87b-149cffa43d8f">

- **Wyświetlanie listy studentów**  
  W zakładce 'Student' mamy możliwość edytowania i usuwania danych studentów.
  
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

- **Kamila Błaszczyna**  [https://github.com/kamilabla]

-  **Kinga Alibożek**  https://github.com/kingaa1]

