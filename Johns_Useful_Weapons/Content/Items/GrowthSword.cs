using Johns_Useful_Weapons.Content.Buffs;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Johns_Useful_Weapons.Content.Items
{
	public class GrowthSword : ModItem
	{
        // The Display Name and Tooltip of this item can be edited in the Localization/en-US_Mods.FirstMod.hjson file.
		public override void SetDefaults()
		{
			Item.damage = 1;
			Item.DamageType = DamageClass.Melee;
			Item.width = 80;
			Item.height = 400;
			Item.useTime = 60;
			Item.useAnimation = 20;
			Item.useStyle = ItemUseStyleID.Swing;
			Item.knockBack = 0;
			Item.value = 10000;
			Item.rare = 2;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
			Item.noMelee = false;
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.DirtBlock, 10);
			recipe.AddTile(TileID.WorkBenches);
			recipe.Register();
		}

	 	//infict a debuff to an enemy
		public override void OnHitNPC(Player player, NPC target, NPC.HitInfo hit, int damageDone) 
		{
			target.AddBuff(ModContent.BuffType<GrowthDebuff>(), 1);
			
		}
	}
}