using Microsoft.Xna.Framework;
using Johns_Useful_Weapons.Content.Buffs;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Johns_Useful_Weapons.Content.Items
{
	public class GrowthSword : ModItem
	{
		public override void SetDefaults()
		{
			Item.damage = 1;
			Item.DamageType = DamageClass.Melee;
			Item.width = 40;
			Item.height = 40;
			Item.useTime = 60;
			Item.useAnimation = 20;
			Item.useStyle = ItemUseStyleID.Swing;
			Item.knockBack = 0;
			Item.value = 20000;
			Item.rare = 2;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
			Item.noMelee = false;
		}
		//use iron or lead bars and some large gems
		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.IronBar, 10);
			recipe.AddIngredient(ItemID.LargeEmerald, 1);
            recipe.AddIngredient(ItemID.LargeAmethyst, 1);
            recipe.AddIngredient(ItemID.LargeSapphire, 1);
			recipe.AddIngredient(ItemID.LargeTopaz, 1);
			recipe.AddTile(TileID.Anvils);
			recipe.Register();

            recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.LeadBar, 10);
      		recipe.AddIngredient(ItemID.LargeEmerald, 1);
            recipe.AddIngredient(ItemID.LargeAmethyst, 1);
            recipe.AddIngredient(ItemID.LargeSapphire, 1);
			recipe.AddIngredient(ItemID.LargeTopaz, 1);
			recipe.AddTile(TileID.Anvils);
			recipe.Register();
		}

	 	//infict a debuff to an enemy that makes it larger
		public override void OnHitNPC(Player player, NPC target, NPC.HitInfo hit, int damageDone) 
		{
			target.AddBuff(ModContent.BuffType<GrowthDebuff>(), 1);
			Vector2 displaceUp = new Vector2(0, 100);
			target.Center = Vector2.Subtract(target.Center, displaceUp);
		}
	}
}