```mermaid
classDiagram

    class Character {
        <<abstract>>
        -List~Item~ items
        +string Name
        +int Health
        +int MaxHealth
        +int BaseAttack
        +int BaseDefense
        +IReadOnlyList~Item~ Items
        #bool CanUseMagicalItems
        #Character(string name, int health, int baseAttack, int baseDefense)
        +void AddItem(Item item)
        +void RemoveItem(Item item)
        +int GetAttackValue()
        +int GetDefenseValue()
        +void ReceiveAttack(int power)
        +void Cure(int points)
        +void Attack(Character target)
    }

    class Dwarf {
        +Dwarf(string name, int health, int baseAttack, int baseDefense)
    }

    class Elf {
        +Elf(string name, int health, int baseAttack, int baseDefense)
    }

    class Wizard {
        #bool CanUseMagicalItems
        +Wizard(string name, int health, int baseAttack, int baseDefense)
    }

    class Item {
        <<abstract>>
        +string Name
        +int AttackValue
        +int DefenseValue
        #Item(string name)
    }

    class AttackItem {
        <<abstract>>
        +int AttackValue
        #AttackItem(string name, int attackValue)
    }

    class DefenseItem {
        <<abstract>>
        +int DefenseValue
        #DefenseItem(string name, int defenseValue)
    }

    class AttackDefenseItem {
        <<abstract>>
        +int AttackValue
        +int DefenseValue
        #AttackDefenseItem(string name, int attackValue, int defenseValue)
    }

    class MagicalItem {
        <<abstract>>
        #MagicalItem(string name, int attackValue, int defenseValue)
    }

    class Axe
    class Sword
    class Bow
    class Shield
    class Armor
    class Helmet
    class Staff
    class Spell

    class SpellsBook {
        -List~Spell~ spells
        +IReadOnlyList~Spell~ Spells
        +int AttackValue
        +int DefenseValue
        +void AddSpell(Spell spell)
        +void RemoveSpell(Spell spell)
    }

    Character <|-- Dwarf
    Character <|-- Elf
    Character <|-- Wizard
    Character o-- "*" Item : items

    Item <|-- AttackItem
    Item <|-- DefenseItem
    Item <|-- AttackDefenseItem
    AttackDefenseItem <|-- MagicalItem

    AttackItem <|-- Axe
    AttackItem <|-- Sword
    AttackItem <|-- Bow
    DefenseItem <|-- Shield
    DefenseItem <|-- Armor
    DefenseItem <|-- Helmet
    MagicalItem <|-- Staff
    MagicalItem <|-- Spell
    MagicalItem <|-- SpellsBook

    SpellsBook o-- "*" Spell : spells
```

## Decisiones de diseño

- **Todo lo común está en `Character`**: vida, recibir ataques, curarse y tener
  elementos (`AddItem` / `RemoveItem`). El ataque y la defensa totales se
  calculan igual para todos los personajes: el valor base más lo que aporta
  cada elemento.
- **`Item` define `AttackValue` y `DefenseValue` como virtuales que devuelven 0.**
  Cada subclase sobrescribe solo lo que aporta: un arma solo ataque, un
  elemento de defensa solo defensa y `AttackDefenseItem` las dos cosas. Así
  `Character` suma los valores de sus elementos sin preguntar de qué tipo es
  cada uno (polimorfismo).
- **Solo los magos usan elementos mágicos.** `Character` rechaza cualquier
  `MagicalItem` salvo que `CanUseMagicalItems` sea verdadero, y solo `Wizard`
  lo sobrescribe. Los magos también pueden usar elementos comunes.
- **`SpellsBook` calcula su ataque y defensa sumando sus hechizos**, en vez de
  guardar un valor que haya que mantener sincronizado.
