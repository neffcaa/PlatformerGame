using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace PTFGame
{
    public class CollisionHandler
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

                    if (thingI.Bounds.IntersectsWith(thingX.Bounds))
                    {
                        // Objects have collided from top or bottom
                        thingI.collide(thingX);
                        thingX.collide(thingI);
                    }
                         
                }
               
            }               
        }

        public void populateList(GameObject thing)
        {

        }

    }


}
