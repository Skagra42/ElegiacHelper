namespace Celeste.Mod.ElegiacHelper {
    public static class Hooks {
        internal static void Load() {
            //On.Celeste.Player.Die += Player_Die;
        }

        // Any hooks you apply should be undone during your EverestModule's Unload function.
        internal static void Unload() {
            //On.Celeste.Player.Die -= Player_Die;
        }

        private static void Player_Die(
            On.Celeste.Player.orig_Die orig, Player self, Microsoft.Xna.Framework.Vector2 direction, bool evenIfInvincible, bool registerDeathInStats
        ) {
            //self.level.Session.RespawnPoint =

            orig(self, direction, evenIfInvincible, registerDeathInStats);
        }
    }
}