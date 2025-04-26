using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace RVScontentmod.Content.Projectiles
{
    public class CondensedGelBall : ModProjectile
    {
        public override void SetDefaults()
        {
            Projectile.width = 20;
            Projectile.height = 20;
            Projectile.aiStyle = 1;
            Projectile.friendly = true;
			Projectile.DamageType = DamageClass.Melee;
            Projectile.penetrate = 7;
        }
		int bounce = 0;
        int maxbounce = 7;

        

        public override void AI()
        {
            Projectile.velocity.Y += 0.1f;
            if (Projectile.velocity.X > -0.1f && Projectile.velocity.X < 0.1f)
            {
                Projectile.velocity.X = 0f;
            }
        }
            


         public override bool OnTileCollide(Vector2 oldVelocity)
        {
            bounce++;
            if (bounce >= maxbounce)
            {
                Projectile.Kill(); 
            }
            else
            {
                
                if (Projectile.velocity.X != oldVelocity.X)
                {
                    Projectile.velocity.X = -oldVelocity.X;
                }
                if (Projectile.velocity.Y != oldVelocity.Y)
                {
                    Projectile.velocity.Y = -oldVelocity.Y;
                }
            }
            return false; 
        }
    }
}
