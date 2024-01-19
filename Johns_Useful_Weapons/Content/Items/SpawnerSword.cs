using Johns_Useful_Weapons.Content.Buffs;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Johns_Useful_Weapons.Content.Items
{
	public class SpawnerSword : ModItem
	{
		public override void SetDefaults()
		{
			Item.damage = 1;
			Item.DamageType = DamageClass.Melee;
			Item.width = 40;
			Item.height = 40;
			Item.useTime = 90;
			Item.useAnimation = 20;
			Item.useStyle = ItemUseStyleID.Swing;
			Item.knockBack = 0;
			Item.value = 20000;
			Item.rare = 2;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
			Item.noMelee = false;
		}
		//use iron/lead bars and some items known in a common duplication glitch
		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.IronBar, 10);
			recipe.AddIngredient(ItemID.CatBast, 1);
			recipe.AddIngredient(ItemID.GrayPressurePlate, 1);
			recipe.AddIngredient(ItemID.Campfire, 1);
			recipe.AddIngredient(ItemID.Trapdoor, 1);
			recipe.AddIngredient(ItemID.SandBlock, 4);
			recipe.AddTile(TileID.Anvils);
			recipe.Register();

			recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.LeadBar, 10);
			recipe.AddIngredient(ItemID.CatBast, 1);
			recipe.AddIngredient(ItemID.GrayPressurePlate, 1);
			recipe.AddIngredient(ItemID.Campfire, 1);
			recipe.AddIngredient(ItemID.Trapdoor, 1);
			recipe.AddIngredient(ItemID.SandBlock, 4);
			recipe.AddTile(TileID.Anvils);
			recipe.Register();
		}

	 	//creates a clone of the target and spawns it above the player
		public override void OnHitNPC(Player player, NPC target, NPC.HitInfo hit, int damageDone) 
		{   
            int npcSpawn = target.type;
            int npcIndex = NPC.NewNPC(target.GetSource_FromAI(), (int)player.Center.X, (int)(player.Center.Y - 40), npcSpawn, 0, 0f, 0f, 0f, 0f, 255);
            Main.npc[npcIndex].whoAmI = npcIndex;
		}
	}
}