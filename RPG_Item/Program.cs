//--------------------------------------------------
//
// メインプログラム [Program.cs]
// Author:Kenta Nakamoto
// Data 2024/08/30
// Update 2024/08/30
//
//--------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Item
{
    internal class Item
    {
        /// <summary>
        /// アイテムID
        /// </summary>
        public int ID {  get; set; }

        /// <summary>
        /// アイテム名
        /// </summary>
        public string Name {  get; set; }

        /// <summary>
        /// 価格
        /// </summary>
        public int Price {  get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // 道具屋のアイテムリスト
            List<Item> shopList = new List<Item>()
            {
                new Item() { ID = 1, Name = "なべのふた", Price = 300 },
                new Item() { ID = 2, Name = "どうのつるぎ", Price = 500},
                new Item() { ID = 3, Name = "やくそう", Price = 100}
            };
        }
    }
}
