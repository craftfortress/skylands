#region Using Statements
using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using JigLibX.Collision;
using JigLibX.Physics;
using JigLibX.Geometry;
using JigLibX.Math;
using Microsoft.Xna.Framework.Graphics;
#endregion

namespace skylands.PhysicObjects
{

    public class BoxObject : PhysicObject
    {
        //public Vector3 place;

        public BoxObject(Game game,Model model,Vector3 sideLengths, Matrix orientation, Vector3 position) : base(game,model)
        {
            body = new Body();
            collision = new CollisionSkin(body);

            collision.AddPrimitive(new Box(- 0.5f * sideLengths, orientation, sideLengths), new MaterialProperties(0.8f, 0.8f, 0.7f));
            body.CollisionSkin = this.collision;
            Vector3 com = SetMass(50.0f);
            body.MoveTo(position, Matrix.Identity);
            collision.ApplyLocalTransform(new Transform(-com, Matrix.Identity));
            body.EnableBody();
            this.scale = sideLengths;
        }

        
        public  void MoveTo(Vector3 xxx, Matrix ccccc)
        {
         body.MoveTo(xxx, Matrix.Identity);
           }

        public override void ApplyEffects(BasicEffect effect)
        {
            effect.DiffuseColor = color;
        }
    }
}


