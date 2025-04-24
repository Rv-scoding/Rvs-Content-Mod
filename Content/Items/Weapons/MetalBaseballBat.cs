using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace tutorial.Content.Items.Weapons
{ 
	
	public class MetalBaseballBat : ModItem
	{
		
		public override void SetDefaults()
		{
			Item.damage = 60;
			Item.DamageType = DamageClass.Melee;
			Item.width = 50;
			Item.height = 50;
			Item.useTime = 25;
			Item.useAnimation = 25;
			Item.useStyle = ItemUseStyleID.Swing;
			Item.knockBack = 2000;
			Item.value = Item.buyPrice(gold: 2);
			Item.rare = ItemRarityID.Blue;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = false;
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
