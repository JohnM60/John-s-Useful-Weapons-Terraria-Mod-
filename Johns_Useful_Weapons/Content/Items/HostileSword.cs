using Johns_Useful_Weapons.Content.Items.Projectiles;
using Microsoft.Xna.Framework;
using Johns_Useful_Weapons.Content.Buffs;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Johns_Useful_Weapons.Content.Items
{
	public class HostileSword : ModItem
	{
		//the projectile shot changes the npc to hostile
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
			Item.value = 10000;
			Item.rare = 2;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
			Item.noMelee = false;
            Item.shoot = ModContent.ProjectileType<HostileProjectile>();
			Item.shootSpeed = 1f;
		}
		//use demonite/crimtane bars and some evil biome drops
		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.DemoniteBar, 5);
            recipe.AddIngredient(ItemID.RottenChunk, 5);
            recipe.AddIngredient(ItemID.VilePowder,15);
            recipe.AddIngredient(ItemID.EbonstoneBlock,20);
            recipe.AddIngredient(ItemID.CorruptSeeds, 1);
			recipe.AddTile(TileID.Anvils);
			recipe.Register();

            recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.CrimtaneBar, 5);
			recipe.AddIngredient(ItemID.Vertebrae, 5);
			recipe.AddIngredient(ItemID.ViciousPowder, 15);
			recipe.AddIngredient(ItemID.CrimstoneBlock, 20);
			recipe.AddIngredient(ItemID.CrimsonSeeds, 1);
			recipe.AddTile(TileID.Anvils);
			recipe.Register();
		}
	}
}