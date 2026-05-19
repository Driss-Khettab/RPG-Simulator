# RPG Combat Simulator - Squelette TD

## 🎯 Objectif

Implémenter un système de combat RPG en utilisant 3 design patterns :
- **Factory** : création des personnages
- **Strategy** : mécaniques d'attaque
- **State** : gestion des états du personnage

Voir le sujet complet pour le détail des besoins et spécifications

---

## 📁 Structure du projet

```
RPGCombatSimulator/
├── RPGCombatSimulator.sln
└── RPGCombatSimulator/
    ├── RPGCombatSimulator.csproj
    ├── Program.cs                     ← À compléter (Main)
    │
    ├── Characters/
    │   └── Character.cs               ← À compléter pour l'initialisation de l'état
    │
    ├── Factories/
    │   └── CharacterFactory.cs        ← Classe abstraite fournie
    │
    ├── Strategies/
    │   └── IAttackStrategy.cs         ← Interface fournie
    │
    └── States/
        └── CharacterState.cs          ← Classe abstraite fournie
```

---

## 🛠️ Ce qui est fourni

✅ **Character.cs** : classe complète gérant un personnage  
✅ **CharacterFactory.cs** : classe abstraite définissant le contrat des factories  
✅ **IAttackStrategy.cs** : interface des stratégies d'attaque  
✅ **CharacterState.cs** : classe abstraite des états  
✅ **Program.cs** : squelette du Main avec les étapes à suivre

---

## 📐 Spécifications

### Statistiques des personnages

| Type | MaxHealth | BaseDamage | Stratégie |
|------|-----------|------------|-----------|
| Warrior | 150 | 20 | Melee |
| Mage | 80 | 15 | Magic |
| Rogue | 100 | 12 | Ranged |

### Formules de dégâts

| Stratégie | Calcul |
|-----------|--------|
| Melee | baseDamage × 1.2 |
| Magic | baseDamage × 1.5 |
| Ranged | baseDamage + random(5, 15) |

### Pourcentage d'attaque selon l'état (appliquée après calcul de l'attaque ci-dessus)

| Etat | Pourcentage d'attaque |
|-----------|--------|
| Healthy | 100% |
| Wounded | 80% |
| Critical | 50% |
| Dead | 0% |

### Transitions d'état

| Condition | Transition |
|-----------|------------|
| HP < 50% MaxHP | → Wounded |
| HP < 25% MaxHP | → Critical |
| HP <= 0 | → Dead |

⚠️ Un personnage peut passer directement de Healthy à Critical (ou Dead) si les dégâts sont importants.

---

## 🚀 Démarrage

### Prérequis

- .NET 8 SDK installé
- Un IDE C# (Visual Studio, VS Code, ou Rider)

### Vérifier que le squelette compile

```bash
cd RPGCombatSimulator
dotnet build
```

Vous devez obtenir une compilation réussie (avec peut-être des warnings sur les TODO).

### Exécuter

```bash
dotnet run
```

---

## 💡 Conseils

### Ordre de travail recommandé

1. **Strategy** (~20 min) — le plus simple
2. **Factory** (~30 min) — création des personnages
3. **State** (~30 min) — le plus subtil
4. **Main + tests** (~30 min)
5. **Diagramme UML** (~20 min)

### Bonnes pratiques

✅ Une classe = un fichier  
✅ Respecter les namespaces (ex: `RPGCombatSimulator.Strategies`)  
✅ Tester chaque pattern AVANT de passer au suivant  
✅ Commencer simple, complexifier après

---

## 📦 Livrables

À la fin du TD, vous devez rendre :

1. ✅ **Le code source** : projet complet zippé (sans `bin/` ni `obj/`)
2. ✅ **Un diagramme UML** : à la main (photo) ou numérique
3. ✅ **Le tout** déposé selon les modalités indiquées par l'enseignant

---

## 📚 Ressources

- Notes de cours et exercices précédents
- [refactoring.guru](https://refactoring.guru/fr/design-patterns) pour les patterns
- Documentation Microsoft C#

**Interdit** : ChatGPT, Copilot, autres IA génératives, échange de code entre étudiants

---

## ❓ Besoin d'aide ?

Levez la main pendant le TD. Je passe régulièrement dans les rangs.

**Bon courage !** 💪
