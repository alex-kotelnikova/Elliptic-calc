using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OxyPlot;
using OxyPlot.Series;


namespace calc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
          /*  var myModel = new PlotModel { Title = "Example 1" };
            double x1, x2, y1, y2, k, b;
            x1 = 1.75;
            x2 = 0.3;
            y1 = -2.5;
            y2 = -0.5;
            k = (y1 - y2) / (x1 - x2);
            b = y1 - k * x1;
          //  myModel.Series.Add(new FunctionSeries(x => Math.Sqrt((x * x * x - 255 * -14 * 54 * 255 * x + 1 * 1)), -100000, 0, 1000));
         //   myModel.Series.Add(new FunctionSeries(x => -Math.Sqrt((x * x * x - 255 * -14 * 54 * 255 * x + 1 * 1)), -100000, 0, 1000));
            myModel.Series.Add(new FunctionSeries(x => Math.Sqrt((x * x * x - x + 1 * 1)), -3, 3, 0.0001));
            myModel.Title=("Эллиптические кривые");
           myModel.Series.Add(new FunctionSeries(x => -Math.Sqrt((x * x * x - x + 1 * 1)), -3, 3, 0.0001));
          myModel.Series.Add(new FunctionSeries(x => (k * x + b), -1.5, 3, 0.0001));
            this.plot1.Model = myModel;*/
        }
  /*      public static  void my(double x, double y)
    {
        y =  Math.Sqrt(x * x * x + x + 1);
        return   ;
    }*/
        public int[] input_only_number(string my_string, int sign)
        {
            string str_final;
            str_final="";
            int i = 0;
            sign = 0;
            for (i = 0; i < my_string.Length; i++)
            {
                if ((my_string[i] >= '0') && (my_string[i] <= '9'))
                {
                    str_final = str_final + my_string[i];
                }
            }
            if (my_string[0] == '-')
                sign = 1;
            return input_my(str_final);
        }
        public int[] input_my(string number_str)
        {
            int length = number_str.Length;
            int i;
            int[] number = new int[length];
            for (i = 0; i < length; i++)
            {
                    number[length-1-i] = (number_str[i] - 48);
            }
            return number;
        }

        public int base_number = 10;
        public long base_numberl = 10;
        public long t_long ;
        public static int[] x_3 = new int[617];
        public static int[] y_3 = new int[617];
        public string notation = "Dec";
        public int[] cut_zero (int[] massive)
        {
            int i = 0;
            int j=0;
            for (i=massive.Length-1; i>=0; i--)
            {
                if (massive[i] != 0)
                    break;
            }
            if (i == -1) i++;
            int[] result=new int [i+1];
            for (j = 0; j <= i; j++)
                result[j] = massive[j];
            return result;
        }

        public string output_my (int[] result_sum_, int length)
        {
            int i = 0;
            int x = 0;
            char[] result_char_sum = new char[length];
            for (i = (length - 1); i >= 0; i--)
                result_char_sum[length - 1 - i] = (char)(result_sum_[i] + 48);
            i = 0;
            while (result_char_sum[i] == 48)
            {
                if (i >= length - 1)
                    break;
                x++;
                i++;
            }
            char[] result_char_sum_final = new char[length - x];
            for (i = 0; i < (length - x); i++)
                result_char_sum_final[i] = result_char_sum[x + i];
            string result_str_sum = new string(result_char_sum_final);
                return result_str_sum; 
        }

        public int cmp_my (int[] my_number_1, int[] my_number_2)
        {
            int sign=0;
            int i = 0;
            int c = 0;
            int t = 0;
            int b = 0;
            int length;
            int length_1 = my_number_1.Length;
            int length_2 = my_number_2.Length;
            int[] Number_1;
            int[] Number_2;
            if (length_1 > length_2)
            {
                length = length_1;
                Number_1 = new int[length];
                Number_2 = new int[length];
                Number_1 = my_number_1;
                Number_2 = equal_length(my_number_2, length);
            }
            else
            {
                length = length_2;
                Number_1 = new int[length];
                Number_2 = new int[length];
                Number_2 = my_number_2;
                Number_1 = equal_length(my_number_1, length);
            }
            for (i = 0; i < length; i++)
            {
                t = Number_1[i] - Number_2[i] + b;
                if (t < 0)
                {
                    c = (t + 10) % base_number;
                    b = (t - 1 - c) / base_number;
                }
                else
                {
                    c = (t) % base_number;
                    b = (t - c) / base_number;
                }
            }
            if (b == -1)
                sign = 1;
            return sign;
        }

        public int cmp_my_equal (int[] my_number_1, int[] my_number_2)
        {
            int sign = 0;
            int i = 0;
            int c = 0;
            int t = 0;
            int b = 0;
            int length;
            int length_1 = my_number_1.Length;
            int length_2 = my_number_2.Length;
            int[] Number_1;
            int[] Number_2;
            int zero = 0;
            if (length_1 > length_2)
            {
                length = length_1;
                Number_1 = new int[length];
                Number_2 = new int[length];
                Number_1 = my_number_1;
                Number_2 = equal_length(my_number_2, length);
            }
            else
            {
                length = length_2;
                Number_1 = new int[length];
                Number_2 = new int[length];
                Number_2 = my_number_2;
                Number_1 = equal_length(my_number_1, length);
            }
            for (i = 0; i < length; i++)
            {
                t = Number_1[i] - Number_2[i] + b;
                if (t < 0)
                {
                    c = (t + 10) % base_number;
                    b = (t - 1 - c) / base_number;
                    t = t + 10;
                }
                else
                {
                    c = (t) % base_number;
                    b = (t - c) / base_number;
                }
                if (t != 0)
                    zero = 1;
            }

            if (b == -1)
                sign = 1;
            if (zero == 0)
                sign = 2;
                return sign;
        }

        public long bl;
        public int[] my_deduct (int[] my_number_1, int[] my_number_2, int sign)
        {
            int c = 0;
            int i = 0;
            int t=0;
            int b = 0;
            
            int length_1 = my_number_1.Length;
            int length_2 = my_number_2.Length;
            int length;
            int[] Number_1;
            int[] Number_2;
            if (length_1 > length_2)
            {
                length = length_1;
                Number_1 = new int[length];
                Number_2 = new int[length];
                Number_1 = my_number_1;
                Number_2 = equal_length(my_number_2, length);
            }
            else
            {
                length = length_2;
                Number_1 = new int[length];
                Number_2 = new int[length];
                Number_2 = my_number_2;
                Number_1 = equal_length(my_number_1, length);
            }
            int[] result_deduct= new int[length*2];
            if ((sign == 0))
            {
                for (i = 0; i < length; i++)
                {
                    t = Number_1[i] - Number_2[i] + b;
                    if (t < 0)
                    {
                        c = (t + 10) % base_number;
                        b = (t - 1 - c) / base_number;
                    }
                    else
                    {
                        c = (t) % base_number;
                        b = (t - c) / base_number;
                    }
                    result_deduct[i] = c;
                }
            }
            if (sign == 1)
            {
                for (i = 0; i < length; i++)
                {
                    t = Number_2[i] - Number_1[i] + b;
                    if (t < 0)
                    {
                        c = (t + 10) % base_number;
                        b = (t - 1 - c) / base_number;
                    }
                    else
                    {
                        c = (t) % base_number;
                        b = (t - c) / base_number;
                    }
                 
                    result_deduct[i] = c;
                }
            }
            int[] tmp = cut_zero(result_deduct);
            result_deduct = new int[Number_1.Length];
            for (i = 0; i < tmp.Length; i++)
                result_deduct[i] = tmp[i];
            return result_deduct;
        }

        public int[] my_deduct_modulo (int[] my_number_1, int[] my_number_2, int sign)
        {
            int[] result_deduct = my_deduct(my_number_1, my_number_2, sign);
            int sign_P = 0;
            int[] P = input_only_number(textBox9.Text, sign_P);
            int[] int_part=new int[result_deduct.Length];
            int[] modulo = new int[P.Length + 1];
            int[] one = new int[1];
            one[0] = 1;
            int[] temp;
            if (sign == 1)
            {
                modulo = my_division(result_deduct, P, int_part);
                temp = my_deduct(my_mul(P, my_sum(one, int_part)), result_deduct, cmp_my(my_mul(P, my_sum(one, int_part)), result_deduct));
                result_deduct = new int[temp.Length];
                result_deduct = temp;
            }
            return result_deduct;
        }

        public int[] my_sum(int[] number_1, int[] number_2)
        {
            int c = 0;
            int d = 0;
            int b = 0;
            int temporary = 0;
            int length_1 = number_1.Length;
            int length_2 = number_2.Length;
            int length;
            int[] Number_1;
            int[] Number_2;
            if (length_1 > length_2)
            {
                length = length_1;
                Number_1 = new int[length];
                Number_2 = new int[length];
                Number_1 = number_1;
                Number_2 = equal_length(number_2, length);
            }
            else
            {
                length = length_2;
                Number_1 = new int[length];
                Number_2 = new int[length];
                Number_2 = number_2;
                Number_1 = equal_length(number_1, length);
            }
            int[] result_sum = new int[length * 2];
            for (d = 0; d < length; d++)
            {
                temporary = 0;
                temporary = Number_1[d] + Number_2[d] + b;
                c = temporary % base_number;
                b = (temporary - c) / base_number;
                result_sum[d] = c;
            }
            result_sum[d] = b;
            int[] tmp = cut_zero(result_sum);
            return tmp;
        }

        public int[] my_mul (int[] number1, int[] number2)
        {
            int i = 0;
            int c = 0; 
            int t = 0;
            int j = 0;
            int b = 0;
            int length;
            int[] Number_1;
            int[] Number_2;
            int length1=number1.Length;
            int length2 = number2.Length;
            if (length1 > length2)
            {
                length = length1;
                Number_1 = new int[length];
                Number_2 = new int[length];
                Number_1 = number1;
                Number_2 = equal_length(number2, length);
            }
            else
            {
                length = length2;
                Number_1 = new int[length];
                Number_2 = new int[length];
                Number_2 = number2;
                Number_1 = equal_length(number1, length);
            }
            int[] result_mul = new int[length * 2];
            for(i=0;i<length;i++)
            {
                c = 0;
                b = 0;
                for(j=0;j<length;j++)
                {
                    t = result_mul[i + j] + Number_1[i] * Number_2[j] + b;
                    result_mul[i + j] = t % base_number;
                    c = t % base_number;
                    b = (t - c) / base_number;
                }
                result_mul[i + length] = b;
            }
            int[] tmp = cut_zero(result_mul);
            return tmp;
        }

        public int[] equal_length (int[] number, int length)
        {
            int[] new_number = new int[length];
            int j = 0;
            int previous_length = number.Length;
                for(j = 0; j < previous_length;j++)
                {
                    new_number[j] = number[j];
                }
            return new_number;     
        }

        public int[] my_division (int[] numbeR1, int[] numbeR2, int[] integer_parT)
        {
            numbeR1 = cut_zero(numbeR1);
            numbeR2 = cut_zero(numbeR2);
            int length1 = numbeR1.Length;
            int length2 = numbeR2.Length;
            int integer_parT_length = integer_parT.Length;
            int[] NUMBER1 = new int[length1 + 1];
            int[] NUMBER2 = new int[length2];
            int[] number2 = new int[length2];
            int h = 0;
            int div1_tmp;
            int div1_tmp_ost =0;
            int ost = 0;
            int[] res1_div = new int[numbeR1.Length];
            if (numbeR2.Length==1)
            {
                for (h = numbeR1.Length - 1; h >= 0; h--)
                {
                    div1_tmp_ost = ((numbeR1[h]+ost) % numbeR2[0]);
                    div1_tmp = (numbeR1[h]+ost) / numbeR2[0];
                    res1_div[h] = (numbeR1[h]+ost) / numbeR2[0];
                    ost = div1_tmp_ost*10;
                }
                int[] mod1 = new int[1];
                mod1[0] = div1_tmp_ost;
                for (h = 0; h < numbeR1.Length; h++)
                    integer_parT[h] = res1_div[h];
                return mod1;
            }
            //переворачиваю делитель, чтобы был в прямом порядке
            for (h = 0; h < length2; h++)
                number2[h] = numbeR2[length2 - 1 - h];
            int[] modulo = new int[length2];
            //если делитель больше делимого
            if(cmp_my(numbeR1,numbeR2)==1)
            {
                modulo = numbeR1;
           //     integer_parT= new int [1];
                integer_parT[0] = 0;
                return modulo;
            }
            //если делитель равен делимому
            if(cmp_my_equal(numbeR1,numbeR2)==2)
            {
          //      integer_parT = new int[1];
                integer_parT[0] = 1;
                modulo = new int[1];
                modulo[0] = 0;
                return modulo;
            }
            //считаю d
            int d = base_number / (number2[0] + 1);
            // делаю из d  массив для дальнейших операций
            int[] dd_reverse; 
            int[] number_tmp=new int [length1+1];
            string str_dd = Convert.ToString(d);
            dd_reverse = new int[str_dd.Length];
            for (h = 0; h < str_dd.Length; h++)
            {
                dd_reverse[h] = (str_dd[h] - 48);
            }
            //переворачиваю dd для операций
            int[] dd= new int[dd_reverse.Length];
            for (h=0;h<dd.Length;h++)
            {
                dd[h] = dd_reverse[dd_reverse.Length - 1 - h];
            }
            int j = 0;
            int Q = 0;
            int q = 0;
            int c = 0;
            int sign;
            int[] qq;
            int[] num_tmp = new int[length1 + 1];
            int[] tmp_num_2 = new int[length2 + 1];
            string temporary_number1;
            //нормализую делимое, но он сейчас в обратном порядке
            number_tmp = my_mul(numbeR1, dd);
            temporary_number1 = output_my(number_tmp, number_tmp.Length);
            string str_last = output_my(numbeR1, numbeR1.Length);
            //проверим добавился ли разряд
            if (temporary_number1.Length == str_last.Length)
                temporary_number1 = "0" + temporary_number1;
            //а теперь сделаю прямой порядок
            for (h = 0; h < temporary_number1.Length;h++ )
            {
                NUMBER1[NUMBER1.Length-h-1] = (temporary_number1[temporary_number1.Length-h-1] - 48);
            }

            //нормализую делитель, но он сейчас в обратном порядке
            number_tmp = my_mul(numbeR2, dd);
            temporary_number1 = output_my(number_tmp, number_tmp.Length);
            //а теперь сделаю прямой порядок
            for (h = 0; h < temporary_number1.Length; h++)
            {
                NUMBER2[NUMBER2.Length - h - 1] = (temporary_number1[temporary_number1.Length - h - 1] - 48);
            }
            //понадобится для компенсирующего сложения
            tmp_num_2[length2] = 0;
            for (c = 0; c < length2; c++)
                tmp_num_2[c] = NUMBER2[length2 - 1 - c];
            int LENGTH1 = NUMBER1.Length;
            int LENGTH2 = NUMBER2.Length;
            int[] integer_part = new int[LENGTH1 - LENGTH2 + 1];
            //начальная установка j
            j = 0;
            int r;
            while (j < LENGTH1 - LENGTH2)
            {
                //вычисляю Q
                Q = (NUMBER1[j] * base_number + NUMBER1[j + 1]) / (NUMBER2[0]);
                r = (NUMBER1[j] * base_number + NUMBER1[j + 1]) % (NUMBER2[0]);
                while((Q==base_number)||((Q*NUMBER2[1])>(base_number*r+NUMBER1[j+2])))
                {
                    Q = Q - 1;
                    r=r+NUMBER2[0];
                    if (r>=base_number)
                        break;
                }
                //делаем из Q массив
                q=Q;
                string str_qq = Convert.ToString(q);
                qq = new int[str_qq.Length];
                for (h = 0; h < str_qq.Length; h++)
                {
                    qq[h] = (str_qq[h] - 48);
                }
                //Умножить и вычесть
                int[] num = new int[LENGTH2+1];
                for (c=0; c < LENGTH2+1 ; c++)
                    num[c] = NUMBER1[c+j];
                //перевернули часть массива делимого для операций
                int[] temp_num = new int[num.Length];
                for (h = 0; h < num.Length; h++)
                    temp_num[h] = num[num.Length - 1 - h];
                //перевернули Q[] для операций
                int[] temp_qq = new int[qq.Length];
                for (h = 0; h < qq.Length; h++)
                    temp_qq[h] = qq[qq.Length - 1 - h];
                //перевенули делитель для операций
                int[] temp_number2 = new int[NUMBER2.Length];
                for (h = 0; h < NUMBER2.Length; h++)
                    temp_number2[h] = NUMBER2[NUMBER2.Length - 1 - h];
                //непосредственно умножение с вычитанием
                sign = cmp_my(temp_num, my_mul(temp_number2, temp_qq));
                temp_num = my_deduct(temp_num, my_mul(temp_number2, temp_qq), sign);
                //кладем в массив целой части Q[]
                integer_part[j] = q;
                //если при вычитании отрицательный результат, то идем в if. если нет, то просто перекладываем для дальнейших операций
                int[] temp_temp_num=new int [LENGTH2+1];
                temp_temp_num = temp_num;
                if (sign == 1)
                {
                    integer_part[j]--;
                    int[] TEMPtemp=new int [LENGTH2+2];
                    TEMPtemp = my_deduct(tmp_num_2, temp_num, cmp_my(tmp_num_2, temp_num));
                    //пренебрегаем лишним разрядом-переносом
                    temp_temp_num = new int[TEMPtemp.Length];
                    for (h=0;h<temp_temp_num.Length;h++)
                        temp_temp_num[h]=TEMPtemp[h];
                }
                //делаем из обратного порядка прямой
                for (h = 0; h < LENGTH2 +1; h++)
                    num[h] = temp_temp_num[LENGTH2-h];
                //положили в нужное место кусок массива, полученный после вычитания
                for (c = j; c < (j + LENGTH2+1); c++)
                    NUMBER1[c] = num[c-j];
                j++;
            }
            //развернули в обратный порядок для вывода
            for (h = 0; h < j; h++)
                integer_parT[h] = integer_part[j - 1 - h];
            //посчитали остаток 
            modulo = my_deduct(numbeR1, my_mul(integer_parT, numbeR2), cmp_my(numbeR1, my_mul(integer_parT, numbeR2)));
            string modulo_str = output_my(modulo, modulo.Length);
            int[] modulO = new int [modulo_str.Length];
            //переворачиваем длля вывода
            for (h = 0; h < modulo_str.Length; h++)
            {
                modulO[modulo_str.Length-1-h] = (modulo_str[h] - 48);
            }
                return modulO;
        }

        public void Weierstrass (int[] x_1, int[] y_1, int[] x_2, int[] y_2, int[] x_3, int[] y_3, int[] a, int[] b, int[] P )
        {
            //ВЕЙЕРШТРАСС
            int[] modulo_first_part_x_3;
            int[] int_part_of_first_part_x_3;
            int[] modulo_first_part_y_3;
            int[] int_part_of_first_part_y_3;
            int[] modulo_second_part_y_3;
            int[] int_part_of_second_part_y_3;
            int[] tmp_x_3;
            int[] tmp_y_3;
            int[] xx_3;
            int[] yy_3;
            int[] temporary;
            int modeX = cmp_my_equal(x_1, x_2);
            int modeY = cmp_my_equal(y_1, y_2);
            int i=0;
            if ((modeX == 2) && (modeY == 2))
            {
                //Удвоение Вейерштрасс
                int[] x_1_power2 = my_mul(x_1, x_1);
                int[] x_1_power2_3plus = my_sum(my_sum(x_1_power2, x_1_power2), x_1_power2);
                int[] x_1_power2_3plus_plus_a = my_sum(x_1_power2_3plus, a);
                int[] x_1_power2_3plus_plus_a_power2 = my_mul(x_1_power2_3plus_plus_a, x_1_power2_3plus_plus_a);
                int[] x_1_power2_3plus_plus_a_power3 = my_mul(x_1_power2_3plus_plus_a_power2, x_1_power2_3plus_plus_a);
                int[] y_1_2plus = my_sum(y_1, y_1);
                int[] y_1_2plus_power2 = my_mul(y_1_2plus, y_1_2plus);
                int[] y_1_2plus_power3 = my_mul(y_1_2plus_power2, y_1_2plus);
                int[] x_1_2plus = my_sum(x_1, x_1);
                int[] x_1_3plus = my_sum(x_1_2plus, x_1);
                int[] x_1_3plus_mul_x_1_power2_3plus_plus_a = my_mul(x_1_3plus, x_1_power2_3plus_plus_a);
                int_part_of_first_part_x_3 = new int[x_1_power2_3plus_plus_a_power2.Length];
                modulo_first_part_x_3 = my_division(x_1_power2_3plus_plus_a_power2, y_1_2plus_power2, int_part_of_first_part_x_3);
                tmp_x_3 = my_deduct_modulo(int_part_of_first_part_x_3, x_1_2plus, cmp_my(int_part_of_first_part_x_3, x_1_2plus));
                temporary = new int[tmp_x_3.Length];
                xx_3 = my_division(tmp_x_3, P, temporary);
                int_part_of_first_part_y_3 = new int[x_1_3plus_mul_x_1_power2_3plus_plus_a.Length];
                modulo_first_part_y_3 = my_division(x_1_3plus_mul_x_1_power2_3plus_plus_a, y_1_2plus, int_part_of_first_part_y_3);
                int_part_of_second_part_y_3 = new int[x_1_power2_3plus_plus_a_power3.Length];
                modulo_second_part_y_3 = my_division(x_1_power2_3plus_plus_a_power3, y_1_2plus_power3, int_part_of_second_part_y_3);
                tmp_y_3 = my_deduct_modulo(int_part_of_first_part_y_3, my_sum(int_part_of_second_part_y_3, y_1), cmp_my(int_part_of_first_part_y_3, my_sum(int_part_of_second_part_y_3, y_1)));
                temporary = new int[tmp_y_3.Length];
                yy_3 = my_division(tmp_y_3, P, temporary);
            }
            else
            {
                //Сложение Вейерштрасс
                int[] y_2_minus_y_1 = my_deduct_modulo(y_2, y_1, cmp_my(y_2, y_1));
                int[] x_2_minus_x_1 = my_deduct_modulo(x_2, x_1, cmp_my(x_2, x_1));
                int[] y_2_minus_y_1_power2 = my_mul(y_2_minus_y_1, y_2_minus_y_1);
                int[] x_2_minus_x_1_power2 = my_mul(x_2_minus_x_1, x_2_minus_x_1);
                int[] x_1_plus_x_2 = my_sum(x_1, x_2);
                int_part_of_first_part_x_3 = new int[y_2_minus_y_1_power2.Length];
                modulo_first_part_x_3 = my_division(y_2_minus_y_1_power2, x_2_minus_x_1_power2, int_part_of_first_part_x_3);
                tmp_x_3 = my_deduct_modulo(int_part_of_first_part_x_3, x_1_plus_x_2, cmp_my(int_part_of_first_part_x_3, x_1_plus_x_2));
                temporary = new int[tmp_x_3.Length];
                xx_3 = my_division(tmp_x_3, P, temporary);
                int[] x_1_plus_x_1 = my_sum(x_1, x_1);
                int[] x_1_plus_x_1_plus_x_2 = my_sum(x_1_plus_x_1, x_2);
                int[] y_2_minus_y_1_power3 = my_mul(y_2_minus_y_1_power2, y_2_minus_y_1);
                int[] x_2_minus_x_1_power3 = my_mul(x_2_minus_x_1_power2, x_2_minus_x_1);
                int[] x_1_plus_x_1_plus_x_2_mul_y_2_minus_y_1 = my_mul(x_1_plus_x_1_plus_x_2, y_2_minus_y_1);
                int_part_of_first_part_y_3 = new int[x_1_plus_x_1_plus_x_2_mul_y_2_minus_y_1.Length];
                modulo_first_part_y_3 = my_division(x_1_plus_x_1_plus_x_2_mul_y_2_minus_y_1, x_2_minus_x_1, int_part_of_first_part_y_3);
                int_part_of_second_part_y_3 = new int[y_2_minus_y_1_power3.Length];
                modulo_second_part_y_3 = my_division(y_2_minus_y_1_power3, x_2_minus_x_1_power3, int_part_of_second_part_y_3);
                tmp_y_3 = my_deduct_modulo(int_part_of_first_part_y_3, my_sum(int_part_of_second_part_y_3, y_1), cmp_my(int_part_of_first_part_y_3, my_sum(int_part_of_second_part_y_3, y_1)));
                temporary = new int[tmp_y_3.Length];
                yy_3 = my_division(tmp_y_3, P, temporary);
            }
            for (i = 0; i < y_3.Length; i++) y_3[i] = 0;
            for (i = 0; i < x_3.Length; i++) x_3[i] = 0;
            for (i = 0; i < yy_3.Length; i++) y_3[i] = yy_3[i];
            for (i = 0; i < xx_3.Length; i++) x_3[i] = xx_3[i];
                return;
        }

        public int Discriminant_Weierstrass (int[] A, int[] B, int[] P)
        {
            int[] A_power3 = my_mul(my_mul(A, A), A);
            int[] A_power3_4plus = my_sum(my_sum(A_power3, A_power3), my_sum(A_power3, A_power3));
            int[] twenty_seven = new int[2];
            twenty_seven[0] = 7;
            twenty_seven[1] = 2;
            int[] B_power2_mul_twenty_seven = my_mul(my_mul(B, B), twenty_seven);
            int[] A_power3_4plus_plus_B_power2_mul_twenty_seven = my_sum(A_power3_4plus, B_power2_mul_twenty_seven);
            int[] integer_p=new int[A_power3_4plus_plus_B_power2_mul_twenty_seven.Length];
            int[] discriminant_modulo=my_division(A_power3_4plus_plus_B_power2_mul_twenty_seven, P, integer_p);
            int[] zero = new int[discriminant_modulo.Length];
            int flag = cmp_my_equal(discriminant_modulo, zero);
            if (flag == 2)
                return 1;
            return 0;
        }
        
        public int point_belongs_Weierstrass (int[] x, int[] y, int[] P, int[] a, int[] b)
        {
            int[] y_power2 = my_mul(y, y);
            int[] int_part_for_right_side = new int[y_power2.Length];
            int[] right_side = my_division(y_power2, P, int_part_for_right_side);
            int[] x_power3 = my_mul(my_mul(x, x), x);
            int[] a_mul_x = my_mul(a, x);
            int[] x_power3_plus_a_mul_x_plus_b = my_sum(my_sum(x_power3, a_mul_x), b);
            int[] int_part_for_left_side = new int[x_power3_plus_a_mul_x_plus_b.Length];
            int[] left_side = my_division(x_power3_plus_a_mul_x_plus_b, P, int_part_for_left_side);
            int flag = cmp_my_equal(right_side, left_side);
            if (flag == 2)
                return 0;
            return 1;
        }

        public void Montgomery (int[] x_1, int[] y_1, int[] x_2, int[] y_2, int[] x_3, int[] y_3, int[] a, int[] b, int[] P)
        {
            int[] one = new int[1];
            one[0] = 1;
            //МОНТГОМЕРИ
            int[] x_3_first_part_modulo;
            int[] x_3_first_part_int_part;
            int[] y_3_first_part_modulo;
            int[] y_3_first_part_int_part;
            int[] y_3_second_part_modulo;
            int[] y_3_second_part_int_part;
            int[] temporaryTMP;
            int[] y_3_temp;
            int[] x_3_temp;
            int[] xx_3;
            int[] yy_3;
            int i = 0;
            int modeX = cmp_my_equal(x_1, x_2);
            int modeY = cmp_my_equal(y_1, y_2);
            if ((modeX == 2) && (modeY == 2))
            {
                //Удвоение Монтгомери
                int[] x1_power2 = my_mul(x_1, x_1);
                int[] x1_power2_3plus = my_sum(my_sum(x1_power2, x1_power2), x1_power2);
                int[] a_mul_x1 = my_mul(a, x_1);
                int[] a_mul_x1_2plus_plusone = my_sum(my_sum(a_mul_x1, a_mul_x1), one);
                int[] x1_power2_3plus_a_mul_x1_2plus_plusone = my_sum(x1_power2_3plus, a_mul_x1_2plus_plusone);
                int[] x1_power2_3plus_a_mul_x1_2plus_plusone_power2 = my_mul(x1_power2_3plus_a_mul_x1_2plus_plusone, x1_power2_3plus_a_mul_x1_2plus_plusone);
                int[] b_x1_power2_3plus_a_mul_x1_2plus_plusone_power2 = my_mul(b, x1_power2_3plus_a_mul_x1_2plus_plusone_power2);
                int[] b_x1_power2_3plus_a_mul_x1_2plus_plusone_power3 = my_mul(b_x1_power2_3plus_a_mul_x1_2plus_plusone_power2, x1_power2_3plus_a_mul_x1_2plus_plusone);
                int[] b_mul_y1 = my_mul(b, y_1);
                int[] b_mul_y1_2plus = my_sum(b_mul_y1, b_mul_y1);
                int[] b_mul_y1_2plus_power2 = my_mul(b_mul_y1_2plus, b_mul_y1_2plus);
                int[] b_mul_y1_2plus_power3 = my_mul(b_mul_y1_2plus_power2, b_mul_y1_2plus);
                int[] x1_2plus = my_sum(x_1, x_1);
                int[] x1_2plus_plus_a = my_sum(x1_2plus, a);
                int[] x1_3plus_plus_a = my_sum(x1_2plus_plus_a, x_1);
                int[] x1_3plus_plus_a_mul_x1_power2_3plus_a_mul_x1_2plus_plusone = my_mul(x1_3plus_plus_a, x1_power2_3plus_a_mul_x1_2plus_plusone);
                x_3_first_part_int_part = new int[b_x1_power2_3plus_a_mul_x1_2plus_plusone_power2.Length];
                x_3_first_part_modulo = my_division(b_x1_power2_3plus_a_mul_x1_2plus_plusone_power2, b_mul_y1_2plus_power2, x_3_first_part_int_part);
                x_3_temp = my_deduct_modulo(x_3_first_part_int_part, x1_2plus_plus_a, cmp_my(x_3_first_part_int_part, x1_2plus_plus_a));
                temporaryTMP = new int[x_3_temp.Length];
                xx_3 = my_division(x_3_temp, P, temporaryTMP);
                y_3_first_part_int_part = new int[x1_3plus_plus_a_mul_x1_power2_3plus_a_mul_x1_2plus_plusone.Length];
                y_3_first_part_modulo = my_division(x1_3plus_plus_a_mul_x1_power2_3plus_a_mul_x1_2plus_plusone, b_mul_y1_2plus, y_3_first_part_int_part);
                y_3_second_part_int_part = new int[b_x1_power2_3plus_a_mul_x1_2plus_plusone_power3.Length];
                y_3_second_part_modulo = my_division(b_x1_power2_3plus_a_mul_x1_2plus_plusone_power3, b_mul_y1_2plus_power3, y_3_second_part_int_part);
                y_3_temp = my_deduct_modulo(y_3_first_part_int_part, my_sum(y_3_second_part_int_part, y_1), cmp_my(y_3_first_part_int_part, my_sum(y_3_second_part_int_part, y_1)));
                temporaryTMP = new int[y_3_temp.Length];
                yy_3 = my_division(y_3_temp, P, temporaryTMP);
            }
            else
            {
                //Сложение Монтгомери
                int[] y2_minus_y1 = my_deduct_modulo(y_2, y_1, cmp_my(y_2, y_1));
                int[] y2_minus_y1_power2 = my_mul(y2_minus_y1, y2_minus_y1);
                int[] b_y2_minus_y1_power2 = my_mul(b, y2_minus_y1_power2);
                int[] b_y2_minus_y1_power3 = my_mul(b_y2_minus_y1_power2, y2_minus_y1);
                int[] x2_minus_x1 = my_deduct_modulo(x_2, x_1, cmp_my(x_2, x_1));
                int[] x2_minus_x1_power2 = my_mul(x2_minus_x1, x2_minus_x1);
                int[] x2_minus_x1_power3 = my_mul(x2_minus_x1_power2, x2_minus_x1);
                int[] x1_plus_x2_plus_a = my_sum(my_sum(x_1, x_2), a);
                int[] x1_plus_x1_plus_x2_plus_a = my_sum(x1_plus_x2_plus_a, x_1);
                int[] x1_plus_x1_plus_x2_plus_a_mul_y2_minus_y1 = my_mul(x1_plus_x1_plus_x2_plus_a, y2_minus_y1);
                x_3_first_part_int_part = new int[b_y2_minus_y1_power2.Length];
                x_3_first_part_modulo = my_division(b_y2_minus_y1_power2, x2_minus_x1_power2, x_3_first_part_int_part);
                x_3_temp = my_deduct_modulo(x_3_first_part_int_part, x1_plus_x2_plus_a, cmp_my(x_3_first_part_int_part, x1_plus_x2_plus_a));
                temporaryTMP = new int[x_3_temp.Length];
                xx_3 = my_division(x_3_temp, P, temporaryTMP);
                y_3_first_part_int_part = new int[x1_plus_x1_plus_x2_plus_a_mul_y2_minus_y1.Length];
                y_3_first_part_modulo = my_division(x1_plus_x1_plus_x2_plus_a_mul_y2_minus_y1, x2_minus_x1, y_3_first_part_int_part);
                y_3_second_part_int_part = new int[b_y2_minus_y1_power3.Length];
                y_3_second_part_modulo = my_division(b_y2_minus_y1_power3, x2_minus_x1_power3, y_3_second_part_int_part);
                y_3_temp = my_deduct_modulo(y_3_first_part_int_part, my_sum(y_3_second_part_int_part, y_1), cmp_my(y_3_first_part_int_part, my_sum(y_3_second_part_int_part, y_1)));
                temporaryTMP = new int[y_3_temp.Length];
                yy_3 = my_division(y_3_temp, P, temporaryTMP);
            }
            for (i = 0; i < y_3.Length; i++) y_3[i] = 0;
            for (i = 0; i < x_3.Length; i++) x_3[i] = 0;
            for (i = 0; i < yy_3.Length; i++) y_3[i] = yy_3[i];
            for (i = 0; i < xx_3.Length; i++) x_3[i] = xx_3[i];
            return;
        }

        public int Discriminant_Montgomery (int[] A, int[] B, int[] P)
        {
            int[] A_power2 = my_mul(A, A);
            int[] four = new int[1];
            four[0]=4;
            int[] A_power2_minus_four = my_deduct_modulo(A_power2, four, cmp_my(A_power2, four));
            int[] B_mul_A_power2_minus_four = my_mul(B, A_power2_minus_four);
            int[] int_part = new int[B_mul_A_power2_minus_four.Length];
            int[] discr_mod = my_division(B_mul_A_power2_minus_four, P, int_part);
            int[] zero = new int[discr_mod.Length];
            int flag = cmp_my_equal(discr_mod, zero);
            if (flag == 2)
                return 1;
            return 0;
        }

        public int point_belongs_Montgomery (int[] x, int[] y, int[] P, int[] a, int[] b)
        {
            int[] b_mul_y_power2 = my_mul(b, my_mul(y, y));
            int[] int_part_of_left_side = new int[b_mul_y_power2.Length];
            int[] left_side = my_division(b_mul_y_power2, P, int_part_of_left_side);
            int[] x_power3 = my_mul(my_mul(x, x), x);
            int[] a_mul_x_power2 = my_mul(a, my_mul(x, x));
            int[] x_power3_plus_a_mul_x_power2_plus_x = my_sum(x_power3, my_sum(a_mul_x_power2, x));
            int[] int_part_of_right_side = new int[x_power3_plus_a_mul_x_power2_plus_x.Length];
            int[] right_side = my_division(x_power3_plus_a_mul_x_power2_plus_x, P, int_part_of_right_side);
            int flag = cmp_my_equal(left_side, right_side);
            if (flag == 2)
                return 0;
            return 1;
        }

        public void Edwards (int[] x_1, int[] y_1, int[] x_2, int[] y_2, int[] x_3, int[] y_3, int[] a, int[] b, int[] P)
        {
            int[] one = new int[1];
            one[0] = 1;
            int[] xx_3;
            int[] yy_3;
            int i = 0;
            //ЭДВАРДС
            int[] temporaryTEMP;
            int[] y_3_tmp;
            int[] x_3_tmp;
            int modeX = cmp_my_equal(x_1, x_2);
            int modeY = cmp_my_equal(y_1, y_2);
            if ((modeX == 2) && (modeY == 2))
            {
                //Удвоение Эдвардс
                int[] x_1_mul_y_1 = my_mul(x_1, y_1);
                int[] x_1_mul_y_1_2plus = my_sum(x_1_mul_y_1, x_1_mul_y_1);
                int[] x_1_mul_y_1_power2 = my_mul(x_1_mul_y_1, x_1_mul_y_1);
                int[] b_mul_x_1_mul_y_1_power2 = my_mul(b, x_1_mul_y_1_power2);
                int[] one_plus_b_mul_x_1_mul_y_1_power2 = my_sum(one, b_mul_x_1_mul_y_1_power2);
                int[] one_minus_b_mul_x_1_mul_y_1_power2 = my_deduct_modulo(one, b_mul_x_1_mul_y_1_power2, cmp_my(one, b_mul_x_1_mul_y_1_power2));
                int[] y_1_power2 = my_mul(y_1, y_1);
                int[] a_mul_x_1_power2 = my_mul(a, my_mul(x_1, x_1));
                int[] y_1_power2_minus_a_mul_x_1_power2 = my_deduct_modulo(y_1_power2, a_mul_x_1_power2, cmp_my(y_1_power2, a_mul_x_1_power2));
                x_3_tmp = new int[x_1_mul_y_1_2plus.Length];
                temporaryTEMP = my_division(x_1_mul_y_1_2plus, one_plus_b_mul_x_1_mul_y_1_power2, x_3_tmp);
                temporaryTEMP = new int[x_3_tmp.Length];
                xx_3 = my_division(x_3_tmp, P, temporaryTEMP);
                y_3_tmp = new int[y_1_power2_minus_a_mul_x_1_power2.Length];
                temporaryTEMP = my_division(y_1_power2_minus_a_mul_x_1_power2, one_minus_b_mul_x_1_mul_y_1_power2, y_3_tmp);
                temporaryTEMP = new int[y_3_tmp.Length];
                yy_3 = my_division(y_3_tmp, P, temporaryTEMP);
            }
            else
            {
                //Сложение Эдвардс
                int[] x_1_mul_y_2 = my_mul(x_1, y_2);
                int[] x_2_mul_y_1 = my_mul(x_2, y_1);
                int[] x_1_mul_y_2_mul_x_2_mul_y_1 = my_mul(x_1_mul_y_2, x_2_mul_y_1);
                int[] x_1_mul_y_2_plus_x_2_mul_y_1 = my_sum(x_1_mul_y_2, x_2_mul_y_1);
                int[] b_mul_x_1_mul_y_2_mul_x_2_mul_y_1 = my_mul(b, x_1_mul_y_2_mul_x_2_mul_y_1);
                int[] one_plus_b_mul_x_1_mul_y_2_mul_x_2_mul_y_1 = my_sum(one, b_mul_x_1_mul_y_2_mul_x_2_mul_y_1);
                int[] one_minus_b_mul_x_1_mul_y_2_mul_x_2_mul_y_1 = my_deduct_modulo(one, b_mul_x_1_mul_y_2_mul_x_2_mul_y_1, cmp_my(one, b_mul_x_1_mul_y_2_mul_x_2_mul_y_1));
                int[] y_1_mul_y_2 = my_mul(y_1, y_2);
                int[] a_mul_x_1_mul_x_2 = my_mul(my_mul(a, x_1), x_2);
                int[] y_1_mul_y_2_minus_a_mul_x_1_mul_x_2 = my_deduct_modulo(y_1_mul_y_2, a_mul_x_1_mul_x_2, cmp_my(y_1_mul_y_2, a_mul_x_1_mul_x_2));
                x_3_tmp = new int[x_1_mul_y_2_plus_x_2_mul_y_1.Length];
                temporaryTEMP = my_division(x_1_mul_y_2_plus_x_2_mul_y_1, one_plus_b_mul_x_1_mul_y_2_mul_x_2_mul_y_1, x_3_tmp);
                temporaryTEMP = new int[x_3_tmp.Length];
                xx_3 = my_division(x_3_tmp, P, temporaryTEMP);
                y_3_tmp = new int[y_1_mul_y_2_minus_a_mul_x_1_mul_x_2.Length];
                temporaryTEMP = my_division(y_1_mul_y_2_minus_a_mul_x_1_mul_x_2, one_minus_b_mul_x_1_mul_y_2_mul_x_2_mul_y_1, y_3_tmp);
                temporaryTEMP = new int[y_3_tmp.Length];
                yy_3 = my_division(y_3_tmp, P, temporaryTEMP);
            }
            for (i = 0; i < y_3.Length; i++) y_3[i] = 0;
            for (i = 0; i < x_3.Length; i++) x_3[i] = 0;
            for (i = 0; i < yy_3.Length; i++) y_3[i] = yy_3[i];
            for (i = 0; i < xx_3.Length; i++) x_3[i] = xx_3[i];
            return;
        }

        public int Discriminant_Edwards (int[] A, int[] B, int[] P)
        {
            int[] A_power2 = my_mul(A, A);
            int[] B_power2 = my_mul(B, B);
            int[] fourteen = new int[2];
            fourteen[0] = 4;
            fourteen[1] = 1;
            int[] fourteen_mul_A_mul_B = my_mul(fourteen, my_mul(A, B));
            int[] A_power2_plus_fourteen_mul_A_mul_B_B_power2 = my_sum(A_power2, my_sum(fourteen_mul_A_mul_B, B_power2));
            int[] int_p = new int[A_power2_plus_fourteen_mul_A_mul_B_B_power2.Length];
            int[] discr_modulo = my_division(A_power2_plus_fourteen_mul_A_mul_B_B_power2, P, int_p);
            int[] zero = new int[discr_modulo.Length];
            int flag = cmp_my_equal(discr_modulo, zero);
            if (flag == 2)
                return 1;
            return 0;
        }

        public int point_belongs_Edwards (int[] x, int[] y, int[] P, int[] a, int[] b)
        {
            int[] x_power2 = my_mul(x, x);
            int[] a_mul_x_power2 = my_mul(a, x_power2);
            int[] y_power2 = my_mul(y, y);
            int[] a_mul_x_power2_plus_y_power2 = my_sum(a_mul_x_power2,y_power2);
            int[] int_part_of_left_part = new int[a_mul_x_power2_plus_y_power2.Length];
            int[] left_part = my_division(a_mul_x_power2_plus_y_power2, P, int_part_of_left_part);
            int[] one = new int[1];
            one[0] = 1;
            int[] b_mul_x_power2_mul_y_power2 = my_mul(b, my_mul(x_power2, y_power2));
            int[] one_sum_b_mul_x_power2_mul_y_power2 = my_sum(one, b_mul_x_power2_mul_y_power2);
            int[] int_part_of_right_part = new int[one_sum_b_mul_x_power2_mul_y_power2.Length];
            int[] right_part = my_division(one_sum_b_mul_x_power2_mul_y_power2, P, int_part_of_right_part);
            int flag = cmp_my_equal(left_part, right_part);
            if (flag == 2)
                return 0;
            return 1;
        }

        public void mul_point_on_curve (int[] x, int[] y, int[] a, int[] b, int[] P, int[] x_3, int[] y_3)
        {
            int k = (int)numericUpDown1.Value;
            int timeint = k/2;
            int plusint = k%2;
            int i;
            int[] xTemp=new int[617];
            int[] yTemp = new int[617];
            int[] xxtemp = x;
            int[] yytemp = y;
            if (radioButton1.Checked == true)
            {
                for (i=0;i<timeint;i++)
                {
                    Weierstrass(x, y, x, y, xTemp, yTemp, a, b, P);
                    x_3 = my_sum(x_3, xTemp);
                    y_3 = my_sum(y_3, yTemp);
                    x = x_3;
                    y = y_3;
                }
                if(plusint==1)
                {
                    Weierstrass(xxtemp, yytemp, x, y, x_3, y_3, a, b, P);
                }
            }
            if (radioButton2.Checked == true)
            {
                for (i = 0; i < timeint; i++)
                {
                    Montgomery(x, y, x, y, xTemp, yTemp, a, b, P);
                    x_3 = my_sum(x_3, xTemp);
                    y_3 = my_sum(y_3, yTemp);
                    x = x_3;
                    y = y_3;
                }
                if (plusint == 1)
                {
                    Montgomery(xxtemp, yytemp, x, y, x_3, y_3, a, b, P);
                }
            }
            if (radioButton3.Checked == true)
            {
                for (i = 0; i < timeint; i++)
                {
                    Edwards(x, y, x, y, xTemp, yTemp, a, b, P);
                    x_3 = my_sum(x_3, xTemp);
                    y_3 = my_sum(y_3, yTemp);
                    x = x_3;
                    y = y_3;
                }
                if (plusint == 1)
                {
                    Edwards(xxtemp, yytemp, x, y, x_3, y_3, a, b, P);
                }
            }
            return;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "")
            {
                MessageBox.Show("Error input. You should input x1.");
                return;
            }
            if (textBox2.Text == "")
            {
                MessageBox.Show("Error input. You should input y1.");
                return;
            }
            if (textBox3.Text == "")
            {
                MessageBox.Show("Error input. You should input x2.");
                return;
            }
            if (textBox4.Text == "")
            {
                MessageBox.Show("Error input. You should input y2.");
                return;
            }
            if (textBox7.Text == "")
            {
                MessageBox.Show("Error input. You should input a.");
                return;
            }
            if (textBox8.Text == "")
            {
                MessageBox.Show("Error input. You should input b.");
                return;
            }
            if (textBox9.Text == "")
            {
                MessageBox.Show("Error input. You should input P.");
                return;
            }
            if (notation == "Hex") Convert_All_to_Dec();
            int sign_x_1 = 0;
            int[] x_1 = input_only_number(textBox1.Text, sign_x_1);
            int sign_y_1 = 0;
            int[] y_1 = input_only_number(textBox2.Text, sign_y_1);
            int sign_x_2 = 0;
            int[] x_2 = input_only_number(textBox3.Text, sign_x_2);
            int sign_y_2 = 0;
            int[] y_2 = input_only_number(textBox4.Text, sign_y_2);
            int sign_P = 0;
            int[] P = input_only_number(textBox9.Text, sign_P);
            int sign_a = 0;
            int[] a = input_only_number(textBox7.Text, sign_a);
            int sign_b = 0;
            int[] b = input_only_number(textBox8.Text, sign_b);
            int[] temp_for_integer_part;
            int[] temp_for_modulo;
            int[] temp;
            int[] one = new int[1];
            one[0] = 1;
          
            
            if (sign_x_1==1)
            {
                temp_for_integer_part = new int[x_1.Length];
                temp_for_modulo = new int[P.Length + 1];
                temp_for_modulo = my_division(x_1, P, temp_for_integer_part);
                temp = new int[P.Length + 1];
                temp = my_deduct(my_mul(my_sum(temp_for_integer_part, one), P), x_1, cmp_my(my_mul(my_sum(temp_for_integer_part, one), P), x_1));
                x_1 = new int[temp.Length];
                x_1 = temp;
            }
            if (sign_y_1 == 1)
            {
                temp_for_integer_part = new int[y_1.Length];
                temp_for_modulo = new int[P.Length + 1];
                temp_for_modulo = my_division(y_1, P, temp_for_integer_part);
                temp = new int[P.Length + 1];
                temp = my_deduct(my_mul(my_sum(temp_for_integer_part, one), P), y_1, cmp_my(my_mul(my_sum(temp_for_integer_part, one), P), y_1));
                y_1 = new int[temp.Length];
                y_1 = temp;
            }
            if (sign_x_2 == 1)
            {
                temp_for_integer_part = new int[x_2.Length];
                temp_for_modulo = new int[P.Length + 1];
                temp_for_modulo = my_division(x_2, P, temp_for_integer_part);
                temp = new int[P.Length + 1];
                temp = my_deduct(my_mul(my_sum(temp_for_integer_part, one), P), x_2, cmp_my(my_mul(my_sum(temp_for_integer_part, one), P), x_2));
                x_2 = new int[temp.Length];
                x_2 = temp;
            }
            if (sign_y_2 == 1)
            {
                temp_for_integer_part = new int[y_2.Length];
                temp_for_modulo = new int[P.Length + 1];
                temp_for_modulo = my_division(y_2, P, temp_for_integer_part);
                temp = new int[P.Length + 1];
                temp = my_deduct(my_mul(my_sum(temp_for_integer_part, one), P), y_2, cmp_my(my_mul(my_sum(temp_for_integer_part, one), P), y_2));
                y_2 = new int[temp.Length];
                y_2 = temp;
            }
            if (sign_a == 1)
            { 
                temp_for_integer_part = new int[a.Length];
                temp_for_modulo = new int[P.Length + 1];
                temp_for_modulo = my_division(a, P, temp_for_integer_part);
                temp = new int[P.Length + 1];
                temp = my_deduct(my_mul(my_sum(temp_for_integer_part, one), P), a, cmp_my(my_mul(my_sum(temp_for_integer_part, one), P), a));
                a = new int[temp.Length];
                a = temp;
            }
            if (sign_b == 1)
            {
                temp_for_integer_part = new int[b.Length];
                temp_for_modulo = new int[P.Length + 1];
                temp_for_modulo = my_division(b, P, temp_for_integer_part);
                temp = new int[P.Length + 1];
                temp = my_deduct(my_mul(my_sum(temp_for_integer_part, one), P), b, cmp_my(my_mul(my_sum(temp_for_integer_part, one), P), b));
                b = new int[temp.Length];
                b = temp;
            }
            int curve_does_not_exist = 0;
            int point_does_not_belong = 0;
            if (r_sum.Checked == true)
            {
                if (radioButton1.Checked == true)
                {
                    curve_does_not_exist = Discriminant_Weierstrass(a, b, P);
                    if (curve_does_not_exist == 1)
                    {
                        MessageBox.Show("Error input. Curve doesn't exist.");
                        return;
                    }
                    point_does_not_belong = point_belongs_Weierstrass(x_1, y_1, P, a, b);
                    if (point_does_not_belong == 1)
                    {
                        MessageBox.Show("Error input. Point (x1,y1) doesn't belong to the curve.");
                        return;
                    }
                    point_does_not_belong = point_belongs_Weierstrass(x_2, y_2, P, a, b);
                    if (point_does_not_belong == 1)
                    {
                        MessageBox.Show("Error input. Point (x2,y2) doesn't belong to the curve.");
                        return;
                    }
                    Weierstrass(x_1, y_1, x_2, y_2, x_3, y_3, a, b, P);
                }
                if (radioButton2.Checked == true)
                {
                    curve_does_not_exist = Discriminant_Montgomery(a, b, P);
                    if (curve_does_not_exist == 1)
                    {
                        MessageBox.Show("Error input. Curve doesn't exist.");
                        return;
                    }
                    point_does_not_belong = point_belongs_Montgomery(x_1, y_1, P, a, b);
                    if (point_does_not_belong == 1)
                    {
                        MessageBox.Show("Error input. Point (x1,y1) doesn't belong to the curve.");
                        return;
                    }
                    point_does_not_belong = point_belongs_Montgomery(x_2, y_2, P, a, b);
                    if (point_does_not_belong == 1)
                    {
                        MessageBox.Show("Error input. Point (x2,y2) doesn't belong to the curve.");
                        return;
                    }
                    Montgomery(x_1, y_1, x_2, y_2, x_3, y_3, a, b, P);
                }
                if (radioButton3.Checked == true)
                {
                    curve_does_not_exist = Discriminant_Edwards(a, b, P);
                    if (curve_does_not_exist == 1)
                    {
                        MessageBox.Show("Error input. Curve doesn't exist.");
                        return;
                    }
                    point_does_not_belong = point_belongs_Edwards(x_1, y_1, P, a, b);
                    if (point_does_not_belong == 1)
                    {
                        MessageBox.Show("Error input. Point (x1,y1) doesn't belong to the curve.");
                        return;
                    }
                    point_does_not_belong = point_belongs_Edwards(x_2, y_2, P, a, b);
                    if (point_does_not_belong == 1)
                    {
                        MessageBox.Show("Error input. Point (x2,y2) doesn't belong to the curve.");
                        return;
                    }
                    Edwards(x_1, y_1, x_2, y_2, x_3, y_3, a, b, P);
                }
            }
            if (r_mult.Checked==true)
            {
                mul_point_on_curve(x_1, y_1, a, b, P, x_3, y_3);
            }
            textBox5.Text = output_my(x_3, x_3.Length);
            textBox6.Text = output_my(y_3, y_3.Length);
        }

        public string Convert_to_Dec (string our_str)
        {
            string res="";
            int[] power = new int[1];
            power[0] = 1;
            int[] sixteen = new int[2];
            sixteen[0] = 6;
            sixteen[1] = 1;
            int[] our_num = new int[our_str.Length];
            int i = 0;
            int j = 0;
            int[] tmp_c = new int[617];
            int[] tmp = new int[2];
            int[] res_num = new int[617];
            for (i = our_str.Length - 1; i >= 0;i-- )
            {
                if (((our_str[i] >= '0') && (our_str[i] <= '9')) || ((our_str[i] >= 'A') && (our_str[i] <= 'F')))
                {
                    if ((our_str[i] >= '0') && (our_str[i] <= '9'))
                    {
                        tmp[1]=0;
                        tmp[0] = our_str[i] - '0';
                    }
                    if ((our_str[i] >= 'A') && (our_str[i] <= 'F'))
                    {
                        tmp[1] = 1;
                        tmp[0] = our_str[i] - 'A';
                    }
                    tmp_c = my_mul(tmp,power);
                    power = my_mul(power, sixteen);
                    res_num = my_sum(res_num, tmp_c);
                }
            }
            res = output_my(res_num, res_num.Length);
            return res;
        }
        public string Convert_to_Hex (string our_str)
        {
            string Dec2Hex = "0123456789ABCDEF";
            int tt = our_str[0] - '0';
            int t;
            int i = 0;
            int f;
            string ans="";
            string res = "";
            string str="";
            for (i = 0; i < our_str.Length; i++)
                if ((our_str[i] >= '0') && (our_str[i] <= '9'))
                    str = str + our_str[i];
            int flag = 0;
            for (int h = 0; h < str.Length; h++)
            {
                if (str[h] != '0')
                    flag = 1;
            }
            while (flag == 1)
            {
                tt = str[0] - '0';
                ans = "";
                for (i = 1; i < str.Length; i++)
                {

                    t = str[i] + (tt * 10) - '0';
                    tt = t % 16;
                    f = t / 16;
                    ans = ans + Dec2Hex[f];

                }
                str = ans;
                res = Dec2Hex[tt] + res;
                flag = 0;
                for (int h = 0; h < str.Length; h++)
                {
                    if (str[h] != '0')
                        flag = 1;
                }
            }
            return res;
        }

        public void Convert_All_to_Hex ()
        {
            notation = "Hex";
            textBox1.Text = Convert_to_Hex(textBox1.Text);
            textBox2.Text = Convert_to_Hex(textBox2.Text);
            textBox3.Text = Convert_to_Hex(textBox3.Text);
            textBox4.Text = Convert_to_Hex(textBox4.Text);
            textBox7.Text = Convert_to_Hex(textBox7.Text);
            textBox8.Text = Convert_to_Hex(textBox8.Text);
            textBox9.Text = Convert_to_Hex(textBox9.Text);
            if (textBox5.TextLength>0) textBox5.Text = Convert_to_Hex(textBox5.Text);
            if (textBox6.TextLength > 0) textBox6.Text = Convert_to_Hex(textBox6.Text);
            label5.ForeColor = System.Drawing.Color.Red;
            label5.Text = "Шестнадцатеричная система счисления";
            return;
        }
        public void Convert_All_to_Dec()
        {
            notation = "Dec";
            textBox1.Text = Convert_to_Dec(textBox1.Text);
            textBox2.Text = Convert_to_Dec(textBox2.Text);
            textBox3.Text = Convert_to_Dec(textBox3.Text);
            textBox4.Text = Convert_to_Dec(textBox4.Text);
            textBox7.Text = Convert_to_Dec(textBox7.Text);
            textBox8.Text = Convert_to_Dec(textBox8.Text);
            textBox9.Text = Convert_to_Dec(textBox9.Text);
            if (textBox5.TextLength > 0) textBox5.Text = Convert_to_Dec(textBox5.Text);
            if (textBox6.TextLength > 0) textBox6.Text = Convert_to_Dec(textBox6.Text);
            label5.ForeColor = System.Drawing.Color.Green;
            label5.Text = "Десятичная система счисления";
            return;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (notation == "Dec")
            {
                Convert_All_to_Hex();
                numericUpDown1.Hexadecimal = (0 < 1);
            }

            else
            {
                Convert_All_to_Dec();
                numericUpDown1.Hexadecimal = (0 > 1);
            }
        }

      


        
        

      

       
     

      
     

       

    

      

        
    

        
    }
}
