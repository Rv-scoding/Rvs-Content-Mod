using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace RVScontentmod.Content.Items.Tools
{
    public class StonePickaxeAxe : ModItem
    {
        public override void SetDefaults() 
        {
            Item.damage = 8;
            Item.DamageType = DamageClass.Melee;
            Item.width = 40;
			Item.height = 40;
			Item.useTime = 18;
            Item.useAnimation = 18;
			Item.useStyle = ItemUseStyleID.Swing;
			Item.knockBack = 6;
            Item.value = Item.buyPrice(copper: 1);
            Item.rare = ItemRarityID.Blue;
            Item.UseSound = SoundID.Item1;
            Item.autoReuse = true;

            
            Item.pick = 45;
            Item.axe = 9;
            Item.attackSpeedOnlyAffectsWeaponAnimation = true;
        }
        public override void AddRecipes() 
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.Gel, 5);
            recipe.AddIngredient<StonePickaxe>();
            recipe.AddIngredient<StoneAxe>();
            recipe.AddTile(TileID.Anvils);
            recipe.Register();


        }
    }
}