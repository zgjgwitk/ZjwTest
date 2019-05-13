using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WardrobeBox
{
    public class Spaces
    {
        public List<Space> GetSpaces()
        {
            var list = new List<Space>();
            var sizes = Size();
            foreach (var key in sizes.Keys)
            {
                list.Add(new Space(key
                    , sizes[key][0]
                    , sizes[key][1]
                    , sizes[key][2]
                    , sizes[key][3]
                    , sizes[key][4]
                    , sizes[key][5])
                    );
            }
            return list;
        }

        public Dictionary<string, int[]> Size()
        {
            var dict = new Dictionary<string, int[]>();
            dict.Add("卧室西", new int[] { 480, 760, 250, 130, 160, 250 });//deep,width,high,subdeep,subwidth,subhigh
            dict.Add("卧室中-下", new int[] { 480, 470, 520, 0, 0, 0 });
            dict.Add("卧室中-上", new int[] { 480, 470, 310, 0, 0, 0 });
            dict.Add("卧室东-下", new int[] { 480, 750, 500, 0, 0, 0 });
            dict.Add("卧室东-上", new int[] { 480, 750, 390, 0, 0, 0 });
            dict.Add("书房左-下", new int[] { 480, 720, 400, 0, 0, 0 });
            dict.Add("书房左-上", new int[] { 480, 720, 310, 0, 0, 0 });
            dict.Add("书房右-上", new int[] { 480, 610, 440, 240, 250, 440 });
            dict.Add("书房右-上", new int[] { 480, 610, 440, 240, 250, 440 });
            dict.Add("卧室矮柜", new int[] { 320, 490, 490, 0, 0, 0 });

            return dict;
        }
    }

    public class Space : BaseVolume
    {
        public Space(string name, int deep, int width, int high, int subdeep = 0, int subwidth = 0, int subhigh = 0)
            : base(name, deep, width, high, subdeep, subwidth, subhigh)
        {

        }
    }
}
