using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using RVScontentmod.Content.Items.Materials;
using RVScontentmod.Content.Projectiles;

namespace RVScontentmod.Content.Items.Weapons
{ 
	
	public class CondensedGelSword : ModItem
	{
		
		public override void SetDefaults()
		{
			Item.damage = 28;
			Item.DamageType = DamageClass.Melee;
			Item.width = 50;
			Item.height = 50;
			Item.useTime = 15;
			Item.useAnimation = 15;
			Item.useStyle = ItemUseStyleID.Swing;
			Item.knockBack = 15;
			Item.value = Item.buyPrice(gold: 1);
			Item.rare = ItemRarityID.Blue;
			Item.UseSound = SoundID.Item154;
			Item.autoReuse = true;
			Item.shoot = ModContent.ProjectileType<CondensedGelBall>();
			Item.shootSpeed = 10f;
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
