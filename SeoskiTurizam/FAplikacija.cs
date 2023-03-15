using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeoskiTurizam
{
    public partial class FAplikacija : Form
    {
        public FAplikacija()
        {
            InitializeComponent();
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string ispis = e.Node.Text;

            switch(ispis)
            {
                case "Prikaz sela":label1.Text = "На форми се приказују подаци о свим селима  у listView контроли. " +
                        "У comboBox контроли су учитани све градови сортирани по азбучном реду." +
                        "\n\nУносом шифре села у одговарајуће текстуално поље, уколико за унету шифру постоје, подаци о селу се приказују на форми и селектује се одговарајући град у comboBox-u. " +
                        "\n\nТакође, одговарајући ред у листи бива селектован.  ";
                    break;
                case "Izmena sela":label1.Text = "Подаци о изабраном селу се могу допунити и/или изменити уносом нових вредности, " +
                        "а кликом на дугме Унеси измене, измењене вредности се памте у бази. " +
                        "\n\nУ случају успешне измене освежити приказ у listView контроли." +
                        "\n\nПоруку о успешности измене приказати у MessageBox-у, а у услучају неуспешне акције, додати запис у лог фајл са називом error.txt. " +
                        "\n\nФајл садржи по један ред за сваку грешку насталу при изменама података (датум покушаја измене и разлог неуспешности промене).  ";
                    break;
                case "Statistički pregled":
                    label1.Text = "Дугме Додели ваучере отвара другу форму на којој се за оне клијенте који су активни  приказује пуно име клијента и број купљених аранжмана. " +
                        "\n\nОбезбедити да се на списку виде само они клијенти  који имају више од задатог броја купљених аражмана.  ";
                    break;
                case "Zatvaranje aplikacije":
                    label1.Text = "Кликом на дугме Излаз у линији алата прве форме, затворити целу апликацију. ";
                    break;
                case "Dodatni zahtevi":
                    label1.Text = "Отворити кратко корисничко упутство кликом на дугме „О апликацији“.";
                    break;
                case "Autor":
                    label1.Text = "Autor:Весна Станојевић";
                    break;
            }    
        }
    }
}
