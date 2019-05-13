using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WardrobeBox
{
    public class Methods
    {
        /// <summary>
        /// 计算放置方案
        /// </summary>
        /// <param name="ifTurn">是否可以水平旋转摆放</param>
        public void Place(Space s, List<Box> b, bool ifTurn = false)
        {
            var nb = GetTurn(b, ifTurn);
            var ret = new Dictionary<int, List<Box>>();

            var method = new List<Box>();
            if (s.SubDeep > 0 && s.SubHigh > 0 && s.SubWidth > 0)
            {
                method.Add(new Box("Block", s.SubDeep, s.SubWidth, s.SubHigh, 1, 1, 1));
            }
        }

        /// <summary>
        /// 计算是否可以添加
        /// </summary>
        /// <param name="s"></param>
        /// <param name="method"></param>
        /// <returns></returns>
        private bool Comp(Space s, List<Box> method, Box next)
        {
            if (!CheckVolume(s.GetVolume(), method, next))
                return false;


            return area >= 0;
        }

        /// <summary>
        /// 体积验证
        /// </summary>
        /// <param name="max"></param>
        /// <param name="method"></param>
        /// <param name="next"></param>
        /// <returns></returns>
        private bool CheckVolume(int max, List<Box> method, Box next)
        {
            method.ForEach(f =>
            {
                max -= f.GetVolume();
            });
            max -= next.GetVolume();
            if (max < 0)
                return false;
            return true;
        }

        /// <summary>
        /// 添加水平旋转后的盒子
        /// </summary>
        /// <param name="b"></param>
        /// <param name="ifTurn"></param>
        /// <returns></returns>
        private List<Box> GetTurn(List<Box> b, bool ifTurn)
        {
            List<Box> nb = null;
            if (ifTurn)
            {
                nb = new List<Box>();
                b.ForEach(f =>
                {
                    nb.Add(f);
                    if (f.Deep != f.Width)
                    {
                        nb.Add(new Box(name: $"{f.Name}-T"
                            , deep: f.Deep
                            , width: f.Width
                            , high: f.High)
                            );
                    }
                });
            }
            else
            {
                nb = b;
            }
            return nb;
        }
    }
}
