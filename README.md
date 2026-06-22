# CinemaApp - System Rezerwacji Biletów Kinowych

Prosta, konsolowa aplikacja zrealizowana w języku C# (w paradygmacie programowania obiektowego - OOP). System umożliwia interaktywne zarządzanie salą kinową oraz rezerwację miejsc na konkretny seans w czasie rzeczywistym, oferując czytelną tekstową wizualizację sali.

## 🚀 Główne Funkcje

* **Architektura Sterowana Obiektowo (OOP):** Wykorzystanie kompozycji klas (`Film`, `Miejsce`, `Seans`, `KinoSystem`) do odwzorowania realnych struktur biznesowych.
* **Abstrakcja Logiki Systemowej:** Cały "silnik" aplikacji został ukryty w klasie `KinoSystem`, dzięki czemu plik uruchomieniowy `Program.cs` zawiera jedynie czystą instrukcję startową.
* **Graficzny Podgląd Sali Kinowej:** Wyświetlanie aktualnego układu foteli w postaci siatki rzędów (miejsca wolne oznaczone jako `[ ]`, zajęte jako `[X]`).
* **Odporność na Błędy (Walidacja danych):** System zabezpiecza aplikację przed wprowadzeniem błędnych znaków (np. liter w menu wyboru) przy użyciu bezpiecznego parsowania `int.TryParse`.
* **Zarządzanie Stanem:** Blokowanie ponownej rezerwacji tego samego (zajętego) miejsca oraz walidacja zakresu rzędów i foteli.

## 📁 Struktura Projektu

* **`Program.cs`** - Punkt wejścia do aplikacji (wywołuje zaledwie jedną metodę, uruchamiając fasadę systemu).
* **`KinoSystem.cs`** - Główny kontroler aplikacji zarządzający pętlą interakcji, czyszczeniem ekranu oraz komunikacją z użytkownikiem (UI).
* **`Seans.cs`** - Klasa przechowująca dane o filmie, dacie oraz liście 50 wygenerowanych dynamicznie miejsc. Odpowiada za logikę biznesową rezerwacji.
* **`Miejsce.cs`** - Model pojedynczego fotela kinowego, przechowujący jego współrzędne (rząd, numer) oraz stan (`CzyZajete`).
* **`Film.cs`** - Model przechowujący podstawowe metadane o tytule, czasie trwania i gatunku filmu.

## 💻 Wygląd Interfejsu

Aplikacja renderuje w oknie konsoli przejrzysty układ sali kinowej:


Rezerwacja biletów do kina
Seans: Incepcja, Kiedy: 2026-06-22 18:00:00

--- EKRAN KINA ---

[ ] [ ] [ ] [ ] [ ] [ ] [ ] [ ] [ ] [ ]
[ ] [ ] [ ] [X] [ ] [ ] [ ] [ ] [ ] [ ]
[ ] [ ] [ ] [ ] [ ] [ ] [ ] [ ] [ ] [ ]
[ ] [ ] [ ] [ ] [ ] [X] [ ] [ ] [ ] [ ]
[ ] [ ] [ ] [ ] [ ] [ ] [ ] [ ] [ ] [ ]

------------------
1. Zarezerwuj bilet
2. Wyjdź

🛠️ Jak uruchomić projekt
Upewnij się, że masz zainstalowane środowisko .NET SDK (w wersji 6.0, 7.0 lub nowszej).

Sklonuj repozytorium lub pobierz pliki źródłowe do jednego folderu.

Otwórz terminal / wiersz poleceń w folderze z projektem.

Uruchom aplikację wpisując polecenie:

dotnet run