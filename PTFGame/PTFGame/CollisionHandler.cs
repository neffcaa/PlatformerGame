using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace PTFGame
{
    public abstract class CollisionHandler
    {
        public List<GameObject> thingsOnMap = new List<GameObject>();


        public void checkCollisions()
        {
            for (int i = 0; i < thingsOnMap.Count - 1; i++)
            {
                for (int x = 1; x < thingsOnMap.Count; x++)
                {
                    GameObject thingI = thingsOnMap.ElementAt(i);
                    GameObject thingX = thingsOnMap.ElementAt(x);

                    if ((thingI.Top <= thingX.Top) && (thingI.Top + thingI.Height <= thingX.Top + thingX.Height) && (thingI.Left <= thingX.Left) && thingI.Left + thingI.Width >= thingX.Left + thingX.Width) 
                    {
                        // Objects have collided from top or bottom
                        thingI.collide(thingX);
                        thingX.collide(thingI);
                    }
                         
                }
               
            }
           
                
                
            

        }

        public void handleCollisions()
        {

        }







    }


}
