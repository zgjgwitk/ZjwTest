using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WardrobeBox
{
    public abstract class BaseVolume
    {
        public string Name { get; set; } = string.Empty;
        public int Deep { get; set; } = 0;
        public int Width { get; set; } = 0;
        public int High { get; set; } = 0;
        public int SubDeep { get; set; } = 0;
        public int SubWidth { get; set; } = 0;
        public int SubHigh { get; set; } = 0;
        public int X { get; set; } = 0;
        public int Y { get; set; } = 0;
        public int Z { get; set; } = 0;

        public BaseVolume(string name, int deep, int width, int high, int subdeep = 0, int subwidth = 0, int subhigh = 0)
        {
            this.Name = name;
            this.Deep = deep;
            this.Width = width;
            this.High = high;
            this.SubDeep = subdeep;
            this.SubWidth = subwidth;
            this.SubHigh = subhigh;
        }

        /// <summary>
        /// 获取体积
        /// </summary>
        /// <returns></returns>
        public int GetVolume()
        {
            return this.Deep * this.High * this.Width
                - this.SubDeep * this.SubHigh * this.SubWidth;
        }

        /// <summary>
        /// 获取底面积
        /// </summary>
        /// <returns></returns>
        public int GetArea()
        {
            return this.Deep * this.Width
                - this.SubDeep * this.SubWidth;
        }
    }
}
