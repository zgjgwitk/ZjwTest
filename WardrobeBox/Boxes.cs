using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WardrobeBox
{
    public class Boxes
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<Box> GetBoxes()
        {
            var list = new List<Box>();
            var sizes = Size();
            foreach (var key in sizes.Keys)
            {
                list.Add(new Box(key
                    , sizes[key][0]
                    , sizes[key][1]
                    , sizes[key][2])
                    );
            }
            return list;

        }

        public Dictionary<string, int[]> Size()
        {
            var dict = new Dictionary<string, int[]>();
            dict.Add("205", new int[] { 477, 448, 230 });
            dict.Add("206", new int[] { 450, 380, 210 });
            dict.Add("207", new int[] { 410, 322, 175 });
            dict.Add("208", new int[] { 360, 257, 140 });
            dict.Add("218", new int[] { 310, 250, 135 });
            dict.Add("209", new int[] { 210, 190, 100 });//deep,width,high
            return dict;
        }
    }

    public class Box : BaseVolume
    {
        public Box(string name, int deep, int width, int high, int x = 0, int y = 0, int z = 0) : base(name, deep, width, high)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }
    }
}
