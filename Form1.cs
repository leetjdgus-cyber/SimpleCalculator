using System.Data;

namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                var text = btn.Text;

                // = 버튼 클릭 시 계산 실행
                if (text == "=")
                {
                    try
                    {
                        string exp = tbcal.Text;
                        if (string.IsNullOrWhiteSpace(exp))
                            return;

                        // X를 *로 변환 (곱하기), %를 /로 변환 (나누기)
                        exp = exp.Replace("X", "*");
                        exp = exp.Replace("÷", "/");

                        DataTable dt = new DataTable();
                        var result = dt.Compute(exp, "");

                        tbresult.Text = result.ToString();
                        tbcal.Text = exp.Replace("*", "X").Replace("/", "÷") + "=" + result.ToString();
                    }
                    catch
                    {
                        tbresult.Text = "Error";
                    }
                    return;
                }

                // 숫자 버튼을 클릭 시, 텍스트 박스에 숫자 추가
                if (!string.IsNullOrEmpty(text) && (char.IsDigit(text[0]) || text == "."))
                {

                    if (text == "." && tbcal.Text.Contains('.'))
                        return;

                    if (string.IsNullOrEmpty(tbcal.Text) || tbcal.Text == "0")
                        tbcal.Text = text;
                    else
                        tbcal.Text += text;

                    // 결과창에 현재 입력 중인 숫자 표시
                    var current = tbcal.Text;
                    int lastOp = -1;
                    for (int i = current.Length - 1; i >= 1; i--)
                    {
                        char c = current[i];
                        if (c == '+' || c == '-' || c == 'X' || c == '÷')
                        {
                            lastOp = i;
                            break;
                        }
                    }
                    tbresult.Text = lastOp >= 0 ? current.Substring(lastOp + 1) : current;

                    return;
                }

                // 초기화, 양수 음수 버튼 클릭 시 텍스트 박스에 추가
                if (text == "+/-")
                {
                    if (double.TryParse(tbcal.Text, out var v))
                        tbcal.Text = (-v).ToString();
                    return;
                }

                // 연산처리를 텍스트 박스에 추가
                var ops = new[] { "+", "-", "X", "÷" };
                if (Array.IndexOf(ops, text) >= 0)
                {

                    if (string.IsNullOrEmpty(tbcal.Text))
                    {
                        if (text == "-")
                            tbcal.Text = "-";
                        return;
                    }


                    if (tbcal.Text.Length == 1 && tbcal.Text[0] == '-')
                    {
                        tbcal.Text += text;
                        return;
                    }

                    var last = tbcal.Text[tbcal.Text.Length - 1];
                    if (char.IsDigit(last) || last == '.')
                    {
                        tbcal.Text += text;
                    }
                    else
                    {

                        tbcal.Text = tbcal.Text.Substring(0, tbcal.Text.Length - 1) + text;
                    }
                    tbresult.Text = "0";
                    return;
                }
                //CE버튼 구현 완성, 연산자와 숫자 사이의 마지막 연산자까지만 남기고 나머지는 삭제
                if (text == "CE")
                {
                    var cal = tbcal.Text;
                    if (string.IsNullOrEmpty(cal))
                        return;

                    int lastOpIndex = -1;
                    for (int i = cal.Length - 1; i >= 1; i--)
                    {
                        char c = cal[i];
                        if (c == '+' || c == '-' || c == 'X' || c == '÷')
                        {
                            lastOpIndex = i;
                            break;
                        }
                    }

                    if (lastOpIndex >= 0)
                        tbcal.Text = cal.Substring(0, lastOpIndex + 1);
                    else
                        tbcal.Clear();

                    return;
                }

                if (text == "C")
                {
                    tbcal.Clear();
                    tbresult.Clear();
                    return;
                }

                if (text == "del")
                {
                    if (!string.IsNullOrEmpty(tbcal.Text))
                        tbcal.Text = tbcal.Text.Substring(0, tbcal.Text.Length - 1);
                    return;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
