# CCObjects

The **Objects!** project, built live in class during *Coding for Games* —
Unit 2 of the Circuit Stream Game Development bootcamp.

A top-down arcade shooter. You are an object, you shoot bullets, and
everything else is trying to hit you.

**Play the finished version:** https://circuit-stream.github.io/objects/

---

## Opening it

- **Unity 6000.3.21f1.** Other Unity 6 versions will likely work, but will
  prompt to upgrade the project.
- It is a **2D** project (URP). Nothing here needs a platform module.
- The first open is slow — Unity is rebuilding the `Library` folder, which
  is not in the repo. Minutes, not seconds. It has not hung.

## What is in here

```
Assets/CircuitStream/
├─ scripts/     the classes we write in class
├─ textures/
│  ├─ Style1/   pixel-ish art, Courier fonts
│  └─ Style2/   neon art, screaming_neon font
├─ scenes/
└─ audio/
```

Two complete art styles ship with the project. Pick whichever you prefer —
the published demo above uses **Style 2**.

## Where we are

**Lecture 1 — Objects and classes.**

Seven files, and only one of them is a MonoBehaviour:

| File | What it is |
|---|---|
| `Health.cs` | Plain class. Current and max health, with clamping |
| `Weapon.cs` | Plain class. Two constructors |
| `Bullet.cs` | Plain class. Damages a `Health` |
| `EnemyType.cs` | An enum. No class in the file at all |
| `Player.cs` | Plain class. **Has** a Health and a Weapon |
| `Enemy.cs` | Plain class. Switches on the enum |
| `LevelLoader.cs` | **The only MonoBehaviour.** Creates the rest with `new` |

Put `LevelLoader` on an empty GameObject and press Play. Everything else
happens in the Console.

### Why most of this is not a MonoBehaviour

In Unit 1 every script was a component you dragged onto a GameObject. From
here, most are not. A plain class is just C#: you create it yourself with
`new`, you decide when, and it does not live in the scene.

If you try to drag `Health.cs` onto a GameObject, Unity will refuse. That is
correct, and it is the difference the `: MonoBehaviour` on `LevelLoader`
makes.

## Known rough edges

`Player` and `Enemy` are **nearly identical**, and that is deliberate. Two
classes with the same fields doing the same job is exactly the duplication
inheritance removes — which is Lecture 2.

The tenth-frame problem of this unit, so to speak. Leave it for now.

## Using this

Clone it, open it, break it. It is a reference, not something to copy
wholesale — your version of the game being different is the point, and you
are encouraged to name it something other than Objects!
