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

    internal class Player
    {
        /// <summary>
        /// 所持アイテム
        /// </summary>
        public List<Item> HaveItems { get; set; }

        /// <summary>
        /// 所持金
        /// </summary>
        public int HaveMoney { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // プレイヤー作成
            Player player = new Player()
            {
                // 所持金の設定
                HaveMoney = 1000
            };

            // 道具屋のアイテムリスト
            List<Item> shopList = new List<Item>()
            {
                new Item() { ID = 1, Name = "なべのふた", Price = 300 },
                new Item() { ID = 2, Name = "どうのつるぎ", Price = 500},
                new Item() { ID = 3, Name = "やくそう", Price = 100}
            };

            while (true)
            {
                // 所持金の表示
                Console.WriteLine("プレイヤーの所持金" + player.HaveMoney + "$" + "\n");

                // アイテムリストの表示
                Console.WriteLine("道具屋のアイテム一覧");
                Console.WriteLine("========================================");
                foreach (Item item in shopList)
                {
                    Console.WriteLine(item.ID.ToString() + "：" + item.Name + "  " + item.Price + "$" );
                }
                Console.WriteLine("========================================");

                // 入力処理
                var input = Console.ReadLine();
                if (input == "0") { break; }    // 0入力で終了
            }
        }
    }
}
