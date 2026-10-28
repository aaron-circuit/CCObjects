// Unit 2, Lecture 1, Section 3.
//
// An ENUM is a list of named options, and a TYPE of its own. Once this
// exists you can write `EnemyType.Shooter` anywhere, and the compiler will
// catch you if you spell it wrong.
//
// Compare that to using a string "shooter", where a typo is silent — which
// is exactly the bug you hit with sound names in Unit 1.
//
// This file has no class in it at all, which is allowed.
public enum EnemyType
{
    Melee,
    Shooter,
    Exploder,
    MachineGun
}
