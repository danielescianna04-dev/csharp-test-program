# Calcolatrice C# con GUI

Un'applicazione desktop cross-platform con interfaccia grafica moderna, sviluppata con C# e Avalonia UI.

## Caratteristiche

- **Interfaccia grafica moderna** con tema scuro in stile iOS
- **Calcolatrice funzionante** con tutte le operazioni base
- **Design responsive** con bottoni colorati e hover effects
- **Pattern MVVM** per architettura pulita e manutenibile
- **Cross-platform** - funziona su Windows, macOS e Linux

## Funzionalità

- Addizione (+)
- Sottrazione (-)
- Moltiplicazione (×)
- Divisione (÷)
- Display grande e leggibile
- Bottone Clear per resettare

## Come eseguire

### Prerequisiti
- .NET SDK 10.0 o superiore

### Esecuzione
```bash
cd CSharpTestApp
dotnet run
```

### Compilazione
```bash
cd CSharpTestApp
dotnet build
```

## Tecnologie Utilizzate

- **.NET 10** - Framework di sviluppo
- **Avalonia UI 11.3** - Framework UI cross-platform
- **CommunityToolkit.Mvvm** - Per implementazione pattern MVVM
- **C# 13** - Linguaggio di programmazione

## Struttura del Progetto

```
CSharpTestApp/
├── ViewModels/          # Logica dell'applicazione
├── Views/               # Interfacce utente (XAML)
├── Assets/              # Risorse (icone, immagini)
├── App.axaml           # Configurazione app
└── Program.cs          # Entry point
```

## Screenshot

L'applicazione presenta:
- Display nero con testo grande e chiaro
- Bottoni numerici grigi scuri (#2D2D2D)
- Bottoni operazioni arancioni (#FF9500)
- Bottone Clear grigio chiaro (#D4D4D2)
- Effetti hover su tutti i bottoni

## Autore

Creato con Claude Code
