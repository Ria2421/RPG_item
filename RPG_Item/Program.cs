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

                // 入力処理
                Console.Write("購入するアイテムIDを入力 (0で終了)：");
                var input = Console.ReadLine();
                switch (input)
                {
                    case "0":
                        break;

                    case "1":
                        // 所持金チェック
                        if(player.HaveMoney < shopList[0].Price)
                        {
                            Console.WriteLine("所持金が足りません");
                        }
                        else
                        {   // 購入処理
                            player.HaveMoney -= shopList[0].Price;  // 所持金の減算
                            Item item = shopList[0];                // アイテム情報の取得
                            player.HaveItems.Add(item);             // プレイヤーの所持品に追加
                        }

                        break;

                    case "2":
                        // 所持金チェック
                        if (player.HaveMoney < shopList[1].Price)
                        {
                            Console.WriteLine("所持金が足りません");
                        }
                        else
                        {   // 購入処理
                            player.HaveMoney -= shopList[1].Price;  // 所持金の減算
                            Item item = shopList[1];                // アイテム情報の取得
                            player.HaveItems.Add(item);             // プレイヤーの所持品に追加
                        }

                        break;

                    case "3":
                        // 所持金チェック
                        if (player.HaveMoney < shopList[2].Price)
                        {
                            Console.WriteLine("所持金が足りません");
                        }
                        else
                        {   // 購入処理
                            player.HaveMoney -= shopList[2].Price;  // 所持金の減算
                            Item item = shopList[2];                // アイテム情報の取得
                            player.HaveItems.Add(item);             // プレイヤーの所持品に追加
                        }

                        break;

                    default:
                        Console.WriteLine("有効な数字を入力してください");
                        break;
                }

                if (input == "0") { break; }    // 0入力で終了

                Console.WriteLine("\n" + "Enterで進む...");
                Console.ReadLine();
                Console.Clear();    // 画面クリア
            }
        }
    }
}
