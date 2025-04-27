using Terraria;
using Terraria.ModLoader;

namespace RVScontentmod.Content.Players
{
    public class CondensedGelPlayer : ModPlayer
    {
        public bool CondensedGelSetBonus;

        public override void ResetEffects()
        {
            CondensedGelSetBonus = false;
            
        }

       
        public override void OnHitByNPC(NPC npc, Player.HurtInfo info)
        {
            if (CondensedGelSetBonus)
            {
                
                
                float knockbackStrengthX = 18f; // Horizontal knockback 
                float knockbackStrengthY = 10f;  // Vertical knockback 
                if (npc.knockBackResist > 0f)
                {
                    int direction = (npc.Center.X > Player.Center.X) ? 1 : -1; // Enemy is right, knock right, else knock left
                    npc.velocity.X = direction * knockbackStrengthX * npc.knockBackResist;
                    npc.velocity.Y = -knockbackStrengthY * npc.knockBackResist;
                }
            }
        }
    }
}