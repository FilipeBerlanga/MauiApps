# MauiAppHotel

[![.NET](https://img.shields.io/badge/.NET-10.0-512BD4?logo=dotnet&logoColor=white)](https://dotnet.microsoft.com/)
[![.NET MAUI](https://img.shields.io/badge/.NET%20MAUI-multiplataforma-512BD4?logo=dotnet&logoColor=white)](https://learn.microsoft.com/dotnet/maui/)
[![C#](https://img.shields.io/badge/C%23-13-239120?logo=csharp&logoColor=white)](https://learn.microsoft.com/dotnet/csharp/)
[![Plataformas](https://img.shields.io/badge/plataformas-Android%20%7C%20iOS%20%7C%20macOS%20%7C%20Windows-0078D4)](https://learn.microsoft.com/dotnet/maui/what-is-maui)

Aplicativo multiplataforma desenvolvido com **.NET MAUI** para simular a contratação de hospedagens. O projeto permite informar a quantidade de adultos e crianças, escolher uma acomodação e selecionar o período da estadia.

## Funcionalidades

- Seleção da quantidade de adultos e crianças.
- Escolha da acomodação.
- Definição das datas de check-in e check-out.
- Navegação para a tela de contratação da hospedagem.
- Tela com informações sobre o aplicativo e o projeto.
- Interface construída em XAML com suporte a Android, iOS, macOS e Windows.

## Tecnologias

- [.NET 10](https://dotnet.microsoft.com/download/dotnet/10.0)
- [.NET MAUI](https://learn.microsoft.com/dotnet/maui/)
- C#
- XAML
- Visual Studio 2026

## Plataformas suportadas

O projeto está configurado para os seguintes destinos:

- Android 5.0 (API 21) ou superior
- iOS 15.0 ou superior
- macOS Catalyst 15.0 ou superior
- Windows 10.0.17763.0 ou superior

## Pré-requisitos

Antes de executar o projeto, instale:

1. [Visual Studio 2026](https://visualstudio.microsoft.com/)
2. A carga de trabalho **Desenvolvimento de interface do usuário de aplicativos multiplataforma .NET**.
3. Os SDKs e emuladores correspondentes à plataforma desejada.
4. O SDK do [.NET 10](https://dotnet.microsoft.com/download/dotnet/10.0).

## Como executar

Clone o repositório e abra a solução no Visual Studio:

```bash
git clone <url-do-repositorio>
cd MauiAppHotel
```

Em seguida:

1. Abra `MauiAppHotel.slnx` no Visual Studio.
2. Selecione o destino de execução, como um emulador Android ou Windows Machine.
3. Compile e execute com `F5`.

Também é possível executar pelo terminal, informando o framework desejado:

```bash
dotnet restore MauiAppHotel/MauiAppHotel.csproj
dotnet build MauiAppHotel/MauiAppHotel.csproj -f net10.0-windows10.0.19041.0
dotnet run --project MauiAppHotel/MauiAppHotel.csproj -f net10.0-windows10.0.19041.0
```

> Os comandos de execução variam conforme a plataforma e os workloads instalados no ambiente.

## Estrutura principal

```text
MauiAppHotel/
├── MainPage.xaml                    # Página inicial
├── AppShell.xaml                    # Configuração da navegação
├── MauiProgram.cs                   # Inicialização da aplicação
├── Views/
│   ├── ContratacaoHospedagem.xaml   # Formulário da hospedagem
│   ├── HospedagemContratada.xaml    # Resultado da contratação
│   └── SobrePage.xaml               # Informações do aplicativo
├── Resources/                       # Imagens, fontes, ícones e estilos
└── Platforms/                       # Configurações específicas por plataforma
```

## Autor

- **Filipe Berlanga**

Projeto desenvolvido em 2026 como parte do curso Técnico em Desenvolvimento de Sistemas.

## Status

Em desenvolvimento.
