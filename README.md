# CrossApp

Навчальний проєкт з курсу «Крос-платформне програмування» на C# та .NET 9.

Предметна область — **склад**: товари, партії, залишки та переміщення. Подальший розвиток проєкту передбачає облік товарів і їхнього руху на складі.

Наразі консольний застосунок виводить відомості про студента, операційну систему, архітектуру процесу, версію .NET, робочі каталоги та обрану предметну область. Доступні два формати виведення: таблиця та JSON.

## Структура проєкту

```text
CrossApp/
├── CrossApp.sln
├── README.md
├── .gitignore
└── src/
    └── Cli/
        ├── Cli.csproj
        └── Program.cs
```

## Збірка та запуск

Для роботи потрібен **.NET SDK 9.0**. Усі команди виконуйте з кореневого каталогу проєкту, де розташований `CrossApp.sln`.

Зібрати рішення:

```bash
dotnet build
```

Запустити програму з виведенням таблиці:

```bash
dotnet run --project src/Cli
```

Вивести інформацію одним JSON-рядком:

```bash
dotnet run --project src/Cli -- --json
```

## Публікація

Створити self-contained версію, яка містить середовище виконання .NET, для macOS на Apple Silicon:

```bash
dotnet publish src/Cli -c Release -r osx-arm64 --self-contained true -o publish/osx-arm64
```

Для Windows x64:

```bash
dotnet publish src/Cli -c Release -r win-x64 --self-contained true -o publish/win-x64
```

Готові файли зберігаються у відповідних підкаталогах `publish`. На цільовій платформі запускайте файл `Cli` для macOS або `Cli.exe` для Windows.
