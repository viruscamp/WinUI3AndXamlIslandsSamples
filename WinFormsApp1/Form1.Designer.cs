
using System.Drawing;

namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Text = "Form1";

            textBox1 = new System.Windows.Forms.TextBox();
            textBox1.Dock = System.Windows.Forms.DockStyle.Top;
            textBox1.Text = "TextBox";
            this.Controls.Add(textBox1);

            panel1 = new System.Windows.Forms.UserControl();
            panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Controls.Add(panel1);

            button1 = new System.Windows.Forms.Button();
            button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            button1.Text = "Click";
            this.Controls.Add(button1);
        }

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.UserControl panel1;
        private System.Windows.Forms.Button button1;

        #endregion
    }
}
