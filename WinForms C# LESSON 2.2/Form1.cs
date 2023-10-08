using System.Diagnostics.Eventing.Reader;
using System.Runtime.CompilerServices;

namespace WinForms_C__LESSON_2._2
{
    public partial class Form1 : Form
    {
        Icon _icon = Icon.FromHandle(((Bitmap)Properties.Resources.icons8_calculator_48).GetHicon());

        public double eded1 = 0;
        public double eded2 = 0;
        public bool eded1Yoxla = false;
        public bool devamBol = false;
        public bool devamVur = false;
        public bool devamTopla = false;
        public bool devamCix = false;
        public bool ilk = false;

        // Cannot divide by zero

        public Form1()
        {
            InitializeComponent();
            Icon = _icon;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            EsasLebleLabel2.Text = "0";
            label11.Text = "";
            eded1Yoxla = false; eded1 = 0;

            devamBol = false;
            devamCix = false;
            devamVur = false;
            devamTopla = false;
            ilk = false;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {

            ilk = false;
            if (EsasLebleLabel2.Text == "0") { }
            else
            {

                if (EsasLebleLabel2.Text.Length == 1) { EsasLebleLabel2.Text = "0"; }
                else
                {

                    List<char> newText = new List<char>();
                    for (int i = 0; i < EsasLebleLabel2.Text.Length - 1; i++)
                    {
                        newText.Add(EsasLebleLabel2.Text[i]);
                    }
                    EsasLebleLabel2.Text = "";

                    for (int i = 0; i < newText.Count; i++)
                    {
                        EsasLebleLabel2.Text += newText[i];
                    }

                }

            }


        }

        private void _1_Click(object sender, EventArgs e)
        {
            if ((EsasLebleLabel2.Text == "0" && EsasLebleLabel2.Text != "Cannot divide by zero" || (eded1Yoxla && (!devamBol || !devamVur || !devamCix || !devamTopla))) || ilk) { EsasLebleLabel2.Text = "1"; eded1Yoxla = false; }
            else { EsasLebleLabel2.Text += "1"; }
            ilk = false;
        }

        private void _2_Click(object sender, EventArgs e)
        {
            if ((EsasLebleLabel2.Text == "0" && EsasLebleLabel2.Text != "Cannot divide by zero" || (eded1Yoxla && (!devamBol || !devamVur || !devamCix || !devamTopla))) || ilk) { EsasLebleLabel2.Text = "2"; eded1Yoxla = false; }
            else { EsasLebleLabel2.Text += "2"; }
            ilk = false;
        }


        private void _3_Click(object sender, EventArgs e)
        {
            if ((EsasLebleLabel2.Text == "0" && EsasLebleLabel2.Text != "Cannot divide by zero" || (eded1Yoxla && (!devamBol || !devamVur || !devamCix || !devamTopla))) || ilk) { EsasLebleLabel2.Text = "3"; eded1Yoxla = false; }
            else { EsasLebleLabel2.Text += "3"; }
            ilk = false;
        }

        private void _4_Click(object sender, EventArgs e)
        {
            if ((EsasLebleLabel2.Text == "0" && EsasLebleLabel2.Text != "Cannot divide by zero" || (eded1Yoxla && (!devamBol || !devamVur || !devamCix || !devamTopla))) || ilk) { EsasLebleLabel2.Text = "4"; eded1Yoxla = false; }
            else { EsasLebleLabel2.Text += "4"; }
            ilk = false;
        }

        private void _5_Click(object sender, EventArgs e)
        {
            if ((EsasLebleLabel2.Text == "0" && EsasLebleLabel2.Text != "Cannot divide by zero" || (eded1Yoxla && (!devamBol || !devamVur || !devamCix || !devamTopla))) || ilk) { EsasLebleLabel2.Text = "5"; eded1Yoxla = false; }
            else { EsasLebleLabel2.Text += "5"; }
            ilk = false;
        }

        private void _6_Click(object sender, EventArgs e)
        {
            if ((EsasLebleLabel2.Text == "0" && EsasLebleLabel2.Text != "Cannot divide by zero" || (eded1Yoxla && (!devamBol || !devamVur || !devamCix || !devamTopla))) || ilk) { EsasLebleLabel2.Text = "6"; eded1Yoxla = false; }
            else { EsasLebleLabel2.Text += "6"; }
            ilk = false;
        }

        private void _7_Click(object sender, EventArgs e)
        {
            if ((EsasLebleLabel2.Text == "0" && EsasLebleLabel2.Text != "Cannot divide by zero" || (eded1Yoxla && (!devamBol || !devamVur || !devamCix || !devamTopla))) || ilk) { EsasLebleLabel2.Text = "7"; eded1Yoxla = false; }
            else { EsasLebleLabel2.Text += "7"; }
            ilk = false;
        }

        private void _8_Click(object sender, EventArgs e)
        {
            if ((EsasLebleLabel2.Text == "0" && EsasLebleLabel2.Text != "Cannot divide by zero" || (eded1Yoxla && (!devamBol || !devamVur || !devamCix || !devamTopla))) || ilk) { EsasLebleLabel2.Text = "8"; eded1Yoxla = false; }
            else { EsasLebleLabel2.Text += "8"; }
            ilk = false;
        }

        private void _9_Click(object sender, EventArgs e)
        {
            if ((EsasLebleLabel2.Text == "0" && EsasLebleLabel2.Text != "Cannot divide by zero" || (eded1Yoxla && (!devamBol || !devamVur || !devamCix || !devamTopla))) || ilk) { EsasLebleLabel2.Text = "9"; eded1Yoxla = false; }
            else { EsasLebleLabel2.Text += "9"; }
            ilk = false;
        }

        private void _0_Click(object sender, EventArgs e)
        {
            if ((EsasLebleLabel2.Text == "0" && EsasLebleLabel2.Text != "Cannot divide by zero" || (eded1Yoxla && (!devamBol || !devamVur || !devamCix || !devamTopla)) || ilk)) { EsasLebleLabel2.Text = "0"; }
            else { EsasLebleLabel2.Text += "0"; }
            ilk = false;
        }

        private void bol_Click(object sender, EventArgs e)
        {
            ilk = true;
            if (devamBol)
            {

                eded2 = double.Parse(EsasLebleLabel2.Text);

                if (eded2 != 0)
                {
                    

                    label11.Text = $"{eded1} {bol.Text} ";
                    eded1 /= eded2;
                    EsasLebleLabel2.Text = $"{eded1}";
                }
                else { label11.Text = $" = {eded1} {bol.Text} {eded2} "; EsasLebleLabel2.Text = "Cannot divide by zero"; }
            }
            else
            {

                eded1Yoxla = true;

                devamBol = true;
                devamVur = false;
                devamTopla = false;
                devamCix = false;

                eded1 = double.Parse(EsasLebleLabel2.Text);
                label11.Text = $"{eded1} {bol.Text} ";

            }
        }

        private void vur_Click(object sender, EventArgs e)
        {
            ilk = true;
            if (devamVur)
            {

                eded2 = double.Parse(EsasLebleLabel2.Text);

                

                label11.Text = $"{eded1} {vur.Text} ";
                eded1 *= eded2;
                EsasLebleLabel2.Text = $"{eded1}";


            }
            else
            {

                eded1Yoxla = true;

                devamBol = false;
                devamVur = true;
                devamTopla = false;
                devamCix = false;

                eded1 = double.Parse(EsasLebleLabel2.Text);
                label11.Text = $"{eded1} {vur.Text} ";


            }
        }

        private void cix_Click(object sender, EventArgs e)
        {
            ilk = true;
            if (devamCix)
            {

                eded2 = double.Parse(EsasLebleLabel2.Text);
                

                label11.Text = $"{eded1} {cix.Text} ";
                eded1 -= eded2;
                EsasLebleLabel2.Text = $"{eded1}";


            }
            else
            {

                eded1Yoxla = true;

                devamBol = false;
                devamVur = false;
                devamTopla = false;
                devamCix = true;

                eded1 = double.Parse(EsasLebleLabel2.Text);
                label11.Text = $"{eded1} {cix.Text} ";


            }
        }

        private void topla_Click(object sender, EventArgs e)
        {
            ilk = true;
            if (devamTopla)
            {

                eded2 = double.Parse(EsasLebleLabel2.Text);

               

                label11.Text = $"{eded1} {topla.Text} ";
                eded1 += eded2;
                EsasLebleLabel2.Text = $"{eded1}";


            }
            else
            {

                eded1Yoxla = true;

                devamBol = false;
                devamVur = false;
                devamTopla = true;
                devamCix = false;

                eded1 = double.Parse(EsasLebleLabel2.Text);
                label11.Text = $"{eded1} {topla.Text} ";


            }
        }

        private void beraberdi_Click(object sender, EventArgs e)
        {


            ilk = false;
            if (devamBol)
            {
                eded2 = double.Parse(EsasLebleLabel2.Text);

                if (eded2 != 0)
                {
                    

                    label11.Text = $"{eded1} {bol.Text} {eded2} = ";
                    eded1 /= eded2;
                    EsasLebleLabel2.Text = $"{eded1}";
                }
                else { label11.Text = $" = {eded1} {bol.Text} {eded1} "; EsasLebleLabel2.Text = "Cannot divide by zero"; }

                devamBol = false;

            }
            else if (devamVur)
            {

                eded2 = double.Parse(EsasLebleLabel2.Text);

                label11.Text = $"{eded1} {vur.Text} {eded2} = ";
                eded1 *= eded2;
                EsasLebleLabel2.Text = $"{eded1}";

                devamVur = false;
            }
            else if (devamTopla)
            {

                eded2 = double.Parse(EsasLebleLabel2.Text);

                label11.Text = $"{eded1} {topla.Text} {eded2} = ";
                eded1 += eded2;

                EsasLebleLabel2.Text = $"{eded1}";

                devamTopla = false;

            }
            else if (devamCix)
            {
                eded2 = double.Parse(EsasLebleLabel2.Text);


                label11.Text = $"{eded1} {cix.Text} {eded2} = ";
                eded1 -= eded2;

                EsasLebleLabel2.Text = $"{eded1}";

                devamCix = false;
            }




        }

        private void button23_Click(object sender, EventArgs e)
        {
            ilk = false;

            bool verguleYoxla = true;

            for (int i = 0; i < EsasLebleLabel2.Text.Length; i++)
            {
                if (EsasLebleLabel2.Text[i] == ',') { verguleYoxla = false; }
            }

            if (verguleYoxla) { EsasLebleLabel2.Text += ','; }

        }
    }
}
