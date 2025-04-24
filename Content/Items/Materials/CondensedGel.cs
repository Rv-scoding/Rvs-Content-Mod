using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.ItemDropRules;

namespace tutorial.Content.Items.Materials
{ 
	
	public class CondensedGel : ModItem
	{
        public override void SetDefaults()
         {
            Item.width = 20; 
			Item.height = 20; 

			Item.maxStack = Item.CommonMaxStack; 
			Item.value = Item.buyPrice(silver: 1);
    
        }
        



    }

}