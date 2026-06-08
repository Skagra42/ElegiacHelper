using Microsoft.Xna.Framework;
using Celeste.Mod.Entities;
using Monocle;

namespace Celeste.Mod.ElegiacHelper.Entities;

[CustomEntity("ElegiacHelper/GildedBerry")]
public class GildedBerry : Strawberry
{
    public int deathsRemaining;

    public GildedBerry(EntityData data, Vector2 offset, EntityID gid, int deathsRemaining) : base(data, offset, gid) {
        ReturnHomeWhenLost = false;
		this.deathsRemaining = deathsRemaining;
    }

	new public void OnLoseLeader() {
		if (!collected) {
			deathsRemaining -= 1;
		}

		base.OnLoseLeader();

		if (deathsRemaining == 0) {
			ReturnHomeWhenLost = true;
		}
	}
}