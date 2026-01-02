using Microsoft.Xna.Framework;
using Celeste.Mod.Entities;
using Monocle;

namespace Celeste.Mod.ElegiacHelper.Entities;

[CustomEntity("ElegiacHelper/HoldablePlayerSpawn")]
public class HoldablePlayerSpawn : Entity
{
    private readonly Holdable HoldableComponent;
    private readonly Image SpawnSprite;

    public HoldablePlayerSpawn(EntityData data, Vector2 offset) : base(data.Position + offset)
    {
        Collider = new Hitbox(8f, 11f, -4f, -11f);

        Add(HoldableComponent = new Holdable()
        {

        });

        Add(SpawnSprite = GFX.SpriteBank.Create("torch"));
    }

    public override void Update() {
        base.Update();
        //Player.level.Session.RespawnPoint =
    }
}