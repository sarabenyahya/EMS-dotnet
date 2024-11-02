# Système de Gestion des Employés (EMS)

## Introduction

Le Système de Gestion des Employés (EMS) est une application complète conçue pour fournir une solution intégrée de gestion des employés, englobant à la fois le frontend et le backend. Son objectif principal est de simplifier la gestion des données des employés, y compris leurs informations personnelles, leur statut d'emploi et leur département.

## Architecture de l'Application

L'application EMS est développée en C# en utilisant le framework .NET. Sa structure repose sur une architecture fullstack, intégrant une API backend pour la gestion des données et Blazor pour l'interface utilisateur.

- **Backend** : L'application est construite sur ASP.NET Core, qui propose une API RESTful pour gérer les données des employés. Cette API permet la communication avec la base de données et fournit des endpoints pour effectuer des opérations CRUD (Create, Read, Update, Delete) sur les employés et les départements.

## Fonctionnalités de l'Application

L'application EMS offre les fonctionnalités suivantes :

- **Gestion des Employés** : Les utilisateurs peuvent ajouter, afficher, mettre à jour et supprimer les informations des employés, y compris leur nom, email, département, salaire et statut d'emploi.
- **Gestion des Départements** : Les utilisateurs peuvent également gérer les départements, avec la possibilité d'ajouter, d'afficher, de mettre à jour et de supprimer les informations associées.
- **Notifications Toast** : L'application utilise la bibliothèque Blazored.Toast pour afficher des notifications de type toast, informant les utilisateurs des opérations réussies ou des erreurs.

## Technologies Utilisées

- **Langage de Programmation** : C#
- **Backend** : ASP.NET Core
- **Frontend** : Blazor
- **Base de Données** : SQLite
- **Outils et Bibliothèques** : Blazored.Toast, Microsoft.Extensions.DependencyInjection, Microsoft.Extensions.Logging, Microsoft.JSInterop

## Démarrage de l'Application

Pour démarrer l'application, suivez les étapes ci-dessous :

1. **Cloner le dépôt :**

   ```bash
   git clone https://github.com/sarabenyahya/EMS-dotnet
   cd EMS-dotnet
   ```
2. **Restaurer les dépendances :**

   ```bash
   dotnet restore
   ```

3. **Configurer la base de données (si nécessaire) :**
    ```bash
    dotnet ef database update
    ```

4. **Démarrer l'application :**
    ```bash
    dotnet run
    ```

5. **Accéder à l'application :**
Ouvrez un navigateur et rendez-vous sur `http://localhost:5000` pour accéder à l'interface utilisateur.

## Conclusion

L'application EMS constitue une solution complète et efficace pour la gestion des employés, offrant une interface utilisateur conviviale ainsi qu'une API backend robuste. Elle permet aux entreprises de gérer facilement les informations de leurs employés tout en assurant une expérience utilisateur fluide. En tirant parti des dernières technologies de développement web de Microsoft, cette application illustre les capacités de C# et .NET pour le développement fullstack.