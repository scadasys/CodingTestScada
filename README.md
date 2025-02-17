### A szakmai feladat

Ebben a szakmai feladatban egy program frissítő alkalmazást kell befejeznie. A programnak képesnek kell lennie egy megadott útvonalon az egyes verziókat leellenőrzive frissítenie egy másik fő programot. A metódusok és környezet mind már meg van valósítva, önnek csak ezeket kell a metódusokat kell kiegészítse, hogy a tesztek helyesen lefussanak.

### Megvalósítandó metódusok:
- CheckForUpdate() - Ez a metódus igazat vagy hamisat ad vissza, attól függően, hogy a megadott *mainAppPath* elérési útvonalon régebbi program van-e, mint a *versionsFolder*-ben szereplő alkalmazások.
- GetLatestVersionPath() - Ez a metódus visszaadja a legnagyobb verziószámú program elérési útvonalát a *versionsFolder* mappában. Ennek az elérési útvonalnak relatívnak kell lennie a frissítő program dll/exe-jéhez.
- GetExeVersion(string exepath) - Ez a metódus visszaadja a megadott *exePath* program verziószámát.
- PromptUserForUpdate() - Ez a metódus megkérdezi a felhasználót, hogy akar-e frissíteni, vagy halassza későbbre.

### A program felépítése
📂 CodingTestScada/
│── 📂 ProgramVersions/   # Itt található az összes elérhető verzió
│   │── program_v1.0.exe
│   │── program_v1.1.exe
│   │── program_v1.2.exe
│
│── 📂 Main/              # Az éppen futó verzió
│   │── program.exe
│
│── Program.cs # A kiegészitendő programkód
│── UnitTest.cs # A teszteket tartalmazó programkód
│
│── 📂 bin/Debug(/Release)/net/ # A fordított program helye

## Telepítés, fejlesztés és tesztelés
A .NET SDK szükséges a fejlesztéshez, ennek telepítése operációs rendszerekre bontva:
- Windows/Linux/MacOS: https://dotnet.microsoft.com/en-us/download
- Linux: sudo apt update && sudo apt install dotnet-sdk-8.0
- MacOS: brew install dotnet-sdk

Terminálban használt parancsok:
- *dotnet build* - A program fordítása a Debug/Release mappába
- *dotnet test* - Fordítás után a tesztek futtatása
- *dotnet run* - A fordított program inditása
- *dotnet clean* - Törli a fordított állományokat.

## Elkészített feladat
Ha elkészült a feladat megvalósításával, kérem futtassa le a *dotnet clean* parancsot és küldje el a projektkönyvtárat bezippelve vagy bárhogy becsomagolva a kurinczky@scadasys.hu email címre a nevével együtt.

