# Gestion de Stock - C# WinForms

Application de gestion de stock développée en C# avec WinForms et Entity Framework.

## Fonctionnalités principales

- **Authentification** : Système de connexion sécurisé
- **Gestion des produits** : CRUD complet pour les produits
- **Gestion des catégories** : Organisation des produits par catégories
- **Gestion des clients** : Suivi des clients et commandes
- **Interface intuitive** : Navigation ergonomique avec menu latéral

## Technologies utilisées

- C# .NET WinForms
- Entity Framework Core (SQLite)
- Dependency Injection
- Repository Pattern
- Material Design UI

## Structure du projet

- `C_Stocke/` - Code principal
  - `Auth/` - Authentification
  - `Categories/` - Gestion catégories 
  - `Clients/` - Gestion clients
  - `Produits/` - Gestion produits
  - `Context/` - Couche données
  - `Repositories/` - Pattern Repository

## Prérequis

- .NET 6+
- Visual Studio 2022
- SQLite

## Installation

1. Cloner le dépôt
2. Restaurer les packages NuGet
3. Configurer la chaîne de connexion dans `appsettings.json`
4. Lancer l'application via Visual Studio