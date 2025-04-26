using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.ItemDropRules;
using RVScontentmod.Content.Items.Materials;

namespace RVScontentmod.Content.Items
{
    public class BagDropGlobalItem : GlobalItem
    {
        public override void ModifyItemLoot(Item item, ItemLoot itemLoot)
        {
            
            if (item.type == ItemID.KingSlimeBossBag)
            {
                itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<CondensedGel>(), 1, 12, 25)); 
                
            }
        }
    }
}