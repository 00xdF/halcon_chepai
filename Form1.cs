using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace halcon_chepai
{
    public partial class Form1 : Form
    {
        private HalconDev halconDev;
        private int threhold_up_value = 100;
        private int threhold_down_value = 0;
        private int area_down_value = 4014;
        private int area_up_value = 19840;
        public Form1()
        {
            halconDev = new HalconDev();
            InitializeComponent();
            threshold_down.Value = threhold_down_value;
            threshold_up.Value = threhold_up_value;
            area_up.Value = area_up_value;
            area_down.Value = area_down_value;
            threhold_up_label.Text = threhold_up_label.Text + " : " + threhold_up_value;
            threhold_down_label.Text = threhold_down_label.Text + " : " +threhold_down_value;
            area_down_label.Text = area_down_label.Text + " : " + area_down_value;
            area_up_label.Text = area_up_label.Text + " : " + area_up_value;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var dic = halconDev.action(threhold_down_value, threhold_up_value, area_down_value, area_up_value, pictureBox1, textBox1.Text);
                listView1.Items.Clear();
                foreach(var i in dic)
                {
                    ListViewItem item = new ListViewItem();
                    item.SubItems.Add(i[1]);
                    item.Text = i[0];
                    listView1.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                label1.Text = ex.Message;
            }
        }

  

        private void threshold_down_Scroll(object sender, EventArgs e)
        {
            try
            {
                threhold_down_value = threshold_down.Value;
                threhold_down_label.Text = threhold_down_label.Text.Split(':')[0].Replace(" ", "") + " : " + threhold_down_value;
                var dic = halconDev.action(threhold_down_value, threhold_up_value, area_down_value, area_up_value, pictureBox1, textBox1.Text);
                listView1.Items.Clear();
                foreach (var i in dic)
                {
                    ListViewItem item = new ListViewItem();
                    item.SubItems.Add(i[1]);
                    item.Text = i[0];
                    listView1.Items.Add(item);
                }
            }
            catch(Exception ex)
            {
                label1.Text = ex.Message;
            }
           
        }

        private void threshold_up_Scroll(object sender, EventArgs e)
        {
            try
            {
                threhold_up_value = threshold_up.Value;
                threhold_up_label.Text = threhold_up_label.Text.Split(':')[0].Replace(" ", "") + " : " + threhold_up_value;
                var dic = halconDev.action(threhold_down_value, threhold_up_value, area_down_value, area_up_value, pictureBox1, textBox1.Text);
                listView1.Items.Clear();
                foreach (var i in dic)
                {
                    ListViewItem item = new ListViewItem();
                    item.SubItems.Add(i[1]);
                    item.Text = i[0];
                    listView1.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                label1.Text = ex.Message;
            }
        }

        private void area_down_Scroll(object sender, EventArgs e)
        {
            try
            {
                area_down_value = area_down.Value;
                area_down_label.Text = area_down_label.Text.Split(':')[0].Replace(" ", "") + " : " + area_down_value;
                var dic = halconDev.action(threhold_down_value, threhold_up_value, area_down_value, area_up_value, pictureBox1, textBox1.Text);
                listView1.Items.Clear();
                foreach (var i in dic)
                {
                    ListViewItem item = new ListViewItem();
                    item.SubItems.Add(i[1]);
                    item.Text = i[0];
                    listView1.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                label1.Text = ex.Message;
            }
        }

        private void area_up_Scroll(object sender, EventArgs e)
        {
            try
            {
                area_up_value = area_up.Value;
                area_up_label.Text = area_up_label.Text.Split(':')[0].Replace(" ", "") + " : " + area_up_value;
                var dic = halconDev.action(threhold_down_value, threhold_up_value, area_down_value, area_up_value, pictureBox1, textBox1.Text);
                listView1.Items.Clear();
                foreach (var i in dic)
                {
                    ListViewItem item = new ListViewItem();
                    item.SubItems.Add(i[1]);
                    item.Text = i[0];
                    listView1.Items.Add(item);
                }
            } 
            catch(Exception ex)
            {
                label1.Text = ex.Message;
            }
}
    }
}
