using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using tutorial.Content.Items.Materials;

namespace tutorial.Content.Items.Armor
{   
    [AutoloadEquip(EquipType.Legs)]
    public class CondensedGelLeggings : ModItem
    {
        public override void SetDefaults()
        {
            Item.width = 18; 
			Item.height = 18; 
			Item.value = Item.sellPrice(gold: 4); 
			Item.rare = ItemRarityID.Green; 
			Item.defense = 9;
        }

        public override void AddRecipes() 
        {
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient<CondensedGel>();
			recipe.AddTile(TileID.Anvils);
			recipe.Register();
        }
    }




}