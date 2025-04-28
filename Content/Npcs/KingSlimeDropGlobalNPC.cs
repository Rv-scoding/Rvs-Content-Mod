using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.ItemDropRules;
using RVScontentmod.Content.Items.Materials;

namespace RVScontentmod.Content.NPCs
{
    public class KingSlimeDropGlobalNPC : GlobalNPC
    {
        public override void ModifyNPCLoot(NPC npc, NPCLoot npcLoot)
        {
            
            if (npc.type == NPCID.KingSlime)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<CondensedGel>(), 1, 12, 25));
            }
        }
    }
}