using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;


namespace RSA
{
    public partial class Form1 : Form
    {

        BigInteger temp_P;
        BigInteger temp_Q;

        BigInteger temp_N;
        BigInteger temp_E;
        BigInteger temp_L;
        BigInteger temp_D;


        public Form1()
        {
            InitializeComponent();
        }


        //---------------------------------------------------------获取参数按钮事件
        private void btn_GetParameter_Click(object sender, EventArgs e)
        {
            // 检测text是否为空
            if ((txb_P.Text == "") || (txb_Q.Text == ""))
            {
                return;
            }

            // 计算 P Q 是否为素数
            if (CheckIsPrime(BigInteger.Parse(txb_P.Text)) == false)
            {
                txb_P.ForeColor = Color.Red;                   // 如果不是素数，字体变为红色
                return;
            }
            else
            {
                txb_P.ForeColor = Color.Black;                 // 如果是素数，恢复黑色
            }

            if (CheckIsPrime(BigInteger.Parse(txb_Q.Text)) == false)
            {
                txb_Q.ForeColor = Color.Red;
                return;
            }
            else
            {
                txb_Q.ForeColor = Color.Black;
            }

            // 计算相关参数  N  L  E  D
            temp_N = BigInteger.Parse(txb_P.Text) * BigInteger.Parse(txb_Q.Text);                                // 计算参数 N = P * Q
            txb_N.Text = temp_N.ToString();
            txb_L.Text = ((BigInteger.Parse(txb_P.Text) - 1) * (BigInteger.Parse(txb_Q.Text) - 1)).ToString();   // 计算参数 L = n*(P - 1)*(Q - 1)      n 暂时为1

            for (BigInteger i = 2; i < BigInteger.Parse(txb_L.Text); i++)                                        // 计算参数 E    E与L互质  且 1< E < L
            {
                if (GCD(BigInteger.Parse(txb_L.Text), i) == 1)                                                   // 不一定为最小互质数，这里为了简化设计，取最小
                {
                    txb_E.Text = i.ToString();
                    break;
                }
            }

            temp_P = BigInteger.Parse(txb_P.Text);                    // 记录参数
            temp_Q = BigInteger.Parse(txb_Q.Text);
            temp_E = Convert.ToInt32(txb_E.Text);
            temp_N = BigInteger.Parse(txb_N.Text);
            temp_L = BigInteger.Parse(txb_L.Text);

            temp_D = Find_Parameter_D(temp_E, temp_L);                // 计算参数 D       E*D % L = 1

            txb_D.Text = temp_D.ToString();

            lab_Public_Key.Text = "E :" + temp_E.ToString() + "   " + "N :" + temp_N.ToString();
            lab_Private_Key.Text = "D :" + temp_D.ToString() + "   " + "N :" + temp_N.ToString();
            
        }

        //--------------------------------------- 加密按钮事件
        private void btn_Encryption_Click(object sender, EventArgs e)
        {
            BigInteger temp_Ciphertext = 1;


            if (BigInteger.Parse(rtb_Ciphertext.Text) > temp_N)                     // 判断密文数值大小
            {
                MessageBox.Show("密文数值需要小于参数N !");
                return;
            }

            if (rtb_Ciphertext.Text != "")  // 判断是否为空
            {
                lab_States.Text = "加密计算中！";

                //for (BigInteger i = 0; i < temp_E; i++)                             
                //{
                //    temp_Ciphertext *= BigInteger.Parse(rtb_Ciphertext.Text);
                //}

                //temp_Ciphertext = BigInteger.Pow(BigInteger.Parse(rtb_Ciphertext.Text), temp_E);// 加密过程： 密文^E % N
                //temp_Ciphertext = temp_Ciphertext % temp_N;

                temp_Ciphertext = BigInteger.ModPow(BigInteger.Parse(rtb_Ciphertext.Text), temp_E, temp_N);     // 利用蒙哥马利算法

                rtb_Rule.Text = temp_Ciphertext.ToString();

                lab_States.Text = "加密计算完成！";
            }
        }


        //--------------------------------------- 解密按钮事件
        private void btn_Decrypt_Click(object sender, EventArgs e)
        {
            BigInteger temp_Result = 1;

            if (rtb_Rule.Text != "")    // 判断是否为空
            {
                lab_States.Text = "解密计算中！";
                this.Refresh();
                //for (BigInteger i = 0; i < temp_D; i++)
                //{
                //    temp_Result *= BigInteger.Parse(rtb_Rule.Text);                
                //}

                //temp_Result = BigInteger.Pow(BigInteger.Parse(rtb_Rule.Text), temp_D);// 解密过程：明文^D % N
                //temp_Result = temp_Result % temp_N;

                temp_Result = BigInteger.ModPow(BigInteger.Parse(rtb_Rule.Text), temp_D, temp_N);               // 利用蒙哥马利算法

                rtb_result.Text = temp_Result.ToString();

                lab_States.Text = "解密计算完成！";
            }
        }


        //---------------------------------------- 获取最小互质数（计算私钥D）
        public BigInteger Find_Parameter_D(BigInteger data_e, BigInteger data_l)
        {
            BigInteger i;
            BigInteger temp_mod;

            for (i = 2; i < data_l; i++)
            {
                temp_mod = (data_e * i) % data_l;
                if (temp_mod == 1)
                {
                    return (BigInteger)i;
                }
            }
            return 0;
        }


        //---------------------------------------- 获取最小公约数
        public BigInteger GCD(BigInteger m, BigInteger n)
        {
            BigInteger r, t;
            if (m < n)
            {
                t = n;
                n = m;
                m = t;
            }
            while (n != 0)
            {
                r = m % n;
                m = n;
                n = r;

            }
            return (m);
        }


        //----------------------------------------- 检测传入参数是否是素数
        public bool CheckIsPrime(BigInteger data)
        {
            BigInteger i;

            for (i = 2; i < data; i++)
            {
                if ((data % i) == 0)
                {
                    return false;             // 如果不是  返回false
                }
            }

            return true;                      // 如果是素数  返回ture
        }




    }
}
