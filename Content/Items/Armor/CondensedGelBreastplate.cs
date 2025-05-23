using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using RVScontentmod.Content.Items.Materials;

namespace RVScontentmod.Content.Items.Armor
{   
    [AutoloadEquip(EquipType.Body)]
    public class CondensedGelBreastplate : ModItem
    {
        public override void SetDefaults()
        {
            Item.width = 18; 
			Item.height = 18; 
			Item.value = Item.sellPrice(gold: 4); 
			Item.rare = ItemRarityID.Green; 
			Item.defense = 7;
        }

        public override void AddRecipes() 
        {
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient<CondensedGel>(25);
			recipe.AddTile(TileID.Anvils);
			recipe.Register();
        }
    }




}