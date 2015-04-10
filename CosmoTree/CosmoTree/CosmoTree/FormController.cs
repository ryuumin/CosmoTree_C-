using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace CosmoTree
{
    class FormController
    {
        public static MyBaseForm topPage;
        public static string userName;
        public static string age;

        FormController()
        {

        }

        static public void createForm(Form newForm, Form oldForm)
        {
            newForm.Show();
            newForm.Location = oldForm.Location;
            oldForm.Visible = false;
        }

        static public void setUserGraph(Chart chart)
        {
            String url = "http://ecl.secret.jp/imazumi/C/GetSkillGraph.php?UserName=" + FormController.userName;
            string html = ServerController.sendMySQL(url);
            Debug.Print(html.Substring(11,15));

            //5ケタの整数の連結が帰って来るので切り出して使う
            //最初と最後は　"　が入るのでそこは無視
            chart.Series.Clear();  //グラフ初期化
            setGraphvalue(chart,"デザイン", int.Parse(html.Substring(1,5)));
            setGraphvalue(chart, "ソフトウェア", int.Parse(html.Substring(6, 5)));
            setGraphvalue(chart, "ハードウェア", int.Parse(html.Substring(11, 5)));
            setGraphvalue(chart, "サウンド", int.Parse(html.Substring(16, 5)));
            setGraphvalue(chart, "企画", int.Parse(html.Substring(21, 5)));
        }

        static public void setProductionGraph(Chart chart)
        {
            String url = "http://ecl.secret.jp/imazumi/C/GetProductionGraph.php?UserName=" + FormController.userName;
            string html = ServerController.sendMySQL(url);
            Debug.Print(html.Substring(11, 15));

            chart.Series.Clear();  //グラフ初期化
            setGraphvalue(chart, "Webサービス", int.Parse(html.Substring(1, 5)));
            setGraphvalue(chart, "ゲーム", int.Parse(html.Substring(6, 5)));
            setGraphvalue(chart, "映画", int.Parse(html.Substring(11, 5)));
            setGraphvalue(chart, "Android/iPhone", int.Parse(html.Substring(16, 5)));
            setGraphvalue(chart, "hoge", int.Parse(html.Substring(21, 5)));
        }

        static void setGraphvalue(Chart chart,String legend,int num) {
            chart.Series.Add(legend);  //グラフ追加
            //グラフの種類を指定（Columnは棒グラフ）
            chart.Series[legend].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            chart.Series[legend].LegendText = legend;  //凡例に表示するテキストを指定

            string[] xValues = new string[] {" "};
            int[] yValues = new int[] { num };

            for (int i = 0; i < xValues.Length; i++)
            {
                //グラフに追加するデータクラスを生成
                System.Windows.Forms.DataVisualization.Charting.DataPoint dp = new System.Windows.Forms.DataVisualization.Charting.DataPoint();
                dp.SetValueXY(xValues[i], yValues[i]);  //XとYの値を設定
                dp.IsValueShownAsLabel = true;  //グラフに値を表示するように指定
                chart.Series[legend].Points.Add(dp);   //グラフにデータ追加
            }
        }

    }
}
