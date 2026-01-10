using Microsoft.Xna.Framework;
using Celeste.Mod.Entities;
using Monocle;

namespace Celeste.Mod.ElegiacHelper.Entities;

[CustomEntity("ElegiacHelper/GildedBerry")]
public class GildedBerry : Strawberry
{
    public int deaths;

    public GildedBerry(EntityData data, Vector2 offset, EntityID gid) : base(data, offset, gid) {
        ReturnHomeWhenLost = false;
    }
}