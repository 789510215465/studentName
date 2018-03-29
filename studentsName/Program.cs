using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentsName
{
    class Program
    {
        static void Main(string[] args)
        {
            // 存在矩陣內的學生資料
            string[] names = { "葉俊廷", "張澤瑜", "王程捷 的咩？", "江儀婷", "張秉華", "陳柏霖", "黃紀瑜", "黃昱維", "蔡逸群", "登琳", "世新魏鈞孝吧", "劉定南", "陳信如", "童信傑", "李岳倫", "鄒和恆", "簡毓玟", "劉子瑄", "蕭紹洋", "李亞宸la", "張以潔", "邱仕紳", "呂家瑩", "世新林鑫佑", "徐均得", "陳佳欣", "張恩瑋", "周詮", "王湘婷", "蕭宇成", "Max Cheung(BANG)", "馬嘉誠Σヽ(ﾟД ﾟ; )ﾉ魔貫光殺砲(ﾟДﾟ)σ━0000", "陳昱嘉", "康珈熏", "盧奕宏", "陳郁佳的大哥黃博涵", "遲正雯", "世新林星彤", "許晏誠ｘ勒是奇多＿８＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝Ｄ　", "許子安", "高子晴", "陳思婷", "矝鵘鮿", "余彥廷", "吳耀輝", "鄭丞智", "林冠廷", "世新何曜宇", "邵喬雨", "張豐愷", "林子晴", "邱雁回", "陳家欣是韓妞", "鄧雅馨", "謝汶珊", "李曼寧", "世新徐偉哲", "张钰慈", "鍾宜珊", "raer_tsai", "世新李姳諼", "鄭曼君", "陳柏霖", "世新許子安", "世新方若帆", "李曼寧", "世新遲正雯", "世新周詮" };
            string[] bloodType = { "O", "其他", "O", "O", "A", "O", "A", "A", "O", "O", "A", "O", "A", "B", "O", "O", "A", "其他", "O", "O", "A", "", "B", "O", "", "O", "B", "O", "B", "B", "B", "O", "O", "AB", "O", "B", "A", "O", "O", "", "O", "A", "", "O", "O", "A", "O", "O", "其他", "B", "O", "O", "O", "A", "AB", "A", "O", "B", "AB", "", "O", "O", "O", "", "O", "A", "A", "O" };
            string[] gender = { "男", "男", "男", "女", "男", "男", "女", "男", "男", "男", "男", "男", "女", "男", "男", "男", "女", "女", "男", "男", "女", "男", "女", "男", "男", "女", "男", "男", "女", "男", "男", "男", "男", "女", "男", "男", "女", "女", "男", "男", "女", "女", "男", "男", "男", "男", "男", "男", "女", "男", "女", "女", "女", "女", "女", "女", "男", "女", "女", "女", "女", "女", "男", "男", "女", "女", "女", "男" } ;
            string[] zodiac = { "金牛", "", "巨蟹", "白羊", "雙魚", "雙子", "天蠍", "巨蟹", "獅子", "雙魚", "雙子", "雙子", "獅子", "雙魚", "天蠍", "天蠍", "處女", "處女", "金牛", "雙魚", "處女", "摩羯", "雙魚", "白羊", "天蠍", "處女", "雙子", "金牛", "雙子", "白羊", "白羊", "摩羯", "射手", "巨蟹", "雙魚", "獅子", "射手", "摩羯", "天蠍", "", "雙魚", "雙子", "", "雙魚", "處女", "金牛", "天秤", "水瓶", "巨蟹", "處女", "白羊", "摩羯", "水瓶", "天秤", "金牛", "天蠍", "天蠍", "處女", "", "", "摩羯", "天蠍", "雙子", "", "獅子", "天蠍", "射手", "金牛" };
            int[] heights = { 173, 1000, 179, 155, 183, 170, 163, 174, 165, 189, 177, 180, 154, 167, 170, 173, 165, 158, 180, 165, 153, 175, 162, 165, 10000, 160, 165, 173, 164, 177, 177, 180, 170, 151, 176, 180, 168, 152,1000, 1000 , 165, 155, 777, 173, 169, 170, 169, 171, 0, 170, 150, 160, 155, 164, 163, 165, 184, 165, 155, 1000, 168, 160, 169, 1000, 150, 163, 168, 173 };

            // 宣告(男/女)總數
            int countBl = 0 ;
            int countGl = 0 ;
            int countTotal = 0 ;

            // 宣告血型
            int countA = 0 ;
            int countB = 0 ;
            int countAB = 0 ;
            int countO = 0 ;
            int countUnknow = 0 ;

            // 宣告身高最高級最矮
            int maxH = 0 ;
            int minH = 199 ;

            // 宣告男女身高總合
            int sumHGl = 0 ;
            int sumHBl= 0 ;
            int sumTotal = 0 ;             

            double total = names.Length;

            
            for (int i = 0; i< names.Length; i++)
            {
                // 所有人名
                Console.WriteLine( names[i] );

                // 身高
                if (heights[i] > 100 && heights[i] < 200)
                {
                    if (heights[i] > maxH)
                    {
                        maxH = heights[i];
                    }
                    if (heights[i] < minH)
                    {
                        minH = heights[i];
                    }

                    if (gender[i]=="女")
                    {
                        sumHGl = sumHGl+ heights[i];
                        countGl++;
                    }
                    else if (gender[i] == "男")
                    {
                        sumHBl = sumHBl + heights[i];
                        countBl++;
                    }
                }          

                // 血型
                    if ( bloodType[i] =="O" ) {
                    countO++;
                } 
                else if( bloodType[i] == "A") {
                    countA++;
                }
                else if ( bloodType[i] == "B" ) {
                    countB++;
                }
                else if ( bloodType[i] == "AB" ) {
                    countAB++;
                }
                else if (bloodType[i] == "其他" ){
                    countUnknow++;
                }
            }

            Console.WriteLine();

            // 計算平均身高
            double averageBl = (double)sumHBl / (double)countBl ;
            double averageGl = (double)sumHGl / (double)countGl ;

            // 計算全班平均身高
            sumTotal = sumHBl + sumHGl ;
            countTotal = countBl + countGl ;
            double averageTotal = (double)sumTotal / (double)countTotal;

            // 輸出
            Console.Write("正常的男性人數 : " + countBl);
            Console.Write(" " + " 正常的男性身高總和 : " + sumHBl );
            Console.WriteLine(" " + " 正常的男性身高平均 : {0:0} " , averageBl );
            Console.Write("正常的女性人數 : " + countGl);
            Console.Write(" " + " 正常的女性身高總和 : " + sumHGl );
            Console.WriteLine(" " + " 正常的女性身高平均 : {0:0} " , averageGl );

            // 身高最大值及最小值
            Console.Write( "全班身高最高為 : " + maxH);
            Console.Write( " 全班身高最矮為 : " + minH );
            Console.WriteLine(" " + " 全班身高平均為 : {0:0}" , averageTotal );
            Console.WriteLine();

            // 計算
            double percentA = (double)countA / (double)total *100;
            double percentB = (double)countB / (double)total * 100;
            double percentAB = (double)countAB / (double)total * 100;
            double percentO = (double)countO / (double)total * 100;
            double percentUnknow = (double)countUnknow / (double)total * 100;

            Console.Write("血型A人數為 : " + countA);
            Console.WriteLine( " 百分比為 : {0:00.00}% ", percentA );
            Console.Write( "血型B人數為 : " + countB );
            Console.WriteLine( " 百分比為 : {0:00.00}% ", percentB);
            Console.Write( "血型AB人數為 : " + countAB );
            Console.WriteLine( " 百分比為 : {0:00.00}% ", percentAB);
            Console.Write( "血型O人數為 : " + countO );
            Console.WriteLine( " 百分比為 : {0:00.00}% ", percentO);
            Console.Write( "血型不可告人之人數為 : " + countUnknow );
            Console.WriteLine( " 百分比為 : {0:00.00}% ", percentUnknow);

            Console.ReadKey();
        }
    }
}
