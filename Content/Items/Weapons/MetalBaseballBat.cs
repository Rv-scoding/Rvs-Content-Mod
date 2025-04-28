using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace RVScontentmod.Content.Items.Weapons
{ 
	
	public class MetalBaseballBat : ModItem
	{
		
		public override void SetDefaults()
		{
			Item.damage = 45;
			Item.DamageType = DamageClass.Melee;
			Item.width = 50;
			Item.height = 50;
			Item.useTime = 28;
			Item.useAnimation = 28;
			Item.useStyle = ItemUseStyleID.Swing;
			Item.knockBack = 2000;
			Item.value = Item.buyPrice(gold: 1);
			Item.rare = ItemRarityID.Blue;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.IronBar, 30);
			recipe.AddTile(TileID.Anvils);
			recipe.Register();
		}
	}
}
