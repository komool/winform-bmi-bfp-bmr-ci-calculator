using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            toolTip1.SetToolTip(BMICalcBtn, "BMI(체질량지수) : 자신의 몸무게를 키의 제곱으로 나눈 값");
            toolTip1.SetToolTip(BFPCalcBtn, "BFP(체지방비율)");
            toolTip1.SetToolTip(BMRCalcBtn, "BMR(기초대사량) : 생명을 유지하는데 필요한 최소한의 에너지량");
            toolTip1.SetToolTip(CICalcBtn, "매일 소비해야 하는 칼로리");
        }

        private void BMICalcBtn_Click(object sender, EventArgs e)
        {
            try
            {
                double weight = Convert.ToDouble(textBoxBMIWeight.Text);
                double height = Convert.ToDouble(textBoxBMIHeight.Text);
                double bmi = Math.Round(weight / (height * 0.01) / (height * 0.01), 1);
                string result;

                if (bmi < 18.5)
                    result = "Underweight";
                else if (bmi >= 18.5 && bmi < 25.0)
                    result = "Normal";
                else if (bmi >= 25.0 && bmi < 30.0)
                    result = "Overweight";
                else
                    result = "Obese";

                textBoxBMIResult.Text = bmi.ToString() + "\r\n" + result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void radioBFPGenderMale_CheckedChanged(object sender, EventArgs e)
        {
            groupBFPMale.Visible = true;
            groupBFPFemale.Visible = false;
        }

        private void radioBFPFemale_CheckedChanged(object sender, EventArgs e)
        {
            groupBFPMale.Visible = false;
            groupBFPFemale.Visible = true;
        }

        private void BFPCalcBtn_Click(object sender, EventArgs e)
        {
            if (radioBFPGenderMale.Checked)
            {
                try
                {
                    double height = Convert.ToDouble(BFPMaleHeight.Text);
                    double neck = Convert.ToDouble(BFPMaleNeck.Text);
                    double waist = Convert.ToDouble(BFPMaleWaist.Text);
                    double bfp = Math.Round(495 / (1.0324 - 0.19077 * Math.Log10(waist - neck) + 0.15456 * Math.Log10(height)) - 450, 1);

                    BFPResult.Text = bfp.ToString();
                } 
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }

            if (radioBFPFemale.Checked)
            {
                try
                {
                    double height = Convert.ToDouble(BFPFemaleHeight.Text);
                    double neck = Convert.ToDouble(BFPFemaleNeck.Text);
                    double waist = Convert.ToDouble(BFPFemaleWaist.Text);
                    double hip = Convert.ToDouble(BFPFemaleHip.Text);
                    double bfp = Math.Round(495 / (1.29579 - 0.35004 * Math.Log10(waist + hip - neck) + 0.22100 * Math.Log10(height)) - 450, 1);

                    BFPResult.Text = bfp.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void BMRCalcBtn_Click(object sender, EventArgs e)
        {
            if (BMRMale.Checked)
            {
                try
                {
                    double height = Convert.ToDouble(BMRHeight.Text);
                    double weight = Convert.ToDouble(BMRWeight.Text);
                    double age = Convert.ToDouble(BMRAge.Text);
                    double bmr = Math.Round(66.4730 + (13.7516 * weight) + (5.0033 * height) - (6.7550 * age), 1);

                    BMRResult.Text = bmr.ToString();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if (BMRFemale.Checked)
            {
                try
                {
                    double height = Convert.ToDouble(BMRHeight.Text);
                    double weight = Convert.ToDouble(BMRWeight.Text);
                    double age = Convert.ToDouble(BMRAge.Text);
                    double bmr = Math.Round(655.0955 + (9.5634 * weight) + (1.8496 * height) - (4.6756 * age), 1);

                    BMRResult.Text = bmr.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void CICalcBtn_Click(object sender, EventArgs e)
        {
            try
            {
                double bmr = Convert.ToDouble(CIBMR.Text);
                string active = CIActive.Text;

                if (active == "Sedentary")
                    CIResult.Text = Convert.ToString(bmr * 1.2);
                if (active == "Lightly_Active")
                    CIResult.Text = Convert.ToString(bmr * 1.375);
                if (active == "Moderately_Active")
                    CIResult.Text = Convert.ToString(bmr * 1.375);
                if (active == "Very_Active")
                    CIResult.Text = Convert.ToString(bmr * 1.375);
                if (active == "Extra_Active")
                    CIResult.Text = Convert.ToString(bmr * 1.375);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void linkBMI_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("https://www.calculator.net/bmi-calculator.html");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void linkBFP_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("https://www.calculator.net/body-fat-calculator.html");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void linkBMR_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("https://www.calculator.net/bmr-calculator.html");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void linkCI_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("https://www.calculator.net/calorie-calculator.html");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
