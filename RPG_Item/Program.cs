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
        /// <summary>
        /// メイン処理
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // プレイヤー作成
            Player player = new Player()
            {
                // リストの生成
                HaveItems = new List<Item>(),

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
                //---------------------------
                // 表示処理

                // 所持金の表示
                Console.WriteLine("[ プレイヤーの所持金 ]" + "\n" + player.HaveMoney + "$" + "\n");

                // アイテムリストの表示
                Console.WriteLine("[ 道具屋のアイテム一覧 ]");
                Console.WriteLine("========================================");
                foreach (Item item in shopList)
                {
                    Console.WriteLine(item.ID.ToString() + "：" + item.Name + "  " + item.Price + "$" );
                }
                Console.WriteLine("========================================" + "\n");

                // 所持アイテムの表示
                Console.WriteLine("[ プレイヤーの所持アイテム ]");
                if (player.HaveItems.Count == 0) 
                {   // 所持アイテムが無いとき
                    Console.WriteLine("なし" + "\n");
                }
                else
                {   // 所持アイテムが有るとき
                    foreach (Item item in player.HaveItems)
                    {   // アイテム名の表示
                        Console.WriteLine(item.Name);
                    }
                    Console.WriteLine();    // 改行
                }

                //---------------------------
                // 入力処理

                Console.Write("購入するアイテムIDを入力 (0で終了)：");
                var input = Console.ReadLine();
                switch (input)
                {
                    case "0":   // 終了処理
                        break;

                    case "1":   // なべのふた
                        // 購入処理
                        BuyItem(player, shopList[0]);

                        break;

                    case "2":   // どうのつるぎ
                        BuyItem(player, shopList[1]);

                        break;

                    case "3":   // やくそう
                        BuyItem(player, shopList[2]);
                        break;

                    default:    // 無効入力
                        Console.WriteLine("有効な数字を入力してください");
                        break;
                }

                if (input == "0") { break; }    // 0入力で終了

                Console.WriteLine("\n" + "Enterで進む...");
                Console.ReadLine();
                Console.Clear();    // 画面クリア
            }
        }

        /// <summary>
        /// 購入処理
        /// </summary>
        /// <param name="player">プレイヤー情報</param>
        /// <param name="item">  購入アイテム情報</param>
        static void BuyItem(Player player,Item item)
        {
            // 所持金チェック
            if (player.HaveMoney < item.Price)
            {
                Console.WriteLine("所持金が足りません");
            }
            else
            {   // 購入処理
                player.HaveMoney -= item.Price;  // 所持金の減算
                player.HaveItems.Add(item);      // プレイヤーの所持品に追加
            }
        }
    }
}
